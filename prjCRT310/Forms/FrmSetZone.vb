Public Class FrmSetZone

    Sub save()
        With My.Settings
            .Zone = cboSdb.Text
            .Save()
        End With
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        save()
        MsgBox("Entry zone successfully set!    ", vbInformation, "Set Zone")
        frmMain.lblZone.Text = cboSdb.Text
        Me.Close()
    End Sub

    Private Sub cboSdb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboSdb.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub
End Class