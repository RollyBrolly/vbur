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
        facultyexitbtn = New PictureBox()
        searchbox = New TextBox()
        gradebtn = New Button()
        gradeDGV = New DataGridView()
        PictureBox1 = New PictureBox()
        programlbl = New Label()
        programcbbox = New ComboBox()
        dptlbl = New Label()
        deptcbbox = New ComboBox()
        sectioncbbox = New ComboBox()
        sectionlbl = New Label()
        computebtn = New Button()
        CType(facultyexitbtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(gradeDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' facultyexitbtn
        ' 
        facultyexitbtn.BackColor = Color.Transparent
        facultyexitbtn.Image = My.Resources.Resources.icons8_log_out_96
        facultyexitbtn.Location = New Point(1674, 35)
        facultyexitbtn.Margin = New Padding(3, 2, 3, 2)
        facultyexitbtn.Name = "facultyexitbtn"
        facultyexitbtn.Size = New Size(114, 103)
        facultyexitbtn.SizeMode = PictureBoxSizeMode.StretchImage
        facultyexitbtn.TabIndex = 119
        facultyexitbtn.TabStop = False
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
        gradebtn.Location = New Point(1644, 967)
        gradebtn.Margin = New Padding(3, 2, 3, 2)
        gradebtn.Name = "gradebtn"
        gradebtn.Size = New Size(192, 63)
        gradebtn.TabIndex = 109
        gradebtn.Text = "SAVE"
        gradebtn.UseVisualStyleBackColor = False
        ' 
        ' gradeDGV
        ' 
        gradeDGV.AllowUserToAddRows = False
        gradeDGV.AllowUserToOrderColumns = True
        gradeDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gradeDGV.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Indigo
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        gradeDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        gradeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        gradeDGV.DefaultCellStyle = DataGridViewCellStyle2
        gradeDGV.Location = New Point(42, 315)
        gradeDGV.Name = "gradeDGV"
        gradeDGV.RowHeadersVisible = False
        gradeDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        gradeDGV.Size = New Size(1833, 625)
        gradeDGV.TabIndex = 94
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
        Controls.Add(facultyexitbtn)
        Controls.Add(searchbox)
        Controls.Add(gradebtn)
        Controls.Add(gradeDGV)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "facultyGradeStudents"
        Text = "Grade Students Form"
        CType(facultyexitbtn, ComponentModel.ISupportInitialize).EndInit()
        CType(gradeDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents facultyexitbtn As PictureBox
    Friend WithEvents searchbox As TextBox
    Friend WithEvents gradebtn As Button
    Friend WithEvents gradeDGV As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents programlbl As Label
    Friend WithEvents programcbbox As ComboBox
    Friend WithEvents dptlbl As Label
    Friend WithEvents deptcbbox As ComboBox
    Friend WithEvents sectioncbbox As ComboBox
    Friend WithEvents sectionlbl As Label
    Friend WithEvents computebtn As Button
End Class
