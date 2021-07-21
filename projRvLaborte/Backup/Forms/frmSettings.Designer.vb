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
        Me.btnStation = New System.Windows.Forms.Button
        Me.cmdDB = New System.Windows.Forms.Button
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.txtTitle = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.btnPoints = New System.Windows.Forms.Button
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStation
        '
        Me.btnStation.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStation.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStation.ForeColor = System.Drawing.Color.White
        Me.btnStation.Image = CType(resources.GetObject("btnStation.Image"), System.Drawing.Image)
        Me.btnStation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStation.Location = New System.Drawing.Point(8, 113)
        Me.btnStation.Name = "btnStation"
        Me.btnStation.Size = New System.Drawing.Size(293, 59)
        Me.btnStation.TabIndex = 3
        Me.btnStation.Text = " (F2) Set Station"
        Me.btnStation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStation.UseVisualStyleBackColor = False
        '
        'cmdDB
        '
        Me.cmdDB.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDB.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDB.ForeColor = System.Drawing.Color.White
        Me.cmdDB.Image = CType(resources.GetObject("cmdDB.Image"), System.Drawing.Image)
        Me.cmdDB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDB.Location = New System.Drawing.Point(8, 48)
        Me.cmdDB.Name = "cmdDB"
        Me.cmdDB.Size = New System.Drawing.Size(293, 59)
        Me.cmdDB.TabIndex = 0
        Me.cmdDB.Text = " (F1) Database Settings"
        Me.cmdDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDB.UseVisualStyleBackColor = False
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.txtTitle)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(308, 38)
        Me.HeaderPanel.TabIndex = 112
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
        Me.txtTitle.Size = New System.Drawing.Size(94, 18)
        Me.txtTitle.TabIndex = 28
        Me.txtTitle.Text = "     Settings"
        Me.txtTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(287, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'btnPoints
        '
        Me.btnPoints.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPoints.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPoints.ForeColor = System.Drawing.Color.White
        Me.btnPoints.Image = CType(resources.GetObject("btnPoints.Image"), System.Drawing.Image)
        Me.btnPoints.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPoints.Location = New System.Drawing.Point(8, 178)
        Me.btnPoints.Name = "btnPoints"
        Me.btnPoints.Size = New System.Drawing.Size(293, 59)
        Me.btnPoints.TabIndex = 113
        Me.btnPoints.Text = " (F3) Loyalty Card Points"
        Me.btnPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPoints.UseVisualStyleBackColor = False
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(308, 246)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPoints)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.btnStation)
        Me.Controls.Add(Me.cmdDB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdDB As System.Windows.Forms.Button
    Friend WithEvents btnStation As System.Windows.Forms.Button
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents txtTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents btnPoints As System.Windows.Forms.Button
End Class
