<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class facultyStudentRecord
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(facultyStudentRecord))
        PictureBox1 = New PictureBox()
        DataGridView1 = New DataGridView()
        studentID = New DataGridViewTextBoxColumn()
        Surname = New DataGridViewTextBoxColumn()
        Firstname = New DataGridViewTextBoxColumn()
        Midname = New DataGridViewTextBoxColumn()
        gender = New DataGridViewTextBoxColumn()
        Department = New DataGridViewTextBoxColumn()
        Program = New DataGridViewTextBoxColumn()
        Section = New DataGridViewTextBoxColumn()
        studidtxtbx = New TextBox()
        studidlbl = New Label()
        surnametxtbox = New TextBox()
        surnamelbl = New Label()
        firstnametxtbox = New TextBox()
        firstnamelbl = New Label()
        midnametxtbox = New TextBox()
        midnamelbl = New Label()
        sectionlbl = New Label()
        sectioncbbox = New ComboBox()
        deptcbbox = New ComboBox()
        dptlbl = New Label()
        programlbl = New Label()
        programcbbox = New ComboBox()
        gradebtn = New Button()
        genderccbox = New ComboBox()
        genderlbl = New Label()
        searchbox = New TextBox()
        filterbtn = New Button()
        deptfltr = New ComboBox()
        programfltr = New ComboBox()
        sectionfltr = New ComboBox()
        resetFilterBtn = New PictureBox()
        PictureBox7 = New PictureBox()
        btnadd = New PictureBox()
        btndelete = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(resetFilterBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnadd, ComponentModel.ISupportInitialize).BeginInit()
        CType(btndelete, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.facultyStudentRecord
        PictureBox1.Location = New Point(-2, 0)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1928, 180)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 65
        PictureBox1.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Indigo
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {studentID, Surname, Firstname, Midname, gender, Department, Program, Section})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(55, 489)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(1800, 540)
        DataGridView1.TabIndex = 66
        ' 
        ' studentID
        ' 
        studentID.HeaderText = "Student ID"
        studentID.Name = "studentID"
        studentID.ReadOnly = True
        studentID.Width = 150
        ' 
        ' Surname
        ' 
        Surname.HeaderText = "Surname"
        Surname.Name = "Surname"
        Surname.ReadOnly = True
        Surname.Width = 200
        ' 
        ' Firstname
        ' 
        Firstname.HeaderText = "First Name"
        Firstname.Name = "Firstname"
        Firstname.ReadOnly = True
        Firstname.Width = 250
        ' 
        ' Midname
        ' 
        Midname.HeaderText = "Middle Name"
        Midname.Name = "Midname"
        Midname.ReadOnly = True
        Midname.Width = 200
        ' 
        ' gender
        ' 
        gender.HeaderText = "Gender"
        gender.Name = "gender"
        gender.ReadOnly = True
        ' 
        ' Department
        ' 
        Department.HeaderText = "Department"
        Department.Name = "Department"
        Department.ReadOnly = True
        Department.Width = 350
        ' 
        ' Program
        ' 
        Program.HeaderText = "Program"
        Program.Name = "Program"
        Program.ReadOnly = True
        Program.Width = 390
        ' 
        ' Section
        ' 
        Section.HeaderText = "Section"
        Section.Name = "Section"
        Section.ReadOnly = True
        Section.Width = 120
        ' 
        ' studidtxtbx
        ' 
        studidtxtbx.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studidtxtbx.Location = New Point(55, 240)
        studidtxtbx.Name = "studidtxtbx"
        studidtxtbx.Size = New Size(153, 35)
        studidtxtbx.TabIndex = 67
        ' 
        ' studidlbl
        ' 
        studidlbl.AutoSize = True
        studidlbl.BackColor = Color.Transparent
        studidlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studidlbl.ForeColor = Color.White
        studidlbl.Location = New Point(55, 191)
        studidlbl.Name = "studidlbl"
        studidlbl.Size = New Size(153, 37)
        studidlbl.TabIndex = 68
        studidlbl.Text = "Student ID"
        ' 
        ' surnametxtbox
        ' 
        surnametxtbox.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        surnametxtbox.Location = New Point(318, 240)
        surnametxtbox.Name = "surnametxtbox"
        surnametxtbox.Size = New Size(310, 35)
        surnametxtbox.TabIndex = 69
        ' 
        ' surnamelbl
        ' 
        surnamelbl.AutoSize = True
        surnamelbl.BackColor = Color.Transparent
        surnamelbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        surnamelbl.ForeColor = Color.White
        surnamelbl.Location = New Point(318, 191)
        surnamelbl.Name = "surnamelbl"
        surnamelbl.Size = New Size(130, 37)
        surnamelbl.TabIndex = 70
        surnamelbl.Text = "Surname"
        ' 
        ' firstnametxtbox
        ' 
        firstnametxtbox.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        firstnametxtbox.Location = New Point(728, 240)
        firstnametxtbox.Name = "firstnametxtbox"
        firstnametxtbox.Size = New Size(357, 35)
        firstnametxtbox.TabIndex = 71
        ' 
        ' firstnamelbl
        ' 
        firstnamelbl.AutoSize = True
        firstnamelbl.BackColor = Color.Transparent
        firstnamelbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        firstnamelbl.ForeColor = Color.White
        firstnamelbl.Location = New Point(728, 191)
        firstnamelbl.Name = "firstnamelbl"
        firstnamelbl.Size = New Size(156, 37)
        firstnamelbl.TabIndex = 72
        firstnamelbl.Text = "First Name"
        ' 
        ' midnametxtbox
        ' 
        midnametxtbox.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        midnametxtbox.Location = New Point(1149, 240)
        midnametxtbox.Name = "midnametxtbox"
        midnametxtbox.Size = New Size(280, 35)
        midnametxtbox.TabIndex = 73
        ' 
        ' midnamelbl
        ' 
        midnamelbl.AutoSize = True
        midnamelbl.BackColor = Color.Transparent
        midnamelbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        midnamelbl.ForeColor = Color.White
        midnamelbl.Location = New Point(1149, 191)
        midnamelbl.Name = "midnamelbl"
        midnamelbl.Size = New Size(191, 37)
        midnamelbl.TabIndex = 74
        midnamelbl.Text = "Middle Name"
        ' 
        ' sectionlbl
        ' 
        sectionlbl.AutoSize = True
        sectionlbl.BackColor = Color.Transparent
        sectionlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sectionlbl.ForeColor = Color.White
        sectionlbl.Location = New Point(1518, 288)
        sectionlbl.Name = "sectionlbl"
        sectionlbl.Size = New Size(112, 37)
        sectionlbl.TabIndex = 76
        sectionlbl.Text = "Section"
        ' 
        ' sectioncbbox
        ' 
        sectioncbbox.DropDownStyle = ComboBoxStyle.DropDownList
        sectioncbbox.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sectioncbbox.FormattingEnabled = True
        sectioncbbox.Location = New Point(1518, 334)
        sectioncbbox.Name = "sectioncbbox"
        sectioncbbox.Size = New Size(104, 38)
        sectioncbbox.TabIndex = 77
        ' 
        ' deptcbbox
        ' 
        deptcbbox.DropDownStyle = ComboBoxStyle.DropDownList
        deptcbbox.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        deptcbbox.FormattingEnabled = True
        deptcbbox.Location = New Point(55, 334)
        deptcbbox.Name = "deptcbbox"
        deptcbbox.Size = New Size(526, 38)
        deptcbbox.TabIndex = 78
        ' 
        ' dptlbl
        ' 
        dptlbl.AutoSize = True
        dptlbl.BackColor = Color.Transparent
        dptlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dptlbl.ForeColor = Color.White
        dptlbl.Location = New Point(55, 288)
        dptlbl.Name = "dptlbl"
        dptlbl.Size = New Size(174, 37)
        dptlbl.TabIndex = 79
        dptlbl.Text = "Department"
        ' 
        ' programlbl
        ' 
        programlbl.AutoSize = True
        programlbl.BackColor = Color.Transparent
        programlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        programlbl.ForeColor = Color.White
        programlbl.Location = New Point(857, 288)
        programlbl.Name = "programlbl"
        programlbl.Size = New Size(130, 37)
        programlbl.TabIndex = 81
        programlbl.Text = "Program"
        ' 
        ' programcbbox
        ' 
        programcbbox.DropDownStyle = ComboBoxStyle.DropDownList
        programcbbox.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        programcbbox.FormattingEnabled = True
        programcbbox.Location = New Point(857, 334)
        programcbbox.Name = "programcbbox"
        programcbbox.Size = New Size(611, 38)
        programcbbox.TabIndex = 80
        ' 
        ' gradebtn
        ' 
        gradebtn.BackColor = Color.Indigo
        gradebtn.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gradebtn.ForeColor = Color.White
        gradebtn.Location = New Point(1663, 212)
        gradebtn.Margin = New Padding(3, 2, 3, 2)
        gradebtn.Name = "gradebtn"
        gradebtn.Size = New Size(192, 63)
        gradebtn.TabIndex = 83
        gradebtn.Text = "GRADE"
        gradebtn.UseVisualStyleBackColor = False
        ' 
        ' genderccbox
        ' 
        genderccbox.DropDownStyle = ComboBoxStyle.DropDownList
        genderccbox.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        genderccbox.FormattingEnabled = True
        genderccbox.Items.AddRange(New Object() {"Male", "Female"})
        genderccbox.Location = New Point(1518, 237)
        genderccbox.Name = "genderccbox"
        genderccbox.Size = New Size(104, 38)
        genderccbox.TabIndex = 85
        ' 
        ' genderlbl
        ' 
        genderlbl.AutoSize = True
        genderlbl.BackColor = Color.Transparent
        genderlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        genderlbl.ForeColor = Color.White
        genderlbl.Location = New Point(1518, 191)
        genderlbl.Name = "genderlbl"
        genderlbl.Size = New Size(110, 37)
        genderlbl.TabIndex = 84
        genderlbl.Text = "Gender"
        ' 
        ' searchbox
        ' 
        searchbox.Font = New Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        searchbox.ForeColor = Color.Gray
        searchbox.Location = New Point(681, 416)
        searchbox.Name = "searchbox"
        searchbox.Size = New Size(306, 35)
        searchbox.TabIndex = 86
        ' 
        ' filterbtn
        ' 
        filterbtn.BackColor = Color.LightSlateGray
        filterbtn.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        filterbtn.ForeColor = Color.White
        filterbtn.Location = New Point(1663, 398)
        filterbtn.Margin = New Padding(3, 2, 3, 2)
        filterbtn.Name = "filterbtn"
        filterbtn.Size = New Size(110, 63)
        filterbtn.TabIndex = 87
        filterbtn.Text = "FILTER"
        filterbtn.UseVisualStyleBackColor = False
        ' 
        ' deptfltr
        ' 
        deptfltr.Font = New Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        deptfltr.ForeColor = Color.Gray
        deptfltr.FormattingEnabled = True
        deptfltr.Location = New Point(1022, 413)
        deptfltr.Name = "deptfltr"
        deptfltr.Size = New Size(216, 38)
        deptfltr.TabIndex = 88
        deptfltr.Text = "Filter Department"
        ' 
        ' programfltr
        ' 
        programfltr.Font = New Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        programfltr.ForeColor = Color.Gray
        programfltr.FormattingEnabled = True
        programfltr.Location = New Point(1267, 413)
        programfltr.Name = "programfltr"
        programfltr.Size = New Size(183, 38)
        programfltr.TabIndex = 89
        programfltr.Text = "Filter Program"
        ' 
        ' sectionfltr
        ' 
        sectionfltr.Font = New Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        sectionfltr.ForeColor = Color.Gray
        sectionfltr.FormattingEnabled = True
        sectionfltr.Location = New Point(1480, 413)
        sectionfltr.Name = "sectionfltr"
        sectionfltr.Size = New Size(142, 38)
        sectionfltr.TabIndex = 90
        sectionfltr.Text = "Filter Section"
        ' 
        ' resetFilterBtn
        ' 
        resetFilterBtn.BackColor = Color.LightSlateGray
        resetFilterBtn.Image = My.Resources.Resources.icons8_reset_64
        resetFilterBtn.Location = New Point(1779, 398)
        resetFilterBtn.Name = "resetFilterBtn"
        resetFilterBtn.Size = New Size(70, 63)
        resetFilterBtn.SizeMode = PictureBoxSizeMode.StretchImage
        resetFilterBtn.TabIndex = 91
        resetFilterBtn.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.Image = My.Resources.Resources.icons8_log_out_96
        PictureBox7.Location = New Point(1684, 34)
        PictureBox7.Margin = New Padding(3, 2, 3, 2)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(114, 103)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 92
        PictureBox7.TabStop = False
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = Color.Indigo
        btnadd.Image = My.Resources.Resources.icons8_plus_math_90
        btnadd.Location = New Point(1663, 309)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(70, 63)
        btnadd.SizeMode = PictureBoxSizeMode.StretchImage
        btnadd.TabIndex = 94
        btnadd.TabStop = False
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.Indigo
        btndelete.Image = My.Resources.Resources.icons8_delete_96
        btndelete.Location = New Point(1779, 309)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(70, 63)
        btndelete.SizeMode = PictureBoxSizeMode.StretchImage
        btndelete.TabIndex = 95
        btndelete.TabStop = False
        ' 
        ' facultyStudentRecord
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        ClientSize = New Size(1904, 1041)
        Controls.Add(btndelete)
        Controls.Add(btnadd)
        Controls.Add(PictureBox7)
        Controls.Add(resetFilterBtn)
        Controls.Add(sectionfltr)
        Controls.Add(programfltr)
        Controls.Add(deptfltr)
        Controls.Add(filterbtn)
        Controls.Add(searchbox)
        Controls.Add(genderccbox)
        Controls.Add(genderlbl)
        Controls.Add(gradebtn)
        Controls.Add(programlbl)
        Controls.Add(programcbbox)
        Controls.Add(dptlbl)
        Controls.Add(deptcbbox)
        Controls.Add(sectioncbbox)
        Controls.Add(sectionlbl)
        Controls.Add(midnamelbl)
        Controls.Add(midnametxtbox)
        Controls.Add(firstnamelbl)
        Controls.Add(firstnametxtbox)
        Controls.Add(surnamelbl)
        Controls.Add(surnametxtbox)
        Controls.Add(studidlbl)
        Controls.Add(studidtxtbx)
        Controls.Add(DataGridView1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "facultyStudentRecord"
        Text = "Student Record"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(resetFilterBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(btnadd, ComponentModel.ISupportInitialize).EndInit()
        CType(btndelete, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents studidtxtbx As TextBox
    Friend WithEvents studidlbl As Label
    Friend WithEvents surnametxtbox As TextBox
    Friend WithEvents surnamelbl As Label
    Friend WithEvents firstnametxtbox As TextBox
    Friend WithEvents firstnamelbl As Label
    Friend WithEvents midnametxtbox As TextBox
    Friend WithEvents midnamelbl As Label
    Friend WithEvents sectionlbl As Label
    Friend WithEvents sectioncbbox As ComboBox
    Friend WithEvents deptcbbox As ComboBox
    Friend WithEvents dptlbl As Label
    Friend WithEvents programlbl As Label
    Friend WithEvents programcbbox As ComboBox
    Friend WithEvents gradebtn As Button
    Friend WithEvents genderccbox As ComboBox
    Friend WithEvents genderlbl As Label
    Friend WithEvents studentID As DataGridViewTextBoxColumn
    Friend WithEvents Surname As DataGridViewTextBoxColumn
    Friend WithEvents Firstname As DataGridViewTextBoxColumn
    Friend WithEvents Midname As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents Department As DataGridViewTextBoxColumn
    Friend WithEvents Program As DataGridViewTextBoxColumn
    Friend WithEvents Section As DataGridViewTextBoxColumn
    Friend WithEvents searchbox As TextBox
    Friend WithEvents filterbtn As Button
    Friend WithEvents deptfltr As ComboBox
    Friend WithEvents programfltr As ComboBox
    Friend WithEvents sectionfltr As ComboBox
    Friend WithEvents resetFilterBtn As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents btnadd As PictureBox
    Friend WithEvents btndelete As PictureBox
End Class
