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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(visitationLogs))
        PictureBox5 = New PictureBox()
        Label9 = New Label()
        dgvLogs = New DataGridView()
        colDate = New DataGridViewTextBoxColumn()
        colTime = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        colPurpose = New DataGridViewTextBoxColumn()
        btnEditItem = New Button()
        Button1 = New Button()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvLogs, ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLogs.Columns.AddRange(New DataGridViewColumn() {colDate, colTime, Column1, colPurpose})
        dgvLogs.Location = New Point(37, 134)
        dgvLogs.Name = "dgvLogs"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvLogs.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvLogs.Size = New Size(1183, 795)
        dgvLogs.TabIndex = 77
        ' 
        ' colDate
        ' 
        colDate.HeaderText = "Date"
        colDate.Name = "colDate"
        ' 
        ' colTime
        ' 
        colTime.HeaderText = "Time"
        colTime.Name = "colTime"
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Name"
        Column1.Name = "Column1"
        ' 
        ' colPurpose
        ' 
        colPurpose.HeaderText = "Purpose"
        colPurpose.Name = "colPurpose"
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
        ' visitationLogs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 1041)
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
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvLogs As DataGridView
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colTime As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents colPurpose As DataGridViewTextBoxColumn
    Friend WithEvents btnEditItem As Button
    Friend WithEvents Button1 As Button
End Class
