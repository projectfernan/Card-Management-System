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
            Save_ErrLogs("[triger] BARRIER_FUNCTION", ex.Message)
        End Try
    End Sub

    Public Sub trigerOff(ByVal PortAdd As String)
        Try
            Out("&H" + PortAdd, 0)
        Catch ex As Exception
            Save_ErrLogs("[trigerOff] BARRIER_FUNCTION", ex.Message)
        End Try
    End Sub

    Public Function Output(ByVal StatAdd As String) As String
        Try
            Return Inp("&H" + StatAdd)
        Catch ex As Exception
            Save_ErrLogs("[Output] BARRIER_FUNCTION", ex.Message)
            Return vbNullString
        End Try
    End Function

    Public Function OpenBarrier() As Boolean
        Try
            Dim io As New IORelayData
            io = Get_IO_Relay()

            triger(io.PortAdd, io.Port, io.Delay)
            Return True
        Catch ex As Exception
            Save_ErrLogs("[OpenBarrier] BARRIER_FUNCTION", ex.Message)
            Return False
        End Try
    End Function

    Public Sub OffBarrier()
        Dim io As New IORelayData
        io = Get_IO_Relay()
        trigerOff(io.PortAdd)
    End Sub

    Sub ViewIOset()
        With My.Settings
            frmBarrier.txtPortAdd.Text = .B_PortAdd
            frmBarrier.txtStatAdd.Text = .B_StatAdd
            frmBarrier.txtPort.Text = .B_Port
            frmBarrier.txtDelay.Text = .B_Delay
        End With
    End Sub
End Module
