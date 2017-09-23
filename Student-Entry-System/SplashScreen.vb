Imports MySql.Data.MySqlClient

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

    Private Sub setValue(query As List(Of List(Of String)))
        Try
            Dim sql = "INSERT INTO studentlogs (StudentNo, logtime, Status, LastName, FirstName, Course) " +
                      "VALUES (@studentno, CURRENT_TIMESTAMP, @state, @lastname, @firstname, @course)"
            Dim params = New MySqlParameter() {
                New MySqlParameter("@studentno", query(0)(0)),
                New MySqlParameter("@lastname", query(0)(1)),
                New MySqlParameter("@state", If(query(0)(4).Equals("0"), "Logged in", "Logged out")),
                New MySqlParameter("@firstname", query(0)(2)),
                New MySqlParameter("@course", query(0)(3))
            }

            App.database.executeCommand(sql, params)
            lblName.Text = query(0)(1) & ", " & query(0)(2)
            lblCourse.Text = query(0)(3)

            setState(query(0)(0), query(0)(4))
        Catch ex As Exception
            MessageBox.Show("Card not registered")
        End Try
    End Sub

    Private Sub setState(studentNo As String, state As String)
        Dim sql = "UPDATE connector SET state = @state WHERE connector.StudentID = @studentID"
        Dim params = New MySqlParameter() {
            New MySqlParameter("@state", If(state.Equals("0"), "1", "0")),
            New MySqlParameter("@studentID", studentNo)
        }
        App.database.executeCommand(sql, params)
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        MessageBox.Show(tbCode.Text)
    End Sub

    Dim s = ""
    Private Sub tbCode_KeyDown(sender As Object, e As KeyEventArgs) Handles tbCode.KeyDown
        If tbCode.Text.Length = 9 Then
            Dim sql = "SELECT StudentNo, LastName, FirstName, Course, state FROM studentinformation, connector WHERE studentinformation.studentno = connector.studentID AND connector.cardNumber = ?"
            Dim params = New MySqlParameter() {
                New MySqlParameter() With {.Value = tbCode.Text}
            }

            setValue(App.database.retrieve(sql, params))
            tbCode.Text = ""
        End If
    End Sub
End Class