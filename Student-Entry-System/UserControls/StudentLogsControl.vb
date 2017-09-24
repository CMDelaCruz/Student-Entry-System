Imports MySql.Data.MySqlClient

Public Class StudentLogsControl
    Private logs As DataTable

    Private Sub StudentLogsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeStudentList()
    End Sub

    Private Sub InitializeStudentList()
        Dim sql = "SELECT * FROM studentlogs"
        logs = App.database.toDataset(sql).Tables(0)
        gridLogs.DataSource = logs
    End Sub

    Private Sub StudentLogsControl_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        InitializeStudentList()
    End Sub
End Class
