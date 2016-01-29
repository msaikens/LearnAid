Namespace BLL
    Public Class ComboboxUtilities
        Public Shared Sub LoadComboBox(sQuery As String, cboBox As ComboBox)
            Dim dt As DataTable = GlobalResources.ExecuteDataTable(sQuery)
            If (dt.Rows.Count > 0) Then
                '
            End If
        End Sub
        Public Shared Sub SetComboItemWithId(ByRef cbox As ComboBox, ByRef id As String)
            If Not String.IsNullOrEmpty(id) Then
                cbox.SelectedValue = id
            End If
        End Sub
        Public Shared Sub SetComboItemWithValue(ByRef cbox As ComboBox, ByRef value As String)
            If Not String.IsNullOrEmpty(value) Then
                cbox.SelectedIndex = cbox.FindStringExact(value)
            End If
        End Sub
        Public Shared Function GetComboSelectedItemId(ByRef cbox As ComboBox) As String
            Dim key As String
            If Not cbox.SelectedItem Is Nothing Then
                'key = CType(cbox.SelectedItem, DataRowView)(0)
                key = cbox.SelectedItem.ToString.Trim
            End If
            Return key
        End Function
        Public Shared Function GetComboSelectedItemValue(ByRef cbox As ComboBox) As String
            Dim value As String = String.Empty
            If Not cbox.SelectedItem Is Nothing Then
                value = CType(cbox.SelectedItem, DataRowView)(1) 'DirectCast(cbox.SelectedItem, KeyValuePair(Of String, String)).Value
            End If
            Return value
        End Function
    End Class
End Namespace