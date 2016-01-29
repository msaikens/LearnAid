Namespace Forms.MasterForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmEditJob
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
        Public WithEvents chkToll2 As System.Windows.Forms.CheckBox
        Public WithEvents chkToll1 As System.Windows.Forms.CheckBox
        Public WithEvents cboConsultant3 As System.Windows.Forms.ComboBox
        Public WithEvents txtDate As System.Windows.Forms.TextBox
        Public WithEvents txtPrice As System.Windows.Forms.TextBox
        Public WithEvents txtTotalStudents As System.Windows.Forms.TextBox
        Public WithEvents cboConsultant2 As System.Windows.Forms.ComboBox
        Public WithEvents cboBattery As System.Windows.Forms.ComboBox
        Public WithEvents cboRen As System.Windows.Forms.ComboBox
        Public WithEvents cboLes As System.Windows.Forms.ComboBox
        Public WithEvents cboMat As System.Windows.Forms.ComboBox
        Public WithEvents cboNV As System.Windows.Forms.ComboBox
        Public WithEvents lblbattery As System.Windows.Forms.Label
        Public WithEvents Label9 As System.Windows.Forms.Label
        Public WithEvents Label8 As System.Windows.Forms.Label
        Public WithEvents Label7 As System.Windows.Forms.Label
        Public WithEvents Label6 As System.Windows.Forms.Label
        Public WithEvents fraBat As System.Windows.Forms.GroupBox
        Public WithEvents cboSchools As System.Windows.Forms.ComboBox
        Public WithEvents txtFile As System.Windows.Forms.TextBox
        Public WithEvents cboGrade As System.Windows.Forms.ComboBox
        Public WithEvents optSecondSemester As System.Windows.Forms.RadioButton
        Public WithEvents optFirstSemester As System.Windows.Forms.RadioButton
        Public WithEvents txtSection As System.Windows.Forms.TextBox
        Public WithEvents cboConsultant As System.Windows.Forms.ComboBox
        Public WithEvents UpDown1 As System.Windows.Forms.Label
        Public WithEvents Label15 As System.Windows.Forms.Label
        Public WithEvents Label13 As System.Windows.Forms.Label
        Public WithEvents Label12 As System.Windows.Forms.Label
        Public WithEvents Label5 As System.Windows.Forms.Label
        Public WithEvents Label14 As System.Windows.Forms.Label
        Public WithEvents lblJobType As System.Windows.Forms.Label
        Public WithEvents Label11 As System.Windows.Forms.Label
        Public WithEvents Label1 As System.Windows.Forms.Label
        Public WithEvents Label2 As System.Windows.Forms.Label
        Public WithEvents Label3 As System.Windows.Forms.Label
        Public WithEvents Label4 As System.Windows.Forms.Label
        Public WithEvents Label10 As System.Windows.Forms.Label
        Public WithEvents fraNormal As System.Windows.Forms.Panel
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditJob))
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.fraNormal = New System.Windows.Forms.Panel()
            Me.optFirstSemester = New System.Windows.Forms.RadioButton()
            Me.chkToll2 = New System.Windows.Forms.CheckBox()
            Me.chkToll1 = New System.Windows.Forms.CheckBox()
            Me.cboConsultant3 = New System.Windows.Forms.ComboBox()
            Me.txtDate = New System.Windows.Forms.TextBox()
            Me.txtPrice = New System.Windows.Forms.TextBox()
            Me.txtTotalStudents = New System.Windows.Forms.TextBox()
            Me.cboConsultant2 = New System.Windows.Forms.ComboBox()
            Me.fraBat = New System.Windows.Forms.GroupBox()
            Me.cboBattery = New System.Windows.Forms.ComboBox()
            Me.cboRen = New System.Windows.Forms.ComboBox()
            Me.cboLes = New System.Windows.Forms.ComboBox()
            Me.cboMat = New System.Windows.Forms.ComboBox()
            Me.cboNV = New System.Windows.Forms.ComboBox()
            Me.lblbattery = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cboSchools = New System.Windows.Forms.ComboBox()
            Me.txtFile = New System.Windows.Forms.TextBox()
            Me.cboGrade = New System.Windows.Forms.ComboBox()
            Me.optSecondSemester = New System.Windows.Forms.RadioButton()
            Me.txtSection = New System.Windows.Forms.TextBox()
            Me.cboConsultant = New System.Windows.Forms.ComboBox()
            Me.UpDown1 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.lblJobType = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.cmdOK = New System.Windows.Forms.Button()
            Me.cmdCancel = New System.Windows.Forms.Button()
            Me.fraNormal.SuspendLayout()
            Me.fraBat.SuspendLayout()
            Me.SuspendLayout()
            '
            'fraNormal
            '
            Me.fraNormal.BackColor = System.Drawing.SystemColors.Control
            Me.fraNormal.Controls.Add(Me.optFirstSemester)
            Me.fraNormal.Controls.Add(Me.chkToll2)
            Me.fraNormal.Controls.Add(Me.chkToll1)
            Me.fraNormal.Controls.Add(Me.cboConsultant3)
            Me.fraNormal.Controls.Add(Me.txtDate)
            Me.fraNormal.Controls.Add(Me.txtPrice)
            Me.fraNormal.Controls.Add(Me.txtTotalStudents)
            Me.fraNormal.Controls.Add(Me.cboConsultant2)
            Me.fraNormal.Controls.Add(Me.fraBat)
            Me.fraNormal.Controls.Add(Me.cboSchools)
            Me.fraNormal.Controls.Add(Me.txtFile)
            Me.fraNormal.Controls.Add(Me.cboGrade)
            Me.fraNormal.Controls.Add(Me.optSecondSemester)
            Me.fraNormal.Controls.Add(Me.txtSection)
            Me.fraNormal.Controls.Add(Me.cboConsultant)
            Me.fraNormal.Controls.Add(Me.UpDown1)
            Me.fraNormal.Controls.Add(Me.Label15)
            Me.fraNormal.Controls.Add(Me.Label13)
            Me.fraNormal.Controls.Add(Me.Label12)
            Me.fraNormal.Controls.Add(Me.Label5)
            Me.fraNormal.Controls.Add(Me.Label14)
            Me.fraNormal.Controls.Add(Me.lblJobType)
            Me.fraNormal.Controls.Add(Me.Label11)
            Me.fraNormal.Controls.Add(Me.Label1)
            Me.fraNormal.Controls.Add(Me.Label2)
            Me.fraNormal.Controls.Add(Me.Label3)
            Me.fraNormal.Controls.Add(Me.Label4)
            Me.fraNormal.Controls.Add(Me.Label10)
            Me.fraNormal.Cursor = System.Windows.Forms.Cursors.Default
            Me.fraNormal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.fraNormal.ForeColor = System.Drawing.SystemColors.ControlText
            Me.fraNormal.Location = New System.Drawing.Point(12, 3)
            Me.fraNormal.Name = "fraNormal"
            Me.fraNormal.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.fraNormal.Size = New System.Drawing.Size(481, 442)
            Me.fraNormal.TabIndex = 15
            Me.fraNormal.Text = "normal"
            '
            'optFirstSemester
            '
            Me.optFirstSemester.BackColor = System.Drawing.SystemColors.Control
            Me.optFirstSemester.Checked = True
            Me.optFirstSemester.Cursor = System.Windows.Forms.Cursors.Default
            Me.optFirstSemester.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.optFirstSemester.ForeColor = System.Drawing.SystemColors.ControlText
            Me.optFirstSemester.Location = New System.Drawing.Point(112, 107)
            Me.optFirstSemester.Name = "optFirstSemester"
            Me.optFirstSemester.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.optFirstSemester.Size = New System.Drawing.Size(97, 25)
            Me.optFirstSemester.TabIndex = 5
            Me.optFirstSemester.TabStop = True
            Me.optFirstSemester.Text = "First Semester"
            Me.optFirstSemester.UseVisualStyleBackColor = False
            '
            'chkToll2
            '
            Me.chkToll2.BackColor = System.Drawing.SystemColors.Control
            Me.chkToll2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkToll2.Cursor = System.Windows.Forms.Cursors.Default
            Me.chkToll2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkToll2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.chkToll2.Location = New System.Drawing.Point(310, 344)
            Me.chkToll2.Name = "chkToll2"
            Me.chkToll2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.chkToll2.Size = New System.Drawing.Size(91, 17)
            Me.chkToll2.TabIndex = 39
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
            Me.chkToll1.Location = New System.Drawing.Point(310, 314)
            Me.chkToll1.Name = "chkToll1"
            Me.chkToll1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.chkToll1.Size = New System.Drawing.Size(91, 17)
            Me.chkToll1.TabIndex = 38
            Me.chkToll1.Text = "Paid Toll"
            Me.chkToll1.UseVisualStyleBackColor = False
            '
            'cboConsultant3
            '
            Me.cboConsultant3.BackColor = System.Drawing.SystemColors.Window
            Me.cboConsultant3.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboConsultant3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboConsultant3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboConsultant3.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboConsultant3.Items.AddRange(New Object() {"JUAN CARLOS"})
            Me.cboConsultant3.Location = New System.Drawing.Point(152, 371)
            Me.cboConsultant3.Name = "cboConsultant3"
            Me.cboConsultant3.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboConsultant3.Size = New System.Drawing.Size(145, 24)
            Me.cboConsultant3.TabIndex = 36
            Me.cboConsultant3.Tag = "Validate Text -Required -RequiredMsg The examiner in charge is a required field!"
            '
            'txtDate
            '
            Me.txtDate.AcceptsReturn = True
            Me.txtDate.BackColor = System.Drawing.SystemColors.Window
            Me.txtDate.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtDate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDate.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtDate.Location = New System.Drawing.Point(363, 19)
            Me.txtDate.MaxLength = 0
            Me.txtDate.Name = "txtDate"
            Me.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtDate.Size = New System.Drawing.Size(81, 23)
            Me.txtDate.TabIndex = 0
            '
            'txtPrice
            '
            Me.txtPrice.AcceptsReturn = True
            Me.txtPrice.BackColor = System.Drawing.SystemColors.Window
            Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtPrice.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPrice.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtPrice.Location = New System.Drawing.Point(152, 405)
            Me.txtPrice.MaxLength = 0
            Me.txtPrice.Name = "txtPrice"
            Me.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtPrice.Size = New System.Drawing.Size(81, 23)
            Me.txtPrice.TabIndex = 14
            '
            'txtTotalStudents
            '
            Me.txtTotalStudents.AcceptsReturn = True
            Me.txtTotalStudents.BackColor = System.Drawing.SystemColors.Window
            Me.txtTotalStudents.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtTotalStudents.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTotalStudents.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtTotalStudents.Location = New System.Drawing.Point(184, 135)
            Me.txtTotalStudents.MaxLength = 0
            Me.txtTotalStudents.Name = "txtTotalStudents"
            Me.txtTotalStudents.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtTotalStudents.Size = New System.Drawing.Size(41, 23)
            Me.txtTotalStudents.TabIndex = 7
            Me.txtTotalStudents.Tag = resources.GetString("txtTotalStudents.Tag")
            Me.txtTotalStudents.Text = "1"
            '
            'cboConsultant2
            '
            Me.cboConsultant2.BackColor = System.Drawing.SystemColors.Window
            Me.cboConsultant2.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboConsultant2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboConsultant2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboConsultant2.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboConsultant2.Items.AddRange(New Object() {"JUAN CARLOS"})
            Me.cboConsultant2.Location = New System.Drawing.Point(120, 341)
            Me.cboConsultant2.Name = "cboConsultant2"
            Me.cboConsultant2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboConsultant2.Size = New System.Drawing.Size(177, 24)
            Me.cboConsultant2.TabIndex = 13
            '
            'fraBat
            '
            Me.fraBat.BackColor = System.Drawing.SystemColors.Control
            Me.fraBat.Controls.Add(Me.cboBattery)
            Me.fraBat.Controls.Add(Me.cboRen)
            Me.fraBat.Controls.Add(Me.cboLes)
            Me.fraBat.Controls.Add(Me.cboMat)
            Me.fraBat.Controls.Add(Me.cboNV)
            Me.fraBat.Controls.Add(Me.lblbattery)
            Me.fraBat.Controls.Add(Me.Label9)
            Me.fraBat.Controls.Add(Me.Label8)
            Me.fraBat.Controls.Add(Me.Label7)
            Me.fraBat.Controls.Add(Me.Label6)
            Me.fraBat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.fraBat.ForeColor = System.Drawing.SystemColors.ControlText
            Me.fraBat.Location = New System.Drawing.Point(48, 161)
            Me.fraBat.Name = "fraBat"
            Me.fraBat.Padding = New System.Windows.Forms.Padding(0)
            Me.fraBat.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.fraBat.Size = New System.Drawing.Size(329, 144)
            Me.fraBat.TabIndex = 16
            Me.fraBat.TabStop = False
            Me.fraBat.Text = "BAT Configuration"
            '
            'cboBattery
            '
            Me.cboBattery.BackColor = System.Drawing.SystemColors.Window
            Me.cboBattery.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboBattery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboBattery.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboBattery.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboBattery.Location = New System.Drawing.Point(128, 24)
            Me.cboBattery.Name = "cboBattery"
            Me.cboBattery.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboBattery.Size = New System.Drawing.Size(174, 24)
            Me.cboBattery.TabIndex = 40
            '
            'cboRen
            '
            Me.cboRen.BackColor = System.Drawing.SystemColors.Window
            Me.cboRen.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboRen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboRen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboRen.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboRen.Location = New System.Drawing.Point(213, 88)
            Me.cboRen.Name = "cboRen"
            Me.cboRen.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboRen.Size = New System.Drawing.Size(89, 24)
            Me.cboRen.TabIndex = 11
            '
            'cboLes
            '
            Me.cboLes.BackColor = System.Drawing.SystemColors.Window
            Me.cboLes.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboLes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboLes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboLes.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboLes.Location = New System.Drawing.Point(213, 54)
            Me.cboLes.Name = "cboLes"
            Me.cboLes.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboLes.Size = New System.Drawing.Size(89, 24)
            Me.cboLes.TabIndex = 10
            '
            'cboMat
            '
            Me.cboMat.BackColor = System.Drawing.SystemColors.Window
            Me.cboMat.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboMat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboMat.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboMat.Location = New System.Drawing.Point(58, 88)
            Me.cboMat.Name = "cboMat"
            Me.cboMat.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboMat.Size = New System.Drawing.Size(89, 24)
            Me.cboMat.TabIndex = 9
            '
            'cboNV
            '
            Me.cboNV.BackColor = System.Drawing.SystemColors.Window
            Me.cboNV.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboNV.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboNV.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboNV.Location = New System.Drawing.Point(58, 54)
            Me.cboNV.Name = "cboNV"
            Me.cboNV.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboNV.Size = New System.Drawing.Size(89, 24)
            Me.cboNV.TabIndex = 8
            '
            'lblbattery
            '
            Me.lblbattery.BackColor = System.Drawing.SystemColors.Control
            Me.lblbattery.Cursor = System.Windows.Forms.Cursors.Default
            Me.lblbattery.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblbattery.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblbattery.Location = New System.Drawing.Point(61, 27)
            Me.lblbattery.Name = "lblbattery"
            Me.lblbattery.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.lblbattery.Size = New System.Drawing.Size(68, 21)
            Me.lblbattery.TabIndex = 41
            Me.lblbattery.Text = "Battery:"
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label9.Location = New System.Drawing.Point(133, 88)
            Me.Label9.Name = "Label9"
            Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label9.Size = New System.Drawing.Size(73, 17)
            Me.Label9.TabIndex = 20
            Me.Label9.Text = "REN:"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label8.Location = New System.Drawing.Point(-22, 88)
            Me.Label8.Name = "Label8"
            Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label8.Size = New System.Drawing.Size(73, 17)
            Me.Label8.TabIndex = 19
            Me.Label8.Text = "MAT:"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label7.Location = New System.Drawing.Point(133, 54)
            Me.Label7.Name = "Label7"
            Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label7.Size = New System.Drawing.Size(73, 17)
            Me.Label7.TabIndex = 18
            Me.Label7.Text = "LES:"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label6.Location = New System.Drawing.Point(-22, 54)
            Me.Label6.Name = "Label6"
            Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label6.Size = New System.Drawing.Size(73, 17)
            Me.Label6.TabIndex = 17
            Me.Label6.Text = "NV:"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'cboSchools
            '
            Me.cboSchools.BackColor = System.Drawing.SystemColors.Window
            Me.cboSchools.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboSchools.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboSchools.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboSchools.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboSchools.Location = New System.Drawing.Point(80, 48)
            Me.cboSchools.Name = "cboSchools"
            Me.cboSchools.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboSchools.Size = New System.Drawing.Size(224, 24)
            Me.cboSchools.TabIndex = 1
            Me.cboSchools.Tag = "Validate Text -Required -RequiredMsg School is a required field!"
            '
            'txtFile
            '
            Me.txtFile.AcceptsReturn = True
            Me.txtFile.BackColor = System.Drawing.SystemColors.Window
            Me.txtFile.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtFile.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFile.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtFile.Location = New System.Drawing.Point(360, 48)
            Me.txtFile.MaxLength = 0
            Me.txtFile.Name = "txtFile"
            Me.txtFile.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtFile.Size = New System.Drawing.Size(84, 23)
            Me.txtFile.TabIndex = 3
            Me.txtFile.Tag = "VValidate Text -Required -AllowLetters -MaxLength 4 -RequiredMsg File is a requir" & _
        "ed field! -InvalidValueMsg File field only accepts letters. -LengthMsg Maximum c" & _
        "haracters allowed is 4."
            '
            'cboGrade
            '
            Me.cboGrade.BackColor = System.Drawing.SystemColors.Window
            Me.cboGrade.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboGrade.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboGrade.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboGrade.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
            Me.cboGrade.Location = New System.Drawing.Point(80, 78)
            Me.cboGrade.Name = "cboGrade"
            Me.cboGrade.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboGrade.Size = New System.Drawing.Size(224, 24)
            Me.cboGrade.TabIndex = 2
            Me.cboGrade.Tag = "Validate Text -Required -RequiredMsg Grade is a required field!"
            '
            'optSecondSemester
            '
            Me.optSecondSemester.BackColor = System.Drawing.SystemColors.Control
            Me.optSecondSemester.Cursor = System.Windows.Forms.Cursors.Default
            Me.optSecondSemester.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.optSecondSemester.ForeColor = System.Drawing.SystemColors.ControlText
            Me.optSecondSemester.Location = New System.Drawing.Point(248, 107)
            Me.optSecondSemester.Name = "optSecondSemester"
            Me.optSecondSemester.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.optSecondSemester.Size = New System.Drawing.Size(105, 25)
            Me.optSecondSemester.TabIndex = 6
            Me.optSecondSemester.TabStop = True
            Me.optSecondSemester.Text = "Second Semester"
            Me.optSecondSemester.UseVisualStyleBackColor = False
            '
            'txtSection
            '
            Me.txtSection.AcceptsReturn = True
            Me.txtSection.BackColor = System.Drawing.SystemColors.Window
            Me.txtSection.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtSection.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSection.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtSection.Location = New System.Drawing.Point(370, 80)
            Me.txtSection.MaxLength = 0
            Me.txtSection.Name = "txtSection"
            Me.txtSection.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtSection.Size = New System.Drawing.Size(74, 23)
            Me.txtSection.TabIndex = 4
            Me.txtSection.Text = "Validate Text -Required -AllowLetters -AllowDigits -RequiredMsg Section is a requ" & _
        "ired field! -InvalidValueMsg Section field doesn't acept white spaces and/or acc" & _
        "entuation."
            '
            'cboConsultant
            '
            Me.cboConsultant.BackColor = System.Drawing.SystemColors.Window
            Me.cboConsultant.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboConsultant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboConsultant.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboConsultant.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboConsultant.Items.AddRange(New Object() {"JUAN CARLOS"})
            Me.cboConsultant.Location = New System.Drawing.Point(120, 311)
            Me.cboConsultant.Name = "cboConsultant"
            Me.cboConsultant.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboConsultant.Size = New System.Drawing.Size(177, 24)
            Me.cboConsultant.TabIndex = 12
            Me.cboConsultant.Tag = "Validate Text -Required -RequiredMsg The examiner is a required field!"
            '
            'UpDown1
            '
            Me.UpDown1.BackColor = System.Drawing.Color.Red
            Me.UpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.UpDown1.Location = New System.Drawing.Point(224, 135)
            Me.UpDown1.Name = "UpDown1"
            Me.UpDown1.Size = New System.Drawing.Size(16, 23)
            Me.UpDown1.TabIndex = 31
            Me.UpDown1.Text = "UpDown1"
            Me.UpDown1.Visible = False
            '
            'Label15
            '
            Me.Label15.BackColor = System.Drawing.SystemColors.Control
            Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label15.Location = New System.Drawing.Point(7, 374)
            Me.Label15.Name = "Label15"
            Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label15.Size = New System.Drawing.Size(139, 21)
            Me.Label15.TabIndex = 37
            Me.Label15.Text = "Examiner in charge:"
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.SystemColors.Control
            Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label13.Location = New System.Drawing.Point(292, 22)
            Me.Label13.Name = "Label13"
            Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label13.Size = New System.Drawing.Size(65, 18)
            Me.Label13.TabIndex = 35
            Me.Label13.Text = "Service Date:"
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.SystemColors.Control
            Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label12.Location = New System.Drawing.Point(7, 408)
            Me.Label12.Name = "Label12"
            Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label12.Size = New System.Drawing.Size(124, 23)
            Me.Label12.TabIndex = 34
            Me.Label12.Text = "Price per Student:"
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.SystemColors.Control
            Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label5.Location = New System.Drawing.Point(7, 344)
            Me.Label5.Name = "Label5"
            Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label5.Size = New System.Drawing.Size(92, 21)
            Me.Label5.TabIndex = 33
            Me.Label5.Text = "Examiner 2:"
            '
            'Label14
            '
            Me.Label14.BackColor = System.Drawing.SystemColors.Control
            Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label14.Location = New System.Drawing.Point(29, 138)
            Me.Label14.Name = "Label14"
            Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label14.Size = New System.Drawing.Size(148, 17)
            Me.Label14.TabIndex = 32
            Me.Label14.Text = "Number of Students"
            '
            'lblJobType
            '
            Me.lblJobType.BackColor = System.Drawing.Color.Transparent
            Me.lblJobType.Cursor = System.Windows.Forms.Cursors.Default
            Me.lblJobType.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblJobType.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblJobType.Location = New System.Drawing.Point(80, 16)
            Me.lblJobType.Name = "lblJobType"
            Me.lblJobType.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.lblJobType.Size = New System.Drawing.Size(206, 24)
            Me.lblJobType.TabIndex = 30
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.Transparent
            Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label11.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label11.Location = New System.Drawing.Point(22, 16)
            Me.Label11.Name = "Label11"
            Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label11.Size = New System.Drawing.Size(56, 17)
            Me.Label11.TabIndex = 29
            Me.Label11.Text = "Job Type:"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.SystemColors.Control
            Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label1.Location = New System.Drawing.Point(22, 48)
            Me.Label1.Name = "Label1"
            Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label1.Size = New System.Drawing.Size(80, 17)
            Me.Label1.TabIndex = 25
            Me.Label1.Text = "School:"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.SystemColors.Control
            Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label2.Location = New System.Drawing.Point(310, 50)
            Me.Label2.Name = "Label2"
            Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label2.Size = New System.Drawing.Size(57, 25)
            Me.Label2.TabIndex = 24
            Me.Label2.Text = "File:"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.SystemColors.Control
            Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label3.Location = New System.Drawing.Point(22, 80)
            Me.Label3.Name = "Label3"
            Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label3.Size = New System.Drawing.Size(56, 17)
            Me.Label3.TabIndex = 23
            Me.Label3.Text = "Grade:"
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.SystemColors.Control
            Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label4.Location = New System.Drawing.Point(307, 82)
            Me.Label4.Name = "Label4"
            Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label4.Size = New System.Drawing.Size(60, 25)
            Me.Label4.TabIndex = 22
            Me.Label4.Text = "Section:"
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.SystemColors.Control
            Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label10.Location = New System.Drawing.Point(7, 314)
            Me.Label10.Name = "Label10"
            Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label10.Size = New System.Drawing.Size(107, 21)
            Me.Label10.TabIndex = 21
            Me.Label10.Text = "Examiner:"
            '
            'cmdOK
            '
            Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
            Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdOK.Location = New System.Drawing.Point(308, 451)
            Me.cmdOK.Name = "cmdOK"
            Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdOK.Size = New System.Drawing.Size(89, 25)
            Me.cmdOK.TabIndex = 27
            Me.cmdOK.Text = "&OK"
            Me.cmdOK.UseVisualStyleBackColor = False
            '
            'cmdCancel
            '
            Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
            Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdCancel.Location = New System.Drawing.Point(404, 451)
            Me.cmdCancel.Name = "cmdCancel"
            Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdCancel.Size = New System.Drawing.Size(89, 25)
            Me.cmdCancel.TabIndex = 28
            Me.cmdCancel.Text = "&Cancel"
            Me.cmdCancel.UseVisualStyleBackColor = False
            '
            'frmEditJob
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.ClientSize = New System.Drawing.Size(505, 488)
            Me.ControlBox = False
            Me.Controls.Add(Me.cmdCancel)
            Me.Controls.Add(Me.fraNormal)
            Me.Controls.Add(Me.cmdOK)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Tahoma", 8.4!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Location = New System.Drawing.Point(4, 29)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmEditJob"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Edit Job"
            Me.fraNormal.ResumeLayout(False)
            Me.fraNormal.PerformLayout()
            Me.fraBat.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Public WithEvents cmdOK As System.Windows.Forms.Button
        Public WithEvents cmdCancel As System.Windows.Forms.Button
#End Region
    End Class
End Namespace