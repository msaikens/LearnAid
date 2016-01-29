Option Strict Off
Option Explicit On

Imports Microsoft.VisualBasic.Compatibility

Namespace Forms.MasterForms
    Friend Class frmListClaves
        Inherits System.Windows.Forms.Form
#Region "LEVEL ONE ROUTINES"
        Private Sub frmListClaves_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
            Call Fill()
        End Sub
        Private Sub CancelButton_Renamed_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CancelButton_Renamed.Click
            Me.Close()
        End Sub
        Private Sub List_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles List.DoubleClick
            Call OKButton_Click(OKButton, New System.EventArgs())
        End Sub
        Private Sub OKButton_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles OKButton.Click
            If List.SelectedIndex >= 0 Then
                frmEditClave.ClaveID = VB6.GetItemData(List, List.SelectedIndex)
                frmEditClave.ShowDialog()
            End If
        End Sub
#End Region
#Region "LEVEL TWO ROUTINES"

        Sub Fill()
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset

            OpenConnection(Cn, Config.ConnectionString)

            Rs.Open("Select * From Claves where active = 1 order by cl_type ", Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            List.Items.Clear()
            While Not Rs.EOF
                List.Items.Add(GetValue(Rs.Fields("cl_type")))
                Microsoft.VisualBasic.Compatibility.VB6.SetItemData(List, List.Items.Count - 1, Rs.Fields("CL_ID").Value)
                Rs.MoveNext()
            End While
            Rs.Close()
            Cn.Close()
        End Sub
#End Region
        
    End Class
End Namespace