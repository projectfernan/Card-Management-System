Imports adodb
Module DB_FUNCTION
    Public conSqlPOS As New Connection
    Public flg As Boolean

    Public Function conSdb(ByVal server As String, ByVal port As String, ByVal UID As String, ByVal PWD As String) As Boolean
        Try
            conSqlPOS = New ADODB.Connection
            conSqlPOS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            conSqlPOS.Open("Driver={mySQL ODBC 5.1 Driver}; " _
            & "Server=" & server & ";" _
            & "Port=" & port & ";" _
            & "Option=3;" _
            & "UID=" & UID & ";" _
            & "PWD=" & PWD & ";")
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Function conServer(ByVal server As String, ByVal port As String, ByVal db As String, ByVal UID As String, ByVal PWD As String) As Boolean
        If server = vbNullString Then Return False
        Try
            conSqlPOS = New ADODB.Connection
            conSqlPOS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            conSqlPOS.Open("Driver={mySQL ODBC 5.1 Driver}; " _
            & "Server=" & server & ";" _
            & "Port=" & port & ";" _
            & "Option=3;" _
            & "Database=" & db & ";" _
            & "UID=" & UID & ";" _
            & "PWD=" & PWD & ";")
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Sub viewDB(ByVal cbo As ComboBox)
        Dim dbshw As New Recordset
        cbo.Items.Clear()
        dbshw = New Recordset
        dbshw = conSqlPOS.Execute("show databases")
        Do While dbshw.EOF = False
            cbo.Items.Add(dbshw("Database").Value)
            dbshw.MoveNext()
        Loop
    End Sub

    Public Sub viewCon()
        With My.Settings
            frmDB.txtIp1.Text = .DB_IP1
            frmDB.txtUser1.Text = .DB_User1
            frmDB.txtPwd1.Text = .DB_Pass1
            frmDB.cboSdb.Text = .DB_Db1
        End With
    End Sub
End Module
