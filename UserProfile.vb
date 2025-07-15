Imports System.Data.OleDb
Imports System.IO
Public Class UserProfile



    Private Sub btnEbook_Click(sender As Object, e As EventArgs) Handles btnEbook.Click
        Me.Hide()
        EbookMarketplace.Show()
    End Sub

    Private Sub btnMarket_Click(sender As Object, e As EventArgs) Handles btnMarket.Click
        Me.Hide()
        MarketPlace.Show()
    End Sub



    Private Sub LinkProfile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkProfile.LinkClicked
        ' Let user pick an image
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If ofd.ShowDialog = DialogResult.OK Then
            ' 1. Display in PictureBox
            PictureBox1.Image = Image.FromFile(ofd.FileName)

            ' 2. Convert image to byte array
            Dim imgBytes() As Byte = File.ReadAllBytes(ofd.FileName)

            ' 3. Save to database
            Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Yiwen\source\repos\BookCraft_Group20\bin\Debug\BookCraft_Group20_Database.accdb"
            Using conn As New OleDbConnection(connStr)
                Dim cmd As New OleDbCommand("UPDATE UserInfo SET ProfilePicturePath = ? WHERE ID = ?", conn)
                cmd.Parameters.Add("?", OleDbType.Binary).Value = imgBytes
                cmd.Parameters.Add("?", OleDbType.Integer).Value = CurrentUser ' Replace with your logic

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Image uploaded and saved.")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class