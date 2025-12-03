<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class visitationLogs
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(visitationLogs))
        dgvLogs = New DataGridView()
        addbtn = New Button()
        returnbtn = New Button()
        PictureBox1 = New PictureBox()
        logoutbtn = New PictureBox()
        CType(dgvLogs, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(logoutbtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvLogs
        ' 
        dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = Color.Indigo
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvLogs.DefaultCellStyle = DataGridViewCellStyle2
        dgvLogs.Location = New Point(37, 251)
        dgvLogs.Name = "dgvLogs"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvLogs.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvLogs.Size = New Size(1819, 678)
        dgvLogs.TabIndex = 77
        ' 
        ' addbtn
        ' 
        addbtn.BackColor = Color.Indigo
        addbtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addbtn.ForeColor = Color.White
        addbtn.Location = New Point(37, 960)
        addbtn.Margin = New Padding(3, 2, 3, 2)
        addbtn.Name = "addbtn"
        addbtn.Size = New Size(124, 45)
        addbtn.TabIndex = 78
        addbtn.Text = "Add Item"
        addbtn.UseVisualStyleBackColor = False
        ' 
        ' returnbtn
        ' 
        returnbtn.BackColor = Color.Indigo
        returnbtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        returnbtn.ForeColor = Color.White
        returnbtn.Location = New Point(189, 960)
        returnbtn.Margin = New Padding(3, 2, 3, 2)
        returnbtn.Name = "returnbtn"
        returnbtn.Size = New Size(124, 45)
        returnbtn.TabIndex = 80
        returnbtn.Text = "Return"
        returnbtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.image_2025_12_03_105246110
        PictureBox1.Location = New Point(-6, -5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1928, 180)
        PictureBox1.TabIndex = 97
        PictureBox1.TabStop = False
        ' 
        ' logoutbtn
        ' 
        logoutbtn.BackColor = Color.DarkGray
        logoutbtn.Image = My.Resources.Resources.icons8_log_out_96
        logoutbtn.Location = New Point(1742, 29)
        logoutbtn.Margin = New Padding(3, 2, 3, 2)
        logoutbtn.Name = "logoutbtn"
        logoutbtn.Size = New Size(114, 103)
        logoutbtn.SizeMode = PictureBoxSizeMode.StretchImage
        logoutbtn.TabIndex = 98
        logoutbtn.TabStop = False
        ' 
        ' visitationLogs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1904, 1041)
        Controls.Add(logoutbtn)
        Controls.Add(PictureBox1)
        Controls.Add(returnbtn)
        Controls.Add(addbtn)
        Controls.Add(dgvLogs)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "visitationLogs"
        Text = "Visitation Logs"
        CType(dgvLogs, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(logoutbtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents dgvLogs As DataGridView
    Friend WithEvents addbtn As Button
    Friend WithEvents returnbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents logoutbtn As PictureBox
End Class
