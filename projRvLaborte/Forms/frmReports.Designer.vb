<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReports))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.cboOrder1 = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboStation = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboCashier = New System.Windows.Forms.ComboBox
        Me.cmdFind1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtTo = New System.Windows.Forms.DateTimePicker
        Me.dtFrm = New System.Windows.Forms.DateTimePicker
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboCashier2 = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboStation2 = New System.Windows.Forms.ComboBox
        Me.cmdFind2 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtTo2 = New System.Windows.Forms.DateTimePicker
        Me.dtFrm2 = New System.Windows.Forms.DateTimePicker
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.cboOrder2 = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboCashier3 = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cboStation3 = New System.Windows.Forms.ComboBox
        Me.cmdFind3 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtTo3 = New System.Windows.Forms.DateTimePicker
        Me.dtFrm3 = New System.Windows.Forms.DateTimePicker
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.txtTitle = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.crtPrev = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lbLoad = New System.Windows.Forms.ToolStripProgressBar
        Me.txtLoadMsg = New System.Windows.Forms.ToolStripStatusLabel
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(9, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1064, 128)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Silver
        Me.TabPage1.Controls.Add(Me.cboOrder1)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.cboStation)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.cboCashier)
        Me.TabPage1.Controls.Add(Me.cmdFind1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.dtTo)
        Me.TabPage1.Controls.Add(Me.dtFrm)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1056, 99)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detailed Transaction Report"
        '
        'cboOrder1
        '
        Me.cboOrder1.FormattingEnabled = True
        Me.cboOrder1.Items.AddRange(New Object() {"Desc", "Asc"})
        Me.cboOrder1.Location = New System.Drawing.Point(540, 54)
        Me.cboOrder1.Name = "cboOrder1"
        Me.cboOrder1.Size = New System.Drawing.Size(67, 24)
        Me.cboOrder1.TabIndex = 46
        Me.cboOrder1.Text = "Desc"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(332, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Station :"
        '
        'cboStation
        '
        Me.cboStation.FormattingEnabled = True
        Me.cboStation.Location = New System.Drawing.Point(402, 54)
        Me.cboStation.Name = "cboStation"
        Me.cboStation.Size = New System.Drawing.Size(132, 24)
        Me.cboStation.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(327, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 16)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Cashier :"
        '
        'cboCashier
        '
        Me.cboCashier.FormattingEnabled = True
        Me.cboCashier.Location = New System.Drawing.Point(402, 19)
        Me.cboCashier.Name = "cboCashier"
        Me.cboCashier.Size = New System.Drawing.Size(205, 24)
        Me.cboCashier.TabIndex = 42
        '
        'cmdFind1
        '
        Me.cmdFind1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdFind1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFind1.ForeColor = System.Drawing.Color.White
        Me.cmdFind1.Image = CType(resources.GetObject("cmdFind1.Image"), System.Drawing.Image)
        Me.cmdFind1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind1.Location = New System.Drawing.Point(628, 17)
        Me.cmdFind1.Name = "cmdFind1"
        Me.cmdFind1.Size = New System.Drawing.Size(74, 61)
        Me.cmdFind1.TabIndex = 22
        Me.cmdFind1.Text = "Preview"
        Me.cmdFind1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdFind1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(33, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Date To :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Date From :"
        '
        'dtTo
        '
        Me.dtTo.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo.Location = New System.Drawing.Point(111, 55)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(200, 24)
        Me.dtTo.TabIndex = 19
        '
        'dtFrm
        '
        Me.dtFrm.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtFrm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFrm.Location = New System.Drawing.Point(111, 18)
        Me.dtFrm.Name = "dtFrm"
        Me.dtFrm.Size = New System.Drawing.Size(200, 24)
        Me.dtFrm.TabIndex = 18
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.cboCashier2)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.cboStation2)
        Me.TabPage2.Controls.Add(Me.cmdFind2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.dtTo2)
        Me.TabPage2.Controls.Add(Me.dtFrm2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1056, 99)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Summary Transaction Report"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(327, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Cashier :"
        '
        'cboCashier2
        '
        Me.cboCashier2.FormattingEnabled = True
        Me.cboCashier2.Location = New System.Drawing.Point(402, 19)
        Me.cboCashier2.Name = "cboCashier2"
        Me.cboCashier2.Size = New System.Drawing.Size(205, 24)
        Me.cboCashier2.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(332, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Station :"
        '
        'cboStation2
        '
        Me.cboStation2.FormattingEnabled = True
        Me.cboStation2.Location = New System.Drawing.Point(402, 54)
        Me.cboStation2.Name = "cboStation2"
        Me.cboStation2.Size = New System.Drawing.Size(205, 24)
        Me.cboStation2.TabIndex = 40
        '
        'cmdFind2
        '
        Me.cmdFind2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdFind2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFind2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind2.ForeColor = System.Drawing.Color.White
        Me.cmdFind2.Image = CType(resources.GetObject("cmdFind2.Image"), System.Drawing.Image)
        Me.cmdFind2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind2.Location = New System.Drawing.Point(628, 17)
        Me.cmdFind2.Name = "cmdFind2"
        Me.cmdFind2.Size = New System.Drawing.Size(74, 61)
        Me.cmdFind2.TabIndex = 36
        Me.cmdFind2.Text = "Preview"
        Me.cmdFind2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdFind2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(33, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Date To :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(17, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Date From :"
        '
        'dtTo2
        '
        Me.dtTo2.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtTo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo2.Location = New System.Drawing.Point(111, 55)
        Me.dtTo2.Name = "dtTo2"
        Me.dtTo2.Size = New System.Drawing.Size(200, 24)
        Me.dtTo2.TabIndex = 33
        '
        'dtFrm2
        '
        Me.dtFrm2.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtFrm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrm2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFrm2.Location = New System.Drawing.Point(111, 18)
        Me.dtFrm2.Name = "dtFrm2"
        Me.dtFrm2.Size = New System.Drawing.Size(200, 24)
        Me.dtFrm2.TabIndex = 32
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Silver
        Me.TabPage3.Controls.Add(Me.cboOrder2)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.cboCashier3)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.cboStation3)
        Me.TabPage3.Controls.Add(Me.cmdFind3)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.dtTo3)
        Me.TabPage3.Controls.Add(Me.dtFrm3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1056, 99)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Loyalty Card Points Report"
        '
        'cboOrder2
        '
        Me.cboOrder2.FormattingEnabled = True
        Me.cboOrder2.Items.AddRange(New Object() {"Desc", "Asc"})
        Me.cboOrder2.Location = New System.Drawing.Point(540, 54)
        Me.cboOrder2.Name = "cboOrder2"
        Me.cboOrder2.Size = New System.Drawing.Size(67, 24)
        Me.cboOrder2.TabIndex = 50
        Me.cboOrder2.Text = "Desc"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(327, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 16)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Cashier :"
        '
        'cboCashier3
        '
        Me.cboCashier3.FormattingEnabled = True
        Me.cboCashier3.Location = New System.Drawing.Point(402, 19)
        Me.cboCashier3.Name = "cboCashier3"
        Me.cboCashier3.Size = New System.Drawing.Size(205, 24)
        Me.cboCashier3.TabIndex = 48
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(332, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 16)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Station :"
        '
        'cboStation3
        '
        Me.cboStation3.FormattingEnabled = True
        Me.cboStation3.Location = New System.Drawing.Point(402, 54)
        Me.cboStation3.Name = "cboStation3"
        Me.cboStation3.Size = New System.Drawing.Size(132, 24)
        Me.cboStation3.TabIndex = 46
        '
        'cmdFind3
        '
        Me.cmdFind3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdFind3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFind3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind3.ForeColor = System.Drawing.Color.White
        Me.cmdFind3.Image = CType(resources.GetObject("cmdFind3.Image"), System.Drawing.Image)
        Me.cmdFind3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind3.Location = New System.Drawing.Point(628, 17)
        Me.cmdFind3.Name = "cmdFind3"
        Me.cmdFind3.Size = New System.Drawing.Size(74, 61)
        Me.cmdFind3.TabIndex = 36
        Me.cmdFind3.Text = "Preview"
        Me.cmdFind3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdFind3.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(33, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Date To :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(17, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Date From :"
        '
        'dtTo3
        '
        Me.dtTo3.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtTo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo3.Location = New System.Drawing.Point(111, 55)
        Me.dtTo3.Name = "dtTo3"
        Me.dtTo3.Size = New System.Drawing.Size(200, 24)
        Me.dtTo3.TabIndex = 33
        '
        'dtFrm3
        '
        Me.dtFrm3.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtFrm3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrm3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFrm3.Location = New System.Drawing.Point(111, 18)
        Me.dtFrm3.Name = "dtFrm3"
        Me.dtFrm3.Size = New System.Drawing.Size(200, 24)
        Me.dtFrm3.TabIndex = 32
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.txtTitle)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(1085, 38)
        Me.HeaderPanel.TabIndex = 111
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
        Me.txtTitle.Size = New System.Drawing.Size(93, 18)
        Me.txtTitle.TabIndex = 28
        Me.txtTitle.Text = "     Reports"
        Me.txtTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1064, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.crtPrev)
        Me.Panel1.Controls.Add(Me.StatusStrip1)
        Me.Panel1.Location = New System.Drawing.Point(10, 188)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1063, 438)
        Me.Panel1.TabIndex = 112
        '
        'crtPrev
        '
        Me.crtPrev.ActiveViewIndex = -1
        Me.crtPrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crtPrev.DisplayGroupTree = False
        Me.crtPrev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crtPrev.Location = New System.Drawing.Point(0, 0)
        Me.crtPrev.Name = "crtPrev"
        Me.crtPrev.SelectionFormula = ""
        Me.crtPrev.Size = New System.Drawing.Size(1061, 411)
        Me.crtPrev.TabIndex = 1
        Me.crtPrev.ViewTimeSelectionFormula = ""
        Me.crtPrev.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbLoad, Me.txtLoadMsg})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 411)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1061, 25)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbLoad
        '
        Me.lbLoad.Name = "lbLoad"
        Me.lbLoad.Size = New System.Drawing.Size(100, 19)
        '
        'txtLoadMsg
        '
        Me.txtLoadMsg.BackColor = System.Drawing.Color.Transparent
        Me.txtLoadMsg.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoadMsg.ForeColor = System.Drawing.Color.Blue
        Me.txtLoadMsg.Name = "txtLoadMsg"
        Me.txtLoadMsg.Size = New System.Drawing.Size(27, 20)
        Me.txtLoadMsg.Text = "---"
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1085, 640)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFrm As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdFind1 As System.Windows.Forms.Button
    Friend WithEvents cmdFind2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtTo2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFrm2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdFind3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtTo3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFrm3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents txtTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents crtPrev As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbLoad As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents txtLoadMsg As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboStation2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboStation As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboCashier As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboCashier2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboCashier3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboStation3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboOrder1 As System.Windows.Forms.ComboBox
    Friend WithEvents cboOrder2 As System.Windows.Forms.ComboBox
End Class
