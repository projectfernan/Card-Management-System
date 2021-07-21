Imports System.Runtime.InteropServices
Imports System.Threading

Module x64TriggerFunc


    <DllImport("InpOut32.dll", CharSet:=CharSet.Auto, EntryPoint:="Inp32")> _
   Public Function Inp32(ByVal PortAddress As Integer) As Integer
    End Function

    <DllImport("InpOut32.dll", CharSet:=CharSet.Auto, EntryPoint:="Out32")> _
   Public Sub Out32(ByVal PortAddress As Integer, ByVal Data As Integer)
    End Sub

    <DllImport("InpOut32.dll", CharSet:=CharSet.Auto, EntryPoint:="IsInpOutDriverOpen")> _
    Public Function IsInpOutDriverOpen() As UInt32
    End Function

    <DllImport("InpOutx64.dll", CharSet:=CharSet.Auto, EntryPoint:="Inp32")> _
   Public Function Inp32_x64(ByVal PortAddress As Short) As Integer
    End Function

    <DllImport("InpOutx64.dll", CharSet:=CharSet.Auto, EntryPoint:="Out32")> _
    Public Sub Out32_x64(ByVal PortAddress As Integer, ByVal Data As Integer)
    End Sub

    <DllImport("InpOutx64.dll", CharSet:=CharSet.Auto, EntryPoint:="IsInpOutDriverOpen")> _
   Public Function IsInpOutDriverOpen_x64() As UInt32
    End Function

    Public m_bX64 As Boolean = False

    Public Sub TriggerWrite(ByVal portAdd As Integer, ByVal DataInp As Integer)
        Try
            Dim iPort As Integer
            Dim iData As Integer

            iPort = portAdd 'Convert.ToInt16(TextBox1.Text)
            iData = DataInp 'Convert.ToInt16(TextBox2.Text)

            If (m_bX64) Then
                Out32_x64(iPort, iData)
            Else
                Out32(iPort, iData)
            End If

        Catch ex As Exception
            ' MessageBox.Show("An error occured:\n" + ex.Message, )
            MsgBox(ex.Message, vbCritical, "Trigger Write")
        End Try
    End Sub

    Public Sub TriggerOnfunc()

        Try
            With My.Settings
                TriggerWrite(.PortAdd, .Port)
                'x64.TriggerOn(.PortAdd, .Port, .Delay)
                Sleep(Val(frmTrigger.txtDelay.Text))
                TriggerWrite(.PortAdd, 0)
            End With

        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Trigger settings")
        End Try
    End Sub

    Public Sub TriggerOff()

        Try
            With My.Settings
                TriggerWrite(.PortAdd, 0)
            End With

        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Trigger settings")
        End Try
    End Sub

End Module
