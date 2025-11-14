Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles
Public Class StudentRegistrationForm

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

    Private ReadOnly courseDict As New Dictionary(Of String, String) From {
        {"Bachelor of Science in Information Technology", "BSIT"},
        {"Bachelor of Science in Computer Science", "BSCS"},
        {"Bachelor of Secondary Education - English", "BSED-E"},
        {"Bachelor of Secondary Education - Math", "BSED-M"},
        {"Bachelor of Elementary Education - Filipino", "BEED"},
        {"Bachelor of Science in Marketing Management", "BSMM"},
        {"Bachelor of Science in Human Resource Management", "BSHR"},
        {"Bachelor of Science in Civil Engineering", "BSCE"},
        {"Bachelor of Science in Mechanical Engineering", "BSME"},
        {"Bachelor of Science in Electrical Engineering", "BSEE"},
        {"Bachelor of Arts in Psychology", "BAPSY"},
        {"Bachelor of Science in Biology", "BSBIO"},
        {"Bachelor of Science in Political Science", "BSPS"},
        {"Bachelor of Science in Hospitality Management", "BSHM"},
        {"Bachelor of Science in Tourism Management", "BSTM"},
        {"Bachelor of Science in Nursing", "BSN"},
        {"Bachelor of Science in Medical Technology", "BSMT"},
        {"Bachelor of Science in Pharmacy", "BSPH"}
    }

    Private ReadOnly sections As String() = {
        "1A", "1B", "1C", "1D", "1E", "1F",
        "2A", "2B", "2C", "2D", "2E", "2F",
        "3A", "3B", "3C", "3D", "3E", "3F",
        "4A", "4B", "4C", "4D", "4E", "4F"
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        studdeptcb.Items.Clear()
        For Each dept As String In departmentDict.Keys
            studdeptcb.Items.Add(dept)
        Next
        studdeptcb.DropDownStyle = ComboBoxStyle.DropDownList
        studdeptcb.SelectedIndex = -1

        studcourcb.Items.Clear()
        studcourcb.Enabled = False

        studsectioncb.Items.Clear()
        studsectioncb.Enabled = False

        studgendercb.Items.Clear()
        studgendercb.Items.AddRange({"M", "F"})
        studgendercb.DropDownStyle = ComboBoxStyle.DropDownList
        studgendercb.SelectedIndex = -1

        studnotxt.Text = GeneratedStudentID()
    End Sub

    Private Sub studdeptcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studdeptcb.SelectedIndexChanged
        studcourcb.Items.Clear()
        studsectioncb.Items.Clear()
        studsectioncb.Enabled = False

        If studcourcb.SelectedItem Is Nothing Then
            studcourcb.Enabled = False
            Return
        End If

        studcourcb.Enabled = True
        studcourcb.Items.Clear()

        For Each kvp In courseDict
            studcourcb.Items.Add(kvp.Key)
        Next
        studcourcb.SelectedIndex = -1
    End Sub

    Private Sub studcourcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studcourcb.SelectedIndexChanged
        studsectioncb.Items.Clear()
        studsectioncb.Items.AddRange(sections)
        studsectioncb.Enabled = True
        studsectioncb.SelectedIndex = -1
    End Sub

    Private Function GeneratedStudentID() As String
        Dim yearprefix As String = (DateTime.Now.Year Mod 100).ToString("D2")
        Dim nextid As Integer = 1

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT StudentID FROM student WHERE StudentID LIKE @YearPrefix ORDER BY StudentID DESC LIMIT 1", conn)
            cmd.Parameters.AddWithValue("@YearPrefix", yearprefix & "- %")
            Dim result = cmd.ExecuteScalar()

            If result IsNot Nothing Then
                Dim lastid As String = result.ToString().Split("-"c)(1).Trim()
                nextid = Integer.Parse(lastid) + 1
            End If
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        Return yearprefix & " - " & nextid.ToString("D5")
    End Function

    Private Sub studregbtn_Click(sender As Object, e As EventArgs) Handles studregbtn.Click
        If String.IsNullOrWhiteSpace(studfnametxt.Text) OrElse
        String.IsNullOrWhiteSpace(studlastntxt.Text) OrElse
        studgendercb.SelectedIndex = -1 OrElse
        studdeptcb.SelectedIndex = -1 OrElse
        studcourcb.SelectedIndex = -1 OrElse
        String.IsNullOrWhiteSpace(studnumtxt.Text) OrElse
        String.IsNullOrWhiteSpace(studemailtxt.Text) OrElse
        String.IsNullOrWhiteSpace(studnotxt.Text) Then

            MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn.Open()


            Dim cmd As New MySqlCommand("
                INSERT INTO student 
                (StudentID, StudentFirstName, StudentMiddleName, StudentLastName, Gender, StudentContantNo, StudentEmail, CourseID)
                VALUES 
                (@StudentID, @FirstName, @MiddleName, @LastName, @Gender, @ContantNo, @Email, @CourseID)
                ", conn)

            Dim studentID As String = studnotxt.Text.Trim()
            Dim courseID As String = courseDict(studcourcb.SelectedItem.ToString())

            cmd.Parameters.AddWithValue("@StudentID", studentID)
            cmd.Parameters.AddWithValue("@FirstName", studfnametxt.Text.Trim())
            cmd.Parameters.AddWithValue("@MiddleName", studmiddlentxt.Text.Trim())
            cmd.Parameters.AddWithValue("@LastName", studlastntxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Gender", studgendercb.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@ContantNo", studnumtxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Email", studemailtxt.Text.Trim())
            cmd.Parameters.AddWithValue("@CourseID", courseID)

            cmd.ExecuteNonQuery()

            '====================================
            ' CREATE LOGIN ACCOUNT (users + useraccounts)
            ' Username = StudentID
            ' Password = lastname_firstname
            '====================================
            Dim username As String = studentID
            Dim password As String = studlastntxt.Text.Trim() & "_" & studfnametxt.Text.Trim()

            If CreateUserAccount(username, password, "Student", studentID, Nothing, Nothing) Then
                MessageBox.Show(
                "Student registered successfully!" & vbCrLf &
                "Student ID: " & studentID & vbCrLf &
                "Username: " & username & vbCrLf &
                "Password: " & password,
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Student saved, but failed to create login account.",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            studnotxt.Text = GeneratedStudentID()

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub studclearbtn_Click(sender As Object, e As EventArgs) Handles studclearbtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear all fields?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ClearAllText(Me)
            studdeptcb.SelectedIndex = -1
            studcourcb.Items.Clear()
            studcourcb.Enabled = False
            studsectioncb.Items.Clear()
            studsectioncb.Enabled = False
            studgendercb.SelectedIndex = -1


            studnotxt.Text = GeneratedStudentID()
        End If
    End Sub

    Private Sub ClearAllText(parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is MaskedTextBox Then
                CType(ctrl, TextBox).Clear()
            ElseIf ctrl.HasChildren Then
                ClearAllText(ctrl)
            End If
        Next
    End Sub

    Private Sub studreternbtn_Click(sender As Object, e As EventArgs) Handles studreternbtn.Click
        Dim result As DialogResult = MessageBox.Show("Return to registration page?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            Dim regForm As New Registration()
            regForm.Show()
        End If
    End Sub

    'to fix
    'wala sa sql
    'suffix
    'section
    'dept
End Class
