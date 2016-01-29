Option Strict Off
Option Explicit On
Friend Class frmT1Dist
	Inherits System.Windows.Forms.Form
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
		On Error GoTo err_rtn
		Dim a As Object
		
		'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		a = Me.txtDesde.Text
		ShowCalendar(a, Me.txtDesde)
		'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Me.txtDesde.Text = a
		
err_cont: 
		Exit Sub
		
err_rtn: 
		MsgBox("Calendar cann't be display")
		Resume err_cont
		
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) 
		On Error GoTo err_rtn
		Dim a As Object
		
		'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		a = Me.txtHasta.Text
		ShowCalendar(a, Me.txtHasta)
		'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Me.txtHasta.Text = a
		
err_cont: 
		Exit Sub
		
err_rtn: 
		MsgBox("Calendar cann't be display")
		Resume err_cont
		
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		ConsultantMod.CreateT1_Dist_Report()
		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
		'UPGRADE_ISSUE: Form property frmT1Dist.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        '--Code Change-- jh'Me.Cursor = vbNormal
        Me.Cursor = Cursors.Default

	End Sub
	
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
		Me.Close()
	End Sub
	
	Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
		Dim ReportFile As Object
		
		Dim CrxApp As New CRAXDRT.Application
		Dim CrxRpt As CRAXDRT.Report
		
		If Me.cboComp.Text <> "" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ReportFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ReportFile = Config.ReportsPath & "T1_DestrezasColegio.rpt"
			'UPGRADE_WARNING: Couldn't resolve default property of object ReportFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CrxRpt = CrxApp.OpenReport(ReportFile)
			CrxRpt.ParameterFields(1).AddCurrentValue((Me.cboComp.Text))
			CrxRpt.ParameterFields(2).AddCurrentValue((Me.cboSem.Text))
			'UPGRADE_WARNING: DateValue has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			CrxRpt.ParameterFields(3).AddCurrentValue(DateValue(Me.txtDesde.Text))
			'UPGRADE_WARNING: DateValue has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			CrxRpt.ParameterFields(4).AddCurrentValue(DateValue(Me.txtHasta.Text))
			CrxRpt.PrintOut(True, 1, False)
			'UPGRADE_NOTE: Object CrxRpt may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			CrxRpt = Nothing
		End If
		
	End Sub
	
	Private Sub frmT1Dist_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		cboSem.Items.Add("1")
		cboSem.Items.Add("2")
		cboSem.SelectedIndex = 0
		
		cboComp.Items.Add("BRAXTON")
		cboComp.Items.Add("NETS")
		cboComp.Items.Add("COSEY")
		cboComp.Items.Add("PROFESSIONAL")
		cboComp.Items.Add("VERNET")
		cboSem.SelectedIndex = 0
		
		txtDesde.Text = CStr(Today)
		txtHasta.Text = CStr(Today)
		
	End Sub
End Class