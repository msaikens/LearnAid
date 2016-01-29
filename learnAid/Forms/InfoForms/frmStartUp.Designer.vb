Namespace Forms.InfoForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmStartUp
#Region "Windows Form Designer generated code "
        <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
            MyBase.New()
            'This call is required by the Windows Form Designer.
            InitializeComponent()
            'This form is an MDI child.
            'This code simulates the VB6 
            ' functionality of automatically
            ' loading and showing an MDI
            ' child's parent.
            Me.MdiParent = frmMain
            frmMain.Show()
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
        Public WithEvents Image1 As System.Windows.Forms.PictureBox
        Public WithEvents LowerBar As Microsoft.VisualBasic.PowerPacks.RectangleShape
        Public WithEvents UpperBar As Microsoft.VisualBasic.PowerPacks.RectangleShape
        Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
            Me.LowerBar = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
            Me.UpperBar = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
            Me.Image1 = New System.Windows.Forms.PictureBox()
            CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ShapeContainer1
            '
            Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
            Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
            Me.ShapeContainer1.Name = "ShapeContainer1"
            Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LowerBar, Me.UpperBar})
            Me.ShapeContainer1.Size = New System.Drawing.Size(482, 343)
            Me.ShapeContainer1.TabIndex = 1
            Me.ShapeContainer1.TabStop = False
            '
            'LowerBar
            '
            Me.LowerBar.BackColor = System.Drawing.SystemColors.Window
            Me.LowerBar.BorderColor = System.Drawing.Color.White
            Me.LowerBar.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.LowerBar.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
            Me.LowerBar.Location = New System.Drawing.Point(4, 314)
            Me.LowerBar.Name = "LowerBar"
            Me.LowerBar.Size = New System.Drawing.Size(273, 25)
            '
            'UpperBar
            '
            Me.UpperBar.BackColor = System.Drawing.SystemColors.Window
            Me.UpperBar.BorderColor = System.Drawing.Color.White
            Me.UpperBar.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.UpperBar.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
            Me.UpperBar.Location = New System.Drawing.Point(8, 8)
            Me.UpperBar.Name = "UpperBar"
            Me.UpperBar.Size = New System.Drawing.Size(273, 25)
            '
            'Image1
            '
            Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
            Me.Image1.Image = Global.learnAid.My.Resources.Resources.LearnAid_DivisionLogo_Main
            Me.Image1.Location = New System.Drawing.Point(102, 108)
            Me.Image1.Name = "Image1"
            Me.Image1.Size = New System.Drawing.Size(285, 107)
            Me.Image1.TabIndex = 0
            Me.Image1.TabStop = False
            '
            'frmStartUp
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(482, 343)
            Me.ControlBox = False
            Me.Controls.Add(Me.Image1)
            Me.Controls.Add(Me.ShapeContainer1)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Location = New System.Drawing.Point(4, 4)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmStartUp"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region
    End Class
End Namespace