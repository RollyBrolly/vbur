Imports System.Diagnostics.Contracts
Imports System.Globalization
Imports System.IO
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class supervisorDashboard
    ' ---------------- PROPERTIES ----------------
    ' Login UserID passed from Login form
    Public Property UserID As Integer

    Public Property SuperID As String

    ' SupervisorID retrieved from useraccounts based on UserID
    Private _supervisorID As String
    Private Property SupervisorID As String
        Get
            Return _supervisorID
        End Get
        Set(value As String)
            _supervisorID = value
        End Set
    End Property

    ' Database connection objects
    Private conn As MySqlConnection
    Private cmd As MySqlCommand
    Private dr As MySqlDataReader

    ' ---------------- TASKS ----------------
    Private Const MaxTasks As Integer = 5
    Private Const MaxTaskTextLength As Integer = 50
    Private ReadOnly TaskStartTop As Integer = 101
    Private ReadOnly TaskLeft As Integer = 33
    Private ReadOnly TaskSpacing As Integer = 40

    Private ReadOnly Property TasksFile As String
        Get
            Dim folder As String = Path.Combine(Application.StartupPath, "Tasks", "Student")
            If Not Directory.Exists(folder) Then Directory.CreateDirectory(folder)
            Return Path.Combine(folder, $"{SupervisorID}.txt")
        End Get
    End Property

    ' ---------------- FORM LOAD ----------------
    Private Async Sub supervisorDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Maximize form
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        conn = New MySqlConnection(connectdb.connstring)
        GetSupervisorIDFromUserID()
        LoadSupervisorData()

        LoadTasks()

        Dim userID As String = SupervisorID
        Dim userType As String = "Supervisor"

        UpdateTimeInOutButton(userID, userType)
        UpdateTimeOutLabel(userID, userType)

        Try
            Await web.EnsureCoreWebView2Async()
        Catch ex As Exception
            MessageBox.Show("Unable to initialize browser: " & ex.Message)
        End Try
    End Sub

    ' ---------------- GET SUPERVISORID ----------------
    Private Sub GetSupervisorIDFromUserID()
        Try
            conn.Open()
            Dim query As String = "SELECT SupervisorID FROM useraccounts WHERE UserID = @uid"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@uid", UserID)
            Dim result = cmd.ExecuteScalar()

            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                SupervisorID = result.ToString()
                Me.SuperID = SupervisorID
            Else
                MessageBox.Show("Supervisor account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error retrieving supervisor ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        Finally
            conn.Close()
        End Try
    End Sub

    ' ---------------- LOAD SUPERVISOR DATA ----------------
    Private Sub LoadSupervisorData()
        If String.IsNullOrEmpty(SupervisorID) Then Return

        Try
            conn.Open()
            ' Join student -> course -> department
            Dim query As String = "
                SELECT s.SupervisorID, s.SupervisorFirstName, s.SupervisorLastName, s.SupervisorEmail, s.MiddleName, 
                       s.Suffix, s.ContactNumber, s.SupervisorPosition, s.Gender, c.CompanyName , c.CompanyAddress
                FROM Supervisor s
                JOIN company c ON c.CompanyID = s.CompanyID
                WHERE s.SupervisorID = @sid
                "
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@sid", SupervisorID)
            dr = cmd.ExecuteReader()

            ' Populate labels
            If dr.Read() Then
                staffid.Text = dr("SupervisorID").ToString()
                staffemail.Text = dr("SupervisorEmail").ToString()
                staffcontact.Text = dr("ContactNumber").ToString()
                staffpos.Text = dr("SupervisorPosition").ToString()
                staffcomp.Text = dr("CompanyName").ToString()
                staffcompadd.Text = dr("CompanyAddress").ToString()
                staffgender.Text = dr("Gender").ToString()

                Dim ti As TextInfo = CultureInfo.CurrentCulture.TextInfo
                ' First name
                Dim firstName As String = dr("SupervisorFirstName").ToString().Trim()
                If firstName <> "" Then firstName = ti.ToTitleCase(firstName.ToLower())

                ' Last name
                Dim lastName As String = dr("SupervisorLastName").ToString().Trim()
                If lastName <> "" Then lastName = ti.ToTitleCase(lastName.ToLower())

                ' Middle initial
                Dim middleInitial As String = ""
                Dim middleName As String = dr("MiddleName").ToString().Trim()
                If middleName <> "" Then middleInitial = " " & Char.ToUpper(middleName(0))

                ' Suffix
                Dim suffix As String = If(dr("Suffix").ToString() <> "", " " & dr("Suffix").ToString(), "")

                staffwelcome.Text = "Welcome, " & firstName & middleInitial & " " & lastName & suffix
                '' Load photo if exists
                'Dim photoPath As String = "images/students/" & dr("StudentID").ToString() & ".jpg"
                'If System.IO.File.Exists(photoPath) Then
                '    studpb.Image = Image.FromFile(photoPath)
                'End If
            Else
                MessageBox.Show("Faculty data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading faculty data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timetodatlbl.Text = "Today: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        Dim timer As New Timer()
        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Interval = 1000
        timer.Start()
    End Sub

    ' ---------------- TIMER ----------------
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        timetodatlbl.Text = "Today: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    ' ---------------- TIME IN / TIME OUT ----------------
    Private Sub timeinbtn_Click(sender As Object, e As EventArgs) Handles timeinbtn.Click
        If String.IsNullOrEmpty(SupervisorID) Then Return

        Dim userID = SupervisorID
        Dim userType = "Supervisor"

        If Not UserExists(userID, userType) Then
            MessageBox.Show($"{userType} ID not found.")
            Return
        End If

        Dim lastAction = GetLastActionToday(userID, userType)
        Dim nowTime = Date.Now

        Select Case lastAction
            Case "IN"
                If HasTimeOutToday(userID, userType) Then
                    MessageBox.Show("You have already timed out for today.")
                Else
                    RecordAttendance(userID, userType, "OUT", nowTime)
                    timeoutlbl.Text = $"Time Out at {nowTime:HH:mm:ss}"
                End If
            Case "OUT"
                MessageBox.Show("You have already completed your attendance today.")
            Case Else
                RecordAttendance(userID, userType, "IN", nowTime)
                timeoutlbl.Text = $"Time In at {nowTime:HH:mm:ss}"
        End Select
    End Sub

    ' ---------------- UPDATE BUTTON / LABEL ----------------
    Private Sub UpdateTimeOutLabel(userID As String, userType As String)
        Dim lastAction As String = GetLastActionToday(userID, userType)
        Dim lastTime As DateTime? = GetLastActionTime(userID, userType)

        If lastAction <> "" AndAlso lastTime.HasValue Then
            timeoutlbl.Text = $"Last Action: {lastAction} at {lastTime:HH:mm:ss}"
        Else
            timeinbtn.Text = "Time In"
        End If
    End Sub

    Private Sub UpdateTimeInOutButton(userID As String, userType As String)
        Dim lastAction As String = GetLastActionToday(userID, userType)
        timeinbtn.Text = If(lastAction = "IN", "Time Out", "Time In")
    End Sub

    Private Sub RecordAttendance(userID As String, userType As String, action As String, actionTime As DateTime)
        Try
            conn.Open()
            Dim query As String = "INSERT INTO attendance (UserID, UserType, ActionType, ActionTime) 
                                   VALUES (@uid, @utype, @action, @time)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@uid", userID)
            cmd.Parameters.AddWithValue("@utype", userType)
            cmd.Parameters.AddWithValue("@action", action)
            cmd.Parameters.AddWithValue("@time", actionTime)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error recording attendance: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Function GetLastActionToday(userID As String, userType As String) As String
        Return ExecuteScalarQuery($"SELECT ActionType FROM attendance WHERE UserID=@uid AND UserType=@utype AND DATE(ActionTime) = 
                                    CURDATE() ORDER BY ActionTime DESC LIMIT 1", userID, userType)
    End Function

    Private Function GetLastActionTime(userID As String, userType As String) As DateTime?
        Dim result As Object = ExecuteScalarQueryObject($"SELECT ActionTime FROM attendance WHERE UserID=@uid AND UserType=@utype 
                                                        ORDER BY ActionTime DESC LIMIT 1", userID, userType)
        Return If(result IsNot Nothing, Convert.ToDateTime(result), Nothing)
    End Function

    Private Function HasTimeOutToday(userID As String, userType As String) As Boolean
        Dim result As Object = ExecuteScalarQueryObject($"SELECT COUNT(*) FROM attendance WHERE UserID=@uid AND UserType=@utype 
                                                          AND ActionType='OUT' AND DATE(ActionTime) = CURDATE()", userID, userType)
        Return Convert.ToInt32(result) > 0
    End Function

    ' ---------------- GENERIC DB HELPERS ----------------
    Private Function ExecuteScalarQuery(query As String, userID As String, userType As String) As String
        Dim value As String = ""
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@uid", userID)
            cmd.Parameters.AddWithValue("@utype", userType)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then value = result.ToString()
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Return value
    End Function
    Private Function ExecuteScalarQueryObject(query As String, userID As String, userType As String) As Object
        Dim value As Object = Nothing
        Try
            conn.Open()
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@uid", userID)
            cmd.Parameters.AddWithValue("@utype", userType)
            value = cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Return value
    End Function

    ' ---------------- task ----------------
    Private Sub completetaskbtn_Click(sender As Object, e As EventArgs) Handles completetaskbtn.Click
        Dim tasks = staffstaskpnl.Controls.OfType(Of CheckBox)().ToList()
        If tasks.Count = 0 Then
            MessageBox.Show("No tasks to complete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show($"Complete all {tasks.Count} tasks?", "Complete Tasks", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            For Each cb In tasks
                staffstaskpnl.Controls.Remove(cb)
                cb.Dispose()
            Next
            ReflowTasks()
            UpdatePendingLabel()
            SaveTasks()
        End If
    End Sub

    Private Sub addtaskbtn_Click(sender As Object, e As EventArgs) Handles addtaskbtn.Click
        Dim currentTasks = staffstaskpnl.Controls.OfType(Of CheckBox)().ToList()
        If currentTasks.Count >= MaxTasks Then
            MessageBox.Show($"You can only have up to {MaxTasks} tasks.", "Task Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim taskText As String = Microsoft.VisualBasic.Interaction.InputBox("Enter task description:", "Add Task").Trim()
        If String.IsNullOrWhiteSpace(taskText) Then Return
        If taskText.Length > MaxTaskTextLength Then
            MessageBox.Show("Task description too long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim cb As New CheckBox() With {
        .Text = taskText,
        .AutoSize = True,
        .Font = New Font("Segoe UI", 14, FontStyle.Bold),
        .ForeColor = Color.Indigo,
        .Left = TaskLeft
    }
        AddHandler cb.CheckedChanged, AddressOf TaskCheckChanged
        staffstaskpnl.Controls.Add(cb)
        ReflowTasks()
        UpdatePendingLabel()
        SaveTasks()
    End Sub

    ' ---------------- LOADTASKS ----------------
    Private Sub LoadTasks()
        For Each cb In staffstaskpnl.Controls.OfType(Of CheckBox)().ToList()
            staffstaskpnl.Controls.Remove(cb)
            cb.Dispose()
        Next

        If File.Exists(TasksFile) Then
            For Each line In File.ReadAllLines(TasksFile)
                Dim cb As New CheckBox() With {
                .Text = line,
                .AutoSize = True,
                .Font = New Font("Segoe UI", 14, FontStyle.Bold),
                .ForeColor = Color.Indigo,
                .Left = TaskLeft
            }
                AddHandler cb.CheckedChanged, AddressOf TaskCheckChanged
                staffstaskpnl.Controls.Add(cb)
            Next
        End If

        ReflowTasks()
        UpdatePendingLabel()
    End Sub

    Private Sub TaskCheckChanged(sender As Object, e As EventArgs)
        Dim cb = TryCast(sender, CheckBox)
        If cb Is Nothing OrElse Not cb.Checked Then Return

        If MessageBox.Show("Complete this task?", "Complete Task", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            staffstaskpnl.Controls.Remove(cb)
            cb.Dispose()
            ReflowTasks()
            UpdatePendingLabel()
            SaveTasks()
        Else
            RemoveHandler cb.CheckedChanged, AddressOf TaskCheckChanged
            cb.Checked = False
            AddHandler cb.CheckedChanged, AddressOf TaskCheckChanged
        End If
    End Sub

    Private Sub ReflowTasks()
        Dim tasks = staffstaskpnl.Controls.OfType(Of CheckBox)().ToList()
        For i As Integer = 0 To tasks.Count - 1
            tasks(i).Top = TaskStartTop + (i * TaskSpacing)
        Next
    End Sub

    Private Sub UpdatePendingLabel()
        pendinglbl.Text = $"Pending Tasks: {staffstaskpnl.Controls.OfType(Of CheckBox)().Count()}"
    End Sub

    Private Sub SaveTasks()
        Dim lines As New List(Of String)
        For Each cb In staffstaskpnl.Controls.OfType(Of CheckBox)()
            lines.Add(cb.Text)
        Next
        File.WriteAllLines(TasksFile, lines)
    End Sub
    ' ---------------- USER VALIDATION ----------------
    Private Function UserExists(userID As String, userType As String) As Boolean
        Dim tableName As String = If(userType = "Student", "student", If(userType = "Faculty", "faculty", "Supervisor"))
        Dim exists As Boolean = False
        Try
            conn.Open()
            Dim query As String = $"SELECT COUNT(*) FROM {tableName} WHERE {tableName}ID=@id"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", userID)
            exists = Convert.ToInt32(cmd.ExecuteScalar()) > 0
        Finally
            conn.Close()
        End Try
        Return exists
    End Function

    ' ---------------- BUTTONS / TASKS ----------------
    Private Sub viewvisitlogbtn_Click(sender As Object, e As EventArgs) Handles viewvisitlogbtn.Click
        Dim visit As New visitationLogs()
        visit.SuperID = Me.SuperID
        visit.Show()
        Me.Hide()
    End Sub

    Private Sub evalstudbtn_Click(sender As Object, e As EventArgs) Handles evalstudbtn.Click
        Dim eval As New supervisorEvaluation()
        eval.SuperID = Me.SuperID
        eval.Show()
        Me.Hide()
    End Sub

    Private Sub vewinternbtn_Click(sender As Object, e As EventArgs) Handles vewinternbtn.Click
        Dim intern As New internsView()
        intern.SuperID = Me.SuperID
        intern.Show()
        Me.Hide()
    End Sub



    ' ---------------- LOGOUT ----------------
    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        If MessageBox.Show("Return to login page?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim loginForm As New Login
            loginForm.Show()
            Hide()
        End If
    End Sub

    Private Sub viewgradebtn_Click(sender As Object, e As EventArgs) Handles viewgradebtn.Click
        Try
            web.CoreWebView2.Navigate("http://localhost/project/py/index.html")
            panelbrowser.Visible = True
        Catch ex As Exception
            MessageBox.Show("Unable to load the website: " & ex.Message)
        End Try
    End Sub


    'Private Sub viewgradebtn_Click(sender As Object, e As EventArgs) Handles viewgradebtn.Click
    '    Try
    '        Dim psi As New ProcessStartInfo("https://raidev07.github.io/cluster/")
    '        psi.UseShellExecute = True
    '        Process.Start(psi)
    '    Catch ex As Exception
    '        MessageBox.Show("Unable to open the website: " & ex.Message)
    '    End Try
    'End Sub

    Private Sub backsbtn_Click(sender As Object, e As EventArgs) Handles backsbtn.Click
        panelbrowser.Visible = False
    End Sub

End Class
