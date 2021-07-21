<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGPIO
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGPIO))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pin5 = New System.Windows.Forms.CheckBox()
        Me.txtTrigger = New System.Windows.Forms.NumericUpDown()
        Me.pin4 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pin3 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pin6 = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pin7 = New System.Windows.Forms.CheckBox()
        Me.txtVehicleInFront = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pin2 = New System.Windows.Forms.CheckBox()
        Me.txtButtonCode2 = New System.Windows.Forms.NumericUpDown()
        Me.pin1 = New System.Windows.Forms.CheckBox()
        Me.txtLoopCode2 = New System.Windows.Forms.NumericUpDown()
        Me.txtDelay = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pin8 = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbDIO = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Btn = New System.Windows.Forms.Button()
        Me.txtOutPut = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdTestTrig2 = New System.Windows.Forms.Button()
        Me.txtTrigger2 = New System.Windows.Forms.NumericUpDown()
        Me.txtDelay2 = New System.Windows.Forms.NumericUpDown()
        Me.txtBarrier2 = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtButtonCode = New System.Windows.Forms.NumericUpDown()
        Me.txtLoopCode = New System.Windows.Forms.NumericUpDown()
        Me.txtBarrierPin = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.txtTrigger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVehicleInFront, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtButtonCode2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLoopCode2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDIO.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtTrigger2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDelay2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarrier2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtButtonCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLoopCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarrierPin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(258, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 16)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Trigger"
        '
        'pin5
        '
        Me.pin5.AutoSize = True
        Me.pin5.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pin5.Location = New System.Drawing.Point(204, 138)
        Me.pin5.Name = "pin5"
        Me.pin5.Size = New System.Drawing.Size(15, 14)
        Me.pin5.TabIndex = 8
        Me.pin5.UseVisualStyleBackColor = False
        '
        'txtTrigger
        '
        Me.txtTrigger.Location = New System.Drawing.Point(261, 32)
        Me.txtTrigger.Maximum = New Decimal(New Integer() {-1530494977, 232830, 0, 0})
        Me.txtTrigger.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtTrigger.Name = "txtTrigger"
        Me.txtTrigger.Size = New System.Drawing.Size(75, 22)
        Me.txtTrigger.TabIndex = 28
        Me.txtTrigger.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'pin4
        '
        Me.pin4.AutoSize = True
        Me.pin4.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pin4.Location = New System.Drawing.Point(255, 138)
        Me.pin4.Name = "pin4"
        Me.pin4.Size = New System.Drawing.Size(15, 14)
        Me.pin4.TabIndex = 7
        Me.pin4.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Button (Two-Wheels) :"
        Me.Label4.Visible = False
        '
        'pin3
        '
        Me.pin3.AutoSize = True
        Me.pin3.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pin3.Location = New System.Drawing.Point(306, 138)
        Me.pin3.Name = "pin3"
        Me.pin3.Size = New System.Drawing.Size(15, 14)
        Me.pin3.TabIndex = 6
        Me.pin3.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Loop (Two-Wheels) :"
        Me.Label3.Visible = False
        '
        'pin6
        '
        Me.pin6.AutoSize = True
        Me.pin6.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pin6.Location = New System.Drawing.Point(383, 178)
        Me.pin6.Name = "pin6"
        Me.pin6.Size = New System.Drawing.Size(15, 14)
        Me.pin6.TabIndex = 9
        Me.pin6.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Button (Four-Wheels) :"
        Me.Label8.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "( 0 to 7 )"
        '
        'pin7
        '
        Me.pin7.AutoSize = True
        Me.pin7.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pin7.Location = New System.Drawing.Point(332, 178)
        Me.pin7.Name = "pin7"
        Me.pin7.Size = New System.Drawing.Size(15, 14)
        Me.pin7.TabIndex = 10
        Me.pin7.UseVisualStyleBackColor = False
        '
        'txtVehicleInFront
        '
        Me.txtVehicleInFront.Location = New System.Drawing.Point(158, 238)
        Me.txtVehicleInFront.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.txtVehicleInFront.Name = "txtVehicleInFront"
        Me.txtVehicleInFront.Size = New System.Drawing.Size(98, 22)
        Me.txtVehicleInFront.TabIndex = 23
        Me.txtVehicleInFront.Value = New Decimal(New Integer() {2, 0, 0, 0})
        Me.txtVehicleInFront.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(38, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 16)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Vehicle in Front :"
        Me.Label10.Visible = False
        '
        'pin2
        '
        Me.pin2.AutoSize = True
        Me.pin2.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pin2.Location = New System.Drawing.Point(357, 138)
        Me.pin2.Name = "pin2"
        Me.pin2.Size = New System.Drawing.Size(15, 14)
        Me.pin2.TabIndex = 5
        Me.pin2.UseVisualStyleBackColor = False
        '
        'txtButtonCode2
        '
        Me.txtButtonCode2.Location = New System.Drawing.Point(158, 210)
        Me.txtButtonCode2.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.txtButtonCode2.Name = "txtButtonCode2"
        Me.txtButtonCode2.Size = New System.Drawing.Size(98, 22)
        Me.txtButtonCode2.TabIndex = 21
        Me.txtButtonCode2.Value = New Decimal(New Integer() {2, 0, 0, 0})
        Me.txtButtonCode2.Visible = False
        '
        'pin1
        '
        Me.pin1.AutoSize = True
        Me.pin1.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pin1.Location = New System.Drawing.Point(408, 138)
        Me.pin1.Name = "pin1"
        Me.pin1.Size = New System.Drawing.Size(15, 14)
        Me.pin1.TabIndex = 4
        Me.pin1.UseVisualStyleBackColor = False
        '
        'txtLoopCode2
        '
        Me.txtLoopCode2.Location = New System.Drawing.Point(158, 147)
        Me.txtLoopCode2.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.txtLoopCode2.Name = "txtLoopCode2"
        Me.txtLoopCode2.Size = New System.Drawing.Size(98, 22)
        Me.txtLoopCode2.TabIndex = 19
        Me.txtLoopCode2.Value = New Decimal(New Integer() {2, 0, 0, 0})
        Me.txtLoopCode2.Visible = False
        '
        'txtDelay
        '
        Me.txtDelay.Location = New System.Drawing.Point(177, 32)
        Me.txtDelay.Maximum = New Decimal(New Integer() {-1530494977, 232830, 0, 0})
        Me.txtDelay.Name = "txtDelay"
        Me.txtDelay.Size = New System.Drawing.Size(75, 22)
        Me.txtDelay.TabIndex = 17
        Me.txtDelay.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(175, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Delay"
        '
        'pin8
        '
        Me.pin8.AutoSize = True
        Me.pin8.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pin8.Location = New System.Drawing.Point(281, 178)
        Me.pin8.Name = "pin8"
        Me.pin8.Size = New System.Drawing.Size(15, 14)
        Me.pin8.TabIndex = 11
        Me.pin8.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(611, 258)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'gbDIO
        '
        Me.gbDIO.Controls.Add(Me.pin8)
        Me.gbDIO.Controls.Add(Me.pin7)
        Me.gbDIO.Controls.Add(Me.pin6)
        Me.gbDIO.Controls.Add(Me.pin5)
        Me.gbDIO.Controls.Add(Me.pin4)
        Me.gbDIO.Controls.Add(Me.pin3)
        Me.gbDIO.Controls.Add(Me.pin2)
        Me.gbDIO.Controls.Add(Me.pin1)
        Me.gbDIO.Controls.Add(Me.PictureBox1)
        Me.gbDIO.Controls.Add(Me.Label12)
        Me.gbDIO.Controls.Add(Me.Label11)
        Me.gbDIO.Controls.Add(Me.Label9)
        Me.gbDIO.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbDIO.Location = New System.Drawing.Point(0, 0)
        Me.gbDIO.Name = "gbDIO"
        Me.gbDIO.Size = New System.Drawing.Size(613, 293)
        Me.gbDIO.TabIndex = 4
        Me.gbDIO.TabStop = False
        Me.gbDIO.Text = "Digital IO Pin Configuration"
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(342, 25)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(136, 35)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Test Barrier"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Btn
        '
        Me.Btn.Image = CType(resources.GetObject("Btn.Image"), System.Drawing.Image)
        Me.Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn.Location = New System.Drawing.Point(262, 156)
        Me.Btn.Name = "Btn"
        Me.Btn.Size = New System.Drawing.Size(136, 35)
        Me.Btn.TabIndex = 12
        Me.Btn.Text = "Scan Pin"
        Me.Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn.UseVisualStyleBackColor = True
        Me.Btn.Visible = False
        '
        'txtOutPut
        '
        Me.txtOutPut.AutoSize = True
        Me.txtOutPut.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutPut.ForeColor = System.Drawing.Color.Red
        Me.txtOutPut.Location = New System.Drawing.Point(259, 226)
        Me.txtOutPut.Name = "txtOutPut"
        Me.txtOutPut.Size = New System.Drawing.Size(46, 31)
        Me.txtOutPut.TabIndex = 11
        Me.txtOutPut.Text = "00"
        Me.txtOutPut.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdTestTrig2)
        Me.GroupBox1.Controls.Add(Me.txtTrigger2)
        Me.GroupBox1.Controls.Add(Me.txtDelay2)
        Me.GroupBox1.Controls.Add(Me.txtBarrier2)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtTrigger)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtVehicleInFront)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtButtonCode2)
        Me.GroupBox1.Controls.Add(Me.txtLoopCode2)
        Me.GroupBox1.Controls.Add(Me.txtDelay)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Btn)
        Me.GroupBox1.Controls.Add(Me.txtOutPut)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtButtonCode)
        Me.GroupBox1.Controls.Add(Me.txtLoopCode)
        Me.GroupBox1.Controls.Add(Me.txtBarrierPin)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 299)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(613, 71)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'cmdTestTrig2
        '
        Me.cmdTestTrig2.Image = CType(resources.GetObject("cmdTestTrig2.Image"), System.Drawing.Image)
        Me.cmdTestTrig2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTestTrig2.Location = New System.Drawing.Point(342, 70)
        Me.cmdTestTrig2.Name = "cmdTestTrig2"
        Me.cmdTestTrig2.Size = New System.Drawing.Size(136, 35)
        Me.cmdTestTrig2.TabIndex = 34
        Me.cmdTestTrig2.Text = "Test Barrier"
        Me.cmdTestTrig2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdTestTrig2.UseVisualStyleBackColor = True
        Me.cmdTestTrig2.Visible = False
        '
        'txtTrigger2
        '
        Me.txtTrigger2.Location = New System.Drawing.Point(261, 77)
        Me.txtTrigger2.Maximum = New Decimal(New Integer() {-1530494977, 232830, 0, 0})
        Me.txtTrigger2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtTrigger2.Name = "txtTrigger2"
        Me.txtTrigger2.Size = New System.Drawing.Size(75, 22)
        Me.txtTrigger2.TabIndex = 33
        Me.txtTrigger2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtTrigger2.Visible = False
        '
        'txtDelay2
        '
        Me.txtDelay2.Location = New System.Drawing.Point(177, 77)
        Me.txtDelay2.Maximum = New Decimal(New Integer() {-1530494977, 232830, 0, 0})
        Me.txtDelay2.Name = "txtDelay2"
        Me.txtDelay2.Size = New System.Drawing.Size(75, 22)
        Me.txtDelay2.TabIndex = 32
        Me.txtDelay2.Value = New Decimal(New Integer() {300, 0, 0, 0})
        Me.txtDelay2.Visible = False
        '
        'txtBarrier2
        '
        Me.txtBarrier2.Location = New System.Drawing.Point(119, 77)
        Me.txtBarrier2.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.txtBarrier2.Name = "txtBarrier2"
        Me.txtBarrier2.Size = New System.Drawing.Size(52, 22)
        Me.txtBarrier2.TabIndex = 31
        Me.txtBarrier2.Value = New Decimal(New Integer() {7, 0, 0, 0})
        Me.txtBarrier2.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 32)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Barrier2 Pin No. :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label14.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(259, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Output"
        Me.Label6.Visible = False
        '
        'txtButtonCode
        '
        Me.txtButtonCode.Location = New System.Drawing.Point(158, 179)
        Me.txtButtonCode.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.txtButtonCode.Name = "txtButtonCode"
        Me.txtButtonCode.Size = New System.Drawing.Size(98, 22)
        Me.txtButtonCode.TabIndex = 9
        Me.txtButtonCode.Value = New Decimal(New Integer() {2, 0, 0, 0})
        Me.txtButtonCode.Visible = False
        '
        'txtLoopCode
        '
        Me.txtLoopCode.Location = New System.Drawing.Point(158, 119)
        Me.txtLoopCode.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.txtLoopCode.Name = "txtLoopCode"
        Me.txtLoopCode.Size = New System.Drawing.Size(98, 22)
        Me.txtLoopCode.TabIndex = 8
        Me.txtLoopCode.Value = New Decimal(New Integer() {2, 0, 0, 0})
        Me.txtLoopCode.Visible = False
        '
        'txtBarrierPin
        '
        Me.txtBarrierPin.Location = New System.Drawing.Point(119, 32)
        Me.txtBarrierPin.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.txtBarrierPin.Name = "txtBarrierPin"
        Me.txtBarrierPin.Size = New System.Drawing.Size(52, 22)
        Me.txtBarrierPin.TabIndex = 7
        Me.txtBarrierPin.Value = New Decimal(New Integer() {7, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Loop (Four-Wheels) :"
        Me.Label5.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "  Pin No. :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Timer1
        '
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Check all"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(66, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "INPUT"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(115, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 16)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "pins"
        '
        'frmGPIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 381)
        Me.Controls.Add(Me.gbDIO)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGPIO"
        Me.Text = " Digital IO Settings"
        CType(Me.txtTrigger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVehicleInFront, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtButtonCode2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLoopCode2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDelay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDIO.ResumeLayout(False)
        Me.gbDIO.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtTrigger2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDelay2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBarrier2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtButtonCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLoopCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBarrierPin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents pin5 As System.Windows.Forms.CheckBox
    Friend WithEvents txtTrigger As System.Windows.Forms.NumericUpDown
    Friend WithEvents pin4 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pin3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pin6 As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pin7 As System.Windows.Forms.CheckBox
    Friend WithEvents txtVehicleInFront As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents pin2 As System.Windows.Forms.CheckBox
    Friend WithEvents txtButtonCode2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents pin1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtLoopCode2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtDelay As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pin8 As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gbDIO As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Btn As System.Windows.Forms.Button
    Friend WithEvents txtOutPut As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtButtonCode As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtLoopCode As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtBarrierPin As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtTrigger2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtDelay2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtBarrier2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmdTestTrig2 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
