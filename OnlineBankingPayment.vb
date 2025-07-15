Public Class OnlineBankingPayment
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        ' nanti kena tambah code here, to make it disappear in cart.
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please Fill in all the Slots", MsgBoxStyle.Critical, "Reminder")
        Else
            MsgBox("Your Purchased is Succesful", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notification")
        End If
        Me.Close()
        SuccessfullyPaid.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Cart.Show()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class