Option Strict Off
Option Explicit On
Friend Class frmCreateStanine
	Inherits System.Windows.Forms.Form
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Dim y As Object
		
		'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        y = CreateStanine(Me.txtSD.Text.Trim, Me.txtLD.Text.Trim, Me.txtM.Text.Trim)
		
		
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		
		Me.txtLD.Text = CStr(CDbl(Me.txtLD.Text) + 0.1)
		Command1_Click(Command1, New System.EventArgs())
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		Me.txtLD.Text = CStr(CDbl(Me.txtLD.Text) - 0.1)
		Command1_Click(Command1, New System.EventArgs())
	End Sub
	
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
		Me.txtSD.Text = CStr(CDbl(Me.txtSD.Text) - 0.1)
		Command1_Click(Command1, New System.EventArgs())
	End Sub
	
	Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
		Me.txtSD.Text = CStr(CDbl(Me.txtSD.Text) + 0.1)
		Command1_Click(Command1, New System.EventArgs())
	End Sub
	
	Private Sub Command6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command6.Click
		Me.txtM.Text = CStr(CDbl(Me.txtM.Text) - 0.1)
		Command1_Click(Command1, New System.EventArgs())
	End Sub
	
	Private Sub Command7_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command7.Click
		Me.txtM.Text = CStr(CDbl(Me.txtM.Text) + 0.1)
		Command1_Click(Command1, New System.EventArgs())
	End Sub
End Class