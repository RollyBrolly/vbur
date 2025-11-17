Imports MySql.Data.MySqlClient

Module UserManager

    Public Function CreateUserAccount(username As String, password As String, role As String, Optional studentID As String = Nothing, Optional facultyID As String = Nothing, Optional supervisorID As String = Nothing) As Boolean
        Try
            Using conn As New MySqlConnection(connstring)
                conn.Open()

                Dim newUserID As Integer
                Dim insertUser As String =
                    "INSERT INTO users (Username, PasswordHash, Role) VALUES (@u, @p, @r);
                     SELECT LAST_INSERT_ID();"
                Using cmd As New MySqlCommand(insertUser, conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@p", password)
                    cmd.Parameters.AddWithValue("@r", role)
                    newUserID = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                Dim insertAccount As String =
                    "INSERT INTO useraccounts(UserID, StudentID, FacultyID, SupervisorID)
                     VALUES(@uid, @sid, @fid, @supid)"
                Using cmdAcc As New MySqlCommand(insertAccount, conn)
                    cmdAcc.Parameters.AddWithValue("@uid", newUserID)
                    cmdAcc.Parameters.AddWithValue("@sid", If(studentID, DBNull.Value))
                    cmdAcc.Parameters.AddWithValue("@fid", If(facultyID, DBNull.Value))
                    cmdAcc.Parameters.AddWithValue("@supid", If(supervisorID, DBNull.Value))
                    cmdAcc.ExecuteNonQuery()
                End Using
            End Using

            Return True
        Catch ex As Exception
            MessageBox.Show("Error creating user account: " & ex.Message)
            Return False
        End Try
    End Function

End Module
