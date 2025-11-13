Public Class TeacherRegistrationForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
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
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        ClearAllText(Me)

        deptcb.SelectedIndex = -1


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(fnametxt.Text) OrElse
       String.IsNullOrWhiteSpace(lastnametxt.Text) OrElse
       deptcb.SelectedIndex = -1 Then

            MessageBox.Show("Please fill out all required fields before registering.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        MessageBox.Show("You are now registered as a Teacher!", "Register Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim regForm As New Registration
        regForm.Show()
        Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles returnbtn.Click
        Dim result As DialogResult = MessageBox.Show("Return to registration page?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim regForm As New Registration()
            regForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles clearbtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear all fields?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ClearAllText(Me)
            deptcb.SelectedIndex = -1
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles fnumbertxt.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
