<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.cmdSetZone = New System.Windows.Forms.ToolStripButton()
        Me.cmdDb = New System.Windows.Forms.ToolStripButton()
        Me.cmdDevice = New System.Windows.Forms.ToolStripButton()
        Me.cmdSync = New System.Windows.Forms.ToolStripButton()
        Me.cmdAbout = New System.Windows.Forms.ToolStripButton()
        Me.cmdtrig = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ParallelPortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GPIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ToolStrip2)
        Me.Panel1.Location = New System.Drawing.Point(7, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 347)
        Me.Panel1.TabIndex = 8
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.White
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSetZone, Me.cmdDb, Me.cmdtrig, Me.cmdDevice, Me.cmdSync, Me.cmdAbout})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(284, 360)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'cmdSetZone
        '
        Me.cmdSetZone.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSetZone.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetZone.ForeColor = System.Drawing.Color.White
        Me.cmdSetZone.Image = CType(resources.GetObject("cmdSetZone.Image"), System.Drawing.Image)
        Me.cmdSetZone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSetZone.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdSetZone.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSetZone.Name = "cmdSetZone"
        Me.cmdSetZone.Size = New System.Drawing.Size(282, 52)
        Me.cmdSetZone.Text = "(F1) Set Entry Zone"
        '
        'cmdDb
        '
        Me.cmdDb.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdDb.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDb.ForeColor = System.Drawing.Color.White
        Me.cmdDb.Image = CType(resources.GetObject("cmdDb.Image"), System.Drawing.Image)
        Me.cmdDb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDb.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdDb.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDb.Name = "cmdDb"
        Me.cmdDb.Size = New System.Drawing.Size(282, 52)
        Me.cmdDb.Text = "(F2) Database Settings"
        '
        'cmdDevice
        '
        Me.cmdDevice.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdDevice.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDevice.ForeColor = System.Drawing.Color.White
        Me.cmdDevice.Image = CType(resources.GetObject("cmdDevice.Image"), System.Drawing.Image)
        Me.cmdDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDevice.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdDevice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDevice.Name = "cmdDevice"
        Me.cmdDevice.Size = New System.Drawing.Size(282, 52)
        Me.cmdDevice.Text = "(F5) Device Settings"
        '
        'cmdSync
        '
        Me.cmdSync.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSync.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSync.ForeColor = System.Drawing.Color.White
        Me.cmdSync.Image = CType(resources.GetObject("cmdSync.Image"), System.Drawing.Image)
        Me.cmdSync.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSync.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdSync.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSync.Name = "cmdSync"
        Me.cmdSync.Size = New System.Drawing.Size(282, 52)
        Me.cmdSync.Text = "(F6) Date and Time Sync"
        '
        'cmdAbout
        '
        Me.cmdAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdAbout.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAbout.ForeColor = System.Drawing.Color.White
        Me.cmdAbout.Image = CType(resources.GetObject("cmdAbout.Image"), System.Drawing.Image)
        Me.cmdAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(282, 52)
        Me.cmdAbout.Text = "(ESC) Exit Program"
        '
        'cmdtrig
        '
        Me.cmdtrig.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdtrig.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParallelPortToolStripMenuItem, Me.GPIOToolStripMenuItem})
        Me.cmdtrig.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdtrig.ForeColor = System.Drawing.Color.White
        Me.cmdtrig.Image = CType(resources.GetObject("cmdtrig.Image"), System.Drawing.Image)
        Me.cmdtrig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdtrig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdtrig.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdtrig.Name = "cmdtrig"
        Me.cmdtrig.Size = New System.Drawing.Size(282, 52)
        Me.cmdtrig.Text = " (F3) Trigger Settings"
        '
        'ParallelPortToolStripMenuItem
        '
        Me.ParallelPortToolStripMenuItem.Name = "ParallelPortToolStripMenuItem"
        Me.ParallelPortToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ParallelPortToolStripMenuItem.Text = "Parallel Port"
        '
        'GPIOToolStripMenuItem
        '
        Me.GPIOToolStripMenuItem.Name = "GPIOToolStripMenuItem"
        Me.GPIOToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.GPIOToolStripMenuItem.Text = "Digital IO"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(298, 356)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Settings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdSetZone As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDb As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDevice As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAbout As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSync As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdtrig As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ParallelPortToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GPIOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
