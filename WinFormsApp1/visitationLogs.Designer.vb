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
        PictureBox5 = New PictureBox()
        Label9 = New Label()
        dgvLogs = New DataGridView()
        btnEditItem = New Button()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        colDate = New DataGridViewTextBoxColumn()
        colTime = New DataGridViewTextBoxColumn()
        Type = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        colPurpose = New DataGridViewTextBoxColumn()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvLogs, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.icons8_book_90
        PictureBox5.Location = New Point(28, 22)
        PictureBox5.Margin = New Padding(3, 2, 3, 2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(73, 71)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 76
        PictureBox5.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Indigo
        Label9.Location = New Point(107, 38)
        Label9.Name = "Label9"
        Label9.Size = New Size(241, 45)
        Label9.TabIndex = 75
        Label9.Text = "Visitation Logs"
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
        dgvLogs.Columns.AddRange(New DataGridViewColumn() {colDate, colTime, Type, Column1, colPurpose})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvLogs.DefaultCellStyle = DataGridViewCellStyle2
        dgvLogs.Location = New Point(37, 134)
        dgvLogs.Name = "dgvLogs"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvLogs.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvLogs.Size = New Size(1183, 795)
        dgvLogs.TabIndex = 77
        ' 
        ' btnEditItem
        ' 
        btnEditItem.BackColor = Color.Indigo
        btnEditItem.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditItem.ForeColor = Color.White
        btnEditItem.Location = New Point(183, 960)
        btnEditItem.Margin = New Padding(3, 2, 3, 2)
        btnEditItem.Name = "btnEditItem"
        btnEditItem.Size = New Size(124, 45)
        btnEditItem.TabIndex = 79
        btnEditItem.Text = "Edit Item"
        btnEditItem.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Indigo
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(37, 960)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(124, 45)
        Button1.TabIndex = 78
        Button1.Text = "Add Item"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.icons8_calendar_100
        PictureBox1.Location = New Point(85, 137)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(38, 34)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 80
        PictureBox1.TabStop = False
        ' 
        ' colDate
        ' 
        colDate.HeaderText = "       Date"
        colDate.Name = "colDate"
        ' 
        ' colTime
        ' 
        colTime.HeaderText = "       Time"
        colTime.Name = "colTime"
        ' 
        ' Type
        ' 
        Type.HeaderText = "       Type"
        Type.Name = "Type"
        Type.Resizable = DataGridViewTriState.True
        Type.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "       Name"
        Column1.Name = "Column1"
        ' 
        ' colPurpose
        ' 
        colPurpose.HeaderText = "       Purpose"
        colPurpose.Name = "colPurpose"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = My.Resources.Resources.icons8_id_100
        PictureBox3.Location = New Point(539, 135)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(38, 37)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 82
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = My.Resources.Resources.icons8_name_90_1_
        PictureBox4.Location = New Point(768, 135)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(38, 37)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 83
        PictureBox4.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.Image = My.Resources.Resources.icons8_help_90
        PictureBox6.Location = New Point(998, 135)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(38, 37)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 84
        PictureBox6.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.icons8_clock_50
        PictureBox2.Location = New Point(310, 135)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(38, 37)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 81
        PictureBox2.TabStop = False
        ' 
        ' visitationLogs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 1041)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(btnEditItem)
        Controls.Add(Button1)
        Controls.Add(dgvLogs)
        Controls.Add(PictureBox5)
        Controls.Add(Label9)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "visitationLogs"
        Text = "Visitation Logs"
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvLogs, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvLogs As DataGridView
    Friend WithEvents btnEditItem As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colTime As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents colPurpose As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
