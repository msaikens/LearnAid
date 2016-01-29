<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmInformeConsultoresAdminMain
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
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Command16 As System.Windows.Forms.Button
	Public WithEvents _lvContitions_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvContitions As System.Windows.Forms.ListView
	Public WithEvents cmdDeleteCondiiton As System.Windows.Forms.Button
	Public WithEvents cmdEditCondiiton As System.Windows.Forms.Button
	Public WithEvents cmdAddCondiiton As System.Windows.Forms.Button
	Public WithEvents _SSTab1_TabPage0 As System.Windows.Forms.TabPage
	Public WithEvents cmdDeleteInstruction As System.Windows.Forms.Button
	Public WithEvents cmdEditInstruction As System.Windows.Forms.Button
	Public WithEvents cmdAddInstruction As System.Windows.Forms.Button
	Public WithEvents _lvInstructions_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvInstructions As System.Windows.Forms.ListView
	Public WithEvents _SSTab1_TabPage1 As System.Windows.Forms.TabPage
	Public WithEvents cmdAddRepetition As System.Windows.Forms.Button
	Public WithEvents cmdEditRepetition As System.Windows.Forms.Button
	Public WithEvents cmdDeleteRepetition As System.Windows.Forms.Button
	Public WithEvents _lvRepetition_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvRepetition As System.Windows.Forms.ListView
	Public WithEvents _SSTab1_TabPage2 As System.Windows.Forms.TabPage
	Public WithEvents cmdAddConduct As System.Windows.Forms.Button
	Public WithEvents cmdEditConduct As System.Windows.Forms.Button
	Public WithEvents cmdDeleteConduct As System.Windows.Forms.Button
	Public WithEvents _lvConduct_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvConduct As System.Windows.Forms.ListView
	Public WithEvents _SSTab1_TabPage3 As System.Windows.Forms.TabPage
	Public WithEvents cmdDeleteRecommendation As System.Windows.Forms.Button
	Public WithEvents cmdEditRecommendation As System.Windows.Forms.Button
	Public WithEvents cmdAddRecommendation As System.Windows.Forms.Button
	Public WithEvents _lvRecommendations_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvRecommendations As System.Windows.Forms.ListView
	Public WithEvents _SSTab1_TabPage4 As System.Windows.Forms.TabPage
	Public WithEvents SSTab1 As System.Windows.Forms.TabControl
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Command16 = New System.Windows.Forms.Button()
        Me.SSTab1 = New System.Windows.Forms.TabControl()
        Me._SSTab1_TabPage0 = New System.Windows.Forms.TabPage()
        Me.lvContitions = New System.Windows.Forms.ListView()
        Me._lvContitions_ColumnHeader_1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdDeleteCondiiton = New System.Windows.Forms.Button()
        Me.cmdEditCondiiton = New System.Windows.Forms.Button()
        Me.cmdAddCondiiton = New System.Windows.Forms.Button()
        Me._SSTab1_TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmdDeleteInstruction = New System.Windows.Forms.Button()
        Me.cmdEditInstruction = New System.Windows.Forms.Button()
        Me.cmdAddInstruction = New System.Windows.Forms.Button()
        Me.lvInstructions = New System.Windows.Forms.ListView()
        Me._lvInstructions_ColumnHeader_1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._SSTab1_TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmdAddRepetition = New System.Windows.Forms.Button()
        Me.cmdEditRepetition = New System.Windows.Forms.Button()
        Me.cmdDeleteRepetition = New System.Windows.Forms.Button()
        Me.lvRepetition = New System.Windows.Forms.ListView()
        Me._lvRepetition_ColumnHeader_1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._SSTab1_TabPage3 = New System.Windows.Forms.TabPage()
        Me.cmdAddConduct = New System.Windows.Forms.Button()
        Me.cmdEditConduct = New System.Windows.Forms.Button()
        Me.cmdDeleteConduct = New System.Windows.Forms.Button()
        Me.lvConduct = New System.Windows.Forms.ListView()
        Me._lvConduct_ColumnHeader_1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._SSTab1_TabPage4 = New System.Windows.Forms.TabPage()
        Me.cmdDeleteRecommendation = New System.Windows.Forms.Button()
        Me.cmdEditRecommendation = New System.Windows.Forms.Button()
        Me.cmdAddRecommendation = New System.Windows.Forms.Button()
        Me.lvRecommendations = New System.Windows.Forms.ListView()
        Me._lvRecommendations_ColumnHeader_1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SSTab1.SuspendLayout()
        Me._SSTab1_TabPage0.SuspendLayout()
        Me._SSTab1_TabPage1.SuspendLayout()
        Me._SSTab1_TabPage2.SuspendLayout()
        Me._SSTab1_TabPage3.SuspendLayout()
        Me._SSTab1_TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(312, 267)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(97, 25)
        Me.Command1.TabIndex = 22
        Me.Command1.Text = "&Cancel"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Command16
        '
        Me.Command16.BackColor = System.Drawing.SystemColors.Control
        Me.Command16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command16.Location = New System.Drawing.Point(208, 267)
        Me.Command16.Name = "Command16"
        Me.Command16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command16.Size = New System.Drawing.Size(97, 25)
        Me.Command16.TabIndex = 21
        Me.Command16.Text = "Save and E&xit"
        Me.Command16.UseVisualStyleBackColor = False
        '
        'SSTab1
        '
        Me.SSTab1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage0)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage1)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage2)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage3)
        Me.SSTab1.Controls.Add(Me._SSTab1_TabPage4)
        Me.SSTab1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSTab1.ItemSize = New System.Drawing.Size(42, 18)
        Me.SSTab1.Location = New System.Drawing.Point(8, 8)
        Me.SSTab1.Name = "SSTab1"
        Me.SSTab1.SelectedIndex = 0
        Me.SSTab1.Size = New System.Drawing.Size(401, 257)
        Me.SSTab1.TabIndex = 0
        '
        '_SSTab1_TabPage0
        '
        Me._SSTab1_TabPage0.Controls.Add(Me.lvContitions)
        Me._SSTab1_TabPage0.Controls.Add(Me.cmdDeleteCondiiton)
        Me._SSTab1_TabPage0.Controls.Add(Me.cmdEditCondiiton)
        Me._SSTab1_TabPage0.Controls.Add(Me.cmdAddCondiiton)
        Me._SSTab1_TabPage0.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage0.Name = "_SSTab1_TabPage0"
        Me._SSTab1_TabPage0.Size = New System.Drawing.Size(393, 231)
        Me._SSTab1_TabPage0.TabIndex = 0
        Me._SSTab1_TabPage0.Text = "Conditions"
        '
        'lvContitions
        '
        Me.lvContitions.BackColor = System.Drawing.SystemColors.Window
        Me.lvContitions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvContitions_ColumnHeader_1})
        Me.lvContitions.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvContitions.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvContitions.FullRowSelect = True
        Me.lvContitions.GridLines = True
        Me.lvContitions.Location = New System.Drawing.Point(8, 3)
        Me.lvContitions.Name = "lvContitions"
        Me.lvContitions.Size = New System.Drawing.Size(385, 185)
        Me.lvContitions.TabIndex = 1
        Me.lvContitions.UseCompatibleStateImageBehavior = False
        Me.lvContitions.View = System.Windows.Forms.View.Details
        '
        '_lvContitions_ColumnHeader_1
        '
        Me._lvContitions_ColumnHeader_1.Width = 671
        '
        'cmdDeleteCondiiton
        '
        Me.cmdDeleteCondiiton.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDeleteCondiiton.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDeleteCondiiton.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeleteCondiiton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDeleteCondiiton.Location = New System.Drawing.Point(317, 194)
        Me.cmdDeleteCondiiton.Name = "cmdDeleteCondiiton"
        Me.cmdDeleteCondiiton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDeleteCondiiton.Size = New System.Drawing.Size(73, 25)
        Me.cmdDeleteCondiiton.TabIndex = 11
        Me.cmdDeleteCondiiton.Text = "&Delete"
        Me.cmdDeleteCondiiton.UseVisualStyleBackColor = False
        '
        'cmdEditCondiiton
        '
        Me.cmdEditCondiiton.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEditCondiiton.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEditCondiiton.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditCondiiton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEditCondiiton.Location = New System.Drawing.Point(237, 194)
        Me.cmdEditCondiiton.Name = "cmdEditCondiiton"
        Me.cmdEditCondiiton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEditCondiiton.Size = New System.Drawing.Size(73, 25)
        Me.cmdEditCondiiton.TabIndex = 12
        Me.cmdEditCondiiton.Text = "&Edit"
        Me.cmdEditCondiiton.UseVisualStyleBackColor = False
        '
        'cmdAddCondiiton
        '
        Me.cmdAddCondiiton.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAddCondiiton.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAddCondiiton.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddCondiiton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAddCondiiton.Location = New System.Drawing.Point(157, 194)
        Me.cmdAddCondiiton.Name = "cmdAddCondiiton"
        Me.cmdAddCondiiton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAddCondiiton.Size = New System.Drawing.Size(73, 25)
        Me.cmdAddCondiiton.TabIndex = 13
        Me.cmdAddCondiiton.Text = "&Add"
        Me.cmdAddCondiiton.UseVisualStyleBackColor = False
        '
        '_SSTab1_TabPage1
        '
        Me._SSTab1_TabPage1.Controls.Add(Me.cmdDeleteInstruction)
        Me._SSTab1_TabPage1.Controls.Add(Me.cmdEditInstruction)
        Me._SSTab1_TabPage1.Controls.Add(Me.cmdAddInstruction)
        Me._SSTab1_TabPage1.Controls.Add(Me.lvInstructions)
        Me._SSTab1_TabPage1.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage1.Name = "_SSTab1_TabPage1"
        Me._SSTab1_TabPage1.Size = New System.Drawing.Size(393, 231)
        Me._SSTab1_TabPage1.TabIndex = 1
        Me._SSTab1_TabPage1.Text = "Instructions"
        '
        'cmdDeleteInstruction
        '
        Me.cmdDeleteInstruction.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDeleteInstruction.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDeleteInstruction.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeleteInstruction.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDeleteInstruction.Location = New System.Drawing.Point(320, 224)
        Me.cmdDeleteInstruction.Name = "cmdDeleteInstruction"
        Me.cmdDeleteInstruction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDeleteInstruction.Size = New System.Drawing.Size(73, 25)
        Me.cmdDeleteInstruction.TabIndex = 20
        Me.cmdDeleteInstruction.Text = "&Delete"
        Me.cmdDeleteInstruction.UseVisualStyleBackColor = False
        '
        'cmdEditInstruction
        '
        Me.cmdEditInstruction.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEditInstruction.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEditInstruction.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditInstruction.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEditInstruction.Location = New System.Drawing.Point(240, 224)
        Me.cmdEditInstruction.Name = "cmdEditInstruction"
        Me.cmdEditInstruction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEditInstruction.Size = New System.Drawing.Size(73, 25)
        Me.cmdEditInstruction.TabIndex = 19
        Me.cmdEditInstruction.Text = "&Edit"
        Me.cmdEditInstruction.UseVisualStyleBackColor = False
        '
        'cmdAddInstruction
        '
        Me.cmdAddInstruction.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAddInstruction.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAddInstruction.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddInstruction.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAddInstruction.Location = New System.Drawing.Point(160, 224)
        Me.cmdAddInstruction.Name = "cmdAddInstruction"
        Me.cmdAddInstruction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAddInstruction.Size = New System.Drawing.Size(73, 25)
        Me.cmdAddInstruction.TabIndex = 18
        Me.cmdAddInstruction.Text = "&Add"
        Me.cmdAddInstruction.UseVisualStyleBackColor = False
        '
        'lvInstructions
        '
        Me.lvInstructions.BackColor = System.Drawing.SystemColors.Window
        Me.lvInstructions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvInstructions_ColumnHeader_1})
        Me.lvInstructions.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvInstructions.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvInstructions.FullRowSelect = True
        Me.lvInstructions.GridLines = True
        Me.lvInstructions.Location = New System.Drawing.Point(8, 32)
        Me.lvInstructions.Name = "lvInstructions"
        Me.lvInstructions.Size = New System.Drawing.Size(385, 185)
        Me.lvInstructions.TabIndex = 2
        Me.lvInstructions.UseCompatibleStateImageBehavior = False
        Me.lvInstructions.View = System.Windows.Forms.View.Details
        '
        '_lvInstructions_ColumnHeader_1
        '
        Me._lvInstructions_ColumnHeader_1.Width = 671
        '
        '_SSTab1_TabPage2
        '
        Me._SSTab1_TabPage2.Controls.Add(Me.cmdAddRepetition)
        Me._SSTab1_TabPage2.Controls.Add(Me.cmdEditRepetition)
        Me._SSTab1_TabPage2.Controls.Add(Me.cmdDeleteRepetition)
        Me._SSTab1_TabPage2.Controls.Add(Me.lvRepetition)
        Me._SSTab1_TabPage2.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage2.Name = "_SSTab1_TabPage2"
        Me._SSTab1_TabPage2.Size = New System.Drawing.Size(393, 231)
        Me._SSTab1_TabPage2.TabIndex = 2
        Me._SSTab1_TabPage2.Text = "Repetition"
        '
        'cmdAddRepetition
        '
        Me.cmdAddRepetition.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAddRepetition.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAddRepetition.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddRepetition.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAddRepetition.Location = New System.Drawing.Point(160, 224)
        Me.cmdAddRepetition.Name = "cmdAddRepetition"
        Me.cmdAddRepetition.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAddRepetition.Size = New System.Drawing.Size(73, 25)
        Me.cmdAddRepetition.TabIndex = 10
        Me.cmdAddRepetition.Text = "&Add"
        Me.cmdAddRepetition.UseVisualStyleBackColor = False
        '
        'cmdEditRepetition
        '
        Me.cmdEditRepetition.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEditRepetition.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEditRepetition.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditRepetition.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEditRepetition.Location = New System.Drawing.Point(240, 224)
        Me.cmdEditRepetition.Name = "cmdEditRepetition"
        Me.cmdEditRepetition.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEditRepetition.Size = New System.Drawing.Size(73, 25)
        Me.cmdEditRepetition.TabIndex = 9
        Me.cmdEditRepetition.Text = "&Edit"
        Me.cmdEditRepetition.UseVisualStyleBackColor = False
        '
        'cmdDeleteRepetition
        '
        Me.cmdDeleteRepetition.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDeleteRepetition.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDeleteRepetition.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeleteRepetition.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDeleteRepetition.Location = New System.Drawing.Point(320, 224)
        Me.cmdDeleteRepetition.Name = "cmdDeleteRepetition"
        Me.cmdDeleteRepetition.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDeleteRepetition.Size = New System.Drawing.Size(73, 25)
        Me.cmdDeleteRepetition.TabIndex = 8
        Me.cmdDeleteRepetition.Text = "&Delete"
        Me.cmdDeleteRepetition.UseVisualStyleBackColor = False
        '
        'lvRepetition
        '
        Me.lvRepetition.BackColor = System.Drawing.SystemColors.Window
        Me.lvRepetition.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvRepetition_ColumnHeader_1})
        Me.lvRepetition.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvRepetition.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvRepetition.FullRowSelect = True
        Me.lvRepetition.GridLines = True
        Me.lvRepetition.Location = New System.Drawing.Point(8, 32)
        Me.lvRepetition.Name = "lvRepetition"
        Me.lvRepetition.Size = New System.Drawing.Size(385, 185)
        Me.lvRepetition.TabIndex = 3
        Me.lvRepetition.UseCompatibleStateImageBehavior = False
        Me.lvRepetition.View = System.Windows.Forms.View.Details
        '
        '_lvRepetition_ColumnHeader_1
        '
        Me._lvRepetition_ColumnHeader_1.Width = 671
        '
        '_SSTab1_TabPage3
        '
        Me._SSTab1_TabPage3.Controls.Add(Me.cmdAddConduct)
        Me._SSTab1_TabPage3.Controls.Add(Me.cmdEditConduct)
        Me._SSTab1_TabPage3.Controls.Add(Me.cmdDeleteConduct)
        Me._SSTab1_TabPage3.Controls.Add(Me.lvConduct)
        Me._SSTab1_TabPage3.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage3.Name = "_SSTab1_TabPage3"
        Me._SSTab1_TabPage3.Size = New System.Drawing.Size(393, 231)
        Me._SSTab1_TabPage3.TabIndex = 3
        Me._SSTab1_TabPage3.Text = "Conduct"
        '
        'cmdAddConduct
        '
        Me.cmdAddConduct.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAddConduct.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAddConduct.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddConduct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAddConduct.Location = New System.Drawing.Point(160, 224)
        Me.cmdAddConduct.Name = "cmdAddConduct"
        Me.cmdAddConduct.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAddConduct.Size = New System.Drawing.Size(73, 25)
        Me.cmdAddConduct.TabIndex = 7
        Me.cmdAddConduct.Text = "&Add"
        Me.cmdAddConduct.UseVisualStyleBackColor = False
        '
        'cmdEditConduct
        '
        Me.cmdEditConduct.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEditConduct.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEditConduct.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditConduct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEditConduct.Location = New System.Drawing.Point(240, 224)
        Me.cmdEditConduct.Name = "cmdEditConduct"
        Me.cmdEditConduct.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEditConduct.Size = New System.Drawing.Size(73, 25)
        Me.cmdEditConduct.TabIndex = 6
        Me.cmdEditConduct.Text = "&Edit"
        Me.cmdEditConduct.UseVisualStyleBackColor = False
        '
        'cmdDeleteConduct
        '
        Me.cmdDeleteConduct.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDeleteConduct.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDeleteConduct.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeleteConduct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDeleteConduct.Location = New System.Drawing.Point(320, 224)
        Me.cmdDeleteConduct.Name = "cmdDeleteConduct"
        Me.cmdDeleteConduct.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDeleteConduct.Size = New System.Drawing.Size(73, 25)
        Me.cmdDeleteConduct.TabIndex = 5
        Me.cmdDeleteConduct.Text = "&Delete"
        Me.cmdDeleteConduct.UseVisualStyleBackColor = False
        '
        'lvConduct
        '
        Me.lvConduct.BackColor = System.Drawing.SystemColors.Window
        Me.lvConduct.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvConduct_ColumnHeader_1})
        Me.lvConduct.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvConduct.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvConduct.FullRowSelect = True
        Me.lvConduct.GridLines = True
        Me.lvConduct.Location = New System.Drawing.Point(8, 32)
        Me.lvConduct.Name = "lvConduct"
        Me.lvConduct.Size = New System.Drawing.Size(385, 185)
        Me.lvConduct.TabIndex = 4
        Me.lvConduct.UseCompatibleStateImageBehavior = False
        Me.lvConduct.View = System.Windows.Forms.View.Details
        '
        '_lvConduct_ColumnHeader_1
        '
        Me._lvConduct_ColumnHeader_1.Width = 671
        '
        '_SSTab1_TabPage4
        '
        Me._SSTab1_TabPage4.Controls.Add(Me.cmdDeleteRecommendation)
        Me._SSTab1_TabPage4.Controls.Add(Me.cmdEditRecommendation)
        Me._SSTab1_TabPage4.Controls.Add(Me.cmdAddRecommendation)
        Me._SSTab1_TabPage4.Controls.Add(Me.lvRecommendations)
        Me._SSTab1_TabPage4.Location = New System.Drawing.Point(4, 22)
        Me._SSTab1_TabPage4.Name = "_SSTab1_TabPage4"
        Me._SSTab1_TabPage4.Size = New System.Drawing.Size(393, 231)
        Me._SSTab1_TabPage4.TabIndex = 4
        Me._SSTab1_TabPage4.Text = "Recommendations"
        '
        'cmdDeleteRecommendation
        '
        Me.cmdDeleteRecommendation.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDeleteRecommendation.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDeleteRecommendation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeleteRecommendation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDeleteRecommendation.Location = New System.Drawing.Point(320, 224)
        Me.cmdDeleteRecommendation.Name = "cmdDeleteRecommendation"
        Me.cmdDeleteRecommendation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDeleteRecommendation.Size = New System.Drawing.Size(73, 25)
        Me.cmdDeleteRecommendation.TabIndex = 17
        Me.cmdDeleteRecommendation.Text = "&Delete"
        Me.cmdDeleteRecommendation.UseVisualStyleBackColor = False
        '
        'cmdEditRecommendation
        '
        Me.cmdEditRecommendation.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEditRecommendation.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEditRecommendation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditRecommendation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEditRecommendation.Location = New System.Drawing.Point(240, 224)
        Me.cmdEditRecommendation.Name = "cmdEditRecommendation"
        Me.cmdEditRecommendation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEditRecommendation.Size = New System.Drawing.Size(73, 25)
        Me.cmdEditRecommendation.TabIndex = 16
        Me.cmdEditRecommendation.Text = "&Edit"
        Me.cmdEditRecommendation.UseVisualStyleBackColor = False
        '
        'cmdAddRecommendation
        '
        Me.cmdAddRecommendation.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAddRecommendation.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAddRecommendation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddRecommendation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAddRecommendation.Location = New System.Drawing.Point(160, 224)
        Me.cmdAddRecommendation.Name = "cmdAddRecommendation"
        Me.cmdAddRecommendation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAddRecommendation.Size = New System.Drawing.Size(73, 25)
        Me.cmdAddRecommendation.TabIndex = 15
        Me.cmdAddRecommendation.Text = "&Add"
        Me.cmdAddRecommendation.UseVisualStyleBackColor = False
        '
        'lvRecommendations
        '
        Me.lvRecommendations.BackColor = System.Drawing.SystemColors.Window
        Me.lvRecommendations.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvRecommendations_ColumnHeader_1})
        Me.lvRecommendations.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvRecommendations.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvRecommendations.FullRowSelect = True
        Me.lvRecommendations.GridLines = True
        Me.lvRecommendations.Location = New System.Drawing.Point(8, 32)
        Me.lvRecommendations.Name = "lvRecommendations"
        Me.lvRecommendations.Size = New System.Drawing.Size(385, 185)
        Me.lvRecommendations.TabIndex = 14
        Me.lvRecommendations.UseCompatibleStateImageBehavior = False
        Me.lvRecommendations.View = System.Windows.Forms.View.Details
        '
        '_lvRecommendations_ColumnHeader_1
        '
        Me._lvRecommendations_ColumnHeader_1.Width = 639
        '
        'frmInformeConsultoresAdminMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(417, 298)
        Me.ControlBox = False
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Command16)
        Me.Controls.Add(Me.SSTab1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInformeConsultoresAdminMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Consultant's report"
        Me.SSTab1.ResumeLayout(False)
        Me._SSTab1_TabPage0.ResumeLayout(False)
        Me._SSTab1_TabPage1.ResumeLayout(False)
        Me._SSTab1_TabPage2.ResumeLayout(False)
        Me._SSTab1_TabPage3.ResumeLayout(False)
        Me._SSTab1_TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class