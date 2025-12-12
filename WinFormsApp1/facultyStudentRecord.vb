Imports System.Data
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Public Class facultyStudentRecord
    Public Property FacultyID As String
    Private Const SMTP_EMAIL As String = "pohlovesyou@gmail.com"
    Private Const SMTP_APP_PASSWORD As String = "wniyhuldxsxahtkt"

    Private Sub facultyStudentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        LoadFilter()
        studDGV.DataSource = GetAllStudents()
        studDGV.Columns("StudentID").FillWeight = 40
        studDGV.Columns("StudentLastName").FillWeight = 50
        studDGV.Columns("StudentFirstName").FillWeight = 50
        studDGV.Columns("StudentMiddleName").FillWeight = 50
        studDGV.Columns("Suffix").FillWeight = 30
        studDGV.Columns("Gender").FillWeight = 30
        studDGV.Columns("Program").FillWeight = 120
        studDGV.Columns("Department").FillWeight = 100
        studDGV.Columns("Section").FillWeight = 30

        studDGV.Columns("StudentID").HeaderText = "Student ID"
        studDGV.Columns("StudentLastName").HeaderText = "Last Name"
        studDGV.Columns("StudentFirstName").HeaderText = "First Name"
        studDGV.Columns("StudentMiddleName").HeaderText = "Middle Name"

        studDGV.AllowUserToResizeColumns = False
        studDGV.RowHeadersVisible = False
        studDGV.AllowUserToResizeRows = False
        studDGV.ClearSelection()

        containerpnl.Visible = False
    End Sub

    Private Sub ApplyFilters()
        Dim sectionValue As String = If(sectionfltr.SelectedIndex >= 0, sectionfltr.SelectedItem.ToString(), "All")
        Dim programValue As String = If(programfltr.SelectedIndex >= 0, programfltr.SelectedItem.ToString(), "All")
        Dim deptValue As String = If(deptfltr.SelectedIndex >= 0, deptfltr.SelectedItem.ToString(), "All")
        Dim keyword As String = searchtxt.Text.Trim()

        studDGV.DataSource = GetFilteredStudents(sectionValue, programValue, deptValue, keyword)

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

    Private Sub searchtxt_TextChanged(sender As Object, e As EventArgs) Handles searchtxt.TextChanged
        ApplyFilters()
    End Sub

    Private Sub deptfltr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles deptfltr.SelectedIndexChanged
        ApplyFilters()
    End Sub

    Private Sub programfltr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles programfltr.SelectedIndexChanged
        ApplyFilters()
    End Sub

    Private Sub sectionfltr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sectionfltr.SelectedIndexChanged
        ApplyFilters()
    End Sub

    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        If MessageBox.Show("Are you sure you want to Return?", "Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim facultyForm = Application.OpenForms.OfType(Of facultyDashboard)().FirstOrDefault()
            If facultyForm IsNot Nothing Then
                facultyForm.Show()
            End If

            Me.Close()
        End If
    End Sub

    Private Sub gradebtn_Click(sender As Object, e As EventArgs) Handles gradebtn.Click
        If studDGV.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a student to grade.", "No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim studentGrades As New facultyGradeStudents()
        studentGrades.FacultyID = Me.FacultyID
        studentGrades.SelectedStudentID = studDGV.SelectedRows(0).Cells("StudentID").Value.ToString()
        studentGrades.Show()
        Me.Close()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If studDGV.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a student to delete.", "No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim studentID As String = studDGV.SelectedRows(0).Cells("StudentID").Value.ToString()

        If MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Try
            Using conn As New MySqlConnection(connstring)
                conn.Open()
                Using transaction = conn.BeginTransaction()

                    ' 1. Get all user accounts of the student
                    Dim userIDs As New List(Of Integer)
                    Using cmd As New MySqlCommand("SELECT UserID FROM useraccounts WHERE StudentID = @id", conn, transaction)
                        cmd.Parameters.AddWithValue("@id", studentID)
                        Using reader = cmd.ExecuteReader()
                            While reader.Read()
                                userIDs.Add(Convert.ToInt32(reader("UserID")))
                            End While
                        End Using
                    End Using

                    ' 2. Delete from studentgrades first (fixes your FK error)
                    Using cmd As New MySqlCommand("DELETE FROM studentgrades WHERE StudentID = @id", conn, transaction)
                        cmd.Parameters.AddWithValue("@id", studentID)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' 3. Delete useraccounts
                    Using cmd As New MySqlCommand("DELETE FROM useraccounts WHERE StudentID = @id", conn, transaction)
                        cmd.Parameters.AddWithValue("@id", studentID)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' 4. Delete users table
                    For Each uid In userIDs
                        Using cmd As New MySqlCommand("DELETE FROM users WHERE UserID = @uid", conn, transaction)
                            cmd.Parameters.AddWithValue("@uid", uid)
                            cmd.ExecuteNonQuery()
                        End Using
                    Next

                    ' 5. Finally, delete student
                    Using cmd As New MySqlCommand("DELETE FROM student WHERE StudentID = @id", conn, transaction)
                        cmd.Parameters.AddWithValue("@id", studentID)
                        cmd.ExecuteNonQuery()
                    End Using

                    transaction.Commit()
                End Using
            End Using

            MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ApplyFilters()

        Catch ex As Exception
            MessageBox.Show("Error deleting student: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub studDGV_SelectionChanged(sender As Object, e As EventArgs) Handles studDGV.SelectionChanged
        For Each row As DataGridViewRow In studDGV.Rows
            row.DefaultCellStyle.BackColor = Color.White
            row.DefaultCellStyle.ForeColor = Color.Black
        Next

        For Each row As DataGridViewRow In studDGV.SelectedRows
            row.DefaultCellStyle.BackColor = Color.LightBlue
            row.DefaultCellStyle.ForeColor = Color.Black
        Next
    End Sub

    Private selectedCSVPath As String = ""
    Private Sub browsebtn_Click(sender As Object, e As EventArgs) Handles browsebtn.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "CSV Files (*.csv)|*.csv"

        If ofd.ShowDialog() = DialogResult.OK Then
            selectedCSVPath = ofd.FileName
            MessageBox.Show("File selected: " & selectedCSVPath, "CSV Selected")
        End If
    End Sub

    Private Sub previewbtn_Click(sender As Object, e As EventArgs) Handles previewbtn.Click
        If String.IsNullOrEmpty(selectedCSVPath) Then
            MessageBox.Show("Please select a CSV file first.", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim dt As New DataTable()
            Dim lines = IO.File.ReadAllLines(selectedCSVPath)

            If lines.Length = 0 Then
                MessageBox.Show("CSV file is empty.", "Empty File", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim columns = lines(0).Split(","c)
            For Each col As String In columns
                dt.Columns.Add(col.Trim())
            Next

            For i As Integer = 1 To lines.Length - 1
                Dim rowData = lines(i).Split(","c)

                While rowData.Length < dt.Columns.Count
                    ReDim Preserve rowData(dt.Columns.Count - 1)
                End While
                dt.Rows.Add(rowData)
            Next

            previewDGV.DataSource = dt

            previewDGV.Columns("StudentID").FillWeight = 40
            previewDGV.Columns("StudentFirstName").FillWeight = 50
            previewDGV.Columns("StudentMiddleName").FillWeight = 50
            previewDGV.Columns("StudentLastName").FillWeight = 50
            previewDGV.Columns("Suffix").FillWeight = 30
            previewDGV.Columns("Gender").FillWeight = 30
            previewDGV.Columns("Program").FillWeight = 120
            previewDGV.Columns("Department").FillWeight = 100
            previewDGV.Columns("Section").FillWeight = 30
            previewDGV.Columns("StudentEmail").FillWeight = 150
            previewDGV.Columns("StudentContactNo").FillWeight = 80

            previewDGV.AllowUserToResizeColumns = False
            previewDGV.RowHeadersVisible = False
            previewDGV.AllowUserToResizeRows = False
            previewDGV.ClearSelection()

            containerpnl.Visible = True
        Catch ex As Exception
            MessageBox.Show("Error previewing CSV: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub importbtn_Click(sender As Object, e As EventArgs) Handles importbtn.Click
        If previewDGV.Rows.Count = 0 Then
            MessageBox.Show("There is no data to import.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim dlg As New EmailProgressDialog(Me)
        dlg.Show()

        Dim rowsToProcess = previewDGV.Rows.Cast(Of DataGridViewRow).Where(Function(r) Not r.IsNewRow).ToList()
        Dim emailsToSend As New List(Of (fullname As String, sid As String, username As String, password As String, email As String))

        Try
            Using conn As New MySqlConnection(connectdb.connstring)
                conn.Open()
                Using transaction As MySqlTransaction = conn.BeginTransaction()

                    For i As Integer = 0 To rowsToProcess.Count - 1
                        Dim row = rowsToProcess(i)

                        ' --- Student Info ---
                        Dim sid As String
                        Dim fname = StrConv(row.Cells("StudentFirstName").Value?.ToString().Trim(), VbStrConv.ProperCase)
                        Dim mname = StrConv(row.Cells("StudentMiddleName").Value?.ToString().Trim(), VbStrConv.ProperCase)
                        Dim lname = StrConv(row.Cells("StudentLastName").Value?.ToString().Trim(), VbStrConv.ProperCase)
                        Dim suffix = StrConv(row.Cells("Suffix").Value?.ToString().Trim(), VbStrConv.ProperCase)
                        Dim gender = row.Cells("Gender").Value?.ToString().Trim()
                        Dim course = row.Cells("Program").Value?.ToString().Trim()
                        Dim dept = row.Cells("Department").Value?.ToString().Trim()
                        Dim section = row.Cells("Section").Value?.ToString().Trim()
                        Dim email = row.Cells("StudentEmail").Value?.ToString().Trim()
                        Dim contact = row.Cells("StudentContactNo").Value?.ToString().Trim()

                        ' --- Validate Email ---
                        Dim isValid As Boolean = True
                        If String.IsNullOrWhiteSpace(email) Then
                            isValid = False
                        Else
                            Try
                                Dim addr As New System.Net.Mail.MailAddress(email)
                                Dim allowedDomains As String() = {"gmail.com", "yahoo.com", "outlook.com", "plpasig.edu.ph"}
                                Dim domain As String = email.Split("@"c)(1).ToLower()
                                If Not allowedDomains.Contains(domain) Then isValid = False
                            Catch
                                isValid = False
                            End Try
                        End If

                        If Not isValid Then
                            dlg.UpdateProgress(CInt((i + 1) / rowsToProcess.Count * 100), $"Skipping invalid email: {email}")
                            Await Task.Delay(1)
                            Continue For
                        End If

                        ' --- Validate Required Fields ---
                        If String.IsNullOrEmpty(fname) OrElse String.IsNullOrEmpty(lname) OrElse
                       String.IsNullOrEmpty(contact) OrElse String.IsNullOrEmpty(section) OrElse
                       String.IsNullOrEmpty(course) OrElse String.IsNullOrEmpty(dept) Then

                            dlg.UpdateProgress(CInt((i + 1) / rowsToProcess.Count * 100), $"Skipping incomplete row ({i + 1}/{rowsToProcess.Count})")
                            Await Task.Delay(1)
                            Continue For
                        End If

                        ' --- Generate or Check StudentID ---
                        If String.IsNullOrEmpty(row.Cells("StudentID").Value?.ToString().Trim()) Then
                            sid = connectdb.GenerateStudentID()
                            row.Cells("StudentID").Value = sid
                        Else
                            sid = row.Cells("StudentID").Value.ToString().Trim()
                        End If

                        Dim checkID As New MySqlCommand("SELECT COUNT(*) FROM student WHERE StudentID = @sid", conn, transaction)
                        checkID.Parameters.AddWithValue("@sid", sid)
                        If Convert.ToInt32(checkID.ExecuteScalar()) > 0 Then
                            sid = connectdb.GenerateStudentID()
                            row.Cells("StudentID").Value = sid
                        End If

                        ' --- Validate Program & Department ---
                        Dim programCheck As New MySqlCommand("
                        SELECT COUNT(*)
                        FROM course c
                        INNER JOIN department d ON c.DepartmentID = d.DepartmentID
                        WHERE c.CourseName = @course AND d.DeptName = @dept", conn, transaction)
                        programCheck.Parameters.AddWithValue("@course", course)
                        programCheck.Parameters.AddWithValue("@dept", dept)
                        If Convert.ToInt32(programCheck.ExecuteScalar()) = 0 Then
                            dlg.UpdateProgress(0, $"Skipping invalid Program/Department at row {i + 1}.")
                            Continue For
                        End If

                        ' --- User Account ---
                        Dim username = sid.Replace("-", "")
                        Dim fullname = $"{fname} {mname} {lname}".Replace("  ", " ").Trim()
                        Dim initials = String.Concat(fullname.Split({" "c}, StringSplitOptions.RemoveEmptyEntries).Select(Function(n) n(0).ToString().ToUpper()))
                        Dim password = username & initials

                        ' --- Insert Student ---
                        Dim studentQuery As String = "
                        INSERT INTO student (StudentID, StudentFirstName, StudentMiddleName, StudentLastName, Suffix, Gender, CourseID, Section, StudentContactNo, StudentEmail)
                        SELECT @sid, @fname, @mname, @lname, @suffix, @gender, c.CourseID, @section, @contact, @email
                        FROM course c
                        INNER JOIN department d ON c.DepartmentID = d.DepartmentID
                        WHERE c.CourseName = @course AND d.DeptName = @dept"

                        Using cmd As New MySqlCommand(studentQuery, conn, transaction)
                            cmd.Parameters.AddWithValue("@sid", sid)
                            cmd.Parameters.AddWithValue("@fname", fname)
                            cmd.Parameters.AddWithValue("@mname", If(String.IsNullOrEmpty(mname), DBNull.Value, mname))
                            cmd.Parameters.AddWithValue("@lname", lname)
                            cmd.Parameters.AddWithValue("@suffix", If(String.IsNullOrEmpty(suffix), DBNull.Value, suffix))
                            cmd.Parameters.AddWithValue("@gender", gender)
                            cmd.Parameters.AddWithValue("@course", course)
                            cmd.Parameters.AddWithValue("@dept", dept)
                            cmd.Parameters.AddWithValue("@section", section)
                            cmd.Parameters.AddWithValue("@contact", If(String.IsNullOrEmpty(contact), DBNull.Value, contact))
                            cmd.Parameters.AddWithValue("@email", email)
                            cmd.ExecuteNonQuery()
                        End Using

                        ' --- Read Evaluation Columns from CSV ---
                        Dim q1 = If(row.Cells("C1: Attends/Starts Promptly").Value IsNot Nothing, Convert.ToInt32(row.Cells("C1: Attends/Starts Promptly").Value), 0)
                        Dim q2 = If(row.Cells("C2: Suitable Work Attire").Value IsNot Nothing, Convert.ToInt32(row.Cells("C2: Suitable Work Attire").Value), 0)
                        Dim q3 = If(row.Cells("C3: Expresses Ideas Well").Value IsNot Nothing, Convert.ToInt32(row.Cells("C3: Expresses Ideas Well").Value), 0)
                        Dim q4 = If(row.Cells("C4: Listens Attentively").Value IsNot Nothing, Convert.ToInt32(row.Cells("C4: Listens Attentively").Value), 0)
                        Dim q5 = If(row.Cells("C5: Displays Interest").Value IsNot Nothing, Convert.ToInt32(row.Cells("C5: Displays Interest").Value), 0)
                        Dim q6 = If(row.Cells("C6: Develops Variety of Skills").Value IsNot Nothing, Convert.ToInt32(row.Cells("C6: Develops Variety of Skills").Value), 0)
                        Dim q7 = If(row.Cells("C7: Orderly/Safe Workstation").Value IsNot Nothing, Convert.ToInt32(row.Cells("C7: Orderly/Safe Workstation").Value), 0)
                        Dim q8 = If(row.Cells("C8: Submits Reports Accurately").Value IsNot Nothing, Convert.ToInt32(row.Cells("C8: Submits Reports Accurately").Value), 0)
                        Dim q9 = If(row.Cells("C9: Knows Functions/Responsibilities").Value IsNot Nothing, Convert.ToInt32(row.Cells("C9: Knows Functions/Responsibilities").Value), 0)
                        Dim q10 = If(row.Cells("C10: Open to Growth/Development").Value IsNot Nothing, Convert.ToInt32(row.Cells("C10: Open to Growth/Development").Value), 0)
                        Dim totalPoints = If(row.Cells("Overall Score").Value IsNot Nothing, Convert.ToInt32(row.Cells("Overall Score").Value), 0)
                        Dim rating = If(row.Cells("Remarks").Value IsNot Nothing, row.Cells("Remarks").Value.ToString(), Nothing)

                        ' --- Insert Evaluation ---
                        Dim evalQuery As String = "
                        INSERT INTO studentevaluations 
                        (StudentID, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, TotalPoints, Rating)
                        VALUES (@sid, @q1, @q2, @q3, @q4, @q5, @q6, @q7, @q8, @q9, @q10, @total, @rating)"

                        Using cmdEval As New MySqlCommand(evalQuery, conn, transaction)
                            cmdEval.Parameters.AddWithValue("@sid", sid)
                            cmdEval.Parameters.AddWithValue("@q1", q1)
                            cmdEval.Parameters.AddWithValue("@q2", q2)
                            cmdEval.Parameters.AddWithValue("@q3", q3)
                            cmdEval.Parameters.AddWithValue("@q4", q4)
                            cmdEval.Parameters.AddWithValue("@q5", q5)
                            cmdEval.Parameters.AddWithValue("@q6", q6)
                            cmdEval.Parameters.AddWithValue("@q7", q7)
                            cmdEval.Parameters.AddWithValue("@q8", q8)
                            cmdEval.Parameters.AddWithValue("@q9", q9)
                            cmdEval.Parameters.AddWithValue("@q10", q10)
                            cmdEval.Parameters.AddWithValue("@total", totalPoints)
                            cmdEval.Parameters.AddWithValue("@rating", If(String.IsNullOrEmpty(rating), DBNull.Value, rating))
                            cmdEval.ExecuteNonQuery()
                        End Using

                        ' --- Create User Account ---
                        If Not CreateUserAccount(conn, transaction, username, password, "Student", sid, Nothing, Nothing) Then
                            transaction.Rollback()
                            MessageBox.Show($"Failed creating login for {fullname}. Import cancelled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If

                        emailsToSend.Add((fullname, sid, username, password, email))
                        dlg.UpdateProgress(CInt((i + 1) / rowsToProcess.Count * 100), $"Importing: {fullname} ({i + 1}/{rowsToProcess.Count})")
                        Await Task.Delay(1)
                    Next

                    transaction.Commit()
                End Using
            End Using

            ' --- Send Emails ---
            For i As Integer = 0 To emailsToSend.Count - 1
                Dim eInfo = emailsToSend(i)
                dlg.UpdateProgress(CInt((i + 1) / emailsToSend.Count * 100), $"Sending email to: {eInfo.fullname}")
                Await SendStudentEmail(eInfo.fullname, eInfo.sid, eInfo.username, eInfo.password, eInfo.email)
                Await Task.Delay(1)
            Next

            MessageBox.Show("Import complete! All emails sent.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            studDGV.DataSource = GetStudentsWithEvaluations() ' Show students + evaluations
            containerpnl.Visible = False

        Catch ex As Exception
            MessageBox.Show("Error importing CSV: " & ex.Message, "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dlg.Close()
        End Try
    End Sub


    Private Function GetStudentsWithEvaluations() As DataTable
        Dim dt As New DataTable()

        Try
            Using conn As New MySqlConnection(connectdb.connstring)
                conn.Open()

                Dim query As String = "
                SELECT s.StudentID,
                       s.StudentFirstName,
                       s.StudentMiddleName,
                       s.StudentLastName,
                       s.Suffix,
                       s.Gender,
                       s.StudentContactNo,
                       s.StudentEmail,
                       c.CourseName,
                       d.DeptName,
                       s.Section,
                       se.Question1,
                       se.Question2,
                       se.Question3,
                       se.Question4,
                       se.Question5,
                       se.Question6,
                       se.Question7,
                       se.Question8,
                       se.Question9,
                       se.Question10,
                       se.TotalPoints,
                       se.Rating
                FROM student s
                INNER JOIN course c ON s.CourseID = c.CourseID
                INNER JOIN department d ON c.DepartmentID = d.DepartmentID
                LEFT JOIN studentevaluations se ON s.StudentID = se.StudentID
                ORDER BY s.StudentLastName, s.StudentFirstName
            "

                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching students: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function


    Private Async Function SendStudentEmail(fullname As String, studentID As String, username As String, password As String, useremail As String) As Task
        Try
            Using smtp As New SmtpClient("smtp.gmail.com", 587)
                smtp.EnableSsl = True
                smtp.UseDefaultCredentials = False
                smtp.Credentials = New Net.NetworkCredential(SMTP_EMAIL, SMTP_APP_PASSWORD)

                Using mail As New MailMessage()
                    mail.From = New MailAddress(SMTP_EMAIL, "Praxis State University")
                    mail.To.Add(useremail)
                    mail.Subject = "Praxis State University - Student Registration Credentails"

                    Dim htmlBody As String =
                "<!DOCTYPE html>" &
                "<html>" &
                "<body style='font-family: Arial, sans-serif; margin:0; padding:0; background-color:#eef2f7;'>" &
                "<table width='100%' cellpadding='0' cellspacing='0' style='padding:30px 0;'>" &
                "<tr><td align='center'>" &
                "<table width='600' cellpadding='0' cellspacing='0' style='background-color:#ffffff; border-radius:10px; box-shadow:0 2px 8px rgba(0,0,0,0.1);'>" &
                "<tr><td style='padding:25px; text-align:center; background-color:#003366; color:#ffffff; border-top-left-radius:10px; border-top-right-radius:10px;'>" &
                "<img src='https://i.imgur.com/bGH3OdK.png' alt='Logo' style='width:90px; display:block; margin:0 auto;'>" &
                "<h1 style='margin:0; font-size:26px;'>Praxis State University</h1>" &
                "<p style='margin:5px 0 0; font-size:16px;'>Student Account Registration</p>" &
                "</td></tr>" &
                "<tr><td style='padding:25px;'>" &
                "<p>Dear <strong>" & fullname.ToUpper() & "</strong>,</p>" &
                "<p>Your student account has been successfully created. Below are your login details:</p>" &
                "<table width='100%' cellpadding='10' cellspacing='0' style='border:1px solid #dddddd; border-radius:5px; background-color:#f9f9f9;'>" &
                "<tr><td style='width:30%; font-weight:bold;'>Student ID:</td><td>" & studentID & "</td></tr>" &
                "<tr><td style='font-weight:bold;'>Username:</td><td>" & username & "</td></tr>" &
                "<tr><td style='font-weight:bold;'>Password:</td><td>" & password & "</td></tr>" &
                "</table>" &
                "<p style='margin-top:20px; font-weight:bold;'>Important Instructions:</p>" &
                "<ul style='margin-top:5px;'>" &
                "<li>Keep your username and password confidential.</li>" &
                "<li>Change your password upon first login.</li>" &
                "<li>Do not share your credentials with anyone.</li>" &
                "<li>Contact the university administration for any issues.</li>" &
                "</ul>" &
                "<p>We are excited to have you as part of Praxis State University!</p>" &
                "<hr style='border:none; border-top:1px solid #dddddd; margin:25px 0;'/>" &
                "<p style='font-size:12px; color:#888888; text-align:center;'>Praxis State University | PSU Pasig Campus Kapasigan, Pasig<br/>" &
                "Email: psu.pasig@gmail.com | Phone: (123) 456-7890 | Website: www.psu-pasig.edu.ph</p>" &
                "<p style='font-size:12px; color:#888888; text-align:center;'>This is an automated message. Please do not reply.</p>" &
                "</td></tr>" &
                "</table>" &
                "</td></tr>" &
                "</table>" &
                "</body></html>"

                    mail.IsBodyHtml = True
                    mail.Body = htmlBody

                    Await smtp.SendMailAsync(mail)
                End Using
            End Using

        Catch ex As Exception
            Debug.WriteLine($"Failed to send email to {useremail}: {ex.Message}")
        End Try
    End Function

End Class