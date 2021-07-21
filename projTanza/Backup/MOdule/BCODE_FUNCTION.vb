Module BCODE_FUNCTION
    Public Function Ticket_Bcode_No() As String

        Dim Ticket As String = My.Settings.BcodeSeries
        Dim x As Integer = 1

        If Ticket.Length > 10 Then

            For x = 1 To 100
                Dim ss As String = "Station " & x
                If ss = My.Settings.STATION Then
                    Exit For
                End If
            Next
            Return x.ToString & "-" & Ticket
        Else

            If Ticket = 0 Then Ticket = 1

            Dim i As Integer = 8 - Ticket.Length
            Dim Nticket As String = New String("0", i)

            For x = 1 To 100
                Dim ss As String = "Station " & x
                If ss = My.Settings.STATION Then
                    Exit For
                End If
            Next

            Return Nticket & Ticket
        End If

    End Function

    Public Sub Update_Bcode()
        Dim i As Long = My.Settings.BcodeSeries
        Dim s As Long = i + 1
        My.Settings.BcodeSeries = s
        My.Settings.Save()
    End Sub

    Public Sub Restore_Bcode(ByVal no As Integer)
        With My.Settings
            .BcodeSeries = no
            .Save()
        End With
    End Sub
End Module
