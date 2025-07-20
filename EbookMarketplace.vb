Public Class EbookMarketplace


    Private Sub btnProfile_Click_1(sender As Object, e As EventArgs) Handles btnProfile.Click
        Me.Hide()
        UserProfile.Show()
    End Sub

    Private Sub btnEbook_Click(sender As Object, e As EventArgs) Handles btnEbook.Click

    End Sub

    Private Sub btnMarket_Click(sender As Object, e As EventArgs) Handles btnMarket.Click
        Me.Hide()
        MarketPlace.Show()
    End Sub
End Class