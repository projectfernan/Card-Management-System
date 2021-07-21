<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDb))
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdTest1 = New System.Windows.Forms.Button
        Me.cboSdb = New System.Windows.Forms.ComboBox
        Me.txtSPort = New System.Windows.Forms.NumericUpDown
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPwd1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUser1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtIp1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.cboOdbc = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.txtSPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.Color.White
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(288, 319)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(89, 34)
        Me.cmdSave.TabIndex = 21
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdTest1
        '
        Me.cmdTest1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdTest1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTest1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTest1.ForeColor = System.Drawing.Color.Black
        Me.cmdTest1.Image = CType(resources.GetObject("cmdTest1.Image"), System.Drawing.Image)
        Me.cmdTest1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTest1.Location = New System.Drawing.Point(344, 266)
        Me.cmdTest1.Name = "cmdTest1"
        Me.cmdTest1.Size = New System.Drawing.Size(33, 34)
        Me.cmdTest1.TabIndex = 20
        Me.cmdTest1.UseVisualStyleBackColor = False
        '
        'cboSdb
        '
        Me.cboSdb.BackColor = System.Drawing.Color.White
        Me.cboSdb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSdb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSdb.FormattingEnabled = True
        Me.cboSdb.Location = New System.Drawing.Point(115, 270)
        Me.cboSdb.Name = "cboSdb"
        Me.cboSdb.Size = New System.Drawing.Size(223, 24)
        Me.cboSdb.TabIndex = 4
        '
        'txtSPort
        '
        Me.txtSPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSPort.Location = New System.Drawing.Point(115, 186)
        Me.txtSPort.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.txtSPort.Name = "txtSPort"
        Me.txtSPort.Size = New System.Drawing.Size(263, 22)
        Me.txtSPort.TabIndex = 3
        Me.txtSPort.Value = New Decimal(New Integer() {3306, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(63, 186)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Port :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(24, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Database :"
        '
        'txtPwd1
        '
        Me.txtPwd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPwd1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPwd1.Location = New System.Drawing.Point(115, 145)
        Me.txtPwd1.Name = "txtPwd1"
        Me.txtPwd1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd1.Size = New System.Drawing.Size(263, 22)
        Me.txtPwd1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(25, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Password :"
        '
        'txtUser1
        '
        Me.txtUser1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser1.Location = New System.Drawing.Point(115, 104)
        Me.txtUser1.Name = "txtUser1"
        Me.txtUser1.Size = New System.Drawing.Size(263, 22)
        Me.txtUser1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(22, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Username :"
        '
        'txtIp1
        '
        Me.txtIp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIp1.Location = New System.Drawing.Point(115, 63)
        Me.txtIp1.Name = "txtIp1"
        Me.txtIp1.Size = New System.Drawing.Size(263, 22)
        Me.txtIp1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(29, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Server IP :"
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.Label9)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(400, 38)
        Me.HeaderPanel.TabIndex = 99
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Location = New System.Drawing.Point(6, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(170, 18)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "     Database Settings"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(378, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'cboOdbc
        '
        Me.cboOdbc.AutoCompleteCustomSource.AddRange(New String() {"MySQL ODBC 5.1 Driver", "MySQL ODBC 8.0 Unicode Driver"})
        Me.cboOdbc.BackColor = System.Drawing.Color.White
        Me.cboOdbc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboOdbc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOdbc.FormattingEnabled = True
        Me.cboOdbc.Items.AddRange(New Object() {"MySQL ODBC 5.1 Driver", "MySQL ODBC 8.0 Unicode Driver"})
        Me.cboOdbc.Location = New System.Drawing.Point(115, 226)
        Me.cboOdbc.Name = "cboOdbc"
        Me.cboOdbc.Size = New System.Drawing.Size(262, 24)
        Me.cboOdbc.TabIndex = 100
        Me.cboOdbc.Text = "MySQL ODBC 5.1 Driver"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(50, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Driver :"
        '
        'frmDb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(400, 377)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboOdbc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdTest1)
        Me.Controls.Add(Me.cboSdb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSPort)
        Me.Controls.Add(Me.txtIp1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUser1)
        Me.Controls.Add(Me.txtPwd1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.txtSPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboSdb As System.Windows.Forms.ComboBox
    Friend WithEvents txtSPort As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPwd1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUser1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIp1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdTest1 As System.Windows.Forms.Button
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents cboOdbc As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
