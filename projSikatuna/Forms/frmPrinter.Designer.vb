<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrinter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrinter))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdTest1 = New System.Windows.Forms.Button
        Me.cboDriver = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmdTest1)
        Me.Panel1.Controls.Add(Me.cboDriver)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 170)
        Me.Panel1.TabIndex = 0
        '
        'cmdTest1
        '
        Me.cmdTest1.BackColor = System.Drawing.Color.White
        Me.cmdTest1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTest1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTest1.Image = CType(resources.GetObject("cmdTest1.Image"), System.Drawing.Image)
        Me.cmdTest1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTest1.Location = New System.Drawing.Point(125, 88)
        Me.cmdTest1.Name = "cmdTest1"
        Me.cmdTest1.Size = New System.Drawing.Size(121, 34)
        Me.cmdTest1.TabIndex = 41
        Me.cmdTest1.Text = "       Test Print"
        Me.cmdTest1.UseVisualStyleBackColor = False
        '
        'cboDriver
        '
        Me.cboDriver.BackColor = System.Drawing.Color.White
        Me.cboDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDriver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDriver.FormattingEnabled = True
        Me.cboDriver.Location = New System.Drawing.Point(125, 46)
        Me.cboDriver.Name = "cboDriver"
        Me.cboDriver.Size = New System.Drawing.Size(188, 24)
        Me.cboDriver.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 16)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Printer Driver :"
        '
        'frmPrinter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(341, 187)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrinter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Printer Settings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdTest1 As System.Windows.Forms.Button
    Friend WithEvents cboDriver As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
