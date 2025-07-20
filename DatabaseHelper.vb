Imports System.Data.OleDb


Public Class DatabaseHelper
    ' Shared connection string (update your path)
    Private Shared ReadOnly ConnString As String =
        "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Yiwen\source\repos\BookCraft_Group20\bin\Debug\BookCraft_Group20_Database.accdb"

    ' Method to get a connection
    Public Shared Function GetConnection() As OleDbConnection
        Return New OleDbConnection(ConnString)
    End Function

    ' Method to execute queries (returns DataTable)
    Public Shared Function ExecuteQuery(query As String, Optional parameters As List(Of OleDbParameter) = Nothing) As DataTable
        Dim dt As New DataTable()

        Using conn As OleDbConnection = GetConnection()
            Using cmd As New OleDbCommand(query, conn)
                ' Add parameters if provided
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If

                conn.Open()
                Using adapter As New OleDbDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function

    ' Method for INSERT/UPDATE/DELETE
    Public Shared Sub ExecuteNonQuery(query As String, Optional parameters As List(Of OleDbParameter) = Nothing)
        Using conn As OleDbConnection = GetConnection()
            Using cmd As New OleDbCommand(query, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Shared Function ExecuteScalar(query As String, parameters As List(Of OleDbParameter)) As Object
        Using conn As OleDbConnection = GetConnection()
            Using cmd As New OleDbCommand(query, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If
                conn.Open()
                Dim result = cmd.ExecuteScalar()
                Return If(result Is DBNull.Value, Nothing, result)
            End Using
        End Using
    End Function

    Public Class DBHelper
        Private Shared ReadOnly ConnectionString As String =
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Yiwen\source\repos\BookCraft_Group20\bin\Debug\BookCraft_Group20_Database.accdb"

        Public Shared Function ExecuteQuery(
            query As String,
            parameters As List(Of OleDbParameter)
        ) As DataTable

            Dim dt As New DataTable()
            Using conn As New OleDbConnection(ConnectionString),
                  cmd As New OleDbCommand(query, conn)

                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If

                conn.Open()
                dt.Load(cmd.ExecuteReader())
            End Using
            Return dt
        End Function
    End Class

End Class
