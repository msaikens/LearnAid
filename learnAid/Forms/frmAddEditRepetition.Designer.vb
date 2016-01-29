<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAddEditRepetition
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
	Public WithEvents txtAction As System.Windows.Forms.TextBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents txtData As System.Windows.Forms.TextBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAddEditRepetition))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.txtAction = New System.Windows.Forms.TextBox
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOk = New System.Windows.Forms.Button
		Me.txtData = New System.Windows.Forms.TextBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = " "
		Me.ClientSize = New System.Drawing.Size(309, 80)
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
		Me.Name = "frmAddEditRepetition"
		Me.txtAction.AutoSize = False
		Me.txtAction.Size = New System.Drawing.Size(65, 19)
		Me.txtAction.Location = New System.Drawing.Point(232, 88)
		Me.txtAction.TabIndex = 4
		Me.txtAction.Text = "Text2"
		Me.txtAction.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAction.AcceptsReturn = True
		Me.txtAction.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtAction.BackColor = System.Drawing.SystemColors.Window
		Me.txtAction.CausesValidation = True
		Me.txtAction.Enabled = True
		Me.txtAction.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtAction.HideSelection = True
		Me.txtAction.ReadOnly = False
		Me.txtAction.Maxlength = 0
		Me.txtAction.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtAction.MultiLine = False
		Me.txtAction.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtAction.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAction.TabStop = True
		Me.txtAction.Visible = True
		Me.txtAction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtAction.Name = "txtAction"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "&Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(65, 25)
		Me.cmdCancel.Location = New System.Drawing.Point(232, 48)
		Me.cmdCancel.TabIndex = 3
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOk.Text = "&Ok"
		Me.cmdOk.Size = New System.Drawing.Size(65, 25)
		Me.cmdOk.Location = New System.Drawing.Point(160, 48)
		Me.cmdOk.TabIndex = 2
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		Me.txtData.AutoSize = False
		Me.txtData.Size = New System.Drawing.Size(289, 19)
		Me.txtData.Location = New System.Drawing.Point(8, 24)
		Me.txtData.TabIndex = 0
		Me.txtData.Text = "Text1"
		Me.txtData.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtData.AcceptsReturn = True
		Me.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtData.BackColor = System.Drawing.SystemColors.Window
		Me.txtData.CausesValidation = True
		Me.txtData.Enabled = True
		Me.txtData.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtData.HideSelection = True
		Me.txtData.ReadOnly = False
		Me.txtData.Maxlength = 0
		Me.txtData.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtData.MultiLine = False
		Me.txtData.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtData.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtData.TabStop = True
		Me.txtData.Visible = True
		Me.txtData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtData.Name = "txtData"
		Me.Label1.Text = "Repetition:"
		Me.Label1.Size = New System.Drawing.Size(113, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 8)
		Me.Label1.TabIndex = 1
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.Controls.Add(txtAction)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(txtData)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class