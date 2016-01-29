Namespace Forms.StudentsForm
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmDataEntry
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
        Public WithEvents txtName As System.Windows.Forms.TextBox
        Public WithEvents _Toolbar1_Button1 As System.Windows.Forms.ToolStripButton
        Public WithEvents _Toolbar1_Button2 As System.Windows.Forms.ToolStripButton
        Public WithEvents BtnDel As System.Windows.Forms.ToolStripButton
        Public WithEvents _Toolbar1_Button4 As System.Windows.Forms.ToolStripSeparator
        Public WithEvents _Toolbar1_Button5 As System.Windows.Forms.ToolStripButton
        Public WithEvents _Toolbar1_Button6 As System.Windows.Forms.ToolStripButton
        Public WithEvents Toolbar1 As System.Windows.Forms.ToolStrip
        Public WithEvents chkPreview As System.Windows.Forms.CheckBox
        Public WithEvents cboAR As System.Windows.Forms.ComboBox
        Public WithEvents cmdPrint As System.Windows.Forms.Button
        Public WithEvents cmdCancel As System.Windows.Forms.Button
        Public WithEvents cmdOK As System.Windows.Forms.Button
        Public WithEvents Label3 As System.Windows.Forms.Label
        Public WithEvents Label2 As System.Windows.Forms.Label
        Public WithEvents Label1 As System.Windows.Forms.Label
        Public WithEvents Frame1 As System.Windows.Forms.GroupBox
        Public WithEvents _LVNames_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVNames_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVNames_ColumnHeader_3 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVNames_ColumnHeader_4 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVNames_ColumnHeader_5 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVNames_ColumnHeader_6 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVNames_ColumnHeader_7 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVNames_ColumnHeader_8 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVNames_ColumnHeader_9 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVNames_ColumnHeader_10 As System.Windows.Forms.ColumnHeader
        Public WithEvents _LVNames_ColumnHeader_11 As System.Windows.Forms.ColumnHeader
        Public WithEvents LVNames As System.Windows.Forms.ListView
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.Toolbar1 = New System.Windows.Forms.ToolStrip()
            Me._Toolbar1_Button1 = New System.Windows.Forms.ToolStripButton()
            Me._Toolbar1_Button2 = New System.Windows.Forms.ToolStripButton()
            Me.BtnDel = New System.Windows.Forms.ToolStripButton()
            Me._Toolbar1_Button4 = New System.Windows.Forms.ToolStripSeparator()
            Me._Toolbar1_Button5 = New System.Windows.Forms.ToolStripButton()
            Me._Toolbar1_Button6 = New System.Windows.Forms.ToolStripButton()
            Me.Frame1 = New System.Windows.Forms.GroupBox()
            Me.chkPreview = New System.Windows.Forms.CheckBox()
            Me.cboAR = New System.Windows.Forms.ComboBox()
            Me.cmdPrint = New System.Windows.Forms.Button()
            Me.cmdCancel = New System.Windows.Forms.Button()
            Me.cmdOK = New System.Windows.Forms.Button()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.LVNames = New System.Windows.Forms.ListView()
            Me._LVNames_ColumnHeader_1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVNames_ColumnHeader_2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVNames_ColumnHeader_3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVNames_ColumnHeader_4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVNames_ColumnHeader_5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVNames_ColumnHeader_6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVNames_ColumnHeader_7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVNames_ColumnHeader_8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVNames_ColumnHeader_9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVNames_ColumnHeader_10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._LVNames_ColumnHeader_11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.txtName = New System.Windows.Forms.TextBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Toolbar1.SuspendLayout()
            Me.Frame1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Toolbar1
            '
            Me.Toolbar1.Dock = System.Windows.Forms.DockStyle.None
            Me.Toolbar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._Toolbar1_Button1, Me._Toolbar1_Button2, Me.BtnDel, Me._Toolbar1_Button4, Me._Toolbar1_Button5, Me._Toolbar1_Button6})
            Me.Toolbar1.Location = New System.Drawing.Point(228, 1)
            Me.Toolbar1.Name = "Toolbar1"
            Me.Toolbar1.Size = New System.Drawing.Size(157, 25)
            Me.Toolbar1.TabIndex = 6
            '
            '_Toolbar1_Button1
            '
            Me._Toolbar1_Button1.AutoSize = False
            Me._Toolbar1_Button1.Image = Global.learnAid.My.Resources.Resources.new1
            Me._Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me._Toolbar1_Button1.Name = "_Toolbar1_Button1"
            Me._Toolbar1_Button1.Size = New System.Drawing.Size(19, 18)
            Me._Toolbar1_Button1.Tag = "New"
            Me._Toolbar1_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me._Toolbar1_Button1.ToolTipText = "Add Student Name"
            '
            '_Toolbar1_Button2
            '
            Me._Toolbar1_Button2.AutoSize = False
            Me._Toolbar1_Button2.Image = Global.learnAid.My.Resources.Resources.edit_job
            Me._Toolbar1_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me._Toolbar1_Button2.Name = "_Toolbar1_Button2"
            Me._Toolbar1_Button2.Size = New System.Drawing.Size(19, 18)
            Me._Toolbar1_Button2.Tag = "Edit"
            Me._Toolbar1_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me._Toolbar1_Button2.ToolTipText = "Edit Student Name"
            '
            'BtnDel
            '
            Me.BtnDel.AutoSize = False
            Me.BtnDel.Image = Global.learnAid.My.Resources.Resources.delete
            Me.BtnDel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.BtnDel.Name = "BtnDel"
            Me.BtnDel.Size = New System.Drawing.Size(19, 18)
            Me.BtnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.BtnDel.ToolTipText = "Delete Student"
            '
            '_Toolbar1_Button4
            '
            Me._Toolbar1_Button4.AutoSize = False
            Me._Toolbar1_Button4.Name = "_Toolbar1_Button4"
            Me._Toolbar1_Button4.Size = New System.Drawing.Size(19, 18)
            '
            '_Toolbar1_Button5
            '
            Me._Toolbar1_Button5.AutoSize = False
            Me._Toolbar1_Button5.Image = Global.learnAid.My.Resources.Resources.BtnUp
            Me._Toolbar1_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me._Toolbar1_Button5.Name = "_Toolbar1_Button5"
            Me._Toolbar1_Button5.Size = New System.Drawing.Size(19, 18)
            Me._Toolbar1_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me._Toolbar1_Button5.ToolTipText = "Move Down"
            '
            '_Toolbar1_Button6
            '
            Me._Toolbar1_Button6.AutoSize = False
            Me._Toolbar1_Button6.Image = Global.learnAid.My.Resources.Resources.BtnDown1
            Me._Toolbar1_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me._Toolbar1_Button6.Name = "_Toolbar1_Button6"
            Me._Toolbar1_Button6.Size = New System.Drawing.Size(19, 18)
            Me._Toolbar1_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me._Toolbar1_Button6.ToolTipText = "Move Up"
            '
            'Frame1
            '
            Me.Frame1.BackColor = System.Drawing.SystemColors.Control
            Me.Frame1.Controls.Add(Me.chkPreview)
            Me.Frame1.Controls.Add(Me.cboAR)
            Me.Frame1.Controls.Add(Me.cmdPrint)
            Me.Frame1.Controls.Add(Me.cmdCancel)
            Me.Frame1.Controls.Add(Me.cmdOK)
            Me.Frame1.Controls.Add(Me.Label3)
            Me.Frame1.Controls.Add(Me.Label2)
            Me.Frame1.Controls.Add(Me.Label1)
            Me.Frame1.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Frame1.Location = New System.Drawing.Point(12, 466)
            Me.Frame1.Name = "Frame1"
            Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
            Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Frame1.Size = New System.Drawing.Size(825, 81)
            Me.Frame1.TabIndex = 1
            Me.Frame1.TabStop = False
            '
            'chkPreview
            '
            Me.chkPreview.BackColor = System.Drawing.SystemColors.Control
            Me.chkPreview.Cursor = System.Windows.Forms.Cursors.Default
            Me.chkPreview.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkPreview.ForeColor = System.Drawing.SystemColors.ControlText
            Me.chkPreview.Location = New System.Drawing.Point(195, 21)
            Me.chkPreview.Name = "chkPreview"
            Me.chkPreview.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.chkPreview.Size = New System.Drawing.Size(66, 20)
            Me.chkPreview.TabIndex = 9
            Me.chkPreview.Text = "Preview"
            Me.chkPreview.UseVisualStyleBackColor = False
            '
            'cboAR
            '
            Me.cboAR.BackColor = System.Drawing.SystemColors.Window
            Me.cboAR.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboAR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboAR.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboAR.Location = New System.Drawing.Point(30, 15)
            Me.cboAR.Name = "cboAR"
            Me.cboAR.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboAR.Size = New System.Drawing.Size(91, 24)
            Me.cboAR.TabIndex = 8
            '
            'cmdPrint
            '
            Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
            Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdPrint.Location = New System.Drawing.Point(125, 15)
            Me.cmdPrint.Name = "cmdPrint"
            Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdPrint.Size = New System.Drawing.Size(66, 26)
            Me.cmdPrint.TabIndex = 7
            Me.cmdPrint.Text = "Print"
            Me.cmdPrint.UseVisualStyleBackColor = False
            '
            'cmdCancel
            '
            Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
            Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdCancel.Location = New System.Drawing.Point(656, 16)
            Me.cmdCancel.Name = "cmdCancel"
            Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdCancel.Size = New System.Drawing.Size(89, 25)
            Me.cmdCancel.TabIndex = 3
            Me.cmdCancel.TabStop = False
            Me.cmdCancel.Text = "&Cancel"
            Me.cmdCancel.UseVisualStyleBackColor = False
            '
            'cmdOK
            '
            Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
            Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdOK.Location = New System.Drawing.Point(564, 16)
            Me.cmdOK.Name = "cmdOK"
            Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdOK.Size = New System.Drawing.Size(89, 25)
            Me.cmdOK.TabIndex = 2
            Me.cmdOK.TabStop = False
            Me.cmdOK.Text = "&OK"
            Me.cmdOK.UseVisualStyleBackColor = False
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.SystemColors.Control
            Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label3.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label3.Location = New System.Drawing.Point(344, 48)
            Me.Label3.Name = "Label3"
            Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label3.Size = New System.Drawing.Size(177, 17)
            Me.Label3.TabIndex = 12
            Me.Label3.Text = "Sexo: (Masculino /SM) (Femenino /SF)"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.SystemColors.Control
            Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label2.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label2.Location = New System.Drawing.Point(328, 32)
            Me.Label2.Name = "Label2"
            Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label2.Size = New System.Drawing.Size(209, 17)
            Me.Label2.TabIndex = 11
            Me.Label2.Text = "ejemplo:Edad 2 años y 10 meses:  /E2.10"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.SystemColors.Control
            Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.Label1.Location = New System.Drawing.Point(280, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label1.Size = New System.Drawing.Size(297, 17)
            Me.Label1.TabIndex = 10
            Me.Label1.Text = "Syntaxis: APELLIDO1,APELLIDO2,NOMBRE/E2.10/SM"
            '
            'LVNames
            '
            Me.LVNames.BackColor = System.Drawing.SystemColors.Window
            Me.LVNames.CheckBoxes = True
            Me.LVNames.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._LVNames_ColumnHeader_1, Me._LVNames_ColumnHeader_2, Me._LVNames_ColumnHeader_3, Me._LVNames_ColumnHeader_4, Me._LVNames_ColumnHeader_5, Me._LVNames_ColumnHeader_6, Me._LVNames_ColumnHeader_7, Me._LVNames_ColumnHeader_8, Me._LVNames_ColumnHeader_9, Me._LVNames_ColumnHeader_10, Me._LVNames_ColumnHeader_11})
            Me.LVNames.Font = New System.Drawing.Font("Tahoma", 8.4!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LVNames.ForeColor = System.Drawing.SystemColors.WindowText
            Me.LVNames.FullRowSelect = True
            Me.LVNames.GridLines = True
            Me.LVNames.HideSelection = False
            Me.LVNames.Location = New System.Drawing.Point(12, 29)
            Me.LVNames.Name = "LVNames"
            Me.LVNames.Size = New System.Drawing.Size(745, 431)
            Me.LVNames.TabIndex = 5
            Me.LVNames.UseCompatibleStateImageBehavior = False
            Me.LVNames.View = System.Windows.Forms.View.Details
            '
            '_LVNames_ColumnHeader_1
            '
            Me._LVNames_ColumnHeader_1.Text = "#"
            Me._LVNames_ColumnHeader_1.Width = 71
            '
            '_LVNames_ColumnHeader_2
            '
            Me._LVNames_ColumnHeader_2.Text = "Name"
            Me._LVNames_ColumnHeader_2.Width = 323
            '
            '_LVNames_ColumnHeader_3
            '
            Me._LVNames_ColumnHeader_3.Text = "A/R"
            Me._LVNames_ColumnHeader_3.Width = 87
            '
            '_LVNames_ColumnHeader_4
            '
            Me._LVNames_ColumnHeader_4.Text = "a_id"
            Me._LVNames_ColumnHeader_4.Width = 135
            '
            '_LVNames_ColumnHeader_5
            '
            Me._LVNames_ColumnHeader_5.Text = "NV"
            Me._LVNames_ColumnHeader_5.Width = 78
            '
            '_LVNames_ColumnHeader_6
            '
            Me._LVNames_ColumnHeader_6.Text = "LES"
            Me._LVNames_ColumnHeader_6.Width = 78
            '
            '_LVNames_ColumnHeader_7
            '
            Me._LVNames_ColumnHeader_7.Text = "REN"
            Me._LVNames_ColumnHeader_7.Width = 78
            '
            '_LVNames_ColumnHeader_8
            '
            Me._LVNames_ColumnHeader_8.Text = "MAT"
            Me._LVNames_ColumnHeader_8.Width = 78
            '
            '_LVNames_ColumnHeader_9
            '
            Me._LVNames_ColumnHeader_9.Text = "A10"
            Me._LVNames_ColumnHeader_9.Width = 78
            '
            '_LVNames_ColumnHeader_10
            '
            Me._LVNames_ColumnHeader_10.Text = "Edad"
            Me._LVNames_ColumnHeader_10.Width = 71
            '
            '_LVNames_ColumnHeader_11
            '
            Me._LVNames_ColumnHeader_11.Text = "Sexo"
            Me._LVNames_ColumnHeader_11.Width = 71
            '
            'txtName
            '
            Me.txtName.Location = New System.Drawing.Point(2, 1)
            Me.txtName.Name = "txtName"
            Me.txtName.Size = New System.Drawing.Size(223, 24)
            Me.txtName.TabIndex = 6
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(679, 404)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(75, 23)
            Me.Button1.TabIndex = 0
            Me.Button1.Text = "Button1"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'frmDataEntry
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.ClientSize = New System.Drawing.Size(790, 553)
            Me.ControlBox = False
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.Toolbar1)
            Me.Controls.Add(Me.Frame1)
            Me.Controls.Add(Me.LVNames)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Tahoma", 8.4!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.KeyPreview = True
            Me.Location = New System.Drawing.Point(12, 31)
            Me.Name = "frmDataEntry"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Enter the Student List"
            Me.Toolbar1.ResumeLayout(False)
            Me.Toolbar1.PerformLayout()
            Me.Frame1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Button1 As System.Windows.Forms.Button
        ' Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
#End Region
    End Class
End Namespace