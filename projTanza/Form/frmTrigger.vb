Imports System.Runtime.InteropServices
Imports System.Threading
Public Class frmTrigger

    Sub save()
        With My.Settings
            .PortAdd = txtPortAdd.Text
            .StatAdd = txtStatAdd.Text
            .Port = txtPort.Value
            .Delay = txtDelay.Value
            .Save()
        End With
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        save()
        MsgBox("Trigger settings saved!    ", MsgBoxStyle.Information, "Trigger Settings")
        Me.Close()
    End Sub

    Private Sub cmdTest1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest1.Click
        If txtPortAdd.Text = vbNullString Then
            MsgBox("Please enter port address!    ", MsgBoxStyle.Exclamation, "Trigger settings")
            txtPortAdd.Focus()
            Exit Sub
        End If

        If txtPort.Value = vbNullString Then
            MsgBox("Please enter port!    ", MsgBoxStyle.Exclamation, "Trigger settings")
            txtPort.Focus()
            Exit Sub
        End If

        If txtDelay.Value = vbNullString Then
            MsgBox("Please enter delay!    ", MsgBoxStyle.Exclamation, "Trigger settings")
            txtDelay.Focus()
            Exit Sub
        End If

        save()

        'Try
        '    Dim iPort As Integer
        '    Dim iData As Integer

        '    iPort = My.Settings.PortAdd  'Convert.ToInt16(TextBox1.Text)
        '    iData = My.Settings.Port  'Convert.ToInt16(TextBox2.Text)

        '    If (m_bX64) Then
        '        Out32_x64(iPort, iData)
        '    Else
        '        Out32(iPort, iData)
        '    End If

        'Catch ex As Exception
        '    MessageBox.Show("An error occured:\n" + ex.Message)
        'End Try

        TriggerOnfunc()
        'trigerOff()
        'triger()
    End Sub

    Private Sub frmTrigger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim nResult As UInt32

        Try
            nResult = IsInpOutDriverOpen()
        Catch ex As Exception
            nResult = IsInpOutDriverOpen_x64()
            If (nResult <> 0) Then
                m_bX64 = True
            End If
        End Try

        If (nResult = 0) Then
            MsgBox("Unable to open InpOut driver")
        End If
    End Sub
End Class