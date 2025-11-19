Imports MySql.Data.MySqlClient

Public Class AddCompanyForm
    Private conn As New MySqlConnection(connectdb.connstring)
    Private skipCloseConfirmation As Boolean = False

    Private Sub AddCompanyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        compidtxt.Text = GenerateCompanyID()

    End Sub

    Private Sub AddCompanyForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If skipCloseConfirmation Then Return

        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to exit?",
            "Exit Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.No Then
            e.Cancel = True
            Return
        End If

        ShowStaffForm()
    End Sub

    Private Function GenerateCompanyID() As String
        Dim nextID As Integer = 1

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT CompanyID FROM company ORDER BY CompanyID", conn)
            Dim reader = cmd.ExecuteReader()
            Dim ids As New List(Of Integer)

            While reader.Read()
                ids.Add(Integer.Parse(reader("CompanyID").ToString().Substring(2)))
            End While
            reader.Close()

            While ids.Contains(nextID)
                nextID += 1
            End While

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        Return "CO" & nextID.ToString("D3")
    End Function

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles addcompantbtn.Click
        Dim companyName As String = compntxt.Text.Trim()
        Dim companyAddress As String = compaddtxt.Text.Trim()

        If String.IsNullOrWhiteSpace(companyName) OrElse String.IsNullOrWhiteSpace(companyAddress) Then
            MessageBox.Show("Enter Company Name and Address", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim companyID As String = GenerateCompanyID()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand(
                "INSERT INTO company (CompanyID, CompanyName, CompanyAddress) VALUES (@id, @name, @address)",
                conn
            )
            cmd.Parameters.AddWithValue("@id", companyID)
            cmd.Parameters.AddWithValue("@name", companyName)
            cmd.Parameters.AddWithValue("@address", companyAddress)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Company added successfully! ID: " & companyID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearAllText(Me)
        Catch ex As MySqlException
            MessageBox.Show("Error adding company: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
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

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles returnbtm.Click
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to exit? Unsaved changes will be lost. Proceed?",
            "Confirm Return",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            skipCloseConfirmation = True
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
    'test
End Class
