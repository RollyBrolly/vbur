Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class StudentRegistrationForm
    Private _loginForm As Login
    Private _registrationForm As Registration

    Public Sub New(loginForm As Login, registrationForm As Registration)
        InitializeComponent()
        _loginForm = loginForm
        _registrationForm = registrationForm
    End Sub

    ' -------------------------- Database & Config --------------------------
    Private ReadOnly connString As String = connectdb.connstring

    ' -------------------------- SMTP Config --------------------------
    Private Const SMTP_EMAIL As String = "pohlovesyou@gmail.com"
    Private Const SMTP_APP_PASSWORD As String = "wniyhuldxsxahtkt"
    Private Const SMTP_DISPLAY_NAME As String = "PSU Student Registration"

    ' -------------------------- Form Load --------------------------
    Private Sub StudentRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        studdeptcb.DropDownStyle = ComboBoxStyle.DropDownList
        studcourcb.DropDownStyle = ComboBoxStyle.DropDownList
        studsectioncb.DropDownStyle = ComboBoxStyle.DropDownList
        studcourcb.Enabled = False
        studsectioncb.Enabled = False

        studgendercb.Items.AddRange({"Male", "Female"})
        studgendercb.DropDownStyle = ComboBoxStyle.DropDownList

        LoadDepartments()
        studnotxt.Text = GenerateStudentID()
        studnotxt.ReadOnly = True
    End Sub

    ' -------------------------- Load Sections --------------------------
    Private Sub LoadSections()
        studsectioncb.Items.Clear()
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Using cmd As New MySqlCommand("SELECT DISTINCT Section FROM student ORDER BY Section", conn)
                    Using reader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                studsectioncb.Items.Add(reader("Section").ToString())
                            End While
                            studsectioncb.Enabled = True
                        Else
                            MessageBox.Show("No sections found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
            GoToLogin()
        End Try
    End Sub

    ' -------------------------- Load Departments --------------------------
    Private Sub LoadDepartments()
        studdeptcb.Items.Clear()
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Using cmd As New MySqlCommand("SELECT DepartmentID, DeptName FROM department ORDER BY DeptName", conn)
                    Using reader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                studdeptcb.Items.Add(New KeyValuePair(Of String, String)(
                                    reader("DepartmentID").ToString(),
                                    reader("DeptName").ToString()
                                ))
                            End While
                            studdeptcb.DisplayMember = "Value"
                            studdeptcb.ValueMember = "Key"
                            studdeptcb.Enabled = True
                        Else
                            MessageBox.Show("No departments found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
            GoToLogin()
        End Try
    End Sub

    ' -------------------------- Load Courses --------------------------
    Private Sub studdeptcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studdeptcb.SelectedIndexChanged
        studcourcb.Items.Clear()
        studcourcb.Enabled = False
        studsectioncb.Items.Clear()
        studsectioncb.Enabled = False

        If studdeptcb.SelectedIndex = -1 Then Return

        Dim deptID As String = CType(studdeptcb.SelectedItem, KeyValuePair(Of String, String)).Key
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Using cmd As New MySqlCommand("SELECT CourseID, CourseName FROM course WHERE DepartmentID = @DeptID ORDER BY CourseName", conn)
                    cmd.Parameters.AddWithValue("@DeptID", deptID)
                    Using reader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                studcourcb.Items.Add(New KeyValuePair(Of String, String)(
                                    reader("CourseID").ToString(),
                                    reader("CourseName").ToString()
                                ))
                            End While
                            studcourcb.DisplayMember = "Value"
                            studcourcb.ValueMember = "Key"
                            studcourcb.Enabled = True
                        Else
                            MessageBox.Show("No courses found for this department.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
            GoToLogin()
        End Try
    End Sub

    ' -------------------------- Load Sections when Course changes --------------------------
    Private Sub studcourcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studcourcb.SelectedIndexChanged
        studsectioncb.Items.Clear()
        studsectioncb.Enabled = False

        If studcourcb.SelectedIndex = -1 Then Return

        ' Load all sections regardless of existing students
        Dim sections As String() = {"4A", "4B", "4C", "4D", "4E", "4F"}
        studsectioncb.Items.AddRange(sections)
        studsectioncb.Enabled = True
    End Sub

    ' -------------------------- Generate Student ID --------------------------
    Private Function GenerateStudentID() As String
        Dim yearPrefix As String = (DateTime.Now.Year Mod 100).ToString("D2")
        Dim lastID As Integer = 0

        Try
            Using conn As New MySqlConnection(connString)
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
            GoToLogin()
        End Try

        Return yearPrefix & "-" & (lastID + 1).ToString("D5")
    End Function

    ' -------------------------- Email Validation --------------------------
    Private Function IsValidEmail(email As String) As Boolean
        If String.IsNullOrWhiteSpace(email) Then Return False

        Try
            Dim addr As New System.Net.Mail.MailAddress(email)
            Dim domain As String = email.Split("@"c)(1).ToLower()

            Dim allowedDomains As String() = {"gmail.com", "yahoo.com", "outlook.com", "plpasig.edu.ph"}

            If Not allowedDomains.Contains(domain) Then Return False
            Return True
        Catch
            Return False
        End Try
    End Function


    ' -------------------------- Required Fields Validation --------------------------
    Private Function AreRequiredFieldsFilled() As Boolean
        Return Not String.IsNullOrWhiteSpace(studfnametxt.Text) AndAlso
               Not String.IsNullOrWhiteSpace(studlastntxt.Text) AndAlso
               studgendercb.SelectedIndex <> -1 AndAlso
               studdeptcb.SelectedIndex <> -1 AndAlso
               studcourcb.SelectedIndex <> -1 AndAlso
               studsectioncb.SelectedIndex <> -1 AndAlso
               Not String.IsNullOrWhiteSpace(studnumtxt.Text) AndAlso
               Not String.IsNullOrWhiteSpace(studemailtxt.Text)
    End Function

    ' -------------------------- Register Student --------------------------
    Private Async Sub studregbtn_Click(sender As Object, e As EventArgs) Handles studregbtn.Click
        If Not AreRequiredFieldsFilled() Then
            MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not IsValidEmail(studemailtxt.Text.Trim()) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            studemailtxt.Focus()
            Return
        End If

        Dim studentID As String = studnotxt.Text.Trim()
        Dim firstname As String = StrConv(studfnametxt.Text.Trim(), VbStrConv.ProperCase)
        Dim middlename As String = StrConv(studmiddlentxt.Text.Trim(), VbStrConv.ProperCase)
        Dim lastname As String = StrConv(studlastntxt.Text.Trim(), VbStrConv.ProperCase)
        Dim suffix As String = StrConv(studsuffixtxt.Text.Trim(), VbStrConv.ProperCase)
        Dim gender As String = studgendercb.SelectedItem.ToString()
        Dim contact As String = studnumtxt.Text.Trim()
        Dim email As String = studemailtxt.Text.Trim()
        Dim courseID As String = CType(studcourcb.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim section As String = studsectioncb.SelectedItem.ToString()

        Dim username As String = studentID.Replace("-", "")
        Dim fullname As String = $"{firstname} {middlename} {lastname}".Trim()
        Dim initials As String = String.Concat(fullname.Split({" "c}, StringSplitOptions.RemoveEmptyEntries).Select(Function(n) n(0).ToString().ToUpper()))
        Dim password As String = username & initials

        studregbtn.Enabled = False

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        ' ---------- INSERT INTO student ----------
                        Using cmd As New MySqlCommand("
                        INSERT INTO student 
                        (StudentID, StudentFirstName, StudentMiddleName, StudentLastName, Suffix, Gender, StudentContactNo, StudentEmail, CourseID, Section)
                        VALUES 
                        (@StudentID, @FirstName, @MiddleName, @LastName, @Suffix, @Gender, @ContactNo, @Email, @CourseID, @Section)
                    ", conn, transaction)
                            cmd.Parameters.AddWithValue("@StudentID", studentID)
                            cmd.Parameters.AddWithValue("@FirstName", firstname)
                            cmd.Parameters.AddWithValue("@MiddleName", If(String.IsNullOrWhiteSpace(middlename), DBNull.Value, middlename))
                            cmd.Parameters.AddWithValue("@LastName", lastname)
                            cmd.Parameters.AddWithValue("@Suffix", If(String.IsNullOrWhiteSpace(suffix), DBNull.Value, suffix))
                            cmd.Parameters.AddWithValue("@Gender", gender)
                            cmd.Parameters.AddWithValue("@ContactNo", contact)
                            cmd.Parameters.AddWithValue("@Email", email)
                            cmd.Parameters.AddWithValue("@CourseID", courseID)
                            cmd.Parameters.AddWithValue("@Section", section)
                            cmd.ExecuteNonQuery()
                        End Using

                        ' ---------- INSERT INTO useraccounts ----------
                        If CreateUserAccount(conn, transaction, username, password, "Student", studentID, Nothing, Nothing) Then
                            transaction.Commit()
                            Await SendStudentEmail(fullname, studentID, username, password, email)

                            GoToLogin()
                        Else
                            transaction.Rollback()
                            MessageBox.Show("Student saved, but failed to create login account.", "Account Creation Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If

                    Catch ex As Exception
                        transaction.Rollback()
                        MessageBox.Show($"Transaction failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            studregbtn.Enabled = True
        End Try
    End Sub


    ' -------------------------- Send Student Email --------------------------
    Private Async Function SendStudentEmail(fullname As String, studentID As String, username As String, password As String, useremail As String) As Task
        Using dlg As New EmailProgressDialog(Me)
            dlg.Show(Me)
            dlg.UpdateProgress(10, "Connecting to SMTP server...")
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

                        dlg.UpdateProgress(60, "Sending email...")
                        Await smtp.SendMailAsync(mail)
                    End Using
                End Using
                dlg.UpdateProgress(100, "Email sent successfully!")
                Await Task.Delay(500)
                MessageBox.Show("Student registered successfully! Email sent to: " & useremail)
            Catch ex As Exception
                MessageBox.Show("Email failed: " & ex.Message)
            Finally
                dlg.Close()
            End Try
        End Using
    End Function

    ' -------------------------- Clear Form --------------------------
    Private Sub studclearbtn_Click(sender As Object, e As EventArgs) Handles studclearbtn.Click
        If MessageBox.Show("Clear all fields?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ClearAllText(Me)
            studdeptcb.SelectedIndex = -1
            studcourcb.Items.Clear()
            studcourcb.Enabled = False
            studsectioncb.Items.Clear()
            studsectioncb.Enabled = False
            studgendercb.SelectedIndex = -1
            studsuffixtxt.Clear()
            studnotxt.Text = GenerateStudentID()
        End If
    End Sub

    Private Sub ClearAllText(parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is TextBox Then CType(ctrl, TextBox).Clear()
            If ctrl.HasChildren Then ClearAllText(ctrl)
        Next
    End Sub

    ' -------------------------- Return Button --------------------------
    Private Sub studreternbtn_Click(sender As Object, e As EventArgs) Handles studreternbtn.Click
        If MessageBox.Show("Return to registration page?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If _registrationForm IsNot Nothing Then _registrationForm.Show()
            Me.Close()
        End If
    End Sub

    ' -------------------------- Input Validation --------------------------
    Private Sub studnumtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles studnumtxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub studnumtxt_TextChanged(sender As Object, e As EventArgs) Handles studnumtxt.TextChanged
        If studnumtxt.Text.Length > 11 Then
            studnumtxt.Text = studnumtxt.Text.Substring(0, 11)
            studnumtxt.SelectionStart = studnumtxt.Text.Length
            MessageBox.Show("Maximum of 11 digits allowed.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' ---------- Suffix ----------
    Private Sub studsuffixtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles studsuffixtxt.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub studsuffixtxt_TextChanged(sender As Object, e As EventArgs) Handles studsuffixtxt.TextChanged
        If studsuffixtxt.Text.Length > 3 Then
            studsuffixtxt.Text = studsuffixtxt.Text.Substring(0, 3)
            studsuffixtxt.SelectionStart = studsuffixtxt.Text.Length
            MessageBox.Show("Suffix can only be up to 3 characters.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub studemailtxt_TextChanged(sender As Object, e As EventArgs) Handles studemailtxt.TextChanged
        Dim email As String = studemailtxt.Text.Trim()

        If String.IsNullOrEmpty(email) Then
            lblemailInvalid.Visible = False
            studemailtxt.BackColor = Color.WhiteSmoke
            Return
        End If

        If IsValidEmail(email) Then
            lblemailInvalid.Text = "Valid email address"
            lblemailInvalid.ForeColor = Color.Green
            studemailtxt.BackColor = Color.White
        Else
            lblemailInvalid.Text = "Invalid email address"
            lblemailInvalid.ForeColor = Color.Red
            studemailtxt.BackColor = Color.MistyRose
        End If

        lblemailInvalid.Visible = True
    End Sub

    ' -------------------------- Helper to Go to Login --------------------------
    Private Sub GoToLogin()
        If _registrationForm IsNot Nothing Then _registrationForm.Close()
        If _loginForm IsNot Nothing Then _loginForm.Show()
        Me.Close()
    End Sub
End Class

