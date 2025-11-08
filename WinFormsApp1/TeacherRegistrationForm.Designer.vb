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
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label10 = New Label()
        Label9 = New Label()
        departmentBox = New ComboBox()
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
        ' Button3
        ' 
        Button3.BackColor = Color.DarkSlateBlue
        Button3.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(429, 664)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(180, 72)
        Button3.TabIndex = 65
        Button3.Text = "CLEAR"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SlateGray
        Button2.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(107, 664)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(180, 72)
        Button2.TabIndex = 64
        Button2.Text = "RETURN"
        Button2.UseVisualStyleBackColor = False
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
        Button1.TabIndex = 63
        Button1.Text = "REGISTER"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label10.ForeColor = Color.Indigo
        Label10.Location = New Point(735, 121)
        Label10.Name = "Label10"
        Label10.Size = New Size(220, 37)
        Label10.TabIndex = 83
        Label10.Text = "Faculty Number"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label9.ForeColor = Color.Indigo
        Label9.Location = New Point(540, 321)
        Label9.Name = "Label9"
        Label9.Size = New Size(174, 37)
        Label9.TabIndex = 82
        Label9.Text = "Department"
        ' 
        ' departmentBox
        ' 
        departmentBox.BackColor = Color.Silver
        departmentBox.Enabled = False
        departmentBox.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        departmentBox.FormattingEnabled = True
        departmentBox.Items.AddRange(New Object() {"COLLEGE OF COMPUTER STUDIES", "COLLEGE OF EDUCATION", "COLLEGE OF ENGINEERING", "COLLEGE OF NURSING", "COLLEGE OF ARTS AND SCIENCE", "COLLEGE OF BUSINESS AND ACCOUNTANCY", "COLLEGE OF HOSPITALITY MANAGEMENT"})
        departmentBox.Location = New Point(540, 374)
        departmentBox.Margin = New Padding(3, 2, 3, 2)
        departmentBox.Name = "departmentBox"
        departmentBox.Size = New Size(327, 48)
        departmentBox.TabIndex = 81
        ' 
        ' numberTextbox
        ' 
        numberTextbox.BackColor = Color.Silver
        numberTextbox.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        numberTextbox.Location = New Point(724, 585)
        numberTextbox.Margin = New Padding(3, 2, 3, 2)
        numberTextbox.Name = "numberTextbox"
        numberTextbox.Size = New Size(231, 46)
        numberTextbox.TabIndex = 80
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label7.ForeColor = Color.Indigo
        Label7.Location = New Point(718, 536)
        Label7.Name = "Label7"
        Label7.Size = New Size(229, 37)
        Label7.TabIndex = 79
        Label7.Text = "Contact Number"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label6.ForeColor = Color.Indigo
        Label6.Location = New Point(107, 536)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 37)
        Label6.TabIndex = 78
        Label6.Text = "Suffix"
        ' 
        ' suffixTxtBox
        ' 
        suffixTxtBox.BackColor = Color.Silver
        suffixTxtBox.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        suffixTxtBox.Location = New Point(107, 585)
        suffixTxtBox.Margin = New Padding(3, 2, 3, 2)
        suffixTxtBox.Name = "suffixTxtBox"
        suffixTxtBox.Size = New Size(102, 46)
        suffixTxtBox.TabIndex = 77
        ' 
        ' emailBox
        ' 
        emailBox.BackColor = Color.Silver
        emailBox.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        emailBox.Location = New Point(404, 586)
        emailBox.Margin = New Padding(3, 2, 3, 2)
        emailBox.Name = "emailBox"
        emailBox.Size = New Size(231, 46)
        emailBox.TabIndex = 76
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label5.ForeColor = Color.Indigo
        Label5.Location = New Point(404, 536)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 37)
        Label5.TabIndex = 75
        Label5.Text = "Email"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.Silver
        ComboBox1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"MALE", "FEMALE"})
        ComboBox1.Location = New Point(540, 166)
        ComboBox1.Margin = New Padding(3, 2, 3, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(142, 48)
        ComboBox1.TabIndex = 74
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label4.ForeColor = Color.Indigo
        Label4.Location = New Point(540, 121)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 37)
        Label4.TabIndex = 73
        Label4.Text = "Gender"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label3.ForeColor = Color.Indigo
        Label3.Location = New Point(107, 408)
        Label3.Name = "Label3"
        Label3.Size = New Size(191, 37)
        Label3.TabIndex = 72
        Label3.Text = "Middle Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label2.ForeColor = Color.Indigo
        Label2.Location = New Point(107, 265)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 37)
        Label2.TabIndex = 71
        Label2.Text = "First Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label1.ForeColor = Color.Indigo
        Label1.Location = New Point(107, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 37)
        Label1.TabIndex = 70
        Label1.Text = "Last Name"
        ' 
        ' nameLabel
        ' 
        nameLabel.AutoSize = True
        nameLabel.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nameLabel.Location = New Point(64, 48)
        nameLabel.Name = "nameLabel"
        nameLabel.Size = New Size(194, 47)
        nameLabel.TabIndex = 69
        nameLabel.Text = "Full Name"
        ' 
        ' midNameBox
        ' 
        midNameBox.BackColor = Color.Silver
        midNameBox.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        midNameBox.Location = New Point(107, 460)
        midNameBox.Margin = New Padding(3, 2, 3, 2)
        midNameBox.Name = "midNameBox"
        midNameBox.Size = New Size(307, 46)
        midNameBox.TabIndex = 68
        ' 
        ' firstNameBox
        ' 
        firstNameBox.BackColor = Color.Silver
        firstNameBox.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        firstNameBox.Location = New Point(107, 316)
        firstNameBox.Margin = New Padding(3, 2, 3, 2)
        firstNameBox.Name = "firstNameBox"
        firstNameBox.Size = New Size(307, 46)
        firstNameBox.TabIndex = 67
        ' 
        ' lastnameBox
        ' 
        lastnameBox.BackColor = Color.Silver
        lastnameBox.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        lastnameBox.Location = New Point(107, 173)
        lastnameBox.Margin = New Padding(3, 2, 3, 2)
        lastnameBox.Name = "lastnameBox"
        lastnameBox.Size = New Size(307, 46)
        lastnameBox.TabIndex = 66
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Silver
        TextBox1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(764, 168)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(122, 46)
        TextBox1.TabIndex = 90
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(departmentBox)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(nameLabel)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(lastnameBox)
        Panel1.Controls.Add(suffixTxtBox)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(firstNameBox)
        Panel1.Controls.Add(emailBox)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(midNameBox)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(numberTextbox)
        Panel1.Controls.Add(Label5)
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
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents departmentBox As ComboBox
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
    Friend WithEvents Panel1 As Panel

End Class
