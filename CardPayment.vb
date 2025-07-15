Public Class CardPayment
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If txtCardHolder.Text = "" Or Not RadioButton_Mastercard.Checked AndAlso Not RadioButton_Visa.Checked Or txt_CardNum.Text = "" Or txtCVV.Text = "" Then
            MsgBox("Please Fill in all the Slots", MsgBoxStyle.Critical, "Reminder")
        Else
            MsgBox("Your Purchased is Succesful", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notification")

        End If
        Me.Hide()
        SuccessfullyPaid.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCardHolder.Text = ""
        txt_CardNum.Text = ""
        txtCVV.Text = ""
        RadioButton_Mastercard.Checked = False
        RadioButton_Visa.Checked = False
        dtp_Expiry.Value = DateTime.Today
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Cart.Show()
    End Sub
End Class