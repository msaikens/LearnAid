Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmConsultoresCalendar
	Inherits System.Windows.Forms.Form
	
	Sub DoSetValue()
		Select Case UCase(CalCaller)
			'    Case "DOS"
			'        frmInformeConsultoresMain.txtDoS = Calendar1.Month & "/" & Calendar1.Day & "/" & Calendar1.Year
			Case "REPOSICIONDATE"
                'frmInformeConsultoresSectionsList.txtReposicionDate.Text = Calendar1.Month & "/" & Calendar1.Day & "/" & Calendar1.Year
                frmInformeConsultoresSectionsList.dtReposicionDate.Text = Calendar1.Month & "/" & Calendar1.Day & "/" & Calendar1.Year
				'    Case "DOS_EDITREPORT"
				'        frmEditReport.txtDate = Calendar1.Month & "/" & Calendar1.Day & "/" & Calendar1.Year
				
		End Select
	End Sub
	
	Private Sub Calendar1_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Calendar1.DblClick
		DoSetValue()
		Me.Close()
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		DoSetValue()
		Me.Close()
	End Sub
	
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Calendar1.Day = VB.Day(Today)
		Calendar1.Month = Month(Today)
		Calendar1.Year = Year(Today)
	End Sub
	
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		Me.Close()
	End Sub
	
	
	Private Sub frmConsultoresCalendar_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'If frmInformeConsultoresSectionsList.txtReposicionDate.Text = "" Then
        If frmInformeConsultoresSectionsList.dtReposicionDate.Text = "" Then
            Me.Calendar1.Value = Today
        Else
            Me.Calendar1.Value = frmInformeConsultoresSectionsList.dtReposicionDate.Text
        End If
	End Sub
End Class