Public Class Login


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passwordBox.UseSystemPasswordChar = True
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ConfirmExit(e)
    End Sub


    Private Sub Button1_SizeChanged(sender As Object, e As EventArgs) Handles Button1.SizeChanged

    End Sub

    Private Sub TextBox1_SizeChanged(sender As Object, e As EventArgs) Handles userBox.SizeChanged

    End Sub

    Private Sub TextBox2_SizeChanged(sender As Object, e As EventArgs) Handles passwordBox.SizeChanged

    End Sub

    Private Sub UpdateAllRegions()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles userBox.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            passwordBox.UseSystemPasswordChar = False
        Else
            passwordBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub passwordBox_TextChanged(sender As Object, e As EventArgs) Handles passwordBox.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim regForm As New Registration()


        regForm.Show()


        Me.Hide()
    End Sub
End Class
