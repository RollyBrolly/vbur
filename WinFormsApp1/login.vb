Public Class Login


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passbtn.UseSystemPasswordChar = True
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ConfirmExit(e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles signupbtn.Click

        Dim regForm As New Registration


        regForm.Show


        Hide
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        If showpasschkb.Checked Then
            passbtn.UseSystemPasswordChar = False
        Else
            passbtn.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub passwordBox_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles welcomelbl.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Me.Close()
    End Sub
End Class
