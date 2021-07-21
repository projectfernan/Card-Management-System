Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports Susi4.APIs
Imports Susi4.Libraries
Imports Susi4.Plugin
Imports UNIPOS.SUSI
Imports UNIPOS.SUSI.SUSI_GPIO
Imports UNIPOS.SUSI.SUSI_DLL
Imports System.Runtime.InteropServices
Module Trigger_Function
    Public Sub Barrier_Up()
        Try
            Dim x As New GPIO_Config
            x = Get_GPIO_Config()
            For i As Integer = 1 To x.Trigger_Times
                Write_One(x.Barrier_Pin, 0)
                Threading.Thread.Sleep(x.GPIO_Delay)
                Write_One(x.Barrier_Pin, 1)
                Threading.Thread.Sleep(x.GPIO_Delay)
                Write_One(x.Barrier_Pin, 0)
            Next

        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Public Sub Barrier_Up2()
        Try
            Dim x As New GPIO_Config
            x = Get_GPIO_Config()
            For i As Integer = 1 To x.Trigger_Times2
                Write_One(x.Barrier_Pin2, 0)
                Threading.Thread.Sleep(x.GPIO_Delay2)
                Write_One(x.Barrier_Pin2, 1)
                Threading.Thread.Sleep(x.GPIO_Delay2)
                Write_One(x.Barrier_Pin2, 0)
            Next

        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Module
