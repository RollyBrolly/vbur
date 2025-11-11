Imports Windows.Win32.UI.Controls

Public Class visitationLogs
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get current date and time
        Dim currentDate As String = Date.Now.ToString("MM/dd/yyyy")
        Dim currentTime As String = Date.Now.ToString("h:mm tt") ' e.g., 2:30PM

        ' Ask for Name
        Dim nameInput As String = InputBox("Enter visitor name:", "Add New Log")
        If String.IsNullOrWhiteSpace(nameInput) Then
            MessageBox.Show("No name entered. Entry canceled.")
            Exit Sub
        End If

        ' Ask for Purpose
        Dim purposeInput As String = InputBox("Enter purpose of visit:", "Add New Log")
        If String.IsNullOrWhiteSpace(purposeInput) Then
            MessageBox.Show("No purpose entered. Entry canceled.")
            Exit Sub
        End If

        ' Add the new entry to the DataGridView
        dgvLogs.Rows.Add(currentDate, currentTime, nameInput, purposeInput)

        MessageBox.Show("Visitation log added successfully!", "Success")
    End Sub
End Class