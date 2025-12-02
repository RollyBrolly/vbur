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
        studDGV = New DataGridView()
        searchlbl = New Label()
        gradebtn = New Button()
        deptfltr = New ComboBox()
        programfltr = New ComboBox()
        sectionfltr = New ComboBox()
        exitbtn = New PictureBox()
        btndelete = New PictureBox()
        searchtxt = New TextBox()
        browsebtn = New Button()
        previewbtn = New Button()
        importbtn = New Button()
        containerpnl = New Panel()
        previewDGV = New DataGridView()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(studDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(exitbtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(btndelete, ComponentModel.ISupportInitialize).BeginInit()
        containerpnl.SuspendLayout()
        CType(previewDGV, ComponentModel.ISupportInitialize).BeginInit()
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
        ' studDGV
        ' 
        studDGV.AllowUserToOrderColumns = True
        studDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        studDGV.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Indigo
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        studDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        studDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        studDGV.DefaultCellStyle = DataGridViewCellStyle2
        studDGV.Location = New Point(46, 303)
        studDGV.Name = "studDGV"
        studDGV.ReadOnly = True
        studDGV.ScrollBars = ScrollBars.Vertical
        studDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        studDGV.Size = New Size(1800, 641)
        studDGV.TabIndex = 66
        ' 
        ' searchlbl
        ' 
        searchlbl.AutoSize = True
        searchlbl.BackColor = Color.Transparent
        searchlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        searchlbl.ForeColor = Color.White
        searchlbl.Location = New Point(96, 205)
        searchlbl.Name = "searchlbl"
        searchlbl.Size = New Size(102, 37)
        searchlbl.TabIndex = 74
        searchlbl.Text = "Search"
        ' 
        ' gradebtn
        ' 
        gradebtn.BackColor = Color.Indigo
        gradebtn.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gradebtn.ForeColor = Color.White
        gradebtn.Location = New Point(61, 967)
        gradebtn.Margin = New Padding(3, 2, 3, 2)
        gradebtn.Name = "gradebtn"
        gradebtn.Size = New Size(192, 63)
        gradebtn.TabIndex = 83
        gradebtn.Text = "GRADE"
        gradebtn.UseVisualStyleBackColor = False
        ' 
        ' deptfltr
        ' 
        deptfltr.DropDownStyle = ComboBoxStyle.DropDownList
        deptfltr.Font = New Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        deptfltr.ForeColor = Color.Gray
        deptfltr.FormattingEnabled = True
        deptfltr.Location = New Point(542, 248)
        deptfltr.Name = "deptfltr"
        deptfltr.Size = New Size(341, 38)
        deptfltr.TabIndex = 88
        ' 
        ' programfltr
        ' 
        programfltr.DropDownStyle = ComboBoxStyle.DropDownList
        programfltr.Font = New Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        programfltr.ForeColor = Color.Gray
        programfltr.FormattingEnabled = True
        programfltr.Location = New Point(901, 248)
        programfltr.Name = "programfltr"
        programfltr.Size = New Size(505, 38)
        programfltr.TabIndex = 89
        ' 
        ' sectionfltr
        ' 
        sectionfltr.DropDownStyle = ComboBoxStyle.DropDownList
        sectionfltr.Font = New Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        sectionfltr.ForeColor = Color.Gray
        sectionfltr.FormattingEnabled = True
        sectionfltr.Location = New Point(1434, 248)
        sectionfltr.Name = "sectionfltr"
        sectionfltr.Size = New Size(92, 38)
        sectionfltr.TabIndex = 90
        ' 
        ' exitbtn
        ' 
        exitbtn.BackColor = Color.Transparent
        exitbtn.Image = My.Resources.Resources.icons8_log_out_96
        exitbtn.Location = New Point(1684, 34)
        exitbtn.Margin = New Padding(3, 2, 3, 2)
        exitbtn.Name = "exitbtn"
        exitbtn.Size = New Size(114, 103)
        exitbtn.SizeMode = PictureBoxSizeMode.StretchImage
        exitbtn.TabIndex = 92
        exitbtn.TabStop = False
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.Indigo
        btndelete.Image = My.Resources.Resources.icons8_delete_96
        btndelete.Location = New Point(290, 967)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(70, 63)
        btndelete.SizeMode = PictureBoxSizeMode.StretchImage
        btndelete.TabIndex = 95
        btndelete.TabStop = False
        ' 
        ' searchtxt
        ' 
        searchtxt.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        searchtxt.Location = New Point(96, 251)
        searchtxt.Name = "searchtxt"
        searchtxt.Size = New Size(426, 35)
        searchtxt.TabIndex = 73
        ' 
        ' browsebtn
        ' 
        browsebtn.BackColor = Color.Indigo
        browsebtn.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        browsebtn.ForeColor = Color.White
        browsebtn.Location = New Point(1638, 967)
        browsebtn.Margin = New Padding(3, 2, 3, 2)
        browsebtn.Name = "browsebtn"
        browsebtn.Size = New Size(192, 63)
        browsebtn.TabIndex = 96
        browsebtn.Text = "BROWSE"
        browsebtn.UseVisualStyleBackColor = False
        ' 
        ' previewbtn
        ' 
        previewbtn.BackColor = Color.Indigo
        previewbtn.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        previewbtn.ForeColor = Color.White
        previewbtn.Location = New Point(1425, 967)
        previewbtn.Margin = New Padding(3, 2, 3, 2)
        previewbtn.Name = "previewbtn"
        previewbtn.Size = New Size(192, 63)
        previewbtn.TabIndex = 97
        previewbtn.Text = "PREVIEW"
        previewbtn.UseVisualStyleBackColor = False
        ' 
        ' importbtn
        ' 
        importbtn.BackColor = Color.Indigo
        importbtn.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        importbtn.ForeColor = Color.White
        importbtn.Location = New Point(1201, 967)
        importbtn.Margin = New Padding(3, 2, 3, 2)
        importbtn.Name = "importbtn"
        importbtn.Size = New Size(192, 63)
        importbtn.TabIndex = 98
        importbtn.Text = "IMPORT"
        importbtn.UseVisualStyleBackColor = False
        ' 
        ' containerpnl
        ' 
        containerpnl.Controls.Add(previewDGV)
        containerpnl.Location = New Point(46, 303)
        containerpnl.Name = "containerpnl"
        containerpnl.Size = New Size(1800, 641)
        containerpnl.TabIndex = 99
        ' 
        ' previewDGV
        ' 
        previewDGV.AllowUserToAddRows = False
        previewDGV.AllowUserToOrderColumns = True
        previewDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        previewDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        previewDGV.Location = New Point(-3, 0)
        previewDGV.Name = "previewDGV"
        previewDGV.ReadOnly = True
        previewDGV.ScrollBars = ScrollBars.Vertical
        previewDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        previewDGV.Size = New Size(1803, 641)
        previewDGV.TabIndex = 0
        ' 
        ' facultyStudentRecord
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        ClientSize = New Size(1904, 1041)
        Controls.Add(containerpnl)
        Controls.Add(importbtn)
        Controls.Add(previewbtn)
        Controls.Add(browsebtn)
        Controls.Add(btndelete)
        Controls.Add(exitbtn)
        Controls.Add(sectionfltr)
        Controls.Add(programfltr)
        Controls.Add(deptfltr)
        Controls.Add(gradebtn)
        Controls.Add(searchlbl)
        Controls.Add(searchtxt)
        Controls.Add(studDGV)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "facultyStudentRecord"
        Text = "Student Record"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(studDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(exitbtn, ComponentModel.ISupportInitialize).EndInit()
        CType(btndelete, ComponentModel.ISupportInitialize).EndInit()
        containerpnl.ResumeLayout(False)
        CType(previewDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents studDGV As DataGridView
    Friend WithEvents searchlbl As Label
    Friend WithEvents gradebtn As Button
    Friend WithEvents deptfltr As ComboBox
    Friend WithEvents programfltr As ComboBox
    Friend WithEvents sectionfltr As ComboBox
    Friend WithEvents exitbtn As PictureBox
    Friend WithEvents btndelete As PictureBox
    Friend WithEvents searchtxt As TextBox
    Friend WithEvents browsebtn As Button
    Friend WithEvents previewbtn As Button
    Friend WithEvents importbtn As Button
    Friend WithEvents containerpnl As Panel
    Friend WithEvents previewDGV As DataGridView
End Class
