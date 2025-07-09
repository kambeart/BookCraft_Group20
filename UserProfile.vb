Public Class UserProfile
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub btnEbook_Click(sender As Object, e As EventArgs) Handles btnEbook.Click
        Me.Hide()
        EbookMarketplace.Show()
    End Sub

    Private Sub btnMarket_Click(sender As Object, e As EventArgs) Handles btnMarket.Click
        Me.Hide()
        MarketPlace.Show()
    End Sub
End Class