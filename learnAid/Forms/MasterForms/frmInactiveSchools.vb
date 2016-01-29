Option Strict Off
Option Explicit On
Namespace Forms.MasterForms
    Friend Class frmInactiveSchools
        Inherits System.Windows.Forms.Form

#Region "LEVEL ONE ROUTINES"
        'Called By: frmSchools.Toolbar1_ButtonClick()
        Private Sub frmInactiveSchools_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            'Nothing here!
        End Sub

        Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
            Dim sQuery As String
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset
            Dim Rs2 As New ADODB.Recordset
            Dim RsRpt As New ADODB.Recordset

            Dim isInactive As Boolean
            Dim LastReport As Object = Nothing
            Dim strSQLDate As String

            If Not IsDate(Me.txtDate.Text) Then
                Exit Sub
            End If

            If Len(Me.txtDate.Text) < 8 Then
                Exit Sub
            End If

            If Year(CDate(Me.txtDate.Text)) < 2000 Then
                Exit Sub
            End If

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

            OpenConnection(Cn, Config.ConnectionString)

            strSQLDate = Me.txtDate.Text & " 12:00:01 AM"
            sQuery = "SELECT  * FROM Schools ORDER BY sc_id"
            Rs.Open(sQuery, Cn, 3, 3)

            'Create RsRpt
            RsRpt.Fields.Append("sc_name", ADODB.DataTypeEnum.adVarChar, 50)
            RsRpt.Fields.Append("sc_city", ADODB.DataTypeEnum.adVarChar, 50)
            RsRpt.Fields.Append("sc_phone", ADODB.DataTypeEnum.adVarChar, 50)
            RsRpt.Fields.Append("sc_rep_date", ADODB.DataTypeEnum.adVarChar, 50)
            RsRpt.Open()
            While Not Rs.EOF
                isInactive = True
                sQuery = "SELECT top 1 rep_serv_date FROM Reports WHERE rep_sch_id = " & Rs.Fields("sc_id").Value & " ORDER BY rep_serv_date DESC"

                Rs2.Open(sQuery, Cn, 3, 3)

                If Rs2.RecordCount = 1 Then
                    If CDate(Rs2.Fields("rep_serv_date").Value) >= CDate(strSQLDate) Then
                        isInactive = False
                    Else
                        'UPGRADE_WARNING: Couldn't resolve default property of object LastReport. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        LastReport = Rs2.Fields("rep_serv_date").Value
                    End If
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object LastReport. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    LastReport = "Unknow"
                End If

                If isInactive Then
                    RsRpt.AddNew()
                    RsRpt.Fields("sc_name").Value = Rs.Fields("sc_sch_name").Value
                    RsRpt.Fields("sc_city").Value = Rs.Fields("sc_city").Value
                    RsRpt.Fields("sc_phone").Value = GetValue(Rs.Fields("sc_phone"), "")
                    'UPGRADE_WARNING: Couldn't resolve default property of object LastReport. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    RsRpt.Fields("sc_rep_date").Value = LastReport
                End If
                Rs2.Close()
                Rs.MoveNext()
            End While

            Rs.Close()
            RsRpt.Close()
            Cn.Close()
        End Sub
#End Region
End Class
End Namespace