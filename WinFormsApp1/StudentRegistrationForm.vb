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

    ' ✅ Fixed abbreviation mapping
    Private ReadOnly courseAbbreviations As New Dictionary(Of String, String) From {
        {"Bachelor of Science in Information Technology", "BSIT"},
        {"Bachelor of Science in Computer Science", "BSCS"},
        {"Bachelor of Secondary Education - English", "BSEDE"},
        {"Bachelor of Secondary Education - Math", "BSEDM"},
        {"Bachelor of Elementary Education - Filipino", "BEED"},
        {"Bachelor of Science in Marketing Management", "BSMM"},
        {"Bachelor of Science in Human Resource Management", "BSHR"},
        {"Bachelor of Science in Civil Engineering", "BSCE"},
        {"Bachelor of Science in Mechanical Engineering", "BSME"},
        {"Bachelor of Science in Electrical Engineering", "BSEE"},
        {"Bachelor of Arts in Psychology", "BAPSY"},
        {"Bachelor of Science in Biology", "BSBIO"},
        {"Bachelor of Science in Political Science", "BSPS"},
        {"Bachelor of Science in Hospitality Management", "BSHM"},
        {"Bachelor of Science in Tourism Management", "BSTM"},
        {"Bachelor of Science in Nursing", "BSN"},
        {"Bachelor of Science in Medical Technology", "BSMT"},
        {"Bachelor of Science in Pharmacy", "BSPH"}
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        departmentBox.Items.Clear()
        For Each dept As String In departmentCourses.Keys
            departmentBox.Items.Add(dept)
        Next

        ' ✅ Enable and make departmentBox selection-only
        departmentBox.Enabled = True
        departmentBox.DropDownStyle = ComboBoxStyle.DropDownList
        departmentBox.SelectedIndex = -1

        courseBox.Items.Clear()
        courseBox.Enabled = False

        sectioncb.Items.Clear()
        sectioncb.Enabled = False
    End Sub

    Private Sub departmentBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles departmentBox.SelectedIndexChanged
        courseBox.Items.Clear()
        sectioncb.Items.Clear()
        sectioncb.Enabled = False

        If departmentBox.SelectedItem Is Nothing Then
            courseBox.Enabled = False
            Return
        End If

        Dim dept As String = departmentBox.SelectedItem.ToString()

        If departmentCourses.ContainsKey(dept) Then
            courseBox.Items.AddRange(departmentCourses(dept).ToArray())
            courseBox.Enabled = True
        Else
            courseBox.Enabled = False
        End If
    End Sub

    ' ✅ Populate sectionBox with correct abbreviation
    Private Sub courseBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles courseBox.SelectedIndexChanged
        sectioncb.Items.Clear()

        If departmentBox.SelectedIndex = -1 OrElse courseBox.SelectedIndex = -1 Then
            sectioncb.Enabled = False
            Return
        End If

        Dim courseName As String = courseBox.SelectedItem.ToString()
        Dim abbreviation As String = ""

        If courseAbbreviations.ContainsKey(courseName) Then
            abbreviation = courseAbbreviations(courseName)
        Else
            abbreviation = "GEN" ' fallback if course not found
        End If

        ' Add 4 sections with abbreviation prefix
        Dim sections As String() = {"4A", "4B", "4C", "4D"}
        For Each sec In sections
            sectioncb.Items.Add(abbreviation & sec)
        Next

        sectioncb.Enabled = True
        sectioncb.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(firstNameBox.Text) OrElse
           String.IsNullOrWhiteSpace(lastnameBox.Text) OrElse
           departmentBox.SelectedIndex = -1 OrElse
           courseBox.SelectedIndex = -1 OrElse
           sectioncb.SelectedIndex = -1 Then

            MessageBox.Show("Please fill out all required fields before registering.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        MessageBox.Show("You are now registered as a Student!", "Register Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear all fields?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ClearAllText(Me)
            departmentBox.SelectedIndex = -1
            courseBox.Items.Clear()
            courseBox.Enabled = False
            sectioncb.Items.Clear()
            sectioncb.Enabled = False
        End If
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult = MessageBox.Show("Return to registration page?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim regForm As New Registration()
            regForm.Show()
            Me.Hide()
        End If
    End Sub

End Class
