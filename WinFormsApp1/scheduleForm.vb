Public Class scheduleForm

    ' Load the time slots into the DataGridView
    Private Sub studentScheduleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up the columns
        With dgvSchedule
            .ColumnCount = 8
            .Columns(0).Name = "Time"
            .Columns(1).Name = "Monday"
            .Columns(2).Name = "Tuesday"
            .Columns(3).Name = "Wednesday"
            .Columns(4).Name = "Thursday"
            .Columns(5).Name = "Friday"
            .Columns(6).Name = "Saturday"
            .Columns(7).Name = "Sunday"

            ' Lock down the Time column and prevent row modifications
            .Columns(0).ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
        End With

        Dim times As String() = {
            "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM",
            "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM",
            "6:00 PM", "7:00 PM", "8:00 PM", "9:00 PM"
        }

        ' Add the times and empty cells for each day
        For Each t As String In times
            dgvSchedule.Rows.Add(t, "", "", "", "", "", "", "")
        Next
    End Sub

    ' Block editing of the Time column
    Private Sub dgvSchedule_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvSchedule.CellBeginEdit
        If e.ColumnIndex = 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If dgvSchedule.SelectedCells.Count > 0 Then
            Dim selectedCell As DataGridViewCell = dgvSchedule.SelectedCells(0)

            ' Do not allow adding items in the Time column
            If selectedCell.ColumnIndex = 0 Then Exit Sub

            If String.IsNullOrEmpty(selectedCell.Value?.ToString()) Then
                Dim description As String = InputBox("Enter the description for this item:", "Add Schedule Item")
                If Not String.IsNullOrWhiteSpace(description) Then
                    selectedCell.Value = description
                End If
            Else
                MessageBox.Show("This cell already contains an item. You can edit it instead.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Please select a cell to add an item to.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEditItem_Click(sender As Object, e As EventArgs) Handles btnEditItem.Click
        If dgvSchedule.SelectedCells.Count > 0 Then
            Dim selectedCell As DataGridViewCell = dgvSchedule.SelectedCells(0)

            ' Prevent editing the Time column
            If selectedCell.ColumnIndex = 0 Then Exit Sub

            ' Show prompt if empty
            If String.IsNullOrEmpty(selectedCell.Value?.ToString()) Then
                MessageBox.Show("Please select a cell that contains an item to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim existingDescription As String = selectedCell.Value.ToString()
                Dim newDescription As String = InputBox("Edit the description (Current: " & existingDescription & "):", "Edit Schedule Item", existingDescription)
                If Not String.IsNullOrWhiteSpace(newDescription) Then
                    selectedCell.Value = newDescription
                End If
            End If
        Else
            MessageBox.Show("Please select a cell to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If dgvSchedule.SelectedCells.Count > 0 Then
            Dim selectedCell As DataGridViewCell = dgvSchedule.SelectedCells(0)

            ' Prevent deleting the Time column
            If selectedCell.ColumnIndex = 0 Then Exit Sub

            ' Show prompt if empty
            If String.IsNullOrEmpty(selectedCell.Value?.ToString()) Then
                MessageBox.Show("Please select a cell that contains an item to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    selectedCell.Value = Nothing
                End If
            End If
        Else
            MessageBox.Show("Please select a cell to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dgvSchedule_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSchedule.CellDoubleClick
        ' Ignore header clicks or invalid cells
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        ' Get the clicked cell
        Dim selectedCell As DataGridViewCell = dgvSchedule.Rows(e.RowIndex).Cells(e.ColumnIndex)

        ' Skip empty cells and the Time column
        If e.ColumnIndex = 0 OrElse String.IsNullOrWhiteSpace(selectedCell.Value?.ToString()) Then Exit Sub

        Dim description As String = selectedCell.Value.ToString()

        ' Measure if the text is longer than what fits in the cell
        Dim displayedWidth As Integer = dgvSchedule.Columns(e.ColumnIndex).Width
        Dim textWidth As Integer = TextRenderer.MeasureText(description, dgvSchedule.Font).Width

        ' If text doesn’t fit, show full description
        If textWidth > displayedWidth Then
            MessageBox.Show(description, "Full Description", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Function GetRowIndexFromTime(time As String) As Integer
        Select Case time
            Case "8:00 AM" : Return 0
            Case "9:00 AM" : Return 1
            Case "10:00 AM" : Return 2
            Case "11:00 AM" : Return 3
            Case "12:00 PM" : Return 4
            Case "1:00 PM" : Return 5
            Case "2:00 PM" : Return 6
            Case "3:00 PM" : Return 7
            Case "4:00 PM" : Return 8
            Case "5:00 PM" : Return 9
            Case "6:00 PM" : Return 10
            Case "7:00 PM" : Return 11
            Case "8:00 PM" : Return 12
            Case "9:00 PM" : Return 13
            Case Else : Return -1
        End Select
    End Function

    Private Function GetColumnIndexFromDay(day As String) As Integer
        Select Case day
            Case "Monday" : Return 1
            Case "Tuesday" : Return 2
            Case "Wednesday" : Return 3
            Case "Thursday" : Return 4
            Case "Friday" : Return 5
            Case "Saturday" : Return 6
            Case "Sunday" : Return 7
            Case Else : Return -1
        End Select
    End Function

End Class
