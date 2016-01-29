Option Strict Off
Option Explicit On
Imports CrystalDecisions.CrystalReports.Engine
Namespace Forms.ReportForms
    Friend Class frmReport
        Inherits System.Windows.Forms.Form


        Public ReportID As Integer
        Public ReportFile As String
        Public FromGrade As Integer
        Public ToGrade As Integer
        Public isAR As Boolean

        ' CP 2015.02.27 - this is <bad>. opens a new instance every time regardless.
        'Dim CrxApp As New CRAXDRT.Application
        'Dim CrxRpt As New CRAXDRT.Report
        Dim CrxApp As CRAXDRT.Application
        Dim CrxRpt As CRAXDRT.Report

#Region "LEVEL ONE ROUTINES"
        Private Sub frmReport_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
            Dim X As Integer
            On Error GoTo Errores

            ' CP 2015.02.28 - redo using Crystal 11.5 viewer... or an attempt to 

            'CrxApp = New CRAXDRT.Application
            'CrxRpt = New CRAXDRT.Report

            Dim cryRpt As New ReportDocument
            cryRpt.Load(Me.ReportFile)
            cryRpt.SetParameterValue(0, Me.ReportID)
            'cryRpt.ParameterFields.Add(New CrystalDecisions.Shared.ParameterField(
            ' cryRpt.ParameterFields(1).CurrentValues.Add(New CrystalDecisions.Shared.parameterv
            CrystalReportViewer1.ReportSource = cryRpt
            CrystalReportViewer1.Refresh()

            'CrxRpt = CrxApp.OpenReport(ReportFile)
            'CrxRpt.ParameterFields(1).AddCurrentValue((Me.ReportID))
            'If Me.FromGrade > 0 Or isAR = True Then
            '    CrxRpt.ParameterFields(2).AddCurrentValue((Me.FromGrade))
            '    CrxRpt.ParameterFields(3).AddCurrentValue((Me.ToGrade))
            'End If

            'CrxRpt.Database.Tables(1).SetLogOnInfo("learnaid", "la", "sa", "")
            'UPGRADE_WARNING: Couldn't resolve default property of object CRViewer.ReportSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'CRViewer.ReportSource = CrxRpt
            'CRViewer.ViewReport()

            ' CrystalReportViewer1.ReportSource=CrxRpt
            ' CrystalReportViewer1.Show()
            'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            X = 1

Salir:
            Exit Sub
Errores:
            If Err.Number = -2147206460 Then
                MsgBox("Invalid Reports Path : " & vbCrLf & vbCrLf & ReportFile, MsgBoxStyle.Critical)
                Resume Salir
            Else
                MsgBox(Err.Number & " - " & Err.Description)
                Resume Salir
                Resume
            End If

        End Sub
        Private Sub frmReport_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
            CrxApp = Nothing
            CrxRpt = Nothing
        End Sub
        'UPGRADE_WARNING: Event frmReport.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub frmReport_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
            SetViewer()
        End Sub
#End Region
#Region "LEVEL TWO ROUTINES"
        'Called By: frmReport.frmReport_Resize()
        Sub SetViewer()

            'CRViewer.Top = 0
            'CRViewer.Left = 0
            'CRViewer.Width = Me.Width
            'CRViewer.Height = Me.Height
        End Sub
#End Region
    End Class
End Namespace