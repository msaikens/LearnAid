Namespace Forms.StudentsForm
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmStudentResult
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
            Me.dataGrid = New System.Windows.Forms.DataGridView()
            Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colStudent = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colJobID = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colSchoolId = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colSchoolName = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colSchoolAdd1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colSchoolAdd2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colSchoolZip = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colSchoolCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colJobType = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtScZip = New System.Windows.Forms.TextBox()
            Me.txtJobName = New System.Windows.Forms.TextBox()
            Me.txtSchool = New System.Windows.Forms.TextBox()
            Me.txtStudentName = New System.Windows.Forms.TextBox()
            Me.btnSearch = New System.Windows.Forms.Button()
            Me.gbCriteria = New System.Windows.Forms.GroupBox()
            Me.rbEndWith = New System.Windows.Forms.RadioButton()
            Me.rbStartWith = New System.Windows.Forms.RadioButton()
            Me.rbAny = New System.Windows.Forms.RadioButton()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.gbCriteria.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'dataGrid
            '
            Me.dataGrid.AllowUserToAddRows = False
            Me.dataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colStudent, Me.colJobID, Me.colSchoolId, Me.colSchoolName, Me.colSchoolAdd1, Me.colSchoolAdd2, Me.colSchoolZip, Me.colSchoolCity, Me.colJobType})
            Me.dataGrid.Location = New System.Drawing.Point(9, 18)
            Me.dataGrid.Name = "dataGrid"
            Me.dataGrid.ReadOnly = True
            Me.dataGrid.Size = New System.Drawing.Size(592, 262)
            Me.dataGrid.TabIndex = 5
            '
            'colId
            '
            Me.colId.HeaderText = "ID"
            Me.colId.Name = "colId"
            Me.colId.ReadOnly = True
            Me.colId.Width = 50
            '
            'colStudent
            '
            Me.colStudent.HeaderText = "Student"
            Me.colStudent.Name = "colStudent"
            Me.colStudent.ReadOnly = True
            Me.colStudent.Width = 200
            '
            'colJobID
            '
            Me.colJobID.HeaderText = "Job ID"
            Me.colJobID.Name = "colJobID"
            Me.colJobID.ReadOnly = True
            Me.colJobID.Width = 50
            '
            'colSchoolId
            '
            Me.colSchoolId.HeaderText = "School Id"
            Me.colSchoolId.Name = "colSchoolId"
            Me.colSchoolId.ReadOnly = True
            Me.colSchoolId.Width = 50
            '
            'colSchoolName
            '
            Me.colSchoolName.HeaderText = "School Name"
            Me.colSchoolName.Name = "colSchoolName"
            Me.colSchoolName.ReadOnly = True
            Me.colSchoolName.Width = 200
            '
            'colSchoolAdd1
            '
            Me.colSchoolAdd1.HeaderText = "School Address 1"
            Me.colSchoolAdd1.Name = "colSchoolAdd1"
            Me.colSchoolAdd1.ReadOnly = True
            '
            'colSchoolAdd2
            '
            Me.colSchoolAdd2.HeaderText = "School Address 2"
            Me.colSchoolAdd2.Name = "colSchoolAdd2"
            Me.colSchoolAdd2.ReadOnly = True
            '
            'colSchoolZip
            '
            Me.colSchoolZip.HeaderText = "School Zip code"
            Me.colSchoolZip.Name = "colSchoolZip"
            Me.colSchoolZip.ReadOnly = True
            '
            'colSchoolCity
            '
            Me.colSchoolCity.HeaderText = "School City"
            Me.colSchoolCity.Name = "colSchoolCity"
            Me.colSchoolCity.ReadOnly = True
            '
            'colJobType
            '
            Me.colJobType.HeaderText = "Job Type"
            Me.colJobType.Name = "colJobType"
            Me.colJobType.ReadOnly = True
            Me.colJobType.Width = 50
            '
            'GroupBox1
            '
            Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.txtScZip)
            Me.GroupBox1.Controls.Add(Me.txtJobName)
            Me.GroupBox1.Controls.Add(Me.txtSchool)
            Me.GroupBox1.Controls.Add(Me.txtStudentName)
            Me.GroupBox1.Controls.Add(Me.btnSearch)
            Me.GroupBox1.Controls.Add(Me.gbCriteria)
            Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(609, 112)
            Me.GroupBox1.TabIndex = 6
            Me.GroupBox1.TabStop = False
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(361, 86)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(60, 13)
            Me.Label4.TabIndex = 3
            Me.Label4.Text = "School ZIP"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(383, 60)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(38, 13)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Job ID"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(12, 86)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(71, 13)
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "School Name"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 60)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(75, 13)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Student Name"
            '
            'txtScZip
            '
            Me.txtScZip.Location = New System.Drawing.Point(422, 82)
            Me.txtScZip.Name = "txtScZip"
            Me.txtScZip.Size = New System.Drawing.Size(95, 20)
            Me.txtScZip.TabIndex = 2
            '
            'txtJobName
            '
            Me.txtJobName.Location = New System.Drawing.Point(422, 56)
            Me.txtJobName.Name = "txtJobName"
            Me.txtJobName.Size = New System.Drawing.Size(95, 20)
            Me.txtJobName.TabIndex = 2
            '
            'txtSchool
            '
            Me.txtSchool.Location = New System.Drawing.Point(93, 82)
            Me.txtSchool.Name = "txtSchool"
            Me.txtSchool.Size = New System.Drawing.Size(244, 20)
            Me.txtSchool.TabIndex = 2
            '
            'txtStudentName
            '
            Me.txtStudentName.Location = New System.Drawing.Point(93, 56)
            Me.txtStudentName.Name = "txtStudentName"
            Me.txtStudentName.Size = New System.Drawing.Size(244, 20)
            Me.txtStudentName.TabIndex = 2
            '
            'btnSearch
            '
            Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSearch.Location = New System.Drawing.Point(529, 53)
            Me.btnSearch.Name = "btnSearch"
            Me.btnSearch.Size = New System.Drawing.Size(74, 49)
            Me.btnSearch.TabIndex = 0
            Me.btnSearch.Text = "Search"
            Me.btnSearch.UseVisualStyleBackColor = True
            '
            'gbCriteria
            '
            Me.gbCriteria.Controls.Add(Me.rbEndWith)
            Me.gbCriteria.Controls.Add(Me.rbStartWith)
            Me.gbCriteria.Controls.Add(Me.rbAny)
            Me.gbCriteria.Location = New System.Drawing.Point(9, 8)
            Me.gbCriteria.Name = "gbCriteria"
            Me.gbCriteria.Size = New System.Drawing.Size(243, 37)
            Me.gbCriteria.TabIndex = 1
            Me.gbCriteria.TabStop = False
            '
            'rbEndWith
            '
            Me.rbEndWith.AutoSize = True
            Me.rbEndWith.Location = New System.Drawing.Point(100, 12)
            Me.rbEndWith.Name = "rbEndWith"
            Me.rbEndWith.Size = New System.Drawing.Size(69, 17)
            Me.rbEndWith.TabIndex = 0
            Me.rbEndWith.Text = "End With"
            Me.rbEndWith.UseVisualStyleBackColor = True
            '
            'rbStartWith
            '
            Me.rbStartWith.AutoSize = True
            Me.rbStartWith.Checked = True
            Me.rbStartWith.Location = New System.Drawing.Point(6, 12)
            Me.rbStartWith.Name = "rbStartWith"
            Me.rbStartWith.Size = New System.Drawing.Size(72, 17)
            Me.rbStartWith.TabIndex = 0
            Me.rbStartWith.TabStop = True
            Me.rbStartWith.Text = "Start With"
            Me.rbStartWith.UseVisualStyleBackColor = True
            '
            'rbAny
            '
            Me.rbAny.AutoSize = True
            Me.rbAny.Location = New System.Drawing.Point(191, 12)
            Me.rbAny.Name = "rbAny"
            Me.rbAny.Size = New System.Drawing.Size(43, 17)
            Me.rbAny.TabIndex = 0
            Me.rbAny.Text = "Any"
            Me.rbAny.UseVisualStyleBackColor = True
            '
            'GroupBox2
            '
            Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox2.Controls.Add(Me.dataGrid)
            Me.GroupBox2.Location = New System.Drawing.Point(12, 119)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(609, 286)
            Me.GroupBox2.TabIndex = 7
            Me.GroupBox2.TabStop = False
            '
            'frmStudentResult
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(631, 413)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.GroupBox1)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmStudentResult"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Students"
            Me.TopMost = True
            CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.gbCriteria.ResumeLayout(False)
            Me.gbCriteria.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dataGrid As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents gbCriteria As System.Windows.Forms.GroupBox
        Friend WithEvents rbEndWith As System.Windows.Forms.RadioButton
        Friend WithEvents rbStartWith As System.Windows.Forms.RadioButton
        Friend WithEvents rbAny As System.Windows.Forms.RadioButton
        Friend WithEvents btnSearch As System.Windows.Forms.Button
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtJobName As System.Windows.Forms.TextBox
        Friend WithEvents txtSchool As System.Windows.Forms.TextBox
        Friend WithEvents txtStudentName As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtScZip As System.Windows.Forms.TextBox
        Friend WithEvents colId As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colStudent As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colJobID As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colSchoolId As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colSchoolName As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colSchoolAdd1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colSchoolAdd2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colSchoolZip As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colSchoolCity As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colJobType As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace