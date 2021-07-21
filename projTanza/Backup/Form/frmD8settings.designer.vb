<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmD8settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmD8settings))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdDetect = New System.Windows.Forms.Button
        Me.cmdInit = New System.Windows.Forms.Button
        Me.cmdBeep = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.cmdDetect)
        Me.Panel1.Controls.Add(Me.cmdInit)
        Me.Panel1.Controls.Add(Me.cmdBeep)
        Me.Panel1.Location = New System.Drawing.Point(9, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(177, 217)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(15, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 34)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "      Get Card Code"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmdDetect
        '
        Me.cmdDetect.BackColor = System.Drawing.Color.White
        Me.cmdDetect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDetect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDetect.Image = CType(resources.GetObject("cmdDetect.Image"), System.Drawing.Image)
        Me.cmdDetect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDetect.Location = New System.Drawing.Point(15, 112)
        Me.cmdDetect.Name = "cmdDetect"
        Me.cmdDetect.Size = New System.Drawing.Size(147, 34)
        Me.cmdDetect.TabIndex = 25
        Me.cmdDetect.Text = "      Detect Card"
        Me.cmdDetect.UseVisualStyleBackColor = False
        '
        'cmdInit
        '
        Me.cmdInit.BackColor = System.Drawing.Color.White
        Me.cmdInit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdInit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInit.Image = CType(resources.GetObject("cmdInit.Image"), System.Drawing.Image)
        Me.cmdInit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdInit.Location = New System.Drawing.Point(15, 15)
        Me.cmdInit.Name = "cmdInit"
        Me.cmdInit.Size = New System.Drawing.Size(147, 34)
        Me.cmdInit.TabIndex = 23
        Me.cmdInit.Text = "      Initialize"
        Me.cmdInit.UseVisualStyleBackColor = False
        '
        'cmdBeep
        '
        Me.cmdBeep.BackColor = System.Drawing.Color.White
        Me.cmdBeep.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBeep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBeep.Image = CType(resources.GetObject("cmdBeep.Image"), System.Drawing.Image)
        Me.cmdBeep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBeep.Location = New System.Drawing.Point(15, 63)
        Me.cmdBeep.Name = "cmdBeep"
        Me.cmdBeep.Size = New System.Drawing.Size(147, 34)
        Me.cmdBeep.TabIndex = 24
        Me.cmdBeep.Text = "       Test Beep"
        Me.cmdBeep.UseVisualStyleBackColor = False
        '
        'frmD8settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(194, 233)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmD8settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " D8U Settings"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdDetect As System.Windows.Forms.Button
    Friend WithEvents cmdBeep As System.Windows.Forms.Button
    Friend WithEvents cmdInit As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
