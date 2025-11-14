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
        firstNameBox = New TextBox()
        midNameBox = New TextBox()
        titlelbl = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        studgendercb = New ComboBox()
        Label5 = New Label()
        studemailtxt = New TextBox()
        suffixTxtBox = New TextBox()
        Label6 = New Label()
        numberTextbox = New TextBox()
        Label7 = New Label()
        courcb = New ComboBox()
        studdeptcb = New ComboBox()
        deptlbl = New Label()
        studnolbl = New Label()
        studnotxt = New MaskedTextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        courlbl = New Label()
        Panel1 = New Panel()
        sectionlbl = New Label()
        sectioncb = New ComboBox()
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
        ' firstNameBox
        ' 
        firstNameBox.BackColor = Color.Silver
        firstNameBox.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        firstNameBox.Location = New Point(107, 316)
        firstNameBox.Margin = New Padding(3, 2, 3, 2)
        firstNameBox.Name = "firstNameBox"
        firstNameBox.Size = New Size(307, 46)
        firstNameBox.TabIndex = 2
        ' 
        ' midNameBox
        ' 
        midNameBox.BackColor = Color.Silver
        midNameBox.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        midNameBox.Location = New Point(107, 460)
        midNameBox.Margin = New Padding(3, 2, 3, 2)
        midNameBox.Name = "midNameBox"
        midNameBox.Size = New Size(307, 46)
        midNameBox.TabIndex = 3
        ' 
        ' titlelbl
        ' 
        titlelbl.AutoSize = True
        titlelbl.Font = New Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        titlelbl.Location = New Point(64, 48)
        titlelbl.Name = "titlelbl"
        titlelbl.Size = New Size(194, 47)
        titlelbl.TabIndex = 4
        titlelbl.Text = "Full Name"
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
        Label4.Location = New Point(215, 543)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 37)
        Label4.TabIndex = 9
        Label4.Text = "Gender"
        ' 
        ' studgendercb
        ' 
        studgendercb.BackColor = Color.Silver
        studgendercb.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studgendercb.FormattingEnabled = True
        studgendercb.Items.AddRange(New Object() {"Male", "Female"})
        studgendercb.Location = New Point(215, 588)
        studgendercb.Margin = New Padding(3, 2, 3, 2)
        studgendercb.Name = "studgendercb"
        studgendercb.Size = New Size(110, 45)
        studgendercb.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label5.ForeColor = Color.Indigo
        Label5.Location = New Point(348, 543)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 37)
        Label5.TabIndex = 11
        Label5.Text = "Email"
        ' 
        ' studemailtxt
        ' 
        studemailtxt.BackColor = Color.Silver
        studemailtxt.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studemailtxt.Location = New Point(348, 590)
        studemailtxt.Margin = New Padding(3, 2, 3, 2)
        studemailtxt.Name = "studemailtxt"
        studemailtxt.Size = New Size(345, 33)
        studemailtxt.TabIndex = 12
        ' 
        ' suffixTxtBox
        ' 
        suffixTxtBox.BackColor = Color.Silver
        suffixTxtBox.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        suffixTxtBox.Location = New Point(107, 589)
        suffixTxtBox.Margin = New Padding(3, 2, 3, 2)
        suffixTxtBox.Name = "suffixTxtBox"
        suffixTxtBox.Size = New Size(68, 46)
        suffixTxtBox.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label6.ForeColor = Color.Indigo
        Label6.Location = New Point(107, 543)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 37)
        Label6.TabIndex = 14
        Label6.Text = "Suffix"
        ' 
        ' numberTextbox
        ' 
        numberTextbox.BackColor = Color.Silver
        numberTextbox.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold)
        numberTextbox.Location = New Point(716, 590)
        numberTextbox.Margin = New Padding(3, 2, 3, 2)
        numberTextbox.Name = "numberTextbox"
        numberTextbox.Size = New Size(231, 46)
        numberTextbox.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label7.ForeColor = Color.Indigo
        Label7.Location = New Point(716, 540)
        Label7.Name = "Label7"
        Label7.Size = New Size(229, 37)
        Label7.TabIndex = 15
        Label7.Text = "Contact Number"
        ' 
        ' courcb
        ' 
        courcb.BackColor = Color.Silver
        courcb.Font = New Font("Segoe UI", 15.75F)
        courcb.FormattingEnabled = True
        courcb.Items.AddRange(New Object() {"Bachelor of Science in Information Technology", "Bachelor of Science in Computer Science"})
        courcb.Location = New Point(470, 461)
        courcb.Margin = New Padding(3, 2, 3, 2)
        courcb.Name = "courcb"
        courcb.Size = New Size(439, 38)
        courcb.TabIndex = 17
        ' 
        ' studdeptcb
        ' 
        studdeptcb.BackColor = Color.Silver
        studdeptcb.Enabled = False
        studdeptcb.Font = New Font("Segoe UI", 15.75F)
        studdeptcb.FormattingEnabled = True
        studdeptcb.Items.AddRange(New Object() {"COLLEGE OF COMPUTER STUDIES", "COLLEGE OF EDUCATION", "COLLEGE OF ENGINEERING", "COLLEGE OF NURSING", "COLLEGE OF ARTS AND SCIENCE", "COLLEGE OF BUSINESS AND ACCOUNTANCY", "COLLEGE OF HOSPITALITY MANAGEMENT"})
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
        studnolbl.Location = New Point(429, 121)
        studnolbl.Name = "studnolbl"
        studnolbl.Size = New Size(229, 37)
        studnolbl.TabIndex = 21
        studnolbl.Text = "Student Number"
        ' 
        ' studnotxt
        ' 
        studnotxt.BackColor = Color.Silver
        studnotxt.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studnotxt.Location = New Point(468, 166)
        studnotxt.Margin = New Padding(3, 2, 3, 2)
        studnotxt.Mask = "0 0  -  0 0 0 0 0"
        studnotxt.Name = "studnotxt"
        studnotxt.Size = New Size(170, 46)
        studnotxt.TabIndex = 22
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
        ' courlbl
        ' 
        courlbl.AutoSize = True
        courlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        courlbl.ForeColor = Color.Indigo
        courlbl.Location = New Point(470, 408)
        courlbl.Name = "courlbl"
        courlbl.Size = New Size(105, 37)
        courlbl.TabIndex = 32
        courlbl.Text = "Course"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(sectionlbl)
        Panel1.Controls.Add(sectioncb)
        Panel1.Controls.Add(titlelbl)
        Panel1.Controls.Add(courlbl)
        Panel1.Controls.Add(courcb)
        Panel1.Controls.Add(deptlbl)
        Panel1.Controls.Add(studdeptcb)
        Panel1.Controls.Add(studnotxt)
        Panel1.Controls.Add(studlastntxt)
        Panel1.Controls.Add(studnolbl)
        Panel1.Controls.Add(studgendercb)
        Panel1.Controls.Add(studemailtxt)
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
        ' sectionlbl
        ' 
        sectionlbl.AutoSize = True
        sectionlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        sectionlbl.ForeColor = Color.Indigo
        sectionlbl.Location = New Point(688, 121)
        sectionlbl.Name = "sectionlbl"
        sectionlbl.Size = New Size(112, 37)
        sectionlbl.TabIndex = 34
        sectionlbl.Text = "Section"
        ' 
        ' sectioncb
        ' 
        sectioncb.BackColor = Color.Silver
        sectioncb.Enabled = False
        sectioncb.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        sectioncb.FormattingEnabled = True
        sectioncb.Items.AddRange(New Object() {"COLLEGE OF COMPUTER STUDIES", "COLLEGE OF EDUCATION", "COLLEGE OF ENGINEERING", "COLLEGE OF NURSING", "COLLEGE OF ARTS AND SCIENCE", "COLLEGE OF BUSINESS AND ACCOUNTANCY", "COLLEGE OF HOSPITALITY MANAGEMENT"})
        sectioncb.Location = New Point(688, 169)
        sectioncb.Margin = New Padding(3, 2, 3, 2)
        sectioncb.Name = "sectioncb"
        sectioncb.Size = New Size(211, 45)
        sectioncb.TabIndex = 33
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
    Friend WithEvents firstNameBox As TextBox
    Friend WithEvents midNameBox As TextBox
    Friend WithEvents titlelbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents studgendercb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents studemailtxt As TextBox
    Friend WithEvents suffixTxtBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents numberTextbox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents courcb As ComboBox
    Friend WithEvents studdeptcb As ComboBox
    Friend WithEvents deptlbl As Label
    Friend WithEvents studnolbl As Label
    Friend WithEvents studnotxt As MaskedTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents courlbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents sectionlbl As Label
    Friend WithEvents sectioncb As ComboBox

End Class
