Option Strict Off
Option Explicit On
Imports learnAid.Forms.MasterForms
Imports learnAid.Forms.AccountingForms

Friend Class frmButtonPanel
	Inherits System.Windows.Forms.Form
	
	Private Sub LV_BeforeLabelEdit(ByRef Cancel As Short)
		
	End Sub
	
	
	Sub SetButtonPanel()
		ButtonsPanel.Height = ClientRectangle.Height		
		
	End Sub
		
	Private Sub ButtonsPanel_ItemClick(ByVal eventSender As System.Object, ByVal eventArgs As Axmccommandv102.__mcbarmenu_ItemClickEvent) Handles ButtonsPanel.ItemClick
		
		Select Case LoggedUser.UserType
			Case LA_Declarations.enumSecurityLevel.Administrator
				Select Case eventArgs.ItemIndex
					Case 1
                 
						
					Case 2
					
						
					Case 3
				
						
					Case 4
				
						
				End Select
				
			Case LA_Declarations.enumSecurityLevel.Consultant
				Select Case eventArgs.ItemIndex
					Case 1
						frmJobsView.Show()
                        Call FillJobsView2()
						If Not frmReportView Is Nothing Then frmReportView.Hide()
						If Not frmAccountingView Is Nothing Then frmAccountingView.Hide()
						If Not frmConsultantView Is Nothing Then frmConsultantView.Hide()
						frmJobsView.WindowState = System.Windows.Forms.FormWindowState.Maximized 'maximize
					Case 2
						frmReportView.Show()
						If Not frmJobsView Is Nothing Then frmJobsView.Hide()
						If Not frmAccountingView Is Nothing Then frmAccountingView.Hide()
						If Not frmConsultantView Is Nothing Then frmConsultantView.Hide()
						frmReportView.WindowState = System.Windows.Forms.FormWindowState.Maximized 'maximize
					Case 3
						frmConsultantView.Show()
						If Not frmJobsView Is Nothing Then frmJobsView.Hide()
						If Not frmReportView Is Nothing Then frmReportView.Hide()
						If Not frmAccountingView Is Nothing Then frmAccountingView.Hide()
				End Select
			Case LA_Declarations.enumSecurityLevel.accounting
				Select Case eventArgs.ItemIndex
					Case 1
						frmAccountingView.Show()
						If Not frmJobsView Is Nothing Then frmJobsView.Hide()
						If Not frmReportView Is Nothing Then frmReportView.Hide()
						If Not frmConsultantView Is Nothing Then frmConsultantView.Hide()
					Case 2
						frmReportView.Show()
						If Not frmJobsView Is Nothing Then frmJobsView.Hide()
						If Not frmAccountingView Is Nothing Then frmAccountingView.Hide()
						If Not frmConsultantView Is Nothing Then frmConsultantView.Hide()
				End Select
				
			Case LA_Declarations.enumSecurityLevel.DataEntry
				Select Case eventArgs.ItemIndex
					Case 1
						frmJobsView.Show()
                        Call FillJobsView2()
						If Not frmReportView Is Nothing Then frmReportView.Hide()
						If Not frmAccountingView Is Nothing Then frmAccountingView.Hide()
						If Not frmConsultantView Is Nothing Then frmConsultantView.Hide()
					Case 2
						frmReportView.Show()
						If Not frmJobsView Is Nothing Then frmJobsView.Hide()
						If Not frmAccountingView Is Nothing Then frmAccountingView.Hide()
						If Not frmConsultantView Is Nothing Then frmConsultantView.Hide()
				End Select
		End Select
		
		
	End Sub
	
	
	Private Sub frmButtonPanel_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Dim BI As mccommandv102.BarMenuItems
		With ButtonsPanel
			.ImageList = ImgMenuBar32
			.Add("Options")
			BI = .Item(1)
			
			Select Case LoggedUser.UserType
				Case LA_Declarations.enumSecurityLevel.Administrator
					BI.Add("Evaluations", "Evaluations")
					BI.Add("Accounting", "Accounting")
					BI.Add("Reports", "Reports")
					BI.Add("Consultant", "Reports")
				Case LA_Declarations.enumSecurityLevel.Consultant
					BI.Add("Evaluations", "Evaluations")
					BI.Add("Reports", "Reports")
					BI.Add("Consultant", "Reports")
				Case LA_Declarations.enumSecurityLevel.accounting
					BI.Add("Accounting", "Accounting")
					BI.Add("Reports", "Reports")
				Case LA_Declarations.enumSecurityLevel.DataEntry
					BI.Add("Evaluations", "Evaluations")
					BI.Add("Reports", "Reports")
					
			End Select
			
			
			.Redraw()
			
		End With
		
		
		Call SetButtonPanel()
		
	End Sub
	
	
	'UPGRADE_WARNING: Event frmButtonPanel.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmButtonPanel_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		Call SetButtonPanel()
	End Sub
End Class