Public Class MainForm

    Dim adminControls As MainControl

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not App.database.tryConnect Then
            MessageBox.Show("Database Connection Failed")
            Application.Exit()
        End If
        adminControls = New MainControl()
        pbLogo.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btnSplash_Click(sender As Object, e As EventArgs) Handles btnSplash.Click
        SplashScreen.Show()
        Me.WindowState = FormWindowState.Minimized
        SplashScreen.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnLabelAdmin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnLabelAdmin.LinkClicked
        LoginForm.ShowDialog()
    End Sub

    Private Sub loadLoginMenu()
        Controls.Remove(adminControls)

        Panel1.Visible = True
        Panel2.Visible = True
        btnLabelAdmin.Visible = True
        btnSplash.Visible = True
    End Sub

    Private Sub loadAdminControls()
        Panel1.Visible = False
        Panel2.Visible = False
        btnLabelAdmin.Visible = False
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
End Class
