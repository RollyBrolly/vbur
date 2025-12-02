<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmailProgressDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmailProgressDialog))
        progreso = New ProgressBar()
        statuslbl = New Label()
        SuspendLayout()
        ' 
        ' progreso
        ' 
        progreso.Location = New Point(25, 50)
        progreso.Name = "progreso"
        progreso.Size = New Size(350, 25)
        progreso.TabIndex = 0
        ' 
        ' statuslbl
        ' 
        statuslbl.Location = New Point(25, 20)
        statuslbl.Name = "statuslbl"
        statuslbl.Size = New Size(350, 25)
        statuslbl.TabIndex = 1
        statuslbl.Text = "Label1"
        statuslbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' EmailProgressDialog
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(384, 111)
        ControlBox = False
        Controls.Add(statuslbl)
        Controls.Add(progreso)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "EmailProgressDialog"
        StartPosition = FormStartPosition.CenterParent
        Text = "aboutPage"
        ResumeLayout(False)
    End Sub

    Friend WithEvents progreso As ProgressBar
    Friend WithEvents statuslbl As Label
End Class
