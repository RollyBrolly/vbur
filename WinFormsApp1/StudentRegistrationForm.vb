Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles
Imports System.Linq

Public Class StudentRegistrationForm

    Private conn As New MySqlConnection(connectdb.connstring)
    Private ReadOnly sections As String() = {"4A", "4B", "4C", "4D", "4E", "4F"}
    Private skipCloseConfirmation As Boolean = False

    Private Sub StudentRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        studcourcb.DropDownStyle = ComboBoxStyle.DropDownList
        studdeptcb.DropDownStyle = ComboBoxStyle.DropDownList
        studsectioncb.DropDownStyle = ComboBoxStyle.DropDownList
        studcourcb.Enabled = False
        studsectioncb.Enabled = False

        studgendercb.Items.AddRange({"Male", "Female"})
        studgendercb.DropDownStyle = ComboBoxStyle.DropDownList

        LoadDepartments()
        studnotxt.Text = GeneratedStudentID().Trim()
    End Sub

    Private Sub LoadDepartments()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT DepartmentID, DeptName FROM department ORDER BY DeptName", conn)
            Dim reader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    studdeptcb.Items.Add(New KeyValuePair(Of String, String)(reader("DepartmentID").ToString(), reader("DeptName").ToString()))
                End While
                studdeptcb.DisplayMember = "Value"
                studdeptcb.ValueMember = "Key"
                studdeptcb.Enabled = True
            Else
                MessageBox.Show("No departments found in the database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            reader.Close()
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub studdeptcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studdeptcb.SelectedIndexChanged
        studcourcb.Items.Clear()
        studcourcb.Enabled = False
        studsectioncb.Items.Clear()
        studsectioncb.Enabled = False

        If studdeptcb.SelectedIndex = -1 Then Return

        Dim deptID As String = CType(studdeptcb.SelectedItem, KeyValuePair(Of String, String)).Key
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT CourseID, CourseName FROM course WHERE DepartmentID = @DeptID ORDER BY CourseName", conn)
            cmd.Parameters.AddWithValue("@DeptID", deptID)
            Dim reader = cmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    studcourcb.Items.Add(New KeyValuePair(Of String, String)(reader("CourseID").ToString(), reader("CourseName").ToString()))
                End While
                studcourcb.DisplayMember = "Value"
                studcourcb.ValueMember = "Key"
                studcourcb.Enabled = True
            Else
                MessageBox.Show("No courses found for this department.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            reader.Close()
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

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

    Private Function GeneratedStudentID() As String
        Dim yearprefix As String = (DateTime.Now.Year Mod 100).ToString("D2")
        Dim nextID As Integer = 1

        Using conn As New MySqlConnection(connectdb.connstring)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("
            SELECT StudentID FROM student
            WHERE StudentID LIKE @YearPrefix
            ORDER BY StudentID
        ", conn)
                cmd.Parameters.AddWithValue("@YearPrefix", yearprefix & "-%")

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                Dim ids As New List(Of Integer)

                While reader.Read()
                    Dim parts = reader("StudentID").ToString().Split("-"c)
                    If parts.Length = 2 Then
                        ids.Add(Integer.Parse(parts(1))) 
                    End If
                End While
                reader.Close()

                While ids.Contains(nextID)
                    nextID += 1
                End While

            Catch ex As MySqlException
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Return yearprefix & "-" & nextID.ToString("D5")

    End Function

    Private Sub studregbtn_Click(sender As Object, e As EventArgs) Handles studregbtn.Click
        If String.IsNullOrWhiteSpace(studfnametxt.Text) OrElse
           String.IsNullOrWhiteSpace(studlastntxt.Text) OrElse
           studgendercb.SelectedIndex = -1 OrElse
           studdeptcb.SelectedIndex = -1 OrElse
           studcourcb.SelectedIndex = -1 OrElse
           studsectioncb.SelectedIndex = -1 OrElse
           String.IsNullOrWhiteSpace(studnumtxt.Text) OrElse
           String.IsNullOrWhiteSpace(studemailtxt.Text) Then

            MessageBox.Show("Please fill in all required fields.")
            Return
        End If

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("
                INSERT INTO student 
                (StudentID, StudentFirstName, StudentMiddleName, StudentLastName, Suffix, Gender, StudentContactNo, StudentEmail, CourseID, Section)
                VALUES 
                (@StudentID, @FirstName, @MiddleName, @LastName, @Suffix, @Gender, @ContactNo, @Email, @CourseID, @Section)
            ", conn)

            Dim studentID As String = studnotxt.Text.Trim()
            Dim courseID As String = CType(studcourcb.SelectedItem, KeyValuePair(Of String, String)).Key

            cmd.Parameters.AddWithValue("@StudentID", studentID.Replace(" ", ""))
            cmd.Parameters.AddWithValue("@FirstName", studfnametxt.Text.Trim())
            cmd.Parameters.AddWithValue("@MiddleName", If(String.IsNullOrWhiteSpace(studmiddlentxt.Text), DBNull.Value, studmiddlentxt.Text.Trim()))
            cmd.Parameters.AddWithValue("@LastName", studlastntxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Suffix", If(String.IsNullOrWhiteSpace(studsuffixtxt.Text), DBNull.Value, studsuffixtxt.Text.Trim()))
            cmd.Parameters.AddWithValue("@Gender", studgendercb.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@ContactNo", studnumtxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Email", studemailtxt.Text.Trim())
            cmd.Parameters.AddWithValue("@CourseID", courseID)
            cmd.Parameters.AddWithValue("@Section", studsectioncb.SelectedItem.ToString())

            cmd.ExecuteNonQuery()

            Dim username As String = studentID
            Dim password As String = studlastntxt.Text.Trim() & "_" & studfnametxt.Text.Trim()

            If CreateUserAccount(username, password, "Student", studentID, Nothing, Nothing) Then
                MessageBox.Show("Student registered successfully!" &
                                vbCrLf & "Student ID: " & studentID &
                                vbCrLf & "Username: " & username &
                                vbCrLf & "Password: " & password)

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
                MessageBox.Show("Student saved, but failed creating login account.")
            End If

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

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
            studnotxt.Text = GeneratedStudentID().Trim()
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

    Private Sub studreternbtn_Click(sender As Object, e As EventArgs) Handles studreternbtn.Click
        skipCloseConfirmation = True
        Me.Close()
    End Sub

    Private Sub StudentRegistrationForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not skipCloseConfirmation Then
            If MessageBox.Show("Return to registration page?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Me.Hide()
                Dim regForm As New Registration()
                regForm.ShowDialog()
            End If
        End If
    End Sub

End Class
