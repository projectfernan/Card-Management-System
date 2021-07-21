Public Class frmDbSettings
    Sub save()
        With My.Settings
            .DB_IP = txtIp.Text
            .DB_UID = txtUID.Text
            .DB_PWD = txtPWD.Text
            .DB_Port = txtPort.Text
            .Save()
        End With
    End Sub

    Private Sub cmdTest1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest1.Click
        save()
        If conServer() = True Then
            MsgBox("Successfully connected!    ", MsgBoxStyle.Information, "Server Connection")
            MainForm.txtDbStat.Text = "Connected"
            MainForm.txtDbStat.ForeColor = Color.Cyan
        Else
            MsgBox("Failed to connect!    ", MsgBoxStyle.Exclamation, "Server Connection")
            MainForm.txtDbStat.Text = "Disconnected"
            MainForm.txtDbStat.ForeColor = Color.Pink
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("Database settings saved successfully!    ", vbInformation, "Database Settings")
        save()
        Me.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class