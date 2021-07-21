Public Class frmLoyaltyCard
    Dim TotalPts As Integer = 0
    Dim TotalPtsRem As Integer = 0
    Dim NewTotalPts As Integer = 0
    Dim Ope As String = vbNullString

    Private Sub frmLoyaltyCard_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.Enter Then
            If PanelPts.Visible = True Then
                Call btnSettle_Click(sender, New System.EventArgs)
            Else
                Call btnContinue_Click(sender, New System.EventArgs)
            End If
        End If
    End Sub

    Private Sub frmLoyaltyCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loc(Me)
        LodCardData()
    End Sub

    Sub LodCardData()
        Try
recon:      If d8_conn() = False Then
                MessageBox.Show("Reader is not connected!", "Loyalty Card Points", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Close()
                Exit Sub
            End If

            d8_Beep()

            If d8_Card() = False Then
                MessageBox.Show("Please place the card to the reader!", "Loyalty Card Points", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Close()
                Exit Sub
            End If

            Dim Stat As String = CardStat()

            If Stat <> "TRUE" Then
                MessageBox.Show("The card is not a loyalty card or not registered to any loyal customer!", "Loyalty Card Points", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Close()
                Exit Sub
            End If

            txtCustName.Text = CustName()
            TotalPtsRem = LoyaltyPts()
            lblPts.Text = TotalPtsRem.ToString
            lblOldPts.Text = lblPts.Text

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Sub txtPts_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        lblTotalPts.Text = TotalPoints()
    End Sub

    Private Sub txtPts_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblTotalPts.Text = TotalPoints()
    End Sub

    Function TotalPoints() As String
        Try
            If rbtAdd.Checked = True Then
                TotalPts = My.Settings.LoyaltyPts * CInt(txtCardQty.Text)
                NewTotalPts = TotalPtsRem + TotalPts
                lblNewPts.Text = NewTotalPts.ToString
                Ope = "Gain"
                Return TotalPts.ToString & " will earn."
            End If

            If rbtUse.Checked = True Then
                TotalPts = My.Settings.PtsToBuy * CInt(txtCardQty.Text)
                NewTotalPts = TotalPtsRem - TotalPts
                lblNewPts.Text = NewTotalPts.ToString
                Ope = "Deduct"
                Return TotalPts.ToString & " will deduct."
            End If

        Catch ex As Exception
            If rbtAdd.Checked = True Then
                lblNewPts.Text = "0"
                Return "0 will earn."
            End If

            If rbtUse.Checked = True Then
                lblNewPts.Text = "0"
                Return "0 will deduct."
            End If
        End Try
    End Function

    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        If rbtAdd.Checked = True Then
            lblSetPts.Text = My.Settings.LoyaltyPts.ToString()
            lblTotalPts.ForeColor = Color.Blue
        End If

        If rbtUse.Checked = True Then
            lblSetPts.Text = My.Settings.PtsToBuy.ToString()
            lblTotalPts.ForeColor = Color.Red
        End If

        PanelPts.Visible = True

        txtCardQty.Focus()
    End Sub

    Private Sub txtCardQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCardQty.KeyPress
        Select Case Asc(e.KeyChar)
            Case 13
                txtCardQty.Focus()
            Case 32 To 47
                e.KeyChar = vbNullString
            Case 58 To 126
                e.KeyChar = vbNullString
            Case 8, 9, 27 'backspace, tab, esc, space
        End Select
    End Sub

    Private Sub txtCardQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCardQty.TextChanged
        lblTotalPts.Text = TotalPoints()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSettle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettle.Click
        settle()
    End Sub

    Sub settle()
        Try
            If txtCardQty.Text = vbNullString Then
                MessageBox.Show("Please input access card quantity!", "Settle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If MessageBox.Show("Are you sure your entries are correct?", "Settle", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) <> Windows.Forms.DialogResult.Yes Then
                Exit Sub
            End If

            If NewTotalPts < 0 Then
                MessageBox.Show("The loyalty card points is insufficient!", "Settle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

resave:     If savePtsUpdate(TotalPts, Ope, MainForm.txtOperator.Text, MainForm.txtStation.Text) = False Then
                MessageBox.Show("Failed to save!", "Settle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                If MessageBox.Show("Retry to save?", "Settle", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    GoTo resave
                End If
                Exit Sub
            End If

reWrite:    If D8_LoadKey(1) = False Then
                MessageBox.Show("Failed to write card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    GoTo reWrite
                Else
                    Exit Sub
                End If
            End If

            If D8_Authenticate(1) = False Then
                MessageBox.Show("Failed to write card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    GoTo reWrite
                Else
                    Exit Sub
                End If
            End If

            D8_WriteCard(4, NewTotalPts.ToString)
            d8_Beep()

            RD.dc_halt()

            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class