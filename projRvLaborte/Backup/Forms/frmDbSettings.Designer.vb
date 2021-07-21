<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDbSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDbSettings))
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtUID = New System.Windows.Forms.TextBox
        Me.txtPort = New System.Windows.Forms.NumericUpDown
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmdTest1 = New System.Windows.Forms.Button
        Me.txtPWD = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtIp = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.txtTitle = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        CType(Me.txtPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(229, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 34)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "&Save"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtUID
        '
        Me.txtUID.BackColor = System.Drawing.Color.White
        Me.txtUID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUID.Location = New System.Drawing.Point(114, 98)
        Me.txtUID.Name = "txtUID"
        Me.txtUID.Size = New System.Drawing.Size(201, 22)
        Me.txtUID.TabIndex = 1
        '
        'txtPort
        '
        Me.txtPort.BackColor = System.Drawing.Color.White
        Me.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort.Location = New System.Drawing.Point(114, 180)
        Me.txtPort.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(161, 22)
        Me.txtPort.TabIndex = 3
        Me.txtPort.Value = New Decimal(New Integer() {3306, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(62, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 16)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Port :"
        '
        'cmdTest1
        '
        Me.cmdTest1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdTest1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTest1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTest1.ForeColor = System.Drawing.Color.Black
        Me.cmdTest1.Image = CType(resources.GetObject("cmdTest1.Image"), System.Drawing.Image)
        Me.cmdTest1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTest1.Location = New System.Drawing.Point(282, 173)
        Me.cmdTest1.Name = "cmdTest1"
        Me.cmdTest1.Size = New System.Drawing.Size(33, 34)
        Me.cmdTest1.TabIndex = 4
        Me.cmdTest1.UseVisualStyleBackColor = False
        '
        'txtPWD
        '
        Me.txtPWD.BackColor = System.Drawing.Color.White
        Me.txtPWD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPWD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPWD.Location = New System.Drawing.Point(114, 139)
        Me.txtPWD.Name = "txtPWD"
        Me.txtPWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPWD.Size = New System.Drawing.Size(201, 22)
        Me.txtPWD.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Username :"
        '
        'txtIp
        '
        Me.txtIp.BackColor = System.Drawing.Color.White
        Me.txtIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIp.Location = New System.Drawing.Point(114, 57)
        Me.txtIp.Name = "txtIp"
        Me.txtIp.Size = New System.Drawing.Size(201, 22)
        Me.txtIp.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(28, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Server IP :"
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.txtTitle)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(334, 38)
        Me.HeaderPanel.TabIndex = 109
        '
        'txtTitle
        '
        Me.txtTitle.AutoSize = True
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.ForeColor = System.Drawing.Color.White
        Me.txtTitle.Image = CType(resources.GetObject("txtTitle.Image"), System.Drawing.Image)
        Me.txtTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtTitle.Location = New System.Drawing.Point(6, 9)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(170, 18)
        Me.txtTitle.TabIndex = 28
        Me.txtTitle.Text = "     Database Settings"
        Me.txtTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(313, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'frmDbSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(334, 284)
        Me.ControlBox = False
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtUID)
        Me.Controls.Add(Me.txtIp)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdTest1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPWD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDbSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.txtPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUID As System.Windows.Forms.TextBox
    Friend WithEvents txtPort As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdTest1 As System.Windows.Forms.Button
    Friend WithEvents txtPWD As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIp As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents txtTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
End Class
