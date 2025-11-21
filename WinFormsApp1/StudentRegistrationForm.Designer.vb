<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentRegistrationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentRegistrationForm))
        studlastntxt = New TextBox()
        studfnametxt = New TextBox()
        studmiddlentxt = New TextBox()
        studtitlelbl = New Label()
        studlnamelbl = New Label()
        studfname = New Label()
        studmddilenlbl = New Label()
        studgenderlbl = New Label()
        studgendercb = New ComboBox()
        studemaillbl = New Label()
        studemailtxt = New TextBox()
        studsuffixtxt = New TextBox()
        suffixlbl = New Label()
        studnumtxt = New TextBox()
        studcontlbl = New Label()
        studcourcb = New ComboBox()
        studdeptcb = New ComboBox()
        deptlbl = New Label()
        studnolbl = New Label()
        studregbtn = New Button()
        studreternbtn = New Button()
        studclearbtn = New Button()
        PictureBox1 = New PictureBox()
        studcourlbl = New Label()
        Panel1 = New Panel()
        lblemailInvalid = New Label()
        studnotxt = New TextBox()
        sectionlbl = New Label()
        studsectioncb = New ComboBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' studlastntxt
        ' 
        studlastntxt.BackColor = Color.Silver
        studlastntxt.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        studlastntxt.Location = New Point(107, 173)
        studlastntxt.Margin = New Padding(3, 2, 3, 2)
        studlastntxt.Name = "studlastntxt"
        studlastntxt.Size = New Size(307, 46)
        studlastntxt.TabIndex = 1
        ' 
        ' studfnametxt
        ' 
        studfnametxt.BackColor = Color.Silver
        studfnametxt.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        studfnametxt.Location = New Point(107, 316)
        studfnametxt.Margin = New Padding(3, 2, 3, 2)
        studfnametxt.Name = "studfnametxt"
        studfnametxt.Size = New Size(307, 46)
        studfnametxt.TabIndex = 2
        ' 
        ' studmiddlentxt
        ' 
        studmiddlentxt.BackColor = Color.Silver
        studmiddlentxt.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        studmiddlentxt.Location = New Point(107, 460)
        studmiddlentxt.Margin = New Padding(3, 2, 3, 2)
        studmiddlentxt.Name = "studmiddlentxt"
        studmiddlentxt.Size = New Size(307, 46)
        studmiddlentxt.TabIndex = 3
        ' 
        ' studtitlelbl
        ' 
        studtitlelbl.AutoSize = True
        studtitlelbl.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studtitlelbl.Location = New Point(64, 48)
        studtitlelbl.Name = "studtitlelbl"
        studtitlelbl.Size = New Size(194, 47)
        studtitlelbl.TabIndex = 4
        studtitlelbl.Text = "Full Name"
        ' 
        ' studlnamelbl
        ' 
        studlnamelbl.AutoSize = True
        studlnamelbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studlnamelbl.ForeColor = Color.Indigo
        studlnamelbl.Location = New Point(107, 121)
        studlnamelbl.Name = "studlnamelbl"
        studlnamelbl.Size = New Size(152, 37)
        studlnamelbl.TabIndex = 5
        studlnamelbl.Text = "Last Name"
        ' 
        ' studfname
        ' 
        studfname.AutoSize = True
        studfname.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        studfname.ForeColor = Color.Indigo
        studfname.Location = New Point(107, 265)
        studfname.Name = "studfname"
        studfname.Size = New Size(156, 37)
        studfname.TabIndex = 6
        studfname.Text = "First Name"
        ' 
        ' studmddilenlbl
        ' 
        studmddilenlbl.AutoSize = True
        studmddilenlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        studmddilenlbl.ForeColor = Color.Indigo
        studmddilenlbl.Location = New Point(107, 408)
        studmddilenlbl.Name = "studmddilenlbl"
        studmddilenlbl.Size = New Size(191, 37)
        studmddilenlbl.TabIndex = 7
        studmddilenlbl.Text = "Middle Name"
        ' 
        ' studgenderlbl
        ' 
        studgenderlbl.AutoSize = True
        studgenderlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        studgenderlbl.ForeColor = Color.Indigo
        studgenderlbl.Location = New Point(107, 543)
        studgenderlbl.Name = "studgenderlbl"
        studgenderlbl.Size = New Size(110, 37)
        studgenderlbl.TabIndex = 9
        studgenderlbl.Text = "Gender"
        ' 
        ' studgendercb
        ' 
        studgendercb.BackColor = Color.Silver
        studgendercb.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studgendercb.FormattingEnabled = True
        studgendercb.Location = New Point(107, 592)
        studgendercb.Margin = New Padding(3, 2, 3, 2)
        studgendercb.Name = "studgendercb"
        studgendercb.Size = New Size(110, 45)
        studgendercb.TabIndex = 10
        ' 
        ' studemaillbl
        ' 
        studemaillbl.AutoSize = True
        studemaillbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        studemaillbl.ForeColor = Color.Indigo
        studemaillbl.Location = New Point(240, 543)
        studemaillbl.Name = "studemaillbl"
        studemaillbl.Size = New Size(87, 37)
        studemaillbl.TabIndex = 11
        studemaillbl.Text = "Email"
        ' 
        ' studemailtxt
        ' 
        studemailtxt.BackColor = Color.Silver
        studemailtxt.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studemailtxt.Location = New Point(240, 592)
        studemailtxt.Margin = New Padding(3, 2, 3, 2)
        studemailtxt.Name = "studemailtxt"
        studemailtxt.Size = New Size(437, 46)
        studemailtxt.TabIndex = 12
        ' 
        ' studsuffixtxt
        ' 
        studsuffixtxt.BackColor = Color.Silver
        studsuffixtxt.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        studsuffixtxt.Location = New Point(831, 167)
        studsuffixtxt.Margin = New Padding(3, 2, 3, 2)
        studsuffixtxt.Name = "studsuffixtxt"
        studsuffixtxt.Size = New Size(68, 46)
        studsuffixtxt.TabIndex = 13
        ' 
        ' suffixlbl
        ' 
        suffixlbl.AutoSize = True
        suffixlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        suffixlbl.ForeColor = Color.Indigo
        suffixlbl.Location = New Point(831, 121)
        suffixlbl.Name = "suffixlbl"
        suffixlbl.Size = New Size(91, 37)
        suffixlbl.TabIndex = 14
        suffixlbl.Text = "Suffix"
        ' 
        ' studnumtxt
        ' 
        studnumtxt.BackColor = Color.Silver
        studnumtxt.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        studnumtxt.Location = New Point(714, 592)
        studnumtxt.Margin = New Padding(3, 2, 3, 2)
        studnumtxt.Name = "studnumtxt"
        studnumtxt.Size = New Size(231, 46)
        studnumtxt.TabIndex = 16
        ' 
        ' studcontlbl
        ' 
        studcontlbl.AutoSize = True
        studcontlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        studcontlbl.ForeColor = Color.Indigo
        studcontlbl.Location = New Point(714, 543)
        studcontlbl.Name = "studcontlbl"
        studcontlbl.Size = New Size(229, 37)
        studcontlbl.TabIndex = 15
        studcontlbl.Text = "Contact Number"
        ' 
        ' studcourcb
        ' 
        studcourcb.BackColor = Color.Silver
        studcourcb.Font = New Font("Segoe UI", 15.75F)
        studcourcb.FormattingEnabled = True
        studcourcb.Location = New Point(470, 461)
        studcourcb.Margin = New Padding(3, 2, 3, 2)
        studcourcb.Name = "studcourcb"
        studcourcb.Size = New Size(439, 38)
        studcourcb.TabIndex = 17
        ' 
        ' studdeptcb
        ' 
        studdeptcb.BackColor = Color.Silver
        studdeptcb.Font = New Font("Segoe UI", 15.75F)
        studdeptcb.FormattingEnabled = True
        studdeptcb.Location = New Point(470, 314)
        studdeptcb.Margin = New Padding(3, 2, 3, 2)
        studdeptcb.Name = "studdeptcb"
        studdeptcb.Size = New Size(439, 38)
        studdeptcb.TabIndex = 19
        ' 
        ' deptlbl
        ' 
        deptlbl.AutoSize = True
        deptlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        deptlbl.ForeColor = Color.Indigo
        deptlbl.Location = New Point(465, 265)
        deptlbl.Name = "deptlbl"
        deptlbl.Size = New Size(174, 37)
        deptlbl.TabIndex = 20
        deptlbl.Text = "Department"
        ' 
        ' studnolbl
        ' 
        studnolbl.AutoSize = True
        studnolbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        studnolbl.ForeColor = Color.Indigo
        studnolbl.Location = New Point(449, 121)
        studnolbl.Name = "studnolbl"
        studnolbl.Size = New Size(229, 37)
        studnolbl.TabIndex = 21
        studnolbl.Text = "Student Number"
        ' 
        ' studregbtn
        ' 
        studregbtn.BackColor = Color.Indigo
        studregbtn.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        studregbtn.ForeColor = Color.White
        studregbtn.Location = New Point(767, 664)
        studregbtn.Margin = New Padding(3, 2, 3, 2)
        studregbtn.Name = "studregbtn"
        studregbtn.Size = New Size(180, 72)
        studregbtn.TabIndex = 28
        studregbtn.Text = "REGISTER"
        studregbtn.UseVisualStyleBackColor = False
        ' 
        ' studreternbtn
        ' 
        studreternbtn.BackColor = Color.SlateGray
        studreternbtn.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studreternbtn.ForeColor = Color.White
        studreternbtn.Location = New Point(107, 664)
        studreternbtn.Margin = New Padding(3, 2, 3, 2)
        studreternbtn.Name = "studreternbtn"
        studreternbtn.Size = New Size(180, 72)
        studreternbtn.TabIndex = 29
        studreternbtn.Text = "RETURN"
        studreternbtn.UseVisualStyleBackColor = False
        ' 
        ' studclearbtn
        ' 
        studclearbtn.BackColor = Color.DarkSlateBlue
        studclearbtn.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        studclearbtn.ForeColor = Color.White
        studclearbtn.Location = New Point(429, 664)
        studclearbtn.Margin = New Padding(3, 2, 3, 2)
        studclearbtn.Name = "studclearbtn"
        studclearbtn.Size = New Size(180, 72)
        studclearbtn.TabIndex = 30
        studclearbtn.Text = "CLEAR"
        studclearbtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.studentHeader1
        PictureBox1.Location = New Point(-3, -2)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1920, 180)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        ' 
        ' studcourlbl
        ' 
        studcourlbl.AutoSize = True
        studcourlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        studcourlbl.ForeColor = Color.Indigo
        studcourlbl.Location = New Point(470, 408)
        studcourlbl.Name = "studcourlbl"
        studcourlbl.Size = New Size(130, 37)
        studcourlbl.TabIndex = 32
        studcourlbl.Text = "Program"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblemailInvalid)
        Panel1.Controls.Add(studnotxt)
        Panel1.Controls.Add(sectionlbl)
        Panel1.Controls.Add(studsectioncb)
        Panel1.Controls.Add(studtitlelbl)
        Panel1.Controls.Add(studcourlbl)
        Panel1.Controls.Add(studcourcb)
        Panel1.Controls.Add(deptlbl)
        Panel1.Controls.Add(studdeptcb)
        Panel1.Controls.Add(studlastntxt)
        Panel1.Controls.Add(studnolbl)
        Panel1.Controls.Add(studgendercb)
        Panel1.Controls.Add(studemailtxt)
        Panel1.Controls.Add(studgenderlbl)
        Panel1.Controls.Add(studnumtxt)
        Panel1.Controls.Add(studemaillbl)
        Panel1.Controls.Add(studsuffixtxt)
        Panel1.Controls.Add(suffixlbl)
        Panel1.Controls.Add(studfnametxt)
        Panel1.Controls.Add(studfname)
        Panel1.Controls.Add(studcontlbl)
        Panel1.Controls.Add(studlnamelbl)
        Panel1.Controls.Add(studmiddlentxt)
        Panel1.Controls.Add(studmddilenlbl)
        Panel1.Controls.Add(studreternbtn)
        Panel1.Controls.Add(studclearbtn)
        Panel1.Controls.Add(studregbtn)
        Panel1.Location = New Point(488, 226)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1024, 767)
        Panel1.TabIndex = 33
        ' 
        ' lblemailInvalid
        ' 
        lblemailInvalid.AutoSize = True
        lblemailInvalid.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblemailInvalid.ForeColor = Color.Maroon
        lblemailInvalid.Location = New Point(535, 554)
        lblemailInvalid.Name = "lblemailInvalid"
        lblemailInvalid.Size = New Size(0, 17)
        lblemailInvalid.TabIndex = 103
        lblemailInvalid.Visible = False
        ' 
        ' studnotxt
        ' 
        studnotxt.BackColor = Color.Silver
        studnotxt.Enabled = False
        studnotxt.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        studnotxt.Location = New Point(484, 173)
        studnotxt.Margin = New Padding(3, 2, 3, 2)
        studnotxt.Name = "studnotxt"
        studnotxt.ReadOnly = True
        studnotxt.Size = New Size(145, 46)
        studnotxt.TabIndex = 35
        studnotxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' sectionlbl
        ' 
        sectionlbl.AutoSize = True
        sectionlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        sectionlbl.ForeColor = Color.Indigo
        sectionlbl.Location = New Point(703, 122)
        sectionlbl.Name = "sectionlbl"
        sectionlbl.Size = New Size(112, 37)
        sectionlbl.TabIndex = 34
        sectionlbl.Text = "Section"
        ' 
        ' studsectioncb
        ' 
        studsectioncb.BackColor = Color.Silver
        studsectioncb.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studsectioncb.FormattingEnabled = True
        studsectioncb.Location = New Point(716, 169)
        studsectioncb.Margin = New Padding(3, 2, 3, 2)
        studsectioncb.Name = "studsectioncb"
        studsectioncb.Size = New Size(71, 48)
        studsectioncb.TabIndex = 33
        ' 
        ' StudentRegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.regisformsBG_bw1
        ClientSize = New Size(1904, 1041)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "StudentRegistrationForm"
        Text = "Student Registration Form"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents studlastntxt As TextBox
    Friend WithEvents studfnametxt As TextBox
    Friend WithEvents studmiddlentxt As TextBox
    Friend WithEvents studtitlelbl As Label
    Friend WithEvents studlnamelbl As Label
    Friend WithEvents studfname As Label
    Friend WithEvents studmddilenlbl As Label
    Friend WithEvents studgenderlbl As Label
    Friend WithEvents studgendercb As ComboBox
    Friend WithEvents studemaillbl As Label
    Friend WithEvents studemailtxt As TextBox
    Friend WithEvents studsuffixtxt As TextBox
    Friend WithEvents suffixlbl As Label
    Friend WithEvents studnumtxt As TextBox
    Friend WithEvents studcontlbl As Label
    Friend WithEvents studcourcb As ComboBox
    Friend WithEvents studdeptcb As ComboBox
    Friend WithEvents deptlbl As Label
    Friend WithEvents studnolbl As Label
    Friend WithEvents studregbtn As Button
    Friend WithEvents studreternbtn As Button
    Friend WithEvents studclearbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents studcourlbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents sectionlbl As Label
    Friend WithEvents studsectioncb As ComboBox
    Friend WithEvents studnotxt As TextBox
    Friend WithEvents lblemailInvalid As Label

End Class
