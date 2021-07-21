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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdReports = New System.Windows.Forms.Button
        Me.cmdEvent = New System.Windows.Forms.Button
        Me.cmdTerminate = New System.Windows.Forms.Button
        Me.cmdAbout = New System.Windows.Forms.Button
        Me.cmdCharging = New System.Windows.Forms.Button
        Me.cmdAccounts = New System.Windows.Forms.Button
        Me.cmdSettings = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmdReports)
        Me.Panel1.Controls.Add(Me.cmdEvent)
        Me.Panel1.Controls.Add(Me.cmdTerminate)
        Me.Panel1.Controls.Add(Me.cmdAbout)
        Me.Panel1.Controls.Add(Me.cmdCharging)
        Me.Panel1.Controls.Add(Me.cmdAccounts)
        Me.Panel1.Controls.Add(Me.cmdSettings)
        Me.Panel1.Location = New System.Drawing.Point(9, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(309, 466)
        Me.Panel1.TabIndex = 0
        '
        'cmdReports
        '
        Me.cmdReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReports.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReports.Image = CType(resources.GetObject("cmdReports.Image"), System.Drawing.Image)
        Me.cmdReports.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdReports.Location = New System.Drawing.Point(8, 267)
        Me.cmdReports.Name = "cmdReports"
        Me.cmdReports.Size = New System.Drawing.Size(293, 59)
        Me.cmdReports.TabIndex = 5
        Me.cmdReports.Text = " (F7) Reports"
        Me.cmdReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdReports.UseVisualStyleBackColor = False
        '
        'cmdEvent
        '
        Me.cmdEvent.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEvent.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEvent.Image = CType(resources.GetObject("cmdEvent.Image"), System.Drawing.Image)
        Me.cmdEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdEvent.Location = New System.Drawing.Point(8, 137)
        Me.cmdEvent.Name = "cmdEvent"
        Me.cmdEvent.Size = New System.Drawing.Size(293, 59)
        Me.cmdEvent.TabIndex = 3
        Me.cmdEvent.Text = " (F5) Events Schedule"
        Me.cmdEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEvent.UseVisualStyleBackColor = False
        '
        'cmdTerminate
        '
        Me.cmdTerminate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdTerminate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTerminate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTerminate.Image = CType(resources.GetObject("cmdTerminate.Image"), System.Drawing.Image)
        Me.cmdTerminate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdTerminate.Location = New System.Drawing.Point(8, 397)
        Me.cmdTerminate.Name = "cmdTerminate"
        Me.cmdTerminate.Size = New System.Drawing.Size(293, 59)
        Me.cmdTerminate.TabIndex = 7
        Me.cmdTerminate.Text = " (Esc) System Terminate"
        Me.cmdTerminate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTerminate.UseVisualStyleBackColor = False
        '
        'cmdAbout
        '
        Me.cmdAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAbout.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAbout.Image = CType(resources.GetObject("cmdAbout.Image"), System.Drawing.Image)
        Me.cmdAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAbout.Location = New System.Drawing.Point(8, 332)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(293, 59)
        Me.cmdAbout.TabIndex = 6
        Me.cmdAbout.Text = " (F8) About"
        Me.cmdAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAbout.UseVisualStyleBackColor = False
        '
        'cmdCharging
        '
        Me.cmdCharging.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdCharging.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCharging.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCharging.Image = CType(resources.GetObject("cmdCharging.Image"), System.Drawing.Image)
        Me.cmdCharging.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCharging.Location = New System.Drawing.Point(8, 202)
        Me.cmdCharging.Name = "cmdCharging"
        Me.cmdCharging.Size = New System.Drawing.Size(293, 59)
        Me.cmdCharging.TabIndex = 4
        Me.cmdCharging.Text = " (F6) Transaction Type"
        Me.cmdCharging.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCharging.UseVisualStyleBackColor = False
        '
        'cmdAccounts
        '
        Me.cmdAccounts.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAccounts.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAccounts.Image = CType(resources.GetObject("cmdAccounts.Image"), System.Drawing.Image)
        Me.cmdAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAccounts.Location = New System.Drawing.Point(8, 73)
        Me.cmdAccounts.Name = "cmdAccounts"
        Me.cmdAccounts.Size = New System.Drawing.Size(293, 59)
        Me.cmdAccounts.TabIndex = 2
        Me.cmdAccounts.Text = " (F3) System Accounts"
        Me.cmdAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAccounts.UseVisualStyleBackColor = False
        '
        'cmdSettings
        '
        Me.cmdSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSettings.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSettings.Image = CType(resources.GetObject("cmdSettings.Image"), System.Drawing.Image)
        Me.cmdSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSettings.Location = New System.Drawing.Point(8, 8)
        Me.cmdSettings.Name = "cmdSettings"
        Me.cmdSettings.Size = New System.Drawing.Size(293, 59)
        Me.cmdSettings.TabIndex = 1
        Me.cmdSettings.Text = " (F2) Settings"
        Me.cmdSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSettings.UseVisualStyleBackColor = False
        '
        'frmSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(326, 484)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSystem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " System Settings"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdSettings As System.Windows.Forms.Button
    Friend WithEvents cmdAccounts As System.Windows.Forms.Button
    Friend WithEvents cmdAbout As System.Windows.Forms.Button
    Friend WithEvents cmdCharging As System.Windows.Forms.Button
    Friend WithEvents cmdTerminate As System.Windows.Forms.Button
    Friend WithEvents cmdEvent As System.Windows.Forms.Button
    Friend WithEvents cmdReports As System.Windows.Forms.Button
End Class
