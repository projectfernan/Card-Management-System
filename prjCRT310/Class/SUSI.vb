Imports System.Collections.Generic
Imports System.Text
Imports System.Runtime.InteropServices
Public Class SUSI
    Public NotInheritable Class SUSI_Parameter
        Private Sub New()
        End Sub
        Public Shared PlatformName As String = ""
    End Class

    Public Structure SSCORE_RUNTIMER
        Public dwOPFlag As UInt32
        Public isRunning As Int32
        ' if define BOOL in Struct in C, remember to define it as Int32 in C#
        Public isAutorun As Int32
        Public dwTimeContinual As UInt32
        Public dwTimeTotal As UInt32
    End Structure

    Public NotInheritable Class SUSI_DLL
        Private Sub New()
        End Sub
        <DllImport("SUSI")> _
        Public Shared Function SusiDllGetLastError() As Integer
        End Function
        <DllImport("SUSI")> _
        Public Shared Sub SusiDllGetVersion(ByVal major As UInt32, ByVal minor As UInt32)
        End Sub
        <DllImport("SUSI")> _
        Public Shared Function SusiDllInit() As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiDllUnInit() As Boolean
        End Function
    End Class

    Public NotInheritable Class SUSI_Core
        Private Sub New()
        End Sub
        '-----------------------------------------------------------------------------
        ' CPU Information
        '-----------------------------------------------------------------------------
        ' Vendor
        Public Const INTEL As UInt32 = 1 << 0
        Public Const VIA As UInt32 = 1 << 1
        Public Const SIS As UInt32 = 1 << 2
        Public Const NVIDIA As UInt32 = 1 << 3
        Public Const AMD As UInt32 = 1 << 4
        Public Const RDC As UInt32 = 1 << 5


        <DllImport("SUSI")> _
        Public Shared Function SusiCoreAccessBootCounter(ByVal mode As UInt32, ByVal OPFlag As UInt32, ByVal enable As Boolean, ByVal value As UInt32) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiCoreAccessRunTimer(ByVal mode As UInt32, ByRef refRunTimer As SSCORE_RUNTIMER) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiCoreAvailable() As Integer
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiCoreGetBIOSVersion(ByVal BIOSVersion As Char, ByVal size As UInt32) As Integer
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiCoreGetPlatformName(ByVal PlatformName As Char, ByVal size As UInt32) As Integer
        End Function

        ' Old (backward-compatible)
        <DllImport("SUSI")> _
        Public Shared Function SusiGetPlatformName(ByVal PlatformName As Char, ByVal size As Byte) As Integer
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiGetBIOSVersion(ByVal BIOSVersion As Char, ByVal size As Byte) As Integer
        End Function


        <DllImport("SUSI")> _
        Public Shared Function SusiCoreReadIO(ByVal addr As UInt32, ByRef value As UInt32) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiCoreWriteIO(ByVal addr As UInt32, ByVal value As UInt32) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiCoreReadULongIO(ByVal addr As UInt32, ByVal value As UInt32) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiCoreWriteULongIO(ByVal addr As UInt32, ByVal value As UInt32) As Boolean
        End Function

        <DllImport("SUSI")> _
        Public Shared Function SusiCoreGetCpuMaxSpeed(ByRef Value As UInt32) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiCoreGetCpuVendor(ByRef Value As UInt32) As Boolean
        End Function

        <DllImport("SUSI")> _
        Public Shared Function SusiCoreEnableBootfail() As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiCoreDisableBootfail() As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiCoreRefreshBootfail() As Boolean
        End Function
    End Class

    Public NotInheritable Class SUSI_HWM
        Private Sub New()
        End Sub
        ' Hardware Monitor Control
        <DllImport("SUSI")> _
        Public Shared Function SusiHWMAvailable() As Integer
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiHWMGetFanSpeed(ByVal fanType As UInt16, ByVal retval As UInt16, ByVal typeSupport As UInt16) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiHWMGetTemperature(ByVal tempType As UInt16, ByVal retval As Single, ByVal typeSupport As UInt16) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiHWMGetVoltage(ByVal voltType As UInt32, ByVal retval As Single, ByVal typeSupport As UInt32) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiHWMSetFanSpeed(ByVal fanType As UInt16, ByVal setval As Byte, ByVal typeSupport As UInt16) As Boolean
        End Function

        ' Temperature flag
        Public Enum TempList As Integer
            TCPU = 0
            ' CPU temperature
            TSYS
            ' System temperature
            TAUX
            ' 3'rd thermal dioad
            TCPU2
            TCount
            ' Only for detect temperature count
        End Enum

        ' Fan speed flag
        Public Enum FanList As Integer
            FCPU = 0
            ' CPU fan speed
            FSYS
            ' System fan speed
            F2ND
            ' Other fan speed
            FCPU2
            FAUX2
            FCount
            ' Only for detect fan count
        End Enum

        ' Voltage flag
        Public Enum VoltList As Integer
            VCORE = 0
            V25
            V33
            V50
            V120
            V5SB
            V3SB
            VBAT
            VN50
            VN120
            VTT
            VCORE2
            V105
            V15
            V18
            V240
            VCount
            ' Only for detect voltage count
        End Enum
    End Class

    Public NotInheritable Class SUSI_WDT
        Private Sub New()
        End Sub
        Public Const WDTOUT0 As UInt32 = 0
        Public Const WDTOUT1 As UInt32 = 1

        <DllImport("SUSI")> _
        Public Shared Function SusiWDAvailable() As Integer
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiWDDisable() As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiWDDisableEx(ByVal group_number As UInt32) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiWDGetRange(ByVal minimum As UInt32, ByVal maximum As UInt32, ByVal stepping As UInt32) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiWDSetConfig(ByVal delay As UInt32, ByVal timeout As UInt32) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiWDSetConfigEx(ByVal group_number As UInt32, ByVal delay As UInt32, ByVal timeout As UInt32) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiWDTrigger() As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiWDTriggerEx(ByVal group_number As UInt32) As Boolean
        End Function
    End Class

    Public NotInheritable Class SUSI_GPIO
        Private Sub New()
        End Sub
        Public Enum ESIO_MASKFLAG
            ' Static mask
            ESIO_SMASK_PIN_FULL = &H1
            ESIO_SMASK_CONFIGURABLE = &H2
            ' Dynamic mask
            ESIO_DMASK_DIRECTION = &H20
        End Enum

        ' Common 
        <DllImport("SUSI")> _
        Public Shared Function SusiIOAvailable() As Integer
        End Function

        ' Programmable
        <DllImport("SUSI")> _
        Public Shared Function SusiIOCountEx(ByVal inCount As UInt32, ByVal outCount As UInt32) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiIOQueryMask(ByVal flag As UInt32, ByVal Mask As UInt32) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiIOReadEx(ByVal PinNum As Byte, ByRef status As UInt32) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiIOReadMultiEx(ByVal TargetPinMask As UInt32, ByRef StatusMask As UInt32) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiIOSetDirection(ByVal PinNum As Byte, ByVal IO As Byte, ByRef PinDirMask As UInt32) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiIOSetDirectionMulti(ByVal TargetPinMask As UInt32, ByRef PinDirMask As UInt32) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiIOWriteEx(ByVal PinNum As Byte, ByVal status As Int32) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiIOWriteMultiEx(ByVal TargetPinMask As UInt32, ByVal StatusMask As UInt32) As Boolean
        End Function

        ' Not programmable (backward-compatible)
        <DllImport("SUSI")> _
        Public Shared Function SusiIOCount(ByVal inCount As UInt16, ByVal outCount As UInt16) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiIOInitial(ByVal statuses As UInt32) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiIORead(ByVal pin As Byte, ByVal status As Boolean) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiIOReadMulti(ByVal pins As UInt32, ByVal statuses As UInt32) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiIOWrite(ByVal pin As Byte, ByVal status As Boolean) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiIOWriteMulti(ByVal pins As UInt32, ByVal statuses As UInt32) As Boolean
        End Function
    End Class

    Public NotInheritable Class SUSI_SMBus
        Private Sub New()
        End Sub
        <DllImport("SUSI")> _
        Public Shared Function SusiSMBusAvailable() As Integer
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiSMBusReadBlock(ByVal SlaveAddress As Byte, ByVal RegisterOffset As Byte, ByVal Result As Byte, ByVal ByteCount As Byte) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiSMBusI2CReadBlock(ByVal SlaveAddress As Byte, ByVal RegisterOffset As Byte, ByVal Result As Byte, ByVal ByteCount As Byte) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiSMBusReadByte(ByVal SlaveAddress As Byte, ByVal RegisterOffset As Byte, ByVal Result As Byte) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiSMBusReadQuick(ByVal SlaveAddress As Byte) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiSMBusReadWord(ByVal SlaveAddress As Byte, ByVal RegisterOffset As Byte, ByVal Result As UInt16) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiSMBusReceiveByte(ByVal SlaveAddress As Byte, ByVal Result As Byte) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiSMBusScanDevice(ByVal SlaveAddress_7 As Byte) As Integer
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiSMBusSendByte(ByVal SlaveAddress As Byte, ByVal Result As Byte) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiSMBusWriteBlock(ByVal SlaveAddress As Byte, ByVal RegisterOffset As Byte, ByVal Result As Byte, ByVal ByteCount As Byte) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiSMBusI2CWriteBlock(ByVal SlaveAddress As Byte, ByVal RegisterOffset As Byte, ByVal Result As Byte, ByVal ByteCount As Byte) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiSMBusWriteByte(ByVal SlaveAddress As Byte, ByVal RegisterOffset As Byte, ByVal Result As Byte) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiSMBusWriteQuick(ByVal SlaveAddress As Byte) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiSMBusWriteWord(ByVal SlaveAddress As Byte, ByVal RegisterOffset As Byte, ByVal Result As UInt16) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiSMBusReset() As Boolean
        End Function
    End Class

    Public NotInheritable Class SUSI_IIC
        Private Sub New()
        End Sub
        <DllImport("SUSI")> _
        Public Shared Function SusiIICAvailable() As Integer
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiIICRead(ByVal IICType As UInt32, ByVal SlaveAddress As Byte, ByVal ReadBuf As Byte, ByVal ReadLen As UInt32) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiIICWrite(ByVal IICType As UInt32, ByVal SlaveAddress As Byte, ByVal WriteBuf As Byte, ByVal WriteLen As UInt32) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiIICWriteReadCombine(ByVal IICType As UInt32, ByVal SlaveAddress As Byte, ByVal WriteBuf As Byte, ByVal WriteLen As UInt32, ByVal ReadBuf As Byte, ByVal ReadLen As UInt32) As Boolean
        End Function

        ' Old (backward-compatible)
        <DllImport("SUSI")> _
        Public Shared Function SusiIICReadByte(ByVal SlaveAddress As Byte, ByVal RegisterOffset As Byte, ByVal Result As Byte) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiIICReadByteMulti(ByVal SlaveAddress As Byte, ByVal ReadBuf As Byte, ByVal ReadLen As UInt32) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiIICWriteByte(ByVal SlaveAddress As Byte, ByVal RegisterOffset As Byte, ByVal Result As Byte) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiIICWriteByteMulti(ByVal SlaveAddress As Byte, ByVal WriteBuf As Byte, ByVal WriteLen As UInt32) As Boolean
        End Function
    End Class

    Public NotInheritable Class SUSI_VC
        Private Sub New()
        End Sub
        <DllImport("SUSI")> _
        Public Shared Function SusiVCAvailable() As Integer
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiVCGetBright(ByRef brightness As Byte) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiVCGetBrightRange(ByVal minimum As Byte, ByVal maximum As Byte, ByVal stepping As Byte) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiVCScreenOff() As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiVCScreenOn() As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiVCSetBright(ByVal brightness As Byte) As Boolean
        End Function
    End Class

    Public NotInheritable Class SUSI_PowerSaving
        Private Sub New()
        End Sub
        <DllImport("kernel32")> _
        Public Shared Function GetCurrentProcess() As IntPtr
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SUSIPlusCpuSetOnDemandThrottling(ByVal proc_handler As IntPtr, ByVal cpu_index As [Byte], ByVal [step] As [Byte]) As UInt32
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SUSIPlusCpuGetOnDemandThrottling(ByVal proc_handler As IntPtr, ByVal cpu_index As [Byte], ByRef [step] As Byte) As UInt32
        End Function

        <DllImport("SUSI")> _
        Public Shared Function SUSIPlusCpuSetThrottling(ByVal [step] As [Byte]) As UInt32
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SUSIPlusCpuGetThrottling(ByRef [step] As Byte) As UInt32
        End Function


        <DllImport("SUSI")> _
        Public Shared Function SusiPlusSpeedIsActive() As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiPlusSpeedSetActive() As Integer
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiPlusSpeedSetInactive() As Integer
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiPlusSpeedWrite(ByVal ACPolicy As Byte, ByVal DCPolicy As Byte) As Integer
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiPlusSpeedRead(ByRef ACPolicy As Byte, ByRef DCPolicy As Byte) As Integer
        End Function

        <DllImport("SUSI")> _
        Public Shared Function SusiPlusGetProcessorSpeed() As Single
        End Function

    End Class

    Public NotInheritable Class SUSI_Hotkey
        Private Sub New()
        End Sub
        <DllImport("SUSI")> _
        Public Shared Function SusiTrekGetHotkey(ByVal DI_data As Byte) As Boolean
        End Function
        <DllImport("SUSI")> _
        Public Shared Function SusiTrekHotkeyAvailable() As Integer
        End Function
    End Class
    ' Common 
    <DllImport("SUSI")> _
    Public Shared Function SusiIOAvailable() As Integer
    End Function

End Class
