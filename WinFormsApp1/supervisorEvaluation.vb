Imports System.Reflection
Imports MySql.Data.MySqlClient

Public Class supervisorEvaluation

    Public Property SuperID As String
    Public Property SelectedStudentID As String

    ' =====================================================
    ' FORM LOAD
    ' =====================================================
    Private Sub supervisorEvaluation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupForm()
        LoadAndDisplayEvaluations()
        ConfigureGrid()
    End Sub

    ' =====================================================
    ' FORM SETTINGS
    ' =====================================================
    Private Sub SetupForm()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    ' =====================================================
    ' DATA LOADING + PROCESSING
    ' =====================================================
    Private Sub LoadAndDisplayEvaluations()
        Dim dt As DataTable = GetAllStudentEvaluations()

        AddFullNameColumn(dt)
        ComputeAllTotals(dt)

        evalDGV.DataSource = dt
    End Sub

    Private Sub AddFullNameColumn(dt As DataTable)
        If Not dt.Columns.Contains("FullName") Then
            dt.Columns.Add("FullName", GetType(String))
        End If

        For Each row As DataRow In dt.Rows
            row("FullName") = $"{row("StudentLastName")}, {row("StudentFirstName")} {row("StudentMiddleName")} {row("Suffix")}".Trim()
        Next
    End Sub

    Private Sub ComputeAllTotals(dt As DataTable)
        For Each row As DataRow In dt.Rows
            Dim total As Double = 0

            For i As Integer = 1 To 10
                total += If(IsDBNull(row($"Question{i}")), 0, CDbl(row($"Question{i}")))
            Next

            row("TotalPoints") = total
            row("Rating") = GetRating(total)
        Next
    End Sub

    ' =====================================================
    ' GRID CONFIGURATION
    ' =====================================================
    Private Sub ConfigureGrid()

        ' Move FullName next to StudentID
        If evalDGV.Columns.Contains("FullName") Then
            evalDGV.Columns("FullName").DisplayIndex = evalDGV.Columns("StudentID").DisplayIndex + 1
            evalDGV.Columns("FullName").HeaderText = "Student Name"
        End If

        ' Rename Q1–Q10
        For i As Integer = 1 To 10
            Dim col = $"Question{i}"
            If evalDGV.Columns.Contains(col) Then
                evalDGV.Columns(col).HeaderText = $"Q{i}"
            End If
        Next

        ' Hide unused columns
        Dim hiddenCols = {"StudentLastName", "StudentFirstName", "StudentMiddleName", "Suffix"}
        For Each col In hiddenCols
            If evalDGV.Columns.Contains(col) Then evalDGV.Columns(col).Visible = False
        Next

        ' Column sizing
        Dim sizes As New Dictionary(Of String, Integer) From {
            {"StudentID", 50}, {"FullName", 140},
            {"Program", 220}, {"Department", 140}, {"Section", 45}
        }

        For i As Integer = 1 To 10
            sizes.Add($"Question{i}", 30)
        Next

        sizes.Add("TotalPoints", 65)
        sizes.Add("Rating", 60)

        For Each col In sizes
            If evalDGV.Columns.Contains(col.Key) Then
                evalDGV.Columns(col.Key).FillWeight = col.Value
            End If
        Next

        ' Make only Q1–Q10 editable
        For Each col As DataGridViewColumn In evalDGV.Columns
            col.ReadOnly = True
        Next

        For i As Integer = 1 To 10
            Dim q = $"Question{i}"
            If evalDGV.Columns.Contains(q) Then evalDGV.Columns(q).ReadOnly = False
        Next

        ' Misc settings
        evalDGV.AllowUserToResizeColumns = False
        evalDGV.AllowUserToResizeRows = False
        evalDGV.RowHeadersVisible = False
        evalDGV.ClearSelection()
    End Sub

    ' =====================================================
    ' RATING
    ' =====================================================
    Private Function GetRating(totalPoints As Double) As String
        Select Case totalPoints
            Case 45 To 50 : Return "Outstanding (O)"
            Case 40 To 44 : Return "Very Satisfactory (VS)"
            Case 30 To 39 : Return "Satisfactory (S)"
            Case 20 To 29 : Return "Needs Improvement (NI)"
            Case 10 To 19 : Return "Unacceptable (U)"
            Case Else : Return "N/A"
        End Select
    End Function

    ' =====================================================
    ' SAVE TO DATABASE
    ' =====================================================
    Private Sub SaveEvaluationsToDatabase()
        Try
            Using conn As New MySqlConnection(connectdb.connstring)
                conn.Open()

                For Each row As DataGridViewRow In evalDGV.Rows
                    If row.IsNewRow Then Continue For

                    Dim studentID As String = row.Cells("StudentID").Value.ToString()
                    Dim updateList As New List(Of String)
                    Dim paramList As New List(Of MySqlParameter)

                    ' Add Q1–Q10
                    For i As Integer = 1 To 10
                        Dim colName = $"Question{i}"
                        Dim value = If(row.Cells(colName).Value, DBNull.Value)
                        updateList.Add($"{colName} = @{colName}")
                        paramList.Add(New MySqlParameter($"@{colName}", value))
                    Next

                    ' Add total, rating, and supervisor
                    Dim total = CDbl(row.Cells("TotalPoints").Value)
                    Dim rating = row.Cells("Rating").Value.ToString()

                    updateList.Add("TotalPoints = @TotalPoints")
                    updateList.Add("Rating = @Rating")
                    updateList.Add("SupervisorID = @SupervisorID") ' Add SupervisorID to update list

                    paramList.Add(New MySqlParameter("@TotalPoints", total))
                    paramList.Add(New MySqlParameter("@Rating", rating))
                    paramList.Add(New MySqlParameter("@SupervisorID", SuperID)) ' Ensure SuperID is set

                    ' Final query with ON DUPLICATE KEY UPDATE
                    Dim query As String =
                    "INSERT INTO studentevaluations " &
                    "(StudentID, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, TotalPoints, Rating, SupervisorID) " &
                    "VALUES (@StudentID, @Question1, @Question2, @Question3, @Question4, @Question5, @Question6, @Question7, @Question8, @Question9, @Question10, @TotalPoints, @Rating, @SupervisorID) " &
                    "ON DUPLICATE KEY UPDATE " & String.Join(", ", updateList)

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@StudentID", studentID)
                        cmd.Parameters.AddRange(paramList.ToArray())
                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using

            MessageBox.Show("Evaluations saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error saving evaluations: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        SaveEvaluationsToDatabase()
    End Sub

    ' =====================================================
    ' LOAD FROM DATABASE
    ' =====================================================
    Private Function GetAllStudentEvaluations() As DataTable
        Dim dt As New DataTable()

        ' Build table schema
        dt.Columns.Add("StudentID", GetType(String))
        dt.Columns.Add("StudentLastName", GetType(String))
        dt.Columns.Add("StudentFirstName", GetType(String))
        dt.Columns.Add("StudentMiddleName", GetType(String))
        dt.Columns.Add("Suffix", GetType(String))
        dt.Columns.Add("Program", GetType(String))
        dt.Columns.Add("Department", GetType(String))
        dt.Columns.Add("Section", GetType(String))

        For i As Integer = 1 To 10
            dt.Columns.Add($"Question{i}", GetType(Double))
        Next

        dt.Columns.Add("TotalPoints", GetType(Double))
        dt.Columns.Add("Rating", GetType(String))

        Try
            Using conn As New MySqlConnection(connectdb.connstring)
                conn.Open()

                Dim query As String =
                    "SELECT s.StudentID, s.StudentLastName, s.StudentFirstName, s.StudentMiddleName, s.Suffix, " &
                    "c.CourseName AS Program, d.DeptName AS Department, s.Section, " &
                    "se.Question1, se.Question2, se.Question3, se.Question4, se.Question5, " &
                    "se.Question6, se.Question7, se.Question8, se.Question9, se.Question10, " &
                    "se.TotalPoints, se.Rating " &
                    "FROM student s " &
                    "INNER JOIN course c ON s.CourseID = c.CourseID " &
                    "INNER JOIN department d ON c.DepartmentID = d.DepartmentID " &
                    "LEFT JOIN studentevaluations se ON s.StudentID = se.StudentID " &
                    "LEFT JOIN supervisor sup ON se.SupervisorID = sup.SupervisorID " &
                    "ORDER BY s.StudentID ASC"

                Using cmd As New MySqlCommand(query, conn)
                    Using rd As MySqlDataReader = cmd.ExecuteReader()
                        While rd.Read()
                            Dim row = dt.NewRow()

                            row("StudentID") = rd("StudentID")
                            row("StudentLastName") = rd("StudentLastName")
                            row("StudentFirstName") = rd("StudentFirstName")
                            row("StudentMiddleName") = rd("StudentMiddleName")
                            row("Suffix") = rd("Suffix")
                            row("Program") = rd("Program")
                            row("Department") = rd("Department")
                            row("Section") = rd("Section")

                            For i As Integer = 1 To 10
                                row($"Question{i}") = If(IsDBNull(rd($"Question{i}")), 0, rd($"Question{i}"))
                            Next

                            dt.Rows.Add(row)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading evaluations: " & ex.Message)
        End Try

        Return dt
    End Function

    Private Sub evalDGV_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles evalDGV.CellEndEdit
        If e.RowIndex < 0 Then Exit Sub

        Dim colName As String = evalDGV.Columns(e.ColumnIndex).Name

        ' Only trigger when editing Q1–Q10
        If Not colName.StartsWith("Question") Then Exit Sub

        Dim row As DataGridViewRow = evalDGV.Rows(e.RowIndex)

        ' Recompute total
        Dim total As Double = 0
        For i As Integer = 1 To 10
            Dim val = row.Cells("Question" & i).Value
            total += If(IsDBNull(val) OrElse val Is Nothing, 0, CDbl(val))
        Next

        row.Cells("TotalPoints").Value = total
        row.Cells("Rating").Value = GetRating(total)
    End Sub


    ' =====================================================
    ' LOGOUT / RETURN
    ' =====================================================
    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        If MessageBox.Show("Are you sure you want to Return?", "Return", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim returnForm = Application.OpenForms.OfType(Of supervisorDashboard)().FirstOrDefault()
            If returnForm IsNot Nothing Then returnForm.Show()
            Me.Close()
        End If
    End Sub

End Class
