Imports ADODB
Module RESET_MAIN
    Public Sub Reset_Tr()
        With frmMain
            ' .txtTotal.Text = "0.00"
            .txtEventName.Text = "--"
            .txtCardType.Text = "--"
            .txtTimeTr.Text = "--"
            .txtBarcode.Text = "---"
            '.txtAmount.Text = "0.00"
            '.txtVat.Text = "0.00"
            '.txtSubTotal.Text = "0.00"
            .gpTR.Enabled = False

        End With
    End Sub

End Module
