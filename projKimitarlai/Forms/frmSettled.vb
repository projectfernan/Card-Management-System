Imports ADODB
Public Class frmSettled

    Private Sub frmSettled_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If d8_conn() = True Then
                If d8_Card() = True Then
                    If d8_AuthenOL() = True Then
                        If d8_LoadpassOL() = True Then
                            HexCardID = vbNullString
                            HexCardID = d8_ReadOL()
                            ' If chkCardCode(HexCardID) = False Then
                            d8_Beep()
                            SAve_Transaction()
                            'Else
                            ' MsgBox("Card is already in used, Please place different card! ", vbExclamation, "D8 reader")
                            'End If
                        Else
                            MsgBox("Failed to load card password, Please place different card! ", vbExclamation, "D8 reader")
                        End If
                    Else
                        MsgBox("Failed to authenticate the card, Please place different card! ", vbExclamation, "D8 reader")
                    End If
                Else
                    MsgBox("There is no card detected! ", vbExclamation, "D8 reader")
                End If
            Else
                MsgBox("Reader is not connected ", vbExclamation, "D8 reader")
            End If
        End If

        If e.KeyCode = Keys.Escape Then
            Reset_Tr()
            frmMain.cmdTransact.Enabled = True
            Me.Close()
        End If
    End Sub

    Function chkCardCode(ByVal code As String) As Boolean
        If conServer() = False Then Return False
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = Conn.Execute("select * from tblincomereport where CardCode = '" & code & "' and Status = '0'")
            If rs.EOF = False Then
                frmMain.txtSystemMsg.Text = "---"
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            frmMain.txtSystemMsg.Text = ex.Message
            Return False
        End Try
    End Function

    Sub SAve_Transaction()
        If conServer() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Database Connection")
            frmDbSettings.ShowDialog()
            Exit Sub
        End If
        ' Try

        With frmMain

            '   P_ORno = .txtORno.Text
            P_CardCode = HexCardID
            P_Card = .txtCardType.Text
            '   P_Total = .txtTotal.Text
            '   P_Vat = .txtVat.Text
            '   P_VatSale = .txtSubTotal.Text
            P_Tendered = txtCardTyp.Text
            '   P_Change = txtChange.Text
            P_date = Now
            P_Msg = "* THIS SERVES AS AN OFFICIAL RECEIPT *"

            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tblincomereport", Conn, 1, 2)
            rs.AddNew()
            '    rs("ORno").Value = .txtORno.Text
            rs("CardCode").Value = HexCardID
            rs("Event").Value = .txtEventName.Text
            rs("CardType").Value = .txtCardType.Text
            rs("RefNo").Value = Coupon_Ref
            '   rs("Amount").Value = .txtTotal.Text
            '   rs("VAT").Value = .txtVat.Text
            '   rs("SubTotal").Value = .txtSubTotal.Text
            '   rs("TenderAmount").Value = txtTendered.Text
            '   rs("Change").Value = txtChange.Text
            rs("TimeTransact").Value = Now
            rs("TimeInserted").Value = Now
            rs("Station").Value = .txtStation.Text
            rs("Operator").Value = .txtOperator.Text
            rs("Status").Value = 0
            rs.Update()

            '  Prnt()
            'SaveReciept()

            '   Update_OR()
            '   .txtORno.Text = Ticket_OR_No()
            Reset_Tr()
            .cmdTransact.Enabled = True

            frmMain.txtSystemMsg.Text = "---"

            Me.Close()
        End With
        ' Catch ex As Exception
        'frmMain.txtSystemMsg.Text = ex.Message
        ' End Try
    End Sub
End Class