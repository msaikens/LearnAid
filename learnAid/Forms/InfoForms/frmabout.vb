Option Strict Off
Option Explicit On
Namespace Forms.InfoForms
    Friend Class frmabout
        Inherits System.Windows.Forms.Form
#Region "LEVEL ONE ROUTINES"
        Private Sub frmabout_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
            Me.lblBuild.Text = My.Application.Info.Version.Major & My.Application.Info.Version.Minor & My.Application.Info.Version.Revision
        End Sub
        Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
            Me.Close()
        End Sub
#End Region

    End Class
End Namespace