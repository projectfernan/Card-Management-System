Public Class frmInternal

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub chkLcOW_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLcOW.CheckedChanged
        My.Settings.LCow = chkLcOW.Checked
        My.Settings.Save()
    End Sub

    Private Sub frmInternal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkLcOW.Checked = My.Settings.LCow
        txtTrId.Value = My.Settings.TrId
    End Sub

    Private Sub btnSettle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettle.Click
        My.Settings.TrId = txtTrId.Value
        My.Settings.Save()

        MessageBox.Show("Internal settings successfully set!", "Set", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class