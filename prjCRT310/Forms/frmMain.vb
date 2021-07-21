Imports System.Threading.Thread
Imports System.IO.Ports
Imports System.Text
Imports ADODB
Public Class frmMain

    Private Sub tmeTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeTimer.Tick
        lblTime.Text = Format(Now, "General Date")
    End Sub

    Private Sub cmdSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSettings.Click
        frmSettings.ShowDialog()
    End Sub

    Function Rfid_Position() As Integer
        Dim i As Integer
        CommClose(Hcom)
        Hcom = CommOpen(frmCrt310.txtCRTCOM.Text)
        i = CRT310_MovePosition(Hcom, CRT_POSITION.RF_POSITION)
        If i = 0 Then
            Return True
        Else
            Return False
        End If
        CommClose(Hcom)
    End Function

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            frmSettings.ShowDialog()
        End If
    End Sub



    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ZONE
        ViewZone()

        'BARRIER
        ViewIOset()
        trigerOff(My.Settings.B_PortAdd)

        'DATABASE
        viewCon()
        frmCrt310.txtCRTCOM.Text = My.Settings.DEV_ComPort
        With frmDb
            If conServer(.txtIp1.Text, .txtSPort.Text, .cboSdb.Text, .txtUser1.Text, .txtPwd1.Text) = False Then
                txtDbStat.Text = "Disconnected"
                txtDbStat.ForeColor = Color.Red
                Exit Sub
            Else
                txtDbStat.Text = "Connected"
                txtDbStat.ForeColor = Color.DodgerBlue

                'DEVICE
                tmeCrt.Interval = My.Settings.DEV_Delay
                viewCom()
                If CRT_INI() = True Then
                    DevStat.Text = "Active"
                    DevStat.ForeColor = Color.DodgerBlue
                    tmeCrt.Enabled = True
                End If
            End If
        End With
    End Sub
    Sub viewCom()
        With My.Settings
            frmCrt310.txtCRTCOM.Text = .DEV_ComPort
        End With
    End Sub
    Sub ViewZone()

        With My.Settings
            If .Zone = vbNullString Then
                Exit Sub
            End If
            FrmSetZone.cboSdb.Text = .Zone
            lblZone.Text = .Zone
        End With
    End Sub

    Function cCode(ByVal code As String) As String
        cCode = Trim(Mid(code, 1, 2)) + Trim(Mid(code, 4, 2)) + Trim(Mid(code, 7, 2)) + Trim(Mid(code, 10, 2)) '11111111
    End Function

    Function GetcardCode() As String
        Dim x(3) As Byte
        Dim i As Integer = 0
        CommClose(Hcom)
        Hcom = CommOpen(frmCrt310.txtCRTCOM.Text)
        i = RF_GetCardID(Hcom, x)
        If i = 0 Then
            Dim cardcode As String = ByteToHex(x)
            Return cCode(cardcode)
        Else
            Return vbNullString
        End If
    End Function

    Sub EjectRear()
        Dim i As Integer
        CommClose(Hcom)
        Hcom = CommOpen(frmCrt310.txtCRTCOM.Text)
        i = CRT310_MovePosition(Hcom, CRT_POSITION.Capture)
        CommClose(Hcom)
    End Sub

    Sub CardOut()
        Dim i As Integer
        CommClose(Hcom)
        Hcom = CommOpen(frmCrt310.txtCRTCOM.Text)
        i = CRT310_MovePosition(Hcom, CRT_POSITION.Release)
        CommClose(Hcom)
    End Sub

    Sub CardVerify(ByVal code As String, ByVal petsa As String)
        With frmDb
            If conServer(.txtIp1.Text, .txtSPort.Text, .cboSdb.Text, .txtUser1.Text, .txtPwd1.Text) = False Then
                Exit Sub
            End If
        End With

        Dim rs As New Recordset

        rs = New Recordset
        rs = conSqlPOS.Execute("select * from tblincomereport where CardCode = '" & code & "' and Status = '0'")
        If rs.EOF = False Then
            Dim rs3 As New Recordset
            Dim dt As String = Format(Now, "yyyy-MM-dd")
            Dim oras As String = Format(Now, "HH:mm:ss")
            rs3 = New Recordset
            rs3 = conSqlPOS.Execute("select * from tblevent where EventName = '" & rs("Event").Value & "'")
            If rs3.EOF = False Then
                Dim Estart As String = Format(rs3("EventStart").Value, "HH:mm:ss")
                Dim Eend As String = Format(rs3("EventEnd").Value, "HH:mm:ss")
                If rs3("EventDate").Value = dt And Estart <= oras And Eend >= oras Then
                    Dim rs2 As New Recordset
                    rs2 = New Recordset
                    rs2.Open("UPDATE tblincomereport SET Status = '1',TimeInserted = '" & petsa & "' where CardCode = '" & code & "'", conSqlPOS, 1, 2)
                    With frmBarrier
                        triger(.txtPortAdd.Text, .txtPort.Text, .txtDelay.Text)
                        txtTriggerStat.Text = "Triggered Successfully"
                    End With
                    txtCardStat.Text = "Card Drop In"
                    EjectRear()
                Else
                    txtCardStat.Text = "Card Out"
                    CardOut()
                End If
            Else
                txtCardStat.Text = "Card Out"
                CardOut()
            End If
        Else
            txtCardStat.Text = "Card Out"
            CardOut()
        End If
    End Sub

    Private Sub tmeCrt_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeCrt.Tick
        If CRT_INI() = True Then
            If Rfid_Position() = True Then
                txtCardStat.Text = "RFID Position"
                txtTriggerStat.Text = "Stanby"
                txtCardCode.Text = GetcardCode()
                txtTime.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
                CardVerify(txtCardCode.Text, txtTime.Text)
            End If
        
        Else
            DevStat.Text = "Stop"
            DevStat.ForeColor = Color.Red
        End If
    End Sub
End Class