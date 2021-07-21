Module Convertion

    Public Structure Card_Data
        Public Is_Value As Boolean
        Public CardCode As String
        Public Timein As Date
        Public VEH As String
        Public ID As String
        Public PLATE As String
        Public IsOnline As Boolean
    End Structure

    Public CD As Card_Data

    Public Structure Computation_Ref
        Public TotalAmount As Double
        Public Regular As Double
        Public Vat As Double
        Public Vat_Sale As Double
        Public Time As Long
        Public Overnight As Double
        Public LostCard As Double
    End Structure

    Public Function HexToString(ByVal strHex As String) As String
        Dim strMakeText As String, lngCharCount As Long
        strMakeText = Space$(Len(strHex) \ 2)
        For lngCharCount = 1 To Len(strHex) \ 2
            Mid$(strMakeText, lngCharCount, 1) = Chr(Val("&H" & Mid$(strHex, (lngCharCount * 2) - 1, 2)))
        Next lngCharCount
        strMakeText = Replace(strMakeText, Chr(0), vbNullString).Trim
        Return strMakeText
    End Function


End Module
