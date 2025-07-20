Imports System.Data.OleDb
Imports System.Diagnostics.Eventing.Reader

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

        ' 4. Prepare SQL (select all needed fields)
        Dim sql As String = "SELECT ID, Username FROM UserInfo WHERE Username = ? AND Password = ?"
        Dim cmd As New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("?", username)
        cmd.Parameters.AddWithValue("?", password)

        ' 5. Execute the query
        Try
            conn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                MessageBox.Show("Login successful!")
                Session.CurrentUserID = reader("ID")
                Me.Hide()
                MarketPlace.Show()
            Else
                MessageBox.Show("Invalid username or password.")
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Login error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Me.Hide()
        SignUp.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
