Imports ADODB
Public Class frmLogout

    Private Sub cmdPrint2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint2.Click
        If OrFrom(cboCashier.Text, frmMain.txtStation.Text, dtFrm.Value.ToString, dtTo.Value.ToString) <> "-" Then
            PrntLO(cboCashier.Text, dtFrm.Value.ToString, dtTo.Value.ToString)
        Else
            MsgBox("No record found!", vbExclamation, "Print")
        End If
    End Sub

    Sub CashierList(ByVal cbo As ComboBox)
        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = Conn.Execute("SELECT Username from tbluseracc")

        While rs.EOF = False
            cbo.Items.Add(rs("Username").Value)
            rs.MoveNext()
        End While
    End Sub

    Private Sub frmLogout_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        CashierList(cboCashier)
        cboCashier.Text = vbNullString
    End Sub

    Private Sub cboCashier_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCashier.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub frmLogout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class