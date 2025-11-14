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
        Label10 = New Label()
        numberTextbox = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        suffixTxtBox = New TextBox()
        emailBox = New TextBox()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        nameLabel = New Label()
        midNameBox = New TextBox()
        firstNameBox = New TextBox()
        lastnameBox = New TextBox()
        Label8 = New Label()
        TextBox4 = New TextBox()
        Label9 = New Label()
        Button1 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Panel1 = New Panel()
        ComboBox2 = New ComboBox()
        Button4 = New Button()
        TextBox2 = New TextBox()
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
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        Label10.ForeColor = Color.Indigo
        Label10.Location = New Point(735, 121)
        Label10.Name = "Label10"
        Label10.Size = New Size(203, 40)
        Label10.TabIndex = 81
        Label10.Text = "Supervisor ID"
        ' 
        ' numberTextbox
        ' 
        numberTextbox.BackColor = Color.Silver
        numberTextbox.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        numberTextbox.Location = New Point(724, 585)
        numberTextbox.Margin = New Padding(3, 2, 3, 2)
        numberTextbox.Name = "numberTextbox"
        numberTextbox.Size = New Size(231, 46)
        numberTextbox.TabIndex = 78
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        Label7.ForeColor = Color.Indigo
        Label7.Location = New Point(718, 536)
        Label7.Name = "Label7"
        Label7.Size = New Size(245, 40)
        Label7.TabIndex = 77
        Label7.Text = "Contact Number"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        Label6.ForeColor = Color.Indigo
        Label6.Location = New Point(107, 536)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 40)
        Label6.TabIndex = 76
        Label6.Text = "Suffix"
        ' 
        ' suffixTxtBox
        ' 
        suffixTxtBox.BackColor = Color.Silver
        suffixTxtBox.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        suffixTxtBox.Location = New Point(107, 585)
        suffixTxtBox.Margin = New Padding(3, 2, 3, 2)
        suffixTxtBox.Name = "suffixTxtBox"
        suffixTxtBox.Size = New Size(51, 46)
        suffixTxtBox.TabIndex = 75
        ' 
        ' emailBox
        ' 
        emailBox.BackColor = Color.Silver
        emailBox.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        emailBox.Location = New Point(325, 585)
        emailBox.Margin = New Padding(3, 2, 3, 2)
        emailBox.Name = "emailBox"
        emailBox.Size = New Size(345, 33)
        emailBox.TabIndex = 74
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        Label5.ForeColor = Color.Indigo
        Label5.Location = New Point(325, 535)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 40)
        Label5.TabIndex = 73
        Label5.Text = "Email"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.Silver
        ComboBox1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Male", "Female"})
        ComboBox1.Location = New Point(540, 166)
        ComboBox1.Margin = New Padding(3, 2, 3, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(142, 48)
        ComboBox1.TabIndex = 72
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        Label4.ForeColor = Color.Indigo
        Label4.Location = New Point(540, 121)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 40)
        Label4.TabIndex = 71
        Label4.Text = "Gender"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        Label3.ForeColor = Color.Indigo
        Label3.Location = New Point(107, 408)
        Label3.Name = "Label3"
        Label3.Size = New Size(203, 40)
        Label3.TabIndex = 70
        Label3.Text = "Middle Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        Label2.ForeColor = Color.Indigo
        Label2.Location = New Point(107, 265)
        Label2.Name = "Label2"
        Label2.Size = New Size(166, 40)
        Label2.TabIndex = 69
        Label2.Text = "First Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        Label1.ForeColor = Color.Indigo
        Label1.Location = New Point(107, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 40)
        Label1.TabIndex = 68
        Label1.Text = "Last Name"
        ' 
        ' nameLabel
        ' 
        nameLabel.AutoSize = True
        nameLabel.Font = New Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nameLabel.Location = New Point(64, 48)
        nameLabel.Name = "nameLabel"
        nameLabel.Size = New Size(204, 50)
        nameLabel.TabIndex = 67
        nameLabel.Text = "Full Name"
        ' 
        ' midNameBox
        ' 
        midNameBox.BackColor = Color.Silver
        midNameBox.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        midNameBox.Location = New Point(107, 460)
        midNameBox.Margin = New Padding(3, 2, 3, 2)
        midNameBox.Name = "midNameBox"
        midNameBox.Size = New Size(231, 46)
        midNameBox.TabIndex = 66
        ' 
        ' firstNameBox
        ' 
        firstNameBox.BackColor = Color.Silver
        firstNameBox.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        firstNameBox.Location = New Point(107, 316)
        firstNameBox.Margin = New Padding(3, 2, 3, 2)
        firstNameBox.Name = "firstNameBox"
        firstNameBox.Size = New Size(231, 46)
        firstNameBox.TabIndex = 65
        ' 
        ' lastnameBox
        ' 
        lastnameBox.BackColor = Color.Silver
        lastnameBox.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        lastnameBox.Location = New Point(107, 173)
        lastnameBox.Margin = New Padding(3, 2, 3, 2)
        lastnameBox.Name = "lastnameBox"
        lastnameBox.Size = New Size(231, 46)
        lastnameBox.TabIndex = 64
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        Label8.ForeColor = Color.Indigo
        Label8.Location = New Point(540, 265)
        Label8.Name = "Label8"
        Label8.Size = New Size(238, 40)
        Label8.TabIndex = 91
        Label8.Text = "Company Name"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.Silver
        TextBox4.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        TextBox4.Location = New Point(545, 461)
        TextBox4.Margin = New Padding(3, 2, 3, 2)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(304, 46)
        TextBox4.TabIndex = 94
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        Label9.ForeColor = Color.Indigo
        Label9.Location = New Point(545, 408)
        Label9.Name = "Label9"
        Label9.Size = New Size(267, 40)
        Label9.TabIndex = 93
        Label9.Text = "Company Position"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Indigo
        Button1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(767, 664)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(180, 72)
        Button1.TabIndex = 95
        Button1.Text = "REGISTER"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DarkSlateBlue
        Button3.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(429, 664)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(180, 72)
        Button3.TabIndex = 96
        Button3.Text = "CLEAR"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightSlateGray
        Button2.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(107, 664)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(180, 72)
        Button2.TabIndex = 97
        Button2.Text = "RETURN"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(ComboBox2)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(nameLabel)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(lastnameBox)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(firstNameBox)
        Panel1.Controls.Add(suffixTxtBox)
        Panel1.Controls.Add(numberTextbox)
        Panel1.Controls.Add(midNameBox)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(emailBox)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(488, 226)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1024, 767)
        Panel1.TabIndex = 98
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.Silver
        ComboBox2.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(545, 315)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(304, 48)
        ComboBox2.TabIndex = 100
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Indigo
        Button4.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(865, 314)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(56, 53)
        Button4.TabIndex = 99
        Button4.Text = "+"
        Button4.TextAlign = ContentAlignment.TopCenter
        Button4.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Silver
        TextBox2.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        TextBox2.Location = New Point(753, 168)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(122, 46)
        TextBox2.TabIndex = 98
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
    Friend WithEvents Label10 As Label
    Friend WithEvents numberTextbox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents suffixTxtBox As TextBox
    Friend WithEvents emailBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents midNameBox As TextBox
    Friend WithEvents firstNameBox As TextBox
    Friend WithEvents lastnameBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button4 As Button
End Class
