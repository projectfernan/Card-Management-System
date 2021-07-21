Public Class frmCoupon

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click
        coupon()
    End Sub

    Sub coupon()
        With MainForm
            .txtEventName.Text = .txtEvent.Text
            .txtCardType.Text = "Coupon"
            .txtTimeTr.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
            ' .txtAmount.Text = "0.00"
            '  .txtVat.Text = "0.00"
            ' .txtSubTotal.Text = "0.00"
            ' .txtTotal.Text = "0.00"
            Coupon_Ref = vbNullString
            Coupon_Ref = txtRefNo.Text
            .gpTR.Enabled = True
            .cmdTransact.Enabled = False
            Me.Close()
        End With
    End Sub

    Private Sub txtRefNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRefNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            coupon()
        End If

        If e.KeyCode = Keys.Escape Then
            MainForm.cmdTransact.Enabled = True
            Me.Close()
        End If
    End Sub

    Private Sub frmCoupon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class