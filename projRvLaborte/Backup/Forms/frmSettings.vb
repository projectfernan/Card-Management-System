Public Class frmSettings

    Private Sub cmdDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDB.Click
        Dim f As New frmDbSettings
        f.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStation.Click
        Dim f As New frmStation
        f.ShowDialog()
    End Sub

    Private Sub btnPoints_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPoints.Click
        Dim f As New frmLoyaltyPts
        f.ShowDialog()
    End Sub

    Private Sub frmSettings_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            cmdDB_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.F2 Then
            Button1_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.F3 Then
            Call btnPoints_Click(sender, e)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class