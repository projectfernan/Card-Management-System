Public Class frmAbout

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivate.Click
        frmActivation.ShowDialog()
    End Sub

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If MainForm.txtOperator.Text = "fernan" Then
            btnActivate.Visible = True
        End If
    End Sub

    Private Sub btnTeamViewer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeamViewer.Click
        System.Diagnostics.Process.Start("https://www.teamviewer.com/en/teamviewer-automatic-download/")
    End Sub
End Class