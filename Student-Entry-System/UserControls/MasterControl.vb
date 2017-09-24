Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient

Public Class MasterControl
    Private isinitialized = False
    Private isEditing = False
    Private isRegistering = True
    Protected adminID As String
    Private saveFileDialog As New SaveFileDialog

    Private Sub MasterControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initializeList()
        btnAdd_Click(btnAddAcc, New EventArgs())
    End Sub

    Private Sub initializeList()
        Try
            Dim sql = "SELECT adminid As 'Administrator ID', log As 'Description', time As 'Timestamp' FROM logs"
            dgvEvents.DataSource = App.database.toDataset(sql).Tables(0)

            sql = "Select employeeid AS 'Employee ID', UPPER(CONCAT(COALESCE(`lastname`,''),',',COALESCE(`firstname`,''),' ',COALESCE(`middlename`,''))) As 'Name' FROM admins"
            adminList.DataSource = App.database.toDataset(sql).Tables(0)
            isinitialized = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub adminList_SelectionChanged(sender As Object, e As EventArgs) Handles adminList.SelectionChanged
        If isinitialized Then
            Try
                Dim employeeID = adminList.SelectedRows(0).Cells(0).Value
                Dim sql = "SELECT ID, employeeid, username, firstname, middlename, lastname, password, state FROM admins WHERE employeeid = ?"
                Dim params = New MySqlParameter() {
                        New MySqlParameter() With {.Value = employeeID}
                }
                setValues(App.database.retrieve(sql, params))
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub clearValues()
        tbEmployeeID.Clear()
        tbUsername.Clear()
        tbFirstname.Clear()
        tbMiddlename.Clear()
        tbLastname.Clear()
        tbPassword.Clear()

        rbAdmin.Checked = True
    End Sub

    Private Sub setValues(query As List(Of List(Of String)))
        Try
            adminID = query(0)(0)
            tbEmployeeID.Text = query(0)(1)
            tbUsername.Text = query(0)(2)
            tbFirstname.Text = query(0)(3)
            tbMiddlename.Text = query(0)(4)
            tbLastname.Text = query(0)(5)
            tbPassword.Text = query(0)(6)
            If query(0)(7).Equals("master") Then
                rbMaster.Checked = True
            Else
                rbAdmin.Checked = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub setState()
        Dim state = If(isEditing, True, False)
        tbEmployeeID.Enabled = state
        tbUsername.Enabled = state
        tbFirstname.Enabled = state
        tbMiddlename.Enabled = state
        tbLastname.Enabled = state
        tbPassword.Enabled = state

        rbMaster.Enabled = state
        rbAdmin.Enabled = state

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If tbMaster.Text = "M45t3R" Then
                If isRegistering Then
                    Dim sql = "INSERT INTO `admins` (`ID`, `state`, `username`, `password`, `firstname`, `lastname`, `middlename`, `employeeid`) " +
                              "VALUES (NULL, @state, @username, @password, @firstname, @lastname, @middlename, @id)"

                    Dim params = New MySqlParameter() {
                            New MySqlParameter("@id", tbEmployeeID.Text),
                            New MySqlParameter("@lastname", tbLastname.Text),
                            New MySqlParameter("@firstname", tbFirstname.Text),
                            New MySqlParameter("@middlename", tbMiddlename.Text),
                            New MySqlParameter("@password", tbPassword.Text),
                            New MySqlParameter("@state", If(rbMaster.Checked, "master", "admin"))
                        }

                    App.database.executeCommand(sql, params)
                    MessageBox.Show("Administrator account added")
                    MainForm.Logger("Administrator " + tbEmployeeID.Text + " account registered")

                Else
                    If isEditing Then
                        Dim sql = "UPDATE admins SET employeeid = @id, lastname = @lastname, firstname = @firstname, middlename = @middlename, password = @password, state = @state WHERE admins.employeeid = @id"

                        Dim params = New MySqlParameter() {
                            New MySqlParameter("@id", tbEmployeeID.Text),
                            New MySqlParameter("@lastname", tbLastname.Text),
                            New MySqlParameter("@firstname", tbFirstname.Text),
                            New MySqlParameter("@middlename", tbMiddlename.Text),
                            New MySqlParameter("@password", tbPassword.Text),
                            New MySqlParameter("@state", If(rbMaster.Checked, "master", "admin"))
                        }
                        App.database.executeCommand(sql, params)
                        MessageBox.Show("Administrator information updated")
                        MainForm.Logger("Administrator account of " + tbEmployeeID.Text + " was updated")
                        btnEdit.Text = "Edit"
                        isEditing = False
                        initializeList()
                    Else
                        btnEdit.Text = "Save"
                        isEditing = True
                    End If
                End If
                setState()
                initializeList()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        isEditing = False
        setState()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim sql = "DELETE FROM admins WHERE admins.ID = ?"
            Dim params = New MySqlParameter() {
               New MySqlParameter() With {.Value = adminID}
            }
            App.database.executeCommand(sql, params)
            MainForm.Logger("Deleted administrator " + tbEmployeeID.Text)
            initializeList()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddAcc.Click
        btnAddAcc.Enabled = False
        btnDelete.Enabled = False
        btnManage.Enabled = True

        btnAddAcc.BackColor = Color.White
        btnAddAcc.ForeColor = Color.Black
        btnManage.BackColor = Color.Green
        btnManage.ForeColor = Color.White

        btnEdit.Text = "Add"
    End Sub

    Private Sub btnManage_Click(sender As Object, e As EventArgs) Handles btnManage.Click
        btnAddAcc.Enabled = True
        btnDelete.Enabled = True
        btnManage.Enabled = False

        btnAddAcc.BackColor = Color.Green
        btnAddAcc.ForeColor = Color.White
        btnManage.BackColor = Color.White
        btnManage.ForeColor = Color.Black

        btnEdit.Text = "Edit"
    End Sub

    Private Sub tbLogPrint_Click(sender As Object, e As EventArgs) Handles tbLogPrint.Click
        saveFileDialog.Filter = "PDF File (*.pdf)|*.pdf"
        If saveFileDialog.ShowDialog = DialogResult.OK Then
            MessageBox.Show("Log printed successfully!")
        End If
    End Sub

    Private Sub tbLogExport_Click(sender As Object, e As EventArgs) Handles tbLogExport.Click
        Dim headers = (From header As DataGridViewColumn In dgvEvents.Columns.Cast(Of DataGridViewColumn)()
                       Select header.HeaderText).ToArray
        Dim rows = From row As DataGridViewRow In dgvEvents.Rows.Cast(Of DataGridViewRow)()
                   Where Not row.IsNewRow
                   Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
        Using sw As New StreamWriter("csv.txt")
            sw.WriteLine(String.Join(",", headers))
            For Each r In rows
                sw.WriteLine(String.Join(",", r))
            Next
        End Using
        Process.Start("csv.txt")
    End Sub

    Private Sub tbDBBackup_Click(sender As Object, e As EventArgs) Handles tbDBBackup.Click
        saveFileDialog.Filter = "SQL Files (*.sql)|*.sql"
        If saveFileDialog.ShowDialog = DialogResult.OK Then
            App.database.backupDatabase(saveFileDialog.FileName)
        End If
    End Sub

    Private Sub tbDBImport_Click(sender As Object, e As EventArgs) Handles tbDBImport.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "SQL Files (*.sql)|*.sql"
        If openFileDialog.ShowDialog = DialogResult.OK Then
            App.database.importDatabase(openFileDialog.FileName)
            MessageBox.Show("Successfully imported file. Please restart the program!")
        End If
    End Sub

    Private Sub tbReset_Click(sender As Object, e As EventArgs)
        MessageBox.Show("This will delete your database!!", "Warning!")
    End Sub

    Private Sub ExportDataToPDFTable()
        Dim paragraph As New Paragraph
        Dim doc As New Document(iTextSharp.text.PageSize.A4, 40, 40, 40, 10)
        Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(saveFileDialog.FileName + ".pdf", FileMode.Create))
        doc.Open()

        Dim font12BoldRed As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12.0F, iTextSharp.text.Font.UNDERLINE Or iTextSharp.text.Font.BOLDITALIC, BaseColor.RED)
        Dim font12Bold As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim font12Normal As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12.0F, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)

        Dim p1 As New Phrase
        p1 = New Phrase(New Chunk("PDF From Datagridview Data", font12BoldRed))
        doc.Add(p1)

        'Create instance of the pdf table and set the number of column in that table
        Dim PdfTable As New PdfPTable(5)
        PdfTable.TotalWidth = 490.0F
        'fix the absolute width of the table
        PdfTable.LockedWidth = True
        'relative col widths in proportions - 1,4,1,1 and 1
        Dim widths As Single() = New Single() {1.0F, 4.0F, 1.0F, 1.0F, 1.0F}
        PdfTable.SetWidths(widths)
        PdfTable.HorizontalAlignment = 1 ' 0 --> Left, 1 --> Center, 2 --> Right
        PdfTable.SpacingBefore = 2.0F

        'pdfCell Decleration
        Dim PdfPCell As PdfPCell = Nothing

        'Assigning values to each cell as phrases
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Taxcode", font12Bold)))
        'Alignment of phrase in the pdfcell
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        'Add pdfcell in pdftable
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Tax Name", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Cess Tax", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Sales Tax", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("Other Tax", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)

        Dim dt As DataTable = GetDataTable()
        If dt IsNot Nothing Then
            'Now add the data from datatable to pdf table
            For rows As Integer = 0 To dt.Rows.Count - 1
                For column As Integer = 0 To dt.Columns.Count - 1
                    PdfPCell = New PdfPCell(New Phrase(dt.Rows(rows)(column).ToString(), font12Normal))
                    If column = 0 Or column = 1 Then
                        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    Else
                        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    End If
                    PdfTable.AddCell(PdfPCell)
                Next
            Next
            'Adding pdftable to the pdfdocument
            doc.Add(PdfTable)
        End If
        doc.Close()
    End Sub

    Private Function GetDataTable() As DataTable
        Dim dataTable As New DataTable("MyDataTable")
        'Create another DataColumn Name
        Dim dataColumn_1 As New DataColumn(dgvEvents.Columns(0).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_1)
        Dim dataColumn_2 As New DataColumn(dgvEvents.Columns(1).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_2)
        Dim dataColumn_3 As New DataColumn(dgvEvents.Columns(2).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_3)
        Dim dataColumn_4 As New DataColumn(dgvEvents.Columns(3).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_4)
        Dim dataColumn_5 As New DataColumn(dgvEvents.Columns(4).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_5)
        'Now Add some row to newly created dataTable
        Dim dataRow As DataRow
        For i As Integer = 0 To dgvEvents.Rows.Count - 1
            dataRow = dataTable.NewRow()
            ' Important you have create New row
            dataRow(dgvEvents.Columns(0).HeaderText.ToString()) = dgvEvents.Rows(i).Cells(0).Value.ToString()
            dataRow(dgvEvents.Columns(1).HeaderText.ToString()) = dgvEvents.Rows(i).Cells(1).Value.ToString()
            dataRow(dgvEvents.Columns(2).HeaderText.ToString()) = dgvEvents.Rows(i).Cells(2).Value.ToString()
            dataRow(dgvEvents.Columns(3).HeaderText.ToString()) = dgvEvents.Rows(i).Cells(3).Value.ToString()
            dataRow(dgvEvents.Columns(4).HeaderText.ToString()) = dgvEvents.Rows(i).Cells(4).Value.ToString()

            dataTable.Rows.Add(dataRow)
        Next
        dataTable.AcceptChanges()
        Return dataTable
    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Dim code = ""
        code = InputBox("Swipe keycard to register student")

        If code = "M45t3R" Then
            Dim sql1 = "DELETE FROM ?"
            Dim params = New MySqlParameter() {
                New MySqlParameter() With {.Value = "logs"}
            }

            App.database.executeCommand(sql1, params)

            params = New MySqlParameter() {
                New MySqlParameter() With {.Value = "studentlogs"}
            }

            App.database.executeCommand(sql1, params)
        Else
            MessageBox.Show("System reset aborted")
        End If

    End Sub

    Private Sub dgvEvents_VisibleChanged(sender As Object, e As EventArgs) Handles dgvEvents.VisibleChanged
        initializeList()
    End Sub
End Class
