Public Class frmSetOR

    Private Sub frmSetOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtOR.Text = Ticket_OR_No()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Do you want to reset the OR Number?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then Exit Sub
        Restore_OR(txtCnt.Value)
        txtOR.Text = Ticket_OR_No()
    End Sub
End Class