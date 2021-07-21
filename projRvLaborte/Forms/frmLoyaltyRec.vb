Public Class frmLoyaltyRec
    Dim qr As String = vbNullString

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmLoyaltyRec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        qr = "select * from vweissuedloyalty where 1=0"

        LoadDgvData(dgvLc, qr, True)
        txtCnt.Text = dgvLc.Rows.Count.ToString
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        qr = "select * from vweissuedloyalty where Customer like '%" & txtKeyword.Text & "%'"

        LoadDgvData(dgvLc, qr, True)
        txtCnt.Text = dgvLc.Rows.Count.ToString
    End Sub

    Private Sub txtKeyword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSearch_Click(sender, New System.EventArgs)
        End If
    End Sub
End Class