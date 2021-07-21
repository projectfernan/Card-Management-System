Imports System.Drawing.Printing
Imports ADODB
Module LOGOUT_REPORT
    Public WithEvents LOPrint As PrintDocument
    Public OperatorName As String
    Public UserPangalan As String
    Public PetsaDtIn As Date
    Public PetsaDtout As Date

    Public Sub PrntLO(ByVal Opname As String, ByVal OrasdtIn As Date, ByVal OrasdtOut As Date)

        OperatorName = Opname
        'UserPangalan = Usernem
        PetsaDtIn = OrasdtIn
        PetsaDtout = OrasdtOut


        LOPrint = New PrintDocument
        ' Change the printer to the indicated printer
        LOPrint.PrinterSettings.PrinterName = My.Settings.PrinterDriver

        If LOPrint.PrinterSettings.IsValid Then
            LOPrint.DocumentName = "Cashier Log-Out Report"
            ' Start printing
            Dim pp As New Printing.StandardPrintController
            LOPrint.PrintController = pp
            LOPrint.Print()
            LOPrint.Dispose()

        Else
            MessageBox.Show("Printer is not available.", "Printer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Private Sub LOPrint_Print(ByVal sender As System.Object, ByVal e As PrintPageEventArgs) Handles LOPrint.PrintPage

        Dim x As Integer = 2, y As Integer = 4, lineOffset As Integer

        ' Instantiate font objects used in printing.
        Dim printFont As New Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point) 'Substituted to FontA Font

        e.Graphics.PageUnit = GraphicsUnit.Point
        lineOffset = printFont.GetHeight(e.Graphics) - 4

        ' Print the receipt text
        y += (lineOffset * 1.0)
        e.Graphics.DrawString("LA GALLERA DE TANZA", printFont, Brushes.Black, x, y - 9)
        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point) 'Substituted to FontA Font

        lineOffset = printFont.GetHeight(e.Graphics) - 4

        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point)
        lineOffset = printFont.GetHeight(e.Graphics) - 4

        y += (lineOffset * 0.5)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 4)
        y += (lineOffset * 2.2)
        e.Graphics.DrawString("OPERATOR'S  LOG-OUT  REPORT", printFont, Brushes.Black, x + 22, y - 5)
        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Bold, GraphicsUnit.Point)
        lineOffset = printFont.GetHeight(e.Graphics) - 4
        y += (lineOffset * 0.7)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 6)

        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point) 'Substituted to FontA Font

        Dim time1 As Date = PetsaDtIn
        Dim time2 As Date = PetsaDtout
        Dim strOp As String = OperatorName
        Dim strStation As String = frmMain.txtStation.Text

        Dim FromOr As String = OrFrom(strOp, strStation, time1, time2)
        Dim ToOr As String = OrTo(strOp, strStation, time1, time2)

        Dim TotalTrans As Integer = TotalTR(strOp, strStation, time1, time2)

        y += (lineOffset * 3.0)
        e.Graphics.DrawString("Time In : ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(Format(time1, "yyyy-MM-dd HH:mm:ss"), printFont, Brushes.Black, x + 65, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Time Out : ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(Format(time2, "yyyy-MM-dd HH:mm:ss"), printFont, Brushes.Black, x + 65, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Operator : ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(strOp, printFont, Brushes.Black, x + 65, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Station : ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(strStation, printFont, Brushes.Black, x + 65, y - 5)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("ID From :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(FromOr, printFont, Brushes.Black, x + 65, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("ID To :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(ToOr, printFont, Brushes.Black, x + 65, y - 5)

        y += (lineOffset * 1.5)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 3)
        y += (lineOffset * 2.2)
        e.Graphics.DrawString("Transaction Summary", printFont, Brushes.Black, x, y - 5)
        y += (lineOffset * 0.7)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 5)

        Dim strTime1 As String = Format(time1, "yyyy-MM-dd HH:mm:ss")
        Dim strTime2 As String = Format(time2, "yyyy-MM-dd HH:mm:ss")
        Dim rs As New Recordset
        rs = New Recordset


        rs = Conn.Execute("select CardType,Count(CardType)as CardCount from tblincomereport where Station = '" & strStation & "' and Operator = '" & strOp & "' and TimeTransact >= '" & strTime1 & "' and  TimeTransact <= '" & strTime2 & "' group by CardType order by CardType")
        Do While rs.EOF = False
            y += (lineOffset * 2.0)
            e.Graphics.DrawString(rs("CardType").Value, printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString(rs("CardCount").Value, printFont, Brushes.Black, x + 85, y - 5)
            rs.MoveNext()
        Loop
        y += (lineOffset * 0.9)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 5)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Total Transaction : ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(TotalTrans, printFont, Brushes.Black, x + 85, y - 5)

        y += (lineOffset * 0.9)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 5)


        y += (lineOffset * 6.5)
        e.Graphics.DrawString("Signature : _________________________________________________", printFont, Brushes.Black, x, y - 15)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("****** END OF REPORT ******", printFont, Brushes.Black, x - 2, y - 5)


        'BARCODE SAMPLE "---------------------------------------------------------------------------------------------------------------"
        'y += (lineOffset * 2.0)
        'e.Graphics.DrawString("*" & "ABC123" & "*", barcodefont, Brushes.Black, x, y - 20)
        e.HasMorePages = False
    End Sub

    Public Function OrFrom(ByVal op As String, ByVal Station As String, ByVal petsa1 As Date, ByVal petsa2 As Date) As String
        If conServer() = False Then Return "-"
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd HH:mm:ss")
            Dim dt2 As String = Format(petsa2, "yyyy-MM-dd HH:mm:ss")
            Dim rs As New Recordset
            rs = New Recordset
            rs = Conn.Execute("select Min(ID) as MinOr from tblincomereport where Station = '" & Station & "' and Operator = '" & op & "' and TimeTransact >= '" & dt1 & "' and  TimeTransact <= '" & dt2 & "'")
            If rs.EOF = False Then
                Return rs("MinOr").Value
            Else
                Return "-"
            End If
        Catch ex As Exception
            Return "-"
        End Try
    End Function

    Public Function OrTo(ByVal op As String, ByVal Station As String, ByVal petsa1 As Date, ByVal petsa2 As Date) As String
        If conServer() = False Then Return "-"
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd HH:mm:ss")
            Dim dt2 As String = Format(petsa2, "yyyy-MM-dd HH:mm:ss")
            Dim rs As New Recordset
            rs = New Recordset
            rs = Conn.Execute("select Max(ID) as MinOr from tblincomereport where Station = '" & Station & "' and Operator = '" & op & "' and TimeTransact >= '" & dt1 & "' and  TimeTransact <= '" & dt2 & "'")
            If rs.EOF = False Then
                Return rs("MinOr").Value
            Else
                Return "-"
            End If
        Catch ex As Exception
            Return "-"
        End Try
    End Function

    Public Function TotalTR(ByVal op As String, ByVal Station As String, ByVal petsa1 As Date, ByVal petsa2 As Date) As Integer
        If conServer() = False Then Return 0
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd HH:mm:ss")
            Dim dt2 As String = Format(petsa2, "yyyy-MM-dd HH:mm:ss")
            Dim rs As New Recordset
            rs = New Recordset
            rs = Conn.Execute("select ID from tblincomereport where Station = '" & Station & "' and Operator = '" & op & "' and TimeTransact >= '" & dt1 & "' and  TimeTransact <= '" & dt2 & "'")
            If rs.EOF = False Then
                Return rs.RecordCount
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function
End Module
