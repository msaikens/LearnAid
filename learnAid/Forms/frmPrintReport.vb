Option Strict Off
Option Explicit On
Friend Class frmPrintReport
	Inherits System.Windows.Forms.Form
	Public iRepID As Integer
    Private RepType As Short

#Region "LEVEL ONE ROUTINES"
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks>
    '''            Called By: frmReportView.ToolBar1.Button_Click()
    ''' </remarks>
    Private Sub frmPrintReport_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.LoadData()
    End Sub
    ''' <summary>
    '''   This is the second print button on the form.
    '''   Top row, second from the left
    ''' </summary>
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks></remarks>
    Private Sub cmdContinue_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdContinue.Click
        Dim VC As New ValidateClass
        Dim Cn As New ADODB.Connection
        Dim Rs As New ADODB.Recordset

        If Not VC.ValidateForm(Me) Then
            Exit Sub
        End If

        LA_Declarations.OpenConnection(Cn, Config.ConnectionString)
        'OpenConnection(Cn, Config.ConnectionStringAdo)

        Rs.Open("Select * From Reports Where Rep_ID =" & iRepID.ToString.Trim, Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
        If Not Rs.EOF Then
            Rs.Fields("rep_indiv").Value = CBool(Me.chkIndiv.CheckState)
            Rs.Fields("rep_destrezas").Value = CBool(Me.chkDestrezas.CheckState)
            Rs.Fields("rep_mid").Value = CBool(Me.chkMID.CheckState)

            Rs.Fields("rep_regular").Value = CBool(Me.chkRegular.CheckState)
            Rs.Fields("rep_factura").Value = CBool(Me.chkInvoice.CheckState)
            Rs.Fields("rep_FromGrade").Value = Val(Me.txtFrom.Text)
            Rs.Fields("rep_ToGrade").Value = Val(Me.txtTo.Text)

            Rs.Update()
        End If
        Rs.Close()
        Cn.Close()
        Me.Hide()
        If CBool(Me.chk_preview.CheckState) Then
            Call LA_Declarations.PreviewReport(iRepID)
        Else
            Call LA_Declarations.PreviewReport(iRepID)
        End If
        Me.Close()
    End Sub
#End Region
#Region "LEVEL TWO ROUTINES"
    ''' <remarks>
    '''           Called By: frmPrintReport_Load()                  
    ''' </remarks>
    Sub LoadData()
        Dim Cn As New ADODB.Connection
        Dim Rs As New ADODB.Recordset
        LA_Declarations.OpenConnection(Cn, Config.ConnectionString)

        Rs.Open("Select * From Reports Where Rep_ID =" & iRepID.ToString.Trim, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not Rs.EOF Then
            RepType = Rs.Fields("rep_type").Value
            Me.lblReport.Text = iRepID.ToString.Trim
            Me.chkDestrezas.CheckState = IIf(Rs.Fields("rep_destrezas").Value, System.Windows.Forms.CheckState.Checked, System.Windows.Forms.CheckState.Unchecked)
            Me.chkIndiv.CheckState = IIf(Rs.Fields("rep_indiv").Value, System.Windows.Forms.CheckState.Checked, System.Windows.Forms.CheckState.Unchecked)
            Me.chkMID.CheckState = IIf(Rs.Fields("rep_mid").Value, System.Windows.Forms.CheckState.Checked, System.Windows.Forms.CheckState.Unchecked)
            Me.chkInvoice.CheckState = IIf(Rs.Fields("rep_factura").Value, System.Windows.Forms.CheckState.Checked, System.Windows.Forms.CheckState.Unchecked)
            Me.chkRegular.CheckState = IIf(Rs.Fields("rep_regular").Value, System.Windows.Forms.CheckState.Checked, System.Windows.Forms.CheckState.Unchecked)
            Me.txtFrom.Text = GetValue(Rs.Fields("rep_FromGrade"))
            Me.txtTo.Text = GetValue(Rs.Fields("rep_ToGrade"))

            Select Case RepType
                Case LA_Declarations.enumReportTypes.Entrance
                    Me.chkIndiv.CheckState = System.Windows.Forms.CheckState.Checked
                    Me.chkRegular.CheckState = System.Windows.Forms.CheckState.Checked
                    Me.chkMID.CheckState = System.Windows.Forms.CheckState.Unchecked
                    Me.chkDestrezas.CheckState = System.Windows.Forms.CheckState.Checked
                    Me.chkRegular.Enabled = True
                    Me.chkIndiv.Enabled = True
                    Me.chkMID.Enabled = False
                    Me.chkDestrezas.Enabled = True
                Case LA_Declarations.enumReportTypes.OfficeTesting
                    Me.chkIndiv.CheckState = System.Windows.Forms.CheckState.Checked
                    Me.chkMID.CheckState = System.Windows.Forms.CheckState.Unchecked
                    Me.chkRegular.CheckState = System.Windows.Forms.CheckState.Unchecked
                    Me.chkDestrezas.CheckState = System.Windows.Forms.CheckState.Unchecked
                    Me.chkIndiv.Enabled = False
                    Me.chkMID.Enabled = False
                    Me.chkRegular.Enabled = False
                    Me.chkDestrezas.Enabled = False
                Case LA_Declarations.enumReportTypes.Regular, LA_Declarations.enumReportTypes.AcomodoRazonable
                    Me.chkRegular.Enabled = True
                    Me.chkIndiv.Enabled = True
                    Me.chkMID.Enabled = True
                    Me.chkDestrezas.Enabled = True
            End Select
        Else
            MsgBox("Report was not found.", MsgBoxStyle.Critical)
            Me.Close()
        End If
        Rs.Close()
    End Sub
#End Region



	
	
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub
	
	
	

    Private Sub cmdLabel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLabel.Click
        Dim ReportFile As Object
        Dim VC As New ValidateClass
        Dim Cn As New ADODB.Connection
        Dim Rs As New ADODB.Recordset

        If Not VC.ValidateForm(Me) Then Exit Sub

        If MsgBox("Print Labels?", MsgBoxStyle.YesNo, "Labels") = MsgBoxResult.No Then
            Exit Sub
        End If

        OpenConnection(Cn, Config.ConnectionString)

        Rs.Open("Select * From Reports Where Rep_ID =" & iRepID, Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
        If Not Rs.EOF Then
            Rs.Fields("rep_FromGrade").Value = Val(Me.txtFrom.Text)
            Rs.Fields("rep_ToGrade").Value = Val(Me.txtTo.Text)
            Rs.Update()
        End If

        Rs.Close()
        Cn.Close()

        Me.Hide()
        Dim rptLabel As New Forms.ReportForms.frmReport
        'Dim CrxApp As New CRAXDRT.Application
        'Dim CrxRpt As CRAXDRT.Report
        If CBool(Me.chk_preview.CheckState) Then
            rptLabel.ReportID = iRepID
            rptLabel.ReportFile = Config.ReportsPath & "labels.rpt"
            rptLabel.Show()
            'Else
            '    'UPGRADE_WARNING: Couldn't resolve default property of object ReportFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '    ReportFile = Config.ReportsPath & "labels.rpt"
            '    'UPGRADE_WARNING: Couldn't resolve default property of object ReportFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '    CrxRpt = CrxApp.OpenReport(ReportFile)
            '    CrxRpt.ParameterFields(1).AddCurrentValue((iRepID))
            '    CrxRpt.PrintOut(False, 1, False)
            '    'UPGRADE_NOTE: Object CrxRpt may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            '    CrxRpt = Nothing
        End If

        Me.Close()

    End Sub

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        'Dim rptDesRen As New frmReport
        'If (iRepID) > 0 Then
        '    Me.Hide()
        '    'rptDesRen.ReportID = iRepID
        '    'rptDesRen.ReportFile = Config.ReportsPath & "DestrezasRENexp.rpt"
        '    'rptDesRen.Show()
        'End If
    End Sub

	
End Class