<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPrintReport
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
	Public WithEvents chkMAT As System.Windows.Forms.CheckBox
	Public WithEvents chkREN As System.Windows.Forms.CheckBox
	Public WithEvents chkLES As System.Windows.Forms.CheckBox
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents cmdLabel As System.Windows.Forms.Button
	Public WithEvents chkLista As System.Windows.Forms.CheckBox
	Public WithEvents chkTecnico As System.Windows.Forms.CheckBox
	Public WithEvents chkRegular As System.Windows.Forms.CheckBox
	Public WithEvents txtTo As System.Windows.Forms.TextBox
	Public WithEvents txtFrom As System.Windows.Forms.TextBox
	Public WithEvents chkMID As System.Windows.Forms.CheckBox
	Public WithEvents chkDestrezas As System.Windows.Forms.CheckBox
	Public WithEvents chkIndiv As System.Windows.Forms.CheckBox
	Public WithEvents chkInvoice As System.Windows.Forms.CheckBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdContinue As System.Windows.Forms.Button
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents chk_preview As System.Windows.Forms.CheckBox
	Public WithEvents lblReport As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintReport))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkMAT = New System.Windows.Forms.CheckBox()
        Me.chkREN = New System.Windows.Forms.CheckBox()
        Me.chkLES = New System.Windows.Forms.CheckBox()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.cmdLabel = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.chkLista = New System.Windows.Forms.CheckBox()
        Me.chkTecnico = New System.Windows.Forms.CheckBox()
        Me.chkRegular = New System.Windows.Forms.CheckBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.chkMID = New System.Windows.Forms.CheckBox()
        Me.chkDestrezas = New System.Windows.Forms.CheckBox()
        Me.chkIndiv = New System.Windows.Forms.CheckBox()
        Me.chkInvoice = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdContinue = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.chk_preview = New System.Windows.Forms.CheckBox()
        Me.lblReport = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkMAT
        '
        Me.chkMAT.BackColor = System.Drawing.SystemColors.Control
        Me.chkMAT.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkMAT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMAT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMAT.Location = New System.Drawing.Point(293, 24)
        Me.chkMAT.Name = "chkMAT"
        Me.chkMAT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMAT.Size = New System.Drawing.Size(59, 25)
        Me.chkMAT.TabIndex = 18
        Me.chkMAT.Text = "MAT"
        Me.chkMAT.UseVisualStyleBackColor = False
        '
        'chkREN
        '
        Me.chkREN.BackColor = System.Drawing.SystemColors.Control
        Me.chkREN.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkREN.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkREN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkREN.Location = New System.Drawing.Point(228, 24)
        Me.chkREN.Name = "chkREN"
        Me.chkREN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkREN.Size = New System.Drawing.Size(59, 25)
        Me.chkREN.TabIndex = 17
        Me.chkREN.Text = "REN"
        Me.chkREN.UseVisualStyleBackColor = False
        '
        'chkLES
        '
        Me.chkLES.BackColor = System.Drawing.SystemColors.Control
        Me.chkLES.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkLES.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLES.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkLES.Location = New System.Drawing.Point(163, 24)
        Me.chkLES.Name = "chkLES"
        Me.chkLES.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkLES.Size = New System.Drawing.Size(59, 25)
        Me.chkLES.TabIndex = 16
        Me.chkLES.Text = "ESP"
        Me.chkLES.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(12, 279)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(97, 47)
        Me.Command1.TabIndex = 14
        Me.Command1.Text = "Print Experimental"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'cmdLabel
        '
        Me.cmdLabel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLabel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLabel.Location = New System.Drawing.Point(115, 279)
        Me.cmdLabel.Name = "cmdLabel"
        Me.cmdLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLabel.Size = New System.Drawing.Size(81, 47)
        Me.cmdLabel.TabIndex = 13
        Me.cmdLabel.Text = "Print Labels"
        Me.cmdLabel.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.chkLES)
        Me.Frame1.Controls.Add(Me.chkREN)
        Me.Frame1.Controls.Add(Me.chkMAT)
        Me.Frame1.Controls.Add(Me.chkLista)
        Me.Frame1.Controls.Add(Me.chkTecnico)
        Me.Frame1.Controls.Add(Me.chkRegular)
        Me.Frame1.Controls.Add(Me.txtTo)
        Me.Frame1.Controls.Add(Me.txtFrom)
        Me.Frame1.Controls.Add(Me.chkMID)
        Me.Frame1.Controls.Add(Me.chkDestrezas)
        Me.Frame1.Controls.Add(Me.chkIndiv)
        Me.Frame1.Controls.Add(Me.chkInvoice)
        Me.Frame1.Controls.Add(Me.Label6)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(355, 205)
        Me.Frame1.TabIndex = 3
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Report Options"
        '
        'chkLista
        '
        Me.chkLista.BackColor = System.Drawing.SystemColors.Control
        Me.chkLista.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkLista.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLista.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkLista.Location = New System.Drawing.Point(228, 75)
        Me.chkLista.Name = "chkLista"
        Me.chkLista.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkLista.Size = New System.Drawing.Size(79, 19)
        Me.chkLista.TabIndex = 19
        Me.chkLista.Text = "Lista Est."
        Me.chkLista.UseVisualStyleBackColor = False
        '
        'chkTecnico
        '
        Me.chkTecnico.BackColor = System.Drawing.SystemColors.Control
        Me.chkTecnico.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTecnico.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTecnico.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkTecnico.Location = New System.Drawing.Point(104, 75)
        Me.chkTecnico.Name = "chkTecnico"
        Me.chkTecnico.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkTecnico.Size = New System.Drawing.Size(79, 19)
        Me.chkTecnico.TabIndex = 15
        Me.chkTecnico.Text = "Tecnico"
        Me.chkTecnico.UseVisualStyleBackColor = False
        '
        'chkRegular
        '
        Me.chkRegular.BackColor = System.Drawing.SystemColors.Control
        Me.chkRegular.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkRegular.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRegular.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkRegular.Location = New System.Drawing.Point(104, 48)
        Me.chkRegular.Name = "chkRegular"
        Me.chkRegular.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkRegular.Size = New System.Drawing.Size(89, 25)
        Me.chkRegular.TabIndex = 12
        Me.chkRegular.Text = "Regular"
        Me.chkRegular.UseVisualStyleBackColor = False
        '
        'txtTo
        '
        Me.txtTo.AcceptsReturn = True
        Me.txtTo.BackColor = System.Drawing.SystemColors.Window
        Me.txtTo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTo.Location = New System.Drawing.Point(92, 175)
        Me.txtTo.MaxLength = 0
        Me.txtTo.Name = "txtTo"
        Me.txtTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTo.Size = New System.Drawing.Size(33, 19)
        Me.txtTo.TabIndex = 9
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
        Me.txtFrom.Location = New System.Drawing.Point(104, 142)
        Me.txtFrom.MaxLength = 0
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFrom.Size = New System.Drawing.Size(33, 19)
        Me.txtFrom.TabIndex = 8
        Me.txtFrom.Tag = resources.GetString("txtFrom.Tag")
        Me.txtFrom.Text = "0"
        '
        'chkMID
        '
        Me.chkMID.BackColor = System.Drawing.SystemColors.Control
        Me.chkMID.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkMID.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkMID.Location = New System.Drawing.Point(16, 48)
        Me.chkMID.Name = "chkMID"
        Me.chkMID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMID.Size = New System.Drawing.Size(89, 25)
        Me.chkMID.TabIndex = 7
        Me.chkMID.Text = "Middle State"
        Me.chkMID.UseVisualStyleBackColor = False
        '
        'chkDestrezas
        '
        Me.chkDestrezas.BackColor = System.Drawing.SystemColors.Control
        Me.chkDestrezas.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDestrezas.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDestrezas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDestrezas.Location = New System.Drawing.Point(104, 24)
        Me.chkDestrezas.Name = "chkDestrezas"
        Me.chkDestrezas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDestrezas.Size = New System.Drawing.Size(89, 25)
        Me.chkDestrezas.TabIndex = 6
        Me.chkDestrezas.Text = "Skills"
        Me.chkDestrezas.UseVisualStyleBackColor = False
        '
        'chkIndiv
        '
        Me.chkIndiv.BackColor = System.Drawing.SystemColors.Control
        Me.chkIndiv.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkIndiv.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIndiv.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkIndiv.Location = New System.Drawing.Point(16, 24)
        Me.chkIndiv.Name = "chkIndiv"
        Me.chkIndiv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkIndiv.Size = New System.Drawing.Size(89, 25)
        Me.chkIndiv.TabIndex = 5
        Me.chkIndiv.Text = "Individual"
        Me.chkIndiv.UseVisualStyleBackColor = False
        '
        'chkInvoice
        '
        Me.chkInvoice.BackColor = System.Drawing.SystemColors.Control
        Me.chkInvoice.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkInvoice.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInvoice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkInvoice.Location = New System.Drawing.Point(16, 72)
        Me.chkInvoice.Name = "chkInvoice"
        Me.chkInvoice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkInvoice.Size = New System.Drawing.Size(89, 25)
        Me.chkInvoice.TabIndex = 4
        Me.chkInvoice.Text = "Print Invoice"
        Me.chkInvoice.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(12, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "To Grade:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(16, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(89, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "From Grade:"
        '
        'cmdContinue
        '
        Me.cmdContinue.BackColor = System.Drawing.SystemColors.Control
        Me.cmdContinue.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdContinue.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdContinue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdContinue.Location = New System.Drawing.Point(202, 279)
        Me.cmdContinue.Name = "cmdContinue"
        Me.cmdContinue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdContinue.Size = New System.Drawing.Size(89, 47)
        Me.cmdContinue.TabIndex = 1
        Me.cmdContinue.Text = "Print Report"
        Me.cmdContinue.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(297, 279)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(73, 47)
        Me.cmdCancel.TabIndex = 0
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'chk_preview
        '
        Me.chk_preview.BackColor = System.Drawing.SystemColors.Control
        Me.chk_preview.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk_preview.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_preview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk_preview.Location = New System.Drawing.Point(12, 231)
        Me.chk_preview.Name = "chk_preview"
        Me.chk_preview.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk_preview.Size = New System.Drawing.Size(81, 17)
        Me.chk_preview.TabIndex = 2
        Me.chk_preview.Text = "Preview"
        Me.chk_preview.UseVisualStyleBackColor = False
        '
        'lblReport
        '
        Me.lblReport.BackColor = System.Drawing.SystemColors.Control
        Me.lblReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblReport.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblReport.Location = New System.Drawing.Point(224, 216)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblReport.Size = New System.Drawing.Size(81, 17)
        Me.lblReport.TabIndex = 20
        '
        'frmPrintReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(375, 338)
        Me.ControlBox = False
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.cmdLabel)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdContinue)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.chk_preview)
        Me.Controls.Add(Me.lblReport)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(4, 29)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrintReport"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Report"
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class