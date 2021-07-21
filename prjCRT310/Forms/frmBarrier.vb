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
        If Set_IO_Relay(txtPortAdd.Text, txtStatAdd.Text, txtPort.Value, txtDelay.Value) = False Then
            MessageBox.Show("Failed to set IO Relay settings!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        MsgBox("Barrier settings saved!    ", vbInformation, "Barrier settings")
        Me.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmBarrier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadIOdata()
    End Sub

    Sub loadIOdata()
        Try
            Dim io As New IORelayData
            io = Get_IO_Relay()

            txtPortAdd.Text = io.PortAdd
            txtStatAdd.Text = io.StatAdd
            txtPort.Value = io.Port
            txtDelay.Value = io.Delay
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class