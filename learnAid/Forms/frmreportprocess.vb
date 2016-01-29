Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frmreportprocess
	Inherits System.Windows.Forms.Form
	'UPGRADE_WARNING: Form event frmreportprocess.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmreportprocess_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		ConsultantMod.CreateConsultantReport(CDbl(frmInformeConsultoresSectionsList.Tag))
		Me.Close()
	End Sub
End Class