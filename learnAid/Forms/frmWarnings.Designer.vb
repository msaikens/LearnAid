<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmWarnings
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
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
	Public WithEvents cboA As System.Windows.Forms.ComboBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents fraEdit As System.Windows.Forms.Panel
	Public WithEvents ilWarnings As System.Windows.Forms.ImageList
	Public WithEvents WarningCount As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents _StatusBar_Panel2 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents StatusBar As System.Windows.Forms.StatusStrip
	Public WithEvents _lvWarnings_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvWarnings_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvWarnings_ColumnHeader_3 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvWarnings_ColumnHeader_4 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvWarnings_ColumnHeader_5 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvWarnings As System.Windows.Forms.ListView
	Public WithEvents _Toolbar_Button1 As System.Windows.Forms.ToolStripButton
	Public WithEvents Toolbar As System.Windows.Forms.ToolStrip
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWarnings))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fraEdit = New System.Windows.Forms.Panel()
        Me.cboA = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ilWarnings = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.WarningCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me._StatusBar_Panel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lvWarnings = New System.Windows.Forms.ListView()
        Me._lvWarnings_ColumnHeader_1 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me._lvWarnings_ColumnHeader_2 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me._lvWarnings_ColumnHeader_3 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me._lvWarnings_ColumnHeader_4 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me._lvWarnings_ColumnHeader_5 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.Toolbar = New System.Windows.Forms.ToolStrip()
        Me._Toolbar_Button1 = New System.Windows.Forms.ToolStripButton()
        Me.fraEdit.SuspendLayout
        Me.StatusBar.SuspendLayout
        Me.Toolbar.SuspendLayout
        Me.SuspendLayout
        '
        'fraEdit
        '
        Me.fraEdit.BackColor = System.Drawing.SystemColors.Info
        Me.fraEdit.Controls.Add(Me.cboA)
        Me.fraEdit.Controls.Add(Me.Label3)
        Me.fraEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.fraEdit.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.fraEdit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraEdit.Location = New System.Drawing.Point(1, 291)
        Me.fraEdit.Name = "fraEdit"
        Me.fraEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraEdit.Size = New System.Drawing.Size(529, 26)
        Me.fraEdit.TabIndex = 2
        '
        'cboA
        '
        Me.cboA.BackColor = System.Drawing.SystemColors.Window
        Me.cboA.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboA.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboA.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboA.Location = New System.Drawing.Point(136, 2)
        Me.cboA.Name = "cboA"
        Me.cboA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboA.Size = New System.Drawing.Size(41, 22)
        Me.cboA.TabIndex = 4
        Me.cboA.TabStop = false
        Me.cboA.Text = "Combo1"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(137, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Change Student Answer:"
        '
        'ilWarnings
        '
        Me.ilWarnings.ImageStream = CType(resources.GetObject("ilWarnings.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.ilWarnings.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.ilWarnings.Images.SetKeyName(0, "Change")
        '
        'StatusBar
        '
        Me.StatusBar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WarningCount, Me._StatusBar_Panel2})
        Me.StatusBar.Location = New System.Drawing.Point(0, 320)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(530, 25)
        Me.StatusBar.TabIndex = 0
        '
        'WarningCount
        '
        Me.WarningCount.AutoSize = false
        Me.WarningCount.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)  _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)  _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom),System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.WarningCount.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.WarningCount.Margin = New System.Windows.Forms.Padding(0)
        Me.WarningCount.Name = "WarningCount"
        Me.WarningCount.Size = New System.Drawing.Size(134, 25)
        Me.WarningCount.Text = "Total Warnings:"
        Me.WarningCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_StatusBar_Panel2
        '
        Me._StatusBar_Panel2.AutoSize = false
        Me._StatusBar_Panel2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)  _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)  _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom),System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me._StatusBar_Panel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me._StatusBar_Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me._StatusBar_Panel2.Name = "_StatusBar_Panel2"
        Me._StatusBar_Panel2.Size = New System.Drawing.Size(381, 25)
        Me._StatusBar_Panel2.Spring = true
        Me._StatusBar_Panel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lvWarnings
        '
        Me.lvWarnings.BackColor = System.Drawing.SystemColors.Window
        Me.lvWarnings.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvWarnings_ColumnHeader_1, Me._lvWarnings_ColumnHeader_2, Me._lvWarnings_ColumnHeader_3, Me._lvWarnings_ColumnHeader_4, Me._lvWarnings_ColumnHeader_5})
        Me.lvWarnings.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lvWarnings.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvWarnings.FullRowSelect = true
        Me.lvWarnings.GridLines = true
        Me.lvWarnings.HideSelection = false
        Me.lvWarnings.Location = New System.Drawing.Point(0, 28)
        Me.lvWarnings.Name = "lvWarnings"
        Me.lvWarnings.Size = New System.Drawing.Size(529, 257)
        Me.lvWarnings.TabIndex = 1
        Me.lvWarnings.TabStop = false
        Me.lvWarnings.UseCompatibleStateImageBehavior = false
        Me.lvWarnings.View = System.Windows.Forms.View.Details
        '
        '_lvWarnings_ColumnHeader_1
        '
        Me._lvWarnings_ColumnHeader_1.Width = 24
        '
        '_lvWarnings_ColumnHeader_2
        '
        Me._lvWarnings_ColumnHeader_2.Text = "Name"
        Me._lvWarnings_ColumnHeader_2.Width = 170
        '
        '_lvWarnings_ColumnHeader_3
        '
        Me._lvWarnings_ColumnHeader_3.Text = "Section"
        Me._lvWarnings_ColumnHeader_3.Width = 170
        '
        '_lvWarnings_ColumnHeader_4
        '
        Me._lvWarnings_ColumnHeader_4.Text = "Question"
        Me._lvWarnings_ColumnHeader_4.Width = 170
        '
        '_lvWarnings_ColumnHeader_5
        '
        Me._lvWarnings_ColumnHeader_5.Text = "Description"
        Me._lvWarnings_ColumnHeader_5.Width = 170
        '
        'Toolbar
        '
        Me.Toolbar.ImageList = Me.ilWarnings
        Me.Toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._Toolbar_Button1})
        Me.Toolbar.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.Size = New System.Drawing.Size(530, 25)
        Me.Toolbar.TabIndex = 5
        '
        '_Toolbar_Button1
        '
        Me._Toolbar_Button1.AutoSize = false
        Me._Toolbar_Button1.ImageKey = "Change"
        Me._Toolbar_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar_Button1.Name = "_Toolbar_Button1"
        Me._Toolbar_Button1.Size = New System.Drawing.Size(24, 22)
        Me._Toolbar_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Toolbar_Button1.ToolTipText = "Change Answer"
        '
        'frmWarnings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(530, 345)
        Me.Controls.Add(Me.fraEdit)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.lvWarnings)
        Me.Controls.Add(Me.Toolbar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmWarnings"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Warnings"
        Me.fraEdit.ResumeLayout(false)
        Me.StatusBar.ResumeLayout(false)
        Me.StatusBar.PerformLayout
        Me.Toolbar.ResumeLayout(false)
        Me.Toolbar.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
#End Region 
End Class