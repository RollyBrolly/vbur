<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class facultyDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(facultyDashboard))
        PictureBox1 = New PictureBox()
        facgradepnl = New Panel()
        gradestudbtn = New Button()
        gradingicon = New PictureBox()
        factimeinpnl = New Panel()
        timeoutlbl = New Label()
        timetodatlbl = New Label()
        timeinbtn = New Button()
        facstudentspnl = New Panel()
        studrecordbtn = New Button()
        PictureBox3 = New PictureBox()
        factaskspnl = New Panel()
        completaskbtn = New Button()
        tasksicon = New PictureBox()
        addtasksbtn = New Button()
        taskslbl = New Label()
        logoutbtn = New PictureBox()
        Panel7 = New Panel()
        studgender = New Label()
        studgenderlbl = New Label()
        femail = New Label()
        femaillbl = New Label()
        fcontact = New Label()
        fcontactlbl = New Label()
        fdept = New Label()
        fdeptlbl = New Label()
        fid = New Label()
        fidlbl = New Label()
        fprofile = New PictureBox()
        fwelcome = New Label()
        Panel1 = New Panel()
        viewschedbtn = New Button()
        schedicon = New PictureBox()
        Label1 = New Label()
        Timer = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        facgradepnl.SuspendLayout()
        CType(gradingicon, ComponentModel.ISupportInitialize).BeginInit()
        factimeinpnl.SuspendLayout()
        facstudentspnl.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        factaskspnl.SuspendLayout()
        CType(tasksicon, ComponentModel.ISupportInitialize).BeginInit()
        CType(logoutbtn, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        CType(fprofile, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(schedicon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.DarkGray
        PictureBox1.Image = My.Resources.Resources.facultydashboardHeader
        PictureBox1.Location = New Point(0, -2)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1928, 180)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 65
        PictureBox1.TabStop = False
        ' 
        ' facgradepnl
        ' 
        facgradepnl.BackColor = Color.White
        facgradepnl.Controls.Add(gradestudbtn)
        facgradepnl.Controls.Add(gradingicon)
        facgradepnl.Location = New Point(732, 828)
        facgradepnl.Margin = New Padding(3, 2, 3, 2)
        facgradepnl.Name = "facgradepnl"
        facgradepnl.Size = New Size(546, 181)
        facgradepnl.TabIndex = 80
        ' 
        ' gradestudbtn
        ' 
        gradestudbtn.BackColor = Color.Indigo
        gradestudbtn.Font = New Font("Segoe UI", 33.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gradestudbtn.ForeColor = Color.White
        gradestudbtn.Location = New Point(101, 38)
        gradestudbtn.Margin = New Padding(3, 2, 3, 2)
        gradestudbtn.Name = "gradestudbtn"
        gradestudbtn.Size = New Size(429, 93)
        gradestudbtn.TabIndex = 68
        gradestudbtn.Text = "GRADE STUDENTS"
        gradestudbtn.UseVisualStyleBackColor = False
        ' 
        ' gradingicon
        ' 
        gradingicon.Image = My.Resources.Resources.icons8_rating_52
        gradingicon.Location = New Point(10, 46)
        gradingicon.Margin = New Padding(3, 2, 3, 2)
        gradingicon.Name = "gradingicon"
        gradingicon.Size = New Size(85, 79)
        gradingicon.SizeMode = PictureBoxSizeMode.StretchImage
        gradingicon.TabIndex = 68
        gradingicon.TabStop = False
        ' 
        ' factimeinpnl
        ' 
        factimeinpnl.BackColor = Color.White
        factimeinpnl.Controls.Add(timeoutlbl)
        factimeinpnl.Controls.Add(timetodatlbl)
        factimeinpnl.Controls.Add(timeinbtn)
        factimeinpnl.Location = New Point(729, 221)
        factimeinpnl.Margin = New Padding(3, 2, 3, 2)
        factimeinpnl.Name = "factimeinpnl"
        factimeinpnl.Size = New Size(546, 380)
        factimeinpnl.TabIndex = 77
        ' 
        ' timeoutlbl
        ' 
        timeoutlbl.Font = New Font("Segoe UI", 27F, FontStyle.Bold)
        timeoutlbl.Location = New Point(3, 278)
        timeoutlbl.Name = "timeoutlbl"
        timeoutlbl.Size = New Size(540, 47)
        timeoutlbl.TabIndex = 3
        timeoutlbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' timetodatlbl
        ' 
        timetodatlbl.Font = New Font("Segoe UI", 27F, FontStyle.Bold)
        timetodatlbl.Location = New Point(3, 62)
        timetodatlbl.Name = "timetodatlbl"
        timetodatlbl.Size = New Size(540, 59)
        timetodatlbl.TabIndex = 1
        timetodatlbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' timeinbtn
        ' 
        timeinbtn.BackColor = Color.Indigo
        timeinbtn.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        timeinbtn.ForeColor = Color.White
        timeinbtn.Location = New Point(160, 141)
        timeinbtn.Margin = New Padding(3, 2, 3, 2)
        timeinbtn.Name = "timeinbtn"
        timeinbtn.Size = New Size(207, 87)
        timeinbtn.TabIndex = 0
        timeinbtn.Text = "TIME IN"
        timeinbtn.UseVisualStyleBackColor = False
        ' 
        ' facstudentspnl
        ' 
        facstudentspnl.BackColor = Color.White
        facstudentspnl.Controls.Add(studrecordbtn)
        facstudentspnl.Controls.Add(PictureBox3)
        facstudentspnl.Location = New Point(729, 631)
        facstudentspnl.Margin = New Padding(3, 2, 3, 2)
        facstudentspnl.Name = "facstudentspnl"
        facstudentspnl.Size = New Size(546, 180)
        facstudentspnl.TabIndex = 76
        ' 
        ' studrecordbtn
        ' 
        studrecordbtn.BackColor = Color.Indigo
        studrecordbtn.Font = New Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studrecordbtn.ForeColor = Color.White
        studrecordbtn.Location = New Point(104, 45)
        studrecordbtn.Margin = New Padding(3, 2, 3, 2)
        studrecordbtn.Name = "studrecordbtn"
        studrecordbtn.Size = New Size(429, 93)
        studrecordbtn.TabIndex = 74
        studrecordbtn.Text = "STUDENT RECORD"
        studrecordbtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.icons8_user_male_96
        PictureBox3.Location = New Point(13, 45)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(85, 93)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 68
        PictureBox3.TabStop = False
        ' 
        ' factaskspnl
        ' 
        factaskspnl.BackColor = Color.White
        factaskspnl.Controls.Add(completaskbtn)
        factaskspnl.Controls.Add(tasksicon)
        factaskspnl.Controls.Add(addtasksbtn)
        factaskspnl.Controls.Add(taskslbl)
        factaskspnl.Location = New Point(1303, 629)
        factaskspnl.Margin = New Padding(3, 2, 3, 2)
        factaskspnl.Name = "factaskspnl"
        factaskspnl.Size = New Size(546, 380)
        factaskspnl.TabIndex = 75
        ' 
        ' completaskbtn
        ' 
        completaskbtn.BackColor = Color.Indigo
        completaskbtn.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        completaskbtn.ForeColor = Color.White
        completaskbtn.Location = New Point(281, 301)
        completaskbtn.Margin = New Padding(3, 2, 3, 2)
        completaskbtn.Name = "completaskbtn"
        completaskbtn.Size = New Size(222, 61)
        completaskbtn.TabIndex = 72
        completaskbtn.Text = "Complete Tasks"
        completaskbtn.UseVisualStyleBackColor = False
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
        ' addtasksbtn
        ' 
        addtasksbtn.BackColor = Color.Indigo
        addtasksbtn.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addtasksbtn.ForeColor = Color.White
        addtasksbtn.Location = New Point(38, 301)
        addtasksbtn.Margin = New Padding(3, 2, 3, 2)
        addtasksbtn.Name = "addtasksbtn"
        addtasksbtn.Size = New Size(155, 61)
        addtasksbtn.TabIndex = 68
        addtasksbtn.Text = "Add Tasks"
        addtasksbtn.UseVisualStyleBackColor = False
        ' 
        ' taskslbl
        ' 
        taskslbl.AutoSize = True
        taskslbl.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        taskslbl.ForeColor = Color.Indigo
        taskslbl.Location = New Point(77, 36)
        taskslbl.Name = "taskslbl"
        taskslbl.Size = New Size(231, 45)
        taskslbl.TabIndex = 67
        taskslbl.Text = "Pending Tasks"
        ' 
        ' logoutbtn
        ' 
        logoutbtn.BackColor = Color.Transparent
        logoutbtn.Image = My.Resources.Resources.icons8_log_out_96
        logoutbtn.Location = New Point(1684, 34)
        logoutbtn.Margin = New Padding(3, 2, 3, 2)
        logoutbtn.Name = "logoutbtn"
        logoutbtn.Size = New Size(114, 103)
        logoutbtn.SizeMode = PictureBoxSizeMode.StretchImage
        logoutbtn.TabIndex = 81
        logoutbtn.TabStop = False
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Controls.Add(studgender)
        Panel7.Controls.Add(studgenderlbl)
        Panel7.Controls.Add(femail)
        Panel7.Controls.Add(femaillbl)
        Panel7.Controls.Add(fcontact)
        Panel7.Controls.Add(fcontactlbl)
        Panel7.Controls.Add(fdept)
        Panel7.Controls.Add(fdeptlbl)
        Panel7.Controls.Add(fid)
        Panel7.Controls.Add(fidlbl)
        Panel7.Controls.Add(fprofile)
        Panel7.Controls.Add(fwelcome)
        Panel7.Location = New Point(37, 221)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(651, 788)
        Panel7.TabIndex = 83
        ' 
        ' studgender
        ' 
        studgender.AutoSize = True
        studgender.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        studgender.ForeColor = SystemColors.ActiveCaptionText
        studgender.Location = New Point(251, 125)
        studgender.Name = "studgender"
        studgender.Size = New Size(55, 25)
        studgender.TabIndex = 90
        studgender.Text = "Male"
        ' 
        ' studgenderlbl
        ' 
        studgenderlbl.AutoSize = True
        studgenderlbl.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic)
        studgenderlbl.ForeColor = SystemColors.ActiveCaptionText
        studgenderlbl.Location = New Point(241, 93)
        studgenderlbl.Name = "studgenderlbl"
        studgenderlbl.Size = New Size(93, 32)
        studgenderlbl.TabIndex = 89
        studgenderlbl.Text = "Gender"
        ' 
        ' femail
        ' 
        femail.AutoSize = True
        femail.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold)
        femail.ForeColor = SystemColors.ActiveCaptionText
        femail.Location = New Point(44, 573)
        femail.Name = "femail"
        femail.Size = New Size(281, 37)
        femail.TabIndex = 82
        femail.Text = "jdelacruz@gmail.com"
        ' 
        ' femaillbl
        ' 
        femaillbl.AutoSize = True
        femaillbl.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic)
        femaillbl.ForeColor = SystemColors.ActiveCaptionText
        femaillbl.Location = New Point(31, 528)
        femaillbl.Name = "femaillbl"
        femaillbl.Size = New Size(105, 45)
        femaillbl.TabIndex = 81
        femaillbl.Text = "Email"
        ' 
        ' fcontact
        ' 
        fcontact.AutoSize = True
        fcontact.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold)
        fcontact.ForeColor = SystemColors.ActiveCaptionText
        fcontact.Location = New Point(44, 455)
        fcontact.Name = "fcontact"
        fcontact.Size = New Size(178, 37)
        fcontact.TabIndex = 80
        fcontact.Text = "09123456789"
        ' 
        ' fcontactlbl
        ' 
        fcontactlbl.AutoSize = True
        fcontactlbl.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic)
        fcontactlbl.ForeColor = SystemColors.ActiveCaptionText
        fcontactlbl.Location = New Point(31, 410)
        fcontactlbl.Name = "fcontactlbl"
        fcontactlbl.Size = New Size(267, 45)
        fcontactlbl.TabIndex = 79
        fcontactlbl.Text = "Contact Number"
        ' 
        ' fdept
        ' 
        fdept.AutoSize = True
        fdept.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        fdept.ForeColor = SystemColors.ActiveCaptionText
        fdept.Location = New Point(33, 339)
        fdept.Name = "fdept"
        fdept.Size = New Size(392, 40)
        fdept.TabIndex = 76
        fdept.Text = "College of Computer Studies"
        ' 
        ' fdeptlbl
        ' 
        fdeptlbl.AutoSize = True
        fdeptlbl.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        fdeptlbl.ForeColor = SystemColors.ActiveCaptionText
        fdeptlbl.Location = New Point(31, 294)
        fdeptlbl.Name = "fdeptlbl"
        fdeptlbl.Size = New Size(201, 45)
        fdeptlbl.TabIndex = 68
        fdeptlbl.Text = "Department"
        ' 
        ' fid
        ' 
        fid.AutoSize = True
        fid.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        fid.ForeColor = SystemColors.ActiveCaptionText
        fid.Location = New Point(251, 62)
        fid.Name = "fid"
        fid.Size = New Size(52, 25)
        fid.TabIndex = 67
        fid.Text = "F001"
        ' 
        ' fidlbl
        ' 
        fidlbl.AutoSize = True
        fidlbl.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic)
        fidlbl.ForeColor = SystemColors.ActiveCaptionText
        fidlbl.Location = New Point(241, 30)
        fidlbl.Name = "fidlbl"
        fidlbl.Size = New Size(129, 32)
        fidlbl.TabIndex = 66
        fidlbl.Text = "Faculty ID"
        ' 
        ' fprofile
        ' 
        fprofile.Cursor = Cursors.Hand
        fprofile.Image = My.Resources.Resources.user_square
        fprofile.Location = New Point(31, 24)
        fprofile.Name = "fprofile"
        fprofile.Size = New Size(191, 184)
        fprofile.SizeMode = PictureBoxSizeMode.StretchImage
        fprofile.TabIndex = 0
        fprofile.TabStop = False
        ' 
        ' fwelcome
        ' 
        fwelcome.AutoSize = True
        fwelcome.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        fwelcome.ForeColor = SystemColors.ActiveCaptionText
        fwelcome.Location = New Point(33, 222)
        fwelcome.Name = "fwelcome"
        fwelcome.Size = New Size(400, 45)
        fwelcome.TabIndex = 65
        fwelcome.Text = "Welcome [Faculty Name]"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(viewschedbtn)
        Panel1.Controls.Add(schedicon)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(1303, 220)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(546, 380)
        Panel1.TabIndex = 76
        ' 
        ' viewschedbtn
        ' 
        viewschedbtn.BackColor = Color.Indigo
        viewschedbtn.Font = New Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        viewschedbtn.ForeColor = Color.White
        viewschedbtn.Location = New Point(25, 158)
        viewschedbtn.Margin = New Padding(3, 2, 3, 2)
        viewschedbtn.Name = "viewschedbtn"
        viewschedbtn.Size = New Size(491, 97)
        viewschedbtn.TabIndex = 68
        viewschedbtn.Text = "VIEW SCHEDULE"
        viewschedbtn.UseVisualStyleBackColor = False
        ' 
        ' schedicon
        ' 
        schedicon.Image = My.Resources.Resources.icons8_schedule_96
        schedicon.Location = New Point(11, 17)
        schedicon.Margin = New Padding(3, 2, 3, 2)
        schedicon.Name = "schedicon"
        schedicon.Size = New Size(73, 71)
        schedicon.SizeMode = PictureBoxSizeMode.StretchImage
        schedicon.TabIndex = 69
        schedicon.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Indigo
        Label1.Location = New Point(90, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(154, 45)
        Label1.TabIndex = 67
        Label1.Text = "Schedule"
        ' 
        ' facultyDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        ClientSize = New Size(1904, 1041)
        Controls.Add(Panel1)
        Controls.Add(Panel7)
        Controls.Add(logoutbtn)
        Controls.Add(facgradepnl)
        Controls.Add(factimeinpnl)
        Controls.Add(facstudentspnl)
        Controls.Add(factaskspnl)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "facultyDashboard"
        Text = "Faculty Dashboard"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        facgradepnl.ResumeLayout(False)
        CType(gradingicon, ComponentModel.ISupportInitialize).EndInit()
        factimeinpnl.ResumeLayout(False)
        facstudentspnl.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        factaskspnl.ResumeLayout(False)
        factaskspnl.PerformLayout()
        CType(tasksicon, ComponentModel.ISupportInitialize).EndInit()
        CType(logoutbtn, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(fprofile, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(schedicon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents facgradepnl As Panel
    Friend WithEvents gradestudbtn As Button
    Friend WithEvents gradingicon As PictureBox
    Friend WithEvents factimeinpnl As Panel
    Friend WithEvents timetodatlbl As Label
    Friend WithEvents timeinbtn As Button
    Friend WithEvents facstudentspnl As Panel
    Friend WithEvents factaskspnl As Panel
    Friend WithEvents completaskbtn As Button
    Friend WithEvents tasksicon As PictureBox
    Friend WithEvents addtasksbtn As Button
    Friend WithEvents taskslbl As Label
    Friend WithEvents logoutbtn As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents studrecordbtn As Button
    Friend WithEvents timeoutlbl As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents femail As Label
    Friend WithEvents femaillbl As Label
    Friend WithEvents fcontact As Label
    Friend WithEvents fcontactlbl As Label
    Friend WithEvents fdept As Label
    Friend WithEvents fdeptlbl As Label
    Friend WithEvents fid As Label
    Friend WithEvents fidlbl As Label
    Friend WithEvents fprofile As PictureBox
    Friend WithEvents fwelcome As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents viewschedbtn As Button
    Friend WithEvents schedicon As PictureBox
    Friend WithEvents Timer As Timer
    Friend WithEvents studgender As Label
    Friend WithEvents studgenderlbl As Label
End Class
