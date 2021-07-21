<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSystem))
        Me.cmdReports = New System.Windows.Forms.Button
        Me.cmdEvent = New System.Windows.Forms.Button
        Me.cmdTerminate = New System.Windows.Forms.Button
        Me.cmdAbout = New System.Windows.Forms.Button
        Me.cmdCharging = New System.Windows.Forms.Button
        Me.cmdAccounts = New System.Windows.Forms.Button
        Me.cmdSettings = New System.Windows.Forms.Button
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.txtTitle = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.btnLc = New System.Windows.Forms.Button
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdReports
        '
        Me.cmdReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReports.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReports.ForeColor = System.Drawing.Color.White
        Me.cmdReports.Image = CType(resources.GetObject("cmdReports.Image"), System.Drawing.Image)
        Me.cmdReports.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdReports.Location = New System.Drawing.Point(7, 370)
        Me.cmdReports.Name = "cmdReports"
        Me.cmdReports.Size = New System.Drawing.Size(293, 59)
        Me.cmdReports.TabIndex = 5
        Me.cmdReports.Text = " (F6) Reports"
        Me.cmdReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdReports.UseVisualStyleBackColor = False
        '
        'cmdEvent
        '
        Me.cmdEvent.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEvent.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEvent.ForeColor = System.Drawing.Color.White
        Me.cmdEvent.Image = CType(resources.GetObject("cmdEvent.Image"), System.Drawing.Image)
        Me.cmdEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdEvent.Location = New System.Drawing.Point(7, 175)
        Me.cmdEvent.Name = "cmdEvent"
        Me.cmdEvent.Size = New System.Drawing.Size(293, 59)
        Me.cmdEvent.TabIndex = 3
        Me.cmdEvent.Text = " (F3) Events Schedule"
        Me.cmdEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEvent.UseVisualStyleBackColor = False
        '
        'cmdTerminate
        '
        Me.cmdTerminate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdTerminate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTerminate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTerminate.ForeColor = System.Drawing.Color.White
        Me.cmdTerminate.Image = CType(resources.GetObject("cmdTerminate.Image"), System.Drawing.Image)
        Me.cmdTerminate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdTerminate.Location = New System.Drawing.Point(7, 500)
        Me.cmdTerminate.Name = "cmdTerminate"
        Me.cmdTerminate.Size = New System.Drawing.Size(293, 59)
        Me.cmdTerminate.TabIndex = 7
        Me.cmdTerminate.Text = " (Esc) System Terminate"
        Me.cmdTerminate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTerminate.UseVisualStyleBackColor = False
        '
        'cmdAbout
        '
        Me.cmdAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAbout.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAbout.ForeColor = System.Drawing.Color.White
        Me.cmdAbout.Image = CType(resources.GetObject("cmdAbout.Image"), System.Drawing.Image)
        Me.cmdAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAbout.Location = New System.Drawing.Point(7, 435)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(293, 59)
        Me.cmdAbout.TabIndex = 6
        Me.cmdAbout.Text = " (F7) About"
        Me.cmdAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAbout.UseVisualStyleBackColor = False
        '
        'cmdCharging
        '
        Me.cmdCharging.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdCharging.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCharging.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCharging.ForeColor = System.Drawing.Color.White
        Me.cmdCharging.Image = CType(resources.GetObject("cmdCharging.Image"), System.Drawing.Image)
        Me.cmdCharging.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCharging.Location = New System.Drawing.Point(7, 240)
        Me.cmdCharging.Name = "cmdCharging"
        Me.cmdCharging.Size = New System.Drawing.Size(293, 59)
        Me.cmdCharging.TabIndex = 4
        Me.cmdCharging.Text = " (F4) Transaction Type"
        Me.cmdCharging.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCharging.UseVisualStyleBackColor = False
        '
        'cmdAccounts
        '
        Me.cmdAccounts.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAccounts.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAccounts.ForeColor = System.Drawing.Color.White
        Me.cmdAccounts.Image = CType(resources.GetObject("cmdAccounts.Image"), System.Drawing.Image)
        Me.cmdAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAccounts.Location = New System.Drawing.Point(7, 111)
        Me.cmdAccounts.Name = "cmdAccounts"
        Me.cmdAccounts.Size = New System.Drawing.Size(293, 59)
        Me.cmdAccounts.TabIndex = 2
        Me.cmdAccounts.Text = " (F2) System Accounts"
        Me.cmdAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAccounts.UseVisualStyleBackColor = False
        '
        'cmdSettings
        '
        Me.cmdSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSettings.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSettings.ForeColor = System.Drawing.Color.White
        Me.cmdSettings.Image = CType(resources.GetObject("cmdSettings.Image"), System.Drawing.Image)
        Me.cmdSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSettings.Location = New System.Drawing.Point(7, 46)
        Me.cmdSettings.Name = "cmdSettings"
        Me.cmdSettings.Size = New System.Drawing.Size(293, 59)
        Me.cmdSettings.TabIndex = 1
        Me.cmdSettings.Text = " (F1) Settings"
        Me.cmdSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSettings.UseVisualStyleBackColor = False
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.txtTitle)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(307, 38)
        Me.HeaderPanel.TabIndex = 113
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
        Me.txtTitle.Size = New System.Drawing.Size(89, 18)
        Me.txtTitle.TabIndex = 28
        Me.txtTitle.Text = "     System"
        Me.txtTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(286, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'btnLc
        '
        Me.btnLc.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLc.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLc.ForeColor = System.Drawing.Color.White
        Me.btnLc.Image = CType(resources.GetObject("btnLc.Image"), System.Drawing.Image)
        Me.btnLc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLc.Location = New System.Drawing.Point(7, 305)
        Me.btnLc.Name = "btnLc"
        Me.btnLc.Size = New System.Drawing.Size(293, 59)
        Me.btnLc.TabIndex = 114
        Me.btnLc.Text = " (F5) Loyalty Cards"
        Me.btnLc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLc.UseVisualStyleBackColor = False
        '
        'frmSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(307, 568)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLc)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.cmdReports)
        Me.Controls.Add(Me.cmdEvent)
        Me.Controls.Add(Me.cmdSettings)
        Me.Controls.Add(Me.cmdTerminate)
        Me.Controls.Add(Me.cmdAccounts)
        Me.Controls.Add(Me.cmdAbout)
        Me.Controls.Add(Me.cmdCharging)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSystem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSettings As System.Windows.Forms.Button
    Friend WithEvents cmdAccounts As System.Windows.Forms.Button
    Friend WithEvents cmdAbout As System.Windows.Forms.Button
    Friend WithEvents cmdCharging As System.Windows.Forms.Button
    Friend WithEvents cmdTerminate As System.Windows.Forms.Button
    Friend WithEvents cmdEvent As System.Windows.Forms.Button
    Friend WithEvents cmdReports As System.Windows.Forms.Button
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents txtTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents btnLc As System.Windows.Forms.Button
End Class
