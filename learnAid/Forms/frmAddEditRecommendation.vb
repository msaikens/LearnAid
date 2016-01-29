Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmAddEditRecommendation
	Inherits System.Windows.Forms.Form
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub
	
	Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
		Dim TheItem As System.Windows.Forms.ListViewItem
		
		If Me.txtData.Text <> "" Then
			If Me.txtAction.Text = "A" Then
				TheItem = frmInformeConsultoresAdminMain.lvRecommendations.Items.Add("condition" & frmInformeConsultoresAdminMain.lvRecommendations.Items.Count + 1, VB.Left(Me.txtData.Text, 75) & "...", "")
				TheItem.Tag = Me.txtData.Text
			Else
				frmInformeConsultoresAdminMain.lvRecommendations.FocusedItem.Text = VB.Left(Me.txtData.Text, 75) & "..."
				frmInformeConsultoresAdminMain.lvRecommendations.FocusedItem.Tag = Me.txtData.Text
			End If
		End If
		
		Me.Close()
	End Sub
	
	
	Private Sub frmAddEditRecommendation_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.txtData.Text = ""
	End Sub
End Class