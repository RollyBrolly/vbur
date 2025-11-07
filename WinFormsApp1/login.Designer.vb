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
        CheckBox1 = New CheckBox()
        Button2 = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        userBox = New TextBox()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label1 = New Label()
        Button1 = New Button()
        passwordBox = New TextBox()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonHighlight
        Panel2.Controls.Add(CheckBox1)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(userBox)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(passwordBox)
        Panel2.Location = New Point(642, 89)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(523, 677)
        Panel2.TabIndex = 12
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(76, 459)
        CheckBox1.Margin = New Padding(3, 2, 3, 2)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(147, 25)
        CheckBox1.TabIndex = 21
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Indigo
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(209, 595)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(119, 46)
        Button2.TabIndex = 20
        Button2.Text = "Sign Up"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(159, 568)
        Label4.Name = "Label4"
        Label4.Size = New Size(218, 25)
        Label4.TabIndex = 19
        Label4.Text = "Don't have an account?"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(70, 360)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 30)
        Label3.TabIndex = 18
        Label3.Text = "PASSWORD"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(70, 265)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 30)
        Label2.TabIndex = 17
        Label2.Text = "USERNAME"
        ' 
        ' userBox
        ' 
        userBox.BackColor = Color.Silver
        userBox.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        userBox.Location = New Point(76, 309)
        userBox.Margin = New Padding(3, 2, 3, 2)
        userBox.Name = "userBox"
        userBox.Size = New Size(378, 39)
        userBox.TabIndex = 12
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
        Panel1.Controls.Add(Label1)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(523, 96)
        Panel1.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(124, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(271, 65)
        Label1.TabIndex = 0
        Label1.Text = "WELCOME"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Indigo
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(76, 495)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(378, 57)
        Button1.TabIndex = 14
        Button1.Text = "SIGN IN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' passwordBox
        ' 
        passwordBox.BackColor = Color.Silver
        passwordBox.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        passwordBox.Location = New Point(76, 400)
        passwordBox.Margin = New Padding(3, 2, 3, 2)
        passwordBox.Name = "passwordBox"
        passwordBox.Size = New Size(378, 39)
        passwordBox.TabIndex = 13
        ' 
        ' Login
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.DarkSlateBlue
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1904, 1041)
        Controls.Add(Panel2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        Name = "Login"
        Text = "Login"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents userBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents passwordBox As TextBox

End Class
