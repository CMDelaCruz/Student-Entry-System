Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbLogo.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub SplashScreen_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.WindowState = FormWindowState.Minimized
            MainForm.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class