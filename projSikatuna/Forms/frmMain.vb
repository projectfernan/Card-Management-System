Imports ADODB
Public Class frmMain

    Private Sub tmrTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTime.Tick
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

    Sub ResetCards()
        If conServer() = False Then Exit Sub

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = Conn.Execute("update tblincomereport set Status = 1 where Status = 0")
        Catch ex As Exception

        End Try
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
                ResetCards()
            End If
        Else
            txtEvent.Text = "NO SCHEDULED EVENT"
            txtdtEvent.Text = "0000-00-00"
            txtevStart.Text = "00:00:00"
            txtEvend.Text = "00:00:00"
            txtSystemMsg.Text = "Please set Event!"
            ResetCards()
        End If
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
  
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.Control = True And e.KeyCode = Keys.Enter Then
            ' If TxtLockStat.Text = "Locked" Then
            frmLogin.ShowDialog()
            'End If
        End If

        If e.KeyCode = Keys.F1 Then
            If TxtLockStat.Text = "Active" Then
                Call cmdTransact_Click(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.F3 Then
            If TxtLockStat.Text = "Active" Then
                If cmdSystem.Enabled = True Then
                    ' Call cmdSystem_Click(sender, New System.EventArgs)
                End If
            End If
        End If

        If e.KeyCode = Keys.Escape Then
            If TxtLockStat.Text = "Active" Then
                Call cmdLogout_Click(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.Enter Then
            If gpTR.Enabled = True Then
                Call cmdAccept_Click(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.D2 Then
            If gpTR.Enabled = True Then
                Call cmdCancel_Click(sender, New System.EventArgs)
            End If
        End If

    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Lock_Main()

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

    End Sub

    Private Sub cmdTransact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTransact.Click
        If cmdTransact.Enabled = True Then
            ViewEvent()
            If txtEvent.Text = "NO SCHEDULED EVENT" Then
                MsgBox("Unable to make a transaction, there is no sheduled event for today! ", vbExclamation, "Transaction")
                Exit Sub
            End If
            ' frmSelectTr.ShowDialog()
            frmTransact.ShowDialog()
        End If
    End Sub

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click
        With frmSettled
            .txtEvent.Text = txtEventName.Text
            .txtCardTyp.Text = txtCardType.Text
            .txtTimeIn.Text = txtTimeTr.Text
            .ShowDialog()
        End With
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        If MsgBox("Are you sure do you want to cancel this transaction?", vbQuestion + vbYesNo + vbDefaultButton2, "Cancel") = vbYes Then
            Reset_Tr()
            cmdTransact.Enabled = True
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
End Class
