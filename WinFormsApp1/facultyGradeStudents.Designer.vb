<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class facultyGradeStudents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(facultyGradeStudents))
        PictureBox7 = New PictureBox()
        filterbtn = New Button()
        searchbox = New TextBox()
        gradebtn = New Button()
        DataGridView1 = New DataGridView()
        studentID = New DataGridViewTextBoxColumn()
        Surname = New DataGridViewTextBoxColumn()
        Firstname = New DataGridViewTextBoxColumn()
        Midname = New DataGridViewTextBoxColumn()
        Quiz1 = New DataGridViewTextBoxColumn()
        Quiz2 = New DataGridViewTextBoxColumn()
        Quiz3 = New DataGridViewTextBoxColumn()
        SW1 = New DataGridViewTextBoxColumn()
        SW2 = New DataGridViewTextBoxColumn()
        SW3 = New DataGridViewTextBoxColumn()
        MidtermExam = New DataGridViewTextBoxColumn()
        FinalExam = New DataGridViewTextBoxColumn()
        GWA = New DataGridViewTextBoxColumn()
        Remarks = New DataGridViewTextBoxColumn()
        PictureBox1 = New PictureBox()
        programlbl = New Label()
        programcbbox = New ComboBox()
        dptlbl = New Label()
        deptcbbox = New ComboBox()
        sectioncbbox = New ComboBox()
        sectionlbl = New Label()
        computebtn = New Button()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.Image = My.Resources.Resources.icons8_log_out_96
        PictureBox7.Location = New Point(1674, 35)
        PictureBox7.Margin = New Padding(3, 2, 3, 2)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(114, 103)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 119
        PictureBox7.TabStop = False
        ' 
        ' filterbtn
        ' 
        filterbtn.BackColor = Color.LightSlateGray
        filterbtn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        filterbtn.ForeColor = Color.White
        filterbtn.Location = New Point(1753, 241)
        filterbtn.Margin = New Padding(3, 2, 3, 2)
        filterbtn.Name = "filterbtn"
        filterbtn.Size = New Size(83, 39)
        filterbtn.TabIndex = 114
        filterbtn.Text = "SEARCH"
        filterbtn.UseVisualStyleBackColor = False
        ' 
        ' searchbox
        ' 
        searchbox.Font = New Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        searchbox.ForeColor = Color.Gray
        searchbox.Location = New Point(1432, 241)
        searchbox.Name = "searchbox"
        searchbox.Size = New Size(306, 35)
        searchbox.TabIndex = 113
        ' 
        ' gradebtn
        ' 
        gradebtn.BackColor = Color.Indigo
        gradebtn.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gradebtn.ForeColor = Color.White
        gradebtn.Location = New Point(1654, 967)
        gradebtn.Margin = New Padding(3, 2, 3, 2)
        gradebtn.Name = "gradebtn"
        gradebtn.Size = New Size(192, 63)
        gradebtn.TabIndex = 109
        gradebtn.Text = "SAVE"
        gradebtn.UseVisualStyleBackColor = False
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {studentID, Surname, Firstname, Midname, Quiz1, Quiz2, Quiz3, SW1, SW2, SW3, MidtermExam, FinalExam, GWA, Remarks})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(54, 315)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1782, 625)
        DataGridView1.TabIndex = 94
        ' 
        ' studentID
        ' 
        studentID.HeaderText = "Student ID"
        studentID.Name = "studentID"
        studentID.Width = 150
        ' 
        ' Surname
        ' 
        Surname.HeaderText = "Surname"
        Surname.Name = "Surname"
        Surname.Width = 200
        ' 
        ' Firstname
        ' 
        Firstname.HeaderText = "First Name"
        Firstname.Name = "Firstname"
        Firstname.Width = 250
        ' 
        ' Midname
        ' 
        Midname.HeaderText = "Middle Name"
        Midname.Name = "Midname"
        Midname.Width = 200
        ' 
        ' Quiz1
        ' 
        Quiz1.HeaderText = "Q1 (20)"
        Quiz1.Name = "Quiz1"
        Quiz1.Width = 90
        ' 
        ' Quiz2
        ' 
        Quiz2.HeaderText = "Q2 (25)"
        Quiz2.Name = "Quiz2"
        Quiz2.Width = 90
        ' 
        ' Quiz3
        ' 
        Quiz3.HeaderText = "Q3 (35)"
        Quiz3.Name = "Quiz3"
        Quiz3.Width = 90
        ' 
        ' SW1
        ' 
        SW1.HeaderText = "SW1 (10)"
        SW1.Name = "SW1"
        SW1.Width = 90
        ' 
        ' SW2
        ' 
        SW2.HeaderText = "SW2 (10)"
        SW2.Name = "SW2"
        SW2.Width = 90
        ' 
        ' SW3
        ' 
        SW3.HeaderText = "SW3 (25)"
        SW3.Name = "SW3"
        SW3.Width = 90
        ' 
        ' MidtermExam
        ' 
        MidtermExam.HeaderText = "ME (50)"
        MidtermExam.Name = "MidtermExam"
        MidtermExam.Width = 90
        ' 
        ' FinalExam
        ' 
        FinalExam.HeaderText = "FE (70)"
        FinalExam.Name = "FinalExam"
        FinalExam.Width = 90
        ' 
        ' GWA
        ' 
        GWA.HeaderText = "GWA"
        GWA.Name = "GWA"
        GWA.Width = 90
        ' 
        ' Remarks
        ' 
        Remarks.HeaderText = "Remarks"
        Remarks.Name = "Remarks"
        Remarks.Width = 130
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.facultygradeStudents
        PictureBox1.Location = New Point(-2, 0)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1928, 180)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 93
        PictureBox1.TabStop = False
        ' 
        ' programlbl
        ' 
        programlbl.AutoSize = True
        programlbl.BackColor = Color.Transparent
        programlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        programlbl.ForeColor = Color.White
        programlbl.Location = New Point(628, 195)
        programlbl.Name = "programlbl"
        programlbl.Size = New Size(130, 37)
        programlbl.TabIndex = 125
        programlbl.Text = "Program"
        ' 
        ' programcbbox
        ' 
        programcbbox.DropDownStyle = ComboBoxStyle.DropDownList
        programcbbox.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        programcbbox.FormattingEnabled = True
        programcbbox.Location = New Point(628, 241)
        programcbbox.Name = "programcbbox"
        programcbbox.Size = New Size(611, 38)
        programcbbox.TabIndex = 124
        ' 
        ' dptlbl
        ' 
        dptlbl.AutoSize = True
        dptlbl.BackColor = Color.Transparent
        dptlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dptlbl.ForeColor = Color.White
        dptlbl.Location = New Point(54, 195)
        dptlbl.Name = "dptlbl"
        dptlbl.Size = New Size(174, 37)
        dptlbl.TabIndex = 123
        dptlbl.Text = "Department"
        ' 
        ' deptcbbox
        ' 
        deptcbbox.DropDownStyle = ComboBoxStyle.DropDownList
        deptcbbox.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        deptcbbox.FormattingEnabled = True
        deptcbbox.Location = New Point(54, 241)
        deptcbbox.Name = "deptcbbox"
        deptcbbox.Size = New Size(526, 38)
        deptcbbox.TabIndex = 122
        ' 
        ' sectioncbbox
        ' 
        sectioncbbox.DropDownStyle = ComboBoxStyle.DropDownList
        sectioncbbox.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sectioncbbox.FormattingEnabled = True
        sectioncbbox.Location = New Point(1305, 239)
        sectioncbbox.Name = "sectioncbbox"
        sectioncbbox.Size = New Size(104, 38)
        sectioncbbox.TabIndex = 121
        ' 
        ' sectionlbl
        ' 
        sectionlbl.AutoSize = True
        sectionlbl.BackColor = Color.Transparent
        sectionlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sectionlbl.ForeColor = Color.White
        sectionlbl.Location = New Point(1305, 193)
        sectionlbl.Name = "sectionlbl"
        sectionlbl.Size = New Size(112, 37)
        sectionlbl.TabIndex = 120
        sectionlbl.Text = "Section"
        ' 
        ' computebtn
        ' 
        computebtn.BackColor = Color.Indigo
        computebtn.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        computebtn.ForeColor = Color.White
        computebtn.Location = New Point(1376, 967)
        computebtn.Margin = New Padding(3, 2, 3, 2)
        computebtn.Name = "computebtn"
        computebtn.Size = New Size(244, 63)
        computebtn.TabIndex = 126
        computebtn.Text = "COMPUTE"
        computebtn.UseVisualStyleBackColor = False
        ' 
        ' facultyGradeStudents
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        ClientSize = New Size(1904, 1041)
        Controls.Add(computebtn)
        Controls.Add(programlbl)
        Controls.Add(programcbbox)
        Controls.Add(dptlbl)
        Controls.Add(deptcbbox)
        Controls.Add(sectioncbbox)
        Controls.Add(sectionlbl)
        Controls.Add(PictureBox7)
        Controls.Add(filterbtn)
        Controls.Add(searchbox)
        Controls.Add(gradebtn)
        Controls.Add(DataGridView1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "facultyGradeStudents"
        Text = "Grade Students Form"
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents filterbtn As Button
    Friend WithEvents searchbox As TextBox
    Friend WithEvents gradebtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents programlbl As Label
    Friend WithEvents programcbbox As ComboBox
    Friend WithEvents dptlbl As Label
    Friend WithEvents deptcbbox As ComboBox
    Friend WithEvents sectioncbbox As ComboBox
    Friend WithEvents sectionlbl As Label
    Friend WithEvents computebtn As Button
    Friend WithEvents studentID As DataGridViewTextBoxColumn
    Friend WithEvents Surname As DataGridViewTextBoxColumn
    Friend WithEvents Firstname As DataGridViewTextBoxColumn
    Friend WithEvents Midname As DataGridViewTextBoxColumn
    Friend WithEvents Quiz1 As DataGridViewTextBoxColumn
    Friend WithEvents Quiz2 As DataGridViewTextBoxColumn
    Friend WithEvents Quiz3 As DataGridViewTextBoxColumn
    Friend WithEvents SW1 As DataGridViewTextBoxColumn
    Friend WithEvents SW2 As DataGridViewTextBoxColumn
    Friend WithEvents SW3 As DataGridViewTextBoxColumn
    Friend WithEvents MidtermExam As DataGridViewTextBoxColumn
    Friend WithEvents FinalExam As DataGridViewTextBoxColumn
    Friend WithEvents GWA As DataGridViewTextBoxColumn
    Friend WithEvents Remarks As DataGridViewTextBoxColumn
End Class
