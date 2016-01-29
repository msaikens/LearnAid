Namespace Forms.ReportForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPreviousRpts
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
        Public WithEvents cmdClose As System.Windows.Forms.Button
        Public WithEvents cmdPrint As System.Windows.Forms.Button
        Public WithEvents _lvReports_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
        Public WithEvents _lvReports_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
        Public WithEvents _lvReports_ColumnHeader_3 As System.Windows.Forms.ColumnHeader
        Public WithEvents _lvReports_ColumnHeader_4 As System.Windows.Forms.ColumnHeader
        Public WithEvents lvReports As System.Windows.Forms.ListView
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.cmdClose = New System.Windows.Forms.Button()
            Me.cmdPrint = New System.Windows.Forms.Button()
            Me.lvReports = New System.Windows.Forms.ListView()
            Me._lvReports_ColumnHeader_1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._lvReports_ColumnHeader_2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._lvReports_ColumnHeader_3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me._lvReports_ColumnHeader_4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.SuspendLayout()
            '
            'cmdClose
            '
            Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
            Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdClose.Location = New System.Drawing.Point(384, 280)
            Me.cmdClose.Name = "cmdClose"
            Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdClose.Size = New System.Drawing.Size(81, 25)
            Me.cmdClose.TabIndex = 2
            Me.cmdClose.Text = "Close"
            Me.cmdClose.UseVisualStyleBackColor = False
            '
            'cmdPrint
            '
            Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
            Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdPrint.Location = New System.Drawing.Point(296, 280)
            Me.cmdPrint.Name = "cmdPrint"
            Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdPrint.Size = New System.Drawing.Size(81, 25)
            Me.cmdPrint.TabIndex = 1
            Me.cmdPrint.Text = "Print Report"
            Me.cmdPrint.UseVisualStyleBackColor = False
            '
            'lvReports
            '
            Me.lvReports.BackColor = System.Drawing.SystemColors.Window
            Me.lvReports.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvReports_ColumnHeader_1, Me._lvReports_ColumnHeader_2, Me._lvReports_ColumnHeader_3, Me._lvReports_ColumnHeader_4})
            Me.lvReports.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lvReports.ForeColor = System.Drawing.SystemColors.WindowText
            Me.lvReports.FullRowSelect = True
            Me.lvReports.GridLines = True
            Me.lvReports.HideSelection = False
            Me.lvReports.Location = New System.Drawing.Point(4, 2)
            Me.lvReports.Name = "lvReports"
            Me.lvReports.Size = New System.Drawing.Size(465, 273)
            Me.lvReports.TabIndex = 0
            Me.lvReports.UseCompatibleStateImageBehavior = False
            Me.lvReports.View = System.Windows.Forms.View.Details
            '
            '_lvReports_ColumnHeader_1
            '
            Me._lvReports_ColumnHeader_1.Text = "Report Date"
            Me._lvReports_ColumnHeader_1.Width = 283
            '
            '_lvReports_ColumnHeader_2
            '
            Me._lvReports_ColumnHeader_2.Text = "Service Date"
            Me._lvReports_ColumnHeader_2.Width = 294
            '
            '_lvReports_ColumnHeader_3
            '
            Me._lvReports_ColumnHeader_3.Text = "Semester"
            Me._lvReports_ColumnHeader_3.Width = 528
            '
            '_lvReports_ColumnHeader_4
            '
            Me._lvReports_ColumnHeader_4.Text = "Report Type"
            Me._lvReports_ColumnHeader_4.Width = 170
            '
            'frmPreviousRpts
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.ClientSize = New System.Drawing.Size(472, 310)
            Me.ControlBox = False
            Me.Controls.Add(Me.cmdClose)
            Me.Controls.Add(Me.cmdPrint)
            Me.Controls.Add(Me.lvReports)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Location = New System.Drawing.Point(4, 30)
            Me.Name = "frmPreviousRpts"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Previous Reports"
            Me.ResumeLayout(False)

        End Sub
#End Region
    End Class
End Namespace