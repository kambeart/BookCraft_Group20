Imports System.Data.OleDb
Imports System.IO
Public Class AddPhysicalBook
    Private coverImagePath As String = ""
    Private currentSellerID As Integer = 1 ' Replace with actual seller ID

    ' ========== FORM CONTROLS ==========
    ' LinkLabel: linkUploadCover
    ' TextBoxes: txtTitle, txtDesc, txtISBN
    ' NumericUpDown: numPrice, numQuantity
    ' ComboBox: cboGenre
    ' Buttons: btnUpload, btnBack

    ' ========== FORM LOAD ==========
    Private Sub frmUploadPhysicalBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure numeric controls
        numPrice.DecimalPlaces = 2
        numPrice.Minimum = 0
        numPrice.Maximum = 1000

        numQuantity.Minimum = 1
        numQuantity.Maximum = 1000
        numQuantity.Value = 1

        ' Load genres
        cboGenre.Items.AddRange({"Fiction", "Non-Fiction", "Science Fiction", "Mystery", "Romance", "Biography"})
    End Sub

    ' ========== UPLOAD COVER ==========
    Private Sub linkUploadCover_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkUploadCover.LinkClicked
        Using ofd As New OpenFileDialog
            ofd.Filter = "Images|*.jpg;*.png;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                coverImagePath = ofd.FileName
                picCover.Image = Image.FromFile(coverImagePath)
            End If
        End Using
    End Sub

    ' ========== UPLOAD BOOK ==========
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        ' Validate inputs
        If String.IsNullOrEmpty(txtTitle.Text) OrElse picCover.Image Is Nothing Then
            MessageBox.Show("Title and cover image are required!")
            Return
        End If

        ' Save to database
        Try
            ' [1] Save cover image
            Dim coverPath = SaveFileToFolder(coverImagePath, "Covers", Guid.NewGuid().ToString() & ".jpg")

            ' [2] Insert into ProductInfo
            Dim query = "INSERT INTO ProductInfo (Title, Description, SellerID, Price, ISBN, Genre, ProductType, CoverImagePath) " &
                        "VALUES (@Title, @Desc, @SellerID, @Price, @ISBN, @Genre, 'PhysicalBook', @CoverPath)"

            Dim parameters As New List(Of OleDbParameter) From {
                New OleDbParameter("@Title", txtTitle.Text),
                New OleDbParameter("@Desc", txtDesc.Text),
                New OleDbParameter("@SellerID", currentSellerID),
                New OleDbParameter("@Price", numPrice.Value),
                New OleDbParameter("@ISBN", If(String.IsNullOrEmpty(txtISBN.Text), DBNull.Value, txtISBN.Text)),
                New OleDbParameter("@Genre", If(cboGenre.SelectedItem Is Nothing, "General", cboGenre.SelectedItem.ToString())),
                New OleDbParameter("@CoverPath", coverPath)
            }

            DatabaseHelper.ExecuteNonQuery(query, parameters)

            ' [3] Update Inventory
            Dim inventoryQuery = "INSERT INTO Inventory (ProductID, StockQuantity) VALUES (@ProductID, @Quantity)"
            ' Get last inserted ID (Access-specific)
            Dim productID = DatabaseHelper.ExecuteScalar("SELECT MAX(ProductID) FROM ProductInfo", Nothing)

            DatabaseHelper.ExecuteNonQuery(inventoryQuery, New List(Of OleDbParameter) From {
                New OleDbParameter("@ProductID", productID),
                New OleDbParameter("@Quantity", CInt(numQuantity.Value))
            })

            MessageBox.Show("Physical book uploaded successfully!")
            ClearForm()

        Catch ex As Exception
            MessageBox.Show($"Error uploading book: {ex.Message}")
        End Try
    End Sub

    ' ========== HELPER METHODS ==========
    Private Function SaveFileToFolder(sourcePath As String, subFolder As String, fileName As String) As String
        Dim appPath = Application.StartupPath
        Dim fullPath = Path.Combine(appPath, subFolder)

        If Not Directory.Exists(fullPath) Then
            Directory.CreateDirectory(fullPath)
        End If

        Dim destPath = Path.Combine(fullPath, fileName)
        File.Copy(sourcePath, destPath, True)
        Return destPath
    End Function

    Private Sub ClearForm()
        txtTitle.Clear()
        txtDesc.Clear()
        txtISBN.Clear()
        numPrice.Value = 0
        numQuantity.Value = 1
        cboGenre.SelectedIndex = -1
        picCover.Image = Nothing
        coverImagePath = ""
    End Sub

    ' ========== NAVIGATION ==========
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        PhysicalOrEbook.Show()
    End Sub
End Class
