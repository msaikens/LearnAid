Namespace Forms.MasterForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmListClaves
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
        Public WithEvents List As System.Windows.Forms.ListBox
        Public WithEvents CancelButton_Renamed As System.Windows.Forms.Button
        Public WithEvents OKButton As System.Windows.Forms.Button
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.List = New System.Windows.Forms.ListBox()
            Me.CancelButton_Renamed = New System.Windows.Forms.Button()
            Me.OKButton = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'List
            '
            Me.List.BackColor = System.Drawing.SystemColors.Window
            Me.List.Cursor = System.Windows.Forms.Cursors.Default
            Me.List.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.List.ForeColor = System.Drawing.SystemColors.WindowText
            Me.List.ItemHeight = 14
            Me.List.Location = New System.Drawing.Point(8, 8)
            Me.List.Name = "List"
            Me.List.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.List.Size = New System.Drawing.Size(193, 200)
            Me.List.TabIndex = 2
            '
            'CancelButton_Renamed
            '
            Me.CancelButton_Renamed.BackColor = System.Drawing.SystemColors.Control
            Me.CancelButton_Renamed.Cursor = System.Windows.Forms.Cursors.Default
            Me.CancelButton_Renamed.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.CancelButton_Renamed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CancelButton_Renamed.ForeColor = System.Drawing.SystemColors.ControlText
            Me.CancelButton_Renamed.Location = New System.Drawing.Point(208, 40)
            Me.CancelButton_Renamed.Name = "CancelButton_Renamed"
            Me.CancelButton_Renamed.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.CancelButton_Renamed.Size = New System.Drawing.Size(81, 25)
            Me.CancelButton_Renamed.TabIndex = 1
            Me.CancelButton_Renamed.Text = "Close"
            Me.CancelButton_Renamed.UseVisualStyleBackColor = False
            '
            'OKButton
            '
            Me.OKButton.BackColor = System.Drawing.SystemColors.Control
            Me.OKButton.Cursor = System.Windows.Forms.Cursors.Default
            Me.OKButton.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.OKButton.ForeColor = System.Drawing.SystemColors.ControlText
            Me.OKButton.Location = New System.Drawing.Point(208, 8)
            Me.OKButton.Name = "OKButton"
            Me.OKButton.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.OKButton.Size = New System.Drawing.Size(81, 25)
            Me.OKButton.TabIndex = 0
            Me.OKButton.Text = "Edit"
            Me.OKButton.UseVisualStyleBackColor = False
            '
            'frmListClaves
            '
            Me.AcceptButton = Me.OKButton
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.CancelButton = Me.CancelButton_Renamed
            Me.ClientSize = New System.Drawing.Size(295, 213)
            Me.ControlBox = False
            Me.Controls.Add(Me.List)
            Me.Controls.Add(Me.CancelButton_Renamed)
            Me.Controls.Add(Me.OKButton)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Location = New System.Drawing.Point(184, 250)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmListClaves"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Edit"
            Me.ResumeLayout(False)

        End Sub
#End Region
    End Class
End Namespace