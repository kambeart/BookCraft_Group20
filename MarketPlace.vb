Public Class MarketPlace
    Private Sub btnProfile_Click(sender As Object, e As EventArgs)
        Me.Hide()
        UserProfile.Show()
    End Sub

    Private Sub btnEbook_Click(sender As Object, e As EventArgs) Handles btnEbook.Click
        Me.Hide()
        EbookMarketplace.Show()
    End Sub

    Private Sub btnMarket_Click(sender As Object, e As EventArgs) Handles btnMarket.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Cart.Show()
    End Sub
End Class