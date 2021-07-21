Public Class frmTender

    Sub Compute(ByVal tender As Double)
        If Val(txtAmount.Text) > tender Then
            MsgBox("Amount entered is not enough!", vbExclamation, "Terder Amount")
            txtTender.Text = vbNullString
        Else
            Dim changeAmt As Double = tender - Val(txtAmount.Text)

            With frmSettled
                '  .txtChange.Text = Format(Math.Round(changeAmt, 2), "0.00")
                .txtEvent.Text = txtAmount.Text
                .txtCardTyp.Text = Format(Math.Round(Val(txtTender.Text), 2), "0.00")
                .ShowDialog()
                Me.Close()
            End With
        End If

    End Sub

    Private Sub frmTender_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
      
    End Sub

    Private Sub frmTender_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '  txtAmount.Text = frmMain.txtTotal.Text
        txtTender.Text = vbNullString
    End Sub

    Private Sub txtTender_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTender.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtTender.Text = "" Then
                MsgBox("Please enter amount!", vbExclamation, "Tender")
                Exit Sub
            End If
            Compute(txtTender.Text)
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtTender_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTender.TextChanged
        If Not IsNumeric(txtTender.Text) Then
            txtTender.Text = vbNullString
        End If
    End Sub
End Class