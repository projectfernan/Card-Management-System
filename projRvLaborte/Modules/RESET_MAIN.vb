Imports ADODB
Module RESET_MAIN
    Public Sub Reset_Tr()
        With MainForm
            .txtEventName.Text = "--"
            .txtCardType.Text = "--"
            .txtTimeTr.Text = "--"

            .lblLCName.Text = "--"
            .lblLCtype.Text = "--"
            .lblPerPts.Text = "0"
            .lblOldPts.Text = "0"
            .lblNewPts.Text = "0"
            .gpTR.Enabled = False
        End With
    End Sub

End Module
