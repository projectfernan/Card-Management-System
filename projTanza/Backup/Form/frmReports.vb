Imports ADODB
Public Class frmReports
    Public rs1 As New Recordset
    Public rs2 As New Recordset
    Public rs3 As New Recordset

    Private Sub frmReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CashierList(cboCashier)


    End Sub

    Sub CashierList(ByVal cbo As ComboBox)
        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = Conn.Execute("SELECT Username from tbluseracc")

        While rs.EOF = False
            cbo.Items.Add(rs("Username").Value)
            rs.MoveNext()
        End While
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
            txtTotalCnt.Text = rs1.RecordCount

            Dim ReportPath As String = Application.StartupPath & "\Reports\dtDate.rpt"

            If Not IO.File.Exists(ReportPath) Then
                MsgBox("Cannot load Report file!    ", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Report.Load(ReportPath)
            Report.SetDataSource(rs1)
            frmReportView.crtView.ReportSource = Report
            frmReportView.ShowDialog()

        End If
    End Sub

    Sub Find2()
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmDbSettings.ShowDialog()
            Exit Sub
        End If
        Try
            rs1 = New Recordset
            rs1 = Conn.Execute("select * from tblincomereport where Operator like '" & cboCashier.Text & "%' and TimeTransact >= '" & dtFrm2.Text & "' and TimeTransact <='" & dtTo2.Text & "'")
            If rs1.EOF = False Then
                txtTotalCnt.Text = rs1.RecordCount

                Dim ReportPath As String = Application.StartupPath & "\Reports\crtCashier.rpt"

                If Not IO.File.Exists(ReportPath) Then
                    MsgBox("Cannot load Report file!    ", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
                Report.Load(ReportPath)
                Report.SetDataSource(rs1)
                frmReportView.crtView.ReportSource = Report
                frmReportView.ShowDialog()
            End If
        Catch ex As Exception
            frmMain.txtSystemMsg.Text = ex.Message
        End Try


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
            txtTotalCnt.Text = rs1.RecordCount

            Dim ReportPath As String = Application.StartupPath & "\Reports\crtNotInserted.rpt"

            If Not IO.File.Exists(ReportPath) Then
                MsgBox("Cannot load Report file!    ", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Report.Load(ReportPath)
            Report.SetDataSource(rs1)
            frmReportView.crtView.ReportSource = Report
            frmReportView.ShowDialog()

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

    Private Sub cmdFind1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        GenTotal()
    End Sub

    Private Sub cmdPrint1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint1.Click
        Find1()
    End Sub

    Private Sub cmdFind2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        GenTotal2()
    End Sub

    Private Sub cmdFind3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        GenTotal3()
    End Sub

    Private Sub cmdPrint2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint2.Click
        Find2()
    End Sub

    Private Sub cmdPrint3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint3.Click
        Find3()
    End Sub

    Private Sub cboCashier_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCashier.KeyPress

    End Sub

    Private Sub cboCashier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCashier.SelectedIndexChanged

    End Sub
End Class