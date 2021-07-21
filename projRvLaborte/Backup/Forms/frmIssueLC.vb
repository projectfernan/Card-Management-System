Imports ADODB
Public Class frmIssueLC

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click

        If txtLastName.Text = vbNullString Or txtFirstName.Text = vbNullString Or txtMI.Text = vbNullString Then
            MessageBox.Show("Please complete all details required!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Dim txt As Control

            For Each txt In GroupBox1.Controls
                If TypeOf txt Is TextBox Then

                    If txt.Text = "" Then
                        If txtLastName.Text = "" Then
                            txtLastName.Focus()
                            Exit For
                        End If

                        If txtFirstName.Text = "" Then
                            txtFirstName.Focus()
                            Exit For
                        End If

                        If txtMI.Text = "" Then
                            txtMI.Focus()
                            Exit For
                        End If

                        Exit For
                    End If
                End If
            Next txt

            Exit Sub
        End If

        If MessageBox.Show("Are you sure your inputs are correct?", "Issuing Loyalty Card", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) <> Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If

recon:  If d8_conn() = False Then
            MessageBox.Show("Reader is not connected!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        d8_Beep()

        If d8_Card() = False Then
            MessageBox.Show("Please place the card to the reader!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If CardStat() = "TRUE" Then
            If My.Settings.LCow = False Then
                MessageBox.Show("Failed to register! The card is already issued to the other valid customer.", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If

resave: If saveLc() = False Then
            MessageBox.Show("Failed to save!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            If MessageBox.Show("Retry to save?", "Issuing Loyalty Card", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                GoTo resave
            End If
            Exit Sub
        End If

        If D8_LoadKey(2) = False Then
            MessageBox.Show("Failed to write card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                GoTo recon
            Else
                Exit Sub
            End If
        End If

        If D8_Authenticate(2) = False Then
            MessageBox.Show("Failed to write card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                GoTo recon
            Else
                Exit Sub
            End If
        End If

        If D8_WriteCard(8, txtLastName.Text) = False Then
            MessageBox.Show("Failed to write card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                GoTo recon
            Else
                Exit Sub
            End If
        End If

        If D8_WriteCard(9, txtFirstName.Text) = False Then
            MessageBox.Show("Failed to write card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                GoTo recon
            Else
                Exit Sub
            End If
        End If

        If D8_WriteCard(10, txtMI.Text) = False Then
            MessageBox.Show("Failed to write card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                GoTo recon
            Else
                Exit Sub
            End If
        End If

        If d8_Card() = False Then
            MessageBox.Show("Please place the card to the reader!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If D8_LoadKey(1) = False Then
            MessageBox.Show("Failed to write card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                GoTo recon
            Else
                Exit Sub
            End If
        End If

        If D8_Authenticate(1) = False Then
            MessageBox.Show("Failed to write card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                GoTo recon
            Else
                Exit Sub
            End If
        End If

        If D8_WriteCard(4, "0") = False Then
            MessageBox.Show("Failed to write card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                GoTo recon
            Else
                Exit Sub
            End If
        End If

        If D8_WriteCard(5, "TRUE") = False Then
            MessageBox.Show("Failed to write card!", "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If MessageBox.Show("Retry to write card?", "Retry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                GoTo recon
            Else
                Exit Sub
            End If
        End If

        MessageBox.Show("Loyalty card successfully registered to " & vbCrLf & _
                    txtLastName.Text & ", " & txtFirstName.Text & " " & txtMI.Text, "Issuing Loyalty Card", MessageBoxButtons.OK, MessageBoxIcon.Information)

        RD.dc_halt()

        Me.Close()
    End Sub

    Function saveLc() As Boolean
        Try
            If delLC(snr) = False Then
                Return False
            End If

            Dim dtNow As String = Format(Now, "yyyy-MM-dd HH:mm")
            Dim rs As New Recordset
            rs = Conn.Execute("insert into tblloyaltycards(CardCode,Lname,Fname,MI,RegDate)VALUES('" & snr & "','" & _
                                                                           txtLastName.Text & "','" & _
                                                                           txtFirstName.Text & "','" & _
                                                                           txtMI.Text & "','" & _
                                                                           dtNow & "')")
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Function delLC(ByVal cCode As String) As Boolean
        Try
            Dim dtNow As String = Format(Now, "yyyy-MM-dd HH:mm")
            Dim rs As New Recordset
            rs = Conn.Execute("delete from tblloyaltycards where CardCode = '" & cCode & "'")
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub frmIssueLC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cmdLogin_Click(sender, e)
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmIssueLC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loc(Me)
    End Sub
End Class