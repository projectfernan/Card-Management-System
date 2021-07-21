Module TRIGGER_SETTINGS
    'function to access barrier
    Public Declare Function Inp Lib "inpout32.dll" _
    Alias "Inp32" (ByVal PortAddress As Integer) As Integer
    Public Declare Sub Out Lib "inpout32.dll" _
    Alias "Out32" (ByVal PortAddress As Integer, ByVal Value As Integer)

    'delay function
    Declare Sub Sleep Lib "kernel32" (ByVal MSmiliSeconds As Long)

    Public Sub triger()
        Try
            Dim padd As String
            padd = "&H" + frmTrigger.txtPortAdd.Text
            Out(padd, Val(frmTrigger.txtPort.Text))
            Sleep(Val(frmTrigger.txtDelay.Text))
            Out("&H" + frmTrigger.txtPortAdd.Text, 0)
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Trigger settings")
        End Try

    End Sub

    Public Sub trigerOff()
        Try
            Out("&H" + frmTrigger.txtPortAdd.Text, 0)
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Trigger settings")

        End Try
    End Sub

    Public Function Output(ByVal StatAdd As String) As String
        Try
            Return Inp("&H" + StatAdd)
        Catch ex As Exception
            Return vbNullString
        End Try
    End Function

    Public Sub viewBarrierSettings()
        With My.Settings
            frmTrigger.txtPortAdd.Text = .PortAdd
            frmTrigger.txtStatAdd.Text = .StatAdd
            frmTrigger.txtPort.Value = .Port
            frmTrigger.txtDelay.Value = .Delay
        End With
    End Sub
End Module
