Imports ADODB
Public Class frmReports
    Public rs1 As New Recordset
    Public rs2 As New Recordset
    Public rs3 As New Recordset

    Private Sub frmReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CashierList(cboCashier)

        lstList1.Clear()
        header1()

        lstList2.Clear()
        header2()

        lstList3.Clear()
        header3()
    End Sub

    Sub CashierList(ByVal cbo As ComboBox)
        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = Conn.Execute("SELECT * from tblincomereport")

        While rs.EOF = False
            If Not cbo.Text = rs("Operator").Value Then
                cbo.Text = rs("Operator").Value
                cbo.Items.Add(rs("Operator").Value)
            End If
            rs.MoveNext()
        End While
    End Sub

    Sub header1()
        Dim hd1 As Integer = lstList1.Width / 4
        lstList1.Columns.Add("ID", hd1, HorizontalAlignment.Left)
        lstList1.Columns.Add("CardType", hd1, HorizontalAlignment.Left)
        lstList1.Columns.Add("RefNo", hd1, HorizontalAlignment.Left)
        lstList1.Columns.Add("DateTime", hd1, HorizontalAlignment.Left)
    End Sub

    Sub header2()
        Dim hd2 As Integer = lstList2.Width / 4
        lstList2.Columns.Add("ID", hd2, HorizontalAlignment.Left)
        lstList2.Columns.Add("CardType", hd2, HorizontalAlignment.Left)
        lstList2.Columns.Add("RefNo", hd2, HorizontalAlignment.Left)
        lstList2.Columns.Add("DateTime", hd2, HorizontalAlignment.Left)
    End Sub

    Sub header3()
        Dim hd3 As Integer = lstList3.Width / 4
        lstList3.Columns.Add("ID", hd3, HorizontalAlignment.Left)
        lstList3.Columns.Add("ORno", hd3, HorizontalAlignment.Left)
        lstList3.Columns.Add("CardType", hd3, HorizontalAlignment.Left)
        lstList3.Columns.Add("RefNo", hd3, HorizontalAlignment.Left)
        lstList3.Columns.Add("DateTime", hd3, HorizontalAlignment.Left)
    End Sub


    Sub Find1()
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmDbSettings.ShowDialog()
            Exit Sub
        End If

        rs1 = New Recordset
        rs1 = Conn.Execute("select * from tblIncomeReport where TimeTransact >= '" & dtFrm.Text & "' and TimeTransact <='" & dtTo.Text & "'")
        If rs1.EOF = False Then
            txtLoad.Maximum = rs1.RecordCount
            txtTotalCnt.Text = rs1.RecordCount
            For lup = 1 To rs1.RecordCount
                lstList1.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList1.Items.Add(rs1("ID").Value, lup)
                viewlst.SubItems.Add(rs1("CardType").Value)
                viewlst.SubItems.Add(rs1("RefNo").Value)
                viewlst.SubItems.Add(rs1("TimeInserted").Value)
                rs1.MoveNext()
                txtLoad.Value = lup
                txtCnt.Text = lup
            Next
        End If
    End Sub

    Sub Find2()
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmDbSettings.ShowDialog()
            Exit Sub
        End If

        rs1 = New Recordset
        rs1 = Conn.Execute("select * from tblincomereport where Operator like '" & cboCashier.Text & "%' and TimeTransact >= '" & dtFrm2.Text & "' and TimeTransact <='" & dtTo2.Text & "'")
        If rs1.EOF = False Then
            txtLoad.Maximum = rs1.RecordCount
            txtTotalCnt.Text = rs1.RecordCount
            For lup = 1 To rs1.RecordCount
                lstList2.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList2.Items.Add(rs1("ID").Value, lup)
                viewlst.SubItems.Add(rs1("CardType").Value)
                viewlst.SubItems.Add(rs1("RefNo").Value)
                viewlst.SubItems.Add(rs1("TimeInserted").Value)
                rs1.MoveNext()
                txtLoad.Value = lup
                txtCnt.Text = lup
            Next
        End If
    End Sub

    Sub Find3()
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmDbSettings.ShowDialog()
            Exit Sub
        End If

        rs1 = New Recordset
        rs1 = Conn.Execute("select * from tblincomereport where Status = '0' and TimeTransact >= '" & dtFrm3.Text & "' and TimeTransact <='" & dtTo3.Text & "'")
        If rs1.EOF = False Then
            txtLoad.Maximum = rs1.RecordCount
            txtTotalCnt.Text = rs1.RecordCount
            For lup = 1 To rs1.RecordCount
                lstList3.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList3.Items.Add(rs1("ID").Value, lup)
                viewlst.SubItems.Add(rs1("CardType").Value)
                viewlst.SubItems.Add(rs1("RefNo").Value)
                viewlst.SubItems.Add(rs1("TimeInserted").Value)
                rs1.MoveNext()
                txtLoad.Value = lup
                txtCnt.Text = lup
            Next
        End If
    End Sub

    Sub GenTotal()
        Try
            rs2 = New Recordset
            rs2 = Conn.Execute("select sum(Amount) as tt,sum(VAT) as vt,sum(SubTotal) as St from tblincomereport where TimeTransact >= '" & dtFrm.Text & "' and TimeTransact <='" & dtTo.Text & "'")
            If rs2.EOF = False Then

            End If
        Catch ex As Exception
            frmMain.txtSystemMsg.Text = ex.Message
        End Try
    End Sub

    Sub GenTotal2()
        Try
            rs2 = New Recordset
            rs2 = Conn.Execute("select sum(Amount) as tt,sum(VAT) as vt,sum(SubTotal) as St from tblincomereport where Operator like '" & cboCashier.Text & "%' and TimeTransact >= '" & dtFrm2.Text & "' and TimeTransact <='" & dtTo2.Text & "'")
            If rs2.EOF = False Then

            End If
        Catch ex As Exception
            frmMain.txtSystemMsg.Text = ex.Message
        End Try
    End Sub

    Sub GenTotal3()
        Try
            rs2 = New Recordset
            rs2 = Conn.Execute("select sum(Amount) as tt,sum(VAT) as vt,sum(SubTotal) as St from tblincomereport where Status = '0' and TimeTransact >= '" & dtFrm3.Text & "' and TimeTransact <='" & dtTo3.Text & "'")
            If rs2.EOF = False Then
             
            End If
        Catch ex As Exception
            frmMain.txtSystemMsg.Text = ex.Message
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
            frmMain.txtSystemMsg.Text = ex.Message
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
            frmMain.txtSystemMsg.Text = ex.Message
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
            frmMain.txtSystemMsg.Text = ex.Message
        End Try
    End Sub

    Private Sub cmdFind1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind1.Click
        lstList1.Clear()
        header1()
        Find1()
        GenTotal()
    End Sub

    Private Sub cmdPrint1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint1.Click
        Print1()
    End Sub

    Private Sub cmdFind2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind2.Click
        lstList2.Clear()
        header2()
        Find2()
        GenTotal2()
    End Sub

    Private Sub cmdFind3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind3.Click
        lstList3.Clear()
        header3()
        Find3()
        GenTotal3()
    End Sub

    Private Sub cmdPrint2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint2.Click
        Print2()
    End Sub

    Private Sub cmdPrint3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint3.Click
        Print3()
    End Sub
End Class