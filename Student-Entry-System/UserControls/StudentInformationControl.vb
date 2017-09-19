Imports MySql.Data.MySqlClient

Public Class StudentInformationControl
    Private studentData As DataTable

    Private Sub StudentInformationControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeStudentList()
    End Sub

    Private Sub InitializeStudentList()
        Dim sql = "SELECT studentid AS 'Student ID', UPPER(CONCAT(lastname, ', ', firstname, ' ', middlename)) As 'Name' FROM students"
        studentData = App.database.toDataset(sql).Tables(0)
        studentTable.DataSource = studentData
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            InitializeStudentList()
        Else
            Dim sql = "SELECT  studentid AS 'Student ID', UPPER(CONCAT(lastname, ', ', firstname, ' ', middlename)) As 'Name' FROM students WHERE firstname LIKE @query OR lastname LIKE @query OR middlename LIKE @query OR studentid LIKE @query"
            Dim params = New MySqlParameter() {
                New MySqlParameter("@query", "%" & txtSearch.Text & "%")
            }
            studentData = App.database.toDataset(sql, params).Tables(0)
            studentTable.DataSource = studentData
        End If
    End Sub

    Private Sub studentTable_SelectionChanged(sender As Object, e As EventArgs) Handles studentTable.SelectionChanged
        Dim id = studentTable.SelectedCells.Item(0).ToString
        Dim sql = "SELECT  * FROM students WHERE studentid = '@query'"
        Dim params = New MySqlParameter() {
            New MySqlParameter("@query", "%" & id & "%")
        }
        Dim values = App.database.retrieve(sql)

    End Sub

    Private Sub SetValues(ByVal query As List(Of List(Of String)))
        Dim values = query.ElementAt(0)
        txtStudentNo.Text = values.ElementAt(0)
        txtFirstName.Text = values.ElementAt(0)
        txtMiddleName.Text = values.ElementAt(0)
        txtLastName.Text = values.ElementAt(0)
        txtSection.Text = values.ElementAt(0)
        txtCourse.Text = values.ElementAt(0)
        txtAddress.Text = values.ElementAt(0)
        cbYear.Text = values.ElementAt(0)
    End Sub

End Class
