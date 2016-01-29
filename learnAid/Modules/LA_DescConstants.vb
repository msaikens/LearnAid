Option Strict Off
Option Explicit On
Module LA_DescConstants
	
	Function GetErrorDesc(ByRef iErrorCode As Short) As String
		
		Select Case iErrorCode
			Case 10001
				GetErrorDesc = "Invalid Connection String."
			Case 10002
				GetErrorDesc = "Data File Missing."
			Case 10003
				GetErrorDesc = "BatTotal Entries For Current Battery Missing."
			Case 10004
				GetErrorDesc = "Student list incomplete or missing."
				
			Case Else
				GetErrorDesc = "Unknown Error."
		End Select
	End Function
	
    'Called By: frmEditJob.LoadData()
	Function GetJobTypeDesc(ByRef iJobType As Short) As String
		
		Select Case iJobType
			Case 0
				GetJobTypeDesc = "Office Testing"
			Case 1
				GetJobTypeDesc = "Entrance"
			Case 2
				GetJobTypeDesc = "Regular"
			Case 3
				GetJobTypeDesc = "Acomodo Razonable"
        End Select
        Return Nothing
	End Function
	
	Function GetJobStatusDesc(ByRef iStatusCode As Short) As String
		Select Case iStatusCode
			Case 0
				GetJobStatusDesc = "Pending"
			Case 1
				GetJobStatusDesc = "Scanning"
			Case 2
				GetJobStatusDesc = "Scanned"
			Case 3
				GetJobStatusDesc = "Evaluating"
			Case 4
				GetJobStatusDesc = "Completed"
			Case 5
				GetJobStatusDesc = "Cancelled"
			Case Else
				GetJobStatusDesc = "Unknown Status."
		End Select
	End Function
	Function GetJobProcStatusDesc(ByRef iProcStatusCode As Short) As String
		
		Select Case iProcStatusCode
			Case 0
				GetJobProcStatusDesc = "Ready"
			Case 1
				GetJobProcStatusDesc = "Stopped"
			Case 2
				GetJobProcStatusDesc = "Hold"
				
			Case Else
				GetJobProcStatusDesc = "Unknown Process Status."
		End Select
		
	End Function
	Function GetLogDesc(ByRef iLogCode As Short) As String
		
		Select Case iLogCode
			Case 0
				GetLogDesc = "Two or more answers"
			Case 1
				GetLogDesc = "Answer in blank."
			Case Else
				GetLogDesc = "Unknown Warning."
		End Select
		
	End Function
	
	
	Function GetSchoolName(ByRef xid As Object) As Object
		Dim sQuery As Object
		
		Dim Cn As New ADODB.Connection
		Dim Rs As New ADODB.Recordset
		Dim Ret As String
		
		OpenConnection(Cn, Config.ConnectionString)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object xid. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object sQuery. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sQuery = "Select sc_sch_name from schools where sc_id =" & xid
		Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
		
		If Rs.RecordCount = 1 Then
			Ret = Rs.Fields("sc_sch_name").Value
		Else
			Ret = ""
		End If
		
		Rs.Close()
		Cn.Close()
		'UPGRADE_NOTE: Object Cn may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		Cn = Nothing
		
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSchoolName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GetSchoolName = Ret
		
	End Function
	
	Function GetSchoolCity(ByRef xid As Object) As Object
		Dim sQuery As Object
		
		Dim Cn As New ADODB.Connection
		Dim Rs As New ADODB.Recordset
		Dim Ret As String
		
		OpenConnection(Cn, Config.ConnectionString)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object xid. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object sQuery. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sQuery = "Select sc_city from schools where sc_id =" & xid
		Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
		
		If Rs.RecordCount = 1 Then
			Ret = Rs.Fields("sc_city").Value
		Else
			Ret = ""
		End If
		
		Rs.Close()
		Cn.Close()
		
		'UPGRADE_WARNING: Couldn't resolve default property of object GetSchoolCity. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GetSchoolCity = Ret
		
	End Function
End Module