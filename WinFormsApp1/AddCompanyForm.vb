Public Class AddCompanyForm


    Private _suppressClosingPrompt As Boolean = False

    Private Sub AddCompanyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub AddCompanyForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If _suppressClosingPrompt Then

            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True
            Return
        End If


        ShowStaffForm()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        If String.IsNullOrWhiteSpace(companyNameBox.Text) OrElse String.IsNullOrWhiteSpace(addressBox.Text) Then
            MessageBox.Show("Please fill out all required fields before adding the company.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        MessageBox.Show("Company added successfully!", "Add Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit? Unsaved changes will be lost. Proceed?", "Confirm Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            _suppressClosingPrompt = True
            ShowStaffForm()
            Me.Close()
        End If
    End Sub

    Private Sub ShowStaffForm()
        For Each f As Form In Application.OpenForms
            If TypeOf f Is StaffRegistrationForm Then
                f.Show()
                f.BringToFront()
                Return
            End If
        Next

        Dim staffForm As New StaffRegistrationForm()
        staffForm.Show()
    End Sub
End Class