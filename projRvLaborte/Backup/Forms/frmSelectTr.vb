Public Class frmSelectTr
    Public flag As Boolean

    Private Sub frmSelectTr_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = flag
    End Sub
    Private Sub frmSelectTr_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If optCoupon.Checked = True Then
                frmCoupon.ShowDialog()
                frmCoupon.txtRefNo.Text = vbNullString
                Me.Close()
            Else
                frmTransact.ShowDialog()
                Me.Close()
            End If
        End If

        If e.KeyCode = Keys.Alt And e.KeyCode = Keys.F4 Then
            flag = True
        End If
    End Sub

End Class