﻿Namespace Forms.MasterForms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmProperty
        Inherits InheritableForms.frmBaseWithNoCloseButton

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
            Me.propGrid = New System.Windows.Forms.PropertyGrid()
            Me.SuspendLayout()
            '
            'propGrid
            '
            Me.propGrid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propGrid.Location = New System.Drawing.Point(0, 0)
            Me.propGrid.Name = "propGrid"
            Me.propGrid.Size = New System.Drawing.Size(258, 399)
            Me.propGrid.TabIndex = 0
            '
            'frmProperty
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(258, 399)
            Me.Controls.Add(Me.propGrid)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmProperty"
            Me.Tag = "Pro"
            Me.Text = "Property"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents propGrid As System.Windows.Forms.PropertyGrid
    End Class
End Namespace