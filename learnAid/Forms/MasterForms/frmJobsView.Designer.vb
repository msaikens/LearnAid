Namespace Forms.MasterForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmJobsView
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
        Public WithEvents _Toolbar_Button1 As System.Windows.Forms.ToolStripButton
        Public WithEvents _Toolbar_Button2 As System.Windows.Forms.ToolStripButton
        Public WithEvents _Toolbar_Button3 As System.Windows.Forms.ToolStripButton
        Public WithEvents _Toolbar_Button4 As System.Windows.Forms.ToolStripButton
        Public WithEvents _Toolbar_Button5 As System.Windows.Forms.ToolStripSeparator
        Public WithEvents _Toolbar_Button6_ButtonMenu1 As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents _Toolbar_Button6_ButtonMenu2 As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents _Toolbar_Button6_ButtonMenu3 As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents _Toolbar_Button6_ButtonMenu4 As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents _Toolbar_Button6_ButtonMenu5 As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents _Toolbar_Button6 As System.Windows.Forms.ToolStripDropDownButton
        Public WithEvents _Toolbar_Button7_ButtonMenu1 As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents _Toolbar_Button7_ButtonMenu2 As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents _Toolbar_Button7 As System.Windows.Forms.ToolStripDropDownButton
        Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
        'Public WithEvents mcTab As Axmccommandv102.Axmctabworkbook
        Public WithEvents ilViewS As System.Windows.Forms.ImageList
        Public WithEvents ilColumHeaders As System.Windows.Forms.ImageList
        Public WithEvents tmrUpdateJobs As System.Windows.Forms.Timer
        Public WithEvents _lvJobs_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
        Public WithEvents _lvJobs_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
        Public WithEvents _lvJobs_ColumnHeader_3 As System.Windows.Forms.ColumnHeader
        Public WithEvents _lvJobs_ColumnHeader_4 As System.Windows.Forms.ColumnHeader
        Public WithEvents _lvJobs_ColumnHeader_5 As System.Windows.Forms.ColumnHeader
        Public WithEvents _lvJobs_ColumnHeader_6 As System.Windows.Forms.ColumnHeader
        Public WithEvents _lvJobs_ColumnHeader_7 As System.Windows.Forms.ColumnHeader
        Public WithEvents _lvJobs_ColumnHeader_8 As System.Windows.Forms.ColumnHeader
        Public WithEvents _lvJobs_ColumnHeader_9 As System.Windows.Forms.ColumnHeader
        Public WithEvents _lvJobs_ColumnHeader_10 As System.Windows.Forms.ColumnHeader
        Public WithEvents lvJobs As System.Windows.Forms.ListView
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJobsView))
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
            Me.ilViewS = New System.Windows.Forms.ImageList(Me.components)
            Me._Toolbar_Button1 = New System.Windows.Forms.ToolStripButton()
            Me._Toolbar_Button2 = New System.Windows.Forms.ToolStripButton()
            Me._Toolbar_Button3 = New System.Windows.Forms.ToolStripButton()
            Me._Toolbar_Button4 = New System.Windows.Forms.ToolStripButton()
            Me._Toolbar_Button5 = New System.Windows.Forms.ToolStripSeparator()
            Me._Toolbar_Button6 = New System.Windows.Forms.ToolStripDropDownButton()
            Me._Toolbar_Button6_ButtonMenu1 = New System.Windows.Forms.ToolStripMenuItem()
            Me._Toolbar_Button6_ButtonMenu2 = New System.Windows.Forms.ToolStripMenuItem()
            Me._Toolbar_Button6_ButtonMenu3 = New System.Windows.Forms.ToolStripMenuItem()
            Me._Toolbar_Button6_ButtonMenu4 = New System.Windows.Forms.ToolStripMenuItem()
            Me._Toolbar_Button6_ButtonMenu5 = New System.Windows.Forms.ToolStripMenuItem()
            Me._Toolbar_Button7 = New System.Windows.Forms.ToolStripDropDownButton()
            Me._Toolbar_Button7_ButtonMenu1 = New System.Windows.Forms.ToolStripMenuItem()
            Me._Toolbar_Button7_ButtonMenu2 = New System.Windows.Forms.ToolStripMenuItem()
            Me.ilColumHeaders = New System.Windows.Forms.ImageList(Me.components)
            Me.tmrUpdateJobs = New System.Windows.Forms.Timer(Me.components)
            Me.lvJobs = New System.Windows.Forms.ListView()
            Me._lvJobs_ColumnHeader_1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._lvJobs_ColumnHeader_2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._lvJobs_ColumnHeader_3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._lvJobs_ColumnHeader_4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._lvJobs_ColumnHeader_5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._lvJobs_ColumnHeader_6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._lvJobs_ColumnHeader_7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._lvJobs_ColumnHeader_8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._lvJobs_ColumnHeader_9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._lvJobs_ColumnHeader_10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.NewJobToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.EditJobToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.DeleteJobToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.ResetJobToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ClearJobToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ViewWarningsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ViewEditStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.Toolbar = New System.Windows.Forms.ToolStrip()
            Me.btnNew = New System.Windows.Forms.ToolStripButton()
            Me.btnEdit = New System.Windows.Forms.ToolStripButton()
            Me.btnDelete = New System.Windows.Forms.ToolStripButton()
            Me.VWarnings = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
            Me.mnuScan = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuEvaluate = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuNewScan = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuOrdenScan = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuReScan = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
            Me.mnuRScan = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuREvaluate = New System.Windows.Forms.ToolStripMenuItem()
            Me.btnAll = New System.Windows.Forms.RadioButton()
            Me.btnPending = New System.Windows.Forms.RadioButton()
            Me.btnMyJobs = New System.Windows.Forms.RadioButton()
            Me.updateResEstbtn = New System.Windows.Forms.Button()
            Me.Toolbar1.SuspendLayout()
            Me.ContextMenuStrip.SuspendLayout()
            Me.Toolbar.SuspendLayout()
            Me.SuspendLayout()
            '
            'Toolbar1
            '
            Me.Toolbar1.AutoSize = False
            Me.Toolbar1.CanOverflow = False
            Me.Toolbar1.ImageList = Me.ilViewS
            Me.Toolbar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._Toolbar_Button1, Me._Toolbar_Button2, Me._Toolbar_Button3, Me._Toolbar_Button4, Me._Toolbar_Button5, Me._Toolbar_Button6, Me._Toolbar_Button7})
            Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
            Me.Toolbar1.Name = "Toolbar1"
            Me.Toolbar1.Size = New System.Drawing.Size(534, 38)
            Me.Toolbar1.TabIndex = 2
            Me.Toolbar1.Visible = False
            '
            'ilViewS
            '
            Me.ilViewS.ImageStream = CType(resources.GetObject("ilViewS.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ilViewS.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.ilViewS.Images.SetKeyName(0, "New")
            Me.ilViewS.Images.SetKeyName(1, "Process")
            Me.ilViewS.Images.SetKeyName(2, "ProcessAll")
            Me.ilViewS.Images.SetKeyName(3, "Edit")
            Me.ilViewS.Images.SetKeyName(4, "Warnings")
            Me.ilViewS.Images.SetKeyName(5, "Errors")
            Me.ilViewS.Images.SetKeyName(6, "ViewWarnings")
            Me.ilViewS.Images.SetKeyName(7, "Delete")
            Me.ilViewS.Images.SetKeyName(8, "Completed")
            '
            '_Toolbar_Button1
            '
            Me._Toolbar_Button1.AutoSize = False
            Me._Toolbar_Button1.Image = Global.learnAid.My.Resources.Resources.new1
            Me._Toolbar_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me._Toolbar_Button1.Name = "_Toolbar_Button1"
            Me._Toolbar_Button1.Size = New System.Drawing.Size(19, 18)
            Me._Toolbar_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me._Toolbar_Button1.ToolTipText = "New Job"
            '
            '_Toolbar_Button2
            '
            Me._Toolbar_Button2.AutoSize = False
            Me._Toolbar_Button2.Image = Global.learnAid.My.Resources.Resources.edit_job
            Me._Toolbar_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me._Toolbar_Button2.Name = "_Toolbar_Button2"
            Me._Toolbar_Button2.Size = New System.Drawing.Size(19, 18)
            Me._Toolbar_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me._Toolbar_Button2.ToolTipText = "Edit Job"
            '
            '_Toolbar_Button3
            '
            Me._Toolbar_Button3.AutoSize = False
            Me._Toolbar_Button3.Image = Global.learnAid.My.Resources.Resources.delete
            Me._Toolbar_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me._Toolbar_Button3.Name = "_Toolbar_Button3"
            Me._Toolbar_Button3.Size = New System.Drawing.Size(19, 18)
            Me._Toolbar_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me._Toolbar_Button3.ToolTipText = "Delete Job"
            '
            '_Toolbar_Button4
            '
            Me._Toolbar_Button4.AutoSize = False
            Me._Toolbar_Button4.ImageKey = "Warnings"
            Me._Toolbar_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me._Toolbar_Button4.Name = "_Toolbar_Button4"
            Me._Toolbar_Button4.Size = New System.Drawing.Size(19, 18)
            Me._Toolbar_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me._Toolbar_Button4.ToolTipText = "View Warnings"
            '
            '_Toolbar_Button5
            '
            Me._Toolbar_Button5.AutoSize = False
            Me._Toolbar_Button5.Name = "_Toolbar_Button5"
            Me._Toolbar_Button5.Size = New System.Drawing.Size(19, 18)
            '
            '_Toolbar_Button6
            '
            Me._Toolbar_Button6.AutoSize = False
            Me._Toolbar_Button6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._Toolbar_Button6_ButtonMenu1, Me._Toolbar_Button6_ButtonMenu2, Me._Toolbar_Button6_ButtonMenu3, Me._Toolbar_Button6_ButtonMenu4, Me._Toolbar_Button6_ButtonMenu5})
            Me._Toolbar_Button6.ImageKey = "Process"
            Me._Toolbar_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me._Toolbar_Button6.Name = "_Toolbar_Button6"
            Me._Toolbar_Button6.Size = New System.Drawing.Size(32, 18)
            Me._Toolbar_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me._Toolbar_Button6.ToolTipText = "Process"
            '
            '_Toolbar_Button6_ButtonMenu1
            '
            Me._Toolbar_Button6_ButtonMenu1.Name = "_Toolbar_Button6_ButtonMenu1"
            Me._Toolbar_Button6_ButtonMenu1.Size = New System.Drawing.Size(188, 24)
            Me._Toolbar_Button6_ButtonMenu1.Text = "Scan"
            '
            '_Toolbar_Button6_ButtonMenu2
            '
            Me._Toolbar_Button6_ButtonMenu2.Name = "_Toolbar_Button6_ButtonMenu2"
            Me._Toolbar_Button6_ButtonMenu2.Size = New System.Drawing.Size(188, 24)
            Me._Toolbar_Button6_ButtonMenu2.Text = "Evaluate"
            '
            '_Toolbar_Button6_ButtonMenu3
            '
            Me._Toolbar_Button6_ButtonMenu3.Name = "_Toolbar_Button6_ButtonMenu3"
            Me._Toolbar_Button6_ButtonMenu3.Size = New System.Drawing.Size(188, 24)
            Me._Toolbar_Button6_ButtonMenu3.Text = "New Scan"
            '
            '_Toolbar_Button6_ButtonMenu4
            '
            Me._Toolbar_Button6_ButtonMenu4.Name = "_Toolbar_Button6_ButtonMenu4"
            Me._Toolbar_Button6_ButtonMenu4.Size = New System.Drawing.Size(188, 24)
            Me._Toolbar_Button6_ButtonMenu4.Text = "New Scan Orden"
            '
            '_Toolbar_Button6_ButtonMenu5
            '
            Me._Toolbar_Button6_ButtonMenu5.Name = "_Toolbar_Button6_ButtonMenu5"
            Me._Toolbar_Button6_ButtonMenu5.Size = New System.Drawing.Size(188, 24)
            Me._Toolbar_Button6_ButtonMenu5.Text = "ReScan"
            '
            '_Toolbar_Button7
            '
            Me._Toolbar_Button7.AutoSize = False
            Me._Toolbar_Button7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._Toolbar_Button7_ButtonMenu1, Me._Toolbar_Button7_ButtonMenu2})
            Me._Toolbar_Button7.ImageKey = "ProcessAll"
            Me._Toolbar_Button7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me._Toolbar_Button7.Name = "_Toolbar_Button7"
            Me._Toolbar_Button7.Size = New System.Drawing.Size(32, 18)
            Me._Toolbar_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me._Toolbar_Button7.ToolTipText = "Process All"
            '
            '_Toolbar_Button7_ButtonMenu1
            '
            Me._Toolbar_Button7_ButtonMenu1.Name = "_Toolbar_Button7_ButtonMenu1"
            Me._Toolbar_Button7_ButtonMenu1.Size = New System.Drawing.Size(134, 24)
            Me._Toolbar_Button7_ButtonMenu1.Text = "Scan"
            '
            '_Toolbar_Button7_ButtonMenu2
            '
            Me._Toolbar_Button7_ButtonMenu2.Name = "_Toolbar_Button7_ButtonMenu2"
            Me._Toolbar_Button7_ButtonMenu2.Size = New System.Drawing.Size(134, 24)
            Me._Toolbar_Button7_ButtonMenu2.Text = "Evaluate"
            '
            'ilColumHeaders
            '
            Me.ilColumHeaders.ImageStream = CType(resources.GetObject("ilColumHeaders.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ilColumHeaders.TransparentColor = System.Drawing.Color.White
            Me.ilColumHeaders.Images.SetKeyName(0, "Down")
            Me.ilColumHeaders.Images.SetKeyName(1, "Up")
            '
            'tmrUpdateJobs
            '
            Me.tmrUpdateJobs.Enabled = True
            Me.tmrUpdateJobs.Interval = 15000
            '
            'lvJobs
            '
            Me.lvJobs.AllowColumnReorder = True
            Me.lvJobs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lvJobs.BackColor = System.Drawing.SystemColors.Window
            Me.lvJobs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lvJobs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvJobs_ColumnHeader_1, Me._lvJobs_ColumnHeader_2, Me._lvJobs_ColumnHeader_3, Me._lvJobs_ColumnHeader_4, Me._lvJobs_ColumnHeader_5, Me._lvJobs_ColumnHeader_6, Me._lvJobs_ColumnHeader_7, Me._lvJobs_ColumnHeader_8, Me._lvJobs_ColumnHeader_9, Me._lvJobs_ColumnHeader_10})
            Me.lvJobs.ContextMenuStrip = Me.ContextMenuStrip
            Me.lvJobs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lvJobs.ForeColor = System.Drawing.SystemColors.WindowText
            Me.lvJobs.FullRowSelect = True
            Me.lvJobs.GridLines = True
            Me.lvJobs.HideSelection = False
            Me.lvJobs.LargeImageList = Me.ilViewS
            Me.lvJobs.Location = New System.Drawing.Point(0, 31)
            Me.lvJobs.Name = "lvJobs"
            Me.lvJobs.Size = New System.Drawing.Size(534, 430)
            Me.lvJobs.SmallImageList = Me.ilViewS
            Me.lvJobs.TabIndex = 0
            Me.lvJobs.UseCompatibleStateImageBehavior = False
            Me.lvJobs.View = System.Windows.Forms.View.Details
            '
            '_lvJobs_ColumnHeader_1
            '
            Me._lvJobs_ColumnHeader_1.Text = ""
            Me._lvJobs_ColumnHeader_1.Width = 34
            '
            '_lvJobs_ColumnHeader_2
            '
            Me._lvJobs_ColumnHeader_2.Text = "School"
            Me._lvJobs_ColumnHeader_2.Width = 142
            '
            '_lvJobs_ColumnHeader_3
            '
            Me._lvJobs_ColumnHeader_3.Text = "Grade"
            Me._lvJobs_ColumnHeader_3.Width = 118
            '
            '_lvJobs_ColumnHeader_4
            '
            Me._lvJobs_ColumnHeader_4.Text = "Section"
            Me._lvJobs_ColumnHeader_4.Width = 118
            '
            '_lvJobs_ColumnHeader_5
            '
            Me._lvJobs_ColumnHeader_5.Text = "Semester"
            Me._lvJobs_ColumnHeader_5.Width = 142
            '
            '_lvJobs_ColumnHeader_6
            '
            Me._lvJobs_ColumnHeader_6.Text = "Date"
            Me._lvJobs_ColumnHeader_6.Width = 118
            '
            '_lvJobs_ColumnHeader_7
            '
            Me._lvJobs_ColumnHeader_7.Text = "Job Status"
            Me._lvJobs_ColumnHeader_7.Width = 118
            '
            '_lvJobs_ColumnHeader_8
            '
            Me._lvJobs_ColumnHeader_8.Text = "Process Status"
            Me._lvJobs_ColumnHeader_8.Width = 170
            '
            '_lvJobs_ColumnHeader_9
            '
            Me._lvJobs_ColumnHeader_9.Text = "Warnings"
            Me._lvJobs_ColumnHeader_9.Width = 170
            '
            '_lvJobs_ColumnHeader_10
            '
            Me._lvJobs_ColumnHeader_10.Text = "Pending"
            Me._lvJobs_ColumnHeader_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me._lvJobs_ColumnHeader_10.Width = 170
            '
            'ContextMenuStrip
            '
            Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewJobToolStripMenuItem, Me.EditJobToolStripMenuItem, Me.DeleteJobToolStripMenuItem, Me.ToolStripSeparator2, Me.ResetJobToolStripMenuItem, Me.ClearJobToolStripMenuItem, Me.ViewWarningsToolStripMenuItem, Me.ViewEditStudentToolStripMenuItem})
            Me.ContextMenuStrip.Name = "ContextMenuStrip"
            Me.ContextMenuStrip.Size = New System.Drawing.Size(224, 178)
            '
            'NewJobToolStripMenuItem
            '
            Me.NewJobToolStripMenuItem.Name = "NewJobToolStripMenuItem"
            Me.NewJobToolStripMenuItem.Size = New System.Drawing.Size(223, 24)
            Me.NewJobToolStripMenuItem.Text = "New Job"
            '
            'EditJobToolStripMenuItem
            '
            Me.EditJobToolStripMenuItem.Name = "EditJobToolStripMenuItem"
            Me.EditJobToolStripMenuItem.Size = New System.Drawing.Size(223, 24)
            Me.EditJobToolStripMenuItem.Text = "Edit Job"
            '
            'DeleteJobToolStripMenuItem
            '
            Me.DeleteJobToolStripMenuItem.Name = "DeleteJobToolStripMenuItem"
            Me.DeleteJobToolStripMenuItem.Size = New System.Drawing.Size(223, 24)
            Me.DeleteJobToolStripMenuItem.Text = "Delete Job"
            '
            'ToolStripSeparator2
            '
            Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
            Me.ToolStripSeparator2.Size = New System.Drawing.Size(220, 6)
            '
            'ResetJobToolStripMenuItem
            '
            Me.ResetJobToolStripMenuItem.Name = "ResetJobToolStripMenuItem"
            Me.ResetJobToolStripMenuItem.Size = New System.Drawing.Size(223, 24)
            Me.ResetJobToolStripMenuItem.Text = "Reset Job"
            '
            'ClearJobToolStripMenuItem
            '
            Me.ClearJobToolStripMenuItem.Name = "ClearJobToolStripMenuItem"
            Me.ClearJobToolStripMenuItem.Size = New System.Drawing.Size(223, 24)
            Me.ClearJobToolStripMenuItem.Text = "Copy Job"
            '
            'ViewWarningsToolStripMenuItem
            '
            Me.ViewWarningsToolStripMenuItem.Name = "ViewWarningsToolStripMenuItem"
            Me.ViewWarningsToolStripMenuItem.Size = New System.Drawing.Size(223, 24)
            Me.ViewWarningsToolStripMenuItem.Text = "View Warnings"
            '
            'ViewEditStudentToolStripMenuItem
            '
            Me.ViewEditStudentToolStripMenuItem.Name = "ViewEditStudentToolStripMenuItem"
            Me.ViewEditStudentToolStripMenuItem.Size = New System.Drawing.Size(223, 24)
            Me.ViewEditStudentToolStripMenuItem.Text = "View/Edit Student List"
            '
            'Toolbar
            '
            Me.Toolbar.Dock = System.Windows.Forms.DockStyle.None
            Me.Toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.Toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnEdit, Me.btnDelete, Me.VWarnings, Me.ToolStripSeparator1, Me.ToolStripDropDownButton1, Me.ToolStripDropDownButton2})
            Me.Toolbar.Location = New System.Drawing.Point(1, 3)
            Me.Toolbar.Name = "Toolbar"
            Me.Toolbar.Size = New System.Drawing.Size(165, 25)
            Me.Toolbar.TabIndex = 4
            Me.Toolbar.Text = "ToolStrip1"
            '
            'btnNew
            '
            Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnNew.Image = Global.learnAid.My.Resources.Resources.new1
            Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnNew.Name = "btnNew"
            Me.btnNew.Size = New System.Drawing.Size(23, 22)
            Me.btnNew.Text = "New"
            '
            'btnEdit
            '
            Me.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnEdit.Image = Global.learnAid.My.Resources.Resources.edit_job
            Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnEdit.Name = "btnEdit"
            Me.btnEdit.Size = New System.Drawing.Size(23, 22)
            Me.btnEdit.Text = "Edit"
            '
            'btnDelete
            '
            Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnDelete.Image = Global.learnAid.My.Resources.Resources.delete
            Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Size = New System.Drawing.Size(23, 22)
            Me.btnDelete.Text = "Delete"
            '
            'VWarnings
            '
            Me.VWarnings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.VWarnings.Image = Global.learnAid.My.Resources.Resources.warning
            Me.VWarnings.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.VWarnings.Name = "VWarnings"
            Me.VWarnings.Size = New System.Drawing.Size(23, 22)
            Me.VWarnings.Text = "Warning"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
            '
            'ToolStripDropDownButton1
            '
            Me.ToolStripDropDownButton1.AutoSize = False
            Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuScan, Me.mnuEvaluate, Me.mnuNewScan, Me.mnuOrdenScan, Me.mnuReScan})
            Me.ToolStripDropDownButton1.Image = Global.learnAid.My.Resources.Resources.Process
            Me.ToolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
            Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(32, 18)
            Me.ToolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.ToolStripDropDownButton1.ToolTipText = "Process"
            '
            'mnuScan
            '
            Me.mnuScan.Name = "mnuScan"
            Me.mnuScan.Size = New System.Drawing.Size(188, 24)
            Me.mnuScan.Text = "Scan"
            '
            'mnuEvaluate
            '
            Me.mnuEvaluate.Name = "mnuEvaluate"
            Me.mnuEvaluate.Size = New System.Drawing.Size(188, 24)
            Me.mnuEvaluate.Text = "Evaluate"
            '
            'mnuNewScan
            '
            Me.mnuNewScan.Name = "mnuNewScan"
            Me.mnuNewScan.Size = New System.Drawing.Size(188, 24)
            Me.mnuNewScan.Text = "New Scan"
            '
            'mnuOrdenScan
            '
            Me.mnuOrdenScan.Name = "mnuOrdenScan"
            Me.mnuOrdenScan.Size = New System.Drawing.Size(188, 24)
            Me.mnuOrdenScan.Text = "New Scan Orden"
            '
            'mnuReScan
            '
            Me.mnuReScan.Name = "mnuReScan"
            Me.mnuReScan.Size = New System.Drawing.Size(188, 24)
            Me.mnuReScan.Text = "ReScan"
            '
            'ToolStripDropDownButton2
            '
            Me.ToolStripDropDownButton2.AutoSize = False
            Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRScan, Me.mnuREvaluate})
            Me.ToolStripDropDownButton2.Image = Global.learnAid.My.Resources.Resources.ProcessAll
            Me.ToolStripDropDownButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
            Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(32, 18)
            Me.ToolStripDropDownButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.ToolStripDropDownButton2.ToolTipText = "Process All"
            '
            'mnuRScan
            '
            Me.mnuRScan.Name = "mnuRScan"
            Me.mnuRScan.Size = New System.Drawing.Size(134, 24)
            Me.mnuRScan.Text = "Scan"
            '
            'mnuREvaluate
            '
            Me.mnuREvaluate.Name = "mnuREvaluate"
            Me.mnuREvaluate.Size = New System.Drawing.Size(134, 24)
            Me.mnuREvaluate.Text = "Evaluate"
            '
            'btnAll
            '
            Me.btnAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnAll.Appearance = System.Windows.Forms.Appearance.Button
            Me.btnAll.AutoSize = True
            Me.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAll.Location = New System.Drawing.Point(1, 459)
            Me.btnAll.Name = "btnAll"
            Me.btnAll.Size = New System.Drawing.Size(32, 29)
            Me.btnAll.TabIndex = 5
            Me.btnAll.TabStop = True
            Me.btnAll.Text = "All"
            Me.btnAll.UseVisualStyleBackColor = True
            '
            'btnPending
            '
            Me.btnPending.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnPending.Appearance = System.Windows.Forms.Appearance.Button
            Me.btnPending.AutoSize = True
            Me.btnPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPending.Location = New System.Drawing.Point(96, 459)
            Me.btnPending.Name = "btnPending"
            Me.btnPending.Size = New System.Drawing.Size(69, 29)
            Me.btnPending.TabIndex = 5
            Me.btnPending.TabStop = True
            Me.btnPending.Text = "Pending"
            Me.btnPending.UseVisualStyleBackColor = True
            '
            'btnMyJobs
            '
            Me.btnMyJobs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnMyJobs.Appearance = System.Windows.Forms.Appearance.Button
            Me.btnMyJobs.AutoSize = True
            Me.btnMyJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnMyJobs.Location = New System.Drawing.Point(33, 459)
            Me.btnMyJobs.Name = "btnMyJobs"
            Me.btnMyJobs.Size = New System.Drawing.Size(70, 29)
            Me.btnMyJobs.TabIndex = 5
            Me.btnMyJobs.TabStop = True
            Me.btnMyJobs.Text = "My Jobs"
            Me.btnMyJobs.UseVisualStyleBackColor = True
            '
            'updateResEstbtn
            '
            Me.updateResEstbtn.Location = New System.Drawing.Point(393, 2)
            Me.updateResEstbtn.Name = "updateResEstbtn"
            Me.updateResEstbtn.Size = New System.Drawing.Size(129, 23)
            Me.updateResEstbtn.TabIndex = 6
            Me.updateResEstbtn.Text = "Update ResEst"
            Me.updateResEstbtn.UseVisualStyleBackColor = True
            '
            'frmJobsView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.ClientSize = New System.Drawing.Size(534, 490)
            Me.ControlBox = False
            Me.Controls.Add(Me.updateResEstbtn)
            Me.Controls.Add(Me.btnPending)
            Me.Controls.Add(Me.btnMyJobs)
            Me.Controls.Add(Me.btnAll)
            Me.Controls.Add(Me.Toolbar)
            Me.Controls.Add(Me.lvJobs)
            Me.Controls.Add(Me.Toolbar1)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Tahoma", 8.4!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Location = New System.Drawing.Point(4, 24)
            Me.Name = "frmJobsView"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
            Me.Text = "Evaluation"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.Toolbar1.ResumeLayout(False)
            Me.Toolbar1.PerformLayout()
            Me.ContextMenuStrip.ResumeLayout(False)
            Me.Toolbar.ResumeLayout(False)
            Me.Toolbar.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents ContextMenuStrip As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents Toolbar As System.Windows.Forms.ToolStrip
        Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
        Friend WithEvents VWarnings As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Public WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
        Public WithEvents mnuScan As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents mnuEvaluate As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents mnuNewScan As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents mnuOrdenScan As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents mnuReScan As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents ToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
        Public WithEvents mnuRScan As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents mnuREvaluate As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents NewJobToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents EditJobToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents DeleteJobToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents ResetJobToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ViewWarningsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ViewEditStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents btnAll As System.Windows.Forms.RadioButton
        Friend WithEvents btnPending As System.Windows.Forms.RadioButton
        Friend WithEvents btnMyJobs As System.Windows.Forms.RadioButton
        Friend WithEvents ClearJobToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents updateResEstbtn As System.Windows.Forms.Button
#End Region
    End Class
End Namespace