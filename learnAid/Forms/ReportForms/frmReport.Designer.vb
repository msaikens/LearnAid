Namespace Forms.ReportForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmReport
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
        'Public WithEvents CRViewer As AxCRVIEWERLib.AxCRViewer
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReport))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.SuspendLayout()
            '
            'CrystalReportViewer1
            '
            Me.CrystalReportViewer1.ActiveViewIndex = -1
            Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
            Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
            Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
            Me.CrystalReportViewer1.Size = New System.Drawing.Size(539, 336)
            Me.CrystalReportViewer1.TabIndex = 0
            '
            'frmReport
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.ClientSize = New System.Drawing.Size(539, 336)
            Me.Controls.Add(Me.CrystalReportViewer1)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Location = New System.Drawing.Point(4, 24)
            Me.Name = "frmReport"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Text = "Report"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
#End Region
    End Class
End Namespace