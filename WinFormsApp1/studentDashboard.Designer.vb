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
        border = New PictureBox()
        welcomestud = New Label()
        studtaskpnl = New Panel()
        completetasks = New Button()
        tasksicon = New PictureBox()
        addtasks = New Button()
        pendingtaskslbl = New Label()
        studtimeinpnl = New Panel()
        timeoutlbl = New Label()
        timetodatlbl = New Label()
        timeinbtn = New Button()
        studevalpnl = New Panel()
        viewEvalbtn = New Button()
        sumreportlbl = New Label()
        viewgradesbtn = New Button()
        evalicon = New PictureBox()
        logout = New PictureBox()
        ColorDialog1 = New ColorDialog()
        schedicon = New PictureBox()
        viewschedbtn = New Button()
        studschedpnl = New Panel()
        schduledesc = New Label()
        scheduellbl = New Label()
        Panel1 = New Panel()
        studgender = New Label()
        studgenderlbl = New Label()
        studsection = New Label()
        studsectionlbl = New Label()
        studemail = New Label()
        emailbl = New Label()
        studcontact = New Label()
        contactlbl = New Label()
        programlbl = New Label()
        studprogram = New Label()
        studdept = New Label()
        deptlbl = New Label()
        studid = New Label()
        idlbl = New Label()
        studpb = New PictureBox()
        CType(border, ComponentModel.ISupportInitialize).BeginInit()
        studtaskpnl.SuspendLayout()
        CType(tasksicon, ComponentModel.ISupportInitialize).BeginInit()
        studtimeinpnl.SuspendLayout()
        studevalpnl.SuspendLayout()
        CType(evalicon, ComponentModel.ISupportInitialize).BeginInit()
        CType(logout, ComponentModel.ISupportInitialize).BeginInit()
        CType(schedicon, ComponentModel.ISupportInitialize).BeginInit()
        studschedpnl.SuspendLayout()
        Panel1.SuspendLayout()
        CType(studpb, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' border
        ' 
        border.Image = My.Resources.Resources.studentdashboardHeader3
        border.Location = New Point(-2, 0)
        border.Margin = New Padding(3, 2, 3, 2)
        border.Name = "border"
        border.Size = New Size(1928, 180)
        border.SizeMode = PictureBoxSizeMode.StretchImage
        border.TabIndex = 64
        border.TabStop = False
        ' 
        ' welcomestud
        ' 
        welcomestud.AutoSize = True
        welcomestud.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        welcomestud.ForeColor = SystemColors.ActiveCaptionText
        welcomestud.Location = New Point(31, 222)
        welcomestud.Name = "welcomestud"
        welcomestud.Size = New Size(406, 45)
        welcomestud.TabIndex = 65
        welcomestud.Text = "Welcome [Student Name]"
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
        timeoutlbl.Font = New Font("Segoe UI", 27F, FontStyle.Bold)
        timeoutlbl.Location = New Point(3, 288)
        timeoutlbl.Name = "timeoutlbl"
        timeoutlbl.Size = New Size(540, 47)
        timeoutlbl.TabIndex = 2
        timeoutlbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' timetodatlbl
        ' 
        timetodatlbl.Font = New Font("Segoe UI", 27F, FontStyle.Bold)
        timetodatlbl.Location = New Point(3, 64)
        timetodatlbl.Name = "timetodatlbl"
        timetodatlbl.Size = New Size(543, 48)
        timetodatlbl.TabIndex = 1
        timetodatlbl.TextAlign = ContentAlignment.MiddleCenter
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
        ' studevalpnl
        ' 
        studevalpnl.BackColor = Color.White
        studevalpnl.Controls.Add(viewEvalbtn)
        studevalpnl.Controls.Add(sumreportlbl)
        studevalpnl.Controls.Add(viewgradesbtn)
        studevalpnl.Controls.Add(evalicon)
        studevalpnl.Location = New Point(731, 629)
        studevalpnl.Margin = New Padding(3, 2, 3, 2)
        studevalpnl.Name = "studevalpnl"
        studevalpnl.Size = New Size(546, 380)
        studevalpnl.TabIndex = 74
        ' 
        ' viewEvalbtn
        ' 
        viewEvalbtn.BackColor = Color.Indigo
        viewEvalbtn.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        viewEvalbtn.ForeColor = Color.White
        viewEvalbtn.Location = New Point(16, 130)
        viewEvalbtn.Margin = New Padding(3, 2, 3, 2)
        viewEvalbtn.Name = "viewEvalbtn"
        viewEvalbtn.Size = New Size(514, 84)
        viewEvalbtn.TabIndex = 75
        viewEvalbtn.Text = "VIEW EVALUATION"
        viewEvalbtn.UseVisualStyleBackColor = False
        ' 
        ' sumreportlbl
        ' 
        sumreportlbl.AutoSize = True
        sumreportlbl.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sumreportlbl.ForeColor = Color.Indigo
        sumreportlbl.Location = New Point(95, 33)
        sumreportlbl.Name = "sumreportlbl"
        sumreportlbl.Size = New Size(275, 45)
        sumreportlbl.TabIndex = 74
        sumreportlbl.Text = "Summary Report"
        ' 
        ' viewgradesbtn
        ' 
        viewgradesbtn.BackColor = Color.Indigo
        viewgradesbtn.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        viewgradesbtn.ForeColor = Color.White
        viewgradesbtn.Location = New Point(16, 251)
        viewgradesbtn.Margin = New Padding(3, 2, 3, 2)
        viewgradesbtn.Name = "viewgradesbtn"
        viewgradesbtn.Size = New Size(514, 84)
        viewgradesbtn.TabIndex = 68
        viewgradesbtn.Text = "VIEW GRADES"
        viewgradesbtn.UseVisualStyleBackColor = False
        ' 
        ' evalicon
        ' 
        evalicon.Image = My.Resources.Resources.icons8_rating_52
        evalicon.Location = New Point(16, 19)
        evalicon.Margin = New Padding(3, 2, 3, 2)
        evalicon.Name = "evalicon"
        evalicon.Size = New Size(73, 72)
        evalicon.SizeMode = PictureBoxSizeMode.StretchImage
        evalicon.TabIndex = 68
        evalicon.TabStop = False
        ' 
        ' logout
        ' 
        logout.BackColor = Color.Transparent
        logout.Image = My.Resources.Resources.icons8_log_out_96
        logout.Location = New Point(1684, 34)
        logout.Margin = New Padding(3, 2, 3, 2)
        logout.Name = "logout"
        logout.Size = New Size(114, 103)
        logout.SizeMode = PictureBoxSizeMode.StretchImage
        logout.TabIndex = 68
        logout.TabStop = False
        ' 
        ' schedicon
        ' 
        schedicon.Image = My.Resources.Resources.icons8_schedule_96
        schedicon.Location = New Point(15, 15)
        schedicon.Margin = New Padding(3, 2, 3, 2)
        schedicon.Name = "schedicon"
        schedicon.Size = New Size(73, 71)
        schedicon.SizeMode = PictureBoxSizeMode.StretchImage
        schedicon.TabIndex = 67
        schedicon.TabStop = False
        ' 
        ' viewschedbtn
        ' 
        viewschedbtn.BackColor = Color.Indigo
        viewschedbtn.Font = New Font("Segoe UI", 33F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        viewschedbtn.ForeColor = Color.White
        viewschedbtn.Location = New Point(15, 260)
        viewschedbtn.Margin = New Padding(3, 2, 3, 2)
        viewschedbtn.Name = "viewschedbtn"
        viewschedbtn.Size = New Size(515, 86)
        viewschedbtn.TabIndex = 4
        viewschedbtn.Text = "VIEW YOUR SCHEDULE"
        viewschedbtn.UseVisualStyleBackColor = False
        ' 
        ' studschedpnl
        ' 
        studschedpnl.BackColor = Color.White
        studschedpnl.Controls.Add(schduledesc)
        studschedpnl.Controls.Add(scheduellbl)
        studschedpnl.Controls.Add(viewschedbtn)
        studschedpnl.Controls.Add(schedicon)
        studschedpnl.Location = New Point(1305, 221)
        studschedpnl.Margin = New Padding(3, 2, 3, 2)
        studschedpnl.Name = "studschedpnl"
        studschedpnl.Size = New Size(546, 380)
        studschedpnl.TabIndex = 73
        ' 
        ' schduledesc
        ' 
        schduledesc.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        schduledesc.ForeColor = SystemColors.ActiveCaptionText
        schduledesc.Location = New Point(15, 101)
        schduledesc.Name = "schduledesc"
        schduledesc.Size = New Size(515, 139)
        schduledesc.TabIndex = 74
        schduledesc.Text = "Note: The faculty will distribute the schedule for the students. Click the button to view"
        ' 
        ' scheduellbl
        ' 
        scheduellbl.AutoSize = True
        scheduellbl.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        scheduellbl.ForeColor = Color.Indigo
        scheduellbl.Location = New Point(94, 27)
        scheduellbl.Name = "scheduellbl"
        scheduellbl.Size = New Size(154, 45)
        scheduellbl.TabIndex = 73
        scheduellbl.Text = "Schedule"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(studgender)
        Panel1.Controls.Add(studgenderlbl)
        Panel1.Controls.Add(studsection)
        Panel1.Controls.Add(studsectionlbl)
        Panel1.Controls.Add(studemail)
        Panel1.Controls.Add(emailbl)
        Panel1.Controls.Add(studcontact)
        Panel1.Controls.Add(contactlbl)
        Panel1.Controls.Add(programlbl)
        Panel1.Controls.Add(studprogram)
        Panel1.Controls.Add(studdept)
        Panel1.Controls.Add(deptlbl)
        Panel1.Controls.Add(studid)
        Panel1.Controls.Add(idlbl)
        Panel1.Controls.Add(studpb)
        Panel1.Controls.Add(welcomestud)
        Panel1.Location = New Point(37, 221)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(651, 788)
        Panel1.TabIndex = 75
        ' 
        ' studgender
        ' 
        studgender.AutoSize = True
        studgender.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        studgender.ForeColor = SystemColors.ActiveCaptionText
        studgender.Location = New Point(250, 178)
        studgender.Name = "studgender"
        studgender.Size = New Size(55, 25)
        studgender.TabIndex = 86
        studgender.Text = "Male"
        ' 
        ' studgenderlbl
        ' 
        studgenderlbl.AutoSize = True
        studgenderlbl.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic)
        studgenderlbl.ForeColor = SystemColors.ActiveCaptionText
        studgenderlbl.Location = New Point(240, 146)
        studgenderlbl.Name = "studgenderlbl"
        studgenderlbl.Size = New Size(93, 32)
        studgenderlbl.TabIndex = 85
        studgenderlbl.Text = "Gender"
        ' 
        ' studsection
        ' 
        studsection.AutoSize = True
        studsection.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        studsection.ForeColor = SystemColors.ActiveCaptionText
        studsection.Location = New Point(250, 123)
        studsection.Name = "studsection"
        studsection.Size = New Size(36, 25)
        studsection.TabIndex = 84
        studsection.Text = "4A"
        ' 
        ' studsectionlbl
        ' 
        studsectionlbl.AutoSize = True
        studsectionlbl.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic)
        studsectionlbl.ForeColor = SystemColors.ActiveCaptionText
        studsectionlbl.Location = New Point(240, 91)
        studsectionlbl.Name = "studsectionlbl"
        studsectionlbl.Size = New Size(95, 32)
        studsectionlbl.TabIndex = 83
        studsectionlbl.Text = "Section"
        ' 
        ' studemail
        ' 
        studemail.AutoSize = True
        studemail.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        studemail.ForeColor = SystemColors.ActiveCaptionText
        studemail.Location = New Point(31, 687)
        studemail.Name = "studemail"
        studemail.Size = New Size(246, 32)
        studemail.TabIndex = 82
        studemail.Text = "jdelacruz@gmail.com"
        ' 
        ' emailbl
        ' 
        emailbl.AutoSize = True
        emailbl.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic)
        emailbl.ForeColor = SystemColors.ActiveCaptionText
        emailbl.Location = New Point(31, 624)
        emailbl.Name = "emailbl"
        emailbl.Size = New Size(105, 45)
        emailbl.TabIndex = 81
        emailbl.Text = "Email"
        ' 
        ' studcontact
        ' 
        studcontact.AutoSize = True
        studcontact.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        studcontact.ForeColor = SystemColors.ActiveCaptionText
        studcontact.Location = New Point(31, 574)
        studcontact.Name = "studcontact"
        studcontact.Size = New Size(155, 32)
        studcontact.TabIndex = 80
        studcontact.Text = "09123456789"
        ' 
        ' contactlbl
        ' 
        contactlbl.AutoSize = True
        contactlbl.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic)
        contactlbl.ForeColor = SystemColors.ActiveCaptionText
        contactlbl.Location = New Point(31, 515)
        contactlbl.Name = "contactlbl"
        contactlbl.Size = New Size(267, 45)
        contactlbl.TabIndex = 79
        contactlbl.Text = "Contact Number"
        ' 
        ' programlbl
        ' 
        programlbl.AutoSize = True
        programlbl.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        programlbl.ForeColor = SystemColors.ActiveCaptionText
        programlbl.Location = New Point(31, 394)
        programlbl.Name = "programlbl"
        programlbl.Size = New Size(151, 45)
        programlbl.TabIndex = 78
        programlbl.Text = "Program"
        ' 
        ' studprogram
        ' 
        studprogram.AutoSize = True
        studprogram.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studprogram.ForeColor = SystemColors.ActiveCaptionText
        studprogram.Location = New Point(31, 457)
        studprogram.Name = "studprogram"
        studprogram.Size = New Size(519, 32)
        studprogram.TabIndex = 77
        studprogram.Text = "Bachelor of Science in Information Technology"
        ' 
        ' studdept
        ' 
        studdept.AutoSize = True
        studdept.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studdept.ForeColor = SystemColors.ActiveCaptionText
        studdept.Location = New Point(31, 340)
        studdept.Name = "studdept"
        studdept.Size = New Size(392, 40)
        studdept.TabIndex = 76
        studdept.Text = "College of Computer Studies"
        ' 
        ' deptlbl
        ' 
        deptlbl.AutoSize = True
        deptlbl.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        deptlbl.ForeColor = SystemColors.ActiveCaptionText
        deptlbl.Location = New Point(31, 279)
        deptlbl.Name = "deptlbl"
        deptlbl.Size = New Size(201, 45)
        deptlbl.TabIndex = 68
        deptlbl.Text = "Department"
        ' 
        ' studid
        ' 
        studid.AutoSize = True
        studid.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        studid.ForeColor = SystemColors.ActiveCaptionText
        studid.Location = New Point(250, 56)
        studid.Name = "studid"
        studid.Size = New Size(97, 25)
        studid.TabIndex = 67
        studid.Text = "25-00000"
        ' 
        ' idlbl
        ' 
        idlbl.AutoSize = True
        idlbl.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic)
        idlbl.ForeColor = SystemColors.ActiveCaptionText
        idlbl.Location = New Point(240, 24)
        idlbl.Name = "idlbl"
        idlbl.Size = New Size(197, 32)
        idlbl.TabIndex = 66
        idlbl.Text = "Student Number"
        ' 
        ' studpb
        ' 
        studpb.Cursor = Cursors.Hand
        studpb.Image = My.Resources.Resources.user_square
        studpb.Location = New Point(31, 24)
        studpb.Name = "studpb"
        studpb.Size = New Size(191, 184)
        studpb.SizeMode = PictureBoxSizeMode.StretchImage
        studpb.TabIndex = 0
        studpb.TabStop = False
        ' 
        ' studentDashboard
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.DarkGray
        ClientSize = New Size(1904, 1041)
        Controls.Add(Panel1)
        Controls.Add(logout)
        Controls.Add(studevalpnl)
        Controls.Add(studschedpnl)
        Controls.Add(studtimeinpnl)
        Controls.Add(studtaskpnl)
        Controls.Add(border)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "studentDashboard"
        Text = "Dashboard"
        CType(border, ComponentModel.ISupportInitialize).EndInit()
        studtaskpnl.ResumeLayout(False)
        studtaskpnl.PerformLayout()
        CType(tasksicon, ComponentModel.ISupportInitialize).EndInit()
        studtimeinpnl.ResumeLayout(False)
        studevalpnl.ResumeLayout(False)
        studevalpnl.PerformLayout()
        CType(evalicon, ComponentModel.ISupportInitialize).EndInit()
        CType(logout, ComponentModel.ISupportInitialize).EndInit()
        CType(schedicon, ComponentModel.ISupportInitialize).EndInit()
        studschedpnl.ResumeLayout(False)
        studschedpnl.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(studpb, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents border As PictureBox
    Friend WithEvents welcomestud As Label
    Friend WithEvents studtaskpnl As Panel
    Friend WithEvents addtasks As Button
    Friend WithEvents pendingtaskslbl As Label
    Friend WithEvents tasksicon As PictureBox
    Friend WithEvents deptlbl As Label
    Friend WithEvents studtimeinpnl As Panel
    Friend WithEvents timeinbtn As Button
    Friend WithEvents programlbl As Label
    Friend WithEvents timeoutlbl As Label
    Friend WithEvents timetodatlbl As Label
    Friend WithEvents completetasks As Button
    Friend WithEvents studevalpnl As Panel
    Friend WithEvents evalicon As PictureBox
    Friend WithEvents logout As PictureBox
    Friend WithEvents viewgradesbtn As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents schedicon As PictureBox
    Friend WithEvents viewschedbtn As Button
    Friend WithEvents studschedpnl As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents studpb As PictureBox
    Friend WithEvents idlbl As Label
    Friend WithEvents studid As Label
    Friend WithEvents studprogram As Label
    Friend WithEvents studdept As Label
    Friend WithEvents studcontact As Label
    Friend WithEvents contactlbl As Label
    Friend WithEvents emailbl As Label
    Friend WithEvents studemail As Label
    Friend WithEvents studsection As Label
    Friend WithEvents studsectionlbl As Label
    Friend WithEvents studgender As Label
    Friend WithEvents studgenderlbl As Label
    Friend WithEvents sumreportlbl As Label
    Friend WithEvents schduledesc As Label
    Friend WithEvents scheduellbl As Label
    Friend WithEvents viewEvalbtn As Button
End Class
