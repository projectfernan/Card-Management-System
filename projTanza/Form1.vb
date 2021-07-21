Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim iPort As Integer
            Dim iData As Integer

            iPort = TextBox1.Text 'Convert.ToInt16(TextBox1.Text)
            iData = TextBox2.Text 'Convert.ToInt16(TextBox2.Text)

            If (m_bX64) Then
                Out32_x64(iPort, iData)
            Else
                Out32(iPort, iData)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occured:\n" + ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            ' Label1.Text = "Unable to open InpOut driver"
        End If

        My.Settings.PortAdd = 888
        My.Settings.Save()

        txtPortAdd.Text = My.Settings.PortAdd
        txtPort.Value = My.Settings.Port


    End Sub

    Private Sub cmdTest1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest1.Click
        Try
            Dim iPort As Integer
            Dim iData As Integer

            iPort = txtPortAdd.Text    'Convert.ToInt16(TextBox1.Text)
            iData = txtPort.Value   'Convert.ToInt16(TextBox2.Text)

            If (m_bX64) Then
                Out32_x64(iPort, iData)
            Else
                Out32(iPort, iData)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occured:\n" + ex.Message)
        End Try
    End Sub
End Class
