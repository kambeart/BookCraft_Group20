Imports System.Data.OleDb
Imports System.IO


Public Class MarketPlace
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Yiwen\source\repos\BookCraft_Group20\bin\Debug\BookCraft_Group20_Database.accdb")




    Private Sub MarketPlace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBooks()
    End Sub

    Private Sub LoadBooks()
        Try
            con.Open()
            Dim cmd As New OleDbCommand("SELECT * FROM ProductInfo", con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            flpBooks.Controls.Clear()

            While reader.Read()
                Dim panel As New Panel()
                panel.Size = New Size(200, 350)
                panel.BorderStyle = BorderStyle.FixedSingle
                panel.BackColor = Color.White

                ' Book Image
                Dim pb As New PictureBox()
                pb.Size = New Size(180, 120)
                pb.SizeMode = PictureBoxSizeMode.StretchImage
                pb.Top = 10
                pb.Left = 10
                If File.Exists(reader("CoverImagePath").ToString()) Then
                    pb.Image = Image.FromFile(reader("CoverImagePath").ToString())
                End If

                ' Title
                Dim lblTitle As New Label()
                lblTitle.Text = reader("Title").ToString()
                lblTitle.Top = pb.Bottom + 5
                lblTitle.Left = 10
                lblTitle.Width = 180
                lblTitle.Font = New Font("Arial", 10, FontStyle.Bold)

                ' Price
                Dim lblPrice As New Label()
                lblPrice.Text = "Price: RM" & reader("Price").ToString()
                lblPrice.Top = lblTitle.Bottom + 5
                lblPrice.Left = 10
                lblPrice.Width = 180

                ' Condition
                Dim lblGenre As New Label()
                lblGenre.Text = "Genre: " & reader("Genre").ToString()
                lblGenre.Top = lblPrice.Bottom + 5
                lblGenre.Left = 10
                lblGenre.Width = 180

                ' Seller
                Dim lblSeller As New Label()
                lblSeller.Text = "Seller: " & reader("SellerUsername").ToString()
                lblSeller.Top = lblGenre.Bottom + 5
                lblSeller.Left = 10
                lblSeller.Width = 180

                ' Description
                Dim lblDesc As New Label()
                lblDesc.Text = "Desc: " & reader("Description").ToString()
                lblDesc.Top = lblSeller.Bottom + 5
                lblDesc.Left = 10
                lblDesc.Width = 180
                lblDesc.Height = 40
                lblDesc.AutoSize = False

                ' Add to Cart Button
                Dim btnAddToCart As New Button()
                btnAddToCart.Text = "Add to Cart"
                btnAddToCart.Top = lblDesc.Bottom + 10
                btnAddToCart.Left = 10
                btnAddToCart.Width = 180
                btnAddToCart.BackColor = Color.LightGreen
                btnAddToCart.FlatStyle = FlatStyle.Flat

                ' Store BookID in the Tag property
                btnAddToCart.Tag = reader("ProductID").ToString()

                ' Handle button click (Add to Cart function)
                AddHandler btnAddToCart.Click, AddressOf AddToCart_Click

                ' Add controls to panel
                panel.Controls.Add(pb)
                panel.Controls.Add(lblTitle)
                panel.Controls.Add(lblPrice)
                panel.Controls.Add(lblGenre)
                panel.Controls.Add(lblSeller)
                panel.Controls.Add(lblDesc)
                panel.Controls.Add(btnAddToCart)




                ' Add panel to FlowLayoutPanel
                flpBooks.Controls.Add(panel)
            End While

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub AddToCart_Click(sender As Object, e As EventArgs)
        Dim btnAddToCart As Button = DirectCast(sender, Button)
        Dim ProductID As Integer = CInt(btnAddToCart.Tag)

        Try
            ' Check if item already exists in cart
            Dim checkSql = "SELECT Quantity FROM shoppingCart WHERE UserID = ? AND ProductID = ?"
            Dim existingQty As Integer = 0

            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Yiwen\source\repos\BookCraft_Group20\bin\Debug\BookCraft_Group20_Database.accdb"),
              cmd As New OleDbCommand(checkSql, conn)

                cmd.Parameters.AddWithValue("?", Session.CurrentUserID)
                cmd.Parameters.AddWithValue("?", ProductID)

                conn.Open()
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    existingQty = CInt(result)
                End If
            End Using

            ' Insert or Update based on existence
            Dim sql As String
            If existingQty > 0 Then
                ' Update quantity if already exists
                sql = "UPDATE shoppingCart SET Quantity = Quantity + 1 WHERE UserID = ? AND ProductID = ?"
            Else
                ' Insert new record if doesn't exist
                sql = "INSERT INTO shoppingCart (UserID, ProductID, Quantity) VALUES (?, ?, 1)"
            End If

            ' Execute the query
            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Yiwen\source\repos\BookCraft_Group20\bin\Debug\BookCraft_Group20_Database.accdb"),
              cmd As New OleDbCommand(sql, conn)

                cmd.Parameters.AddWithValue("?", Session.CurrentUserID)
                cmd.Parameters.AddWithValue("?", ProductID)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Item added to your cart!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show($"Error updating cart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        AddPhysicalBook.Show()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Me.Hide()
        UserProfile.Show()
    End Sub



    Private Sub btn_Ebook_Click_1(sender As Object, e As EventArgs) Handles btn_Ebook.Click
        Me.Hide()
        EbookMarketplace.Show()
    End Sub

    Private Sub btnShoppingCart_Click(sender As Object, e As EventArgs) Handles btnShoppingCart.Click
        Me.Hide()
        Cart.Show()
    End Sub
End Class