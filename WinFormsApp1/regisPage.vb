Public Class Registration


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to go back to Login?",
                                                     "Exit Confirmation",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)

        Login.Show()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        PictureBox4.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim studentForm As New StudentRegistrationForm


        studentForm.Show()

        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim teacherForm As New TeacherRegistrationForm

        teacherForm.Show()

        Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim staffForm As New StaffRegistrationForm

        staffForm.Show()

        Hide()
    End Sub
End Class
