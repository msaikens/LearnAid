Option Strict Off
Option Explicit On
Friend Class frmRecomendacionEdit
	Inherits System.Windows.Forms.Form
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Me.Close()
	End Sub
	
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		'frmInformeConsultoresMain.ListView1.SelectedItem.Tag = Me.txtData
		'frmInformeConsultoresMain.ListView1.SelectedItem.Text = Left(Me.txtData, 60) & "..."
		'frmInformeConsultoresMain.ListView1.SelectedItem.Checked = True
		'Unload Me
	End Sub
End Class