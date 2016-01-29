<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAddOfficeStudent
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
	Public WithEvents cboBattery As System.Windows.Forms.ComboBox
	Public WithEvents cboMAT As System.Windows.Forms.ComboBox
	Public WithEvents cboNV As System.Windows.Forms.ComboBox
	Public WithEvents cboRen As System.Windows.Forms.ComboBox
	Public WithEvents cboLES As System.Windows.Forms.ComboBox
	Public WithEvents cboSemester As System.Windows.Forms.ComboBox
	Public WithEvents cboGrade As System.Windows.Forms.ComboBox
	Public WithEvents cboSchool As System.Windows.Forms.ComboBox
	Public WithEvents txtName As System.Windows.Forms.TextBox
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents cmdAdd As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents lblbattery As System.Windows.Forms.Label
	Public WithEvents lblMsg As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cboBattery = New System.Windows.Forms.ComboBox()
        Me.cboMAT = New System.Windows.Forms.ComboBox()
        Me.cboNV = New System.Windows.Forms.ComboBox()
        Me.cboRen = New System.Windows.Forms.ComboBox()
        Me.cboLES = New System.Windows.Forms.ComboBox()
        Me.cboSemester = New System.Windows.Forms.ComboBox()
        Me.cboGrade = New System.Windows.Forms.ComboBox()
        Me.cboSchool = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.lblbattery = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboBattery
        '
        Me.cboBattery.BackColor = System.Drawing.SystemColors.Window
        Me.cboBattery.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboBattery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBattery.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBattery.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboBattery.Location = New System.Drawing.Point(66, 126)
        Me.cboBattery.Name = "cboBattery"
        Me.cboBattery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboBattery.Size = New System.Drawing.Size(97, 24)
        Me.cboBattery.TabIndex = 20
        '
        'cboMAT
        '
        Me.cboMAT.BackColor = System.Drawing.SystemColors.Window
        Me.cboMAT.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboMAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMAT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMAT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMAT.Location = New System.Drawing.Point(380, 174)
        Me.cboMAT.Name = "cboMAT"
        Me.cboMAT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboMAT.Size = New System.Drawing.Size(73, 24)
        Me.cboMAT.TabIndex = 17
        '
        'cboNV
        '
        Me.cboNV.BackColor = System.Drawing.SystemColors.Window
        Me.cboNV.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNV.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboNV.Location = New System.Drawing.Point(380, 150)
        Me.cboNV.Name = "cboNV"
        Me.cboNV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboNV.Size = New System.Drawing.Size(73, 24)
        Me.cboNV.TabIndex = 15
        '
        'cboRen
        '
        Me.cboRen.BackColor = System.Drawing.SystemColors.Window
        Me.cboRen.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboRen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRen.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboRen.Location = New System.Drawing.Point(220, 174)
        Me.cboRen.Name = "cboRen"
        Me.cboRen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboRen.Size = New System.Drawing.Size(73, 24)
        Me.cboRen.TabIndex = 13
        '
        'cboLES
        '
        Me.cboLES.BackColor = System.Drawing.SystemColors.Window
        Me.cboLES.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboLES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLES.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLES.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboLES.Location = New System.Drawing.Point(220, 150)
        Me.cboLES.Name = "cboLES"
        Me.cboLES.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboLES.Size = New System.Drawing.Size(73, 24)
        Me.cboLES.TabIndex = 11
        '
        'cboSemester
        '
        Me.cboSemester.BackColor = System.Drawing.SystemColors.Window
        Me.cboSemester.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSemester.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSemester.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSemester.Location = New System.Drawing.Point(184, 96)
        Me.cboSemester.Name = "cboSemester"
        Me.cboSemester.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboSemester.Size = New System.Drawing.Size(153, 24)
        Me.cboSemester.TabIndex = 9
        '
        'cboGrade
        '
        Me.cboGrade.BackColor = System.Drawing.SystemColors.Window
        Me.cboGrade.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrade.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrade.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboGrade.Location = New System.Drawing.Point(8, 96)
        Me.cboGrade.Name = "cboGrade"
        Me.cboGrade.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboGrade.Size = New System.Drawing.Size(169, 24)
        Me.cboGrade.TabIndex = 7
        '
        'cboSchool
        '
        Me.cboSchool.BackColor = System.Drawing.SystemColors.Window
        Me.cboSchool.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSchool.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSchool.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSchool.Location = New System.Drawing.Point(184, 48)
        Me.cboSchool.Name = "cboSchool"
        Me.cboSchool.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboSchool.Size = New System.Drawing.Size(370, 24)
        Me.cboSchool.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.AcceptsReturn = True
        Me.txtName.BackColor = System.Drawing.SystemColors.Window
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtName.Location = New System.Drawing.Point(8, 48)
        Me.txtName.MaxLength = 0
        Me.txtName.Name = "txtName"
        Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtName.Size = New System.Drawing.Size(169, 23)
        Me.txtName.TabIndex = 3
        Me.txtName.Tag = "Validate Text -Required -AllowAccentuation -AllowLetters -AllowWhiteSpaces -MaxLe" & _
    "ngth 100 -RequiredMsg Name is a required field! -InvalidValueMsg Name field does" & _
    "n't allow digits."
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClose.Location = New System.Drawing.Point(376, 216)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(81, 25)
        Me.cmdClose.TabIndex = 1
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAdd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAdd.Location = New System.Drawing.Point(288, 216)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAdd.Size = New System.Drawing.Size(81, 25)
        Me.cmdAdd.TabIndex = 0
        Me.cmdAdd.Text = "&ADD"
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(-8, 200)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(481, 65)
        Me.Frame1.TabIndex = 19
        Me.Frame1.TabStop = False
        '
        'lblbattery
        '
        Me.lblbattery.AutoSize = True
        Me.lblbattery.BackColor = System.Drawing.SystemColors.Control
        Me.lblbattery.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblbattery.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbattery.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblbattery.Location = New System.Drawing.Point(8, 129)
        Me.lblbattery.Name = "lblbattery"
        Me.lblbattery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblbattery.Size = New System.Drawing.Size(57, 16)
        Me.lblbattery.TabIndex = 21
        Me.lblbattery.Text = "Battery:"
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.SystemColors.Control
        Me.lblMsg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMsg.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMsg.Location = New System.Drawing.Point(8, 0)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMsg.Size = New System.Drawing.Size(321, 25)
        Me.lblMsg.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(332, 174)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(49, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "MAT:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(332, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(49, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "NV:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(172, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "REN:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(172, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(49, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "LES:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(184, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Semester"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Grade"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(184, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "School"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'frmAddOfficeStudent
        '
        Me.AcceptButton = Me.cmdAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(569, 247)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboBattery)
        Me.Controls.Add(Me.cboMAT)
        Me.Controls.Add(Me.cboNV)
        Me.Controls.Add(Me.cboRen)
        Me.Controls.Add(Me.cboLES)
        Me.Controls.Add(Me.cboSemester)
        Me.Controls.Add(Me.cboGrade)
        Me.Controls.Add(Me.cboSchool)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.lblbattery)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(184, 250)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddOfficeStudent"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 
End Class