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
        studevalpnl = New Panel()
        viewgrades = New Button()
        evalicon = New PictureBox()
        PictureBox7 = New PictureBox()
        ColorDialog1 = New ColorDialog()
        schedicon = New PictureBox()
        viewschedpnl = New Button()
        studschedpnl = New Panel()
        Panel1 = New Panel()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnSelectPhoto = New PictureBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        studtaskpnl.SuspendLayout()
        CType(tasksicon, ComponentModel.ISupportInitialize).BeginInit()
        studhrspanel.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        studtimeinpnl.SuspendLayout()
        studannouncepnl.SuspendLayout()
        CType(announcementsicon, ComponentModel.ISupportInitialize).BeginInit()
        studevalpnl.SuspendLayout()
        CType(evalicon, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(schedicon, ComponentModel.ISupportInitialize).BeginInit()
        studschedpnl.SuspendLayout()
        Panel1.SuspendLayout()
        CType(btnSelectPhoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.studentdashboardHeader3
        PictureBox1.Location = New Point(-2, 0)
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
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(33, 222)
        Label1.Name = "Label1"
        Label1.Size = New Size(406, 45)
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
        studtaskpnl.Location = New Point(1305, 629)
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
        studhrspanel.Location = New Point(1304, 220)
        studhrspanel.Margin = New Padding(3, 2, 3, 2)
        studhrspanel.Name = "studhrspanel"
        studhrspanel.Size = New Size(546, 380)
        studhrspanel.TabIndex = 67
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.hours_line_graph
        PictureBox3.Location = New Point(34, 65)
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
        studtimeinpnl.Location = New Point(731, 221)
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
        studannouncepnl.Location = New Point(731, 629)
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
        ' studevalpnl
        ' 
        studevalpnl.BackColor = Color.White
        studevalpnl.Controls.Add(viewgrades)
        studevalpnl.Controls.Add(evalicon)
        studevalpnl.Location = New Point(37, 889)
        studevalpnl.Margin = New Padding(3, 2, 3, 2)
        studevalpnl.Name = "studevalpnl"
        studevalpnl.Size = New Size(651, 116)
        studevalpnl.TabIndex = 74
        ' 
        ' viewgrades
        ' 
        viewgrades.BackColor = Color.Indigo
        viewgrades.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        viewgrades.ForeColor = Color.White
        viewgrades.Location = New Point(95, 21)
        viewgrades.Margin = New Padding(3, 2, 3, 2)
        viewgrades.Name = "viewgrades"
        viewgrades.Size = New Size(538, 72)
        viewgrades.TabIndex = 68
        viewgrades.Text = " VIEW GRADES AND EVALUATION"
        viewgrades.UseVisualStyleBackColor = False
        ' 
        ' evalicon
        ' 
        evalicon.Image = My.Resources.Resources.icons8_rating_52
        evalicon.Location = New Point(15, 21)
        evalicon.Margin = New Padding(3, 2, 3, 2)
        evalicon.Name = "evalicon"
        evalicon.Size = New Size(73, 72)
        evalicon.SizeMode = PictureBoxSizeMode.StretchImage
        evalicon.TabIndex = 68
        evalicon.TabStop = False
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
        ' viewschedpnl
        ' 
        viewschedpnl.BackColor = Color.Indigo
        viewschedpnl.Font = New Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        viewschedpnl.ForeColor = Color.White
        viewschedpnl.Location = New Point(94, 22)
        viewschedpnl.Margin = New Padding(3, 2, 3, 2)
        viewschedpnl.Name = "viewschedpnl"
        viewschedpnl.Size = New Size(539, 71)
        viewschedpnl.TabIndex = 4
        viewschedpnl.Text = "VIEW YOUR SCHEDULE"
        viewschedpnl.UseVisualStyleBackColor = False
        ' 
        ' studschedpnl
        ' 
        studschedpnl.BackColor = Color.White
        studschedpnl.Controls.Add(viewschedpnl)
        studschedpnl.Controls.Add(schedicon)
        studschedpnl.Location = New Point(37, 759)
        studschedpnl.Margin = New Padding(3, 2, 3, 2)
        studschedpnl.Name = "studschedpnl"
        studschedpnl.Size = New Size(651, 114)
        studschedpnl.TabIndex = 73
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnSelectPhoto)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(37, 221)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(651, 515)
        Panel1.TabIndex = 75
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(31, 397)
        Label7.Name = "Label7"
        Label7.Size = New Size(151, 45)
        Label7.TabIndex = 78
        Label7.Text = "Program"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(31, 442)
        Label6.Name = "Label6"
        Label6.Size = New Size(519, 32)
        Label6.TabIndex = 77
        Label6.Text = "Bachelor of Science in Information Technology"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(33, 339)
        Label5.Name = "Label5"
        Label5.Size = New Size(392, 40)
        Label5.TabIndex = 76
        Label5.Text = "College of Computer Studies"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(31, 294)
        Label4.Name = "Label4"
        Label4.Size = New Size(201, 45)
        Label4.TabIndex = 68
        Label4.Text = "Department"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(251, 62)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 25)
        Label3.TabIndex = 67
        Label3.Text = "25-00000"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(241, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(197, 32)
        Label2.TabIndex = 66
        Label2.Text = "Student Number"
        ' 
        ' btnSelectPhoto
        ' 
        btnSelectPhoto.Cursor = Cursors.Hand
        btnSelectPhoto.Image = My.Resources.Resources.user_square
        btnSelectPhoto.Location = New Point(31, 24)
        btnSelectPhoto.Name = "btnSelectPhoto"
        btnSelectPhoto.Size = New Size(191, 184)
        btnSelectPhoto.SizeMode = PictureBoxSizeMode.StretchImage
        btnSelectPhoto.TabIndex = 0
        btnSelectPhoto.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(251, 122)
        Label8.Name = "Label8"
        Label8.Size = New Size(129, 25)
        Label8.TabIndex = 80
        Label8.Text = "09123456789"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic)
        Label9.ForeColor = SystemColors.ActiveCaptionText
        Label9.Location = New Point(241, 90)
        Label9.Name = "Label9"
        Label9.Size = New Size(198, 32)
        Label9.TabIndex = 79
        Label9.Text = "Contact Number"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic)
        Label10.ForeColor = SystemColors.ActiveCaptionText
        Label10.Location = New Point(241, 147)
        Label10.Name = "Label10"
        Label10.Size = New Size(79, 32)
        Label10.TabIndex = 81
        Label10.Text = "Email"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label11.ForeColor = SystemColors.ActiveCaptionText
        Label11.Location = New Point(251, 179)
        Label11.Name = "Label11"
        Label11.Size = New Size(197, 25)
        Label11.TabIndex = 82
        Label11.Text = "jdelacruz@gmail.com"
        ' 
        ' studentDashboard
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.DarkGray
        ClientSize = New Size(1904, 1041)
        Controls.Add(Panel1)
        Controls.Add(PictureBox7)
        Controls.Add(studevalpnl)
        Controls.Add(studschedpnl)
        Controls.Add(studannouncepnl)
        Controls.Add(studtimeinpnl)
        Controls.Add(studhrspanel)
        Controls.Add(studtaskpnl)
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
        studevalpnl.ResumeLayout(False)
        CType(evalicon, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(schedicon, ComponentModel.ISupportInitialize).EndInit()
        studschedpnl.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(btnSelectPhoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
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
    Friend WithEvents studevalpnl As Panel
    Friend WithEvents evalicon As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents viewgrades As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents schedicon As PictureBox
    Friend WithEvents viewschedpnl As Button
    Friend WithEvents studschedpnl As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSelectPhoto As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
