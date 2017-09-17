Public Class MainControl
    Dim studentLogs As StudentLogsControl
    Dim studentInformation As StudentInformationControl
    Dim studentRegistrar As StudentRegistrationControl
    Dim adminManager As AdminAccountManager

    Dim currentButton As Button

    'New btnLogs_Click(btnLogs, New EventArgs())

    Private Sub btnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        loadControl(studentLogs, controlPanel)
        setClickedNavigationOne(btnLogs, 17, 102, 17)
        currentButton = btnLogs
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        studentInformationPanel.Dock = DockStyle.Fill
        studentInformationPanel.Visible = True
        controlPanel.Controls.Clear()
        controlPanel.Controls.Add(studentInformationPanel)

        setClickedNavigationOne(btnRecords, 17, 102, 17)
        currentButton = btnRecords

        Call btnRegisterStudent_Click(btnRegisterStudent, New EventArgs())
    End Sub

    Private Sub btnAccManager_Click(sender As Object, e As EventArgs) Handles btnAccManager.Click
        loadControl(adminManager, controlPanel)
        setClickedNavigationOne(btnAccManager, 17, 102, 17)
        currentButton = btnAccManager
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        setClickedNavigationOne(btnLogOut, 17, 102, 17)
    End Sub

    Private Sub loadControl(ByVal userControl As UserControl, panel As Panel)
        userControl.Dock = DockStyle.Fill
        userControl.Visible = True
        panel.Controls.Clear()
        panel.Controls.Add(userControl)
    End Sub

    Private Sub setClickedNavigationOne(button As Button, red As Byte, green As Byte, blue As Byte)
        Try
            button.BackColor = Color.FromArgb(red, green, blue)
            button.Enabled = False

            currentButton.BackColor = Color.Transparent
            currentButton.Enabled = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnRegisterStudent_Click(sender As Object, e As EventArgs) Handles btnRegisterStudent.Click
        loadControl(studentRegistrar, studentPanel)
        setClickedNavigationTwo(btnRegisterStudent, btnEditStudent)
    End Sub

    Private Sub btnEditStudent_Click(sender As Object, e As EventArgs) Handles btnEditStudent.Click
        loadControl(studentInformation, studentPanel)
        setClickedNavigationTwo(btnEditStudent, btnRegisterStudent)
    End Sub

    Private Sub setClickedNavigationTwo(newButton As Button, oldButton As Button)
        Try
            newButton.BackColor = Color.White
            newButton.ForeColor = Color.FromArgb(17, 102, 17)

            oldButton.BackColor = Color.Transparent
            oldButton.ForeColor = Color.White
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MainControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        studentLogs = New StudentLogsControl()
        studentInformation = New StudentInformationControl()
        studentRegistrar = New StudentRegistrationControl()
        adminManager = New AdminAccountManager()

        btnLogs.PerformClick()
    End Sub
End Class
