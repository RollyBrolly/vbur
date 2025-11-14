Public Class Registration


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to go back to Login?",
                                                     "Exit Confirmation",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)

        Login.Show()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles studbtn.Click
        Dim studentForm As New StudentRegistrationForm()
        studentForm.Show()

        Hide()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim studentForm As New StudentRegistrationForm


        studentForm.Show

        Hide
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim staffForm As New StaffRegistrationForm

        staffForm.Show()

        Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles faculbtn.Click
        Dim teacherForm As New TeacherRegistrationForm()
        teacherForm.Show()

        Hide()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles staffbtn.Click
        Dim staffForm As New StaffRegistrationForm()
        staffForm.Show()

        Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles returnbtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to go back to Login?",
                                                     "Exit Confirmation",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)

        Login.Show()
    End Sub
End Class
