Imports System.Linq
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class StudentRegistrationForm

    ' -------------------------- Database & Config --------------------------
    Private ReadOnly connString As String = connectdb.connstring
    Private ReadOnly sections As String() = {"4A", "4B", "4C", "4D", "4E", "4F"}
    Private skipCloseConfirmation As Boolean = False

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
        End Try
    End Sub

    ' -------------------------- Load Sections --------------------------
    Private Sub studcourcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studcourcb.SelectedIndexChanged
        studsectioncb.Items.Clear()
        If studcourcb.SelectedIndex = -1 Then
            studsectioncb.Enabled = False
            Return
        End If
        studsectioncb.Enabled = True
        studsectioncb.Items.AddRange(sections)
        studsectioncb.SelectedIndex = -1
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
            MessageBox.Show("Database error: " & ex.Message)

        End Try

        Return yearPrefix & "-" & (lastID + 1).ToString("D5")
    End Function

    ' -------------------------- Email Validation --------------------------
    Private Function IsValidEmail(email As String) As Boolean
        If String.IsNullOrWhiteSpace(email) Then Return False
        Dim pattern As String = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"
        Return Regex.IsMatch(email, pattern)
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
    Private Sub studregbtn_Click(sender As Object, e As EventArgs) Handles studregbtn.Click
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
        Dim firstname As String = studfnametxt.Text.Trim()
        Dim middlename As String = studmiddlentxt.Text.Trim()
        Dim lastname As String = studlastntxt.Text.Trim()
        Dim suffix As String = studsuffixtxt.Text.Trim()
        Dim gender As String = studgendercb.SelectedItem.ToString()
        Dim contact As String = studnumtxt.Text.Trim()
        Dim email As String = studemailtxt.Text.Trim()
        Dim courseID As String = CType(studcourcb.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim section As String = studsectioncb.SelectedItem.ToString()

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Using cmd As New MySqlCommand("
                    INSERT INTO student 
                    (StudentID, StudentFirstName, StudentMiddleName, StudentLastName, Suffix, Gender, StudentContactNo, StudentEmail, CourseID, Section)
                    VALUES 
                    (@StudentID, @FirstName, @MiddleName, @LastName, @Suffix, @Gender, @ContactNo, @Email, @CourseID, @Section)
                ", conn)
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
            End Using
        Catch ex As Exception
            MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ' -------------------------- Create login credentials --------------------------
        Try
            Dim cleanStudentID As String = studentID.Replace("-", "")
            Dim fullname As String = $"{firstname} {middlename} {lastname}"
            Dim initials As String = String.Concat(fullname.Split(" "c).Select(Function(n) n(0).ToString().ToUpper()))
            Dim username As String = cleanStudentID
            Dim password As String = cleanStudentID & initials

            If CreateUserAccount(username, password, "Student", cleanStudentID, Nothing, Nothing) Then
                SendStudentEmail(fullname, cleanStudentID, username, password, email)
                skipCloseConfirmation = True
                ReturnToLogin()
            Else
                MessageBox.Show("Student saved, but failed to create login account.", "Account Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As MySqlException
            MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' -------------------------- Send Student Email --------------------------
    Private Sub SendStudentEmail(fullname As String, studentID As String, username As String, password As String, useremail As String)
        Try
            Using smtp As New SmtpClient("smtp.gmail.com", 587)
                smtp.EnableSsl = True
                smtp.UseDefaultCredentials = False
                smtp.Credentials = New Net.NetworkCredential(SMTP_EMAIL, SMTP_APP_PASSWORD)

                Using mail As New MailMessage()
                    mail.From = New MailAddress(SMTP_EMAIL, "Praxis State University")
                    mail.To.Add(useremail)
                    mail.Subject = "Praxis State University - Student Registration Details"

                    Dim htmlBody As String =
                    "<!DOCTYPE html>" &
                    "<html>" &
                    "<body style='font-family: Arial, sans-serif; margin:0; padding:0; background-color:#eef2f7;'>" &
                    "<table width='100%' cellpadding='0' cellspacing='0' style='padding:30px 0;'>" &
                    "<tr><td align='center'>" &
                    "<table width='600' cellpadding='0' cellspacing='0' style='background-color:#ffffff; border-radius:10px; box-shadow:0 2px 8px rgba(0,0,0,0.1);'>" &
                    "<tr><td style='padding:25px; text-align:center; background-color:#003366; color:#ffffff; border-top-left-radius:10px; border-top-right-radius:10px;'>" &
                    "<img src='cid:LogoImage' alt='Praxis State University Logo' style='width:90px; margin-bottom:10px; display:block; margin-left:auto; margin-right:auto;'>" &
                    "<h1 style='margin:0; font-size:26px;'>Praxis State University</h1>" &
                    "<p style='margin:5px 0 0; font-size:16px;'>Student Registration Portal</p>" &
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
                    "<p>We are excited to have you join the Praxis State University community and wish you a successful academic journey!</p>" &
                    "<hr style='border:none; border-top:1px solid #dddddd; margin:25px 0;'/>" &
                    "<p style='font-size:12px; color:#888888; text-align:center;'>Praxis State University | 123 University Avenue, City, Province<br/>" &
                    "Email: support@praxis.edu | Phone: (123) 456-7890</p>" &
                    "<p style='font-size:12px; color:#888888; text-align:center;'>This is an automated message. Please do not reply.</p>" &
                    "</td></tr>" &
                    "</table>" &
                    "</td></tr>" &
                    "</table>" &
                    "</body>" &
                    "</html>"

                    Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(htmlBody, Nothing, "text/html")

                    Dim logo As New LinkedResource("C:\Users\acer\Source\Repos\vbur\WinFormsApp1\Resources\Praxis logo.png", MediaTypeNames.Image.Png)
                    logo.ContentId = "LogoImage"
                    htmlView.LinkedResources.Add(logo)

                    mail.AlternateViews.Add(htmlView)

                    smtp.Send(mail)
                End Using
            End Using

            MessageBox.Show("Student registered successfully! Email sent to: " & useremail)
        Catch ex As Exception
            MessageBox.Show("Email failed: " & ex.Message)
        End Try
    End Sub

    ' -------------------------- Return to Login -------------------------- 
    Private Sub ReturnToLogin()
        Dim loginForm = Application.OpenForms.OfType(Of Login)().FirstOrDefault()
        If loginForm IsNot Nothing Then
            loginForm.Show()
            loginForm.BringToFront()
        Else
            Dim lf As New Login()
            lf.Show()
        End If

        If TypeOf Me.Owner Is Registration Then
            Try
                CType(Me.Owner, Registration).CloseWithoutPrompt()
            Catch
            End Try
        Else
            For Each rf In Application.OpenForms.OfType(Of Registration)().ToList()
                Try
                    rf.Close()
                Catch
                    rf.Hide()
                End Try
            Next
        End If

        Try
            Me.DialogResult = DialogResult.OK
        Catch
        End Try
        Me.Close()
    End Sub

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
        skipCloseConfirmation = True
        Me.Close()
    End Sub

    ' -------------------------- Form Closing --------------------------
    Private Sub StudentRegistrationForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not skipCloseConfirmation Then
            If MessageBox.Show("Return to registration page?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Hide()
                Dim regForm As New Registration()
                regForm.ShowDialog()
            End If
        End If
    End Sub

    ' -------------------------- Input Validation --------------------------
    Private Sub studnumtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles studnumtxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
        If Char.IsDigit(e.KeyChar) AndAlso studnumtxt.Text.Length >= 11 Then
            MessageBox.Show("Maximum of 11 digits allowed.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Handled = True
        End If
    End Sub

    Private Sub studsuffixtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles studsuffixtxt.KeyPress
        If studsuffixtxt.Text.Length >= 3 AndAlso Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Suffix can only be up to 3 characters.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Handled = True
        End If
    End Sub

    Private Sub studemailtxt_TextChanged(sender As Object, e As EventArgs) Handles studemailtxt.TextChanged
        Dim email = studemailtxt.Text.Trim()
        If String.IsNullOrEmpty(email) Then
            lblemailInvalid.Visible = False
            studemailtxt.BackColor = Color.DarkGray
            Return
        End If

        If IsValidEmail(email) Then
            lblemailInvalid.Text = "Valid email address"
            lblemailInvalid.ForeColor = Color.Green
            studemailtxt.BackColor = Color.Silver
        Else
            lblemailInvalid.Text = "Invalid email address"
            lblemailInvalid.ForeColor = Color.Red
            studemailtxt.BackColor = Color.DarkGray
        End If
        lblemailInvalid.Visible = True
    End Sub

End Class
