Imports System.Globalization
Imports System.IO
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class facultyDashboard
    ' ---------------- PROPERTIES ----------------
    ' Login UserID passed from Login form
    Public Property UserID As Integer

    ' FacultyID retrieved from useraccounts based on UserID
    Private _facultyID As String
    Private Property FacultyID As String
        Get
            Return _facultyID
        End Get
        Set(value As String)
            _facultyID = value
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
            Return Path.Combine(folder, $"{FacultyID}.txt")
        End Get
    End Property
    ' ---------------- FORM LOAD ----------------
    Private Sub facultyDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        ' Initialize connection
        conn = New MySqlConnection(connectdb.connstring)
        GetFacultyIDFromUserID()
        LoadFacultyData()

        LoadTasks()

        Dim userID As String = FacultyID
        Dim userType As String = "Faculty"

        UpdateTimeInOutButton(userID, userType)
        UpdateTimeOutLabel(userID, userType)
    End Sub

    ' ---------------- GET FACULTYID ----------------
    Private Sub GetFacultyIDFromUserID()
        Try
            conn.Open()
            ' Query useraccounts table
            Dim query As String = "SELECT FacultyID From useraccounts WHERE UserID = @uid"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@uid", UserID)
            Dim result = cmd.ExecuteScalar()

            'Assign FacultyID or Show error 
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                FacultyID = result.ToString()
            Else
                MessageBox.Show("Facaulty account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error retrieving faculty ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        Finally
            conn.Close()
        End Try
    End Sub

    ' ---------------- LOAD FACULTY DATA ----------------
    Private Sub LoadFacultyData()
        If String.IsNullOrEmpty(FacultyID) Then Return

        Try
            conn.Open()
            ' Join Faculty -> course -> department
            Dim query As String = "
                    SELECT f.FacultyID, f.FacultyFirstName, f.FacultyLastName, 
                    f.FacultyEmail, f.MiddleName, f.Suffix, 
                    f.ContactNumber, d.DeptName
                    FROM faculty f
                    JOIN department d ON f.DeptID = d.DepartmentID
                    WHERE f.FacultyID = @fid
                    "

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@fid", FacultyID)
            dr = cmd.ExecuteReader()

            ' Populate labels
            If dr.Read() Then
                fid.Text = dr("FacultyID").ToString()
                femail.Text = dr("FacultyEmail").ToString()
                fcontact.Text = dr("ContactNumber").ToString()
                fdept.Text = dr("DeptName").ToString()

                Dim ti As TextInfo = CultureInfo.CurrentCulture.TextInfo
                ' First name
                Dim firstName As String = dr("FacultyFirstName").ToString().Trim()
                If firstName <> "" Then firstName = ti.ToTitleCase(firstName.ToLower())

                ' Last name
                Dim lastName As String = dr("FacultyLastName").ToString().Trim()
                If lastName <> "" Then lastName = ti.ToTitleCase(lastName.ToLower())

                ' Middle initial
                Dim middleInitial As String = ""
                Dim middleName As String = dr("MiddleName").ToString().Trim()
                If middleName <> "" Then middleInitial = " " & Char.ToUpper(middleName(0))

                ' Suffix
                Dim suffix As String = If(dr("Suffix").ToString() <> "", " " & dr("Suffix").ToString(), "")

                fwelcome.Text = "Welcome, " & firstName & middleInitial & " " & lastName & suffix
                '' Load photo if exists
                'Dim photoPath As String = "images/Facultys/" & dr("FacultyID").ToString() & ".jpg"
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

    Private Sub dashboardTimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timetodatlbl.Text = "Today: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        Dim timer As New Timer()
        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Interval = 1000
        timer.Start()
    End Sub

    ' ---------------- TIMER ----------------
    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        timetodatlbl.Text = "Today: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    ' ---------------- TIME IN / TIME OUT ----------------
    Private Sub timeinbtn_Click(sender As Object, e As EventArgs) Handles timeinbtn.Click
        If String.IsNullOrEmpty(FacultyID) Then Return

        Dim userID As String = FacultyID
        Dim userType As String = "Faculty"

        If Not UserExists(userID, userType) Then
            MessageBox.Show($"{userType} ID not found.")
            Return
        End If

        Dim lastAction As String = GetLastActionToday(userID, userType)
        Dim nowTime As DateTime = DateTime.Now

        Select Case lastAction
            Case "IN"
                If HasTimeOutToday(userID, userType) Then
                    MessageBox.Show("You have already timed out today.")
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

        UpdateTimeInOutButton(userID, userType)
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

    ' ---------------- DATABASE FUNCTIONS ----------------
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

    ' ---------------- USER VALIDATION ----------------
    Private Function UserExists(userID As String, userType As String) As Boolean
        Dim tableName As String = If(userType = "Student", "student", If(userType = "Faculty", "faculty", "supervisor"))
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

    ' ---------------- viewsched ----------------
    Private Sub viewschedbtn_Click(sender As Object, e As EventArgs) Handles viewschedbtn.Click
        Dim scheduleForm As New scheduleForm()
        scheduleForm.FacultyID = Me.FacultyID
        scheduleForm.ReadOnlyMode = False
        scheduleForm.ShowDialog()
    End Sub

    ' ---------------- Task ----------------
    Private Sub completaskbtn_Click(sender As Object, e As EventArgs) Handles completaskbtn.Click
        Dim tasks = factaskspnl.Controls.OfType(Of CheckBox)().ToList()
        If tasks.Count = 0 Then
            MessageBox.Show("No tasks to complete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show($"Complete all {tasks.Count} tasks?", "Complete Tasks", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            For Each cb In tasks
                factaskspnl.Controls.Remove(cb)
                cb.Dispose()
            Next
            ReflowTasks()
            UpdatePendingLabel()
            SaveTasks()
        End If
    End Sub

    Private Sub addtasksbtn_Click(sender As Object, e As EventArgs) Handles addtasksbtn.Click
        Dim currentTasks = factaskspnl.Controls.OfType(Of CheckBox)().ToList()
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
        factaskspnl.Controls.Add(cb)
        ReflowTasks()
        UpdatePendingLabel()
        SaveTasks()
    End Sub

    ' ---------------- LOADTASKS ----------------
    Private Sub LoadTasks()
        For Each cb In factaskspnl.Controls.OfType(Of CheckBox)().ToList()
            factaskspnl.Controls.Remove(cb)
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
                factaskspnl.Controls.Add(cb)
            Next
        End If

        ReflowTasks()
        UpdatePendingLabel()
    End Sub

    Private Sub TaskCheckChanged(sender As Object, e As EventArgs)
        Dim cb = TryCast(sender, CheckBox)
        If cb Is Nothing OrElse Not cb.Checked Then Return

        If MessageBox.Show("Complete this task?", "Complete Task", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            factaskspnl.Controls.Remove(cb)
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
        Dim tasks = factaskspnl.Controls.OfType(Of CheckBox)().ToList()
        For i As Integer = 0 To tasks.Count - 1
            tasks(i).Top = TaskStartTop + (i * TaskSpacing)
        Next
    End Sub

    Private Sub UpdatePendingLabel()
        taskslbl.Text = $"Pending Tasks: {factaskspnl.Controls.OfType(Of CheckBox)().Count()}"
    End Sub
    ' ---------------- BUTTONS ----------------
    ' You can edit these functions for actual features later
    Private Sub studrecordbtn_Click(sender As Object, e As EventArgs) Handles studrecordbtn.Click
        Dim studentRecord As New facultyStudentRecord()
        studentRecord.FacultyID = Me.FacultyID
        studentRecord.Show()
        Me.Hide()
    End Sub
    Private Sub gradestudbtn_Click(sender As Object, e As EventArgs) Handles gradestudbtn.Click
        Dim studentGrades As New facultyGradeStudents()
        studentGrades.FacultyID = Me.FacultyID
        studentGrades.Show()
        Me.Hide()
    End Sub
    Private Sub SaveTasks()
        Dim lines As New List(Of String)
        For Each cb In factaskspnl.Controls.OfType(Of CheckBox)()
            lines.Add(cb.Text)
        Next
        File.WriteAllLines(TasksFile, lines)
    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        If MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
            Dim loginForm As New Login()
            loginForm.Show()
        End If
    End Sub


End Class
