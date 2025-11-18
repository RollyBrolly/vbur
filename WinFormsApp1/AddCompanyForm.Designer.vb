<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCompanyForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCompanyForm))
        compidtxt = New TextBox()
        compntxt = New TextBox()
        compaddtxt = New TextBox()
        compidlbl = New Label()
        compnlbl = New Label()
        compaddlbl = New Label()
        returnbtm = New Button()
        addcompantbtn = New Button()
        SuspendLayout()
        ' 
        ' compidtxt
        ' 
        compidtxt.BackColor = Color.Silver
        compidtxt.Enabled = False
        compidtxt.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        compidtxt.Location = New Point(41, 82)
        compidtxt.Margin = New Padding(3, 2, 3, 2)
        compidtxt.Name = "compidtxt"
        compidtxt.ReadOnly = True
        compidtxt.Size = New Size(130, 46)
        compidtxt.TabIndex = 65
        ' 
        ' compntxt
        ' 
        compntxt.BackColor = Color.Silver
        compntxt.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        compntxt.Location = New Point(205, 82)
        compntxt.Margin = New Padding(3, 2, 3, 2)
        compntxt.Name = "compntxt"
        compntxt.Size = New Size(283, 46)
        compntxt.TabIndex = 66
        ' 
        ' compaddtxt
        ' 
        compaddtxt.BackColor = Color.Silver
        compaddtxt.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        compaddtxt.Location = New Point(517, 82)
        compaddtxt.Margin = New Padding(3, 2, 3, 2)
        compaddtxt.Name = "compaddtxt"
        compaddtxt.Size = New Size(347, 46)
        compaddtxt.TabIndex = 67
        ' 
        ' compidlbl
        ' 
        compidlbl.AutoSize = True
        compidlbl.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        compidlbl.ForeColor = Color.Indigo
        compidlbl.Location = New Point(41, 35)
        compidlbl.Name = "compidlbl"
        compidlbl.Size = New Size(155, 32)
        compidlbl.TabIndex = 69
        compidlbl.Text = "Company ID"
        ' 
        ' compnlbl
        ' 
        compnlbl.AutoSize = True
        compnlbl.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        compnlbl.ForeColor = Color.Indigo
        compnlbl.Location = New Point(205, 35)
        compnlbl.Name = "compnlbl"
        compnlbl.Size = New Size(196, 32)
        compnlbl.TabIndex = 70
        compnlbl.Text = "Company Name"
        ' 
        ' compaddlbl
        ' 
        compaddlbl.AutoSize = True
        compaddlbl.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        compaddlbl.ForeColor = Color.Indigo
        compaddlbl.Location = New Point(517, 35)
        compaddlbl.Name = "compaddlbl"
        compaddlbl.Size = New Size(221, 32)
        compaddlbl.TabIndex = 71
        compaddlbl.Text = "Company Address"
        ' 
        ' returnbtm
        ' 
        returnbtm.BackColor = Color.LightSlateGray
        returnbtm.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        returnbtm.ForeColor = Color.White
        returnbtm.Location = New Point(627, 160)
        returnbtm.Margin = New Padding(3, 2, 3, 2)
        returnbtm.Name = "returnbtm"
        returnbtm.Size = New Size(111, 50)
        returnbtm.TabIndex = 98
        returnbtm.Text = "RETURN"
        returnbtm.UseVisualStyleBackColor = False
        ' 
        ' addcompantbtn
        ' 
        addcompantbtn.BackColor = Color.Indigo
        addcompantbtn.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addcompantbtn.ForeColor = Color.White
        addcompantbtn.Location = New Point(753, 160)
        addcompantbtn.Margin = New Padding(3, 2, 3, 2)
        addcompantbtn.Name = "addcompantbtn"
        addcompantbtn.Size = New Size(111, 50)
        addcompantbtn.TabIndex = 99
        addcompantbtn.Text = "ADD"
        addcompantbtn.UseVisualStyleBackColor = False
        ' 
        ' AddCompanyForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(911, 221)
        Controls.Add(addcompantbtn)
        Controls.Add(returnbtm)
        Controls.Add(compaddlbl)
        Controls.Add(compnlbl)
        Controls.Add(compidlbl)
        Controls.Add(compaddtxt)
        Controls.Add(compntxt)
        Controls.Add(compidtxt)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "AddCompanyForm"
        Text = "Add Company Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents compidtxt As TextBox
    Friend WithEvents compntxt As TextBox
    Friend WithEvents compaddtxt As TextBox
    Friend WithEvents compidlbl As Label
    Friend WithEvents compnlbl As Label
    Friend WithEvents compaddlbl As Label
    Friend WithEvents returnbtm As Button
    Friend WithEvents addcompantbtn As Button
End Class
