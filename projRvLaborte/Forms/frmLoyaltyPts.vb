Public Class frmLoyaltyPts

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        My.Settings.LoyaltyPts = txtPts.Value
        My.Settings.PtsToBuy = txtPtsDeduct.Value
        My.Settings.Save()

        MessageBox.Show("Loyalty card points successfully set!", "Set", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub frmLoyaltyPts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPts.Value = My.Settings.LoyaltyPts
        txtPtsDeduct.Value = My.Settings.PtsToBuy
    End Sub
End Class