Imports MySql.Data.MySqlClient

Public Class StudentRegistrationControl

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            InputBox("Swipe keycard to register student")

            Dim sql = "INSERT INTO `studentinformation` (`ID`, `StudentNo`, `LastName`, `FirstName`, `MiddleName`, `Course`, `Year`, `Section`, `Address`, `Gender`, `ContactNo`, `Image`) " +
                      " VALUES (NULL, @studentid, @lastname, @firstname, @middlename, @course, @year, @section, @address, @gender, @contactno, @image)"

            Dim params = New MySqlParameter() {
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
                New MySqlParameter("@image", studentPictureBox.Image)
            }

            App.database.executeCommand(sql, params)
            MessageBox.Show("Student registered successfully!!")
            MainForm.Logger("Registered student " + tbStudentNo.Text)
            clearForm()
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

        openFileDialog.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If openFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            studentPictureBox.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    End Sub
End Class
