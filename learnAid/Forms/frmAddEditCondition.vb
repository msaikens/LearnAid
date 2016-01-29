Option Strict Off
Option Explicit On
Friend Class frmAddEditCondition
    Inherits System.Windows.Forms.Form
#Region "LEVEL ONE ROUTINES"
    Private Sub frmAddEditCondition_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.txtData.Text = String.Empty
    End Sub
    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
    Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
        Dim TheItem As System.Windows.Forms.ListViewItem
        If Me.txtData.Text <> String.Empty Then
            If Me.txtAction.Text = "A" Then
                TheItem = frmInformeConsultoresAdminMain.lvContitions.Items.Add("condition" & frmInformeConsultoresAdminMain.lvContitions.Items.Count + 1, Me.txtData.Text, "")
            Else
                frmInformeConsultoresAdminMain.lvContitions.FocusedItem.Text = Me.txtData.Text
            End If
        End If
        Me.Close()
    End Sub
#End Region
End Class