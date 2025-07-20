Imports System.Data.OleDb
Imports System.Text.RegularExpressions


Public Class SignUp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 1. Client-side validation
        If Not ValidateInputs() Then Exit Sub

        ' 2. Database operations
        Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Yiwen\source\repos\BookCraft_Group20\bin\Debug\BookCraft_Group20_Database.accdb")
            Try
                conn.Open()

                ' 3. Check for existing user
                If UserExists(conn, txtUsername.Text, txtEmail.Text) Then
                    MessageBox.Show("Username or email already exists.")
                    Exit Sub
                End If

                ' 4. Insert new user
                If InsertUser(conn) Then
                    MessageBox.Show("Registration successful!")
                    Me.Hide()
                    Form1.Show()
                End If

            Catch ex As Exception
                HandleDatabaseError(ex)
            End Try
        End Using
    End Sub

    Private Function ValidateInputs() As Boolean
        ' Password match check
        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.")
            Return False
        End If

        ' Check required fields
        If String.IsNullOrWhiteSpace(txtFullName.Text) OrElse
           String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please fill all required fields.")
            Return False
        End If

        Return True
    End Function

    Private Function IsValidEmail(email As String) As Boolean
        ' Robust email validation
        Return Regex.IsMatch(email, "^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")
    End Function

    Private Function UserExists(conn As OleDbConnection, username As String, email As String) As Boolean
        Using cmd As New OleDbCommand("SELECT COUNT(*) FROM UserInfo WHERE Username = ? OR Email = ?", conn)
            cmd.Parameters.AddWithValue("?", username)
            cmd.Parameters.AddWithValue("?", email)
            Return CInt(cmd.ExecuteScalar()) > 0
        End Using
    End Function

    Private Function InsertUser(conn As OleDbConnection) As Boolean
        Using cmd As New OleDbCommand("INSERT INTO UserInfo (NameOfUser, Username, Email, [Password], DateOfBirth, Address, PhoneNumber) VALUES (?, ?, ?, ?, ?, ?, ?)", conn)
            ' Add parameters with explicit types
            cmd.Parameters.Add("@Name", OleDbType.VarChar).Value = txtFullName.Text
            cmd.Parameters.Add("@User", OleDbType.VarChar).Value = txtUsername.Text
            cmd.Parameters.Add("@Email", OleDbType.VarChar).Value = txtEmail.Text.Trim()
            cmd.Parameters.Add("@Pass", OleDbType.VarChar).Value = txtPassword.Text
            cmd.Parameters.Add("@DOB", OleDbType.DBDate).Value = dtpDOB.Value.Date
            cmd.Parameters.Add("@Addr", OleDbType.VarChar).Value = If(String.IsNullOrEmpty(txtAddress.Text), DBNull.Value, txtAddress.Text)
            cmd.Parameters.Add("@Phone", OleDbType.VarChar).Value = If(String.IsNullOrEmpty(txtPhone.Text), DBNull.Value, txtPhone.Text)

            Return cmd.ExecuteNonQuery() > 0
        End Using
    End Function

    Private Sub HandleDatabaseError(ex As Exception)
        If ex.Message.Contains("validation") Then
            MessageBox.Show("Database rejected the data. Please check your inputs.")
        ElseIf ex.Message.Contains("duplicate") Then
            MessageBox.Show("This email or username already exists.")
        Else
            MessageBox.Show("Database error: " & ex.Message)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide（）
        Form1.Show（）
    End Sub

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class