Imports System.ComponentModel.Design
Imports System.Linq
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles
Imports MySql.Data.MySqlClient

Public Class StaffRegistrationForm

    ' -------------------------- Config --------------------------
    Private ReadOnly genders As String() = {"Male", "Female"}
    Private skipCloseConfirmation As Boolean = False
    Private Const SMTP_EMAIL As String = "pohlovesyou@gmail.com"
    Private Const SMTP_APP_PASSWORD As String = "wniyhuldxsxahtkt"
    Private Const SMTP_DISPLAY_NAME As String = "PSU Supervisor Registration"

    ' -------------------------- Form Load --------------------------
    Private Sub StaffRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        staffgendercb.DropDownStyle = ComboBoxStyle.DropDownList
        staffgendercb.Items.AddRange(genders)
        staffgendercb.SelectedIndex = -1

        LoadCompanies()
        staffidtxt.Text = GenerateSupervisorID()
        staffidtxt.ReadOnly = True
    End Sub

    ' -------------------------- Generate Supervisor ID --------------------------
    Private Function GenerateSupervisorID() As String
        Dim nextID As Integer = 1

        Try
            Using conn As New MySqlConnection(connectdb.connstring)
                conn.Open()
                Using cmd As New MySqlCommand("SELECT SupervisorID FROM companycontact ORDER BY SupervisorID", conn)
                    Using reader = cmd.ExecuteReader()
                        Dim ids As New List(Of Integer)
                        While reader.Read()
                            ids.Add(Integer.Parse(reader("SupervisorID").ToString().Substring(1)))
                        End While

                        While ids.Contains(nextID)
                            nextID += 1
                        End While
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        End Try

        Return "S" & nextID.ToString("D3")
    End Function

    ' -------------------------- Load Companies --------------------------
    Private Sub LoadCompanies()
        Try
            staffcomptxt.Items.Clear()
            Using conn As New MySqlConnection(connectdb.connstring)
                conn.Open()
                Using cmd As New MySqlCommand("SELECT CompanyID, CompanyName FROM company ORDER BY CompanyName", conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            staffcomptxt.Items.Add(New KeyValuePair(Of String, String)(
                                reader("CompanyID").ToString(),
                                reader("CompanyName").ToString()
                            ))
                        End While
                    End Using
                End Using
            End Using
            staffcomptxt.DisplayMember = "Value"
            staffcomptxt.ValueMember = "Key"
        Catch ex As Exception
            MessageBox.Show("Error loading companies: " & ex.Message)
        End Try
    End Sub

    ' -------------------------- Clear Form --------------------------
    Private Sub ClearAllText(parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            ElseIf ctrl.HasChildren Then
                ClearAllText(ctrl)
            End If
        Next
        staffgendercb.SelectedIndex = -1
        staffcomptxt.SelectedIndex = -1
    End Sub

    ' -------------------------- Email Validation --------------------------
    Private Function IsValidEmail(email As String) As Boolean
        If String.IsNullOrWhiteSpace(email) Then Return False
        Dim pattern As String = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"
        Return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase)
    End Function

    ' -------------------------- Register Supervisor --------------------------
    Private Sub staffregbtn_Click(sender As Object, e As EventArgs) Handles staffregbtn.Click
        '-------------------- VALIDATION --------------------
        If String.IsNullOrWhiteSpace(stafffnametxt.Text) OrElse
       String.IsNullOrWhiteSpace(stafflnametxt.Text) OrElse
       String.IsNullOrWhiteSpace(staffcompostxt.Text) OrElse
       String.IsNullOrWhiteSpace(staffemailtxt.Text) OrElse
       staffgendercb.SelectedIndex = -1 OrElse
       staffcomptxt.SelectedIndex = -1 Then

            MessageBox.Show("Please fill in all required fields.", "Missing Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not IsValidEmail(staffemailtxt.Text.Trim()) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Email",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            staffemailtxt.Focus()
            Return
        End If

        '-------------------- PROCESS --------------------
        Try
            Dim supID As String = GenerateSupervisorID()
            Dim companyID As String = CType(staffcomptxt.SelectedItem, KeyValuePair(Of String, String)).Key

            Using conn As New MySqlConnection(connectdb.connstring)
                conn.Open()
                Dim transaction As MySqlTransaction = conn.BeginTransaction()

                Try
                    '-------------------- SAVE SUPERVISOR --------------------
                    Using cmd As New MySqlCommand("
                    INSERT INTO companycontact
                    (SupervisorID, SupervisorFirstName, MiddleName, SupervisorLastName, Suffix, 
                     SupervisorPosition, SupervisorEmail, ContactNumber, Gender, CompanyID, CompanyContact)
                    VALUES
                    (@ID, @FirstName, @MiddleName, @LastName, @Suffix, 
                     @Position, @Email, @ContactNumber, @Gender, @CompanyID, @CompanyContact)
                ", conn, transaction)

                        cmd.Parameters.AddWithValue("@ID", supID)
                        cmd.Parameters.AddWithValue("@FirstName", stafffnametxt.Text.Trim())
                        cmd.Parameters.AddWithValue("@MiddleName", If(String.IsNullOrWhiteSpace(staffmidnametxt.Text), DBNull.Value, staffmidnametxt.Text.Trim()))
                        cmd.Parameters.AddWithValue("@LastName", stafflnametxt.Text.Trim())
                        cmd.Parameters.AddWithValue("@Suffix", If(String.IsNullOrWhiteSpace(staffsuffixtxt.Text), DBNull.Value, staffsuffixtxt.Text.Trim()))
                        cmd.Parameters.AddWithValue("@Position", staffcompostxt.Text.Trim())
                        cmd.Parameters.AddWithValue("@Email", staffemailtxt.Text.Trim())
                        cmd.Parameters.AddWithValue("@ContactNumber", If(String.IsNullOrWhiteSpace(staffcompnumtxt.Text), DBNull.Value, staffcompnumtxt.Text.Trim()))
                        cmd.Parameters.AddWithValue("@Gender", staffgendercb.SelectedItem.ToString())
                        cmd.Parameters.AddWithValue("@CompanyID", companyID)
                        cmd.Parameters.AddWithValue("@CompanyContact", staffcompnametxt.Text.Trim())

                        cmd.ExecuteNonQuery()
                    End Using

                    '-------------------- CREATE ACCOUNT --------------------
                    Dim cleanID As String = supID.Replace("-", "")
                    Dim fullname As String = $"{stafffnametxt.Text.Trim()} {staffmidnametxt.Text.Trim()} {stafflnametxt.Text.Trim()}".Trim()
                    Dim initials As String = String.Concat(fullname.Split({" "c}, StringSplitOptions.RemoveEmptyEntries).Select(Function(n) n(0).ToString().ToUpper()))
                    Dim username As String = cleanID
                    Dim password As String = cleanID & initials

                    If CreateUserAccount(conn, transaction, username, password, "Faculty", Nothing, Nothing) Then
                        transaction.Commit()
                        SendStaffEmail(fullname, cleanID, username, password, staffemailtxt.Text.Trim())
                        skipCloseConfirmation = True
                        ReturnToLogin()
                    Else
                        transaction.Rollback()
                        MessageBox.Show("Supervisor saved, but failed to create login account.", "Account Creation Failed",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Catch ex As MySqlException
                    MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
    End Sub


    ' -------------------------- Send Staff Email --------------------------
    Private Sub SendStaffEmail(fullname As String, supID As String, username As String, password As String, useremail As String)
        Try
            Using smtp As New SmtpClient("smtp.gmail.com", 587)
                smtp.EnableSsl = True
                smtp.UseDefaultCredentials = False
                smtp.Credentials = New NetworkCredential(SMTP_EMAIL, SMTP_APP_PASSWORD)

                Using mail As New MailMessage()
                    mail.From = New MailAddress(SMTP_EMAIL, "Praxis State University")
                    mail.To.Add(useremail)
                    mail.Subject = "Praxis State University - Staff Account Credentials"

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
                    "<p style='margin:5px 0 0; font-size:16px;'>Staff Account Registration</p>" &
                    "</td></tr>" &
                    "<tr><td style='padding:25px;'>" &
                    "<p>Dear <strong>" & fullname.ToUpper() & "</strong>,</p>" &
                    "<p>Your staff account has been successfully created. Below are your login details:</p>" &
                    "<table width='100%' cellpadding='10' cellspacing='0' style='border:1px solid #dddddd; border-radius:5px; background-color:#f9f9f9;'>" &
                    "<tr><td style='width:30%; font-weight:bold;'>Staff ID:</td><td>" & supID & "</td></tr>" &
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

            MessageBox.Show("Staff email sent successfully to: " & useremail, "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Email failed: " & ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' -------------------------- Return to Login --------------------------
    Private Sub ReturnToLogin()
        For Each regForm In Application.OpenForms.OfType(Of StaffRegistrationForm)().ToList()
            regForm.Hide()
        Next

        Me.Hide()

        Dim loginForm = Application.OpenForms.OfType(Of Login)().FirstOrDefault()
        If loginForm Is Nothing Then
            loginForm = New Login()
            loginForm.Show()
        Else
            loginForm.Show()
            loginForm.Activate()
        End If
    End Sub

    ' -------------------------- Buttons --------------------------
    Private Sub staffreturnbtn_Click(sender As Object, e As EventArgs) Handles staffreturnbtn.Click
        If MessageBox.Show("Return to registration page?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            skipCloseConfirmation = True
            Me.Close()
        End If
    End Sub

    Private Sub staffclearbtn_Click(sender As Object, e As EventArgs) Handles staffclearbtn.Click
        If MessageBox.Show("Are you sure you want to clear all fields?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ClearAllText(Me)
            staffidtxt.Text = GenerateSupervisorID()
        End If
    End Sub

    Private Sub staffaddcompbtn_Click(sender As Object, e As EventArgs) Handles staffaddcompbtn.Click
        Dim addForm As New AddCompanyForm()
        addForm.FormBorderStyle = FormBorderStyle.None
        addForm.StartPosition = FormStartPosition.CenterParent
        addForm.TopMost = True
        addForm.ShowDialog()
    End Sub

    ' -------------------------- Input Validations --------------------------
    Private Sub staffcompnumtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles staffcompnumtxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            Return
        End If
    End Sub
    Private Sub staffcompnumtxt_TextChanged(sender As Object, e As EventArgs) Handles staffcompnumtxt.TextChanged
        If staffcompnumtxt.Text.Length > 11 Then
            staffcompnumtxt.Text = staffcompnumtxt.Text.Substring(0, 11)
            staffcompnumtxt.SelectionStart = staffcompnumtxt.Text.Length
            MessageBox.Show("Maximum of 11 digits allowed.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub staffemailtxt_TextChanged(sender As Object, e As EventArgs) Handles staffemailtxt.TextChanged
        Dim email As String = staffemailtxt.Text.Trim()
        If String.IsNullOrEmpty(email) Then
            lblemailInvalid.Visible = False
            staffemailtxt.BackColor = Color.WhiteSmoke
            Return
        End If

        If IsValidEmail(email) Then
            lblemailInvalid.Text = "Valid email address"
            lblemailInvalid.ForeColor = Color.Green
            staffemailtxt.BackColor = Color.White
        Else
            lblemailInvalid.Text = "Invalid email address"
            lblemailInvalid.ForeColor = Color.Red
            staffemailtxt.BackColor = Color.MistyRose
        End If
        lblemailInvalid.Visible = True
    End Sub

    Private Sub staffsuffixtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles staffsuffixtxt.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub staffsuffixtxt_TextChanged(sender As Object, e As EventArgs) Handles staffsuffixtxt.TextChanged
        If staffsuffixtxt.Text.Length > 3 Then
            staffsuffixtxt.Text = staffsuffixtxt.Text.Substring(0, 3)
            staffsuffixtxt.SelectionStart = staffsuffixtxt.Text.Length
            MessageBox.Show("Suffix can only be up to 3 characters.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class
