Imports System.Data.OleDb
Imports System.Drawing.Imaging
Imports System.IO

Public Class Cart

    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListView()
        LoadCartItems()
    End Sub

    Private Sub SetupListView()
        lstCartItems.Clear()
        lstCartItems.View = View.Details
        lstCartItems.FullRowSelect = True
        lstCartItems.GridLines = True
        lstCartItems.Font = New Font("Segoe UI", 10)
        lstCartItems.HeaderStyle = ColumnHeaderStyle.Nonclickable
        lstCartItems.OwnerDraw = True

        ' Set column headers to match your design
        lstCartItems.Columns.Add("Item", 400, HorizontalAlignment.Left) ' Book title
        lstCartItems.Columns.Add("Unit Price", 150, HorizontalAlignment.Right)
        lstCartItems.Columns.Add("Quantity", 150, HorizontalAlignment.Center)
        lstCartItems.Columns.Add("Price", 150, HorizontalAlignment.Right)
    End Sub

    Private Sub LoadCartItems()
        lstCartItems.Items.Clear()
        Dim grandTotal As Decimal = 0

        Dim query = "SELECT p.Title, p.Price, c.Quantity " &
                    "FROM ProductInfo p INNER JOIN ShoppingCart c ON p.ProductID = c.ProductID " &
                    "WHERE c.UserID = @UserID"

        Dim params As New List(Of OleDbParameter) From {
            New OleDbParameter("@UserID", CurrentUserID)
        }

        Dim dt = DatabaseHelper.ExecuteQuery(query, params)

        For Each row As DataRow In dt.Rows
            Dim title As String = row("Title").ToString()
            Dim price As Decimal = CDec(row("Price"))
            Dim quantity As Integer = CInt(row("Quantity"))
            Dim itemTotal As Decimal = price * quantity

            ' Create ListViewItem
            Dim lvi As New ListViewItem(title) ' Book title in first column

            ' Add subitems with proper alignment
            lvi.SubItems.Add("RM " & price.ToString("0.00")) ' Unit Price
            lvi.SubItems.Add(quantity.ToString()) ' Quantity
            lvi.SubItems.Add("RM " & itemTotal.ToString("0.00")) ' Price

            lstCartItems.Items.Add(lvi)
            grandTotal += itemTotal
        Next

        ' Add grand total row
        Dim totalRow As New ListViewItem("TOTAL")
        totalRow.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        totalRow.SubItems.Add("") ' Empty unit price
        totalRow.SubItems.Add("") ' Empty quantity
        totalRow.SubItems.Add("RM " & grandTotal.ToString("0.00"))
        lstCartItems.Items.Add(totalRow)
    End Sub

    ' Navigation buttons
    Private Sub btnBackToMarketPlace_Click(sender As Object, e As EventArgs) Handles btnBackToMarketPlace.Click
        Me.Hide()
        MarketPlace.Show()
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Me.Hide()
        Transaction_Place.Show()
    End Sub

    Private Sub lstCartItems_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles lstCartItems.DrawColumnHeader
        e.DrawDefault = True
        e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds)
        TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds, Color.Black,
                              TextFormatFlags.VerticalCenter Or TextFormatFlags.Left)
    End Sub

End Class