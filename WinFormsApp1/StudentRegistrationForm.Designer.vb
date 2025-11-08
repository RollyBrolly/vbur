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
        lastnameBox = New TextBox()
        firstNameBox = New TextBox()
        midNameBox = New TextBox()
        nameLabel = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        ComboBox1 = New ComboBox()
        Label5 = New Label()
        emailBox = New TextBox()
        suffixTxtBox = New TextBox()
        Label6 = New Label()
        numberTextbox = New TextBox()
        Label7 = New Label()
        courseBox = New ComboBox()
        departmentBox = New ComboBox()
        Label9 = New Label()
        Label10 = New Label()
        MaskedTextBox1 = New MaskedTextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        Label13 = New Label()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lastnameBox
        ' 
        lastnameBox.BackColor = Color.Silver
        lastnameBox.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lastnameBox.Location = New Point(107, 173)
        lastnameBox.Margin = New Padding(3, 2, 3, 2)
        lastnameBox.Name = "lastnameBox"
        lastnameBox.Size = New Size(307, 46)
        lastnameBox.TabIndex = 1
        ' 
        ' firstNameBox
        ' 
        firstNameBox.BackColor = Color.Silver
        firstNameBox.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        firstNameBox.Location = New Point(107, 316)
        firstNameBox.Margin = New Padding(3, 2, 3, 2)
        firstNameBox.Name = "firstNameBox"
        firstNameBox.Size = New Size(307, 46)
        firstNameBox.TabIndex = 2
        ' 
        ' midNameBox
        ' 
        midNameBox.BackColor = Color.Silver
        midNameBox.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        midNameBox.Location = New Point(107, 460)
        midNameBox.Margin = New Padding(3, 2, 3, 2)
        midNameBox.Name = "midNameBox"
        midNameBox.Size = New Size(307, 46)
        midNameBox.TabIndex = 3
        ' 
        ' nameLabel
        ' 
        nameLabel.AutoSize = True
        nameLabel.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nameLabel.Location = New Point(64, 48)
        nameLabel.Name = "nameLabel"
        nameLabel.Size = New Size(194, 47)
        nameLabel.TabIndex = 4
        nameLabel.Text = "Full Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Indigo
        Label1.Location = New Point(107, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 37)
        Label1.TabIndex = 5
        Label1.Text = "Last Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label2.ForeColor = Color.Indigo
        Label2.Location = New Point(107, 265)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 37)
        Label2.TabIndex = 6
        Label2.Text = "First Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label3.ForeColor = Color.Indigo
        Label3.Location = New Point(107, 408)
        Label3.Name = "Label3"
        Label3.Size = New Size(191, 37)
        Label3.TabIndex = 7
        Label3.Text = "Middle Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label4.ForeColor = Color.Indigo
        Label4.Location = New Point(540, 121)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 37)
        Label4.TabIndex = 9
        Label4.Text = "Gender"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.Silver
        ComboBox1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"MALE", "FEMALE"})
        ComboBox1.Location = New Point(540, 166)
        ComboBox1.Margin = New Padding(3, 2, 3, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(142, 45)
        ComboBox1.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label5.ForeColor = Color.Indigo
        Label5.Location = New Point(404, 536)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 37)
        Label5.TabIndex = 11
        Label5.Text = "Email"
        ' 
        ' emailBox
        ' 
        emailBox.BackColor = Color.Silver
        emailBox.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        emailBox.Location = New Point(404, 586)
        emailBox.Margin = New Padding(3, 2, 3, 2)
        emailBox.Name = "emailBox"
        emailBox.Size = New Size(232, 43)
        emailBox.TabIndex = 12
        ' 
        ' suffixTxtBox
        ' 
        suffixTxtBox.BackColor = Color.Silver
        suffixTxtBox.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        suffixTxtBox.Location = New Point(107, 585)
        suffixTxtBox.Margin = New Padding(3, 2, 3, 2)
        suffixTxtBox.Name = "suffixTxtBox"
        suffixTxtBox.Size = New Size(102, 43)
        suffixTxtBox.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label6.ForeColor = Color.Indigo
        Label6.Location = New Point(107, 536)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 37)
        Label6.TabIndex = 14
        Label6.Text = "Suffix"
        ' 
        ' numberTextbox
        ' 
        numberTextbox.BackColor = Color.Silver
        numberTextbox.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        numberTextbox.Location = New Point(718, 586)
        numberTextbox.Margin = New Padding(3, 2, 3, 2)
        numberTextbox.Name = "numberTextbox"
        numberTextbox.Size = New Size(231, 43)
        numberTextbox.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label7.ForeColor = Color.Indigo
        Label7.Location = New Point(718, 536)
        Label7.Name = "Label7"
        Label7.Size = New Size(229, 37)
        Label7.TabIndex = 15
        Label7.Text = "Contact Number"
        ' 
        ' courseBox
        ' 
        courseBox.BackColor = Color.Silver
        courseBox.Font = New Font("Segoe UI", 20.25F)
        courseBox.FormattingEnabled = True
        courseBox.Items.AddRange(New Object() {"Bachelor of Science in Information Technology", "Bachelor of Science in Computer Science"})
        courseBox.Location = New Point(545, 461)
        courseBox.Margin = New Padding(3, 2, 3, 2)
        courseBox.Name = "courseBox"
        courseBox.Size = New Size(389, 45)
        courseBox.TabIndex = 17
        ' 
        ' departmentBox
        ' 
        departmentBox.BackColor = Color.Silver
        departmentBox.Enabled = False
        departmentBox.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        departmentBox.FormattingEnabled = True
        departmentBox.Items.AddRange(New Object() {"COLLEGE OF COMPUTER STUDIES", "COLLEGE OF EDUCATION", "COLLEGE OF ENGINEERING", "COLLEGE OF NURSING", "COLLEGE OF ARTS AND SCIENCE", "COLLEGE OF BUSINESS AND ACCOUNTANCY", "COLLEGE OF HOSPITALITY MANAGEMENT"})
        departmentBox.Location = New Point(545, 314)
        departmentBox.Margin = New Padding(3, 2, 3, 2)
        departmentBox.Name = "departmentBox"
        departmentBox.Size = New Size(327, 48)
        departmentBox.TabIndex = 19
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Indigo
        Label9.Location = New Point(540, 265)
        Label9.Name = "Label9"
        Label9.Size = New Size(174, 37)
        Label9.TabIndex = 20
        Label9.Text = "Department"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label10.ForeColor = Color.Indigo
        Label10.Location = New Point(735, 121)
        Label10.Name = "Label10"
        Label10.Size = New Size(229, 37)
        Label10.TabIndex = 21
        Label10.Text = "Student Number"
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.BackColor = Color.Silver
        MaskedTextBox1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MaskedTextBox1.Location = New Point(764, 168)
        MaskedTextBox1.Margin = New Padding(3, 2, 3, 2)
        MaskedTextBox1.Mask = "0 0  -  0 0 0 0 0"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(170, 46)
        MaskedTextBox1.TabIndex = 22
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.Silver
        TextBox3.Font = New Font("Microsoft Sans Serif", 18F)
        TextBox3.Location = New Point(0, 0)
        TextBox3.Margin = New Padding(3, 2, 3, 2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(231, 35)
        TextBox3.TabIndex = 23
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
        Button1.TabIndex = 28
        Button1.Text = "REGISTER"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SlateGray
        Button2.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(107, 664)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(180, 72)
        Button2.TabIndex = 29
        Button2.Text = "RETURN"
        Button2.UseVisualStyleBackColor = False
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
        Button3.TabIndex = 30
        Button3.Text = "CLEAR"
        Button3.UseVisualStyleBackColor = False
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
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label13.ForeColor = Color.Indigo
        Label13.Location = New Point(545, 408)
        Label13.Name = "Label13"
        Label13.Size = New Size(105, 37)
        Label13.TabIndex = 32
        Label13.Text = "Course"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(nameLabel)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(courseBox)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(departmentBox)
        Panel1.Controls.Add(MaskedTextBox1)
        Panel1.Controls.Add(lastnameBox)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(emailBox)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(numberTextbox)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(suffixTxtBox)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(firstNameBox)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(midNameBox)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(488, 226)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1024, 767)
        Panel1.TabIndex = 33
        ' 
        ' StudentRegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.regisformsBG_bw1
        ClientSize = New Size(1904, 1041)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox3)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "StudentRegistrationForm"
        Text = "Student Registration Form"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lastnameBox As TextBox
    Friend WithEvents firstNameBox As TextBox
    Friend WithEvents midNameBox As TextBox
    Friend WithEvents nameLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents emailBox As TextBox
    Friend WithEvents suffixTxtBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents numberTextbox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents courseBox As ComboBox
    Friend WithEvents departmentBox As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel1 As Panel

End Class
