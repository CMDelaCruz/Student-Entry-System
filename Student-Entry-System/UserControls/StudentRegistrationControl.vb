Imports MySql.Data.MySqlClient

Public Class StudentRegistrationControl

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim code = ""
            code = InputBox("Swipe keycard to register student")


            Dim sql = "SELECT * FROM connector WHERE CardNumber = ?"
            Dim params = New MySqlParameter() {
                New MySqlParameter() With {.Value = code}
            }

            Dim result = App.database.retrieve(sql, params)

            If result.Count > 0 Then
                MessageBox.Show("A student is already registered for this card.")
                Return
            Else
                sql = "INSERT INTO connector (StudentID, CardNumber) VALUES (@studentID, @code)"
                params = New MySqlParameter() {
                    New MySqlParameter("@studentID", tbStudentNo.Text),
                    New MySqlParameter("@code", code)
                }

                App.database.executeCommand(sql, params)

                sql = "INSERT INTO `studentinformation` (`ID`, `StudentNo`, `LastName`, `FirstName`, `MiddleName`, `Course`, `Year`, `Section`, `Address`, `Gender`, `ContactNo`, `Image`) " +
                          " VALUES (NULL, @studentid, @lastname, @firstname, @middlename, @course, @year, @section, @address, @gender, @contactno, @image)"

                params = New MySqlParameter() {
                    New MySqlParameter("@studentid", tbStudentNo.Text),
                    New MySqlParameter("@lastname", tbLastName.Text),
                    New MySqlParameter("@firstname", tbFirstName.Text),
                    New MySqlParameter("@middlename", tbMiddleName.Text),
                    New MySqlParameter("@course", cbCourse.Text),
                    New MySqlParameter("@year", cbYear.SelectedIndex + 1),
                    New MySqlParameter("@section", cbSection.Text),
                    New MySqlParameter("@address", tbAddress.Text),
                    New MySqlParameter("@gender", If(RadioButton1.Checked, 0, 1)),
                    New MySqlParameter("@contactno", tbContactNo.Text),
                    New MySqlParameter("@image", studentPictureBox.ImageLocation)
                }

                App.database.executeCommand(sql, params)
                MessageBox.Show("Student registered successfully!!")
                MainForm.Logger("Registered student " + tbStudentNo.Text)
                clearForm()
            End If
        Catch ex As Exception
            MessageBox.Show("Student registration failed")
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure?", "Warning!!!", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            clearForm()
        End If
    End Sub

    Private Sub clearForm()
        tbStudentNo.Clear()
        tbLastName.Clear()
        tbFirstName.Clear()
        tbMiddleName.Clear()
        cbCourse.Text = ""
        cbYear.Text = ""
        cbSection.Text = ""
        tbAddress.Clear()
        RadioButton1.Checked = True
        tbContactNo.Clear()
        Button2_Click(Button2, New EventArgs())
    End Sub

    Private Sub touchedEvent(sender As Object, e As EventArgs) Handles tbMiddleName.TextChanged, tbLastName.TextChanged, tbFirstName.TextChanged, tbAddress.TextChanged
        btnCancel.Enabled = True
        btnAdd.Enabled = True
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog As New OpenFileDialog

        openFileDialog.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg; *.png"
        If openFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            studentPictureBox.ImageLocation = openFileDialog.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        studentPictureBox.Image = Nothing
    End Sub
End Class
