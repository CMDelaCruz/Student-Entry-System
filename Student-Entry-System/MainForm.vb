Imports MySql.Data.MySqlClient

Public Class MainForm

    Public Shared username As String
    Public Shared adminID As String
    Public Shared isMaster As Boolean
    Dim adminControls As MainControl

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not App.database.tryConnect Then
            MessageBox.Show("Database Connection Failed")
            Application.Exit()
        End If
        adminControls = New MainControl()
    End Sub

    Private Sub btnSplash_Click(sender As Object, e As EventArgs) Handles btnSplash.Click
        SplashScreen.Show()
        WindowState = FormWindowState.Minimized
        SplashScreen.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub loadLoginMenu()
        Controls.Remove(adminControls)

        Panel2.Visible = True
        Panel3.Visible = True
        btnLogin.Visible = True
        btnSplash.Visible = True
    End Sub

    Private Sub loadAdminControls()
        Panel2.Visible = False
        Panel3.Visible = False
        btnLogin.Visible = False
        btnSplash.Visible = False

        adminControls.Dock = DockStyle.Fill
        adminControls.Visible = True
        Controls.Add(adminControls)
    End Sub

    Public Sub changeForm(state As String)
        If state.Equals("login") Then
            loadAdminControls()
        End If
        If state.Equals("logOut") Then
            loadLoginMenu()
        End If

    End Sub

    Public Sub Logger(log As String)
        Dim sql = "INSERT INTO logs (ID, adminID, log, time) VALUES (NULL, @adminid, @description, CURRENT_TIMESTAMP)"
        Dim params = New MySqlParameter() {
            New MySqlParameter("@adminid", adminID),
            New MySqlParameter("@description", log)
        }

        App.database.executeCommand(sql, params)
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
            username = txtUsername.Text
            adminID = result(0)(7)
            isMaster = If(result(0)(1).Equals("master"), True, False)
            changeForm("login")

        Else
            MessageBox.Show("Invalid credentials!")
        End If
    End Sub
End Class
