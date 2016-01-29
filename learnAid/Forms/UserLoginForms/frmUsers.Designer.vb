Namespace Forms.UserLoginForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmUsers
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
        Public WithEvents ImageList1 As System.Windows.Forms.ImageList
        Public WithEvents _lvUsers_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
        Public WithEvents _lvUsers_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
        Public WithEvents lvUsers As System.Windows.Forms.ListView
        Public WithEvents _Toolbar1_Button1 As System.Windows.Forms.ToolStripButton
        Public WithEvents _Toolbar1_Button2 As System.Windows.Forms.ToolStripButton
        Public WithEvents _Toolbar1_Button3 As System.Windows.Forms.ToolStripSeparator
        Public WithEvents _Toolbar1_Button4 As System.Windows.Forms.ToolStripButton
        Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUsers))
            Me.components = New System.ComponentModel.Container()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
            Me.ImageList1 = New System.Windows.Forms.ImageList
            Me.lvUsers = New System.Windows.Forms.ListView
            Me._lvUsers_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
            Me._lvUsers_ColumnHeader_2 = New System.Windows.Forms.ColumnHeader
            Me.Toolbar1 = New System.Windows.Forms.ToolStrip
            Me._Toolbar1_Button1 = New System.Windows.Forms.ToolStripButton
            Me._Toolbar1_Button2 = New System.Windows.Forms.ToolStripButton
            Me._Toolbar1_Button3 = New System.Windows.Forms.ToolStripSeparator
            Me._Toolbar1_Button4 = New System.Windows.Forms.ToolStripButton
            Me.lvUsers.SuspendLayout()
            Me.Toolbar1.SuspendLayout()
            Me.SuspendLayout()
            Me.ToolTip1.Active = True
            Me.Text = "Users"
            Me.ClientSize = New System.Drawing.Size(434, 387)
            Me.Location = New System.Drawing.Point(4, 23)
            Me.Icon = CType(resources.GetObject("frmUsers.Icon"), System.Drawing.Icon)
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
            Me.ControlBox = True
            Me.Enabled = True
            Me.KeyPreview = False
            Me.MaximizeBox = True
            Me.MinimizeBox = True
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.ShowInTaskbar = True
            Me.HelpButton = False
            Me.WindowState = System.Windows.Forms.FormWindowState.Normal
            Me.Name = "frmUsers"
            Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
            Me.ImageList1.TransparentColor = System.Drawing.Color.FromARGB(192, 192, 192)
            Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageList1.Images.SetKeyName(0, "Delete")
            Me.ImageList1.Images.SetKeyName(1, "Password")
            Me.ImageList1.Images.SetKeyName(2, "New")
            Me.ImageList1.Images.SetKeyName(3, "Edit")
            Me.lvUsers.Size = New System.Drawing.Size(433, 345)
            Me.lvUsers.Location = New System.Drawing.Point(8, 32)
            Me.lvUsers.TabIndex = 1
            Me.lvUsers.View = System.Windows.Forms.View.Details
            Me.lvUsers.LabelEdit = False
            Me.lvUsers.LabelWrap = True
            Me.lvUsers.HideSelection = True
            Me.lvUsers.FullRowSelect = True
            Me.lvUsers.GridLines = True
            Me.lvUsers.ForeColor = System.Drawing.SystemColors.WindowText
            Me.lvUsers.BackColor = System.Drawing.SystemColors.Window
            Me.lvUsers.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lvUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lvUsers.Name = "lvUsers"
            Me._lvUsers_ColumnHeader_1.Text = "Username"
            Me._lvUsers_ColumnHeader_1.Width = 170
            Me._lvUsers_ColumnHeader_2.Text = "User type"
            Me._lvUsers_ColumnHeader_2.Width = 353
            Me.Toolbar1.ShowItemToolTips = True
            Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Toolbar1.Size = New System.Drawing.Size(434, 24)
            Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
            Me.Toolbar1.TabIndex = 0
            Me.Toolbar1.ImageList = ImageList1
            Me.Toolbar1.Name = "Toolbar1"
            Me._Toolbar1_Button1.Size = New System.Drawing.Size(24, 22)
            Me._Toolbar1_Button1.AutoSize = False
            Me._Toolbar1_Button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me._Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me._Toolbar1_Button1.Name = "New"
            Me._Toolbar1_Button1.ToolTipText = "New User"
            Me._Toolbar1_Button1.ImageKey = "New"
            Me._Toolbar1_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me._Toolbar1_Button2.Size = New System.Drawing.Size(24, 22)
            Me._Toolbar1_Button2.AutoSize = False
            Me._Toolbar1_Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me._Toolbar1_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me._Toolbar1_Button2.Name = "Delete"
            Me._Toolbar1_Button2.ToolTipText = "Delete User"
            Me._Toolbar1_Button2.ImageKey = "Delete"
            Me._Toolbar1_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me._Toolbar1_Button3.Size = New System.Drawing.Size(24, 22)
            Me._Toolbar1_Button3.AutoSize = False
            Me._Toolbar1_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me._Toolbar1_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me._Toolbar1_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me._Toolbar1_Button4.Size = New System.Drawing.Size(24, 22)
            Me._Toolbar1_Button4.AutoSize = False
            Me._Toolbar1_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me._Toolbar1_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me._Toolbar1_Button4.Name = "ChangePassword"
            Me._Toolbar1_Button4.ToolTipText = "Change Password"
            Me._Toolbar1_Button4.ImageKey = "Password"
            Me._Toolbar1_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.Controls.Add(lvUsers)
            Me.Controls.Add(Toolbar1)
            Me.lvUsers.Columns.Add(_lvUsers_ColumnHeader_1)
            Me.lvUsers.Columns.Add(_lvUsers_ColumnHeader_2)
            Me.Toolbar1.Items.Add(_Toolbar1_Button1)
            Me.Toolbar1.Items.Add(_Toolbar1_Button2)
            Me.Toolbar1.Items.Add(_Toolbar1_Button3)
            Me.Toolbar1.Items.Add(_Toolbar1_Button4)
            Me.lvUsers.ResumeLayout(False)
            Me.Toolbar1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub
#End Region
    End Class
End Namespace