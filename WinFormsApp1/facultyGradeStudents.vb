Imports MySql.Data.MySqlClient

Public Class facultyGradeStudents

    Public Property FacultyID As String
    Public Property SelectedStudentID As String

    Private Sub facultyGradeStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        LoadFilter()

        Dim dt As DataTable = GetAllStudentGrades()

        dt.Columns.Add("FullName", GetType(String))

        For Each row As DataRow In dt.Rows
            row("FullName") = $"{row("StudentLastName")}, {row("StudentFirstName")} {row("StudentMiddleName")} {row("Suffix")}".Trim()
        Next

        gradeDGV.DataSource = dt

        If Not dt.Columns.Contains("QuizAverage") Then
            dt.Columns.Add("QuizAverage", GetType(Double))
        End If

        If Not dt.Columns.Contains("SeatworkAverage") Then
            dt.Columns.Add("SeatworkAverage", GetType(Double))
        End If

        If gradeDGV.Columns.Contains("QuizAverage") Then
            gradeDGV.Columns("QuizAverage").Visible = False
        End If

        If gradeDGV.Columns.Contains("SeatworkAverage") Then
            gradeDGV.Columns("SeatworkAverage").Visible = False
        End If

        dt.Columns("FullName").SetOrdinal(1)
        gradeDGV.Columns("FullName").HeaderText = "Student Name"
        gradeDGV.Columns("Quiz1").HeaderText = "Q1 (20)"
        gradeDGV.Columns("Quiz2").HeaderText = "Q2 (25)"
        gradeDGV.Columns("Quiz3").HeaderText = "Q3 (35)"
        gradeDGV.Columns("Seatwork1").HeaderText = "Sw1 (10)"
        gradeDGV.Columns("Seatwork2").HeaderText = "Sw2 (10)"
        gradeDGV.Columns("Seatwork3").HeaderText = "Sw3 (25)"

        For Each colName In {"StudentLastName", "StudentFirstName", "StudentMiddleName", "Suffix"}
            If gradeDGV.Columns.Contains(colName) Then
                gradeDGV.Columns(colName).Visible = False
            End If
        Next

        Dim columnsWithWidths As New Dictionary(Of String, Integer) From {
        {"StudentID", 40},
        {"FullName", 110},
        {"Program", 155},
        {"Department", 105},
        {"Section", 30},
        {"Quiz1", 30},
        {"Quiz2", 30},
        {"Quiz3", 30},
        {"Seatwork1", 30},
        {"Seatwork2", 30},
        {"Seatwork3", 30},
        {"GWA", 25},
        {"Remarks", 30},
        {"QuizAverage", 30},
        {"SeatworkAverage", 30}
    }

        For Each col In columnsWithWidths
            If gradeDGV.Columns.Contains(col.Key) Then
                gradeDGV.Columns(col.Key).FillWeight = col.Value
            End If
        Next

        For Each col As DataGridViewColumn In gradeDGV.Columns
            col.ReadOnly = True
        Next

        gradeDGV.Columns("Quiz1").ReadOnly = False
        gradeDGV.Columns("Quiz2").ReadOnly = False
        gradeDGV.Columns("Quiz3").ReadOnly = False
        gradeDGV.Columns("Seatwork1").ReadOnly = False
        gradeDGV.Columns("Seatwork2").ReadOnly = False
        gradeDGV.Columns("Seatwork3").ReadOnly = False

        gradeDGV.AllowUserToResizeColumns = False
        gradeDGV.RowHeadersVisible = False
        gradeDGV.AllowUserToResizeRows = False
        gradeDGV.ClearSelection()

        HighlightSelectedStudent()
    End Sub

    Private Sub HighlightSelectedStudent()
        If String.IsNullOrEmpty(SelectedStudentID) Then Exit Sub

        For Each row As DataGridViewRow In gradeDGV.Rows
            If row.Cells("StudentID").Value.ToString() = SelectedStudentID Then
                row.Selected = True
                gradeDGV.FirstDisplayedScrollingRowIndex = row.Index
                Exit For
            End If
        Next
    End Sub

    Private Sub ApplyFilters()
        Dim sectionValue As String = If(sectioncbbox.SelectedIndex >= 0, sectioncbbox.SelectedItem.ToString(), "All")
        Dim programValue As String = If(programcbbox.SelectedIndex >= 0, programcbbox.SelectedItem.ToString(), "All")
        Dim deptValue As String = If(deptcbbox.SelectedIndex >= 0, deptcbbox.SelectedItem.ToString(), "All")
        Dim keyword As String = searchbox.Text.Trim()

        Dim dt As DataTable = GetFilteredStudentsGrade(sectionValue, programValue, deptValue, keyword)

        If Not dt.Columns.Contains("FullName") Then
            dt.Columns.Add("FullName", GetType(String))
        End If

        For Each row As DataRow In dt.Rows
            row("FullName") = $"{row("StudentLastName")}, {row("StudentFirstName")} {row("StudentMiddleName")} {row("Suffix")}".Trim()
        Next

        gradeDGV.DataSource = dt

        If Not dt.Columns.Contains("QuizAverage") Then
            dt.Columns.Add("QuizAverage", GetType(Double))
        End If

        If Not dt.Columns.Contains("SeatworkAverage") Then
            dt.Columns.Add("SeatworkAverage", GetType(Double))
        End If

        If gradeDGV.Columns.Contains("QuizAverage") Then
            gradeDGV.Columns("QuizAverage").Visible = False
        End If

        If gradeDGV.Columns.Contains("SeatworkAverage") Then
            gradeDGV.Columns("SeatworkAverage").Visible = False
        End If

        dt.Columns("FullName").SetOrdinal(1)

        If gradeDGV.Columns.Contains("FullName") Then gradeDGV.Columns("FullName").HeaderText = "Student Name"
        If gradeDGV.Columns.Contains("Quiz1") Then gradeDGV.Columns("Quiz1").HeaderText = "Q1 (20)"
        If gradeDGV.Columns.Contains("Quiz2") Then gradeDGV.Columns("Quiz2").HeaderText = "Q2 (25)"
        If gradeDGV.Columns.Contains("Quiz3") Then gradeDGV.Columns("Quiz3").HeaderText = "Q3 (35)"
        If gradeDGV.Columns.Contains("Seatwork1") Then gradeDGV.Columns("Seatwork1").HeaderText = "Sw1 (10)"
        If gradeDGV.Columns.Contains("Seatwork2") Then gradeDGV.Columns("Seatwork2").HeaderText = "Sw2 (10)"
        If gradeDGV.Columns.Contains("Seatwork3") Then gradeDGV.Columns("Seatwork3").HeaderText = "Sw3 (25)"

        For Each colName In {"StudentLastName", "StudentFirstName", "StudentMiddleName", "Suffix"}
            If gradeDGV.Columns.Contains(colName) Then
                gradeDGV.Columns(colName).Visible = False
            End If
        Next

        Dim columnsWithWidths As New Dictionary(Of String, Integer) From {
            {"StudentID", 40},
            {"FullName", 110},
            {"Program", 155},
            {"Department", 105},
            {"Section", 30},
            {"Quiz1", 30},
            {"Quiz2", 30},
            {"Quiz3", 30},
            {"Seatwork1", 30},
            {"Seatwork2", 30},
            {"Seatwork3", 30},
            {"GWA", 25},
            {"Remarks", 30},
            {"QuizAverage", 30},
            {"SeatworkAverage", 30}
        }

        For Each col In columnsWithWidths
            If gradeDGV.Columns.Contains(col.Key) Then
                gradeDGV.Columns(col.Key).FillWeight = col.Value
            End If
        Next

        For Each col As DataGridViewColumn In gradeDGV.Columns
            col.ReadOnly = True
        Next

        gradeDGV.Columns("Quiz1").ReadOnly = False
        gradeDGV.Columns("Quiz2").ReadOnly = False
        gradeDGV.Columns("Quiz3").ReadOnly = False
        gradeDGV.Columns("Seatwork1").ReadOnly = False
        gradeDGV.Columns("Seatwork2").ReadOnly = False
        gradeDGV.Columns("Seatwork3").ReadOnly = False
    End Sub

    Private Sub LoadFilter()
        sectioncbbox.Items.Clear()
        sectioncbbox.Items.Add("All")
        sectioncbbox.Items.AddRange(New String() {"4A", "4B", "4C", "4D", "4E", "4F"})
        sectioncbbox.SelectedIndex = 0

        programcbbox.Items.Clear()
        programcbbox.Items.Add("All")
        Using conn As New MySqlConnection(connstring)
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT CourseName FROM course ORDER BY CourseName", conn)
            Dim reader = cmd.ExecuteReader()
            While reader.Read()
                programcbbox.Items.Add(reader("CourseName").ToString())
            End While
        End Using
        programcbbox.SelectedIndex = 0

        deptcbbox.Items.Clear()
        deptcbbox.Items.Add("All")
        Using conn As New MySqlConnection(connstring)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT DeptName FROM department ORDER BY DeptName", conn)
            Dim reader = cmd.ExecuteReader()
            While reader.Read()
                deptcbbox.Items.Add(reader("DeptName").ToString())
            End While
        End Using
        deptcbbox.SelectedIndex = 0
    End Sub

    Private Sub gradeDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gradeDGV.CellContentClick
        For Each row As DataGridViewRow In gradeDGV.Rows
            row.DefaultCellStyle.BackColor = Color.White
            row.DefaultCellStyle.ForeColor = Color.Black
        Next

        For Each row As DataGridViewRow In gradeDGV.SelectedRows
            row.DefaultCellStyle.BackColor = Color.LightBlue
            row.DefaultCellStyle.ForeColor = Color.Black
        Next
    End Sub

    Private Sub deptcbbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles deptcbbox.SelectedIndexChanged
        ApplyFilters()
    End Sub

    Private Sub programcbbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles programcbbox.SelectedIndexChanged
        ApplyFilters()
    End Sub

    Private Sub sectioncbbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sectioncbbox.SelectedIndexChanged
        ApplyFilters()
    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged
        ApplyFilters()
    End Sub

    Private Sub facultyexitbtn_Click(sender As Object, e As EventArgs) Handles facultyexitbtn.Click
        If MessageBox.Show("Are you sure you want to Return?", "Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim facultyForm = Application.OpenForms.OfType(Of facultyDashboard)().FirstOrDefault()
            If facultyForm IsNot Nothing Then
                facultyForm.Show()
            End If
            Me.Close()
        End If
    End Sub

    Private Sub ComputeRow(rowIndex As Integer)
        If rowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = gradeDGV.Rows(rowIndex)

        Dim scoreMax As New Dictionary(Of String, Double) From {
        {"Quiz1", 20},
        {"Quiz2", 25},
        {"Quiz3", 35},
        {"Seatwork1", 10},
        {"Seatwork2", 10},
        {"Seatwork3", 25}
    }

        Dim totalPercent As Double = 0
        Dim count As Integer = 0

        For Each colName In scoreMax.Keys

            If gradeDGV.Columns.Contains(colName) Then

                Dim valueObj = row.Cells(colName).Value
                Dim score As Double = 0

                If valueObj Is Nothing OrElse Not Double.TryParse(valueObj.ToString(), score) Then
                    Continue For
                End If

                If score > scoreMax(colName) Then
                    MessageBox.Show(colName & " cannot exceed " & scoreMax(colName) & " points.",
                                "Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    row.Cells(colName).Value = Nothing
                    Continue For
                End If

                Dim percent = (score / scoreMax(colName)) * 100
                totalPercent += percent
                count += 1

            End If
        Next

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

    Private Sub gradeDGV_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles gradeDGV.CellValidating

        Dim scoreMax As New Dictionary(Of String, Double) From {
        {"Quiz1", 20},
        {"Quiz2", 25},
        {"Quiz3", 35},
        {"Seatwork1", 10},
        {"Seatwork2", 10},
        {"Seatwork3", 25}
    }

        Dim colName As String = gradeDGV.Columns(e.ColumnIndex).Name

        ' Validate only score columns
        If scoreMax.ContainsKey(colName) Then

            Dim newValue As String = e.FormattedValue.ToString()
            Dim score As Double

            If newValue = "" Then Exit Sub

            If Not Double.TryParse(newValue, score) Then
                MessageBox.Show("Please enter a valid number.", "Invalid Input",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
                Exit Sub
            End If

            ' Must not exceed max
            If score > scoreMax(colName) Then
                MessageBox.Show(colName & " cannot exceed " & scoreMax(colName) & " points.",
                            "Score Too High", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
            End If

        End If
    End Sub


    Private Sub ComputeAll()
        For i As Integer = 0 To gradeDGV.Rows.Count - 1
            ComputeRow(i)
        Next
    End Sub

    Private Sub computebtn_Click(sender As Object, e As EventArgs) Handles computebtn.Click
        ComputeAll()
        MessageBox.Show("Grades computed successfully.")
    End Sub

    Private Sub SaveGradesToDatabase()
        Try
            Using conn As New MySqlConnection(connstring)
                conn.Open()

                For Each row As DataGridViewRow In gradeDGV.Rows
                    ' Skip empty rows
                    If row.IsNewRow Then Continue For

                    Dim studentID As String = row.Cells("StudentID").Value.ToString()
                    Dim quiz1 As Object = If(row.Cells("Quiz1").Value Is Nothing, DBNull.Value, row.Cells("Quiz1").Value)
                    Dim quiz2 As Object = If(row.Cells("Quiz2").Value Is Nothing, DBNull.Value, row.Cells("Quiz2").Value)
                    Dim quiz3 As Object = If(row.Cells("Quiz3").Value Is Nothing, DBNull.Value, row.Cells("Quiz3").Value)
                    Dim sw1 As Object = If(row.Cells("Seatwork1").Value Is Nothing, DBNull.Value, row.Cells("Seatwork1").Value)
                    Dim sw2 As Object = If(row.Cells("Seatwork2").Value Is Nothing, DBNull.Value, row.Cells("Seatwork2").Value)
                    Dim sw3 As Object = If(row.Cells("Seatwork3").Value Is Nothing, DBNull.Value, row.Cells("Seatwork3").Value)
                    Dim gwa As Object = If(row.Cells("GWA").Value Is Nothing, DBNull.Value, row.Cells("GWA").Value)
                    Dim remarks As Object = If(row.Cells("Remarks").Value Is Nothing, DBNull.Value, row.Cells("Remarks").Value)

                    ' Use INSERT ... ON DUPLICATE KEY UPDATE for MySQL
                    Dim query As String = "
                    INSERT INTO studentgrades
                    (StudentID, Quiz1, Quiz2, Quiz3, Seatwork1, Seatwork2, Seatwork3, GWA, Remarks)
                    VALUES (@StudentID, @Quiz1, @Quiz2, @Quiz3, @SW1, @SW2, @SW3, @GWA, @Remarks)
                    ON DUPLICATE KEY UPDATE
                        Quiz1 = @Quiz1,
                        Quiz2 = @Quiz2,
                        Quiz3 = @Quiz3,
                        Seatwork1 = @SW1,
                        Seatwork2 = @SW2,
                        Seatwork3 = @SW3,
                        GWA = @GWA,
                        Remarks = @Remarks
                "

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@StudentID", studentID)
                        cmd.Parameters.AddWithValue("@Quiz1", quiz1)
                        cmd.Parameters.AddWithValue("@Quiz2", quiz2)
                        cmd.Parameters.AddWithValue("@Quiz3", quiz3)
                        cmd.Parameters.AddWithValue("@SW1", sw1)
                        cmd.Parameters.AddWithValue("@SW2", sw2)
                        cmd.Parameters.AddWithValue("@SW3", sw3)
                        cmd.Parameters.AddWithValue("@GWA", gwa)
                        cmd.Parameters.AddWithValue("@Remarks", remarks)

                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using

            MessageBox.Show("Grades saved to database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving grades: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub gradebtn_Click(sender As Object, e As EventArgs) Handles gradebtn.Click
        SaveGradesToDatabase()
        MessageBox.Show("Grades save successfully.")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class