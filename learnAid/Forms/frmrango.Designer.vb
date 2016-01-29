<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRango
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
	Public WithEvents cmdCreateDataReport As System.Windows.Forms.Button
	Public WithEvents cmdMoveBack As System.Windows.Forms.Button
	Public WithEvents cmdAdd As System.Windows.Forms.Button
	Public WithEvents lstProcess As System.Windows.Forms.ListBox
	Public WithEvents txtMaxStudents As System.Windows.Forms.TextBox
	Public WithEvents cboPromedio As System.Windows.Forms.ComboBox
	Public WithEvents txtMinStudents As System.Windows.Forms.TextBox
	Public WithEvents cboYear As System.Windows.Forms.ComboBox
	Public WithEvents cboTest As System.Windows.Forms.ComboBox
	Public WithEvents lblStatus As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cmdCreateExcel As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdCreateDataReport = New System.Windows.Forms.Button()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.cmdMoveBack = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.lstProcess = New System.Windows.Forms.ListBox()
        Me.txtMaxStudents = New System.Windows.Forms.TextBox()
        Me.cboPromedio = New System.Windows.Forms.ComboBox()
        Me.txtMinStudents = New System.Windows.Forms.TextBox()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.cboTest = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCreateExcel = New System.Windows.Forms.Button()
        Me.Frame2.SuspendLayout
        Me.SuspendLayout
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClose.Location = New System.Drawing.Point(401, 185)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(60, 28)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = false
        '
        'cmdCreateDataReport
        '
        Me.cmdCreateDataReport.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCreateDataReport.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCreateDataReport.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdCreateDataReport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCreateDataReport.Location = New System.Drawing.Point(280, 185)
        Me.cmdCreateDataReport.Name = "cmdCreateDataReport"
        Me.cmdCreateDataReport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCreateDataReport.Size = New System.Drawing.Size(123, 28)
        Me.cmdCreateDataReport.TabIndex = 13
        Me.cmdCreateDataReport.Text = "Create Data Report"
        Me.cmdCreateDataReport.UseVisualStyleBackColor = false
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.cmdMoveBack)
        Me.Frame2.Controls.Add(Me.cmdAdd)
        Me.Frame2.Controls.Add(Me.lstProcess)
        Me.Frame2.Controls.Add(Me.txtMaxStudents)
        Me.Frame2.Controls.Add(Me.cboPromedio)
        Me.Frame2.Controls.Add(Me.txtMinStudents)
        Me.Frame2.Controls.Add(Me.cboYear)
        Me.Frame2.Controls.Add(Me.cboTest)
        Me.Frame2.Controls.Add(Me.lblStatus)
        Me.Frame2.Controls.Add(Me.Label6)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Controls.Add(Me.Label5)
        Me.Frame2.Controls.Add(Me.Label4)
        Me.Frame2.Controls.Add(Me.Label3)
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(0, 3)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(461, 177)
        Me.Frame2.TabIndex = 1
        Me.Frame2.TabStop = false
        Me.Frame2.Text = "Select Parameters"
        '
        'cmdMoveBack
        '
        Me.cmdMoveBack.BackColor = System.Drawing.SystemColors.Control
        Me.cmdMoveBack.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdMoveBack.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdMoveBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdMoveBack.Location = New System.Drawing.Point(355, 155)
        Me.cmdMoveBack.Name = "cmdMoveBack"
        Me.cmdMoveBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdMoveBack.Size = New System.Drawing.Size(31, 21)
        Me.cmdMoveBack.TabIndex = 17
        Me.cmdMoveBack.Text = "<<"
        Me.cmdMoveBack.UseVisualStyleBackColor = false
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAdd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAdd.Location = New System.Drawing.Point(290, 130)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAdd.Size = New System.Drawing.Size(61, 26)
        Me.cmdAdd.TabIndex = 16
        Me.cmdAdd.Text = "Add >>"
        Me.cmdAdd.UseVisualStyleBackColor = false
        '
        'lstProcess
        '
        Me.lstProcess.BackColor = System.Drawing.SystemColors.Window
        Me.lstProcess.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstProcess.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lstProcess.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstProcess.ItemHeight = 14
        Me.lstProcess.Location = New System.Drawing.Point(355, 35)
        Me.lstProcess.Name = "lstProcess"
        Me.lstProcess.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstProcess.Size = New System.Drawing.Size(101, 116)
        Me.lstProcess.TabIndex = 14
        '
        'txtMaxStudents
        '
        Me.txtMaxStudents.AcceptsReturn = true
        Me.txtMaxStudents.BackColor = System.Drawing.SystemColors.Window
        Me.txtMaxStudents.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMaxStudents.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMaxStudents.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMaxStudents.Location = New System.Drawing.Point(255, 99)
        Me.txtMaxStudents.MaxLength = 0
        Me.txtMaxStudents.Name = "txtMaxStudents"
        Me.txtMaxStudents.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMaxStudents.Size = New System.Drawing.Size(31, 20)
        Me.txtMaxStudents.TabIndex = 11
        Me.txtMaxStudents.Text = "9999"
        '
        'cboPromedio
        '
        Me.cboPromedio.BackColor = System.Drawing.SystemColors.Window
        Me.cboPromedio.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboPromedio.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboPromedio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboPromedio.Location = New System.Drawing.Point(135, 123)
        Me.cboPromedio.Name = "cboPromedio"
        Me.cboPromedio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboPromedio.Size = New System.Drawing.Size(118, 22)
        Me.cboPromedio.TabIndex = 10
        '
        'txtMinStudents
        '
        Me.txtMinStudents.AcceptsReturn = true
        Me.txtMinStudents.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinStudents.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinStudents.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMinStudents.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMinStudents.Location = New System.Drawing.Point(138, 96)
        Me.txtMinStudents.MaxLength = 0
        Me.txtMinStudents.Name = "txtMinStudents"
        Me.txtMinStudents.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinStudents.Size = New System.Drawing.Size(31, 20)
        Me.txtMinStudents.TabIndex = 8
        Me.txtMinStudents.Text = "10"
        '
        'cboYear
        '
        Me.cboYear.BackColor = System.Drawing.SystemColors.Window
        Me.cboYear.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboYear.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboYear.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboYear.Location = New System.Drawing.Point(138, 66)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboYear.Size = New System.Drawing.Size(121, 22)
        Me.cboYear.TabIndex = 4
        '
        'cboTest
        '
        Me.cboTest.BackColor = System.Drawing.SystemColors.Window
        Me.cboTest.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTest.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboTest.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTest.Location = New System.Drawing.Point(138, 39)
        Me.cboTest.Name = "cboTest"
        Me.cboTest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTest.Size = New System.Drawing.Size(121, 22)
        Me.cboTest.TabIndex = 3
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.SystemColors.Control
        Me.lblStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStatus.Location = New System.Drawing.Point(145, 150)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStatus.Size = New System.Drawing.Size(141, 16)
        Me.lblStatus.TabIndex = 18
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(355, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(91, 21)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Test to process:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(183, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Max Students:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(66, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Average:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(66, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Min. Students:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(66, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(79, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Year:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(66, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Test:"
        '
        'cmdCreateExcel
        '
        Me.cmdCreateExcel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCreateExcel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCreateExcel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdCreateExcel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCreateExcel.Location = New System.Drawing.Point(0, 185)
        Me.cmdCreateExcel.Name = "cmdCreateExcel"
        Me.cmdCreateExcel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCreateExcel.Size = New System.Drawing.Size(104, 28)
        Me.cmdCreateExcel.TabIndex = 0
        Me.cmdCreateExcel.Text = "Create Excel Report"
        Me.cmdCreateExcel.UseVisualStyleBackColor = false
        '
        'frmRango
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 14!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(469, 218)
        Me.ControlBox = false
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdCreateDataReport)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.cmdCreateExcel)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmRango"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "School Range Rep"
        Me.Frame2.ResumeLayout(false)
        Me.Frame2.PerformLayout
        Me.ResumeLayout(false)

End Sub
#End Region 
End Class