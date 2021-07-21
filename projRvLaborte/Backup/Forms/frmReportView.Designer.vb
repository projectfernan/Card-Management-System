<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportView))
        Me.crtPrev = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crtPrev
        '
        Me.crtPrev.ActiveViewIndex = -1
        Me.crtPrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crtPrev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crtPrev.Location = New System.Drawing.Point(0, 0)
        Me.crtPrev.Name = "crtPrev"
        Me.crtPrev.SelectionFormula = ""
        Me.crtPrev.Size = New System.Drawing.Size(1102, 519)
        Me.crtPrev.TabIndex = 0
        Me.crtPrev.ViewTimeSelectionFormula = ""
        '
        'frmReportView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 519)
        Me.Controls.Add(Me.crtPrev)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Report Preview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crtPrev As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
