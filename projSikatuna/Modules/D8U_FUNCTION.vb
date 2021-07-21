
Module D8U_FUNCTION
    Public rd As COMRD800Lib.RD800
    Public st As Integer
    Public st2 As Integer
    Public snr As String
    Public readData As String
    Public HexCardID As String
    Public timeIN As String

    Public Function d8_conn() As Boolean
        rd = New COMRD800Lib.RD800
        st = rd.dc_init(100, 115200)
        If st < 0 Then
            frmMain.txtSystemMsg.Text = "No reader is connected."
            Return False
        Else
            frmMain.txtSystemMsg.Text = "---"
            Return True
        End If
    End Function

    Public Sub d8_Beep()
        rd = New COMRD800Lib.RD800
        st = rd.dc_init(100, 115200)
        If st < 0 Then
            frmMain.txtSystemMsg.Text = "Reader beep error."
        Else
            frmMain.txtSystemMsg.Text = "---"
            rd.dc_beep(10)
        End If
    End Sub

    Public Function d8_Card() As Boolean
        rd = New COMRD800Lib.RD800
        st = rd.dc_init(100, 115200)
        If st < 0 Then
            frmMain.txtSystemMsg.Text = "No card is detected."
            Return False
        Else
            st = rd.dc_card(0, snr)
            If st = 0 Then
                '  MsgBox(snr)
                frmMain.txtSystemMsg.Text = "---"
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Public Function d8_LoadpassOL() As Boolean
        rd.put_bstrSBuffer_asc = "FFFFFFFFFFFF" 'this is load key function
        st = rd.dc_load_key(0, CShort(0))
        If st < 0 Then
            frmMain.txtSystemMsg.Text = "Failed to load the card password."
            Return False
        Else
            frmMain.txtSystemMsg.Text = "---"
            Return True
        End If
    End Function

    Public Function d8_AuthenOL() As Boolean
        st = rd.dc_authentication(0, CShort(0)) 'this is to authentication
        If st < 0 Then
            frmMain.txtSystemMsg.Text = "Failed to authenticate the card."
            Return False
        Else
            frmMain.txtSystemMsg.Text = "---"
            Return True
        End If
    End Function

    Public Function d8_ReadOL() As String
        st = rd.dc_read(CShort(0)) 'this is how to read
        If st < 0 Then
            frmMain.txtSystemMsg.Text = "Failed to read the card."
            Return vbNullString
        Else
            frmMain.txtSystemMsg.Text = "---"
            System.Threading.Thread.Sleep(200)
            Return Trim(Mid(rd.get_bstrRBuffer_asc, 1, 8))
        End If
    End Function
End Module
