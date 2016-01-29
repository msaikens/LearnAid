<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmReportView
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
		'This form is an MDI child.
		'This code simulates the VB6 
		' functionality of automatically
		' loading and showing an MDI
		' child's parent.
        Me.MdiParent = frmMain
        frmMain.Show()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents ilViewS As System.Windows.Forms.ImageList
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents _lvReports_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvReports_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvReports_ColumnHeader_3 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvReports_ColumnHeader_4 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvReports_ColumnHeader_5 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvReports_ColumnHeader_6 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvReports_ColumnHeader_7 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvReports As System.Windows.Forms.ListView
	Public WithEvents RegularReport As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents OTReport As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents EntranceReport As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents _Toolbar1_Button1 As System.Windows.Forms.ToolStripDropDownButton
	Public WithEvents Print As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar1_Button3 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents Delete As System.Windows.Forms.ToolStripButton
	Public WithEvents Analysis As System.Windows.Forms.ToolStripButton
	Public WithEvents Range As System.Windows.Forms.ToolStripButton
	Public WithEvents Certificados As System.Windows.Forms.ToolStripButton
	Public WithEvents Five As System.Windows.Forms.ToolStripButton
	Public WithEvents Estanina As System.Windows.Forms.ToolStripButton
	Public WithEvents Prepost As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
	Public WithEvents cmdRepRefresh As System.Windows.Forms.Button
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportView))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ilViewS = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lvReports = New System.Windows.Forms.ListView()
        Me._lvReports_ColumnHeader_1 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me._lvReports_ColumnHeader_2 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me._lvReports_ColumnHeader_3 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me._lvReports_ColumnHeader_4 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me._lvReports_ColumnHeader_5 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me._lvReports_ColumnHeader_6 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me._lvReports_ColumnHeader_7 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
        Me._Toolbar1_Button1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.RegularReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.OTReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntranceReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.Print = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar1_Button3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Delete = New System.Windows.Forms.ToolStripButton()
        Me.Analysis = New System.Windows.Forms.ToolStripButton()
        Me.Range = New System.Windows.Forms.ToolStripButton()
        Me.Certificados = New System.Windows.Forms.ToolStripButton()
        Me.Five = New System.Windows.Forms.ToolStripButton()
        Me.Estanina = New System.Windows.Forms.ToolStripButton()
        Me.Prepost = New System.Windows.Forms.ToolStripButton()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txtRepFromDate = New System.Windows.Forms.DateTimePicker()
        Me.txtRepToDate = New System.Windows.Forms.DateTimePicker()
        Me.cmdRepRefresh = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Toolbar1.SuspendLayout
        Me.Frame1.SuspendLayout
        Me.SuspendLayout
        '
        'ilViewS
        '
        Me.ilViewS.ImageStream = CType(resources.GetObject("ilViewS.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.ilViewS.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.ilViewS.Images.SetKeyName(0, "New")
        Me.ilViewS.Images.SetKeyName(1, "Print")
        Me.ilViewS.Images.SetKeyName(2, "Edit")
        Me.ilViewS.Images.SetKeyName(3, "Warnings")
        Me.ilViewS.Images.SetKeyName(4, "Errors")
        Me.ilViewS.Images.SetKeyName(5, "ViewWarnings")
        Me.ilViewS.Images.SetKeyName(6, "Delete")
        Me.ilViewS.Images.SetKeyName(7, "Completed")
        '
        'Timer1
        '
        Me.Timer1.Enabled = true
        Me.Timer1.Interval = 300000
        '
        'lvReports
        '
        Me.lvReports.BackColor = System.Drawing.SystemColors.Window
        Me.lvReports.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvReports_ColumnHeader_1, Me._lvReports_ColumnHeader_2, Me._lvReports_ColumnHeader_3, Me._lvReports_ColumnHeader_4, Me._lvReports_ColumnHeader_5, Me._lvReports_ColumnHeader_6, Me._lvReports_ColumnHeader_7})
        Me.lvReports.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvReports.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvReports.FullRowSelect = True
        Me.lvReports.GridLines = True
        Me.lvReports.HideSelection = False
        Me.lvReports.Location = New System.Drawing.Point(0, 63)
        Me.lvReports.Name = "lvReports"
        Me.lvReports.Size = New System.Drawing.Size(481, 289)
        Me.lvReports.TabIndex = 1
        Me.lvReports.UseCompatibleStateImageBehavior = False
        Me.lvReports.View = System.Windows.Forms.View.Details
        '
        '_lvReports_ColumnHeader_1
        '
        Me._lvReports_ColumnHeader_1.Text = "Service Date"
        Me._lvReports_ColumnHeader_1.Width = 170
        '
        '_lvReports_ColumnHeader_2
        '
        Me._lvReports_ColumnHeader_2.Text = "Report Type"
        Me._lvReports_ColumnHeader_2.Width = 170
        '
        '_lvReports_ColumnHeader_3
        '
        Me._lvReports_ColumnHeader_3.Text = "School"
        Me._lvReports_ColumnHeader_3.Width = 457
        '
        '_lvReports_ColumnHeader_4
        '
        Me._lvReports_ColumnHeader_4.Text = "Year"
        Me._lvReports_ColumnHeader_4.Width = 170
        '
        '_lvReports_ColumnHeader_5
        '
        Me._lvReports_ColumnHeader_5.Text = "Semester"
        Me._lvReports_ColumnHeader_5.Width = 170
        '
        '_lvReports_ColumnHeader_6
        '
        Me._lvReports_ColumnHeader_6.Text = "Acomodo Razonable"
        Me._lvReports_ColumnHeader_6.Width = 170
        '
        '_lvReports_ColumnHeader_7
        '
        Me._lvReports_ColumnHeader_7.Text = "Reposición"
        Me._lvReports_ColumnHeader_7.Width = 170
        '
        'Toolbar1
        '
        Me.Toolbar1.ImageList = Me.ilViewS
        Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._Toolbar1_Button1, Me.Print, Me._Toolbar1_Button3, Me.Delete, Me.Analysis, Me.Range, Me.Certificados, Me.Five, Me.Estanina, Me.Prepost})
        Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar1.Name = "Toolbar1"
        Me.Toolbar1.Size = New System.Drawing.Size(826, 25)
        Me.Toolbar1.TabIndex = 0
        '
        '_Toolbar1_Button1
        '
        Me._Toolbar1_Button1.AutoSize = False
        Me._Toolbar1_Button1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegularReport, Me.OTReport, Me.EntranceReport})
        Me._Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar1_Button1.Name = "_Toolbar1_Button1"
        Me._Toolbar1_Button1.Size = New System.Drawing.Size(114, 22)
        Me._Toolbar1_Button1.Text = "Create Report"
        '
        'RegularReport
        '
        Me.RegularReport.Name = "RegularReport"
        Me.RegularReport.Size = New System.Drawing.Size(266, 24)
        Me.RegularReport.Text = "Create Regular Report"
        '
        'OTReport
        '
        Me.OTReport.Name = "OTReport"
        Me.OTReport.Size = New System.Drawing.Size(266, 24)
        Me.OTReport.Text = "Create Office Testing Report"
        '
        'EntranceReport
        '
        Me.EntranceReport.Name = "EntranceReport"
        Me.EntranceReport.Size = New System.Drawing.Size(266, 24)
        Me.EntranceReport.Text = "Create Entrance Report"
        '
        'Print
        '
        Me.Print.AutoSize = False
        Me.Print.ImageKey = "Print"
        Me.Print.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(101, 22)
        Me.Print.Text = "Print Report"
        Me.Print.ToolTipText = "Print Report"
        '
        '_Toolbar1_Button3
        '
        Me._Toolbar1_Button3.AutoSize = False
        Me._Toolbar1_Button3.Name = "_Toolbar1_Button3"
        Me._Toolbar1_Button3.Size = New System.Drawing.Size(101, 22)
        '
        'Delete
        '
        Me.Delete.AutoSize = False
        Me.Delete.ImageKey = "Delete"
        Me.Delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(101, 22)
        Me.Delete.Text = "Delete Rep"
        Me.Delete.ToolTipText = "Delete Report"
        '
        'Analysis
        '
        Me.Analysis.AutoSize = False
        Me.Analysis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Analysis.Name = "Analysis"
        Me.Analysis.Size = New System.Drawing.Size(101, 22)
        Me.Analysis.Text = "Analysis Rep"
        '
        'Range
        '
        Me.Range.AutoSize = False
        Me.Range.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Range.Name = "Range"
        Me.Range.Size = New System.Drawing.Size(101, 22)
        Me.Range.Text = "Sch Range Rep"
        '
        'Certificados
        '
        Me.Certificados.AutoSize = False
        Me.Certificados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Certificados.Name = "Certificados"
        Me.Certificados.Size = New System.Drawing.Size(101, 22)
        Me.Certificados.Text = "Certificados"
        '
        'Five
        '
        Me.Five.AutoSize = False
        Me.Five.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Five.Name = "Five"
        Me.Five.Size = New System.Drawing.Size(101, 22)
        Me.Five.Text = "5Years"
        '
        'Estanina
        '
        Me.Estanina.AutoSize = False
        Me.Estanina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Estanina.Name = "Estanina"
        Me.Estanina.Size = New System.Drawing.Size(101, 22)
        Me.Estanina.Text = "Estanina Anual"
        '
        'Prepost
        '
        Me.Prepost.AutoSize = False
        Me.Prepost.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Prepost.Name = "Prepost"
        Me.Prepost.Size = New System.Drawing.Size(101, 22)
        Me.Prepost.Text = "Pre-Post"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtRepFromDate)
        Me.Frame1.Controls.Add(Me.txtRepToDate)
        Me.Frame1.Controls.Add(Me.cmdRepRefresh)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 20)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(732, 37)
        Me.Frame1.TabIndex = 2
        Me.Frame1.TabStop = False
        '
        'txtRepFromDate
        '
        Me.txtRepFromDate.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption
        Me.txtRepFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtRepFromDate.Location = New System.Drawing.Point(56, 12)
        Me.txtRepFromDate.Name = "txtRepFromDate"
        Me.txtRepFromDate.Size = New System.Drawing.Size(97, 23)
        Me.txtRepFromDate.TabIndex = 10
        '
        'txtRepToDate
        '
        Me.txtRepToDate.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption
        Me.txtRepToDate.CustomFormat = "MM/dd/yy"
        Me.txtRepToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtRepToDate.Location = New System.Drawing.Point(183, 13)
        Me.txtRepToDate.Name = "txtRepToDate"
        Me.txtRepToDate.Size = New System.Drawing.Size(98, 23)
        Me.txtRepToDate.TabIndex = 3
        '
        'cmdRepRefresh
        '
        Me.cmdRepRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRepRefresh.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cmdRepRefresh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRepRefresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRepRefresh.Location = New System.Drawing.Point(296, 11)
        Me.cmdRepRefresh.Name = "cmdRepRefresh"
        Me.cmdRepRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRepRefresh.Size = New System.Drawing.Size(59, 22)
        Me.cmdRepRefresh.TabIndex = 7
        Me.cmdRepRefresh.Text = "Refresh"
        Me.cmdRepRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdRepRefresh.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(159, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "From:"
        '
        'frmReportView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(826, 448)
        Me.Controls.Add(Me.lvReports)
        Me.Controls.Add(Me.Toolbar1)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Location = New System.Drawing.Point(4, 4)
        Me.Name = "frmReportView"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Toolbar1.ResumeLayout(false)
        Me.Toolbar1.PerformLayout
        Me.Frame1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
 Friend WithEvents txtRepToDate As System.Windows.Forms.DateTimePicker
 Friend WithEvents txtRepFromDate As System.Windows.Forms.DateTimePicker
#End Region 
End Class