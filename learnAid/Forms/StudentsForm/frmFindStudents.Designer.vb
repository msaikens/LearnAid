Namespace Forms.StudentsForm
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmFindStudents
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
            Me.Find_FirstName = New System.Windows.Forms.Label()
            Me.Find_LastName = New System.Windows.Forms.Label()
            Me.Find_FNameBox = New System.Windows.Forms.TextBox()
            Me.Find_LNameBox = New System.Windows.Forms.TextBox()
            Me.FindStdntSearchBtn = New System.Windows.Forms.Button()
            Me.Find_CancelBtn = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'Find_FirstName
            '
            Me.Find_FirstName.AutoSize = True
            Me.Find_FirstName.Location = New System.Drawing.Point(12, 15)
            Me.Find_FirstName.Name = "Find_FirstName"
            Me.Find_FirstName.Size = New System.Drawing.Size(57, 13)
            Me.Find_FirstName.TabIndex = 0
            Me.Find_FirstName.Text = "First Name"
            '
            'Find_LastName
            '
            Me.Find_LastName.AutoSize = True
            Me.Find_LastName.Location = New System.Drawing.Point(181, 15)
            Me.Find_LastName.Name = "Find_LastName"
            Me.Find_LastName.Size = New System.Drawing.Size(58, 13)
            Me.Find_LastName.TabIndex = 1
            Me.Find_LastName.Text = "Last Name"
            '
            'Find_FNameBox
            '
            Me.Find_FNameBox.Location = New System.Drawing.Point(75, 12)
            Me.Find_FNameBox.Name = "Find_FNameBox"
            Me.Find_FNameBox.Size = New System.Drawing.Size(100, 20)
            Me.Find_FNameBox.TabIndex = 2
            '
            'Find_LNameBox
            '
            Me.Find_LNameBox.Location = New System.Drawing.Point(245, 12)
            Me.Find_LNameBox.Name = "Find_LNameBox"
            Me.Find_LNameBox.Size = New System.Drawing.Size(100, 20)
            Me.Find_LNameBox.TabIndex = 3
            '
            'FindStdntSearchBtn
            '
            Me.FindStdntSearchBtn.Location = New System.Drawing.Point(15, 74)
            Me.FindStdntSearchBtn.Name = "FindStdntSearchBtn"
            Me.FindStdntSearchBtn.Size = New System.Drawing.Size(75, 23)
            Me.FindStdntSearchBtn.TabIndex = 4
            Me.FindStdntSearchBtn.Text = "Search"
            Me.FindStdntSearchBtn.UseVisualStyleBackColor = True
            '
            'Find_CancelBtn
            '
            Me.Find_CancelBtn.Location = New System.Drawing.Point(301, 74)
            Me.Find_CancelBtn.Name = "Find_CancelBtn"
            Me.Find_CancelBtn.Size = New System.Drawing.Size(75, 23)
            Me.Find_CancelBtn.TabIndex = 5
            Me.Find_CancelBtn.Text = "Cancel"
            Me.Find_CancelBtn.UseVisualStyleBackColor = True
            '
            'frmFindStudents
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(388, 109)
            Me.ControlBox = False
            Me.Controls.Add(Me.Find_CancelBtn)
            Me.Controls.Add(Me.FindStdntSearchBtn)
            Me.Controls.Add(Me.Find_LNameBox)
            Me.Controls.Add(Me.Find_FNameBox)
            Me.Controls.Add(Me.Find_LastName)
            Me.Controls.Add(Me.Find_FirstName)
            Me.Name = "frmFindStudents"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Search Students"
            Me.TopMost = True
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Find_FirstName As System.Windows.Forms.Label
        Friend WithEvents Find_LastName As System.Windows.Forms.Label
        Friend WithEvents Find_FNameBox As System.Windows.Forms.TextBox
        Friend WithEvents Find_LNameBox As System.Windows.Forms.TextBox
        Friend WithEvents FindStdntSearchBtn As System.Windows.Forms.Button
        Friend WithEvents Find_CancelBtn As System.Windows.Forms.Button
    End Class
End Namespace