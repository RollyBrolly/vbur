Imports MySql.Data.MySqlClient

Public Class Login
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passtxt.UseSystemPasswordChar = True
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub



    Private Sub showpasschkb_CheckedChanged(sender As Object, e As EventArgs) Handles showpasschkb.CheckedChanged
        passtxt.UseSystemPasswordChar = Not showpasschkb.Checked
    End Sub

    Private Sub signupbtn_Click(sender As Object, e As EventArgs) Handles signupbtn.Click
        Dim registrationForm As New Registration(Me)
        registrationForm.Show()
        Me.Hide()
    End Sub

    Private Sub signinbtn_Click(sender As Object, e As EventArgs) Handles signinbtn.Click
        If String.IsNullOrWhiteSpace(usertxt.Text) OrElse String.IsNullOrWhiteSpace(passtxt.Text) Then
            MessageBox.Show("Please enter username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(connectdb.connstring)
                conn.Open()
                Dim query As String = "SELECT UserID, Role FROM users WHERE Username=@u AND PasswordHash=@p"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@u", usertxt.Text)
                    cmd.Parameters.AddWithValue("@p", passtxt.Text)

                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim userID As Integer = Convert.ToInt32(reader("UserID"))
                            Dim role As String = reader("Role").ToString()

                            Me.Hide()
                            Select Case role
                                'Case "Admin"
                                '    Dim adminForm As New AdminDashboard()
                                '    adminForm.userID = userID
                                '    adminForm.Show()
                                Case "Student"
                                    Dim studentForm As New studentDashboard()
                                    studentForm.UserID = userID.ToString()
                                    studentForm.Show()
                                Case "Faculty"
                                    Dim facultyForm As New facultyDashboard()
                                    facultyForm.UserID = userID.ToString()
                                    facultyForm.Show()
                                Case "Supervisor"
                                    Dim supervisorForm As New supervisorDashboard()
                                    supervisorForm.UserID = userID.ToString()
                                    supervisorForm.Show()
                                Case Else
                                    MessageBox.Show("Unknown role. Cannot open dashboard.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Me.Show()
                                    Exit Sub
                            End Select

                        Else
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub systemexitbtn_Click(sender As Object, e As EventArgs) Handles systemexitbtn.Click
        Dim result = MessageBox.Show("Are you sure you want to shut down the system?", "Confirm Shutdown", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
