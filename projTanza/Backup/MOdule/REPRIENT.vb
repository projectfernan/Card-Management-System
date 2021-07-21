Imports System.Drawing.Printing
Module REPRIENT
    ' Constant variable holding the Printer name.
    Public PRINTER_NAME As String = frmPrinter.cboDriver.Text
    ' Variables/Objects.
    Public WithEvents pdPrint As PrintDocument

    Public Function RePrnt() As Boolean

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

    Private Sub pdRePrint_Print(ByVal sender As System.Object, ByVal e As PrintPageEventArgs) Handles pdPrint.PrintPage
        Try
            Dim x As Integer = 10, y As Integer = 4, lineOffset As Integer

            ' Instantiate font objects used in printing.
            Dim printFont As New Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point) 'Substituted to FontA Font

            e.Graphics.PageUnit = GraphicsUnit.Point
            lineOffset = printFont.GetHeight(e.Graphics) - 4

            ' Print the receipt text
            y += (lineOffset * 1.0)
            e.Graphics.DrawString(RecieptList.Item(0), printFont, Brushes.Black, x - 3, y - 15)
            printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point) 'Substituted to FontA Font

            lineOffset = printFont.GetHeight(e.Graphics) - 4

            y += (lineOffset * 2.75)
            e.Graphics.DrawString(RecieptList.Item(1), printFont, Brushes.Black, x - 2, y - 15)
            y += (lineOffset * 2.0)
            e.Graphics.DrawString(" Contact No.: " & RecieptList.Item(2), printFont, Brushes.Black, x - 2, y - 15)
            y += (lineOffset * 2.0)
            e.Graphics.DrawString(" Permit #: ", printFont, Brushes.Black, x - 2, y - 15)
            e.Graphics.DrawString(RecieptList.Item(3), printFont, Brushes.Black, x + 57, y - 15)
            y += (lineOffset * 2.0)
            e.Graphics.DrawString(" TIN : ", printFont, Brushes.Black, x - 2, y - 15)
            e.Graphics.DrawString(RecieptList.Item(4), printFont, Brushes.Black, x + 57, y - 15)
            y += (lineOffset * 2.0)
            e.Graphics.DrawString(" Accr #: ", printFont, Brushes.Black, x - 2, y - 15)
            e.Graphics.DrawString(RecieptList.Item(5), printFont, Brushes.Black, x + 57, y - 15)
            y += (lineOffset * 2.0)
            e.Graphics.DrawString("Machine #:", printFont, Brushes.Black, x, y - 15)
            e.Graphics.DrawString(RecieptList.Item(6), printFont, Brushes.Black, x + 57, y - 15)
            y += (lineOffset * 2.0)
            e.Graphics.DrawString("Serial #:", printFont, Brushes.Black, x, y - 15)
            e.Graphics.DrawString(RecieptList.Item(7), printFont, Brushes.Black, x + 57, y - 15)

            printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point)
            lineOffset = printFont.GetHeight(e.Graphics) - 4

            y += (lineOffset * 0.5)
            e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 15)
            y += (lineOffset * 2.2)
            e.Graphics.DrawString("Official Receipt", printFont, Brushes.Black, x, y - 15)
            printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Bold, GraphicsUnit.Point)
            lineOffset = printFont.GetHeight(e.Graphics) - 4
            e.Graphics.DrawString("N0." + " " + RecieptList.Item(8), printFont, Brushes.Black, x + 90, y - 15)
            y += (lineOffset * 0.7)
            e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 15)

            printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point) 'Substituted to FontA Font

            y += (lineOffset * 3.0)
            e.Graphics.DrawString("Card Code :", printFont, Brushes.Black, x, y - 15)
            e.Graphics.DrawString(RecieptList.Item(9), printFont, Brushes.Black, x + 85, y - 15)
            y += (lineOffset * 2.0)
            e.Graphics.DrawString("Card Type :", printFont, Brushes.Black, x, y - 15)
            e.Graphics.DrawString(RecieptList.Item(10), printFont, Brushes.Black, x + 85, y - 15)

            y += (lineOffset * 1.5)
            e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 15)
            y += (lineOffset * 2.2)
            e.Graphics.DrawString("Charges", printFont, Brushes.Black, x, y - 15)
            y += (lineOffset * 0.7)
            e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 15)

            y += (lineOffset * 3.0)
            e.Graphics.DrawString("Amount :", printFont, Brushes.Black, x, y - 15)
            e.Graphics.DrawString("P" + " " + RecieptList.Item(11), printFont, Brushes.Black, x + 85, y - 15)

            y += (lineOffset * 2.0)
            e.Graphics.DrawString("VAT :", printFont, Brushes.Black, x, y - 15)
            e.Graphics.DrawString("P" + " " + RecieptList.Item(12), printFont, Brushes.Black, x + 85, y - 15)
            y += (lineOffset * 2.0)
            e.Graphics.DrawString("VAT Sale :", printFont, Brushes.Black, x, y - 15)
            e.Graphics.DrawString("P" + " " + RecieptList.Item(13), printFont, Brushes.Black, x + 85, y - 15)

            y += (lineOffset * 3.0)
            e.Graphics.DrawString("Amount Tendered :", printFont, Brushes.Black, x, y - 15)
            e.Graphics.DrawString("P" + " " + RecieptList.Item(14), printFont, Brushes.Black, x + 85, y - 15)
            y += (lineOffset * 2.0)
            e.Graphics.DrawString("Change :", printFont, Brushes.Black, x, y - 15)
            e.Graphics.DrawString("P" + " " + RecieptList.Item(15), printFont, Brushes.Black, x + 85, y - 15)

            y += (lineOffset * 2.0)
            e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 20)

            y += (lineOffset * 2.0)
            e.Graphics.DrawString("Operator :", printFont, Brushes.Black, x, y - 15)
            e.Graphics.DrawString(RecieptList.Item(16), printFont, Brushes.Black, x + 85, y - 15)
            y += (lineOffset * 2.0)
            e.Graphics.DrawString("Station :", printFont, Brushes.Black, x, y - 15)
            e.Graphics.DrawString(RecieptList.Item(17), printFont, Brushes.Black, x + 85, y - 15)
            y += (lineOffset * 2.0)
            e.Graphics.DrawString("Date :", printFont, Brushes.Black, x, y - 15)
            e.Graphics.DrawString(RecieptList.Item(18), printFont, Brushes.Black, x + 85, y - 15)
            y += (lineOffset * 2.5)
            e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 20)

            y += (lineOffset * 2.0)
            e.Graphics.DrawString(RecieptList.Item(19), printFont, Brushes.Black, x, y - 20)

            e.HasMorePages = False
        Catch ex As Exception
            frmMain.txtSystemMsg.Text = ex.Message
        End Try
    End Sub
End Module
