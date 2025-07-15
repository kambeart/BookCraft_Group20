Public Class Transaction_Place

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirmPayment.Click
        If RadioButton_Ewallet.Checked Then
            EwalletPayment.ShowDialog()
        ElseIf RadioButton_OnlineBank.Checked Then
            OnlineBankingPayment.ShowDialog()
        ElseIf RadioButton_Card.Checked Then
            CardPayment.ShowDialog()
        End If
    End Sub

    Private Sub btnBackToShoppingCart_Click(sender As Object, e As EventArgs) Handles btnBackToShoppingCart.Click
        Me.Hide()
        Cart.Show()
    End Sub

    Private Sub RadioButton_Ewallet_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Ewallet.CheckedChanged

    End Sub
End Class