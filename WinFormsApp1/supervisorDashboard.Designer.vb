<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class supervisorDashboard
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(supervisorDashboard))
        PictureBox1 = New PictureBox()
        Panel6 = New Panel()
        evalstudbtn = New Button()
        PictureBox6 = New PictureBox()
        Panel5 = New Panel()
        viewvisitlogbtn = New Button()
        PictureBox5 = New PictureBox()
        Panel3 = New Panel()
        timeoutlbl = New Label()
        timetodatlbl = New Label()
        timeinbtn = New Button()
        Panel2 = New Panel()
        vewinternbtn = New Button()
        PictureBox3 = New PictureBox()
        staffstaskpnl = New Panel()
        completetaskbtn = New Button()
        PictureBox2 = New PictureBox()
        addtaskbtn = New Button()
        pendinglbl = New Label()
        Panel7 = New Panel()
        staffcompadd = New Label()
        staffcompaddlbl = New Label()
        staffgender = New Label()
        studgenderlbl = New Label()
        staffemail = New Label()
        stafemaillbl = New Label()
        staffcontact = New Label()
        staffcontactlbl = New Label()
        staffposlbl = New Label()
        staffpos = New Label()
        staffcomp = New Label()
        staffcomplbl = New Label()
        staffid = New Label()
        staffidlbl = New Label()
        profilebtn = New PictureBox()
        staffwelcome = New Label()
        panelbrowser = New Panel()
        backsbtn = New PictureBox()
        web = New Microsoft.Web.WebView2.WinForms.WebView2()
        Timer = New Timer(components)
        Panel1 = New Panel()
        viewgradebtn = New Button()
        PictureBox4 = New PictureBox()
        logoutbtn = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        staffstaskpnl.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        CType(profilebtn, ComponentModel.ISupportInitialize).BeginInit()
        panelbrowser.SuspendLayout()
        CType(backsbtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(web, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(logoutbtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.DarkGray
        PictureBox1.Image = My.Resources.Resources.supervisorDashboardHeader
        PictureBox1.Location = New Point(0, -2)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1928, 180)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 66
        PictureBox1.TabStop = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(evalstudbtn)
        Panel6.Controls.Add(PictureBox6)
        Panel6.Location = New Point(741, 772)
        Panel6.Margin = New Padding(3, 2, 3, 2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(543, 111)
        Panel6.TabIndex = 80
        ' 
        ' evalstudbtn
        ' 
        evalstudbtn.BackColor = Color.Indigo
        evalstudbtn.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        evalstudbtn.ForeColor = Color.White
        evalstudbtn.Location = New Point(96, 22)
        evalstudbtn.Margin = New Padding(3, 2, 3, 2)
        evalstudbtn.Name = "evalstudbtn"
        evalstudbtn.Size = New Size(429, 69)
        evalstudbtn.TabIndex = 68
        evalstudbtn.Text = "EVALUATE STUDENTS"
        evalstudbtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.icons8_rating_52
        PictureBox6.Location = New Point(17, 22)
        PictureBox6.Margin = New Padding(3, 2, 3, 2)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(73, 69)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 68
        PictureBox6.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(viewvisitlogbtn)
        Panel5.Controls.Add(PictureBox5)
        Panel5.Location = New Point(741, 629)
        Panel5.Margin = New Padding(3, 2, 3, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(543, 117)
        Panel5.TabIndex = 79
        ' 
        ' viewvisitlogbtn
        ' 
        viewvisitlogbtn.BackColor = Color.Indigo
        viewvisitlogbtn.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        viewvisitlogbtn.ForeColor = Color.White
        viewvisitlogbtn.Location = New Point(94, 22)
        viewvisitlogbtn.Margin = New Padding(3, 2, 3, 2)
        viewvisitlogbtn.Name = "viewvisitlogbtn"
        viewvisitlogbtn.Size = New Size(431, 71)
        viewvisitlogbtn.TabIndex = 74
        viewvisitlogbtn.Text = "VIEW VISITATION LOGS"
        viewvisitlogbtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.icons8_book_90
        PictureBox5.Location = New Point(15, 22)
        PictureBox5.Margin = New Padding(3, 2, 3, 2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(73, 71)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 68
        PictureBox5.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(timeoutlbl)
        Panel3.Controls.Add(timetodatlbl)
        Panel3.Controls.Add(timeinbtn)
        Panel3.Location = New Point(738, 221)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(546, 380)
        Panel3.TabIndex = 77
        ' 
        ' timeoutlbl
        ' 
        timeoutlbl.Font = New Font("Segoe UI", 27F, FontStyle.Bold)
        timeoutlbl.Location = New Point(3, 276)
        timeoutlbl.Name = "timeoutlbl"
        timeoutlbl.Size = New Size(540, 47)
        timeoutlbl.TabIndex = 3
        timeoutlbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' timetodatlbl
        ' 
        timetodatlbl.Font = New Font("Segoe UI", 27F, FontStyle.Bold)
        timetodatlbl.Location = New Point(3, 64)
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
        timeinbtn.Location = New Point(172, 146)
        timeinbtn.Margin = New Padding(3, 2, 3, 2)
        timeinbtn.Name = "timeinbtn"
        timeinbtn.Size = New Size(207, 87)
        timeinbtn.TabIndex = 0
        timeinbtn.Text = "TIME IN"
        timeinbtn.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(vewinternbtn)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(738, 913)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(546, 96)
        Panel2.TabIndex = 76
        ' 
        ' vewinternbtn
        ' 
        vewinternbtn.BackColor = Color.Indigo
        vewinternbtn.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        vewinternbtn.ForeColor = Color.White
        vewinternbtn.Location = New Point(96, 11)
        vewinternbtn.Margin = New Padding(3, 2, 3, 2)
        vewinternbtn.Name = "vewinternbtn"
        vewinternbtn.Size = New Size(432, 71)
        vewinternbtn.TabIndex = 76
        vewinternbtn.Text = "VIEW INTERNS"
        vewinternbtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.icons8_user_male_96
        PictureBox3.Location = New Point(17, 11)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(73, 71)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 74
        PictureBox3.TabStop = False
        ' 
        ' staffstaskpnl
        ' 
        staffstaskpnl.BackColor = Color.White
        staffstaskpnl.Controls.Add(completetaskbtn)
        staffstaskpnl.Controls.Add(PictureBox2)
        staffstaskpnl.Controls.Add(addtaskbtn)
        staffstaskpnl.Controls.Add(pendinglbl)
        staffstaskpnl.Location = New Point(1312, 629)
        staffstaskpnl.Margin = New Padding(3, 2, 3, 2)
        staffstaskpnl.Name = "staffstaskpnl"
        staffstaskpnl.Size = New Size(546, 380)
        staffstaskpnl.TabIndex = 75
        ' 
        ' completetaskbtn
        ' 
        completetaskbtn.BackColor = Color.Indigo
        completetaskbtn.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        completetaskbtn.ForeColor = Color.White
        completetaskbtn.Location = New Point(281, 301)
        completetaskbtn.Margin = New Padding(3, 2, 3, 2)
        completetaskbtn.Name = "completetaskbtn"
        completetaskbtn.Size = New Size(222, 61)
        completetaskbtn.TabIndex = 72
        completetaskbtn.Text = "Complete Tasks"
        completetaskbtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.icons8_tasks_48
        PictureBox2.Location = New Point(15, 22)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(69, 71)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 67
        PictureBox2.TabStop = False
        ' 
        ' addtaskbtn
        ' 
        addtaskbtn.BackColor = Color.Indigo
        addtaskbtn.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addtaskbtn.ForeColor = Color.White
        addtaskbtn.Location = New Point(38, 301)
        addtaskbtn.Margin = New Padding(3, 2, 3, 2)
        addtaskbtn.Name = "addtaskbtn"
        addtaskbtn.Size = New Size(155, 61)
        addtaskbtn.TabIndex = 68
        addtaskbtn.Text = "Add Tasks"
        addtaskbtn.UseVisualStyleBackColor = False
        ' 
        ' pendinglbl
        ' 
        pendinglbl.AutoSize = True
        pendinglbl.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pendinglbl.ForeColor = Color.Indigo
        pendinglbl.Location = New Point(77, 36)
        pendinglbl.Name = "pendinglbl"
        pendinglbl.Size = New Size(231, 45)
        pendinglbl.TabIndex = 67
        pendinglbl.Text = "Pending Tasks"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Controls.Add(staffcompadd)
        Panel7.Controls.Add(staffcompaddlbl)
        Panel7.Controls.Add(staffgender)
        Panel7.Controls.Add(studgenderlbl)
        Panel7.Controls.Add(staffemail)
        Panel7.Controls.Add(stafemaillbl)
        Panel7.Controls.Add(staffcontact)
        Panel7.Controls.Add(staffcontactlbl)
        Panel7.Controls.Add(staffposlbl)
        Panel7.Controls.Add(staffpos)
        Panel7.Controls.Add(staffcomp)
        Panel7.Controls.Add(staffcomplbl)
        Panel7.Controls.Add(staffid)
        Panel7.Controls.Add(staffidlbl)
        Panel7.Controls.Add(profilebtn)
        Panel7.Controls.Add(staffwelcome)
        Panel7.Location = New Point(37, 221)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(651, 788)
        Panel7.TabIndex = 82
        ' 
        ' staffcompadd
        ' 
        staffcompadd.AutoSize = True
        staffcompadd.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        staffcompadd.ForeColor = SystemColors.ActiveCaptionText
        staffcompadd.Location = New Point(41, 444)
        staffcompadd.Name = "staffcompadd"
        staffcompadd.Size = New Size(197, 32)
        staffcompadd.TabIndex = 90
        staffcompadd.Text = "123 St. Kingsfield"
        ' 
        ' staffcompaddlbl
        ' 
        staffcompaddlbl.AutoSize = True
        staffcompaddlbl.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        staffcompaddlbl.ForeColor = SystemColors.ActiveCaptionText
        staffcompaddlbl.Location = New Point(31, 394)
        staffcompaddlbl.Name = "staffcompaddlbl"
        staffcompaddlbl.Size = New Size(289, 45)
        staffcompaddlbl.TabIndex = 89
        staffcompaddlbl.Text = "Company Address"
        ' 
        ' staffgender
        ' 
        staffgender.AutoSize = True
        staffgender.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        staffgender.ForeColor = SystemColors.ActiveCaptionText
        staffgender.Location = New Point(251, 125)
        staffgender.Name = "staffgender"
        staffgender.Size = New Size(55, 25)
        staffgender.TabIndex = 88
        staffgender.Text = "Male"
        ' 
        ' studgenderlbl
        ' 
        studgenderlbl.AutoSize = True
        studgenderlbl.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic)
        studgenderlbl.ForeColor = SystemColors.ActiveCaptionText
        studgenderlbl.Location = New Point(241, 93)
        studgenderlbl.Name = "studgenderlbl"
        studgenderlbl.Size = New Size(93, 32)
        studgenderlbl.TabIndex = 87
        studgenderlbl.Text = "Gender"
        ' 
        ' staffemail
        ' 
        staffemail.AutoSize = True
        staffemail.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        staffemail.ForeColor = SystemColors.ActiveCaptionText
        staffemail.Location = New Point(38, 626)
        staffemail.Name = "staffemail"
        staffemail.Size = New Size(246, 32)
        staffemail.TabIndex = 82
        staffemail.Text = "jdelacruz@gmail.com"
        ' 
        ' stafemaillbl
        ' 
        stafemaillbl.AutoSize = True
        stafemaillbl.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic)
        stafemaillbl.ForeColor = SystemColors.ActiveCaptionText
        stafemaillbl.Location = New Point(33, 581)
        stafemaillbl.Name = "stafemaillbl"
        stafemaillbl.Size = New Size(105, 45)
        stafemaillbl.TabIndex = 81
        stafemaillbl.Text = "Email"
        ' 
        ' staffcontact
        ' 
        staffcontact.AutoSize = True
        staffcontact.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        staffcontact.ForeColor = SystemColors.ActiveCaptionText
        staffcontact.Location = New Point(41, 722)
        staffcontact.Name = "staffcontact"
        staffcontact.Size = New Size(155, 32)
        staffcontact.TabIndex = 80
        staffcontact.Text = "09123456789"
        ' 
        ' staffcontactlbl
        ' 
        staffcontactlbl.AutoSize = True
        staffcontactlbl.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic)
        staffcontactlbl.ForeColor = SystemColors.ActiveCaptionText
        staffcontactlbl.Location = New Point(36, 677)
        staffcontactlbl.Name = "staffcontactlbl"
        staffcontactlbl.Size = New Size(267, 45)
        staffcontactlbl.TabIndex = 79
        staffcontactlbl.Text = "Contact Number"
        ' 
        ' staffposlbl
        ' 
        staffposlbl.AutoSize = True
        staffposlbl.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        staffposlbl.ForeColor = SystemColors.ActiveCaptionText
        staffposlbl.Location = New Point(31, 490)
        staffposlbl.Name = "staffposlbl"
        staffposlbl.Size = New Size(141, 45)
        staffposlbl.TabIndex = 78
        staffposlbl.Text = "Position"
        ' 
        ' staffpos
        ' 
        staffpos.AutoSize = True
        staffpos.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        staffpos.ForeColor = SystemColors.ActiveCaptionText
        staffpos.Location = New Point(41, 535)
        staffpos.Name = "staffpos"
        staffpos.Size = New Size(131, 32)
        staffpos.TabIndex = 77
        staffpos.Text = "Missionary"
        ' 
        ' staffcomp
        ' 
        staffcomp.AutoSize = True
        staffcomp.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        staffcomp.ForeColor = SystemColors.ActiveCaptionText
        staffcomp.Location = New Point(41, 339)
        staffcomp.Name = "staffcomp"
        staffcomp.Size = New Size(108, 40)
        staffcomp.TabIndex = 76
        staffcomp.Text = "Adonis"
        ' 
        ' staffcomplbl
        ' 
        staffcomplbl.AutoSize = True
        staffcomplbl.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        staffcomplbl.ForeColor = SystemColors.ActiveCaptionText
        staffcomplbl.Location = New Point(31, 294)
        staffcomplbl.Name = "staffcomplbl"
        staffcomplbl.Size = New Size(161, 45)
        staffcomplbl.TabIndex = 68
        staffcomplbl.Text = "Company"
        ' 
        ' staffid
        ' 
        staffid.AutoSize = True
        staffid.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        staffid.ForeColor = SystemColors.ActiveCaptionText
        staffid.Location = New Point(251, 62)
        staffid.Name = "staffid"
        staffid.Size = New Size(52, 25)
        staffid.TabIndex = 67
        staffid.Text = "S001"
        ' 
        ' staffidlbl
        ' 
        staffidlbl.AutoSize = True
        staffidlbl.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic)
        staffidlbl.ForeColor = SystemColors.ActiveCaptionText
        staffidlbl.Location = New Point(241, 30)
        staffidlbl.Name = "staffidlbl"
        staffidlbl.Size = New Size(166, 32)
        staffidlbl.TabIndex = 66
        staffidlbl.Text = "Supervisor ID"
        ' 
        ' profilebtn
        ' 
        profilebtn.Cursor = Cursors.Hand
        profilebtn.Image = My.Resources.Resources.user_square
        profilebtn.Location = New Point(31, 24)
        profilebtn.Name = "profilebtn"
        profilebtn.Size = New Size(191, 184)
        profilebtn.SizeMode = PictureBoxSizeMode.StretchImage
        profilebtn.TabIndex = 0
        profilebtn.TabStop = False
        ' 
        ' staffwelcome
        ' 
        staffwelcome.AutoSize = True
        staffwelcome.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        staffwelcome.ForeColor = SystemColors.ActiveCaptionText
        staffwelcome.Location = New Point(33, 222)
        staffwelcome.Name = "staffwelcome"
        staffwelcome.Size = New Size(448, 45)
        staffwelcome.TabIndex = 65
        staffwelcome.Text = "Welcome [Supervisor Name]"
        ' 
        ' panelbrowser
        ' 
        panelbrowser.Controls.Add(backsbtn)
        panelbrowser.Controls.Add(web)
        panelbrowser.Dock = DockStyle.Fill
        panelbrowser.Location = New Point(0, 0)
        panelbrowser.Name = "panelbrowser"
        panelbrowser.Size = New Size(1684, 796)
        panelbrowser.TabIndex = 91
        panelbrowser.Visible = False
        ' 
        ' backsbtn
        ' 
        backsbtn.BackColor = Color.Transparent
        backsbtn.Image = My.Resources.Resources.icons8_log_out_96
        backsbtn.Location = New Point(1800, 10)
        backsbtn.Margin = New Padding(3, 2, 3, 2)
        backsbtn.Name = "backsbtn"
        backsbtn.Size = New Size(90, 80)
        backsbtn.SizeMode = PictureBoxSizeMode.StretchImage
        backsbtn.TabIndex = 82
        backsbtn.TabStop = False
        ' 
        ' web
        ' 
        web.AllowExternalDrop = True
        web.CreationProperties = Nothing
        web.DefaultBackgroundColor = Color.White
        web.Dock = DockStyle.Fill
        web.Location = New Point(0, 0)
        web.Name = "web"
        web.Size = New Size(1684, 796)
        web.TabIndex = 0
        web.ZoomFactor = 1R
        ' 
        ' Timer
        ' 
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(viewgradebtn)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Location = New Point(1312, 221)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(546, 380)
        Panel1.TabIndex = 85
        ' 
        ' viewgradebtn
        ' 
        viewgradebtn.BackColor = Color.Indigo
        viewgradebtn.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        viewgradebtn.ForeColor = Color.White
        viewgradebtn.Location = New Point(38, 141)
        viewgradebtn.Margin = New Padding(3, 2, 3, 2)
        viewgradebtn.Name = "viewgradebtn"
        viewgradebtn.Size = New Size(473, 87)
        viewgradebtn.TabIndex = 4
        viewgradebtn.Text = "VIEW GRADE DATA"
        viewgradebtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.icons8_positive_dynamic_100
        PictureBox4.Location = New Point(13, 13)
        PictureBox4.Margin = New Padding(3, 2, 3, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(73, 71)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 69
        PictureBox4.TabStop = False
        ' 
        ' logoutbtn
        ' 
        logoutbtn.BackColor = Color.Transparent
        logoutbtn.Image = My.Resources.Resources.icons8_log_out_96
        logoutbtn.Location = New Point(1580, 41)
        logoutbtn.Margin = New Padding(3, 2, 3, 2)
        logoutbtn.Name = "logoutbtn"
        logoutbtn.Size = New Size(92, 99)
        logoutbtn.SizeMode = PictureBoxSizeMode.StretchImage
        logoutbtn.TabIndex = 83
        logoutbtn.TabStop = False
        ' 
        ' supervisorDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        ClientSize = New Size(1684, 796)
        Controls.Add(panelbrowser)
        Controls.Add(Panel1)
        Controls.Add(Panel7)
        Controls.Add(logoutbtn)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(staffstaskpnl)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "supervisorDashboard"
        Text = "supervisorDashboard"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        staffstaskpnl.ResumeLayout(False)
        staffstaskpnl.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(profilebtn, ComponentModel.ISupportInitialize).EndInit()
        panelbrowser.ResumeLayout(False)
        CType(backsbtn, ComponentModel.ISupportInitialize).EndInit()
        CType(web, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(logoutbtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents evalstudbtn As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents timeoutlbl As Label
    Friend WithEvents timetodatlbl As Label
    Friend WithEvents timeinbtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents staffstaskpnl As Panel
    Friend WithEvents completetaskbtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents addtaskbtn As Button
    Friend WithEvents pendinglbl As Label
    Friend WithEvents vewinternbtn As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents viewvisitlogbtn As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents staffemail As Label
    Friend WithEvents stafemaillbl As Label
    Friend WithEvents staffcontact As Label
    Friend WithEvents staffcontactlbl As Label
    Friend WithEvents staffposlbl As Label
    Friend WithEvents staffpos As Label
    Friend WithEvents staffcomp As Label
    Friend WithEvents staffcomplbl As Label
    Friend WithEvents staffid As Label
    Friend WithEvents staffidlbl As Label
    Friend WithEvents profilebtn As PictureBox
    Friend WithEvents staffwelcome As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents viewgradebtn As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents staffcompadd As Label
    Friend WithEvents staffcompaddlbl As Label
    Friend WithEvents staffgender As Label
    Friend WithEvents studgenderlbl As Label
    Friend WithEvents panelbrowser As Panel
    Friend WithEvents web As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents backsbtn As PictureBox
    Friend WithEvents logoutbtn As PictureBox
End Class
