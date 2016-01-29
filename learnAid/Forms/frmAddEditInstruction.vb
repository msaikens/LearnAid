Option Strict Off
Option Explicit On
Friend Class frmAddEditInstruction
	Inherits System.Windows.Forms.Form
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub
	
	Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
		Dim TheItem As System.Windows.Forms.ListViewItem
		
		If Me.txtData.Text <> "" Then
			If Me.txtAction.Text = "A" Then
				TheItem = frmInformeConsultoresAdminMain.lvInstructions.Items.Add("condition" & frmInformeConsultoresAdminMain.lvInstructions.Items.Count + 1, Me.txtData.Text, "")
			Else
				frmInformeConsultoresAdminMain.lvInstructions.FocusedItem.Text = Me.txtData.Text
			End If
		End If
		
		Me.Close()
	End Sub
	
	
	Private Sub frmAddEditInstruction_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.txtData.Text = ""
	End Sub
End Class