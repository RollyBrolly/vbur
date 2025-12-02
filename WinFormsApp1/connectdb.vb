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
End Module
