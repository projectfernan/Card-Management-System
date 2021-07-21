Imports ADODB
Public Class frmMain

    Private Sub tmrTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTime.Tick
        txtTrig.Focus()

        txtTime.Text = Format(Now, "Long Date")
        txtTimer.Text = Format(Now, "HH:mm:ss tt")

        If My.Settings.DesktopLock = True Then
            For Each selProcess As Process In Process.GetProcesses
                If selProcess.ProcessName = "taskmgr" Then
                    selProcess.Kill()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub cmdSystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSystem.Click
        frmSystem.ShowDialog()
    End Sub

    Sub ViewEvent()
        If conServer() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Database connection")
            Exit Sub
        End If

        Dim petsa As String = Format(Now, "yyyy-MM-dd")
        Dim oras As String = Format(Now, "HH:mm:ss")
        Dim rs As New Recordset
        rs = New Recordset

        rs = Conn.Execute("select * from tblevent where EventDate = '" & petsa & "'")
        If rs.EOF = False Then
            If oras <= Format(rs("EventEnd").Value, "HH:mm:ss") Then
                txtEvent.Text = rs("EventName").Value
                txtdtEvent.Text = Format(rs("EventDate").Value, "Long Date")
                txtevStart.Text = Format(rs("EventStart").Value, "HH:mm:ss")
                txtEvend.Text = Format(rs("EventEnd").Value, "HH:mm:ss")
            Else
                txtEvent.Text = "NO SCHEDULED EVENT"
                txtdtEvent.Text = "0000-00-00"
                txtevStart.Text = "00:00:00"
                txtEvend.Text = "00:00:00"
                txtSystemMsg.Text = "Please set Event!"
            End If
        Else
            txtEvent.Text = "NO SCHEDULED EVENT"
            txtdtEvent.Text = "0000-00-00"
            txtevStart.Text = "00:00:00"
            txtEvend.Text = "00:00:00"
            txtSystemMsg.Text = "Please set Event!"
        End If
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If txtOpLabel.Text = "OPERATOR :" Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

       

        'If e.KeyCode = Keys.D2 Then
        'If gpTR.Enabled = True Then
        'Call cmdCancel_Click(sender, New System.EventArgs)
        ' End If
        'End If

    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



        viewBarrierSettings()

        Lock_Main()

        Dim nResult As UInt32


        Try
            nResult = IsInpOutDriverOpen()
        Catch ex As Exception
            nResult = IsInpOutDriverOpen_x64()
            If (nResult <> 0) Then
                m_bX64 = True
            End If
        End Try

        If (nResult = 0) Then
            MsgBox("Unable to open InpOut driver", vbCritical, "System")
        End If


        If My.Settings.DesktopLock = True Then
            disableExplorer()
        End If

        With My.Settings
            txtStation.Text = .STATION
            frmStation.cboStation.Text = .STATION
        End With
        '   txtORno.Text = Ticket_OR_No()
        frmSetOR.txtOR.Text = Ticket_OR_No()
        Reset_Tr()
        ViewDriver()

        ViewConn()
        If conServer() = True Then
            txtDbStat.Text = "Connected"
            txtDbStat.ForeColor = Color.Cyan

            ViewEvent()
            viewPOSSet()

            If frmLogo.chk = False Then
                PicLogo.Image = Logo_Image()
            End If
        Else
            txtDbStat.Text = "Disconnected"
            txtDbStat.ForeColor = Color.Pink
            frmDbSettings.ShowDialog()
        End If

      
        ' TriggerOff()
    End Sub

    Private Sub cmdTransact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTransact.Click
        If cmdTransact.Enabled = True Then
            ViewEvent()
            If txtEvent.Text = "NO SCHEDULED EVENT" Then
                MsgBox("Unable to make a transaction, there is no sheduled event for today! ", vbExclamation, "Transaction")
                Exit Sub
            End If
            frmTransact.ShowDialog()
        End If
    End Sub

    Sub CardVerify(ByVal code As String, ByVal petsa As String)

        If conServer() = False Then
            Exit Sub
        End If



        Dim dtStr As String = Format(Now, "yyyy-MM-dd HH:mm:ss")

        Dim rs As New Recordset

        rs = New Recordset
        rs = Conn.Execute("select CardCode,Event,Status from tblincomereport where CardCode = '" & code & "' and Status = '0' and Event = '" & txtEvent.Text & "' Limit 1")
        If rs.EOF = False Then
            Dim rs3 As New Recordset
            Dim dt As String = Format(Now, "yyyy-MM-dd")
            Dim oras As String = Format(Now, "HH:mm:ss")
            rs3 = New Recordset
            rs3 = Conn.Execute("select * from tblevent where EventName = '" & rs("Event").Value & "'")
            If rs3.EOF = False Then
                Dim Estart As String = Format(rs3("EventStart").Value, "HH:mm:ss")
                Dim Eend As String = Format(rs3("EventEnd").Value, "HH:mm:ss")
                If rs3("EventDate").Value = dt And Estart <= oras And Eend >= oras Then
                    Dim rs2 As New Recordset
                    rs2 = New Recordset
                    rs2.Open("UPDATE tblincomereport SET Status = 1,TimeInserted = '" & dtStr & "' where CardCode = '" & code & "' and Status = 0 and Event = '" & rs("Event").Value & "'", Conn, 1, 2)
                    TriggerOnfunc()
                Else
                End If
            Else

            End If
        Else

        End If
    End Sub

    Sub SAve_Transaction()
        If conServer() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Database Connection")
            frmDbSettings.ShowDialog()
            Exit Sub
        End If

        Try
            P_CardCode = txtBarcode.Text
            P_Card = txtCardType.Text
            P_Tendered = txtCardType.Text
            P_Event = txtEventName.Text
            P_date = Now

            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tblincomereport", Conn, 1, 2)
            rs.AddNew()
            rs("CardCode").Value = txtBarcode.Text
            rs("Event").Value = txtEventName.Text
            rs("CardType").Value = txtCardType.Text
            rs("TimeTransact").Value = Now
            rs("TimeInserted").Value = Now
            rs("Station").Value = txtStation.Text
            rs("Operator").Value = txtOperator.Text
            rs("Status").Value = 0
            rs.Update()

            Update_Bcode()
            Prnt()

            Reset_Tr()
            cmdTransact.Enabled = True

            txtSystemMsg.Text = "---"
            txtTrig.Text = vbNullString
        Catch ex As Exception
            txtSystemMsg.Text = ex.Message
        End Try

    End Sub

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click
        If gpTR.Enabled = True Then
            SAve_Transaction()
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        If gpTR.Enabled = True Then
            If MsgBox("Are you sure do you want to cancel this transaction?", vbQuestion + vbYesNo + vbDefaultButton2, "Cancel") = vbYes Then
                Reset_Tr()
                cmdTransact.Enabled = True
                txtTrig.Text = vbNullString
            End If
        End If       
    End Sub

    Private Sub cmdLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogout.Click
        If MsgBox("Are you sure do you want to logout?", vbQuestion + vbYesNo + vbDefaultButton2, "Logout") = vbYes Then
            If TxtLockStat.Text = "Active" Then
                txtOperator.Text = "---"
                Reset_Tr()
                Lock_Main()
                frmLogin.txtUser.Focus()
            End If
        End If
    End Sub

    Private Sub cmdReprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RePrnt()
    End Sub

    Private Sub txtTrig_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTrig.KeyDown

        If e.Control = True And e.KeyCode = Keys.Enter Then
            If TxtLockStat.Text = "Locked" Then
                frmLogin.ShowDialog()
            End If
        End If

        If e.KeyCode = Keys.F1 Then
            If TxtLockStat.Text = "Active" Then
                Call cmdTransact_Click(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.F2 Then
            If TxtLockStat.Text = "Active" Then
                If cmdSystem.Enabled = True Then
                    Call cmdSystem_Click(sender, New System.EventArgs)
                End If
            End If
        End If

        If e.KeyCode = Keys.Escape Then
            If TxtLockStat.Text = "Active" Then
                Call cmdLogout_Click(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.F3 Then
            Call cmdAccept_Click(sender, New System.EventArgs)
            txtTrig.Text = vbNullString
        End If

        If e.KeyCode = Keys.F4 Then
            Call cmdCancel_Click(sender, New System.EventArgs)
            txtTrig.Text = vbNullString
        End If

        If e.KeyCode = Keys.Enter Then
            CardVerify(txtTrig.Text, Now)
            txtTrig.Text = vbNullString
        End If


    End Sub

    Private Sub txtTrig_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTrig.TextChanged

    End Sub
End Class
