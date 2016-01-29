Option Strict Off
Option Explicit On
Friend Class frmGenericCal
	Inherits System.Windows.Forms.Form
	
	Private Sub Calendar1_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Calendar1.DblClick
		'UPGRADE_WARNING: Couldn't resolve default property of object Calendar1.Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object CalendarValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CalendarValue = Calendar1.Value
		Me.Close()
	End Sub
	
	
	Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
		Me.Close()
	End Sub
	
	
	Private Sub cmdToday_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdToday.Click
		Me.Calendar1.Value = Today
	End Sub
End Class