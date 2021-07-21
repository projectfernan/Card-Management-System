﻿Public Class frmSettings

    Private Sub cmdDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDB.Click
        frmDbSettings.ShowDialog()
    End Sub

    Private Sub cmdReader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReader.Click
        frmD8settings.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmStation.ShowDialog()
    End Sub

    Private Sub cmdOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSetOR.ShowDialog()
    End Sub

    Private Sub cmdPrinter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPrinter.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmLogo.Show()
    End Sub

    Private Sub frmSettings_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            frmDbSettings.ShowDialog()
        End If

        If e.KeyCode = Keys.F2 Then
            frmD8settings.ShowDialog()
        End If

        If e.KeyCode = Keys.F5 Then
            frmStation.ShowDialog()
        End If

        If e.KeyCode = Keys.F7 Then
            frmLogo.ShowDialog()
        End If
    End Sub

End Class