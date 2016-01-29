<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmEditConsEntry
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
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdSave As System.Windows.Forms.Button
	Public WithEvents txtText As System.Windows.Forms.TextBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEditConsEntry))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdSave = New System.Windows.Forms.Button
		Me.txtText = New System.Windows.Forms.TextBox
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "View Entry"
		Me.ClientSize = New System.Drawing.Size(339, 137)
		Me.Location = New System.Drawing.Point(3, 29)
		Me.ControlBox = False
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmEditConsEntry"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "&Close"
		Me.cmdCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.Size = New System.Drawing.Size(81, 25)
		Me.cmdCancel.Location = New System.Drawing.Point(248, 104)
		Me.cmdCancel.TabIndex = 2
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSave.Text = "&Save"
		Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSave.Size = New System.Drawing.Size(81, 25)
		Me.cmdSave.Location = New System.Drawing.Point(160, 104)
		Me.cmdSave.TabIndex = 1
		Me.cmdSave.Visible = False
		Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSave.CausesValidation = True
		Me.cmdSave.Enabled = True
		Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSave.TabStop = True
		Me.cmdSave.Name = "cmdSave"
		Me.txtText.AutoSize = False
		Me.txtText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtText.Size = New System.Drawing.Size(321, 89)
		Me.txtText.Location = New System.Drawing.Point(8, 8)
		Me.txtText.ReadOnly = True
		Me.txtText.MultiLine = True
		Me.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtText.TabIndex = 0
		Me.txtText.Text = "Text1"
		Me.txtText.AcceptsReturn = True
		Me.txtText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtText.BackColor = System.Drawing.SystemColors.Window
		Me.txtText.CausesValidation = True
		Me.txtText.Enabled = True
		Me.txtText.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtText.HideSelection = True
		Me.txtText.Maxlength = 0
		Me.txtText.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtText.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtText.TabStop = True
		Me.txtText.Visible = True
		Me.txtText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtText.Name = "txtText"
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdSave)
		Me.Controls.Add(txtText)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class