Imports System.Data.OleDb


Public Class DatabaseHelper
    ' Shared connection string (update your path)
    Private Shared ReadOnly ConnString As String =
        "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Yiwen\Documents\BookCraft_Group20_Database.accdb;"

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
End Class
