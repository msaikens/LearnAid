Namespace Forms.AccountingForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAccountingView
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
        Public WithEvents _lvAccounting_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
        Public WithEvents _lvAccounting_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
        Public WithEvents _lvAccounting_ColumnHeader_3 As System.Windows.Forms.ColumnHeader
        Public WithEvents _lvAccounting_ColumnHeader_4 As System.Windows.Forms.ColumnHeader
        Public WithEvents _lvAccounting_ColumnHeader_5 As System.Windows.Forms.ColumnHeader
        Public WithEvents lvAccounting As System.Windows.Forms.ListView
        Public WithEvents Add As System.Windows.Forms.ToolStripButton
        Public WithEvents PrintReport As System.Windows.Forms.ToolStripButton
        Public WithEvents Toolbar As System.Windows.Forms.ToolStrip
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccountingView))
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.ilViewS = New System.Windows.Forms.ImageList(Me.components)
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.lvAccounting = New System.Windows.Forms.ListView()
            Me._lvAccounting_ColumnHeader_1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._lvAccounting_ColumnHeader_2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._lvAccounting_ColumnHeader_3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._lvAccounting_ColumnHeader_4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._lvAccounting_ColumnHeader_5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.Toolbar = New System.Windows.Forms.ToolStrip()
            Me.Add = New System.Windows.Forms.ToolStripButton()
            Me.PrintReport = New System.Windows.Forms.ToolStripButton()
            Me.Toolbar.SuspendLayout()
            Me.SuspendLayout()
            '
            'ilViewS
            '
            Me.ilViewS.ImageStream = CType(resources.GetObject("ilViewS.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ilViewS.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.ilViewS.Images.SetKeyName(0, "add")
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
            Me.Timer1.Enabled = True
            Me.Timer1.Interval = 60000
            '
            'lvAccounting
            '
            Me.lvAccounting.AllowColumnReorder = True
            Me.lvAccounting.BackColor = System.Drawing.SystemColors.Window
            Me.lvAccounting.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvAccounting_ColumnHeader_1, Me._lvAccounting_ColumnHeader_2, Me._lvAccounting_ColumnHeader_3, Me._lvAccounting_ColumnHeader_4, Me._lvAccounting_ColumnHeader_5})
            Me.lvAccounting.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lvAccounting.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lvAccounting.ForeColor = System.Drawing.SystemColors.WindowText
            Me.lvAccounting.FullRowSelect = True
            Me.lvAccounting.GridLines = True
            Me.lvAccounting.HideSelection = False
            Me.lvAccounting.Location = New System.Drawing.Point(0, 25)
            Me.lvAccounting.Name = "lvAccounting"
            Me.lvAccounting.Size = New System.Drawing.Size(583, 404)
            Me.lvAccounting.TabIndex = 1
            Me.lvAccounting.UseCompatibleStateImageBehavior = False
            Me.lvAccounting.View = System.Windows.Forms.View.Details
            '
            '_lvAccounting_ColumnHeader_1
            '
            Me._lvAccounting_ColumnHeader_1.Text = "From Date"
            Me._lvAccounting_ColumnHeader_1.Width = 170
            '
            '_lvAccounting_ColumnHeader_2
            '
            Me._lvAccounting_ColumnHeader_2.Text = "To Date"
            Me._lvAccounting_ColumnHeader_2.Width = 170
            '
            '_lvAccounting_ColumnHeader_3
            '
            Me._lvAccounting_ColumnHeader_3.Text = "Total Examiners"
            Me._lvAccounting_ColumnHeader_3.Width = 170
            '
            '_lvAccounting_ColumnHeader_4
            '
            Me._lvAccounting_ColumnHeader_4.Text = "Total Paid"
            Me._lvAccounting_ColumnHeader_4.Width = 170
            '
            '_lvAccounting_ColumnHeader_5
            '
            Me._lvAccounting_ColumnHeader_5.Text = "Status"
            Me._lvAccounting_ColumnHeader_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me._lvAccounting_ColumnHeader_5.Width = 170
            '
            'Toolbar
            '
            Me.Toolbar.ImageList = Me.ilViewS
            Me.Toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Add, Me.PrintReport})
            Me.Toolbar.Location = New System.Drawing.Point(0, 0)
            Me.Toolbar.Name = "Toolbar"
            Me.Toolbar.Size = New System.Drawing.Size(583, 25)
            Me.Toolbar.TabIndex = 0
            '
            'Add
            '
            Me.Add.AutoSize = False
            Me.Add.ImageKey = "add"
            Me.Add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.Add.Name = "Add"
            Me.Add.Size = New System.Drawing.Size(24, 22)
            Me.Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.Add.ToolTipText = "Create Accounting Summary"
            '
            'PrintReport
            '
            Me.PrintReport.AutoSize = False
            Me.PrintReport.ImageKey = "Print"
            Me.PrintReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.PrintReport.Name = "PrintReport"
            Me.PrintReport.Size = New System.Drawing.Size(24, 22)
            Me.PrintReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.PrintReport.ToolTipText = "Print Accounting Report"
            '
            'frmAccountingView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.ClientSize = New System.Drawing.Size(583, 429)
            Me.ControlBox = False
            Me.Controls.Add(Me.lvAccounting)
            Me.Controls.Add(Me.Toolbar)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Location = New System.Drawing.Point(4, 23)
            Me.Name = "frmAccountingView"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
            Me.Text = "Accounting"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.Toolbar.ResumeLayout(False)
            Me.Toolbar.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region
    End Class
End Namespace