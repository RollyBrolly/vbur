Public Class TeacherRegistrationForm
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

        departmentBox.SelectedIndex = -1

        CheckBox1.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(firstNameBox.Text) OrElse
       String.IsNullOrWhiteSpace(lastnameBox.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
       departmentBox.SelectedIndex = -1 Then

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

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim regForm As New Registration()
        regForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        ClearAllText(Me)


        departmentBox.SelectedIndex = -1


        CheckBox1.Checked = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
