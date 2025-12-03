Imports MySql.Data.MySqlClient
Module connectdb
    Public connstring As String =
        "
        server=localhost;
        userid=root;
        password=;
        database=internship_db;
        "

    Public Function GetAllStudents() As DataTable
        Dim dt As New DataTable()

        Try
            Using conn As New MySqlConnection(connstring)
                conn.Open()

                Dim query As String =
                    "SELECT s.StudentID, s.StudentLastName, s.StudentFirstName, s.StudentMiddleName, s.Suffix,
                            s.Gender, c.CourseName AS Program, d.DeptName AS Department, s.Section
                    FROM student s
                    INNER JOIN course c ON s.CourseID = c.CourseID
                    INNER JOIN department d ON c.DepartmentID = d.DepartmentID
                    ORDER BY s.StudentID ASC"

                Using adapter As New MySqlDataAdapter(query, conn)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading students: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Function GetFilteredStudents(section As String, program As String, department As String, keyword As String) As DataTable
        Dim dt As New DataTable()

        Try
            Using connectdb As New MySqlConnection(connstring)
                connectdb.Open()

                Dim query As String =
                "SELECT s.StudentID, s.StudentLastName, s.StudentFirstName, s.StudentMiddleName, s.Suffix, " &
                "s.Gender, c.CourseName AS Program, d.DeptName AS Department, s.Section " &
                "FROM student s " &
                "INNER JOIN course c ON s.CourseID = c.CourseID " &
                "INNER JOIN department d ON c.DepartmentID = d.DepartmentID " &
                "WHERE 1=1 "

                If section <> "All" AndAlso section <> "" Then
                    query &= " AND s.Section = @section "
                End If

                If program <> "All" AndAlso program <> "" Then
                    query &= " AND c.CourseName = @program "
                End If

                If department <> "All" AndAlso department <> "" Then
                    query &= " AND d.DeptName = @department "
                End If

                If keyword.Trim() <> "" Then
                    query &= " AND (s.StudentID LIKE @keyword OR " &
                         "s.StudentLastName LIKE @keyword OR " &
                         "s.StudentFirstName LIKE @keyword OR " &
                         "s.StudentMiddleName LIKE @keyword) "
                End If

                query &= " ORDER BY s.StudentID ASC"

                Using cmd As New MySqlCommand(query, connectdb)

                    If section <> "All" AndAlso section <> "" Then cmd.Parameters.AddWithValue("@section", section)
                    If program <> "All" AndAlso program <> "" Then cmd.Parameters.AddWithValue("@program", program)
                    If department <> "All" AndAlso department <> "" Then cmd.Parameters.AddWithValue("@department", department)
                    If keyword.Trim() <> "" Then cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error fetching filtered students: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Function GetAllStudentGrades() As DataTable
        Dim dt As New DataTable()

        Try
            Using conn As New MySqlConnection(connstring)
                conn.Open()

                Dim query As String =
            "SELECT s.StudentID, 
                    s.StudentFirstName, 
                    s.StudentMiddleName, 
                    s.StudentLastName, 
                    s.Suffix, 
                    c.CourseName AS Program, 
                    d.DeptName AS Department, 
                    s.Section,
                    COALESCE(sg.Quiz1, '') AS Quiz1,
                    COALESCE(sg.Quiz2, '') AS Quiz2,
                    COALESCE(sg.Quiz3, '') AS Quiz3,
                    COALESCE(sg.Seatwork1, '') AS Seatwork1,
                    COALESCE(sg.Seatwork2, '') AS Seatwork2,
                    COALESCE(sg.Seatwork3, '') AS Seatwork3,
                    COALESCE(sg.GWA, '') AS GWA,
                    COALESCE(sg.Remarks, '') AS Remarks
             FROM student s
             LEFT JOIN studentgrades sg ON s.StudentID = sg.StudentID
             INNER JOIN course c ON s.CourseID = c.CourseID
             INNER JOIN department d ON c.DepartmentID = d.DepartmentID
             ORDER BY s.StudentID ASC"

                Using adapter As New MySqlDataAdapter(query, conn)
                    adapter.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading student grades: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Function GetFilteredStudentsGrade(section As String, program As String, department As String, keyword As String) As DataTable
        Dim dt As New DataTable()


        Try
            Using connectdb As New MySqlConnection(connstring)
                connectdb.Open()

                Dim query As String =
                    "SELECT s.StudentID, s.StudentLastName, s.StudentFirstName, s.StudentMiddleName, s.Suffix, " &
                    "c.CourseName AS Program, d.DeptName AS Department, s.Section, " &
                    "g.Quiz1, g.Quiz2, g.Quiz3, g.Seatwork1, g.Seatwork2, g.Seatwork3, g.GWA, g.Remarks " &
                    "FROM student s " &
                    "INNER JOIN course c ON s.CourseID = c.CourseID " &
                    "INNER JOIN department d ON c.DepartmentID = d.DepartmentID " &
                    "LEFT JOIN studentgrades g ON s.StudentID = g.StudentID " &
                    "WHERE 1=1 "

                If section <> "All" AndAlso section <> "" Then
                    query &= " AND s.Section = @section "
                End If

                If program <> "All" AndAlso program <> "" Then
                    query &= " AND c.CourseName = @program "
                End If

                If department <> "All" AndAlso department <> "" Then
                    query &= " AND d.DeptName = @department "
                End If

                If keyword.Trim() <> "" Then
                    query &= " AND (s.StudentID LIKE @keyword OR " &
                     "s.StudentLastName LIKE @keyword OR " &
                     "s.StudentFirstName LIKE @keyword OR " &
                     "s.StudentMiddleName LIKE @keyword) "
                End If

                query &= " ORDER BY s.StudentID ASC"

                Using cmd As New MySqlCommand(query, connectdb)
                    If section <> "All" AndAlso section <> "" Then cmd.Parameters.AddWithValue("@section", section)
                    If program <> "All" AndAlso program <> "" Then cmd.Parameters.AddWithValue("@program", program)
                    If department <> "All" AndAlso department <> "" Then cmd.Parameters.AddWithValue("@department", department)
                    If keyword.Trim() <> "" Then cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            If Not dt.Columns.Contains("FullName") Then
                dt.Columns.Add("FullName", GetType(String))
            End If

            For Each row As DataRow In dt.Rows
                Dim lastName As String = If(row("StudentLastName") Is DBNull.Value, "", row("StudentLastName").ToString())
                Dim firstName As String = If(row("StudentFirstName") Is DBNull.Value, "", row("StudentFirstName").ToString())
                Dim middleName As String = If(row("StudentMiddleName") Is DBNull.Value, "", row("StudentMiddleName").ToString())
                Dim suffix As String = If(row("Suffix") Is DBNull.Value, "", row("Suffix").ToString())

                row("FullName") = $"{lastName}, {firstName} {middleName} {suffix}".Trim()
            Next

        Catch ex As Exception
            MessageBox.Show("Error fetching filtered students: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Function GenerateStudentID() As String
        Dim yearPrefix As String = (DateTime.Now.Year Mod 100).ToString("D2")
        Dim lastID As Integer = 0

        Try
            Using conn As New MySqlConnection(connstring)
                conn.Open()
                Using cmd As New MySqlCommand("
                    SELECT MAX(CAST(SUBSTRING(StudentID, 4) AS UNSIGNED)) 
                    FROM student 
                    WHERE StudentID LIKE @YearPrefix", conn)
                    cmd.Parameters.AddWithValue("@YearPrefix", yearPrefix & "-%")
                    Dim result = cmd.ExecuteScalar()
                    If Not IsDBNull(result) Then lastID = Convert.ToInt32(result)
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error while generating Student ID: " & ex.Message)
        End Try

        Return yearPrefix & "-" & (lastID + 1).ToString("D5")
    End Function




    ' --- Get All Interns ---
    Public Function GetAllInterns() As DataTable
    Dim dt As New DataTable()
    Try
        Using conn As New MySqlConnection(connstring)
            conn.Open()
                Dim query As String =
"SELECT
s.StudentID,
s.StudentLastName,
s.StudentFirstName,
s.StudentMiddleName,
s.Suffix,
s.Gender,
c.CourseName AS Program,
d.DeptName AS Department,
s.Section,
co.CompanyID,
co.CompanyName,
i.InternshipID,
i.StartDate AS DateStart,
i.EndDate AS DateEnd,
i.Status
FROM student s
LEFT JOIN internships i ON i.StudentID = s.StudentID
INNER JOIN course c ON s.CourseID = c.CourseID
INNER JOIN department d ON c.DepartmentID = d.DepartmentID
LEFT JOIN company co ON i.CompanyID = co.CompanyID
ORDER BY s.StudentID ASC"


                Using adapter As New MySqlDataAdapter(query, conn)
                adapter.Fill(dt)
            End Using
        End Using
    Catch ex As Exception
        MessageBox.Show("Error loading interns: " & ex.Message)
    End Try
    Return dt
End Function

' --- Get Filtered Interns ---
Public Function GetFilteredInterns(section As String, program As String, department As String, keyword As String) As DataTable
    Dim dt As New DataTable()
    Try
        Using conn As New MySqlConnection(connstring)
            conn.Open()
                Dim query As String =
"SELECT
s.StudentID,
s.StudentLastName,
s.StudentFirstName,
s.StudentMiddleName,
s.Suffix,
s.Gender,
c.CourseName AS Program,
d.DeptName AS Department,
s.Section,
co.CompanyID,
co.CompanyName,
i.InternshipID,
i.StartDate AS DateStart,
i.EndDate AS DateEnd,
i.Status
FROM student s
LEFT JOIN internships i ON i.StudentID = s.StudentID
INNER JOIN course c ON s.CourseID = c.CourseID
INNER JOIN department d ON c.DepartmentID = d.DepartmentID
LEFT JOIN company co ON i.CompanyID = co.CompanyID
WHERE 1=1"


                ' Filters
                If section <> "All" AndAlso section <> "" Then query &= " AND s.Section = @section"
            If program <> "All" AndAlso program <> "" Then query &= " AND c.CourseName = @program"
            If department <> "All" AndAlso department <> "" Then query &= " AND d.DeptName = @department"
            If Not String.IsNullOrWhiteSpace(keyword) Then
                query &= " AND (s.StudentID LIKE @keyword OR
                                s.StudentLastName LIKE @keyword OR
                                s.StudentFirstName LIKE @keyword OR
                                s.StudentMiddleName LIKE @keyword OR
                                co.CompanyName LIKE @keyword OR
                                i.InternshipID LIKE @keyword)"
            End If

            query &= " ORDER BY s.StudentID ASC"

            Using cmd As New MySqlCommand(query, conn)
                If section <> "All" AndAlso section <> "" Then cmd.Parameters.AddWithValue("@section", section)
                If program <> "All" AndAlso program <> "" Then cmd.Parameters.AddWithValue("@program", program)
                If department <> "All" AndAlso department <> "" Then cmd.Parameters.AddWithValue("@department", department)
                If Not String.IsNullOrWhiteSpace(keyword) Then cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
    Catch ex As Exception
        MessageBox.Show("Error fetching filtered interns: " & ex.Message)
    End Try
    Return dt
End Function

' --- Get Companies ---
Public Function GetCompanies() As DataTable
    Dim dt As New DataTable()
    Try
        Using conn As New MySqlConnection(connstring)
            conn.Open()
            Dim query As String = "SELECT CompanyID, CompanyName FROM company ORDER BY CompanyName ASC"
            Using adapter As New MySqlDataAdapter(query, conn)
                adapter.Fill(dt)
            End Using
        End Using
    Catch ex As Exception
        MessageBox.Show("Error loading companies: " & ex.Message)
    End Try
    Return dt
End Function


End Module
