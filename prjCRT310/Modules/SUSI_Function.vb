Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports Susi4.APIs
Imports Susi4.Libraries
Imports Susi4.Plugin
Imports prjCRT310.SUSI
Imports prjCRT310.SUSI.SUSI_GPIO
Imports prjCRT310.SUSI.SUSI_DLL
Imports System.Runtime.InteropServices

Module SUSI_Function
    Public Function Initialize_SUSI() As Boolean
        Try
            If SusiDllInit() = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Set_MultiDirection(ByVal pin As Integer, ByVal InOut As Integer) As Boolean

        Dim targetPinMask As UInt32 = Convert.ToUInt32(pin.ToString, 2)
        Dim pinDirMask As UInt32 = Convert.ToUInt32(InOut.ToString, 2)

        Try
            If Not SUSI_GPIO.SusiIOSetDirectionMulti(targetPinMask, pinDirMask) Then

                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            '  Save_Logs("Set_MultiDirection:" & ex.Message.ToString)
            Return False
        End Try

    End Function

    Public Function Set_OneDirection(ByVal pin As Integer, ByVal InOut As Integer) As Boolean

        Try
            Dim pinDirAfterSet As UInt32
            Dim pinNum As Byte = Convert.ToByte(pin)
            Dim IO As Byte = Convert.ToByte(InOut.ToString, 2)

            If Not SUSI_GPIO.SusiIOSetDirection(pinNum, IO, pinDirAfterSet) Then
                Return False

            Else
                Return True

            End If
        Catch ex As Exception
            '  Save_Logs("Set_OneDirection: " & ex.Message.ToString)
            Return False
        End Try
    End Function

    Public Function Read_One(ByVal pin As Integer) As UInt32


        Try
            Dim status As UInt32

            Dim pinNum As Byte = Convert.ToByte(pin.ToString)

            If Not SUSI.SUSI_GPIO.SusiIOReadEx(pinNum, status) Then
                Return 0
            Else
                Return status
            End If

        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Read_Multiple(ByVal pins As Integer) As UInt32
        Try
            Dim targetPinMask As UInt32 = Convert.ToUInt32(pins.ToString, 2)
            Dim statusMask As UInt32

            If Not SUSI.SUSI_GPIO.SusiIOReadMultiEx(targetPinMask, statusMask) Then

                Return 0
            Else
                Return statusMask

            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Write_One(ByVal pin As Integer, ByVal value As Integer) As Boolean
        Try

            If value <> 0 Then
                value = 1
            Else
                value = 0

            End If
            Dim status As Int32 = Convert.ToInt32(value.ToString, 2)
            Dim pinNum As Byte = Convert.ToByte(pin.ToString)
            If Set_OneDirection(pin, 0) = False Then
                Return False
                Exit Function
            End If

            If Not SUSI.SUSI_GPIO.SusiIOWriteEx(pinNum, status) Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Write_Multiple(ByVal pin As Integer, ByVal value As Integer) As Boolean
        Try
            value = IntToBin(CLng(value))
            Dim statusMask As UInt32 = Convert.ToUInt32(value.ToString, 2)
            Dim targetPinMask As UInt32 = Convert.ToUInt32(pin.ToString, 2)

            If Not SUSI.SUSI_GPIO.SusiIOWriteMultiEx(targetPinMask, statusMask) Then
                Return False
            Else
                Return True

            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function IntToBin(ByVal IntegerNumber As Long) As String
        Dim BinValue As String = vbNullString
        Dim IntNum = IntegerNumber
        Do
            'Use the Mod operator to get the current binary digit from the
            'Integer number
            Dim TempValue As Long = IntNum Mod 2
            BinValue = CStr(TempValue) + BinValue

            'Divide the current number by 2 and get the integer result
            IntNum = IntNum \ 2
        Loop Until IntNum = 0

        Return BinValue

    End Function
End Module
