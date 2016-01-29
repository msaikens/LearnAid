<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmConsultantView
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
	Public WithEvents ImageList1 As System.Windows.Forms.ImageList
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents _lvConsultant_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvConsultant_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvConsultant_ColumnHeader_3 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvConsultant As System.Windows.Forms.ListView
	Public WithEvents _Toolbar_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents _Toolbar_Button2 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents _Toolbar_Button3 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar As System.Windows.Forms.ToolStrip
    Public WithEvents cmdConsRefresh As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultantView))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lvConsultant = New System.Windows.Forms.ListView()
        Me._lvConsultant_ColumnHeader_1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._lvConsultant_ColumnHeader_2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._lvConsultant_ColumnHeader_3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Toolbar = New System.Windows.Forms.ToolStrip()
        Me._Toolbar_Button1 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar_Button2 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar_Button3 = New System.Windows.Forms.ToolStripButton()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.cmdConsRefresh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtConsFromDate = New System.Windows.Forms.DateTimePicker()
        Me.txtConsToDate = New System.Windows.Forms.DateTimePicker()
        Me.Toolbar.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ImageList1.Images.SetKeyName(0, "open_rep")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'lvConsultant
        '
        Me.lvConsultant.AllowColumnReorder = True
        Me.lvConsultant.BackColor = System.Drawing.SystemColors.Window
        Me.lvConsultant.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvConsultant_ColumnHeader_1, Me._lvConsultant_ColumnHeader_2, Me._lvConsultant_ColumnHeader_3})
        Me.lvConsultant.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvConsultant.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvConsultant.FullRowSelect = True
        Me.lvConsultant.GridLines = True
        Me.lvConsultant.HideSelection = False
        Me.lvConsultant.Location = New System.Drawing.Point(16, 69)
        Me.lvConsultant.Name = "lvConsultant"
        Me.lvConsultant.Size = New System.Drawing.Size(521, 345)
        Me.lvConsultant.TabIndex = 1
        Me.lvConsultant.UseCompatibleStateImageBehavior = False
        Me.lvConsultant.View = System.Windows.Forms.View.Details
        '
        '_lvConsultant_ColumnHeader_1
        '
        Me._lvConsultant_ColumnHeader_1.Text = "Service Date"
        Me._lvConsultant_ColumnHeader_1.Width = 170
        '
        '_lvConsultant_ColumnHeader_2
        '
        Me._lvConsultant_ColumnHeader_2.Text = "School"
        Me._lvConsultant_ColumnHeader_2.Width = 287
        '
        '_lvConsultant_ColumnHeader_3
        '
        Me._lvConsultant_ColumnHeader_3.Text = "Status"
        Me._lvConsultant_ColumnHeader_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me._lvConsultant_ColumnHeader_3.Width = 170
        '
        'Toolbar
        '
        Me.Toolbar.ImageList = Me.ImageList1
        Me.Toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._Toolbar_Button1, Me._Toolbar_Button2, Me._Toolbar_Button3})
        Me.Toolbar.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.Size = New System.Drawing.Size(583, 25)
        Me.Toolbar.TabIndex = 0
        '
        '_Toolbar_Button1
        '
        Me._Toolbar_Button1.AutoSize = False
        Me._Toolbar_Button1.ImageKey = "open_rep"
        Me._Toolbar_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar_Button1.Name = "_Toolbar_Button1"
        Me._Toolbar_Button1.Size = New System.Drawing.Size(98, 22)
        Me._Toolbar_Button1.ToolTipText = "Open Report"
        '
        '_Toolbar_Button2
        '
        Me._Toolbar_Button2.AutoSize = False
        Me._Toolbar_Button2.Name = "_Toolbar_Button2"
        Me._Toolbar_Button2.Size = New System.Drawing.Size(98, 22)
        '
        '_Toolbar_Button3
        '
        Me._Toolbar_Button3.AutoSize = False
        Me._Toolbar_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar_Button3.Name = "_Toolbar_Button3"
        Me._Toolbar_Button3.Size = New System.Drawing.Size(98, 22)
        Me._Toolbar_Button3.Text = "T1 D. Staninas"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtConsToDate)
        Me.Frame1.Controls.Add(Me.txtConsFromDate)
        Me.Frame1.Controls.Add(Me.cmdConsRefresh)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 24)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(562, 37)
        Me.Frame1.TabIndex = 2
        Me.Frame1.TabStop = False
        '
        'cmdConsRefresh
        '
        Me.cmdConsRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConsRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConsRefresh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConsRefresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConsRefresh.Location = New System.Drawing.Point(321, 11)
        Me.cmdConsRefresh.Name = "cmdConsRefresh"
        Me.cmdConsRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConsRefresh.Size = New System.Drawing.Size(61, 23)
        Me.cmdConsRefresh.TabIndex = 3
        Me.cmdConsRefresh.Text = "Refresh"
        Me.cmdConsRefresh.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(169, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "To:"
        '
        'txtConsFromDate
        '
        Me.txtConsFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtConsFromDate.Location = New System.Drawing.Point(52, 13)
        Me.txtConsFromDate.Name = "txtConsFromDate"
        Me.txtConsFromDate.Size = New System.Drawing.Size(109, 20)
        Me.txtConsFromDate.TabIndex = 9
        '
        'txtConsToDate
        '
        Me.txtConsToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtConsToDate.Location = New System.Drawing.Point(197, 13)
        Me.txtConsToDate.Name = "txtConsToDate"
        Me.txtConsToDate.Size = New System.Drawing.Size(114, 20)
        Me.txtConsToDate.TabIndex = 10
        '
        'frmConsultantView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(583, 429)
        Me.ControlBox = False
        Me.Controls.Add(Me.lvConsultant)
        Me.Controls.Add(Me.Toolbar)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmConsultantView"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Consultant"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Toolbar.ResumeLayout(False)
        Me.Toolbar.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtConsToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtConsFromDate As System.Windows.Forms.DateTimePicker
#End Region 
End Class