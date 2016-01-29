<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmGenericCal
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
	Public WithEvents cmdToday As System.Windows.Forms.Button
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents Calendar1 As AxMSACAL.AxCalendar
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmGenericCal))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdToday = New System.Windows.Forms.Button
		Me.cmdClose = New System.Windows.Forms.Button
		Me.Calendar1 = New AxMSACAL.AxCalendar
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.Calendar1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ControlBox = False
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.ClientSize = New System.Drawing.Size(284, 221)
		Me.Location = New System.Drawing.Point(3, 3)
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
		Me.Name = "frmGenericCal"
		Me.cmdToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdToday.Text = "&Today"
		Me.cmdToday.Size = New System.Drawing.Size(73, 25)
		Me.cmdToday.Location = New System.Drawing.Point(120, 192)
		Me.cmdToday.TabIndex = 2
		Me.cmdToday.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdToday.BackColor = System.Drawing.SystemColors.Control
		Me.cmdToday.CausesValidation = True
		Me.cmdToday.Enabled = True
		Me.cmdToday.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdToday.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdToday.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdToday.TabStop = True
		Me.cmdToday.Name = "cmdToday"
		Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClose.Text = "&Close"
		Me.cmdClose.Size = New System.Drawing.Size(73, 25)
		Me.cmdClose.Location = New System.Drawing.Point(200, 192)
		Me.cmdClose.TabIndex = 1
		Me.cmdClose.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.CausesValidation = True
		Me.cmdClose.Enabled = True
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.TabStop = True
		Me.cmdClose.Name = "cmdClose"
		Calendar1.OcxState = CType(resources.GetObject("Calendar1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Calendar1.Size = New System.Drawing.Size(281, 193)
		Me.Calendar1.Location = New System.Drawing.Point(0, 0)
		Me.Calendar1.TabIndex = 0
		Me.Calendar1.Name = "Calendar1"
		Me.Controls.Add(cmdToday)
		Me.Controls.Add(cmdClose)
		Me.Controls.Add(Calendar1)
		CType(Me.Calendar1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class