<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Panel2 = New Panel()
        showpasschkb = New CheckBox()
        signupbtn = New Button()
        donthaveacclbl = New Label()
        passlbl = New Label()
        userlbl = New Label()
        usertxt = New TextBox()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        welcomelbl = New Label()
        signinbtn = New Button()
        passtxt = New TextBox()
        systemexitbtn = New PictureBox()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(systemexitbtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonHighlight
        Panel2.Controls.Add(showpasschkb)
        Panel2.Controls.Add(signupbtn)
        Panel2.Controls.Add(donthaveacclbl)
        Panel2.Controls.Add(passlbl)
        Panel2.Controls.Add(userlbl)
        Panel2.Controls.Add(usertxt)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(signinbtn)
        Panel2.Controls.Add(passtxt)
        Panel2.Location = New Point(699, 202)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(523, 677)
        Panel2.TabIndex = 12
        ' 
        ' showpasschkb
        ' 
        showpasschkb.AutoSize = True
        showpasschkb.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        showpasschkb.Location = New Point(76, 459)
        showpasschkb.Margin = New Padding(3, 2, 3, 2)
        showpasschkb.Name = "showpasschkb"
        showpasschkb.Size = New Size(147, 25)
        showpasschkb.TabIndex = 21
        showpasschkb.Text = "Show Password"
        showpasschkb.UseVisualStyleBackColor = True
        ' 
        ' signupbtn
        ' 
        signupbtn.BackColor = Color.Indigo
        signupbtn.FlatStyle = FlatStyle.Popup
        signupbtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        signupbtn.ForeColor = SystemColors.ControlLightLight
        signupbtn.Location = New Point(198, 604)
        signupbtn.Margin = New Padding(3, 2, 3, 2)
        signupbtn.Name = "signupbtn"
        signupbtn.Size = New Size(119, 46)
        signupbtn.TabIndex = 20
        signupbtn.Text = "Sign Up"
        signupbtn.UseVisualStyleBackColor = False
        ' 
        ' donthaveacclbl
        ' 
        donthaveacclbl.AutoSize = True
        donthaveacclbl.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        donthaveacclbl.Location = New Point(159, 568)
        donthaveacclbl.Name = "donthaveacclbl"
        donthaveacclbl.Size = New Size(218, 25)
        donthaveacclbl.TabIndex = 19
        donthaveacclbl.Text = "Don't have an account?"
        ' 
        ' passlbl
        ' 
        passlbl.AutoSize = True
        passlbl.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        passlbl.Location = New Point(70, 360)
        passlbl.Name = "passlbl"
        passlbl.Size = New Size(130, 30)
        passlbl.TabIndex = 18
        passlbl.Text = "PASSWORD"
        ' 
        ' userlbl
        ' 
        userlbl.AutoSize = True
        userlbl.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        userlbl.Location = New Point(70, 265)
        userlbl.Name = "userlbl"
        userlbl.Size = New Size(128, 30)
        userlbl.TabIndex = 17
        userlbl.Text = "USERNAME"
        ' 
        ' usertxt
        ' 
        usertxt.BackColor = Color.Silver
        usertxt.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        usertxt.Location = New Point(76, 309)
        usertxt.Margin = New Padding(3, 2, 3, 2)
        usertxt.Name = "usertxt"
        usertxt.Size = New Size(378, 39)
        usertxt.TabIndex = 12
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(198, 116)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(130, 132)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Indigo
        Panel1.Controls.Add(welcomelbl)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(523, 96)
        Panel1.TabIndex = 15
        ' 
        ' welcomelbl
        ' 
        welcomelbl.AutoSize = True
        welcomelbl.Font = New Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        welcomelbl.Location = New Point(126, 17)
        welcomelbl.Name = "welcomelbl"
        welcomelbl.Size = New Size(271, 65)
        welcomelbl.TabIndex = 0
        welcomelbl.Text = "WELCOME"
        ' 
        ' signinbtn
        ' 
        signinbtn.BackColor = Color.Indigo
        signinbtn.FlatStyle = FlatStyle.Popup
        signinbtn.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        signinbtn.ForeColor = SystemColors.ControlLightLight
        signinbtn.Location = New Point(76, 495)
        signinbtn.Margin = New Padding(3, 2, 3, 2)
        signinbtn.Name = "signinbtn"
        signinbtn.Size = New Size(378, 57)
        signinbtn.TabIndex = 14
        signinbtn.Text = "SIGN IN"
        signinbtn.UseVisualStyleBackColor = False
        ' 
        ' passtxt
        ' 
        passtxt.BackColor = Color.Silver
        passtxt.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        passtxt.Location = New Point(76, 400)
        passtxt.Margin = New Padding(3, 2, 3, 2)
        passtxt.Name = "passtxt"
        passtxt.Size = New Size(378, 39)
        passtxt.TabIndex = 13
        ' 
        ' systemexitbtn
        ' 
        systemexitbtn.BackColor = Color.Transparent
        systemexitbtn.Image = My.Resources.Resources.icons8_power_off_64
        systemexitbtn.Location = New Point(1827, 1)
        systemexitbtn.Name = "systemexitbtn"
        systemexitbtn.Size = New Size(75, 75)
        systemexitbtn.SizeMode = PictureBoxSizeMode.StretchImage
        systemexitbtn.TabIndex = 23
        systemexitbtn.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.DarkSlateBlue
        BackgroundImage = My.Resources.Resources.regisformsBG_bw
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1904, 1041)
        Controls.Add(systemexitbtn)
        Controls.Add(Panel2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        Name = "Login"
        Text = "no"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(systemexitbtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents showpasschkb As CheckBox
    Friend WithEvents signupbtn As Button
    Friend WithEvents donthaveacclbl As Label
    Friend WithEvents passlbl As Label
    Friend WithEvents userlbl As Label
    Friend WithEvents usertxt As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents welcomelbl As Label
    Friend WithEvents signinbtn As Button
    Friend WithEvents passtxt As TextBox
    Friend WithEvents systemexitbtn As PictureBox

End Class
