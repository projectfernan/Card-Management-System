<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStation))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cboStation = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.cboStation)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(9, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(349, 160)
        Me.Panel1.TabIndex = 0
        '
        'cboStation
        '
        Me.cboStation.BackColor = System.Drawing.Color.White
        Me.cboStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboStation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStation.FormattingEnabled = True
        Me.cboStation.Items.AddRange(New Object() {"Station 1", "Station 2", "Station 3", "Station 4", "Station 5", "Station 6", "Station 7", "Station 8", "Station 9", "Station 10", "Station 11", "Station 12", "Station 13", "Station 14", "Station 15", "Station 16", "Station 17", "Station 18", "Station 19", "Station 20", "Station 21", "Station 22", "Station 23", "Station 24", "Station 25", "Station 26", "Station 27", "Station 28", "Station 29", "Station 30", "Station 31", "Station 32", "Station 33", "Station 34", "Station 35", "Station 36", "Station 37", "Station 38", "Station 39", "Station 40", "Station 41", "Station 42", "Station 43", "Station 44", "Station 45", "Station 46", "Station 47", "Station 48", "Station 49", "Station 50", "Station 51", "Station 52", "Station 53", "Station 54", "Station 55", "Station 56", "Station 57", "Station 58", "Station 59", "Station 60", "Station 61", "Station 62", "Station 63", "Station 64", "Station 65", "Station 66", "Station 67", "Station 68", "Station 69", "Station 70", "Station 71", "Station 72", "Station 73", "Station 74", "Station 75", "Station 76", "Station 77", "Station 78", "Station 79", "Station 80", "Station 81", "Station 82", "Station 83", "Station 84", "Station 85", "Station 86", "Station 87", "Station 88", "Station 89", "Station 90", "Station 91", "Station 92", "Station 93", "Station 94", "Station 95", "Station 96", "Station 97", "Station 98", "Station 99", "Station 100"})
        Me.cboStation.Location = New System.Drawing.Point(120, 52)
        Me.cboStation.Name = "cboStation"
        Me.cboStation.Size = New System.Drawing.Size(177, 24)
        Me.cboStation.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(49, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Station :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(132, 92)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 34)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "       Save"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmStation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(367, 179)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Set Station"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboStation As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
