Imports MySql.Data.MySqlClient
Public Class TeacherRegistrationForm
    Private conn As New MySqlConnection(connectdb.connstring)

    Private ReadOnly departmentDict As New Dictionary(Of String, String) From {
        {"College of Computer Studies", "CCS"},
        {"College of Education", "COED"},
        {"College of Business Management", "CBM"},
        {"College of Marketing", "CMKT"},
        {"College of Arts and Sciences", "CAS"},
        {"College of Hospitality Management", "CHM"},
        {"College of Nursing", "CON"}
    }

    Private ReadOnly genders As String() = {"Male", "Female"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        tcdeptcb.Enabled = True

        tcdeptcb.Items.Clear()
        For Each dept As String In departmentDict.Keys
            tcdeptcb.Items.Add(dept)
        Next
        tcdeptcb.SelectedIndex = -1

        tcgendercb.Items.Clear()
        tcgendercb.Items.AddRange(genders)
        tcgendercb.SelectedIndex = -1

        tcfnumbertxt.Text = GenerateFacultyID()
    End Sub

    Private Function GenerateFacultyID() As String
        Dim nextID As Integer = 1
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT FacultyID FROM faculty ORDER BY FacultyID DESC LIMIT 1", conn)
            Dim result = cmd.ExecuteScalar()

            If result Is Nothing Then
                Dim lastID As String = result.ToString().Substring(1)
                nextID = Integer.Parse(lastID) + 1
            End If
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
       String.IsNullOrWhiteSpace(tcemailtxt.Text) Then

            MessageBox.Show("Please fill out all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn.Open()


            Dim cmd As New MySqlCommand("
                INSERT INTO faculty 
                (FacultyID, FacultyFirstName, FacultyLastName, FacultyEmail, IsEvaluator, DeptID)
                VALUES 
                (@FacultyID, @FirstName, @LastName, @Email, @IsEvaluator, @DeptID)", conn)

            Dim facultyID As String = tcfnumbertxt.Text.Trim()
            Dim deptID As String = departmentDict(tcdeptcb.SelectedItem.ToString())

            cmd.Parameters.AddWithValue("@FacultyID", facultyID)
            cmd.Parameters.AddWithValue("@FirstName", tcfnametxt.Text.Trim())
            cmd.Parameters.AddWithValue("@LastName", tclastnametxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Email", tcemailtxt.Text.Trim())
            cmd.Parameters.AddWithValue("@IsEvaluator", 0)
            cmd.Parameters.AddWithValue("@DeptID", deptID)

            cmd.ExecuteNonQuery()

            '=========================
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
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        ClearAllText(Me)

        tcdeptcb.SelectedIndex = -1


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(tcfnametxt.Text) OrElse
       String.IsNullOrWhiteSpace(tclastnametxt.Text) OrElse
       tcdeptcb.SelectedIndex = -1 Then

            MessageBox.Show("Please fill out all required fields before registering.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        MessageBox.Show("You are now registered as a Teacher!", "Register Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub tcreturnbtn_Click(sender As Object, e As EventArgs) Handles tcreturnbtn.Click
        Dim result As DialogResult = MessageBox.Show("Return to registration page?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim regForm As New Registration()
            regForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub tcdeptcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcdeptcb.SelectedIndexChanged

    End Sub

    'to fix
    'Middle name wala sa SQL
    'Suffix wala sa SQL
    'Contact number wala sa SQL
    ' Gender wala sa SQL
End Class
