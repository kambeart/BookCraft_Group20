Public Class Transaction_Place

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If RadioButton_Ewallet.Checked Then
            PaymentForm.ShowDialog()
        ElseIf RadioButton_OnlineBank.Checked Then

        ElseIf RadioButton_Card.Checked Then

        End If
    End Sub
End Class