Imports System.Windows.Forms.VisualStyles

Public Class StudentRegistrationForm

    Private ReadOnly departmentCourses As New Dictionary(Of String, List(Of String)) From {
        {"COLLEGE OF COMPUTER STUDIES", New List(Of String) From {
            "Bachelor of Science in Information Technology",
            "Bachelor of Science in Computer Science"
        }},
        {"COLLEGE OF EDUCATION", New List(Of String) From {
            "Bachelor of Secondary Education - English",
            "Bachelor of Secondary Education - Math",
            "Bachelor of Elementary Education - Filipino"
        }},
        {"COLLEGE OF BUSINESS ADMINISTRATION", New List(Of String) From {
            "Bachelor of Science in Marketing Management",
            "Bachelor of Science in Human Resource Management"
        }},
        {"COLLEGE OF ENGINEERING", New List(Of String) From {
            "Bachelor of Science in Civil Engineering",
            "Bachelor of Science in Mechanical Engineering",
            "Bachelor of Science in Electrical Engineering"
        }},
        {"COLLEGE OF ARTS AND SCIENCES", New List(Of String) From {
            "Bachelor of Arts in Psychology",
            "Bachelor of Science in Biology",
            "Bachelor of Science in Political Science"
        }},
        {"COLLEGE OF HOSPITALITY MANAGEMENT", New List(Of String) From {
            "Bachelor of Science in Hospitality Management",
            "Bachelor of Science in Tourism Management"
        }},
        {"COLLEGE OF NURSING", New List(Of String) From {
            "Bachelor of Science in Nursing",
            "Bachelor of Science in Medical Technology",
            "Bachelor of Science in Pharmacy"
        }}
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        departmentBox.Items.Clear()
        For Each dept As String In departmentCourses.Keys
            departmentBox.Items.Add(dept)
        Next
        departmentBox.Enabled = True
        departmentBox.SelectedIndex = -1


        courseBox.Items.Clear()
        courseBox.Enabled = False


        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ConfirmExit(e)
    End Sub

    Private Sub departmentBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles departmentBox.SelectedIndexChanged
        If departmentBox.SelectedItem Is Nothing Then
            courseBox.Items.Clear()
            courseBox.Enabled = False
            Return
        End If

        Dim dept As String = departmentBox.SelectedItem.ToString()
        courseBox.Items.Clear()

        If departmentCourses.ContainsKey(dept) Then
            courseBox.Items.AddRange(departmentCourses(dept).ToArray())
            courseBox.Enabled = True
            If courseBox.Items.Count > 0 Then courseBox.SelectedIndex = 0
        Else
            courseBox.Enabled = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        TextBox2.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub


    Private Sub ClearAllText(parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            ElseIf ctrl.HasChildren Then
                ClearAllText(ctrl)
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(firstNameBox.Text) OrElse
       String.IsNullOrWhiteSpace(lastnameBox.Text) OrElse
       String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
       departmentBox.SelectedIndex = -1 OrElse
       courseBox.SelectedIndex = -1 Then

            MessageBox.Show("Please fill out all required fields before registering.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        MessageBox.Show("You are now registered as a Student!", "Register Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ClearAllText(Me)


        departmentBox.SelectedIndex = -1


        courseBox.Items.Clear()
        courseBox.SelectedIndex = -1
        courseBox.Text = String.Empty
        courseBox.ResetText()
        courseBox.Enabled = False


        CheckBox1.Checked = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim regForm As New Registration()
        regForm.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub courseBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles courseBox.SelectedIndexChanged

    End Sub

    Private Sub nameLabel_Click(sender As Object, e As EventArgs) Handles nameLabel.Click

    End Sub

    Private Sub midNameBox_TextChanged(sender As Object, e As EventArgs) Handles midNameBox.TextChanged

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub firstNameBox_TextChanged(sender As Object, e As EventArgs) Handles firstNameBox.TextChanged

    End Sub
End Class
