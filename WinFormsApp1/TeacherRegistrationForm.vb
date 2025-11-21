Imports System.Linq
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class TeacherRegistrationForm

    ' -------------------------- Config --------------------------
    Private ReadOnly genders As String() = {"Male", "Female"}
    Private skipCloseConfirmation As Boolean = False

    Private Const SMTP_EMAIL As String = "pohlovesyou@gmail.com"
    Private Const SMTP_APP_PASSWORD As String = "wniyhuldxsxahtkt"
    Private Const SMTP_DISPLAY_NAME As String = "PSU Teacher Registration"

    ' -------------------------- Form Load --------------------------
    Private Sub TeacherRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        tcdeptcb.DropDownStyle = ComboBoxStyle.DropDownList
        tcgendercb.DropDownStyle = ComboBoxStyle.DropDownList
        tcgendercb.Items.AddRange(genders)
        tcgendercb.SelectedIndex = -1

        LoadDepartments()
        tcfnumbertxt.Text = GenerateFacultyID()
    End Sub

    ' -------------------------- Load Departments --------------------------
    Private Sub LoadDepartments()
        tcdeptcb.Items.Clear()
        Try
            Using conn As New MySqlConnection(connectdb.connstring)
                conn.Open()
                Using cmd As New MySqlCommand("SELECT DepartmentID, DeptName FROM department ORDER BY DeptName", conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            tcdeptcb.Items.Add(New KeyValuePair(Of String, String)(
                                reader("DepartmentID").ToString(),
                                reader("DeptName").ToString()))
                        End While
                    End Using
                End Using
            End Using

            tcdeptcb.DisplayMember = "Value"
            tcdeptcb.ValueMember = "Key"
            tcdeptcb.Enabled = True
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -------------------------- Generate Faculty ID --------------------------
    Private Function GenerateFacultyID() As String
        Dim nextID As Integer = 1
        Try
            Using conn As New MySqlConnection(connectdb.connstring)
                conn.Open()
                Using cmd As New MySqlCommand("SELECT FacultyID FROM faculty ORDER BY FacultyID", conn)
                    Using reader = cmd.ExecuteReader()
                        Dim ids As New List(Of Integer)
                        While reader.Read()
                            ids.Add(Integer.Parse(reader("FacultyID").ToString().Substring(1)))
                        End While
                        While ids.Contains(nextID)
                            nextID += 1
                        End While
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return "F" & nextID.ToString("D3")
    End Function

    ' -------------------------- Email Validation --------------------------
    Private Function IsValidEmail(email As String) As Boolean
        If String.IsNullOrWhiteSpace(email) Then Return False
        Dim pattern As String = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"
        Return Regex.IsMatch(email, pattern)
    End Function

    ' -------------------------- Required Fields Validation --------------------------
    Private Function AreRequiredFieldsFilled() As Boolean
        Return Not String.IsNullOrWhiteSpace(tcfnametxt.Text) AndAlso
               Not String.IsNullOrWhiteSpace(tclastnametxt.Text) AndAlso
               tcdeptcb.SelectedIndex <> -1 AndAlso
               Not String.IsNullOrWhiteSpace(tcemailtxt.Text) AndAlso
               Not String.IsNullOrWhiteSpace(tcnumtxt.Text) AndAlso
               tcgendercb.SelectedIndex <> -1
    End Function

    ' -------------------------- Register Teacher --------------------------
    Private Sub tcregbtn_Click(sender As Object, e As EventArgs) Handles tcregbtn.Click
        If Not AreRequiredFieldsFilled() Then
            MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not IsValidEmail(tcemailtxt.Text.Trim()) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tcemailtxt.Focus()
            Return
        End If

        Dim facultyID As String = tcfnumbertxt.Text.Trim()
        Dim firstname As String = tcfnametxt.Text.Trim()
        Dim middlename As String = tcmidnametxt.Text.Trim()
        Dim lastname As String = tclastnametxt.Text.Trim()
        Dim suffix As String = tcsuffixtxt.Text.Trim()
        Dim gender As String = tcgendercb.SelectedItem.ToString()
        Dim contact As String = tcnumtxt.Text.Trim()
        Dim email As String = tcemailtxt.Text.Trim()
        Dim deptID As String = CType(tcdeptcb.SelectedItem, KeyValuePair(Of String, String)).Key

        Try
            Using conn As New MySqlConnection(connectdb.connstring)
                conn.Open()
                Using cmd As New MySqlCommand("
                    INSERT INTO faculty 
                    (FacultyID, FacultyFirstName, MiddleName, FacultyLastName, Suffix, ContactNumber, Gender, FacultyEmail, IsEvaluator, DeptID)
                    VALUES 
                    (@FacultyID, @FirstName, @MiddleName, @LastName, @Suffix, @ContactNumber, @Gender, @Email, @IsEvaluator, @DeptID)
                ", conn)
                    cmd.Parameters.AddWithValue("@FacultyID", facultyID)
                    cmd.Parameters.AddWithValue("@FirstName", firstname)
                    cmd.Parameters.AddWithValue("@MiddleName", If(String.IsNullOrWhiteSpace(middlename), DBNull.Value, middlename))
                    cmd.Parameters.AddWithValue("@LastName", lastname)
                    cmd.Parameters.AddWithValue("@Suffix", If(String.IsNullOrWhiteSpace(suffix), DBNull.Value, suffix))
                    cmd.Parameters.AddWithValue("@ContactNumber", contact)
                    cmd.Parameters.AddWithValue("@Gender", gender)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@IsEvaluator", 0)
                    cmd.Parameters.AddWithValue("@DeptID", deptID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' -------------------------- Create Account --------------------------
            Try
                Dim cleanFacultyID As String = facultyID.Replace("-", "")
                Dim fullname As String = $"{firstname} {middlename} {lastname}"
                Dim initials As String = String.Concat(fullname.Split(" "c).Select(Function(n) n(0).ToString().ToUpper()))
                Dim username As String = cleanFacultyID
                Dim password As String = cleanFacultyID & initials

                If CreateUserAccount(username, password, "Faculty", cleanFacultyID, Nothing, Nothing) Then
                    SendTeacherEmail(fullname, cleanFacultyID, username, password, email)
                    skipCloseConfirmation = True
                    ReturnToLogin()
                Else
                    MessageBox.Show("Teacher saved, but failed to create login account.", "Account Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Catch ex As MySqlException
                MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
    End Sub

    ' -------------------------- Send Teacher Email --------------------------
    Private Sub SendTeacherEmail(fullname As String, facultyID As String, username As String, password As String, useremail As String)
        Try
            Using smtp As New SmtpClient("smtp.gmail.com", 587)
                smtp.EnableSsl = True
                smtp.UseDefaultCredentials = False
                smtp.Credentials = New NetworkCredential(SMTP_EMAIL, SMTP_APP_PASSWORD)

                Using mail As New MailMessage()
                    mail.From = New MailAddress(SMTP_EMAIL, "Praxis State University")
                    mail.To.Add(useremail)
                    mail.Subject = "Praxis State University - Teacher Account Credentials"

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
                    "<p style='margin:5px 0 0; font-size:16px;'>Teacher Account Registration</p>" &
                    "</td></tr>" &
                    "<tr><td style='padding:25px;'>" &
                    "<p>Dear <strong>" & fullname.ToUpper() & "</strong>,</p>" &
                    "<p>Your teacher account has been successfully created. Below are your login details:</p>" &
                    "<table width='100%' cellpadding='10' cellspacing='0' style='border:1px solid #dddddd; border-radius:5px; background-color:#f9f9f9;'>" &
                    "<tr><td style='width:30%; font-weight:bold;'>Faculty ID:</td><td>" & facultyID & "</td></tr>" &
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
                    "<p style='font-size:12px; color:#888888; text-align:center;'>Praxis State University | 123 University Avenue, City, Province<br/>" &
                    "Email: support@praxis.edu | Phone: (123) 456-7890</p>" &
                    "<p style='font-size:12px; color:#888888; text-align:center;'>This is an automated message. Please do not reply.</p>" &
                    "</td></tr>" &
                    "</table>" &
                    "</td></tr>" &
                    "</table>" &
                    "</body></html>"

                    Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(htmlBody, Nothing, "text/html")

                    Dim logo As New LinkedResource("C:\Users\acer\Source\Repos\vbur\WinFormsApp1\Resources\Praxis logo.png", MediaTypeNames.Image.Png)
                    logo.ContentId = "LogoImage"
                    htmlView.LinkedResources.Add(logo)

                    mail.AlternateViews.Add(htmlView)

                    smtp.Send(mail)
                End Using
            End Using

            MessageBox.Show("Teacher email sent successfully to: " & useremail, "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Email failed: " & ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub tcclearbtn_Click(sender As Object, e As EventArgs) Handles tcclearbtn.Click
        If MessageBox.Show("Are you sure you want to clear all fields?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ClearForm()
        End If
    End Sub

    Private Sub ClearForm()
        ClearAllText(Me)
        tcdeptcb.SelectedIndex = -1
        tcgendercb.SelectedIndex = -1
        tcfnumbertxt.Text = GenerateFacultyID()
    End Sub

    Private Sub ClearAllText(parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is TextBox Then CType(ctrl, TextBox).Clear()
            If ctrl.HasChildren Then ClearAllText(ctrl)
        Next
    End Sub

    ' -------------------------- Return Button --------------------------
    Private Sub tcreturnbtn_Click(sender As Object, e As EventArgs) Handles tcreturnbtn.Click
        If MessageBox.Show("Return to registration page?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            skipCloseConfirmation = True
            Try
                Me.DialogResult = DialogResult.Cancel
            Catch
            End Try
            Me.Close()
        End If
    End Sub

    ' -------------------------- Input Validation --------------------------
    Private Sub tcnumtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcnumtxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
        If Char.IsDigit(e.KeyChar) AndAlso tcnumtxt.Text.Length >= 11 Then
            MessageBox.Show("Maximum of 11 digits allowed.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Handled = True
        End If
    End Sub

    Private Sub tcsuffixtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcsuffixtxt.KeyPress
        If tcsuffixtxt.Text.Length >= 3 AndAlso Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Suffix can only be up to 3 characters.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Handled = True
        End If
    End Sub

    Private Sub tcemailtxt_TextChanged(sender As Object, e As EventArgs) Handles tcemailtxt.TextChanged
        If IsValidEmail(tcemailtxt.Text.Trim()) Then
            lblemailInvalid.Text = "Valid email address"
            lblemailInvalid.ForeColor = Color.Green
            lblemailInvalid.Visible = True
            tcemailtxt.BackColor = Color.Silver
        Else
            lblemailInvalid.Text = "Invalid email address"
            lblemailInvalid.ForeColor = Color.Red
            lblemailInvalid.Visible = True
            tcemailtxt.BackColor = Color.DarkGray
        End If
    End Sub

End Class
