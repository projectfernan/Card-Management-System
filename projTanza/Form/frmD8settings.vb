Public Class frmD8settings

    Private Sub cmdInit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInit.Click
        If d8_conn() = True Then
            MsgBox("Initialize succefully!    ", vbInformation, "Initilize")
        Else
            MsgBox("Initialize Failed!    ", vbExclamation, "Initilize")
        End If
    End Sub

    Private Sub cmdBeep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBeep.Click
        d8_Beep()
    End Sub

    Private Sub cmdDetect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDetect.Click
        If d8_Card() = True Then
            MsgBox("Card detected!    ", vbInformation, "Detect")
        Else
            MsgBox("No card!    ", vbExclamation, "Detect")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If d8_AuthenOL() = True Then
            If d8_LoadpassOL() = True Then
                MsgBox("Card Code: " & d8_ReadOL(), vbInformation)
            Else
                MsgBox("Failed to load card password!", vbExclamation)
            End If
        Else
            MsgBox("Failed to athenticate the card!", vbExclamation)
        End If

    End Sub
End Class