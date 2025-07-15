Public Class EwalletPayment
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        ' nanti kena tambah code here, to make it disappear in cart.
        MsgBox("Your Purchase is Successfull", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Notification")
        Me.Close()
        SuccessfullyPaid.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Cart.Show()
    End Sub
End Class