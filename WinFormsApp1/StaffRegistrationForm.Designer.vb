<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffRegistrationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffRegistrationForm))
        PictureBox1 = New PictureBox()
        staffidlbl = New Label()
        staffcompnumtxt = New TextBox()
        staffcontlbl = New Label()
        staffsuffixlbl = New Label()
        staffsuffixtxt = New TextBox()
        staffemailtxt = New TextBox()
        staffemaillbl = New Label()
        staffgendercb = New ComboBox()
        staffgenderlbl = New Label()
        staffmidnamelbl = New Label()
        stafffnamelbl = New Label()
        stafflnamelbl = New Label()
        stafftitlelbl = New Label()
        staffmidnametxt = New TextBox()
        stafffnametxt = New TextBox()
        stafflnametxt = New TextBox()
        staffcompnametxt = New Label()
        staffcompostxt = New TextBox()
        staffcomposlbl = New Label()
        staffregbtn = New Button()
        staffclearbtn = New Button()
        staffreturnbtn = New Button()
        Panel1 = New Panel()
        staffcomptxt = New ComboBox()
        staffaddcompbtn = New Button()
        staffidtxt = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.staffHeader1
        PictureBox1.Location = New Point(-1, -3)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1920, 180)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 63
        PictureBox1.TabStop = False
        ' 
        ' staffidlbl
        ' 
        staffidlbl.AutoSize = True
        staffidlbl.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        staffidlbl.ForeColor = Color.Indigo
        staffidlbl.Location = New Point(735, 121)
        staffidlbl.Name = "staffidlbl"
        staffidlbl.Size = New Size(203, 40)
        staffidlbl.TabIndex = 81
        staffidlbl.Text = "Supervisor ID"
        ' 
        ' staffcompnumtxt
        ' 
        staffcompnumtxt.BackColor = Color.Silver
        staffcompnumtxt.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        staffcompnumtxt.Location = New Point(724, 585)
        staffcompnumtxt.Margin = New Padding(3, 2, 3, 2)
        staffcompnumtxt.Name = "staffcompnumtxt"
        staffcompnumtxt.Size = New Size(231, 46)
        staffcompnumtxt.TabIndex = 78
        ' 
        ' staffcontlbl
        ' 
        staffcontlbl.AutoSize = True
        staffcontlbl.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        staffcontlbl.ForeColor = Color.Indigo
        staffcontlbl.Location = New Point(718, 536)
        staffcontlbl.Name = "staffcontlbl"
        staffcontlbl.Size = New Size(245, 40)
        staffcontlbl.TabIndex = 77
        staffcontlbl.Text = "Contact Number"
        ' 
        ' staffsuffixlbl
        ' 
        staffsuffixlbl.AutoSize = True
        staffsuffixlbl.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        staffsuffixlbl.ForeColor = Color.Indigo
        staffsuffixlbl.Location = New Point(107, 536)
        staffsuffixlbl.Name = "staffsuffixlbl"
        staffsuffixlbl.Size = New Size(97, 40)
        staffsuffixlbl.TabIndex = 76
        staffsuffixlbl.Text = "Suffix"
        ' 
        ' staffsuffixtxt
        ' 
        staffsuffixtxt.BackColor = Color.Silver
        staffsuffixtxt.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        staffsuffixtxt.Location = New Point(107, 585)
        staffsuffixtxt.Margin = New Padding(3, 2, 3, 2)
        staffsuffixtxt.Name = "staffsuffixtxt"
        staffsuffixtxt.Size = New Size(51, 46)
        staffsuffixtxt.TabIndex = 75
        ' 
        ' staffemailtxt
        ' 
        staffemailtxt.BackColor = Color.Silver
        staffemailtxt.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        staffemailtxt.Location = New Point(325, 585)
        staffemailtxt.Margin = New Padding(3, 2, 3, 2)
        staffemailtxt.Name = "staffemailtxt"
        staffemailtxt.Size = New Size(345, 33)
        staffemailtxt.TabIndex = 74
        ' 
        ' staffemaillbl
        ' 
        staffemaillbl.AutoSize = True
        staffemaillbl.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        staffemaillbl.ForeColor = Color.Indigo
        staffemaillbl.Location = New Point(325, 535)
        staffemaillbl.Name = "staffemaillbl"
        staffemaillbl.Size = New Size(91, 40)
        staffemaillbl.TabIndex = 73
        staffemaillbl.Text = "Email"
        ' 
        ' staffgendercb
        ' 
        staffgendercb.BackColor = Color.Silver
        staffgendercb.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        staffgendercb.FormattingEnabled = True
        staffgendercb.Items.AddRange(New Object() {"Male", "Female"})
        staffgendercb.Location = New Point(540, 166)
        staffgendercb.Margin = New Padding(3, 2, 3, 2)
        staffgendercb.Name = "staffgendercb"
        staffgendercb.Size = New Size(142, 48)
        staffgendercb.TabIndex = 72
        ' 
        ' staffgenderlbl
        ' 
        staffgenderlbl.AutoSize = True
        staffgenderlbl.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        staffgenderlbl.ForeColor = Color.Indigo
        staffgenderlbl.Location = New Point(540, 121)
        staffgenderlbl.Name = "staffgenderlbl"
        staffgenderlbl.Size = New Size(118, 40)
        staffgenderlbl.TabIndex = 71
        staffgenderlbl.Text = "Gender"
        ' 
        ' staffmidnamelbl
        ' 
        staffmidnamelbl.AutoSize = True
        staffmidnamelbl.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        staffmidnamelbl.ForeColor = Color.Indigo
        staffmidnamelbl.Location = New Point(107, 408)
        staffmidnamelbl.Name = "staffmidnamelbl"
        staffmidnamelbl.Size = New Size(203, 40)
        staffmidnamelbl.TabIndex = 70
        staffmidnamelbl.Text = "Middle Name"
        ' 
        ' stafffnamelbl
        ' 
        stafffnamelbl.AutoSize = True
        stafffnamelbl.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        stafffnamelbl.ForeColor = Color.Indigo
        stafffnamelbl.Location = New Point(107, 265)
        stafffnamelbl.Name = "stafffnamelbl"
        stafffnamelbl.Size = New Size(166, 40)
        stafffnamelbl.TabIndex = 69
        stafffnamelbl.Text = "First Name"
        ' 
        ' stafflnamelbl
        ' 
        stafflnamelbl.AutoSize = True
        stafflnamelbl.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        stafflnamelbl.ForeColor = Color.Indigo
        stafflnamelbl.Location = New Point(107, 121)
        stafflnamelbl.Name = "stafflnamelbl"
        stafflnamelbl.Size = New Size(162, 40)
        stafflnamelbl.TabIndex = 68
        stafflnamelbl.Text = "Last Name"
        ' 
        ' stafftitlelbl
        ' 
        stafftitlelbl.AutoSize = True
        stafftitlelbl.Font = New Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        stafftitlelbl.Location = New Point(64, 48)
        stafftitlelbl.Name = "stafftitlelbl"
        stafftitlelbl.Size = New Size(204, 50)
        stafftitlelbl.TabIndex = 67
        stafftitlelbl.Text = "Full Name"
        ' 
        ' staffmidnametxt
        ' 
        staffmidnametxt.BackColor = Color.Silver
        staffmidnametxt.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        staffmidnametxt.Location = New Point(107, 460)
        staffmidnametxt.Margin = New Padding(3, 2, 3, 2)
        staffmidnametxt.Name = "staffmidnametxt"
        staffmidnametxt.Size = New Size(231, 46)
        staffmidnametxt.TabIndex = 66
        ' 
        ' stafffnametxt
        ' 
        stafffnametxt.BackColor = Color.Silver
        stafffnametxt.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        stafffnametxt.Location = New Point(107, 316)
        stafffnametxt.Margin = New Padding(3, 2, 3, 2)
        stafffnametxt.Name = "stafffnametxt"
        stafffnametxt.Size = New Size(231, 46)
        stafffnametxt.TabIndex = 65
        ' 
        ' stafflnametxt
        ' 
        stafflnametxt.BackColor = Color.Silver
        stafflnametxt.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        stafflnametxt.Location = New Point(107, 173)
        stafflnametxt.Margin = New Padding(3, 2, 3, 2)
        stafflnametxt.Name = "stafflnametxt"
        stafflnametxt.Size = New Size(231, 46)
        stafflnametxt.TabIndex = 64
        ' 
        ' staffcompnametxt
        ' 
        staffcompnametxt.AutoSize = True
        staffcompnametxt.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        staffcompnametxt.ForeColor = Color.Indigo
        staffcompnametxt.Location = New Point(540, 265)
        staffcompnametxt.Name = "staffcompnametxt"
        staffcompnametxt.Size = New Size(238, 40)
        staffcompnametxt.TabIndex = 91
        staffcompnametxt.Text = "Company Name"
        ' 
        ' staffcompostxt
        ' 
        staffcompostxt.BackColor = Color.Silver
        staffcompostxt.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        staffcompostxt.Location = New Point(545, 461)
        staffcompostxt.Margin = New Padding(3, 2, 3, 2)
        staffcompostxt.Name = "staffcompostxt"
        staffcompostxt.Size = New Size(304, 46)
        staffcompostxt.TabIndex = 94
        ' 
        ' staffcomposlbl
        ' 
        staffcomposlbl.AutoSize = True
        staffcomposlbl.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        staffcomposlbl.ForeColor = Color.Indigo
        staffcomposlbl.Location = New Point(545, 408)
        staffcomposlbl.Name = "staffcomposlbl"
        staffcomposlbl.Size = New Size(267, 40)
        staffcomposlbl.TabIndex = 93
        staffcomposlbl.Text = "Company Position"
        ' 
        ' staffregbtn
        ' 
        staffregbtn.BackColor = Color.Indigo
        staffregbtn.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        staffregbtn.ForeColor = Color.White
        staffregbtn.Location = New Point(767, 664)
        staffregbtn.Margin = New Padding(3, 2, 3, 2)
        staffregbtn.Name = "staffregbtn"
        staffregbtn.Size = New Size(180, 72)
        staffregbtn.TabIndex = 95
        staffregbtn.Text = "REGISTER"
        staffregbtn.UseVisualStyleBackColor = False
        ' 
        ' staffclearbtn
        ' 
        staffclearbtn.BackColor = Color.DarkSlateBlue
        staffclearbtn.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        staffclearbtn.ForeColor = Color.White
        staffclearbtn.Location = New Point(429, 664)
        staffclearbtn.Margin = New Padding(3, 2, 3, 2)
        staffclearbtn.Name = "staffclearbtn"
        staffclearbtn.Size = New Size(180, 72)
        staffclearbtn.TabIndex = 96
        staffclearbtn.Text = "CLEAR"
        staffclearbtn.UseVisualStyleBackColor = False
        ' 
        ' staffreturnbtn
        ' 
        staffreturnbtn.BackColor = Color.LightSlateGray
        staffreturnbtn.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        staffreturnbtn.ForeColor = Color.White
        staffreturnbtn.Location = New Point(107, 664)
        staffreturnbtn.Margin = New Padding(3, 2, 3, 2)
        staffreturnbtn.Name = "staffreturnbtn"
        staffreturnbtn.Size = New Size(180, 72)
        staffreturnbtn.TabIndex = 97
        staffreturnbtn.Text = "RETURN"
        staffreturnbtn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(staffcomptxt)
        Panel1.Controls.Add(staffaddcompbtn)
        Panel1.Controls.Add(staffidtxt)
        Panel1.Controls.Add(staffcomposlbl)
        Panel1.Controls.Add(staffcompostxt)
        Panel1.Controls.Add(staffregbtn)
        Panel1.Controls.Add(staffclearbtn)
        Panel1.Controls.Add(staffcompnametxt)
        Panel1.Controls.Add(staffreturnbtn)
        Panel1.Controls.Add(stafftitlelbl)
        Panel1.Controls.Add(stafflnamelbl)
        Panel1.Controls.Add(stafffnamelbl)
        Panel1.Controls.Add(staffmidnamelbl)
        Panel1.Controls.Add(stafflnametxt)
        Panel1.Controls.Add(staffsuffixlbl)
        Panel1.Controls.Add(staffcontlbl)
        Panel1.Controls.Add(stafffnametxt)
        Panel1.Controls.Add(staffsuffixtxt)
        Panel1.Controls.Add(staffcompnumtxt)
        Panel1.Controls.Add(staffmidnametxt)
        Panel1.Controls.Add(staffemaillbl)
        Panel1.Controls.Add(staffemailtxt)
        Panel1.Controls.Add(staffidlbl)
        Panel1.Controls.Add(staffgendercb)
        Panel1.Controls.Add(staffgenderlbl)
        Panel1.Location = New Point(488, 226)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1024, 767)
        Panel1.TabIndex = 98
        ' 
        ' staffcomptxt
        ' 
        staffcomptxt.BackColor = Color.Silver
        staffcomptxt.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        staffcomptxt.FormattingEnabled = True
        staffcomptxt.Location = New Point(545, 315)
        staffcomptxt.Name = "staffcomptxt"
        staffcomptxt.Size = New Size(304, 48)
        staffcomptxt.TabIndex = 100
        ' 
        ' staffaddcompbtn
        ' 
        staffaddcompbtn.BackColor = Color.Indigo
        staffaddcompbtn.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        staffaddcompbtn.ForeColor = Color.White
        staffaddcompbtn.Location = New Point(865, 314)
        staffaddcompbtn.Margin = New Padding(3, 2, 3, 2)
        staffaddcompbtn.Name = "staffaddcompbtn"
        staffaddcompbtn.Size = New Size(56, 53)
        staffaddcompbtn.TabIndex = 99
        staffaddcompbtn.Text = "+"
        staffaddcompbtn.TextAlign = ContentAlignment.TopCenter
        staffaddcompbtn.UseVisualStyleBackColor = False
        ' 
        ' staffidtxt
        ' 
        staffidtxt.BackColor = Color.Silver
        staffidtxt.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        staffidtxt.Location = New Point(753, 168)
        staffidtxt.Margin = New Padding(3, 2, 3, 2)
        staffidtxt.Name = "staffidtxt"
        staffidtxt.Size = New Size(122, 46)
        staffidtxt.TabIndex = 98
        ' 
        ' StaffRegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.regisformsBG_bw1
        ClientSize = New Size(1904, 1041)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "StaffRegistrationForm"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents staffidlbl As Label
    Friend WithEvents staffcompnumtxt As TextBox
    Friend WithEvents staffcontlbl As Label
    Friend WithEvents staffsuffixlbl As Label
    Friend WithEvents staffsuffixtxt As TextBox
    Friend WithEvents staffemailtxt As TextBox
    Friend WithEvents staffemaillbl As Label
    Friend WithEvents staffgendercb As ComboBox
    Friend WithEvents staffgenderlbl As Label
    Friend WithEvents staffmidnamelbl As Label
    Friend WithEvents stafffnamelbl As Label
    Friend WithEvents stafflnamelbl As Label
    Friend WithEvents stafftitlelbl As Label
    Friend WithEvents staffmidnametxt As TextBox
    Friend WithEvents stafffnametxt As TextBox
    Friend WithEvents stafflnametxt As TextBox
    Friend WithEvents staffcompnametxt As Label
    Friend WithEvents staffcompostxt As TextBox
    Friend WithEvents staffcomposlbl As Label
    Friend WithEvents staffregbtn As Button
    Friend WithEvents staffclearbtn As Button
    Friend WithEvents staffreturnbtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents staffidtxt As TextBox
    Friend WithEvents staffcomptxt As ComboBox
    Friend WithEvents staffaddcompbtn As Button
End Class
