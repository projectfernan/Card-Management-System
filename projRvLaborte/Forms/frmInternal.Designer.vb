<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInternal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInternal))
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.txtTitle = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.chkLcOW = New System.Windows.Forms.CheckBox
        Me.txtTrId = New System.Windows.Forms.NumericUpDown
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnSettle = New System.Windows.Forms.Button
        Me.HeaderPanel.SuspendLayout()
        CType(Me.txtTrId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.txtTitle)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(309, 38)
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
        Me.txtTitle.Size = New System.Drawing.Size(154, 18)
        Me.txtTitle.TabIndex = 28
        Me.txtTitle.Text = "     Internal Settings"
        Me.txtTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(288, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'chkLcOW
        '
        Me.chkLcOW.AutoSize = True
        Me.chkLcOW.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLcOW.Location = New System.Drawing.Point(37, 106)
        Me.chkLcOW.Name = "chkLcOW"
        Me.chkLcOW.Size = New System.Drawing.Size(243, 22)
        Me.chkLcOW.TabIndex = 113
        Me.chkLcOW.Text = "Allow Loyalty Card Overwrite"
        Me.chkLcOW.UseVisualStyleBackColor = True
        '
        'txtTrId
        '
        Me.txtTrId.BackColor = System.Drawing.Color.White
        Me.txtTrId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTrId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrId.Location = New System.Drawing.Point(88, 67)
        Me.txtTrId.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.txtTrId.Name = "txtTrId"
        Me.txtTrId.Size = New System.Drawing.Size(188, 22)
        Me.txtTrId.TabIndex = 114
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(34, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "Tr Id :"
        '
        'btnSettle
        '
        Me.btnSettle.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSettle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSettle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettle.ForeColor = System.Drawing.Color.White
        Me.btnSettle.Image = CType(resources.GetObject("btnSettle.Image"), System.Drawing.Image)
        Me.btnSettle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettle.Location = New System.Drawing.Point(203, 139)
        Me.btnSettle.Name = "btnSettle"
        Me.btnSettle.Size = New System.Drawing.Size(73, 34)
        Me.btnSettle.TabIndex = 124
        Me.btnSettle.Text = "&Set"
        Me.btnSettle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSettle.UseVisualStyleBackColor = False
        '
        'frmInternal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(309, 200)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSettle)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTrId)
        Me.Controls.Add(Me.chkLcOW)
        Me.Controls.Add(Me.HeaderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInternal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        CType(Me.txtTrId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents txtTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents chkLcOW As System.Windows.Forms.CheckBox
    Friend WithEvents txtTrId As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSettle As System.Windows.Forms.Button
End Class
