<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSetZone
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSetZone))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cboSdb = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmdSave)
        Me.Panel1.Controls.Add(Me.cboSdb)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 136)
        Me.Panel1.TabIndex = 1
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.White
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.Color.Black
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(117, 75)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(103, 34)
        Me.cmdSave.TabIndex = 21
        Me.cmdSave.Text = "      Set "
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cboSdb
        '
        Me.cboSdb.BackColor = System.Drawing.Color.White
        Me.cboSdb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSdb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSdb.FormattingEnabled = True
        Me.cboSdb.Items.AddRange(New Object() {"Entry Zone 1", "Entry Zone 2", "Entry Zone 3", "Entry Zone 4", "Entry Zone 5", "Entry Zone 6", "Entry Zone 7", "Entry Zone 8", "Entry Zone 9", "Entry Zone 10", "Entry Zone 11", "Entry Zone 12", "Entry Zone 13", "Entry Zone 14", "Entry Zone 15", "Entry Zone 16", "Entry Zone 17", "Entry Zone 18", "Entry Zone 19", "Entry Zone 20", "Entry Zone 21", "Entry Zone 22", "Entry Zone 23", "Entry Zone 24", "Entry Zone 25", "Entry Zone 26", "Entry Zone 27", "Entry Zone 28", "Entry Zone 29", "Entry Zone 30", "Entry Zone 31", "Entry Zone 32", "Entry Zone 33", "Entry Zone 34", "Entry Zone 35", "Entry Zone 36", "Entry Zone 37", "Entry Zone 38", "Entry Zone 39", "Entry Zone 40", "Entry Zone 41", "Entry Zone 42", "Entry Zone 43", "Entry Zone 44", "Entry Zone 45", "Entry Zone 46", "Entry Zone 47", "Entry Zone 48", "Entry Zone 49", "Entry Zone 50", "Entry Zone 51", "Entry Zone 52", "Entry Zone 53", "Entry Zone 54", "Entry Zone 55", "Entry Zone 56", "Entry Zone 57", "Entry Zone 58", "Entry Zone 59", "Entry Zone 60", "Entry Zone 61", "Entry Zone 62", "Entry Zone 63", "Entry Zone 64", "Entry Zone 65", "Entry Zone 66", "Entry Zone 67", "Entry Zone 68", "Entry Zone 69", "Entry Zone 70", "Entry Zone 71", "Entry Zone 72", "Entry Zone 73", "Entry Zone 74", "Entry Zone 75", "Entry Zone 76", "Entry Zone 77", "Entry Zone 78", "Entry Zone 79", "Entry Zone 80", "Entry Zone 81", "Entry Zone 82", "Entry Zone 83", "Entry Zone 84", "Entry Zone 85", "Entry Zone 86", "Entry Zone 87", "Entry Zone 88", "Entry Zone 89", "Entry Zone 90", "Entry Zone 91", "Entry Zone 92", "Entry Zone 93", "Entry Zone 94", "Entry Zone 95", "Entry Zone 96", "Entry Zone 97", "Entry Zone 98", "Entry Zone 99", "Entry Zone 100"})
        Me.cboSdb.Location = New System.Drawing.Point(110, 29)
        Me.cboSdb.Name = "cboSdb"
        Me.cboSdb.Size = New System.Drawing.Size(138, 24)
        Me.cboSdb.TabIndex = 19
        Me.cboSdb.Text = "Entry Zone 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(53, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Zone :"
        '
        'FrmSetZone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(338, 149)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSetZone"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Set Zone"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cboSdb As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
