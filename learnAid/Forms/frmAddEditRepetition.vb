Option Strict Off
Option Explicit On
Friend Class frmAddEditRepetition
	Inherits System.Windows.Forms.Form
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub
	
	Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
		Dim TheItem As System.Windows.Forms.ListViewItem
		
		If Me.txtData.Text <> "" Then
			If Me.txtAction.Text = "A" Then
				TheItem = frmInformeConsultoresAdminMain.lvRepetition.Items.Add("condition" & frmInformeConsultoresAdminMain.lvRepetition.Items.Count + 1, Me.txtData.Text, "")
			Else
				frmInformeConsultoresAdminMain.lvRepetition.FocusedItem.Text = Me.txtData.Text
			End If
		End If
		
		Me.Close()
	End Sub
	
	
	Private Sub frmAddEditRepetition_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.txtData.Text = ""
	End Sub
End Class