Public Class frmStation

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        With My.Settings
            MainForm.txtStation.Text = cboStation.Text
            .STATION = cboStation.Text
            .Save()
            MsgBox("Station successfully set!", vbInformation, "Set Station")
            Me.Close()
        End With
    End Sub

    Private Sub cboStation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboStation.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class