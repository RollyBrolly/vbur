<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class internsView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(internsView))
        PictureBox1 = New PictureBox()
        sectionfltr = New ComboBox()
        programfltr = New ComboBox()
        deptfltr = New ComboBox()
        savebtn = New Button()
        internDGV = New DataGridView()
        btndelete = New PictureBox()
        searchtxt = New TextBox()
        searchlbl = New Label()
        returnbtn = New PictureBox()
        compnamecb = New ComboBox()
        statuscb = New ComboBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(internDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(btndelete, ComponentModel.ISupportInitialize).BeginInit()
        CType(returnbtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.supervisorviewinterns
        PictureBox1.Location = New Point(-2, 0)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1928, 180)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 94
        PictureBox1.TabStop = False
        ' 
        ' sectionfltr
        ' 
        sectionfltr.Font = New Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        sectionfltr.ForeColor = Color.Gray
        sectionfltr.FormattingEnabled = True
        sectionfltr.Location = New Point(1299, 228)
        sectionfltr.Name = "sectionfltr"
        sectionfltr.Size = New Size(142, 38)
        sectionfltr.TabIndex = 117
        sectionfltr.Text = "Filter Section"
        ' 
        ' programfltr
        ' 
        programfltr.Font = New Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        programfltr.ForeColor = Color.Gray
        programfltr.FormattingEnabled = True
        programfltr.Location = New Point(974, 228)
        programfltr.Name = "programfltr"
        programfltr.Size = New Size(309, 38)
        programfltr.TabIndex = 116
        programfltr.Text = "Filter Program"
        ' 
        ' deptfltr
        ' 
        deptfltr.Font = New Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        deptfltr.ForeColor = Color.Gray
        deptfltr.FormattingEnabled = True
        deptfltr.Location = New Point(537, 228)
        deptfltr.Name = "deptfltr"
        deptfltr.Size = New Size(419, 38)
        deptfltr.TabIndex = 115
        deptfltr.Text = "Filter Department"
        ' 
        ' savebtn
        ' 
        savebtn.BackColor = Color.Indigo
        savebtn.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        savebtn.ForeColor = Color.White
        savebtn.Location = New Point(78, 967)
        savebtn.Margin = New Padding(3, 2, 3, 2)
        savebtn.Name = "savebtn"
        savebtn.Size = New Size(192, 63)
        savebtn.TabIndex = 110
        savebtn.Text = "EVALUATE"
        savebtn.UseVisualStyleBackColor = False
        ' 
        ' internDGV
        ' 
        internDGV.AllowUserToOrderColumns = True
        internDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        internDGV.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Indigo
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        internDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        internDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        internDGV.DefaultCellStyle = DataGridViewCellStyle2
        internDGV.Location = New Point(36, 289)
        internDGV.Name = "internDGV"
        internDGV.ReadOnly = True
        internDGV.ScrollBars = ScrollBars.Vertical
        internDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        internDGV.Size = New Size(1832, 653)
        internDGV.TabIndex = 96
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.Indigo
        btndelete.Image = My.Resources.Resources.icons8_delete_96
        btndelete.Location = New Point(318, 966)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(70, 63)
        btndelete.SizeMode = PictureBoxSizeMode.StretchImage
        btndelete.TabIndex = 120
        btndelete.TabStop = False
        ' 
        ' searchtxt
        ' 
        searchtxt.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        searchtxt.Location = New Point(163, 230)
        searchtxt.Name = "searchtxt"
        searchtxt.Size = New Size(357, 35)
        searchtxt.TabIndex = 101
        ' 
        ' searchlbl
        ' 
        searchlbl.AutoSize = True
        searchlbl.BackColor = Color.Transparent
        searchlbl.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        searchlbl.ForeColor = Color.White
        searchlbl.Location = New Point(163, 191)
        searchlbl.Name = "searchlbl"
        searchlbl.Size = New Size(156, 37)
        searchlbl.TabIndex = 102
        searchlbl.Text = "First Name"
        ' 
        ' returnbtn
        ' 
        returnbtn.BackColor = Color.Transparent
        returnbtn.Image = My.Resources.Resources.icons8_log_out_96
        returnbtn.Location = New Point(1684, 34)
        returnbtn.Margin = New Padding(3, 2, 3, 2)
        returnbtn.Name = "returnbtn"
        returnbtn.Size = New Size(114, 103)
        returnbtn.SizeMode = PictureBoxSizeMode.StretchImage
        returnbtn.TabIndex = 121
        returnbtn.TabStop = False
        ' 
        ' compnamecb
        ' 
        compnamecb.Font = New Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        compnamecb.ForeColor = Color.Gray
        compnamecb.FormattingEnabled = True
        compnamecb.Location = New Point(1464, 228)
        compnamecb.Name = "compnamecb"
        compnamecb.Size = New Size(256, 38)
        compnamecb.TabIndex = 122
        compnamecb.Text = "companyname"
        ' 
        ' statuscb
        ' 
        statuscb.Font = New Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        statuscb.ForeColor = Color.Gray
        statuscb.FormattingEnabled = True
        statuscb.Location = New Point(1726, 228)
        statuscb.Name = "statuscb"
        statuscb.Size = New Size(142, 38)
        statuscb.TabIndex = 123
        statuscb.Text = "status"
        ' 
        ' internsView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        ClientSize = New Size(1904, 1041)
        Controls.Add(statuscb)
        Controls.Add(compnamecb)
        Controls.Add(returnbtn)
        Controls.Add(btndelete)
        Controls.Add(sectionfltr)
        Controls.Add(programfltr)
        Controls.Add(deptfltr)
        Controls.Add(savebtn)
        Controls.Add(searchlbl)
        Controls.Add(searchtxt)
        Controls.Add(internDGV)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "internsView"
        Text = "internsView"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(internDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(btndelete, ComponentModel.ISupportInitialize).EndInit()
        CType(returnbtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents sectionfltr As ComboBox
    Friend WithEvents programfltr As ComboBox
    Friend WithEvents deptfltr As ComboBox
    Friend WithEvents savebtn As Button
    Friend WithEvents internDGV As DataGridView
    Friend WithEvents btndelete As PictureBox
    Friend WithEvents searchtxt As TextBox
    Friend WithEvents searchlbl As Label
    Friend WithEvents returnbtn As PictureBox
    Friend WithEvents compnamecb As ComboBox
    Friend WithEvents statuscb As ComboBox

End Class
