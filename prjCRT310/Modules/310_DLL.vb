Imports System.Runtime.InteropServices
Imports Microsoft.Win32.SafeHandles

Module _310_DLL

    Public CardPass As Byte()
    Public SNR As Byte()
    Public Data32 As Byte()

    Public Enum CRT_POSITION As Byte
        RF_POSITION = 46
        Release = 48
        Capture = 51
    End Enum

#Region "DLL Imports"

    <DllImport("CRT_310.dll")> _
Public Function CommOpen(ByVal port As String) As IntPtr
    End Function
    'Open the serial port baud rate specified
    <DllImport("CRT_310.dll")> _
    Public Function CommOpenWithBaut(ByVal port As String, ByVal _data As UShort) As IntPtr
    End Function
    'Serial number of the card reader
    <DllImport("CRT_310.dll")> _
    Public Function CRT310_ReadSnr(ByVal ComHandle As IntPtr, ByVal _SNData As Byte(), ByRef _dataLen As Byte) As Integer
    End Function
    'Close the serial port
    <DllImport("CRT_310.dll")> _
    Public Function CommClose(ByVal ComHandle As IntPtr) As Integer
    End Function
    'CRT into the card control settings
    <DllImport("CRT_310.dll")> _
    Public Function CRT310_CardSetting(ByVal ComHandle As IntPtr, ByVal _CardIn As Byte, ByVal _EnableBaceIn As Byte) As Integer
    End Function
    'Card stop position set
    <DllImport("CRT_310.dll")> _
    Public Function CRT310_CardPosition(ByVal ComHandle As IntPtr, <[In]()> ByVal _Position As CRT_POSITION) As Integer
    End Function
    'Reset Card Reader
    <DllImport("CRT_310.dll")> _
    Public Function CRT310_Reset(ByVal ComHandle As IntPtr, ByVal _Eject As Byte) As Integer
    End Function
    'Status information is read from the card reader
    <DllImport("CRT_310.dll")> _
    Public Function CRT310_GetStatus(ByVal ComHandle As IntPtr, ByRef _atPosition As Byte, ByRef _frontSetting As Byte, ByRef _rearSetting As Byte) As Integer
    End Function
    'Read CRT_310 sensor status
    <DllImport("CRT_310.dll")> _
    Public Function CRT310_SensorStatusV3(ByVal ComHandle As IntPtr, ByRef _PSS0 As Byte, ByRef _PSS1 As Byte, ByRef _PSS2 As Byte, ByRef _PSS3 As Byte, ByRef _PSS4 As Byte, _
     ByRef _PSS5 As Byte, ByRef _CTSW As Byte, ByRef _KSW As Byte) As Integer
    End Function
    'CRT indicator light off set
    <DllImport("CRT_310.dll")> _
    Public Function CRT310_LEDSet(ByVal ComHandle As IntPtr, ByVal _ONOFF As Byte) As Integer
    End Function
    'CRT指示灯亮灭时间设置
    <DllImport("CRT_310.dll")> _
    Public Function CRT310_LEDTime(ByVal ComHandle As IntPtr, ByVal _T1 As Byte, ByVal _T2 As Byte) As Integer
    End Function
    'CRT310 go card location settings
    <DllImport("CRT_310.dll")> _
    Public Function CRT310_MovePosition(ByVal ComHandle As IntPtr, ByVal _Positon As Byte) As Integer
    End Function
    '读磁轨数据
    <DllImport("CRT_310.dll")> _
    Public Function MC_ReadTrack(ByVal ComHandle As IntPtr, ByVal _Mode As Byte, ByVal _track As Byte, ByVal _BlockData As Byte()) As Integer
    End Function

    'int APIENTRY RF_GetCardID(HANDLE ComHandle, BYTE _CardID[4]);
    <DllImport("CRT_310.dll", SetLastError:=False)> _
    Public Function RF_GetCardID(ByVal hcom As IntPtr, <Out()> ByVal CardID As Byte()) As Integer
    End Function

    'int APIENTRY RF_LoadSecKey(HANDLE ComHandle, BYTE _Sec, BYTE _KEY[6]);
    'to load a key to a SEctor
    <DllImport("CRT_310.dll", SetLastError:=False)> _
    Public Function RF_LoadSecKey(ByVal hcom As IntPtr, _
    ByVal SectorNo As Byte, ByVal Keytype As Integer, <[In]()> ByVal SectorKey As Byte()) As Integer
    End Function

    'int APIENTRY RF_ReadBlock(HANDLE ComHandle, BYTE _Sec, BYTE _Block, BYTE
    '_BlockData[16]);
    <DllImport("CRT_310.dll", SetLastError:=False)> _
    Public Function RF_ReadBlock(ByVal hcom As IntPtr, _
    ByVal Sector As Byte, ByVal Block As Byte, <Out()> ByVal blockData As Byte()) As Integer
    End Function

    <DllImport("CRT_310.dll", SetLastError:=False)> _
    Public Function RF_WriteBlock _
    (ByVal hcom As IntPtr, ByVal SecNum As Byte, ByVal BlockAdd As Byte, _
     <[In]()> ByVal Data As Byte()) As Integer
    End Function

#End Region

End Module
