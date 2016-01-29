Namespace Forms.AccountingForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmnomina
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
        Public WithEvents cmdCompleted As System.Windows.Forms.Button
        Public WithEvents cmdSave As System.Windows.Forms.Button
        Public WithEvents lblTotalData As System.Windows.Forms.Label
        Public WithEvents lblTotal As System.Windows.Forms.Label
        Public WithEvents Frame2 As System.Windows.Forms.GroupBox
        Public WithEvents Frame1 As System.Windows.Forms.GroupBox
        Public WithEvents cmdClose As System.Windows.Forms.Button
        Public WithEvents cmdPrint As System.Windows.Forms.Button
        Public WithEvents cmdAdjustments As System.Windows.Forms.Button
        Public WithEvents cmdProcess As System.Windows.Forms.Button
        Public WithEvents _lvActivity_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
        Public WithEvents _lvActivity_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
        Public WithEvents _lvActivity_ColumnHeader_3 As System.Windows.Forms.ColumnHeader
        Public WithEvents _lvActivity_ColumnHeader_4 As System.Windows.Forms.ColumnHeader
        Public WithEvents lvActivity As System.Windows.Forms.ListView
        Public WithEvents _lvExaminers_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
        Public WithEvents lvExaminers As System.Windows.Forms.ListView
        Public WithEvents Label2 As System.Windows.Forms.Label
        Public WithEvents Label1 As System.Windows.Forms.Label
        Public WithEvents Shape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
        Public WithEvents lblTo As System.Windows.Forms.Label
        Public WithEvents lblFrom As System.Windows.Forms.Label
        Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
            Me.Shape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
            Me.cmdCompleted = New System.Windows.Forms.Button()
            Me.cmdSave = New System.Windows.Forms.Button()
            Me.Frame2 = New System.Windows.Forms.GroupBox()
            Me.lblTotalData = New System.Windows.Forms.Label()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.Frame1 = New System.Windows.Forms.GroupBox()
            Me.cmdClose = New System.Windows.Forms.Button()
            Me.cmdPrint = New System.Windows.Forms.Button()
            Me.cmdAdjustments = New System.Windows.Forms.Button()
            Me.cmdProcess = New System.Windows.Forms.Button()
            Me.lvActivity = New System.Windows.Forms.ListView()
            Me._lvActivity_ColumnHeader_1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._lvActivity_ColumnHeader_2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._lvActivity_ColumnHeader_3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._lvActivity_ColumnHeader_4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.lvExaminers = New System.Windows.Forms.ListView()
            Me._lvExaminers_ColumnHeader_1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblTo = New System.Windows.Forms.Label()
            Me.lblFrom = New System.Windows.Forms.Label()
            Me.btnExcel = New System.Windows.Forms.Button()
            Me.saveFD = New System.Windows.Forms.SaveFileDialog()
            Me.txtFrom = New System.Windows.Forms.DateTimePicker()
            Me.txtTo = New System.Windows.Forms.DateTimePicker()
            Me.txtParentID = New System.Windows.Forms.TextBox()
            Me.SuspendLayout()
            '
            'ShapeContainer1
            '
            Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
            Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
            Me.ShapeContainer1.Name = "ShapeContainer1"
            Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Shape1})
            Me.ShapeContainer1.Size = New System.Drawing.Size(668, 498)
            Me.ShapeContainer1.TabIndex = 22
            Me.ShapeContainer1.TabStop = False
            '
            'Shape1
            '
            Me.Shape1.BackColor = System.Drawing.SystemColors.ScrollBar
            Me.Shape1.BorderColor = System.Drawing.SystemColors.WindowText
            Me.Shape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
            Me.Shape1.FillColor = System.Drawing.SystemColors.ScrollBar
            Me.Shape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
            Me.Shape1.Location = New System.Drawing.Point(0, 0)
            Me.Shape1.Name = "Shape1"
            Me.Shape1.Size = New System.Drawing.Size(575, 57)
            '
            'cmdCompleted
            '
            Me.cmdCompleted.BackColor = System.Drawing.SystemColors.Control
            Me.cmdCompleted.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdCompleted.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCompleted.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdCompleted.Location = New System.Drawing.Point(125, 461)
            Me.cmdCompleted.Name = "cmdCompleted"
            Me.cmdCompleted.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdCompleted.Size = New System.Drawing.Size(133, 25)
            Me.cmdCompleted.TabIndex = 7
            Me.cmdCompleted.Text = "Set Completed"
            Me.cmdCompleted.UseVisualStyleBackColor = False
            '
            'cmdSave
            '
            Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
            Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdSave.Location = New System.Drawing.Point(403, 461)
            Me.cmdSave.Name = "cmdSave"
            Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdSave.Size = New System.Drawing.Size(81, 25)
            Me.cmdSave.TabIndex = 19
            Me.cmdSave.Text = "&Save"
            Me.cmdSave.UseVisualStyleBackColor = False
            '
            'Frame2
            '
            Me.Frame2.BackColor = System.Drawing.SystemColors.Control
            Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Frame2.Location = New System.Drawing.Point(12, 401)
            Me.Frame2.Name = "Frame2"
            Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
            Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Frame2.Size = New System.Drawing.Size(441, 27)
            Me.Frame2.TabIndex = 16
            Me.Frame2.TabStop = False
            '
            'lblTotalData
            '
            Me.lblTotalData.BackColor = System.Drawing.SystemColors.Control
            Me.lblTotalData.Cursor = System.Windows.Forms.Cursors.Default
            Me.lblTotalData.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalData.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblTotalData.Location = New System.Drawing.Point(491, 401)
            Me.lblTotalData.Name = "lblTotalData"
            Me.lblTotalData.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.lblTotalData.Size = New System.Drawing.Size(120, 20)
            Me.lblTotalData.TabIndex = 18
            Me.lblTotalData.Text = "0"
            Me.lblTotalData.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'lblTotal
            '
            Me.lblTotal.BackColor = System.Drawing.SystemColors.Control
            Me.lblTotal.Cursor = System.Windows.Forms.Cursors.Default
            Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblTotal.Location = New System.Drawing.Point(424, 401)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.lblTotal.Size = New System.Drawing.Size(49, 17)
            Me.lblTotal.TabIndex = 17
            Me.lblTotal.Text = "Total:"
            '
            'Frame1
            '
            Me.Frame1.BackColor = System.Drawing.SystemColors.Control
            Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Frame1.Location = New System.Drawing.Point(-8, 56)
            Me.Frame1.Name = "Frame1"
            Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
            Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Frame1.Size = New System.Drawing.Size(481, 2)
            Me.Frame1.TabIndex = 15
            Me.Frame1.TabStop = False
            '
            'cmdClose
            '
            Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
            Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdClose.Location = New System.Drawing.Point(492, 461)
            Me.cmdClose.Name = "cmdClose"
            Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdClose.Size = New System.Drawing.Size(81, 25)
            Me.cmdClose.TabIndex = 10
            Me.cmdClose.Text = "&Close"
            Me.cmdClose.UseVisualStyleBackColor = False
            '
            'cmdPrint
            '
            Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
            Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdPrint.Location = New System.Drawing.Point(12, 461)
            Me.cmdPrint.Name = "cmdPrint"
            Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdPrint.Size = New System.Drawing.Size(81, 25)
            Me.cmdPrint.TabIndex = 9
            Me.cmdPrint.Text = "&Print"
            Me.cmdPrint.UseVisualStyleBackColor = False
            Me.cmdPrint.Visible = False
            '
            'cmdAdjustments
            '
            Me.cmdAdjustments.BackColor = System.Drawing.SystemColors.Control
            Me.cmdAdjustments.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdAdjustments.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdAdjustments.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdAdjustments.Location = New System.Drawing.Point(264, 461)
            Me.cmdAdjustments.Name = "cmdAdjustments"
            Me.cmdAdjustments.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdAdjustments.Size = New System.Drawing.Size(105, 25)
            Me.cmdAdjustments.TabIndex = 8
            Me.cmdAdjustments.Text = "&Adjustments"
            Me.cmdAdjustments.UseVisualStyleBackColor = False
            '
            'cmdProcess
            '
            Me.cmdProcess.BackColor = System.Drawing.SystemColors.Control
            Me.cmdProcess.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdProcess.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdProcess.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdProcess.Location = New System.Drawing.Point(427, 68)
            Me.cmdProcess.Name = "cmdProcess"
            Me.cmdProcess.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdProcess.Size = New System.Drawing.Size(90, 25)
            Me.cmdProcess.TabIndex = 4
            Me.cmdProcess.Text = "&Retrieve Data"
            Me.cmdProcess.UseVisualStyleBackColor = False
            '
            'lvActivity
            '
            Me.lvActivity.BackColor = System.Drawing.SystemColors.Window
            Me.lvActivity.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvActivity_ColumnHeader_1, Me._lvActivity_ColumnHeader_2, Me._lvActivity_ColumnHeader_3, Me._lvActivity_ColumnHeader_4})
            Me.lvActivity.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lvActivity.ForeColor = System.Drawing.SystemColors.WindowText
            Me.lvActivity.FullRowSelect = True
            Me.lvActivity.GridLines = True
            Me.lvActivity.Location = New System.Drawing.Point(8, 246)
            Me.lvActivity.Name = "lvActivity"
            Me.lvActivity.Size = New System.Drawing.Size(648, 141)
            Me.lvActivity.TabIndex = 6
            Me.lvActivity.UseCompatibleStateImageBehavior = False
            Me.lvActivity.View = System.Windows.Forms.View.Details
            '
            '_lvActivity_ColumnHeader_1
            '
            Me._lvActivity_ColumnHeader_1.Text = "Service Date"
            Me._lvActivity_ColumnHeader_1.Width = 170
            '
            '_lvActivity_ColumnHeader_2
            '
            Me._lvActivity_ColumnHeader_2.Text = "School"
            Me._lvActivity_ColumnHeader_2.Width = 236
            '
            '_lvActivity_ColumnHeader_3
            '
            Me._lvActivity_ColumnHeader_3.Text = "Type"
            Me._lvActivity_ColumnHeader_3.Width = 236
            '
            '_lvActivity_ColumnHeader_4
            '
            Me._lvActivity_ColumnHeader_4.Text = "Paid"
            Me._lvActivity_ColumnHeader_4.Width = 170
            '
            'lvExaminers
            '
            Me.lvExaminers.BackColor = System.Drawing.SystemColors.Window
            Me.lvExaminers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvExaminers_ColumnHeader_1})
            Me.lvExaminers.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lvExaminers.ForeColor = System.Drawing.SystemColors.WindowText
            Me.lvExaminers.FullRowSelect = True
            Me.lvExaminers.GridLines = True
            Me.lvExaminers.Location = New System.Drawing.Point(8, 104)
            Me.lvExaminers.Name = "lvExaminers"
            Me.lvExaminers.Size = New System.Drawing.Size(648, 136)
            Me.lvExaminers.TabIndex = 5
            Me.lvExaminers.UseCompatibleStateImageBehavior = False
            Me.lvExaminers.View = System.Windows.Forms.View.Details
            '
            '_lvExaminers_ColumnHeader_1
            '
            Me._lvExaminers_ColumnHeader_1.Text = "Examiner"
            Me._lvExaminers_ColumnHeader_1.Width = 765
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.SystemColors.ScrollBar
            Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label2.Location = New System.Drawing.Point(159, 9)
            Me.Label2.Name = "Label2"
            Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label2.Size = New System.Drawing.Size(361, 44)
            Me.Label2.TabIndex = 14
            Me.Label2.Text = "This process takes the activity for the given period and generates the respective" & _
        " payroll information."
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.SystemColors.ScrollBar
            Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label1.Location = New System.Drawing.Point(8, 4)
            Me.Label1.Name = "Label1"
            Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label1.Size = New System.Drawing.Size(145, 17)
            Me.Label1.TabIndex = 13
            Me.Label1.Text = "Payroll Generator"
            '
            'lblTo
            '
            Me.lblTo.BackColor = System.Drawing.SystemColors.Control
            Me.lblTo.Cursor = System.Windows.Forms.Cursors.Default
            Me.lblTo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTo.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblTo.Location = New System.Drawing.Point(175, 72)
            Me.lblTo.Name = "lblTo"
            Me.lblTo.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.lblTo.Size = New System.Drawing.Size(57, 17)
            Me.lblTo.TabIndex = 12
            Me.lblTo.Text = "To:"
            '
            'lblFrom
            '
            Me.lblFrom.BackColor = System.Drawing.SystemColors.Control
            Me.lblFrom.Cursor = System.Windows.Forms.Cursors.Default
            Me.lblFrom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFrom.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblFrom.Location = New System.Drawing.Point(8, 72)
            Me.lblFrom.Name = "lblFrom"
            Me.lblFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.lblFrom.Size = New System.Drawing.Size(65, 17)
            Me.lblFrom.TabIndex = 11
            Me.lblFrom.Text = "From:"
            '
            'btnExcel
            '
            Me.btnExcel.Location = New System.Drawing.Point(530, 69)
            Me.btnExcel.Name = "btnExcel"
            Me.btnExcel.Size = New System.Drawing.Size(71, 23)
            Me.btnExcel.TabIndex = 23
            Me.btnExcel.Text = "Excel"
            Me.btnExcel.UseVisualStyleBackColor = True
            '
            'txtFrom
            '
            Me.txtFrom.CustomFormat = "MM/dd/yyyy"
            Me.txtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.txtFrom.Location = New System.Drawing.Point(52, 70)
            Me.txtFrom.Name = "txtFrom"
            Me.txtFrom.Size = New System.Drawing.Size(101, 23)
            Me.txtFrom.TabIndex = 24
            '
            'txtTo
            '
            Me.txtTo.CustomFormat = "MM/dd/yyyy"
            Me.txtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.txtTo.Location = New System.Drawing.Point(206, 68)
            Me.txtTo.Name = "txtTo"
            Me.txtTo.Size = New System.Drawing.Size(117, 23)
            Me.txtTo.TabIndex = 25
            '
            'txtParentID
            '
            Me.txtParentID.Location = New System.Drawing.Point(588, 35)
            Me.txtParentID.Name = "txtParentID"
            Me.txtParentID.Size = New System.Drawing.Size(68, 23)
            Me.txtParentID.TabIndex = 26
            '
            'frmnomina
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.ClientSize = New System.Drawing.Size(668, 498)
            Me.ControlBox = False
            Me.Controls.Add(Me.txtParentID)
            Me.Controls.Add(Me.lblTotalData)
            Me.Controls.Add(Me.lblTotal)
            Me.Controls.Add(Me.txtTo)
            Me.Controls.Add(Me.txtFrom)
            Me.Controls.Add(Me.btnExcel)
            Me.Controls.Add(Me.cmdCompleted)
            Me.Controls.Add(Me.cmdSave)
            Me.Controls.Add(Me.Frame1)
            Me.Controls.Add(Me.cmdClose)
            Me.Controls.Add(Me.cmdPrint)
            Me.Controls.Add(Me.cmdAdjustments)
            Me.Controls.Add(Me.cmdProcess)
            Me.Controls.Add(Me.lvActivity)
            Me.Controls.Add(Me.lvExaminers)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.lblTo)
            Me.Controls.Add(Me.lblFrom)
            Me.Controls.Add(Me.Frame2)
            Me.Controls.Add(Me.ShapeContainer1)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Location = New System.Drawing.Point(3, 22)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmnomina"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = " "
            Me.ResumeLayout(False)
            Me.PerformLayout()

End Sub
        Friend WithEvents btnExcel As System.Windows.Forms.Button
        Friend WithEvents saveFD As System.Windows.Forms.SaveFileDialog
        Friend WithEvents txtFrom As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtTo As System.Windows.Forms.DateTimePicker
        Friend WithEvents txtParentID As System.Windows.Forms.TextBox
#End Region
    End Class
End Namespace