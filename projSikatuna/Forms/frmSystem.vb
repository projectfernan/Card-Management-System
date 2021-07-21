Public Class frmSystem

    Private Sub cmdSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSettings.Click
        frmSettings.ShowDialog()
    End Sub

    Private Sub cmdCharging_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCharging.Click
        frmCharging.ShowDialog()
    End Sub

    Private Sub cmdEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEvent.Click
        frmEvent.ShowDialog()
    End Sub

    Private Sub cmdTerminate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTerminate.Click
        If MsgBox("Are you sure do you want to quit?    ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "System") = vbYes Then
            RestartExplorer()
            Application.Exit()
        End If
    End Sub

    Private Sub cmdAccounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccounts.Click
        frmAccounts.ShowDialog()
    End Sub

    Private Sub cmdAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub cmdReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReports.Click
        frmReports.ShowDialog()
    End Sub

    Private Sub cmdLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSetPOS.ShowDialog()
    End Sub

    Private Sub frmSystem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.F2 Then
            frmSettings.ShowDialog()
        End If

        If e.KeyCode = Keys.F3 Then
            frmAccounts.ShowDialog()
        End If

        If e.KeyCode = Keys.F5 Then
            frmEvent.ShowDialog()
        End If

        If e.KeyCode = Keys.F6 Then
            frmCharging.ShowDialog()
        End If

        If e.KeyCode = Keys.F7 Then
            frmReports.ShowDialog()
        End If

        If e.KeyCode = Keys.F8 Then
            frmAbout.ShowDialog()
        End If

        If e.KeyCode = Keys.Escape Then
            If MsgBox("Are you sure do you want to quit?    ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "System") = vbYes Then
                RestartExplorer()
                Application.Exit()
            End If
        End If
    End Sub
End Class