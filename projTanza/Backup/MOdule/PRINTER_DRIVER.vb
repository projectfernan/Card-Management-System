Imports System.Drawing.Printing
Imports ADODB
Module PRINTER_DRIVER
    Public Sub PopulateInstalledPrintersCombo(ByVal cbo As ComboBox)
        ' Add list of installed printers found to the combo box. 
        ' The pkInstalledPrinters string will be used to provide the display string. 
        Dim i As Integer
        Dim pkInstalledPrinters As String

        For i = 0 To PrinterSettings.InstalledPrinters.Count - 1
            pkInstalledPrinters = PrinterSettings.InstalledPrinters.Item(i)
            cbo.Items.Add(pkInstalledPrinters)
        Next
    End Sub

    Public Sub ViewDriver()
        With My.Settings
            frmPrinter.cboDriver.Text = .PrinterDriver
        End With
    End Sub

    Public Sub viewPOSSet()
        If conServer() = False Then
            MsgBox("Please connect to database! ", vbInformation, "Database connection")
            frmDbSettings.ShowDialog()
            Exit Sub
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = Conn.Execute("Select * from tblPOS")
            If rs.EOF = False Then
                With frmSetPOS
                    .txtTitle.Text = rs("Title").Value
                    .txtAdd.Text = rs("Address").Value
                    .txtContact.Text = rs("ContactNo").Value
                    .txtTin.Text = rs("TIN").Value
                    .txtPermit.Text = rs("Permit").Value
                    .txtSerial.Text = rs("Serial").Value
                    .txtMachine.Text = rs("Machine").Value
                    .txtAccr.Text = rs("Accr").Value
                End With
            End If

        Catch ex As Exception
            frmMain.txtSystemMsg.Text = ex.Message
        End Try
    End Sub

End Module
