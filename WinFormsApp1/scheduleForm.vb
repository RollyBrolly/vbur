Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class scheduleForm

    '---------------- PROPERTIES ----------------
    Public Property StudentID As String
    Public Property FacultyID As String
    Public Property ReadOnlyMode As Boolean = True

    Private conn As MySqlConnection
    Private timeSlots As String() = {
        "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM",
        "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM", "5:00 PM",
        "6:00 PM", "7:00 PM", "8:00 PM", "9:00 PM"
    }

    ' ---------------- FORM LOAD ----------------
    Private Sub scheduleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.StartPosition = FormStartPosition.CenterScreen

        SetupDataGridView()

        ' Hide buttons if student
        btnAddItem.Visible = Not ReadOnlyMode
        btnEditItem.Visible = Not ReadOnlyMode
        btnDeleteItem.Visible = Not ReadOnlyMode

        ' Hide course/section filters if student
        coursecb.Visible = Not ReadOnlyMode
        sectioncb.Visible = Not ReadOnlyMode
        courselbl.Visible = Not ReadOnlyMode
        sectionlbl.Visible = Not ReadOnlyMode

        ' Initialize rows
        dgvSchedule.Rows.Clear()
        For Each t As String In timeSlots
            dgvSchedule.Rows.Add(t, "", "", "", "", "", "", "")
        Next

        conn = New MySqlConnection(connectdb.connstring)

        ' Faculty mode
        If Not ReadOnlyMode Then
            PopulateCourses()
            PopulateSections()
        End If

        LoadScheduleFromDB()
    End Sub

    ' ---------------- DATA GRID SETUP ----------------
    Private Sub SetupDataGridView()
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
            .Columns(0).ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
        End With
    End Sub

    ' ---------------- POPULATE COURSES (FACULTY DEPARTMENT FILTER) ----------------
    Private Sub PopulateCourses()
        coursecb.Items.Clear()

        If String.IsNullOrEmpty(FacultyID) Then
            MessageBox.Show("FacultyID not set!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Using tempConn As New MySqlConnection(connectdb.connstring)
                tempConn.Open()

                ' 1. Get the faculty department
                Dim deptCmd As New MySqlCommand("SELECT DeptID FROM faculty WHERE FacultyID=@fid", tempConn)
                deptCmd.Parameters.AddWithValue("@fid", FacultyID.Trim())
                Dim deptIDObj = deptCmd.ExecuteScalar()

                If deptIDObj Is Nothing Then
                    MessageBox.Show("Department not found for this faculty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim deptID As String = deptIDObj.ToString().Trim()

                ' 2. Get courses for that department
                Dim cmd As New MySqlCommand("SELECT CourseID, CourseName FROM course WHERE DepartmentID=@did ORDER BY CourseName", tempConn)
                cmd.Parameters.AddWithValue("@did", deptID)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        coursecb.Items.Add(New KeyValuePair(Of String, String)(
                        dr("CourseID").ToString(),
                        dr("CourseName").ToString()
                    ))
                    End While
                End Using

                ' 3. Set ComboBox selection
                If coursecb.Items.Count > 0 Then
                    coursecb.DisplayMember = "Value"
                    coursecb.ValueMember = "Key"
                    coursecb.SelectedIndex = 0
                Else
                    MessageBox.Show("No courses found for your department.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading courses: " & ex.Message)
        End Try
    End Sub



    ' ---------------- POPULATE SECTIONS ----------------
    Private Sub PopulateSections()
        sectioncb.Items.Clear()
        Dim sections As String() = {"4A", "4B", "4C", "4D", "4E", "4F"}
        sectioncb.Items.AddRange(sections)
        If sectioncb.Items.Count > 0 Then sectioncb.SelectedIndex = 0
    End Sub

    Public Sub LoadScheduleFromDB()
        Try
            conn.Open()
            Dim courseID As String = ""
            Dim section As String = ""

            ' ---------------- STUDENT VIEW ----------------
            If Not String.IsNullOrEmpty(StudentID) Then
                Dim cmd As New MySqlCommand("SELECT CourseID, section FROM student WHERE StudentID=@sid LIMIT 1", conn)
                cmd.Parameters.AddWithValue("@sid", StudentID)

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        courseID = dr("CourseID").ToString()
                        section = dr("section").ToString()
                    Else
                        Exit Sub
                    End If
                End Using

                ' Set ComboBoxes to the student's course & section
                SetComboBoxSelection(coursecb, courseID)
                SetComboBoxSelection(sectioncb, section)

            Else
                ' ---------------- FACULTY VIEW ----------------
                If coursecb.SelectedItem Is Nothing OrElse sectioncb.SelectedItem Is Nothing Then Exit Sub
                courseID = CType(coursecb.SelectedItem, KeyValuePair(Of String, String)).Key
                section = sectioncb.SelectedItem.ToString()
            End If

            ' Clear old schedule
            For i As Integer = 0 To dgvSchedule.Rows.Count - 1
                For j As Integer = 1 To 7
                    dgvSchedule.Rows(i).Cells(j).Value = ""
                Next
            Next

            ' Load schedule per course + section
            Dim schedCmd As New MySqlCommand("SELECT * FROM schedule WHERE CourseID=@course AND Section=@section", conn)
            schedCmd.Parameters.AddWithValue("@course", courseID)
            schedCmd.Parameters.AddWithValue("@section", section)

            Using dr As MySqlDataReader = schedCmd.ExecuteReader()
                While dr.Read()
                    Dim rowIndex As Integer = GetRowIndexFromTime(dr("Time").ToString())
                    If rowIndex >= 0 Then
                        dgvSchedule.Rows(rowIndex).Cells("Monday").Value = dr("Monday").ToString()
                        dgvSchedule.Rows(rowIndex).Cells("Tuesday").Value = dr("Tuesday").ToString()
                        dgvSchedule.Rows(rowIndex).Cells("Wednesday").Value = dr("Wednesday").ToString()
                        dgvSchedule.Rows(rowIndex).Cells("Thursday").Value = dr("Thursday").ToString()
                        dgvSchedule.Rows(rowIndex).Cells("Friday").Value = dr("Friday").ToString()
                        dgvSchedule.Rows(rowIndex).Cells("Saturday").Value = dr("Saturday").ToString()
                        dgvSchedule.Rows(rowIndex).Cells("Sunday").Value = dr("Sunday").ToString()
                    End If
                End While
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading schedule: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    ' ---------------- BUTTON EVENTS ----------------
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If ReadOnlyMode Or dgvSchedule.SelectedCells.Count = 0 Then Exit Sub
        Dim cell = dgvSchedule.SelectedCells(0)
        If cell.ColumnIndex = 0 Then Exit Sub
        Dim desc = InputBox("Enter description:", "Add Schedule Item")
        If Not String.IsNullOrWhiteSpace(desc) Then
            cell.Value = desc
            SaveScheduleToDB()
        End If
    End Sub

    Private Sub btnEditItem_Click(sender As Object, e As EventArgs) Handles btnEditItem.Click
        If ReadOnlyMode Or dgvSchedule.SelectedCells.Count = 0 Then Exit Sub
        Dim cell = dgvSchedule.SelectedCells(0)
        If cell.ColumnIndex = 0 Then Exit Sub
        Dim currentVal = cell.Value?.ToString()
        If String.IsNullOrWhiteSpace(currentVal) Then Exit Sub
        Dim newVal = InputBox("Edit description:", "Edit Schedule Item", currentVal)
        If Not String.IsNullOrWhiteSpace(newVal) Then
            cell.Value = newVal
            SaveScheduleToDB()
        End If
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If ReadOnlyMode Or dgvSchedule.SelectedCells.Count = 0 Then Exit Sub
        Dim cell = dgvSchedule.SelectedCells(0)
        If cell.ColumnIndex = 0 Then Exit Sub
        If MessageBox.Show("Delete this item?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            cell.Value = ""
            SaveScheduleToDB()
        End If
    End Sub

    Private Sub dgvSchedule_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvSchedule.CellBeginEdit
        If e.ColumnIndex = 0 Or ReadOnlyMode Then e.Cancel = True
    End Sub

    ' ---------------- COMBOBOX EVENTS ----------------
    Private Sub coursecb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles coursecb.SelectedIndexChanged
        PopulateSections()
        LoadScheduleFromDB()
    End Sub

    Private Sub sectioncb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sectioncb.SelectedIndexChanged
        LoadScheduleFromDB()
    End Sub

    ' ---------------- HELPER ----------------
    Private Function GetRowIndexFromTime(time As String) As Integer
        For i As Integer = 0 To timeSlots.Length - 1
            If timeSlots(i) = time Then Return i
        Next
        Return -1
    End Function

    Private Sub SaveScheduleToDB()
        If ReadOnlyMode Then Exit Sub
        If coursecb.SelectedItem Is Nothing OrElse sectioncb.SelectedItem Is Nothing Then Exit Sub

        Dim courseID As String = CType(coursecb.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim section As String = sectioncb.SelectedItem.ToString()

        Try
            conn.Open()

            ' Loop through all time rows
            For i As Integer = 0 To dgvSchedule.Rows.Count - 1
                Dim rowTime As String = dgvSchedule.Rows(i).Cells("Time").Value?.ToString()
                If String.IsNullOrEmpty(rowTime) Then Continue For

                ' Check if schedule already exists
                Dim checkCmd As New MySqlCommand("
                SELECT ScheduleID FROM schedule 
                WHERE CourseID=@course AND Section=@section AND Time=@time 
                LIMIT 1", conn)

                checkCmd.Parameters.AddWithValue("@course", courseID)
                checkCmd.Parameters.AddWithValue("@section", section)
                checkCmd.Parameters.AddWithValue("@time", rowTime)

                Dim schedIDObj = checkCmd.ExecuteScalar()

                If schedIDObj Is Nothing Then
                    ' INSERT
                    Dim insertCmd As New MySqlCommand("
                    INSERT INTO schedule
                        (CourseID, Section, Time, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday)
                    VALUES
                        (@course, @section, @time, @mon, @tue, @wed, @thu, @fri, @sat, @sun)", conn)

                    insertCmd.Parameters.AddWithValue("@course", courseID)
                    insertCmd.Parameters.AddWithValue("@section", section)
                    insertCmd.Parameters.AddWithValue("@time", rowTime)
                    insertCmd.Parameters.AddWithValue("@mon", dgvSchedule.Rows(i).Cells("Monday").Value?.ToString())
                    insertCmd.Parameters.AddWithValue("@tue", dgvSchedule.Rows(i).Cells("Tuesday").Value?.ToString())
                    insertCmd.Parameters.AddWithValue("@wed", dgvSchedule.Rows(i).Cells("Wednesday").Value?.ToString())
                    insertCmd.Parameters.AddWithValue("@thu", dgvSchedule.Rows(i).Cells("Thursday").Value?.ToString())
                    insertCmd.Parameters.AddWithValue("@fri", dgvSchedule.Rows(i).Cells("Friday").Value?.ToString())
                    insertCmd.Parameters.AddWithValue("@sat", dgvSchedule.Rows(i).Cells("Saturday").Value?.ToString())
                    insertCmd.Parameters.AddWithValue("@sun", dgvSchedule.Rows(i).Cells("Sunday").Value?.ToString())

                    insertCmd.ExecuteNonQuery()

                Else
                    ' UPDATE
                    Dim updateCmd As New MySqlCommand("
                    UPDATE schedule SET
                        Monday=@mon,
                        Tuesday=@tue,
                        Wednesday=@wed,
                        Thursday=@thu,
                        Friday=@fri,
                        Saturday=@sat,
                        Sunday=@sun
                    WHERE ScheduleID=@id", conn)

                    updateCmd.Parameters.AddWithValue("@id", schedIDObj)
                    updateCmd.Parameters.AddWithValue("@mon", dgvSchedule.Rows(i).Cells("Monday").Value?.ToString())
                    updateCmd.Parameters.AddWithValue("@tue", dgvSchedule.Rows(i).Cells("Tuesday").Value?.ToString())
                    updateCmd.Parameters.AddWithValue("@wed", dgvSchedule.Rows(i).Cells("Wednesday").Value?.ToString())
                    updateCmd.Parameters.AddWithValue("@thu", dgvSchedule.Rows(i).Cells("Thursday").Value?.ToString())
                    updateCmd.Parameters.AddWithValue("@fri", dgvSchedule.Rows(i).Cells("Friday").Value?.ToString())
                    updateCmd.Parameters.AddWithValue("@sat", dgvSchedule.Rows(i).Cells("Saturday").Value?.ToString())
                    updateCmd.Parameters.AddWithValue("@sun", dgvSchedule.Rows(i).Cells("Sunday").Value?.ToString())

                    updateCmd.ExecuteNonQuery()
                End If
            Next

            MessageBox.Show("Schedule saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error saving schedule: " & ex.Message)

        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub SetComboBoxSelection(cb As ComboBox, value As String)
        For i As Integer = 0 To cb.Items.Count - 1
            Dim item = cb.Items(i)
            If TypeOf item Is KeyValuePair(Of String, String) Then
                If CType(item, KeyValuePair(Of String, String)).Key = value Then
                    cb.SelectedIndex = i
                    Exit For
                End If
            ElseIf TypeOf item Is String Then
                If item.ToString() = value Then
                    cb.SelectedIndex = i
                    Exit For
                End If
            End If
        Next
    End Sub

End Class
