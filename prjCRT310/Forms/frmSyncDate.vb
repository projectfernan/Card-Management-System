Public Class frmSyncDate

    Private Sub cmdSvDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSvDt.Click
        Dim sql As New MySqlData
        sql = Get_MySql()

        If PingMe(sql.ServerIp) = True Then
            If conServer(sql.ServerIp, sql.Port, sql.Database, sql.Username, sql.Password, sql.Odbc) = True Then
                txtServerDt.Text = Format(CDate(getservertime()), "yyyy-MM-dd HH:mm:ss")
            Else
                MsgBox("Please connect to server!    ", MsgBoxStyle.Exclamation, "Database connection")
                frmDb.ShowDialog()
            End If
        Else
            MsgBox("Please connect to server!    ", MsgBoxStyle.Exclamation, "Database connection")
            frmDb.ShowDialog()
        End If
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

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmSyncDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class