<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoyaltyPts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoyaltyPts))
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.txtTitle = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.txtPts = New System.Windows.Forms.NumericUpDown
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnSet = New System.Windows.Forms.Button
        Me.txtPtsDeduct = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.HeaderPanel.SuspendLayout()
        CType(Me.txtPts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPtsDeduct, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.HeaderPanel.Size = New System.Drawing.Size(312, 38)
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
        Me.txtTitle.Size = New System.Drawing.Size(180, 18)
        Me.txtTitle.TabIndex = 28
        Me.txtTitle.Text = "     Loyalty Card Points"
        Me.txtTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(291, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'txtPts
        '
        Me.txtPts.BackColor = System.Drawing.Color.White
        Me.txtPts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPts.Location = New System.Drawing.Point(180, 70)
        Me.txtPts.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.txtPts.Name = "txtPts"
        Me.txtPts.Size = New System.Drawing.Size(114, 22)
        Me.txtPts.TabIndex = 113
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(22, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 16)
        Me.Label10.TabIndex = 114
        Me.Label10.Text = "Add points per card :"
        '
        'btnSet
        '
        Me.btnSet.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSet.ForeColor = System.Drawing.Color.White
        Me.btnSet.Image = CType(resources.GetObject("btnSet.Image"), System.Drawing.Image)
        Me.btnSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSet.Location = New System.Drawing.Point(206, 154)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(87, 34)
        Me.btnSet.TabIndex = 115
        Me.btnSet.Text = "&Set"
        Me.btnSet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSet.UseVisualStyleBackColor = False
        '
        'txtPtsDeduct
        '
        Me.txtPtsDeduct.BackColor = System.Drawing.Color.White
        Me.txtPtsDeduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPtsDeduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPtsDeduct.Location = New System.Drawing.Point(180, 112)
        Me.txtPtsDeduct.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.txtPtsDeduct.Name = "txtPtsDeduct"
        Me.txtPtsDeduct.Size = New System.Drawing.Size(114, 22)
        Me.txtPtsDeduct.TabIndex = 116
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(34, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 16)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Points to buy card :"
        '
        'frmLoyaltyPts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(312, 210)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtPtsDeduct)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.txtPts)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.HeaderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoyaltyPts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        CType(Me.txtPts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPtsDeduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents txtTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents txtPts As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents txtPtsDeduct As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
