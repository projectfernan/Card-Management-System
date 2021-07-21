Imports ADODB
Public Class frmSetPOS

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        DelPOS()
        savePOS()
    End Sub

    Sub savePOS()
        If conServer() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Database Connection")
            frmDbSettings.ShowDialog()
            Exit Sub
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select * from tblPOS", Conn, 1, 2)
            rs.AddNew()
            rs("Title").Value = txtTitle.Text
            rs("Address").Value = txtAdd.Text
            rs("ContactNo").Value = txtContact.Text
            rs("TIN").Value = txtTin.Text
            rs("Permit").Value = txtPermit.Text
            rs("Serial").Value = txtSerial.Text
            rs("Machine").Value = txtMachine.Text
            rs("Accr").Value = txtAccr.Text
            rs.Update()

            MsgBox("POS settings succefullt set! ", vbInformation, "Save")
            Me.Close()
        Catch ex As Exception
            MainForm.txtSystemMsg.Text = ex.Message
        End Try

    End Sub

    Sub DelPOS()
        If conServer() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Database Connection")
            frmDbSettings.ShowDialog()
            Exit Sub
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = Conn.Execute("delete from tblPOS")
        Catch ex As Exception
            MainForm.txtSystemMsg.Text = ex.Message
        End Try
    End Sub

    Private Sub chkDesktop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDesktop.CheckedChanged
        My.Settings.DesktopLock = chkDesktop.Checked
        My.Settings.Save()
    End Sub

    Private Sub frmSetPOS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        chkDesktop.Checked = My.Settings.DesktopLock
    End Sub

    Private Sub chkDesktop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDesktop.Click
        MsgBox("To take the effect of this setting, Please restart the application!", vbInformation, "Lock Desktop")
    End Sub

End Class