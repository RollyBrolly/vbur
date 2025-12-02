Public Class EmailProgressDialog
    Inherits Form

    Private progressLabel As Label
    Private progressBar As ProgressBar
    Private overlayPanel As Panel
    Private ReadOnly cornerRadius As Integer = 15 ' Rounded corners

    Public Sub New(parent As Form)
        ' --- Form Properties ---
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Size = New Size(400, 120)
        Me.StartPosition = FormStartPosition.Manual
        Me.BackColor = Color.FromArgb(35, 35, 35)
        Me.ShowInTaskbar = False
        Me.TopMost = True

        ' --- Center manually on parent ---
        Me.Location = New Point(
            parent.Location.X + (parent.Width - Me.Width) \ 2,
            parent.Location.Y + (parent.Height - Me.Height) \ 2
        )

        ' --- Overlay Panel ---
        overlayPanel = New Panel() With {
            .Dock = DockStyle.Fill,
            .BackColor = Color.FromArgb(50, 50, 50),
            .Padding = New Padding(15)
        }
        Me.Controls.Add(overlayPanel)

        ' --- Progress Label ---
        progressLabel = New Label() With {
            .Text = "Starting...",
            .AutoSize = False,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Dock = DockStyle.Top,
            .Height = 40,
            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
            .ForeColor = Color.White
        }
        overlayPanel.Controls.Add(progressLabel)

        ' --- Progress Bar ---
        progressBar = New ProgressBar() With {
            .Minimum = 0,
            .Maximum = 100,
            .Value = 0,
            .Dock = DockStyle.Bottom,
            .Height = 25,
            .ForeColor = Color.FromArgb(0, 150, 136),
            .Style = ProgressBarStyle.Continuous
        }
        overlayPanel.Controls.Add(progressBar)

        ' --- Set form region for rounded corners ---
        Me.Region = CreateRoundRectRegion(New Rectangle(0, 0, Me.Width, Me.Height), cornerRadius)
    End Sub

    Public Sub UpdateProgress(value As Integer, status As String)
        If value > 100 Then value = 100
        progressBar.Value = value
        progressLabel.Text = status
        Me.Refresh()
        Application.DoEvents()
    End Sub

    ' --- Rounded Rectangle Region ---
    Private Function CreateRoundRectRegion(rect As Rectangle, radius As Integer) As Drawing.Region
        Dim path As New Drawing.Drawing2D.GraphicsPath()
        path.StartFigure()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()
        Return New Drawing.Region(path)
    End Function

    ' --- Optional: subtle shadow effect on paint ---
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Using shadowBrush As New SolidBrush(Color.FromArgb(60, 0, 0, 0))
            e.Graphics.FillRectangle(shadowBrush, 2, 2, Me.Width - 4, Me.Height - 4)
        End Using
    End Sub
End Class
