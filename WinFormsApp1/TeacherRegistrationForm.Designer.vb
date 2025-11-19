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
        tcclearbtn = New Button()
        tcreturnbtn = New Button()
        tcregbtn = New Button()
        tcfnumlbl = New Label()
        tcdeptlbl = New Label()
        tcdeptcb = New ComboBox()
        tcnumtxt = New TextBox()
        tcnumlbl = New Label()
        tcsuffixlbl = New Label()
        tcsuffixtxt = New TextBox()
        tcemailtxt = New TextBox()
        tcemaillbl = New Label()
        tcgendercb = New ComboBox()
        tcgenderlbl = New Label()
        tcmidnamelbl = New Label()
        tcfnamelbl = New Label()
        tclnamelbl = New Label()
        tctitlelbl = New Label()
        tcmidnametxt = New TextBox()
        tcfnametxt = New TextBox()
        tclastnametxt = New TextBox()
        tcfnumbertxt = New TextBox()
        Panel1 = New Panel()
        lblemailInvalid = New Label()
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
        PictureBox1.Size = New Size(1914, 177)
        PictureBox1.TabIndex = 62
        PictureBox1.TabStop = False
        ' 
        ' tcclearbtn
        ' 
        tcclearbtn.BackColor = Color.DarkSlateBlue
        tcclearbtn.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        tcclearbtn.ForeColor = Color.White
        tcclearbtn.Location = New Point(429, 664)
        tcclearbtn.Margin = New Padding(3, 2, 3, 2)
        tcclearbtn.Name = "tcclearbtn"
        tcclearbtn.Size = New Size(180, 72)
        tcclearbtn.TabIndex = 65
        tcclearbtn.Text = "CLEAR"
        tcclearbtn.UseVisualStyleBackColor = False
        ' 
        ' tcreturnbtn
        ' 
        tcreturnbtn.BackColor = Color.SlateGray
        tcreturnbtn.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        tcreturnbtn.ForeColor = Color.White
        tcreturnbtn.Location = New Point(107, 664)
        tcreturnbtn.Margin = New Padding(3, 2, 3, 2)
        tcreturnbtn.Name = "tcreturnbtn"
        tcreturnbtn.Size = New Size(180, 72)
        tcreturnbtn.TabIndex = 64
        tcreturnbtn.Text = "RETURN"
        tcreturnbtn.UseVisualStyleBackColor = False
        ' 
        ' tcregbtn
        ' 
        tcregbtn.BackColor = Color.Indigo
        tcregbtn.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        tcregbtn.ForeColor = Color.White
        tcregbtn.Location = New Point(767, 664)
        tcregbtn.Margin = New Padding(3, 2, 3, 2)
        tcregbtn.Name = "tcregbtn"
        tcregbtn.Size = New Size(180, 72)
        tcregbtn.TabIndex = 63
        tcregbtn.Text = "REGISTER"
        tcregbtn.UseVisualStyleBackColor = False
        ' 
        ' tcfnumlbl
        ' 
        tcfnumlbl.AutoSize = True
        tcfnumlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        tcfnumlbl.ForeColor = Color.Indigo
        tcfnumlbl.Location = New Point(735, 121)
        tcfnumlbl.Name = "tcfnumlbl"
        tcfnumlbl.Size = New Size(220, 37)
        tcfnumlbl.TabIndex = 83
        tcfnumlbl.Text = "Faculty Number"
        ' 
        ' tcdeptlbl
        ' 
        tcdeptlbl.AutoSize = True
        tcdeptlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        tcdeptlbl.ForeColor = Color.Indigo
        tcdeptlbl.Location = New Point(508, 348)
        tcdeptlbl.Name = "tcdeptlbl"
        tcdeptlbl.Size = New Size(174, 37)
        tcdeptlbl.TabIndex = 82
        tcdeptlbl.Text = "Department"
        ' 
        ' tcdeptcb
        ' 
        tcdeptcb.BackColor = Color.Silver
        tcdeptcb.Enabled = False
        tcdeptcb.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tcdeptcb.FormattingEnabled = True
        tcdeptcb.Location = New Point(508, 401)
        tcdeptcb.Margin = New Padding(3, 2, 3, 2)
        tcdeptcb.Name = "tcdeptcb"
        tcdeptcb.Size = New Size(439, 38)
        tcdeptcb.TabIndex = 81
        ' 
        ' tcnumtxt
        ' 
        tcnumtxt.BackColor = Color.Silver
        tcnumtxt.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        tcnumtxt.Location = New Point(724, 585)
        tcnumtxt.Margin = New Padding(3, 2, 3, 2)
        tcnumtxt.Name = "tcnumtxt"
        tcnumtxt.Size = New Size(231, 46)
        tcnumtxt.TabIndex = 80
        ' 
        ' tcnumlbl
        ' 
        tcnumlbl.AutoSize = True
        tcnumlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        tcnumlbl.ForeColor = Color.Indigo
        tcnumlbl.Location = New Point(718, 536)
        tcnumlbl.Name = "tcnumlbl"
        tcnumlbl.Size = New Size(229, 37)
        tcnumlbl.TabIndex = 79
        tcnumlbl.Text = "Contact Number"
        ' 
        ' tcsuffixlbl
        ' 
        tcsuffixlbl.AutoSize = True
        tcsuffixlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        tcsuffixlbl.ForeColor = Color.Indigo
        tcsuffixlbl.Location = New Point(107, 536)
        tcsuffixlbl.Name = "tcsuffixlbl"
        tcsuffixlbl.Size = New Size(91, 37)
        tcsuffixlbl.TabIndex = 78
        tcsuffixlbl.Text = "Suffix"
        ' 
        ' tcsuffixtxt
        ' 
        tcsuffixtxt.BackColor = Color.Silver
        tcsuffixtxt.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        tcsuffixtxt.Location = New Point(107, 585)
        tcsuffixtxt.Margin = New Padding(3, 2, 3, 2)
        tcsuffixtxt.Name = "tcsuffixtxt"
        tcsuffixtxt.Size = New Size(68, 46)
        tcsuffixtxt.TabIndex = 77
        ' 
        ' tcemailtxt
        ' 
        tcemailtxt.BackColor = Color.Silver
        tcemailtxt.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tcemailtxt.Location = New Point(254, 585)
        tcemailtxt.Margin = New Padding(3, 2, 3, 2)
        tcemailtxt.Name = "tcemailtxt"
        tcemailtxt.Size = New Size(437, 46)
        tcemailtxt.TabIndex = 76
        ' 
        ' tcemaillbl
        ' 
        tcemaillbl.AutoSize = True
        tcemaillbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        tcemaillbl.ForeColor = Color.Indigo
        tcemaillbl.Location = New Point(254, 536)
        tcemaillbl.Name = "tcemaillbl"
        tcemaillbl.Size = New Size(87, 37)
        tcemaillbl.TabIndex = 75
        tcemaillbl.Text = "Email"
        ' 
        ' tcgendercb
        ' 
        tcgendercb.BackColor = Color.Silver
        tcgendercb.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tcgendercb.FormattingEnabled = True
        tcgendercb.Location = New Point(533, 171)
        tcgendercb.Margin = New Padding(3, 2, 3, 2)
        tcgendercb.Name = "tcgendercb"
        tcgendercb.Size = New Size(110, 48)
        tcgendercb.TabIndex = 74
        ' 
        ' tcgenderlbl
        ' 
        tcgenderlbl.AutoSize = True
        tcgenderlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        tcgenderlbl.ForeColor = Color.Indigo
        tcgenderlbl.Location = New Point(533, 121)
        tcgenderlbl.Name = "tcgenderlbl"
        tcgenderlbl.Size = New Size(110, 37)
        tcgenderlbl.TabIndex = 73
        tcgenderlbl.Text = "Gender"
        ' 
        ' tcmidnamelbl
        ' 
        tcmidnamelbl.AutoSize = True
        tcmidnamelbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tcmidnamelbl.ForeColor = Color.Indigo
        tcmidnamelbl.Location = New Point(107, 408)
        tcmidnamelbl.Name = "tcmidnamelbl"
        tcmidnamelbl.Size = New Size(191, 37)
        tcmidnamelbl.TabIndex = 72
        tcmidnamelbl.Text = "Middle Name"
        ' 
        ' tcfnamelbl
        ' 
        tcfnamelbl.AutoSize = True
        tcfnamelbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        tcfnamelbl.ForeColor = Color.Indigo
        tcfnamelbl.Location = New Point(107, 265)
        tcfnamelbl.Name = "tcfnamelbl"
        tcfnamelbl.Size = New Size(156, 37)
        tcfnamelbl.TabIndex = 71
        tcfnamelbl.Text = "First Name"
        ' 
        ' tclnamelbl
        ' 
        tclnamelbl.AutoSize = True
        tclnamelbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        tclnamelbl.ForeColor = Color.Indigo
        tclnamelbl.Location = New Point(107, 121)
        tclnamelbl.Name = "tclnamelbl"
        tclnamelbl.Size = New Size(152, 37)
        tclnamelbl.TabIndex = 70
        tclnamelbl.Text = "Last Name"
        ' 
        ' tctitlelbl
        ' 
        tctitlelbl.AutoSize = True
        tctitlelbl.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tctitlelbl.Location = New Point(64, 48)
        tctitlelbl.Name = "tctitlelbl"
        tctitlelbl.Size = New Size(194, 47)
        tctitlelbl.TabIndex = 69
        tctitlelbl.Text = "Full Name"
        ' 
        ' tcmidnametxt
        ' 
        tcmidnametxt.BackColor = Color.Silver
        tcmidnametxt.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        tcmidnametxt.Location = New Point(107, 460)
        tcmidnametxt.Margin = New Padding(3, 2, 3, 2)
        tcmidnametxt.Name = "tcmidnametxt"
        tcmidnametxt.Size = New Size(307, 46)
        tcmidnametxt.TabIndex = 68
        ' 
        ' tcfnametxt
        ' 
        tcfnametxt.BackColor = Color.Silver
        tcfnametxt.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        tcfnametxt.Location = New Point(107, 316)
        tcfnametxt.Margin = New Padding(3, 2, 3, 2)
        tcfnametxt.Name = "tcfnametxt"
        tcfnametxt.Size = New Size(307, 46)
        tcfnametxt.TabIndex = 67
        ' 
        ' tclastnametxt
        ' 
        tclastnametxt.BackColor = Color.Silver
        tclastnametxt.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        tclastnametxt.Location = New Point(107, 173)
        tclastnametxt.Margin = New Padding(3, 2, 3, 2)
        tclastnametxt.Name = "tclastnametxt"
        tclastnametxt.Size = New Size(307, 46)
        tclastnametxt.TabIndex = 66
        ' 
        ' tcfnumbertxt
        ' 
        tcfnumbertxt.BackColor = Color.White
        tcfnumbertxt.Enabled = False
        tcfnumbertxt.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tcfnumbertxt.Location = New Point(735, 173)
        tcfnumbertxt.Margin = New Padding(3, 2, 3, 2)
        tcfnumbertxt.Name = "tcfnumbertxt"
        tcfnumbertxt.ReadOnly = True
        tcfnumbertxt.Size = New Size(122, 46)
        tcfnumbertxt.TabIndex = 90
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblemailInvalid)
        Panel1.Controls.Add(tcdeptlbl)
        Panel1.Controls.Add(tcfnumbertxt)
        Panel1.Controls.Add(tcdeptcb)
        Panel1.Controls.Add(tcregbtn)
        Panel1.Controls.Add(tcgenderlbl)
        Panel1.Controls.Add(tcgendercb)
        Panel1.Controls.Add(tcsuffixlbl)
        Panel1.Controls.Add(tcfnumlbl)
        Panel1.Controls.Add(tctitlelbl)
        Panel1.Controls.Add(tclnamelbl)
        Panel1.Controls.Add(tcfnamelbl)
        Panel1.Controls.Add(tcmidnamelbl)
        Panel1.Controls.Add(tclastnametxt)
        Panel1.Controls.Add(tcsuffixtxt)
        Panel1.Controls.Add(tcreturnbtn)
        Panel1.Controls.Add(tcfnametxt)
        Panel1.Controls.Add(tcemailtxt)
        Panel1.Controls.Add(tcclearbtn)
        Panel1.Controls.Add(tcmidnametxt)
        Panel1.Controls.Add(tcnumlbl)
        Panel1.Controls.Add(tcnumtxt)
        Panel1.Controls.Add(tcemaillbl)
        Panel1.Location = New Point(488, 226)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1024, 767)
        Panel1.TabIndex = 91
        ' 
        ' lblemailInvalid
        ' 
        lblemailInvalid.AutoSize = True
        lblemailInvalid.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblemailInvalid.ForeColor = Color.Maroon
        lblemailInvalid.Location = New Point(535, 554)
        lblemailInvalid.Name = "lblemailInvalid"
        lblemailInvalid.Size = New Size(18, 17)
        lblemailInvalid.TabIndex = 102
        lblemailInvalid.Text = "tt"
        lblemailInvalid.Visible = False
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
    Friend WithEvents tcclearbtn As Button
    Friend WithEvents tcreturnbtn As Button
    Friend WithEvents tcregbtn As Button
    Friend WithEvents tcfnumlbl As Label
    Friend WithEvents tcdeptlbl As Label
    Friend WithEvents tcdeptcb As ComboBox
    Friend WithEvents tcnumtxt As TextBox
    Friend WithEvents tcnumlbl As Label
    Friend WithEvents tcsuffixlbl As Label
    Friend WithEvents tcsuffixtxt As TextBox
    Friend WithEvents tcemailtxt As TextBox
    Friend WithEvents tcemaillbl As Label
    Friend WithEvents tcgendercb As ComboBox
    Friend WithEvents tcgenderlbl As Label
    Friend WithEvents tcmidnamelbl As Label
    Friend WithEvents tcfnamelbl As Label
    Friend WithEvents tclnamelbl As Label
    Friend WithEvents tctitlelbl As Label
    Friend WithEvents tcmidnametxt As TextBox
    Friend WithEvents tcfnametxt As TextBox
    Friend WithEvents tclastnametxt As TextBox
    Friend WithEvents tcfnumbertxt As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblemailInvalid As Label

End Class
