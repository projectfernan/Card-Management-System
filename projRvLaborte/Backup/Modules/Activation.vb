﻿Module Activation
    Public FullActi As String = "z3Nta1!aKut1"
    Public TrialActi As String = "aKut1!5aI8an"

    Public Sub SysActivation()
        Try
            If My.Settings.ActiCode = vbNullString Then
                frmActivation.ShowDialog()
                Exit Sub
            End If

            Dim deActiCode As String = DecryptCode(My.Settings.ActiCode)

            With frmAbout
                Select Case deActiCode
                    Case FullActi
                        MainForm.lblTrial.Visible = False
                        .lblActiStat.Text = "Activated"
                        .btnActivate.Visible = False
                    Case TrialActi
                        Dim trialStart As String = DecryptCode(My.Settings.TrialStart)
                        Dim trialDays As String = DecryptCode(My.Settings.TrialDays)

                        Dim trdt1 As Date = CDate(trialStart)
                        Dim trdt2 As Date = Now.Date

                        Dim daysDiff As Integer = DateDiff(DateInterval.Day, trdt1, trdt2)
                        Dim tDays As Integer = CInt(trialDays)
                        Dim daysRem As Integer = tDays - daysDiff

                        If daysRem <= 0 Then
                            MainForm.lblTrial.Text = "Trial Expired!"
                            MainForm.lblTrial.Visible = True
                            frmActivation.ShowDialog()
                        ElseIf daysRem = 1 Then
                            MainForm.lblTrial.Text = "Trial - " & daysRem.ToString & " Day Left"
                            MainForm.lblTrial.Visible = True
                            .lblActiStat.Text = "Trial - " & daysRem.ToString & " Day Left"
                            .btnActivate.Visible = True
                        Else
                            MainForm.lblTrial.Text = "Trial - " & daysRem.ToString & " Days Left"
                            MainForm.lblTrial.Visible = True
                            .lblActiStat.Text = "Trial - " & daysRem.ToString & " Days Left"
                            .btnActivate.Visible = True
                        End If
                    Case Else
                        frmActivation.ShowDialog()
                End Select
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Activation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Function resetFlogs() As Boolean
    '    Try
    '        Dim delLogs As String = "delete * from tblErrLogs"
    '        Dim AlterId As String = "Alter Table tblErrLogs Alter Column ID Counter(1,1);"

    '        If ConnFLogs() = False Then Return False
    '        rsFlogsCUD(delLogs)

    '        If ConnFLogs() = False Then Return False
    '        rsFlogsCUD(AlterId)

    '        Return True
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function
End Module
