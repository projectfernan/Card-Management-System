Public Class frmDb

    Private Sub frmDb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As New MySqlData
        sql = Get_MySql()

        txtIp1.Text = sql.ServerIp
        txtUser1.Text = sql.Username
        txtPwd1.Text = sql.Password
        txtSPort.Value = CInt(sql.Port)
        cboSdb.Text = sql.Database
        cboOdbc.Text = sql.Odbc
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Set_MySql(txtIp1.Text, txtUser1.Text, txtPwd1.Text, txtSPort.Value, cboSdb.Text, cboOdbc.Text) = False Then
            MessageBox.Show("Failed to save MySql settings!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        With frmMain

            If conServer(txtIp1.Text, txtSPort.Text, cboSdb.Text, txtUser1.Text, txtPwd1.Text, cboOdbc.Text) = False Then
                .txtDbStat.Text = "Disconnected"
                .txtDbStat.ForeColor = Color.LightCoral
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

            If conServer(txtIp1.Text, txtSPort.Text, cboSdb.Text, txtUser1.Text, txtPwd1.Text, cboOdbc.Text) = False Then
                MsgBox("Failed to connect!    ", vbExclamation, "Database connection")
                .txtDbStat.Text = "Disconnected"
                .txtDbStat.ForeColor = Color.LightCoral
                Exit Sub
            Else
                MsgBox("Succesfully connected!    ", vbInformation, "Database connection")
                .txtDbStat.Text = "Connected"
                .txtDbStat.ForeColor = Color.DodgerBlue
            End If
        End With
    End Sub

    Private Sub cboSdb_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSdb.GotFocus

        If conSdb(txtIp1.Text, txtSPort.Text, txtUser1.Text, txtPwd1.Text, cboOdbc.Text) = False Then
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

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cboOdbc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboOdbc.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub
End Class