Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbLogo.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Check for Nulls
        If txtUsername.Text.Equals("") Or txtPassword.Text.Equals("") Then
            MessageBox.Show("Please Fill all fields")
            Return
        End If

        'Query to Database
        Dim sql = "SELECT * FROM admins WHERE username = @username AND password = @password"
        Dim parameters = New MySqlParameter() {
            New MySqlParameter("@username", txtUsername.Text),
            New MySqlParameter("@password", txtPassword.Text)
        }
        Dim result = App.database.retrieve(sql, parameters)
        If result.Count > 0 Then
            'Open admin form if successful
            MainForm.changeForm("login")
            Me.Close()
        Else
            MessageBox.Show("Invalid credentials!")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class