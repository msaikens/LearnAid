Option Strict Off
Option Explicit On
Friend Class frmInformeConsultoresMain
	Inherits System.Windows.Forms.Form
	Public RepID As Integer
	Private Sub Combo1_Change()
		
	End Sub
	
	Private Sub Combo2_Change()
		
	End Sub
	
	
	Sub FillAmbienteList()
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		Dim TheItem As System.Windows.Forms.ListViewItem
		
		
		Cn = New ADODB.Connection
		Rs = New ADODB.Recordset
		
		OpenConnection(Cn, Config.ConnectionString)
		
		Rs.Open("Select * From observacion where ob_type='a'", Cn)
		While Not Rs.EOF
			TheItem = Me.lvAmbiente.Items.Add("a_" & Rs.Fields("ob_id").Value, Rs.Fields("ob_desc").Value, "")
			Rs.MoveNext()
		End While
		Rs.Close()
		Cn.Close()
	End Sub
	
	Sub FillAmbienteListEx()
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		Dim TheItem As System.Windows.Forms.ListViewItem
        'Dim sModText As String
		Dim iResgID As Integer
		
		Cn = New ADODB.Connection
		Rs = New ADODB.Recordset
		iResgID = Val(Split(Me.Tag, "_")(1))
		
		OpenConnection(Cn, Config.ConnectionString)
		
		Rs.Open("Select * From observacion where ob_type='a'", Cn)
		While Not Rs.EOF
			If IsSelected(Rs.Fields("ob_id").Value, iResgID) Then
				TheItem = Me.lvAmbiente.Items.Add("a_" & Rs.Fields("ob_id").Value, Rs.Fields("ob_desc").Value, "")
				TheItem.Checked = True
			Else
				TheItem = Me.lvAmbiente.Items.Add("a_" & Rs.Fields("ob_id").Value, Rs.Fields("ob_desc").Value, "")
			End If
			Rs.MoveNext()
		End While
		Rs.Close()
		Cn.Close()
	End Sub
	Sub FillConductaList()
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		Dim TheItem As System.Windows.Forms.ListViewItem
		
		
		Cn = New ADODB.Connection
		Rs = New ADODB.Recordset
		
		OpenConnection(Cn, Config.ConnectionString)
		
		Rs.Open("Select * From observacion where ob_type='c'", Cn)
		While Not Rs.EOF
			TheItem = Me.lvConducta.Items.Add("c_" & Rs.Fields("ob_id").Value, Rs.Fields("ob_desc").Value, "")
			Rs.MoveNext()
		End While
		Rs.Close()
		Cn.Close()
	End Sub
	
	Sub FillConductaListEx()
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		Dim TheItem As System.Windows.Forms.ListViewItem
        'Dim sModText As String
		Dim iResgID As Integer
		
		Cn = New ADODB.Connection
		Rs = New ADODB.Recordset
		iResgID = Val(Split(Me.Tag, "_")(1))
		
		OpenConnection(Cn, Config.ConnectionString)
		
		Rs.Open("Select * From observacion where ob_type='c'", Cn)
		While Not Rs.EOF
			If IsSelected(Rs.Fields("ob_id").Value, iResgID) Then
				TheItem = Me.lvConducta.Items.Add("c_" & Rs.Fields("ob_id").Value, Rs.Fields("ob_desc").Value, "")
				TheItem.Checked = True
			Else
				TheItem = Me.lvConducta.Items.Add("c_" & Rs.Fields("ob_id").Value, Rs.Fields("ob_desc").Value, "")
			End If
			Rs.MoveNext()
		End While
		Rs.Close()
		Cn.Close()
	End Sub
	
	Sub FillRecomendacionesList()
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		Dim TheItem As System.Windows.Forms.ListViewItem
		
		
		Cn = New ADODB.Connection
		Rs = New ADODB.Recordset
		
		OpenConnection(Cn, Config.ConnectionString)
		
		Rs.Open("Select * From observacion where ob_type='r'", Cn)
		While Not Rs.EOF
			TheItem = Me.lvRecomendaciones.Items.Add("c_" & Rs.Fields("ob_id").Value, Rs.Fields("ob_desc").Value, "")
			Rs.MoveNext()
		End While
		Rs.Close()
		Cn.Close()
	End Sub
	
	Sub FillRecomendacionesListEx()
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		Dim TheItem As System.Windows.Forms.ListViewItem
		Dim iResgID As Integer
		
		Cn = New ADODB.Connection
		Rs = New ADODB.Recordset
		iResgID = Val(Split(Me.Tag, "_")(1))
		
		OpenConnection(Cn, Config.ConnectionString)
		
		Rs.Open("Select * From observacion where ob_type='r'", Cn)
		While Not Rs.EOF
			If IsSelected(Rs.Fields("ob_id").Value, iResgID) Then
				TheItem = Me.lvRecomendaciones.Items.Add("r_" & Rs.Fields("ob_id").Value, Rs.Fields("ob_desc").Value, "")
				TheItem.Checked = True
			Else
				TheItem = Me.lvRecomendaciones.Items.Add("r_" & Rs.Fields("ob_id").Value, Rs.Fields("ob_desc").Value, "")
			End If
			Rs.MoveNext()
		End While
		Rs.Close()
		Cn.Close()
	End Sub
	
	
	Sub FillDificultadesList()
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		Dim TheItem As System.Windows.Forms.ListViewItem
		
		
		Cn = New ADODB.Connection
		Rs = New ADODB.Recordset
		
		OpenConnection(Cn, Config.ConnectionString)
		
		Rs.Open("Select * From observacion where ob_type='d'", Cn)
		While Not Rs.EOF
			TheItem = Me.lvDificultades.Items.Add("d_" & Rs.Fields("ob_id").Value, Rs.Fields("ob_desc").Value, "")
			Rs.MoveNext()
		End While
		Rs.Close()
		Cn.Close()
	End Sub
	
	Sub FillDificultadesListEx()
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		Dim TheItem As System.Windows.Forms.ListViewItem
		Dim iResgID As Integer
		
		Cn = New ADODB.Connection
		Rs = New ADODB.Recordset
		iResgID = Val(Split(Me.Tag, "_")(1))
		
		OpenConnection(Cn, Config.ConnectionString)
		
		Rs.Open("Select * From observacion where ob_type='d'", Cn)
		While Not Rs.EOF
			If IsSelected(Rs.Fields("ob_id").Value, iResgID) Then
				TheItem = Me.lvDificultades.Items.Add("d_" & Rs.Fields("ob_id").Value, Rs.Fields("ob_desc").Value, "")
				TheItem.Checked = True
			Else
				TheItem = Me.lvDificultades.Items.Add("d_" & Rs.Fields("ob_id").Value, Rs.Fields("ob_desc").Value, "")
			End If
			
			Rs.MoveNext()
		End While
		Rs.Close()
		Cn.Close()
	End Sub
	
	Sub FillInstruccionesList()
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		Dim TheItem As System.Windows.Forms.ListViewItem
		
		
		Cn = New ADODB.Connection
		Rs = New ADODB.Recordset
		
		OpenConnection(Cn, Config.ConnectionString)
		
		Rs.Open("Select * From observacion where ob_type='i'", Cn)
		While Not Rs.EOF
			TheItem = Me.lvInstrucciones.Items.Add("i_" & Rs.Fields("ob_id").Value, Rs.Fields("ob_desc").Value, "")
			Rs.MoveNext()
		End While
		Rs.Close()
		Cn.Close()
	End Sub
	Sub FillInstruccionesListEx()
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		Dim TheItem As System.Windows.Forms.ListViewItem
		Dim iResgID As Integer
		
		Cn = New ADODB.Connection
		Rs = New ADODB.Recordset
		iResgID = Val(Split(Me.Tag, "_")(1))
		
		OpenConnection(Cn, Config.ConnectionString)
		
		Rs.Open("Select * From observacion where ob_type='i'", Cn)
		While Not Rs.EOF
			If IsSelected(Rs.Fields("ob_id").Value, iResgID) Then
				TheItem = Me.lvInstrucciones.Items.Add("i_" & Rs.Fields("ob_id").Value, Rs.Fields("ob_desc").Value, "")
				TheItem.Checked = True
			Else
				TheItem = Me.lvInstrucciones.Items.Add("i_" & Rs.Fields("ob_id").Value, Rs.Fields("ob_desc").Value, "")
			End If
			Rs.MoveNext()
		End While
		Rs.Close()
		Cn.Close()
	End Sub
	
	
	
	
	Sub FillConducta()
		Dim iCount As Short
		Dim iCtr As Short
		Dim sThisItem As String
		
		iCount = CShort(GetINIValue(Config.ReportsPath & "data.ini", "Conducta", "Count"))
		
		For iCtr = 0 To iCount - 1
			sThisItem = GetINIValue(Config.ReportsPath & "data.ini", "Conducta", "Conducta" & iCtr)
			''Me.cmbConducta.AddItem sThisItem
		Next iCtr
		'Me.cmbConducta.ListIndex = 0
		
	End Sub
	
	
	
	
	
	Function GetModifiedText(ByRef iID As Short) As String
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		
		Cn = New ADODB.Connection
		Rs = New ADODB.Recordset
		
		OpenConnection(Cn, Config.ConnectionString)
		
		Rs.Open("Select * From rep_observaciones where ro_selectedid=" & iID, Cn, 3, 3)
		
		If Rs.RecordCount > 0 Then
			GetModifiedText = Rs.Fields("ro_selectedtext").Value
		Else
			GetModifiedText = "NAK"
		End If
		
		Rs.Close()
		Cn.Close()
	End Function
	
	Function IsSelected(ByRef iID As Short, ByRef iResgID As Integer) As Boolean
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		
		Cn = New ADODB.Connection
		Rs = New ADODB.Recordset
		
		OpenConnection(Cn, Config.ConnectionString)
		
		Rs.Open("Select * From rep_observaciones where ro_selectedid=" & iID & " and ro_resg_id=" & iResgID & ";", Cn, 3, 3)
		
		If Rs.RecordCount > 0 Then
			IsSelected = True
		Else
			IsSelected = False
		End If
		
		Rs.Close()
		Cn.Close()
	End Function
	
	
    Sub IsSelectedC(ByRef iID As Short, ByRef iResgID As Short)
        Dim IsSelectedA As Object
        Dim Cn As ADODB.Connection
        Dim Rs As ADODB.Recordset

        Cn = New ADODB.Connection
        Rs = New ADODB.Recordset

        OpenConnection(Cn, Config.ConnectionString)

        Rs.Open("Select * From rep_observaciones where ro_selectedid=" & iID & " and ro_resg_id=" & iResgID & ";", Cn, 3, 3)

        If Rs.RecordCount > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object IsSelectedA. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            IsSelectedA = True
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object IsSelectedA. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            IsSelectedA = False
        End If

        Rs.Close()
        Cn.Close()
    End Sub
	
	
	
	Sub StoreSelectedItems()
        Dim sQuery As String
        Dim Cn As New ADODB.Connection

        Dim iCtr As Short
		Dim sType As String
		Dim sResgID As Integer
		Dim sSelectedID As Short
        'Dim sSelectedText As String


		OpenConnection(Cn, Config.ConnectionString)
		
		sResgID = CInt(Split(Me.Tag, "_")(1))
		
		'-- DELETE ALL FOR THIS SECTION AND ADD NEW ONES
		sQuery = "delete from rep_observaciones where ro_resg_id=" & Val(CStr(sResgID))
        Cn.Execute(sQuery)
		
		'-- Ambiente
		sType = "a"
		With Me.lvAmbiente
			For iCtr = 1 To .Items.Count
				'UPGRADE_WARNING: Lower bound of collection Me.lvAmbiente.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				If .Items.Item(iCtr).Checked Then
					'UPGRADE_WARNING: Lower bound of collection Me.lvAmbiente.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					sSelectedID = CShort(Split(.Items.Item(iCtr).Name, "_")(1))
					'sSelectedText = .ListItems(iCtr).Text
					'sql = "insert into rep_observaciones (ro_resg_id,ro_type,ro_selectedid,ro_selectedtext) values (" & sResgID & ",'" & sType & "'," & sSelectedID & ",'" & sSelectedText & "')"
                    sQuery = "insert into rep_observaciones (ro_resg_id,ro_type,ro_selectedid) values (" & sResgID & ",'" & sType & "'," & sSelectedID & ")"
                    Cn.Execute(sQuery)
				End If
			Next iCtr
		End With
		
		'-- Instrucciones
		sType = "i"
		With Me.lvInstrucciones
			For iCtr = 1 To .Items.Count
				'UPGRADE_WARNING: Lower bound of collection Me.lvInstrucciones.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				If .Items.Item(iCtr).Checked Then
					'UPGRADE_WARNING: Lower bound of collection Me.lvInstrucciones.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					sSelectedID = CShort(Split(.Items.Item(iCtr).Name, "_")(1))
					'sSelectedText = .ListItems(iCtr).Text
					'sql = "insert into rep_observaciones (ro_resg_id,ro_type,ro_selectedid,ro_selectedtext) values (" & sResgID & ",'" & sType & "'," & sSelectedID & ",'" & sSelectedText & "')"
                    sQuery = "insert into rep_observaciones (ro_resg_id,ro_type,ro_selectedid) values (" & sResgID & ",'" & sType & "'," & sSelectedID & ")"
                    Cn.Execute(sQuery)
				End If
			Next iCtr
		End With
		
		'-- Conducta
		sType = "c"
		With Me.lvConducta
			For iCtr = 1 To .Items.Count
				'UPGRADE_WARNING: Lower bound of collection Me.lvConducta.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				If .Items.Item(iCtr).Checked Then
					'UPGRADE_WARNING: Lower bound of collection Me.lvConducta.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					sSelectedID = CShort(Split(.Items.Item(iCtr).Name, "_")(1))
					'sSelectedText = .ListItems(iCtr).Text
					'sql = "insert into rep_observaciones (ro_resg_id,ro_type,ro_selectedid,ro_selectedtext) values (" & sResgID & ",'" & sType & "'," & sSelectedID & ",'" & sSelectedText & "')"
                    sQuery = "insert into rep_observaciones (ro_resg_id,ro_type,ro_selectedid) values (" & sResgID & ",'" & sType & "'," & sSelectedID & ")"
                    Cn.Execute(sQuery)
				End If
			Next iCtr
		End With
		
		'-- Dificultades
		sType = "d"
		With Me.lvDificultades
			For iCtr = 1 To .Items.Count
				'UPGRADE_WARNING: Lower bound of collection Me.lvDificultades.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				If .Items.Item(iCtr).Checked Then
					'UPGRADE_WARNING: Lower bound of collection Me.lvDificultades.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					sSelectedID = CShort(Split(.Items.Item(iCtr).Name, "_")(1))
					'sSelectedText = .ListItems(iCtr).Text
					'sql = "insert into rep_observaciones (ro_resg_id,ro_type,ro_selectedid,ro_selectedtext) values (" & sResgID & ",'" & sType & "'," & sSelectedID & ",'" & sSelectedText & "')"
                    sQuery = "insert into rep_observaciones (ro_resg_id,ro_type,ro_selectedid) values (" & sResgID & ",'" & sType & "'," & sSelectedID & ")"
                    Cn.Execute(sQuery)
				End If
			Next iCtr
		End With
		
		'-- Recomendaciones
		sType = "r"
		With Me.lvRecomendaciones
			For iCtr = 1 To .Items.Count
				'UPGRADE_WARNING: Lower bound of collection Me.lvRecomendaciones.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				If .Items.Item(iCtr).Checked Then
					'UPGRADE_WARNING: Lower bound of collection Me.lvRecomendaciones.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					sSelectedID = CShort(Split(.Items.Item(iCtr).Name, "_")(1))
					'sSelectedText = .ListItems(iCtr).Text
                    sQuery = "insert into rep_observaciones (ro_resg_id,ro_type,ro_selectedid) values (" & sResgID & ",'" & sType & "'," & sSelectedID & ")"
                    Cn.Execute(sQuery)
				End If
			Next iCtr
		End With
	End Sub
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub
	
	Private Sub Command1_Click()
		
	End Sub
	
	Private Sub cmdSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.Click
		' -- Add selections to database
		Call StoreSelectedItems()
		
		' -- Flag parent as DONE
		'UPGRADE_WARNING: Lower bound of collection frmInformeConsultoresSectionsList.lvSections.ListItems() has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
		If frmInformeConsultoresSectionsList.lvSections.Items.Item(Split(Me.Tag, "_")(0) & "_" & Split(Me.Tag, "_")(1)).SubItems.Count > 3 Then
			frmInformeConsultoresSectionsList.lvSections.Items.Item(Split(Me.Tag, "_")(0) & "_" & Split(Me.Tag, "_")(1)).SubItems(3).Text = "Yes"
		Else
			frmInformeConsultoresSectionsList.lvSections.Items.Item(Split(Me.Tag, "_")(0) & "_" & Split(Me.Tag, "_")(1)).SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "Yes"))
		End If
		Me.Close()
	End Sub
	
	
	Private Sub Command2_Click()
		CalCaller = "DOS"
		frmConsultoresCalendar.ShowDialog()
	End Sub
	
	Private Sub Command3_Click()
		CalCaller = "ReposicionDate"
		frmConsultoresCalendar.ShowDialog()
	End Sub
	
	
	Private Sub Command4_Click()
		
	End Sub
	
	
	'UPGRADE_WARNING: Form event frmInformeConsultoresMain.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmInformeConsultoresMain_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		'MsgBox Me.Tag
		If Me.lvAmbiente.Items.Count = 0 Then
			Select Case Split(Me.Tag, "_")(2)
				Case "a"
					Call Me.FillAmbienteList()
					Call Me.FillInstruccionesList()
					Call Me.FillConductaList()
					Call Me.FillDificultadesList()
					Call Me.FillRecomendacionesList()
				Case "e"
					Call Me.FillAmbienteListEx()
					Call Me.FillInstruccionesListEx()
					Call Me.FillConductaListEx()
					Call Me.FillDificultadesListEx()
					Call Me.FillRecomendacionesListEx()
			End Select
		End If
	End Sub
	
	Private Sub frmInformeConsultoresMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.lbConsRepInstructions.Text = ""
		Me.lbConsRepInstructions.Text = Me.lbConsRepInstructions.Text & "Use the following lists to select observations and " & "recommendations for this section.  These selections will be " & "inserted into a pre-formated MS Word document for further editing."
	End Sub
	
	Private Sub ListView1_DblClick()
		'Load frmRecomendacionEdit
		'frmRecomendacionEdit.txtData = Me.ListView1.SelectedItem.Tag
		'frmRecomendacionEdit.Show vbModal
	End Sub
	
	
	Private Sub lvAmbiente_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvAmbiente.DoubleClick
		If Not Me.lvAmbiente.FocusedItem Is Nothing Then
			'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'

            '--Code Change-- jh' Load(frmEditConsEntry)
            Dim frmEditConsEntry As New frmEditConsEntry

            frmEditConsEntry.txtText.Text = Me.lvAmbiente.FocusedItem.Text
            frmEditConsEntry.Tag = "a"
            frmEditConsEntry.ShowDialog()
        End If
    End Sub


    Private Sub lvConducta_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvConducta.DoubleClick
        If Not Me.lvConducta.FocusedItem Is Nothing Then
            'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'

            '--Code Change-- jh'  Load(frmEditConsEntry)
            Dim frmEditConsEntry As New frmEditConsEntry

            frmEditConsEntry.txtText.Text = Me.lvConducta.FocusedItem.Text
            frmEditConsEntry.Tag = "c"
            frmEditConsEntry.ShowDialog()
        End If
    End Sub


    Private Sub lvDificultades_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvDificultades.DoubleClick
        If Not Me.lvDificultades.FocusedItem Is Nothing Then
            'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'

            '--Code Change-- jh' Load(frmEditConsEntry)
            Dim frmEditConsEntry As New frmEditConsEntry

            frmEditConsEntry.txtText.Text = Me.lvDificultades.FocusedItem.Text
            frmEditConsEntry.Tag = "d"
            frmEditConsEntry.ShowDialog()
        End If
    End Sub


    Private Sub lvInstrucciones_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvInstrucciones.DoubleClick
        If Not Me.lvInstrucciones.FocusedItem Is Nothing Then
            'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'

            '--Code Change-- jh' Load(frmEditConsEntry)
            Dim frmEditConsEntry As New frmEditConsEntry

            frmEditConsEntry.txtText.Text = Me.lvInstrucciones.FocusedItem.Text
            frmEditConsEntry.Tag = "i"
            frmEditConsEntry.ShowDialog()
        End If
    End Sub


    Private Sub lvRecomendaciones_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvRecomendaciones.DoubleClick
        If Not Me.lvRecomendaciones.FocusedItem Is Nothing Then
            'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'

            '--Code Change-- jh' Load(frmEditConsEntry)
            Dim frmEditConsEntry As New frmEditConsEntry

            frmEditConsEntry.txtText.Text = Me.lvRecomendaciones.FocusedItem.Text
            frmEditConsEntry.Tag = "r"
            frmEditConsEntry.ShowDialog()
        End If
    End Sub
End Class