Imports System.Threading.Thread
Imports System.IO.Ports
Imports System.Text
Public Class frmCrt310
    Private Sub frmCrt310_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Get_PORTS(txtCRTCOM)
    End Sub

    Private Sub Displ(ByVal msg As String)
        txtCrtTest.AppendText(msg & vbNewLine)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If CRT_INI() Then
            Displ("Connection Ok")
            frmMain.DevStat.Text = "Active"
            frmMain.DevStat.ForeColor = Color.DodgerBlue
            frmMain.tmeTimer.Enabled = True
        Else
            Displ("Error Connection")
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim i As Integer
        CommClose(Hcom)
        Hcom = CommOpen(txtCRTCOM.Text)
        i = CRT310_MovePosition(Hcom, CRT_POSITION.RF_POSITION)
        If i = 0 Then
            Displ("Command Ok")
        Else
            Displ("Error Command")
        End If
        CommClose(Hcom)
    End Sub

    Function cCode(ByVal code As String) As String
        cCode = Trim(Mid(code, 1, 2)) + Trim(Mid(code, 4, 2)) + Trim(Mid(code, 7, 2)) + Trim(Mid(code, 10, 2)) '11111111
    End Function

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim x(3) As Byte
        Dim i As Integer = 0
        CommClose(Hcom)
        Hcom = CommOpen(txtCRTCOM.Text)
        i = RF_GetCardID(Hcom, x)
        If i = 0 Then
            Dim cardcode As String = ByteToHex(x)

            Displ("CardCode := " & cCode(cardcode))
        Else
            Displ("CardCode Error")
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        CRT_AUTHEN(3)
        Sleep(200)

        Dim ss As String = CRT_READ(Hcom, txtSector.Text, txtBlock.Text)

        Displ("Data : " & ss)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim i As Integer
        CommClose(Hcom)
        Hcom = CommOpen(txtCRTCOM.Text)
        i = CRT310_MovePosition(Hcom, CRT_POSITION.Release)
        CommClose(Hcom)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtCrtTest.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        CommClose(Hcom)
        Hcom = CommOpen(txtCRTCOM.Text)
        i = CRT310_MovePosition(Hcom, CRT_POSITION.Capture)
        CommClose(Hcom)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        With My.Settings
            .DEV_ComPort = txtCRTCOM.Text
            .DEV_Delay = txtDelay.Text
            .Save()
            MsgBox("Device settings saved!", vbInformation, "Save")
            Me.Close()
        End With
    End Sub

    Private Sub txtCRTCOM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCRTCOM.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

End Class
