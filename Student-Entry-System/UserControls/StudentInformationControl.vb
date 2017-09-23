Imports MySql.Data.MySqlClient

Public Class StudentInformationControl

    Private isEditing As Boolean
    Protected id As String
    Private isinitialized = False

    Private Sub StudentInformationControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeStudentList()
    End Sub

    Public Sub InitializeStudentList()
        Dim sql = "SELECT studentno AS 'Student ID', UPPER(CONCAT(COALESCE(`lastname`,''),',',COALESCE(`firstname`,''),' ',COALESCE(`middlename`,''))) As 'Name' FROM studentinformation"
        studentTable.DataSource = App.database.toDataset(sql).Tables(0)
        isinitialized = True
        studentTable.Update()
        studentTable.Refresh()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            InitializeStudentList()
        Else
            Dim sql = "SELECT  studentid AS 'Student ID', UPPER(CONCAT(lastname, ', ', firstname, ' ', middlename)) As 'Name' FROM studentinformation WHERE firstname LIKE @query OR lastname LIKE @query OR middlename LIKE @query OR studentid LIKE @query"
            Dim params = New MySqlParameter() {
                New MySqlParameter("@query", "%" & txtSearch.Text & "%")
            }
            studentTable.DataSource = App.database.toDataset(sql, params).Tables(0)
        End If
    End Sub

    Private Sub SetValues(ByVal query As List(Of List(Of String)))
        Try
            id = query(0)(0)
            txtStudentNo.Text = query(0)(1)
            txtLastName.Text = query(0)(2)
            txtFirstName.Text = query(0)(3)
            txtMiddleName.Text = query(0)(4) & ""
            cbCourse.Text = query(0)(5)
            cbYear.Text = query(0)(6)
            cbSection.Text = query(0)(7)
            txtAddress.Text = query(0)(8) & ""
            If query(0)(9).Equals("0") Then
                rbMale.Checked = True
            Else
                rbFemale.Checked = True
            End If

            txtContactNo.Text = query(0)(10) & ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SetState()
        Dim state = If(isEditing, True, False)
        btnCancel.Enabled = state
        btnBrowse.Enabled = state

        txtLastName.Enabled = state
        txtFirstName.Enabled = state
        txtMiddleName.Enabled = state
        cbCourse.Enabled = state
        cbYear.Enabled = state
        cbSection.Enabled = state
        txtAddress.Enabled = state
        rbMale.Enabled = state
        rbFemale.Enabled = state
        txtContactNo.Enabled = state
    End Sub

    Private Sub studentTable_SelectionChanged(sender As Object, e As EventArgs) Handles studentTable.SelectionChanged
        If isinitialized Then
            Try
                Dim studentno = studentTable.SelectedRows(0).Cells(0).Value
                Dim sql = "SELECT ID,StudentNo,LastName,FirstName,MiddleName,Course,Year,Section,Address,Gender,ContactNo FROM studentinformation WHERE StudentNo = ?"
                Dim params = New MySqlParameter() {
                    New MySqlParameter() With {.Value = studentno}
                }

                SetValues(App.database.retrieve(sql, params))
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog As New OpenFileDialog

        openFileDialog.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If openFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            studentPictureBox.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If isEditing Then
            Try
                Dim sql = "UPDATE studentinformation SET StudentNo = @studentid, LastName = @lastname, FirstName = @firstname, MiddleName = @middlename, " +
                          "Course = @course, Year = @year, Section = @section, Address = @address, Gender = @gender, ContactNo = @contactno, Image = @image WHERE studentinformation.StudentNo = @studentid"

                Dim params = New MySqlParameter() {
                    New MySqlParameter("@studentid", txtStudentNo.Text),
                    New MySqlParameter("@lastname", txtLastName.Text),
                    New MySqlParameter("@firstname", txtFirstName.Text),
                    New MySqlParameter("@middlename", txtMiddleName.Text),
                    New MySqlParameter("@course", cbCourse.Text),
                    New MySqlParameter("@year", cbYear.SelectedIndex + 1),
                    New MySqlParameter("@section", cbSection.Text),
                    New MySqlParameter("@address", txtAddress.Text),
                    New MySqlParameter("@gender", If(rbMale.Checked, 0, 1)),
                    New MySqlParameter("@contactno", txtContactNo.Text),
                    New MySqlParameter("@image", studentPictureBox.ImageLocation)
                }
                App.database.executeCommand(sql, params)
                MessageBox.Show("Student information updated")
                MainForm.Logger("Updated student " + txtStudentNo.Text + " information")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            btnEdit.Text = "Edit"
            isEditing = False
            InitializeStudentList()
        Else
            btnEdit.Text = "Save"
            isEditing = True
        End If
        SetState()
        InitializeStudentList()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        isEditing = False
        SetState()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim sql = "DELETE FROM studentinformation WHERE studentinformation.ID = ?"
            Dim params = New MySqlParameter() {
                New MySqlParameter() With {.Value = id}
            }
            App.database.executeCommand(sql, params)
            MainForm.Logger("Deleted student " + id)
            InitializeStudentList()
        Catch ex As Exception
        End Try
    End Sub
End Class
