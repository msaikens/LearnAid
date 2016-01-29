Namespace Forms.UserLoginForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmNewUser
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
        Public WithEvents cboConsultant As System.Windows.Forms.ComboBox
        Public WithEvents cboUserType As System.Windows.Forms.ComboBox
        Public WithEvents Command1 As System.Windows.Forms.Button
        Public WithEvents txtConfirmation As System.Windows.Forms.TextBox
        Public WithEvents txtUserName As System.Windows.Forms.TextBox
        Public WithEvents cmdOK As System.Windows.Forms.Button
        Public WithEvents txtPassword As System.Windows.Forms.TextBox
        Public WithEvents _lblLabels_3 As System.Windows.Forms.Label
        Public WithEvents Label1 As System.Windows.Forms.Label
        Public WithEvents _lblLabels_2 As System.Windows.Forms.Label
        Public WithEvents _lblLabels_0 As System.Windows.Forms.Label
        Public WithEvents _lblLabels_1 As System.Windows.Forms.Label
        Public WithEvents lblLabels As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmNewUser))
            Me.components = New System.ComponentModel.Container()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
            Me.cboConsultant = New System.Windows.Forms.ComboBox
            Me.cboUserType = New System.Windows.Forms.ComboBox
            Me.Command1 = New System.Windows.Forms.Button
            Me.txtConfirmation = New System.Windows.Forms.TextBox
            Me.txtUserName = New System.Windows.Forms.TextBox
            Me.cmdOK = New System.Windows.Forms.Button
            Me.txtPassword = New System.Windows.Forms.TextBox
            Me._lblLabels_3 = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me._lblLabels_2 = New System.Windows.Forms.Label
            Me._lblLabels_0 = New System.Windows.Forms.Label
            Me._lblLabels_1 = New System.Windows.Forms.Label
            Me.lblLabels = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
            Me.SuspendLayout()
            Me.ToolTip1.Active = True
            CType(Me.lblLabels, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Text = "New User"
            Me.ClientSize = New System.Drawing.Size(257, 202)
            Me.Location = New System.Drawing.Point(189, 232)
            Me.ControlBox = False
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.Enabled = True
            Me.KeyPreview = False
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.HelpButton = False
            Me.WindowState = System.Windows.Forms.FormWindowState.Normal
            Me.Name = "frmNewUser"
            Me.cboConsultant.Size = New System.Drawing.Size(153, 21)
            Me.cboConsultant.Location = New System.Drawing.Point(88, 72)
            Me.cboConsultant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboConsultant.TabIndex = 2
            Me.cboConsultant.Tag = "Validate Text -Required -RequiredMsg User type is a required field!"
            Me.cboConsultant.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboConsultant.BackColor = System.Drawing.SystemColors.Window
            Me.cboConsultant.CausesValidation = True
            Me.cboConsultant.Enabled = True
            Me.cboConsultant.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboConsultant.IntegralHeight = True
            Me.cboConsultant.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboConsultant.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboConsultant.Sorted = False
            Me.cboConsultant.TabStop = True
            Me.cboConsultant.Visible = True
            Me.cboConsultant.Name = "cboConsultant"
            Me.cboUserType.Size = New System.Drawing.Size(153, 21)
            Me.cboUserType.Location = New System.Drawing.Point(88, 40)
            Me.cboUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboUserType.TabIndex = 1
            Me.cboUserType.Tag = "Validate Text -Required -RequiredMsg User type is a required field!"
            Me.cboUserType.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboUserType.BackColor = System.Drawing.SystemColors.Window
            Me.cboUserType.CausesValidation = True
            Me.cboUserType.Enabled = True
            Me.cboUserType.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboUserType.IntegralHeight = True
            Me.cboUserType.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboUserType.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboUserType.Sorted = False
            Me.cboUserType.TabStop = True
            Me.cboUserType.Visible = True
            Me.cboUserType.Name = "cboUserType"
            Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.CancelButton = Me.Command1
            Me.Command1.Text = "Cancel"
            Me.Command1.Size = New System.Drawing.Size(76, 26)
            Me.Command1.Location = New System.Drawing.Point(168, 168)
            Me.Command1.TabIndex = 6
            Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Command1.BackColor = System.Drawing.SystemColors.Control
            Me.Command1.CausesValidation = True
            Me.Command1.Enabled = True
            Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
            Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Command1.TabStop = True
            Me.Command1.Name = "Command1"
            Me.txtConfirmation.AutoSize = False
            Me.txtConfirmation.Size = New System.Drawing.Size(155, 23)
            Me.txtConfirmation.IMEMode = System.Windows.Forms.ImeMode.Disable
            Me.txtConfirmation.Location = New System.Drawing.Point(87, 128)
            Me.txtConfirmation.PasswordChar = ChrW(42)
            Me.txtConfirmation.TabIndex = 4
            Me.txtConfirmation.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtConfirmation.AcceptsReturn = True
            Me.txtConfirmation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.txtConfirmation.BackColor = System.Drawing.SystemColors.Window
            Me.txtConfirmation.CausesValidation = True
            Me.txtConfirmation.Enabled = True
            Me.txtConfirmation.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtConfirmation.HideSelection = True
            Me.txtConfirmation.ReadOnly = False
            Me.txtConfirmation.Maxlength = 0
            Me.txtConfirmation.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtConfirmation.MultiLine = False
            Me.txtConfirmation.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtConfirmation.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.txtConfirmation.TabStop = True
            Me.txtConfirmation.Visible = True
            Me.txtConfirmation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.txtConfirmation.Name = "txtConfirmation"
            Me.txtUserName.AutoSize = False
            Me.txtUserName.Size = New System.Drawing.Size(155, 23)
            Me.txtUserName.Location = New System.Drawing.Point(86, 9)
            Me.txtUserName.TabIndex = 0
            Me.txtUserName.Tag = "Validate Text -Required -AllowLetters -AllowDigits -RequiredMsg User name is a required field! -InvalidValueMsg User name field doesn't allow whitespaces, accentuation or special characters."
            Me.txtUserName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUserName.AcceptsReturn = True
            Me.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.txtUserName.BackColor = System.Drawing.SystemColors.Window
            Me.txtUserName.CausesValidation = True
            Me.txtUserName.Enabled = True
            Me.txtUserName.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtUserName.HideSelection = True
            Me.txtUserName.ReadOnly = False
            Me.txtUserName.Maxlength = 0
            Me.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtUserName.MultiLine = False
            Me.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.txtUserName.TabStop = True
            Me.txtUserName.Visible = True
            Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.txtUserName.Name = "txtUserName"
            Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.cmdOK.Text = "OK"
            Me.AcceptButton = Me.cmdOK
            Me.cmdOK.Size = New System.Drawing.Size(76, 26)
            Me.cmdOK.Location = New System.Drawing.Point(80, 168)
            Me.cmdOK.TabIndex = 5
            Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
            Me.cmdOK.CausesValidation = True
            Me.cmdOK.Enabled = True
            Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdOK.TabStop = True
            Me.cmdOK.Name = "cmdOK"
            Me.txtPassword.AutoSize = False
            Me.txtPassword.Size = New System.Drawing.Size(155, 23)
            Me.txtPassword.IMEMode = System.Windows.Forms.ImeMode.Disable
            Me.txtPassword.Location = New System.Drawing.Point(88, 99)
            Me.txtPassword.PasswordChar = ChrW(42)
            Me.txtPassword.TabIndex = 3
            Me.txtPassword.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPassword.AcceptsReturn = True
            Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
            Me.txtPassword.CausesValidation = True
            Me.txtPassword.Enabled = True
            Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtPassword.HideSelection = True
            Me.txtPassword.ReadOnly = False
            Me.txtPassword.Maxlength = 0
            Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtPassword.MultiLine = False
            Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.txtPassword.TabStop = True
            Me.txtPassword.Visible = True
            Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.txtPassword.Name = "txtPassword"
            Me._lblLabels_3.TextAlign = System.Drawing.ContentAlignment.TopRight
            Me._lblLabels_3.Text = "Consultant"
            Me._lblLabels_3.Size = New System.Drawing.Size(72, 18)
            Me._lblLabels_3.Location = New System.Drawing.Point(8, 73)
            Me._lblLabels_3.TabIndex = 11
            Me._lblLabels_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._lblLabels_3.BackColor = System.Drawing.SystemColors.Control
            Me._lblLabels_3.Enabled = True
            Me._lblLabels_3.ForeColor = System.Drawing.SystemColors.ControlText
            Me._lblLabels_3.Cursor = System.Windows.Forms.Cursors.Default
            Me._lblLabels_3.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me._lblLabels_3.UseMnemonic = True
            Me._lblLabels_3.Visible = True
            Me._lblLabels_3.AutoSize = False
            Me._lblLabels_3.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me._lblLabels_3.Name = "_lblLabels_3"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
            Me.Label1.Text = "User Type"
            Me.Label1.Size = New System.Drawing.Size(73, 25)
            Me.Label1.Location = New System.Drawing.Point(8, 40)
            Me.Label1.TabIndex = 10
            Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
            Me._lblLabels_2.TextAlign = System.Drawing.ContentAlignment.TopRight
            Me._lblLabels_2.Text = "&Confirmation:"
            Me._lblLabels_2.Size = New System.Drawing.Size(72, 18)
            Me._lblLabels_2.Location = New System.Drawing.Point(8, 128)
            Me._lblLabels_2.TabIndex = 9
            Me._lblLabels_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._lblLabels_2.BackColor = System.Drawing.SystemColors.Control
            Me._lblLabels_2.Enabled = True
            Me._lblLabels_2.ForeColor = System.Drawing.SystemColors.ControlText
            Me._lblLabels_2.Cursor = System.Windows.Forms.Cursors.Default
            Me._lblLabels_2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me._lblLabels_2.UseMnemonic = True
            Me._lblLabels_2.Visible = True
            Me._lblLabels_2.AutoSize = False
            Me._lblLabels_2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me._lblLabels_2.Name = "_lblLabels_2"
            Me._lblLabels_0.TextAlign = System.Drawing.ContentAlignment.TopRight
            Me._lblLabels_0.Text = "&User Name:"
            Me._lblLabels_0.Size = New System.Drawing.Size(72, 18)
            Me._lblLabels_0.Location = New System.Drawing.Point(7, 10)
            Me._lblLabels_0.TabIndex = 7
            Me._lblLabels_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._lblLabels_0.BackColor = System.Drawing.SystemColors.Control
            Me._lblLabels_0.Enabled = True
            Me._lblLabels_0.ForeColor = System.Drawing.SystemColors.ControlText
            Me._lblLabels_0.Cursor = System.Windows.Forms.Cursors.Default
            Me._lblLabels_0.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me._lblLabels_0.UseMnemonic = True
            Me._lblLabels_0.Visible = True
            Me._lblLabels_0.AutoSize = False
            Me._lblLabels_0.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me._lblLabels_0.Name = "_lblLabels_0"
            Me._lblLabels_1.TextAlign = System.Drawing.ContentAlignment.TopRight
            Me._lblLabels_1.Text = "&Password:"
            Me._lblLabels_1.Size = New System.Drawing.Size(72, 18)
            Me._lblLabels_1.Location = New System.Drawing.Point(7, 100)
            Me._lblLabels_1.TabIndex = 8
            Me._lblLabels_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._lblLabels_1.BackColor = System.Drawing.SystemColors.Control
            Me._lblLabels_1.Enabled = True
            Me._lblLabels_1.ForeColor = System.Drawing.SystemColors.ControlText
            Me._lblLabels_1.Cursor = System.Windows.Forms.Cursors.Default
            Me._lblLabels_1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me._lblLabels_1.UseMnemonic = True
            Me._lblLabels_1.Visible = True
            Me._lblLabels_1.AutoSize = False
            Me._lblLabels_1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me._lblLabels_1.Name = "_lblLabels_1"
            Me.Controls.Add(cboConsultant)
            Me.Controls.Add(cboUserType)
            Me.Controls.Add(Command1)
            Me.Controls.Add(txtConfirmation)
            Me.Controls.Add(txtUserName)
            Me.Controls.Add(cmdOK)
            Me.Controls.Add(txtPassword)
            Me.Controls.Add(_lblLabels_3)
            Me.Controls.Add(Label1)
            Me.Controls.Add(_lblLabels_2)
            Me.Controls.Add(_lblLabels_0)
            Me.Controls.Add(_lblLabels_1)
            Me.lblLabels.SetIndex(_lblLabels_3, CType(3, Short))
            Me.lblLabels.SetIndex(_lblLabels_2, CType(2, Short))
            Me.lblLabels.SetIndex(_lblLabels_0, CType(0, Short))
            Me.lblLabels.SetIndex(_lblLabels_1, CType(1, Short))
            CType(Me.lblLabels, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub
#End Region
    End Class
End Namespace