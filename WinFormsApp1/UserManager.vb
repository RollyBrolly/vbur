Imports MySql.Data.MySqlClient

Module UserManager

    Public Function CreateUserAccount(conn As MySqlConnection, transaction As MySqlTransaction,
                                      username As String, password As String, role As String,
                                      studentID As String, supervisorID As String) As Boolean
        Try
            Using cmd As New MySqlCommand("INSERT INTO users (Username, PasswordHash, Role)
                VALUES (@Username, @Password, @Role)", conn, transaction)

                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Password", password)
                cmd.Parameters.AddWithValue("@Role", role)

                cmd.ExecuteNonQuery()

                Dim userID As Long = cmd.LastInsertedId

                Using cmd2 As New MySqlCommand("INSERT INTO useraccounts (UserID, StudentID, SupervisorID)
                    VALUES (@UserID, @StudentID, @SupervisorID)", conn, transaction)

                    cmd2.Parameters.AddWithValue("@UserID", userID)
                    cmd2.Parameters.AddWithValue("@StudentID", If(String.IsNullOrWhiteSpace(studentID), DBNull.Value, studentID))
                    cmd2.Parameters.AddWithValue("@SupervisorID", If(String.IsNullOrWhiteSpace(supervisorID), DBNull.Value, supervisorID))

                    Return cmd2.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show($"Account creation error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module
