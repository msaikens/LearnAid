Option Strict Off
Option Explicit On

Imports Microsoft.VisualBasic.PowerPacks

Namespace Forms.InfoForms
    Friend Class frmStartUp
        Inherits System.Windows.Forms.Form



#Region "LEVEL ONE ROUTINES"
        Private Sub frmStartUp_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
            Call SetControls()
        End Sub
        'UPGRADE_WARNING: Event frmStartUp.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub frmStartUp_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
            Me.SetControls()
        End Sub

        Private Sub Command1_Click()
            'frmPreJob.iSchoolID = 1
            'frmPreJob.ShowDialog()
        End Sub
#End Region
#Region "LEVEL TWO ROUTINES"
        Sub SetControls()
            UpperBar.Top = 0
            UpperBar.Left = 0
            UpperBar.Width = Me.Width

            LowerBar.Top = Microsoft.VisualBasic.Compatibility.VB6.TwipsToPixelsY(Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(Me.Height) - Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(LowerBar.Height) - 100)
            LowerBar.Left = 0
            LowerBar.Width = Me.Width

            Image1.Left = Microsoft.VisualBasic.Compatibility.VB6.TwipsToPixelsX((Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsX(ClientRectangle.Width) - Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsX(Image1.Width)) / 2)
            Image1.Top = Microsoft.VisualBasic.Compatibility.VB6.TwipsToPixelsY((Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(ClientRectangle.Height) - Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(Image1.Height)) / 2)

        End Sub

#End Region

    End Class
End Namespace