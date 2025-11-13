<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TeacherRegistrationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeacherRegistrationForm))
        PictureBox1 = New PictureBox()
        clearbtn = New Button()
        returnbtn = New Button()
        regbtn = New Button()
        fnumlbl = New Label()
        deptlbl = New Label()
        deptcb = New ComboBox()
        numtxt = New TextBox()
        numlbl = New Label()
        suffixlbl = New Label()
        suffixtxt = New TextBox()
        emailtxt = New TextBox()
        emaillbl = New Label()
        gendercb = New ComboBox()
        genderlbl = New Label()
        midnamelbl = New Label()
        fnamelbl = New Label()
        lnamelbl = New Label()
        fullnamelbl = New Label()
        midnametxt = New TextBox()
        fnametxt = New TextBox()
        lastnametxt = New TextBox()
        fnumbertxt = New TextBox()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.facultyheader
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1914, 159)
        PictureBox1.TabIndex = 62
        PictureBox1.TabStop = False
        ' 
        ' clearbtn
        ' 
        clearbtn.BackColor = Color.DarkSlateBlue
        clearbtn.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        clearbtn.ForeColor = Color.White
        clearbtn.Location = New Point(429, 664)
        clearbtn.Margin = New Padding(3, 2, 3, 2)
        clearbtn.Name = "clearbtn"
        clearbtn.Size = New Size(180, 72)
        clearbtn.TabIndex = 65
        clearbtn.Text = "CLEAR"
        clearbtn.UseVisualStyleBackColor = False
        ' 
        ' returnbtn
        ' 
        returnbtn.BackColor = Color.SlateGray
        returnbtn.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        returnbtn.ForeColor = Color.White
        returnbtn.Location = New Point(107, 664)
        returnbtn.Margin = New Padding(3, 2, 3, 2)
        returnbtn.Name = "returnbtn"
        returnbtn.Size = New Size(180, 72)
        returnbtn.TabIndex = 64
        returnbtn.Text = "RETURN"
        returnbtn.UseVisualStyleBackColor = False
        ' 
        ' regbtn
        ' 
        regbtn.BackColor = Color.Indigo
        regbtn.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        regbtn.ForeColor = Color.White
        regbtn.Location = New Point(767, 664)
        regbtn.Margin = New Padding(3, 2, 3, 2)
        regbtn.Name = "regbtn"
        regbtn.Size = New Size(180, 72)
        regbtn.TabIndex = 63
        regbtn.Text = "REGISTER"
        regbtn.UseVisualStyleBackColor = False
        ' 
        ' fnumlbl
        ' 
        fnumlbl.AutoSize = True
        fnumlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        fnumlbl.ForeColor = Color.Indigo
        fnumlbl.Location = New Point(735, 121)
        fnumlbl.Name = "fnumlbl"
        fnumlbl.Size = New Size(274, 46)
        fnumlbl.TabIndex = 83
        fnumlbl.Text = "Faculty Number"
        ' 
        ' deptlbl
        ' 
        deptlbl.AutoSize = True
        deptlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        deptlbl.ForeColor = Color.Indigo
        deptlbl.Location = New Point(540, 321)
        deptlbl.Name = "deptlbl"
        deptlbl.Size = New Size(213, 46)
        deptlbl.TabIndex = 82
        deptlbl.Text = "Department"
        ' 
        ' deptcb
        ' 
        deptcb.BackColor = Color.Silver
        deptcb.Enabled = False
        deptcb.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        deptcb.FormattingEnabled = True
        deptcb.Items.AddRange(New Object() {"COLLEGE OF COMPUTER STUDIES", "COLLEGE OF EDUCATION", "COLLEGE OF ENGINEERING", "COLLEGE OF NURSING", "COLLEGE OF ARTS AND SCIENCE", "COLLEGE OF BUSINESS AND ACCOUNTANCY", "COLLEGE OF HOSPITALITY MANAGEMENT"})
        deptcb.Location = New Point(540, 374)
        deptcb.Margin = New Padding(3, 2, 3, 2)
        deptcb.Name = "deptcb"
        deptcb.Size = New Size(327, 56)
        deptcb.TabIndex = 81
        ' 
        ' numtxt
        ' 
        numtxt.BackColor = Color.Silver
        numtxt.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        numtxt.Location = New Point(724, 585)
        numtxt.Margin = New Padding(3, 2, 3, 2)
        numtxt.Name = "numtxt"
        numtxt.Size = New Size(231, 56)
        numtxt.TabIndex = 80
        ' 
        ' numlbl
        ' 
        numlbl.AutoSize = True
        numlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        numlbl.ForeColor = Color.Indigo
        numlbl.Location = New Point(718, 536)
        numlbl.Name = "numlbl"
        numlbl.Size = New Size(284, 46)
        numlbl.TabIndex = 79
        numlbl.Text = "Contact Number"
        ' 
        ' suffixlbl
        ' 
        suffixlbl.AutoSize = True
        suffixlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        suffixlbl.ForeColor = Color.Indigo
        suffixlbl.Location = New Point(107, 536)
        suffixlbl.Name = "suffixlbl"
        suffixlbl.Size = New Size(115, 46)
        suffixlbl.TabIndex = 78
        suffixlbl.Text = "Suffix"
        ' 
        ' suffixtxt
        ' 
        suffixtxt.BackColor = Color.Silver
        suffixtxt.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        suffixtxt.Location = New Point(107, 585)
        suffixtxt.Margin = New Padding(3, 2, 3, 2)
        suffixtxt.Name = "suffixtxt"
        suffixtxt.Size = New Size(102, 56)
        suffixtxt.TabIndex = 77
        ' 
        ' emailtxt
        ' 
        emailtxt.BackColor = Color.Silver
        emailtxt.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        emailtxt.Location = New Point(404, 586)
        emailtxt.Margin = New Padding(3, 2, 3, 2)
        emailtxt.Name = "emailtxt"
        emailtxt.Size = New Size(231, 56)
        emailtxt.TabIndex = 76
        ' 
        ' emaillbl
        ' 
        emaillbl.AutoSize = True
        emaillbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        emaillbl.ForeColor = Color.Indigo
        emaillbl.Location = New Point(404, 536)
        emaillbl.Name = "emaillbl"
        emaillbl.Size = New Size(107, 46)
        emaillbl.TabIndex = 75
        emaillbl.Text = "Email"
        ' 
        ' gendercb
        ' 
        gendercb.BackColor = Color.Silver
        gendercb.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gendercb.FormattingEnabled = True
        gendercb.Items.AddRange(New Object() {"MALE", "FEMALE"})
        gendercb.Location = New Point(540, 166)
        gendercb.Margin = New Padding(3, 2, 3, 2)
        gendercb.Name = "gendercb"
        gendercb.Size = New Size(142, 56)
        gendercb.TabIndex = 74
        ' 
        ' genderlbl
        ' 
        genderlbl.AutoSize = True
        genderlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        genderlbl.ForeColor = Color.Indigo
        genderlbl.Location = New Point(540, 121)
        genderlbl.Name = "genderlbl"
        genderlbl.Size = New Size(136, 46)
        genderlbl.TabIndex = 73
        genderlbl.Text = "Gender"
        ' 
        ' midnamelbl
        ' 
        midnamelbl.AutoSize = True
        midnamelbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        midnamelbl.ForeColor = Color.Indigo
        midnamelbl.Location = New Point(107, 408)
        midnamelbl.Name = "midnamelbl"
        midnamelbl.Size = New Size(236, 46)
        midnamelbl.TabIndex = 72
        midnamelbl.Text = "Middle Name"
        ' 
        ' fnamelbl
        ' 
        fnamelbl.AutoSize = True
        fnamelbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        fnamelbl.ForeColor = Color.Indigo
        fnamelbl.Location = New Point(107, 265)
        fnamelbl.Name = "fnamelbl"
        fnamelbl.Size = New Size(193, 46)
        fnamelbl.TabIndex = 71
        fnamelbl.Text = "First Name"
        ' 
        ' lnamelbl
        ' 
        lnamelbl.AutoSize = True
        lnamelbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        lnamelbl.ForeColor = Color.Indigo
        lnamelbl.Location = New Point(107, 121)
        lnamelbl.Name = "lnamelbl"
        lnamelbl.Size = New Size(186, 46)
        lnamelbl.TabIndex = 70
        lnamelbl.Text = "Last Name"
        ' 
        ' fullnamelbl
        ' 
        fullnamelbl.AutoSize = True
        fullnamelbl.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        fullnamelbl.Location = New Point(64, 48)
        fullnamelbl.Name = "fullnamelbl"
        fullnamelbl.Size = New Size(245, 60)
        fullnamelbl.TabIndex = 69
        fullnamelbl.Text = "Full Name"
        ' 
        ' midnametxt
        ' 
        midnametxt.BackColor = Color.Silver
        midnametxt.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        midnametxt.Location = New Point(107, 460)
        midnametxt.Margin = New Padding(3, 2, 3, 2)
        midnametxt.Name = "midnametxt"
        midnametxt.Size = New Size(307, 56)
        midnametxt.TabIndex = 68
        ' 
        ' fnametxt
        ' 
        fnametxt.BackColor = Color.Silver
        fnametxt.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        fnametxt.Location = New Point(107, 316)
        fnametxt.Margin = New Padding(3, 2, 3, 2)
        fnametxt.Name = "fnametxt"
        fnametxt.Size = New Size(307, 56)
        fnametxt.TabIndex = 67
        ' 
        ' lastnametxt
        ' 
        lastnametxt.BackColor = Color.Silver
        lastnametxt.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        lastnametxt.Location = New Point(107, 173)
        lastnametxt.Margin = New Padding(3, 2, 3, 2)
        lastnametxt.Name = "lastnametxt"
        lastnametxt.Size = New Size(307, 56)
        lastnametxt.TabIndex = 66
        ' 
        ' fnumbertxt
        ' 
        fnumbertxt.BackColor = Color.Silver
        fnumbertxt.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        fnumbertxt.Location = New Point(764, 168)
        fnumbertxt.Margin = New Padding(3, 2, 3, 2)
        fnumbertxt.Name = "fnumbertxt"
        fnumbertxt.Size = New Size(122, 56)
        fnumbertxt.TabIndex = 90
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(deptlbl)
        Panel1.Controls.Add(fnumbertxt)
        Panel1.Controls.Add(deptcb)
        Panel1.Controls.Add(regbtn)
        Panel1.Controls.Add(genderlbl)
        Panel1.Controls.Add(gendercb)
        Panel1.Controls.Add(suffixlbl)
        Panel1.Controls.Add(fnumlbl)
        Panel1.Controls.Add(fullnamelbl)
        Panel1.Controls.Add(lnamelbl)
        Panel1.Controls.Add(fnamelbl)
        Panel1.Controls.Add(midnamelbl)
        Panel1.Controls.Add(lastnametxt)
        Panel1.Controls.Add(suffixtxt)
        Panel1.Controls.Add(returnbtn)
        Panel1.Controls.Add(fnametxt)
        Panel1.Controls.Add(emailtxt)
        Panel1.Controls.Add(clearbtn)
        Panel1.Controls.Add(midnametxt)
        Panel1.Controls.Add(numlbl)
        Panel1.Controls.Add(numtxt)
        Panel1.Controls.Add(emaillbl)
        Panel1.Location = New Point(488, 226)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1024, 767)
        Panel1.TabIndex = 91
        ' 
        ' TeacherRegistrationForm
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackgroundImage = My.Resources.Resources.regisformsBG_bw1
        ClientSize = New Size(1904, 1041)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "TeacherRegistrationForm"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents clearbtn As Button
    Friend WithEvents returnbtn As Button
    Friend WithEvents regbtn As Button
    Friend WithEvents fnumlbl As Label
    Friend WithEvents deptlbl As Label
    Friend WithEvents deptcb As ComboBox
    Friend WithEvents numtxt As TextBox
    Friend WithEvents numlbl As Label
    Friend WithEvents suffixlbl As Label
    Friend WithEvents suffixtxt As TextBox
    Friend WithEvents emailtxt As TextBox
    Friend WithEvents emaillbl As Label
    Friend WithEvents gendercb As ComboBox
    Friend WithEvents genderlbl As Label
    Friend WithEvents midnamelbl As Label
    Friend WithEvents fnamelbl As Label
    Friend WithEvents lnamelbl As Label
    Friend WithEvents fullnamelbl As Label
    Friend WithEvents midnametxt As TextBox
    Friend WithEvents fnametxt As TextBox
    Friend WithEvents lastnametxt As TextBox
    Friend WithEvents fnumbertxt As TextBox
    Friend WithEvents Panel1 As Panel

End Class
