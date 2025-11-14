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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        Label13 = New Label()
        Panel1 = New Panel()
        Label8 = New Label()
        sectionBox = New ComboBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lastnameBox
        ' 
        lastnameBox.BackColor = Color.Silver
        lastnameBox.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lastnameBox.Location = New Point(122, 231)
        lastnameBox.Name = "lastnameBox"
        lastnameBox.Size = New Size(350, 56)
        lastnameBox.TabIndex = 1
        ' 
        ' firstNameBox
        ' 
        firstNameBox.BackColor = Color.Silver
        firstNameBox.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        firstNameBox.Location = New Point(122, 421)
        firstNameBox.Name = "firstNameBox"
        firstNameBox.Size = New Size(350, 56)
        firstNameBox.TabIndex = 2
        ' 
        ' midNameBox
        ' 
        midNameBox.BackColor = Color.Silver
        midNameBox.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        midNameBox.Location = New Point(122, 613)
        midNameBox.Name = "midNameBox"
        midNameBox.Size = New Size(350, 56)
        midNameBox.TabIndex = 3
        ' 
        ' nameLabel
        ' 
        nameLabel.AutoSize = True
        nameLabel.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nameLabel.Location = New Point(73, 64)
        nameLabel.Name = "nameLabel"
        nameLabel.Size = New Size(245, 60)
        nameLabel.TabIndex = 4
        nameLabel.Text = "Full Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Indigo
        Label1.Location = New Point(122, 161)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 46)
        Label1.TabIndex = 5
        Label1.Text = "Last Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label2.ForeColor = Color.Indigo
        Label2.Location = New Point(122, 353)
        Label2.Name = "Label2"
        Label2.Size = New Size(193, 46)
        Label2.TabIndex = 6
        Label2.Text = "First Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label3.ForeColor = Color.Indigo
        Label3.Location = New Point(122, 544)
        Label3.Name = "Label3"
        Label3.Size = New Size(236, 46)
        Label3.TabIndex = 7
        Label3.Text = "Middle Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label4.ForeColor = Color.Indigo
        Label4.Location = New Point(297, 724)
        Label4.Name = "Label4"
        Label4.Size = New Size(136, 46)
        Label4.TabIndex = 9
        Label4.Text = "Gender"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.Silver
        ComboBox1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"MALE", "FEMALE"})
        ComboBox1.Location = New Point(297, 784)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(162, 54)
        ComboBox1.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label5.ForeColor = Color.Indigo
        Label5.Location = New Point(505, 720)
        Label5.Name = "Label5"
        Label5.Size = New Size(107, 46)
        Label5.TabIndex = 11
        Label5.Text = "Email"
        ' 
        ' emailBox
        ' 
        emailBox.BackColor = Color.Silver
        emailBox.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        emailBox.Location = New Point(505, 787)
        emailBox.Name = "emailBox"
        emailBox.Size = New Size(265, 52)
        emailBox.TabIndex = 12
        ' 
        ' suffixTxtBox
        ' 
        suffixTxtBox.BackColor = Color.Silver
        suffixTxtBox.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        suffixTxtBox.Location = New Point(122, 785)
        suffixTxtBox.Name = "suffixTxtBox"
        suffixTxtBox.Size = New Size(116, 52)
        suffixTxtBox.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label6.ForeColor = Color.Indigo
        Label6.Location = New Point(122, 724)
        Label6.Name = "Label6"
        Label6.Size = New Size(115, 46)
        Label6.TabIndex = 14
        Label6.Text = "Suffix"
        ' 
        ' numberTextbox
        ' 
        numberTextbox.BackColor = Color.Silver
        numberTextbox.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        numberTextbox.Location = New Point(818, 787)
        numberTextbox.Name = "numberTextbox"
        numberTextbox.Size = New Size(263, 52)
        numberTextbox.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label7.ForeColor = Color.Indigo
        Label7.Location = New Point(818, 720)
        Label7.Name = "Label7"
        Label7.Size = New Size(284, 46)
        Label7.TabIndex = 15
        Label7.Text = "Contact Number"
        ' 
        ' courseBox
        ' 
        courseBox.BackColor = Color.Silver
        courseBox.Font = New Font("Segoe UI", 15.75F)
        courseBox.FormattingEnabled = True
        courseBox.Items.AddRange(New Object() {"Bachelor of Science in Information Technology", "Bachelor of Science in Computer Science"})
        courseBox.Location = New Point(537, 615)
        courseBox.Name = "courseBox"
        courseBox.Size = New Size(501, 44)
        courseBox.TabIndex = 17
        ' 
        ' departmentBox
        ' 
        departmentBox.BackColor = Color.Silver
        departmentBox.Enabled = False
        departmentBox.Font = New Font("Segoe UI", 15.75F)
        departmentBox.FormattingEnabled = True
        departmentBox.Items.AddRange(New Object() {"COLLEGE OF COMPUTER STUDIES", "COLLEGE OF EDUCATION", "COLLEGE OF ENGINEERING", "COLLEGE OF NURSING", "COLLEGE OF ARTS AND SCIENCE", "COLLEGE OF BUSINESS AND ACCOUNTANCY", "COLLEGE OF HOSPITALITY MANAGEMENT"})
        departmentBox.Location = New Point(537, 419)
        departmentBox.Name = "departmentBox"
        departmentBox.Size = New Size(501, 44)
        departmentBox.TabIndex = 19
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Indigo
        Label9.Location = New Point(531, 353)
        Label9.Name = "Label9"
        Label9.Size = New Size(213, 46)
        Label9.TabIndex = 20
        Label9.Text = "Department"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label10.ForeColor = Color.Indigo
        Label10.Location = New Point(847, 161)
        Label10.Name = "Label10"
        Label10.Size = New Size(286, 46)
        Label10.TabIndex = 21
        Label10.Text = "Student Number"
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.BackColor = Color.Silver
        MaskedTextBox1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MaskedTextBox1.Location = New Point(851, 221)
        MaskedTextBox1.Mask = "0 0  -  0 0 0 0 0"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(194, 56)
        MaskedTextBox1.TabIndex = 22
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Indigo
        Button1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(877, 885)
        Button1.Name = "Button1"
        Button1.Size = New Size(206, 96)
        Button1.TabIndex = 28
        Button1.Text = "REGISTER"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SlateGray
        Button2.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(122, 885)
        Button2.Name = "Button2"
        Button2.Size = New Size(206, 96)
        Button2.TabIndex = 29
        Button2.Text = "RETURN"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DarkSlateBlue
        Button3.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(490, 885)
        Button3.Name = "Button3"
        Button3.Size = New Size(206, 96)
        Button3.TabIndex = 30
        Button3.Text = "CLEAR"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.studentHeader1
        PictureBox1.Location = New Point(-3, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(2194, 240)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label13.ForeColor = Color.Indigo
        Label13.Location = New Point(537, 544)
        Label13.Name = "Label13"
        Label13.Size = New Size(130, 46)
        Label13.TabIndex = 32
        Label13.Text = "Course"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(sectionBox)
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
        Panel1.Location = New Point(558, 301)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1170, 1023)
        Panel1.TabIndex = 33
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label8.ForeColor = Color.Indigo
        Label8.Location = New Point(531, 161)
        Label8.Name = "Label8"
        Label8.Size = New Size(138, 46)
        Label8.TabIndex = 34
        Label8.Text = "Section"
        ' 
        ' sectionBox
        ' 
        sectionBox.BackColor = Color.Silver
        sectionBox.Enabled = False
        sectionBox.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        sectionBox.FormattingEnabled = True
        sectionBox.Items.AddRange(New Object() {"COLLEGE OF COMPUTER STUDIES", "COLLEGE OF EDUCATION", "COLLEGE OF ENGINEERING", "COLLEGE OF NURSING", "COLLEGE OF ARTS AND SCIENCE", "COLLEGE OF BUSINESS AND ACCOUNTANCY", "COLLEGE OF HOSPITALITY MANAGEMENT"})
        sectionBox.Location = New Point(531, 225)
        sectionBox.Name = "sectionBox"
        sectionBox.Size = New Size(241, 54)
        sectionBox.TabIndex = 33
        ' 
        ' StudentRegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.regisformsBG_bw1
        ClientSize = New Size(1924, 1055)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "StudentRegistrationForm"
        Text = "Student Registration Form"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents sectionBox As ComboBox

End Class
