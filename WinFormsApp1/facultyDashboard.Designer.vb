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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(facultyDashboard))
        PictureBox1 = New PictureBox()
        facgradepnl = New Panel()
        gradestudentslbl = New Button()
        gradingicon = New PictureBox()
        facannouncementspnl = New Panel()
        CheckBox4 = New CheckBox()
        announcementslbl = New Label()
        CheckBox5 = New CheckBox()
        announcementsicon = New PictureBox()
        CheckBox6 = New CheckBox()
        factimeinpnl = New Panel()
        Label7 = New Label()
        timeoutlbl = New Label()
        timetodaylbl = New Label()
        timeinbtn = New Button()
        facstudentspnl = New Panel()
        Button6 = New Button()
        PictureBox3 = New PictureBox()
        factaskspnl = New Panel()
        completetasksbtn = New Button()
        tasksicon = New PictureBox()
        addtasksbtn = New Button()
        taskslbl = New Label()
        PictureBox7 = New PictureBox()
        Panel7 = New Panel()
        Label3 = New Label()
        Label10 = New Label()
        Label4 = New Label()
        Label9 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        btnSelectPhoto = New PictureBox()
        Label18 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        facgradepnl.SuspendLayout()
        CType(gradingicon, ComponentModel.ISupportInitialize).BeginInit()
        facannouncementspnl.SuspendLayout()
        CType(announcementsicon, ComponentModel.ISupportInitialize).BeginInit()
        factimeinpnl.SuspendLayout()
        facstudentspnl.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        factaskspnl.SuspendLayout()
        CType(tasksicon, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        CType(btnSelectPhoto, ComponentModel.ISupportInitialize).BeginInit()
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
        facgradepnl.Controls.Add(gradestudentslbl)
        facgradepnl.Controls.Add(gradingicon)
        facgradepnl.Location = New Point(37, 889)
        facgradepnl.Margin = New Padding(3, 2, 3, 2)
        facgradepnl.Name = "facgradepnl"
        facgradepnl.Size = New Size(651, 109)
        facgradepnl.TabIndex = 80
        ' 
        ' gradestudentslbl
        ' 
        gradestudentslbl.BackColor = Color.Indigo
        gradestudentslbl.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gradestudentslbl.ForeColor = Color.White
        gradestudentslbl.Location = New Point(101, 22)
        gradestudentslbl.Margin = New Padding(3, 2, 3, 2)
        gradestudentslbl.Name = "gradestudentslbl"
        gradestudentslbl.Size = New Size(533, 71)
        gradestudentslbl.TabIndex = 68
        gradestudentslbl.Text = "GRADE STUDENTS"
        gradestudentslbl.UseVisualStyleBackColor = False
        ' 
        ' gradingicon
        ' 
        gradingicon.Image = My.Resources.Resources.icons8_rating_52
        gradingicon.Location = New Point(15, 25)
        gradingicon.Margin = New Padding(3, 2, 3, 2)
        gradingicon.Name = "gradingicon"
        gradingicon.Size = New Size(73, 68)
        gradingicon.SizeMode = PictureBoxSizeMode.StretchImage
        gradingicon.TabIndex = 68
        gradingicon.TabStop = False
        ' 
        ' facannouncementspnl
        ' 
        facannouncementspnl.BackColor = Color.White
        facannouncementspnl.Controls.Add(CheckBox4)
        facannouncementspnl.Controls.Add(announcementslbl)
        facannouncementspnl.Controls.Add(CheckBox5)
        facannouncementspnl.Controls.Add(announcementsicon)
        facannouncementspnl.Controls.Add(CheckBox6)
        facannouncementspnl.Location = New Point(729, 629)
        facannouncementspnl.Margin = New Padding(3, 2, 3, 2)
        facannouncementspnl.Name = "facannouncementspnl"
        facannouncementspnl.Size = New Size(546, 380)
        facannouncementspnl.TabIndex = 78
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
        ' factimeinpnl
        ' 
        factimeinpnl.BackColor = Color.White
        factimeinpnl.Controls.Add(Label7)
        factimeinpnl.Controls.Add(timeoutlbl)
        factimeinpnl.Controls.Add(timetodaylbl)
        factimeinpnl.Controls.Add(timeinbtn)
        factimeinpnl.Location = New Point(729, 221)
        factimeinpnl.Margin = New Padding(3, 2, 3, 2)
        factimeinpnl.Name = "factimeinpnl"
        factimeinpnl.Size = New Size(546, 380)
        factimeinpnl.TabIndex = 77
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold)
        Label7.Location = New Point(41, 308)
        Label7.Name = "Label7"
        Label7.Size = New Size(472, 47)
        Label7.TabIndex = 3
        Label7.Text = "October 29, 2025 - 5:01 PM"
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
        ' timetodaylbl
        ' 
        timetodaylbl.AutoSize = True
        timetodaylbl.Font = New Font("Segoe UI", 32.25F, FontStyle.Bold)
        timetodaylbl.Location = New Point(31, 64)
        timetodaylbl.Name = "timetodaylbl"
        timetodaylbl.Size = New Size(471, 59)
        timetodaylbl.TabIndex = 1
        timetodaylbl.Text = "Time Today: 12:30 PM"
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
        ' facstudentspnl
        ' 
        facstudentspnl.BackColor = Color.White
        facstudentspnl.Controls.Add(Button6)
        facstudentspnl.Controls.Add(PictureBox3)
        facstudentspnl.Location = New Point(37, 759)
        facstudentspnl.Margin = New Padding(3, 2, 3, 2)
        facstudentspnl.Name = "facstudentspnl"
        facstudentspnl.Size = New Size(651, 109)
        facstudentspnl.TabIndex = 76
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Indigo
        Button6.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = Color.White
        Button6.Location = New Point(101, 21)
        Button6.Margin = New Padding(3, 2, 3, 2)
        Button6.Name = "Button6"
        Button6.Size = New Size(533, 72)
        Button6.TabIndex = 74
        Button6.Text = "VIEW STUDENTS"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.icons8_user_male_96
        PictureBox3.Location = New Point(13, 21)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(73, 71)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 68
        PictureBox3.TabStop = False
        ' 
        ' factaskspnl
        ' 
        factaskspnl.BackColor = Color.White
        factaskspnl.Controls.Add(completetasksbtn)
        factaskspnl.Controls.Add(tasksicon)
        factaskspnl.Controls.Add(addtasksbtn)
        factaskspnl.Controls.Add(taskslbl)
        factaskspnl.Location = New Point(1303, 629)
        factaskspnl.Margin = New Padding(3, 2, 3, 2)
        factaskspnl.Name = "factaskspnl"
        factaskspnl.Size = New Size(546, 380)
        factaskspnl.TabIndex = 75
        ' 
        ' completetasksbtn
        ' 
        completetasksbtn.BackColor = Color.Indigo
        completetasksbtn.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        completetasksbtn.ForeColor = Color.White
        completetasksbtn.Location = New Point(281, 301)
        completetasksbtn.Margin = New Padding(3, 2, 3, 2)
        completetasksbtn.Name = "completetasksbtn"
        completetasksbtn.Size = New Size(222, 61)
        completetasksbtn.TabIndex = 72
        completetasksbtn.Text = "Complete Tasks"
        completetasksbtn.UseVisualStyleBackColor = False
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
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.Image = My.Resources.Resources.icons8_log_out_96
        PictureBox7.Location = New Point(1684, 34)
        PictureBox7.Margin = New Padding(3, 2, 3, 2)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(114, 103)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 81
        PictureBox7.TabStop = False
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Controls.Add(Label3)
        Panel7.Controls.Add(Label10)
        Panel7.Controls.Add(Label4)
        Panel7.Controls.Add(Label9)
        Panel7.Controls.Add(Label14)
        Panel7.Controls.Add(Label15)
        Panel7.Controls.Add(Label16)
        Panel7.Controls.Add(Label17)
        Panel7.Controls.Add(btnSelectPhoto)
        Panel7.Controls.Add(Label18)
        Panel7.Location = New Point(37, 221)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(651, 515)
        Panel7.TabIndex = 83
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(251, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(197, 25)
        Label3.TabIndex = 82
        Label3.Text = "jdelacruz@gmail.com"
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
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(251, 122)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 25)
        Label4.TabIndex = 80
        Label4.Text = "09123456789"
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
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = SystemColors.ActiveCaptionText
        Label14.Location = New Point(33, 339)
        Label14.Name = "Label14"
        Label14.Size = New Size(392, 40)
        Label14.TabIndex = 76
        Label14.Text = "College of Computer Studies"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = SystemColors.ActiveCaptionText
        Label15.Location = New Point(31, 294)
        Label15.Name = "Label15"
        Label15.Size = New Size(201, 45)
        Label15.TabIndex = 68
        Label15.Text = "Department"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label16.ForeColor = SystemColors.ActiveCaptionText
        Label16.Location = New Point(251, 62)
        Label16.Name = "Label16"
        Label16.Size = New Size(52, 25)
        Label16.TabIndex = 67
        Label16.Text = "F001"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic)
        Label17.ForeColor = SystemColors.ActiveCaptionText
        Label17.Location = New Point(241, 30)
        Label17.Name = "Label17"
        Label17.Size = New Size(129, 32)
        Label17.TabIndex = 66
        Label17.Text = "Faculty ID"
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
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = SystemColors.ActiveCaptionText
        Label18.Location = New Point(33, 222)
        Label18.Name = "Label18"
        Label18.Size = New Size(400, 45)
        Label18.TabIndex = 65
        Label18.Text = "Welcome [Faculty Name]"
        ' 
        ' facultyDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        ClientSize = New Size(1904, 1041)
        Controls.Add(Panel7)
        Controls.Add(PictureBox7)
        Controls.Add(facgradepnl)
        Controls.Add(facannouncementspnl)
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
        facannouncementspnl.ResumeLayout(False)
        facannouncementspnl.PerformLayout()
        CType(announcementsicon, ComponentModel.ISupportInitialize).EndInit()
        factimeinpnl.ResumeLayout(False)
        factimeinpnl.PerformLayout()
        facstudentspnl.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        factaskspnl.ResumeLayout(False)
        factaskspnl.PerformLayout()
        CType(tasksicon, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(btnSelectPhoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents facgradepnl As Panel
    Friend WithEvents gradestudentslbl As Button
    Friend WithEvents gradingicon As PictureBox
    Friend WithEvents facannouncementspnl As Panel
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents announcementslbl As Label
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents announcementsicon As PictureBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents factimeinpnl As Panel
    Friend WithEvents timeoutlbl As Label
    Friend WithEvents timetodaylbl As Label
    Friend WithEvents timeinbtn As Button
    Friend WithEvents facstudentspnl As Panel
    Friend WithEvents factaskspnl As Panel
    Friend WithEvents completetasksbtn As Button
    Friend WithEvents tasksicon As PictureBox
    Friend WithEvents addtasksbtn As Button
    Friend WithEvents taskslbl As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnSelectPhoto As PictureBox
    Friend WithEvents Label18 As Label
End Class
