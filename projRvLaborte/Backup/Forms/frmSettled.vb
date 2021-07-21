Imports ADODB
Public Class frmSettled
    Dim closing As Boolean = False
    Dim EvDate As String
    Dim EvStart As String
    Dim EvEnd As String

    Dim ORno As String
    Dim cORno As String
    Private Sub frmSettled_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If closing = False Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub frmSettled_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            settleAccessCard()
        End If

        If e.KeyCode = Keys.Escape Then
            If MainForm.grpLoyalty.Enabled = True Then
                closing = False
                Exit Sub
            End If
            closing = True
            Reset_Tr()
            MainForm.cmdTransact.Enabled = True
            Me.Close()
        End If
    End Sub

    Sub settleAccessCard()
        Try
            If txtNotice.Text = "* PLEASE DON'T REMOVE THE CARD! *" Then
                Exit Sub
            End If

            If txtCardTyp.Text = "--" Then
                MessageBox.Show("Unknown card transaction! Please wait the operation to be done!", "Settle", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Close()
                Exit Sub
            End If

            If d8_conn() = True Then
                If d8_Card() = True Then
                    If CardStat() = "TRUE" Then
                        MessageBox.Show("You can't use the loyalty card for issuing of access card!", "Settle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    txtNotice.Text = "* PLEASE DON'T REMOVE THE CARD! *"
                    txtNotice.ForeColor = Color.Red

                    Application.DoEvents()

                    If d8_AuthenOL() = True Then
                        If d8_LoadpassOL() = True Then
                            HexCardID = vbNullString
                            HexCardID = d8_ReadOL()

                            If checkCardExp() = True Then
                                If checkEncoded() = False Then
resave:                             If SAve_Transaction(cORno) = False Then
                                        MessageBox.Show("Something wrong occured in the operation!", "Settle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                        If MessageBox.Show("Retry settle?", "Settle", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                                            GoTo resave
                                        Else
                                            txtNotice.Text = "* Please place the access card to reader. *"
                                            txtNotice.ForeColor = Color.Chocolate
                                        End If
                                    End If
                                End If
                                MessageBox.Show("The card is already encoded!", "Settle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                txtNotice.Text = "* Please place the access card to reader. *"
                                txtNotice.ForeColor = Color.Chocolate
                                Exit Sub
                            Else
                                If checkEncoded() = True Then
redel:                              If deleteCardTrans(ORno) = False Then
                                        MessageBox.Show("Something wrong occured in the operation!", "Settle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                        If MessageBox.Show("Retry settle?", "Settle", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                                            GoTo redel
                                        Else
                                            txtNotice.Text = "* Please place the access card to reader. *"
                                            txtNotice.ForeColor = Color.Chocolate
                                        End If
                                    End If
                                End If
                            End If

                            If writeCardExp() = False Then
                                Exit Sub
                            End If

reTr:                       If updateTr() = False Then
                                MessageBox.Show("Something wrong occured in the operation!", "Settle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                If MessageBox.Show("Retry settle?", "Settle", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                                    GoTo reTr
                                Else
                                    txtNotice.Text = "* Please place the access card to reader. *"
                                    txtNotice.ForeColor = Color.Chocolate
                                End If
                            End If

                            d8_Beep()

                            MessageBox.Show("Card operation successful!", "Settle", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Reset_Tr()
                            MainForm.cmdTransact.Enabled = True
                            MainForm.txtSystemMsg.Text = "---"

                            closing = True

                            Me.Close()

                            RD.dc_halt()
                        Else
                            MsgBox("Failed to load card password, Please place different card! ", vbExclamation, "D8 reader")
                            txtNotice.Text = "* Please place the access card to reader. *"
                            txtNotice.ForeColor = Color.Chocolate
                        End If
                    Else
                        MsgBox("Failed to authenticate the card, Please place different card! ", vbExclamation, "D8 reader")
                        txtNotice.Text = "* Please place the access card to reader. *"
                        txtNotice.ForeColor = Color.Chocolate
                    End If
                Else
                    MsgBox("There is no card detected! ", vbExclamation, "D8 reader")
                End If
            Else
                MsgBox("Reader is not connected ", vbExclamation, "D8 reader")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Function checkEncoded() As Boolean
        Try
            If conServer() = False Then
                Return False
            End If

            Dim rs As New Recordset
            rs = New Recordset

            rs = Conn.Execute("SELECT ORno FROM tblincomereport WHERE CardCode = '" & HexCardID & "' and TimeTransact	>= '" & EvStart & "' AND TimeTransact <= '" & EvEnd & "'")
            If rs.EOF = False Then
                ORno = rs("ORno").Value
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function deleteCardTrans(ByVal ORnum As String) As Boolean
        Try
            Dim rs As New Recordset
            rs = Conn.Execute("delete from tblincomereport where ORno = '" & ORnum & "'")
            Return True
        Catch ex As Exception
            MainForm.txtSystemMsg.Text = ex.Message
            Return False
        End Try
    End Function

    Function checkCardExp() As Boolean
        Try
recon:      If D8_LoadKey(3) = False Then
                MessageBox.Show("Failed to read the card!", "Settle", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If MessageBox.Show("Retry to read card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    GoTo recon
                Else
                    Return False
                End If
            End If

            If D8_Authenticate(3) = False Then
                MessageBox.Show("Failed to read the card!", "Settle", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If MessageBox.Show("Retry to read card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    GoTo recon
                Else
                    Return False
                End If
            End If

            Dim strEvStart As String = d8_RetDate(12)
            Dim strEvEnd As String = d8_RetDate(13)
            cORno = d8_RetData(14)

            Dim dtEvStart As DateTime = Format(CDate(strEvStart), "yyyy-MM-dd HH:mm")
            Dim dtEvEnd As String = Format(CDate(strEvEnd), "yyyy-MM-dd HH:mm")

            Dim dtSetEvStart As DateTime = EvStart
            Dim dtSetEvEnd As DateTime = EvEnd

            If dtSetEvStart <= dtEvStart And dtSetEvEnd >= dtEvEnd Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function

    Function writeCardExp() As Boolean
        Try
recon:      If D8_LoadKey(3) = False Then
                MessageBox.Show("Failed to write card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    GoTo recon
                Else
                    Return False
                End If
            End If

            If D8_Authenticate(3) = False Then
                MessageBox.Show("Failed to write card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    GoTo recon
                Else
                    Return False
                End If
            End If

            If D8_WriteCard(12, EvStart) = False Then
                MessageBox.Show("Failed to write card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    GoTo recon
                Else
                    Return False
                End If
            End If

            If D8_WriteCard(13, EvEnd) = False Then
                MessageBox.Show("Failed to write card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    GoTo recon
                Else
                    Return False
                End If
            End If

            Dim trId As String = My.Settings.TrId.ToString
            If D8_WriteCard(14, trId) = False Then
                MessageBox.Show("Failed to write card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    GoTo recon
                Else
                    Return False
                End If
            End If

            If SAve_Transaction(My.Settings.TrId.ToString) = False Then
                Return False
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function updateTr() As Boolean
        Try
            My.Settings.TrId = My.Settings.TrId + 1
            My.Settings.Save()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function chkCardCode(ByVal code As String) As Boolean
        If conServer() = False Then Return False
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = Conn.Execute("select * from tblincomereport where CardCode = '" & code & "' and Status = '0'")
            If rs.EOF = False Then
                MainForm.txtSystemMsg.Text = "---"
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MainForm.txtSystemMsg.Text = ex.Message
            Return False
        End Try
    End Function

    Function SAve_Transaction(ByVal orNumber As String) As Boolean
        If conServer() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Database Connection")
            frmDbSettings.ShowDialog()
            Return False
        End If

        If txtCardTyp.Text = "--" Then
            MessageBox.Show("Unknown card transaction! Please wait the operation to be done!", "Settle", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
            Me.Close()
        End If

        If HexCardID = "00000000" Then
            MessageBox.Show("Unknown card transaction! Please wait the operation to be done!", "Settle", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
            Me.Close()
        End If

        Try
            With MainForm

                Dim strNow As String = Format(Now, "yyyy-MM-dd HH:mm")
                Dim rs As New Recordset
                rs = Conn.Execute("insert into tblincomereport(ORno,CardCode,Event,CardType,TimeTransact,Station,Operator)VALUES('" & orNumber & _
                                                                                                                                    "','" & HexCardID & _
                                                                                                                                    "','" & .txtEventName.Text & _
                                                                                                                                    "','" & .txtCardType.Text & _
                                                                                                                                    "','" & strNow & _
                                                                                                                                    "','" & .txtStation.Text & _
                                                                                                                                    "','" & .txtOperator.Text & "')")
            End With
            Return True
        Catch ex As Exception
            MainForm.txtSystemMsg.Text = ex.Message
            Return False
        End Try
    End Function

    Private Sub frmSettled_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtNotice.Text = "* Please place the access card to reader. *"
        txtNotice.ForeColor = Color.Chocolate
        closing = False

        With MainForm
            EvDate = Format(CDate(.txtdtEvent.Text), "yyyy-MM-dd")
            EvStart = EvDate & " " & Mid(.txtevStart.Text, 1, 5)
            EvEnd = EvDate & " " & Mid(.txtEvend.Text, 1, 5) '00:00
        End With
    End Sub
End Class