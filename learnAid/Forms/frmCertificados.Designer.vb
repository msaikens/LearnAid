<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCertificados
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
	Public WithEvents cmdConnTest As System.Windows.Forms.Button
	Public WithEvents chkNV As System.Windows.Forms.CheckBox
	Public WithEvents chkMAT As System.Windows.Forms.CheckBox
	Public WithEvents chkREN As System.Windows.Forms.CheckBox
	Public WithEvents chkLES As System.Windows.Forms.CheckBox
	Public WithEvents cmdBuscar As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents List2 As System.Windows.Forms.ListBox
	Public WithEvents cmdSalir As System.Windows.Forms.Button
	Public WithEvents cmdCrear As System.Windows.Forms.Button
	Public WithEvents List1 As System.Windows.Forms.ListBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents lclColegio As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdConnTest = New System.Windows.Forms.Button()
        Me.chkNV = New System.Windows.Forms.CheckBox()
        Me.chkMAT = New System.Windows.Forms.CheckBox()
        Me.chkREN = New System.Windows.Forms.CheckBox()
        Me.chkLES = New System.Windows.Forms.CheckBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.List2 = New System.Windows.Forms.ListBox()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.List1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lclColegio = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'cmdConnTest
        '
        Me.cmdConnTest.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConnTest.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConnTest.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdConnTest.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConnTest.Location = New System.Drawing.Point(400, 352)
        Me.cmdConnTest.Name = "cmdConnTest"
        Me.cmdConnTest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConnTest.Size = New System.Drawing.Size(94, 28)
        Me.cmdConnTest.TabIndex = 13
        Me.cmdConnTest.Text = "Conn Test"
        Me.cmdConnTest.UseVisualStyleBackColor = false
        '
        'chkNV
        '
        Me.chkNV.BackColor = System.Drawing.SystemColors.Control
        Me.chkNV.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkNV.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkNV.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkNV.Location = New System.Drawing.Point(207, 288)
        Me.chkNV.Name = "chkNV"
        Me.chkNV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNV.Size = New System.Drawing.Size(52, 19)
        Me.chkNV.TabIndex = 12
        Me.chkNV.Text = "NV"
        Me.chkNV.UseVisualStyleBackColor = false
        '
        'chkMAT
        '
        Me.chkMAT.BackColor = System.Drawing.SystemColors.Control
        Me.chkMAT.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkMAT.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkMAT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMAT.Location = New System.Drawing.Point(147, 288)
        Me.chkMAT.Name = "chkMAT"
        Me.chkMAT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMAT.Size = New System.Drawing.Size(52, 19)
        Me.chkMAT.TabIndex = 11
        Me.chkMAT.Text = "MAT"
        Me.chkMAT.UseVisualStyleBackColor = false
        '
        'chkREN
        '
        Me.chkREN.BackColor = System.Drawing.SystemColors.Control
        Me.chkREN.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkREN.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkREN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkREN.Location = New System.Drawing.Point(87, 288)
        Me.chkREN.Name = "chkREN"
        Me.chkREN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkREN.Size = New System.Drawing.Size(52, 19)
        Me.chkREN.TabIndex = 10
        Me.chkREN.Text = "REN"
        Me.chkREN.UseVisualStyleBackColor = false
        '
        'chkLES
        '
        Me.chkLES.BackColor = System.Drawing.SystemColors.Control
        Me.chkLES.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkLES.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.chkLES.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkLES.Location = New System.Drawing.Point(21, 288)
        Me.chkLES.Name = "chkLES"
        Me.chkLES.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkLES.Size = New System.Drawing.Size(52, 19)
        Me.chkLES.TabIndex = 9
        Me.chkLES.Text = "LES"
        Me.chkLES.UseVisualStyleBackColor = false
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBuscar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBuscar.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBuscar.Location = New System.Drawing.Point(207, 318)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBuscar.Size = New System.Drawing.Size(94, 28)
        Me.cmdBuscar.TabIndex = 8
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = false
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(468, 180)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(40, 25)
        Me.Command1.TabIndex = 6
        Me.Command1.Text = ">>"
        Me.Command1.UseVisualStyleBackColor = false
        '
        'List2
        '
        Me.List2.BackColor = System.Drawing.SystemColors.Window
        Me.List2.Cursor = System.Windows.Forms.Cursors.Default
        Me.List2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.List2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.List2.ItemHeight = 14
        Me.List2.Location = New System.Drawing.Point(540, 120)
        Me.List2.Name = "List2"
        Me.List2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.List2.Size = New System.Drawing.Size(298, 172)
        Me.List2.TabIndex = 5
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSalir.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSalir.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdSalir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSalir.Location = New System.Drawing.Point(771, 390)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSalir.Size = New System.Drawing.Size(67, 40)
        Me.cmdSalir.TabIndex = 4
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = false
        '
        'cmdCrear
        '
        Me.cmdCrear.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCrear.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCrear.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdCrear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCrear.Location = New System.Drawing.Point(633, 300)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCrear.Size = New System.Drawing.Size(97, 28)
        Me.cmdCrear.TabIndex = 3
        Me.cmdCrear.Text = "Crear Certificados"
        Me.cmdCrear.UseVisualStyleBackColor = false
        '
        'List1
        '
        Me.List1.BackColor = System.Drawing.SystemColors.Window
        Me.List1.Cursor = System.Windows.Forms.Cursors.Default
        Me.List1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.List1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.List1.ItemHeight = 14
        Me.List1.Location = New System.Drawing.Point(15, 117)
        Me.List1.Name = "List1"
        Me.List1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.List1.Size = New System.Drawing.Size(433, 158)
        Me.List1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(546, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(193, 22)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Listado Final"
        '
        'lclColegio
        '
        Me.lclColegio.BackColor = System.Drawing.SystemColors.Control
        Me.lclColegio.Cursor = System.Windows.Forms.Cursors.Default
        Me.lclColegio.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lclColegio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lclColegio.Location = New System.Drawing.Point(21, 42)
        Me.lclColegio.Name = "lclColegio"
        Me.lclColegio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lclColegio.Size = New System.Drawing.Size(814, 22)
        Me.lclColegio.TabIndex = 1
        Me.lclColegio.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(811, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Certifados de Reconocimiento para:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmCertificados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 14!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(849, 434)
        Me.Controls.Add(Me.cmdConnTest)
        Me.Controls.Add(Me.chkNV)
        Me.Controls.Add(Me.chkMAT)
        Me.Controls.Add(Me.chkREN)
        Me.Controls.Add(Me.chkLES)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.List2)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lclColegio)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmCertificados"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Certificados"
        Me.ResumeLayout(false)

End Sub
#End Region 
End Class