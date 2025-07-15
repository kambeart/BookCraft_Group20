Imports System.Data.OleDb
Imports System.Drawing.Imaging
Imports System.IO

Public Class Cart
    Private currentUserID As Integer = 1
    Private currentPage As Integer = 1
    Private pageSize As Integer = 3 ' Items per page


    Private Sub CartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupDataGridView()
        LoadCartItems()
    End Sub

    Private Sub SetupDataGridView()
        dgvCart.Columns.Clear()

        ' Image column
        Dim imgCol As New DataGridViewImageColumn()
        imgCol.Name = "Image"
        imgCol.HeaderText = "Cover"
        imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
        imgCol.Width = 80
        dgvCart.Columns.Add(imgCol)

        ' Other columns (same as before)
        dgvCart.Columns.Add("ProductID", "ID") ' Hidden
        dgvCart.Columns.Add("Title", "Book Title")
        ' ... (add other columns)

        ' Pagination controls
        btnPreviousPage.Enabled = False
        UpdatePaginationButtons()
    End Sub

    ' ======================
    ' LOAD DATA WITH PAGINATION
    ' ======================
    Private Sub LoadCartItems()
        dgvCart.Rows.Clear()

        Dim query = "SELECT TOP " & pageSize & " * FROM (" &
            "SELECT TOP " & (currentPage * pageSize) & " p.ProductID, p.Title, p.Price, p.ImagePath, c.Quantity " &
            "FROM ProductInfo p INNER JOIN Cart c ON p.ProductID = c.ProductID " &
            "WHERE c.UserID = @UserID ORDER BY p.Title" &
            ") ORDER BY Title DESC"

        Dim params As New List(Of OleDbParameter) From {
            New OleDbParameter("@UserID", currentUserID),
            New OleDbParameter("@PageSize", pageSize),
            New OleDbParameter("@Offset", (currentPage - 1) * pageSize)
        }

        Dim dt = DatabaseHelper.ExecuteQuery(query, params)

        For Each row As DataRow In dt.Rows
            ' Load image (handle missing files)
            Dim img As Image = My.Resources.Comic1 ' Default image

            If Not IsDBNull(row("ImagePath")) AndAlso Not String.IsNullOrEmpty(row("ImagePath").ToString()) Then
                Try
                    img = Image.FromFile(row("ImagePath").ToString()) ' Try custom image
                Catch
                    ' Keep default image if error occurs
                End Try
            End If

            dgvCart.Rows.Add(
                    img,                          ' Image
                    row("ProductID"),             ' Hidden ID
                    row("Title"),                 ' Book title
                    CDec(row("Price")),           ' Unit price
                    row("Quantity"),              ' Quantity
                    CDec(row("Price")) * CInt(row("Quantity")), ' Total
                    "Remove"                      ' Button text
                    )
        Next

        UpdateTotal()
        UpdatePaginationButtons()
    End Sub

    Private Sub btnPreviousPage_Click(sender As Object, e As EventArgs) Handles btnPreviousPage.Click
        If currentPage > 1 Then
            currentPage -= 1
            LoadCartItems()
        End If
    End Sub

    Private Sub btnNextPage_Click(sender As Object, e As EventArgs) Handles btnNextPage.Click
        currentPage += 1
        LoadCartItems()
    End Sub

    Private Sub UpdatePaginationButtons()
        ' Disable Previous if on first page
        btnPreviousPage.Enabled = (currentPage > 1)

        ' Disable Next if no more items
        Dim totalItems = GetTotalCartItems()
        btnNextPage.Enabled = (currentPage * pageSize < totalItems)

        lblPageInfo.Text = $"Page {currentPage} of {Math.Ceiling(totalItems / pageSize)}"
    End Sub

    Private Function GetTotalCartItems() As Integer
        Dim query = "SELECT COUNT(*) FROM Cart WHERE UserID = @UserID"
        Return CInt(DatabaseHelper.ExecuteScalar(query,
        New List(Of OleDbParameter) From {New OleDbParameter("@UserID", currentUserID)}))
    End Function

    Private Sub UpdateTotal()
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgvCart.Rows
            If Not row.IsNewRow AndAlso row.Cells("Total").Value IsNot Nothing Then
                total += CDec(row.Cells("Total").Value)
            End If
        Next
        txtTotal.Text = "Total: RM " & total.ToString("0.00")
    End Sub

End Class