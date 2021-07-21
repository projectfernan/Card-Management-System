Public Class frmReportType

    Private Sub cmdLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogout.Click
        frmLogout.ShowDialog()
    End Sub

    Private Sub cmdDetailed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDetailed.Click
        frmReports.ShowDialog()
    End Sub

    Private Sub frmReportType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            frmLogout.ShowDialog()
        End If

        If e.KeyCode = Keys.F2 Then
            frmReports.ShowDialog()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class