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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.cmdSetZone = New System.Windows.Forms.ToolStripButton
        Me.cmdDb = New System.Windows.Forms.ToolStripButton
        Me.cmdBarrier = New System.Windows.Forms.ToolStripButton
        Me.cmdDevice = New System.Windows.Forms.ToolStripButton
        Me.cmdSync = New System.Windows.Forms.ToolStripButton
        Me.cmdAbout = New System.Windows.Forms.ToolStripButton
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ToolStrip2)
        Me.Panel1.Location = New System.Drawing.Point(7, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 332)
        Me.Panel1.TabIndex = 8
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.White
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSetZone, Me.cmdDb, Me.cmdBarrier, Me.cmdDevice, Me.cmdSync, Me.cmdAbout})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(282, 332)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'cmdSetZone
        '
        Me.cmdSetZone.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdSetZone.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetZone.ForeColor = System.Drawing.Color.White
        Me.cmdSetZone.Image = CType(resources.GetObject("cmdSetZone.Image"), System.Drawing.Image)
        Me.cmdSetZone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSetZone.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdSetZone.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSetZone.Name = "cmdSetZone"
        Me.cmdSetZone.Size = New System.Drawing.Size(280, 52)
        Me.cmdSetZone.Text = "(F1) Set Entry Zone"
        '
        'cmdDb
        '
        Me.cmdDb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdDb.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDb.ForeColor = System.Drawing.Color.White
        Me.cmdDb.Image = CType(resources.GetObject("cmdDb.Image"), System.Drawing.Image)
        Me.cmdDb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDb.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdDb.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDb.Name = "cmdDb"
        Me.cmdDb.Size = New System.Drawing.Size(280, 52)
        Me.cmdDb.Text = "(F2) Database Settings"
        '
        'cmdBarrier
        '
        Me.cmdBarrier.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdBarrier.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBarrier.ForeColor = System.Drawing.Color.White
        Me.cmdBarrier.Image = CType(resources.GetObject("cmdBarrier.Image"), System.Drawing.Image)
        Me.cmdBarrier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBarrier.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdBarrier.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBarrier.Name = "cmdBarrier"
        Me.cmdBarrier.Size = New System.Drawing.Size(280, 52)
        Me.cmdBarrier.Text = "(F3) Trigger Settings"
        '
        'cmdDevice
        '
        Me.cmdDevice.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdDevice.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDevice.ForeColor = System.Drawing.Color.White
        Me.cmdDevice.Image = CType(resources.GetObject("cmdDevice.Image"), System.Drawing.Image)
        Me.cmdDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDevice.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdDevice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDevice.Name = "cmdDevice"
        Me.cmdDevice.Size = New System.Drawing.Size(280, 52)
        Me.cmdDevice.Text = "(F4) Device Settings"
        '
        'cmdSync
        '
        Me.cmdSync.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdSync.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSync.ForeColor = System.Drawing.Color.White
        Me.cmdSync.Image = CType(resources.GetObject("cmdSync.Image"), System.Drawing.Image)
        Me.cmdSync.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSync.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdSync.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSync.Name = "cmdSync"
        Me.cmdSync.Size = New System.Drawing.Size(280, 52)
        Me.cmdSync.Text = "(F5) Date and Time Sync"
        '
        'cmdAbout
        '
        Me.cmdAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdAbout.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAbout.ForeColor = System.Drawing.Color.White
        Me.cmdAbout.Image = CType(resources.GetObject("cmdAbout.Image"), System.Drawing.Image)
        Me.cmdAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(280, 52)
        Me.cmdAbout.Text = "(ESC) Exit Program"
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.Label9)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(297, 38)
        Me.HeaderPanel.TabIndex = 100
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
        Me.Label9.Size = New System.Drawing.Size(94, 18)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "     Settings"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(275, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(23, 25)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(297, 386)
        Me.ControlBox = False
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdSetZone As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDb As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdBarrier As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDevice As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAbout As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSync As System.Windows.Forms.ToolStripButton
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
End Class
