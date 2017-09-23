Imports MySql.Data.MySqlClient

Public Class AdminAccountManager
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If tbSystemKey.Equals("S3GM5") Then
                If Not tbEmployeeID.Text.Equals("") And Not tbFirstName.Text.Equals("") And Not tbMiddleName.Text.Equals("") And Not tbLastName.Text.Equals("") And Not tbUserName.Text.Equals("") And Not tbPassword.Text.Equals("") Then
                    If tbPassword.Text.Equals(tbConfirmPassword.Text) Then
                        Dim sql = "UPDATE admins SET employeeid = @employeeid, firstname = @firstname, middlename = @middlename, lastname = @lastname, username = @username, password = @password WHERE admins.username = @oldusername"
                        Dim params = New MySqlParameter() {
                            New MySqlParameter("@employeeid", tbEmployeeID.Text),
                            New MySqlParameter("@firstname", tbFirstName.Text),
                            New MySqlParameter("@middlename", tbMiddleName.Text),
                            New MySqlParameter("@lastname", tbLastName.Text),
                            New MySqlParameter("@username", tbUserName.Text),
                            New MySqlParameter("@password", tbPassword.Text),
                            New MySqlParameter("@oldusername", MainForm.username)
                        }

                        App.database.executeCommand(sql, params)
                        MessageBox.Show("Account updated!")
                        MainForm.Logger("Updated administrator " + MainForm.adminID + "s account")
                    End If
                Else
                    MessageBox.Show("Please fill all required fields...")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        initialize()
    End Sub

    Private Sub AdminAccountManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialize()
    End Sub

    Private Sub initialize()
        Dim sql = "SELECT employeeid,firstname,middlename,lastname,username FROM admins WHERE username = ?"
        Dim params = New MySqlParameter() {
            New MySqlParameter() With {.Value = MainForm.username}
        }
        setValues(App.database.retrieve(sql, params))
    End Sub

    Private Sub setValues(query As List(Of List(Of String)))
        tbEmployeeID.Text = query(0)(0)
        tbFirstName.Text = query(0)(1)
        tbMiddleName.Text = query(0)(2)
        tbLastName.Text = query(0)(3)
        tbUserName.Text = MainForm.username
    End Sub
End Class
