Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.Compatibility
Friend Class frmEditReport
	Inherits System.Windows.Forms.Form
	Public RepID As Integer
	Sub LoadData()
		Dim Cn As New ADODB.Connection
		Dim Rs As New ADODB.Recordset
		
		OpenConnection(Cn, Config.ConnectionString)
		
		Rs.Open("Select rep_cons_id,rep_serv_date,rep_reposicion from reports where rep_id =" & RepID, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
		If Not Rs.EOF Then
            Me.txtDate.Text = GetValue(Rs.Fields("rep_serv_date"))
			Call SelectItemWithID((Me.cboConsultant), GetValue(Rs.Fields("rep_cons_id"), 0))
            If IsDBNull(Rs.Fields("rep_reposicion").Value) Then
                Me.chkreposition.CheckState = System.Windows.Forms.CheckState.Unchecked
            ElseIf Rs.Fields("rep_reposicion").Value = False Then
                Me.chkreposition.CheckState = System.Windows.Forms.CheckState.Unchecked
            ElseIf Rs.Fields("rep_reposicion").Value = True Then
                Me.chkreposition.CheckState = System.Windows.Forms.CheckState.Checked
            End If
		End If
		
		Rs.Close()
		Cn.Close()
		
		
		
	End Sub
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub
	
	Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
		Dim Cn As New ADODB.Connection
		Dim sCmd As String
		
		sCmd = "Update Reports set rep_serv_date = '" & Me.txtDate.Text & "'," & " rep_cons_id = " & VB6.GetItemData(Me.cboConsultant, cboConsultant.SelectedIndex) & "," & " rep_reposicion = " & Me.chkreposition.CheckState & " Where Rep_Id =" & RepID
		
		OpenConnection(Cn, Config.ConnectionString)
		
		Cn.Execute(sCmd)
		
		If Me.chkreposition.CheckState = 0 Then
			'UPGRADE_WARNING: Lower bound of collection frmReportView.lvReports.SelectedItem.ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			frmReportView.lvReports.FocusedItem.SubItems.Item(6).Text = "No"
		Else
			'UPGRADE_WARNING: Lower bound of collection frmReportView.lvReports.SelectedItem.ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			frmReportView.lvReports.FocusedItem.SubItems.Item(6).Text = "Yes"
		End If
		Me.Close()
	End Sub
	
	Private Sub frmEditReport_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Call FillConsultantCBox((Me.cboConsultant), LA_Declarations.enumConsultantType.ctConsultant)
		Call LoadData()
	End Sub
	
	Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar1_Button1.Click
		Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
		
		CalCaller = "DOS_EDITREPORT"
		frmConsultoresCalendar.ShowDialog()
	End Sub
	
	Private Sub txtDate_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDate.Validating
		Dim Cancel As Boolean = eventArgs.Cancel
		Me.txtDate.Text = VB6.Format(Me.txtDate.Text, "mm/dd/yyyy")
        If Me.txtDate.Text <> "" And Not IsDBNull(Me.txtDate.Text) Then
            If IsDate(Me.txtDate.Text) = False Then
                MsgBox("Enter a valid date format")
                Cancel = True
            End If
        End If
		eventArgs.Cancel = Cancel
	End Sub
End Class