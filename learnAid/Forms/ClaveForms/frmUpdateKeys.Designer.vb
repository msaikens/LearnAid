Namespace Forms.ClaveForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmUpdateKeys
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
            Me.cboDB = New System.Windows.Forms.ComboBox()
            Me.cmbEdit = New System.Windows.Forms.ComboBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Command1 = New System.Windows.Forms.Button()
            Me.cmdEditDestrezas = New System.Windows.Forms.Button()
            Me.cmdEdit = New System.Windows.Forms.Button()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.cboDB)
            Me.GroupBox1.Controls.Add(Me.cmbEdit)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Location = New System.Drawing.Point(12, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(383, 122)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            '
            'cboDB
            '
            Me.cboDB.BackColor = System.Drawing.SystemColors.Window
            Me.cboDB.Cursor = System.Windows.Forms.Cursors.Default
            Me.cboDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboDB.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboDB.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cboDB.Location = New System.Drawing.Point(103, 34)
            Me.cboDB.Name = "cboDB"
            Me.cboDB.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cboDB.Size = New System.Drawing.Size(181, 22)
            Me.cboDB.TabIndex = 9
            '
            'cmbEdit
            '
            Me.cmbEdit.BackColor = System.Drawing.SystemColors.Window
            Me.cmbEdit.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmbEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbEdit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmbEdit.ForeColor = System.Drawing.SystemColors.WindowText
            Me.cmbEdit.Location = New System.Drawing.Point(103, 86)
            Me.cmbEdit.Name = "cmbEdit"
            Me.cmbEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmbEdit.Size = New System.Drawing.Size(181, 22)
            Me.cmbEdit.TabIndex = 7
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.SystemColors.Control
            Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label2.Location = New System.Drawing.Point(117, 15)
            Me.Label2.Name = "Label2"
            Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label2.Size = New System.Drawing.Size(153, 11)
            Me.Label2.TabIndex = 10
            Me.Label2.Text = "Select Database"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.SystemColors.Control
            Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label1.Location = New System.Drawing.Point(145, 67)
            Me.Label1.Name = "Label1"
            Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label1.Size = New System.Drawing.Size(97, 19)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "Select Test"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Command1
            '
            Me.Command1.BackColor = System.Drawing.SystemColors.Control
            Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
            Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Command1.Location = New System.Drawing.Point(262, 125)
            Me.Command1.Name = "Command1"
            Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Command1.Size = New System.Drawing.Size(96, 26)
            Me.Command1.TabIndex = 7
            Me.Command1.Text = "Edit Rules"
            Me.Command1.UseVisualStyleBackColor = False
            '
            'cmdEditDestrezas
            '
            Me.cmdEditDestrezas.BackColor = System.Drawing.SystemColors.Control
            Me.cmdEditDestrezas.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdEditDestrezas.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdEditDestrezas.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdEditDestrezas.Location = New System.Drawing.Point(158, 125)
            Me.cmdEditDestrezas.Name = "cmdEditDestrezas"
            Me.cmdEditDestrezas.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdEditDestrezas.Size = New System.Drawing.Size(96, 26)
            Me.cmdEditDestrezas.TabIndex = 6
            Me.cmdEditDestrezas.Text = "Edit Skills"
            Me.cmdEditDestrezas.UseVisualStyleBackColor = False
            '
            'cmdEdit
            '
            Me.cmdEdit.BackColor = System.Drawing.SystemColors.Control
            Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Default
            Me.cmdEdit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdEdit.ForeColor = System.Drawing.SystemColors.ControlText
            Me.cmdEdit.Location = New System.Drawing.Point(54, 125)
            Me.cmdEdit.Name = "cmdEdit"
            Me.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.cmdEdit.Size = New System.Drawing.Size(93, 26)
            Me.cmdEdit.TabIndex = 5
            Me.cmdEdit.Text = "Edit Keys"
            Me.cmdEdit.UseVisualStyleBackColor = False
            '
            'frmUpdateKeys
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(407, 155)
            Me.Controls.Add(Me.Command1)
            Me.Controls.Add(Me.cmdEditDestrezas)
            Me.Controls.Add(Me.cmdEdit)
            Me.Controls.Add(Me.GroupBox1)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmUpdateKeys"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Update Keys"
            Me.GroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Public WithEvents cboDB As System.Windows.Forms.ComboBox
        Public WithEvents cmbEdit As System.Windows.Forms.ComboBox
        Public WithEvents Label2 As System.Windows.Forms.Label
        Public WithEvents Label1 As System.Windows.Forms.Label
        Public WithEvents Command1 As System.Windows.Forms.Button
        Public WithEvents cmdEditDestrezas As System.Windows.Forms.Button
        Public WithEvents cmdEdit As System.Windows.Forms.Button
    End Class
End Namespace