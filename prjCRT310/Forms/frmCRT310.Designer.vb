<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrt310
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrt310))
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtCrtTest = New System.Windows.Forms.RichTextBox
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtCRTCOM = New System.Windows.Forms.ComboBox
        Me.txtSector = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBlock = New System.Windows.Forms.NumericUpDown
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.txtDelay = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.txtSector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBlock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(18, 388)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 24)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "&Clear Text"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtCrtTest
        '
        Me.txtCrtTest.Location = New System.Drawing.Point(134, 18)
        Me.txtCrtTest.Name = "txtCrtTest"
        Me.txtCrtTest.Size = New System.Drawing.Size(363, 395)
        Me.txtCrtTest.TabIndex = 20
        Me.txtCrtTest.Text = ""
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.White
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.Location = New System.Drawing.Point(15, 250)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(113, 24)
        Me.Button10.TabIndex = 19
        Me.Button10.Text = "&Check Card"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(15, 121)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(113, 24)
        Me.Button7.TabIndex = 18
        Me.Button7.Text = "&Test Read SN"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(15, 91)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(113, 24)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "&Test Card RF"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(15, 280)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(113, 24)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "&Test Card Out"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(15, 61)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(113, 24)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "&Test Connection"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(12, 18)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(73, 13)
        Me.Label23.TabIndex = 13
        Me.Label23.Text = "COM PORT : "
        '
        'txtCRTCOM
        '
        Me.txtCRTCOM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtCRTCOM.FormattingEnabled = True
        Me.txtCRTCOM.Location = New System.Drawing.Point(15, 34)
        Me.txtCRTCOM.Name = "txtCRTCOM"
        Me.txtCRTCOM.Size = New System.Drawing.Size(113, 21)
        Me.txtCRTCOM.TabIndex = 14
        '
        'txtSector
        '
        Me.txtSector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSector.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSector.Location = New System.Drawing.Point(15, 174)
        Me.txtSector.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtSector.Name = "txtSector"
        Me.txtSector.Size = New System.Drawing.Size(113, 22)
        Me.txtSector.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "SECTOR NO. : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "BLOCK NO. : "
        '
        'txtBlock
        '
        Me.txtBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBlock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlock.Location = New System.Drawing.Point(15, 223)
        Me.txtBlock.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtBlock.Name = "txtBlock"
        Me.txtBlock.Size = New System.Drawing.Size(113, 22)
        Me.txtBlock.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(15, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 24)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "&Eject Rear"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(384, 419)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 24)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "&Save Settings"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtDelay
        '
        Me.txtDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDelay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelay.Location = New System.Drawing.Point(18, 358)
        Me.txtDelay.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtDelay.Name = "txtDelay"
        Me.txtDelay.Size = New System.Drawing.Size(113, 22)
        Me.txtDelay.TabIndex = 29
        Me.txtDelay.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(15, 339)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "DELAY : "
        '
        'frmCrt310
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(510, 451)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDelay)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBlock)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSector)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtCrtTest)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtCRTCOM)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCrt310"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " CRT310 Settings"
        CType(Me.txtSector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBlock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDelay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtCrtTest As System.Windows.Forms.RichTextBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtCRTCOM As System.Windows.Forms.ComboBox
    Friend WithEvents txtSector As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBlock As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtDelay As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
