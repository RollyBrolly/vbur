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
        CheckBox1 = New CheckBox()
        Label12 = New Label()
        Label11 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        MaskedTextBox1 = New MaskedTextBox()
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
        TextBox1 = New TextBox()
        Label8 = New Label()
        TextBox4 = New TextBox()
        Label9 = New Label()
        Button1 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.staffHeader
        PictureBox1.Location = New Point(-1, -3)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1280, 122)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 63
        PictureBox1.TabStop = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(483, 625)
        CheckBox1.Margin = New Padding(3, 2, 3, 2)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(138, 25)
        CheckBox1.TabIndex = 87
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label12.Location = New Point(482, 543)
        Label12.Name = "Label12"
        Label12.Size = New Size(139, 37)
        Label12.TabIndex = 86
        Label12.Text = "Password"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label11.Location = New Point(482, 435)
        Label11.Name = "Label11"
        Label11.Size = New Size(146, 37)
        Label11.TabIndex = 85
        Label11.Text = "Username"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Silver
        TextBox2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        TextBox2.Location = New Point(483, 582)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(231, 35)
        TextBox2.TabIndex = 84
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.Silver
        TextBox3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        TextBox3.Location = New Point(482, 475)
        TextBox3.Margin = New Padding(3, 2, 3, 2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(231, 35)
        TextBox3.TabIndex = 83
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.BackColor = Color.Silver
        MaskedTextBox1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MaskedTextBox1.Location = New Point(726, 342)
        MaskedTextBox1.Margin = New Padding(3, 2, 3, 2)
        MaskedTextBox1.Mask = "0 0  -  0 0 0 0 0"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(138, 35)
        MaskedTextBox1.TabIndex = 82
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label10.Location = New Point(726, 295)
        Label10.Name = "Label10"
        Label10.Size = New Size(191, 37)
        Label10.TabIndex = 81
        Label10.Text = "Supervisor ID"
        ' 
        ' numberTextbox
        ' 
        numberTextbox.BackColor = Color.Silver
        numberTextbox.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        numberTextbox.Location = New Point(463, 341)
        numberTextbox.Margin = New Padding(3, 2, 3, 2)
        numberTextbox.Name = "numberTextbox"
        numberTextbox.Size = New Size(231, 35)
        numberTextbox.TabIndex = 78
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label7.Location = New Point(463, 295)
        Label7.Name = "Label7"
        Label7.Size = New Size(229, 37)
        Label7.TabIndex = 77
        Label7.Text = "Contact Number"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F)
        Label6.ForeColor = SystemColors.ControlDarkDark
        Label6.Location = New Point(854, 237)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 25)
        Label6.TabIndex = 76
        Label6.Text = "Suffix"
        ' 
        ' suffixTxtBox
        ' 
        suffixTxtBox.BackColor = Color.Silver
        suffixTxtBox.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        suffixTxtBox.Location = New Point(847, 200)
        suffixTxtBox.Margin = New Padding(3, 2, 3, 2)
        suffixTxtBox.Name = "suffixTxtBox"
        suffixTxtBox.Size = New Size(73, 35)
        suffixTxtBox.TabIndex = 75
        ' 
        ' emailBox
        ' 
        emailBox.BackColor = Color.Silver
        emailBox.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        emailBox.Location = New Point(206, 341)
        emailBox.Margin = New Padding(3, 2, 3, 2)
        emailBox.Name = "emailBox"
        emailBox.Size = New Size(231, 35)
        emailBox.TabIndex = 74
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label5.Location = New Point(206, 295)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 37)
        Label5.TabIndex = 73
        Label5.Text = "Email"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.Silver
        ComboBox1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"MALE", "FEMALE"})
        ComboBox1.Location = New Point(33, 340)
        ComboBox1.Margin = New Padding(3, 2, 3, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(142, 38)
        ComboBox1.TabIndex = 72
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label4.Location = New Point(33, 295)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 37)
        Label4.TabIndex = 71
        Label4.Text = "Gender"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F)
        Label3.ForeColor = SystemColors.ControlDarkDark
        Label3.Location = New Point(630, 237)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 25)
        Label3.TabIndex = 70
        Label3.Text = "Middle Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F)
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(381, 237)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 25)
        Label2.TabIndex = 69
        Label2.Text = "First Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F)
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(91, 237)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 25)
        Label1.TabIndex = 68
        Label1.Text = "Last Name"
        ' 
        ' nameLabel
        ' 
        nameLabel.AutoSize = True
        nameLabel.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        nameLabel.Location = New Point(36, 161)
        nameLabel.Name = "nameLabel"
        nameLabel.Size = New Size(146, 37)
        nameLabel.TabIndex = 67
        nameLabel.Text = "Full Name"
        ' 
        ' midNameBox
        ' 
        midNameBox.BackColor = Color.Silver
        midNameBox.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        midNameBox.Location = New Point(577, 200)
        midNameBox.Margin = New Padding(3, 2, 3, 2)
        midNameBox.Name = "midNameBox"
        midNameBox.Size = New Size(231, 35)
        midNameBox.TabIndex = 66
        ' 
        ' firstNameBox
        ' 
        firstNameBox.BackColor = Color.Silver
        firstNameBox.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        firstNameBox.Location = New Point(315, 200)
        firstNameBox.Margin = New Padding(3, 2, 3, 2)
        firstNameBox.Name = "firstNameBox"
        firstNameBox.Size = New Size(231, 35)
        firstNameBox.TabIndex = 65
        ' 
        ' lastnameBox
        ' 
        lastnameBox.BackColor = Color.Silver
        lastnameBox.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        lastnameBox.Location = New Point(36, 200)
        lastnameBox.Margin = New Padding(3, 2, 3, 2)
        lastnameBox.Name = "lastnameBox"
        lastnameBox.Size = New Size(231, 35)
        lastnameBox.TabIndex = 64
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Silver
        TextBox1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        TextBox1.Location = New Point(32, 484)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(304, 35)
        TextBox1.TabIndex = 92
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label8.Location = New Point(32, 435)
        Label8.Name = "Label8"
        Label8.Size = New Size(222, 37)
        Label8.TabIndex = 91
        Label8.Text = "Company Name"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.Silver
        TextBox4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        TextBox4.Location = New Point(33, 582)
        TextBox4.Margin = New Padding(3, 2, 3, 2)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(304, 35)
        TextBox4.TabIndex = 94
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label9.Location = New Point(33, 542)
        Label9.Name = "Label9"
        Label9.Size = New Size(251, 37)
        Label9.TabIndex = 93
        Label9.Text = "Company Position"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Indigo
        Button1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(1090, 597)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(137, 58)
        Button1.TabIndex = 95
        Button1.Text = "REGISTER"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DarkSlateBlue
        Button3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(932, 597)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(137, 58)
        Button3.TabIndex = 96
        Button3.Text = "CLEAR"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightSlateGray
        Button2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(771, 597)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(137, 58)
        Button2.TabIndex = 97
        Button2.Text = "RETURN"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' StaffRegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 681)
        Controls.Add(Button2)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(Label9)
        Controls.Add(TextBox1)
        Controls.Add(Label8)
        Controls.Add(CheckBox1)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(TextBox2)
        Controls.Add(TextBox3)
        Controls.Add(MaskedTextBox1)
        Controls.Add(Label10)
        Controls.Add(numberTextbox)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(suffixTxtBox)
        Controls.Add(emailBox)
        Controls.Add(Label5)
        Controls.Add(ComboBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(nameLabel)
        Controls.Add(midNameBox)
        Controls.Add(firstNameBox)
        Controls.Add(lastnameBox)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "StaffRegistrationForm"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
