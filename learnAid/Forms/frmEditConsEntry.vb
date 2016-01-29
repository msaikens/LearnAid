Option Strict Off
Option Explicit On
Friend Class frmEditConsEntry
	Inherits System.Windows.Forms.Form
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub
	
	
	Private Sub cmdSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.Click
		Select Case Me.Tag
			Case "a"
				frmInformeConsultoresMain.lvAmbiente.FocusedItem.Text = Me.txtText.Text
				frmInformeConsultoresMain.lvAmbiente.FocusedItem.Checked = True
			Case "i"
				frmInformeConsultoresMain.lvInstrucciones.FocusedItem.Text = Me.txtText.Text
				frmInformeConsultoresMain.lvInstrucciones.FocusedItem.Checked = True
			Case "c"
				frmInformeConsultoresMain.lvConducta.FocusedItem.Text = Me.txtText.Text
				frmInformeConsultoresMain.lvConducta.FocusedItem.Checked = True
			Case "d"
				frmInformeConsultoresMain.lvDificultades.FocusedItem.Text = Me.txtText.Text
				frmInformeConsultoresMain.lvDificultades.FocusedItem.Checked = True
			Case "r"
				frmInformeConsultoresMain.lvRecomendaciones.FocusedItem.Text = Me.txtText.Text
				frmInformeConsultoresMain.lvRecomendaciones.FocusedItem.Checked = True
		End Select
		Me.Close()
	End Sub
End Class