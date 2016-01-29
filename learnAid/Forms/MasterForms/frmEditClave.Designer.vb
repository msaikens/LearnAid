Namespace Forms.MasterForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmEditClave
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
        Public WithEvents cmdOK As System.Windows.Forms.Button
        Public WithEvents ImageList1 As System.Windows.Forms.ImageList
        Public WithEvents _Toolbar1_Button1 As System.Windows.Forms.ToolStripButton
        Public WithEvents _Toolbar1_Button2 As System.Windows.Forms.ToolStripButton
        Public WithEvents _Toolbar1_Button3 As System.Windows.Forms.ToolStripSeparator
        Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
        Public WithEvents _txtDes_2 As System.Windows.Forms.TextBox
        Public WithEvents _txtDes_1 As System.Windows.Forms.TextBox
        Public WithEvents _txtDes_0 As System.Windows.Forms.TextBox
        Public WithEvents Label3 As System.Windows.Forms.Label
        Public WithEvents Label2 As System.Windows.Forms.Label
        Public WithEvents Label1 As System.Windows.Forms.Label
        Public WithEvents fraDes As System.Windows.Forms.GroupBox
        'Public WithEvents Grid As AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
        Public WithEvents _cboA_1 As System.Windows.Forms.ComboBox
        Public WithEvents _cboA_0 As System.Windows.Forms.ComboBox
        Public WithEvents Label4 As System.Windows.Forms.Label
        Public WithEvents fraEditCell As System.Windows.Forms.GroupBox
        Public WithEvents cboA As Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray
        Public WithEvents txtDes As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEditClave))
            Me.components = New System.ComponentModel.Container()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
            Me.cmdCancel = New System.Windows.Forms.Button
            Me.cmdOK = New System.Windows.Forms.Button
            Me.ImageList1 = New System.Windows.Forms.ImageList
            Me.Toolbar1 = New System.Windows.Forms.ToolStrip
            Me._Toolbar1_Button1 = New System.Windows.Forms.ToolStripButton
            Me._Toolbar1_Button2 = New System.Windows.Forms.ToolStripButton
            Me._Toolbar1_Button3 = New System.Windows.Forms.ToolStripSeparator
            Me.fraDes = New System.Windows.Forms.GroupBox
            Me._txtDes_2 = New System.Windows.Forms.TextBox
            Me._txtDes_1 = New System.Windows.Forms.TextBox
            Me._txtDes_0 = New System.Windows.Forms.TextBox
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            'Me.Grid = New AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
            Me.fraEditCell = New System.Windows.Forms.GroupBox
            Me._cboA_1 = New System.Windows.Forms.ComboBox
            Me._cboA_0 = New System.Windows.Forms.ComboBox
            Me.Label4 = New System.Windows.Forms.Label
            Me.cboA = New Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray(components)
            Me.txtDes = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
            Me.Toolbar1.SuspendLayout()
            Me.fraDes.SuspendLayout()
            Me.fraEditCell.SuspendLayout()
            Me.SuspendLayout()
            Me.ToolTip1.Active = True
            'CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cboA, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtDes, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Text = " "
            Me.ClientSize = New System.Drawing.Size(563, 349)
            Me.Location = New System.Drawing.Point(3, 22)
            Me.ControlBox = False
            Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.Enabled = True
            Me.KeyPreview = False
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.HelpButton = False
            Me.WindowState = System.Windows.Forms.FormWindowState.Normal
            Me.Name = "frmEditClave"
            Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.cmdCancel.Text = "&Cancel"
            Me.cmdCancel.Size = New System.Drawing.Size(73, 25)
            Me.cmdCancel.Location = New System.Drawing.Point(488, 320)
            Me.cmdCancel.TabIndex = 14
            Me.cmdCancel.TabStop = False
            Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
            Me.cmdCancel.CausesValidation = True
            Me.cmdCancel.Enabled = True
            Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdCancel.Name = "cmdCancel"
            Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.cmdOK.Text = "&OK"
            Me.cmdOK.Size = New System.Drawing.Size(73, 25)
            Me.cmdOK.Location = New System.Drawing.Point(408, 320)
            Me.cmdOK.TabIndex = 13
            Me.cmdOK.TabStop = False
            Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
            Me.cmdOK.CausesValidation = True
            Me.cmdOK.Enabled = True
            Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdOK.Name = "cmdOK"
            Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
            Me.ImageList1.TransparentColor = System.Drawing.Color.FromARGB(192, 192, 192)
            Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageList1.Images.SetKeyName(0, "EditClave")
            Me.ImageList1.Images.SetKeyName(1, "EditSkill")
            Me.Toolbar1.ShowItemToolTips = True
            Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Toolbar1.Size = New System.Drawing.Size(563, 24)
            Me.Toolbar1.Location = New System.Drawing.Point(0, 0)
            Me.Toolbar1.TabIndex = 12
            Me.Toolbar1.ImageList = ImageList1
            Me.Toolbar1.Name = "Toolbar1"
            Me._Toolbar1_Button1.Size = New System.Drawing.Size(24, 22)
            Me._Toolbar1_Button1.AutoSize = False
            Me._Toolbar1_Button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me._Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me._Toolbar1_Button1.Name = "EditClave"
            Me._Toolbar1_Button1.ImageKey = "EditClave"
            Me._Toolbar1_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me._Toolbar1_Button2.Size = New System.Drawing.Size(24, 22)
            Me._Toolbar1_Button2.AutoSize = False
            Me._Toolbar1_Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me._Toolbar1_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me._Toolbar1_Button2.Name = "EditDestreza"
            Me._Toolbar1_Button2.ImageKey = "EditSkill"
            Me._Toolbar1_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me._Toolbar1_Button3.Size = New System.Drawing.Size(24, 22)
            Me._Toolbar1_Button3.AutoSize = False
            Me._Toolbar1_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
            Me._Toolbar1_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me._Toolbar1_Button3.Width = 1000
            Me._Toolbar1_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.fraDes.Text = "Destreza 1"
            Me.fraDes.Size = New System.Drawing.Size(561, 105)
            Me.fraDes.Location = New System.Drawing.Point(0, 24)
            Me.fraDes.TabIndex = 1
            Me.fraDes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.fraDes.BackColor = System.Drawing.SystemColors.Control
            Me.fraDes.Enabled = True
            Me.fraDes.ForeColor = System.Drawing.SystemColors.ControlText
            Me.fraDes.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.fraDes.Visible = True
            Me.fraDes.Padding = New System.Windows.Forms.Padding(0)
            Me.fraDes.Name = "fraDes"
            Me._txtDes_2.AutoSize = False
            Me._txtDes_2.Size = New System.Drawing.Size(305, 19)
            Me._txtDes_2.Location = New System.Drawing.Point(90, 72)
            Me._txtDes_2.Maxlength = 300
            Me._txtDes_2.TabIndex = 4
            Me._txtDes_2.TabStop = False
            Me._txtDes_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._txtDes_2.AcceptsReturn = True
            Me._txtDes_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me._txtDes_2.BackColor = System.Drawing.SystemColors.Window
            Me._txtDes_2.CausesValidation = True
            Me._txtDes_2.Enabled = True
            Me._txtDes_2.ForeColor = System.Drawing.SystemColors.WindowText
            Me._txtDes_2.HideSelection = True
            Me._txtDes_2.ReadOnly = False
            Me._txtDes_2.Cursor = System.Windows.Forms.Cursors.IBeam
            Me._txtDes_2.MultiLine = False
            Me._txtDes_2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me._txtDes_2.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me._txtDes_2.Visible = True
            Me._txtDes_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me._txtDes_2.Name = "_txtDes_2"
            Me._txtDes_1.AutoSize = False
            Me._txtDes_1.Size = New System.Drawing.Size(145, 19)
            Me._txtDes_1.Location = New System.Drawing.Point(90, 48)
            Me._txtDes_1.Maxlength = 20
            Me._txtDes_1.TabIndex = 3
            Me._txtDes_1.TabStop = False
            Me._txtDes_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._txtDes_1.AcceptsReturn = True
            Me._txtDes_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me._txtDes_1.BackColor = System.Drawing.SystemColors.Window
            Me._txtDes_1.CausesValidation = True
            Me._txtDes_1.Enabled = True
            Me._txtDes_1.ForeColor = System.Drawing.SystemColors.WindowText
            Me._txtDes_1.HideSelection = True
            Me._txtDes_1.ReadOnly = False
            Me._txtDes_1.Cursor = System.Windows.Forms.Cursors.IBeam
            Me._txtDes_1.MultiLine = False
            Me._txtDes_1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me._txtDes_1.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me._txtDes_1.Visible = True
            Me._txtDes_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me._txtDes_1.Name = "_txtDes_1"
            Me._txtDes_0.AutoSize = False
            Me._txtDes_0.Size = New System.Drawing.Size(145, 19)
            Me._txtDes_0.Location = New System.Drawing.Point(90, 24)
            Me._txtDes_0.Maxlength = 50
            Me._txtDes_0.TabIndex = 2
            Me._txtDes_0.TabStop = False
            Me._txtDes_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._txtDes_0.AcceptsReturn = True
            Me._txtDes_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me._txtDes_0.BackColor = System.Drawing.SystemColors.Window
            Me._txtDes_0.CausesValidation = True
            Me._txtDes_0.Enabled = True
            Me._txtDes_0.ForeColor = System.Drawing.SystemColors.WindowText
            Me._txtDes_0.HideSelection = True
            Me._txtDes_0.ReadOnly = False
            Me._txtDes_0.Cursor = System.Windows.Forms.Cursors.IBeam
            Me._txtDes_0.MultiLine = False
            Me._txtDes_0.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me._txtDes_0.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me._txtDes_0.Visible = True
            Me._txtDes_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me._txtDes_0.Name = "_txtDes_0"
            Me.Label3.Text = "Descripción"
            Me.Label3.Size = New System.Drawing.Size(57, 17)
            Me.Label3.Location = New System.Drawing.Point(24, 72)
            Me.Label3.TabIndex = 7
            Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
            Me.Label3.BackColor = System.Drawing.SystemColors.Control
            Me.Label3.Enabled = True
            Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label3.UseMnemonic = True
            Me.Label3.Visible = True
            Me.Label3.AutoSize = False
            Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.Label3.Name = "Label3"
            Me.Label2.Text = "Destreza"
            Me.Label2.Size = New System.Drawing.Size(65, 17)
            Me.Label2.Location = New System.Drawing.Point(24, 24)
            Me.Label2.TabIndex = 6
            Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
            Me.Label2.BackColor = System.Drawing.SystemColors.Control
            Me.Label2.Enabled = True
            Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label2.UseMnemonic = True
            Me.Label2.Visible = True
            Me.Label2.AutoSize = False
            Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.Label2.Name = "Label2"
            Me.Label1.Text = "Abreviacion"
            Me.Label1.Size = New System.Drawing.Size(57, 17)
            Me.Label1.Location = New System.Drawing.Point(24, 48)
            Me.Label1.TabIndex = 5
            Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
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
            'Grid.OcxState = CType(resources.GetObject("Grid.OcxState"), System.Windows.Forms.AxHost.State)
            'Me.Grid.Size = New System.Drawing.Size(561, 161)
            'Me.Grid.Location = New System.Drawing.Point(0, 152)
            'Me.Grid.TabIndex = 0
            'Me.Grid.Name = "Grid"
            Me.fraEditCell.BackColor = System.Drawing.SystemColors.Info
            Me.fraEditCell.Size = New System.Drawing.Size(561, 39)
            Me.fraEditCell.Location = New System.Drawing.Point(0, 118)
            Me.fraEditCell.TabIndex = 8
            Me.fraEditCell.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.fraEditCell.Enabled = True
            Me.fraEditCell.ForeColor = System.Drawing.SystemColors.ControlText
            Me.fraEditCell.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.fraEditCell.Visible = True
            Me.fraEditCell.Padding = New System.Windows.Forms.Padding(0)
            Me.fraEditCell.Name = "fraEditCell"
            Me._cboA_1.Size = New System.Drawing.Size(41, 21)
            Me._cboA_1.Location = New System.Drawing.Point(144, 10)
            Me._cboA_1.TabIndex = 10
            Me._cboA_1.TabStop = False
            Me._cboA_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._cboA_1.BackColor = System.Drawing.SystemColors.Window
            Me._cboA_1.CausesValidation = True
            Me._cboA_1.Enabled = True
            Me._cboA_1.ForeColor = System.Drawing.SystemColors.WindowText
            Me._cboA_1.IntegralHeight = True
            Me._cboA_1.Cursor = System.Windows.Forms.Cursors.Default
            Me._cboA_1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me._cboA_1.Sorted = False
            Me._cboA_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
            Me._cboA_1.Visible = True
            Me._cboA_1.Name = "_cboA_1"
            Me._cboA_0.CausesValidation = False
            Me._cboA_0.Size = New System.Drawing.Size(41, 21)
            Me._cboA_0.Location = New System.Drawing.Point(100, 10)
            Me._cboA_0.TabIndex = 9
            Me._cboA_0.TabStop = False
            Me._cboA_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._cboA_0.BackColor = System.Drawing.SystemColors.Window
            Me._cboA_0.Enabled = True
            Me._cboA_0.ForeColor = System.Drawing.SystemColors.WindowText
            Me._cboA_0.IntegralHeight = True
            Me._cboA_0.Cursor = System.Windows.Forms.Cursors.Default
            Me._cboA_0.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me._cboA_0.Sorted = False
            Me._cboA_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
            Me._cboA_0.Visible = True
            Me._cboA_0.Name = "_cboA_0"
            Me.Label4.Text = "Question | Answer"
            Me.Label4.Size = New System.Drawing.Size(96, 16)
            Me.Label4.Location = New System.Drawing.Point(5, 15)
            Me.Label4.TabIndex = 11
            Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Enabled = True
            Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label4.UseMnemonic = True
            Me.Label4.Visible = True
            Me.Label4.AutoSize = False
            Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.Label4.Name = "Label4"
            Me.Controls.Add(cmdCancel)
            Me.Controls.Add(cmdOK)
            Me.Controls.Add(Toolbar1)
            Me.Controls.Add(fraDes)
            'Me.Controls.Add(Grid)
            Me.Controls.Add(fraEditCell)
            Me.Toolbar1.Items.Add(_Toolbar1_Button1)
            Me.Toolbar1.Items.Add(_Toolbar1_Button2)
            Me.Toolbar1.Items.Add(_Toolbar1_Button3)
            Me.fraDes.Controls.Add(_txtDes_2)
            Me.fraDes.Controls.Add(_txtDes_1)
            Me.fraDes.Controls.Add(_txtDes_0)
            Me.fraDes.Controls.Add(Label3)
            Me.fraDes.Controls.Add(Label2)
            Me.fraDes.Controls.Add(Label1)
            Me.fraEditCell.Controls.Add(_cboA_1)
            Me.fraEditCell.Controls.Add(_cboA_0)
            Me.fraEditCell.Controls.Add(Label4)
            Me.cboA.SetIndex(_cboA_1, CType(1, Short))
            Me.cboA.SetIndex(_cboA_0, CType(0, Short))
            Me.txtDes.SetIndex(_txtDes_2, CType(2, Short))
            Me.txtDes.SetIndex(_txtDes_1, CType(1, Short))
            Me.txtDes.SetIndex(_txtDes_0, CType(0, Short))
            CType(Me.txtDes, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cboA, System.ComponentModel.ISupportInitialize).EndInit()
            'CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Toolbar1.ResumeLayout(False)
            Me.fraDes.ResumeLayout(False)
            Me.fraEditCell.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub
#End Region
    End Class
End Namespace