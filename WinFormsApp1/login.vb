Public Class Login


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passwordBox.UseSystemPasswordChar = True
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim regForm As New Registration


        regForm.Show


        Hide
    End Sub


    Private Sub Button1_SizeChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_SizeChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_SizeChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub UpdateAllRegions()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        If CheckBox1.Checked Then
            passwordBox.UseSystemPasswordChar = False
        Else
            passwordBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub passwordBox_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?",
                                                     "Exit Confirmation",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
