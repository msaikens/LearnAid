Namespace Forms.MasterForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmConsultants
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
        Public WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents mnuRMNU As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents mnuDock As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents mnusep As System.Windows.Forms.ToolStripSeparator
        Public WithEvents mnuHide As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents mnuDockMenu As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
        Public WithEvents ImageList As System.Windows.Forms.ImageList
        Public WithEvents _lvCons_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
        Public WithEvents lvCons As System.Windows.Forms.ListView
        Public WithEvents Add As System.Windows.Forms.ToolStripButton
        Public WithEvents Edit As System.Windows.Forms.ToolStripButton
        Public WithEvents Delete As System.Windows.Forms.ToolStripButton
        Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultants))
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
            Me.mnuRMNU = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuAdd = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuDockMenu = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuDock = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnusep = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuHide = New System.Windows.Forms.ToolStripMenuItem()
            Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
            Me.lvCons = New System.Windows.Forms.ListView()
            Me._lvCons_ColumnHeader_1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
            Me.Add = New System.Windows.Forms.ToolStripButton()
            Me.Edit = New System.Windows.Forms.ToolStripButton()
            Me.Delete = New System.Windows.Forms.ToolStripButton()
            Me.MainMenu1.SuspendLayout()
            Me.ContextMenuStrip.SuspendLayout()
            Me.Toolbar1.SuspendLayout()
            Me.SuspendLayout()
            '
            'MainMenu1
            '
            Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRMNU, Me.mnuDockMenu})
            Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
            Me.MainMenu1.Name = "MainMenu1"
            Me.MainMenu1.Size = New System.Drawing.Size(356, 24)
            Me.MainMenu1.TabIndex = 2
            Me.MainMenu1.Visible = False
            '
            'mnuRMNU
            '
            Me.mnuRMNU.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuDelete})
            Me.mnuRMNU.Name = "mnuRMNU"
            Me.mnuRMNU.Size = New System.Drawing.Size(60, 20)
            Me.mnuRMNU.Text = "RMENU"
            Me.mnuRMNU.Visible = False
            '
            'mnuAdd
            '
            Me.mnuAdd.Name = "mnuAdd"
            Me.mnuAdd.Size = New System.Drawing.Size(274, 22)
            Me.mnuAdd.Text = "Add Consultant"
            '
            'mnuEdit
            '
            Me.mnuEdit.Name = "mnuEdit"
            Me.mnuEdit.Size = New System.Drawing.Size(274, 22)
            Me.mnuEdit.Text = "View/Edit Examiner or Consultant Info"
            '
            'mnuDelete
            '
            Me.mnuDelete.Name = "mnuDelete"
            Me.mnuDelete.Size = New System.Drawing.Size(274, 22)
            Me.mnuDelete.Text = "Delete Consultant"
            '
            'mnuDockMenu
            '
            Me.mnuDockMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDock, Me.mnusep, Me.mnuHide})
            Me.mnuDockMenu.Name = "mnuDockMenu"
            Me.mnuDockMenu.Size = New System.Drawing.Size(77, 20)
            Me.mnuDockMenu.Text = "DockMenu"
            Me.mnuDockMenu.Visible = False
            '
            'mnuDock
            '
            Me.mnuDock.Name = "mnuDock"
            Me.mnuDock.Size = New System.Drawing.Size(115, 22)
            Me.mnuDock.Text = "Undock"
            '
            'mnusep
            '
            Me.mnusep.Name = "mnusep"
            Me.mnusep.Size = New System.Drawing.Size(112, 6)
            '
            'mnuHide
            '
            Me.mnuHide.Name = "mnuHide"
            Me.mnuHide.Size = New System.Drawing.Size(115, 22)
            Me.mnuHide.Text = "Hide"
            '
            'ImageList
            '
            Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageList.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.ImageList.Images.SetKeyName(0, "Consultant")
            Me.ImageList.Images.SetKeyName(1, "Delete")
            Me.ImageList.Images.SetKeyName(2, "New")
            Me.ImageList.Images.SetKeyName(3, "Edit")
            '
            'lvCons
            '
            Me.lvCons.BackColor = System.Drawing.SystemColors.Window
            Me.lvCons.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvCons_ColumnHeader_1})
            Me.lvCons.ContextMenuStrip = Me.ContextMenuStrip
            Me.lvCons.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lvCons.ForeColor = System.Drawing.SystemColors.WindowText
            Me.lvCons.FullRowSelect = True
            Me.lvCons.GridLines = True
            Me.lvCons.LargeImageList = Me.ImageList
            Me.lvCons.Location = New System.Drawing.Point(0, 28)
            Me.lvCons.Name = "lvCons"
            Me.lvCons.Size = New System.Drawing.Size(266, 244)
            Me.lvCons.SmallImageList = Me.ImageList
            Me.lvCons.TabIndex = 1
            Me.lvCons.UseCompatibleStateImageBehavior = False
            Me.lvCons.View = System.Windows.Forms.View.Details
            '
            '_lvCons_ColumnHeader_1
            '
            Me._lvCons_ColumnHeader_1.Text = "Name"
            Me._lvCons_ColumnHeader_1.Width = 300
            '
            'ContextMenuStrip
            '
            Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
            Me.ContextMenuStrip.Name = "ContextMenuStrip"
            Me.ContextMenuStrip.Size = New System.Drawing.Size(210, 70)
            '
            'AddToolStripMenuItem
            '
            Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
            Me.AddToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
            Me.AddToolStripMenuItem.Text = "Add Consultant"
            '
            'EditToolStripMenuItem
            '
            Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
            Me.EditToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
            Me.EditToolStripMenuItem.Text = "View/Edit Consultant Info"
            '
            'DeleteToolStripMenuItem
            '
            Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
            Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
            Me.DeleteToolStripMenuItem.Text = "Delete Consultant"
            '
            'Toolbar1
            '
            Me.Toolbar1.ImageList = Me.ImageList
            Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Add, Me.Edit, Me.Delete})
            Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
            Me.Toolbar1.Name = "Toolbar1"
            Me.Toolbar1.Size = New System.Drawing.Size(266, 25)
            Me.Toolbar1.TabIndex = 0
            '
            'Add
            '
            Me.Add.AutoSize = False
            Me.Add.ImageKey = "New"
            Me.Add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.Add.Name = "Add"
            Me.Add.Size = New System.Drawing.Size(19, 20)
            Me.Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.Add.ToolTipText = "Add Examiner / Consultant"
            '
            'Edit
            '
            Me.Edit.AutoSize = False
            Me.Edit.ImageKey = "Edit"
            Me.Edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.Edit.Name = "Edit"
            Me.Edit.Size = New System.Drawing.Size(19, 20)
            Me.Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.Edit.ToolTipText = "View/Edit Examiner or Consultant"
            '
            'Delete
            '
            Me.Delete.AutoSize = False
            Me.Delete.ImageKey = "Delete"
            Me.Delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.Delete.Name = "Delete"
            Me.Delete.Size = New System.Drawing.Size(19, 20)
            Me.Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.Delete.ToolTipText = "Delete Examiner / Consultant"
            '
            'frmConsultants
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.ClientSize = New System.Drawing.Size(266, 275)
            Me.Controls.Add(Me.lvCons)
            Me.Controls.Add(Me.Toolbar1)
            Me.Controls.Add(Me.MainMenu1)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Location = New System.Drawing.Point(4, 24)
            Me.Name = "frmConsultants"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Examiners / Consultants"
            Me.MainMenu1.ResumeLayout(False)
            Me.MainMenu1.PerformLayout()
            Me.ContextMenuStrip.ResumeLayout(False)
            Me.Toolbar1.ResumeLayout(False)
            Me.Toolbar1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents ContextMenuStrip As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
#End Region
    End Class
End Namespace