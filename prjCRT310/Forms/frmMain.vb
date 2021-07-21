Imports System.Threading.Thread
Imports System.IO.Ports
Imports System.Text
Imports ADODB
Public Class frmMain
    Dim crt As New CRT310Data
    Dim trId As Integer = 0

    Dim cnt As New Card_Counter


    Private Sub tmeTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeTimer.Tick
        lblTime.Text = Format(Now, "General Date")
    End Sub

    Private Sub cmdSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSettings.Click
        frmSettings.ShowDialog()
    End Sub

    Function Rfid_Position() As Boolean
        Dim i As Integer
        CommClose(Hcom)
        Hcom = CommOpen(crt.Com)
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

        If e.Control = True And e.Alt = True And e.KeyCode = Keys.E Then
            Dim f As New ErrLogs
            f.ShowDialog()
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ConnFLogs() = False Then
            MessageBox.Show("System error! Please contact your software vendor!", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.ExitThread()
        End If

        'ZONE
        ViewZone()

        'BARRIER
        OffBarrier()

        resetCounter()
        cnt = New Card_Counter
        cnt = GET_InsCount()
        txtCounter.Text = cnt.InsCount.ToString

        'START SYSTEM
        btnStart.Image = Image.FromFile(Application.StartupPath & "/imgOn.png")
        btnStart_Click_1(sender, New System.EventArgs)

        'DATABASE
        Dim sql As New MySqlData
        sql = Get_MySql()
        With frmDb
            If conServer(sql.ServerIp, sql.Port, sql.Database, sql.Username, sql.Password, sql.Odbc) = False Then
                txtDbStat.Text = "Disconnected"
                txtDbStat.ForeColor = Color.LightCoral
                Exit Sub
            Else
                txtDbStat.Text = "Connected"
                txtDbStat.ForeColor = Color.DodgerBlue
            End If
        End With
    End Sub

    Sub viewCom()
        With My.Settings
            frmCrt310.txtCRTCOM.Text = .DEV_ComPort
        End With
    End Sub
    Sub ViewZone()
        Dim z As New ZoneData
        z = Get_Zone()

        lblZone.Text = z.Zone
    End Sub

    Function cCode(ByVal code As String) As String
        cCode = Trim(Mid(code, 1, 2)) + Trim(Mid(code, 4, 2)) + Trim(Mid(code, 7, 2)) + Trim(Mid(code, 10, 2)) '11111111
    End Function

    Function GetcardCode() As String
        Dim x(3) As Byte
        Dim i As Integer = 0
        CommClose(Hcom)
        Hcom = CommOpen(crt.Com)
        i = RF_GetCardID(Hcom, x)
        If i = 0 Then
            Dim cardcode As String = ByteToHex(x)
            Return cCode(cardcode)
        Else
            Return vbNullString
        End If
    End Function

    Function EjectRear() As Boolean
        Try
            Dim i As Integer
            CommClose(Hcom)
            Hcom = CommOpen(crt.Com)
            i = CRT310_MovePosition(Hcom, CRT_POSITION.Capture)
            CommClose(Hcom)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Sub CardOut()
        Dim i As Integer
        CommClose(Hcom)
        Hcom = CommOpen(crt.Com)
        i = CRT310_MovePosition(Hcom, CRT_POSITION.Release)
        CommClose(Hcom)
    End Sub

    Function CardVerify() As Boolean
        Try
            If CRT_AUTHEN(3) = False Then
                Return False
            End If

            Dim EvtStart As DateTime = CRT_READ(Hcom, 3, 0)
            Dim EvtEnd As DateTime = CRT_READ(Hcom, 3, 1)
            trId = CInt(CRT_READ(Hcom, 3, 2))
            Dim dtNow As DateTime = Format(Now, "yyyy-MM-dd HH:mm")

            If dtNow >= EvtStart And dtNow <= EvtEnd Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Save_ErrLogs("[CardVerify] frmMain", ex.Message)
            Return False
        End Try
    End Function

    Function ServerCardVerify(ByVal code As String) As Boolean
        Try
            If MySQLconn() = False Then
                Return False
            End If

            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("CALL get_CardExp('" & code & "')")
            If rs.EOF = False Then
                trId = rs("Id").Value
                Dim EvtDt As String = Format(CDate(rs("EventDate").Value), "yyyy-MM-dd")
                Dim StrEvStart As String = Format(CDate(rs("EventStart").Value), "HH:mm")
                Dim EvtStart As DateTime = EvtDt & " " & StrEvStart
                Dim strEvEnd As String = Format(CDate(rs("EventEnd").Value), "HH:mm")
                Dim EvtEnd As DateTime = EvtDt & " " & strEvEnd

                Dim dtNow As DateTime = Format(Now, "yyyy-MM-dd HH:mm")

                If dtNow >= EvtStart And dtNow <= EvtEnd Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub tmeCrt_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeCrt.Tick
        If CRT_INI() = True Then
            Dim cnt As New Card_Counter
            cnt = GET_InsCount()
            txtCounter.Text = cnt.InsCount.ToString

            If Rfid_Position() = True Then
                tmeCrt.Enabled = False
                txtCardStat.Text = "RFID Position"
                txtTriggerStat.Text = "Stanby"
                txtCardCode.Text = GetcardCode()
                txtTime.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")

                If CardVerify() = False Then
                    'If ServerCardVerify(txtCardCode.Text) = False Then
                    CardOut()
                    tmeCrt.Enabled = True
                    Exit Sub
                    'End If
                End If

                If saveInsert(trId, txtCardCode.Text) = False Then
                    saveInsertLoc(trId, txtCardCode.Text)
                Else
                    If bwPushToServer.IsBusy = False Then
                        bwPushToServer.RunWorkerAsync()
                    End If
                End If

                If OpenBarrier() = True Then
                    txtTriggerStat.Text = "Triggered Successfully"
                    txtCardStat.Text = "Card Drop In"
                    If EjectRear() = True Then
                        If bwUpdateCnt.IsBusy = False Then
                            bwUpdateCnt.RunWorkerAsync()
                        End If
                    End If
                Else
                    txtTriggerStat.Text = "Failed to trigger open"
                    CardOut()
                End If
            End If
            tmeCrt.Enabled = True
        Else
            DevStat.Text = "Stop"
            DevStat.ForeColor = Color.LightCoral
        End If
    End Sub

    Function saveInsert(ByVal id As Integer, ByVal CardCod As String) As Boolean
        Try
            Dim sql As New MySqlData
            sql = Get_MySql()

            If conServer(sql.ServerIp, sql.Port, sql.Database, sql.Username, sql.Password, sql.Odbc) = False Then
                txtDbStat.Text = "Disconnected"
                txtDbStat.ForeColor = Color.LightCoral
                Exit Function
            End If

            Dim rs As New Recordset
            'rs = conSqlPOS.Execute("CALL save_CardIns(" & id & ",'" & CardCod & "')")
            'INSERT INTO tblinserted(TrId,CardCode,TimeInserted)VALUES(id,cCode,DATE_FORMAT(NOW(),'%Y-%m-%d %H:%i'))

            Dim dtnow As String = Format(Now, "yyyy-MM-dd HH:mm")
            rs = conSqlPOS.Execute("INSERT INTO tblinserted(TrId,CardCode,TimeInserted)VALUES(" & id & ",'" & CardCod & "','" & dtnow & "')")
            Return True
        Catch ex As Exception
            Save_ErrLogs("[saveInsert] frmMain", ex.Message)
            Return False
        End Try
    End Function

    Function saveInsertLoc(ByVal id As Integer, ByVal CardCod As String) As Boolean
        Try
            Dim tmeNow As String = Format(Now, "yyyy'/'MM'/'dd HH:mm:ss")
            Dim query As String = "INSERT INTO tblinserted([TrId],[CardCode],[TimeInserted])VALUES(" & _
                                   id & ",'" & _
                                   CardCod & "',#" & _
                                   tmeNow & "#)"

            If rsPsCUD(query) = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Save_ErrLogs("[saveInsertLoc] frmMain", ex.Message)
            Return False
        End Try
    End Function

    Sub PushToServer()
        Try
            Dim qr As String = "select * from tblinserted"
            Dim dt As DataTable = rsPsQuery(qr)
            Dim cnt As Integer = 0
            Dim dtCnt As Integer = 0

            If dt IsNot Nothing Then
                dtCnt = dt.Rows.Count - 1
                If dt.Rows.Count > 0 Then
                    For cnt = 0 To dtCnt
                        If saveInsert(CInt(dt.Rows(cnt)("TrId").ToString()), dt.Rows(cnt)("CardCode").ToString()) = True Then
                            rsPsQuery("delete from tblinserted where TrId = " & dt.Rows(cnt)("TrId").ToString())
                        End If
                    Next cnt
                End If
            End If
        Catch ex As Exception
            Save_ErrLogs("[PushToServer] frmMain", ex.Message)
        End Try
    End Sub

    Private Sub bwPushToServer_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwPushToServer.DoWork
        PushToServer()
    End Sub

    Private Sub btnStart_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If btnStart.Text = "&START SYSTEM" Then
            'DEVICE
            crt = Get_CRT310()
            tmeCrt.Interval = crt.Delay

            If CRT_INI() = True Then
                DevStat.Text = "Active"
                DevStat.ForeColor = Color.DodgerBlue
                tmeCrt.Enabled = True
            End If

            tmeCrt.Enabled = True

            btnStart.Image = Image.FromFile(Application.StartupPath & "/imgOff.png")
            btnStart.Text = "&STOP SYSTEM"
        Else
            DevStat.Text = "Stop"
            DevStat.ForeColor = Color.LightCoral
            tmeCrt.Enabled = False


            btnStart.Image = Image.FromFile(Application.StartupPath & "/imgOn.png")
            btnStart.Text = "&START SYSTEM"
        End If
    End Sub

    Sub UpdateCount()
        Dim cnt As New Card_Counter
        cnt = GET_InsCount()

        Dim newCnt As Integer = cnt.InsCount + 1
        Dim dtnow As Date = Format(Now, "yyyy-MM-dd")

        Dim x As New ini(IniFile)
        x.WriteInteger("Counter", "InsCount", newCnt)
        x.WriteString("Counter", "InsDate", dtnow.ToString)
    End Sub

    Sub UpdateTblCount(ByVal cnt As Integer)
        Dim tmeNow As String = Format(Now, "yyyy'/'MM'/'dd")

        Dim delquery As String = "delete from tblcounter"
        Dim query As String = "INSERT INTO tblcounter([Count],[UpdateTime])VALUES(" & cnt & ",#" & tmeNow & "#)"

        If rsPsCUD(delquery) = True Then
            rsPsCUD(query)
        End If
    End Sub

    Sub checkCounter()
        Dim cnt As New insertCount
        cnt = Get_tblCounter()

        If cnt.Count < My.Settings.Counter Then
            UpdateTblCount(My.Settings.Counter)
        ElseIf cnt.Count > My.Settings.Counter Then
            My.Settings.Counter = cnt.Count
            My.Settings.Save()
        End If
    End Sub

    'Sub resetCounter()
    '    Dim cnt As New insertCount
    '    cnt = Get_tblCounter()
    '    Dim dtnow As Date = Format(Now, "yyyy-MM-dd")

    '    If cnt.UpdateTime < dtnow Then
    '        My.Settings.Counter = 0
    '        My.Settings.Save()

    '        UpdateTblCount(My.Settings.Counter)
    '    End If
    'End Sub

    Sub resetCounter()
        Dim cnt As New Card_Counter
        cnt = GET_InsCount()
        Dim dtnow As Date = Format(Now, "yyyy-MM-dd")

        If CDate(cnt.InsDate) < dtnow Then
            Dim x As New ini(IniFile)
            x.WriteInteger("Counter", "InsCount", 0)
            x.WriteString("Counter", "InsDate", dtnow.ToString)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Application.ExitThread()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'testSave(2, "0453203F")
        'Save_ErrLogs("[PushToServer] frmMain", "Test err")
        'UpdateCount()
        'txtCounter.Text = My.Settings.Counter.ToString

        If bwUpdateCnt.IsBusy = False Then
            bwUpdateCnt.RunWorkerAsync()
        End If
    End Sub

    Sub testSave(ByVal id As Integer, ByVal cod As String)
        If saveInsert(id, cod) = False Then
            saveInsertLoc(id, cod)
        Else
            If bwPushToServer.IsBusy = False Then
                bwPushToServer.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub bwUpdateCnt_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwUpdateCnt.DoWork
        resetCounter()
        UpdateCount()
    End Sub
End Class