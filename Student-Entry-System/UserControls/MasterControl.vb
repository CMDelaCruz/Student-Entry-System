Imports MySql.Data.MySqlClient

Public Class MasterControl
    Private isinitialized = False
    Private isEditing = False
    Private isRegistering = True
    Protected adminID As String

    Private Sub MasterControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initializeList()
        btnAddAcc.PerformClick()
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        isEditing = False
        SetState()
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

        btnEdit.Text = "Add"
    End Sub

    Private Sub btnManage_Click(sender As Object, e As EventArgs) Handles btnManage.Click
        btnAddAcc.Enabled = True
        btnDelete.Enabled = True
        btnManage.Enabled = False

        btnEdit.Text = "Edit"
    End Sub
End Class
