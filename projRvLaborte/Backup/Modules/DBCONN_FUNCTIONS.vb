Imports ADODB
Imports System.Data.OleDb

Module DBCONN_FUNCTIONS
    Public dtDgv As DataTable = New DataTable
    Public dtQ As DataTable = New DataTable
    Public Conn As New ADODB.Connection

    Public Sub ViewConn()
        With My.Settings
            frmDbSettings.txtIp.Text = .DB_IP
            frmDbSettings.txtUID.Text = .DB_UID
            frmDbSettings.txtPWD.Text = .DB_PWD
            frmDbSettings.txtPort.Text = .DB_PORT
        End With
    End Sub

    Public Function conServer() As Boolean
        Try
            With My.Settings
                If Conn.State = ConnectionState.Open Then Conn.Close()
                Conn = New ADODB.Connection
                Conn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
                Conn.Open("Driver={MySQL ODBC 8.0 Unicode Driver}; " _
                & "Server=" & .DB_IP & ";" _
                & "Port=" & .DB_PORT & ";" _
                & "Option=3;" _
                & "Database=cmsdb;" _
                & "UID=" & .DB_UID & ";" _
                & "PWD=" & .DB_PWD & ";")

                MainForm.txtSystemMsg.Text = "---"

                Return True
            End With
        Catch ex As Exception
            MainForm.txtSystemMsg.Text = ex.Message
            Return False
        End Try
    End Function

    Public Function rsMySqlQuery(ByVal strQuery As String) As DataTable
        Try
            dtQ = New DataTable

            If conServer() = False Then
                Return dtQ
            End If

            Dim OleAdapter As OleDbDataAdapter = New OleDbDataAdapter

            Dim rs As New Recordset
            rs = Conn.Execute(strQuery)

            OleAdapter.Fill(dtQ, rs)

            Return dtQ
        Catch ex As Exception
            'errMsg = ex.Message
            dtQ = New DataTable
            Return dtQ
        End Try
    End Function

    Public Function LoadDgvData(ByVal dgv As DataGridView, ByVal query As String, ByVal HdAutoRez As Boolean) As Boolean
        Try
            dtDgv = New DataTable
            dtDgv = rsMySqlQuery(query)

            If dtDgv IsNot Nothing Then
                dgv.DataSource = dtDgv
            End If

            Dim HdCnt As Integer = dgv.Columns.Count
            Dim HdLup As Integer = 0
            Dim HdW As Integer = (dgv.Width - dgv.RowHeadersWidth) / HdCnt

            Do While HdLup <> HdCnt
                dgv.Columns(HdLup).HeaderCell.Style.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                If HdAutoRez = True Then
                    dgv.Columns(HdLup).Width = HdW
                End If
                HdLup = HdLup + 1
            Loop

            Return True
        Catch ex As Exception
            'errMsg = "LoadDgvData: " & ex.Message
            Return False
        End Try
    End Function
End Module
