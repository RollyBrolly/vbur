Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class internsView
    Public Property SuperID As String

    ' --- Load Form ---
    Private Sub internsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        LoadFilter()
        LoadCompanies()
        LoadStatuses()

        LoadInterns()
        SetupDGV()
    End Sub

    Private Sub LoadInterns()
        internDGV.DataSource = GetAllInterns()
    End Sub

    Private Sub SetupDGV()
        internDGV.AllowUserToResizeColumns = False
        internDGV.AllowUserToResizeRows = False
        internDGV.RowHeadersVisible = False
        internDGV.ClearSelection()

        If internDGV.Columns.Contains("CompanyID") Then internDGV.Columns("CompanyID").Visible = False
    End Sub

    Private Sub LoadFilter()
        sectionfltr.Items.Clear()
        sectionfltr.Items.Add("All")
        sectionfltr.Items.AddRange(New String() {"4A", "4B", "4C", "4D", "4E", "4F"})
        sectionfltr.SelectedIndex = 0

        programfltr.Items.Clear()
        programfltr.Items.Add("All")
        Using conn As New MySqlConnection(connstring)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT CourseName FROM course ORDER BY CourseName", conn)
            Dim reader = cmd.ExecuteReader()
            While reader.Read()
                programfltr.Items.Add(reader("CourseName").ToString())
            End While
        End Using
        programfltr.SelectedIndex = 0

        deptfltr.Items.Clear()
        deptfltr.Items.Add("All")
        Using conn As New MySqlConnection(connstring)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT DeptName FROM department ORDER BY DeptName", conn)
            Dim reader = cmd.ExecuteReader()
            While reader.Read()
                deptfltr.Items.Add(reader("DeptName").ToString())
            End While
        End Using
        deptfltr.SelectedIndex = 0
    End Sub

    Private Sub ApplyFilters()
        Dim sectionValue As String = If(sectionfltr.SelectedIndex >= 0, sectionfltr.SelectedItem.ToString(), "All")
        Dim programValue As String = If(programfltr.SelectedIndex >= 0, programfltr.SelectedItem.ToString(), "All")
        Dim deptValue As String = If(deptfltr.SelectedIndex >= 0, deptfltr.SelectedItem.ToString(), "All")
        Dim keyword As String = searchtxt.Text.Trim()

        internDGV.DataSource = GetFilteredInterns(sectionValue, programValue, deptValue, keyword)
    End Sub

    Private Sub LoadCompanies()
        Dim dtCompanies As DataTable = GetCompanies()
        compnamecb.DataSource = dtCompanies
        compnamecb.DisplayMember = "CompanyName"
        compnamecb.ValueMember = "CompanyID"
        compnamecb.SelectedIndex = -1
    End Sub

    Private Sub LoadStatuses()
        statuscb.Items.Clear()
        statuscb.Items.AddRange(New String() {"Pending", "Active", "Completed", "Dropped"})
        statuscb.SelectedIndex = -1
    End Sub

    Private Sub internDGV_SelectionChanged(sender As Object, e As EventArgs) Handles internDGV.SelectionChanged
        If internDGV.SelectedRows.Count = 0 Then
            compnamecb.SelectedIndex = -1
            statuscb.SelectedIndex = -1
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow = internDGV.SelectedRows(0)

        If internDGV.Columns.Contains("CompanyID") AndAlso selectedRow.Cells("CompanyID").Value IsNot DBNull.Value Then
            compnamecb.SelectedValue = selectedRow.Cells("CompanyID").Value
        Else
            compnamecb.SelectedIndex = -1
        End If

        If internDGV.Columns.Contains("Status") Then
            Dim status = Convert.ToString(selectedRow.Cells("Status").Value)
            If String.IsNullOrEmpty(status) Then
                statuscb.SelectedIndex = -1
            Else
                statuscb.SelectedIndex = statuscb.FindStringExact(status)
            End If
        Else
            statuscb.SelectedIndex = -1
        End If
    End Sub

    Private Sub compnamecb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles compnamecb.SelectedIndexChanged
        If internDGV.SelectedRows.Count = 0 OrElse compnamecb.SelectedIndex < 0 Then Exit Sub
        Dim selectedRow As DataGridViewRow = internDGV.SelectedRows(0)
        If internDGV.Columns.Contains("CompanyID") Then selectedRow.Cells("CompanyID").Value = compnamecb.SelectedValue
        If internDGV.Columns.Contains("CompanyName") Then selectedRow.Cells("CompanyName").Value = compnamecb.Text
    End Sub

    Private Sub statuscb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles statuscb.SelectedIndexChanged
        If internDGV.SelectedRows.Count = 0 OrElse statuscb.SelectedIndex < 0 Then Exit Sub
        Dim selectedRow As DataGridViewRow = internDGV.SelectedRows(0)
        Dim newStatus As String = statuscb.Text
        selectedRow.Cells("Status").Value = newStatus

        If newStatus = "Active" Then
            If String.IsNullOrEmpty(Convert.ToString(selectedRow.Cells("InternshipID").Value)) Then
                selectedRow.Cells("InternshipID").Value = GenerateInternshipID()
            End If
            If IsDBNull(selectedRow.Cells("DateStart").Value) OrElse String.IsNullOrEmpty(selectedRow.Cells("DateStart").Value.ToString()) Then
                selectedRow.Cells("DateStart").Value = DateTime.Now.Date
            End If
        ElseIf newStatus = "Completed" Then
            selectedRow.Cells("DateEnd").Value = DateTime.Now.Date
        End If
    End Sub

    Private Function GenerateInternshipID() As String
        Dim lastID As String = ""
        Using conn As New MySqlConnection(connstring)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT MAX(InternshipID) FROM internships", conn)
            Dim result = cmd.ExecuteScalar()
            If result IsNot DBNull.Value AndAlso result IsNot Nothing Then lastID = result.ToString()
        End Using

        If String.IsNullOrEmpty(lastID) Then Return "I001"

        Dim numberPart As Integer = Integer.Parse(System.Text.RegularExpressions.Regex.Match(lastID, "\d+").Value)
        Return "I" & (numberPart + 1).ToString("D3")
    End Function

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        If internDGV.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow = internDGV.SelectedRows(0)

        Dim internshipID As String = Convert.ToString(selectedRow.Cells("InternshipID").Value)
        Dim studentID As String = Convert.ToString(selectedRow.Cells("StudentID").Value)
        Dim status As String = Convert.ToString(selectedRow.Cells("Status").Value)

        Dim companyID As Object = If(compnamecb.SelectedIndex >= 0, compnamecb.SelectedValue, DBNull.Value)

        If companyID Is DBNull.Value Then
            MessageBox.Show("Please select a company before saving.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If String.IsNullOrEmpty(status) Then
            MessageBox.Show("Please select a status before saving.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim startDateValue As Object = If(DateTime.TryParse(Convert.ToString(selectedRow.Cells("DateStart").Value), Nothing), Convert.ToDateTime(selectedRow.Cells("DateStart").Value), DBNull.Value)
        Dim endDateValue As Object = If(DateTime.TryParse(Convert.ToString(selectedRow.Cells("DateEnd").Value), Nothing), Convert.ToDateTime(selectedRow.Cells("DateEnd").Value), DBNull.Value)

        If String.IsNullOrEmpty(internshipID) Then
            internshipID = GenerateInternshipID()
            selectedRow.Cells("InternshipID").Value = internshipID
        End If

        Try
            Using conn As New MySqlConnection(connectdb.connstring)
                conn.Open()

                Dim query As String = "
                INSERT INTO internships (InternshipID, StudentID, CompanyID, Status, StartDate, EndDate)
                VALUES (@InternshipID, @StudentID, @CompanyID, @Status, @StartDate, @EndDate)
                ON DUPLICATE KEY UPDATE
                    CompanyID=@CompanyID,
                    Status=@Status,
                    StartDate=@StartDate,
                    EndDate=@EndDate
            "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@InternshipID", internshipID)
                    cmd.Parameters.AddWithValue("@StudentID", studentID)
                    cmd.Parameters.AddWithValue("@CompanyID", companyID)
                    cmd.Parameters.AddWithValue("@Status", status)
                    cmd.Parameters.AddWithValue("@StartDate", startDateValue)
                    cmd.Parameters.AddWithValue("@EndDate", endDateValue)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Internship record saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadInterns()

        Catch ex As Exception
            MessageBox.Show("Error saving internship record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If internDGV.SelectedRows.Count = 0 Then
            MessageBox.Show("No row selected to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow = internDGV.SelectedRows(0)
        Dim internshipID As String = Convert.ToString(selectedRow.Cells("InternshipID").Value)

        Dim confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            If Not String.IsNullOrEmpty(internshipID) Then
                Using conn As New MySqlConnection(connstring)
                    conn.Open()
                    Dim deleteCmd As New MySqlCommand("DELETE FROM internships WHERE InternshipID=@InternshipID", conn)
                    deleteCmd.Parameters.AddWithValue("@InternshipID", internshipID)
                    deleteCmd.ExecuteNonQuery()
                End Using
            End If
            internDGV.Rows.Remove(selectedRow)
            MessageBox.Show("Record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub returnbtn_Click(sender As Object, e As EventArgs) Handles returnbtn.Click
        If MessageBox.Show("Are you sure you want to Return?", "Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim returnForm = Application.OpenForms.OfType(Of supervisorDashboard)().FirstOrDefault()
            If returnForm IsNot Nothing Then
                returnForm.Show()
            End If
            Me.Close()
        End If
    End Sub
End Class
