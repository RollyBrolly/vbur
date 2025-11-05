Module ExitModule

    Public Sub ConfirmExit(e As FormClosingEventArgs)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?",
                                                     "Exit Confirmation",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)

        If result = DialogResult.No Then
            e.Cancel = True ' Cancel form closing
        End If
    End Sub

End Module


