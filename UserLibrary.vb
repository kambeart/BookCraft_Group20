Imports System.Data.OleDb

Public Class UserLibrary
    Private Sub UserLibrary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserLibrary(Session.CurrentUserID)
    End Sub

    Private Sub LoadUserLibrary(userID As Integer)
        flpLibrary.Controls.Clear()

        Dim query As String = "SELECT p.ProductID, p.Title, p.SellerUsername, p.CoverImagePath " &
                             "FROM UserLibrary ul " &
                             "JOIN ProductInfo p ON ul.ProductID = p.ProductID " &
                             "WHERE ul.UserID = ? AND p.ProductType = 'eBook'"

        Dim parameters As New List(Of OleDbParameter) From {
            New OleDbParameter("@UserID", userID)
        }

        Dim books As DataTable = DatabaseHelper.ExecuteQuery(query, parameters)

        For Each row As DataRow In books.Rows
            Dim bookCard As New Panel With {
                .Width = 150,
                .Height = 220,
                .Margin = New Padding(10),
                .BorderStyle = BorderStyle.FixedSingle
            }

            Dim picCover As New PictureBox With {
                .Width = 130,
                .Height = 130,
                .Top = 10,
                .Left = 10,
                .SizeMode = PictureBoxSizeMode.Zoom
            }

            ' Handle cover image
            If Not IsDBNull(row("CoverImagePath")) AndAlso
   Not String.IsNullOrEmpty(row("CoverImagePath").ToString()) Then
                picCover.Image = Image.FromFile(row("CoverImagePath").ToString())
            Else
                picCover.Image = CreatePlaceholderCover()
            End If

            ' Rest of your card creation code...
            bookCard.Controls.Add(picCover)
            flpLibrary.Controls.Add(bookCard)
        Next
    End Sub

    Private Function CreatePlaceholderCover() As Image
        Dim img As New Bitmap(130, 130)
        Using g As Graphics = Graphics.FromImage(img)
            g.Clear(Color.LightGray)
            g.DrawString("No Cover", New Font("Arial", 8), Brushes.Black, 10, 50)
        End Using
        Return img
    End Function

    Private Sub btnRead_Click(sender As Object, e As EventArgs)
        Dim selectedProductID As Integer = CInt(DirectCast(sender, Button).Tag)
        Dim eBookReader As New ReadEbook(selectedProductID)
        eBookReader.Show()
    End Sub

End Class