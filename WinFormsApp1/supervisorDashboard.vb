Imports System.Globalization

Public Class supervisorDashboard
    Private Const MaxTasks As Integer = 3
    Private Const MaxTaskTextLength As Integer = 20
    Private ReadOnly TaskStartTop As Integer = 119
    Private ReadOnly TaskLeft As Integer = 33
    Private ReadOnly TaskSpacing As Integer = 67


    ' runtime-only label for AM/PM of last timeout
    Private lastOutAmPm As Label
    Private ReadOnly clockTimer As New Timer() With {.Interval = 1000} ' updates every second

    ' ---------------- FORM LOAD ----------------
    Private Sub supervisorDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        ' Wire buttons (always present)
        AddHandler Button1.Click, AddressOf ButtonAddTask_Click
        AddHandler Button3.Click, AddressOf ButtonCompleteSelected_Click
        AddHandler Button6.Click, AddressOf ButtonAddAnnouncement_Click

        ' Attempt to wire up any design-time checkboxes if they exist.
        ' Use Controls.Find so we don't get compile errors if those controls were removed from designer.
        ' Wire CheckBox1..CheckBox6 so announcements checkboxes are included too.
        For i As Integer = 1 To 6
            Dim found() As Control = Me.Controls.Find($"CheckBox{i}", True)
            If found IsNot Nothing AndAlso found.Length > 0 AndAlso TypeOf found(0) Is CheckBox Then
                AddHandler DirectCast(found(0), CheckBox).CheckedChanged, AddressOf TaskCheckChanged
            End If
        Next

        ' Do NOT clear Panel1 here — keep any design-time tasks if present.
        ReflowPanel(Panel1)
        ' Also reflow announcements panel in case design-time announcements exist.
        ReflowPanel(Panel4)

        ' Initialize time system
        Button2.Text = If(String.IsNullOrWhiteSpace(Button2.Text), "TIME IN", Button2.Text)

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
        AddHandler Panel3.Resize, AddressOf Panel3_Resize
    End Sub

    ' ---------------- CLOCK ----------------
    Private Sub UpdateTimeToday(sender As Object, e As EventArgs)
        ' Update with seconds so it visibly changes
        Label5.Text = $"Time Today: {DateTime.Now.ToString("h:mm:ss tt", CultureInfo.InvariantCulture)}"
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
            Panel3.Controls.Add(lastOutAmPm)
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
        If Label5 IsNot Nothing Then
            Label5.AutoSize = True
            Label5.Left = (Panel3.ClientSize.Width - Label5.Width) \ 2
            Label5.Top = 70 ' adjust as needed
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
        Dim groupLeft As Integer = Math.Max(0, (Panel3.ClientSize.Width - combinedWidth) \ 2)

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
        Dim currentTasks = Panel1.Controls.OfType(Of CheckBox)().ToList()
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
        Panel1.Controls.Add(cb)
        ReflowPanel(Panel1)
    End Sub

    ' ---------------- ADD ANNOUNCEMENT ----------------
    Private Sub ButtonAddAnnouncement_Click(sender As Object, e As EventArgs)
        Dim currentAnnouncements = Panel4.Controls.OfType(Of CheckBox)().ToList()
        If currentAnnouncements.Count >= MaxTasks Then
            MessageBox.Show($"You can only have up to {MaxTasks} announcements.", "Announcement Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim annText As String = Microsoft.VisualBasic.Interaction.InputBox("Enter announcement text:", "Add Announcement").Trim()
        If String.IsNullOrWhiteSpace(annText) Then Return
        If annText.Length > MaxTaskTextLength Then
            MessageBox.Show($"Announcement too long. Shorten it and try again.", "Text Too Long", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim cb As New CheckBox() With {
            .AutoSize = True,
            .Font = New Font("Segoe UI", 24.0F, FontStyle.Bold),
            .ForeColor = Color.Indigo,
            .Left = TaskLeft,
            .Text = annText,
            .UseVisualStyleBackColor = True
        }
        AddHandler cb.CheckedChanged, AddressOf TaskCheckChanged
        Panel4.Controls.Add(cb)
        ReflowPanel(Panel4)
    End Sub

    ' ---------------- TASK/ANNOUNCEMENT CHECKED ----------------
    Private Sub TaskCheckChanged(sender As Object, e As EventArgs)
        Dim cb = TryCast(sender, CheckBox)
        If cb Is Nothing OrElse Not cb.Checked Then Return

        If MessageBox.Show("Complete this item?", "Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ' capture parent before removal
            Dim parentPanel = TryCast(cb.Parent, Panel)
            If parentPanel IsNot Nothing Then
                parentPanel.Controls.Remove(cb)
            Else
                ' fallback: remove from form-level controls
                Me.Controls.Remove(cb)
            End If
            cb.Dispose()

            ' reflow the panel that contained the checkbox
            If parentPanel IsNot Nothing Then
                ReflowPanel(parentPanel)
            End If
        Else
            cb.Checked = False
        End If
    End Sub

    ' ---------------- COMPLETE ALL TASKS (pending tasks only) ----------------
    Private Sub ButtonCompleteSelected_Click(sender As Object, e As EventArgs)
        Dim tasks = Panel1.Controls.OfType(Of CheckBox)().ToList()
        If tasks.Count = 0 Then
            MessageBox.Show("There are no tasks to complete.", "Complete Tasks", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show($"Complete and erase all {tasks.Count} task(s)?", "Complete All Tasks", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            For Each cb In tasks
                Panel1.Controls.Remove(cb)
                cb.Dispose()
            Next
            ReflowPanel(Panel1)
        End If
    End Sub

    ' ---------------- REFLOW PANEL (generic) ----------------
    Private Sub ReflowPanel(targetPanel As Panel)
        If targetPanel Is Nothing Then Return
        Dim items = targetPanel.Controls.OfType(Of CheckBox)().ToList()
        For i As Integer = 0 To items.Count - 1
            Dim cb = items(i)
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim now As DateTime = DateTime.Now
        Dim timeOnly As String = now.ToString("h:mm tt", CultureInfo.InvariantCulture)

        If String.Equals(Button2.Text.Trim(), "TIME IN", StringComparison.OrdinalIgnoreCase) Then
            ' TIME IN
            Label5.Text = $"Time Today: {timeOnly}"
            MessageBox.Show($"You are timed in at {timeOnly}", "Time In", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Button2.Text = "TIME OUT"
        Else
            ' TIME OUT - set label text and show AM/PM next to it
            Label7.Text = now.ToString("MMMM dd, yyyy - h:mm", CultureInfo.InvariantCulture)
            CreateOrConfigureLastOutAmPmLabel()
            lastOutAmPm.Text = now.ToString("tt", CultureInfo.InvariantCulture).ToUpperInvariant()
            lastOutAmPm.Visible = True

            MessageBox.Show($"You are timed out at {timeOnly}", "Time Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Button2.Text = "TIME IN"
        End If

        CenterTimeLabels()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim visitform As New visitationLogs
        visitform.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim evalform As New supervisorEvaluation
        evalform.ShowDialog()
    End Sub
End Class