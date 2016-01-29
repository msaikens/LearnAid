Imports learnAid.BLL

Namespace Forms.MasterForms

    Friend Class frmProperty
        Inherits InheritableForms.frmBaseWithNoCloseButton

#Region "LEVEL ONE ROUTINES"
        Private Sub frmProperty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.Left = 0
            Me.Top = 0
        End Sub
        Private Sub frmProperty_Move(sender As Object, e As System.EventArgs) Handles MyBase.Move
            Me.Left = 0
            Me.Top = 0
        End Sub


        Public Sub FillWithConsultant(iConsId As Integer)
            Dim sQuery As String = "SELECT * From CONSULTANTS Where CON_ID = " & iConsId.ToString.Trim
            Dim dt As DataTable = GlobalResources.ExecuteDataTable(sQuery)

            Dim consultantProperty = New ConsultantProperty()

            If dt.Rows.Count > 0 Then
                consultantProperty.FirstName = (dt.Rows(0)("CON_NAME").ToString())
                consultantProperty.LastName2 = (dt.Rows(0)("Con_LName2").ToString())
                consultantProperty.LastName1 = (dt.Rows(0)("Con_LName1").ToString())
                consultantProperty.Address = (dt.Rows(0)("Con_Address").ToString())
                consultantProperty.City = (dt.Rows(0)("Con_City").ToString())
                consultantProperty.ZipCode = (dt.Rows(0)("Con_ZipCode").ToString())
                consultantProperty.PhoneNumber = (dt.Rows(0)("Con_Phone").ToString())
            End If
            propGrid.SelectedObject = consultantProperty
            propGrid.Refresh()
        End Sub

        Public Sub FillWithSchool(schoolId As Integer)
            Dim sQuery As String = "SELECT * From SCHOOLS Where sc_id = " & schoolId.ToString.Trim
            Dim dt As DataTable = GlobalResources.ExecuteDataTable(sQuery)

            Dim schoolProperty = New SchoolProperty()

            If dt.Rows.Count > 0 Then
                schoolProperty.SchoolName = (dt.Rows(0)("SC_SCH_NAME").ToString())
                schoolProperty.SchoolCode = (dt.Rows(0)("SC_SCH_CODE").ToString())
                schoolProperty.SchoolType = (dt.Rows(0)("SC_Type").ToString())
                schoolProperty.Address1 = (dt.Rows(0)("SC_Address1").ToString())
                schoolProperty.Address2 = (dt.Rows(0)("SC_Address2").ToString())
                schoolProperty.ZipCode = (dt.Rows(0)("SC_ZipCode").ToString())
                schoolProperty.PhoneNumber = (dt.Rows(0)("SC_Phone").ToString())
            End If
            propGrid.SelectedObject = schoolProperty
            propGrid.Refresh()
        End Sub
#End Region
    End Class
End Namespace