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
        Me.crtView = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crtView
        '
        Me.crtView.ActiveViewIndex = -1
        Me.crtView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crtView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crtView.Location = New System.Drawing.Point(0, 0)
        Me.crtView.Name = "crtView"
        Me.crtView.SelectionFormula = ""
        Me.crtView.Size = New System.Drawing.Size(292, 273)
        Me.crtView.TabIndex = 0
        Me.crtView.ViewTimeSelectionFormula = ""
        '
        'frmReportView
        '
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.crtView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Preview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crtPrev As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crtView As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
