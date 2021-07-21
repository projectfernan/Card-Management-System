Public Class frmSettings

    Private Sub cmdSetZone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetZone.Click
        FrmSetZone.ShowDialog()
    End Sub

    Private Sub cmdDb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDb.Click
        frmDb.ShowDialog()
    End Sub

    Private Sub cmdBarrier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBarrier.Click
        frmBarrier.ShowDialog()
    End Sub

    Private Sub cmdDevice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDevice.Click
        frmCrt310.ShowDialog()
    End Sub

    Private Sub cmdAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbout.Click
        If MsgBox("Are you sure do you want to exit?", vbQuestion + vbYesNo + vbDefaultButton2, "Exit Program") = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub frmSettings_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            FrmSetZone.ShowDialog()
        End If

        If e.KeyCode = Keys.F2 Then
            frmDb.ShowDialog()
        End If

        If e.KeyCode = Keys.F3 Then
            frmBarrier.ShowDialog()
        End If

        If e.KeyCode = Keys.F5 Then
            frmCrt310.ShowDialog()
        End If

        If e.KeyCode = Keys.F6 Then
            frmSyncDate.ShowDialog()
        End If

        If e.KeyCode = Keys.Escape Then
            If MsgBox("Are you sure do you want to exit?", vbQuestion + vbYesNo + vbDefaultButton2, "Exit Program") = vbYes Then
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub cmdSync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSync.Click
        frmSyncDate.ShowDialog()
    End Sub
End Class