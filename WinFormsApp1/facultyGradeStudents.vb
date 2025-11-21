Public Class facultyGradeStudents
    Private Sub facultyGradeStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.ReadOnly = True
        Next

        Dim editableCols As String() = {
            "Quiz1", "Quiz2", "Quiz3",
            "SW1", "SW2", "SW3",
            "MidtermExam", "FinalExam"
        }

        For Each colName In editableCols
            If DataGridView1.Columns.Contains(colName) Then
                DataGridView1.Columns(colName).ReadOnly = False
            End If
        Next
    End Sub

    Private Sub ComputeAll()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            ComputeRow(i)
        Next
    End Sub

    Private Sub ComputeRow(rowIndex As Integer)
        If rowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = DataGridView1.Rows(rowIndex)

        ' Score columns with their maximum points
        Dim scoreMax As New Dictionary(Of String, Double) From {
            {"Quiz1", 20},
            {"Quiz2", 25},
            {"Quiz3", 35},
            {"SW1", 10},
            {"SW2", 10},
            {"SW3", 20},
            {"MidtermExam", 50},
            {"FinalExam", 70}
        }

        Dim totalPercent As Double = 0
        Dim count As Integer = 0

        For Each colName In scoreMax.Keys

            If DataGridView1.Columns.Contains(colName) Then

                Dim valueObj = row.Cells(colName).Value
                Dim score As Double = 0

                ' Skip empty or non-numeric cells
                If valueObj Is Nothing OrElse Not Double.TryParse(valueObj.ToString(), score) Then
                    Continue For
                End If

                ' ❗ VALIDATION: Exceeds maximum score
                If score > scoreMax(colName) Then
                    MessageBox.Show(
                        colName & " cannot exceed " & scoreMax(colName).ToString() & " points.",
                        "Invalid Score",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    )

                    row.Cells(colName).Value = Nothing
                    Continue For
                End If

                ' Convert score to percentage
                Dim percent = (score / scoreMax(colName)) * 100
                totalPercent += percent
                count += 1

            End If
        Next

        ' Compute GWA and Remarks
        If count > 0 Then
            Dim gwa As Double = totalPercent / count
            row.Cells("GWA").Value = Math.Round(gwa, 2)

            If gwa >= 75 Then
                row.Cells("Remarks").Value = "Passed"
            Else
                row.Cells("Remarks").Value = "Failed"
            End If
        End If

    End Sub

    Private Sub computebtn_Click(sender As Object, e As EventArgs) Handles computebtn.Click
        ComputeAll()
        MessageBox.Show("Grades computed successfully.")
    End Sub

    Private Sub DataGridView1_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DataGridView1.CellValidating

        ' Score columns with max points
        Dim scoreMax As New Dictionary(Of String, Double) From {
        {"Quiz1", 20},
        {"Quiz2", 25},
        {"Quiz3", 35},
        {"SW1", 10},
        {"SW2", 10},
        {"SW3", 20},
        {"MidtermExam", 50},
        {"FinalExam", 70}
    }

        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name

        ' Only validate if column is in our scoring list
        If scoreMax.ContainsKey(colName) Then

            Dim newValue As String = e.FormattedValue.ToString()
            Dim score As Double

            ' If empty, allow
            If newValue = "" Then Exit Sub

            ' If not numeric, prompt and block
            If Not Double.TryParse(newValue, score) Then
                MessageBox.Show("Please enter a valid number.", "Invalid Input",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
                Exit Sub
            End If

            ' If exceeds max points
            If score > scoreMax(colName) Then
                MessageBox.Show(colName & " cannot exceed " & scoreMax(colName) & " points.",
                            "Score Too High",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)

                ' Reject the edit and keep focus on the cell
                e.Cancel = True
            End If

        End If

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim result As DialogResult = MessageBox.Show("Return to dashboard?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim dashboard As New facultyDashboard()
            dashboard.Show()
            Me.Hide()
        End If
    End Sub
End Class
