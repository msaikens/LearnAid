Namespace Forms.MasterForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSchools
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
        Public WithEvents mnuAdd As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents mnuSep00 As System.Windows.Forms.ToolStripSeparator
        Public WithEvents mnuView As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents mnuEditPreJobs As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents mnusep01 As System.Windows.Forms.ToolStripSeparator
        Public WithEvents mnuPreviousReports As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents mnuSchools As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents mnuDock As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents mnuSep0021 As System.Windows.Forms.ToolStripSeparator
        Public WithEvents mnuHide As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents mnuDockMenu As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
        Public WithEvents ImageList1 As System.Windows.Forms.ImageList
        Public WithEvents _lvSchools_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
        Public WithEvents lvSchools As System.Windows.Forms.ListView
        Public WithEvents Add As System.Windows.Forms.ToolStripButton
        Public WithEvents Edit As System.Windows.Forms.ToolStripButton
        Public WithEvents Delete As System.Windows.Forms.ToolStripButton
        Public WithEvents Inactive As System.Windows.Forms.ToolStripButton
        Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchools))
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.AddSchoolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.DeleteSchoolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.ViewEditSchoolInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.AddEditPreJobsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.PreviousReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.lvSchools = New System.Windows.Forms.ListView()
            Me._lvSchools_ColumnHeader_1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
            Me.Add = New System.Windows.Forms.ToolStripButton()
            Me.Edit = New System.Windows.Forms.ToolStripButton()
            Me.Delete = New System.Windows.Forms.ToolStripButton()
            Me.Inactive = New System.Windows.Forms.ToolStripButton()
            Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
            Me.mnuSchools = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuAdd = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuSep00 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuEditPreJobs = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnusep01 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuPreviousReports = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuDockMenu = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuDock = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuSep0021 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuHide = New System.Windows.Forms.ToolStripMenuItem()
            Me.ContextMenuStrip.SuspendLayout()
            Me.Toolbar1.SuspendLayout()
            Me.MainMenu1.SuspendLayout()
            Me.SuspendLayout()
            '
            'ImageList1
            '
            Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageList1.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.ImageList1.Images.SetKeyName(0, "School")
            Me.ImageList1.Images.SetKeyName(1, "Delete")
            Me.ImageList1.Images.SetKeyName(2, "New")
            Me.ImageList1.Images.SetKeyName(3, "Edit")
            Me.ImageList1.Images.SetKeyName(4, "Inactive")
            '
            'ContextMenuStrip
            '
            Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSchoolToolStripMenuItem, Me.DeleteSchoolToolStripMenuItem, Me.ToolStripSeparator1, Me.ViewEditSchoolInfoToolStripMenuItem, Me.AddEditPreJobsToolStripMenuItem, Me.ToolStripSeparator2, Me.PreviousReportsToolStripMenuItem})
            Me.ContextMenuStrip.Name = "ContextMenuStrip"
            Me.ContextMenuStrip.Size = New System.Drawing.Size(188, 126)
            '
            'AddSchoolToolStripMenuItem
            '
            Me.AddSchoolToolStripMenuItem.Name = "AddSchoolToolStripMenuItem"
            Me.AddSchoolToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
            Me.AddSchoolToolStripMenuItem.Text = "Add School"
            '
            'DeleteSchoolToolStripMenuItem
            '
            Me.DeleteSchoolToolStripMenuItem.Name = "DeleteSchoolToolStripMenuItem"
            Me.DeleteSchoolToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
            Me.DeleteSchoolToolStripMenuItem.Text = "Delete School"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(184, 6)
            '
            'ViewEditSchoolInfoToolStripMenuItem
            '
            Me.ViewEditSchoolInfoToolStripMenuItem.Name = "ViewEditSchoolInfoToolStripMenuItem"
            Me.ViewEditSchoolInfoToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
            Me.ViewEditSchoolInfoToolStripMenuItem.Text = "View/Edit School Info"
            '
            'AddEditPreJobsToolStripMenuItem
            '
            Me.AddEditPreJobsToolStripMenuItem.Name = "AddEditPreJobsToolStripMenuItem"
            Me.AddEditPreJobsToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
            Me.AddEditPreJobsToolStripMenuItem.Text = "Add/Edit PreJobs"
            '
            'ToolStripSeparator2
            '
            Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
            Me.ToolStripSeparator2.Size = New System.Drawing.Size(184, 6)
            '
            'PreviousReportsToolStripMenuItem
            '
            Me.PreviousReportsToolStripMenuItem.Name = "PreviousReportsToolStripMenuItem"
            Me.PreviousReportsToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
            Me.PreviousReportsToolStripMenuItem.Text = "Previous Reports"
            '
            'lvSchools
            '
            Me.lvSchools.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lvSchools.BackColor = System.Drawing.SystemColors.Window
            Me.lvSchools.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvSchools_ColumnHeader_1})
            Me.lvSchools.ContextMenuStrip = Me.ContextMenuStrip
            Me.lvSchools.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lvSchools.ForeColor = System.Drawing.SystemColors.WindowText
            Me.lvSchools.FullRowSelect = True
            Me.lvSchools.GridLines = True
            Me.lvSchools.LargeImageList = Me.ImageList1
            Me.lvSchools.Location = New System.Drawing.Point(0, 28)
            Me.lvSchools.Name = "lvSchools"
            Me.lvSchools.Size = New System.Drawing.Size(188, 252)
            Me.lvSchools.SmallImageList = Me.ImageList1
            Me.lvSchools.TabIndex = 1
            Me.lvSchools.UseCompatibleStateImageBehavior = False
            Me.lvSchools.View = System.Windows.Forms.View.Details
            '
            '_lvSchools_ColumnHeader_1
            '
            Me._lvSchools_ColumnHeader_1.Text = "School"
            Me._lvSchools_ColumnHeader_1.Width = 300
            '
            'Toolbar1
            '
            Me.Toolbar1.ImageList = Me.ImageList1
            Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Add, Me.Edit, Me.Delete, Me.Inactive})
            Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
            Me.Toolbar1.Name = "Toolbar1"
            Me.Toolbar1.Size = New System.Drawing.Size(188, 25)
            Me.Toolbar1.TabIndex = 0
            '
            'Add
            '
            Me.Add.AutoSize = False
            Me.Add.ImageKey = "New"
            Me.Add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.Add.Name = "Add"
            Me.Add.Size = New System.Drawing.Size(24, 22)
            Me.Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.Add.ToolTipText = "Add School"
            '
            'Edit
            '
            Me.Edit.AutoSize = False
            Me.Edit.ImageKey = "Edit"
            Me.Edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.Edit.Name = "Edit"
            Me.Edit.Size = New System.Drawing.Size(24, 22)
            Me.Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.Edit.ToolTipText = "View/Edit School"
            '
            'Delete
            '
            Me.Delete.AutoSize = False
            Me.Delete.ImageKey = "Delete"
            Me.Delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.Delete.Name = "Delete"
            Me.Delete.Size = New System.Drawing.Size(24, 22)
            Me.Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.Delete.ToolTipText = "Delete School"
            '
            'Inactive
            '
            Me.Inactive.AutoSize = False
            Me.Inactive.ImageKey = "Inactive"
            Me.Inactive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.Inactive.Name = "Inactive"
            Me.Inactive.Size = New System.Drawing.Size(24, 22)
            Me.Inactive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.Inactive.ToolTipText = "Inactive Schools"
            '
            'MainMenu1
            '
            Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSchools, Me.mnuDockMenu})
            Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
            Me.MainMenu1.Name = "MainMenu1"
            Me.MainMenu1.Size = New System.Drawing.Size(188, 24)
            Me.MainMenu1.TabIndex = 2
            Me.MainMenu1.Visible = False
            '
            'mnuSchools
            '
            Me.mnuSchools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAdd, Me.mnuDelete, Me.mnuSep00, Me.mnuView, Me.mnuEditPreJobs, Me.mnusep01, Me.mnuPreviousReports})
            Me.mnuSchools.Name = "mnuSchools"
            Me.mnuSchools.Size = New System.Drawing.Size(60, 20)
            Me.mnuSchools.Text = "Schools"
            Me.mnuSchools.Visible = False
            '
            'mnuAdd
            '
            Me.mnuAdd.Name = "mnuAdd"
            Me.mnuAdd.Size = New System.Drawing.Size(187, 22)
            Me.mnuAdd.Text = "&Add School"
            '
            'mnuDelete
            '
            Me.mnuDelete.Name = "mnuDelete"
            Me.mnuDelete.Size = New System.Drawing.Size(187, 22)
            Me.mnuDelete.Text = "&Delete School"
            '
            'mnuSep00
            '
            Me.mnuSep00.Name = "mnuSep00"
            Me.mnuSep00.Size = New System.Drawing.Size(184, 6)
            '
            'mnuView
            '
            Me.mnuView.Name = "mnuView"
            Me.mnuView.Size = New System.Drawing.Size(187, 22)
            Me.mnuView.Text = "&View/Edit School Info"
            '
            'mnuEditPreJobs
            '
            Me.mnuEditPreJobs.Name = "mnuEditPreJobs"
            Me.mnuEditPreJobs.Size = New System.Drawing.Size(187, 22)
            Me.mnuEditPreJobs.Text = "Add/Edit PreJobs"
            '
            'mnusep01
            '
            Me.mnusep01.Name = "mnusep01"
            Me.mnusep01.Size = New System.Drawing.Size(184, 6)
            '
            'mnuPreviousReports
            '
            Me.mnuPreviousReports.Name = "mnuPreviousReports"
            Me.mnuPreviousReports.Size = New System.Drawing.Size(187, 22)
            Me.mnuPreviousReports.Text = "& Previous Reports"
            '
            'mnuDockMenu
            '
            Me.mnuDockMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDock, Me.mnuSep0021, Me.mnuHide})
            Me.mnuDockMenu.Name = "mnuDockMenu"
            Me.mnuDockMenu.Size = New System.Drawing.Size(77, 20)
            Me.mnuDockMenu.Text = "DockMenu"
            Me.mnuDockMenu.Visible = False
            '
            'mnuDock
            '
            Me.mnuDock.Name = "mnuDock"
            Me.mnuDock.Size = New System.Drawing.Size(116, 22)
            Me.mnuDock.Text = "UnDock"
            '
            'mnuSep0021
            '
            Me.mnuSep0021.Name = "mnuSep0021"
            Me.mnuSep0021.Size = New System.Drawing.Size(113, 6)
            '
            'mnuHide
            '
            Me.mnuHide.Name = "mnuHide"
            Me.mnuHide.Size = New System.Drawing.Size(116, 22)
            Me.mnuHide.Text = "Hide"
            '
            'frmSchools
            '
            Me.AllowDrop = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.ClientSize = New System.Drawing.Size(188, 278)
            Me.Controls.Add(Me.lvSchools)
            Me.Controls.Add(Me.Toolbar1)
            Me.Controls.Add(Me.MainMenu1)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "frmSchools"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Schools"
            Me.ContextMenuStrip.ResumeLayout(False)
            Me.Toolbar1.ResumeLayout(False)
            Me.Toolbar1.PerformLayout()
            Me.MainMenu1.ResumeLayout(False)
            Me.MainMenu1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend Shadows WithEvents ContextMenuStrip As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents AddSchoolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents DeleteSchoolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents ViewEditSchoolInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents AddEditPreJobsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents PreviousReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
#End Region
    End Class
End Namespace