Imports System.Threading.Thread
Imports System.IO.Ports
Imports System.Text

Module CRT_310_API
    Public Sub Get_PORTS(ByVal Box As ComboBox)
        Box.Items.Clear()
        For Each s As String In My.Computer.Ports.SerialPortNames
            Box.Items.Add(s)
        Next
    End Sub

#Region "VARIABLE"
    Public Hcom As New IntPtr
#End Region

#Region "CRT COMMAND"

    Public Function CRT_INI() As Boolean
        CommClose(Hcom)
        Hcom = 0
        Hcom = CommOpen(frmCrt310.txtCRTCOM.Text)
        If Hcom = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function CRT_MOVE(ByVal _POS As CRT_POSITION) As Boolean

        CommClose(Hcom)
        Hcom = CommOpen(frmCrt310.txtCRTCOM.Text)

        If Hcom = 0 Then
            Return False
        End If

        Dim i As Integer = 0

        Select Case _POS
            Case CRT_POSITION.Capture
                i = CRT310_MovePosition(Hcom, CRT_POSITION.Capture)
            Case CRT_POSITION.RF_POSITION
                i = CRT310_MovePosition(Hcom, CRT_POSITION.RF_POSITION)
            Case CRT_POSITION.Release
                i = CRT310_MovePosition(Hcom, CRT_POSITION.Release)
        End Select

        If i = 0 Then Return True

    End Function

    Public Function CRT_GETSN() As String
        Dim x(3) As Byte
        Dim i As Integer = 0
        i = RF_GetCardID(Hcom, x)

        If i = 0 Then
            Dim cardcode As String = ByteToHex(x)
            Return cardcode
        Else
            Return vbNullString
        End If
    End Function

    Public Function CRT_AUTHEN(ByVal Sec As Byte) As Boolean
        Dim p(5) As Byte
        Dim i As Integer = 0
        p(0) = 255
        p(1) = 255
        p(2) = 255
        p(3) = 255
        p(4) = 255
        p(5) = 255
        i = RF_LoadSecKey(Hcom, Sec, 0, p)
        If i = 0 Then Return True

    End Function

    Public Function CRT_READ(ByVal h As IntPtr, ByVal Sec As Byte, ByVal Block As Byte) As String
        On Error Resume Next
        Dim Data(15) As Byte
        Dim i As Integer = 0

        i = RF_ReadBlock(h, Sec, Block, Data)
        Sleep(100)
        If i = 0 Then
            Dim x As String = ByteToHex(Data)
            x = Replace(x, " ", vbNullString).Trim
            x = HexToString(x)
            x = Replace(x, Chr(0), vbNullString).Trim
            Return x
        Else
            Return vbNullString
        End If
    End Function

#End Region

#Region "HexToByte"
    Private Function HexToByte(ByVal msg As String) As Byte()
        If msg.Length Mod 2 = 0 Then
            On Error Resume Next
            Dim _msg As String = vbNullString
            _msg = msg
            _msg = msg.Replace(" ", "").Trim
            Dim comBuffer As Byte() = New Byte(_msg.Length / 2 - 1) {}
            For i As Integer = 0 To _msg.Length - 1 Step 2
                comBuffer(i / 2) = CByte(Convert.ToByte(_msg.Substring(i, 2), 16))
            Next
            Return comBuffer
        Else
            Return Nothing
        End If
    End Function
#End Region

#Region "ByteToHex"
    Public Function ByteToHex(ByVal comByte As Byte()) As String
        Dim builder As New StringBuilder(comByte.Length * 3)
        For Each data As Byte In comByte
            builder.Append(Convert.ToString(data, 16).PadLeft(2, "0"c).PadRight(3, " "c))
        Next
        Return builder.ToString().ToUpper()
    End Function
#End Region
End Module
