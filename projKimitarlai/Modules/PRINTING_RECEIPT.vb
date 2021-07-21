Imports System.Drawing.Printing
Module PRINTING_RECEIPT
    Public RecieptList As ArrayList

    Public P_ORno As String
    Public P_Permit As String
    Public P_TIN As String
    Public P_ACCR As String
    Public P_CardCode As String
    Public P_EntTime As String
    Public P_ExtTime As String
    Public P_TotalTime As String
    Public P_Card As String
    Public P_PlateNo As String

    Public P_HourLy As String
    Public P_Overnigth As String
    Public P_Lost As String
    Public P_Total As String
    Public P_Vat As String
    Public P_VatSale As String
    Public P_Tendered As String
    Public P_Change As String
    Public P_DiscountType As String
    Public P_Discount As String

    Public P_Teller As String
    Public P_Station As String
    Public P_Machine As String
    Public P_Serial As String
    Public P_date As String

    Public P_Msg As String

    Public dvr As String
    ' Constant variable holding the Printer name.
    Public PRINTER_NAME As String = frmPrinter.cboDriver.Text
    ' Variables/Objects.
    Public WithEvents pdPrint As PrintDocument

    Public Function Prnt() As Boolean

        pdPrint = New PrintDocument
        ' Change the printer to the indicated printer
        pdPrint.PrinterSettings.PrinterName = PRINTER_NAME

        If pdPrint.PrinterSettings.IsValid Then
            pdPrint.DocumentName = "Official Receipt"
            ' Start printing
            pdPrint.Print()
            Return True
        Else
            MessageBox.Show("Printer is not available.", "Printer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Private Sub pdPrint_Print(ByVal sender As System.Object, ByVal e As PrintPageEventArgs) Handles pdPrint.PrintPage
        Dim x As Integer = 10, y As Integer = 4, lineOffset As Integer

        ' Instantiate font objects used in printing.
        Dim printFont As New Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point) 'Substituted to FontA Font

        e.Graphics.PageUnit = GraphicsUnit.Point
        lineOffset = printFont.GetHeight(e.Graphics) - 4

        ' Print the receipt text
        y += (lineOffset * 1.0)
        e.Graphics.DrawString(frmSetPOS.txtTitle.Text, printFont, Brushes.Black, x - 3, y - 15)
        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point) 'Substituted to FontA Font

        lineOffset = printFont.GetHeight(e.Graphics) - 4

        y += (lineOffset * 2.75)
        e.Graphics.DrawString(frmSetPOS.txtAdd.Text, printFont, Brushes.Black, x - 2, y - 15)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString(" Contact No.: " & frmSetPOS.txtContact.Text, printFont, Brushes.Black, x - 2, y - 15)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString(" Permit #: ", printFont, Brushes.Black, x - 2, y - 15)
        e.Graphics.DrawString(frmSetPOS.txtPermit.Text, printFont, Brushes.Black, x + 57, y - 15)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString(" TIN : ", printFont, Brushes.Black, x - 2, y - 15)
        e.Graphics.DrawString(frmSetPOS.txtTin.Text, printFont, Brushes.Black, x + 57, y - 15)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString(" Accr #: ", printFont, Brushes.Black, x - 2, y - 15)
        e.Graphics.DrawString(frmSetPOS.txtAccr.Text, printFont, Brushes.Black, x + 57, y - 15)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Machine #:", printFont, Brushes.Black, x, y - 15)
        e.Graphics.DrawString(frmSetPOS.txtMachine.Text, printFont, Brushes.Black, x + 57, y - 15)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Serial #:", printFont, Brushes.Black, x, y - 15)
        e.Graphics.DrawString(frmSetPOS.txtSerial.Text, printFont, Brushes.Black, x + 57, y - 15)

        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point)
        lineOffset = printFont.GetHeight(e.Graphics) - 4

        y += (lineOffset * 0.5)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 15)
        y += (lineOffset * 2.2)
        e.Graphics.DrawString("Official Receipt", printFont, Brushes.Black, x, y - 15)
        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Bold, GraphicsUnit.Point)
        lineOffset = printFont.GetHeight(e.Graphics) - 4
        e.Graphics.DrawString("N0." + " " + P_ORno, printFont, Brushes.Black, x + 90, y - 15)
        y += (lineOffset * 0.7)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 15)

        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point) 'Substituted to FontA Font

        y += (lineOffset * 3.0)
        e.Graphics.DrawString("Card Code :", printFont, Brushes.Black, x, y - 15)
        e.Graphics.DrawString(P_CardCode, printFont, Brushes.Black, x + 85, y - 15)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Card Type :", printFont, Brushes.Black, x, y - 15)
        e.Graphics.DrawString(P_Card, printFont, Brushes.Black, x + 85, y - 15)
    
        y += (lineOffset * 1.5)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 15)
        y += (lineOffset * 2.2)
        e.Graphics.DrawString("Charges", printFont, Brushes.Black, x, y - 15)
        y += (lineOffset * 0.7)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 15)

        y += (lineOffset * 3.0)
        e.Graphics.DrawString("Amount :", printFont, Brushes.Black, x, y - 15)
        e.Graphics.DrawString("P" + " " + P_Total, printFont, Brushes.Black, x + 85, y - 15)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("VAT :", printFont, Brushes.Black, x, y - 15)
        e.Graphics.DrawString("P" + " " + P_Vat, printFont, Brushes.Black, x + 85, y - 15)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("VAT Sale :", printFont, Brushes.Black, x, y - 15)
        e.Graphics.DrawString("P" + " " + P_VatSale, printFont, Brushes.Black, x + 85, y - 15)

        y += (lineOffset * 3.0)
        e.Graphics.DrawString("Amount Tendered :", printFont, Brushes.Black, x, y - 15)
        e.Graphics.DrawString("P" + " " + P_Tendered, printFont, Brushes.Black, x + 85, y - 15)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Change :", printFont, Brushes.Black, x, y - 15)
        e.Graphics.DrawString("P" + " " + P_Change, printFont, Brushes.Black, x + 85, y - 15)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 20)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Operator :", printFont, Brushes.Black, x, y - 15)
        e.Graphics.DrawString(frmMain.txtOperator.Text, printFont, Brushes.Black, x + 85, y - 15)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Station :", printFont, Brushes.Black, x, y - 15)
        e.Graphics.DrawString(frmMain.txtStation.Text, printFont, Brushes.Black, x + 85, y - 15)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Date :", printFont, Brushes.Black, x, y - 15)
        e.Graphics.DrawString(P_date, printFont, Brushes.Black, x + 85, y - 15)
        y += (lineOffset * 2.5)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 20)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString(P_Msg, printFont, Brushes.Black, x, y - 20)

        e.HasMorePages = False
    End Sub

    Public Sub SaveReciept()
        RecieptList = New ArrayList
        With frmMain
            RecieptList.Insert(0, frmSetPOS.txtTitle.Text)
            RecieptList.Insert(1, frmSetPOS.txtAdd.Text)
            RecieptList.Insert(2, frmSetPOS.txtContact.Text)
            RecieptList.Insert(3, frmSetPOS.txtPermit.Text)
            RecieptList.Insert(4, frmSetPOS.txtTin.Text)
            RecieptList.Insert(5, frmSetPOS.txtAccr.Text)
            RecieptList.Insert(6, frmSetPOS.txtMachine.Text)
            RecieptList.Insert(7, frmSetPOS.txtSerial.Text)

            RecieptList.Insert(8, P_ORno)
            RecieptList.Insert(9, P_CardCode)
            RecieptList.Insert(10, P_Card)
            RecieptList.Insert(11, P_Total)
            RecieptList.Insert(12, P_Vat)
            RecieptList.Insert(13, P_VatSale)
            RecieptList.Insert(14, P_Tendered)
            RecieptList.Insert(15, P_Change)

            RecieptList.Insert(16, frmMain.txtOperator.Text)
            RecieptList.Insert(17, frmMain.txtStation.Text)
            RecieptList.Insert(18, P_date)
            RecieptList.Insert(19, "* REPRINT COPY OF OFFICIAL RECEIPT *")

        End With
    End Sub
End Module
