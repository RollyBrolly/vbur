<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class studentDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentDashboard))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        Button3 = New Button()
        PictureBox2 = New PictureBox()
        Button1 = New Button()
        Label2 = New Label()
        Panel2 = New Panel()
        PictureBox3 = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        Panel3 = New Panel()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Button2 = New Button()
        ColorDialog1 = New ColorDialog()
        Panel4 = New Panel()
        CheckBox4 = New CheckBox()
        Label8 = New Label()
        CheckBox5 = New CheckBox()
        PictureBox4 = New PictureBox()
        CheckBox6 = New CheckBox()
        Panel5 = New Panel()
        Button4 = New Button()
        PictureBox5 = New PictureBox()
        Label9 = New Label()
        Panel6 = New Panel()
        Button5 = New Button()
        PictureBox6 = New PictureBox()
        Label10 = New Label()
        PictureBox7 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.studentdashboardHeader3
        PictureBox1.Location = New Point(-2, 1)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1928, 180)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 64
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(749, 196)
        Label1.Name = "Label1"
        Label1.Size = New Size(420, 45)
        Label1.TabIndex = 65
        Label1.Text = "Welcome [Student Name]"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(687, 670)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(546, 380)
        Panel1.TabIndex = 66
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Indigo
        Button3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(281, 301)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(222, 61)
        Button3.TabIndex = 72
        Button3.Text = "Complete Tasks"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.icons8_tasks_48
        PictureBox2.Location = New Point(15, 22)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(69, 71)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 67
        PictureBox2.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Indigo
        Button1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(38, 301)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(155, 61)
        Button1.TabIndex = 68
        Button1.Text = "Add Tasks"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Indigo
        Label2.Location = New Point(77, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(231, 45)
        Label2.TabIndex = 67
        Label2.Text = "Pending Tasks"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(686, 261)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(546, 380)
        Panel2.TabIndex = 67
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.hours_line_graph
        PictureBox3.Location = New Point(34, 79)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(470, 299)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 74
        PictureBox3.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(63, 50)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 21)
        Label4.TabIndex = 73
        Label4.Text = "Total Hours: 450"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Indigo
        Label3.Location = New Point(53, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(175, 32)
        Label3.TabIndex = 72
        Label3.Text = "Hours Logged"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Button2)
        Panel3.Location = New Point(113, 262)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(546, 380)
        Panel3.TabIndex = 68
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold)
        Label7.Location = New Point(41, 308)
        Label7.Name = "Label7"
        Label7.Size = New Size(472, 47)
        Label7.TabIndex = 3
        Label7.Text = "October 29, 2025 - 5:01 PM"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold)
        Label6.Location = New Point(144, 251)
        Label6.Name = "Label6"
        Label6.Size = New Size(259, 47)
        Label6.TabIndex = 2
        Label6.Text = "Last Time Out:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 32.25F, FontStyle.Bold)
        Label5.Location = New Point(31, 64)
        Label5.Name = "Label5"
        Label5.Size = New Size(471, 59)
        Label5.TabIndex = 1
        Label5.Text = "Time Today: 12:30 PM"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Indigo
        Button2.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(172, 146)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(207, 87)
        Button2.TabIndex = 0
        Button2.Text = "TIME IN"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(CheckBox4)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(CheckBox5)
        Panel4.Controls.Add(PictureBox4)
        Panel4.Controls.Add(CheckBox6)
        Panel4.Location = New Point(113, 670)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(546, 380)
        Panel4.TabIndex = 69
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        CheckBox4.ForeColor = Color.Indigo
        CheckBox4.Location = New Point(41, 301)
        CheckBox4.Margin = New Padding(3, 2, 3, 2)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(421, 49)
        CheckBox4.TabIndex = 75
        CheckBox4.Text = "Coffee Machine is broken"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Indigo
        Label8.Location = New Point(92, 36)
        Label8.Name = "Label8"
        Label8.Size = New Size(287, 47)
        Label8.TabIndex = 74
        Label8.Text = "Announcements"
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        CheckBox5.ForeColor = Color.Indigo
        CheckBox5.Location = New Point(41, 214)
        CheckBox5.Margin = New Padding(3, 2, 3, 2)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(326, 49)
        CheckBox5.TabIndex = 74
        CheckBox5.Text = "Meeting tomorrow"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.icons8_announcement_90
        PictureBox4.Location = New Point(17, 22)
        PictureBox4.Margin = New Padding(3, 2, 3, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(69, 71)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 73
        PictureBox4.TabStop = False
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        CheckBox6.ForeColor = Color.Indigo
        CheckBox6.Location = New Point(41, 130)
        CheckBox6.Margin = New Padding(3, 2, 3, 2)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(433, 49)
        CheckBox6.TabIndex = 73
        CheckBox6.Text = "Company Event at 3:00PM"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(Button4)
        Panel5.Controls.Add(PictureBox5)
        Panel5.Controls.Add(Label9)
        Panel5.Location = New Point(1252, 262)
        Panel5.Margin = New Padding(3, 2, 3, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(546, 380)
        Panel5.TabIndex = 73
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Indigo
        Button4.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(35, 158)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(474, 87)
        Button4.TabIndex = 4
        Button4.Text = "VIEW YOUR SCHEDULE"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.icons8_schedule_96
        PictureBox5.Location = New Point(15, 22)
        PictureBox5.Margin = New Padding(3, 2, 3, 2)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(73, 71)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 67
        PictureBox5.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Indigo
        Label9.Location = New Point(94, 38)
        Label9.Name = "Label9"
        Label9.Size = New Size(154, 45)
        Label9.TabIndex = 67
        Label9.Text = "Schedule"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(Button5)
        Panel6.Controls.Add(PictureBox6)
        Panel6.Controls.Add(Label10)
        Panel6.Location = New Point(1252, 670)
        Panel6.Margin = New Padding(3, 2, 3, 2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(546, 380)
        Panel6.TabIndex = 74
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Indigo
        Button5.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.White
        Button5.Location = New Point(35, 165)
        Button5.Margin = New Padding(3, 2, 3, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(474, 87)
        Button5.TabIndex = 68
        Button5.Text = " VIEW GRADES AND EVALUATION"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.icons8_rating_52
        PictureBox6.Location = New Point(23, 27)
        PictureBox6.Margin = New Padding(3, 2, 3, 2)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(56, 55)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 68
        PictureBox6.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Indigo
        Label10.Location = New Point(85, 31)
        Label10.Name = "Label10"
        Label10.Size = New Size(188, 45)
        Label10.TabIndex = 67
        Label10.Text = "Evalutation"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.Image = My.Resources.Resources.icons8_log_out_96
        PictureBox7.Location = New Point(1684, 34)
        PictureBox7.Margin = New Padding(3, 2, 3, 2)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(114, 103)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 68
        PictureBox7.TabStop = False
        ' 
        ' studentDashboard
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.DarkGray
        ClientSize = New Size(1904, 1041)
        Controls.Add(PictureBox7)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "studentDashboard"
        Text = "Dashboard"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
