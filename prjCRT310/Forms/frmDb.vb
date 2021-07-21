Public Class frmDb

    Private Sub frmDb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub save()
        With My.Settings
            .DB_IP1 = txtIp1.Text
            .DB_User1 = txtUser1.Text
            .DB_Pass1 = txtPwd1.Text
            .DB_Db1 = cboSdb.Text

            .Save()
        End With
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        save()
        With frmMain

            If conServer(txtIp1.Text, txtSPort.Text, cboSdb.Text, txtUser1.Text, txtPwd1.Text) = False Then
                .txtDbStat.Text = "Disconnected"
                .txtDbStat.ForeColor = Color.Red
                MsgBox("Database settings saved!    ", vbInformation, "Database settings")
                Me.Close()
                Exit Sub
            Else
                .txtDbStat.Text = "Connected"
                .txtDbStat.ForeColor = Color.DodgerBlue
                MsgBox("Database settings saved!    ", vbInformation, "Database settings")
                Me.Close()
            End If
        End With
    End Sub

    Private Sub cmdTest1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest1.Click
        With frmMain

            If conServer(txtIp1.Text, txtSPort.Text, cboSdb.Text, txtUser1.Text, txtPwd1.Text) = False Then
                MsgBox("Failed to connect!    ", vbExclamation, "Database connection")
                .txtDbStat.Text = "Disconnected"
                .txtDbStat.ForeColor = Color.Red
                Exit Sub
            Else
                MsgBox("Succesfully connected!    ", vbInformation, "Database connection")
                .txtDbStat.Text = "Connected"
                .txtDbStat.ForeColor = Color.DodgerBlue
            End If
        End With
    End Sub

    Private Sub cboSdb_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSdb.GotFocus

        If conSdb(txtIp1.Text, txtSPort.Text, txtUser1.Text, txtPwd1.Text) = False Then
            MsgBox("Failed to connect!    ", vbExclamation, "Database connection")
            Exit Sub
        End If
        viewDB(cboSdb)
    End Sub

    Private Sub cboSdb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboSdb.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub
End Class