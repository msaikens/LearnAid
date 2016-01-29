<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPrintNomina
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
	Public WithEvents chkPreview As System.Windows.Forms.CheckBox
	Public WithEvents chkDetailed As System.Windows.Forms.CheckBox
	Public WithEvents chkSummary As System.Windows.Forms.CheckBox
	Public WithEvents CancelButton_Renamed As System.Windows.Forms.Button
	Public WithEvents OKButton As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkPreview = New System.Windows.Forms.CheckBox()
        Me.chkDetailed = New System.Windows.Forms.CheckBox()
        Me.chkSummary = New System.Windows.Forms.CheckBox()
        Me.CancelButton_Renamed = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'chkPreview
        '
        Me.chkPreview.BackColor = System.Drawing.SystemColors.Control
        Me.chkPreview.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkPreview.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPreview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkPreview.Location = New System.Drawing.Point(16, 88)
        Me.chkPreview.Name = "chkPreview"
        Me.chkPreview.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkPreview.Size = New System.Drawing.Size(99, 17)
        Me.chkPreview.TabIndex = 4
        Me.chkPreview.Text = "Preview"
        Me.chkPreview.UseVisualStyleBackColor = False
        '
        'chkDetailed
        '
        Me.chkDetailed.BackColor = System.Drawing.SystemColors.Control
        Me.chkDetailed.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDetailed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDetailed.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDetailed.Location = New System.Drawing.Point(56, 48)
        Me.chkDetailed.Name = "chkDetailed"
        Me.chkDetailed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDetailed.Size = New System.Drawing.Size(177, 17)
        Me.chkDetailed.TabIndex = 3
        Me.chkDetailed.Text = "Print Detailed Report"
        Me.chkDetailed.UseVisualStyleBackColor = False
        '
        'chkSummary
        '
        Me.chkSummary.BackColor = System.Drawing.SystemColors.Control
        Me.chkSummary.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSummary.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSummary.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSummary.Location = New System.Drawing.Point(56, 16)
        Me.chkSummary.Name = "chkSummary"
        Me.chkSummary.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSummary.Size = New System.Drawing.Size(177, 17)
        Me.chkSummary.TabIndex = 2
        Me.chkSummary.Text = "Print Summary"
        Me.chkSummary.UseVisualStyleBackColor = False
        '
        'CancelButton_Renamed
        '
        Me.CancelButton_Renamed.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton_Renamed.Cursor = System.Windows.Forms.Cursors.Default
        Me.CancelButton_Renamed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton_Renamed.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CancelButton_Renamed.Location = New System.Drawing.Point(160, 120)
        Me.CancelButton_Renamed.Name = "CancelButton_Renamed"
        Me.CancelButton_Renamed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CancelButton_Renamed.Size = New System.Drawing.Size(81, 25)
        Me.CancelButton_Renamed.TabIndex = 1
        Me.CancelButton_Renamed.Text = "Cancel"
        Me.CancelButton_Renamed.UseVisualStyleBackColor = False
        '
        'OKButton
        '
        Me.OKButton.BackColor = System.Drawing.SystemColors.Control
        Me.OKButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.OKButton.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OKButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OKButton.Location = New System.Drawing.Point(72, 120)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OKButton.Size = New System.Drawing.Size(81, 25)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "Print"
        Me.OKButton.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(233, 81)
        Me.Frame1.TabIndex = 5
        Me.Frame1.TabStop = False
        '
        'frmPrintNomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(249, 149)
        Me.Controls.Add(Me.chkPreview)
        Me.Controls.Add(Me.chkDetailed)
        Me.Controls.Add(Me.chkSummary)
        Me.Controls.Add(Me.CancelButton_Renamed)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(184, 250)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrintNomina"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print "
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class