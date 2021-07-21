<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportType))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdDetailed = New System.Windows.Forms.Button
        Me.cmdLogout = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmdDetailed)
        Me.Panel1.Controls.Add(Me.cmdLogout)
        Me.Panel1.Location = New System.Drawing.Point(7, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(309, 141)
        Me.Panel1.TabIndex = 2
        '
        'cmdDetailed
        '
        Me.cmdDetailed.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdDetailed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDetailed.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDetailed.Image = CType(resources.GetObject("cmdDetailed.Image"), System.Drawing.Image)
        Me.cmdDetailed.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDetailed.Location = New System.Drawing.Point(8, 74)
        Me.cmdDetailed.Name = "cmdDetailed"
        Me.cmdDetailed.Size = New System.Drawing.Size(293, 59)
        Me.cmdDetailed.TabIndex = 7
        Me.cmdDetailed.Text = " (F2) Detailed Report"
        Me.cmdDetailed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDetailed.UseVisualStyleBackColor = False
        '
        'cmdLogout
        '
        Me.cmdLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLogout.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogout.Image = CType(resources.GetObject("cmdLogout.Image"), System.Drawing.Image)
        Me.cmdLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdLogout.Location = New System.Drawing.Point(8, 9)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.Size = New System.Drawing.Size(293, 59)
        Me.cmdLogout.TabIndex = 0
        Me.cmdLogout.Text = " (F1) Logout Report"
        Me.cmdLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLogout.UseVisualStyleBackColor = False
        '
        'frmReportType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(324, 157)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReportType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Report Type"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdDetailed As System.Windows.Forms.Button
    Friend WithEvents cmdLogout As System.Windows.Forms.Button
End Class
