Imports System.Windows.Forms

Public Class Registration

    Private skipCloseConfirmation As Boolean = False

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub studbtn_Click(sender As Object, e As EventArgs) Handles studbtn.Click
        OpenFormModally(Of StudentRegistrationForm)()
    End Sub

    Private Sub faculbtn_Click(sender As Object, e As EventArgs) Handles faculbtn.Click
        OpenFormModally(Of TeacherRegistrationForm)()
    End Sub

    Private Sub staffbtn_Click(sender As Object, e As EventArgs) Handles staffbtn.Click
        OpenFormModally(Of StaffRegistrationForm)()
    End Sub

    Private Sub returnbtn_Click(sender As Object, e As EventArgs) Handles returnbtn.Click
        If MessageBox.Show("Are you sure you want to go back to Login?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            skipCloseConfirmation = True
            Me.Close()
        End If
    End Sub

    Private Sub Registration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If skipCloseConfirmation Then Return

        If MessageBox.Show("Are you sure you want to exit Registration?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub OpenFormModally(Of T As {Form, New})()
        Using form As New T()
            Me.Hide()
            Try
                form.ShowDialog(Me)
            Finally
                Me.Show()
            End Try
        End Using
    End Sub

    Public Sub CloseWithoutPrompt()
        skipCloseConfirmation = True
        Me.Close()
    End Sub

End Class
