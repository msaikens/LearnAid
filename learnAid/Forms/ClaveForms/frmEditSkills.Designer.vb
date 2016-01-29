Namespace Forms.ClaveForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmEditSkills
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
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.grid = New System.Windows.Forms.DataGridView()
            Me.colAbr = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.GroupBox1.SuspendLayout()
            CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.grid)
            Me.GroupBox1.Location = New System.Drawing.Point(2, 12)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(763, 504)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Edit Skills to Test"
            '
            'grid
            '
            Me.grid.AllowUserToAddRows = False
            Me.grid.AllowUserToDeleteRows = False
            Me.grid.AllowUserToOrderColumns = True
            Me.grid.AllowUserToResizeColumns = False
            Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colAbr, Me.colName, Me.colDescription})
            Me.grid.Location = New System.Drawing.Point(9, 17)
            Me.grid.Name = "grid"
            Me.grid.Size = New System.Drawing.Size(745, 479)
            Me.grid.TabIndex = 0
            '
            'colAbr
            '
            Me.colAbr.HeaderText = "ABR"
            Me.colAbr.Name = "colAbr"
            '
            'colName
            '
            Me.colName.HeaderText = "NAME"
            Me.colName.Name = "colName"
            Me.colName.Width = 250
            '
            'colDescription
            '
            Me.colDescription.HeaderText = "DESCRIPTION"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Width = 300
            '
            'btnSave
            '
            Me.btnSave.Location = New System.Drawing.Point(607, 524)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(75, 23)
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "Save"
            Me.btnSave.UseVisualStyleBackColor = True
            '
            'btnCancel
            '
            Me.btnCancel.Location = New System.Drawing.Point(688, 524)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 23)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = True
            '
            'frmEditSkills
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(772, 557)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.GroupBox1)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmEditSkills"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Edit Skills"
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents btnSave As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents grid As System.Windows.Forms.DataGridView
        Friend WithEvents colAbr As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace