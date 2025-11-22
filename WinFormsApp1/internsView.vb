Public Class internsView
    Private Sub internsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If String.IsNullOrWhiteSpace(deptcbbox.Text) OrElse
         String.IsNullOrWhiteSpace(programcbbox.Text) OrElse
         String.IsNullOrWhiteSpace(sectioncbbox.Text) OrElse
            String.IsNullOrWhiteSpace(surnametxtbox.Text) Then
            MessageBox.Show("Please fill all selections.")
            Exit Sub
        End If

        DataGridView1.Rows.Add(
            internidtxtbox.Text,
            surnametxtbox.Text,
            firstnametxtbox.Text,
            midnametxtbox.Text,
            genderccbox.Text,
            deptcbbox.Text,
            programcbbox.Text,
            sectioncbbox.Text
        )

        internidtxtbox.Clear()
        surnametxtbox.Clear()
        firstnametxtbox.Clear()
        midnametxtbox.Clear()
        genderccbox.SelectedIndex = -1
        deptcbbox.SelectedIndex = -1
        programcbbox.SelectedIndex = -1
        sectioncbbox.SelectedIndex = -1
        programcbbox.Enabled = False
        sectioncbbox.Enabled = False

        MessageBox.Show("Intern added successfully!", "Intern Addition Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim result As DialogResult = MessageBox.Show("Return to dashboard?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim dashboard As New facultyDashboard()
            dashboard.Show()
            Me.Hide()
        End If
    End Sub
End Class