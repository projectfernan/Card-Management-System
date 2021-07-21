Imports adodb
Module DB_FUNCTION
    Public conSqlPOS As New Connection
    Public flg As Boolean

    Public Function conSdb(ByVal server As String, ByVal port As String, ByVal UID As String, ByVal PWD As String, ByVal Odbc As String) As Boolean
        Try
            conSqlPOS = New ADODB.Connection
            conSqlPOS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            conSqlPOS.Open("Driver={" & Odbc & "}; " _
            & "Server=" & server & ";" _
            & "Port=" & port & ";" _
            & "Option=3;" _
            & "UID=" & UID & ";" _
            & "PWD=" & PWD & ";")
            conSqlPOS.Execute("SET GLOBAL wait_timeout=5000;")
            Return True
        Catch ex As Exception
            Save_ErrLogs("[conSdb] DB_FUNCTION", ex.Message)
            Return False
        End Try
    End Function

    Public Function conServer(ByVal server As String, ByVal port As String, ByVal db As String, ByVal UID As String, ByVal PWD As String, ByVal Odbc As String) As Boolean
        If server = vbNullString Then Return False
        Try
            conSqlPOS = New ADODB.Connection
            conSqlPOS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            conSqlPOS.Open("Driver={" & Odbc & "}; " _
            & "Server=" & server & ";" _
            & "Port=" & port & ";" _
            & "Option=3;" _
            & "Database=" & db & ";" _
            & "UID=" & UID & ";" _
            & "PWD=" & PWD & ";")
            conSqlPOS.Execute("SET GLOBAL wait_timeout=5000;")
            Return True
        Catch ex As Exception
            Save_ErrLogs("[conServer] DB_FUNCTION", ex.Message)
            Return False
        End Try
    End Function

    Function MySQLconn() As Boolean
        Dim sql As New MySqlData
        sql = Get_MySql()

        If conServer(sql.ServerIp, sql.Port, sql.Database, sql.Username, sql.Password, sql.Odbc) = False Then
            Return False
        Else
            Return True
        End If
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
            frmDb.txtIp1.Text = .DB_IP1
            frmDb.txtUser1.Text = .DB_User1
            frmDb.txtPwd1.Text = .DB_Pass1
            frmDb.cboSdb.Text = .DB_Db1
        End With
    End Sub
End Module
