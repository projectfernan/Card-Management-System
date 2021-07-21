Imports ADODB
Public Class frmReports
    Public rs1 As New Recordset
    Public rs2 As New Recordset
    Public rs3 As New Recordset

    Public Structure MinMaxDate
        Public MinDate As String
        Public MaxDate As String
    End Structure

    Private Sub frmReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CashierList(cboCashier)
        StationList(cboStation)

        CashierList(cboCashier2)
        StationList(cboStation2)

        CashierList(cboCashier3)
        StationList(cboStation3)

        failedLoad("---")

        'Me.TabControl1.TabPages.Remove(TabPage2)
    End Sub

    Sub initLoad()
        lbLoad.Maximum = 100
        lbLoad.Value = 0
        txtLoadMsg.Text = "Please Wait..."
    End Sub

    Sub succeedLoad()
        lbLoad.Maximum = 100
        lbLoad.Value = 100
        txtLoadMsg.Text = "---"
        crtPrev.Visible = True
    End Sub

    Sub failedLoad(ByVal msg As String)
        lbLoad.Maximum = 100
        lbLoad.Value = 0
        txtLoadMsg.Text = msg
        crtPrev.Visible = False
    End Sub

    Sub CashierList(ByVal cbo As ComboBox)
        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = Conn.Execute("CALL get_OperatorList")

        While rs.EOF = False
            cbo.Items.Add(rs("Operator").Value)
            rs.MoveNext()
        End While
    End Sub

    Sub StationList(ByVal cbo As ComboBox)
        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = Conn.Execute("CALL get_StationList")

        While rs.EOF = False
            cbo.Items.Add(rs("Station").Value)
            rs.MoveNext()
        End While
    End Sub

    Sub Find1()

        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmDbSettings.ShowDialog()
            Exit Sub
        End If

        Dim dtf As String = Format(dtFrm.Value, "yyyy-MM-dd HH:mm")
        Dim dtt As String = Format(dtTo.Value, "yyyy-MM-dd HH:mm")

        initLoad()
        lbLoad.Value = 50

        Dim qr As String = "select * from vwetransaction where " & _
                           "Operator like '%" & cboCashier.Text & "%' and " & _
                           "Station like '%" & cboStation.Text & "%' and " & _
                           " TimeInserted >= '" & dtf & "' and TimeInserted <='" & dtt & "' order by TimeInserted " & cboOrder1.Text

        rs1 = New Recordset
        rs1 = Conn.Execute(qr)
        If rs1.EOF = False Then
            Dim ReportPath As String = Application.StartupPath & "\Reports\crtTransRec.rpt"

            If Not IO.File.Exists(ReportPath) Then
                failedLoad("Cannot load Report file!")
                'MsgBox("Cannot load Report file!    ", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Report.Load(ReportPath)
            Report.SetDataSource(rs1)
            crtPrev.ReportSource = Report

            succeedLoad()
        Else
            failedLoad("No record found!")
        End If
    End Sub

    Sub Find2()
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmDbSettings.ShowDialog()
            Exit Sub
        End If

        initLoad()
        lbLoad.Value = 50

        Dim dtf As String = Format(dtFrm2.Value, "yyyy-MM-dd HH:mm")
        Dim dtt As String = Format(dtTo2.Value, "yyyy-MM-dd HH:mm")

        Dim qr As String = "select DateTransact,CardType,SUM(TotalCount)AS TotalCount from vwecardtypecount where " & _
                           "Operator like '%" & cboCashier2.Text & "%' and " & _
                           "Station like '%" & cboStation2.Text & "%' and " & _
                           " DateTransact >= '" & dtf & "' and DateTransact <='" & dtt & "' group by CardType"

        rs1 = New Recordset
        rs1 = Conn.Execute(qr)
        If rs1.EOF = False Then
            Dim ReportPath As String = Application.StartupPath & "\Reports\crtSummRep.rpt"

            If Not IO.File.Exists(ReportPath) Then
                failedLoad("Cannot load Report file!")
                Exit Sub
            End If
            Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Report.Load(ReportPath)
            Report.SetDataSource(rs1)

            Dim mx As New MinMaxDate
            mx = get_MinMaxDt()

            Dim InsCnt As Integer = get_InsCnt()
            Dim NotInsCnt As Integer = get_NotInsCnt()
            Dim goaTotal As Integer = InsCnt + NotInsCnt


            Report.SetParameterValue("MinDate", mx.MinDate)
            Report.SetParameterValue("MaxDate", mx.MaxDate)

            Report.SetParameterValue("InsertedCnt", InsCnt)
            Report.SetParameterValue("NotInsertedCnt", NotInsCnt)
            Report.SetParameterValue("GoaTotal", goaTotal)

            crtPrev.ReportSource = Report

            succeedLoad()
        Else
            failedLoad("No record found!")
        End If
    End Sub

    Function get_NotInsCnt() As Integer
        Try
            If conServer() = False Then
                Return 0
            End If

            Dim dtf As String = Format(dtFrm2.Value, "yyyy-MM-dd HH:mm")
            Dim dtt As String = Format(dtTo2.Value, "yyyy-MM-dd HH:mm")

            Dim notIns As String = "CALL get_NotInsCnt('" & dtf & "','" & dtt & "','" & cboCashier.Text & "','" & cboStation.Text & "')"

            Dim rs As New Recordset
            rs = Conn.Execute(notIns)
            If rs.EOF = False Then
                Return CInt(rs("TotalCount").Value)
            End If
        Catch ex As Exception

        End Try
    End Function

    Function get_InsCnt() As Integer
        Try
            If conServer() = False Then
                Return 0
            End If

            Dim dtf As String = Format(dtFrm2.Value, "yyyy-MM-dd HH:mm")
            Dim dtt As String = Format(dtTo2.Value, "yyyy-MM-dd HH:mm")

            Dim notIns As String = "CALL get_InsCnt('" & dtf & "','" & dtt & "','" & cboCashier.Text & "','" & cboStation.Text & "')"

            Dim rs As New Recordset
            rs = Conn.Execute(notIns)
            If rs.EOF = False Then
                Return CInt(rs("TotalCount").Value)
            End If
        Catch ex As Exception

        End Try
    End Function

    Function get_MinMaxDt() As MinMaxDate
        Dim mx As New MinMaxDate
        Try
            If conServer() = False Then
                mx.MinDate = Format(Now, "yyyy-MM-dd HH:mm")
                mx.MaxDate = Format(Now, "yyyy-MM-dd HH:mm")
                Return mx
            End If

            Dim dtf As String = Format(dtFrm2.Value, "yyyy-MM-dd HH:mm")
            Dim dtt As String = Format(dtTo2.Value, "yyyy-MM-dd HH:mm")

            Dim notIns As String = "CALL get_SummMinMaxDt('" & dtf & "','" & dtt & "','" & cboCashier.Text & "','" & cboStation.Text & "')"

            Dim rs As New Recordset
            rs = Conn.Execute(notIns)
            If rs.EOF = False Then
                mx.MinDate = Format(CDate(rs("MinDate").Value), "yyyy-MM-dd HH:mm")
                mx.MaxDate = Format(CDate(rs("MaxDate").Value), "yyyy-MM-dd HH:mm")
                Return mx
            Else
                mx.MinDate = Format(Now, "yyyy-MM-dd HH:mm")
                mx.MaxDate = Format(Now, "yyyy-MM-dd HH:mm")
                Return mx
            End If
        Catch ex As Exception
            mx.MinDate = Format(Now, "yyyy-MM-dd HH:mm")
            mx.MaxDate = Format(Now, "yyyy-MM-dd HH:mm")
            Return mx
        End Try
    End Function

    Sub Find3()
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmDbSettings.ShowDialog()
            Exit Sub
        End If

        Dim dtf As String = Format(dtFrm3.Value, "yyyy-MM-dd HH:mm")
        Dim dtt As String = Format(dtTo3.Value, "yyyy-MM-dd HH:mm")

        initLoad()
        lbLoad.Value = 50

        Dim qr As String = "select * from vweptslogs where " & _
                           "Operator like '%" & cboCashier3.Text & "%' and " & _
                           "Station like '%" & cboStation3.Text & "%' and " & _
                           " LogTime >= '" & dtf & "' and LogTime <='" & dtt & "'"

        rs1 = New Recordset
        rs1 = Conn.Execute(qr)
        If rs1.EOF = False Then
            Dim ReportPath As String = Application.StartupPath & "\Reports\crtPtsLogs.rpt"

            If Not IO.File.Exists(ReportPath) Then
                failedLoad("Failed to load file!")
                Exit Sub
            End If
            Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Report.Load(ReportPath)
            Report.SetDataSource(rs1)
            crtPrev.ReportSource = Report

            succeedLoad()
        Else
            failedLoad("No record found!")
        End If
    End Sub

    Sub GenTotal()
        Try
            rs2 = New Recordset
            rs2 = Conn.Execute("select sum(Amount) as tt,sum(VAT) as vt,sum(SubTotal) as St from tblincomereport where TimeTransact >= '" & dtFrm.Text & "' and TimeTransact <='" & dtTo.Text & "'")
            If rs2.EOF = False Then

            End If
        Catch ex As Exception
            MainForm.txtSystemMsg.Text = ex.Message
        End Try
    End Sub

    Sub GenTotal2()
        Try
            rs2 = New Recordset
            rs2 = Conn.Execute("select sum(Amount) as tt,sum(VAT) as vt,sum(SubTotal) as St from tblincomereport where Operator like '" & cboCashier.Text & "%' and TimeTransact >= '" & dtFrm2.Text & "' and TimeTransact <='" & dtTo2.Text & "'")
            If rs2.EOF = False Then

            End If
        Catch ex As Exception
            MainForm.txtSystemMsg.Text = ex.Message
        End Try
    End Sub

    Sub GenTotal3()
        Try
            rs2 = New Recordset
            rs2 = Conn.Execute("select sum(Amount) as tt,sum(VAT) as vt,sum(SubTotal) as St from tblincomereport where Status = '0' and TimeTransact >= '" & dtFrm3.Text & "' and TimeTransact <='" & dtTo3.Text & "'")
            If rs2.EOF = False Then

            End If
        Catch ex As Exception
            MainForm.txtSystemMsg.Text = ex.Message
        End Try
    End Sub

    Sub Print1()
        Try
            Dim ReportPath As String = Application.StartupPath & "\Reports\dtDate.rpt"

            If Not IO.File.Exists(ReportPath) Then
                MsgBox("Cannot load Report file!    ", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Report.Load(ReportPath)
            Report.SetDataSource(rs1)
            frmReportView.crtPrev.ReportSource = Report
            frmReportView.ShowDialog()
        Catch ex As Exception
            MainForm.txtSystemMsg.Text = ex.Message
        End Try
    End Sub

    Sub Print2()
        Try
            Dim ReportPath As String = Application.StartupPath & "\Reports\crtCashier.rpt"

            If Not IO.File.Exists(ReportPath) Then
                MsgBox("Cannot load Report file!    ", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Report.Load(ReportPath)
            Report.SetDataSource(rs1)
            frmReportView.crtPrev.ReportSource = Report
            frmReportView.ShowDialog()
        Catch ex As Exception
            MainForm.txtSystemMsg.Text = ex.Message
        End Try
    End Sub

    Sub Print3()
        Try
            Dim ReportPath As String = Application.StartupPath & "\Reports\crtNotInserted.rpt"

            If Not IO.File.Exists(ReportPath) Then
                MsgBox("Cannot load Report file!    ", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Report.Load(ReportPath)
            Report.SetDataSource(rs1)
            frmReportView.crtPrev.ReportSource = Report
            frmReportView.ShowDialog()
        Catch ex As Exception
            MainForm.txtSystemMsg.Text = ex.Message
        End Try
    End Sub

    Private Sub cmdFind1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind1.Click
        Find1()
    End Sub

    Private Sub cmdPrint1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Print1()
    End Sub

    Private Sub cmdFind2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind2.Click
        Find2()
    End Sub

    Private Sub cmdFind3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind3.Click
        Find3()
    End Sub

    Private Sub cmdPrint2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Print2()
    End Sub

    Private Sub cmdPrint3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Print3()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cboOrder2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboOrder2.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboOrder1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboOrder1.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub
End Class