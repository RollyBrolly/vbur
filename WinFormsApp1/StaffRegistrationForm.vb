Imports System.ComponentModel.Design
Imports System.IO
Imports System.Threading.Tasks
Imports System.Linq
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles
Imports MySql.Data.MySqlClient

Public Class StaffRegistrationForm
    Private _loginForm As Login
    Private _registrationForm As Registration

    Public Sub New(loginForm As Login, registrationForm As Registration)
        InitializeComponent()
        _loginForm = loginForm
        _registrationForm = registrationForm
    End Sub
    ' -------------------------- Config --------------------------
    Private ReadOnly genders As String() = {"Male", "Female"}

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
                Using cmd As New MySqlCommand("SELECT SupervisorID FROM Supervisor ORDER BY SupervisorID", conn)
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
            GoToLogin()
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
            GoToLogin()
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

        Try
            Dim addr As New System.Net.Mail.MailAddress(email)
            Dim domain As String = email.Split("@"c)(1).ToLower()

            Dim allowedDomains As String() = {"gmail.com", "yahoo.com", "outlook.com", "yourschool.edu.ph"}

            If Not allowedDomains.Contains(domain) Then Return False
            Return True
        Catch
            Return False
        End Try
    End Function

    ' -------------------------- Register Supervisor --------------------------
    Private Async Sub staffregbtn_Click(sender As Object, e As EventArgs) Handles staffregbtn.Click
        '-------------------- VALIDATION --------------------
        If String.IsNullOrWhiteSpace(stafffnametxt.Text) OrElse
       String.IsNullOrWhiteSpace(stafflnametxt.Text) OrElse
       String.IsNullOrWhiteSpace(staffcompostxt.Text) OrElse
       String.IsNullOrWhiteSpace(staffemailtxt.Text) OrElse
       staffgendercb.SelectedIndex = -1 OrElse
       staffcomptxt.SelectedIndex = -1 Then

            MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not IsValidEmail(staffemailtxt.Text.Trim()) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            staffemailtxt.Focus()
            Return
        End If

        staffregbtn.Enabled = False

        '-------------------- PROCESS --------------------
        Try
            Dim supID As String = staffidtxt.Text.Trim()
            Dim firstname As String = stafffnametxt.Text.Trim()
            Dim middlename As String = staffmidnametxt.Text.Trim()
            Dim lastname As String = stafflnametxt.Text.Trim()
            Dim suffix As String = staffsuffixtxt.Text.Trim()
            Dim gender As String = staffgendercb.SelectedItem.ToString()
            Dim contact As String = staffcompnumtxt.Text.Trim()
            Dim email As String = staffemailtxt.Text.Trim()
            Dim companyID As String = CType(staffcomptxt.SelectedItem, KeyValuePair(Of String, String)).Key

            Using conn As New MySqlConnection(connectdb.connstring)
                conn.Open()
                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Using cmd As New MySqlCommand("
                        INSERT INTO Supervisor
                        (SupervisorID, SupervisorFirstName, MiddleName, SupervisorLastName, Suffix, SupervisorPosition, SupervisorEmail, ContactNumber, Gender, CompanyID)
                        VALUES (@ID, @FirstName, @MiddleName, @LastName, @Suffix, @Position, @Email, @ContactNumber, @Gender, @CompanyID)
                    ", conn, transaction)

                            cmd.Parameters.AddWithValue("@ID", supID)
                            cmd.Parameters.AddWithValue("@FirstName", StrConv(stafffnametxt.Text.Trim(), VbStrConv.ProperCase))
                            cmd.Parameters.AddWithValue("@MiddleName", If(String.IsNullOrWhiteSpace(staffmidnametxt.Text), DBNull.Value, StrConv(staffmidnametxt.Text.Trim(), VbStrConv.ProperCase)))
                            cmd.Parameters.AddWithValue("@LastName", StrConv(stafflnametxt.Text.Trim(), VbStrConv.ProperCase))
                            cmd.Parameters.AddWithValue("@Suffix", If(String.IsNullOrWhiteSpace(staffsuffixtxt.Text), DBNull.Value, StrConv(staffsuffixtxt.Text.Trim(), VbStrConv.ProperCase)))
                            cmd.Parameters.AddWithValue("@Position", StrConv(staffcompostxt.Text.Trim(), VbStrConv.ProperCase))
                            cmd.Parameters.AddWithValue("@Email", staffemailtxt.Text.Trim())
                            cmd.Parameters.AddWithValue("@ContactNumber", If(String.IsNullOrWhiteSpace(staffcompnumtxt.Text), DBNull.Value, staffcompnumtxt.Text.Trim()))
                            cmd.Parameters.AddWithValue("@Gender", staffgendercb.SelectedItem.ToString())
                            cmd.Parameters.AddWithValue("@CompanyID", companyID)

                            cmd.ExecuteNonQuery()
                        End Using

                        '-------------------- CREATE ACCOUNT --------------------
                        Dim username As String = supID.Replace("-", "")
                        Dim fullname As String = $"{stafffnametxt.Text.Trim()} {staffmidnametxt.Text.Trim()} {stafflnametxt.Text.Trim()}".Trim()
                        Dim initials As String = String.Concat(fullname.Split({" "c}, StringSplitOptions.RemoveEmptyEntries).Select(Function(n) n(0).ToString().ToUpper()))
                        Dim password As String = username & initials

                        If CreateUserAccount(conn, transaction, username, password, "Supervisor", Nothing, Nothing, supID) Then
                            transaction.Commit()

                            ' -------------------- SEND EMAIL --------------------
                            Await SendStaffEmailAsync(fullname, supID, username, password, staffemailtxt.Text.Trim())

                            GoToLogin()
                            Return
                        Else
                            transaction.Rollback()
                            MessageBox.Show("Supervisor saved, but failed to create login account.", "Account Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If

                    Catch ex As MySqlException
                        transaction.Rollback()
                        MessageBox.Show($"Database error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            staffregbtn.Enabled = True
        End Try
    End Sub



    ' -------------------------- Send Staff Email --------------------------
    Private Async Function SendStaffEmailAsync(fullname As String, supID As String, username As String, password As String, useremail As String) As Task
        Using dlg As New EmailProgressDialog(Me)
            dlg.Show(Me)
            dlg.UpdateProgress(10, "Connecting to SMTP server...")
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
                    "<img src='https://i.imgur.com/bGH3OdK.png' alt='Logo' style='width:90px; display:block; margin:0 auto;'>" &
                    "<h1 style='margin:0; font-size:26px;'>Praxis State University</h1>" &
                    "<p style='margin:5px 0 0; font-size:16px;'>Supervisor Account Registration</p>" &
                    "</td></tr>" &
                    "<tr><td style='padding:25px;'>" &
                    "<p>Dear <strong>" & fullname.ToUpper() & "</strong>,</p>" &
                    "<p>Your Supervisor account has been successfully created. Below are your login details:</p>" &
                    "<table width='100%' cellpadding='10' cellspacing='0' style='border:1px solid #dddddd; border-radius:5px; background-color:#f9f9f9;'>" &
                    "<tr><td style='width:30%; font-weight:bold;'>Supervisor ID:</td><td>" & supID & "</td></tr>" &
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
                MessageBox.Show("Staff email sent successfully to: " & useremail, "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Email failed: " & ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                dlg.Close()
            End Try
        End Using
    End Function

    ' -------------------------- Buttons --------------------------
    Public Sub Refreshcompanies()
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
    End Sub

    Private Sub staffreturnbtn_Click(sender As Object, e As EventArgs) Handles staffreturnbtn.Click
        If MessageBox.Show("Return to registration page?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If _registrationForm IsNot Nothing Then _registrationForm.Show()
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
        Dim addcompany As New AddCompanyForm()
        addcompany.ParentStaffForm = Me
        addcompany.FormBorderStyle = FormBorderStyle.None
        addcompany.StartPosition = FormStartPosition.CenterParent
        addcompany.TopMost = True
        addcompany.ShowDialog()
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

    ' -------------------------- Helper to Go to Login --------------------------
    Private Sub GoToLogin()
        If _registrationForm IsNot Nothing Then _registrationForm.Close()
        If _loginForm IsNot Nothing Then _loginForm.Show()
        Me.Close()
    End Sub
End Class
