﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.DevStat = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtDbStat = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolMenu = New System.Windows.Forms.ToolStrip
        Me.cmdSettings = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.lblTime = New System.Windows.Forms.ToolStripLabel
        Me.lblZone = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtTime = New System.Windows.Forms.TextBox
        Me.txtCardCode = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtCounter = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCardStat = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTriggerStat = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tmeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.tmeCrt = New System.Windows.Forms.Timer(Me.components)
        Me.bwPushToServer = New System.ComponentModel.BackgroundWorker
        Me.btnStart = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnClose = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.lblTitle = New System.Windows.Forms.ToolStripLabel
        Me.btnImg = New System.Windows.Forms.ImageList(Me.components)
        Me.bwUpdateCnt = New System.ComponentModel.BackgroundWorker
        Me.StatusStrip1.SuspendLayout()
        Me.ToolMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel1, Me.DevStat, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel8, Me.txtDbStat})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 493)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(537, 37)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(10, 32)
        Me.ToolStripStatusLabel2.Text = " "
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Image = CType(resources.GetObject("ToolStripStatusLabel1.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(86, 32)
        Me.ToolStripStatusLabel1.Text = "Device :"
        '
        'DevStat
        '
        Me.DevStat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DevStat.ForeColor = System.Drawing.Color.LightCoral
        Me.DevStat.Name = "DevStat"
        Me.DevStat.Size = New System.Drawing.Size(42, 32)
        Me.DevStat.Text = " Stop"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(10, 32)
        Me.ToolStripStatusLabel5.Text = " "
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(10, 32)
        Me.ToolStripStatusLabel7.Text = " "
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel8.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel8.Image = CType(resources.GetObject("ToolStripStatusLabel8.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(102, 32)
        Me.ToolStripStatusLabel8.Text = "Database :"
        '
        'txtDbStat
        '
        Me.txtDbStat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDbStat.ForeColor = System.Drawing.Color.LightCoral
        Me.txtDbStat.Name = "txtDbStat"
        Me.txtDbStat.Size = New System.Drawing.Size(95, 32)
        Me.txtDbStat.Text = "Disconnected"
        '
        'ToolMenu
        '
        Me.ToolMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSettings, Me.ToolStripSeparator1, Me.lblTime, Me.lblZone, Me.ToolStripSeparator4})
        Me.ToolMenu.Location = New System.Drawing.Point(0, 26)
        Me.ToolMenu.Name = "ToolMenu"
        Me.ToolMenu.Size = New System.Drawing.Size(537, 39)
        Me.ToolMenu.TabIndex = 3
        Me.ToolMenu.Text = "ToolStrip1"
        '
        'cmdSettings
        '
        Me.cmdSettings.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSettings.ForeColor = System.Drawing.Color.White
        Me.cmdSettings.Image = CType(resources.GetObject("cmdSettings.Image"), System.Drawing.Image)
        Me.cmdSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSettings.Name = "cmdSettings"
        Me.cmdSettings.Size = New System.Drawing.Size(128, 36)
        Me.cmdSettings.Text = "(F1) Settings"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'lblTime
        '
        Me.lblTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblTime.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Image = CType(resources.GetObject("lblTime.Image"), System.Drawing.Image)
        Me.lblTime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(76, 36)
        Me.lblTime.Text = "Time"
        '
        'lblZone
        '
        Me.lblZone.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZone.ForeColor = System.Drawing.Color.White
        Me.lblZone.Image = CType(resources.GetObject("lblZone.Image"), System.Drawing.Image)
        Me.lblZone.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.lblZone.Name = "lblZone"
        Me.lblZone.Size = New System.Drawing.Size(122, 36)
        Me.lblZone.Text = "Entry Zone 1"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtTime)
        Me.GroupBox1.Controls.Add(Me.txtCardCode)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(20, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 137)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entry Information"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(217, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 30)
        Me.Button1.TabIndex = 902
        Me.Button1.Text = "Test"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'txtTime
        '
        Me.txtTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTime.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Location = New System.Drawing.Point(123, 74)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = True
        Me.txtTime.Size = New System.Drawing.Size(323, 20)
        Me.txtTime.TabIndex = 901
        Me.txtTime.TabStop = False
        Me.txtTime.Text = "yyyy-MM-dd HH:mm:ss"
        Me.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCardCode
        '
        Me.txtCardCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCardCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCardCode.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardCode.Location = New System.Drawing.Point(123, 38)
        Me.txtCardCode.Name = "txtCardCode"
        Me.txtCardCode.ReadOnly = True
        Me.txtCardCode.Size = New System.Drawing.Size(323, 20)
        Me.txtCardCode.TabIndex = 900
        Me.txtCardCode.TabStop = False
        Me.txtCardCode.Text = "00000000"
        Me.txtCardCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(66, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Time :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(27, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Card Code :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.txtCounter)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtCardStat)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtTriggerStat)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(20, 240)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(491, 167)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Status Information"
        '
        'txtCounter
        '
        Me.txtCounter.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCounter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCounter.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCounter.Location = New System.Drawing.Point(147, 120)
        Me.txtCounter.Name = "txtCounter"
        Me.txtCounter.ReadOnly = True
        Me.txtCounter.Size = New System.Drawing.Size(310, 20)
        Me.txtCounter.TabIndex = 907
        Me.txtCounter.TabStop = False
        Me.txtCounter.Text = "0"
        Me.txtCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 16)
        Me.Label1.TabIndex = 906
        Me.Label1.Text = "Inserted Counter :"
        '
        'txtCardStat
        '
        Me.txtCardStat.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCardStat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCardStat.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardStat.Location = New System.Drawing.Point(147, 37)
        Me.txtCardStat.Name = "txtCardStat"
        Me.txtCardStat.ReadOnly = True
        Me.txtCardStat.Size = New System.Drawing.Size(310, 20)
        Me.txtCardStat.TabIndex = 903
        Me.txtCardStat.TabStop = False
        Me.txtCardStat.Text = "No Card"
        Me.txtCardStat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(46, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Card Status :"
        '
        'txtTriggerStat
        '
        Me.txtTriggerStat.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTriggerStat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTriggerStat.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriggerStat.Location = New System.Drawing.Point(147, 77)
        Me.txtTriggerStat.Name = "txtTriggerStat"
        Me.txtTriggerStat.ReadOnly = True
        Me.txtTriggerStat.Size = New System.Drawing.Size(310, 20)
        Me.txtTriggerStat.TabIndex = 905
        Me.txtTriggerStat.TabStop = False
        Me.txtTriggerStat.Text = "Stanby"
        Me.txtTriggerStat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(28, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Trigger Status :"
        '
        'tmeTimer
        '
        Me.tmeTimer.Enabled = True
        '
        'tmeCrt
        '
        Me.tmeCrt.Interval = 1000
        '
        'bwPushToServer
        '
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStart.ImageIndex = 0
        Me.btnStart.Location = New System.Drawing.Point(20, 425)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(491, 49)
        Me.btnStart.TabIndex = 7
        Me.btnStart.Text = "&START SYSTEM"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Controls.Add(Me.ToolMenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(537, 65)
        Me.Panel1.TabIndex = 8
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Silver
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnClose, Me.ToolStripButton1, Me.lblTitle})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(537, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnClose
        '
        Me.btnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(24, 24)
        Me.btnClose.Text = "ToolStripButton1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(250, 24)
        Me.lblTitle.Text = "Turnstile Operating System v 1.2.1"
        '
        'btnImg
        '
        Me.btnImg.ImageStream = CType(resources.GetObject("btnImg.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.btnImg.TransparentColor = System.Drawing.Color.Transparent
        Me.btnImg.Images.SetKeyName(0, "icons8-toggle-off-32.png")
        Me.btnImg.Images.SetKeyName(1, "icons8-toggle-on-32.png")
        '
        'bwUpdateCnt
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(537, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolMenu.ResumeLayout(False)
        Me.ToolMenu.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DevStat As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtDbStat As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdSettings As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblTime As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblZone As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents txtCardCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCardStat As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTriggerStat As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tmeTimer As System.Windows.Forms.Timer
    Friend WithEvents tmeCrt As System.Windows.Forms.Timer
    Friend WithEvents bwPushToServer As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblTitle As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImg As System.Windows.Forms.ImageList
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtCounter As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bwUpdateCnt As System.ComponentModel.BackgroundWorker
End Class
