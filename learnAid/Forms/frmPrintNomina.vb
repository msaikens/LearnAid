Option Strict Off
Option Explicit On

Imports learnAid.Forms.ReportForms

Friend Class frmPrintNomina
    Inherits System.Windows.Forms.Form

    Public dNominaID As Double

#Region "LEVEL ONE ROUTINES"
    Private Sub CancelButton_Renamed_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CancelButton_Renamed.Click
        Me.Close()
    End Sub
    Private Sub OKButton_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles OKButton.Click
        Dim ReportFile As String
        Dim bPreview As Boolean
        Dim bSummary As Boolean
        Dim bDetailed As Boolean
        'Dim CrxApp As New CRAXDRT.Application
        'Dim CrxRpt As CRAXDRT.Report

        bPreview = CBool(chkPreview.CheckState)
        bDetailed = CBool(chkDetailed.CheckState)
        bSummary = CBool(chkSummary.CheckState)

        Me.Close()
        'TODO
        Dim Report As New frmReport
        Dim Report2 As New frmReport
        Dim Report3 As New frmReport
        Dim Report4 As New frmReport
        If bPreview Then
            If bSummary Then
                Report.ReportID = dNominaID
                If bTITULO1 Then
                    Report.ReportFile = Config.ReportsPath & "titulo1_nomina_examiners.rpt"
                Else
                    Report.ReportFile = Config.ReportsPath & "nomina_examiners.rpt"
                End If
                Report.Show()
            End If
            If bDetailed Then
                Report2.ReportID = dNominaID
                If bTITULO1 Then
                    Report2.ReportFile = Config.ReportsPath & "TITULO1_nomina_examiners_individual.rpt"
                Else
                    Report2.ReportFile = Config.ReportsPath & "nomina_examiners_individual.rpt"
                End If
                Report2.Show()
            End If
        Else
            frmMain.CDPrint.ShowDialog()
            If bSummary Then
                Report3.ReportID = dNominaID
                If bTITULO1 Then
                    Report3.ReportFile = Config.ReportsPath & "TITULO1_nomina_examiners.rpt"
                Else
                    Report3.ReportFile = Config.ReportsPath & "nomina_examiners.rpt"
                End If
                Report3.Show()
            End If
            If bDetailed Then
                Report4.ReportID = dNominaID
                If bTITULO1 Then
                    Report4.ReportFile = Config.ReportsPath & "TITULO1_nomina_examiners_individual.rpt"
                Else
                    Report4.ReportFile = Config.ReportsPath & "nomina_examiners_individual.rpt"
                End If
                Report4.Show()
            End If
        End If
    End Sub
#End Region

End Class