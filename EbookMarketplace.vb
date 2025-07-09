Public Class EbookMarketplace
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Me.Hide()
        UserProfile.Show()
    End Sub

    Private Sub btnMarket_Click(sender As Object, e As EventArgs) Handles btnMarket.Click
        Me.Hide()
        MarketPlace.Show()
    End Sub
End Class