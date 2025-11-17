Imports MySql.Data.MySqlClient
Imports System.Linq

Public Class StaffRegistrationForm
    Private conn As New MySqlConnection(connectdb.connstring)
    Private ReadOnly genders As String() = {"Male", "Female"}
    Private skipCloseConfirmation As Boolean = False

    Private Sub StaffRegistrationForm(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        staffgendercb.DropDownStyle = ComboBoxStyle.DropDownList
        staffgendercb.Items.AddRange(genders)
        staffgendercb.SelectedIndex = -1

        LoadCompanies()
        staffidtxt.Text = GenerateSupervisorID()
        staffidtxt.ReadOnly = True
    End Sub

    Private Function GenerateSupervisorID() As String
        Dim nextID As Integer = 1
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT SupervisorID FROM companycontact ORDER BY SupervisorID DESC LIMIT 1", conn)
            Dim result = cmd.ExecuteScalar()

            If result IsNot Nothing Then
                Dim lastID As String = result.ToString().Substring(1)
                nextID = Integer.Parse(lastID) + 1
            End If
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Return "S" & nextID.ToString("D3")
    End Function

    Private Sub LoadCompanies()
        Try
            staffcomptxt.Items.Clear()
            conn.Open()
            Dim query As String = "SELECT CompanyID, CompanyName FROM company ORDER BY CompanyName"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader = cmd.ExecuteReader()

            While reader.Read()
                staffcomptxt.Items.Add(New KeyValuePair(Of String, String)(reader("CompanyID").ToString(), reader("CompanyName").ToString()))
            End While

            staffcomptxt.DisplayMember = "Value"
            staffcomptxt.ValueMember = "Key"
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading companies: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

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

    Private Sub staffregbtn_Click(sender As Object, e As EventArgs) Handles staffregbtn.Click
        If String.IsNullOrWhiteSpace(stafffnametxt.Text) OrElse
           String.IsNullOrWhiteSpace(stafflnametxt.Text) OrElse
           String.IsNullOrWhiteSpace(staffcompostxt.Text) OrElse
           String.IsNullOrWhiteSpace(staffemailtxt.Text) OrElse
           staffgendercb.SelectedIndex = -1 OrElse
           staffcomptxt.SelectedIndex = -1 Then

            MessageBox.Show("Please fill out all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn.Open()
            Dim supID As String = GenerateSupervisorID()
            Dim companyID As String = CType(staffcomptxt.SelectedItem, KeyValuePair(Of String, String)).Key

            Dim cmd As New MySqlCommand("
                INSERT INTO companycontact
                (SupervisorID, SupervisorFirstName, MiddleName, SupervisorLastName, Suffix, SupervisorPosition,
                 SupervisorEmail, ContactNumber, Gender, CompanyID, CompanyContact)
                VALUES
                (@ID, @FirstName, @MiddleName, @LastName, @Suffix, @Position,
                 @Email, @ContactNumber, @Gender, @CompanyID, @CompanyContact)
            ", conn)

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

            '===========================
            ' CREATE USER FOR SUPERVISOR
            ' Username = SupervisorID
            ' Password = lastname_firstname
            '===========================
            Dim username As String = supID
            Dim password As String = stafflnametxt.Text.Trim() & "_" & stafffnametxt.Text.Trim()

            If CreateUserAccount(username, password, "Supervisor", Nothing, Nothing, supID) Then
                MessageBox.Show("Supervisor registered successfully!" & vbCrLf &
                                "Supervisor ID: " & supID & vbCrLf &
                                "Username: " & username & vbCrLf &
                                "Password: " & password,
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                skipCloseConfirmation = True

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
            Else
                MessageBox.Show("Supervisor saved, but account creation failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            ClearAllText(Me)
            staffidtxt.Text = GenerateSupervisorID()

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub staffreturnbtn_Click(sender As Object, e As EventArgs) Handles staffreturnbtn.Click
        If MessageBox.Show("Return to registration page?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            skipCloseConfirmation = True
            Try
                Me.DialogResult = DialogResult.Cancel
            Catch
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub staffclearbtn_Click(sender As Object, e As EventArgs) Handles staffclearbtn.Click
        If MessageBox.Show("Are you sure you want to clear all fields?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ClearAllText(Me)

            staffgendercb.SelectedIndex = -1
            staffcomptxt.SelectedIndex = -1

            staffidtxt.Text = GenerateSupervisorID()
        End If
    End Sub

    'comment to muna to kulang isa textbox for company address

    'Private Sub staffaddcompbtn_Click(sender As Object, e As EventArgs) Handles staffaddcompbtn.Click
    '    Dim companyName = staffcomptxt.Text.Trim()
    '    Dim companyAddress = staffnewcompaddtxt.Text.Trim() 'walapa

    '    If String.IsNullOrWhiteSpace(companyName) OrElse String.IsNullOrWhiteSpace(companyAddress) Then
    '        MessageBox.Show("Enter Company Name and Address", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return
    '    End If

    '    Dim companyID = GenerateCompanyID()

    '    Try
    '        conn.Open()
    '        Dim cmd As New MySqlCommand("INSERT INTO company (CompanyID, CompanyName, CompanyAddress) VALUES (@id, @name, @address)", conn)
    '        cmd.Parameters.AddWithValue("@id", companyID)
    '        cmd.Parameters.AddWithValue("@name", companyName)
    '        cmd.Parameters.AddWithValue("@address", companyAddress)
    '        cmd.ExecuteNonQuery()

    '        MessageBox.Show("Company added successfully! ID: " & companyID)
    '        staffcomptxt.Text.Trim()
    '        staffnewcompaddtxt.Clear() ' walapa
    '    Catch ex As Exception
    '        MessageBox.Show("Error adding company: " & ex.Message)
    '    Finally
    '        conn.Close()
    '    End Try
    'End Sub

    'Private Function GenerateCompanyID() As String
    '    Dim nextID As Integer = 1
    '    Try
    '        conn.Open()
    '        Dim cmd As New MySqlCommand("SELECT CompanyID FROM company ORDER BY CompanyID DESC LIMIT 1", conn)
    '        Dim result = cmd.ExecuteScalar()

    '        If result IsNot Nothing Then
    '            Dim lastNumber As String = result.ToString().Substring(2)
    '            nextID = Integer.Parse(lastNumber) + 1
    '        End If

    '    Catch ex As MySqlException
    '        MessageBox.Show("Database error: " & ex.Message)
    '    Finally
    '        conn.Close()
    '    End Try

    '    Return "CO" & nextID.ToString("D3")
    'End Function

End Class
