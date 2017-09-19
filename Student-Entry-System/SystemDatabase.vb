Imports MySql.Data.MySqlClient

Public Class SystemDatabase

    Public connection As MySqlConnection

    Public Sub New(ByVal connectionString As String)

        connection = New MySqlConnection(connectionString)
    End Sub

    Public Function tryConnect() As Boolean
        Try
            connection.Open()
            connection.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("Cannot connect to database")
            Return False
        End Try
    End Function

    Public Function retrieveFromTable(ByVal tableName As String) As List(Of List(Of String))
        Dim sql = "SELECT * FROM " + tableName
        Dim returnValue As New List(Of List(Of String))
        Dim command As New MySqlCommand(sql, connection)
        Try
            connection.Open()

            Dim reader = command.ExecuteReader()
            While reader.Read()
                Dim list = New List(Of String)
                For column As Integer = 0 To reader.FieldCount
                    list.Add(reader.GetValue(column))
                Next
                returnValue.Add(list)
            End While

            connection.Close()
            Return returnValue
        Catch ex As Exception
            Return returnValue
        End Try
    End Function

    Public Function retrieveFromTable(ByVal tableName As String, ByVal columns As List(Of String)) As List(Of List(Of String))
        Dim sql As String
        Dim builder As New Text.StringBuilder("SELECT ")

        For index As Integer = 0 To columns.Count
            builder.Append(index)
            If index <> columns.Count - 1 Then
                builder.Append(", ")
            End If
        Next
        builder.Append(" FROM " + tableName)
        sql = builder.ToString

        Dim returnValue As New List(Of List(Of String))
        Dim command As New MySqlCommand(sql, connection)
        Try
            connection.Open()

            Dim reader = command.ExecuteReader()
            While reader.Read()
                Dim list = New List(Of String)
                For column As Integer = 0 To reader.FieldCount
                    list.Add(reader.GetValue(column))
                Next
                returnValue.Add(list)
            End While

            connection.Close()
            Return returnValue
        Catch ex As Exception
            Return returnValue
        End Try
    End Function

    Public Function retrieve(ByVal sql As String) As List(Of List(Of String))
        Dim command = New MySqlCommand(sql, connection)
        Dim returnValue As New List(Of List(Of String))
        Try
            connection.Open()
            Dim reader = command.ExecuteReader()
            While reader.Read()
                Dim list = New List(Of String)
                For column As Integer = 0 To reader.FieldCount - 1
                    list.Add(reader.GetValue(column))
                Next
                returnValue.Add(list)
            End While

            connection.Close()
            Return returnValue
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return returnValue
        End Try
    End Function

    Public Function retrieve(ByVal sql As String, ByVal parameters As MySqlParameter()) As List(Of List(Of String))
        Dim command = New MySqlCommand(sql, connection)
        command.Parameters.AddRange(parameters)
        Dim returnValue As New List(Of List(Of String))
        Try
            connection.Open()
            Dim reader = command.ExecuteReader()
            While reader.Read()
                Dim list = New List(Of String)
                For column As Integer = 0 To reader.FieldCount - 1
                    list.Add(reader.GetValue(column))
                Next
                returnValue.Add(list)
            End While

            connection.Close()
            Return returnValue
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return returnValue
        End Try
    End Function

    Public Function toDataset(ByVal sql As String, ByVal parameters As MySqlParameter()) As DataSet
        Dim command = New MySqlCommand(sql, connection)
        command.Parameters.AddRange(parameters)
        Dim dataSet As New DataSet()

        Try
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(dataSet)
            adapter.Dispose()
            connection.Close()
            Return dataSet
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return dataSet
        End Try
    End Function

    Public Function toDataset(ByVal sql As String) As DataSet
        Dim command = New MySqlCommand(sql, connection)
        Dim dataSet As New DataSet()

        Try
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(dataSet)
            adapter.Dispose()
            connection.Close()
            Return dataSet
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return dataSet
        End Try
    End Function

    Public Function executeCommand(sql As String, parameters As MySqlParameter()) As Boolean
        Dim command = New MySqlCommand(sql, connection)
        command.Parameters.AddRange(parameters)
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            command.ExecuteNonQuery()
            command.Dispose()
            connection.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
End Class