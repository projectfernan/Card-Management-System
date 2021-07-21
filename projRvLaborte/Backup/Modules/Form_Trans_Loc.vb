Module Form_Trans_Loc

    Public Sub loc(ByVal frm As Form)
        frm.Top = Screen.PrimaryScreen.Bounds.Height - 395
        'Dim w As Integer = frmMain.CamEntry.Width + 17
        frm.Left = Screen.PrimaryScreen.Bounds.Left + 13
    End Sub
End Module
