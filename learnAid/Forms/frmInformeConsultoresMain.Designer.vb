<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmInformeConsultoresMain
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
	Public WithEvents _lvDificultades_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvDificultades As System.Windows.Forms.ListView
	Public WithEvents _lvConducta_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvConducta As System.Windows.Forms.ListView
	Public WithEvents _lvInstrucciones_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvInstrucciones As System.Windows.Forms.ListView
	Public WithEvents _lvAmbiente_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvAmbiente As System.Windows.Forms.ListView
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdSave As System.Windows.Forms.Button
	Public WithEvents _lvRecomendaciones_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvRecomendaciones As System.Windows.Forms.ListView
	Public WithEvents lblConsRepInstructionsTitle As System.Windows.Forms.Label
	Public WithEvents lbConsRepInstructions As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmInformeConsultoresMain))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.lvDificultades = New System.Windows.Forms.ListView
		Me._lvDificultades_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
		Me.lvConducta = New System.Windows.Forms.ListView
		Me._lvConducta_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
		Me.lvInstrucciones = New System.Windows.Forms.ListView
		Me._lvInstrucciones_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
		Me.lvAmbiente = New System.Windows.Forms.ListView
		Me._lvAmbiente_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdSave = New System.Windows.Forms.Button
		Me.lvRecomendaciones = New System.Windows.Forms.ListView
		Me._lvRecomendaciones_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
		Me.lblConsRepInstructionsTitle = New System.Windows.Forms.Label
		Me.lbConsRepInstructions = New System.Windows.Forms.Label
		Me.lvDificultades.SuspendLayout()
		Me.lvConducta.SuspendLayout()
		Me.lvInstrucciones.SuspendLayout()
		Me.lvAmbiente.SuspendLayout()
		Me.lvRecomendaciones.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Consultant Report Configuration"
		Me.ClientSize = New System.Drawing.Size(560, 511)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ControlBox = False
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmInformeConsultoresMain"
		Me.lvDificultades.Size = New System.Drawing.Size(273, 145)
		Me.lvDificultades.Location = New System.Drawing.Point(280, 224)
		Me.lvDificultades.TabIndex = 3
		Me.lvDificultades.View = System.Windows.Forms.View.Details
		Me.lvDificultades.LabelEdit = False
		Me.lvDificultades.LabelWrap = True
		Me.lvDificultades.HideSelection = True
		Me.lvDificultades.Checkboxes = True
		Me.lvDificultades.FullRowSelect = True
		Me.lvDificultades.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lvDificultades.BackColor = System.Drawing.SystemColors.Window
		Me.lvDificultades.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lvDificultades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lvDificultades.Name = "lvDificultades"
		Me._lvDificultades_ColumnHeader_1.Text = "Difficulties"
		Me._lvDificultades_ColumnHeader_1.Width = 818
		Me.lvConducta.Size = New System.Drawing.Size(265, 145)
		Me.lvConducta.Location = New System.Drawing.Point(8, 224)
		Me.lvConducta.TabIndex = 2
		Me.lvConducta.View = System.Windows.Forms.View.Details
		Me.lvConducta.LabelEdit = False
		Me.lvConducta.LabelWrap = True
		Me.lvConducta.HideSelection = True
		Me.lvConducta.Checkboxes = True
		Me.lvConducta.FullRowSelect = True
		Me.lvConducta.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lvConducta.BackColor = System.Drawing.SystemColors.Window
		Me.lvConducta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lvConducta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lvConducta.Name = "lvConducta"
		Me._lvConducta_ColumnHeader_1.Text = "Conduct"
		Me._lvConducta_ColumnHeader_1.Width = 818
		Me.lvInstrucciones.Size = New System.Drawing.Size(273, 145)
		Me.lvInstrucciones.Location = New System.Drawing.Point(280, 72)
		Me.lvInstrucciones.TabIndex = 1
		Me.lvInstrucciones.View = System.Windows.Forms.View.Details
		Me.lvInstrucciones.LabelEdit = False
		Me.lvInstrucciones.LabelWrap = True
		Me.lvInstrucciones.HideSelection = True
		Me.lvInstrucciones.Checkboxes = True
		Me.lvInstrucciones.FullRowSelect = True
		Me.lvInstrucciones.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lvInstrucciones.BackColor = System.Drawing.SystemColors.Window
		Me.lvInstrucciones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lvInstrucciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lvInstrucciones.Name = "lvInstrucciones"
		Me._lvInstrucciones_ColumnHeader_1.Text = "Instructions"
		Me._lvInstrucciones_ColumnHeader_1.Width = 818
		Me.lvAmbiente.Size = New System.Drawing.Size(265, 145)
		Me.lvAmbiente.Location = New System.Drawing.Point(8, 72)
		Me.lvAmbiente.TabIndex = 0
		Me.lvAmbiente.View = System.Windows.Forms.View.Details
		Me.lvAmbiente.LabelEdit = False
		Me.lvAmbiente.LabelWrap = True
		Me.lvAmbiente.HideSelection = True
		Me.lvAmbiente.Checkboxes = True
		Me.lvAmbiente.FullRowSelect = True
		Me.lvAmbiente.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lvAmbiente.BackColor = System.Drawing.SystemColors.Window
		Me.lvAmbiente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lvAmbiente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lvAmbiente.Name = "lvAmbiente"
		Me._lvAmbiente_ColumnHeader_1.Text = "Environment"
		Me._lvAmbiente_ColumnHeader_1.Width = 818
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "&Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(81, 25)
		Me.cmdCancel.Location = New System.Drawing.Point(472, 480)
		Me.cmdCancel.TabIndex = 6
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSave.Text = "Save"
		Me.cmdSave.Size = New System.Drawing.Size(81, 25)
		Me.cmdSave.Location = New System.Drawing.Point(384, 480)
		Me.cmdSave.TabIndex = 5
		Me.cmdSave.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSave.CausesValidation = True
		Me.cmdSave.Enabled = True
		Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSave.TabStop = True
		Me.cmdSave.Name = "cmdSave"
		Me.lvRecomendaciones.Size = New System.Drawing.Size(545, 97)
		Me.lvRecomendaciones.Location = New System.Drawing.Point(8, 376)
		Me.lvRecomendaciones.TabIndex = 4
		Me.lvRecomendaciones.View = System.Windows.Forms.View.Details
		Me.lvRecomendaciones.LabelEdit = False
		Me.lvRecomendaciones.LabelWrap = True
		Me.lvRecomendaciones.HideSelection = True
		Me.lvRecomendaciones.Checkboxes = True
		Me.lvRecomendaciones.FullRowSelect = True
		Me.lvRecomendaciones.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lvRecomendaciones.BackColor = System.Drawing.SystemColors.Window
		Me.lvRecomendaciones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lvRecomendaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lvRecomendaciones.Name = "lvRecomendaciones"
		Me._lvRecomendaciones_ColumnHeader_1.Text = "Recomendations"
		Me._lvRecomendaciones_ColumnHeader_1.Width = 953
		Me.lblConsRepInstructionsTitle.Text = "Consultant Report Configuration"
		Me.lblConsRepInstructionsTitle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblConsRepInstructionsTitle.Size = New System.Drawing.Size(529, 17)
		Me.lblConsRepInstructionsTitle.Location = New System.Drawing.Point(16, 8)
		Me.lblConsRepInstructionsTitle.TabIndex = 8
		Me.lblConsRepInstructionsTitle.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblConsRepInstructionsTitle.BackColor = System.Drawing.SystemColors.Control
		Me.lblConsRepInstructionsTitle.Enabled = True
		Me.lblConsRepInstructionsTitle.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblConsRepInstructionsTitle.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblConsRepInstructionsTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblConsRepInstructionsTitle.UseMnemonic = True
		Me.lblConsRepInstructionsTitle.Visible = True
		Me.lblConsRepInstructionsTitle.AutoSize = False
		Me.lblConsRepInstructionsTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblConsRepInstructionsTitle.Name = "lblConsRepInstructionsTitle"
		Me.lbConsRepInstructions.Text = "lbConsRepInstructions"
		Me.lbConsRepInstructions.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbConsRepInstructions.Size = New System.Drawing.Size(537, 41)
		Me.lbConsRepInstructions.Location = New System.Drawing.Point(16, 24)
		Me.lbConsRepInstructions.TabIndex = 7
		Me.lbConsRepInstructions.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbConsRepInstructions.BackColor = System.Drawing.SystemColors.Control
		Me.lbConsRepInstructions.Enabled = True
		Me.lbConsRepInstructions.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbConsRepInstructions.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbConsRepInstructions.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbConsRepInstructions.UseMnemonic = True
		Me.lbConsRepInstructions.Visible = True
		Me.lbConsRepInstructions.AutoSize = False
		Me.lbConsRepInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbConsRepInstructions.Name = "lbConsRepInstructions"
		Me.Controls.Add(lvDificultades)
		Me.Controls.Add(lvConducta)
		Me.Controls.Add(lvInstrucciones)
		Me.Controls.Add(lvAmbiente)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdSave)
		Me.Controls.Add(lvRecomendaciones)
		Me.Controls.Add(lblConsRepInstructionsTitle)
		Me.Controls.Add(lbConsRepInstructions)
		Me.lvDificultades.Columns.Add(_lvDificultades_ColumnHeader_1)
		Me.lvConducta.Columns.Add(_lvConducta_ColumnHeader_1)
		Me.lvInstrucciones.Columns.Add(_lvInstrucciones_ColumnHeader_1)
		Me.lvAmbiente.Columns.Add(_lvAmbiente_ColumnHeader_1)
		Me.lvRecomendaciones.Columns.Add(_lvRecomendaciones_ColumnHeader_1)
		Me.lvDificultades.ResumeLayout(False)
		Me.lvConducta.ResumeLayout(False)
		Me.lvInstrucciones.ResumeLayout(False)
		Me.lvAmbiente.ResumeLayout(False)
		Me.lvRecomendaciones.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class