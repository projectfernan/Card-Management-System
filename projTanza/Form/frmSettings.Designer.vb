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
        Me.cmdBarrier = New System.Windows.Forms.Button
        Me.cmdPrinter = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdDB = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmdBarrier)
        Me.Panel1.Controls.Add(Me.cmdPrinter)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.cmdDB)
        Me.Panel1.Location = New System.Drawing.Point(9, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(309, 338)
        Me.Panel1.TabIndex = 1
        '
        'cmdBarrier
        '
        Me.cmdBarrier.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdBarrier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBarrier.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBarrier.Image = CType(resources.GetObject("cmdBarrier.Image"), System.Drawing.Image)
        Me.cmdBarrier.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdBarrier.Location = New System.Drawing.Point(8, 74)
        Me.cmdBarrier.Name = "cmdBarrier"
        Me.cmdBarrier.Size = New System.Drawing.Size(293, 59)
        Me.cmdBarrier.TabIndex = 7
        Me.cmdBarrier.Text = " (F3) Trigger Settings"
        Me.cmdBarrier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBarrier.UseVisualStyleBackColor = False
        '
        'cmdPrinter
        '
        Me.cmdPrinter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrinter.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrinter.Image = CType(resources.GetObject("cmdPrinter.Image"), System.Drawing.Image)
        Me.cmdPrinter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPrinter.Location = New System.Drawing.Point(8, 204)
        Me.cmdPrinter.Name = "cmdPrinter"
        Me.cmdPrinter.Size = New System.Drawing.Size(293, 59)
        Me.cmdPrinter.TabIndex = 6
        Me.cmdPrinter.Text = " (F6) Printer"
        Me.cmdPrinter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrinter.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(8, 269)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(293, 59)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = " (F7) Set System Logo"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(8, 139)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(293, 59)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = " (F5) Set Station"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmdDB
        '
        Me.cmdDB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDB.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDB.Image = CType(resources.GetObject("cmdDB.Image"), System.Drawing.Image)
        Me.cmdDB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDB.Location = New System.Drawing.Point(8, 9)
        Me.cmdDB.Name = "cmdDB"
        Me.cmdDB.Size = New System.Drawing.Size(293, 59)
        Me.cmdDB.TabIndex = 0
        Me.cmdDB.Text = " (F1) Database Settings"
        Me.cmdDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDB.UseVisualStyleBackColor = False
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(327, 358)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Settings"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdDB As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmdPrinter As System.Windows.Forms.Button
    Friend WithEvents cmdBarrier As System.Windows.Forms.Button
End Class
