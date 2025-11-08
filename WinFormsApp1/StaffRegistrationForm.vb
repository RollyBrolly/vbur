Public Class StaffRegistrationForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ConfirmExit(e)
    End Sub
    Private Sub ClearAllText(parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            ElseIf ctrl.HasChildren Then
                ClearAllText(ctrl)
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(firstNameBox.Text) OrElse
       String.IsNullOrWhiteSpace(lastnameBox.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox2.Text) Then


            MessageBox.Show("Please fill out all required fields before registering.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        MessageBox.Show("You are now registered as a Student!", "Register Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        ClearAllText(Me)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim regForm As New Registration
        regForm.Show
        Hide
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub emailBox_TextChanged(sender As Object, e As EventArgs) Handles emailBox.TextChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim regForm As New Registration()
        regForm.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
