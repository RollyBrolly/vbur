Imports MySql.Data.MySqlClient
Public Class StaffRegistrationForm
    Private Function GenerateSupervisorID() As String
        Dim newID As String = "S001"

        Try
            Using conn As New MySqlConnection(connstring)
                conn.Open()

                Dim query As String = "SELECT SupervisorID FROM companycontact ORDER BY SupervisorID DESC LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    Dim result = cmd.ExecuteScalar()

                    If result IsNot Nothing Then
                        Dim lastID As String = result.ToString()
                        Dim nextID As Integer = Integer.Parse(lastID.Substring(1)) + 1
                        newID = "S" & nextID.ToString("000")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating Supervisor ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return newID
    End Function

    Private Sub LoadCompanies()
        Try
            staffcomptxt.Items.Clear()

            Using conn As New MySqlConnection(connstring)
                conn.Open()

                Dim query As String = "SELECT CompanyName FROM company"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            staffcomptxt.Items.Add(reader("CompanyName").ToString() & " - " & reader("CompanyName").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading companies: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        staffidtxt.Text = GenerateSupervisorID()
        staffidtxt.ReadOnly = True

        LoadCompanies()

        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ConfirmExit(e)
    End Sub

    Private Sub staffregbtn_Click(sender As Object, e As EventArgs) Handles staffregbtn.Click
        Try
            Using conn As New MySqlConnection(connstring)
                conn.Open()

                '===========================
                ' GENERATE NEW SUPERVISOR ID
                '===========================
                Dim supID As String = GenerateSupervisorID()

                '===========================
                ' INSERT INTO companycontact
                '===========================
                Dim query As String =
                "INSERT INTO companycontact
                (SupervisorID, SupervisorFirstName, SupervisorLastName, SupervisorPosition,
                 SupervisorEmail, SupervisorPhone, CompanyID, CompanyContact)
                 VALUES
                (@id, @fn, @ln, @pos, @em, @ph, @cid, @contact)"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@id", supID)
                    cmd.Parameters.AddWithValue("@fn", stafffnametxt.Text)
                    cmd.Parameters.AddWithValue("@ln", stafflnametxt.Text)
                    cmd.Parameters.AddWithValue("@pos", staffcompostxt.Text)
                    cmd.Parameters.AddWithValue("@em", staffemailtxt.Text)
                    cmd.Parameters.AddWithValue("@ph", staffcompnumtxt.Text)

                    cmd.ExecuteNonQuery()
                End Using

                '===========================
                ' CREATE USER FOR SUPERVISOR
                ' Username = SupervisorID
                ' Password = lastname_firstname
                '===========================
                Dim username As String = supID
                Dim password As String = stafflnametxt.Text & "_" & stafffnametxt.Text

                If CreateUserAccount(username, password, "Supervisor", Nothing, Nothing, supID) Then
                    MessageBox.Show(
                    "Supervisor Registered Successfully!" & vbCrLf &
                    "Supervisor ID: " & supID & vbCrLf &
                    "Username: " & username & vbCrLf &
                    "Password: " & password
                )
                End If

            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub staffreturnbtn_Click(sender As Object, e As EventArgs) Handles staffreturnbtn.Click
        Dim result As DialogResult = MessageBox.Show("Return to registration page?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim reg As New Registration()
            reg.Show()
            Me.Hide()
        End If
    End Sub

End Class
