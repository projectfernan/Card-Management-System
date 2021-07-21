Public Class frmSettings

    Private Sub cmdSetZone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetZone.Click
        Dim f As New FrmSetZone
        f.ShowDialog()
    End Sub

    Private Sub cmdDb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDb.Click
        Dim f As New frmDb
        f.ShowDialog()
    End Sub

    Private Sub cmdBarrier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBarrier.Click
        Dim f As New frmBarrier
        f.ShowDialog()
    End Sub

    Private Sub cmdDevice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDevice.Click
        Dim f As New frmCrt310
        f.ShowDialog()
    End Sub

    Private Sub cmdAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbout.Click
        If MsgBox("Are you sure do you want to exit?", vbQuestion + vbYesNo + vbDefaultButton2, "Exit Program") = vbYes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub frmSettings_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            cmdSetZone_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.F2 Then
            cmdDb_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.F3 Then
            cmdBarrier_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.F4 Then
            cmdDevice_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.F5 Then
            cmdSync_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.Escape Then
            cmdAbout_Click(sender, New System.EventArgs)
        End If
    End Sub

    Private Sub cmdSync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSync.Click
        Dim f As New frmSyncDate
        f.ShowDialog()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class