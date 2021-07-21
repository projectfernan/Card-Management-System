<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSyncDate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSyncDate))
        Me.cmdLocDt = New System.Windows.Forms.Button
        Me.txtLocalDt = New System.Windows.Forms.TextBox
        Me.cmdSvDt = New System.Windows.Forms.Button
        Me.cmdTest1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtServerDt = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdLocDt
        '
        Me.cmdLocDt.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdLocDt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLocDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLocDt.ForeColor = System.Drawing.Color.White
        Me.cmdLocDt.Image = CType(resources.GetObject("cmdLocDt.Image"), System.Drawing.Image)
        Me.cmdLocDt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLocDt.Location = New System.Drawing.Point(396, 99)
        Me.cmdLocDt.Name = "cmdLocDt"
        Me.cmdLocDt.Size = New System.Drawing.Size(34, 34)
        Me.cmdLocDt.TabIndex = 1
        Me.cmdLocDt.UseVisualStyleBackColor = False
        '
        'txtLocalDt
        '
        Me.txtLocalDt.BackColor = System.Drawing.Color.White
        Me.txtLocalDt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocalDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalDt.Location = New System.Drawing.Point(135, 104)
        Me.txtLocalDt.Name = "txtLocalDt"
        Me.txtLocalDt.ReadOnly = True
        Me.txtLocalDt.Size = New System.Drawing.Size(241, 24)
        Me.txtLocalDt.TabIndex = 200
        Me.txtLocalDt.Text = "yyyy-MM-dd HH:hh:ss"
        Me.txtLocalDt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdSvDt
        '
        Me.cmdSvDt.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdSvDt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSvDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSvDt.ForeColor = System.Drawing.Color.White
        Me.cmdSvDt.Image = CType(resources.GetObject("cmdSvDt.Image"), System.Drawing.Image)
        Me.cmdSvDt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSvDt.Location = New System.Drawing.Point(396, 57)
        Me.cmdSvDt.Name = "cmdSvDt"
        Me.cmdSvDt.Size = New System.Drawing.Size(34, 34)
        Me.cmdSvDt.TabIndex = 0
        Me.cmdSvDt.UseVisualStyleBackColor = False
        '
        'cmdTest1
        '
        Me.cmdTest1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdTest1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTest1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTest1.ForeColor = System.Drawing.Color.White
        Me.cmdTest1.Image = CType(resources.GetObject("cmdTest1.Image"), System.Drawing.Image)
        Me.cmdTest1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTest1.Location = New System.Drawing.Point(176, 143)
        Me.cmdTest1.Name = "cmdTest1"
        Me.cmdTest1.Size = New System.Drawing.Size(132, 34)
        Me.cmdTest1.TabIndex = 2
        Me.cmdTest1.Text = "       Synchronize"
        Me.cmdTest1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Local Time :"
        '
        'txtServerDt
        '
        Me.txtServerDt.BackColor = System.Drawing.Color.White
        Me.txtServerDt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtServerDt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServerDt.Location = New System.Drawing.Point(135, 64)
        Me.txtServerDt.Name = "txtServerDt"
        Me.txtServerDt.ReadOnly = True
        Me.txtServerDt.Size = New System.Drawing.Size(241, 24)
        Me.txtServerDt.TabIndex = 100
        Me.txtServerDt.Text = "yyyy-MM-dd HH:hh:ss"
        Me.txtServerDt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(23, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Server Time :"
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.Label9)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(459, 38)
        Me.HeaderPanel.TabIndex = 201
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
        Me.Label9.Size = New System.Drawing.Size(196, 18)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "     Time Synchronization"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(437, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'frmSyncDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(459, 198)
        Me.ControlBox = False
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.cmdLocDt)
        Me.Controls.Add(Me.txtLocalDt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdSvDt)
        Me.Controls.Add(Me.txtServerDt)
        Me.Controls.Add(Me.cmdTest1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSyncDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdLocDt As System.Windows.Forms.Button
    Friend WithEvents txtLocalDt As System.Windows.Forms.TextBox
    Friend WithEvents cmdSvDt As System.Windows.Forms.Button
    Friend WithEvents cmdTest1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtServerDt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
End Class
