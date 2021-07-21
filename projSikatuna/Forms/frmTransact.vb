Imports ADODB
Public Class frmTransact

    Sub loc()
        Me.Top = Screen.PrimaryScreen.Bounds.Height - 375
        'Dim w As Integer = frmMain.CamEntry.Width + 17
        Me.Left = Screen.PrimaryScreen.Bounds.Left + 13
    End Sub

    Sub header()
        Dim w As Integer = lstList.Width / 2
        Dim w2 As Integer = w / 2
        lstList.Columns.Add("Key", w2, HorizontalAlignment.Left)
        lstList.Columns.Add("Charging", w2 + w, HorizontalAlignment.Left)
    End Sub

    Sub fillL()
        ' On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = Conn.Execute("select CardType,`Key` from tblcharging order By `Key`")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Key").Value, lup)
                viewlst.SubItems.Add(rs("CardType").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Function Get_Vtype(ByVal K As String) As String
        If conServer() = False Then Return vbNullString

        Try
            Dim rs As New Recordset

            rs = New Recordset

            rs = Conn.Execute("select * from tblcharging where `Key` = '" & K & "'")
            If rs.EOF = False Then
                Return rs("CardType").Value
            Else
                Return vbNullString
            End If
        Catch ex As Exception
            Return vbNullString
        End Try
    End Function


    Private Sub frmTransact_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.F1 Then
            Dim vtp As String = Get_Vtype("F1")
            If vtp <> vbNullString Then
                transact(vtp)
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F2 Then
            Dim vtp As String = Get_Vtype("F2")
            If vtp <> vbNullString Then
                transact(vtp)
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F3 Then
            Dim vtp As String = Get_Vtype("F3")
            If vtp <> vbNullString Then
                transact(vtp)
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F4 Then
            Dim vtp As String = Get_Vtype("F4")
            If vtp <> vbNullString Then
                transact(vtp)
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F5 Then
            Dim vtp As String = Get_Vtype("F5")
            If vtp <> vbNullString Then
                transact(vtp)
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F6 Then
            Dim vtp As String = Get_Vtype("F6")

            If vtp <> vbNullString Then
                transact(vtp)
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F7 Then
            Dim vtp As String = Get_Vtype("F7")
            If vtp <> vbNullString Then
                transact(vtp)
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F8 Then
            Dim vtp As String = Get_Vtype("F8")
            If vtp <> vbNullString Then
                transact(vtp)
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F9 Then
            Dim vtp As String = Get_Vtype("F9")
            If vtp <> vbNullString Then
                transact(vtp)
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F10 Then
            Dim vtp As String = Get_Vtype("F10")
            If vtp <> vbNullString Then
                transact(vtp)
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F11 Then
            Dim vtp As String = Get_Vtype("F11")
            If vtp <> vbNullString Then
                transact(vtp)
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            Dim vtp As String = Get_Vtype("F12")
            If vtp <> vbNullString Then
                transact(vtp)
                Me.Close()
            End If
        End If


        If e.KeyCode = Keys.Escape Then
            frmMain.cmdTransact.Enabled = True
            Me.Close()
        End If
    End Sub

    Private Sub frmTransact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conServer() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Database Connection")
            frmDbSettings.ShowDialog()
            Exit Sub
        End If

    End Sub

    Function chkEvent(ByVal evnt As String) As Boolean
        'If conServer() = False Then Return False
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = Conn.Execute("select * from tblevent where EventName = '" & evnt & "'")
            If rs.EOF = False Then
                Dim petsa As String = Format(Now, "yyyy-MM-dd")
                Dim oras As String = Format(Now, "HH:mm:ss")
                Dim EvntEnd As String = Format(rs("EventEnd").Value, "HH:mm:ss")

                If rs("EventDate").Value = petsa Then
                    If EvntEnd >= oras Then
                        Return True
                    End If
                End If
            Else
                Return False
            End If

        Catch
            Return False
        End Try
    End Function

    Sub CardList(ByVal cbo As ComboBox)
        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = Conn.Execute("SELECT * from tblcharging")
        If rs.EOF = False Then
            If chkEvent(rs("Event").Value) = True Then
                While rs.EOF = False
                    cbo.Items.Add(rs("CardType").Value)
                    rs.MoveNext()
                End While
            End If
        End If

    End Sub

    Sub transact(ByVal Card As String)
        If conServer() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Database Connection")
            frmDbSettings.ShowDialog()
            Exit Sub
        End If

        Dim ch As New Charging_Str
        Dim rs As New Recordset
        rs = New Recordset
        rs = Conn.Execute("select * from tblcharging where CardType = '" & Card & "'")
        If rs.EOF = False Then

            ch.C_CardType = rs("CardType").Value.ToString
            ch.C_Event = rs("Event").Value.ToString
            'ch.C_Amount = rs("Amount").Value.ToString
            'ch.C_VAT = rs("VAT").Value.ToString

            Dim vat1 As Double = ch.C_VAT + 1
            Dim vat2 As Double = ch.C_Amount / vat1
            Dim Fvat As Double = vat2 * ch.C_VAT

            If ch.C_VAT = 0 Then
                ch.C_SubTotal = 0
            Else
                ch.C_SubTotal = ch.C_Amount - Fvat
            End If

            With frmMain
                .cmdTransact.Enabled = False
                .txtEventName.Text = ch.C_Event
                .txtCardType.Text = ch.C_CardType
                .txtTimeTr.Text = Format(Now, "yyyy-MM-dd HH:mm:ss")
                '.txtAmount.Text = Format(Math.Round(ch.C_Amount, 2), "0.00")
                '.txtVat.Text = Format(Math.Round(Fvat, 2), "0.00")
                '.txtSubTotal.Text = Format(Math.Round(ch.C_SubTotal, 2), "0.00")
                '.txtTotal.Text = Format(Math.Round(ch.C_Amount, 2), "0.00")
                Coupon_Ref = vbNullString
                Coupon_Ref = "NA"
                .gpTR.Enabled = True
                Me.Close()
            End With
        End If
    End Sub

    Private Sub cboCardType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub frmTransact_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If conServer() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Database Connection")
            frmDbSettings.ShowDialog()
            Exit Sub
        End If

        lstList.Clear()
        header()
        fillL()
        ' CardList(cboCardType)
        loc()
    End Sub
End Class