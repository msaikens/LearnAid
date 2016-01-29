<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCreateReport
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
	Public WithEvents chkExperimental As System.Windows.Forms.CheckBox
	Public WithEvents chkReposition As System.Windows.Forms.CheckBox
	Public WithEvents chkPEP As System.Windows.Forms.CheckBox
	Public WithEvents chkAcomodo As System.Windows.Forms.CheckBox
	Public WithEvents chk_preview As System.Windows.Forms.CheckBox
	Public WithEvents txtTo As System.Windows.Forms.TextBox
	Public WithEvents txtFrom As System.Windows.Forms.TextBox
	Public WithEvents _lvJobs_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvJobs_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvJobs_ColumnHeader_3 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvJobs_ColumnHeader_4 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvJobs_ColumnHeader_5 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvJobs As System.Windows.Forms.ListView
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdContinue As System.Windows.Forms.Button
	Public WithEvents cmdPrevious As System.Windows.Forms.Button
	Public WithEvents cboSemester As System.Windows.Forms.ComboBox
	Public WithEvents txtYear As System.Windows.Forms.TextBox
	Public WithEvents cboSchool As System.Windows.Forms.ComboBox
	Public WithEvents chkRegular As System.Windows.Forms.CheckBox
	Public WithEvents chkIndiv As System.Windows.Forms.CheckBox
	Public WithEvents chkComp As System.Windows.Forms.CheckBox
	Public WithEvents chkDestrezas As System.Windows.Forms.CheckBox
	Public WithEvents chkMID As System.Windows.Forms.CheckBox
	Public WithEvents chkInvoice As System.Windows.Forms.CheckBox
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents lblPending As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreateReport))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkExperimental = New System.Windows.Forms.CheckBox()
        Me.chkReposition = New System.Windows.Forms.CheckBox()
        Me.chkPEP = New System.Windows.Forms.CheckBox()
        Me.chkAcomodo = New System.Windows.Forms.CheckBox()
        Me.chk_preview = New System.Windows.Forms.CheckBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.lvJobs = New System.Windows.Forms.ListView()
        Me._lvJobs_ColumnHeader_1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._lvJobs_ColumnHeader_2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._lvJobs_ColumnHeader_3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._lvJobs_ColumnHeader_4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._lvJobs_ColumnHeader_5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdContinue = New System.Windows.Forms.Button()
        Me.cmdPrevious = New System.Windows.Forms.Button()
        Me.cboSemester = New System.Windows.Forms.ComboBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.cboSchool = New System.Windows.Forms.ComboBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.chkRegular = New System.Windows.Forms.CheckBox()
        Me.chkIndiv = New System.Windows.Forms.CheckBox()
        Me.chkComp = New System.Windows.Forms.CheckBox()
        Me.chkDestrezas = New System.Windows.Forms.CheckBox()
        Me.chkMID = New System.Windows.Forms.CheckBox()
        Me.chkInvoice = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPending = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkExperimental
        '
        Me.chkExperimental.BackColor = System.Drawing.SystemColors.Control
        Me.chkExperimental.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkExperimental.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExperimental.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkExperimental.Location = New System.Drawing.Point(160, 132)
        Me.chkExperimental.Name = "chkExperimental"
        Me.chkExperimental.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkExperimental.Size = New System.Drawing.Size(114, 18)
        Me.chkExperimental.TabIndex = 27
        Me.chkExperimental.Text = "Experimental (REN)"
        Me.chkExperimental.UseVisualStyleBackColor = False
        '
        'chkReposition
        '
        Me.chkReposition.BackColor = System.Drawing.SystemColors.Control
        Me.chkReposition.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkReposition.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReposition.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkReposition.Location = New System.Drawing.Point(160, 104)
        Me.chkReposition.Name = "chkReposition"
        Me.chkReposition.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkReposition.Size = New System.Drawing.Size(98, 22)
        Me.chkReposition.TabIndex = 26
        Me.chkReposition.Text = "Reposition"
        Me.chkReposition.UseVisualStyleBackColor = False
        '
        'chkPEP
        '
        Me.chkPEP.BackColor = System.Drawing.SystemColors.Control
        Me.chkPEP.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkPEP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPEP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkPEP.Location = New System.Drawing.Point(68, 129)
        Me.chkPEP.Name = "chkPEP"
        Me.chkPEP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkPEP.Size = New System.Drawing.Size(80, 25)
        Me.chkPEP.TabIndex = 25
        Me.chkPEP.Text = "PEPV"
        Me.chkPEP.UseVisualStyleBackColor = False
        '
        'chkAcomodo
        '
        Me.chkAcomodo.BackColor = System.Drawing.SystemColors.Control
        Me.chkAcomodo.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAcomodo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAcomodo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAcomodo.Location = New System.Drawing.Point(68, 105)
        Me.chkAcomodo.Name = "chkAcomodo"
        Me.chkAcomodo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAcomodo.Size = New System.Drawing.Size(91, 18)
        Me.chkAcomodo.TabIndex = 23
        Me.chkAcomodo.Text = "Acomodo Razonable"
        Me.chkAcomodo.UseVisualStyleBackColor = False
        '
        'chk_preview
        '
        Me.chk_preview.BackColor = System.Drawing.SystemColors.Control
        Me.chk_preview.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk_preview.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_preview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk_preview.Location = New System.Drawing.Point(8, 334)
        Me.chk_preview.Name = "chk_preview"
        Me.chk_preview.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk_preview.Size = New System.Drawing.Size(139, 20)
        Me.chk_preview.TabIndex = 16
        Me.chk_preview.Text = "Preview Report"
        Me.chk_preview.UseVisualStyleBackColor = False
        '
        'txtTo
        '
        Me.txtTo.AcceptsReturn = True
        Me.txtTo.BackColor = System.Drawing.SystemColors.Window
        Me.txtTo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTo.Location = New System.Drawing.Point(418, 175)
        Me.txtTo.MaxLength = 0
        Me.txtTo.Name = "txtTo"
        Me.txtTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTo.Size = New System.Drawing.Size(33, 23)
        Me.txtTo.TabIndex = 13
        Me.txtTo.Tag = resources.GetString("txtTo.Tag")
        Me.txtTo.Text = "12"
        '
        'txtFrom
        '
        Me.txtFrom.AcceptsReturn = True
        Me.txtFrom.BackColor = System.Drawing.SystemColors.Window
        Me.txtFrom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFrom.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrom.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFrom.Location = New System.Drawing.Point(418, 146)
        Me.txtFrom.MaxLength = 0
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFrom.Size = New System.Drawing.Size(33, 23)
        Me.txtFrom.TabIndex = 12
        Me.txtFrom.Tag = resources.GetString("txtFrom.Tag")
        Me.txtFrom.Text = "0"
        '
        'lvJobs
        '
        Me.lvJobs.BackColor = System.Drawing.SystemColors.Window
        Me.lvJobs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvJobs_ColumnHeader_1, Me._lvJobs_ColumnHeader_2, Me._lvJobs_ColumnHeader_3, Me._lvJobs_ColumnHeader_4, Me._lvJobs_ColumnHeader_5})
        Me.lvJobs.Font = New System.Drawing.Font("Tahoma", 8.4!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvJobs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvJobs.FullRowSelect = True
        Me.lvJobs.GridLines = True
        Me.lvJobs.Location = New System.Drawing.Point(8, 205)
        Me.lvJobs.Name = "lvJobs"
        Me.lvJobs.Size = New System.Drawing.Size(490, 110)
        Me.lvJobs.TabIndex = 9
        Me.lvJobs.UseCompatibleStateImageBehavior = False
        Me.lvJobs.View = System.Windows.Forms.View.Details
        '
        '_lvJobs_ColumnHeader_1
        '
        Me._lvJobs_ColumnHeader_1.Text = "School"
        Me._lvJobs_ColumnHeader_1.Width = 170
        '
        '_lvJobs_ColumnHeader_2
        '
        Me._lvJobs_ColumnHeader_2.Text = "Job Date"
        Me._lvJobs_ColumnHeader_2.Width = 94
        '
        '_lvJobs_ColumnHeader_3
        '
        Me._lvJobs_ColumnHeader_3.Text = "Grade"
        Me._lvJobs_ColumnHeader_3.Width = 170
        '
        '_lvJobs_ColumnHeader_4
        '
        Me._lvJobs_ColumnHeader_4.Text = "Section"
        Me._lvJobs_ColumnHeader_4.Width = 170
        '
        '_lvJobs_ColumnHeader_5
        '
        Me._lvJobs_ColumnHeader_5.Text = "Students"
        Me._lvJobs_ColumnHeader_5.Width = 170
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(385, 329)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(81, 25)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdContinue
        '
        Me.cmdContinue.BackColor = System.Drawing.SystemColors.Control
        Me.cmdContinue.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdContinue.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdContinue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdContinue.Location = New System.Drawing.Point(298, 329)
        Me.cmdContinue.Name = "cmdContinue"
        Me.cmdContinue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdContinue.Size = New System.Drawing.Size(81, 25)
        Me.cmdContinue.TabIndex = 7
        Me.cmdContinue.Text = "Create Report"
        Me.cmdContinue.UseVisualStyleBackColor = False
        '
        'cmdPrevious
        '
        Me.cmdPrevious.BackColor = System.Drawing.SystemColors.Control
        Me.cmdPrevious.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrevious.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrevious.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdPrevious.Location = New System.Drawing.Point(179, 329)
        Me.cmdPrevious.Name = "cmdPrevious"
        Me.cmdPrevious.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPrevious.Size = New System.Drawing.Size(113, 25)
        Me.cmdPrevious.TabIndex = 6
        Me.cmdPrevious.Text = "Previous Reports"
        Me.cmdPrevious.UseVisualStyleBackColor = False
        '
        'cboSemester
        '
        Me.cboSemester.BackColor = System.Drawing.SystemColors.Window
        Me.cboSemester.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSemester.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSemester.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSemester.Location = New System.Drawing.Point(82, 72)
        Me.cboSemester.Name = "cboSemester"
        Me.cboSemester.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboSemester.Size = New System.Drawing.Size(215, 24)
        Me.cboSemester.TabIndex = 5
        Me.cboSemester.Tag = "Validate Text -Required -RequiredMsg Please select the semester."
        '
        'txtYear
        '
        Me.txtYear.AcceptsReturn = True
        Me.txtYear.BackColor = System.Drawing.SystemColors.Window
        Me.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtYear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtYear.Location = New System.Drawing.Point(82, 40)
        Me.txtYear.MaxLength = 0
        Me.txtYear.Name = "txtYear"
        Me.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtYear.Size = New System.Drawing.Size(65, 23)
        Me.txtYear.TabIndex = 4
        Me.txtYear.Tag = "Validate Text -Required -AllowDigits -FieldMustBe >= 1900 -RequiredMsg Year is a " & _
    "required field! -InvalidValueMsg Year field only accept digits. -OutOfRangeMsg Y" & _
    "ear must be greater or equal than 1900."
        '
        'cboSchool
        '
        Me.cboSchool.BackColor = System.Drawing.SystemColors.Window
        Me.cboSchool.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSchool.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSchool.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSchool.Location = New System.Drawing.Point(82, 8)
        Me.cboSchool.Name = "cboSchool"
        Me.cboSchool.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboSchool.Size = New System.Drawing.Size(416, 24)
        Me.cboSchool.TabIndex = 3
        Me.cboSchool.Tag = "Validate Text -Required -RequiredMsg Please select the school."
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.chkRegular)
        Me.Frame1.Controls.Add(Me.chkIndiv)
        Me.Frame1.Controls.Add(Me.chkComp)
        Me.Frame1.Controls.Add(Me.chkDestrezas)
        Me.Frame1.Controls.Add(Me.chkMID)
        Me.Frame1.Controls.Add(Me.chkInvoice)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(310, 43)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(188, 97)
        Me.Frame1.TabIndex = 17
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Include"
        '
        'chkRegular
        '
        Me.chkRegular.BackColor = System.Drawing.SystemColors.Control
        Me.chkRegular.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkRegular.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRegular.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkRegular.Location = New System.Drawing.Point(10, 62)
        Me.chkRegular.Name = "chkRegular"
        Me.chkRegular.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkRegular.Size = New System.Drawing.Size(81, 25)
        Me.chkRegular.TabIndex = 24
        Me.chkRegular.Text = "Regular"
        Me.chkRegular.UseVisualStyleBackColor = False
        '
        'chkIndiv
        '
        Me.chkIndiv.BackColor = System.Drawing.SystemColors.Control
        Me.chkIndiv.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkIndiv.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIndiv.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkIndiv.Location = New System.Drawing.Point(10, 16)
        Me.chkIndiv.Name = "chkIndiv"
        Me.chkIndiv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkIndiv.Size = New System.Drawing.Size(89, 25)
        Me.chkIndiv.TabIndex = 22
        Me.chkIndiv.Text = "Individual"
        Me.chkIndiv.UseVisualStyleBackColor = False
        '
        'chkComp
        '
        Me.chkComp.BackColor = System.Drawing.SystemColors.Control
        Me.chkComp.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkComp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkComp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkComp.Location = New System.Drawing.Point(97, 40)
        Me.chkComp.Name = "chkComp"
        Me.chkComp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkComp.Size = New System.Drawing.Size(89, 25)
        Me.chkComp.TabIndex = 21
        Me.chkComp.Text = "Comparison"
        Me.chkComp.UseVisualStyleBackColor = False
        Me.chkComp.Visible = False
        '
        'chkDestrezas
        '
        Me.chkDestrezas.BackColor = System.Drawing.SystemColors.Control
        Me.chkDestrezas.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDestrezas.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDestrezas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDestrezas.Location = New System.Drawing.Point(97, 16)
        Me.chkDestrezas.Name = "chkDestrezas"
        Me.chkDestrezas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDestrezas.Size = New System.Drawing.Size(89, 25)
        Me.chkDestrezas.TabIndex = 20
        Me.chkDestrezas.Text = "Skills"
        Me.chkDestrezas.UseVisualStyleBackColor = False
        '
        'chkMID
        '
        Me.chkMID.BackColor = System.Drawing.SystemColors.Control
        Me.chkMID.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkMID.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMID.Location = New System.Drawing.Point(10, 40)
        Me.chkMID.Name = "chkMID"
        Me.chkMID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMID.Size = New System.Drawing.Size(89, 25)
        Me.chkMID.TabIndex = 19
        Me.chkMID.Text = "Middle State"
        Me.chkMID.UseVisualStyleBackColor = False
        '
        'chkInvoice
        '
        Me.chkInvoice.BackColor = System.Drawing.SystemColors.Control
        Me.chkInvoice.Checked = True
        Me.chkInvoice.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkInvoice.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkInvoice.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInvoice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkInvoice.Location = New System.Drawing.Point(97, 62)
        Me.chkInvoice.Name = "chkInvoice"
        Me.chkInvoice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkInvoice.Size = New System.Drawing.Size(68, 25)
        Me.chkInvoice.TabIndex = 18
        Me.chkInvoice.Text = "Print Invoice"
        Me.chkInvoice.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(317, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "To Grade:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(317, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "From Grade:"
        '
        'lblPending
        '
        Me.lblPending.BackColor = System.Drawing.SystemColors.Control
        Me.lblPending.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPending.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPending.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPending.Location = New System.Drawing.Point(79, 178)
        Me.lblPending.Name = "lblPending"
        Me.lblPending.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPending.Size = New System.Drawing.Size(41, 17)
        Me.lblPending.TabIndex = 11
        Me.lblPending.Text = "0"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(11, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Jobs Pending:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(5, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Semester:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(11, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Year:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(11, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "School:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmCreateReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(510, 371)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkExperimental)
        Me.Controls.Add(Me.chkReposition)
        Me.Controls.Add(Me.chkPEP)
        Me.Controls.Add(Me.chkAcomodo)
        Me.Controls.Add(Me.chk_preview)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.lvJobs)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdContinue)
        Me.Controls.Add(Me.cmdPrevious)
        Me.Controls.Add(Me.cboSemester)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.cboSchool)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblPending)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.4!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(4, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCreateReport"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create Report"
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 
End Class