Imports System.Globalization
Imports System.Linq

Public Class facultyDashboard

    Private Const MaxTasks As Integer = 3
    Private Const MaxTaskTextLength As Integer = 20
    Private ReadOnly TaskStartTop As Integer = 119
    Private ReadOnly TaskLeft As Integer = 33
    Private ReadOnly TaskSpacing As Integer = 67

    ' runtime-only label for AM/PM of last timeout
    Private lastOutAmPm As Label
    Private ReadOnly clockTimer As New Timer() With {.Interval = 1000} ' updates every second

    ' ---------------- FORM LOAD ----------------
    Private Sub studentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        ' Wire buttons (always present)
        AddHandler addtasksbtn.Click, AddressOf ButtonAddTask_Click
        AddHandler completetasksbtn.Click, AddressOf ButtonCompleteSelected_Click

        ' Attempt to wire up any design-time checkboxes if they exist.
        ' Use Controls.Find so we don't get compile errors if those controls were removed from designer.
        For i As Integer = 1 To 3
            Dim found() As Control = Me.Controls.Find($"CheckBox{i}", True)
            If found IsNot Nothing AndAlso found.Length > 0 AndAlso TypeOf found(0) Is CheckBox Then
                AddHandler DirectCast(found(0), CheckBox).CheckedChanged, AddressOf TaskCheckChanged
            End If
        Next

        ' Do NOT clear Panel1 here — keep any design-time tasks if present.
        ReflowTasks()

        ' Configure announcements to match pending tasks visually and layout
        ConfigureAnnouncements()
        ReflowAnnouncements()

        ' Initialize time system
        timeinbtn.Text = If(String.IsNullOrWhiteSpace(timeinbtn.Text), "TIME IN", timeinbtn.Text)

        ' Start clock for "Time Today"
        AddHandler clockTimer.Tick, AddressOf UpdateTimeToday
        clockTimer.Start()
        UpdateTimeToday(Nothing, EventArgs.Empty)

        ' Initialize Last Time Out (start blank and hide AM/PM)
        Label7.Text = ""
        CreateOrConfigureLastOutAmPmLabel()
        If lastOutAmPm IsNot Nothing Then
            lastOutAmPm.Text = ""
            lastOutAmPm.Visible = False
        End If

        ' Label alignment and centering
        Label7.AutoSize = False
        Label7.TextAlign = ContentAlignment.MiddleCenter
        CenterTimeLabels()
        AddHandler factimeinpnl.Resize, AddressOf Panel3_Resize
        ' Also keep announcement panel centered when form resizes
        AddHandler facannouncementspnl.Resize, AddressOf Panel4_Resize
    End Sub

    ' ---------------- ANNOUNCEMENTS: style and layout to match pending tasks ----------------
    Private Sub ConfigureAnnouncements()
        ' Find Panel4 (Announcements) and style its checkboxes and label similar to pending tasks
        If facannouncementspnl Is Nothing Then Return

        ' Ensure the announcement header (Label8) uses the same visual style as pending tasks header
        Try
            announcementslbl.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold)
            announcementslbl.ForeColor = Color.Indigo
        Catch
            ' ignore if Label8 doesn't exist or font assignment fails
        End Try

        ' Style each CheckBox inside Panel4 to match pending tasks and wire the checked handler
        Dim announceCheckboxes = facannouncementspnl.Controls.OfType(Of CheckBox)().OrderBy(Function(c) c.TabIndex).ToList()
        For Each cb In announceCheckboxes
            cb.AutoSize = True
            cb.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
            cb.ForeColor = Color.Indigo
            cb.UseVisualStyleBackColor = True
            cb.Left = TaskLeft

            ' Attach checked handler so announcements behave like pending tasks
            RemoveHandler cb.CheckedChanged, AddressOf AnnouncementCheckChanged
            AddHandler cb.CheckedChanged, AddressOf AnnouncementCheckChanged
        Next
    End Sub

    Private Sub ReflowAnnouncements()
        If facannouncementspnl Is Nothing Then Return

        Dim announceCheckboxes = facannouncementspnl.Controls.OfType(Of CheckBox)().OrderBy(Function(c) c.TabIndex).ToList()
        ' Start under the announcement header — pick a start top that matches visual spacing used for tasks
        Dim announcementStartTop As Integer = 130
        For i As Integer = 0 To announceCheckboxes.Count - 1
            Dim cb = announceCheckboxes(i)
            cb.Top = announcementStartTop + (i * TaskSpacing)
        Next

        ' Center the announcement header (Label8) horizontally in the panel
        If announcementslbl IsNot Nothing Then
            announcementslbl.AutoSize = False
            announcementslbl.TextAlign = ContentAlignment.MiddleCenter
            announcementslbl.Width = Math.Max(100, facannouncementspnl.ClientSize.Width - 40)
            announcementslbl.Left = (facannouncementspnl.ClientSize.Width - announcementslbl.Width) \ 2
        End If
    End Sub

    Private Sub Panel4_Resize(sender As Object, e As EventArgs)
        ReflowAnnouncements()
    End Sub

    ' ---------------- CLOCK ----------------
    Private Sub UpdateTimeToday(sender As Object, e As EventArgs)
        ' Update with seconds so it visibly changes
        timetodaylbl.Text = $"Time Today: {DateTime.Now.ToString("h:mm:ss tt", CultureInfo.InvariantCulture)}"
    End Sub

    ' ---------------- CREATE/CONFIGURE AMPM LABEL ----------------
    Private Sub CreateOrConfigureLastOutAmPmLabel()
        If lastOutAmPm Is Nothing Then
            lastOutAmPm = New Label() With {
                .Name = "LabelLastOutAMPM",
                .AutoSize = True,
                .Font = New Font(Label7.Font.FontFamily, 18.0F, FontStyle.Bold),
                .ForeColor = Label7.ForeColor,
                .BackColor = Color.Transparent,
                .Text = ""
            }
            ' Add to the same parent as Label7 (Panel3 assumed)
            factimeinpnl.Controls.Add(lastOutAmPm)
        Else
            ' Ensure visual consistency
            lastOutAmPm.Font = New Font(Label7.Font.FontFamily, 18.0F, FontStyle.Bold)
            lastOutAmPm.ForeColor = Label7.ForeColor
            lastOutAmPm.BackColor = Color.Transparent
        End If
    End Sub

    ' ---------------- CENTER LABELS ----------------
    Private Sub Panel3_Resize(sender As Object, e As EventArgs)
        CenterTimeLabels()
    End Sub

    Private Sub CenterTimeLabels()
        ' Center "Time Today"
        If timetodaylbl IsNot Nothing Then
            timetodaylbl.AutoSize = True
            timetodaylbl.Left = (factimeinpnl.ClientSize.Width - timetodaylbl.Width) \ 2
            timetodaylbl.Top = 70 ' adjust as needed
        End If

        ' --- Center "Last Time Out" + AM/PM ---
        Dim spacing As Integer = 3 ' tighter gap
        Dim horizontalPadding As Integer = 20

        ' Measure Label7 based on its actual content
        Label7.AutoSize = True
        Label7.TextAlign = ContentAlignment.MiddleCenter

        ' Match AM/PM label style and size
        If lastOutAmPm IsNot Nothing Then
            lastOutAmPm.Font = New Font(Label7.Font.FontFamily, Label7.Font.Size, FontStyle.Bold)
            lastOutAmPm.AutoSize = True
        End If

        ' Calculate total width of both labels
        Dim ampmWidth As Integer = If(lastOutAmPm IsNot Nothing, lastOutAmPm.PreferredSize.Width, 0)
        Dim combinedWidth As Integer = Label7.PreferredWidth + spacing + ampmWidth

        ' Center the pair horizontally within Panel3
        Dim groupLeft As Integer = Math.Max(0, (factimeinpnl.ClientSize.Width - combinedWidth) \ 2)

        ' Position Label7
        Label7.Left = groupLeft

        ' Position AM/PM immediately after text (not blank area)
        If lastOutAmPm IsNot Nothing Then
            lastOutAmPm.Left = Label7.Left + Label7.PreferredWidth + spacing
            lastOutAmPm.Top = Label7.Top + ((Label7.Height - lastOutAmPm.Height) \ 2)
        End If
    End Sub

    ' ---------------- ADD TASK ----------------
    Private Sub ButtonAddTask_Click(sender As Object, e As EventArgs)
        Dim currentTasks = factaskspnl.Controls.OfType(Of CheckBox)().ToList()
        If currentTasks.Count >= MaxTasks Then
            MessageBox.Show($"You can only have up to {MaxTasks} pending tasks.", "Task Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim taskText As String = Microsoft.VisualBasic.Interaction.InputBox("Enter task description:", "Add Task").Trim()
        If String.IsNullOrWhiteSpace(taskText) Then Return
        If taskText.Length > MaxTaskTextLength Then
            MessageBox.Show($"Task description too long. Shorten it and try again.", "Task Too Long", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim cb As New CheckBox() With {
            .AutoSize = True,
            .Font = New Font("Segoe UI", 24.0F, FontStyle.Bold),
            .ForeColor = Color.Indigo,
            .Left = TaskLeft,
            .Text = taskText,
            .UseVisualStyleBackColor = True
        }
        AddHandler cb.CheckedChanged, AddressOf TaskCheckChanged
        factaskspnl.Controls.Add(cb)
        ReflowTasks()
    End Sub

    ' ---------------- TASK CHECKED (PENDING TASKS) ----------------
    Private Sub TaskCheckChanged(sender As Object, e As EventArgs)
        Dim cb = TryCast(sender, CheckBox)
        If cb Is Nothing OrElse Not cb.Checked Then Return

        If MessageBox.Show("Complete this task?", "Complete Task", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            factaskspnl.Controls.Remove(cb)
            cb.Dispose()
            ReflowTasks()
        Else
            cb.Checked = False
        End If
    End Sub

    ' ---------------- ANNOUNCEMENT CHECKED (acts like pending tasks) ----------------
    Private Sub AnnouncementCheckChanged(sender As Object, e As EventArgs)
        Dim cb = TryCast(sender, CheckBox)
        If cb Is Nothing OrElse Not cb.Checked Then Return

        If MessageBox.Show("Mark this announcement as handled and remove it?", "Announcements", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            facannouncementspnl.Controls.Remove(cb)
            cb.Dispose()
            ReflowAnnouncements()
        Else
            cb.Checked = False
        End If
    End Sub

    ' ---------------- COMPLETE ALL TASKS ----------------
    Private Sub ButtonCompleteSelected_Click(sender As Object, e As EventArgs)
        Dim tasks = factaskspnl.Controls.OfType(Of CheckBox)().ToList()
        If tasks.Count = 0 Then
            MessageBox.Show("There are no tasks to complete.", "Complete Tasks", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show($"Complete and erase all {tasks.Count} task(s)?", "Complete All Tasks", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            For Each cb In tasks
                factaskspnl.Controls.Remove(cb)
                cb.Dispose()
            Next
            ReflowTasks()
        End If
    End Sub

    ' ---------------- REFLOW TASKS ----------------
    Private Sub ReflowTasks()
        Dim tasks = factaskspnl.Controls.OfType(Of CheckBox)().ToList()
        For i As Integer = 0 To tasks.Count - 1
            Dim cb = tasks(i)
            cb.Left = TaskLeft
            cb.Top = TaskStartTop + (i * TaskSpacing)
        Next
    End Sub

    ' ---------------- RETURN TO LOGIN ----------------
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If MessageBox.Show("Return to login page?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim loginForm As New Login()
            loginForm.Show()
            Me.Hide()
        End If
    End Sub

    ' ---------------- TIME IN / TIME OUT ----------------
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles timeinbtn.Click
        Dim now As DateTime = DateTime.Now
        Dim timeOnly As String = now.ToString("h:mm tt", CultureInfo.InvariantCulture)

        If String.Equals(timeinbtn.Text.Trim(), "TIME IN", StringComparison.OrdinalIgnoreCase) Then
            ' TIME IN
            timetodaylbl.Text = $"Time Today: {timeOnly}"
            MessageBox.Show($"You are timed in at {timeOnly}", "Time In", MessageBoxButtons.OK, MessageBoxIcon.Information)
            timeinbtn.Text = "TIME OUT"
        Else
            ' TIME OUT - set label text and show AM/PM next to it
            Label7.Text = now.ToString("MMMM dd, yyyy - h:mm", CultureInfo.InvariantCulture)
            CreateOrConfigureLastOutAmPmLabel()
            lastOutAmPm.Text = now.ToString("tt", CultureInfo.InvariantCulture).ToUpperInvariant()
            lastOutAmPm.Visible = True

            MessageBox.Show($"You are timed out at {timeOnly}", "Time Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
            timeinbtn.Text = "TIME IN"
        End If

        CenterTimeLabels()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addtasksbtn.Click

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim viewstudent As New facultyStudentRecord()
        viewstudent.Show()
        Me.Hide()
    End Sub

    Private Sub viewschedpnl_Click(sender As Object, e As EventArgs) Handles viewschedpnl.Click
        Dim viewschedule As New scheduleForm()
        viewschedule.Show()
        Me.Hide()
    End Sub

    Private Sub btnSelectPhoto_Click(sender As Object, e As EventArgs) Handles btnSelectPhoto.Click

        Dim result As DialogResult = MessageBox.Show(
            "Do you want to change display photo? 1x1 only",
            "Change Photo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.No Then
            Exit Sub ' user canceled
        End If


        Dim ofd As New OpenFileDialog()
        ofd.Title = "Select a Photo"
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

        If ofd.ShowDialog() = DialogResult.OK Then
            btnSelectPhoto.Image = Image.FromFile(ofd.FileName)
            btnSelectPhoto.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub
End Class