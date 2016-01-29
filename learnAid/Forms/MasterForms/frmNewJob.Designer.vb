Namespace Forms.MasterForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmNewJob
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
        Public WithEvents lblDesc As System.Windows.Forms.Label
        Public WithEvents Label12 As System.Windows.Forms.Label
        Public WithEvents Frame2 As System.Windows.Forms.GroupBox
        Public WithEvents cmdCancel As System.Windows.Forms.Button
        Public WithEvents cmdBack As System.Windows.Forms.Button
        Public WithEvents cmdNext As System.Windows.Forms.Button
        Public WithEvents Frame3 As System.Windows.Forms.GroupBox
        Public WithEvents fraReport As System.Windows.Forms.GroupBox
        Public WithEvents txtFile As System.Windows.Forms.TextBox
        Public WithEvents chkPEP As System.Windows.Forms.CheckBox
        Public WithEvents chkAcomodo As System.Windows.Forms.CheckBox
        Public WithEvents txtDate As System.Windows.Forms.TextBox
        Public WithEvents Label2 As System.Windows.Forms.Label
        Public WithEvents Label16 As System.Windows.Forms.Label
        Public WithEvents Label14 As System.Windows.Forms.Label
        Public WithEvents fraStudentCount As System.Windows.Forms.GroupBox
        Public WithEvents ImageList1 As System.Windows.Forms.ImageList
        Public WithEvents cboExaminerOT As System.Windows.Forms.ComboBox
        Public WithEvents _OfficeList_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
        Public WithEvents _OfficeList_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
        Public WithEvents _OfficeList_ColumnHeader_3 As System.Windows.Forms.ColumnHeader
        Public WithEvents _OfficeList_ColumnHeader_4 As System.Windows.Forms.ColumnHeader
        Public WithEvents _OfficeList_ColumnHeader_5 As System.Windows.Forms.ColumnHeader
        Public WithEvents _OfficeList_ColumnHeader_6 As System.Windows.Forms.ColumnHeader
        Public WithEvents _OfficeList_ColumnHeader_7 As System.Windows.Forms.ColumnHeader
        Public WithEvents _OfficeList_ColumnHeader_8 As System.Windows.Forms.ColumnHeader
        Public WithEvents _OfficeList_ColumnHeader_9 As System.Windows.Forms.ColumnHeader
        Public WithEvents _OfficeList_ColumnHeader_10 As System.Windows.Forms.ColumnHeader
        Public WithEvents OfficeList As System.Windows.Forms.ListView
        Public WithEvents Add As System.Windows.Forms.ToolStripButton
        Public WithEvents Remove As System.Windows.Forms.ToolStripButton
        Public WithEvents _Toolbar1_Button3 As System.Windows.Forms.ToolStripSeparator
        Public WithEvents btnMoveUp As System.Windows.Forms.ToolStripButton
        Public WithEvents btnMoveDown As System.Windows.Forms.ToolStripButton
        Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
        Public WithEvents Label19 As System.Windows.Forms.Label
        Public WithEvents fraOffice As System.Windows.Forms.GroupBox
        Public WithEvents chkToll2 As System.Windows.Forms.CheckBox
        Public WithEvents chkToll1 As System.Windows.Forms.CheckBox
        Public WithEvents txtPrice As System.Windows.Forms.TextBox
        Public WithEvents txtSection As System.Windows.Forms.TextBox
        Public WithEvents optFirstSemester As System.Windows.Forms.RadioButton
        Public WithEvents optSecondSemester As System.Windows.Forms.RadioButton
        Public WithEvents cboGrade As System.Windows.Forms.ComboBox
        Public WithEvents cboSchools As System.Windows.Forms.ComboBox
        Public WithEvents cboNV As System.Windows.Forms.ComboBox
        Public WithEvents cboMat As System.Windows.Forms.ComboBox
        Public WithEvents cboLes As System.Windows.Forms.ComboBox
        Public WithEvents cboRen As System.Windows.Forms.ComboBox
        Public WithEvents Label6 As System.Windows.Forms.Label
        Public WithEvents Label7 As System.Windows.Forms.Label
        Public WithEvents Label8 As System.Windows.Forms.Label
        Public WithEvents Label9 As System.Windows.Forms.Label
        Public WithEvents Frame4 As System.Windows.Forms.GroupBox
        Public WithEvents Label18 As System.Windows.Forms.Label
        Public WithEvents Label17 As System.Windows.Forms.Label
        Public WithEvents Label11 As System.Windows.Forms.Label
        Public WithEvents Label10 As System.Windows.Forms.Label
        Public WithEvents Label5 As System.Windows.Forms.Label
        Public WithEvents Label4 As System.Windows.Forms.Label
        Public WithEvents Label3 As System.Windows.Forms.Label
        Public WithEvents Label1 As System.Windows.Forms.Label
        Public WithEvents fraNormal As System.Windows.Forms.GroupBox
        Public WithEvents optNormal As System.Windows.Forms.RadioButton
        Public WithEvents optEntrance As System.Windows.Forms.RadioButton
        Public WithEvents optOffice As System.Windows.Forms.RadioButton
        Public WithEvents Label13 As System.Windows.Forms.Label
        Public WithEvents fraType As System.Windows.Forms.GroupBox
        Public WithEvents Label15 As System.Windows.Forms.Label
        Public WithEvents fraFinish As System.Windows.Forms.GroupBox
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewJob))
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.Frame2 = New System.Windows.Forms.GroupBox()
            Me.lblDesc = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.cmdCancel = New System.Windows.Forms.Button()
            Me.Frame3 = New System.Windows.Forms.GroupBox()
            Me.cmdBack = New System.Windows.Forms.Button()
            Me.cmdNext = New System.Windows.Forms.Button()
            Me.fraReport = New System.Windows.Forms.GroupBox()
            Me.fraStudentCount = New System.Windows.Forms.GroupBox()
            Me.txtTotalStudents = New System.Windows.Forms.NumericUpDown()
            Me.txtFile = New System.Windows.Forms.TextBox()
            Me.chkPEP = New System.Windows.Forms.CheckBox()
            Me.chkAcomodo = New System.Windows.Forms.CheckBox()
            Me.txtDate = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.fraOffice = New System.Windows.Forms.GroupBox()
            Me.cboExaminerOT = New System.Windows.Forms.ComboBox()
            Me.OfficeList = New System.Windows.Forms.ListView()
            Me._OfficeList_ColumnHeader_1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._OfficeList_ColumnHeader_2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._OfficeList_ColumnHeader_3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._OfficeList_ColumnHeader_4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._OfficeList_ColumnHeader_5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._OfficeList_ColumnHeader_6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._OfficeList_ColumnHeader_7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._OfficeList_ColumnHeader_8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._OfficeList_ColumnHeader_9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._OfficeList_ColumnHeader_10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
            Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.Add = New System.Windows.Forms.ToolStripButton()
            Me.Remove = New System.Windows.Forms.ToolStripButton()
            Me._Toolbar1_Button3 = New System.Windows.Forms.ToolStripSeparator()
            Me.btnMoveUp = New System.Windows.Forms.ToolStripButton()
            Me.btnMoveDown = New System.Windows.Forms.ToolStripButton()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.fraNormal = New System.Windows.Forms.GroupBox()
            Me.cboConsultant3 = New System.Windows.Forms.ComboBox()
            Me.cboConsultant2 = New System.Windows.Forms.ComboBox()
            Me.cboConsultant = New System.Windows.Forms.ComboBox()
            Me.chkToll2 = New System.Windows.Forms.CheckBox()
            Me.chkToll1 = New System.Windows.Forms.CheckBox()
            Me.txtPrice = New System.Windows.Forms.TextBox()
            Me.txtSection = New System.Windows.Forms.TextBox()
            Me.optFirstSemester = New System.Windows.Forms.RadioButton()
            Me.optSecondSemester = New System.Windows.Forms.RadioButton()
            Me.cboGrade = New System.Windows.Forms.ComboBox()
            Me.cboSchools = New System.Windows.Forms.ComboBox()
            Me.Frame4 = New System.Windows.Forms.GroupBox()
            Me.cboNV = New System.Windows.Forms.ComboBox()
            Me.cboMat = New System.Windows.Forms.ComboBox()
            Me.cboLes = New System.Windows.Forms.ComboBox()
            Me.cboRen = New System.Windows.Forms.ComboBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.fraType = New System.Windows.Forms.GroupBox()
            Me.optNormal = New System.Windows.Forms.RadioButton()
            Me.optEntrance = New System.Windows.Forms.RadioButton()
            Me.optOffice = New System.Windows.Forms.RadioButton()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.fraFinish = New System.Windows.Forms.GroupBox()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.tvGroups = New System.Windows.Forms.TreeView()
            Me.Frame2.SuspendLayout()
            Me.Frame3.SuspendLayout()
            Me.fraReport.SuspendLayout()
            Me.fraStudentCount.SuspendLayout()
            CType(Me.txtTotalStudents, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.fraOffice.SuspendLayout()
            Me.Toolbar1.SuspendLayout()
            Me.fraNormal.SuspendLayout()
            Me.Frame4.SuspendLayout()
            Me.fraType.SuspendLayout()
            Me.fraFinish.SuspendLayout()
            Me.SuspendLayout()
            '
            'Frame2
            '
            Me.Frame2.BackColor = System.Drawing.Color.White
            Me.Frame2.Controls.Add(Me.lblDesc)
            Me.Frame2.Controls.Add(Me.Label12)
            Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Frame2.Location = New System.Drawing.Point(-24, -56)
            Me.Frame2.Name = "Frame2"
            Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
            Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Frame2.Size = New System.Drawing.Size(529, 121)
            Me.Frame2.TabIndex = 15
            Me.Frame2.TabStop = False
            Me.Frame2.Text = "Frame2"
            '
            'lblDesc
            '
            Me.lblDesc.BackColor = System.Drawing.Color.Transparent
            Me.lblDesc.Cursor = System.Windows.Forms.Cursors.Default
            Me.lblDesc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDesc.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblDesc.Location = New System.Drawing.Point(96, 88)
            Me.lblDesc.Name = "lblDesc"
            Me.lblDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.lblDesc.Size = New System.Drawing.Size(345, 25)
            Me.lblDesc.TabIndex = 17
            Me.lblDesc.Text = "Enter the following information"
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.Transparent
            Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label12.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label12.Location = New System.Drawing.Point(64, 64)
            Me.Label12.Name = "Label12"
            Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label12.Size = New System.Drawing.Size(113, 25)
            Me.Label12.TabIndex = 16
            Me.Label12.Text = "Creating a new Job"
            '
            'cmdCancel
            '
            Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
            Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdCancel.Location = New System.Drawing.Point(370, 21)
            Me.cmdCancel.Name = "cmdCancel"
            Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdCancel.Size = New System.Drawing.Size(89, 25)
            Me.cmdCancel.TabIndex = 14
            Me.cmdCancel.Text = "&Cancel"
            Me.cmdCancel.UseVisualStyleBackColor = False
            '
            'Frame3
            '
            Me.Frame3.BackColor = System.Drawing.SystemColors.Control
            Me.Frame3.Controls.Add(Me.cmdBack)
            Me.Frame3.Controls.Add(Me.cmdCancel)
            Me.Frame3.Controls.Add(Me.cmdNext)
            Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Frame3.Location = New System.Drawing.Point(12, 336)
            Me.Frame3.Name = "Frame3"
            Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
            Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Frame3.Size = New System.Drawing.Size(469, 61)
            Me.Frame3.TabIndex = 18
            Me.Frame3.TabStop = False
            '
            'cmdBack
            '
            Me.cmdBack.BackColor = System.Drawing.SystemColors.Control
            Me.cmdBack.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdBack.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdBack.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdBack.Location = New System.Drawing.Point(179, 21)
            Me.cmdBack.Name = "cmdBack"
            Me.cmdBack.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdBack.Size = New System.Drawing.Size(89, 25)
            Me.cmdBack.TabIndex = 35
            Me.cmdBack.Text = "&Back"
            Me.cmdBack.UseVisualStyleBackColor = False
            '
            'cmdNext
            '
            Me.cmdNext.BackColor = System.Drawing.SystemColors.Control
            Me.cmdNext.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdNext.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdNext.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdNext.Location = New System.Drawing.Point(275, 20)
            Me.cmdNext.Name = "cmdNext"
            Me.cmdNext.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdNext.Size = New System.Drawing.Size(89, 25)
            Me.cmdNext.TabIndex = 34
            Me.cmdNext.Text = "&Next"
            Me.cmdNext.UseVisualStyleBackColor = False
            '
            'fraReport
            '
            Me.fraReport.BackColor = System.Drawing.SystemColors.Control
            Me.fraReport.Controls.Add(Me.tvGroups)
            Me.fraReport.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.fraReport.ForeColor = System.Drawing.SystemColors.ControlText
            Me.fraReport.Location = New System.Drawing.Point(443, 399)
            Me.fraReport.Name = "fraReport"
            Me.fraReport.Padding = New System.Windows.Forms.Padding(0)
            Me.fraReport.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.fraReport.Size = New System.Drawing.Size(307, 217)
            Me.fraReport.TabIndex = 36
            Me.fraReport.TabStop = False
            Me.fraReport.Text = "Report"
            '
            'fraStudentCount
            '
            Me.fraStudentCount.BackColor = System.Drawing.SystemColors.Control
            Me.fraStudentCount.Controls.Add(Me.txtTotalStudents)
            Me.fraStudentCount.Controls.Add(Me.txtFile)
            Me.fraStudentCount.Controls.Add(Me.chkPEP)
            Me.fraStudentCount.Controls.Add(Me.chkAcomodo)
            Me.fraStudentCount.Controls.Add(Me.txtDate)
            Me.fraStudentCount.Controls.Add(Me.Label2)
            Me.fraStudentCount.Controls.Add(Me.Label16)
            Me.fraStudentCount.Controls.Add(Me.Label14)
            Me.fraStudentCount.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.fraStudentCount.ForeColor = System.Drawing.SystemColors.ControlText
            Me.fraStudentCount.Location = New System.Drawing.Point(756, 304)
            Me.fraStudentCount.Name = "fraStudentCount"
            Me.fraStudentCount.Padding = New System.Windows.Forms.Padding(0)
            Me.fraStudentCount.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.fraStudentCount.Size = New System.Drawing.Size(417, 225)
            Me.fraStudentCount.TabIndex = 40
            Me.fraStudentCount.TabStop = False
            Me.fraStudentCount.Text = "student count"
            '
            'txtTotalStudents
            '
            Me.txtTotalStudents.Location = New System.Drawing.Point(167, 42)
            Me.txtTotalStudents.Name = "txtTotalStudents"
            Me.txtTotalStudents.Size = New System.Drawing.Size(82, 23)
            Me.txtTotalStudents.TabIndex = 59
            '
            'txtFile
            '
            Me.txtFile.AcceptsReturn = True
            Me.txtFile.BackColor = System.Drawing.SystemColors.Window
            Me.txtFile.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtFile.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFile.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtFile.Location = New System.Drawing.Point(167, 100)
            Me.txtFile.MaxLength = 0
            Me.txtFile.Name = "txtFile"
            Me.txtFile.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtFile.Size = New System.Drawing.Size(81, 23)
            Me.txtFile.TabIndex = 57
            Me.txtFile.Tag = "Validate Text -Required -AllowLetters -MaxLength 4 -RequiredMsg File is a require" & _
        "d field! -InvalidValueMsg File field only accepts letters. -LengthMsg Maximum ch" & _
        "aracters allowed is 4."
            '
            'chkPEP
            '
            Me.chkPEP.BackColor = System.Drawing.SystemColors.Control
            Me.chkPEP.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkPEP.Cursor = System.Windows.Forms.Cursors.Default
            Me.chkPEP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkPEP.ForeColor = System.Drawing.SystemColors.ControlText
            Me.chkPEP.Location = New System.Drawing.Point(-8, 165)
            Me.chkPEP.Name = "chkPEP"
            Me.chkPEP.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.chkPEP.Size = New System.Drawing.Size(190, 35)
            Me.chkPEP.TabIndex = 56
            Me.chkPEP.Text = "                       PEP V"
            Me.chkPEP.UseVisualStyleBackColor = False
            '
            'chkAcomodo
            '
            Me.chkAcomodo.BackColor = System.Drawing.SystemColors.Control
            Me.chkAcomodo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkAcomodo.Cursor = System.Windows.Forms.Cursors.Default
            Me.chkAcomodo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkAcomodo.ForeColor = System.Drawing.SystemColors.ControlText
            Me.chkAcomodo.Location = New System.Drawing.Point(61, 127)
            Me.chkAcomodo.Name = "chkAcomodo"
            Me.chkAcomodo.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.chkAcomodo.Size = New System.Drawing.Size(121, 41)
            Me.chkAcomodo.TabIndex = 50
            Me.chkAcomodo.Text = "Acomodo Razonable"
            Me.chkAcomodo.UseVisualStyleBackColor = False
            '
            'txtDate
            '
            Me.txtDate.AcceptsReturn = True
            Me.txtDate.BackColor = System.Drawing.SystemColors.Window
            Me.txtDate.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtDate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDate.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtDate.Location = New System.Drawing.Point(167, 71)
            Me.txtDate.MaxLength = 0
            Me.txtDate.Name = "txtDate"
            Me.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtDate.Size = New System.Drawing.Size(81, 23)
            Me.txtDate.TabIndex = 13
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.SystemColors.Control
            Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label2.Location = New System.Drawing.Point(104, 103)
            Me.Label2.Name = "Label2"
            Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label2.Size = New System.Drawing.Size(57, 25)
            Me.Label2.TabIndex = 58
            Me.Label2.Text = "File:"
            '
            'Label16
            '
            Me.Label16.BackColor = System.Drawing.SystemColors.Control
            Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label16.Location = New System.Drawing.Point(80, 74)
            Me.Label16.Name = "Label16"
            Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label16.Size = New System.Drawing.Size(73, 17)
            Me.Label16.TabIndex = 49
            Me.Label16.Text = "Service Date:"
            '
            'Label14
            '
            Me.Label14.BackColor = System.Drawing.SystemColors.Control
            Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label14.Location = New System.Drawing.Point(3, 44)
            Me.Label14.Name = "Label14"
            Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label14.Size = New System.Drawing.Size(137, 28)
            Me.Label14.TabIndex = 42
            Me.Label14.Text = "Number of Students:"
            '
            'fraOffice
            '
            Me.fraOffice.BackColor = System.Drawing.SystemColors.Control
            Me.fraOffice.Controls.Add(Me.cboExaminerOT)
            Me.fraOffice.Controls.Add(Me.OfficeList)
            Me.fraOffice.Controls.Add(Me.Toolbar1)
            Me.fraOffice.Controls.Add(Me.Label19)
            Me.fraOffice.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.fraOffice.ForeColor = System.Drawing.SystemColors.ControlText
            Me.fraOffice.Location = New System.Drawing.Point(531, 12)
            Me.fraOffice.Name = "fraOffice"
            Me.fraOffice.Padding = New System.Windows.Forms.Padding(0)
            Me.fraOffice.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.fraOffice.Size = New System.Drawing.Size(449, 253)
            Me.fraOffice.TabIndex = 39
            Me.fraOffice.TabStop = False
            Me.fraOffice.Text = "office"
            '
            'cboExaminerOT
            '
            Me.cboExaminerOT.BackColor = System.Drawing.SystemColors.Window
            Me.cboExaminerOT.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboExaminerOT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboExaminerOT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboExaminerOT.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboExaminerOT.Location = New System.Drawing.Point(91, 213)
            Me.cboExaminerOT.Name = "cboExaminerOT"
            Me.cboExaminerOT.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboExaminerOT.Size = New System.Drawing.Size(233, 24)
            Me.cboExaminerOT.TabIndex = 60
            Me.cboExaminerOT.Tag = "Validate Text -Required -RequiredMsg The Examiner is a required field!"
            '
            'OfficeList
            '
            Me.OfficeList.BackColor = System.Drawing.SystemColors.Window
            Me.OfficeList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._OfficeList_ColumnHeader_1, Me._OfficeList_ColumnHeader_2, Me._OfficeList_ColumnHeader_3, Me._OfficeList_ColumnHeader_4, Me._OfficeList_ColumnHeader_5, Me._OfficeList_ColumnHeader_6, Me._OfficeList_ColumnHeader_7, Me._OfficeList_ColumnHeader_8, Me._OfficeList_ColumnHeader_9, Me._OfficeList_ColumnHeader_10})
            Me.OfficeList.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.OfficeList.ForeColor = System.Drawing.SystemColors.WindowText
            Me.OfficeList.FullRowSelect = True
            Me.OfficeList.GridLines = True
            Me.OfficeList.HideSelection = False
            Me.OfficeList.Location = New System.Drawing.Point(6, 41)
            Me.OfficeList.Name = "OfficeList"
            Me.OfficeList.Size = New System.Drawing.Size(439, 161)
            Me.OfficeList.TabIndex = 45
            Me.OfficeList.UseCompatibleStateImageBehavior = False
            Me.OfficeList.View = System.Windows.Forms.View.Details
            '
            '_OfficeList_ColumnHeader_1
            '
            Me._OfficeList_ColumnHeader_1.Text = "Name"
            Me._OfficeList_ColumnHeader_1.Width = 170
            '
            '_OfficeList_ColumnHeader_2
            '
            Me._OfficeList_ColumnHeader_2.Text = "School"
            Me._OfficeList_ColumnHeader_2.Width = 170
            '
            '_OfficeList_ColumnHeader_3
            '
            Me._OfficeList_ColumnHeader_3.Text = "Grade"
            Me._OfficeList_ColumnHeader_3.Width = 170
            '
            '_OfficeList_ColumnHeader_4
            '
            Me._OfficeList_ColumnHeader_4.Text = "Semester"
            Me._OfficeList_ColumnHeader_4.Width = 170
            '
            '_OfficeList_ColumnHeader_5
            '
            Me._OfficeList_ColumnHeader_5.Width = 0
            '
            '_OfficeList_ColumnHeader_6
            '
            Me._OfficeList_ColumnHeader_6.Text = "MAT"
            Me._OfficeList_ColumnHeader_6.Width = 170
            '
            '_OfficeList_ColumnHeader_7
            '
            Me._OfficeList_ColumnHeader_7.Text = "NV"
            Me._OfficeList_ColumnHeader_7.Width = 170
            '
            '_OfficeList_ColumnHeader_8
            '
            Me._OfficeList_ColumnHeader_8.Text = "LES"
            Me._OfficeList_ColumnHeader_8.Width = 170
            '
            '_OfficeList_ColumnHeader_9
            '
            Me._OfficeList_ColumnHeader_9.Text = "REN"
            Me._OfficeList_ColumnHeader_9.Width = 170
            '
            '_OfficeList_ColumnHeader_10
            '
            Me._OfficeList_ColumnHeader_10.Text = "Battery"
            Me._OfficeList_ColumnHeader_10.Width = 170
            '
            'Toolbar1
            '
            Me.Toolbar1.ImageList = Me.ImageList1
            Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Add, Me.Remove, Me._Toolbar1_Button3, Me.btnMoveUp, Me.btnMoveDown})
            Me.Toolbar1.Location = New System.Drawing.Point(0, 16)
            Me.Toolbar1.Name = "Toolbar1"
            Me.Toolbar1.Size = New System.Drawing.Size(449, 25)
            Me.Toolbar1.TabIndex = 47
            '
            'ImageList1
            '
            Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageList1.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.ImageList1.Images.SetKeyName(0, "")
            Me.ImageList1.Images.SetKeyName(1, "")
            Me.ImageList1.Images.SetKeyName(2, "")
            Me.ImageList1.Images.SetKeyName(3, "")
            Me.ImageList1.Images.SetKeyName(4, "")
            '
            'Add
            '
            Me.Add.AutoSize = False
            Me.Add.Image = Global.learnAid.My.Resources.Resources.new1
            Me.Add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.Add.Name = "Add"
            Me.Add.Size = New System.Drawing.Size(86, 21)
            Me.Add.Text = "Add           "
            '
            'Remove
            '
            Me.Remove.AutoSize = False
            Me.Remove.Image = Global.learnAid.My.Resources.Resources.delete
            Me.Remove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.Remove.Name = "Remove"
            Me.Remove.Size = New System.Drawing.Size(86, 21)
            Me.Remove.Text = "Remove     "
            '
            '_Toolbar1_Button3
            '
            Me._Toolbar1_Button3.AutoSize = False
            Me._Toolbar1_Button3.Name = "_Toolbar1_Button3"
            Me._Toolbar1_Button3.Size = New System.Drawing.Size(20, 21)
            '
            'btnMoveUp
            '
            Me.btnMoveUp.AutoSize = False
            Me.btnMoveUp.Image = Global.learnAid.My.Resources.Resources.BtnUp
            Me.btnMoveUp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnMoveUp.Name = "btnMoveUp"
            Me.btnMoveUp.Size = New System.Drawing.Size(86, 21)
            Me.btnMoveUp.Text = "Move Up    "
            '
            'btnMoveDown
            '
            Me.btnMoveDown.AutoSize = False
            Me.btnMoveDown.Image = Global.learnAid.My.Resources.Resources.BtnDown
            Me.btnMoveDown.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.btnMoveDown.Name = "btnMoveDown"
            Me.btnMoveDown.Size = New System.Drawing.Size(86, 21)
            Me.btnMoveDown.Text = "Move Down"
            '
            'Label19
            '
            Me.Label19.BackColor = System.Drawing.SystemColors.Control
            Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label19.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label19.Location = New System.Drawing.Point(11, 216)
            Me.Label19.Name = "Label19"
            Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label19.Size = New System.Drawing.Size(97, 33)
            Me.Label19.TabIndex = 59
            Me.Label19.Text = "Examiner:"
            '
            'fraNormal
            '
            Me.fraNormal.BackColor = System.Drawing.SystemColors.Control
            Me.fraNormal.Controls.Add(Me.cboConsultant3)
            Me.fraNormal.Controls.Add(Me.cboConsultant2)
            Me.fraNormal.Controls.Add(Me.cboConsultant)
            Me.fraNormal.Controls.Add(Me.chkToll2)
            Me.fraNormal.Controls.Add(Me.chkToll1)
            Me.fraNormal.Controls.Add(Me.txtPrice)
            Me.fraNormal.Controls.Add(Me.txtSection)
            Me.fraNormal.Controls.Add(Me.optFirstSemester)
            Me.fraNormal.Controls.Add(Me.optSecondSemester)
            Me.fraNormal.Controls.Add(Me.cboGrade)
            Me.fraNormal.Controls.Add(Me.cboSchools)
            Me.fraNormal.Controls.Add(Me.Frame4)
            Me.fraNormal.Controls.Add(Me.Label18)
            Me.fraNormal.Controls.Add(Me.Label17)
            Me.fraNormal.Controls.Add(Me.Label11)
            Me.fraNormal.Controls.Add(Me.Label10)
            Me.fraNormal.Controls.Add(Me.Label5)
            Me.fraNormal.Controls.Add(Me.Label4)
            Me.fraNormal.Controls.Add(Me.Label3)
            Me.fraNormal.Controls.Add(Me.Label1)
            Me.fraNormal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.fraNormal.ForeColor = System.Drawing.SystemColors.ControlText
            Me.fraNormal.Location = New System.Drawing.Point(12, 404)
            Me.fraNormal.Name = "fraNormal"
            Me.fraNormal.Padding = New System.Windows.Forms.Padding(0)
            Me.fraNormal.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.fraNormal.Size = New System.Drawing.Size(425, 273)
            Me.fraNormal.TabIndex = 19
            Me.fraNormal.TabStop = False
            Me.fraNormal.Text = "normal"
            '
            'cboConsultant3
            '
            Me.cboConsultant3.FormattingEnabled = True
            Me.cboConsultant3.Location = New System.Drawing.Point(104, 234)
            Me.cboConsultant3.Name = "cboConsultant3"
            Me.cboConsultant3.Size = New System.Drawing.Size(121, 24)
            Me.cboConsultant3.TabIndex = 58
            '
            'cboConsultant2
            '
            Me.cboConsultant2.FormattingEnabled = True
            Me.cboConsultant2.Location = New System.Drawing.Point(104, 207)
            Me.cboConsultant2.Name = "cboConsultant2"
            Me.cboConsultant2.Size = New System.Drawing.Size(121, 24)
            Me.cboConsultant2.TabIndex = 57
            '
            'cboConsultant
            '
            Me.cboConsultant.FormattingEnabled = True
            Me.cboConsultant.Location = New System.Drawing.Point(104, 186)
            Me.cboConsultant.Name = "cboConsultant"
            Me.cboConsultant.Size = New System.Drawing.Size(121, 24)
            Me.cboConsultant.TabIndex = 56
            '
            'chkToll2
            '
            Me.chkToll2.BackColor = System.Drawing.SystemColors.Control
            Me.chkToll2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkToll2.Cursor = System.Windows.Forms.Cursors.Default
            Me.chkToll2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkToll2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.chkToll2.Location = New System.Drawing.Point(264, 210)
            Me.chkToll2.Name = "chkToll2"
            Me.chkToll2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.chkToll2.Size = New System.Drawing.Size(65, 17)
            Me.chkToll2.TabIndex = 55
            Me.chkToll2.Text = "Paid Toll"
            Me.chkToll2.UseVisualStyleBackColor = False
            '
            'chkToll1
            '
            Me.chkToll1.BackColor = System.Drawing.SystemColors.Control
            Me.chkToll1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkToll1.Cursor = System.Windows.Forms.Cursors.Default
            Me.chkToll1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkToll1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.chkToll1.Location = New System.Drawing.Point(264, 186)
            Me.chkToll1.Name = "chkToll1"
            Me.chkToll1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.chkToll1.Size = New System.Drawing.Size(65, 17)
            Me.chkToll1.TabIndex = 54
            Me.chkToll1.Text = "Paid Toll"
            Me.chkToll1.UseVisualStyleBackColor = False
            '
            'txtPrice
            '
            Me.txtPrice.AcceptsReturn = True
            Me.txtPrice.BackColor = System.Drawing.SystemColors.Window
            Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtPrice.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPrice.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtPrice.Location = New System.Drawing.Point(328, 236)
            Me.txtPrice.MaxLength = 0
            Me.txtPrice.Name = "txtPrice"
            Me.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtPrice.Size = New System.Drawing.Size(57, 23)
            Me.txtPrice.TabIndex = 11
            '
            'txtSection
            '
            Me.txtSection.AcceptsReturn = True
            Me.txtSection.BackColor = System.Drawing.SystemColors.Window
            Me.txtSection.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtSection.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSection.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtSection.Location = New System.Drawing.Point(359, 37)
            Me.txtSection.MaxLength = 0
            Me.txtSection.Name = "txtSection"
            Me.txtSection.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtSection.Size = New System.Drawing.Size(41, 23)
            Me.txtSection.TabIndex = 2
            Me.txtSection.Tag = "Validate Text -Required -AllowLetters -AllowDigits -RequiredMsg Section is a requ" & _
        "ired field! -InvalidValueMsg Section field doesn't allow accentuation or special" & _
        " characters."
            Me.txtSection.Text = "1"
            '
            'optFirstSemester
            '
            Me.optFirstSemester.BackColor = System.Drawing.SystemColors.Control
            Me.optFirstSemester.Checked = True
            Me.optFirstSemester.Cursor = System.Windows.Forms.Cursors.Default
            Me.optFirstSemester.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.optFirstSemester.ForeColor = System.Drawing.SystemColors.ControlText
            Me.optFirstSemester.Location = New System.Drawing.Point(80, 65)
            Me.optFirstSemester.Name = "optFirstSemester"
            Me.optFirstSemester.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.optFirstSemester.Size = New System.Drawing.Size(97, 24)
            Me.optFirstSemester.TabIndex = 3
            Me.optFirstSemester.TabStop = True
            Me.optFirstSemester.Text = "First Semester"
            Me.optFirstSemester.UseVisualStyleBackColor = False
            '
            'optSecondSemester
            '
            Me.optSecondSemester.BackColor = System.Drawing.SystemColors.Control
            Me.optSecondSemester.Cursor = System.Windows.Forms.Cursors.Default
            Me.optSecondSemester.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.optSecondSemester.ForeColor = System.Drawing.SystemColors.ControlText
            Me.optSecondSemester.Location = New System.Drawing.Point(183, 65)
            Me.optSecondSemester.Name = "optSecondSemester"
            Me.optSecondSemester.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.optSecondSemester.Size = New System.Drawing.Size(137, 24)
            Me.optSecondSemester.TabIndex = 4
            Me.optSecondSemester.TabStop = True
            Me.optSecondSemester.Text = "Second Semester"
            Me.optSecondSemester.UseVisualStyleBackColor = False
            '
            'cboGrade
            '
            Me.cboGrade.BackColor = System.Drawing.SystemColors.Window
            Me.cboGrade.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboGrade.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboGrade.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboGrade.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
            Me.cboGrade.Location = New System.Drawing.Point(72, 40)
            Me.cboGrade.Name = "cboGrade"
            Me.cboGrade.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboGrade.Size = New System.Drawing.Size(218, 24)
            Me.cboGrade.TabIndex = 1
            Me.cboGrade.Tag = "Validate Text -Required -RequiredMsg Grade is a required field!"
            '
            'cboSchools
            '
            Me.cboSchools.BackColor = System.Drawing.SystemColors.Window
            Me.cboSchools.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboSchools.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboSchools.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboSchools.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboSchools.Location = New System.Drawing.Point(72, 15)
            Me.cboSchools.Name = "cboSchools"
            Me.cboSchools.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboSchools.Size = New System.Drawing.Size(218, 24)
            Me.cboSchools.TabIndex = 0
            Me.cboSchools.Tag = "Validate Text -Required -RequiredMsg School is a required field!"
            '
            'Frame4
            '
            Me.Frame4.BackColor = System.Drawing.SystemColors.Control
            Me.Frame4.Controls.Add(Me.cboNV)
            Me.Frame4.Controls.Add(Me.cboMat)
            Me.Frame4.Controls.Add(Me.cboLes)
            Me.Frame4.Controls.Add(Me.cboRen)
            Me.Frame4.Controls.Add(Me.Label6)
            Me.Frame4.Controls.Add(Me.Label7)
            Me.Frame4.Controls.Add(Me.Label8)
            Me.Frame4.Controls.Add(Me.Label9)
            Me.Frame4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Frame4.Location = New System.Drawing.Point(32, 86)
            Me.Frame4.Name = "Frame4"
            Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
            Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Frame4.Size = New System.Drawing.Size(369, 89)
            Me.Frame4.TabIndex = 20
            Me.Frame4.TabStop = False
            Me.Frame4.Text = "BAT Configuration"
            '
            'cboNV
            '
            Me.cboNV.BackColor = System.Drawing.SystemColors.Window
            Me.cboNV.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboNV.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboNV.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboNV.Location = New System.Drawing.Point(56, 24)
            Me.cboNV.Name = "cboNV"
            Me.cboNV.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboNV.Size = New System.Drawing.Size(89, 24)
            Me.cboNV.TabIndex = 5
            '
            'cboMat
            '
            Me.cboMat.BackColor = System.Drawing.SystemColors.Window
            Me.cboMat.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboMat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboMat.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboMat.Location = New System.Drawing.Point(56, 56)
            Me.cboMat.Name = "cboMat"
            Me.cboMat.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboMat.Size = New System.Drawing.Size(89, 24)
            Me.cboMat.TabIndex = 6
            '
            'cboLes
            '
            Me.cboLes.BackColor = System.Drawing.SystemColors.Window
            Me.cboLes.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboLes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboLes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboLes.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboLes.Location = New System.Drawing.Point(240, 24)
            Me.cboLes.Name = "cboLes"
            Me.cboLes.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboLes.Size = New System.Drawing.Size(89, 24)
            Me.cboLes.TabIndex = 7
            '
            'cboRen
            '
            Me.cboRen.BackColor = System.Drawing.SystemColors.Window
            Me.cboRen.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboRen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboRen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboRen.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboRen.Location = New System.Drawing.Point(240, 56)
            Me.cboRen.Name = "cboRen"
            Me.cboRen.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboRen.Size = New System.Drawing.Size(89, 24)
            Me.cboRen.TabIndex = 8
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label6.Location = New System.Drawing.Point(-24, 24)
            Me.Label6.Name = "Label6"
            Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label6.Size = New System.Drawing.Size(73, 17)
            Me.Label6.TabIndex = 24
            Me.Label6.Text = "NV:"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label7.Location = New System.Drawing.Point(160, 24)
            Me.Label7.Name = "Label7"
            Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label7.Size = New System.Drawing.Size(73, 17)
            Me.Label7.TabIndex = 23
            Me.Label7.Text = "LES:"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label8.Location = New System.Drawing.Point(-24, 56)
            Me.Label8.Name = "Label8"
            Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label8.Size = New System.Drawing.Size(73, 17)
            Me.Label8.TabIndex = 22
            Me.Label8.Text = "MAT:"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label9.Location = New System.Drawing.Point(160, 56)
            Me.Label9.Name = "Label9"
            Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label9.Size = New System.Drawing.Size(73, 17)
            Me.Label9.TabIndex = 21
            Me.Label9.Text = "REN:"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label18
            '
            Me.Label18.BackColor = System.Drawing.SystemColors.Control
            Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label18.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label18.Location = New System.Drawing.Point(24, 210)
            Me.Label18.Name = "Label18"
            Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label18.Size = New System.Drawing.Size(73, 20)
            Me.Label18.TabIndex = 53
            Me.Label18.Text = "Examiner 2:"
            '
            'Label17
            '
            Me.Label17.BackColor = System.Drawing.SystemColors.Control
            Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label17.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label17.Location = New System.Drawing.Point(27, 234)
            Me.Label17.Name = "Label17"
            Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label17.Size = New System.Drawing.Size(99, 25)
            Me.Label17.TabIndex = 52
            Me.Label17.Text = "In Charge:"
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.SystemColors.Control
            Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label11.Location = New System.Drawing.Point(255, 234)
            Me.Label11.Name = "Label11"
            Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label11.Size = New System.Drawing.Size(98, 39)
            Me.Label11.TabIndex = 48
            Me.Label11.Text = "Price per Student:"
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.SystemColors.Control
            Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label10.Location = New System.Drawing.Point(24, 186)
            Me.Label10.Name = "Label10"
            Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label10.Size = New System.Drawing.Size(73, 17)
            Me.Label10.TabIndex = 29
            Me.Label10.Text = "Examiner:"
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.SystemColors.Control
            Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label5.Location = New System.Drawing.Point(32, 120)
            Me.Label5.Name = "Label5"
            Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label5.Size = New System.Drawing.Size(81, 17)
            Me.Label5.TabIndex = 28
            Me.Label5.Text = "Exam:"
            Me.Label5.Visible = False
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.SystemColors.Control
            Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label4.Location = New System.Drawing.Point(296, 40)
            Me.Label4.Name = "Label4"
            Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label4.Size = New System.Drawing.Size(57, 17)
            Me.Label4.TabIndex = 27
            Me.Label4.Text = "Section:"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.SystemColors.Control
            Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label3.Location = New System.Drawing.Point(8, 40)
            Me.Label3.Name = "Label3"
            Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label3.Size = New System.Drawing.Size(58, 23)
            Me.Label3.TabIndex = 26
            Me.Label3.Text = "Grade:"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.SystemColors.Control
            Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label1.Location = New System.Drawing.Point(8, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label1.Size = New System.Drawing.Size(73, 17)
            Me.Label1.TabIndex = 25
            Me.Label1.Text = "School:"
            '
            'fraType
            '
            Me.fraType.BackColor = System.Drawing.SystemColors.Control
            Me.fraType.Controls.Add(Me.optNormal)
            Me.fraType.Controls.Add(Me.optEntrance)
            Me.fraType.Controls.Add(Me.optOffice)
            Me.fraType.Controls.Add(Me.Label13)
            Me.fraType.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.fraType.ForeColor = System.Drawing.SystemColors.ControlText
            Me.fraType.Location = New System.Drawing.Point(12, 64)
            Me.fraType.Name = "fraType"
            Me.fraType.Padding = New System.Windows.Forms.Padding(0)
            Me.fraType.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.fraType.Size = New System.Drawing.Size(469, 273)
            Me.fraType.TabIndex = 30
            Me.fraType.TabStop = False
            Me.fraType.Text = "Type"
            '
            'optNormal
            '
            Me.optNormal.BackColor = System.Drawing.SystemColors.Control
            Me.optNormal.Checked = True
            Me.optNormal.Cursor = System.Windows.Forms.Cursors.Default
            Me.optNormal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.optNormal.ForeColor = System.Drawing.SystemColors.ControlText
            Me.optNormal.Location = New System.Drawing.Point(136, 145)
            Me.optNormal.Name = "optNormal"
            Me.optNormal.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.optNormal.Size = New System.Drawing.Size(113, 27)
            Me.optNormal.TabIndex = 33
            Me.optNormal.TabStop = True
            Me.optNormal.Text = "Regular"
            Me.optNormal.UseVisualStyleBackColor = False
            '
            'optEntrance
            '
            Me.optEntrance.BackColor = System.Drawing.SystemColors.Control
            Me.optEntrance.Cursor = System.Windows.Forms.Cursors.Default
            Me.optEntrance.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.optEntrance.ForeColor = System.Drawing.SystemColors.ControlText
            Me.optEntrance.Location = New System.Drawing.Point(136, 111)
            Me.optEntrance.Name = "optEntrance"
            Me.optEntrance.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.optEntrance.Size = New System.Drawing.Size(121, 17)
            Me.optEntrance.TabIndex = 32
            Me.optEntrance.TabStop = True
            Me.optEntrance.Text = "Entrance"
            Me.optEntrance.UseVisualStyleBackColor = False
            '
            'optOffice
            '
            Me.optOffice.BackColor = System.Drawing.SystemColors.Control
            Me.optOffice.CheckAlign = System.Drawing.ContentAlignment.TopLeft
            Me.optOffice.Cursor = System.Windows.Forms.Cursors.Default
            Me.optOffice.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.optOffice.ForeColor = System.Drawing.SystemColors.ControlText
            Me.optOffice.Location = New System.Drawing.Point(136, 68)
            Me.optOffice.Name = "optOffice"
            Me.optOffice.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.optOffice.Size = New System.Drawing.Size(89, 25)
            Me.optOffice.TabIndex = 31
            Me.optOffice.TabStop = True
            Me.optOffice.Text = "Office Testing"
            Me.optOffice.UseVisualStyleBackColor = False
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.SystemColors.Control
            Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label13.Location = New System.Drawing.Point(60, 16)
            Me.Label13.Name = "Label13"
            Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label13.Size = New System.Drawing.Size(97, 25)
            Me.Label13.TabIndex = 41
            Me.Label13.Text = "Select the job type:"
            '
            'fraFinish
            '
            Me.fraFinish.BackColor = System.Drawing.SystemColors.Control
            Me.fraFinish.Controls.Add(Me.Label15)
            Me.fraFinish.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.fraFinish.ForeColor = System.Drawing.SystemColors.ControlText
            Me.fraFinish.Location = New System.Drawing.Point(500, 294)
            Me.fraFinish.Name = "fraFinish"
            Me.fraFinish.Padding = New System.Windows.Forms.Padding(0)
            Me.fraFinish.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.fraFinish.Size = New System.Drawing.Size(209, 57)
            Me.fraFinish.TabIndex = 37
            Me.fraFinish.TabStop = False
            Me.fraFinish.Text = "finish"
            '
            'Label15
            '
            Me.Label15.BackColor = System.Drawing.SystemColors.Control
            Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label15.Location = New System.Drawing.Point(88, 80)
            Me.Label15.Name = "Label15"
            Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label15.Size = New System.Drawing.Size(209, 81)
            Me.Label15.TabIndex = 43
            Me.Label15.Text = "     The process to create a new Job was finished. Press the Finish button to sav" & _
        "e and return to the application."
            '
            'tvGroups
            '
            Me.tvGroups.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.tvGroups.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tvGroups.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tvGroups.LabelEdit = True
            Me.tvGroups.Location = New System.Drawing.Point(0, 16)
            Me.tvGroups.Name = "tvGroups"
            Me.tvGroups.Size = New System.Drawing.Size(307, 201)
            Me.tvGroups.TabIndex = 46
            '
            'frmNewJob
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.ClientSize = New System.Drawing.Size(1072, 732)
            Me.Controls.Add(Me.Frame2)
            Me.Controls.Add(Me.fraReport)
            Me.Controls.Add(Me.fraStudentCount)
            Me.Controls.Add(Me.fraOffice)
            Me.Controls.Add(Me.fraNormal)
            Me.Controls.Add(Me.fraType)
            Me.Controls.Add(Me.fraFinish)
            Me.Controls.Add(Me.Frame3)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Location = New System.Drawing.Point(4, 23)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmNewJob"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Add Job"
            Me.Frame2.ResumeLayout(False)
            Me.Frame3.ResumeLayout(False)
            Me.fraReport.ResumeLayout(False)
            Me.fraStudentCount.ResumeLayout(False)
            Me.fraStudentCount.PerformLayout()
            CType(Me.txtTotalStudents, System.ComponentModel.ISupportInitialize).EndInit()
            Me.fraOffice.ResumeLayout(False)
            Me.fraOffice.PerformLayout()
            Me.Toolbar1.ResumeLayout(False)
            Me.Toolbar1.PerformLayout()
            Me.fraNormal.ResumeLayout(False)
            Me.fraNormal.PerformLayout()
            Me.Frame4.ResumeLayout(False)
            Me.fraType.ResumeLayout(False)
            Me.fraFinish.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents cboConsultant As System.Windows.Forms.ComboBox
        Friend WithEvents cboConsultant3 As System.Windows.Forms.ComboBox
        Friend WithEvents cboConsultant2 As System.Windows.Forms.ComboBox
        Friend WithEvents txtTotalStudents As System.Windows.Forms.NumericUpDown
        Public WithEvents tvGroups As System.Windows.Forms.TreeView
#End Region
    End Class
End Namespace