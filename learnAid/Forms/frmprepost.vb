Option Strict Off
Option Explicit On

Imports learnAid.Forms.ReportForms
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Compatibility
Friend Class frmPrePost
	Inherits System.Windows.Forms.Form
	
	Sub SetPrePostDate()
		
        Dim sDesdePRE As String = Nothing
        Dim sDesdePOST As String = Nothing
        Dim sHastaPRE As String = Nothing
        Dim sHastaPOST As String = Nothing
		
		Select Case VB.Left(Me.cboMetodo.Text, 10)
			Case "Pre: 1er S"
				sDesdePRE = "08/01/" & Me.cboYear.Text
				sHastaPRE = "12/31/" & Me.cboYear.Text
				sDesdePOST = "01/01/" & Val(Me.cboYear.Text) + 1
				sHastaPOST = "07/31/" & Val(Me.cboYear.Text) + 1
				Me.lblPrePost.Text = "PRE: 1er Sem " & Me.cboYear.Text & "  Post: 2do Sem del " & Me.cboYear.Text
				Me.txtPREsem.Text = CStr(1)
				Me.txtPOSTSem.Text = CStr(2)
			Case "Pre: 2do S"
				sDesdePRE = "01/01/" & Me.cboYear.Text
				sHastaPRE = "07/31/" & Me.cboYear.Text
				sDesdePOST = "08/01/" & Me.cboYear.Text
				sHastaPOST = "12/31/" & Me.cboYear.Text
				Me.lblPrePost.Text = "PRE: 2do Sem " & Me.cboYear.Text & "  Post: 1er Sem del " & Val(Me.cboYear.Text) + 1
				Me.txtPREsem.Text = CStr(2)
				Me.txtPOSTSem.Text = CStr(1)
		End Select
		
		
		Me.txtPREDesde.Text = sDesdePRE
		Me.txtPREHasta.Text = sHastaPRE
		Me.txtPOSTDesde.Text = sDesdePOST
		Me.txtPOSTHasta.Text = sHastaPOST
		
		
		
	End Sub
	
	'UPGRADE_WARNING: Event cboMetodo.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	'UPGRADE_WARNING: ComboBox event cboMetodo.Change was upgraded to cboMetodo.TextChanged which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
	Private Sub cboMetodo_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboMetodo.TextChanged
		
		SetPrePostDate()
		
	End Sub
	
	'UPGRADE_WARNING: Event cboMetodo.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboMetodo_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboMetodo.SelectedIndexChanged
		SetPrePostDate()
	End Sub
	
	
	Private Sub cboMetodo_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboMetodo.Leave
		SetPrePostDate()
	End Sub
	
	'UPGRADE_WARNING: Event cboYear.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	'UPGRADE_WARNING: ComboBox event cboYear.Change was upgraded to cboYear.TextChanged which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
	Private Sub cboYear_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboYear.TextChanged
		
		SetPrePostDate()
		
		
	End Sub
	
	
	
	'UPGRADE_WARNING: Event cboYear.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboYear_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboYear.SelectedIndexChanged
		SetPrePostDate()
	End Sub
	
	Private Sub cboYear_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboYear.Leave
		SetPrePostDate()
	End Sub
	
	Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
		
		Me.Close()
		
	End Sub
	
	Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
		
        'Dim CrxApp As New CRAXDRT.Application
        'Dim CrxRpt As CRAXDRT.Report
		
		
		Dim rptI As New frmReport
		If Me.cboSchools2.SelectedIndex >= 0 Then
			rptI.ReportID = VB6.GetItemData(Me.cboSchools2, Me.cboSchools2.SelectedIndex)
		End If
		rptI.ReportFile = Config.ReportsPath & "INDIVIDUALPRE_POST.rpt"
		rptI.Show()
		
		
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		
		
        'Dim CrxApp As New CRAXDRT.Application
        'Dim CrxRpt As CRAXDRT.Report
		
		
		Dim rptI As New frmReport
		rptI.ReportID = VB6.GetItemData(Me.cboSchools, Me.cboSchools.SelectedIndex)
		rptI.ReportFile = Config.ReportsPath & "TITULO1_INDIVIDUAL_COMP.rpt"
		rptI.Show()
		
	End Sub
	
	Private Sub Command10_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command10.Click
        'Dim CrxApp As New CRAXDRT.Application
        'Dim CrxRpt As CRAXDRT.Report
		
		
		Dim rptI As New frmReport
		rptI.ReportID = VB6.GetItemData(Me.cboSchools, Me.cboSchools.SelectedIndex)
		rptI.ReportFile = Config.ReportsPath & "TITULO1_DestrezasMATPRE1_Post.rpt"
		rptI.Show()
		
		
	End Sub
	
	Private Sub Command11_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command11.Click
		
        'Dim CrxApp As New CRAXDRT.Application
        'Dim CrxRpt As CRAXDRT.Report
		
		
		Dim rptI As New frmReport
		rptI.ReportID = VB6.GetItemData(Me.cboSchools, Me.cboSchools.SelectedIndex)
		rptI.ReportFile = Config.ReportsPath & "TITULO1_DestrezasLESPRE1_POST.rpt"
		rptI.Show()
	End Sub
	
	Private Sub Command12_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command12.Click
		
		
        'Dim CrxApp As New CRAXDRT.Application
        'Dim CrxRpt As CRAXDRT.Report
		
		
		Dim rptI As New frmReport
		rptI.ReportID = VB6.GetItemData(Me.cboSchools, Me.cboSchools.SelectedIndex)
		rptI.ReportFile = Config.ReportsPath & "TITULO1_Regular0_Post.rpt"
		rptI.Show()
		
	End Sub
	
	Private Sub Command13_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command13.Click
        Dim sQuery As String
        Dim Cn As New ADODB.Connection
        Dim Rs As New ADODB.Recordset
        Dim Rs2 As New ADODB.Recordset

        Dim iCtr As Integer
		Dim pGrado As Object
		Dim aa As Object
        Dim bb As Object = Nothing
		Dim sTot As Object
		Dim iNVTot As Object
		Dim iMatTot As Object
		Dim iLesTot As Object
		Dim iRenTot As Object
		
		'Dim CurrNombre As String
		
        'Dim SchID As Integer
        'Dim isOK As Boolean
        'Dim CrxApp As New CRAXDRT.Application
        'Dim CrxRpt As CRAXDRT.Report
		Dim iTot As Short
        'Dim iTotDup As Short
        'Dim iTotPost As Short
        'Dim iTotNoMatch As Short
		Dim RsRpt As New ADODB.Recordset
		Dim scID As Integer
		
		OpenConnection(Cn, Config.ConnectionString)
		
		'Create RsRpt
		'SQL = "delete from tmp_Comparativo_Grupal"
		'Cn.Execute SQL
		
		'SQL = "select * from tmp_Comparativo_Grupal"
		'RsRpt.Open SQL, Cn, 1, 3, 0
		'---
		
		'Me.MousePointer = vbHourglass
		
		scID = VB6.GetItemData(Me.cboSchools2, Me.cboSchools2.SelectedIndex)
		
		iTot = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object iRenTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		iRenTot = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object iLesTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		iLesTot = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object iMatTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		iMatTot = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object iNVTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		iNVTot = 0
		Me.txtRen.Text = CStr(0)
		Me.txtMat.Text = CStr(0)
		Me.txtLes.Text = CStr(0)
		Me.TxtNV.Text = CStr(0)
		
        sQuery = "Select resest.*, resultados.*, rep_id, rep_sch_id from ResEst Inner Join Resultados ON ResEst.resg_id = Resultados.resg_id " & "INNER JOIN Reports ON Resultados.resg_rep_id = rep_id " & "WHERE rep_type = 2  AND rep_serv_date >= '" & Me.txtPOSTDesde.Text & "' AND rep_serv_date <= '" & Me.txtPOSTHasta.Text & "' and rep_sch_id =" & scID
		
        Rs.Open(sQuery, Cn, 3, 3)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object sTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sTot = Rs.RecordCount
		While Not Rs.EOF
			
			'trabajo LES
			If Rs.Fields("resg_grado").Value = 6 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object bb. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object aa. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				aa = bb
			End If
			If Not IsDbNull(Rs.Fields("rese_esta_l").Value) And Not IsDbNull(Rs.Fields("rese_l").Value) Then
				
				If CDbl(txtPOSTSem.Text) = 2 Then
                    sQuery = "SELECT * FROM tmp_comparativo_grupal WHERE comp_materia = 'LES' AND comp_sch_id = " & Rs.Fields("rep_sch_id").Value & " AND " & "comp_pregrado = " & Rs.Fields("resg_grado").Value & " AND comp_cl_id = " & Rs.Fields("resg_les").Value & " AND comp_preyear = " & Year(CDate(txtPREHasta.Text))
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object pGrado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					pGrado = Rs.Fields("resg_grado").Value - 1
					'UPGRADE_WARNING: Couldn't resolve default property of object pGrado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sQuery = "SELECT * FROM tmp_comparativo_grupal WHERE comp_materia = 'LES' AND comp_sch_id = " & Rs.Fields("rep_sch_id").Value & " AND " & "comp_pregrado = " & pGrado & " AND comp_cl_id = " & Rs.Fields("resg_les").Value
				End If
				
                RsRpt.Open(sQuery, Cn, 1, 3, 0)
				
				If RsRpt.EOF = True Then
					'    RsRpt.AddNew
					'    RsRpt!comp_sch_id = Rs!rep_sch_id
					'    RsRpt!comp_postgrado = Rs!resg_Grado
					'    RsRpt!comp_postsem = txtPOSTSem
					'    RsRpt!comp_postyear = Year(txtPOSTDesde)
					'    RsRpt!comp_cl_id = Rs!resg_les
					'    RsRpt!comp_post_les_est = GetValue(Rs!rese_esta_l, 0)
					'    RsRpt!comp_post_les_corr = GetValue(Rs!rese_l, 0)
					'    RsRpt!comp_post_les_tot = 1
					'    RsRpt!comp_status = "NOT PRE"
					'    RsRpt!comp_materia = "LES"
					'    RsRpt!comp_repid_post = Rs!Rep_ID
					'    For iCtr = 1 To 10
					'        RsRpt("comp_post_l" & iCtr) = GetValue(Rs("rese_l" & iCtr), 0)
					'    Next
					'    RsRpt.Update
				Else
					'aparece, acumulo
					RsRpt.Fields("comp_postgrado").Value = Rs.Fields("resg_grado").Value
					RsRpt.Fields("comp_postsem").Value = txtPOSTSem.Text
					RsRpt.Fields("comp_postyear").Value = Year(CDate(txtPOSTDesde.Text))
                    RsRpt.Fields("comp_post_les_est").Value = GetValue(RsRpt.Fields("comp_post_les_est"), 0) + GetValue(Rs.Fields("rese_esta_l"), 0)
                    RsRpt.Fields("comp_post_les_corr").Value = GetValue(RsRpt.Fields("comp_post_les_corr"), 0) + GetValue(Rs.Fields("rese_l"), 0)
                    RsRpt.Fields("comp_post_les_tot").Value = GetValue(RsRpt.Fields("comp_post_les_tot"), 0) + 1
					For iCtr = 1 To 10
						'UPGRADE_WARNING: Couldn't resolve default property of object iCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        RsRpt.Fields("comp_post_l" & iCtr).Value = GetValue(RsRpt.Fields("comp_post_l" & iCtr), 0) + GetValue(Rs.Fields("rese_l" & iCtr), 0)
					Next 
					RsRpt.Fields("comp_status").Value = "OK"
					RsRpt.Fields("comp_repid_post").Value = Rs.Fields("Rep_ID").Value
					RsRpt.Update()
					'UPGRADE_WARNING: Couldn't resolve default property of object iLesTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					iLesTot = iLesTot + 1
					'UPGRADE_WARNING: Couldn't resolve default property of object iLesTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Me.txtLes.Text = iLesTot
				End If
				
				RsRpt.Close()
				
			End If
			
			'trabajo MAT
			
			If Not IsDbNull(Rs.Fields("rese_esta_m").Value) And Not IsDbNull(Rs.Fields("rese_m").Value) Then
				
				If CDbl(txtPOSTSem.Text) = 2 Then
                    sQuery = "SELECT * FROM tmp_comparativo_grupal WHERE comp_materia = 'MAT' AND comp_sch_id = " & Rs.Fields("rep_sch_id").Value & " AND " & "comp_pregrado = " & Rs.Fields("resg_grado").Value & " AND comp_cl_id = " & Rs.Fields("resg_mat").Value & " AND comp_preyear = " & Year(CDate(txtPREHasta.Text))
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object pGrado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					pGrado = Rs.Fields("resg_grado").Value - 1
					'UPGRADE_WARNING: Couldn't resolve default property of object pGrado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sQuery = "SELECT * FROM tmp_comparativo_grupal WHERE comp_materia = 'MAT' AND comp_sch_id = " & Rs.Fields("rep_sch_id").Value & " AND " & "comp_pregrado = " & pGrado & " AND comp_cl_id = " & Rs.Fields("resg_mat").Value
				End If
				
                RsRpt.Open(sQuery, Cn, 1, 3, 0)
				
				If RsRpt.EOF = True Then
					'    RsRpt.AddNew
					'    RsRpt!comp_sch_id = Rs!rep_sch_id
					'    RsRpt!comp_postgrado = Rs!resg_Grado
					'    RsRpt!comp_postsem = txtPOSTSem
					'    RsRpt!comp_postyear = Year(txtPOSTDesde)
					'    RsRpt!comp_cl_id = Rs!resg_mat
					'    RsRpt!comp_post_les_est = GetValue(Rs!rese_esta_m, 0)
					'    RsRpt!comp_post_les_corr = GetValue(Rs!rese_m, 0)
					'    RsRpt!comp_post_les_tot = 1
					'    RsRpt!comp_status = "NOT PRE"
					'    RsRpt!comp_materia = "MAT"
					'    RsRpt!comp_repid_post = Rs!Rep_ID
					'    For iCtr = 1 To 10
					'        RsRpt("comp_post_l" & iCtr) = GetValue(Rs("rese_m" & iCtr), 0)
					'    Next
					'    RsRpt.Update
				Else
					'aparece, acumulo
					RsRpt.Fields("comp_postgrado").Value = Rs.Fields("resg_grado").Value
					RsRpt.Fields("comp_postsem").Value = txtPOSTSem.Text
					RsRpt.Fields("comp_postyear").Value = Year(CDate(txtPOSTDesde.Text))
                    RsRpt.Fields("comp_post_les_est").Value = GetValue(RsRpt.Fields("comp_post_les_est"), 0) + GetValue(Rs.Fields("rese_esta_m"), 0)
                    RsRpt.Fields("comp_post_les_corr").Value = GetValue(RsRpt.Fields("comp_post_les_corr"), 0) + GetValue(Rs.Fields("rese_m"), 0)
                    RsRpt.Fields("comp_post_les_tot").Value = GetValue(RsRpt.Fields("comp_post_les_tot"), 0) + 1
					For iCtr = 1 To 10
						'UPGRADE_WARNING: Couldn't resolve default property of object iCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        RsRpt.Fields("comp_post_l" & iCtr).Value = GetValue(RsRpt.Fields("comp_post_l" & iCtr), 0) + GetValue(Rs.Fields("rese_m" & iCtr), 0)
					Next 
					RsRpt.Fields("comp_status").Value = "OK"
					RsRpt.Fields("comp_repid_post").Value = Rs.Fields("Rep_ID").Value
					RsRpt.Update()
					'UPGRADE_WARNING: Couldn't resolve default property of object iMatTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					iMatTot = iMatTot + 1
					'UPGRADE_WARNING: Couldn't resolve default property of object iMatTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Me.txtMat.Text = iMatTot
					
				End If
				
				RsRpt.Close()
				
			End If
			
			'trabajo REN
			
            If Not IsDBNull(Rs.Fields("rese_esta_r").Value) And Not IsDBNull(Rs.Fields("rese_R").Value) Then

                If CDbl(txtPOSTSem.Text) = 2 Then
                    sQuery = "SELECT * FROM tmp_comparativo_grupal WHERE comp_materia = 'REN' AND comp_sch_id = " & Rs.Fields("rep_sch_id").Value & " AND " & "comp_pregrado = " & Rs.Fields("resg_grado").Value & " AND comp_cl_id = " & Rs.Fields("resg_REN").Value & " AND comp_preyear = " & Year(CDate(txtPREHasta.Text))
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object pGrado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    pGrado = Rs.Fields("resg_grado").Value - 1
                    'UPGRADE_WARNING: Couldn't resolve default property of object pGrado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sQuery = "SELECT * FROM tmp_comparativo_grupal WHERE comp_materia = 'REN' AND comp_sch_id = " & Rs.Fields("rep_sch_id").Value & " AND " & "comp_pregrado = " & pGrado & " AND comp_cl_id = " & Rs.Fields("resg_REN").Value
                End If

                RsRpt.Open(sQuery, Cn, 1, 3, 0)

                If RsRpt.EOF = True Then
                    '  RsRpt.AddNew
                    '  RsRpt!comp_sch_id = Rs!rep_sch_id
                    '  RsRpt!comp_postgrado = Rs!resg_Grado
                    '  RsRpt!comp_postsem = txtPOSTSem
                    '  RsRpt!comp_postyear = Year(txtPOSTDesde)
                    '  RsRpt!comp_cl_id = Rs!resg_REN
                    '  RsRpt!comp_post_les_est = GetValue(Rs!rese_esta_R, 0)
                    '  RsRpt!comp_post_les_corr = GetValue(Rs!rese_R, 0)
                    '  RsRpt!comp_post_les_tot = 1
                    '  RsRpt!comp_status = "NOT PRE"
                    '  RsRpt!comp_materia = "REN"
                    '  RsRpt!comp_repid_post = Rs!Rep_ID
                    '  For iCtr = 1 To 10
                    '      RsRpt("comp_post_l" & iCtr) = GetValue(Rs("rese_R" & iCtr), 0)
                    '  Next
                    '  RsRpt.Update
                Else
                    'aparece, acumulo
                    RsRpt.Fields("comp_postgrado").Value = Rs.Fields("resg_grado").Value
                    RsRpt.Fields("comp_postsem").Value = txtPOSTSem.Text
                    RsRpt.Fields("comp_postyear").Value = Year(CDate(txtPOSTDesde.Text))
                    RsRpt.Fields("comp_post_les_est").Value = GetValue(RsRpt.Fields("comp_post_les_est"), 0) + GetValue(Rs.Fields("rese_esta_r"), 0)
                    RsRpt.Fields("comp_post_les_corr").Value = GetValue(RsRpt.Fields("comp_post_les_corr"), 0) + GetValue(Rs.Fields("rese_R"), 0)
                    RsRpt.Fields("comp_post_les_tot").Value = GetValue(RsRpt.Fields("comp_post_les_tot"), 0) + 1
                    For iCtr = 1 To 10
                        'UPGRADE_WARNING: Couldn't resolve default property of object iCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        RsRpt.Fields("comp_post_l" & iCtr).Value = GetValue(RsRpt.Fields("comp_post_l" & iCtr), 0) + GetValue(Rs.Fields("rese_R" & iCtr), 0)
                    Next
                    RsRpt.Fields("comp_status").Value = "OK"
                    RsRpt.Fields("comp_repid_post").Value = Rs.Fields("Rep_ID").Value
                    RsRpt.Update()
                    'UPGRADE_WARNING: Couldn't resolve default property of object iRenTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    iRenTot = iRenTot + 1
                    'UPGRADE_WARNING: Couldn't resolve default property of object iRenTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Me.txtRen.Text = iRenTot
                End If

                RsRpt.Close()

            End If
			
			'trabajo NV
			
            If Not IsDBNull(Rs.Fields("rese_esta_n").Value) And Not IsDBNull(Rs.Fields("rese_N").Value) Then

                If CDbl(txtPOSTSem.Text) = 2 Then
                    sQuery = "SELECT * FROM tmp_comparativo_grupal WHERE comp_materia = 'NV' AND comp_sch_id = " & Rs.Fields("rep_sch_id").Value & " AND " & "comp_pregrado = " & Rs.Fields("resg_grado").Value & " AND comp_cl_id = " & Rs.Fields("resg_NV").Value & " AND comp_preyear = " & Year(CDate(txtPREHasta.Text))
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object pGrado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    pGrado = Rs.Fields("resg_grado").Value - 1
                    'UPGRADE_WARNING: Couldn't resolve default property of object pGrado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sQuery = "SELECT * FROM tmp_comparativo_grupal WHERE comp_materia = 'NV' AND comp_sch_id = " & Rs.Fields("rep_sch_id").Value & " AND " & "comp_pregrado = " & pGrado & " AND comp_cl_id = " & Rs.Fields("resg_NV").Value
                End If

                RsRpt.Open(sQuery, Cn, 1, 3, 0)

                If RsRpt.EOF = True Then
                    '    RsRpt.AddNew
                    '    RsRpt!comp_sch_id = Rs!rep_sch_id
                    '    RsRpt!comp_postgrado = Rs!resg_Grado
                    '    RsRpt!comp_postsem = txtPOSTSem
                    '    RsRpt!comp_postyear = Year(txtPOSTDesde)
                    '    RsRpt!comp_cl_id = Rs!resg_NV
                    '    RsRpt!comp_post_les_est = GetValue(Rs!rese_esta_N, 0)
                    '    RsRpt!comp_post_les_corr = GetValue(Rs!rese_N, 0)
                    '    RsRpt!comp_post_les_tot = 1
                    '    RsRpt!comp_status = "NOT PRE"
                    '    RsRpt!comp_materia = "NV"
                    '    RsRpt!comp_repid_post = Rs!Rep_ID
                    '    For iCtr = 1 To 10
                    '        RsRpt("comp_post_l" & iCtr) = GetValue(Rs("rese_N" & iCtr), 0)
                    '    Next
                    '    RsRpt.Update
                Else
                    'aparece, acumulo
                    RsRpt.Fields("comp_postgrado").Value = Rs.Fields("resg_grado").Value
                    RsRpt.Fields("comp_postsem").Value = txtPOSTSem.Text
                    RsRpt.Fields("comp_postyear").Value = Year(CDate(txtPOSTDesde.Text))
                    RsRpt.Fields("comp_post_les_est").Value = GetValue(RsRpt.Fields("comp_post_les_est"), 0) + GetValue(Rs.Fields("rese_esta_n"), 0)
                    RsRpt.Fields("comp_post_les_corr").Value = GetValue(RsRpt.Fields("comp_post_les_corr"), 0) + GetValue(Rs.Fields("rese_N"), 0)
                    RsRpt.Fields("comp_post_les_tot").Value = GetValue(RsRpt.Fields("comp_post_les_tot"), 0) + 1
                    For iCtr = 1 To 10
                        'UPGRADE_WARNING: Couldn't resolve default property of object iCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        RsRpt.Fields("comp_post_l" & iCtr).Value = GetValue(RsRpt.Fields("comp_post_l" & iCtr), 0) + GetValue(Rs.Fields("rese_N" & iCtr), 0)
                    Next
                    RsRpt.Fields("comp_status").Value = "OK"
                    RsRpt.Fields("comp_repid_post").Value = Rs.Fields("Rep_ID").Value
                    RsRpt.Update()
                    'UPGRADE_WARNING: Couldn't resolve default property of object iNVTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    iNVTot = iNVTot + 1
                    'UPGRADE_WARNING: Couldn't resolve default property of object iNVTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Me.TxtNV.Text = iNVTot
                End If

                RsRpt.Close()

            End If
			
			Rs.MoveNext()
			
			'UPGRADE_WARNING: Couldn't resolve default property of object sTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sTot = sTot - 1
			'Me.txtEstPre = iTot
			'UPGRADE_WARNING: Couldn't resolve default property of object sTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.lblStatus2.Text = "Post-" & sTot & " records left"
			System.Windows.Forms.Application.DoEvents()
		End While
		
		Rs.Close()
		
	End Sub
	
	Private Sub Command14_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command14.Click
		Dim sQuery As String
		Dim Cn As New ADODB.Connection
		Dim Rs As New ADODB.Recordset
		Dim Rs2 As New ADODB.Recordset
        'Dim CurrNombre As String
        Dim iCtr As Integer
        Dim sTot As Object
		
        'Dim SchID As Integer
        'Dim isOK As Boolean
        'Dim CrxApp As New CRAXDRT.Application
        'Dim CrxRpt As CRAXDRT.Report
		Dim iTot As Short
        'Dim iTotDup As Short
        'Dim iTotPost As Short
        'Dim iTotNoMatch As Short
		Dim RsRpt As New ADODB.Recordset
		Dim scID As Integer
		
		OpenConnection(Cn, Config.ConnectionString)
		
		'Create RsRpt
        sQuery = "delete from tmp_Comparativo_Grupal"
        Cn.Execute(sQuery)
		
		'SQL = "select * from tmp_Comparativo_Grupal"
		'RsRpt.Open SQL, Cn, 1, 3, 0
		'---
		
		'Me.MousePointer = vbHourglass
		
		
		scID = VB6.GetItemData(Me.cboSchools2, Me.cboSchools2.SelectedIndex)
		
		iTot = 0
        sQuery = "Select resest.*, resultados.*, rep_id, rep_sch_id from ResEst Inner Join Resultados ON ResEst.resg_id = Resultados.resg_id " & "INNER JOIN Reports ON Resultados.resg_rep_id = rep_id " & "WHERE rep_type = 2 AND rep_serv_date >= '" & Me.txtPREDesde.Text & "' AND rep_serv_date <= '" & Me.txtPREHasta.Text & "' and rep_sch_id = " & scID
		
        Rs.Open(sQuery, Cn, 3, 3)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object sTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sTot = Rs.RecordCount
		While Not Rs.EOF
			
			'trabajo LES
			
            If Not IsDBNull(Rs.Fields("rese_esta_l").Value) And Not IsDBNull(Rs.Fields("rese_l").Value) Then
                If Rs.Fields("resg_grado").Value = 1 Then Debug.Print(Rs.Fields("rese_nombre").Value)
                sQuery = "SELECT * FROM tmp_comparativo_grupal WHERE comp_materia = 'LES' AND comp_sch_id = " & Rs.Fields("rep_sch_id").Value & " AND " & "comp_pregrado = " & Rs.Fields("resg_grado").Value & " AND comp_cl_id = " & Rs.Fields("resg_les").Value

                RsRpt.Open(sQuery, Cn, 1, 3, 0)

                If RsRpt.EOF = True Then
                    RsRpt.AddNew()
                    RsRpt.Fields("comp_sch_id").Value = Rs.Fields("rep_sch_id").Value
                    RsRpt.Fields("comp_pregrado").Value = Rs.Fields("resg_grado").Value
                    RsRpt.Fields("comp_presem").Value = txtPREsem.Text
                    RsRpt.Fields("comp_preyear").Value = Year(CDate(txtPREDesde.Text))
                    RsRpt.Fields("comp_cl_id").Value = Rs.Fields("resg_les").Value
                    RsRpt.Fields("comp_pre_les_est").Value = GetValue(Rs.Fields("rese_esta_l"), 0)
                    RsRpt.Fields("comp_pre_les_corr").Value = GetValue(Rs.Fields("rese_l"), 0)
                    RsRpt.Fields("comp_pre_les_tot").Value = 1
                    For iCtr = 1 To 10
                        'UPGRADE_WARNING: Couldn't resolve default property of object iCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        RsRpt.Fields("comp_pre_l" & iCtr).Value = GetValue(Rs.Fields("rese_l" & iCtr), 0)
                    Next iCtr

                    RsRpt.Fields("comp_status").Value = "NOT POST"
                    RsRpt.Fields("comp_materia").Value = "LES"
                    RsRpt.Fields("comp_repid_pre").Value = Rs.Fields("Rep_ID").Value
                    RsRpt.Update()
                Else
                    'aparece, acumulo
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetValue(Rs!rese_esta_l, 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    RsRpt.Fields("comp_pre_les_est").Value = RsRpt.Fields("comp_pre_les_est").Value + GetValue(Rs.Fields("rese_esta_l"), 0)
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetValue(Rs!rese_l, 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    RsRpt.Fields("comp_pre_les_corr").Value = RsRpt.Fields("comp_pre_les_corr").Value + GetValue(Rs.Fields("rese_l"), 0)
                    RsRpt.Fields("comp_pre_les_tot").Value = RsRpt.Fields("comp_pre_les_tot").Value + 1
                    For iCtr = 1 To 10
                        'UPGRADE_WARNING: Couldn't resolve default property of object iCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object GetValue(Rs(rese_l & iCtr), 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        RsRpt.Fields("comp_pre_l" & iCtr).Value = RsRpt.Fields("comp_pre_l" & iCtr).Value + GetValue(Rs.Fields("rese_l" & iCtr), 0)
                    Next iCtr
                    RsRpt.Update()
                End If

                RsRpt.Close()

                'End If


                'trabajo MAT


                sQuery = "SELECT * FROM tmp_comparativo_grupal WHERE comp_materia = 'MAT' AND comp_sch_id = " & Rs.Fields("rep_sch_id").Value & " AND " & "comp_pregrado = " & Rs.Fields("resg_grado").Value & " AND comp_cl_id = " & Rs.Fields("resg_mat").Value

                RsRpt.Open(sQuery, Cn, 1, 3, 0)

                If RsRpt.EOF = True Then
                    RsRpt.AddNew()
                    RsRpt.Fields("comp_sch_id").Value = Rs.Fields("rep_sch_id").Value
                    RsRpt.Fields("comp_pregrado").Value = Rs.Fields("resg_grado").Value
                    RsRpt.Fields("comp_presem").Value = txtPREsem.Text
                    RsRpt.Fields("comp_preyear").Value = Year(CDate(txtPREDesde.Text))
                    RsRpt.Fields("comp_cl_id").Value = Rs.Fields("resg_mat").Value
                    RsRpt.Fields("comp_pre_les_est").Value = GetValue(Rs.Fields("rese_esta_m"), 0)
                    RsRpt.Fields("comp_pre_les_corr").Value = GetValue(Rs.Fields("rese_m"), 0)
                    RsRpt.Fields("comp_pre_les_tot").Value = 1
                    For iCtr = 1 To 20
                        'UPGRADE_WARNING: Couldn't resolve default property of object iCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        RsRpt.Fields("comp_pre_l" & iCtr).Value = GetValue(Rs.Fields("rese_m" & iCtr), 0)
                    Next

                    RsRpt.Fields("comp_status").Value = "NOT POST"
                    RsRpt.Fields("comp_materia").Value = "MAT"
                    RsRpt.Fields("comp_repid_pre").Value = Rs.Fields("Rep_ID").Value
                    RsRpt.Update()
                Else
                    'aparece, acumulo
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetValue(Rs!rese_esta_m, 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    RsRpt.Fields("comp_pre_les_est").Value = RsRpt.Fields("comp_pre_les_est").Value + GetValue(Rs.Fields("rese_esta_m"), 0)
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetValue(Rs!rese_m, 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    RsRpt.Fields("comp_pre_les_corr").Value = RsRpt.Fields("comp_pre_les_corr").Value + GetValue(Rs.Fields("rese_m"), 0)
                    RsRpt.Fields("comp_pre_les_tot").Value = RsRpt.Fields("comp_pre_les_tot").Value + 1
                    For iCtr = 1 To 20
                        'UPGRADE_WARNING: Couldn't resolve default property of object iCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object GetValue(Rs(rese_m & iCtr), 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        RsRpt.Fields("comp_pre_l" & iCtr).Value = RsRpt.Fields("comp_pre_l" & iCtr).Value + GetValue(Rs.Fields("rese_m" & iCtr), 0)
                    Next
                    RsRpt.Update()
                End If

                RsRpt.Close()

            End If


            'trabajo REN

            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(Rs.Fields("rese_esta_r").Value) And Not IsDBNull(Rs.Fields("rese_R").Value) Then

                sQuery = "SELECT * FROM tmp_comparativo_grupal WHERE comp_materia = 'REN' AND comp_sch_id = " & Rs.Fields("rep_sch_id").Value & " AND " & "comp_pregrado = " & Rs.Fields("resg_grado").Value & " AND comp_cl_id = " & Rs.Fields("resg_REN").Value

                RsRpt.Open(sQuery, Cn, 1, 3, 0)

                If RsRpt.EOF = True Then
                    RsRpt.AddNew()
                    RsRpt.Fields("comp_sch_id").Value = Rs.Fields("rep_sch_id").Value
                    RsRpt.Fields("comp_pregrado").Value = Rs.Fields("resg_grado").Value
                    RsRpt.Fields("comp_presem").Value = txtPREsem.Text
                    RsRpt.Fields("comp_preyear").Value = Year(CDate(txtPREDesde.Text))
                    RsRpt.Fields("comp_cl_id").Value = Rs.Fields("resg_REN").Value
                    RsRpt.Fields("comp_pre_les_est").Value = GetValue(Rs.Fields("rese_esta_r"), 0)
                    RsRpt.Fields("comp_pre_les_corr").Value = GetValue(Rs.Fields("rese_R"), 0)
                    RsRpt.Fields("comp_pre_les_tot").Value = 1
                    For iCtr = 1 To 10
                        'UPGRADE_WARNING: Couldn't resolve default property of object iCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        RsRpt.Fields("comp_pre_l" & iCtr).Value = GetValue(Rs.Fields("rese_R" & iCtr), 0)
                    Next

                    RsRpt.Fields("comp_status").Value = "NOT POST"
                    RsRpt.Fields("comp_materia").Value = "REN"
                    RsRpt.Fields("comp_repid_pre").Value = Rs.Fields("Rep_ID").Value
                    RsRpt.Update()
                Else
                    'aparece, acumulo
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetValue(Rs!rese_esta_r, 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    RsRpt.Fields("comp_pre_les_est").Value = RsRpt.Fields("comp_pre_les_est").Value + GetValue(Rs.Fields("rese_esta_r"), 0)
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetValue(Rs!rese_R, 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    RsRpt.Fields("comp_pre_les_corr").Value = RsRpt.Fields("comp_pre_les_corr").Value + GetValue(Rs.Fields("rese_R"), 0)
                    RsRpt.Fields("comp_pre_les_tot").Value = RsRpt.Fields("comp_pre_les_tot").Value + 1
                    For iCtr = 1 To 10
                        'UPGRADE_WARNING: Couldn't resolve default property of object iCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object GetValue(Rs(rese_R & iCtr), 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        RsRpt.Fields("comp_pre_l" & iCtr).Value = RsRpt.Fields("comp_pre_l" & iCtr).Value + GetValue(Rs.Fields("rese_R" & iCtr), 0)
                    Next
                    RsRpt.Update()
                End If

                RsRpt.Close()

            End If

            'trabajo NV

            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(Rs.Fields("rese_esta_n").Value) And Not IsDBNull(Rs.Fields("rese_N").Value) Then

                sQuery = "SELECT * FROM tmp_comparativo_grupal WHERE comp_materia = 'NV' AND comp_sch_id = " & Rs.Fields("rep_sch_id").Value & " AND " & "comp_pregrado = " & Rs.Fields("resg_grado").Value & " AND comp_cl_id = " & Rs.Fields("resg_NV").Value

                RsRpt.Open(sQuery, Cn, 1, 3, 0)

                If RsRpt.EOF = True Then
                    RsRpt.AddNew()
                    RsRpt.Fields("comp_sch_id").Value = Rs.Fields("rep_sch_id").Value
                    RsRpt.Fields("comp_pregrado").Value = Rs.Fields("resg_grado").Value
                    RsRpt.Fields("comp_presem").Value = txtPREsem.Text
                    RsRpt.Fields("comp_preyear").Value = Year(CDate(txtPREDesde.Text))
                    RsRpt.Fields("comp_cl_id").Value = Rs.Fields("resg_NV").Value
                    RsRpt.Fields("comp_pre_les_est").Value = GetValue(Rs.Fields("rese_esta_n"), 0)
                    RsRpt.Fields("comp_pre_les_corr").Value = GetValue(Rs.Fields("rese_N"), 0)
                    RsRpt.Fields("comp_pre_les_tot").Value = 1
                    For iCtr = 1 To 10
                        'UPGRADE_WARNING: Couldn't resolve default property of object iCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        RsRpt.Fields("comp_pre_l" & iCtr).Value = GetValue(Rs.Fields("rese_N" & iCtr), 0)
                    Next

                    RsRpt.Fields("comp_status").Value = "NOT POST"
                    RsRpt.Fields("comp_materia").Value = "NV"
                    RsRpt.Fields("comp_repid_pre").Value = Rs.Fields("Rep_ID").Value
                    RsRpt.Update()
                Else
                    'aparece, acumulo
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetValue(Rs!rese_esta_n, 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    RsRpt.Fields("comp_pre_les_est").Value = RsRpt.Fields("comp_pre_les_est").Value + GetValue(Rs.Fields("rese_esta_n"), 0)
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetValue(Rs!rese_N, 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    RsRpt.Fields("comp_pre_les_corr").Value = RsRpt.Fields("comp_pre_les_corr").Value + GetValue(Rs.Fields("rese_N"), 0)
                    RsRpt.Fields("comp_pre_les_tot").Value = RsRpt.Fields("comp_pre_les_tot").Value + 1
                    For iCtr = 1 To 10
                        'UPGRADE_WARNING: Couldn't resolve default property of object iCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object GetValue(Rs(rese_N & iCtr), 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        RsRpt.Fields("comp_pre_l" & iCtr).Value = RsRpt.Fields("comp_pre_l" & iCtr).Value + GetValue(Rs.Fields("rese_N" & iCtr), 0)
                    Next
                    RsRpt.Update()
                End If

                RsRpt.Close()

            End If



            Rs.MoveNext()
            iTot = iTot + 1
            'UPGRADE_WARNING: Couldn't resolve default property of object sTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sTot = sTot - 1
            Me.txtEstPre.Text = CStr(iTot)
            'UPGRADE_WARNING: Couldn't resolve default property of object sTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.lblStatus2.Text = "Pre-" & sTot & " records left"
            System.Windows.Forms.Application.DoEvents()
        End While
		
		Rs.Close()
		
		
	End Sub
	
	Private Sub Command15_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command15.Click
		Me.Close()
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Dim sQuery As String
		Dim Cn As New ADODB.Connection
		Dim Rs As New ADODB.Recordset
		Dim Rs2 As New ADODB.Recordset
        'Dim CurrNombre As String
        Dim sDesde As Object
        Dim sHasta As Object
        Dim sTot As Object
        'Dim SchID As Integer
        'Dim isOK As Boolean
		'ConnectionString = "Provider=MSDASQL.1;Persist Security Info=False;User ID=sa;Data Source=LearnAid;Initial Catalog=LA"
        'Dim CrxApp As New CRAXDRT.Application
        'Dim CrxRpt As CRAXDRT.Report
		Dim iTot As Short
        'Dim iTotDup As Short
        'Dim iTotPost As Short
        'Dim iTotNoMatch As Short
		Dim RsRpt As New ADODB.Recordset
		
		OpenConnection(Cn, Config.ConnectionString)
		
		'Create RsRpt
        sQuery = "delete from tmp_Comparativo"
        Cn.Execute(sQuery)
		
        sQuery = "select * from tmp_Comparativo"
        RsRpt.Open(sQuery, Cn, 1, 3, 0)
		'---
		
		'Me.MousePointer = vbHourglass
		
		
		'1. Hago loop por Semestre uno del ano en solicitud.
		'2. Lo coloco en la tabla tmp_comparativa con la info del pre
		'3. Luego hago loop de nuevo por semestre 2, si macheo el nombre con
		'   grado y escuela lo pongo en su record de tmp_comparativa
		
		
		If Val(txtSemPRE.Text) = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object sDesde. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sDesde = "08/01/" & Me.txtYearPRE.Text
			'UPGRADE_WARNING: Couldn't resolve default property of object sHasta. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sHasta = "12/31/" & Val(Me.txtYearPRE.Text)
		ElseIf Val(txtSemPRE.Text) = 2 Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object sDesde. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sDesde = "01/01/" & Val(Me.txtYearPRE.Text) + 1
			'UPGRADE_WARNING: Couldn't resolve default property of object sHasta. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sHasta = "07/31/" & Val(Me.txtYearPRE.Text) + 1
		Else
			MsgBox("Semestre es incorrecto")
			txtSemPRE.Focus()
			Exit Sub
		End If
		
		iTot = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object sHasta. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object sDesde. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sQuery = "Select rese_nombre, rese_id, resultados.resg_id, rep_id, rep_sch_id, resg_grado from ResEst Inner Join Resultados ON ResEst.resg_id = Resultados.resg_id " & "INNER JOIN Reports ON Resultados.resg_rep_id = rep_id " & "WHERE rep_sem = " & txtSemPRE.Text & " AND rep_serv_date >= '" & sDesde & "' AND rep_serv_date <= '" & sHasta & "' and rep_sch_id > 0"
		
        Rs.Open(sQuery, Cn, 3, 3)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object sTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sTot = Rs.RecordCount
		While Not Rs.EOF
            RsRpt.AddNew()
			RsRpt.Fields("comp_nombre").Value = Rs.Fields("rese_nombre").Value
			RsRpt.Fields("comp_sch_id").Value = Rs.Fields("rep_sch_id").Value
			RsRpt.Fields("comp_grado").Value = Rs.Fields("resg_grado").Value
			RsRpt.Fields("comp_repid_pre").Value = Rs.Fields("Rep_ID").Value
			RsRpt.Fields("comp_reseid_pre").Value = Rs.Fields("rese_id").Value
			RsRpt.Fields("comp_resgid_pre").Value = Rs.Fields("resg_id").Value
			RsRpt.Fields("comp_repid_post").Value = 0
			RsRpt.Fields("comp_reseid_post").Value = 0
			RsRpt.Fields("comp_resgid_post").Value = 0
			RsRpt.Fields("comp_status").Value = ""
			RsRpt.Update()
			
			Rs.MoveNext()
			iTot = iTot + 1
			'UPGRADE_WARNING: Couldn't resolve default property of object sTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sTot = sTot - 1
			Me.txtDatosPre.Text = CStr(iTot)
			'UPGRADE_WARNING: Couldn't resolve default property of object sTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.lblStatus.Text = "Pre-" & sTot & " records left"
			System.Windows.Forms.Application.DoEvents()
		End While
		
		Rs.Close()
		RsRpt.Close()
		
		
		
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		
        'Dim CrxApp As New CRAXDRT.Application
        'Dim CrxRpt As CRAXDRT.Report
		
		
		Dim rptI As New frmReport
		rptI.ReportID = VB6.GetItemData(Me.cboSchools, Me.cboSchools.SelectedIndex)
		rptI.ReportFile = Config.ReportsPath & "TITULO1_DestrezasLES_Post.rpt"
		rptI.Show()
		
	End Sub
	
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
        Dim sQuery As String
		Dim Cn As New ADODB.Connection
		Dim Rs As New ADODB.Recordset
		Dim Rs2 As New ADODB.Recordset
		Dim CurrNombre As String
        Dim xGrado As Object
        Dim sTot As Object
        Dim sHasta As Object
        Dim sDesde As Object

        'Dim SchID As Integer
        'Dim isOK As Boolean
		'ConnectionString = "Provider=MSDASQL.1;Persist Security Info=False;User ID=sa;Data Source=LearnAid;Initial Catalog=LA"
        'Dim CrxApp As New CRAXDRT.Application
        'Dim CrxRpt As CRAXDRT.Report
        'Dim iTot As Short
        Dim iTotDup As Short
		Dim iTotPost As Short
		Dim iTotNoMatch As Short
		Dim RsRpt As New ADODB.Recordset
		
		OpenConnection(Cn, Config.ConnectionString)
		
		
		'3. Luego hago loop de nuevo por semestre 2, si macheo el nombre con
		'   grado y escuela lo pongo en su record de tmp_comparativa
        sQuery = "delete from Tmp_comparativo WHERE comp_status = 'NOMATCH'"
        Cn.Execute(sQuery)
		
		
		If Val(txtSemPost.Text) = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object sDesde. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sDesde = "08/01/" & Me.txtyearPost.Text
			'UPGRADE_WARNING: Couldn't resolve default property of object sHasta. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sHasta = "12/31/" & Val(Me.txtyearPost.Text)
		ElseIf Val(txtSemPost.Text) = 2 Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object sDesde. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sDesde = "01/01/" & Val(Me.txtyearPost.Text) + 1
			'UPGRADE_WARNING: Couldn't resolve default property of object sHasta. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sHasta = "07/31/" & Val(Me.txtyearPost.Text) + 1
		Else
			MsgBox("Semestre es incorrecto")
			txtSemPost.Focus()
			Exit Sub
		End If
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object sHasta. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object sDesde. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sQuery = "Select rese_nombre, rese_id,rep_id, resultados.resg_id, rep_sch_id, resg_grado from ResEst Inner Join Resultados ON ResEst.resg_id = Resultados.resg_id " & "INNER JOIN Reports ON Resultados.resg_rep_id = rep_id " & "WHERE rep_sem = " & txtSemPost.Text & " AND rep_serv_date >= '" & sDesde & "' AND rep_serv_date <= '" & sHasta & "' and rep_sch_id > 0"
		
        Rs.Open(sQuery, Cn, 3, 3)
		'UPGRADE_WARNING: Couldn't resolve default property of object sTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sTot = Rs.RecordCount
		
		While Not Rs.EOF
			
			CurrNombre = Rs.Fields("rese_nombre").Value
			CurrNombre = Replace(CurrNombre, "'", "")
			If CDbl(txtSemPost.Text) = 1 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object xGrado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				xGrado = Val(Rs.Fields("resg_grado").Value) - 1
				'UPGRADE_WARNING: Couldn't resolve default property of object xGrado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				xGrado = IIf(xGrado < 0, 0, xGrado)
				'UPGRADE_WARNING: Couldn't resolve default property of object xGrado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sQuery = "SELECT * from tmp_Comparativo WHERE " & "comp_nombre = '" & CurrNombre & "' AND " & "comp_grado = " & xGrado & " AND " & "comp_sch_id = " & Rs.Fields("rep_sch_id").Value
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object xGrado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				xGrado = Rs.Fields("resg_grado").Value
				'UPGRADE_WARNING: Couldn't resolve default property of object xGrado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sQuery = "SELECT * from tmp_Comparativo WHERE " & "comp_nombre = '" & CurrNombre & "' AND " & "comp_grado = " & xGrado & " AND " & "comp_sch_id = " & Rs.Fields("rep_sch_id").Value
			End If
            Rs2.Open(sQuery, Cn, 1, 3, 0)
			
			If Rs2.RecordCount = 1 Then
				Rs2.Fields("comp_repid_post").Value = Rs.Fields("Rep_ID").Value
				Rs2.Fields("comp_reseid_post").Value = Rs.Fields("rese_id").Value
				Rs2.Fields("comp_resgid_post").Value = Rs.Fields("resg_id").Value
				Rs2.Fields("comp_status").Value = "OK"
				Rs2.Update()
				iTotPost = iTotPost + 1
				Me.txtDatosPost.Text = CStr(iTotPost)
			ElseIf Rs2.RecordCount > 1 Then 
				Rs2.Fields("comp_status").Value = "DUP"
				Rs2.Update()
				iTotDup = iTotDup + 1
				Me.txtDatosDup.Text = CStr(iTotDup)
			Else
                sQuery = "insert into tmp_comparativo (comp_reseid_post,comp_resgid_post, comp_repid_post, comp_status, comp_nombre, comp_sch_id, comp_grado) values (" & Rs.Fields("rese_id").Value & "," & Rs.Fields("resg_id").Value & "," & Rs.Fields("Rep_ID").Value & ",'NOMATCH', '" & CurrNombre & "'," & Rs.Fields("rep_sch_id").Value & ",'" & Rs.Fields("resg_grado").Value & "')"
                Cn.Execute(sQuery)
				iTotNoMatch = iTotNoMatch + 1
				Me.txtDatosNoMatch.Text = CStr(iTotNoMatch)
			End If
			Rs2.Close()
			Rs.MoveNext()
			System.Windows.Forms.Application.DoEvents()
			'UPGRADE_WARNING: Couldn't resolve default property of object sTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sTot = sTot - 1
			'UPGRADE_WARNING: Couldn't resolve default property of object sTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.lblStatus.Text = "Post-" & sTot
		End While
		Rs.Close()
		
		
	End Sub
	
	Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
		
        'Dim CrxApp As New CRAXDRT.Application
        'Dim CrxRpt As CRAXDRT.Report
		
		
		Dim rptI As New frmReport
		rptI.ReportID = VB6.GetItemData(Me.cboSchools, Me.cboSchools.SelectedIndex)
		rptI.ReportFile = Config.ReportsPath & "TITULO1_DestrezasMAT_Post.rpt"
		rptI.Show()
		
	End Sub
	
	Private Sub Command6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command6.Click
		
        'Dim CrxApp As New CRAXDRT.Application
        'Dim CrxRpt As CRAXDRT.Report
		
		
		Dim rptI As New frmReport
		rptI.ReportID = VB6.GetItemData(Me.cboSchools, Me.cboSchools.SelectedIndex)
		rptI.ReportFile = Config.ReportsPath & "TITULO1_DestrezasREN_Post.rpt"
		rptI.Show()
		
	End Sub
	
	
	Private Sub Command7_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command7.Click
		
        'Dim CrxApp As New CRAXDRT.Application
        'Dim CrxRpt As CRAXDRT.Report
		
		
		Dim rptI As New frmReport
		rptI.ReportID = VB6.GetItemData(Me.cboSchools, Me.cboSchools.SelectedIndex)
		rptI.ReportFile = Config.ReportsPath & "TITULO1_INDIVIDUALPRE1_POST.rpt"
		rptI.Show()
		
	End Sub
	
	Private Sub Command8_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command8.Click
		
        'Dim CrxApp As New CRAXDRT.Application
        'Dim CrxRpt As CRAXDRT.Report
		
		
		Dim rptI As New frmReport
		rptI.ReportID = VB6.GetItemData(Me.cboSchools, Me.cboSchools.SelectedIndex)
		rptI.ReportFile = Config.ReportsPath & "TITULO1_rptIndividual0_Post.rpt"
		rptI.Show()
		
	End Sub
	
	Private Sub Command9_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command9.Click
		
        'Dim CrxApp As New CRAXDRT.Application
        'Dim CrxRpt As CRAXDRT.Report
		
		
		Dim rptI As New frmReport
		rptI.ReportID = VB6.GetItemData(Me.cboSchools, Me.cboSchools.SelectedIndex)
		rptI.ReportFile = Config.ReportsPath & "TITULO1_DestrezasRENPRE1_Post.rpt"
		rptI.Show()
		
		
	End Sub
	
	Private Sub frmPrePost_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim sQuery As String
		Dim Cn As New ADODB.Connection
		Dim Rs As New ADODB.Recordset
        Dim iYear As Object

		
		
		OpenConnection(Cn, Config.ConnectionString)
		
		
        sQuery = "Select * FROM tmp_comparativo WHERE comp_status = 'DUP'"
        Rs.Open(sQuery, Cn, 3, 3)
        Me.txtDatosDup.Text = Rs.RecordCount.ToString
		Rs.Close()
		
        sQuery = "Select * FROM tmp_comparativo WHERE comp_status = 'NOMATCH'"
        Rs.Open(sQuery, Cn, 3, 3)
        Me.txtDatosNoMatch.Text = Rs.RecordCount.ToString
		Rs.Close()
		
        sQuery = "Select * FROM tmp_comparativo WHERE comp_status = 'OK'"
        Rs.Open(sQuery, Cn, 3, 3)
        Me.txtDatosPost.Text = Rs.RecordCount.ToString
		Rs.Close()
		
        sQuery = "Select * FROM tmp_comparativo WHERE comp_status <> 'NOMATCH'"
        Rs.Open(sQuery, Cn, 3, 3)
        Me.txtDatosPre.Text = Rs.RecordCount.ToString
		Rs.Close()

        sQuery = "SELECT SCHOOLS.SC_SCH_NAME, SC_ID FROM SCHOOLS order by SC_sch_name "
        Rs.Open(sQuery, Cn, 3, 3)
		
		While Not Rs.EOF
			Me.cboSchools.Items.Add(Rs.Fields("sc_sch_name").Value & "-" & Rs.Fields("sc_id").Value)
			VB6.SetItemData(Me.cboSchools, Me.cboSchools.Items.Count - 1, Rs.Fields("sc_id").Value)
			Me.cboSchools2.Items.Add(Rs.Fields("sc_sch_name").Value & "-" & Rs.Fields("sc_id").Value)
			VB6.SetItemData(Me.cboSchools2, Me.cboSchools2.Items.Count - 1, Rs.Fields("sc_id").Value)
			Rs.MoveNext()
		End While
		Rs.Close()
		Me.cboSchools.Refresh()
		Me.cboSchools2.Refresh()
		
        iYear = 2005
		For iYear = 2005 To Year(Today) + 1
            Me.cboYear.Items.Add(iYear)
		Next 
		
		Me.cboMetodo.Items.Add("Pre: 1er Sem, Post: 2do Sem")
		Me.cboMetodo.Items.Add("Pre: 2do Sem, Post: 1er Sem (prox año)")
		
		
		
	End Sub
	
	
	Private Sub Text3_Change()
		
	End Sub
End Class