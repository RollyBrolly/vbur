Public Class facultyStudentRecord

    Private skipCloseConfirmation As Boolean = False

    'dictionary
    Private departmentPrograms As New Dictionary(Of String, String()) From {
        {"CAS", {"PSY", "BIO", "POL"}},
        {"CBA", {"BSA", "BMM", "HRM"}},
        {"CCS", {"CS", "IT"}},
        {"CIHM", {"HOSP", "TOUR"}},
        {"COED", {"ELE", "ENG", "FIL", "MATH"}},
        {"CON", {"NUR", "PHAR", "MEDT"}}
    }

    'abbreviation dept
    Private departmentFullNames As New Dictionary(Of String, String) From {
        {"CAS", "College of Arts and Sciences"},
        {"CBA", "College of Business Management"},
        {"CCS", "College of Computer Studies"},
        {"CIHM", "College of Hospitality Management"},
        {"COED", "College of Education"},
        {"CON", "College of Nursing"}
    }

    'abbreviation program
    Private programFullNames As New Dictionary(Of String, String) From {
        {"PSY", "Bachelor of Arts in Psychology"},
        {"BIO", "Bachelor of Science in Biology"},
        {"POL", "Bachelor of Science in Political Science"},
        {"BSA", "Bachelor of Science in Business Administration"},
        {"BMM", "Bachelor of Science in Marketing Management"},
        {"HRM", "Bachelor of Science in Human Resource Management"},
        {"CS", "Bachelor of Science in Computer Science"},
        {"IT", "Bachelor of Science in Information Technology"},
        {"HOSP", "Bachelor of Science in Hospitality Management"},
        {"TOUR", "Bachelor of Science in Tourism Management"},
        {"ELE", "Bachelor of Elementary Education"},
        {"ENG", "Bachelor of Secondary Education - English"},
        {"FIL", "Bachelor of Elementary Education - Filipino"},
        {"MATH", "Bachelor of Secondary Education - Math"},
        {"NUR", "Bachelor of Science in Nursing"},
        {"PHAR", "Bachelor of Science in Pharmacy"},
        {"MEDT", "Bachelor of Science in Medical Technology"}
        }


    Private sections() As String = {"4A", "4B", "4C", "4D", "4E", "4F"}

    Private Sub facultygradestudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized


        deptcbbox.Items.AddRange(departmentFullNames.Values.ToArray())
        programcbbox.Enabled = False
        sectioncbbox.Enabled = False

        deptfltr.Items.AddRange(departmentPrograms.Keys.ToArray())
        programfltr.Enabled = False
        sectionfltr.Enabled = False

        searchbox.Text = "Search Name"
        searchbox.ForeColor = Color.DarkGray


    End Sub


    Private Sub deptcbbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles deptcbbox.SelectedIndexChanged
        If deptcbbox.SelectedItem Is Nothing Then
            programcbbox.Enabled = False
            sectioncbbox.Enabled = False
            Exit Sub
        End If

        programcbbox.Enabled = True
        programcbbox.Items.Clear()
        sectioncbbox.Items.Clear()
        sectioncbbox.Enabled = False

        Dim selectedDept = deptcbbox.SelectedItem.ToString()

        Select Case selectedDept
            Case "College of Arts and Sciences"
                programcbbox.Items.AddRange({"Bachelor of Arts in Psychology", "Bachelor of Science in Biology", "Bachelor of Science in Political Science"})
            Case "College of Business Management"
                programcbbox.Items.AddRange({"Bachelor of Science in Business Administration", "Bachelor of Science in Marketing Management", "Bachelor of Science in Human Resource Management"})
            Case "College of Computer Studies"
                programcbbox.Items.AddRange({"Bachelor of Science in Computer Science", "Bachelor of Science in Information Technology"})
            Case "College of Hospitality Management"
                programcbbox.Items.AddRange({"Bachelor of Science in Hospitality Management", "Bachelor of Science in Tourism Management"})
            Case "College of Education"
                programcbbox.Items.AddRange({"Bachelor of Elementary Education", "Bachelor of Secondary Education - English", "Bachelor of Elementary Education - Filipino", "Bachelor of Secondary Education - Math"})
            Case "College of Nursing"
                programcbbox.Items.AddRange({"Bachelor of Science in Nursing", "Bachelor of Science in Pharmacy", "Bachelor of Science in Medical Technology"})
        End Select
    End Sub


    Private Sub programcbbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles programcbbox.SelectedIndexChanged
        If programcbbox.SelectedItem Is Nothing Then
            sectioncbbox.Enabled = False
            Exit Sub
        End If

        sectioncbbox.Enabled = True
        sectioncbbox.Items.Clear()
        sectioncbbox.Items.AddRange(sections)
    End Sub




    Private Sub filterDeptCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles deptfltr.SelectedIndexChanged
        programfltr.Items.Clear()
        sectionfltr.Items.Clear()

        If deptfltr.SelectedItem Is Nothing Then
            programfltr.Enabled = False
            sectionfltr.Enabled = False
            Exit Sub
        End If


        Dim deptKey = deptfltr.SelectedItem.ToString()
        programfltr.Items.AddRange(departmentPrograms(deptKey))
        programfltr.Enabled = True
        sectionfltr.Enabled = False
    End Sub

    Private Sub programfltr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles programfltr.SelectedIndexChanged
        If programfltr.SelectedItem Is Nothing Then
            sectionfltr.Enabled = False
            Exit Sub
        End If

        sectionfltr.Items.Clear()
        sectionfltr.Items.AddRange(sections)
        sectionfltr.Enabled = True
    End Sub

    Private Sub filterbtn_Click(sender As Object, e As EventArgs) Handles filterbtn.Click
        Dim nameKeyword As String = searchbox.Text.Trim().ToLower()
        Dim deptFilter As String = deptfltr.Text
        Dim progFilter As String = programfltr.Text
        Dim secFilter As String = sectionfltr.Text

        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.IsNewRow Then Continue For

            Dim visible As Boolean = True


            If nameKeyword <> "" Then
                Dim combinedName = row.Cells("Surname").Value.ToString().ToLower() & " " &
                                   row.Cells("Firstname").Value.ToString().ToLower() & " " &
                                   row.Cells("Midname").Value.ToString().ToLower()
                If Not combinedName.Contains(nameKeyword) Then visible = False
            End If

            ' Department filter
            If deptFilter <> "" AndAlso Not departmentFullNames(deptFilter).Equals(row.Cells("Department").Value.ToString()) Then
                visible = False
            End If

            ' Program filter
            If progFilter <> "" Then
                Dim fullProgramName As String = If(programFullNames.ContainsKey(progFilter), programFullNames(progFilter), progFilter)
                If row.Cells("Program").Value.ToString() <> fullProgramName Then visible = False
            End If

            ' Section filter
            If secFilter <> "" AndAlso row.Cells("Section").Value.ToString() <> secFilter Then visible = False

            row.Visible = visible
        Next
    End Sub

    Private Sub resetFilterBtn_Click(sender As Object, e As EventArgs) Handles resetFilterBtn.Click
        ' Clear filter ComboBoxes and search box
        deptfltr.SelectedIndex = -1
        programfltr.SelectedIndex = -1
        sectionfltr.SelectedIndex = -1
        searchbox.Clear()

        ' Disable program and section filters
        programfltr.Enabled = False
        sectionfltr.Enabled = False

        ' Make all rows visible
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                row.Visible = True
            End If
        Next


    End Sub

    Private Sub searchbox_Enter(sender As Object, e As EventArgs) Handles searchbox.Enter
        If searchbox.Text = "Search Name" Then
            searchbox.Text = ""
            searchbox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub searchbox_Leave(sender As Object, e As EventArgs) Handles searchbox.Leave
        If String.IsNullOrWhiteSpace(searchbox.Text) Then
            searchbox.Text = "Search Name"
            searchbox.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim result As DialogResult = MessageBox.Show("Return to dashboard?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim dashboard As New facultyDashboard()
            dashboard.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If String.IsNullOrWhiteSpace(deptcbbox.Text) OrElse
          String.IsNullOrWhiteSpace(programcbbox.Text) OrElse
          String.IsNullOrWhiteSpace(sectioncbbox.Text) Then
            MessageBox.Show("Please fill all selections.")
            Exit Sub
        End If

        DataGridView1.Rows.Add(
            studidtxtbx.Text,
            surnametxtbox.Text,
            firstnametxtbox.Text,
            midnametxtbox.Text,
            genderccbox.Text,
            deptcbbox.Text,
            programcbbox.Text,
            sectioncbbox.Text
        )

        studidtxtbx.Clear()
        surnametxtbox.Clear()
        firstnametxtbox.Clear()
        midnametxtbox.Clear()
        genderccbox.SelectedIndex = -1
        deptcbbox.SelectedIndex = -1
        programcbbox.SelectedIndex = -1
        sectioncbbox.SelectedIndex = -1
        programcbbox.Enabled = False
        sectioncbbox.Enabled = False

        MessageBox.Show("Student record added successfully!", "Record Addition Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        ' Check if a row is selected
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a student to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Confirm deletion
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Delete selected rows
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                If Not row.IsNewRow Then
                    DataGridView1.Rows.Remove(row)
                End If
            Next

            MessageBox.Show("Selected student(s) deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub gradebtn_Click(sender As Object, e As EventArgs) Handles gradebtn.Click
        Dim result As DialogResult = MessageBox.Show("Grade Students?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Open the grade form
            Dim gradeForm As New facultyGradeStudents()
            gradeForm.ShowDialog() ' Opens as modal
            Me.Hide()
            Exit Sub
        Else
        End If
    End Sub

End Class
