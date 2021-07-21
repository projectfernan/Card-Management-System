
Module MAIN_SECURITY
    Public errMsg As String = vbNullString
    Public loginFlag As Boolean

    Public Sub Lock_Main()
        With MainForm
            .cmdTransact.Enabled = False
            .cmdLogout.Enabled = False
            .btnIssuingLC.Enabled = False
            .btnTransLC.Enabled = False

            .TxtLockStat.Text = "Locked"
            .txtOpLabel.Text = "OPERATOR :"
        End With
    End Sub

    Public Sub unLock_Admin()
        With MainForm
            .cmdTransact.Enabled = True
            .cmdLogout.Enabled = True
            .TxtLockStat.Text = "Active"
        End With
    End Sub

    Public Sub unLock_SuperVisor()
        With MainForm
            .cmdTransact.Enabled = True
            .cmdLogout.Enabled = True
            .btnIssuingLC.Enabled = True
            .btnTransLC.Enabled = True

            .TxtLockStat.Text = "Active"
        End With
    End Sub

    Public Sub unLock_User()
        With MainForm
            .cmdTransact.Enabled = True
            .cmdLogout.Enabled = True
            .btnIssuingLC.Enabled = True
            .btnTransLC.Enabled = False

            .TxtLockStat.Text = "Active"
        End With
    End Sub

    Public Sub disableExplorer()
        Dim taskKill As ProcessStartInfo = New ProcessStartInfo("taskkill", "/F /IM explorer.exe")
        taskKill.WindowStyle = ProcessWindowStyle.Hidden
        Dim Process As Process = New Process()
        Process.StartInfo = taskKill
        Process.Start()
        Process.WaitForExit()
    End Sub

    Public Sub RestartExplorer()
        System.Diagnostics.Process.Start("explorer.exe")
    End Sub

    Public Const SPI_SCREENSAVERRUNNING = 97&
    Public Declare Function SystemParametersInfo Lib "User32" _
    Alias "SystemParametersInfoA" _
    (ByVal uAction As Long, _
    ByVal uParam As Long, _
    ByVal lpvParam As Long, _
    ByVal fuWinIni As Long) As Long

    Public Sub disabled()
        Dim lngRet As Long
        Dim blnOld As Boolean
        lngRet = SystemParametersInfo(SPI_SCREENSAVERRUNNING, True, _
        blnOld, 0&)
    End Sub

    Public Sub Enabled()
        Dim lngRet As Long
        Dim blnOld As Boolean
        lngRet = SystemParametersInfo(SPI_SCREENSAVERRUNNING, False, _
        blnOld, 0&)
    End Sub
End Module
