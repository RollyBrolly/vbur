<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scheduleForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scheduleForm))
        PictureBox5 = New PictureBox()
        Label9 = New Label()
        dgvSchedule = New DataGridView()
        Time = New DataGridViewTextBoxColumn()
        Monday = New DataGridViewTextBoxColumn()
        Tuesday = New DataGridViewTextBoxColumn()
        Wednesday = New DataGridViewTextBoxColumn()
        Thursday = New DataGridViewTextBoxColumn()
        Friday = New DataGridViewTextBoxColumn()
        Saturday = New DataGridViewTextBoxColumn()
        Sunday = New DataGridViewTextBoxColumn()
        btnAddItem = New Button()
        btnEditItem = New Button()
        btnDeleteItem = New Button()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvSchedule, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.icons8_schedule_96
        PictureBox5.Location = New Point(18, 20)
        PictureBox5.Margin = New Padding(3, 2, 3, 2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(73, 71)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 68
        PictureBox5.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Indigo
        Label9.Location = New Point(97, 30)
        Label9.Name = "Label9"
        Label9.Size = New Size(154, 45)
        Label9.TabIndex = 69
        Label9.Text = "Schedule"
        ' 
        ' dgvSchedule
        ' 
        dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSchedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvSchedule.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSchedule.Columns.AddRange(New DataGridViewColumn() {Time, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvSchedule.DefaultCellStyle = DataGridViewCellStyle2
        dgvSchedule.Location = New Point(31, 105)
        dgvSchedule.Name = "dgvSchedule"
        dgvSchedule.ReadOnly = True
        dgvSchedule.Size = New Size(1204, 396)
        dgvSchedule.TabIndex = 70
        ' 
        ' Time
        ' 
        Time.HeaderText = "Time"
        Time.Name = "Time"
        Time.ReadOnly = True
        ' 
        ' Monday
        ' 
        Monday.HeaderText = "Monday"
        Monday.Name = "Monday"
        Monday.ReadOnly = True
        ' 
        ' Tuesday
        ' 
        Tuesday.HeaderText = "Tuesday"
        Tuesday.Name = "Tuesday"
        Tuesday.ReadOnly = True
        ' 
        ' Wednesday
        ' 
        Wednesday.HeaderText = "Wednesday"
        Wednesday.Name = "Wednesday"
        Wednesday.ReadOnly = True
        ' 
        ' Thursday
        ' 
        Thursday.HeaderText = "Thursday"
        Thursday.Name = "Thursday"
        Thursday.ReadOnly = True
        ' 
        ' Friday
        ' 
        Friday.HeaderText = "Friday"
        Friday.Name = "Friday"
        Friday.ReadOnly = True
        ' 
        ' Saturday
        ' 
        Saturday.HeaderText = "Saturday"
        Saturday.Name = "Saturday"
        Saturday.ReadOnly = True
        ' 
        ' Sunday
        ' 
        Sunday.HeaderText = "Sunday"
        Sunday.Name = "Sunday"
        Sunday.ReadOnly = True
        ' 
        ' btnAddItem
        ' 
        btnAddItem.BackColor = Color.Indigo
        btnAddItem.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddItem.ForeColor = Color.White
        btnAddItem.Location = New Point(31, 516)
        btnAddItem.Margin = New Padding(3, 2, 3, 2)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(124, 45)
        btnAddItem.TabIndex = 74
        btnAddItem.Text = "Add Item"
        btnAddItem.UseVisualStyleBackColor = False
        ' 
        ' btnEditItem
        ' 
        btnEditItem.BackColor = Color.Indigo
        btnEditItem.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditItem.ForeColor = Color.White
        btnEditItem.Location = New Point(177, 516)
        btnEditItem.Margin = New Padding(3, 2, 3, 2)
        btnEditItem.Name = "btnEditItem"
        btnEditItem.Size = New Size(124, 45)
        btnEditItem.TabIndex = 75
        btnEditItem.Text = "Edit Item"
        btnEditItem.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteItem
        ' 
        btnDeleteItem.BackColor = Color.Indigo
        btnDeleteItem.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteItem.ForeColor = Color.White
        btnDeleteItem.Location = New Point(326, 516)
        btnDeleteItem.Margin = New Padding(3, 2, 3, 2)
        btnDeleteItem.Name = "btnDeleteItem"
        btnDeleteItem.Size = New Size(124, 45)
        btnDeleteItem.TabIndex = 76
        btnDeleteItem.Text = "Delete Item"
        btnDeleteItem.UseVisualStyleBackColor = False
        ' 
        ' studentScheduleForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 575)
        Controls.Add(btnDeleteItem)
        Controls.Add(btnEditItem)
        Controls.Add(btnAddItem)
        Controls.Add(dgvSchedule)
        Controls.Add(PictureBox5)
        Controls.Add(Label9)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "studentScheduleForm"
        Text = "Student Schedule Form"
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvSchedule, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvSchedule As DataGridView
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnEditItem As Button
    Friend WithEvents btnDeleteItem As Button
    Friend WithEvents Time As DataGridViewTextBoxColumn
    Friend WithEvents Monday As DataGridViewTextBoxColumn
    Friend WithEvents Tuesday As DataGridViewTextBoxColumn
    Friend WithEvents Wednesday As DataGridViewTextBoxColumn
    Friend WithEvents Thursday As DataGridViewTextBoxColumn
    Friend WithEvents Friday As DataGridViewTextBoxColumn
    Friend WithEvents Saturday As DataGridViewTextBoxColumn
    Friend WithEvents Sunday As DataGridViewTextBoxColumn
End Class
