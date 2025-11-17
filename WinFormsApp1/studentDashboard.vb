Imports System.Globalization

Public Class studentDashboard

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
        AddHandler addtasks.Click, AddressOf ButtonAddTask_Click
        AddHandler completetasks.Click, AddressOf ButtonCompleteSelected_Click

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

        ' Initialize time system
        timeinbtn.Text = If(String.IsNullOrWhiteSpace(timeinbtn.Text), "TIME IN", timeinbtn.Text)

        ' Start clock for "Time Today"
        AddHandler clockTimer.Tick, AddressOf UpdateTimeToday
        clockTimer.Start()
        UpdateTimeToday(Nothing, EventArgs.Empty)

        ' Ensure Label7 exists (some designer variants can omit it)
        EnsureLabel7()

        ' Initialize Last Time Out (start blank and hide AM/PM)
        CreateOrConfigureLastOutAmPmLabel()
        If lastOutAmPm IsNot Nothing Then
            lastOutAmPm.Text = ""
            lastOutAmPm.Visible = False
        End If

        ' Label alignment and centering
        If Label7 IsNot Nothing Then
            Label7.AutoSize = False
            Label7.TextAlign = ContentAlignment.MiddleCenter
        End If
        CenterTimeLabels()
        AddHandler studtimeinpnl.Resize, AddressOf Panel3_Resize
    End Sub

    ' ---------------- CLOCK ----------------
    Private Sub UpdateTimeToday(sender As Object, e As EventArgs)
        ' Update with seconds so it visibly changes
        timetodatlbl.Text = $"Time Today: {DateTime.Now.ToString("h:mm:ss tt", CultureInfo.InvariantCulture)}"
    End Sub

    ' Ensure Label7 exists and is parented to studtimeinpnl if the designer did not create it
    Private Sub EnsureLabel7()
        If Label7 Is Nothing Then
            Label7 = New Label() With {
                .Name = "Label7",
                .AutoSize = True,
                .Font = New Font("Segoe UI", 26.25F, FontStyle.Bold),
                .ForeColor = Color.Indigo,
                .BackColor = Color.Transparent,
                .Text = ""
            }
            ' If there's a timeout label defined in the designer, use its Top to align initial placement.
            Try
                If timeoutlbl IsNot Nothing Then
                    Label7.Top = timeoutlbl.Top
                    Label7.Left = timeoutlbl.Left + timeoutlbl.Width + 8
                End If
            Catch
                ' ignore positioning exceptions; CenterTimeLabels will reposition correctly
            End Try

            If studtimeinpnl IsNot Nothing Then
                studtimeinpnl.Controls.Add(Label7)
            Else
                ' As a fallback, add to the form so the control exists (rare)
                Me.Controls.Add(Label7)
            End If
        End If
    End Sub

    ' ---------------- CREATE/CONFIGURE AMPM LABEL ----------------
    Private Sub CreateOrConfigureLastOutAmPmLabel()
        ' Ensure Label7 exists before referencing its properties
        EnsureLabel7()

        ' If Label7 still isn't available, create lastOutAmPm with reasonable defaults
        If lastOutAmPm Is Nothing Then
            Dim baseFontFamily = If(Label7 IsNot Nothing AndAlso Label7.Font IsNot Nothing, Label7.Font.FontFamily, New Font("Segoe UI", 10).FontFamily)
            Dim baseForeColor = If(Label7 IsNot Nothing, Label7.ForeColor, Color.Black)

            lastOutAmPm = New Label() With {
                .Name = "LabelLastOutAMPM",
                .AutoSize = True,
                .Font = New Font(baseFontFamily, 18.0F, FontStyle.Bold),
                .ForeColor = baseForeColor,
                .BackColor = Color.Transparent,
                .Text = ""
            }

            ' Add to the same parent as Label7 (Panel assumed)
            If studtimeinpnl IsNot Nothing Then
                studtimeinpnl.Controls.Add(lastOutAmPm)
            ElseIf Label7 IsNot Nothing AndAlso Label7.Parent IsNot Nothing Then
                Label7.Parent.Controls.Add(lastOutAmPm)
            Else
                Me.Controls.Add(lastOutAmPm)
            End If
        Else
            ' Ensure visual consistency
            If Label7 IsNot Nothing AndAlso Label7.Font IsNot Nothing Then
                lastOutAmPm.Font = New Font(Label7.Font.FontFamily, 18.0F, FontStyle.Bold)
            End If
            If Label7 IsNot Nothing Then lastOutAmPm.ForeColor = Label7.ForeColor
            lastOutAmPm.BackColor = Color.Transparent
        End If
    End Sub

    ' ---------------- CENTER LABELS ----------------
    Private Sub Panel3_Resize(sender As Object, e As EventArgs)
        CenterTimeLabels()
    End Sub

    Private Sub CenterTimeLabels()
        If studtimeinpnl Is Nothing Then Return

        ' Center "Time Today"
        If timetodatlbl IsNot Nothing Then
            timetodatlbl.AutoSize = True
            timetodatlbl.Left = (studtimeinpnl.ClientSize.Width - timetodatlbl.Width) \ 2
            timetodatlbl.Top = 70 ' adjust as needed
        End If

        ' Require Label7 for the rest of centering; otherwise nothing to center
        If Label7 Is Nothing Then Return

        ' --- Center "Last Time Out" + AM/PM ---
        Dim spacing As Integer = 3 ' tighter gap

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
        Dim groupLeft As Integer = Math.Max(0, (studtimeinpnl.ClientSize.Width - combinedWidth) \ 2)

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
        Dim currentTasks = studtaskpnl.Controls.OfType(Of CheckBox)().ToList()
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
        studtaskpnl.Controls.Add(cb)
        ReflowTasks()
    End Sub

    ' ---------------- TASK CHECKED ----------------
    Private Sub TaskCheckChanged(sender As Object, e As EventArgs)
        Dim cb = TryCast(sender, CheckBox)
        If cb Is Nothing OrElse Not cb.Checked Then Return

        If MessageBox.Show("Complete this task?", "Complete Task", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            studtaskpnl.Controls.Remove(cb)
            cb.Dispose()
            ReflowTasks()
        Else
            cb.Checked = False
        End If
    End Sub

    ' ---------------- COMPLETE ALL TASKS ----------------
    Private Sub ButtonCompleteSelected_Click(sender As Object, e As EventArgs)
        Dim tasks = studtaskpnl.Controls.OfType(Of CheckBox)().ToList()
        If tasks.Count = 0 Then
            MessageBox.Show("There are no tasks to complete.", "Complete Tasks", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show($"Complete and erase all {tasks.Count} task(s)?", "Complete All Tasks", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            For Each cb In tasks
                studtaskpnl.Controls.Remove(cb)
                cb.Dispose()
            Next
            ReflowTasks()
        End If
    End Sub

    ' ---------------- REFLOW TASKS ----------------
    Private Sub ReflowTasks()
        Dim tasks = studtaskpnl.Controls.OfType(Of CheckBox)().ToList()
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
            timetodatlbl.Text = $"Time Today: {timeOnly}"
            MessageBox.Show($"You are timed in at {timeOnly}", "Time In", MessageBoxButtons.OK, MessageBoxIcon.Information)
            timeinbtn.Text = "TIME OUT"
        Else
            ' TIME OUT - set label text and show AM/PM next to it
            EnsureLabel7()
            Label7.Text = now.ToString("MMMM dd, yyyy - h:mm", CultureInfo.InvariantCulture)
            CreateOrConfigureLastOutAmPmLabel()
            If lastOutAmPm IsNot Nothing Then
                lastOutAmPm.Text = now.ToString("tt", CultureInfo.InvariantCulture).ToUpperInvariant()
                lastOutAmPm.Visible = True
            End If

            MessageBox.Show($"You are timed out at {timeOnly}", "Time Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
            timeinbtn.Text = "TIME IN"
        End If

        CenterTimeLabels()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles viewschedpnl.Click
        Dim schedule As New studentScheduleForm()
        schedule.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addtasks.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles completetasks.Click

    End Sub
End Class
