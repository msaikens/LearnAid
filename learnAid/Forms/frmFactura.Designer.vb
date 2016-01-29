<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmFactura
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
	Public WithEvents cmdExit As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents txtTotal As System.Windows.Forms.TextBox
	Public WithEvents txtAmount As System.Windows.Forms.TextBox
	Public WithEvents txtEst As System.Windows.Forms.TextBox
	Public WithEvents txtGrupos As System.Windows.Forms.TextBox
	Public WithEvents txtGrados As System.Windows.Forms.TextBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFactura))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdExit = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me.txtTotal = New System.Windows.Forms.TextBox
		Me.txtAmount = New System.Windows.Forms.TextBox
		Me.txtEst = New System.Windows.Forms.TextBox
		Me.txtGrupos = New System.Windows.Forms.TextBox
		Me.txtGrados = New System.Windows.Forms.TextBox
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Acomodo Razonable"
		Me.ClientSize = New System.Drawing.Size(536, 122)
		Me.Location = New System.Drawing.Point(3, 24)
		Me.ControlBox = False
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmFactura"
		Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdExit.Text = "Exit"
		Me.cmdExit.Size = New System.Drawing.Size(81, 25)
		Me.cmdExit.Location = New System.Drawing.Point(448, 88)
		Me.cmdExit.TabIndex = 6
		Me.cmdExit.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdExit.BackColor = System.Drawing.SystemColors.Control
		Me.cmdExit.CausesValidation = True
		Me.cmdExit.Enabled = True
		Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdExit.TabStop = True
		Me.cmdExit.Name = "cmdExit"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "Continue"
		Me.Command1.Size = New System.Drawing.Size(81, 25)
		Me.Command1.Location = New System.Drawing.Point(368, 88)
		Me.Command1.TabIndex = 5
		Me.Command1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.txtTotal.AutoSize = False
		Me.txtTotal.Enabled = False
		Me.txtTotal.Size = New System.Drawing.Size(89, 20)
		Me.txtTotal.Location = New System.Drawing.Point(432, 56)
		Me.txtTotal.TabIndex = 4
		Me.txtTotal.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTotal.AcceptsReturn = True
		Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTotal.BackColor = System.Drawing.SystemColors.Window
		Me.txtTotal.CausesValidation = True
		Me.txtTotal.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTotal.HideSelection = True
		Me.txtTotal.ReadOnly = False
		Me.txtTotal.Maxlength = 0
		Me.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTotal.MultiLine = False
		Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTotal.TabStop = True
		Me.txtTotal.Visible = True
		Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTotal.Name = "txtTotal"
		Me.txtAmount.AutoSize = False
		Me.txtAmount.Size = New System.Drawing.Size(89, 20)
		Me.txtAmount.Location = New System.Drawing.Point(336, 56)
		Me.txtAmount.TabIndex = 3
		Me.txtAmount.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAmount.AcceptsReturn = True
		Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtAmount.BackColor = System.Drawing.SystemColors.Window
		Me.txtAmount.CausesValidation = True
		Me.txtAmount.Enabled = True
		Me.txtAmount.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtAmount.HideSelection = True
		Me.txtAmount.ReadOnly = False
		Me.txtAmount.Maxlength = 0
		Me.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtAmount.MultiLine = False
		Me.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAmount.TabStop = True
		Me.txtAmount.Visible = True
		Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtAmount.Name = "txtAmount"
		Me.txtEst.AutoSize = False
		Me.txtEst.Size = New System.Drawing.Size(89, 20)
		Me.txtEst.Location = New System.Drawing.Point(240, 56)
		Me.txtEst.TabIndex = 2
		Me.txtEst.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtEst.AcceptsReturn = True
		Me.txtEst.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtEst.BackColor = System.Drawing.SystemColors.Window
		Me.txtEst.CausesValidation = True
		Me.txtEst.Enabled = True
		Me.txtEst.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtEst.HideSelection = True
		Me.txtEst.ReadOnly = False
		Me.txtEst.Maxlength = 0
		Me.txtEst.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtEst.MultiLine = False
		Me.txtEst.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtEst.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtEst.TabStop = True
		Me.txtEst.Visible = True
		Me.txtEst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtEst.Name = "txtEst"
		Me.txtGrupos.AutoSize = False
		Me.txtGrupos.Size = New System.Drawing.Size(89, 20)
		Me.txtGrupos.Location = New System.Drawing.Point(136, 56)
		Me.txtGrupos.TabIndex = 1
		Me.txtGrupos.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGrupos.AcceptsReturn = True
		Me.txtGrupos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtGrupos.BackColor = System.Drawing.SystemColors.Window
		Me.txtGrupos.CausesValidation = True
		Me.txtGrupos.Enabled = True
		Me.txtGrupos.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtGrupos.HideSelection = True
		Me.txtGrupos.ReadOnly = False
		Me.txtGrupos.Maxlength = 0
		Me.txtGrupos.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtGrupos.MultiLine = False
		Me.txtGrupos.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtGrupos.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtGrupos.TabStop = True
		Me.txtGrupos.Visible = True
		Me.txtGrupos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtGrupos.Name = "txtGrupos"
		Me.txtGrados.AutoSize = False
		Me.txtGrados.Size = New System.Drawing.Size(89, 20)
		Me.txtGrados.Location = New System.Drawing.Point(24, 56)
		Me.txtGrados.TabIndex = 0
		Me.txtGrados.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGrados.AcceptsReturn = True
		Me.txtGrados.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtGrados.BackColor = System.Drawing.SystemColors.Window
		Me.txtGrados.CausesValidation = True
		Me.txtGrados.Enabled = True
		Me.txtGrados.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtGrados.HideSelection = True
		Me.txtGrados.ReadOnly = False
		Me.txtGrados.Maxlength = 0
		Me.txtGrados.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtGrados.MultiLine = False
		Me.txtGrados.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtGrados.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtGrados.TabStop = True
		Me.txtGrados.Visible = True
		Me.txtGrados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtGrados.Name = "txtGrados"
		Me.Label6.Text = "Total:"
		Me.Label6.Size = New System.Drawing.Size(81, 17)
		Me.Label6.Location = New System.Drawing.Point(432, 40)
		Me.Label6.TabIndex = 12
		Me.Label6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Label5.Text = "Precio/Grupo"
		Me.Label5.Size = New System.Drawing.Size(81, 17)
		Me.Label5.Location = New System.Drawing.Point(336, 40)
		Me.Label5.TabIndex = 11
		Me.Label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label4.Text = "# Estudiantes"
		Me.Label4.Size = New System.Drawing.Size(81, 17)
		Me.Label4.Location = New System.Drawing.Point(240, 40)
		Me.Label4.TabIndex = 10
		Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label3.Text = "# Grupos:"
		Me.Label3.Size = New System.Drawing.Size(49, 17)
		Me.Label3.Location = New System.Drawing.Point(136, 40)
		Me.Label3.TabIndex = 9
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label2.Text = "Grados:"
		Me.Label2.Size = New System.Drawing.Size(49, 25)
		Me.Label2.Location = New System.Drawing.Point(24, 40)
		Me.Label2.TabIndex = 8
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.Text = "Acomodo Razonable:"
		Me.Label1.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Size = New System.Drawing.Size(153, 17)
		Me.Label1.Location = New System.Drawing.Point(232, 8)
		Me.Label1.TabIndex = 7
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(cmdExit)
		Me.Controls.Add(Command1)
		Me.Controls.Add(txtTotal)
		Me.Controls.Add(txtAmount)
		Me.Controls.Add(txtEst)
		Me.Controls.Add(txtGrupos)
		Me.Controls.Add(txtGrados)
		Me.Controls.Add(Label6)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class