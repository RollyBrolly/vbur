Imports MySql.Data.MySqlClient

Public Class facultyGradeStudents

    Public Property FacultyID As String

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

        dt.Columns("FullName").SetOrdinal(1)
        gradeDGV.Columns("FullName").HeaderText = "Student Name"
        gradeDGV.Columns("Quiz1").HeaderText = "Q1"
        gradeDGV.Columns("Quiz2").HeaderText = "Q2"
        gradeDGV.Columns("Quiz3").HeaderText = "Q3"
        gradeDGV.Columns("Seatwork1").HeaderText = "Sw1"
        gradeDGV.Columns("Seatwork2").HeaderText = "Sw2"
        gradeDGV.Columns("Seatwork3").HeaderText = "Sw3"

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
        {"GWA", 30},
        {"Remarks", 30}
    }

        For Each col In columnsWithWidths
            If gradeDGV.Columns.Contains(col.Key) Then
                gradeDGV.Columns(col.Key).FillWeight = col.Value
            End If
        Next

        gradeDGV.AllowUserToResizeColumns = False
        gradeDGV.RowHeadersVisible = False
        gradeDGV.AllowUserToResizeRows = False
        gradeDGV.ClearSelection()
    End Sub

    Private Sub ApplyFilters()
        Dim sectionValue As String = If(sectioncbbox.SelectedIndex >= 0, sectioncbbox.SelectedItem.ToString(), "All")
        Dim programValue As String = If(programcbbox.SelectedIndex >= 0, programcbbox.SelectedItem.ToString(), "All")
        Dim deptValue As String = If(deptcbbox.SelectedIndex >= 0, deptcbbox.SelectedItem.ToString(), "All")
        Dim keyword As String = searchbox.Text.Trim()

        Dim dt As DataTable = GetFilteredStudents(sectionValue, programValue, deptValue, keyword)

        If Not dt.Columns.Contains("FullName") Then
            dt.Columns.Add("FullName", GetType(String))
        End If

        For Each row As DataRow In dt.Rows
            row("FullName") = $"{row("StudentLastName")}, {row("StudentFirstName")} {row("StudentMiddleName")} {row("Suffix")}".Trim()
        Next

        gradeDGV.DataSource = dt

        dt.Columns("FullName").SetOrdinal(1)

        If gradeDGV.Columns.Contains("FullName") Then gradeDGV.Columns("FullName").HeaderText = "Student Name"
        If gradeDGV.Columns.Contains("Quiz1") Then gradeDGV.Columns("Quiz1").HeaderText = "Q1"
        If gradeDGV.Columns.Contains("Quiz2") Then gradeDGV.Columns("Quiz2").HeaderText = "Q2"
        If gradeDGV.Columns.Contains("Quiz3") Then gradeDGV.Columns("Quiz3").HeaderText = "Q3"
        If gradeDGV.Columns.Contains("Seatwork1") Then gradeDGV.Columns("Seatwork1").HeaderText = "Sw1"
        If gradeDGV.Columns.Contains("Seatwork2") Then gradeDGV.Columns("Seatwork2").HeaderText = "Sw2"
        If gradeDGV.Columns.Contains("Seatwork3") Then gradeDGV.Columns("Seatwork3").HeaderText = "Sw3"

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
            {"GWA", 30},
            {"Remarks", 30}
        }

        For Each col In columnsWithWidths
            If gradeDGV.Columns.Contains(col.Key) Then
                gradeDGV.Columns(col.Key).FillWeight = col.Value
            End If
        Next
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
End Class
