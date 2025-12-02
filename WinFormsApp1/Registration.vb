Imports System.Windows.Forms

Public Class Registration
    Private _loginForm As Login

    Public Sub New(loginForm As Login)
        InitializeComponent()
        _loginForm = loginForm
    End Sub
    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub studbtn_Click(sender As Object, e As EventArgs) Handles studbtn.Click
        Dim studentForm As New StudentRegistrationForm(_loginForm, Me)
        studentForm.Show()
        Me.Hide()
    End Sub

    Private Sub faculbtn_Click(sender As Object, e As EventArgs) Handles faculbtn.Click
        Dim tcregistrationForm As New TeacherRegistrationForm(_loginForm, Me)
        tcregistrationForm.Show()
        Me.Hide()
    End Sub

    Private Sub staffbtn_Click(sender As Object, e As EventArgs) Handles staffbtn.Click
        Dim staffregistrationForm As New StaffRegistrationForm(_loginForm, Me)
        staffregistrationForm.Show()
        Me.Hide()
    End Sub

    Private Sub returnbtn_Click(sender As Object, e As EventArgs) Handles returnbtn.Click
        If MessageBox.Show("Are you sure you want to go back to Login?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
            _loginForm.Show()
        End If
    End Sub

End Class
