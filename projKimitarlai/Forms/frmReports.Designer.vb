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
        Me.cmdPrint1 = New System.Windows.Forms.Button
        Me.cmdFind1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtTo = New System.Windows.Forms.DateTimePicker
        Me.dtFrm = New System.Windows.Forms.DateTimePicker
        Me.lstList1 = New System.Windows.Forms.ListView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboCashier = New System.Windows.Forms.ComboBox
        Me.cmdPrint2 = New System.Windows.Forms.Button
        Me.cmdFind2 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtTo2 = New System.Windows.Forms.DateTimePicker
        Me.dtFrm2 = New System.Windows.Forms.DateTimePicker
        Me.lstList2 = New System.Windows.Forms.ListView
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.cmdPrint3 = New System.Windows.Forms.Button
        Me.cmdFind3 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtTo3 = New System.Windows.Forms.DateTimePicker
        Me.dtFrm3 = New System.Windows.Forms.DateTimePicker
        Me.lstList3 = New System.Windows.Forms.ListView
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtLoad = New System.Windows.Forms.ToolStripProgressBar
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtCnt = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtTotalCnt = New System.Windows.Forms.ToolStripStatusLabel
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1064, 547)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.cmdPrint1)
        Me.TabPage1.Controls.Add(Me.cmdFind1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.dtTo)
        Me.TabPage1.Controls.Add(Me.dtFrm)
        Me.TabPage1.Controls.Add(Me.lstList1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1056, 518)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Generate By Date"
        '
        'cmdPrint1
        '
        Me.cmdPrint1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdPrint1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPrint1.Image = CType(resources.GetObject("cmdPrint1.Image"), System.Drawing.Image)
        Me.cmdPrint1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint1.Location = New System.Drawing.Point(429, 18)
        Me.cmdPrint1.Name = "cmdPrint1"
        Me.cmdPrint1.Size = New System.Drawing.Size(74, 61)
        Me.cmdPrint1.TabIndex = 23
        Me.cmdPrint1.Text = "Print"
        Me.cmdPrint1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPrint1.UseVisualStyleBackColor = False
        '
        'cmdFind1
        '
        Me.cmdFind1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdFind1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFind1.Image = CType(resources.GetObject("cmdFind1.Image"), System.Drawing.Image)
        Me.cmdFind1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind1.Location = New System.Drawing.Point(341, 18)
        Me.cmdFind1.Name = "cmdFind1"
        Me.cmdFind1.Size = New System.Drawing.Size(74, 61)
        Me.cmdFind1.TabIndex = 22
        Me.cmdFind1.Text = "Find"
        Me.cmdFind1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdFind1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(46, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Date To :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Date From :"
        '
        'dtTo
        '
        Me.dtTo.CustomFormat = "yyyy-MM-dd 23:59:59"
        Me.dtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo.Location = New System.Drawing.Point(124, 55)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(200, 24)
        Me.dtTo.TabIndex = 19
        '
        'dtFrm
        '
        Me.dtFrm.CustomFormat = "yyyy-MM-dd 00:00:00"
        Me.dtFrm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFrm.Location = New System.Drawing.Point(124, 18)
        Me.dtFrm.Name = "dtFrm"
        Me.dtFrm.Size = New System.Drawing.Size(200, 24)
        Me.dtFrm.TabIndex = 18
        '
        'lstList1
        '
        Me.lstList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstList1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstList1.ForeColor = System.Drawing.Color.Black
        Me.lstList1.FullRowSelect = True
        Me.lstList1.GridLines = True
        Me.lstList1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstList1.Location = New System.Drawing.Point(9, 98)
        Me.lstList1.Name = "lstList1"
        Me.lstList1.Size = New System.Drawing.Size(1038, 410)
        Me.lstList1.TabIndex = 17
        Me.lstList1.UseCompatibleStateImageBehavior = False
        Me.lstList1.View = System.Windows.Forms.View.Details
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.cboCashier)
        Me.TabPage2.Controls.Add(Me.cmdPrint2)
        Me.TabPage2.Controls.Add(Me.cmdFind2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.dtTo2)
        Me.TabPage2.Controls.Add(Me.dtFrm2)
        Me.TabPage2.Controls.Add(Me.lstList2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1056, 518)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Generate By Cashier"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(325, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Cashier :"
        '
        'cboCashier
        '
        Me.cboCashier.FormattingEnabled = True
        Me.cboCashier.Location = New System.Drawing.Point(328, 41)
        Me.cboCashier.Name = "cboCashier"
        Me.cboCashier.Size = New System.Drawing.Size(205, 24)
        Me.cboCashier.TabIndex = 38
        '
        'cmdPrint2
        '
        Me.cmdPrint2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdPrint2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPrint2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint2.Image = CType(resources.GetObject("cmdPrint2.Image"), System.Drawing.Image)
        Me.cmdPrint2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint2.Location = New System.Drawing.Point(627, 21)
        Me.cmdPrint2.Name = "cmdPrint2"
        Me.cmdPrint2.Size = New System.Drawing.Size(74, 61)
        Me.cmdPrint2.TabIndex = 37
        Me.cmdPrint2.Text = "Print"
        Me.cmdPrint2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPrint2.UseVisualStyleBackColor = False
        '
        'cmdFind2
        '
        Me.cmdFind2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdFind2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFind2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind2.Image = CType(resources.GetObject("cmdFind2.Image"), System.Drawing.Image)
        Me.cmdFind2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind2.Location = New System.Drawing.Point(547, 21)
        Me.cmdFind2.Name = "cmdFind2"
        Me.cmdFind2.Size = New System.Drawing.Size(74, 61)
        Me.cmdFind2.TabIndex = 36
        Me.cmdFind2.Text = "Find"
        Me.cmdFind2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdFind2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Date To :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(15, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Date From :"
        '
        'dtTo2
        '
        Me.dtTo2.CustomFormat = "yyyy-MM-dd 23:59:59"
        Me.dtTo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo2.Location = New System.Drawing.Point(109, 55)
        Me.dtTo2.Name = "dtTo2"
        Me.dtTo2.Size = New System.Drawing.Size(200, 24)
        Me.dtTo2.TabIndex = 33
        '
        'dtFrm2
        '
        Me.dtFrm2.CustomFormat = "yyyy-MM-dd 00:00:00"
        Me.dtFrm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrm2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFrm2.Location = New System.Drawing.Point(109, 18)
        Me.dtFrm2.Name = "dtFrm2"
        Me.dtFrm2.Size = New System.Drawing.Size(200, 24)
        Me.dtFrm2.TabIndex = 32
        '
        'lstList2
        '
        Me.lstList2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstList2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstList2.ForeColor = System.Drawing.Color.Black
        Me.lstList2.FullRowSelect = True
        Me.lstList2.GridLines = True
        Me.lstList2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstList2.Location = New System.Drawing.Point(9, 98)
        Me.lstList2.Name = "lstList2"
        Me.lstList2.Size = New System.Drawing.Size(1038, 410)
        Me.lstList2.TabIndex = 31
        Me.lstList2.UseCompatibleStateImageBehavior = False
        Me.lstList2.View = System.Windows.Forms.View.Details
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.cmdPrint3)
        Me.TabPage3.Controls.Add(Me.cmdFind3)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.dtTo3)
        Me.TabPage3.Controls.Add(Me.dtFrm3)
        Me.TabPage3.Controls.Add(Me.lstList3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1056, 518)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Not Inserted Cards Report"
        '
        'cmdPrint3
        '
        Me.cmdPrint3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdPrint3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPrint3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint3.Image = CType(resources.GetObject("cmdPrint3.Image"), System.Drawing.Image)
        Me.cmdPrint3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint3.Location = New System.Drawing.Point(421, 19)
        Me.cmdPrint3.Name = "cmdPrint3"
        Me.cmdPrint3.Size = New System.Drawing.Size(74, 61)
        Me.cmdPrint3.TabIndex = 37
        Me.cmdPrint3.Text = "Print"
        Me.cmdPrint3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPrint3.UseVisualStyleBackColor = False
        '
        'cmdFind3
        '
        Me.cmdFind3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdFind3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFind3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind3.Image = CType(resources.GetObject("cmdFind3.Image"), System.Drawing.Image)
        Me.cmdFind3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind3.Location = New System.Drawing.Point(333, 19)
        Me.cmdFind3.Name = "cmdFind3"
        Me.cmdFind3.Size = New System.Drawing.Size(74, 61)
        Me.cmdFind3.TabIndex = 36
        Me.cmdFind3.Text = "Find"
        Me.cmdFind3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdFind3.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(38, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Date To :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(22, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Date From :"
        '
        'dtTo3
        '
        Me.dtTo3.CustomFormat = "yyyy-MM-dd 23:59:59"
        Me.dtTo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo3.Location = New System.Drawing.Point(116, 56)
        Me.dtTo3.Name = "dtTo3"
        Me.dtTo3.Size = New System.Drawing.Size(200, 24)
        Me.dtTo3.TabIndex = 33
        '
        'dtFrm3
        '
        Me.dtFrm3.CustomFormat = "yyyy-MM-dd 00:00:00"
        Me.dtFrm3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrm3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFrm3.Location = New System.Drawing.Point(116, 19)
        Me.dtFrm3.Name = "dtFrm3"
        Me.dtFrm3.Size = New System.Drawing.Size(200, 24)
        Me.dtFrm3.TabIndex = 32
        '
        'lstList3
        '
        Me.lstList3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstList3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstList3.ForeColor = System.Drawing.Color.Black
        Me.lstList3.FullRowSelect = True
        Me.lstList3.GridLines = True
        Me.lstList3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstList3.Location = New System.Drawing.Point(9, 99)
        Me.lstList3.Name = "lstList3"
        Me.lstList3.Size = New System.Drawing.Size(1038, 410)
        Me.lstList3.TabIndex = 31
        Me.lstList3.UseCompatibleStateImageBehavior = False
        Me.lstList3.View = System.Windows.Forms.View.Details
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.txtLoad, Me.ToolStripStatusLabel2, Me.txtCnt, Me.ToolStripStatusLabel3, Me.txtTotalCnt})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 571)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1087, 37)
        Me.StatusStrip1.TabIndex = 20
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Image = CType(resources.GetObject("ToolStripStatusLabel1.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(137, 32)
        Me.ToolStripStatusLabel1.Text = "Record Count :"
        '
        'txtLoad
        '
        Me.txtLoad.Name = "txtLoad"
        Me.txtLoad.Size = New System.Drawing.Size(100, 31)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(12, 32)
        Me.ToolStripStatusLabel2.Text = " "
        '
        'txtCnt
        '
        Me.txtCnt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCnt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCnt.ForeColor = System.Drawing.Color.Blue
        Me.txtCnt.Name = "txtCnt"
        Me.txtCnt.Size = New System.Drawing.Size(16, 32)
        Me.txtCnt.Text = "0"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(16, 32)
        Me.ToolStripStatusLabel3.Text = "/"
        '
        'txtTotalCnt
        '
        Me.txtTotalCnt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTotalCnt.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCnt.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalCnt.Name = "txtTotalCnt"
        Me.txtTotalCnt.Size = New System.Drawing.Size(16, 32)
        Me.txtTotalCnt.Text = "0"
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1087, 608)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Reports"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lstList1 As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFrm As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdPrint1 As System.Windows.Forms.Button
    Friend WithEvents cmdFind1 As System.Windows.Forms.Button
    Friend WithEvents cmdPrint2 As System.Windows.Forms.Button
    Friend WithEvents cmdFind2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtTo2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFrm2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lstList2 As System.Windows.Forms.ListView
    Friend WithEvents cmdPrint3 As System.Windows.Forms.Button
    Friend WithEvents cmdFind3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtTo3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFrm3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lstList3 As System.Windows.Forms.ListView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboCashier As System.Windows.Forms.ComboBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtCnt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtLoad As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtTotalCnt As System.Windows.Forms.ToolStripStatusLabel
End Class
