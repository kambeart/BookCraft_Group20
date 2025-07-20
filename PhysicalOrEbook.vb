Public Class PhysicalOrEbook
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEbook.Click
        Me.Hide()
        UploadEbook.Show()
    End Sub

    Private Sub btnBackToMarketPlace_Click(sender As Object, e As EventArgs) Handles btnBackToMarketPlace.Click
        Me.Hide()
        MarketPlace.Show()
    End Sub

    Private Sub btnPhysical_Click(sender As Object, e As EventArgs) Handles btnPhysical.Click
        Me.Hide()
        AddPhysicalBook.Show()
    End Sub
End Class