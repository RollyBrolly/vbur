Module ExitModule

    Public Sub ConfirmExit(e As FormClosingEventArgs)
        ' Only show the confirmation when the user explicitly closes a form (e.g. clicking the window's X
        ' or calling `Close()` from UI code). If the application is shutting down via Application.Exit()
        ' (CloseReason.ApplicationExitCall) we skip additional prompts so the exit dialog appears only once.
        If e.CloseReason = CloseReason.UserClosing Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?",
                                                         "Exit Confirmation",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question)

            If result = DialogResult.No Then
                e.Cancel = True ' Cancel form closing
            End If
        End If
    End Sub

End Module


