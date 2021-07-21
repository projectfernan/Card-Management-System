Public Class frmBarrier

    Private Sub cmdTest1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest1.Click
        If txtPortAdd.Text = vbNullString Then
            MsgBox("Please input port address!    ", vbExclamation, "Port Address")
            Exit Sub
        End If

        If txtPort.Text = vbNullString Then
            MsgBox("Please input port!    ", vbExclamation, "Status Address")
            Exit Sub
        End If

        If txtStatAdd.Text = vbNullString Then
            MsgBox("Please input status address!    ", vbExclamation, "Status Address")
            Exit Sub
        End If

        If txtDelay.Text = vbNullString Then
            MsgBox("Please input delay!    ", vbExclamation, "Status Address")
            Exit Sub
        End If

        triger(txtPortAdd.Text, txtPort.Text, txtDelay.Text)
    End Sub

    Sub save()
        With My.Settings
            .B_PortAdd = txtPortAdd.Text
            .B_StatAdd = txtStatAdd.Text
            .B_Port = txtPort.Text
            .B_Delay = txtDelay.Text
            .Save()
        End With
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        save()
        MsgBox("Barrier settings saved!    ", vbInformation, "Barrier settings")
        Me.Close()
    End Sub
End Class