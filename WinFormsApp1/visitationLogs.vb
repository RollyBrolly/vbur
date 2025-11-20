Public Class visitationLogs

    Private Sub visitationLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' auto date and time
        Dim currentDate As String = Date.Now.ToString("MM/dd/yyyy")
        Dim currentTime As String = Date.Now.ToString("hh:mm tt")


        Dim typeChoice As String = InputBox(
        "Choose Type:" & vbCrLf &
        "1 - Visitor" & vbCrLf &
        "2 - Employee" & vbCrLf &
        "3 - Intern",
        "Select Type"
    )

        Select Case typeChoice
            Case "1"
                typeChoice = "Visitor"
            Case "2"
                typeChoice = "Employee"
            Case "3"
                typeChoice = "Intern"
            Case Else
                MessageBox.Show("Invalid type selected. Entry canceled.")
                Exit Sub
        End Select

        ' Ask for Name
        Dim nameInput As String = InputBox("Enter visitor name (Firstname Surname):", "Add New Log")
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

        ' Add new row (make sure columns are in correct order)
        dgvLogs.Rows.Add(currentDate, currentTime, typeChoice, nameInput, purposeInput)

        MessageBox.Show("Visitation log added successfully!", "Success")
    End Sub

    Private Sub dgvLogs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLogs.CellContentClick

    End Sub


End Class
