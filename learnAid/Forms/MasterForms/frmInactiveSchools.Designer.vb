Namespace Forms.MasterForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmInactiveSchools
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
        Public WithEvents cmdPrint As System.Windows.Forms.Button
        Public WithEvents txtDate As System.Windows.Forms.TextBox
        Public WithEvents Label1 As System.Windows.Forms.Label
        Public WithEvents Frame1 As System.Windows.Forms.GroupBox
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.Frame1 = New System.Windows.Forms.GroupBox()
            Me.cmdPrint = New System.Windows.Forms.Button()
            Me.txtDate = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Frame1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Frame1
            '
            Me.Frame1.BackColor = System.Drawing.SystemColors.Control
            Me.Frame1.Controls.Add(Me.cmdPrint)
            Me.Frame1.Controls.Add(Me.txtDate)
            Me.Frame1.Controls.Add(Me.Label1)
            Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Frame1.Location = New System.Drawing.Point(3, 0)
            Me.Frame1.Name = "Frame1"
            Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
            Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Frame1.Size = New System.Drawing.Size(316, 46)
            Me.Frame1.TabIndex = 0
            Me.Frame1.TabStop = False
            '
            'cmdPrint
            '
            Me.cmdPrint.BackColor = System.Drawing.SystemColors.Control
            Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdPrint.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdPrint.Location = New System.Drawing.Point(225, 12)
            Me.cmdPrint.Name = "cmdPrint"
            Me.cmdPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdPrint.Size = New System.Drawing.Size(70, 25)
            Me.cmdPrint.TabIndex = 3
            Me.cmdPrint.Text = "Imprimir"
            Me.cmdPrint.UseVisualStyleBackColor = False
            '
            'txtDate
            '
            Me.txtDate.AcceptsReturn = True
            Me.txtDate.BackColor = System.Drawing.SystemColors.Window
            Me.txtDate.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtDate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDate.ForeColor = System.Drawing.SystemColors.WindowText
            Me.txtDate.Location = New System.Drawing.Point(117, 15)
            Me.txtDate.MaxLength = 0
            Me.txtDate.Name = "txtDate"
            Me.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.txtDate.Size = New System.Drawing.Size(79, 22)
            Me.txtDate.TabIndex = 1
            Me.txtDate.Text = "12/31/2003"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.SystemColors.Control
            Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label1.Location = New System.Drawing.Point(21, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label1.Size = New System.Drawing.Size(97, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Last Report Date:"
            '
            'frmInactiveSchools
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.ClientSize = New System.Drawing.Size(321, 50)
            Me.Controls.Add(Me.Frame1)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Location = New System.Drawing.Point(4, 34)
            Me.MaximizeBox = False
            Me.Name = "frmInactiveSchools"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Text = "Inactive Schools Report"
            Me.Frame1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region
    End Class
End Namespace