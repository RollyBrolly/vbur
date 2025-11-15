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
        lnametxtbox = New TextBox()
        companynametxtbx = New TextBox()
        addresstxtbox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        returnbtm = New Button()
        addcompantbtn = New Button()
        SuspendLayout()
        ' 
        ' lnametxtbox
        ' 
        lnametxtbox.BackColor = Color.Silver
        lnametxtbox.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        lnametxtbox.Location = New Point(41, 82)
        lnametxtbox.Margin = New Padding(3, 2, 3, 2)
        lnametxtbox.Name = "lnametxtbox"
        lnametxtbox.Size = New Size(130, 46)
        lnametxtbox.TabIndex = 65
        ' 
        ' companynametxtbx
        ' 
        companynametxtbx.BackColor = Color.Silver
        companynametxtbx.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        companynametxtbx.Location = New Point(205, 82)
        companynametxtbx.Margin = New Padding(3, 2, 3, 2)
        companynametxtbx.Name = "companynametxtbx"
        companynametxtbx.Size = New Size(283, 46)
        companynametxtbx.TabIndex = 66
        ' 
        ' addresstxtbox
        ' 
        addresstxtbox.BackColor = Color.Silver
        addresstxtbox.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        addresstxtbox.Location = New Point(517, 82)
        addresstxtbox.Margin = New Padding(3, 2, 3, 2)
        addresstxtbox.Name = "addresstxtbox"
        addresstxtbox.Size = New Size(347, 46)
        addresstxtbox.TabIndex = 67
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Indigo
        Label1.Location = New Point(41, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 32)
        Label1.TabIndex = 69
        Label1.Text = "Company ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Indigo
        Label2.Location = New Point(205, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(196, 32)
        Label2.TabIndex = 70
        Label2.Text = "Company Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Indigo
        Label3.Location = New Point(517, 35)
        Label3.Name = "Label3"
        Label3.Size = New Size(221, 32)
        Label3.TabIndex = 71
        Label3.Text = "Company Address"
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
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(addresstxtbox)
        Controls.Add(companynametxtbx)
        Controls.Add(lnametxtbox)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "AddCompanyForm"
        Text = "Add Company Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lnametxtbox As TextBox
    Friend WithEvents companynametxtbx As TextBox
    Friend WithEvents addresstxtbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents returnbtm As Button
    Friend WithEvents addcompantbtn As Button
End Class
