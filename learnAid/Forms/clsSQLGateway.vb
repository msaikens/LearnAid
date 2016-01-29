Imports System.Data.Sql
Imports System.Data.SqlClient
'Note: This class will replace all ADODB procedures within the program.
'
'At the top of every module put this:
'
' Private Gateway as clsSQLGateway
'
'This will give you access to this class.
'To use it:
'
'Just for grins, I grabbed the sQuery statement from frmCreateReport.FillJobsPending

'     If RptType <> 0 Then
'            sQuery = "Select Jobs.*,Schools.SC_SCH_NAME From Jobs left outer join SCHOOLS ON Jobs.J_SCH = SCHOOLS.SC_ID WHERE "
'            sQuery = sQuery & " Year(Jobs.J_DATE) = " & Me.txtYear.Text & " AND "
'            sQuery = sQuery & " Jobs.J_Type = " & Me.RptType & " AND "
'            sQuery = sQuery & " Jobs.J_USER = '" & LoggedUser.UserID & "' AND "
'            sQuery = sQuery & " Jobs.J_SCH = " &
'                     id &
'                     " AND "
'            sQuery = sQuery & " Jobs.J_SEM = " &
'                     cboSemester.SelectedIndex.ToString &
'                     " AND "
'            sQuery = sQuery & " Jobs.J_Status = 4 AND Jobs.J_AcomRazonable = " &
'                     chkAcomodo.CheckState
'        Else
'            sQuery = "Select Jobs.* From Jobs WHERE "
'            sQuery = sQuery & " Year(Jobs.J_DATE) = " & Me.txtYear.Text & " AND "
'            sQuery = sQuery & " Jobs.J_Type = " & Me.RptType & " AND "
'            sQuery = sQuery & " Jobs.J_USER = '" & LoggedUser.UserID & "' AND "
'            sQuery = sQuery & " Jobs.J_SEM = " &
'                     cboSemester.SelectedIndex.ToString &
'                     " AND "
'            sQuery = sQuery & " Jobs.J_Printed = 0 AND Jobs.J_Status = 4 AND Jobs.J_AcomRazonable = " &
'                     chkAcomodo.CheckState
'        End If
'
'        If CBool(chkPEP.CheckState) Then
'            sQuery = sQuery & " AND IsNull(Jobs.J_PEPV,0) = 52 "
'        Else
'            sQuery = sQuery & " AND IsNull(Jobs.J_PEPV,0) <> 52 "
'        End If

' If Gateway.HasSQConnection = True
'   Gateway.Pass("SEARCH",sQuery)
' End If





Public Class clsSQLGateway
    '##### SQL DB START
    Public cnnSQL As New SqlConnection
    Public cmdSQL As New SqlCommand
    Public cmdSQLInsert As New SqlCommand
    Public cmdSQLUpdate As New SqlCommand
    Public cmdSQLDelete As New SqlCommand
    Public cmdSQLSearch As New SqlCommand
    Public cmdSQLFillDVG As New SqlCommand
    'Public strConnSQL = "Data Source=(localdb)\ProjectsV12;Initial Catalog=IDScanSQL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False"
    'Public strConnSQL = "Dim cn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\Mitchell\Documents\Visual Studio 2013\Projects\IDScan\IDScan\idscan.mdf';Integrated Security=True;Connect Timeout=30")"
    Public SQLDA As SqlDataAdapter
    Public SQLDS As DataSet
    Public SQLTables As DataTableCollection
    Public SQLSource As New BindingSource
    '##### SQL DB END

    '##### SQL DB Connection Check Start
    Public Function HasSQLConnection() As Boolean
        'cnnSQL.ConnectionString = strConnSQL
        Try
            cnnSQL.Open()
            cnnSQL.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            cnnSQL.Close()
            Return False
        End Try
    End Function
    '##### SQL DB Connection Check End

    Public Function Pass(ByVal ACTION As String, ByVal sQuery As String) As String
        Try
            cnnSQL.Open()
            Select Case ACTION
                Case "INSERT"
                    cmdSQLInsert.CommandText = SQuery
                    cmdSQLInsert.CommandType = CommandType.Text
                    cmdSQLInsert.Connection = cnnSQL
                    cmdSQLInsert.ExecuteNonQuery()
                    cmdSQLInsert.Dispose()
                Case "DELETE"
                    cmdSQLDelete.CommandText = SQuery
                    cmdSQLDelete.CommandType = CommandType.Text
                    cmdSQLDelete.Connection = cnnSQL
                    cmdSQLDelete.ExecuteNonQuery()
                    cmdSQLDelete.Dispose()
                Case "UPDATE"
                    cmdSQLUpdate.CommandText = SQuery
                    cmdSQLUpdate.CommandType = CommandType.Text
                    cmdSQLUpdate.Connection = cnnSQL
                    cmdSQLUpdate.ExecuteNonQuery()
                    cmdSQLUpdate.Dispose()
                Case "SEARCH"
                    cmdSQLSearch.CommandText = SQuery
                    cmdSQLSearch.CommandText = CommandType.Text
                    cmdSQLSearch.Connection = cnnSQL
                    'cmdSQLSearch.ExecuteReader()
                    'cmdSQLSearch.Dispose()
                    SQLDS = New DataSet
                    SQLTables = SQLDS.Tables
                    SQLDA = New SqlDataAdapter(SQuery, cnnSQL) 'Change items to your database name
                    SQLDA.Fill(SQLDS, "IDScan") ' change items to your database name
            End Select
            SQuery = ""
            cnnSQL.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnnSQL.Close()
        End Try
        If ACTION = "SEARCH" Then
            'Return strResults
        Else

        End If

    End Function
    
End Class
