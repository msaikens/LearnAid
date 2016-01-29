Namespace Forms.InfoForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmabout
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
        Public WithEvents Image2 As System.Windows.Forms.PictureBox
        Public WithEvents Image1 As System.Windows.Forms.PictureBox
        Public WithEvents Picture1 As System.Windows.Forms.Panel
        Public WithEvents Command1 As System.Windows.Forms.Button
        Public WithEvents Frame1 As System.Windows.Forms.GroupBox
        Public WithEvents Label6 As System.Windows.Forms.Label
        Public WithEvents Label5 As System.Windows.Forms.Label
        Public WithEvents lblBuild As System.Windows.Forms.Label
        Public WithEvents Label3 As System.Windows.Forms.Label
        Public WithEvents Label2 As System.Windows.Forms.Label
        Public WithEvents Label1 As System.Windows.Forms.Label
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmabout))
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.Picture1 = New System.Windows.Forms.Panel()
            Me.Image2 = New System.Windows.Forms.PictureBox()
            Me.Image1 = New System.Windows.Forms.PictureBox()
            Me.Command1 = New System.Windows.Forms.Button()
            Me.Frame1 = New System.Windows.Forms.GroupBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblBuild = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Picture1.SuspendLayout()
            CType(Me.Image2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Picture1
            '
            Me.Picture1.BackColor = System.Drawing.Color.White
            Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Picture1.Controls.Add(Me.Image2)
            Me.Picture1.Controls.Add(Me.Image1)
            Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
            Me.Picture1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Picture1.Location = New System.Drawing.Point(0, 0)
            Me.Picture1.Name = "Picture1"
            Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Picture1.Size = New System.Drawing.Size(113, 213)
            Me.Picture1.TabIndex = 7
            Me.Picture1.TabStop = True
            '
            'Image2
            '
            Me.Image2.Cursor = System.Windows.Forms.Cursors.Default
            Me.Image2.Image = CType(resources.GetObject("Image2.Image"), System.Drawing.Image)
            Me.Image2.Location = New System.Drawing.Point(0, 152)
            Me.Image2.Name = "Image2"
            Me.Image2.Size = New System.Drawing.Size(106, 54)
            Me.Image2.TabIndex = 0
            Me.Image2.TabStop = False
            '
            'Image1
            '
            Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
            Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
            Me.Image1.Location = New System.Drawing.Point(8, -3)
            Me.Image1.Name = "Image1"
            Me.Image1.Size = New System.Drawing.Size(99, 83)
            Me.Image1.TabIndex = 1
            Me.Image1.TabStop = False
            '
            'Command1
            '
            Me.Command1.BackColor = System.Drawing.SystemColors.Control
            Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
            Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Command1.Location = New System.Drawing.Point(288, 184)
            Me.Command1.Name = "Command1"
            Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Command1.Size = New System.Drawing.Size(81, 25)
            Me.Command1.TabIndex = 6
            Me.Command1.Text = "&Close"
            Me.Command1.UseVisualStyleBackColor = False
            '
            'Frame1
            '
            Me.Frame1.BackColor = System.Drawing.SystemColors.Control
            Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Frame1.Location = New System.Drawing.Point(117, 168)
            Me.Frame1.Name = "Frame1"
            Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
            Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Frame1.Size = New System.Drawing.Size(257, 8)
            Me.Frame1.TabIndex = 8
            Me.Frame1.TabStop = False
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label6.Location = New System.Drawing.Point(120, 141)
            Me.Label6.Name = "Label6"
            Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label6.Size = New System.Drawing.Size(281, 41)
            Me.Label6.TabIndex = 5
            Me.Label6.Text = "Developed by Aranay Interactive Systems http://www.aranay.com"
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label5.Location = New System.Drawing.Point(120, 128)
            Me.Label5.Name = "Label5"
            Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label5.Size = New System.Drawing.Size(281, 17)
            Me.Label5.TabIndex = 4
            Me.Label5.Text = "Copyright (c) 2002 · Learn AID of Puerto Rico, Inc."
            '
            'lblBuild
            '
            Me.lblBuild.BackColor = System.Drawing.Color.Transparent
            Me.lblBuild.Cursor = System.Windows.Forms.Cursors.Default
            Me.lblBuild.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBuild.ForeColor = System.Drawing.SystemColors.ControlText
            Me.lblBuild.Location = New System.Drawing.Point(150, 57)
            Me.lblBuild.Name = "lblBuild"
            Me.lblBuild.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.lblBuild.Size = New System.Drawing.Size(201, 17)
            Me.lblBuild.TabIndex = 3
            Me.lblBuild.Text = "Label4"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label3.Location = New System.Drawing.Point(120, 57)
            Me.Label3.Name = "Label3"
            Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label3.Size = New System.Drawing.Size(36, 17)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "Build: "
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label2.Location = New System.Drawing.Point(120, 24)
            Me.Label2.Name = "Label2"
            Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label2.Size = New System.Drawing.Size(217, 31)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Student evaluation administration, reporting and management system"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
            Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label1.Location = New System.Drawing.Point(120, 8)
            Me.Label1.Name = "Label1"
            Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Label1.Size = New System.Drawing.Size(241, 17)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Learn AID of Puerto Rico, Inc."
            '
            'frmabout
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.ClientSize = New System.Drawing.Size(377, 213)
            Me.ControlBox = False
            Me.Controls.Add(Me.Picture1)
            Me.Controls.Add(Me.Command1)
            Me.Controls.Add(Me.Frame1)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.lblBuild)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Location = New System.Drawing.Point(3, 22)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmabout"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "About"
            Me.Picture1.ResumeLayout(False)
            CType(Me.Image2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region
    End Class
End Namespace