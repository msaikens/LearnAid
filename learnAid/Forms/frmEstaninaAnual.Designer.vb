<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmEstaninaAnual
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
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents cmdProcesar As System.Windows.Forms.Button
	Public WithEvents txtY As System.Windows.Forms.TextBox
	Public WithEvents txtYear As System.Windows.Forms.TextBox
	Public WithEvents lblLes As System.Windows.Forms.Label
	Public WithEvents lblNV As System.Windows.Forms.Label
	Public WithEvents lblMat As System.Windows.Forms.Label
	Public WithEvents lblREN As System.Windows.Forms.Label
	Public WithEvents lblStatus As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdProcesar = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txtY = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lblLes = New System.Windows.Forms.Label()
        Me.lblNV = New System.Windows.Forms.Label()
        Me.lblMat = New System.Windows.Forms.Label()
        Me.lblREN = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClose.Location = New System.Drawing.Point(401, 192)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(64, 28)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "Cerrar"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cmdProcesar
        '
        Me.cmdProcesar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdProcesar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdProcesar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProcesar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdProcesar.Location = New System.Drawing.Point(320, 192)
        Me.cmdProcesar.Name = "cmdProcesar"
        Me.cmdProcesar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdProcesar.Size = New System.Drawing.Size(79, 28)
        Me.cmdProcesar.TabIndex = 3
        Me.cmdProcesar.Text = "Crear"
        Me.cmdProcesar.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtY)
        Me.Frame1.Controls.Add(Me.txtYear)
        Me.Frame1.Controls.Add(Me.lblLes)
        Me.Frame1.Controls.Add(Me.lblNV)
        Me.Frame1.Controls.Add(Me.lblMat)
        Me.Frame1.Controls.Add(Me.lblREN)
        Me.Frame1.Controls.Add(Me.lblStatus)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(2, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(467, 189)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'txtY
        '
        Me.txtY.AcceptsReturn = True
        Me.txtY.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtY.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtY.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtY.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtY.Location = New System.Drawing.Point(48, 160)
        Me.txtY.MaxLength = 0
        Me.txtY.Name = "txtY"
        Me.txtY.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtY.Size = New System.Drawing.Size(47, 20)
        Me.txtY.TabIndex = 12
        Me.txtY.Text = "0"
        Me.txtY.Visible = False
        '
        'txtYear
        '
        Me.txtYear.AcceptsReturn = True
        Me.txtYear.BackColor = System.Drawing.SystemColors.Window
        Me.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtYear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtYear.Location = New System.Drawing.Point(168, 96)
        Me.txtYear.MaxLength = 0
        Me.txtYear.Name = "txtYear"
        Me.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtYear.Size = New System.Drawing.Size(47, 20)
        Me.txtYear.TabIndex = 1
        Me.txtYear.Text = "2008"
        '
        'lblLes
        '
        Me.lblLes.BackColor = System.Drawing.SystemColors.Control
        Me.lblLes.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLes.Location = New System.Drawing.Point(184, 160)
        Me.lblLes.Name = "lblLes"
        Me.lblLes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLes.Size = New System.Drawing.Size(33, 23)
        Me.lblLes.TabIndex = 11
        Me.lblLes.Text = "LES"
        Me.lblLes.Visible = False
        '
        'lblNV
        '
        Me.lblNV.BackColor = System.Drawing.SystemColors.Control
        Me.lblNV.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNV.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNV.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNV.Location = New System.Drawing.Point(152, 160)
        Me.lblNV.Name = "lblNV"
        Me.lblNV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNV.Size = New System.Drawing.Size(33, 23)
        Me.lblNV.TabIndex = 10
        Me.lblNV.Text = "NV"
        Me.lblNV.Visible = False
        '
        'lblMat
        '
        Me.lblMat.BackColor = System.Drawing.SystemColors.Control
        Me.lblMat.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMat.Location = New System.Drawing.Point(224, 160)
        Me.lblMat.Name = "lblMat"
        Me.lblMat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMat.Size = New System.Drawing.Size(33, 23)
        Me.lblMat.TabIndex = 9
        Me.lblMat.Text = "MAT"
        Me.lblMat.Visible = False
        '
        'lblREN
        '
        Me.lblREN.BackColor = System.Drawing.SystemColors.Control
        Me.lblREN.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblREN.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblREN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblREN.Location = New System.Drawing.Point(112, 160)
        Me.lblREN.Name = "lblREN"
        Me.lblREN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblREN.Size = New System.Drawing.Size(33, 23)
        Me.lblREN.TabIndex = 8
        Me.lblREN.Text = "REN"
        Me.lblREN.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.SystemColors.Control
        Me.lblStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStatus.Location = New System.Drawing.Point(48, 144)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStatus.Size = New System.Drawing.Size(41, 24)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "Status:"
        Me.lblStatus.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(168, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(153, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ejemplo: 2008 significa 08-09"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(454, 54)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DISTRIBUCION PORCENTUAL DE ESTUDIANTES EN CADA ESTANINA POR PRUEBA ADMINISTRADA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(55, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(121, 22)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "SELECCIONE EL AÑO:"
        '
        'frmEstaninaAnual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(481, 226)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdProcesar)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmEstaninaAnual"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Dist. Estanina Anual"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class