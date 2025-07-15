Public Class SuccessfullyPaid
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Hide()
        Cart.Show()
    End Sub
End Class