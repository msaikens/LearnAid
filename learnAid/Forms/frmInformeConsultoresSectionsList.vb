Option Strict Off
Option Explicit On
Friend Class frmInformeConsultoresSectionsList
	Inherits System.Windows.Forms.Form
	
	Sub FillSectionsList()
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		Dim TheItem As System.Windows.Forms.ListViewItem
		Dim sThisRepID As String
		
		Cn = New ADODB.Connection
		Rs = New ADODB.Recordset
		
		OpenConnection(Cn, Config.ConnectionString)
		
		sThisRepID = Replace(frmConsultantView.lvConsultant.FocusedItem.Name, "A", "")
		Me.Tag = sThisRepID
		Rs.Open("Select * From resultados where resg_rep_id=" & Val(sThisRepID), Cn)
        'CLEAR THE LISTBOX PRIOR TO READIING IN THE RECORDS.
        If Me.lvSections.Items.Count > 0 Then
            Me.lvSections.Items.Clear()
        End If
        While Not Rs.EOF
            TheItem = Me.lvSections.Items.Add("s_" & Rs.Fields("resg_id").Value, Rs.Fields("resg_grado").Value, "")
            'UPGRADE_WARNING: Lower bound of collection TheItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If TheItem.SubItems.Count > 1 Then
                TheItem.SubItems(1).Text = Rs.Fields("resg_section").Value
            Else
                TheItem.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Rs.Fields("resg_section").Value))
            End If
            'UPGRADE_WARNING: Lower bound of collection TheItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If TheItem.SubItems.Count > 2 Then
                TheItem.SubItems(2).Text = Rs.Fields("resg_total_est").Value
            Else
                TheItem.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Rs.Fields("resg_total_est").Value))
            End If
            'UPGRADE_WARNING: Lower bound of collection TheItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If TheItem.SubItems.Count > 3 Then
                TheItem.SubItems(3).Text = IIf(IsDone(Rs.Fields("resg_id")), "Yes", "No")
            Else
                TheItem.SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, IIf(IsDone(Rs.Fields("resg_id")), "Yes", "No")))
            End If

            dtDoS.Text = Rs.Fields("reg_serv_date").Value
            Rs.MoveNext()
        End While
        Rs.Close()
        Cn.Close()
    End Sub
	
	Function IsDone(ByRef iSectId As Object) As Boolean
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		
		IsDone = False
		
		Cn = New ADODB.Connection
		Rs = New ADODB.Recordset
		
		OpenConnection(Cn, Config.ConnectionString)
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object iSectId. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Rs.Open("Select * From rep_observaciones where ro_resg_id=" & GetValue(iSectId), Cn, 3, 3)
		If Rs.RecordCount > 0 Then
			IsDone = True
		End If
		Rs.Close()
		Cn.Close()
	End Function
	
	
	Sub SetButtons()
        'Dim msgReturn As Object
		Dim sQuery As String
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		Dim dRepID As Double
		
		dRepID = CDbl(Me.Tag)
		Cn = CreateObject("ADODB.CONNECTION")
		
		OpenConnection(Cn, Config.ConnectionString)
		
		sQuery = "SELECT CONSULTANTS.CON_NAME, CONSULTANTS.CON_LNAME1, CONSULTANTS.CON_LNAME2, CONSULTANTS.CON_FULL_NAME,CONSULTANTS.CON_TITLE, SCHOOLS.SC_SCH_NAME, Reports.rep_serv_date, Reports.Rep_ID, Reports.rep_consult_status " & "FROM (Reports LEFT JOIN SCHOOLS ON Reports.Rep_SCH_ID = SCHOOLS.SC_ID) LEFT JOIN CONSULTANTS ON Reports.rep_cons_id = CONSULTANTS.CON_ID " & "WHERE (((Reports.Rep_ID)=" & dRepID & " ))"
		
		Rs = CreateObject("ADODB.RECORDSET")
		Rs.Open(sQuery, Cn, 1, 3, 0)
		
		Select Case Rs.Fields("rep_consult_status").Value
			Case "P"
				'Pending
				'-- Do Save Record
				Me.cmdReCreate.Visible = False
				Me.cmdSave.Text = "Create &Document"
				'--
			Case "C"
				'Completed
				Me.cmdReCreate.Visible = True
				Me.cmdSave.Text = "Open &Document"
		End Select
		
		
		Rs.Close()
		Cn.Close()
		
	End Sub
	
	Private Sub cmdCalendar1_Click()
		
	End Sub
	
	Private Sub cmdCalendar2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCalendar2.Click
		CalCaller = "ReposicionDate"
		frmConsultoresCalendar.ShowDialog()
	End Sub
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
	End Sub
	
	
	Private Sub cmdReCreate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReCreate.Click
		Dim sthisdocpath As Object
        Dim msgReturn As Object = Nothing
		Dim hShell As Object
		Dim WordPath As String
		Dim sQuery As String
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		Dim dRepID As Double
		WordPath = GetINIValue(My.Application.Info.DirectoryPath & "\learnaid.ini", "System.Settings", "MSWordPath")
		
		dRepID = CDbl(Me.Tag)
		Cn = CreateObject("ADODB.CONNECTION")
		
		OpenConnection(Cn, Config.ConnectionString)
		
		sQuery = "SELECT CONSULTANTS.CON_NAME, CONSULTANTS.CON_LNAME1, CONSULTANTS.CON_LNAME2, CONSULTANTS.CON_FULL_NAME,CONSULTANTS.CON_TITLE, SCHOOLS.SC_SCH_NAME, Reports.rep_serv_date, Reports.Rep_ID, Reports.rep_consult_status " & "FROM (Reports LEFT JOIN SCHOOLS ON Reports.Rep_SCH_ID = SCHOOLS.SC_ID) LEFT JOIN CONSULTANTS ON Reports.rep_cons_id = CONSULTANTS.CON_ID " & "WHERE (((Reports.Rep_ID)=" & dRepID & " ))"
		
		Rs = CreateObject("ADODB.RECORDSET")
		Rs.Open(sQuery, Cn, 1, 3, 0)
		
		Select Case Rs.Fields("rep_consult_status").Value
			Case "C"
				'Pending
				'-- Do Save Record
				Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                ConsultantMod.CreateConsultantReport(dRepID)
				frmreportprocess.ShowDialog()
				
                Me.Cursor = Cursors.Default

                '--
                'Cambiar status del Report
                Rs.Fields("rep_consult_status").Value = "C"
                Rs.Update()
                '--
                'UPGRADE_WARNING: Couldn't resolve default property of object msgReturn. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                msgReturn = MsgBox("Your report has been created.  Would you like to open it now in MS Word?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        End Select


        'UPGRADE_WARNING: Couldn't resolve default property of object sthisdocpath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sthisdocpath = Rs.Fields("sc_sch_name").Value & " - " & Month(Rs.Fields("rep_serv_date").Value) & " - " & Year(Rs.Fields("rep_serv_date").Value) & ".htm"
        'UPGRADE_WARNING: Couldn't resolve default property of object sthisdocpath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sthisdocpath = Config.ConsultantsPath & Trim(Rs.Fields("con_name").Value & " " & Rs.Fields("con_lname1").Value & " " & Rs.Fields("con_lname2").Value) & "\" & sthisdocpath

        Rs.Close()
        Cn.Close()

        If msgReturn <> MsgBoxResult.Cancel Then
            If msgReturn = MsgBoxResult.Yes Then
                'hShell = StartDoc(CStr(sthisdocpath))
                'sThisDocPath = "C:\Documents and Settings\jesus\Desktop\LAID-ScreenShots.doc"
                'UPGRADE_WARNING: Couldn't resolve default property of object sthisdocpath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object hShell. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                hShell = Shell(WordPath & " " & Chr(34) & sthisdocpath & Chr(34), AppWinStyle.MaximizedFocus)
            End If
            Me.Close()
        End If

    End Sub

    Private Sub cmdSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.Click
        Dim sthisdocpath As Object
        Dim msgReturn As Object = Nothing
        Dim hShell As Object
        Dim WordPath As String
        Dim sQuery As String
        Dim Cn As ADODB.Connection
        Dim Rs As ADODB.Recordset
        Dim dRepID As Double
        WordPath = GetINIValue(My.Application.Info.DirectoryPath & "\learnaid.ini", "System.Settings", "MSWordPath")

        dRepID = CDbl(Me.Tag)
        Cn = CreateObject("ADODB.CONNECTION")

        OpenConnection(Cn, Config.ConnectionString)

        sQuery = "SELECT CONSULTANTS.CON_NAME, CONSULTANTS.CON_LNAME1, CONSULTANTS.CON_LNAME2, CONSULTANTS.CON_FULL_NAME,CONSULTANTS.CON_TITLE, SCHOOLS.SC_SCH_NAME, Reports.rep_serv_date, Reports.Rep_ID, Reports.rep_consult_status " & "FROM (Reports LEFT JOIN SCHOOLS ON Reports.Rep_SCH_ID = SCHOOLS.SC_ID) LEFT JOIN CONSULTANTS ON Reports.rep_cons_id = CONSULTANTS.CON_ID " & "WHERE (((Reports.Rep_ID)=" & dRepID & " ))"

        Rs = CreateObject("ADODB.RECORDSET")
        Rs.Open(sQuery, Cn, 1, 3, 0)

        Select Case Rs.Fields("rep_consult_status").Value
            Case "P"
                'Pending
                '-- Do Save Record
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                ConsultantMod.CreateConsultantReport(dRepID)
                frmreportprocess.ShowDialog()

                Me.Cursor = Cursors.Default

                '--
                'Cambiar status del Report
                Rs.Fields("rep_consult_status").Value = "C"
                Rs.Update()
                '--
                'UPGRADE_WARNING: Couldn't resolve default property of object msgReturn. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                msgReturn = MsgBox("Your report has been created.  Would you like to open it now in MS Word?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            Case "C"
                'Completed
                'UPGRADE_WARNING: Couldn't resolve default property of object msgReturn. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                msgReturn = MsgBox("Would you like to open it now in MS Word?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        End Select


        'UPGRADE_WARNING: Couldn't resolve default property of object sthisdocpath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sthisdocpath = Rs.Fields("sc_sch_name").Value & " - " & Month(Rs.Fields("rep_serv_date").Value) & " - " & Year(Rs.Fields("rep_serv_date").Value) & ".htm"
        'UPGRADE_WARNING: Couldn't resolve default property of object sthisdocpath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sthisdocpath = Config.ConsultantsPath & Trim(Rs.Fields("con_name").Value & " " & Rs.Fields("con_lname1").Value & " " & Rs.Fields("con_lname2").Value) & "\" & sthisdocpath

        Rs.Close()
        Cn.Close()

        If msgReturn <> MsgBoxResult.Cancel Then
            If msgReturn = MsgBoxResult.Yes Then
                'hShell = StartDoc(CStr(sthisdocpath))
                'sThisDocPath = "C:\Documents and Settings\jesus\Desktop\LAID-ScreenShots.doc"
                'UPGRADE_WARNING: Couldn't resolve default property of object sthisdocpath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object hShell. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                hShell = Shell(WordPath & " " & Chr(34) & sthisdocpath & Chr(34), AppWinStyle.MaximizedFocus)
            End If
            Me.Close()
        End If
Salir:
        Exit Sub


Errores:
        Select Case Err.Number
            Case 53 'File not found
                MsgBox("Cannot open the document because was not found.", MsgBoxStyle.Critical, "Consultant document")
                Resume Salir
            Case 0 'File already open
                MsgBox("Cannot open the document because it is in use.", MsgBoxStyle.Critical, "Consultant document")
                Resume

            Case Else
        End Select
    End Sub
	
	Private Sub Command2_Click()
		
	End Sub
	
	Private Sub frmInformeConsultoresSectionsList_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.lblSectionsInstructions.Text = "Please select the section for which you want to create an observations and recommendations report.    "
		Me.FillSectionsList()
        'Me.txtDoS.Text = frmConsultantView.lvConsultant.FocusedItem.Text
		Me.txtAcomodo.Text = ""
		Me.txtAusentes.Text = ""
		Me.txtReposicion.Text = ""
		Me.txtReposicionDate.Text = ""
		
		Call SetButtons()
		
	End Sub
	
	
	Private Sub lvSections_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvSections.DoubleClick
		If Not Me.lvSections.FocusedItem Is Nothing Then
			'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'

            '--Code Change-- jh' Load(frmInformeConsultoresMain)
            Dim frmInformeConsultoresMain As New frmInformeConsultoresMain
            'UPGRADE_WARNING: Lower bound of collection Me.lvSections.SelectedItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			If Me.lvSections.FocusedItem.SubItems(3).Text = "Yes" Then
				frmInformeConsultoresMain.Tag = Me.lvSections.FocusedItem.Name & "_" & "e"
			Else
				frmInformeConsultoresMain.Tag = Me.lvSections.FocusedItem.Name & "_" & "a"
            End If
            frmInformeConsultoresMain.ShowDialog()
		End If
	End Sub

  
End Class