<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class studentDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentDashboard))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        studtaskpnl = New Panel()
        completetasks = New Button()
        tasksicon = New PictureBox()
        addtasks = New Button()
        pendingtaskslbl = New Label()
        studhrspanel = New Panel()
        PictureBox3 = New PictureBox()
        hrsloglbl = New Label()
        studtimeinpnl = New Panel()
        timeoutlbl = New Label()
        timetodatlbl = New Label()
        timeinbtn = New Button()
        studannouncepnl = New Panel()
        CheckBox4 = New CheckBox()
        announcementslbl = New Label()
        CheckBox5 = New CheckBox()
        announcementsicon = New PictureBox()
        CheckBox6 = New CheckBox()
        studschedpnl = New Panel()
        viewschedpnl = New Button()
        schedicon = New PictureBox()
        schedlbl = New Label()
        studevalpnl = New Panel()
        viewgrades = New Button()
        evalicon = New PictureBox()
        evallbl = New Label()
        PictureBox7 = New PictureBox()
        ColorDialog1 = New ColorDialog()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        studtaskpnl.SuspendLayout()
        CType(tasksicon, ComponentModel.ISupportInitialize).BeginInit()
        studhrspanel.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        studtimeinpnl.SuspendLayout()
        studannouncepnl.SuspendLayout()
        CType(announcementsicon, ComponentModel.ISupportInitialize).BeginInit()
        studschedpnl.SuspendLayout()
        CType(schedicon, ComponentModel.ISupportInitialize).BeginInit()
        studevalpnl.SuspendLayout()
        CType(evalicon, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.studentdashboardHeader3
        PictureBox1.Location = New Point(-2, 1)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1928, 180)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 64
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(749, 196)
        Label1.Name = "Label1"
        Label1.Size = New Size(420, 45)
        Label1.TabIndex = 65
        Label1.Text = "Welcome [Student Name]"
        ' 
        ' studtaskpnl
        ' 
        studtaskpnl.BackColor = Color.White
        studtaskpnl.Controls.Add(completetasks)
        studtaskpnl.Controls.Add(tasksicon)
        studtaskpnl.Controls.Add(addtasks)
        studtaskpnl.Controls.Add(pendingtaskslbl)
        studtaskpnl.Location = New Point(687, 670)
        studtaskpnl.Margin = New Padding(3, 2, 3, 2)
        studtaskpnl.Name = "studtaskpnl"
        studtaskpnl.Size = New Size(546, 380)
        studtaskpnl.TabIndex = 66
        ' 
        ' completetasks
        ' 
        completetasks.BackColor = Color.Indigo
        completetasks.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        completetasks.ForeColor = Color.White
        completetasks.Location = New Point(281, 301)
        completetasks.Margin = New Padding(3, 2, 3, 2)
        completetasks.Name = "completetasks"
        completetasks.Size = New Size(222, 61)
        completetasks.TabIndex = 72
        completetasks.Text = "Complete Tasks"
        completetasks.UseVisualStyleBackColor = False
        ' 
        ' tasksicon
        ' 
        tasksicon.Image = My.Resources.Resources.icons8_tasks_48
        tasksicon.Location = New Point(15, 22)
        tasksicon.Margin = New Padding(3, 2, 3, 2)
        tasksicon.Name = "tasksicon"
        tasksicon.Size = New Size(69, 71)
        tasksicon.SizeMode = PictureBoxSizeMode.StretchImage
        tasksicon.TabIndex = 67
        tasksicon.TabStop = False
        ' 
        ' addtasks
        ' 
        addtasks.BackColor = Color.Indigo
        addtasks.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addtasks.ForeColor = Color.White
        addtasks.Location = New Point(38, 301)
        addtasks.Margin = New Padding(3, 2, 3, 2)
        addtasks.Name = "addtasks"
        addtasks.Size = New Size(155, 61)
        addtasks.TabIndex = 68
        addtasks.Text = "Add Tasks"
        addtasks.UseVisualStyleBackColor = False
        ' 
        ' pendingtaskslbl
        ' 
        pendingtaskslbl.AutoSize = True
        pendingtaskslbl.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pendingtaskslbl.ForeColor = Color.Indigo
        pendingtaskslbl.Location = New Point(77, 36)
        pendingtaskslbl.Name = "pendingtaskslbl"
        pendingtaskslbl.Size = New Size(231, 45)
        pendingtaskslbl.TabIndex = 67
        pendingtaskslbl.Text = "Pending Tasks"
        ' 
        ' studhrspanel
        ' 
        studhrspanel.BackColor = Color.White
        studhrspanel.Controls.Add(PictureBox3)
        studhrspanel.Controls.Add(hrsloglbl)
        studhrspanel.Location = New Point(686, 261)
        studhrspanel.Margin = New Padding(3, 2, 3, 2)
        studhrspanel.Name = "studhrspanel"
        studhrspanel.Size = New Size(546, 380)
        studhrspanel.TabIndex = 67
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.hours_line_graph
        PictureBox3.Location = New Point(34, 79)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(470, 299)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 74
        PictureBox3.TabStop = False
        ' 
        ' hrsloglbl
        ' 
        hrsloglbl.AutoSize = True
        hrsloglbl.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        hrsloglbl.ForeColor = Color.Indigo
        hrsloglbl.Location = New Point(53, 16)
        hrsloglbl.Name = "hrsloglbl"
        hrsloglbl.Size = New Size(175, 32)
        hrsloglbl.TabIndex = 72
        hrsloglbl.Text = "Hours Logged"
        ' 
        ' studtimeinpnl
        ' 
        studtimeinpnl.BackColor = Color.White
        studtimeinpnl.Controls.Add(timeoutlbl)
        studtimeinpnl.Controls.Add(timetodatlbl)
        studtimeinpnl.Controls.Add(timeinbtn)
        studtimeinpnl.Location = New Point(113, 262)
        studtimeinpnl.Margin = New Padding(3, 2, 3, 2)
        studtimeinpnl.Name = "studtimeinpnl"
        studtimeinpnl.Size = New Size(546, 380)
        studtimeinpnl.TabIndex = 68
        ' 
        ' timeoutlbl
        ' 
        timeoutlbl.AutoSize = True
        timeoutlbl.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold)
        timeoutlbl.Location = New Point(144, 251)
        timeoutlbl.Name = "timeoutlbl"
        timeoutlbl.Size = New Size(259, 47)
        timeoutlbl.TabIndex = 2
        timeoutlbl.Text = "Last Time Out:"
        ' 
        ' timetodatlbl
        ' 
        timetodatlbl.AutoSize = True
        timetodatlbl.Font = New Font("Segoe UI", 32.25F, FontStyle.Bold)
        timetodatlbl.Location = New Point(31, 64)
        timetodatlbl.Name = "timetodatlbl"
        timetodatlbl.Size = New Size(471, 59)
        timetodatlbl.TabIndex = 1
        timetodatlbl.Text = "Time Today: 12:30 PM"
        ' 
        ' timeinbtn
        ' 
        timeinbtn.BackColor = Color.Indigo
        timeinbtn.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        timeinbtn.ForeColor = Color.White
        timeinbtn.Location = New Point(172, 146)
        timeinbtn.Margin = New Padding(3, 2, 3, 2)
        timeinbtn.Name = "timeinbtn"
        timeinbtn.Size = New Size(207, 87)
        timeinbtn.TabIndex = 0
        timeinbtn.Text = "TIME IN"
        timeinbtn.UseVisualStyleBackColor = False
        ' 
        ' studannouncepnl
        ' 
        studannouncepnl.BackColor = Color.White
        studannouncepnl.Controls.Add(CheckBox4)
        studannouncepnl.Controls.Add(announcementslbl)
        studannouncepnl.Controls.Add(CheckBox5)
        studannouncepnl.Controls.Add(announcementsicon)
        studannouncepnl.Controls.Add(CheckBox6)
        studannouncepnl.Location = New Point(113, 670)
        studannouncepnl.Margin = New Padding(3, 2, 3, 2)
        studannouncepnl.Name = "studannouncepnl"
        studannouncepnl.Size = New Size(546, 380)
        studannouncepnl.TabIndex = 69
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        CheckBox4.ForeColor = Color.Indigo
        CheckBox4.Location = New Point(41, 301)
        CheckBox4.Margin = New Padding(3, 2, 3, 2)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(421, 49)
        CheckBox4.TabIndex = 75
        CheckBox4.Text = "Coffee Machine is broken"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' announcementslbl
        ' 
        announcementslbl.AutoSize = True
        announcementslbl.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        announcementslbl.ForeColor = Color.Indigo
        announcementslbl.Location = New Point(92, 36)
        announcementslbl.Name = "announcementslbl"
        announcementslbl.Size = New Size(287, 47)
        announcementslbl.TabIndex = 74
        announcementslbl.Text = "Announcements"
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        CheckBox5.ForeColor = Color.Indigo
        CheckBox5.Location = New Point(41, 214)
        CheckBox5.Margin = New Padding(3, 2, 3, 2)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(326, 49)
        CheckBox5.TabIndex = 74
        CheckBox5.Text = "Meeting tomorrow"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' announcementsicon
        ' 
        announcementsicon.Image = My.Resources.Resources.icons8_announcement_90
        announcementsicon.Location = New Point(17, 22)
        announcementsicon.Margin = New Padding(3, 2, 3, 2)
        announcementsicon.Name = "announcementsicon"
        announcementsicon.Size = New Size(69, 71)
        announcementsicon.SizeMode = PictureBoxSizeMode.StretchImage
        announcementsicon.TabIndex = 73
        announcementsicon.TabStop = False
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        CheckBox6.ForeColor = Color.Indigo
        CheckBox6.Location = New Point(41, 130)
        CheckBox6.Margin = New Padding(3, 2, 3, 2)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(433, 49)
        CheckBox6.TabIndex = 73
        CheckBox6.Text = "Company Event at 3:00PM"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' studschedpnl
        ' 
        studschedpnl.BackColor = Color.White
        studschedpnl.Controls.Add(viewschedpnl)
        studschedpnl.Controls.Add(schedicon)
        studschedpnl.Controls.Add(schedlbl)
        studschedpnl.Location = New Point(1252, 262)
        studschedpnl.Margin = New Padding(3, 2, 3, 2)
        studschedpnl.Name = "studschedpnl"
        studschedpnl.Size = New Size(546, 380)
        studschedpnl.TabIndex = 73
        ' 
        ' viewschedpnl
        ' 
        viewschedpnl.BackColor = Color.Indigo
        viewschedpnl.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        viewschedpnl.ForeColor = Color.White
        viewschedpnl.Location = New Point(35, 158)
        viewschedpnl.Margin = New Padding(3, 2, 3, 2)
        viewschedpnl.Name = "viewschedpnl"
        viewschedpnl.Size = New Size(474, 87)
        viewschedpnl.TabIndex = 4
        viewschedpnl.Text = "VIEW YOUR SCHEDULE"
        viewschedpnl.UseVisualStyleBackColor = False
        ' 
        ' schedicon
        ' 
        schedicon.Image = My.Resources.Resources.icons8_schedule_96
        schedicon.Location = New Point(15, 22)
        schedicon.Margin = New Padding(3, 2, 3, 2)
        schedicon.Name = "schedicon"
        schedicon.Size = New Size(73, 71)
        schedicon.SizeMode = PictureBoxSizeMode.StretchImage
        schedicon.TabIndex = 67
        schedicon.TabStop = False
        ' 
        ' schedlbl
        ' 
        schedlbl.AutoSize = True
        schedlbl.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        schedlbl.ForeColor = Color.Indigo
        schedlbl.Location = New Point(94, 38)
        schedlbl.Name = "schedlbl"
        schedlbl.Size = New Size(154, 45)
        schedlbl.TabIndex = 67
        schedlbl.Text = "Schedule"
        ' 
        ' studevalpnl
        ' 
        studevalpnl.BackColor = Color.White
        studevalpnl.Controls.Add(viewgrades)
        studevalpnl.Controls.Add(evalicon)
        studevalpnl.Controls.Add(evallbl)
        studevalpnl.Location = New Point(1252, 670)
        studevalpnl.Margin = New Padding(3, 2, 3, 2)
        studevalpnl.Name = "studevalpnl"
        studevalpnl.Size = New Size(546, 380)
        studevalpnl.TabIndex = 74
        ' 
        ' viewgrades
        ' 
        viewgrades.BackColor = Color.Indigo
        viewgrades.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        viewgrades.ForeColor = Color.White
        viewgrades.Location = New Point(35, 165)
        viewgrades.Margin = New Padding(3, 2, 3, 2)
        viewgrades.Name = "viewgrades"
        viewgrades.Size = New Size(474, 87)
        viewgrades.TabIndex = 68
        viewgrades.Text = " VIEW GRADES AND EVALUATION"
        viewgrades.UseVisualStyleBackColor = False
        ' 
        ' evalicon
        ' 
        evalicon.Image = My.Resources.Resources.icons8_rating_52
        evalicon.Location = New Point(23, 27)
        evalicon.Margin = New Padding(3, 2, 3, 2)
        evalicon.Name = "evalicon"
        evalicon.Size = New Size(56, 55)
        evalicon.SizeMode = PictureBoxSizeMode.StretchImage
        evalicon.TabIndex = 68
        evalicon.TabStop = False
        ' 
        ' evallbl
        ' 
        evallbl.AutoSize = True
        evallbl.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        evallbl.ForeColor = Color.Indigo
        evallbl.Location = New Point(85, 31)
        evallbl.Name = "evallbl"
        evallbl.Size = New Size(188, 45)
        evallbl.TabIndex = 67
        evallbl.Text = "Evalutation"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.Image = My.Resources.Resources.icons8_log_out_96
        PictureBox7.Location = New Point(1684, 34)
        PictureBox7.Margin = New Padding(3, 2, 3, 2)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(114, 103)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 68
        PictureBox7.TabStop = False
        ' 
        ' studentDashboard
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.DarkGray
        ClientSize = New Size(1904, 1041)
        Controls.Add(PictureBox7)
        Controls.Add(studevalpnl)
        Controls.Add(studschedpnl)
        Controls.Add(studannouncepnl)
        Controls.Add(studtimeinpnl)
        Controls.Add(studhrspanel)
        Controls.Add(studtaskpnl)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "studentDashboard"
        Text = "Dashboard"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        studtaskpnl.ResumeLayout(False)
        studtaskpnl.PerformLayout()
        CType(tasksicon, ComponentModel.ISupportInitialize).EndInit()
        studhrspanel.ResumeLayout(False)
        studhrspanel.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        studtimeinpnl.ResumeLayout(False)
        studtimeinpnl.PerformLayout()
        studannouncepnl.ResumeLayout(False)
        studannouncepnl.PerformLayout()
        CType(announcementsicon, ComponentModel.ISupportInitialize).EndInit()
        studschedpnl.ResumeLayout(False)
        studschedpnl.PerformLayout()
        CType(schedicon, ComponentModel.ISupportInitialize).EndInit()
        studevalpnl.ResumeLayout(False)
        studevalpnl.PerformLayout()
        CType(evalicon, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents studtaskpnl As Panel
    Friend WithEvents addtasks As Button
    Friend WithEvents pendingtaskslbl As Label
    Friend WithEvents tasksicon As PictureBox
    Friend WithEvents studhrspanel As Panel
    Friend WithEvents hrsloglbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents studtimeinpnl As Panel
    Friend WithEvents timeinbtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents timeoutlbl As Label
    Friend WithEvents timetodatlbl As Label
    Friend WithEvents studannouncepnl As Panel
    Friend WithEvents completetasks As Button
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents announcementslbl As Label
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents announcementsicon As PictureBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents studschedpnl As Panel
    Friend WithEvents schedicon As PictureBox
    Friend WithEvents schedlbl As Label
    Friend WithEvents studevalpnl As Panel
    Friend WithEvents evallbl As Label
    Friend WithEvents evalicon As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents viewschedpnl As Button
    Friend WithEvents viewgrades As Button
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
