Imports ADODB
Public Class MainForm
    Dim OldPts As Integer = 0
    Dim NewPts As Integer = 0
    Dim Operation As String = ""
    Dim ptss As Integer = 0

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

    Private Sub cmdSystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

        If e.Control = True And e.Alt = True And e.KeyCode = Keys.I Then
            If txtOperator.Text = "fernan" Then
                frmInternal.ShowDialog()
            End If
        End If

        If e.Control = True And e.KeyCode = Keys.Insert Then
            If txtOperator.Text = "fernan" Then
                frmSystem.ShowDialog()
            End If
        End If

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

        If e.KeyCode = Keys.F2 Then
            If TxtLockStat.Text = "Active" Then
                Call btnIssuingLC_Click(sender, New System.EventArgs)
            End If
        End If


        If e.KeyCode = Keys.F3 Then
            If TxtLockStat.Text = "Active" Then
                If btnTransLC.Enabled = False Then Exit Sub
                Call btnTransLC_Click(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.Escape Then
            If TxtLockStat.Text = "Active" Then
                If PanelOptPts.Visible = True Then
                    PanelOptPts.Visible = False
                    Exit Sub
                End If
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

    Function updateCardPts() As Boolean
        Try
reWrite:    If d8_conn() = False Then
                MessageBox.Show("Reader is not connected!", "Loyalty Card Points", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            If d8_Card() = False Then
                MessageBox.Show("Please place the card to the reader!", "Loyalty Card Points", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            If D8_LoadKey(1) = False Then
                MessageBox.Show("Failed to write card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    GoTo reWrite
                Else
                    Return False
                End If
            End If

            If D8_Authenticate(1) = False Then
                MessageBox.Show("Failed to write card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    GoTo reWrite
                Else
                    Return False
                End If
            End If

            D8_WriteCard(4, NewPts.ToString)
            d8_Beep()

            RD.dc_halt()

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

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

        If conServer() = True Then
            txtDbStat.Text = "Connected"
            txtDbStat.ForeColor = Color.Cyan

            ViewEvent()
        Else
            txtDbStat.Text = "Disconnected"
            txtDbStat.ForeColor = Color.Pink
            frmDbSettings.ShowDialog()
        End If

        SysActivation()

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

        If PanelOptPts.Visible = True Then
            lblLCName.Text = CustName()
            OldPts = LoyaltyPts()
            If optAddPts.Checked = True Then

                lblOldPts.Text = OldPts.ToString
                lblLCtype.Text = "Add Points"
                Operation = "Gain"

                ptss = My.Settings.LoyaltyPts
                lblPerPts.Text = My.Settings.LoyaltyPts.ToString
                NewPts = OldPts + My.Settings.LoyaltyPts
                lblNewPts.Text = NewPts.ToString
            End If

            If optUsePts.Checked = True Then
                NewPts = OldPts - My.Settings.PtsToBuy

                If NewPts < 0 Then
                    MessageBox.Show("The transaction cannot be proceed! Insufficient loyalty card points.", "Scan Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    PanelOptPts.Visible = False
                    Exit Sub
                End If

                lblOldPts.Text = OldPts.ToString
                lblLCtype.Text = "Use Points"
                Operation = "Deduct"

                ptss = My.Settings.PtsToBuy
                lblPerPts.Text = My.Settings.PtsToBuy.ToString
                lblNewPts.Text = NewPts.ToString
            End If

            PanelOptPts.Visible = False
            grpLoyalty.Enabled = True
            Exit Sub
        End If

        If grpLoyalty.Enabled = True Then
            If MessageBox.Show("Are you sure do you want to use loyalty card in this transaction?", "Settle", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) <> Windows.Forms.DialogResult.Yes Then
                Exit Sub
            End If

resave:     If savePtsUpdate(ptss, Operation, txtOperator.Text, txtStation.Text) = False Then
                MessageBox.Show("Failed to save!", "Settle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                If MessageBox.Show("Retry to save?", "Settle", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    GoTo resave
                End If
                Exit Sub
            End If

            updateCardPts()
        End If

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

    Private Sub btnIssuingLC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIssuingLC.Click
        Dim f As New frmIssueLC
        f.ShowDialog()
    End Sub

    Private Sub btnTransLC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransLC.Click
        Dim f As New frmLoyaltyCard
        f.ShowDialog()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        PanelOptPts.Visible = False
    End Sub

    Private Sub btnScanLoyalty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScanLoyalty.Click
        ScanLoyaltyCard()
    End Sub

    Sub ScanLoyaltyCard()
        Try
recon:      If d8_conn() = False Then
                MessageBox.Show("Reader is not connected!", "Loyalty Card Points", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            d8_Beep()

            If d8_Card() = False Then
                MessageBox.Show("Please place the card to the reader!", "Loyalty Card Points", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim Stat As String = CardStat()

            If Stat <> "TRUE" Then
                MessageBox.Show("The card is not a loyalty card or not registered to any loyal customer!", "Loyalty Card Points", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Close()
                Exit Sub
            End If

            PanelOptPts.Visible = True
            optAddPts.Checked = True
            optAddPts.Focus()
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub
End Class
