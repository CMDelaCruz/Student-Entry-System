Imports MySql.Data.MySqlClient

Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub SplashScreen_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.WindowState = FormWindowState.Minimized
            MainForm.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub tbCode_KeyDown(sender As Object, e As KeyEventArgs) Handles tbCode.KeyDown
        If tbCode.Text.Length = 10 Then
            Dim sql = "SELECT StudentNo, LastName, FirstName, Course, state FROM studentinformation, connector WHERE studentinformation.studentno = connector.studentID AND connector.CardNumber = ?"
            Dim params = New MySqlParameter() {
                New MySqlParameter() With {.Value = tbCode.Text}
            }

            setValue(App.database.retrieve(sql, params))
            tbCode.Text = ""
        ElseIf e.KeyCode = Keys.Escape Then
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
                New MySqlParameter("@state", If(query(0)(4).Equals("False"), "Logged in", "Logged out")),
                New MySqlParameter("@firstname", query(0)(2)),
                New MySqlParameter("@course", query(0)(3))
            }

            App.database.executeCommand(sql, params)
            lblDateTime.Text = If(query(0)(4).Equals("False"), "Logged in: ", "Logged out: ") & System.DateTime.Now
            lblName.Text = query(0)(1) & ", " & query(0)(2)
            lblCourse.Text = query(0)(3)
            setState(query(0)(0), query(0)(4))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub setState(studentNo As String, state As String)
        Dim sql = "UPDATE connector SET state = @state WHERE connector.StudentID = @studentID"
        Dim params = New MySqlParameter() {
            New MySqlParameter("@state", If(state.Equals("False"), "1", "0")),
            New MySqlParameter("@studentID", studentNo)
        }
        App.database.executeCommand(sql, params)
    End Sub
End Class