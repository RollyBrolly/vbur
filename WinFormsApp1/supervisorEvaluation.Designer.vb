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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(supervisorEvaluation))
        savebtn = New Button()
        evalDGV = New DataGridView()
        PictureBox1 = New PictureBox()
        logoutbtn = New PictureBox()
        Label1 = New Label()
        CType(evalDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(logoutbtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' savebtn
        ' 
        savebtn.BackColor = Color.Indigo
        savebtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        savebtn.ForeColor = Color.White
        savebtn.Location = New Point(24, 985)
        savebtn.Margin = New Padding(3, 2, 3, 2)
        savebtn.Name = "savebtn"
        savebtn.Size = New Size(124, 45)
        savebtn.TabIndex = 76
        savebtn.Text = "Save"
        savebtn.UseVisualStyleBackColor = False
        ' 
        ' evalDGV
        ' 
        evalDGV.AllowUserToAddRows = False
        evalDGV.AllowUserToOrderColumns = True
        evalDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        evalDGV.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Indigo
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        evalDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        evalDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        evalDGV.DefaultCellStyle = DataGridViewCellStyle2
        evalDGV.Location = New Point(12, 295)
        evalDGV.Name = "evalDGV"
        evalDGV.RowHeadersVisible = False
        evalDGV.ScrollBars = ScrollBars.Vertical
        evalDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        evalDGV.Size = New Size(1891, 676)
        evalDGV.TabIndex = 95
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.evalInternsheader
        PictureBox1.Location = New Point(-12, -4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1928, 180)
        PictureBox1.TabIndex = 96
        PictureBox1.TabStop = False
        ' 
        ' logoutbtn
        ' 
        logoutbtn.BackColor = Color.Transparent
        logoutbtn.Image = My.Resources.Resources.icons8_log_out_96
        logoutbtn.Location = New Point(1749, 33)
        logoutbtn.Margin = New Padding(3, 2, 3, 2)
        logoutbtn.Name = "logoutbtn"
        logoutbtn.Size = New Size(114, 103)
        logoutbtn.SizeMode = PictureBoxSizeMode.StretchImage
        logoutbtn.TabIndex = 97
        logoutbtn.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(157, 218)
        Label1.Name = "Label1"
        Label1.Size = New Size(1706, 47)
        Label1.TabIndex = 98
        Label1.Text = "5 – Outstanding (O)    4 – Very Satisfactory (VS)    3 – Satisfactory (S)    2 – Needs Improvement (NI)   1 – Unacceptable (U)"
        ' 
        ' supervisorEvaluation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        ClientSize = New Size(1904, 1041)
        Controls.Add(Label1)
        Controls.Add(logoutbtn)
        Controls.Add(PictureBox1)
        Controls.Add(evalDGV)
        Controls.Add(savebtn)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "supervisorEvaluation"
        Text = "Evaluation Form"
        CType(evalDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(logoutbtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents savebtn As Button
    Friend WithEvents evalDGV As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents logoutbtn As PictureBox
    Friend WithEvents Label1 As Label
End Class
