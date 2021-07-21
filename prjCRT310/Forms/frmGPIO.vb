Public Class frmGPIO

    Private Sub frmGPIO_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Save()
    End Sub

    Private Sub frmGPIO_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Fill()
    End Sub

    Private Sub Fill()
        Try
            Dim x As New GPIO_Config
            x = Get_GPIO_Config()
            Me.txtLoopCode.Value = x.FourWheels_Code
            Me.txtLoopCode2.Value = x.TwoWheels_Code
            Me.txtButtonCode.Value = x.FourWheels_Button
            Me.txtButtonCode2.Value = x.TwoWheels_Button
            Me.txtDelay.Value = x.GPIO_Delay
            Me.txtDelay2.Value = x.GPIO_Delay2
            Me.txtBarrierPin.Value = x.Barrier_Pin
            Me.txtBarrier2.Value = x.Barrier_Pin2
            Me.txtVehicleInFront.Value = x.VehFront_Pin
            Me.txtTrigger.Value = x.Trigger_Times
            Me.txtTrigger2.Value = x.Trigger_Times2
            Dim pins As String = x.Input_Pins
            Me.pin1.Checked = CBool(pins.Substring(7, 1))
            Me.pin2.Checked = CBool(pins.Substring(6, 1))
            Me.pin3.Checked = CBool(pins.Substring(5, 1))
            Me.pin4.Checked = CBool(pins.Substring(4, 1))
            Me.pin5.Checked = CBool(pins.Substring(3, 1))
            Me.pin6.Checked = CBool(pins.Substring(2, 1))
            Me.pin7.Checked = CBool(pins.Substring(1, 1))
            Me.pin8.Checked = CBool(pins.Substring(0, 1))

        Catch ex As Exception

        End Try
       
    End Sub
    Private Sub Save()

        Dim x As New ini(IniFile)
        x.WriteInteger("GPIO", "CODE1", Me.txtLoopCode.Value)
        x.WriteInteger("GPIO", "CODE2", Me.txtLoopCode2.Value)
        x.WriteInteger("GPIO", "BUTTON1", Me.txtButtonCode.Value)
        x.WriteInteger("GPIO", "BUTTON2", Me.txtButtonCode2.Value)
        x.WriteInteger("GPIO", "BARPIN", Me.txtBarrierPin.Value)
        x.WriteInteger("GPIO", "BARPIN2", Me.txtBarrier2.Value)
        x.WriteInteger("GPIO", "VFPIN", Me.txtVehicleInFront.Value)
        x.WriteInteger("GPIO", "DELAY", Me.txtDelay.Value)
        x.WriteInteger("GPIO", "DELAY2", Me.txtDelay2.Value)
        Dim pins As String = (CInt(Me.pin8.Checked).ToString & CInt(Me.pin7.Checked).ToString & CInt(Me.pin6.Checked).ToString & CInt(Me.pin5.Checked).ToString & CInt(Me.pin4.Checked).ToString & CInt(Me.pin3.Checked).ToString & CInt(Me.pin2.Checked).ToString & CInt(Me.pin1.Checked).ToString).Replace("-", "")
        x.WriteString("GPIO", "PINS", pins)
        x.WriteInteger("GPIO", "TIMES", Me.txtTrigger.Value)
        x.WriteInteger("GPIO", "TIMES2", Me.txtTrigger2.Value)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Me.Timer1.Enabled = True Then
            Btn.Text = "Scan Pin"
            Timer1.Enabled = False
            txtOutPut.Text = "00"
        End If
        Save()
        Barrier_Up()
    End Sub

    Private Sub cmdTestTrig2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTestTrig2.Click
        If Me.Timer1.Enabled = True Then
            Btn.Text = "Scan Pin"
            Timer1.Enabled = False
            txtOutPut.Text = "00"
        End If
        Save()
        Barrier_Up2()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim x As New GPIO_Config
        x = Get_GPIO_Config()
        Try
            txtOutPut.Text = Read_Multiple(CInt(x.Input_Pins))
        Catch ex As Exception
            txtOutPut.Text = "Error"
            Exit Sub
        End Try
    End Sub

    Private Sub Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn.Click
        If Btn.Text = "Scan Pin" Then
            Btn.Text = "Stop"
            Timer1.Enabled = True
        Else
            Btn.Text = "Scan Pin"
            Timer1.Enabled = False
            txtOutPut.Text = "00"
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub gbDIO_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbDIO.Enter

    End Sub
End Class