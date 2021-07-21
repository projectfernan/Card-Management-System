Imports ADODB
Module DBCONN_FUNCTIONS
    Public Conn As New ADODB.Connection

    Public Sub ViewConn()
        With My.Settings
            frmDbSettings.txtIp.Text = .DB_IP
            frmDbSettings.txtUID.Text = .DB_UID
            frmDbSettings.txtPWD.Text = .DB_PWD
            frmDbSettings.txtPort.Text = .DB_Port
        End With
    End Sub

    Public Function conServer() As Boolean
        Try
            With My.Settings
                If Conn.State = ConnectionState.Open Then Conn.Close()
                Conn = New ADODB.Connection
                Conn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
                Conn.Open("Driver={mySQL ODBC 5.1 Driver}; " _
                & "Server=" & .DB_IP & ";" _
                & "Port=" & .DB_PORT & ";" _
                & "Option=3;" _
                & "Database=lavortedb;" _
                & "UID=" & .DB_UID & ";" _
                & "PWD=" & .DB_PWD & ";")

                frmMain.txtSystemMsg.Text = "---"

                Return True
            End With
        Catch ex As Exception
            frmMain.txtSystemMsg.Text = ex.Message
            Return False
        End Try
    End Function
End Module
