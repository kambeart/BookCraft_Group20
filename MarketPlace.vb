Public Class MarketPlace


    Private Sub btnEbook_Click(sender As Object, e As EventArgs)
        Me.Hide()
        EbookMarketplace.Show()
    End Sub

    Private Sub btnMarket_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Cart.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Me.Hide()
        UserProfile.Show()
    End Sub
End Class