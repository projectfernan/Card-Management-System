Public Class FrmSetZone

    Sub save()
        With My.Settings
            .Zone = cboZone.Text
            .Save()
        End With
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Set_Zone(cboZone.Text) = False Then
            MessageBox.Show("Failed to save zone settings!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        MsgBox("Entry zone successfully set!    ", vbInformation, "Set Zone")
        frmMain.lblZone.Text = cboZone.Text
        Me.Close()
    End Sub

    Private Sub cboSdb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboZone.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmSetZone_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim z As New ZoneData
        z = Get_Zone()

        cboZone.Text = z.Zone
    End Sub
End Class