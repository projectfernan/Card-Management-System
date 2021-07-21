Module BARRIER_FUNCTION
    'function to access barrier
    Public Declare Function Inp Lib "inpout32.dll" _
    Alias "Inp32" (ByVal PortAddress As Integer) As Integer
    Public Declare Sub Out Lib "inpout32.dll" _
    Alias "Out32" (ByVal PortAddress As Integer, ByVal Value As Integer)
    'delay function
    Declare Sub Sleep Lib "kernel32" (ByVal MSmiliSeconds As Long)

    Public Sub triger(ByVal PortAdd As String, ByVal Port As String, ByVal delay As String)
        Try
            Dim padd As String
            padd = "&H" + PortAdd
            Out(padd, Val(Port))
            Sleep(Val(delay))
            Out("&H" + PortAdd, 0)
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Barrier settings")
        End Try
    End Sub

    Public Sub trigerOff(ByVal PortAdd As String)
        Try
            Out("&H" + PortAdd, 0)
        Catch ex As Exception

        End Try
    End Sub

    Public Function Output(ByVal StatAdd As String) As String
        Try
            Return Inp("&H" + StatAdd)
        Catch ex As Exception
            Return vbNullString
        End Try
    End Function

    Sub ViewIOset()
        With My.Settings
            frmBarrier.txtPortAdd.Text = .B_PortAdd
            frmBarrier.txtStatAdd.Text = .B_StatAdd
            frmBarrier.txtPort.Text = .B_Port
            frmBarrier.txtDelay.Text = .B_Delay
        End With
    End Sub
End Module
