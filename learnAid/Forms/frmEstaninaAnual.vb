Option Strict Off
Option Explicit On
Friend Class frmEstaninaAnual
	Inherits System.Windows.Forms.Form
	Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
		Me.Close()
		
	End Sub
	
	Private Sub Label4_Click()
		
	End Sub
	
	Private Sub cmdProcesar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdProcesar.Click
		
		CreateYearPromedioStaninasNEW()
		
	End Sub
End Class