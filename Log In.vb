Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        ' 1. Get user inputs
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        ' 2. Validate inputs
        If username = "" OrElse password = "" Then
            MessageBox.Show("Please enter both username and password.")
            Exit Sub
        End If

        ' 3. Prepare connection
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Yiwen\source\repos\BookCraft_Group20\bin\Debug\BookCraft_Group20_Database.accdb")

        ' 4. Prepare SQL (use parameters for security)
        Dim sql As String = "SELECT COUNT(*) FROM UserInfo WHERE Username = ? AND Password = ?"
        Dim cmd As New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("?", username)
        cmd.Parameters.AddWithValue("?", password)

        ' 5. Execute the query
        Try
            conn.Open()
            Dim userFound As Integer = CInt(cmd.ExecuteScalar())
            conn.Close()

            If userFound > 0 Then Thenw
                MessageBox.Show("Login successful!")
                Me.Hide()
                MarketPlace.Show()
                ' TODO: Open the main form or dashboard
                ' e.g., MainForm.Show() : Me.Hide()
            Else
                MessageBox.Show("Invalid username or password.")
            End If

        Catch ex As Exception
            MessageBox.Show("Login error: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    'This is just a test' 
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Me.Hide()
        SignUp.Show()
    End Sub

End Class
