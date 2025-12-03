Imports System.Reflection
Imports MySql.Data.MySqlClient

Public Class visitationLogs
    Public Property SuperID As String
    Private Sub visitationLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        dgvLogs.Columns.Clear()
        dgvLogs.Columns.Add("colDate", "Date")
        dgvLogs.Columns.Add("colTime", "Time")
        dgvLogs.Columns.Add("colType", "Visitor Type")
        dgvLogs.Columns.Add("Column1", "Visitor Name")
        dgvLogs.Columns.Add("colPurpose", "Purpose")

        dgvLogs.AllowUserToAddRows = False
        dgvLogs.ReadOnly = True
        dgvLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        LoadVisitLogs()
    End Sub

    Private Sub LoadVisitLogs()
        Try
            Using conn As New MySqlConnection(connectdb.connstring)
                conn.Open()
                Dim query As String = "SELECT VisitDate, VisitTime, VisitorType, VisitorName, Purpose FROM visitlogs ORDER BY VisitDate DESC, VisitTime DESC"
                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    dgvLogs.Rows.Clear()
                    For Each row As DataRow In dt.Rows
                        ' Format VisitDate to show only date
                        Dim formattedDate As String = DateTime.Parse(row("VisitDate").ToString()).ToString("yyyy-MM-dd")

                        ' Format VisitTime to 12-hour format with AM/PM
                        Dim formattedTime As String = DateTime.Parse(row("VisitTime").ToString()).ToString("hh:mm tt")

                        dgvLogs.Rows.Add(formattedDate, formattedTime,
                     row("VisitorType").ToString(), row("VisitorName").ToString(),
                     row("Purpose").ToString())
                    Next
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading visit logs: " & ex.Message)
        End Try
    End Sub


    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        Try
            ' Collect input from user
            ' Get current date automatically
            Dim visitDate As String = DateTime.Now.ToString("yyyy-MM-dd")

            ' Current time automatically
            Dim visitTime As String = DateTime.Now.ToString("HH:mm:ss")

            Dim visitorType As String = InputBox("Enter Visitor Type (Intern, Employee, Faculty):", "Visitor Type", "Intern")

            If String.IsNullOrWhiteSpace(visitorType) Then Exit Sub

            visitorType = visitorType.Trim()

            Dim allowedTypes As String() = {"Intern", "Employee", "Faculty"}

            If Not allowedTypes.Contains(visitorType, StringComparer.OrdinalIgnoreCase) Then
                MessageBox.Show("Invalid visitor type. Please enter Intern, Employee, or Faculty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim visitorName As String = InputBox("Enter Visitor Name:", "Visitor Name", "")
            If String.IsNullOrWhiteSpace(visitorName) Then Exit Sub

            Dim purpose As String = InputBox("Enter Purpose of Visit:", "Purpose", "")
            If String.IsNullOrWhiteSpace(purpose) Then Exit Sub

            ' Insert into database
            Using conn As New MySqlConnection(connectdb.connstring)
                conn.Open()
                Dim query As String = "INSERT INTO visitlogs (VisitDate, VisitTime, VisitorType, VisitorName, Purpose) " &
                                      "VALUES (@VisitDate, @VisitTime, @VisitorType, @VisitorName, @Purpose)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@VisitDate", visitDate)
                    cmd.Parameters.AddWithValue("@VisitTime", visitTime)
                    cmd.Parameters.AddWithValue("@VisitorType", visitorType)
                    cmd.Parameters.AddWithValue("@VisitorName", visitorName)
                    cmd.Parameters.AddWithValue("@Purpose", purpose)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Visit log added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadVisitLogs() ' Refresh DataGridView
        Catch ex As Exception
            MessageBox.Show("Error adding visit log: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub returnbtn_Click(sender As Object, e As EventArgs) Handles returnbtn.Click
        If MessageBox.Show("Are you sure you want to Return?", "Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim supForm = Application.OpenForms.OfType(Of supervisorDashboard)().FirstOrDefault()
            If supForm IsNot Nothing Then
                supForm.Show()
            End If

            Me.Close()
        End If
    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        If MessageBox.Show("Are you sure you want to Return?", "Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim returnForm = Application.OpenForms.OfType(Of supervisorDashboard)().FirstOrDefault()
            If returnForm IsNot Nothing Then
                returnForm.Show()
            End If
            Me.Close()
        End If
    End Sub
End Class
