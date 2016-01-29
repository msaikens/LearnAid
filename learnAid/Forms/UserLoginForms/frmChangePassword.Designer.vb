Namespace Forms.UserLoginForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmChangePassword
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
        Public WithEvents txtOLD As System.Windows.Forms.TextBox
        Public WithEvents txtConfirmation As System.Windows.Forms.TextBox
        Public WithEvents txtUserName As System.Windows.Forms.TextBox
        Public WithEvents cmdOK As System.Windows.Forms.Button
        Public WithEvents cmdCancel As System.Windows.Forms.Button
        Public WithEvents txtNew As System.Windows.Forms.TextBox
        Public WithEvents _lblLabels_3 As System.Windows.Forms.Label
        Public WithEvents _lblLabels_2 As System.Windows.Forms.Label
        Public WithEvents _lblLabels_0 As System.Windows.Forms.Label
        Public WithEvents _lblLabels_1 As System.Windows.Forms.Label
        Public WithEvents lblLabels As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmChangePassword))
            Me.components = New System.ComponentModel.Container()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
            Me.txtOLD = New System.Windows.Forms.TextBox
            Me.txtConfirmation = New System.Windows.Forms.TextBox
            Me.txtUserName = New System.Windows.Forms.TextBox
            Me.cmdOK = New System.Windows.Forms.Button
            Me.cmdCancel = New System.Windows.Forms.Button
            Me.txtNew = New System.Windows.Forms.TextBox
            Me._lblLabels_3 = New System.Windows.Forms.Label
            Me._lblLabels_2 = New System.Windows.Forms.Label
            Me._lblLabels_0 = New System.Windows.Forms.Label
            Me._lblLabels_1 = New System.Windows.Forms.Label
            Me.lblLabels = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
            Me.SuspendLayout()
            Me.ToolTip1.Active = True
            CType(Me.lblLabels, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Text = "Change  Password"
            Me.ClientSize = New System.Drawing.Size(255, 168)
            Me.Location = New System.Drawing.Point(189, 232)
            Me.ControlBox = False
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.Enabled = True
            Me.KeyPreview = False
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.HelpButton = False
            Me.WindowState = System.Windows.Forms.FormWindowState.Normal
            Me.Name = "frmChangePassword"
            Me.txtOLD.AutoSize = False
            Me.txtOLD.Size = New System.Drawing.Size(155, 23)
            Me.txtOLD.IMEMode = System.Windows.Forms.ImeMode.Disable
            Me.txtOLD.Location = New System.Drawing.Point(87, 40)
            Me.txtOLD.PasswordChar = ChrW(42)
            Me.txtOLD.TabIndex = 1
            Me.txtOLD.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOLD.AcceptsReturn = True
            Me.txtOLD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.txtOLD.BackColor = System.Drawing.SystemColors.Window
            Me.txtOLD.CausesValidation = True
            Me.txtOLD.Enabled = True
            Me.txtOLD.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtOLD.HideSelection = True
            Me.txtOLD.ReadOnly = False
            Me.txtOLD.Maxlength = 0
            Me.txtOLD.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtOLD.MultiLine = False
            Me.txtOLD.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtOLD.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.txtOLD.TabStop = True
            Me.txtOLD.Visible = True
            Me.txtOLD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.txtOLD.Name = "txtOLD"
            Me.txtConfirmation.AutoSize = False
            Me.txtConfirmation.Size = New System.Drawing.Size(155, 23)
            Me.txtConfirmation.IMEMode = System.Windows.Forms.ImeMode.Disable
            Me.txtConfirmation.Location = New System.Drawing.Point(87, 96)
            Me.txtConfirmation.PasswordChar = ChrW(42)
            Me.txtConfirmation.TabIndex = 3
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
            Me.txtUserName.Enabled = False
            Me.txtUserName.Size = New System.Drawing.Size(155, 23)
            Me.txtUserName.Location = New System.Drawing.Point(86, 9)
            Me.txtUserName.TabIndex = 0
            Me.txtUserName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUserName.AcceptsReturn = True
            Me.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.txtUserName.BackColor = System.Drawing.SystemColors.Window
            Me.txtUserName.CausesValidation = True
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
            Me.cmdOK.Location = New System.Drawing.Point(88, 132)
            Me.cmdOK.TabIndex = 4
            Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
            Me.cmdOK.CausesValidation = True
            Me.cmdOK.Enabled = True
            Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdOK.TabStop = True
            Me.cmdOK.Name = "cmdOK"
            Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.CancelButton = Me.cmdCancel
            Me.cmdCancel.Text = "Cancel"
            Me.cmdCancel.Size = New System.Drawing.Size(76, 26)
            Me.cmdCancel.Location = New System.Drawing.Point(172, 132)
            Me.cmdCancel.TabIndex = 5
            Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
            Me.cmdCancel.CausesValidation = True
            Me.cmdCancel.Enabled = True
            Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdCancel.TabStop = True
            Me.cmdCancel.Name = "cmdCancel"
            Me.txtNew.AutoSize = False
            Me.txtNew.Size = New System.Drawing.Size(155, 23)
            Me.txtNew.IMEMode = System.Windows.Forms.ImeMode.Disable
            Me.txtNew.Location = New System.Drawing.Point(86, 67)
            Me.txtNew.PasswordChar = ChrW(42)
            Me.txtNew.TabIndex = 2
            Me.txtNew.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNew.AcceptsReturn = True
            Me.txtNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.txtNew.BackColor = System.Drawing.SystemColors.Window
            Me.txtNew.CausesValidation = True
            Me.txtNew.Enabled = True
            Me.txtNew.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtNew.HideSelection = True
            Me.txtNew.ReadOnly = False
            Me.txtNew.Maxlength = 0
            Me.txtNew.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtNew.MultiLine = False
            Me.txtNew.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtNew.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.txtNew.TabStop = True
            Me.txtNew.Visible = True
            Me.txtNew.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.txtNew.Name = "txtNew"
            Me._lblLabels_3.Text = "Old Password:"
            Me._lblLabels_3.Size = New System.Drawing.Size(72, 18)
            Me._lblLabels_3.Location = New System.Drawing.Point(8, 41)
            Me._lblLabels_3.TabIndex = 9
            Me._lblLabels_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._lblLabels_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
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
            Me._lblLabels_2.Text = "Confirmation:"
            Me._lblLabels_2.Size = New System.Drawing.Size(72, 18)
            Me._lblLabels_2.Location = New System.Drawing.Point(8, 97)
            Me._lblLabels_2.TabIndex = 8
            Me._lblLabels_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._lblLabels_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
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
            Me._lblLabels_0.Text = "&User Name:"
            Me._lblLabels_0.Size = New System.Drawing.Size(72, 18)
            Me._lblLabels_0.Location = New System.Drawing.Point(7, 10)
            Me._lblLabels_0.TabIndex = 6
            Me._lblLabels_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._lblLabels_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
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
            Me._lblLabels_1.Text = "New Password:"
            Me._lblLabels_1.Size = New System.Drawing.Size(80, 18)
            Me._lblLabels_1.Location = New System.Drawing.Point(7, 68)
            Me._lblLabels_1.TabIndex = 7
            Me._lblLabels_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._lblLabels_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
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
            Me.Controls.Add(txtOLD)
            Me.Controls.Add(txtConfirmation)
            Me.Controls.Add(txtUserName)
            Me.Controls.Add(cmdOK)
            Me.Controls.Add(cmdCancel)
            Me.Controls.Add(txtNew)
            Me.Controls.Add(_lblLabels_3)
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