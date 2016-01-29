<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep0011 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEvaluations = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAccounting = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep0023 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuViewButtonPanel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewSchools = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewConsultants = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewProperties = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClaves = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditClaves = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpUsersManual = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCreateReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRegularReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOfficeTestingReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEntranceReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuJobsRmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewJob = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditJob = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteJob = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep001 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuResetJob = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopyJob = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVWarnings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStudentList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRep_RMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuResetRep = New System.Windows.Forms.ToolStripMenuItem()
        Me.CDPrint = New System.Windows.Forms.PrintDialog()
        Me.CDOpen = New System.Windows.Forms.OpenFileDialog()
        Me.CDSave = New System.Windows.Forms.SaveFileDialog()
        Me.CDFont = New System.Windows.Forms.FontDialog()
        Me.CDColor = New System.Windows.Forms.ColorDialog()
        Me.ilToolbar = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me._StatusBar_Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me._StatusBar_Panel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Toolbar = New System.Windows.Forms.ToolStrip()
        Me.Options = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar_Button2 = New System.Windows.Forms.ToolStripSeparator()
        Me._Toolbar_Button3 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar_Button4 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar_Button5 = New System.Windows.Forms.ToolStripButton()
        Me._Toolbar_Button6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.panelLeft = New System.Windows.Forms.Panel()
        Me.rbConsultants = New System.Windows.Forms.RadioButton()
        Me.rbStudents = New System.Windows.Forms.RadioButton()
        Me.rbReport = New System.Windows.Forms.RadioButton()
        Me.rbAccounting = New System.Windows.Forms.RadioButton()
        Me.rbEvaluation = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelRight = New System.Windows.Forms.Panel()
        Me.MainMenu1.SuspendLayout()
        Me.StatusBar.SuspendLayout()
        Me.Toolbar.SuspendLayout()
        Me.panelLeft.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuView, Me.mnuTools, Me.mnuHelp, Me.mnuCreateReports, Me.mnuJobsRmenu, Me.mnuRep_RMenu})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MainMenu1.Size = New System.Drawing.Size(1344, 28)
        Me.MainMenu1.TabIndex = 3
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogout, Me.mnuSep0011, Me.mnuExit})
        Me.mnuFile.MergeAction = System.Windows.Forms.MergeAction.Remove
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(44, 24)
        Me.mnuFile.Text = "&File"
        '
        'mnuLogout
        '
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(129, 24)
        Me.mnuLogout.Text = "Log out"
        '
        'mnuSep0011
        '
        Me.mnuSep0011.Name = "mnuSep0011"
        Me.mnuSep0011.Size = New System.Drawing.Size(126, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(129, 24)
        Me.mnuExit.Text = "&Exit"
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHome, Me.mnuEvaluations, Me.mnuAccounting, Me.mnuReports, Me.mnuSep0023, Me.mnuViewButtonPanel, Me.mnuViewSchools, Me.mnuViewConsultants, Me.mnuViewProperties})
        Me.mnuView.MergeAction = System.Windows.Forms.MergeAction.Remove
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(53, 24)
        Me.mnuView.Text = "View"
        '
        'mnuHome
        '
        Me.mnuHome.Name = "mnuHome"
        Me.mnuHome.Size = New System.Drawing.Size(202, 24)
        Me.mnuHome.Text = "Home"
        '
        'mnuEvaluations
        '
        Me.mnuEvaluations.Name = "mnuEvaluations"
        Me.mnuEvaluations.Size = New System.Drawing.Size(202, 24)
        Me.mnuEvaluations.Text = "Evaluations"
        '
        'mnuAccounting
        '
        Me.mnuAccounting.Name = "mnuAccounting"
        Me.mnuAccounting.Size = New System.Drawing.Size(202, 24)
        Me.mnuAccounting.Text = "Accounting"
        '
        'mnuReports
        '
        Me.mnuReports.Name = "mnuReports"
        Me.mnuReports.Size = New System.Drawing.Size(202, 24)
        Me.mnuReports.Text = "Reports"
        '
        'mnuSep0023
        '
        Me.mnuSep0023.Name = "mnuSep0023"
        Me.mnuSep0023.Size = New System.Drawing.Size(199, 6)
        '
        'mnuViewButtonPanel
        '
        Me.mnuViewButtonPanel.Checked = True
        Me.mnuViewButtonPanel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuViewButtonPanel.Name = "mnuViewButtonPanel"
        Me.mnuViewButtonPanel.Size = New System.Drawing.Size(202, 24)
        Me.mnuViewButtonPanel.Text = "Show Button Panel"
        '
        'mnuViewSchools
        '
        Me.mnuViewSchools.Name = "mnuViewSchools"
        Me.mnuViewSchools.Size = New System.Drawing.Size(202, 24)
        Me.mnuViewSchools.Text = "Show Schools"
        '
        'mnuViewConsultants
        '
        Me.mnuViewConsultants.Name = "mnuViewConsultants"
        Me.mnuViewConsultants.Size = New System.Drawing.Size(202, 24)
        Me.mnuViewConsultants.Text = "Show Consultants"
        '
        'mnuViewProperties
        '
        Me.mnuViewProperties.Checked = True
        Me.mnuViewProperties.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuViewProperties.Name = "mnuViewProperties"
        Me.mnuViewProperties.Size = New System.Drawing.Size(202, 24)
        Me.mnuViewProperties.Text = "Show Properties"
        '
        'mnuTools
        '
        Me.mnuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClaves, Me.mnuUsers, Me.mnuOptions, Me.mnuEditClaves})
        Me.mnuTools.MergeAction = System.Windows.Forms.MergeAction.Remove
        Me.mnuTools.Name = "mnuTools"
        Me.mnuTools.Size = New System.Drawing.Size(57, 24)
        Me.mnuTools.Text = "&Tools"
        '
        'mnuClaves
        '
        Me.mnuClaves.Name = "mnuClaves"
        Me.mnuClaves.Size = New System.Drawing.Size(174, 24)
        Me.mnuClaves.Text = "&Change Claves"
        '
        'mnuUsers
        '
        Me.mnuUsers.Name = "mnuUsers"
        Me.mnuUsers.Size = New System.Drawing.Size(174, 24)
        Me.mnuUsers.Text = "&User Accounts"
        '
        'mnuOptions
        '
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(174, 24)
        Me.mnuOptions.Text = "&Options..."
        '
        'mnuEditClaves
        '
        Me.mnuEditClaves.Name = "mnuEditClaves"
        Me.mnuEditClaves.Size = New System.Drawing.Size(174, 24)
        Me.mnuEditClaves.Text = "Edit Claves"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpUsersManual, Me.mnuHelpAbout})
        Me.mnuHelp.MergeAction = System.Windows.Forms.MergeAction.Remove
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(53, 24)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpUsersManual
        '
        Me.mnuHelpUsersManual.Name = "mnuHelpUsersManual"
        Me.mnuHelpUsersManual.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuHelpUsersManual.Size = New System.Drawing.Size(190, 24)
        Me.mnuHelpUsersManual.Text = "&Users Manual"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(190, 24)
        Me.mnuHelpAbout.Text = "&About..."
        '
        'mnuCreateReports
        '
        Me.mnuCreateReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRegularReport, Me.mnuOfficeTestingReport, Me.mnuEntranceReport})
        Me.mnuCreateReports.MergeAction = System.Windows.Forms.MergeAction.Remove
        Me.mnuCreateReports.Name = "mnuCreateReports"
        Me.mnuCreateReports.Size = New System.Drawing.Size(72, 24)
        Me.mnuCreateReports.Text = "&Reports"
        Me.mnuCreateReports.Visible = False
        '
        'mnuRegularReport
        '
        Me.mnuRegularReport.Name = "mnuRegularReport"
        Me.mnuRegularReport.Size = New System.Drawing.Size(266, 24)
        Me.mnuRegularReport.Text = "Create Regular Report"
        '
        'mnuOfficeTestingReport
        '
        Me.mnuOfficeTestingReport.Name = "mnuOfficeTestingReport"
        Me.mnuOfficeTestingReport.Size = New System.Drawing.Size(266, 24)
        Me.mnuOfficeTestingReport.Text = "Create Office Testing Report"
        '
        'mnuEntranceReport
        '
        Me.mnuEntranceReport.Name = "mnuEntranceReport"
        Me.mnuEntranceReport.Size = New System.Drawing.Size(266, 24)
        Me.mnuEntranceReport.Text = "Create Entrance Report"
        '
        'mnuJobsRmenu
        '
        Me.mnuJobsRmenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewJob, Me.mnuEditJob, Me.mnuDeleteJob, Me.mnuSep001, Me.mnuResetJob, Me.mnuCopyJob, Me.mnuVWarnings, Me.mnuStudentList})
        Me.mnuJobsRmenu.Enabled = False
        Me.mnuJobsRmenu.MergeAction = System.Windows.Forms.MergeAction.Remove
        Me.mnuJobsRmenu.Name = "mnuJobsRmenu"
        Me.mnuJobsRmenu.Size = New System.Drawing.Size(67, 24)
        Me.mnuJobsRmenu.Text = "RMenu"
        Me.mnuJobsRmenu.Visible = False
        '
        'mnuNewJob
        '
        Me.mnuNewJob.Name = "mnuNewJob"
        Me.mnuNewJob.Size = New System.Drawing.Size(223, 24)
        Me.mnuNewJob.Text = "New Job"
        '
        'mnuEditJob
        '
        Me.mnuEditJob.Name = "mnuEditJob"
        Me.mnuEditJob.Size = New System.Drawing.Size(223, 24)
        Me.mnuEditJob.Text = "Edit Job"
        '
        'mnuDeleteJob
        '
        Me.mnuDeleteJob.Name = "mnuDeleteJob"
        Me.mnuDeleteJob.Size = New System.Drawing.Size(223, 24)
        Me.mnuDeleteJob.Text = "Delete Job"
        '
        'mnuSep001
        '
        Me.mnuSep001.Name = "mnuSep001"
        Me.mnuSep001.Size = New System.Drawing.Size(220, 6)
        '
        'mnuResetJob
        '
        Me.mnuResetJob.Name = "mnuResetJob"
        Me.mnuResetJob.Size = New System.Drawing.Size(223, 24)
        Me.mnuResetJob.Text = "Reset Job"
        '
        'mnuCopyJob
        '
        Me.mnuCopyJob.Name = "mnuCopyJob"
        Me.mnuCopyJob.Size = New System.Drawing.Size(223, 24)
        Me.mnuCopyJob.Text = "Copy Job"
        '
        'mnuVWarnings
        '
        Me.mnuVWarnings.Name = "mnuVWarnings"
        Me.mnuVWarnings.Size = New System.Drawing.Size(223, 24)
        Me.mnuVWarnings.Text = "View Warnings"
        '
        'mnuStudentList
        '
        Me.mnuStudentList.Name = "mnuStudentList"
        Me.mnuStudentList.Size = New System.Drawing.Size(223, 24)
        Me.mnuStudentList.Text = "View/Edit Student List"
        '
        'mnuRep_RMenu
        '
        Me.mnuRep_RMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuResetRep})
        Me.mnuRep_RMenu.MergeAction = System.Windows.Forms.MergeAction.Remove
        Me.mnuRep_RMenu.Name = "mnuRep_RMenu"
        Me.mnuRep_RMenu.Size = New System.Drawing.Size(103, 24)
        Me.mnuRep_RMenu.Text = "REP_RMENU"
        Me.mnuRep_RMenu.Visible = False
        '
        'mnuResetRep
        '
        Me.mnuResetRep.Name = "mnuResetRep"
        Me.mnuResetRep.Size = New System.Drawing.Size(171, 24)
        Me.mnuResetRep.Text = "Delete Report"
        '
        'CDFont
        '
        Me.CDFont.Color = System.Drawing.SystemColors.ControlText
        '
        'ilToolbar
        '
        Me.ilToolbar.ImageStream = CType(resources.GetObject("ilToolbar.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilToolbar.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ilToolbar.Images.SetKeyName(0, "School")
        Me.ilToolbar.Images.SetKeyName(1, "Consultant")
        Me.ilToolbar.Images.SetKeyName(2, "Options")
        Me.ilToolbar.Images.SetKeyName(3, "Properties")
        Me.ilToolbar.Images.SetKeyName(4, "ButtonPanel")
        '
        'StatusBar
        '
        Me.StatusBar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._StatusBar_Panel1, Me._StatusBar_Panel2})
        Me.StatusBar.Location = New System.Drawing.Point(0, 873)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusBar.Size = New System.Drawing.Size(1344, 25)
        Me.StatusBar.TabIndex = 6
        '
        '_StatusBar_Panel1
        '
        Me._StatusBar_Panel1.AutoSize = False
        Me._StatusBar_Panel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me._StatusBar_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me._StatusBar_Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me._StatusBar_Panel1.Name = "_StatusBar_Panel1"
        Me._StatusBar_Panel1.Size = New System.Drawing.Size(110, 25)
        Me._StatusBar_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_StatusBar_Panel2
        '
        Me._StatusBar_Panel2.AutoSize = False
        Me._StatusBar_Panel2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me._StatusBar_Panel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me._StatusBar_Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me._StatusBar_Panel2.Name = "_StatusBar_Panel2"
        Me._StatusBar_Panel2.Size = New System.Drawing.Size(1214, 25)
        Me._StatusBar_Panel2.Spring = True
        Me._StatusBar_Panel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Toolbar
        '
        Me.Toolbar.CanOverflow = False
        Me.Toolbar.ImageList = Me.ilToolbar
        Me.Toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Options, Me._Toolbar_Button2, Me._Toolbar_Button3, Me._Toolbar_Button4, Me._Toolbar_Button5, Me._Toolbar_Button6})
        Me.Toolbar.Location = New System.Drawing.Point(0, 28)
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.Size = New System.Drawing.Size(1344, 25)
        Me.Toolbar.TabIndex = 5
        '
        'Options
        '
        Me.Options.AutoSize = False
        Me.Options.ImageKey = "Options"
        Me.Options.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Options.Name = "Options"
        Me.Options.Size = New System.Drawing.Size(19, 18)
        Me.Options.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Options.ToolTipText = "Options"
        '
        '_Toolbar_Button2
        '
        Me._Toolbar_Button2.AutoSize = False
        Me._Toolbar_Button2.Name = "_Toolbar_Button2"
        Me._Toolbar_Button2.Size = New System.Drawing.Size(10, 18)
        '
        '_Toolbar_Button3
        '
        Me._Toolbar_Button3.AutoSize = False
        Me._Toolbar_Button3.CheckOnClick = True
        Me._Toolbar_Button3.ImageKey = "School"
        Me._Toolbar_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar_Button3.Name = "_Toolbar_Button3"
        Me._Toolbar_Button3.Size = New System.Drawing.Size(19, 18)
        Me._Toolbar_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Toolbar_Button3.ToolTipText = "Show\Hide Schools Window"
        '
        '_Toolbar_Button4
        '
        Me._Toolbar_Button4.AutoSize = False
        Me._Toolbar_Button4.CheckOnClick = True
        Me._Toolbar_Button4.ImageKey = "Consultant"
        Me._Toolbar_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar_Button4.Name = "_Toolbar_Button4"
        Me._Toolbar_Button4.Size = New System.Drawing.Size(19, 18)
        Me._Toolbar_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Toolbar_Button4.ToolTipText = "Show the Examiners window"
        '
        '_Toolbar_Button5
        '
        Me._Toolbar_Button5.AutoSize = False
        Me._Toolbar_Button5.Checked = True
        Me._Toolbar_Button5.CheckOnClick = True
        Me._Toolbar_Button5.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Toolbar_Button5.ImageKey = "Properties"
        Me._Toolbar_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar_Button5.Name = "_Toolbar_Button5"
        Me._Toolbar_Button5.Size = New System.Drawing.Size(19, 18)
        Me._Toolbar_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Toolbar_Button5.ToolTipText = "Show the Properties window"
        '
        '_Toolbar_Button6
        '
        Me._Toolbar_Button6.AutoSize = False
        Me._Toolbar_Button6.Checked = True
        Me._Toolbar_Button6.CheckOnClick = True
        Me._Toolbar_Button6.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Toolbar_Button6.ImageKey = "ButtonPanel"
        Me._Toolbar_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me._Toolbar_Button6.Name = "_Toolbar_Button6"
        Me._Toolbar_Button6.Size = New System.Drawing.Size(19, 18)
        Me._Toolbar_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me._Toolbar_Button6.ToolTipText = "Show the Button panel"
        '
        'panelLeft
        '
        Me.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelLeft.Controls.Add(Me.rbConsultants)
        Me.panelLeft.Controls.Add(Me.rbStudents)
        Me.panelLeft.Controls.Add(Me.rbReport)
        Me.panelLeft.Controls.Add(Me.rbAccounting)
        Me.panelLeft.Controls.Add(Me.rbEvaluation)
        Me.panelLeft.Controls.Add(Me.Label1)
        Me.panelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelLeft.Location = New System.Drawing.Point(0, 53)
        Me.panelLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.panelLeft.Name = "panelLeft"
        Me.panelLeft.Size = New System.Drawing.Size(125, 820)
        Me.panelLeft.TabIndex = 10
        '
        'rbConsultants
        '
        Me.rbConsultants.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbConsultants.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbConsultants.Image = Global.learnAid.My.Resources.Resources.user_321
        Me.rbConsultants.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rbConsultants.Location = New System.Drawing.Point(3, 234)
        Me.rbConsultants.Margin = New System.Windows.Forms.Padding(4)
        Me.rbConsultants.Name = "rbConsultants"
        Me.rbConsultants.Size = New System.Drawing.Size(116, 66)
        Me.rbConsultants.TabIndex = 1
        Me.rbConsultants.Text = "Consultants"
        Me.rbConsultants.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbConsultants.UseVisualStyleBackColor = True
        '
        'rbStudents
        '
        Me.rbStudents.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbStudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbStudents.Image = Global.learnAid.My.Resources.Resources.search_32
        Me.rbStudents.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rbStudents.Location = New System.Drawing.Point(3, 302)
        Me.rbStudents.Margin = New System.Windows.Forms.Padding(4)
        Me.rbStudents.Name = "rbStudents"
        Me.rbStudents.Size = New System.Drawing.Size(116, 66)
        Me.rbStudents.TabIndex = 1
        Me.rbStudents.Text = "Students"
        Me.rbStudents.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbStudents.UseVisualStyleBackColor = True
        '
        'rbReport
        '
        Me.rbReport.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbReport.Image = Global.learnAid.My.Resources.Resources.print_32
        Me.rbReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rbReport.Location = New System.Drawing.Point(3, 166)
        Me.rbReport.Margin = New System.Windows.Forms.Padding(4)
        Me.rbReport.Name = "rbReport"
        Me.rbReport.Size = New System.Drawing.Size(116, 66)
        Me.rbReport.TabIndex = 1
        Me.rbReport.Text = "Report"
        Me.rbReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbReport.UseVisualStyleBackColor = True
        '
        'rbAccounting
        '
        Me.rbAccounting.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbAccounting.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbAccounting.Image = Global.learnAid.My.Resources.Resources.briefcase_32
        Me.rbAccounting.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rbAccounting.Location = New System.Drawing.Point(3, 98)
        Me.rbAccounting.Margin = New System.Windows.Forms.Padding(4)
        Me.rbAccounting.Name = "rbAccounting"
        Me.rbAccounting.Size = New System.Drawing.Size(116, 66)
        Me.rbAccounting.TabIndex = 1
        Me.rbAccounting.Text = "Accounting"
        Me.rbAccounting.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbAccounting.UseVisualStyleBackColor = True
        '
        'rbEvaluation
        '
        Me.rbEvaluation.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbEvaluation.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbEvaluation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbEvaluation.Image = Global.learnAid.My.Resources.Resources.address_32
        Me.rbEvaluation.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rbEvaluation.Location = New System.Drawing.Point(3, 31)
        Me.rbEvaluation.Margin = New System.Windows.Forms.Padding(4)
        Me.rbEvaluation.Name = "rbEvaluation"
        Me.rbEvaluation.Size = New System.Drawing.Size(116, 66)
        Me.rbEvaluation.TabIndex = 1
        Me.rbEvaluation.Text = "Evaluation"
        Me.rbEvaluation.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbEvaluation.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-3, -1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Options"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'panelRight
        '
        Me.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelRight.Location = New System.Drawing.Point(1003, 53)
        Me.panelRight.Margin = New System.Windows.Forms.Padding(4)
        Me.panelRight.Name = "panelRight"
        Me.panelRight.Size = New System.Drawing.Size(341, 820)
        Me.panelRight.TabIndex = 11
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 898)
        Me.Controls.Add(Me.panelRight)
        Me.Controls.Add(Me.panelLeft)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.Toolbar)
        Me.Controls.Add(Me.MainMenu1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Learn Aid"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.Toolbar.ResumeLayout(False)
        Me.Toolbar.PerformLayout()
        Me.panelLeft.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
    Public WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuLogout As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuSep0011 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuView As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuHome As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuEvaluations As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuAccounting As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuReports As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuSep0023 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuViewButtonPanel As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuViewSchools As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuViewConsultants As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuViewProperties As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuTools As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuClaves As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuUsers As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuOptions As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuHelpUsersManual As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuHelpAbout As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuCreateReports As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuRegularReport As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuOfficeTestingReport As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuEntranceReport As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuJobsRmenu As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuNewJob As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuEditJob As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuDeleteJob As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuSep001 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuResetJob As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuCopyJob As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuVWarnings As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuStudentList As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuRep_RMenu As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuResetRep As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents CDPrint As System.Windows.Forms.PrintDialog
    Public WithEvents CDOpen As System.Windows.Forms.OpenFileDialog
    Public WithEvents CDSave As System.Windows.Forms.SaveFileDialog
    Public WithEvents CDFont As System.Windows.Forms.FontDialog
    Public WithEvents CDColor As System.Windows.Forms.ColorDialog
    Public WithEvents ilToolbar As System.Windows.Forms.ImageList
    Public WithEvents StatusBar As System.Windows.Forms.StatusStrip
    Public WithEvents _StatusBar_Panel1 As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents _StatusBar_Panel2 As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents Toolbar As System.Windows.Forms.ToolStrip
    Public WithEvents Options As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar_Button2 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents _Toolbar_Button3 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar_Button4 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar_Button5 As System.Windows.Forms.ToolStripButton
    Public WithEvents _Toolbar_Button6 As System.Windows.Forms.ToolStripButton
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents panelLeft As System.Windows.Forms.Panel
    Friend WithEvents panelRight As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbConsultants As System.Windows.Forms.RadioButton
    Friend WithEvents rbStudents As System.Windows.Forms.RadioButton
    Friend WithEvents rbReport As System.Windows.Forms.RadioButton
    Friend WithEvents rbAccounting As System.Windows.Forms.RadioButton
    Friend WithEvents rbEvaluation As System.Windows.Forms.RadioButton
    Friend WithEvents mnuEditClaves As System.Windows.Forms.ToolStripMenuItem

End Class
