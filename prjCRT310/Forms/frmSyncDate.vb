Public Class frmSyncDate

    Private Sub cmdSvDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSvDt.Click
        With frmDb
            If PingMe(.txtIp1.Text) = True Then
                If conServer(.txtIp1.Text, .txtSPort.Text, .cboSdb.Text, .txtUser1.Text, .txtPwd1.Text) = True Then
                    txtServerDt.Text = Format(CDate(getservertime()), "yyyy-MM-dd HH:mm:ss")
                Else
                    MsgBox("Please connect to server!    ", MsgBoxStyle.Exclamation, "Database connection")
                    frmDb.ShowDialog()
                End If
            Else
                MsgBox("Please connect to server!    ", MsgBoxStyle.Exclamation, "Database connection")
                frmDb.ShowDialog()
            End If
        End With
    End Sub

    Private Sub cmdLocDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLocDt.Click
        txtLocalDt.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub cmdTest1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest1.Click
        Try
            SetDeviceTime(txtServerDt.Text)
            txtLocalDt.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
            MsgBox("Successfully synchronized!    ", MsgBoxStyle.Information, "Synchronization")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Synchronization")
        End Try
    End Sub
End Class