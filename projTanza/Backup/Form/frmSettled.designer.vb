<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettled
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettled))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTimeIn = New System.Windows.Forms.Label
        Me.txtEvent = New System.Windows.Forms.Label
        Me.txtCardTyp = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(9, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 205)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaction Settled"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtTimeIn)
        Me.GroupBox2.Controls.Add(Me.txtEvent)
        Me.GroupBox2.Controls.Add(Me.txtCardTyp)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 167)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(100, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 24)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Time :"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(50, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 24)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Card Type :"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(94, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 24)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Event :"
        '
        'txtTimeIn
        '
        Me.txtTimeIn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTimeIn.AutoSize = True
        Me.txtTimeIn.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeIn.ForeColor = System.Drawing.Color.Lime
        Me.txtTimeIn.Location = New System.Drawing.Point(175, 106)
        Me.txtTimeIn.Name = "txtTimeIn"
        Me.txtTimeIn.Size = New System.Drawing.Size(34, 23)
        Me.txtTimeIn.TabIndex = 80
        Me.txtTimeIn.Text = "---"
        '
        'txtEvent
        '
        Me.txtEvent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtEvent.AutoSize = True
        Me.txtEvent.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEvent.ForeColor = System.Drawing.Color.Lime
        Me.txtEvent.Location = New System.Drawing.Point(175, 40)
        Me.txtEvent.Name = "txtEvent"
        Me.txtEvent.Size = New System.Drawing.Size(34, 23)
        Me.txtEvent.TabIndex = 77
        Me.txtEvent.Text = "---"
        '
        'txtCardTyp
        '
        Me.txtCardTyp.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCardTyp.AutoSize = True
        Me.txtCardTyp.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardTyp.ForeColor = System.Drawing.Color.Lime
        Me.txtCardTyp.Location = New System.Drawing.Point(175, 73)
        Me.txtCardTyp.Name = "txtCardTyp"
        Me.txtCardTyp.Size = New System.Drawing.Size(34, 23)
        Me.txtCardTyp.TabIndex = 76
        Me.txtCardTyp.Text = "---"
        '
        'frmSettled
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(493, 221)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSettled"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEvent As System.Windows.Forms.Label
    Friend WithEvents txtCardTyp As System.Windows.Forms.Label
    Friend WithEvents txtTimeIn As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
