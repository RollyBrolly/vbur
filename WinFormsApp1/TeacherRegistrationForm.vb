Imports MySql.Data.MySqlClient
Imports System.Linq

Public Class TeacherRegistrationForm
    Private conn As New MySqlConnection(connectdb.connstring)
    Private ReadOnly genders As String() = {"Male", "Female"}
    Private skipCloseConfirmation As Boolean = False

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

    Private Sub LoadDepartments()
        tcdeptcb.Items.Clear()
        tcdeptcb.Enabled = True
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT DepartmentID, DeptName FROM department ORDER BY DeptName", conn)
            Dim reader = cmd.ExecuteReader()

            While reader.Read()
                tcdeptcb.Items.Add(New KeyValuePair(Of String, String)(reader("DepartmentID").ToString(), reader("DeptName").ToString()))
            End While

            tcdeptcb.DisplayMember = "Value"
            tcdeptcb.ValueMember = "Key"
            tcdeptcb.Enabled = True

            reader.Close()
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Function GenerateFacultyID() As String
        Dim nextID As Integer = 1

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT FacultyID FROM faculty ORDER BY FacultyID", conn)
            Dim reader = cmd.ExecuteReader()
            Dim ids As New List(Of Integer)

            While reader.Read()
                ids.Add(Integer.Parse(reader("FacultyID").ToString().Substring(1)))
            End While
            reader.Close()

            While ids.Contains(nextID)
                nextID += 1
            End While

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Return "F" & nextID.ToString("D3")
    End Function

    Private Sub tcclearbtn_Click(sender As Object, e As EventArgs) Handles tcclearbtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear all fields?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ClearAllText(Me)
            tcdeptcb.SelectedIndex = -1
            tcgendercb.SelectedIndex = -1
            tcfnumbertxt.Text = GenerateFacultyID()
        End If
    End Sub

    Private Sub ClearAllText(parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            ElseIf ctrl.HasChildren Then
                ClearAllText(ctrl)
            End If
        Next
    End Sub

    Private Sub tcregbtn_Click(sender As Object, e As EventArgs) Handles tcregbtn.Click
        If String.IsNullOrWhiteSpace(tcfnametxt.Text) OrElse
           String.IsNullOrWhiteSpace(tclastnametxt.Text) OrElse
           tcdeptcb.SelectedIndex = -1 OrElse
           String.IsNullOrWhiteSpace(tcemailtxt.Text) OrElse
           String.IsNullOrWhiteSpace(tcfnumbertxt.Text) OrElse
           tcgendercb.SelectedIndex = -1 Then

            MessageBox.Show("Please fill out all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("
                INSERT INTO faculty 
                (FacultyID, FacultyFirstName, FacultyMiddleName, FacultyLastName, Suffix, ContactNumber, Gender, FacultyEmail, IsEvaluator, DeptID)
                VALUES 
                (@FacultyID, @FirstName, @MiddleName, @LastName, @Suffix, @ContactNumber, @Gender, @Email, @IsEvaluator, @DeptID)
            ", conn)

            Dim facultyID As String = tcfnumbertxt.Text.Trim()
            Dim deptID As String = CType(tcdeptcb.SelectedItem, KeyValuePair(Of String, String)).Key

            cmd.Parameters.AddWithValue("@FacultyID", facultyID)
            cmd.Parameters.AddWithValue("@FirstName", tcfnametxt.Text.Trim())
            cmd.Parameters.AddWithValue("@MiddleName", If(String.IsNullOrWhiteSpace(tcmidnametxt.Text), DBNull.Value, tcmidnametxt.Text.Trim()))
            cmd.Parameters.AddWithValue("@LastName", tclastnametxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Suffix", If(String.IsNullOrWhiteSpace(tcsuffixtxt.Text), DBNull.Value, tcsuffixtxt.Text.Trim()))
            cmd.Parameters.AddWithValue("@ContactNumber", tcfnumbertxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Gender", tcgendercb.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Email", tcemailtxt.Text.Trim())
            cmd.Parameters.AddWithValue("@IsEvaluator", 0)
            cmd.Parameters.AddWithValue("@DeptID", deptID)

            cmd.ExecuteNonQuery()

            '======================== =
            ' CREATE ACCOUNT
            ' Username = FacultyID
            ' Password = lastname_firstname
            '=========================
            Dim username As String = facultyID
            Dim password As String = tclastnametxt.Text.Trim() & "_" & tcfnametxt.Text.Trim()

            If CreateUserAccount(username, password, "Faculty", Nothing, facultyID, Nothing) Then
                MessageBox.Show("Teacher registered successfully!" & vbCrLf &
                "Faculty ID: " & facultyID & vbCrLf &
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
                MessageBox.Show("Teacher saved, but account creation failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            ClearAllText(Me)
            tcdeptcb.SelectedIndex = -1
            tcgendercb.SelectedIndex = -1
            tcfnumbertxt.Text = GenerateFacultyID()

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub tcreturnbtn_Click(sender As Object, e As EventArgs) Handles tcreturnbtn.Click
        Dim result As DialogResult = MessageBox.Show("Return to registration page?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            skipCloseConfirmation = True
            Try
                Me.DialogResult = DialogResult.Cancel
            Catch
            End Try
            Me.Close()
        End If
    End Sub
End Class
