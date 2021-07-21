Module CHARGING_STRUCTURE
    Public Structure Charging_Str
        Public C_CardType As String
        Public C_Event As String
        Public C_Amount As Double
        Public C_VAT As Double
        Public C_SubTotal As Double
    End Structure

    Public chc As Charging_Str
    Public Coupon_Ref As String
End Module
