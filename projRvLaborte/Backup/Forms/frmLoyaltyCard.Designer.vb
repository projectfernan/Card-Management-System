<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoyaltyCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoyaltyCard))
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.txtTitle = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCustName = New System.Windows.Forms.RichTextBox
        Me.rbtAdd = New System.Windows.Forms.RadioButton
        Me.rbtUse = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblPts = New System.Windows.Forms.Label
        Me.PanelPts = New System.Windows.Forms.Panel
        Me.txtCardQty = New System.Windows.Forms.TextBox
        Me.btnSettle = New System.Windows.Forms.Button
        Me.lblTotalPts = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblSetPts = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnContinue = New System.Windows.Forms.Button
        Me.lblNewPts = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblOldPts = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.HeaderPanel.SuspendLayout()
        Me.PanelPts.SuspendLayout()
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
        Me.HeaderPanel.Size = New System.Drawing.Size(443, 38)
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
        Me.btnClose.Location = New System.Drawing.Point(422, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(25, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 16)
        Me.Label10.TabIndex = 115
        Me.Label10.Text = "Customer Name :"
        '
        'txtCustName
        '
        Me.txtCustName.BackColor = System.Drawing.Color.Silver
        Me.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustName.ForeColor = System.Drawing.Color.Blue
        Me.txtCustName.Location = New System.Drawing.Point(157, 80)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.ReadOnly = True
        Me.txtCustName.Size = New System.Drawing.Size(255, 35)
        Me.txtCustName.TabIndex = 116
        Me.txtCustName.TabStop = False
        Me.txtCustName.Text = ""
        '
        'rbtAdd
        '
        Me.rbtAdd.AutoSize = True
        Me.rbtAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAdd.Location = New System.Drawing.Point(158, 156)
        Me.rbtAdd.Name = "rbtAdd"
        Me.rbtAdd.Size = New System.Drawing.Size(101, 20)
        Me.rbtAdd.TabIndex = 117
        Me.rbtAdd.TabStop = True
        Me.rbtAdd.Text = "Add Points"
        Me.rbtAdd.UseVisualStyleBackColor = True
        '
        'rbtUse
        '
        Me.rbtUse.AutoSize = True
        Me.rbtUse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtUse.Location = New System.Drawing.Point(280, 156)
        Me.rbtUse.Name = "rbtUse"
        Me.rbtUse.Size = New System.Drawing.Size(101, 20)
        Me.rbtUse.TabIndex = 118
        Me.rbtUse.TabStop = True
        Me.rbtUse.Text = "Use Points"
        Me.rbtUse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(39, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Current Points :"
        '
        'lblPts
        '
        Me.lblPts.AutoSize = True
        Me.lblPts.BackColor = System.Drawing.Color.Transparent
        Me.lblPts.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPts.ForeColor = System.Drawing.Color.Green
        Me.lblPts.Location = New System.Drawing.Point(154, 120)
        Me.lblPts.Name = "lblPts"
        Me.lblPts.Size = New System.Drawing.Size(21, 24)
        Me.lblPts.TabIndex = 120
        Me.lblPts.Text = "0"
        '
        'PanelPts
        '
        Me.PanelPts.Controls.Add(Me.lblOldPts)
        Me.PanelPts.Controls.Add(Me.Label7)
        Me.PanelPts.Controls.Add(Me.lblNewPts)
        Me.PanelPts.Controls.Add(Me.Label6)
        Me.PanelPts.Controls.Add(Me.txtCardQty)
        Me.PanelPts.Controls.Add(Me.btnSettle)
        Me.PanelPts.Controls.Add(Me.lblTotalPts)
        Me.PanelPts.Controls.Add(Me.Label5)
        Me.PanelPts.Controls.Add(Me.lblSetPts)
        Me.PanelPts.Controls.Add(Me.Label3)
        Me.PanelPts.Controls.Add(Me.Label2)
        Me.PanelPts.Location = New System.Drawing.Point(6, 44)
        Me.PanelPts.Name = "PanelPts"
        Me.PanelPts.Size = New System.Drawing.Size(433, 211)
        Me.PanelPts.TabIndex = 121
        Me.PanelPts.Visible = False
        '
        'txtCardQty
        '
        Me.txtCardQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCardQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardQty.Location = New System.Drawing.Point(239, 41)
        Me.txtCardQty.MaxLength = 12
        Me.txtCardQty.Name = "txtCardQty"
        Me.txtCardQty.Size = New System.Drawing.Size(102, 26)
        Me.txtCardQty.TabIndex = 124
        '
        'btnSettle
        '
        Me.btnSettle.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSettle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSettle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettle.ForeColor = System.Drawing.Color.White
        Me.btnSettle.Image = CType(resources.GetObject("btnSettle.Image"), System.Drawing.Image)
        Me.btnSettle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettle.Location = New System.Drawing.Point(161, 162)
        Me.btnSettle.Name = "btnSettle"
        Me.btnSettle.Size = New System.Drawing.Size(100, 34)
        Me.btnSettle.TabIndex = 123
        Me.btnSettle.Text = "&Settle"
        Me.btnSettle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSettle.UseVisualStyleBackColor = False
        '
        'lblTotalPts
        '
        Me.lblTotalPts.AutoSize = True
        Me.lblTotalPts.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalPts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPts.ForeColor = System.Drawing.Color.Blue
        Me.lblTotalPts.Location = New System.Drawing.Point(236, 75)
        Me.lblTotalPts.Name = "lblTotalPts"
        Me.lblTotalPts.Size = New System.Drawing.Size(97, 16)
        Me.lblTotalPts.TabIndex = 120
        Me.lblTotalPts.Text = "0 will deduct."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(152, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "Total Pts :"
        '
        'lblSetPts
        '
        Me.lblSetPts.AutoSize = True
        Me.lblSetPts.BackColor = System.Drawing.Color.Transparent
        Me.lblSetPts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetPts.ForeColor = System.Drawing.Color.Green
        Me.lblSetPts.Location = New System.Drawing.Point(236, 18)
        Me.lblSetPts.Name = "lblSetPts"
        Me.lblSetPts.Size = New System.Drawing.Size(16, 16)
        Me.lblSetPts.TabIndex = 118
        Me.lblSetPts.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(106, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 16)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "Points Per Card :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(91, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 16)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "Access Cards Qty :"
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnContinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.ForeColor = System.Drawing.Color.White
        Me.btnContinue.Image = CType(resources.GetObject("btnContinue.Image"), System.Drawing.Image)
        Me.btnContinue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContinue.Location = New System.Drawing.Point(178, 190)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(100, 34)
        Me.btnContinue.TabIndex = 122
        Me.btnContinue.Text = "&Continue"
        Me.btnContinue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'lblNewPts
        '
        Me.lblNewPts.AutoSize = True
        Me.lblNewPts.BackColor = System.Drawing.Color.Transparent
        Me.lblNewPts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPts.ForeColor = System.Drawing.Color.Teal
        Me.lblNewPts.Location = New System.Drawing.Point(236, 131)
        Me.lblNewPts.Name = "lblNewPts"
        Me.lblNewPts.Size = New System.Drawing.Size(16, 16)
        Me.lblNewPts.TabIndex = 126
        Me.lblNewPts.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(158, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "New Pts :"
        '
        'lblOldPts
        '
        Me.lblOldPts.AutoSize = True
        Me.lblOldPts.BackColor = System.Drawing.Color.Transparent
        Me.lblOldPts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldPts.ForeColor = System.Drawing.Color.Maroon
        Me.lblOldPts.Location = New System.Drawing.Point(236, 103)
        Me.lblOldPts.Name = "lblOldPts"
        Me.lblOldPts.Size = New System.Drawing.Size(16, 16)
        Me.lblOldPts.TabIndex = 128
        Me.lblOldPts.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(164, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Old Pts :"
        '
        'frmLoyaltyCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(443, 259)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelPts)
        Me.Controls.Add(Me.lblPts)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbtUse)
        Me.Controls.Add(Me.rbtAdd)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.btnContinue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoyaltyCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.PanelPts.ResumeLayout(False)
        Me.PanelPts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents txtTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCustName As System.Windows.Forms.RichTextBox
    Friend WithEvents rbtAdd As System.Windows.Forms.RadioButton
    Friend WithEvents rbtUse As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPts As System.Windows.Forms.Label
    Friend WithEvents PanelPts As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSetPts As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPts As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents btnSettle As System.Windows.Forms.Button
    Friend WithEvents txtCardQty As System.Windows.Forms.TextBox
    Friend WithEvents lblNewPts As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblOldPts As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
