Public Class EbookMarketplace
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) 
        Me.Hide()
        UserProfile.Show()
    End Sub

    Private Sub btnMarket_Click(sender As Object, e As EventArgs) 
        Me.Hide()
        MarketPlace.Show()
    End Sub
End Class