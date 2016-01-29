Namespace Forms.UserLoginForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmLogin
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
        Public WithEvents cboDB As System.Windows.Forms.ComboBox
        Public WithEvents txtUserName As System.Windows.Forms.TextBox
        Public WithEvents cmdOK As System.Windows.Forms.Button
        Public WithEvents cmdCancel As System.Windows.Forms.Button
        Public WithEvents txtPassword As System.Windows.Forms.TextBox
        Public WithEvents _lblLabels_2 As System.Windows.Forms.Label
        Public WithEvents lblVersion As System.Windows.Forms.Label
        Public WithEvents Image1 As System.Windows.Forms.PictureBox
        Public WithEvents _lblLabels_0 As System.Windows.Forms.Label
        Public WithEvents _lblLabels_1 As System.Windows.Forms.Label
        Public WithEvents lblLabels As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.cboDB = New System.Windows.Forms.ComboBox()
            Me.txtUserName = New System.Windows.Forms.TextBox()
            Me.cmdOK = New System.Windows.Forms.Button()
            Me.cmdCancel = New System.Windows.Forms.Button()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me._lblLabels_2 = New System.Windows.Forms.Label()
            Me.lblVersion = New System.Windows.Forms.Label()
            Me.Image1 = New System.Windows.Forms.PictureBox()
            Me._lblLabels_0 = New System.Windows.Forms.Label()
            Me._lblLabels_1 = New System.Windows.Forms.Label()
            Me.lblLabels = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
            CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lblLabels, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'cboDB
            '
            Me.cboDB.BackColor = System.Drawing.SystemColors.Window
            Me.cboDB.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboDB.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboDB.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboDB.Location = New System.Drawing.Point(56, 128)
            Me.cboDB.Name = "cboDB"
            Me.cboDB.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboDB.Size = New System.Drawing.Size(129, 22)
            Me.cboDB.TabIndex = 7
            '
            'txtUserName
            '
            Me.txtUserName.AcceptsReturn = True
            Me.txtUserName.BackColor = System.Drawing.SystemColors.Window
            Me.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtUserName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUserName.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtUserName.Location = New System.Drawing.Point(56, 24)
            Me.txtUserName.MaxLength = 0
            Me.txtUserName.Name = "txtUserName"
            Me.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtUserName.Size = New System.Drawing.Size(123, 20)
            Me.txtUserName.TabIndex = 1
            Me.txtUserName.Text = "jesus"
            '
            'cmdOK
            '
            Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
            Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdOK.Location = New System.Drawing.Point(192, 24)
            Me.cmdOK.Name = "cmdOK"
            Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdOK.Size = New System.Drawing.Size(76, 26)
            Me.cmdOK.TabIndex = 4
            Me.cmdOK.Text = "OK"
            Me.cmdOK.UseVisualStyleBackColor = False
            '
            'cmdCancel
            '
            Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
            Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdCancel.Location = New System.Drawing.Point(192, 56)
            Me.cmdCancel.Name = "cmdCancel"
            Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdCancel.Size = New System.Drawing.Size(76, 26)
            Me.cmdCancel.TabIndex = 5
            Me.cmdCancel.Text = "Cancel"
            Me.cmdCancel.UseVisualStyleBackColor = False
            '
            'txtPassword
            '
            Me.txtPassword.AcceptsReturn = True
            Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
            Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtPassword.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable
            Me.txtPassword.Location = New System.Drawing.Point(56, 72)
            Me.txtPassword.MaxLength = 0
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtPassword.Size = New System.Drawing.Size(123, 20)
            Me.txtPassword.TabIndex = 3
            '
            '_lblLabels_2
            '
            Me._lblLabels_2.BackColor = System.Drawing.SystemColors.Control
            Me._lblLabels_2.Cursor = System.Windows.Forms.Cursors.Default
            Me._lblLabels_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._lblLabels_2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblLabels.SetIndex(Me._lblLabels_2, CType(2, Short))
            Me._lblLabels_2.Location = New System.Drawing.Point(56, 112)
            Me._lblLabels_2.Name = "_lblLabels_2"
            Me._lblLabels_2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me._lblLabels_2.Size = New System.Drawing.Size(72, 18)
            Me._lblLabels_2.TabIndex = 8
            Me._lblLabels_2.Text = "Database:"
            '
            'lblVersion
            '
            Me.lblVersion.BackColor = System.Drawing.SystemColors.Control
            Me.lblVersion.Cursor = System.Windows.Forms.Cursors.Default
            Me.lblVersion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblVersion.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblVersion.Location = New System.Drawing.Point(216, 96)
            Me.lblVersion.Name = "lblVersion"
            Me.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.lblVersion.Size = New System.Drawing.Size(61, 16)
            Me.lblVersion.TabIndex = 6
            Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Image1
            '
            Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
            Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
            Me.Image1.Location = New System.Drawing.Point(8, 8)
            Me.Image1.Name = "Image1"
            Me.Image1.Size = New System.Drawing.Size(28, 31)
            Me.Image1.TabIndex = 9
            Me.Image1.TabStop = False
            '
            '_lblLabels_0
            '
            Me._lblLabels_0.BackColor = System.Drawing.SystemColors.Control
            Me._lblLabels_0.Cursor = System.Windows.Forms.Cursors.Default
            Me._lblLabels_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._lblLabels_0.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblLabels.SetIndex(Me._lblLabels_0, CType(0, Short))
            Me._lblLabels_0.Location = New System.Drawing.Point(55, 9)
            Me._lblLabels_0.Name = "_lblLabels_0"
            Me._lblLabels_0.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me._lblLabels_0.Size = New System.Drawing.Size(72, 18)
            Me._lblLabels_0.TabIndex = 0
            Me._lblLabels_0.Text = "&User Name:"
            '
            '_lblLabels_1
            '
            Me._lblLabels_1.BackColor = System.Drawing.SystemColors.Control
            Me._lblLabels_1.Cursor = System.Windows.Forms.Cursors.Default
            Me._lblLabels_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._lblLabels_1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblLabels.SetIndex(Me._lblLabels_1, CType(1, Short))
            Me._lblLabels_1.Location = New System.Drawing.Point(56, 56)
            Me._lblLabels_1.Name = "_lblLabels_1"
            Me._lblLabels_1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me._lblLabels_1.Size = New System.Drawing.Size(72, 18)
            Me._lblLabels_1.TabIndex = 2
            Me._lblLabels_1.Text = "&Password:"
            '
            'frmLogin
            '
            Me.AcceptButton = Me.cmdOK
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.CancelButton = Me.cmdCancel
            Me.ClientSize = New System.Drawing.Size(280, 164)
            Me.ControlBox = False
            Me.Controls.Add(Me.cboDB)
            Me.Controls.Add(Me.txtUserName)
            Me.Controls.Add(Me.cmdOK)
            Me.Controls.Add(Me.cmdCancel)
            Me.Controls.Add(Me.txtPassword)
            Me.Controls.Add(Me._lblLabels_2)
            Me.Controls.Add(Me.lblVersion)
            Me.Controls.Add(Me.Image1)
            Me.Controls.Add(Me._lblLabels_0)
            Me.Controls.Add(Me._lblLabels_1)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Location = New System.Drawing.Point(189, 232)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmLogin"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Login"
            CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lblLabels, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region
    End Class
End Namespace