Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Module UserManager

    Public Function HashPassword(password As String) As String
        Using sha As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha.ComputeHash(Encoding.UTF8.GetBytes(password))
            Return BitConverter.ToString(bytes).Replace("-", "").ToLower()
        End Using
    End Function

    Public Function CreateUserAccount(username As String, password As String, role As String, studentID As String, facultyID As String, supervisorID As String) As Boolean

        Dim newUserID As Integer = 0

        Try
            Using conn As New MySqlConnection(connstring)
                conn.Open()

                Dim insertUser As String =
                    "INSERT INTO users (Username, PasswordHash, Role)
                     VALUES (@u, @p, @r);
                     SELECT LAST_INSERT_ID();"

                Using cmd As New MySqlCommand(insertUser, conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@p", HashPassword(password))
                    cmd.Parameters.AddWithValue("@r", role)

                    newUserID = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                Dim insertAccount As String =
                    "INSERT INTO useraccounts(UserID, StudentID, FacultyID, SupervisorID)
                     VALUES(@uid, @sid, @fid, @supid)"

                Using cmdAcc As New MySqlCommand(insertAccount, conn)
                    cmdAcc.Parameters.AddWithValue("@uid", newUserID)
                    cmdAcc.Parameters.AddWithValue("@sid", If(studentID IsNot Nothing, studentID, DBNull.Value))
                    cmdAcc.Parameters.AddWithValue("@fid", If(facultyID IsNot Nothing, facultyID, DBNull.Value))
                    cmdAcc.Parameters.AddWithValue("@supid", If(supervisorID IsNot Nothing, supervisorID, DBNull.Value))

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
