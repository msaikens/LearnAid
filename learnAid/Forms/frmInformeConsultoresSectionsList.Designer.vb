<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmInformeConsultoresSectionsList
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
	Public WithEvents cmdReCreate As System.Windows.Forms.Button
	Public WithEvents txtAusentes As System.Windows.Forms.TextBox
	Public WithEvents txtReposicionDate As System.Windows.Forms.TextBox
	Public WithEvents txtReposicion As System.Windows.Forms.TextBox
	Public WithEvents cmdCalendar2 As System.Windows.Forms.Button
	Public WithEvents txtAcomodo As System.Windows.Forms.TextBox
	Public WithEvents txtDoS As System.Windows.Forms.TextBox
	Public WithEvents lblAusentes As System.Windows.Forms.Label
	Public WithEvents lblReposicion As System.Windows.Forms.Label
	Public WithEvents lblAcomodo As System.Windows.Forms.Label
	Public WithEvents lblDoS As System.Windows.Forms.Label
	Public WithEvents lblReposicionDate As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmbCondiciones As System.Windows.Forms.ComboBox
	Public WithEvents cmbRepeticion As System.Windows.Forms.ComboBox
	Public WithEvents cmbInstrucciones As System.Windows.Forms.ComboBox
	Public WithEvents cmbConducta As System.Windows.Forms.ComboBox
	Public WithEvents lblConducta As System.Windows.Forms.Label
	Public WithEvents lblRepeticion As System.Windows.Forms.Label
	Public WithEvents lblInstrucciones As System.Windows.Forms.Label
	Public WithEvents lblCondiciones As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Picture1 As System.Windows.Forms.Panel
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdSave As System.Windows.Forms.Button
	Public WithEvents _lvSections_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvSections_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvSections_ColumnHeader_3 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvSections_ColumnHeader_4 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvSections As System.Windows.Forms.ListView
	Public WithEvents lblSectionsInstructions As System.Windows.Forms.Label
	Public WithEvents lblSectionsTitle As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdReCreate = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.dtReposicionDate = New System.Windows.Forms.DateTimePicker()
        Me.dtDoS = New System.Windows.Forms.DateTimePicker()
        Me.txtAusentes = New System.Windows.Forms.TextBox()
        Me.txtReposicionDate = New System.Windows.Forms.TextBox()
        Me.txtReposicion = New System.Windows.Forms.TextBox()
        Me.cmdCalendar2 = New System.Windows.Forms.Button()
        Me.txtAcomodo = New System.Windows.Forms.TextBox()
        Me.txtDoS = New System.Windows.Forms.TextBox()
        Me.lblAusentes = New System.Windows.Forms.Label()
        Me.lblReposicion = New System.Windows.Forms.Label()
        Me.lblAcomodo = New System.Windows.Forms.Label()
        Me.lblDoS = New System.Windows.Forms.Label()
        Me.lblReposicionDate = New System.Windows.Forms.Label()
        Me.Picture1 = New System.Windows.Forms.Panel()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.cmbCondiciones = New System.Windows.Forms.ComboBox()
        Me.cmbRepeticion = New System.Windows.Forms.ComboBox()
        Me.cmbInstrucciones = New System.Windows.Forms.ComboBox()
        Me.cmbConducta = New System.Windows.Forms.ComboBox()
        Me.lblConducta = New System.Windows.Forms.Label()
        Me.lblRepeticion = New System.Windows.Forms.Label()
        Me.lblInstrucciones = New System.Windows.Forms.Label()
        Me.lblCondiciones = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.lvSections = New System.Windows.Forms.ListView()
        Me._lvSections_ColumnHeader_1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._lvSections_ColumnHeader_2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._lvSections_ColumnHeader_3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me._lvSections_ColumnHeader_4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblSectionsInstructions = New System.Windows.Forms.Label()
        Me.lblSectionsTitle = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        Me.Picture1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdReCreate
        '
        Me.cmdReCreate.BackColor = System.Drawing.SystemColors.Control
        Me.cmdReCreate.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReCreate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReCreate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdReCreate.Location = New System.Drawing.Point(72, 320)
        Me.cmdReCreate.Name = "cmdReCreate"
        Me.cmdReCreate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdReCreate.Size = New System.Drawing.Size(121, 25)
        Me.cmdReCreate.TabIndex = 7
        Me.cmdReCreate.Text = "&Re-Create Document"
        Me.cmdReCreate.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.dtReposicionDate)
        Me.Frame1.Controls.Add(Me.dtDoS)
        Me.Frame1.Controls.Add(Me.txtAusentes)
        Me.Frame1.Controls.Add(Me.txtReposicionDate)
        Me.Frame1.Controls.Add(Me.txtReposicion)
        Me.Frame1.Controls.Add(Me.cmdCalendar2)
        Me.Frame1.Controls.Add(Me.txtAcomodo)
        Me.Frame1.Controls.Add(Me.txtDoS)
        Me.Frame1.Controls.Add(Me.lblAusentes)
        Me.Frame1.Controls.Add(Me.lblReposicion)
        Me.Frame1.Controls.Add(Me.lblAcomodo)
        Me.Frame1.Controls.Add(Me.lblDoS)
        Me.Frame1.Controls.Add(Me.lblReposicionDate)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 56)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(409, 121)
        Me.Frame1.TabIndex = 22
        Me.Frame1.TabStop = False
        '
        'dtReposicionDate
        '
        Me.dtReposicionDate.CustomFormat = """  """
        Me.dtReposicionDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtReposicionDate.Location = New System.Drawing.Point(304, 62)
        Me.dtReposicionDate.Name = "dtReposicionDate"
        Me.dtReposicionDate.Size = New System.Drawing.Size(97, 23)
        Me.dtReposicionDate.TabIndex = 29
        '
        'dtDoS
        '
        Me.dtDoS.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDoS.Location = New System.Drawing.Point(128, 12)
        Me.dtDoS.Name = "dtDoS"
        Me.dtDoS.Size = New System.Drawing.Size(105, 23)
        Me.dtDoS.TabIndex = 28
        '
        'txtAusentes
        '
        Me.txtAusentes.AcceptsReturn = True
        Me.txtAusentes.BackColor = System.Drawing.SystemColors.Window
        Me.txtAusentes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAusentes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAusentes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAusentes.Location = New System.Drawing.Point(128, 86)
        Me.txtAusentes.MaxLength = 0
        Me.txtAusentes.Name = "txtAusentes"
        Me.txtAusentes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAusentes.Size = New System.Drawing.Size(41, 24)
        Me.txtAusentes.TabIndex = 5
        '
        'txtReposicionDate
        '
        Me.txtReposicionDate.AcceptsReturn = True
        Me.txtReposicionDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtReposicionDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReposicionDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReposicionDate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtReposicionDate.Location = New System.Drawing.Point(304, 0)
        Me.txtReposicionDate.MaxLength = 0
        Me.txtReposicionDate.Name = "txtReposicionDate"
        Me.txtReposicionDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtReposicionDate.Size = New System.Drawing.Size(65, 24)
        Me.txtReposicionDate.TabIndex = 3
        Me.txtReposicionDate.Visible = False
        '
        'txtReposicion
        '
        Me.txtReposicion.AcceptsReturn = True
        Me.txtReposicion.BackColor = System.Drawing.SystemColors.Window
        Me.txtReposicion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReposicion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReposicion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtReposicion.Location = New System.Drawing.Point(128, 62)
        Me.txtReposicion.MaxLength = 0
        Me.txtReposicion.Name = "txtReposicion"
        Me.txtReposicion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtReposicion.Size = New System.Drawing.Size(41, 24)
        Me.txtReposicion.TabIndex = 2
        '
        'cmdCalendar2
        '
        Me.cmdCalendar2.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCalendar2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCalendar2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalendar2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCalendar2.Location = New System.Drawing.Point(376, 0)
        Me.cmdCalendar2.Name = "cmdCalendar2"
        Me.cmdCalendar2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCalendar2.Size = New System.Drawing.Size(25, 19)
        Me.cmdCalendar2.TabIndex = 4
        Me.cmdCalendar2.Text = "..."
        Me.cmdCalendar2.UseVisualStyleBackColor = False
        Me.cmdCalendar2.Visible = False
        '
        'txtAcomodo
        '
        Me.txtAcomodo.AcceptsReturn = True
        Me.txtAcomodo.BackColor = System.Drawing.SystemColors.Window
        Me.txtAcomodo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAcomodo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcomodo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAcomodo.Location = New System.Drawing.Point(128, 38)
        Me.txtAcomodo.MaxLength = 0
        Me.txtAcomodo.Name = "txtAcomodo"
        Me.txtAcomodo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAcomodo.Size = New System.Drawing.Size(41, 24)
        Me.txtAcomodo.TabIndex = 1
        '
        'txtDoS
        '
        Me.txtDoS.AcceptsReturn = True
        Me.txtDoS.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtDoS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDoS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDoS.Location = New System.Drawing.Point(320, 37)
        Me.txtDoS.MaxLength = 0
        Me.txtDoS.Name = "txtDoS"
        Me.txtDoS.ReadOnly = True
        Me.txtDoS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDoS.Size = New System.Drawing.Size(81, 24)
        Me.txtDoS.TabIndex = 0
        Me.txtDoS.TabStop = False
        Me.txtDoS.Visible = False
        '
        'lblAusentes
        '
        Me.lblAusentes.BackColor = System.Drawing.SystemColors.Control
        Me.lblAusentes.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAusentes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAusentes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAusentes.Location = New System.Drawing.Point(16, 88)
        Me.lblAusentes.Name = "lblAusentes"
        Me.lblAusentes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAusentes.Size = New System.Drawing.Size(57, 17)
        Me.lblAusentes.TabIndex = 27
        Me.lblAusentes.Text = "Absent:"
        '
        'lblReposicion
        '
        Me.lblReposicion.BackColor = System.Drawing.SystemColors.Control
        Me.lblReposicion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblReposicion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReposicion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblReposicion.Location = New System.Drawing.Point(16, 64)
        Me.lblReposicion.Name = "lblReposicion"
        Me.lblReposicion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblReposicion.Size = New System.Drawing.Size(73, 17)
        Me.lblReposicion.TabIndex = 26
        Me.lblReposicion.Text = "Make-up:"
        '
        'lblAcomodo
        '
        Me.lblAcomodo.BackColor = System.Drawing.SystemColors.Control
        Me.lblAcomodo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAcomodo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcomodo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAcomodo.Location = New System.Drawing.Point(16, 40)
        Me.lblAcomodo.Name = "lblAcomodo"
        Me.lblAcomodo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAcomodo.Size = New System.Drawing.Size(113, 17)
        Me.lblAcomodo.TabIndex = 25
        Me.lblAcomodo.Text = "Acomodo Razonable:"
        '
        'lblDoS
        '
        Me.lblDoS.BackColor = System.Drawing.SystemColors.Control
        Me.lblDoS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDoS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDoS.Location = New System.Drawing.Point(16, 16)
        Me.lblDoS.Name = "lblDoS"
        Me.lblDoS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDoS.Size = New System.Drawing.Size(97, 17)
        Me.lblDoS.TabIndex = 24
        Me.lblDoS.Text = "Date of Service:"
        '
        'lblReposicionDate
        '
        Me.lblReposicionDate.BackColor = System.Drawing.SystemColors.Control
        Me.lblReposicionDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblReposicionDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReposicionDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblReposicionDate.Location = New System.Drawing.Point(248, 64)
        Me.lblReposicionDate.Name = "lblReposicionDate"
        Me.lblReposicionDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblReposicionDate.Size = New System.Drawing.Size(41, 17)
        Me.lblReposicionDate.TabIndex = 23
        Me.lblReposicionDate.Text = "Date:"
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.SystemColors.Control
        Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture1.Controls.Add(Me.Frame2)
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Picture1.Location = New System.Drawing.Point(152, 368)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(361, 281)
        Me.Picture1.TabIndex = 12
        Me.Picture1.TabStop = True
        Me.Picture1.Visible = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.cmbCondiciones)
        Me.Frame2.Controls.Add(Me.cmbRepeticion)
        Me.Frame2.Controls.Add(Me.cmbInstrucciones)
        Me.Frame2.Controls.Add(Me.cmbConducta)
        Me.Frame2.Controls.Add(Me.lblConducta)
        Me.Frame2.Controls.Add(Me.lblRepeticion)
        Me.Frame2.Controls.Add(Me.lblInstrucciones)
        Me.Frame2.Controls.Add(Me.lblCondiciones)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(8, 136)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(353, 121)
        Me.Frame2.TabIndex = 13
        Me.Frame2.TabStop = False
        '
        'cmbCondiciones
        '
        Me.cmbCondiciones.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCondiciones.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCondiciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondiciones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCondiciones.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCondiciones.Location = New System.Drawing.Point(16, 32)
        Me.cmbCondiciones.Name = "cmbCondiciones"
        Me.cmbCondiciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCondiciones.Size = New System.Drawing.Size(153, 25)
        Me.cmbCondiciones.TabIndex = 17
        '
        'cmbRepeticion
        '
        Me.cmbRepeticion.BackColor = System.Drawing.SystemColors.Window
        Me.cmbRepeticion.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbRepeticion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRepeticion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRepeticion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRepeticion.Location = New System.Drawing.Point(16, 80)
        Me.cmbRepeticion.Name = "cmbRepeticion"
        Me.cmbRepeticion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbRepeticion.Size = New System.Drawing.Size(153, 25)
        Me.cmbRepeticion.TabIndex = 16
        '
        'cmbInstrucciones
        '
        Me.cmbInstrucciones.BackColor = System.Drawing.SystemColors.Window
        Me.cmbInstrucciones.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbInstrucciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInstrucciones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInstrucciones.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbInstrucciones.Location = New System.Drawing.Point(184, 32)
        Me.cmbInstrucciones.Name = "cmbInstrucciones"
        Me.cmbInstrucciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbInstrucciones.Size = New System.Drawing.Size(153, 25)
        Me.cmbInstrucciones.TabIndex = 15
        '
        'cmbConducta
        '
        Me.cmbConducta.BackColor = System.Drawing.SystemColors.Window
        Me.cmbConducta.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbConducta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConducta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConducta.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbConducta.Location = New System.Drawing.Point(184, 80)
        Me.cmbConducta.Name = "cmbConducta"
        Me.cmbConducta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbConducta.Size = New System.Drawing.Size(153, 25)
        Me.cmbConducta.TabIndex = 14
        '
        'lblConducta
        '
        Me.lblConducta.BackColor = System.Drawing.SystemColors.Control
        Me.lblConducta.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblConducta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConducta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblConducta.Location = New System.Drawing.Point(184, 64)
        Me.lblConducta.Name = "lblConducta"
        Me.lblConducta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblConducta.Size = New System.Drawing.Size(129, 17)
        Me.lblConducta.TabIndex = 21
        Me.lblConducta.Text = "Conduct:"
        '
        'lblRepeticion
        '
        Me.lblRepeticion.BackColor = System.Drawing.SystemColors.Control
        Me.lblRepeticion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRepeticion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepeticion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRepeticion.Location = New System.Drawing.Point(16, 64)
        Me.lblRepeticion.Name = "lblRepeticion"
        Me.lblRepeticion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRepeticion.Size = New System.Drawing.Size(121, 17)
        Me.lblRepeticion.TabIndex = 20
        Me.lblRepeticion.Text = "Repetition:"
        '
        'lblInstrucciones
        '
        Me.lblInstrucciones.BackColor = System.Drawing.SystemColors.Control
        Me.lblInstrucciones.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblInstrucciones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstrucciones.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblInstrucciones.Location = New System.Drawing.Point(184, 16)
        Me.lblInstrucciones.Name = "lblInstrucciones"
        Me.lblInstrucciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInstrucciones.Size = New System.Drawing.Size(113, 17)
        Me.lblInstrucciones.TabIndex = 19
        Me.lblInstrucciones.Text = "Instructions:"
        '
        'lblCondiciones
        '
        Me.lblCondiciones.BackColor = System.Drawing.SystemColors.Control
        Me.lblCondiciones.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCondiciones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCondiciones.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCondiciones.Location = New System.Drawing.Point(16, 16)
        Me.lblCondiciones.Name = "lblCondiciones"
        Me.lblCondiciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCondiciones.Size = New System.Drawing.Size(105, 17)
        Me.lblCondiciones.TabIndex = 18
        Me.lblCondiciones.Text = "Conditions:"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(312, 320)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(105, 25)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "&Close"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSave.Location = New System.Drawing.Point(200, 320)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSave.Size = New System.Drawing.Size(105, 25)
        Me.cmdSave.TabIndex = 8
        Me.cmdSave.Text = "Create &Document"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'lvSections
        '
        Me.lvSections.BackColor = System.Drawing.SystemColors.Window
        Me.lvSections.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvSections_ColumnHeader_1, Me._lvSections_ColumnHeader_2, Me._lvSections_ColumnHeader_3, Me._lvSections_ColumnHeader_4})
        Me.lvSections.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSections.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvSections.FullRowSelect = True
        Me.lvSections.GridLines = True
        Me.lvSections.Location = New System.Drawing.Point(8, 184)
        Me.lvSections.Name = "lvSections"
        Me.lvSections.Size = New System.Drawing.Size(409, 129)
        Me.lvSections.TabIndex = 6
        Me.lvSections.UseCompatibleStateImageBehavior = False
        Me.lvSections.View = System.Windows.Forms.View.Details
        '
        '_lvSections_ColumnHeader_1
        '
        Me._lvSections_ColumnHeader_1.Text = "Group"
        Me._lvSections_ColumnHeader_1.Width = 142
        '
        '_lvSections_ColumnHeader_2
        '
        Me._lvSections_ColumnHeader_2.Text = "Section"
        Me._lvSections_ColumnHeader_2.Width = 170
        '
        '_lvSections_ColumnHeader_3
        '
        Me._lvSections_ColumnHeader_3.Text = "Amount of Students"
        Me._lvSections_ColumnHeader_3.Width = 236
        '
        '_lvSections_ColumnHeader_4
        '
        Me._lvSections_ColumnHeader_4.Text = "Completed?"
        Me._lvSections_ColumnHeader_4.Width = 170
        '
        'lblSectionsInstructions
        '
        Me.lblSectionsInstructions.BackColor = System.Drawing.SystemColors.Control
        Me.lblSectionsInstructions.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSectionsInstructions.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectionsInstructions.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSectionsInstructions.Location = New System.Drawing.Point(8, 24)
        Me.lblSectionsInstructions.Name = "lblSectionsInstructions"
        Me.lblSectionsInstructions.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSectionsInstructions.Size = New System.Drawing.Size(401, 33)
        Me.lblSectionsInstructions.TabIndex = 11
        Me.lblSectionsInstructions.Text = "Label2"
        '
        'lblSectionsTitle
        '
        Me.lblSectionsTitle.BackColor = System.Drawing.SystemColors.Control
        Me.lblSectionsTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSectionsTitle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectionsTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSectionsTitle.Location = New System.Drawing.Point(8, 8)
        Me.lblSectionsTitle.Name = "lblSectionsTitle"
        Me.lblSectionsTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSectionsTitle.Size = New System.Drawing.Size(393, 17)
        Me.lblSectionsTitle.TabIndex = 10
        Me.lblSectionsTitle.Text = "Select Section"
        '
        'frmInformeConsultoresSectionsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(426, 353)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdReCreate)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.lvSections)
        Me.Controls.Add(Me.lblSectionsInstructions)
        Me.Controls.Add(Me.lblSectionsTitle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(3, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInformeConsultoresSectionsList"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Available Sections for this School"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Picture1.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtDoS As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtReposicionDate As System.Windows.Forms.DateTimePicker
#End Region 
End Class