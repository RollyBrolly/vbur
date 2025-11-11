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
        lastnameBox = New TextBox()
        companyNameBox = New TextBox()
        addressBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        ButtonBack = New Button()
        ButtonAdd = New Button()
        SuspendLayout()
        ' 
        ' lastnameBox
        ' 
        lastnameBox.BackColor = Color.Silver
        lastnameBox.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        lastnameBox.Location = New Point(41, 82)
        lastnameBox.Margin = New Padding(3, 2, 3, 2)
        lastnameBox.Name = "lastnameBox"
        lastnameBox.Size = New Size(130, 46)
        lastnameBox.TabIndex = 65
        ' 
        ' companyNameBox
        ' 
        companyNameBox.BackColor = Color.Silver
        companyNameBox.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        companyNameBox.Location = New Point(205, 82)
        companyNameBox.Margin = New Padding(3, 2, 3, 2)
        companyNameBox.Name = "companyNameBox"
        companyNameBox.Size = New Size(283, 46)
        companyNameBox.TabIndex = 66
        ' 
        ' addressBox
        ' 
        addressBox.BackColor = Color.Silver
        addressBox.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold)
        addressBox.Location = New Point(517, 82)
        addressBox.Margin = New Padding(3, 2, 3, 2)
        addressBox.Name = "addressBox"
        addressBox.Size = New Size(347, 46)
        addressBox.TabIndex = 67
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
        ' ButtonBack
        ' 
        ButtonBack.BackColor = Color.LightSlateGray
        ButtonBack.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonBack.ForeColor = Color.White
        ButtonBack.Location = New Point(627, 160)
        ButtonBack.Margin = New Padding(3, 2, 3, 2)
        ButtonBack.Name = "ButtonBack"
        ButtonBack.Size = New Size(111, 50)
        ButtonBack.TabIndex = 98
        ButtonBack.Text = "RETURN"
        ButtonBack.UseVisualStyleBackColor = False
        ' 
        ' ButtonAdd
        ' 
        ButtonAdd.BackColor = Color.Indigo
        ButtonAdd.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonAdd.ForeColor = Color.White
        ButtonAdd.Location = New Point(753, 160)
        ButtonAdd.Margin = New Padding(3, 2, 3, 2)
        ButtonAdd.Name = "ButtonAdd"
        ButtonAdd.Size = New Size(111, 50)
        ButtonAdd.TabIndex = 99
        ButtonAdd.Text = "ADD"
        ButtonAdd.UseVisualStyleBackColor = False
        ' 
        ' AddCompanyForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(911, 221)
        Controls.Add(ButtonAdd)
        Controls.Add(ButtonBack)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(addressBox)
        Controls.Add(companyNameBox)
        Controls.Add(lastnameBox)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "AddCompanyForm"
        Text = "Add Company Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lastnameBox As TextBox
    Friend WithEvents companyNameBox As TextBox
    Friend WithEvents addressBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonBack As Button
    Friend WithEvents ButtonAdd As Button
End Class
