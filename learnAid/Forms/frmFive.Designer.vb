<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmFive
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
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents cmdProcesar As System.Windows.Forms.Button
	Public WithEvents txtYear As System.Windows.Forms.TextBox
	Public WithEvents cbosem As System.Windows.Forms.ComboBox
	Public WithEvents cboHasta As System.Windows.Forms.ComboBox
	Public WithEvents cboDesde As System.Windows.Forms.ComboBox
	Public WithEvents cboSchools As System.Windows.Forms.ComboBox
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents lblStatus As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.cmdProcesar = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.cbosem = New System.Windows.Forms.ComboBox()
        Me.cboHasta = New System.Windows.Forms.ComboBox()
        Me.cboDesde = New System.Windows.Forms.ComboBox()
        Me.cboSchools = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(193, 312)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(91, 28)
        Me.Command2.TabIndex = 14
        Me.Command2.Text = "Pre-Post Excel"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(8, 315)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(179, 25)
        Me.Command1.TabIndex = 13
        Me.Command1.Text = "Procesar Colegios"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'cmdProcesar
        '
        Me.cmdProcesar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdProcesar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdProcesar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProcesar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdProcesar.Location = New System.Drawing.Point(290, 312)
        Me.cmdProcesar.Name = "cmdProcesar"
        Me.cmdProcesar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdProcesar.Size = New System.Drawing.Size(101, 28)
        Me.cmdProcesar.TabIndex = 8
        Me.cmdProcesar.Text = "Procesar"
        Me.cmdProcesar.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtYear)
        Me.Frame1.Controls.Add(Me.cbosem)
        Me.Frame1.Controls.Add(Me.cboHasta)
        Me.Frame1.Controls.Add(Me.cboDesde)
        Me.Frame1.Controls.Add(Me.cboSchools)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(6, 9)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(355, 157)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'txtYear
        '
        Me.txtYear.AcceptsReturn = True
        Me.txtYear.BackColor = System.Drawing.SystemColors.Window
        Me.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtYear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtYear.Location = New System.Drawing.Point(228, 117)
        Me.txtYear.MaxLength = 0
        Me.txtYear.Name = "txtYear"
        Me.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtYear.Size = New System.Drawing.Size(79, 23)
        Me.txtYear.TabIndex = 12
        Me.txtYear.Text = "2008"
        '
        'cbosem
        '
        Me.cbosem.BackColor = System.Drawing.SystemColors.Window
        Me.cbosem.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbosem.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbosem.Items.AddRange(New Object() {"BOTH", "1", "2"})
        Me.cbosem.Location = New System.Drawing.Point(93, 114)
        Me.cbosem.Name = "cbosem"
        Me.cbosem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbosem.Size = New System.Drawing.Size(73, 24)
        Me.cbosem.TabIndex = 9
        Me.cbosem.Text = "Combo1"
        '
        'cboHasta
        '
        Me.cboHasta.BackColor = System.Drawing.SystemColors.Window
        Me.cboHasta.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboHasta.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHasta.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboHasta.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cboHasta.Location = New System.Drawing.Point(228, 78)
        Me.cboHasta.Name = "cboHasta"
        Me.cboHasta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboHasta.Size = New System.Drawing.Size(88, 24)
        Me.cboHasta.TabIndex = 4
        Me.cboHasta.Text = "Combo1"
        '
        'cboDesde
        '
        Me.cboDesde.BackColor = System.Drawing.SystemColors.Window
        Me.cboDesde.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboDesde.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDesde.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDesde.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cboDesde.Location = New System.Drawing.Point(90, 75)
        Me.cboDesde.Name = "cboDesde"
        Me.cboDesde.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboDesde.Size = New System.Drawing.Size(79, 24)
        Me.cboDesde.TabIndex = 3
        Me.cboDesde.Text = "Combo1"
        '
        'cboSchools
        '
        Me.cboSchools.BackColor = System.Drawing.SystemColors.Window
        Me.cboSchools.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboSchools.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSchools.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSchools.Location = New System.Drawing.Point(90, 42)
        Me.cboSchools.Name = "cboSchools"
        Me.cboSchools.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboSchools.Size = New System.Drawing.Size(229, 24)
        Me.cboSchools.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(186, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(34, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Año:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(24, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(58, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Semestre:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(21, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(63, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Colegio:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(175, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(52, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(24, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Desde"
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClose.Location = New System.Drawing.Point(407, 312)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(64, 28)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.SystemColors.Control
        Me.lblStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStatus.Location = New System.Drawing.Point(10, 170)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStatus.Size = New System.Drawing.Size(236, 21)
        Me.lblStatus.TabIndex = 15
        '
        'frmFive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(483, 352)
        Me.ControlBox = False
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.cmdProcesar)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.lblStatus)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmFive"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Five Years"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class