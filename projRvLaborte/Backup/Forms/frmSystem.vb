Public Class frmSystem

    Private Sub cmdSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSettings.Click
        Dim f As New frmSettings
        f.ShowDialog()
    End Sub

    Private Sub cmdAccounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccounts.Click
        Dim f As New frmAccounts
        f.ShowDialog()
    End Sub

    Private Sub cmdEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEvent.Click
        Dim f As New frmEvent
        f.ShowDialog()
    End Sub

    Private Sub cmdCharging_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCharging.Click
        Dim f As New frmCharging
        f.ShowDialog()
    End Sub

    Private Sub btnLc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLc.Click
        Dim f As New frmLoyaltyRec
        f.ShowDialog()
    End Sub

    Private Sub cmdReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReports.Click
        Dim f As New frmReports
        f.ShowDialog()
    End Sub

    Private Sub cmdAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub cmdTerminate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTerminate.Click
        If MsgBox("Are you sure do you want to quit?    ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "System") = vbYes Then
            RestartExplorer()
            Application.Exit()
        End If
    End Sub

    Private Sub frmSystem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.F1 Then
            cmdSettings_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.F2 Then
            cmdAccounts_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.F3 Then
            cmdEvent_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.F4 Then
            cmdCharging_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.F5 Then
            btnLc_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.F6 Then
            cmdReports_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.F7 Then
            cmdAbout_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.Escape Then
            cmdTerminate_Click(sender, New System.EventArgs)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class