<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supervisorEvaluation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(supervisorEvaluation))
        PictureBox6 = New PictureBox()
        Label10 = New Label()
        DataGridView1 = New DataGridView()
        colStudNo = New DataGridViewTextBoxColumn()
        colLastName = New DataGridViewTextBoxColumn()
        colFirstName = New DataGridViewTextBoxColumn()
        colDept = New DataGridViewTextBoxColumn()
        colCourse = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        btnEditItem = New Button()
        btnAddItem = New Button()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.icons8_rating_52
        PictureBox6.Location = New Point(24, 23)
        PictureBox6.Margin = New Padding(3, 2, 3, 2)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(56, 55)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 70
        PictureBox6.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Indigo
        Label10.Location = New Point(86, 27)
        Label10.Name = "Label10"
        Label10.Size = New Size(188, 45)
        Label10.TabIndex = 69
        Label10.Text = "Evalutation"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {colStudNo, colLastName, colFirstName, colDept, colCourse, colStatus})
        DataGridView1.Location = New Point(76, 127)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1733, 150)
        DataGridView1.TabIndex = 71
        ' 
        ' colStudNo
        ' 
        colStudNo.HeaderText = "Student Number"
        colStudNo.Name = "colStudNo"
        ' 
        ' colLastName
        ' 
        colLastName.HeaderText = "Last Name"
        colLastName.Name = "colLastName"
        ' 
        ' colFirstName
        ' 
        colFirstName.HeaderText = "First Name"
        colFirstName.Name = "colFirstName"
        ' 
        ' colDept
        ' 
        colDept.HeaderText = "Department"
        colDept.Name = "colDept"
        ' 
        ' colCourse
        ' 
        colCourse.HeaderText = "Course"
        colCourse.Name = "colCourse"
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.Name = "colStatus"
        ' 
        ' btnEditItem
        ' 
        btnEditItem.BackColor = Color.Indigo
        btnEditItem.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditItem.ForeColor = Color.White
        btnEditItem.Location = New Point(170, 967)
        btnEditItem.Margin = New Padding(3, 2, 3, 2)
        btnEditItem.Name = "btnEditItem"
        btnEditItem.Size = New Size(124, 45)
        btnEditItem.TabIndex = 77
        btnEditItem.Text = "Edit Item"
        btnEditItem.UseVisualStyleBackColor = False
        ' 
        ' btnAddItem
        ' 
        btnAddItem.BackColor = Color.Indigo
        btnAddItem.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddItem.ForeColor = Color.White
        btnAddItem.Location = New Point(24, 967)
        btnAddItem.Margin = New Padding(3, 2, 3, 2)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(124, 45)
        btnAddItem.TabIndex = 76
        btnAddItem.Text = "Add Item"
        btnAddItem.UseVisualStyleBackColor = False
        ' 
        ' supervisorEvaluation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1904, 1041)
        Controls.Add(btnEditItem)
        Controls.Add(btnAddItem)
        Controls.Add(DataGridView1)
        Controls.Add(PictureBox6)
        Controls.Add(Label10)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "supervisorEvaluation"
        Text = "Evaluation Form"
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents colStudNo As DataGridViewTextBoxColumn
    Friend WithEvents colLastName As DataGridViewTextBoxColumn
    Friend WithEvents colFirstName As DataGridViewTextBoxColumn
    Friend WithEvents colDept As DataGridViewTextBoxColumn
    Friend WithEvents colCourse As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents btnEditItem As Button
    Friend WithEvents btnAddItem As Button
End Class
