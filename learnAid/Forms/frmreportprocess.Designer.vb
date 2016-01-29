<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmreportprocess
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
	Public WithEvents Shape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents Picture1 As System.Windows.Forms.Panel
	Public WithEvents status1 As System.Windows.Forms.Label
	Public WithEvents status2 As System.Windows.Forms.Label
	Public WithEvents status3 As System.Windows.Forms.Label
	Public WithEvents status4 As System.Windows.Forms.Label
	Public WithEvents status5 As System.Windows.Forms.Label
	Public WithEvents status6 As System.Windows.Forms.Label
	Public WithEvents chk1 As System.Windows.Forms.Label
	Public WithEvents chk2 As System.Windows.Forms.Label
	Public WithEvents chk3 As System.Windows.Forms.Label
	Public WithEvents chk4 As System.Windows.Forms.Label
	Public WithEvents chk5 As System.Windows.Forms.Label
	Public WithEvents chk6 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.Panel
	Public WithEvents lblStatus As System.Windows.Forms.Label
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmreportprocess))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.Picture1 = New System.Windows.Forms.Panel
		Me.Shape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.Frame1 = New System.Windows.Forms.Panel
		Me.status1 = New System.Windows.Forms.Label
		Me.status2 = New System.Windows.Forms.Label
		Me.status3 = New System.Windows.Forms.Label
		Me.status4 = New System.Windows.Forms.Label
		Me.status5 = New System.Windows.Forms.Label
		Me.status6 = New System.Windows.Forms.Label
		Me.chk1 = New System.Windows.Forms.Label
		Me.chk2 = New System.Windows.Forms.Label
		Me.chk3 = New System.Windows.Forms.Label
		Me.chk4 = New System.Windows.Forms.Label
		Me.chk5 = New System.Windows.Forms.Label
		Me.chk6 = New System.Windows.Forms.Label
		Me.lblStatus = New System.Windows.Forms.Label
		Me.Picture1.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Generating Consultant Report"
		Me.ClientSize = New System.Drawing.Size(321, 74)
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
		Me.Name = "frmreportprocess"
		Me.Picture1.BackColor = System.Drawing.Color.FromARGB(128, 128, 128)
		Me.Picture1.Size = New System.Drawing.Size(289, 20)
		Me.Picture1.Location = New System.Drawing.Point(16, 40)
		Me.Picture1.TabIndex = 14
		Me.Picture1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture1.Dock = System.Windows.Forms.DockStyle.None
		Me.Picture1.CausesValidation = True
		Me.Picture1.Enabled = True
		Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Picture1.TabStop = True
		Me.Picture1.Visible = True
		Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Picture1.Name = "Picture1"
		Me.Shape1.BackColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.Shape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
		Me.Shape1.BorderColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.Shape1.Size = New System.Drawing.Size(286, 17)
		Me.Shape1.Location = New System.Drawing.Point(0, 0)
		Me.Shape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape1.BorderWidth = 1
		Me.Shape1.FillColor = System.Drawing.Color.Black
		Me.Shape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape1.Visible = True
		Me.Shape1.Name = "Shape1"
		Me.Frame1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Frame1.Size = New System.Drawing.Size(233, 161)
		Me.Frame1.Location = New System.Drawing.Point(184, 168)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Visible = False
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Name = "Frame1"
		Me.status1.Text = "Verifying batteries for examiners"
		Me.status1.Size = New System.Drawing.Size(233, 17)
		Me.status1.Location = New System.Drawing.Point(40, 16)
		Me.status1.TabIndex = 12
		Me.status1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.status1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.status1.BackColor = System.Drawing.SystemColors.Control
		Me.status1.Enabled = True
		Me.status1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.status1.Cursor = System.Windows.Forms.Cursors.Default
		Me.status1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.status1.UseMnemonic = True
		Me.status1.Visible = True
		Me.status1.AutoSize = False
		Me.status1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.status1.Name = "status1"
		Me.status2.Text = "Verifying batteries for assistants"
		Me.status2.Size = New System.Drawing.Size(233, 17)
		Me.status2.Location = New System.Drawing.Point(40, 40)
		Me.status2.TabIndex = 11
		Me.status2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.status2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.status2.BackColor = System.Drawing.SystemColors.Control
		Me.status2.Enabled = True
		Me.status2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.status2.Cursor = System.Windows.Forms.Cursors.Default
		Me.status2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.status2.UseMnemonic = True
		Me.status2.Visible = True
		Me.status2.AutoSize = False
		Me.status2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.status2.Name = "status2"
		Me.status3.Text = "Verifying examiners in charge"
		Me.status3.Size = New System.Drawing.Size(225, 17)
		Me.status3.Location = New System.Drawing.Point(40, 64)
		Me.status3.TabIndex = 10
		Me.status3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.status3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.status3.BackColor = System.Drawing.SystemColors.Control
		Me.status3.Enabled = True
		Me.status3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.status3.Cursor = System.Windows.Forms.Cursors.Default
		Me.status3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.status3.UseMnemonic = True
		Me.status3.Visible = True
		Me.status3.AutoSize = False
		Me.status3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.status3.Name = "status3"
		Me.status4.Text = "Verifying toll payment for examiners"
		Me.status4.Size = New System.Drawing.Size(225, 17)
		Me.status4.Location = New System.Drawing.Point(40, 88)
		Me.status4.TabIndex = 9
		Me.status4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.status4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.status4.BackColor = System.Drawing.SystemColors.Control
		Me.status4.Enabled = True
		Me.status4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.status4.Cursor = System.Windows.Forms.Cursors.Default
		Me.status4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.status4.UseMnemonic = True
		Me.status4.Visible = True
		Me.status4.AutoSize = False
		Me.status4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.status4.Name = "status4"
		Me.status5.Text = "Verifying toll payment for assistants"
		Me.status5.Size = New System.Drawing.Size(225, 17)
		Me.status5.Location = New System.Drawing.Point(40, 112)
		Me.status5.TabIndex = 8
		Me.status5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.status5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.status5.BackColor = System.Drawing.SystemColors.Control
		Me.status5.Enabled = True
		Me.status5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.status5.Cursor = System.Windows.Forms.Cursors.Default
		Me.status5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.status5.UseMnemonic = True
		Me.status5.Visible = True
		Me.status5.AutoSize = False
		Me.status5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.status5.Name = "status5"
		Me.status6.Text = "Verifying corrections"
		Me.status6.Size = New System.Drawing.Size(225, 17)
		Me.status6.Location = New System.Drawing.Point(40, 136)
		Me.status6.TabIndex = 7
		Me.status6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.status6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.status6.BackColor = System.Drawing.SystemColors.Control
		Me.status6.Enabled = True
		Me.status6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.status6.Cursor = System.Windows.Forms.Cursors.Default
		Me.status6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.status6.UseMnemonic = True
		Me.status6.Visible = True
		Me.status6.AutoSize = False
		Me.status6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.status6.Name = "status6"
		Me.chk1.Text = "Ö"
		Me.chk1.Font = New System.Drawing.Font("Symbol", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.chk1.Size = New System.Drawing.Size(17, 17)
		Me.chk1.Location = New System.Drawing.Point(16, 16)
		Me.chk1.TabIndex = 6
		Me.chk1.Visible = False
		Me.chk1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.chk1.BackColor = System.Drawing.SystemColors.Control
		Me.chk1.Enabled = True
		Me.chk1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chk1.Cursor = System.Windows.Forms.Cursors.Default
		Me.chk1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chk1.UseMnemonic = True
		Me.chk1.AutoSize = False
		Me.chk1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.chk1.Name = "chk1"
		Me.chk2.Text = "Ö"
		Me.chk2.Font = New System.Drawing.Font("Symbol", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.chk2.Size = New System.Drawing.Size(17, 17)
		Me.chk2.Location = New System.Drawing.Point(16, 40)
		Me.chk2.TabIndex = 5
		Me.chk2.Visible = False
		Me.chk2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.chk2.BackColor = System.Drawing.SystemColors.Control
		Me.chk2.Enabled = True
		Me.chk2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chk2.Cursor = System.Windows.Forms.Cursors.Default
		Me.chk2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chk2.UseMnemonic = True
		Me.chk2.AutoSize = False
		Me.chk2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.chk2.Name = "chk2"
		Me.chk3.Text = "Ö"
		Me.chk3.Font = New System.Drawing.Font("Symbol", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.chk3.Size = New System.Drawing.Size(17, 17)
		Me.chk3.Location = New System.Drawing.Point(16, 64)
		Me.chk3.TabIndex = 4
		Me.chk3.Visible = False
		Me.chk3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.chk3.BackColor = System.Drawing.SystemColors.Control
		Me.chk3.Enabled = True
		Me.chk3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chk3.Cursor = System.Windows.Forms.Cursors.Default
		Me.chk3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chk3.UseMnemonic = True
		Me.chk3.AutoSize = False
		Me.chk3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.chk3.Name = "chk3"
		Me.chk4.Text = "Ö"
		Me.chk4.Font = New System.Drawing.Font("Symbol", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.chk4.Size = New System.Drawing.Size(17, 17)
		Me.chk4.Location = New System.Drawing.Point(16, 88)
		Me.chk4.TabIndex = 3
		Me.chk4.Visible = False
		Me.chk4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.chk4.BackColor = System.Drawing.SystemColors.Control
		Me.chk4.Enabled = True
		Me.chk4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chk4.Cursor = System.Windows.Forms.Cursors.Default
		Me.chk4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chk4.UseMnemonic = True
		Me.chk4.AutoSize = False
		Me.chk4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.chk4.Name = "chk4"
		Me.chk5.Text = "Ö"
		Me.chk5.Font = New System.Drawing.Font("Symbol", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.chk5.Size = New System.Drawing.Size(17, 17)
		Me.chk5.Location = New System.Drawing.Point(16, 112)
		Me.chk5.TabIndex = 2
		Me.chk5.Visible = False
		Me.chk5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.chk5.BackColor = System.Drawing.SystemColors.Control
		Me.chk5.Enabled = True
		Me.chk5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chk5.Cursor = System.Windows.Forms.Cursors.Default
		Me.chk5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chk5.UseMnemonic = True
		Me.chk5.AutoSize = False
		Me.chk5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.chk5.Name = "chk5"
		Me.chk6.Text = "Ö"
		Me.chk6.Font = New System.Drawing.Font("Symbol", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.chk6.Size = New System.Drawing.Size(17, 17)
		Me.chk6.Location = New System.Drawing.Point(16, 136)
		Me.chk6.TabIndex = 1
		Me.chk6.Visible = False
		Me.chk6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.chk6.BackColor = System.Drawing.SystemColors.Control
		Me.chk6.Enabled = True
		Me.chk6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chk6.Cursor = System.Windows.Forms.Cursors.Default
		Me.chk6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chk6.UseMnemonic = True
		Me.chk6.AutoSize = False
		Me.chk6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.chk6.Name = "chk6"
		Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblStatus.Text = "Generating Consultant Report"
		Me.lblStatus.Size = New System.Drawing.Size(281, 25)
		Me.lblStatus.Location = New System.Drawing.Point(16, 16)
		Me.lblStatus.TabIndex = 13
		Me.lblStatus.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStatus.BackColor = System.Drawing.SystemColors.Control
		Me.lblStatus.Enabled = True
		Me.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblStatus.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblStatus.UseMnemonic = True
		Me.lblStatus.Visible = True
		Me.lblStatus.AutoSize = False
		Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblStatus.Name = "lblStatus"
		Me.Controls.Add(Picture1)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(lblStatus)
		Me.ShapeContainer1.Shapes.Add(Shape1)
		Me.Picture1.Controls.Add(ShapeContainer1)
		Me.Frame1.Controls.Add(status1)
		Me.Frame1.Controls.Add(status2)
		Me.Frame1.Controls.Add(status3)
		Me.Frame1.Controls.Add(status4)
		Me.Frame1.Controls.Add(status5)
		Me.Frame1.Controls.Add(status6)
		Me.Frame1.Controls.Add(chk1)
		Me.Frame1.Controls.Add(chk2)
		Me.Frame1.Controls.Add(chk3)
		Me.Frame1.Controls.Add(chk4)
		Me.Frame1.Controls.Add(chk5)
		Me.Frame1.Controls.Add(chk6)
		Me.Picture1.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class