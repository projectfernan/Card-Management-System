Imports ADODB

Module SETTINGS
    Public IniFile As String = Application.StartupPath & "\Inf.ini"
    Public INI As New ini(IniFile)
#Region "IO_Relay"
    Public Structure IORelayData
        Public PortAdd As String
        Public StatAdd As String
        Public Port As Integer
        Public Delay As Integer
    End Structure

    Function Get_IO_Relay() As IORelayData
        Dim io As New IORelayData

        Try
            If ConnPS() = False Then
                io.PortAdd = "E010"
                io.StatAdd = "E011"
                io.Port = 255
                io.Delay = 300
                Return io
            End If

            Dim rs As New Recordset
            rs = connMS.Execute("select * from tbliorelay")
            If rs.EOF = False Then
                io.PortAdd = rs("PortAdd").Value
                io.StatAdd = rs("StatAdd").Value
                io.Port = rs("Port").Value
                io.Delay = rs("Delay").Value
                Return io
            Else
                io.PortAdd = "E010"
                io.StatAdd = "E011"
                io.Port = 255
                io.Delay = 300
                Return io
            End If
           
        Catch ex As Exception
            Save_ErrLogs("[Get_IO_Relay] SETTINGS", ex.Message)
            io.PortAdd = "E010"
            io.StatAdd = "E011"
            io.Port = 255
            io.Delay = 300
            Return io
        End Try
    End Function

    Public Function Set_IO_Relay(ByVal PortAdd As String, ByVal StatAdd As String, ByVal Port As Integer, ByVal delay As Integer) As Boolean
        Try
            Dim delIOdata As String = "delete * from tbliorelay"
            Dim qr As String = "insert into tbliorelay([PortAdd],[StatAdd],[Port],[Delay])VALUES('" & PortAdd & "','" & _
                                                                                              StatAdd & "'," & _
                                                                                              Port & "," & _
                                                                                              delay & ")"
            If rsPsCUD(delIOdata) = True Then
                Return rsPsCUD(qr)
            End If
        Catch ex As Exception
            Save_ErrLogs("[Set_IO_Relay] SETTINGS", ex.Message)
            Return False
        End Try
    End Function
#End Region

#Region "CRT310"
    Public Structure CRT310Data
        Public Com As String
        Public Delay As Integer
    End Structure

    Public Function Get_CRT310() As CRT310Data
        Dim crt As New CRT310Data

        Try
            If ConnPS() = False Then
                crt.Com = "COM1"
                crt.Delay = 300
                Return crt
            End If

            Dim rs As New Recordset
            rs = connMS.Execute("select * from tblcrt310")
            If rs.EOF = False Then
                crt.Com = rs("Com").Value
                crt.Delay = rs("Delay").Value
                Return crt
            Else
                crt.Com = "COM1"
                crt.Delay = 300
                Return crt
            End If

        Catch ex As Exception
            Save_ErrLogs("[Get_CRT310] SETTINGS", ex.Message)
            crt.Com = "COM1"
            crt.Delay = 300
            Return crt
        End Try
    End Function

    Public Function Set_CRT310(ByVal COM As String, ByVal Delay As Integer) As Boolean
        Try
            Dim delIOdata As String = "delete * from tblcrt310"
            Dim qr As String = "insert into tblcrt310([Com],[Delay])VALUES('" & COM & "'," & _
                                                                               Delay & ")"
            If rsPsCUD(delIOdata) = True Then
                Return rsPsCUD(qr)
            End If
        Catch ex As Exception
            Save_ErrLogs("[Set_CRT310] SETTINGS", ex.Message)
            Return False
        End Try
    End Function
#End Region

#Region "MySql"
    Public Structure MySqlData
        Public ServerIp As String
        Public Username As String
        Public Password As String
        Public Port As String
        Public Database As String
        Public Odbc As String
    End Structure

    Public Function Get_MySql() As MySqlData
        Dim sql As New MySqlData

        Try
            If ConnPS() = False Then
                sql.ServerIp = "DESKTOP-4PV8HPU"
                sql.Username = "root"
                sql.Password = "pr0J3ctF"
                sql.Port = "3306"
                sql.Database = "cmsdb"
                sql.Odbc = "MySQL ODBC 5.1 Driver"
                Return sql
            End If

            Dim rs As New Recordset
            rs = connMS.Execute("select * from tblmysql")
            If rs.EOF = False Then
                sql.ServerIp = rs("ServerIp").Value
                sql.Username = rs("Username").Value
                sql.Password = rs("Password").Value
                sql.Port = rs("Port").Value
                sql.Database = rs("Database").Value
                sql.Odbc = rs("ODBC").Value
                Return sql
            Else
                sql.ServerIp = "DESKTOP-4PV8HPU"
                sql.Username = "root"
                sql.Password = "pr0J3ctF"
                sql.Port = "3306"
                sql.Database = "cmsdb"
                sql.Odbc = "MySQL ODBC 5.1 Driver"
                Return sql
            End If

        Catch ex As Exception
            Save_ErrLogs("[Get_MySql] SETTINGS", ex.Message)
            sql.ServerIp = "DESKTOP-4PV8HPU"
            sql.Username = "root"
            sql.Password = "pr0J3ctF"
            sql.Port = "3306"
            sql.Database = "cmsdb"
            sql.Odbc = "MySQL ODBC 5.1 Driver"
            Return sql
        End Try
    End Function

    Public Function Set_MySql(ByVal ServerIp As String, ByVal Uid As String, ByVal Pwd As String, ByVal Port As String, ByVal Database As String, ByVal Odbc As String) As Boolean
        Try
            Dim delIOdata As String = "delete * from tblmysql"
            Dim qr As String = "insert into tblmysql([ServerIp],[Username],[Password],[Port],[Database],[ODBC])VALUES('" & ServerIp & "','" & _
                                                                                                                    Uid & "','" & _
                                                                                                                    Pwd & "','" & _
                                                                                                                    Port & "','" & _
                                                                                                                    Database & "','" & _
                                                                                                                    Odbc & "')"

            If rsPsCUD(delIOdata) = True Then
                Return rsPsCUD(qr)
            End If
        Catch ex As Exception
            Save_ErrLogs("[Set_MySql] SETTINGS", ex.Message)
            Return False
        End Try
    End Function
#End Region

#Region "Zone"
    Public Structure ZoneData
        Public Zone As String
    End Structure

    Public Function Get_Zone() As ZoneData
        Dim z As New ZoneData

        Try
            If ConnPS() = False Then
                z.Zone = "Entry Zone 1"
                Return z
            End If

            Dim rs As New Recordset
            rs = connMS.Execute("select * from tblZone")
            If rs.EOF = False Then
                z.Zone = rs("Zone").Value
                Return z
            Else
                z.Zone = "Entry Zone 1"
                Return z
            End If

        Catch ex As Exception
            Save_ErrLogs("[Get_Zone] SETTINGS", ex.Message)
            z.Zone = "Entry Zone 1"
            Return z
        End Try
    End Function

    Public Function Set_Zone(ByVal Zone As String) As Boolean
        Try
            Dim delIOdata As String = "delete * from tblZone"
            Dim qr As String = "insert into tblZone([Zone])VALUES('" & Zone & "')"
            If rsPsCUD(delIOdata) = True Then
                Return rsPsCUD(qr)
            End If
        Catch ex As Exception
            Save_ErrLogs("[Set_Zone] SETTINGS", ex.Message)
            Return False
        End Try
    End Function
#End Region

#Region "Counter"
    Public Structure insertCount
        Public Count As Integer
        Public UpdateTime As Date
    End Structure

    Function Get_tblCounter() As insertCount
        Dim cnt As New insertCount

        Try
            If ConnPS() = False Then
                cnt.Count = 0
                cnt.UpdateTime = Now
                Return cnt
            End If

            Dim rs As New Recordset
            rs = connMS.Execute("select * from tblcounter")
            If rs.EOF = False Then
                cnt.Count = rs("Count").Value
                cnt.UpdateTime = CDate(rs("UpdateTime").Value.ToString)
                Return cnt
            Else
                cnt.Count = 0
                cnt.UpdateTime = Now
                Return cnt
            End If

        Catch ex As Exception
            Save_ErrLogs("[Get_tblCounter] SETTINGS", ex.Message)
            cnt.Count = 0
            cnt.UpdateTime = Now
            Return cnt
        End Try
    End Function
#End Region

    Public Structure Card_Counter
        Public InsCount As Integer
        Public InsDate As String
    End Structure
    Public Function GET_InsCount() As Card_Counter
        Dim x As New Card_Counter
        x.InsCount = INI.GetInteger("Counter", "InsCount", 0)
        x.InsDate = INI.GetString("Counter", "InsDate", Format(Now, "yyyy-MM-dd"))
        Return x
    End Function

End Module
