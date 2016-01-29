Namespace Forms.ClaveForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmEditKeys
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.toolStrip = New System.Windows.Forms.ToolStrip()
            Me.btnEditClave = New System.Windows.Forms.ToolStripButton()
            Me.btnEditSkill = New System.Windows.Forms.ToolStripButton()
            Me.btnInsert = New System.Windows.Forms.ToolStripButton()
            Me.fraDes = New System.Windows.Forms.GroupBox()
            Me.btnAddToGrid = New System.Windows.Forms.Button()
            Me._txtDes_2 = New System.Windows.Forms.TextBox()
            Me._txtDes_1 = New System.Windows.Forms.TextBox()
            Me._txtDes_0 = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.fraEditCell = New System.Windows.Forms.GroupBox()
            Me.btnAdd = New System.Windows.Forms.Button()
            Me._cboA_1 = New System.Windows.Forms.ComboBox()
            Me._cboA_0 = New System.Windows.Forms.ComboBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.cmdCancel = New System.Windows.Forms.Button()
            Me.cmdOK = New System.Windows.Forms.Button()
            Me.dgv = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.toolStrip.SuspendLayout()
            Me.fraDes.SuspendLayout()
            Me.fraEditCell.SuspendLayout()
            CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'toolStrip
            '
            Me.toolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEditClave, Me.btnEditSkill, Me.btnInsert})
            Me.toolStrip.Location = New System.Drawing.Point(0, 0)
            Me.toolStrip.Name = "toolStrip"
            Me.toolStrip.Size = New System.Drawing.Size(805, 25)
            Me.toolStrip.TabIndex = 0
            Me.toolStrip.Text = "ToolStrip1"
            '
            'btnEditClave
            '
            Me.btnEditClave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnEditClave.Image = Global.learnAid.My.Resources.Resources.new1
            Me.btnEditClave.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnEditClave.Name = "btnEditClave"
            Me.btnEditClave.Size = New System.Drawing.Size(23, 22)
            '
            'btnEditSkill
            '
            Me.btnEditSkill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnEditSkill.Image = Global.learnAid.My.Resources.Resources.pencil_16
            Me.btnEditSkill.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnEditSkill.Name = "btnEditSkill"
            Me.btnEditSkill.Size = New System.Drawing.Size(23, 22)
            '
            'btnInsert
            '
            Me.btnInsert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnInsert.Image = Global.learnAid.My.Resources.Resources.address_16
            Me.btnInsert.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnInsert.Name = "btnInsert"
            Me.btnInsert.Size = New System.Drawing.Size(23, 22)
            '
            'fraDes
            '
            Me.fraDes.BackColor = System.Drawing.SystemColors.Control
            Me.fraDes.Controls.Add(Me.btnAddToGrid)
            Me.fraDes.Controls.Add(Me._txtDes_2)
            Me.fraDes.Controls.Add(Me._txtDes_1)
            Me.fraDes.Controls.Add(Me._txtDes_0)
            Me.fraDes.Controls.Add(Me.Label3)
            Me.fraDes.Controls.Add(Me.Label2)
            Me.fraDes.Controls.Add(Me.Label1)
            Me.fraDes.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.fraDes.ForeColor = System.Drawing.SystemColors.ControlText
            Me.fraDes.Location = New System.Drawing.Point(3, 22)
            Me.fraDes.Name = "fraDes"
            Me.fraDes.Padding = New System.Windows.Forms.Padding(0)
            Me.fraDes.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.fraDes.Size = New System.Drawing.Size(797, 105)
            Me.fraDes.TabIndex = 1
            Me.fraDes.TabStop = False
            '
            'btnAddToGrid
            '
            Me.btnAddToGrid.Image = Global.learnAid.My.Resources.Resources.BtnDown1
            Me.btnAddToGrid.Location = New System.Drawing.Point(359, 20)
            Me.btnAddToGrid.Name = "btnAddToGrid"
            Me.btnAddToGrid.Size = New System.Drawing.Size(103, 47)
            Me.btnAddToGrid.TabIndex = 6
            Me.btnAddToGrid.UseVisualStyleBackColor = True
            '
            '_txtDes_2
            '
            Me._txtDes_2.AcceptsReturn = True
            Me._txtDes_2.BackColor = System.Drawing.SystemColors.Window
            Me._txtDes_2.Cursor = System.Windows.Forms.Cursors.IBeam
            Me._txtDes_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._txtDes_2.ForeColor = System.Drawing.SystemColors.WindowText
            Me._txtDes_2.Location = New System.Drawing.Point(105, 71)
            Me._txtDes_2.MaxLength = 0
            Me._txtDes_2.Name = "_txtDes_2"
            Me._txtDes_2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me._txtDes_2.Size = New System.Drawing.Size(592, 20)
            Me._txtDes_2.TabIndex = 5
            Me._txtDes_2.TabStop = False
            '
            '_txtDes_1
            '
            Me._txtDes_1.AcceptsReturn = True
            Me._txtDes_1.BackColor = System.Drawing.SystemColors.Window
            Me._txtDes_1.Cursor = System.Windows.Forms.Cursors.IBeam
            Me._txtDes_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._txtDes_1.ForeColor = System.Drawing.SystemColors.WindowText
            Me._txtDes_1.Location = New System.Drawing.Point(105, 47)
            Me._txtDes_1.MaxLength = 0
            Me._txtDes_1.Name = "_txtDes_1"
            Me._txtDes_1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me._txtDes_1.Size = New System.Drawing.Size(248, 20)
            Me._txtDes_1.TabIndex = 3
            Me._txtDes_1.TabStop = False
            '
            '_txtDes_0
            '
            Me._txtDes_0.AcceptsReturn = True
            Me._txtDes_0.BackColor = System.Drawing.SystemColors.Window
            Me._txtDes_0.Cursor = System.Windows.Forms.Cursors.IBeam
            Me._txtDes_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._txtDes_0.ForeColor = System.Drawing.SystemColors.WindowText
            Me._txtDes_0.Location = New System.Drawing.Point(105, 23)
            Me._txtDes_0.MaxLength = 0
            Me._txtDes_0.Name = "_txtDes_0"
            Me._txtDes_0.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me._txtDes_0.Size = New System.Drawing.Size(248, 20)
            Me._txtDes_0.TabIndex = 1
            Me._txtDes_0.TabStop = False
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.SystemColors.Control
            Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label3.Location = New System.Drawing.Point(24, 71)
            Me.Label3.Name = "Label3"
            Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label3.Size = New System.Drawing.Size(92, 17)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Description"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.SystemColors.Control
            Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label2.Location = New System.Drawing.Point(24, 23)
            Me.Label2.Name = "Label2"
            Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label2.Size = New System.Drawing.Size(65, 17)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Skills"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.SystemColors.Control
            Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label1.Location = New System.Drawing.Point(24, 47)
            Me.Label1.Name = "Label1"
            Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label1.Size = New System.Drawing.Size(92, 17)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Abbreviation"
            '
            'fraEditCell
            '
            Me.fraEditCell.BackColor = System.Drawing.SystemColors.Info
            Me.fraEditCell.Controls.Add(Me.btnAdd)
            Me.fraEditCell.Controls.Add(Me._cboA_1)
            Me.fraEditCell.Controls.Add(Me._cboA_0)
            Me.fraEditCell.Controls.Add(Me.Label4)
            Me.fraEditCell.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.fraEditCell.ForeColor = System.Drawing.SystemColors.ControlText
            Me.fraEditCell.Location = New System.Drawing.Point(3, 123)
            Me.fraEditCell.Name = "fraEditCell"
            Me.fraEditCell.Padding = New System.Windows.Forms.Padding(0)
            Me.fraEditCell.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.fraEditCell.Size = New System.Drawing.Size(797, 39)
            Me.fraEditCell.TabIndex = 2
            Me.fraEditCell.TabStop = False
            '
            'btnAdd
            '
            Me.btnAdd.Image = Global.learnAid.My.Resources.Resources.BtnDown1
            Me.btnAdd.Location = New System.Drawing.Point(186, 10)
            Me.btnAdd.Name = "btnAdd"
            Me.btnAdd.Size = New System.Drawing.Size(21, 23)
            Me.btnAdd.TabIndex = 3
            Me.btnAdd.UseVisualStyleBackColor = True
            '
            '_cboA_1
            '
            Me._cboA_1.BackColor = System.Drawing.SystemColors.Window
            Me._cboA_1.Cursor = System.Windows.Forms.Cursors.Default
            Me._cboA_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._cboA_1.ForeColor = System.Drawing.SystemColors.WindowText
            Me._cboA_1.Location = New System.Drawing.Point(140, 10)
            Me._cboA_1.Name = "_cboA_1"
            Me._cboA_1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me._cboA_1.Size = New System.Drawing.Size(38, 22)
            Me._cboA_1.TabIndex = 2
            Me._cboA_1.TabStop = False
            '
            '_cboA_0
            '
            Me._cboA_0.BackColor = System.Drawing.SystemColors.Window
            Me._cboA_0.CausesValidation = False
            Me._cboA_0.Cursor = System.Windows.Forms.Cursors.Default
            Me._cboA_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me._cboA_0.ForeColor = System.Drawing.SystemColors.WindowText
            Me._cboA_0.Location = New System.Drawing.Point(100, 10)
            Me._cboA_0.Name = "_cboA_0"
            Me._cboA_0.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me._cboA_0.Size = New System.Drawing.Size(38, 22)
            Me._cboA_0.TabIndex = 1
            Me._cboA_0.TabStop = False
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label4.Location = New System.Drawing.Point(5, 15)
            Me.Label4.Name = "Label4"
            Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label4.Size = New System.Drawing.Size(96, 16)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Question | Answer"
            '
            'cmdCancel
            '
            Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
            Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdCancel.Location = New System.Drawing.Point(727, 425)
            Me.cmdCancel.Name = "cmdCancel"
            Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdCancel.Size = New System.Drawing.Size(73, 25)
            Me.cmdCancel.TabIndex = 5
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
            Me.cmdOK.Location = New System.Drawing.Point(647, 425)
            Me.cmdOK.Name = "cmdOK"
            Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdOK.Size = New System.Drawing.Size(73, 25)
            Me.cmdOK.TabIndex = 4
            Me.cmdOK.TabStop = False
            Me.cmdOK.Text = "&OK"
            Me.cmdOK.UseVisualStyleBackColor = False
            '
            'dgv
            '
            Me.dgv.AllowUserToAddRows = False
            Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgv.ColumnHeadersHeight = 25
            Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column19, Me.Column20})
            Me.dgv.Location = New System.Drawing.Point(5, 165)
            Me.dgv.Name = "dgv"
            Me.dgv.ReadOnly = True
            Me.dgv.Size = New System.Drawing.Size(795, 254)
            Me.dgv.TabIndex = 3
            '
            'Column1
            '
            Me.Column1.HeaderText = "Column1"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'Column2
            '
            Me.Column2.HeaderText = "Column2"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'Column3
            '
            Me.Column3.HeaderText = "Column3"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'Column4
            '
            Me.Column4.HeaderText = "Column4"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'Column5
            '
            Me.Column5.HeaderText = "Column5"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'Column6
            '
            Me.Column6.HeaderText = "Column6"
            Me.Column6.Name = "Column6"
            Me.Column6.ReadOnly = True
            Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'Column7
            '
            Me.Column7.HeaderText = "Column7"
            Me.Column7.Name = "Column7"
            Me.Column7.ReadOnly = True
            Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'Column8
            '
            Me.Column8.HeaderText = "Column8"
            Me.Column8.Name = "Column8"
            Me.Column8.ReadOnly = True
            Me.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'Column9
            '
            Me.Column9.HeaderText = "Column9"
            Me.Column9.Name = "Column9"
            Me.Column9.ReadOnly = True
            Me.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'Column10
            '
            Me.Column10.HeaderText = "Column10"
            Me.Column10.Name = "Column10"
            Me.Column10.ReadOnly = True
            Me.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'Column11
            '
            Me.Column11.HeaderText = "Column11"
            Me.Column11.Name = "Column11"
            Me.Column11.ReadOnly = True
            Me.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'Column12
            '
            Me.Column12.HeaderText = "Column12"
            Me.Column12.Name = "Column12"
            Me.Column12.ReadOnly = True
            Me.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'Column13
            '
            Me.Column13.HeaderText = "Column13"
            Me.Column13.Name = "Column13"
            Me.Column13.ReadOnly = True
            Me.Column13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'Column14
            '
            Me.Column14.HeaderText = "Column14"
            Me.Column14.Name = "Column14"
            Me.Column14.ReadOnly = True
            '
            'Column15
            '
            Me.Column15.HeaderText = "Column15"
            Me.Column15.Name = "Column15"
            Me.Column15.ReadOnly = True
            '
            'Column16
            '
            Me.Column16.HeaderText = "Column16"
            Me.Column16.Name = "Column16"
            Me.Column16.ReadOnly = True
            '
            'Column17
            '
            Me.Column17.HeaderText = "Column17"
            Me.Column17.Name = "Column17"
            Me.Column17.ReadOnly = True
            '
            'Column18
            '
            Me.Column18.HeaderText = "Column18"
            Me.Column18.Name = "Column18"
            Me.Column18.ReadOnly = True
            '
            'Column19
            '
            Me.Column19.HeaderText = "Column19"
            Me.Column19.Name = "Column19"
            Me.Column19.ReadOnly = True
            '
            'Column20
            '
            Me.Column20.HeaderText = "Column20"
            Me.Column20.Name = "Column20"
            Me.Column20.ReadOnly = True
            '
            'frmEditKeys
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(805, 456)
            Me.Controls.Add(Me.dgv)
            Me.Controls.Add(Me.cmdCancel)
            Me.Controls.Add(Me.cmdOK)
            Me.Controls.Add(Me.fraDes)
            Me.Controls.Add(Me.toolStrip)
            Me.Controls.Add(Me.fraEditCell)
            Me.Name = "frmEditKeys"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Edit Keys"
            Me.toolStrip.ResumeLayout(False)
            Me.toolStrip.PerformLayout()
            Me.fraDes.ResumeLayout(False)
            Me.fraDes.PerformLayout()
            Me.fraEditCell.ResumeLayout(False)
            CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents toolStrip As System.Windows.Forms.ToolStrip
        Friend WithEvents btnEditClave As System.Windows.Forms.ToolStripButton
        Public WithEvents fraDes As System.Windows.Forms.GroupBox
        Public WithEvents _txtDes_2 As System.Windows.Forms.TextBox
        Public WithEvents _txtDes_1 As System.Windows.Forms.TextBox
        Public WithEvents _txtDes_0 As System.Windows.Forms.TextBox
        Public WithEvents Label3 As System.Windows.Forms.Label
        Public WithEvents Label2 As System.Windows.Forms.Label
        Public WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnEditSkill As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnInsert As System.Windows.Forms.ToolStripButton
        Public WithEvents fraEditCell As System.Windows.Forms.GroupBox
        Public WithEvents _cboA_1 As System.Windows.Forms.ComboBox
        Public WithEvents _cboA_0 As System.Windows.Forms.ComboBox
        Public WithEvents Label4 As System.Windows.Forms.Label
        Public WithEvents cmdCancel As System.Windows.Forms.Button
        Public WithEvents cmdOK As System.Windows.Forms.Button
        Friend WithEvents dgv As System.Windows.Forms.DataGridView
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column18 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column19 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column20 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents btnAdd As System.Windows.Forms.Button
        Friend WithEvents btnAddToGrid As System.Windows.Forms.Button
    End Class
End Namespace