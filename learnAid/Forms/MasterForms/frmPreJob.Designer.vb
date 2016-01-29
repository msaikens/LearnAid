Namespace Forms.MasterForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPreJob
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
        Public WithEvents cboBattery As System.Windows.Forms.ComboBox
        Public WithEvents chkEntrance As System.Windows.Forms.CheckBox
        Public WithEvents chkPEP As System.Windows.Forms.CheckBox
        Public WithEvents chkToll2 As System.Windows.Forms.CheckBox
        Public WithEvents chkToll1 As System.Windows.Forms.CheckBox
        Public WithEvents cboConsultant3 As System.Windows.Forms.ComboBox
        Public WithEvents chkAcomodo As System.Windows.Forms.CheckBox
        Public WithEvents cmdProgram As System.Windows.Forms.Button
        Public WithEvents txtPrice As System.Windows.Forms.TextBox
        Public WithEvents Command1 As System.Windows.Forms.Button
        Public WithEvents cmdCancel As System.Windows.Forms.Button
        Public WithEvents cmdOK As System.Windows.Forms.Button
        Public WithEvents cboNV As System.Windows.Forms.ComboBox
        Public WithEvents cboMat As System.Windows.Forms.ComboBox
        Public WithEvents cboLes As System.Windows.Forms.ComboBox
        Public WithEvents cboRen As System.Windows.Forms.ComboBox
        Public WithEvents cboSchools As System.Windows.Forms.ComboBox
        Public WithEvents cboGrade As System.Windows.Forms.ComboBox
        Public WithEvents cboSemester As System.Windows.Forms.ComboBox
        Public WithEvents txtSection As System.Windows.Forms.TextBox
        Public WithEvents txtTotalStudents As System.Windows.Forms.TextBox
        Public WithEvents txtFile As System.Windows.Forms.TextBox
        Public WithEvents cboConsultant2 As System.Windows.Forms.ComboBox
        Public WithEvents cboConsultant As System.Windows.Forms.ComboBox
        Public WithEvents _LVDetails_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVDetails_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVDetails_ColumnHeader_3 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVDetails_ColumnHeader_4 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVDetails_ColumnHeader_5 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVDetails_ColumnHeader_6 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVDetails_ColumnHeader_7 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVDetails_ColumnHeader_8 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVDetails_ColumnHeader_9 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVDetails_ColumnHeader_10 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVDetails_ColumnHeader_11 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVDetails_ColumnHeader_12 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVDetails_ColumnHeader_13 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVDetails_ColumnHeader_14 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVDetails_ColumnHeader_15 As System.Windows.Forms.ColumnHeader
        Public WithEvents LVDetails As System.Windows.Forms.ListView
        'Public WithEvents imgTool As System.Windows.Forms.ImageList
        Public WithEvents BtnNew As System.Windows.Forms.ToolStripButton
        Public WithEvents _Toolbar1_Button2 As System.Windows.Forms.ToolStripSeparator
        Public WithEvents BtnEdit As System.Windows.Forms.ToolStripButton
        Public WithEvents _Toolbar1_Button4 As System.Windows.Forms.ToolStripSeparator
        Public WithEvents BtnDel As System.Windows.Forms.ToolStripButton
        Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
        Public WithEvents lblbattery As System.Windows.Forms.Label
        Public WithEvents Label15 As System.Windows.Forms.Label
        Public WithEvents Label14 As System.Windows.Forms.Label
        Public WithEvents Label13 As System.Windows.Forms.Label
        Public WithEvents Label6 As System.Windows.Forms.Label
        Public WithEvents Label7 As System.Windows.Forms.Label
        Public WithEvents Label8 As System.Windows.Forms.Label
        Public WithEvents Label9 As System.Windows.Forms.Label
        Public WithEvents Label1 As System.Windows.Forms.Label
        Public WithEvents Label3 As System.Windows.Forms.Label
        Public WithEvents Label4 As System.Windows.Forms.Label
        Public WithEvents Label2 As System.Windows.Forms.Label
        Public WithEvents Label5 As System.Windows.Forms.Label
        Public WithEvents Label10 As System.Windows.Forms.Label
        Public WithEvents Label12 As System.Windows.Forms.Label
        Public WithEvents Label11 As System.Windows.Forms.Label
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.cboBattery = New System.Windows.Forms.ComboBox()
            Me.chkEntrance = New System.Windows.Forms.CheckBox()
            Me.chkPEP = New System.Windows.Forms.CheckBox()
            Me.chkToll2 = New System.Windows.Forms.CheckBox()
            Me.chkToll1 = New System.Windows.Forms.CheckBox()
            Me.cboConsultant3 = New System.Windows.Forms.ComboBox()
            Me.chkAcomodo = New System.Windows.Forms.CheckBox()
            Me.cmdProgram = New System.Windows.Forms.Button()
            Me.txtPrice = New System.Windows.Forms.TextBox()
            Me.Command1 = New System.Windows.Forms.Button()
            Me.cmdCancel = New System.Windows.Forms.Button()
            Me.cmdOK = New System.Windows.Forms.Button()
            Me.cboNV = New System.Windows.Forms.ComboBox()
            Me.cboMat = New System.Windows.Forms.ComboBox()
            Me.cboLes = New System.Windows.Forms.ComboBox()
            Me.cboRen = New System.Windows.Forms.ComboBox()
            Me.cboSchools = New System.Windows.Forms.ComboBox()
            Me.cboGrade = New System.Windows.Forms.ComboBox()
            Me.cboSemester = New System.Windows.Forms.ComboBox()
            Me.txtSection = New System.Windows.Forms.TextBox()
            Me.txtTotalStudents = New System.Windows.Forms.TextBox()
            Me.txtFile = New System.Windows.Forms.TextBox()
            Me.cboConsultant2 = New System.Windows.Forms.ComboBox()
            Me.cboConsultant = New System.Windows.Forms.ComboBox()
            Me.LVDetails = New System.Windows.Forms.ListView()
            Me._LVDetails_ColumnHeader_1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVDetails_ColumnHeader_2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVDetails_ColumnHeader_3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVDetails_ColumnHeader_4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVDetails_ColumnHeader_5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVDetails_ColumnHeader_6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVDetails_ColumnHeader_7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVDetails_ColumnHeader_8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVDetails_ColumnHeader_9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVDetails_ColumnHeader_10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVDetails_ColumnHeader_11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVDetails_ColumnHeader_12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVDetails_ColumnHeader_13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVDetails_ColumnHeader_14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVDetails_ColumnHeader_15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
            Me.BtnNew = New System.Windows.Forms.ToolStripButton()
            Me._Toolbar1_Button2 = New System.Windows.Forms.ToolStripSeparator()
            Me.BtnEdit = New System.Windows.Forms.ToolStripButton()
            Me._Toolbar1_Button4 = New System.Windows.Forms.ToolStripSeparator()
            Me.BtnDel = New System.Windows.Forms.ToolStripButton()
            Me.lblbattery = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtDate = New System.Windows.Forms.DateTimePicker()
            Me.Toolbar1.SuspendLayout()
            Me.SuspendLayout()
            '
            'cboBattery
            '
            Me.cboBattery.BackColor = System.Drawing.SystemColors.Window
            Me.cboBattery.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboBattery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboBattery.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboBattery.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboBattery.Location = New System.Drawing.Point(70, 147)
            Me.cboBattery.Name = "cboBattery"
            Me.cboBattery.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboBattery.Size = New System.Drawing.Size(145, 24)
            Me.cboBattery.TabIndex = 7
            '
            'chkEntrance
            '
            Me.chkEntrance.BackColor = System.Drawing.SystemColors.Control
            Me.chkEntrance.Cursor = System.Windows.Forms.Cursors.Default
            Me.chkEntrance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkEntrance.ForeColor = System.Drawing.SystemColors.ControlText
            Me.chkEntrance.Location = New System.Drawing.Point(319, 3)
            Me.chkEntrance.Name = "chkEntrance"
            Me.chkEntrance.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.chkEntrance.Size = New System.Drawing.Size(89, 50)
            Me.chkEntrance.TabIndex = 41
            Me.chkEntrance.Text = "Entrance"
            Me.chkEntrance.UseVisualStyleBackColor = False
            '
            'chkPEP
            '
            Me.chkPEP.BackColor = System.Drawing.SystemColors.Control
            Me.chkPEP.Cursor = System.Windows.Forms.Cursors.Default
            Me.chkPEP.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkPEP.ForeColor = System.Drawing.SystemColors.ControlText
            Me.chkPEP.Location = New System.Drawing.Point(210, 3)
            Me.chkPEP.Name = "chkPEP"
            Me.chkPEP.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.chkPEP.Size = New System.Drawing.Size(104, 50)
            Me.chkPEP.TabIndex = 40
            Me.chkPEP.Text = "PEPV"
            Me.chkPEP.UseVisualStyleBackColor = False
            '
            'chkToll2
            '
            Me.chkToll2.BackColor = System.Drawing.SystemColors.Control
            Me.chkToll2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkToll2.Cursor = System.Windows.Forms.Cursors.Default
            Me.chkToll2.Enabled = False
            Me.chkToll2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkToll2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.chkToll2.Location = New System.Drawing.Point(340, 250)
            Me.chkToll2.Name = "chkToll2"
            Me.chkToll2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.chkToll2.Size = New System.Drawing.Size(65, 25)
            Me.chkToll2.TabIndex = 15
            Me.chkToll2.Text = "Paid Toll"
            Me.chkToll2.UseVisualStyleBackColor = False
            '
            'chkToll1
            '
            Me.chkToll1.BackColor = System.Drawing.SystemColors.Control
            Me.chkToll1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkToll1.Cursor = System.Windows.Forms.Cursors.Default
            Me.chkToll1.Enabled = False
            Me.chkToll1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkToll1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.chkToll1.Location = New System.Drawing.Point(340, 219)
            Me.chkToll1.Name = "chkToll1"
            Me.chkToll1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.chkToll1.Size = New System.Drawing.Size(65, 21)
            Me.chkToll1.TabIndex = 13
            Me.chkToll1.Text = "Paid Toll"
            Me.chkToll1.UseVisualStyleBackColor = False
            '
            'cboConsultant3
            '
            Me.cboConsultant3.BackColor = System.Drawing.SystemColors.Window
            Me.cboConsultant3.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboConsultant3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboConsultant3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboConsultant3.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboConsultant3.Items.AddRange(New Object() {"JUAN CARLOS"})
            Me.cboConsultant3.Location = New System.Drawing.Point(163, 281)
            Me.cboConsultant3.Name = "cboConsultant3"
            Me.cboConsultant3.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboConsultant3.Size = New System.Drawing.Size(161, 25)
            Me.cboConsultant3.TabIndex = 16
            '
            'chkAcomodo
            '
            Me.chkAcomodo.BackColor = System.Drawing.SystemColors.Control
            Me.chkAcomodo.Cursor = System.Windows.Forms.Cursors.Default
            Me.chkAcomodo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkAcomodo.ForeColor = System.Drawing.SystemColors.ControlText
            Me.chkAcomodo.Location = New System.Drawing.Point(14, 3)
            Me.chkAcomodo.Name = "chkAcomodo"
            Me.chkAcomodo.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.chkAcomodo.Size = New System.Drawing.Size(191, 50)
            Me.chkAcomodo.TabIndex = 0
            Me.chkAcomodo.Text = "Acomodo Razonable"
            Me.chkAcomodo.UseVisualStyleBackColor = False
            '
            'cmdProgram
            '
            Me.cmdProgram.BackColor = System.Drawing.SystemColors.Control
            Me.cmdProgram.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdProgram.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdProgram.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdProgram.Location = New System.Drawing.Point(127, 519)
            Me.cmdProgram.Name = "cmdProgram"
            Me.cmdProgram.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdProgram.Size = New System.Drawing.Size(81, 25)
            Me.cmdProgram.TabIndex = 21
            Me.cmdProgram.Text = "Program"
            Me.cmdProgram.UseVisualStyleBackColor = False
            '
            'txtPrice
            '
            Me.txtPrice.AcceptsReturn = True
            Me.txtPrice.BackColor = System.Drawing.SystemColors.Window
            Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtPrice.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPrice.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtPrice.Location = New System.Drawing.Point(308, 331)
            Me.txtPrice.MaxLength = 0
            Me.txtPrice.Name = "txtPrice"
            Me.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtPrice.Size = New System.Drawing.Size(97, 24)
            Me.txtPrice.TabIndex = 18
            '
            'Command1
            '
            Me.Command1.BackColor = System.Drawing.SystemColors.Control
            Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
            Me.Command1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Command1.Location = New System.Drawing.Point(12, 519)
            Me.Command1.Name = "Command1"
            Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Command1.Size = New System.Drawing.Size(81, 25)
            Me.Command1.TabIndex = 20
            Me.Command1.Text = "Generate Jobs"
            Me.Command1.UseVisualStyleBackColor = False
            '
            'cmdCancel
            '
            Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
            Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdCancel.Location = New System.Drawing.Point(341, 519)
            Me.cmdCancel.Name = "cmdCancel"
            Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdCancel.Size = New System.Drawing.Size(65, 25)
            Me.cmdCancel.TabIndex = 23
            Me.cmdCancel.Text = "Cancel"
            Me.cmdCancel.UseVisualStyleBackColor = False
            '
            'cmdOK
            '
            Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
            Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdOK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdOK.Location = New System.Drawing.Point(242, 519)
            Me.cmdOK.Name = "cmdOK"
            Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdOK.Size = New System.Drawing.Size(65, 25)
            Me.cmdOK.TabIndex = 22
            Me.cmdOK.Text = "OK"
            Me.cmdOK.UseVisualStyleBackColor = False
            '
            'cboNV
            '
            Me.cboNV.BackColor = System.Drawing.SystemColors.Window
            Me.cboNV.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboNV.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboNV.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboNV.Location = New System.Drawing.Point(14, 189)
            Me.cboNV.Name = "cboNV"
            Me.cboNV.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboNV.Size = New System.Drawing.Size(94, 25)
            Me.cboNV.TabIndex = 8
            '
            'cboMat
            '
            Me.cboMat.BackColor = System.Drawing.SystemColors.Window
            Me.cboMat.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboMat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboMat.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboMat.Location = New System.Drawing.Point(114, 189)
            Me.cboMat.Name = "cboMat"
            Me.cboMat.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboMat.Size = New System.Drawing.Size(94, 25)
            Me.cboMat.TabIndex = 9
            '
            'cboLes
            '
            Me.cboLes.BackColor = System.Drawing.SystemColors.Window
            Me.cboLes.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboLes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboLes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboLes.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboLes.Location = New System.Drawing.Point(214, 189)
            Me.cboLes.Name = "cboLes"
            Me.cboLes.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboLes.Size = New System.Drawing.Size(94, 25)
            Me.cboLes.TabIndex = 10
            '
            'cboRen
            '
            Me.cboRen.BackColor = System.Drawing.SystemColors.Window
            Me.cboRen.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboRen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboRen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboRen.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboRen.Location = New System.Drawing.Point(314, 189)
            Me.cboRen.Name = "cboRen"
            Me.cboRen.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboRen.Size = New System.Drawing.Size(94, 25)
            Me.cboRen.TabIndex = 11
            '
            'cboSchools
            '
            Me.cboSchools.BackColor = System.Drawing.SystemColors.Window
            Me.cboSchools.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboSchools.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboSchools.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboSchools.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboSchools.Location = New System.Drawing.Point(14, 75)
            Me.cboSchools.Name = "cboSchools"
            Me.cboSchools.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboSchools.Size = New System.Drawing.Size(194, 25)
            Me.cboSchools.TabIndex = 1
            Me.cboSchools.Tag = "Validate Text -Required -RequiredMsg School is a required field!"
            '
            'cboGrade
            '
            Me.cboGrade.BackColor = System.Drawing.SystemColors.Window
            Me.cboGrade.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboGrade.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboGrade.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboGrade.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
            Me.cboGrade.Location = New System.Drawing.Point(14, 116)
            Me.cboGrade.Name = "cboGrade"
            Me.cboGrade.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboGrade.Size = New System.Drawing.Size(191, 25)
            Me.cboGrade.TabIndex = 4
            Me.cboGrade.Tag = "Validate Text -Required -RequiredMsg Grade is a required field!"
            '
            'cboSemester
            '
            Me.cboSemester.BackColor = System.Drawing.SystemColors.Window
            Me.cboSemester.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboSemester.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboSemester.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboSemester.Location = New System.Drawing.Point(216, 75)
            Me.cboSemester.Name = "cboSemester"
            Me.cboSemester.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboSemester.Size = New System.Drawing.Size(89, 25)
            Me.cboSemester.TabIndex = 2
            Me.cboSemester.Tag = "Validate Text -Required -RequiredMsg Semester is a required field!"
            '
            'txtSection
            '
            Me.txtSection.AcceptsReturn = True
            Me.txtSection.BackColor = System.Drawing.SystemColors.Window
            Me.txtSection.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtSection.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSection.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtSection.Location = New System.Drawing.Point(216, 116)
            Me.txtSection.MaxLength = 20
            Me.txtSection.Name = "txtSection"
            Me.txtSection.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtSection.Size = New System.Drawing.Size(89, 23)
            Me.txtSection.TabIndex = 5
            Me.txtSection.Tag = "Validate Text -Required -AllowLetters -AllowDigits -AllowWhiteSpaces -RequiredMsg" & _
        " Section is a required field! -InvalidValueMsg Section field doesn't allow accen" & _
        "tuation and/or special characters."
            '
            'txtTotalStudents
            '
            Me.txtTotalStudents.AcceptsReturn = True
            Me.txtTotalStudents.BackColor = System.Drawing.SystemColors.Window
            Me.txtTotalStudents.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtTotalStudents.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalStudents.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtTotalStudents.Location = New System.Drawing.Point(317, 116)
            Me.txtTotalStudents.MaxLength = 0
            Me.txtTotalStudents.Name = "txtTotalStudents"
            Me.txtTotalStudents.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtTotalStudents.Size = New System.Drawing.Size(91, 23)
            Me.txtTotalStudents.TabIndex = 6
            Me.txtTotalStudents.Tag = "Validate Text -AllowDigits -InvalidValueMsg Total students field only accepts dig" & _
        "its. -RequiredMsg Total students is required."
            '
            'txtFile
            '
            Me.txtFile.AcceptsReturn = True
            Me.txtFile.BackColor = System.Drawing.SystemColors.Window
            Me.txtFile.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtFile.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFile.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtFile.Location = New System.Drawing.Point(317, 75)
            Me.txtFile.MaxLength = 0
            Me.txtFile.Name = "txtFile"
            Me.txtFile.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtFile.Size = New System.Drawing.Size(91, 24)
            Me.txtFile.TabIndex = 3
            Me.txtFile.Tag = "Validate Text -RequiredMsg The File Code Field is a required."
            '
            'cboConsultant2
            '
            Me.cboConsultant2.BackColor = System.Drawing.SystemColors.Window
            Me.cboConsultant2.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboConsultant2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboConsultant2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboConsultant2.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboConsultant2.Items.AddRange(New Object() {"JUAN CARLOS"})
            Me.cboConsultant2.Location = New System.Drawing.Point(163, 250)
            Me.cboConsultant2.Name = "cboConsultant2"
            Me.cboConsultant2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboConsultant2.Size = New System.Drawing.Size(145, 25)
            Me.cboConsultant2.TabIndex = 14
            '
            'cboConsultant
            '
            Me.cboConsultant.BackColor = System.Drawing.SystemColors.Window
            Me.cboConsultant.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboConsultant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboConsultant.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboConsultant.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboConsultant.Items.AddRange(New Object() {"JUAN CARLOS"})
            Me.cboConsultant.Location = New System.Drawing.Point(163, 219)
            Me.cboConsultant.Name = "cboConsultant"
            Me.cboConsultant.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboConsultant.Size = New System.Drawing.Size(145, 25)
            Me.cboConsultant.TabIndex = 12
            '
            'LVDetails
            '
            Me.LVDetails.BackColor = System.Drawing.SystemColors.Window
            Me.LVDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._LVDetails_ColumnHeader_1, Me._LVDetails_ColumnHeader_2, Me._LVDetails_ColumnHeader_3, Me._LVDetails_ColumnHeader_4, Me._LVDetails_ColumnHeader_5, Me._LVDetails_ColumnHeader_6, Me._LVDetails_ColumnHeader_7, Me._LVDetails_ColumnHeader_8, Me._LVDetails_ColumnHeader_9, Me._LVDetails_ColumnHeader_10, Me._LVDetails_ColumnHeader_11, Me._LVDetails_ColumnHeader_12, Me._LVDetails_ColumnHeader_13, Me._LVDetails_ColumnHeader_14, Me._LVDetails_ColumnHeader_15})
            Me.LVDetails.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LVDetails.ForeColor = System.Drawing.SystemColors.WindowText
            Me.LVDetails.FullRowSelect = True
            Me.LVDetails.GridLines = True
            Me.LVDetails.HideSelection = False
            Me.LVDetails.Location = New System.Drawing.Point(12, 361)
            Me.LVDetails.Name = "LVDetails"
            Me.LVDetails.Size = New System.Drawing.Size(395, 151)
            Me.LVDetails.TabIndex = 19
            Me.LVDetails.UseCompatibleStateImageBehavior = False
            Me.LVDetails.View = System.Windows.Forms.View.Details
            '
            '_LVDetails_ColumnHeader_1
            '
            Me._LVDetails_ColumnHeader_1.Text = "Grade"
            Me._LVDetails_ColumnHeader_1.Width = 170
            '
            '_LVDetails_ColumnHeader_2
            '
            Me._LVDetails_ColumnHeader_2.Text = "Section"
            Me._LVDetails_ColumnHeader_2.Width = 170
            '
            '_LVDetails_ColumnHeader_3
            '
            Me._LVDetails_ColumnHeader_3.Text = "N Students"
            Me._LVDetails_ColumnHeader_3.Width = 170
            '
            '_LVDetails_ColumnHeader_4
            '
            Me._LVDetails_ColumnHeader_4.Text = "LES"
            Me._LVDetails_ColumnHeader_4.Width = 170
            '
            '_LVDetails_ColumnHeader_5
            '
            Me._LVDetails_ColumnHeader_5.Text = "NV"
            Me._LVDetails_ColumnHeader_5.Width = 170
            '
            '_LVDetails_ColumnHeader_6
            '
            Me._LVDetails_ColumnHeader_6.Text = "REN"
            Me._LVDetails_ColumnHeader_6.Width = 170
            '
            '_LVDetails_ColumnHeader_7
            '
            Me._LVDetails_ColumnHeader_7.Text = "MAT"
            Me._LVDetails_ColumnHeader_7.Width = 170
            '
            '_LVDetails_ColumnHeader_8
            '
            Me._LVDetails_ColumnHeader_8.Text = "Examiner 1"
            Me._LVDetails_ColumnHeader_8.Width = 170
            '
            '_LVDetails_ColumnHeader_9
            '
            Me._LVDetails_ColumnHeader_9.Text = "Toll"
            Me._LVDetails_ColumnHeader_9.Width = 59
            '
            '_LVDetails_ColumnHeader_10
            '
            Me._LVDetails_ColumnHeader_10.Text = "Examiner 2"
            Me._LVDetails_ColumnHeader_10.Width = 170
            '
            '_LVDetails_ColumnHeader_11
            '
            Me._LVDetails_ColumnHeader_11.Text = "Toll"
            Me._LVDetails_ColumnHeader_11.Width = 59
            '
            '_LVDetails_ColumnHeader_12
            '
            Me._LVDetails_ColumnHeader_12.Text = "Examiner In Charge"
            Me._LVDetails_ColumnHeader_12.Width = 170
            '
            '_LVDetails_ColumnHeader_13
            '
            Me._LVDetails_ColumnHeader_13.Text = "ServDate"
            Me._LVDetails_ColumnHeader_13.Width = 170
            '
            '_LVDetails_ColumnHeader_14
            '
            Me._LVDetails_ColumnHeader_14.Text = "Price"
            Me._LVDetails_ColumnHeader_14.Width = 170
            '
            '_LVDetails_ColumnHeader_15
            '
            Me._LVDetails_ColumnHeader_15.Text = "Plugin"
            Me._LVDetails_ColumnHeader_15.Width = 170
            '
            'Toolbar1
            '
            Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.None
            Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNew, Me._Toolbar1_Button2, Me.BtnEdit, Me._Toolbar1_Button4, Me.BtnDel})
            Me.Toolbar1.Location = New System.Drawing.Point(13, 336)
            Me.Toolbar1.Name = "Toolbar1"
            Me.Toolbar1.Size = New System.Drawing.Size(104, 25)
            Me.Toolbar1.TabIndex = 26
            '
            'BtnNew
            '
            Me.BtnNew.AutoSize = False
            Me.BtnNew.Image = Global.learnAid.My.Resources.Resources.new1
            Me.BtnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.BtnNew.Name = "BtnNew"
            Me.BtnNew.Size = New System.Drawing.Size(24, 22)
            Me.BtnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.BtnNew.ToolTipText = "Add School Record"
            '
            '_Toolbar1_Button2
            '
            Me._Toolbar1_Button2.AutoSize = False
            Me._Toolbar1_Button2.Name = "_Toolbar1_Button2"
            Me._Toolbar1_Button2.Size = New System.Drawing.Size(10, 22)
            '
            'BtnEdit
            '
            Me.BtnEdit.AutoSize = False
            Me.BtnEdit.Image = Global.learnAid.My.Resources.Resources.edit_job
            Me.BtnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.BtnEdit.Name = "BtnEdit"
            Me.BtnEdit.Size = New System.Drawing.Size(24, 22)
            Me.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.BtnEdit.ToolTipText = "Edit School Record"
            '
            '_Toolbar1_Button4
            '
            Me._Toolbar1_Button4.AutoSize = False
            Me._Toolbar1_Button4.Name = "_Toolbar1_Button4"
            Me._Toolbar1_Button4.Size = New System.Drawing.Size(10, 22)
            '
            'BtnDel
            '
            Me.BtnDel.AutoSize = False
            Me.BtnDel.Image = Global.learnAid.My.Resources.Resources.delete
            Me.BtnDel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.BtnDel.Name = "BtnDel"
            Me.BtnDel.Size = New System.Drawing.Size(24, 22)
            Me.BtnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.BtnDel.ToolTipText = "Delete School Record"
            '
            'lblbattery
            '
            Me.lblbattery.BackColor = System.Drawing.SystemColors.Control
            Me.lblbattery.Cursor = System.Windows.Forms.Cursors.Default
            Me.lblbattery.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblbattery.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblbattery.Location = New System.Drawing.Point(14, 152)
            Me.lblbattery.Name = "lblbattery"
            Me.lblbattery.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.lblbattery.Size = New System.Drawing.Size(73, 19)
            Me.lblbattery.TabIndex = 42
            Me.lblbattery.Text = "Battery:"
            '
            'Label15
            '
            Me.Label15.BackColor = System.Drawing.SystemColors.Control
            Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label15.Location = New System.Drawing.Point(14, 284)
            Me.Label15.Name = "Label15"
            Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label15.Size = New System.Drawing.Size(158, 17)
            Me.Label15.TabIndex = 39
            Me.Label15.Text = "Examiner in charge:"
            '
            'Label14
            '
            Me.Label14.BackColor = System.Drawing.SystemColors.Control
            Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label14.Location = New System.Drawing.Point(311, 311)
            Me.Label14.Name = "Label14"
            Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label14.Size = New System.Drawing.Size(97, 17)
            Me.Label14.TabIndex = 38
            Me.Label14.Text = "Price per Student:"
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.SystemColors.Control
            Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label13.Location = New System.Drawing.Point(14, 311)
            Me.Label13.Name = "Label13"
            Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label13.Size = New System.Drawing.Size(73, 17)
            Me.Label13.TabIndex = 37
            Me.Label13.Text = "Service Date:"
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label6.Location = New System.Drawing.Point(14, 173)
            Me.Label6.Name = "Label6"
            Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label6.Size = New System.Drawing.Size(73, 17)
            Me.Label6.TabIndex = 36
            Me.Label6.Text = "NV:"
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label7.Location = New System.Drawing.Point(216, 173)
            Me.Label7.Name = "Label7"
            Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label7.Size = New System.Drawing.Size(73, 17)
            Me.Label7.TabIndex = 35
            Me.Label7.Text = "LES:"
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label8.Location = New System.Drawing.Point(115, 173)
            Me.Label8.Name = "Label8"
            Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label8.Size = New System.Drawing.Size(73, 17)
            Me.Label8.TabIndex = 34
            Me.Label8.Text = "MAT:"
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label9.Location = New System.Drawing.Point(314, 173)
            Me.Label9.Name = "Label9"
            Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label9.Size = New System.Drawing.Size(73, 17)
            Me.Label9.TabIndex = 33
            Me.Label9.Text = "REN:"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.SystemColors.Control
            Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label1.Location = New System.Drawing.Point(14, 56)
            Me.Label1.Name = "Label1"
            Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label1.Size = New System.Drawing.Size(73, 17)
            Me.Label1.TabIndex = 32
            Me.Label1.Text = "School:"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.SystemColors.Control
            Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label3.Location = New System.Drawing.Point(14, 100)
            Me.Label3.Name = "Label3"
            Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label3.Size = New System.Drawing.Size(62, 17)
            Me.Label3.TabIndex = 31
            Me.Label3.Text = "Grade:"
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.SystemColors.Control
            Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label4.Location = New System.Drawing.Point(217, 100)
            Me.Label4.Name = "Label4"
            Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label4.Size = New System.Drawing.Size(64, 17)
            Me.Label4.TabIndex = 30
            Me.Label4.Text = "Section:"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.SystemColors.Control
            Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label2.Location = New System.Drawing.Point(214, 56)
            Me.Label2.Name = "Label2"
            Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label2.Size = New System.Drawing.Size(67, 21)
            Me.Label2.TabIndex = 29
            Me.Label2.Text = "Semester:"
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.SystemColors.Control
            Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label5.Location = New System.Drawing.Point(319, 100)
            Me.Label5.Name = "Label5"
            Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label5.Size = New System.Drawing.Size(78, 13)
            Me.Label5.TabIndex = 28
            Me.Label5.Text = "Total Students:"
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.SystemColors.Control
            Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label10.Location = New System.Drawing.Point(319, 56)
            Me.Label10.Name = "Label10"
            Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label10.Size = New System.Drawing.Size(46, 16)
            Me.Label10.TabIndex = 27
            Me.Label10.Text = "File:"
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.SystemColors.Control
            Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label12.Location = New System.Drawing.Point(14, 253)
            Me.Label12.Name = "Label12"
            Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label12.Size = New System.Drawing.Size(103, 17)
            Me.Label12.TabIndex = 25
            Me.Label12.Text = "Examiner 2:"
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.SystemColors.Control
            Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label11.Location = New System.Drawing.Point(14, 223)
            Me.Label11.Name = "Label11"
            Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label11.Size = New System.Drawing.Size(73, 17)
            Me.Label11.TabIndex = 24
            Me.Label11.Text = "Examiner:"
            '
            'txtDate
            '
            Me.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.txtDate.Location = New System.Drawing.Point(93, 312)
            Me.txtDate.Name = "txtDate"
            Me.txtDate.Size = New System.Drawing.Size(91, 23)
            Me.txtDate.TabIndex = 43
            '
            'frmPreJob
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.ClientSize = New System.Drawing.Size(433, 552)
            Me.ControlBox = False
            Me.Controls.Add(Me.txtDate)
            Me.Controls.Add(Me.cboBattery)
            Me.Controls.Add(Me.chkEntrance)
            Me.Controls.Add(Me.chkPEP)
            Me.Controls.Add(Me.chkToll2)
            Me.Controls.Add(Me.chkToll1)
            Me.Controls.Add(Me.cboConsultant3)
            Me.Controls.Add(Me.chkAcomodo)
            Me.Controls.Add(Me.cmdProgram)
            Me.Controls.Add(Me.txtPrice)
            Me.Controls.Add(Me.Command1)
            Me.Controls.Add(Me.cmdCancel)
            Me.Controls.Add(Me.cmdOK)
            Me.Controls.Add(Me.cboNV)
            Me.Controls.Add(Me.cboMat)
            Me.Controls.Add(Me.cboLes)
            Me.Controls.Add(Me.cboRen)
            Me.Controls.Add(Me.cboSchools)
            Me.Controls.Add(Me.cboGrade)
            Me.Controls.Add(Me.cboSemester)
            Me.Controls.Add(Me.txtSection)
            Me.Controls.Add(Me.txtTotalStudents)
            Me.Controls.Add(Me.txtFile)
            Me.Controls.Add(Me.cboConsultant2)
            Me.Controls.Add(Me.cboConsultant)
            Me.Controls.Add(Me.LVDetails)
            Me.Controls.Add(Me.Toolbar1)
            Me.Controls.Add(Me.lblbattery)
            Me.Controls.Add(Me.Label15)
            Me.Controls.Add(Me.Label14)
            Me.Controls.Add(Me.Label13)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.Label12)
            Me.Controls.Add(Me.Label11)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(3, 22)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmPreJob"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "PreJob"
            Me.Toolbar1.ResumeLayout(False)
            Me.Toolbar1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtDate As System.Windows.Forms.DateTimePicker
#End Region
    End Class
End Namespace