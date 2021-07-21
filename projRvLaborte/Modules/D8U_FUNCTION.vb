Imports ADODB
Module D8U_FUNCTION
    Public RD As COMRD800Lib.RD800
    Public st As Integer
    Public st2 As Integer
    Public snr As String
    Public readData As String
    Public HexCardID As String
    Public timeIN As String

    Public Function d8_conn() As Boolean
        RD = New COMRD800Lib.RD800
        st = rd.dc_init(100, 115200)
        If st < 0 Then
            MainForm.txtSystemMsg.Text = "No reader is connected."
            Return False
        Else
            MainForm.txtSystemMsg.Text = "---"
            Return True
        End If
    End Function

    Public Sub d8_Beep()
        rd = New COMRD800Lib.RD800
        st = rd.dc_init(100, 115200)
        If st < 0 Then
            MainForm.txtSystemMsg.Text = "Reader beep error."
        Else
            MainForm.txtSystemMsg.Text = "---"
            rd.dc_beep(10)
        End If
    End Sub

    Public Function d8_Card() As Boolean
        rd = New COMRD800Lib.RD800
        st = rd.dc_init(100, 115200)
        If st < 0 Then
            MainForm.txtSystemMsg.Text = "No card is detected."
            Return False
        Else
            st = rd.dc_card(0, snr)
            If st = 0 Then
                '  MsgBox(snr)
                MainForm.txtSystemMsg.Text = "---"
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
            MainForm.txtSystemMsg.Text = "Failed to load the card password."
            Return False
        Else
            MainForm.txtSystemMsg.Text = "---"
            Return True
        End If
    End Function

    Public Function d8_AuthenOL() As Boolean
        st = rd.dc_authentication(0, CShort(0)) 'this is to authentication
        If st < 0 Then
            MainForm.txtSystemMsg.Text = "Failed to authenticate the card."
            Return False
        Else
            MainForm.txtSystemMsg.Text = "---"
            Return True
        End If
    End Function

    Public Function d8_ReadOL() As String
        st = rd.dc_read(CShort(0)) 'this is how to read
        If st < 0 Then
            MainForm.txtSystemMsg.Text = "Failed to read the card."
            Return vbNullString
        Else
            MainForm.txtSystemMsg.Text = "---"
            System.Threading.Thread.Sleep(200)
            Return Trim(Mid(rd.get_bstrRBuffer_asc, 1, 8))
        End If
    End Function

    Public Function d8_AuthenWr() As Boolean
        Try
            st = rd.dc_authentication(0, CShort(3)) 'this is to authentication
            If st < 0 Then
                Return False
            Else
                Return True
            End If
        Catch
            Return False
        End Try
    End Function

    Public Function D8_LoadKey(ByVal Sector As Short) As Boolean

        RD.put_bstrSBuffer_asc = "FFFFFFFFFFFF"
        st = RD.dc_load_key(0, Sector)
        If st < 0 Then
            errMsg = "Card Password Error"
            Return False
        Else
            errMsg = vbNullString
            Return True
        End If

    End Function

    Public Function D8_Authenticate(ByVal Sector As Short) As Boolean
        st = RD.dc_authentication(0, Sector)
        If st < 0 Then
            errMsg = "Card Authentication Error"
            Return False
        Else
            errMsg = vbNullString
            Return True
        End If
    End Function

    Public Function D8_WriteCard(ByVal address As Short, ByVal StrData As String) As Boolean 'write Date Time ========================
        RD.dc_restore(CShort(address))

        Dim DataL As Integer = StrData.Length
        Dim Spc As Integer = 16 - DataL
        Dim strSpc As String = vbNullString
        strSpc = New String(" ", Spc)

        RD.put_bstrSBuffer_asc = StringToHex(StrData & strSpc)
        st = rd.dc_write(CShort(address))
        If st < 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Function d8_RetData(ByVal addr As Short) As String
        st = RD.dc_read(CShort(addr)) 'this is how to read
        If st < 0 Then
            Return ""
        Else
            System.Threading.Thread.Sleep(200)
            Dim cData As String = Replace(RD.get_bstrRBuffer, " ", "")
            Return cData
        End If
    End Function

    Function d8_RetDate(ByVal addr As Short) As String
        st = RD.dc_read(CShort(addr)) 'this is how to read
        If st < 0 Then
            Return ""
        Else
            System.Threading.Thread.Sleep(200)
            Dim cData As String = RD.get_bstrRBuffer
            Return cData
        End If
    End Function

    Public Function CardStat() As String
        Try
reRead:     If D8_LoadKey(1) = False Then
                MessageBox.Show("Failed to read card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    GoTo reRead
                Else
                    Return "FALSE"
                End If
            End If

            If D8_Authenticate(1) = False Then
                MessageBox.Show("Failed to read card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    GoTo reRead
                Else
                    Return "FALSE"
                End If
            End If

            Dim RetStat As String = d8_RetData(5)

            Return RetStat
        Catch ex As Exception
            Return "FALSE"
        End Try
    End Function

    Public Function LoyaltyPts() As Integer
        Try
reRead:     If D8_LoadKey(1) = False Then
                MessageBox.Show("Failed to read card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    GoTo reRead
                Else
                    Return 0
                End If
            End If

            If D8_Authenticate(1) = False Then
                MessageBox.Show("Failed to read card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    GoTo reRead
                Else
                    Return 0
                End If
            End If

            Dim RetPts As Integer = CInt(d8_RetData(4))

            Return RetPts
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function CustName() As String
        Try
reRead:     If d8_Card() = False Then
                MessageBox.Show("Please place the card to the reader!", "Loyalty Card Points", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return ""
            End If

            If D8_LoadKey(2) = False Then
                MessageBox.Show("Failed to read card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    GoTo reRead
                Else
                    Return ""
                End If
            End If

            If D8_Authenticate(2) = False Then
                MessageBox.Show("Failed to read card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    GoTo reRead
                Else
                    Return ""
                End If
            End If

            Dim LName As String = d8_RetData(8)
            Dim FName As String = d8_RetData(9)
            Dim MI As String = d8_RetData(10)

            Dim FullName As String = LName & ", " & FName & " " & MI
            Return FullName
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function savePtsUpdate(ByVal pts As Integer, ByVal Ope As String, ByVal Optr As String, ByVal Sta As String) As Boolean
        Try
            Dim LogTime As String = Format(Now, "yyyy-MM-dd HH:mm")
            Dim rs As New Recordset
            rs = Conn.Execute("insert into tblptslogs(CardCode,Points,Operation,Operator,Station,LogTime)VALUES('" & _
                              snr & "'," & _
                              pts & ",'" & _
                              Ope & "','" & _
                              Optr & "','" & _
                              Sta & "','" & _
                              LogTime & "')")
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Module
