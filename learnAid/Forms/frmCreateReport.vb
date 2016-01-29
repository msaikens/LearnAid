Option Strict Off
Option Explicit On

Imports System.Data.SqlClient
Imports ADODB
Imports learnAid.Forms.ReportForms

Friend Class frmCreateReport
    Inherits Form
    Public RptType As Short
    Private oldRptType As Short
    Public bPEP As Boolean

    '0 - Office Testing
    '1 - Entrance
    '2 - Regular
    '3 - Acomodo Razonable
#Region "LEVEL ONE ROUTINES"
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks>
    '''           Called By: frmReportView.ToolBar1.ButtonMenu_Click()
    ''' </remarks>
    Private Sub frmCreateReport_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        cmdContinue.Enabled = False
        cmdPrevious.Enabled = False
        Me.lvJobs.Columns(0).Width = 240
        Me.lvJobs.Columns(1).Width = 170
        Me.lvJobs.Columns(2).Width = 80

        Me.txtYear.Text = Year(Today).ToString
        Me.chk_preview.CheckState = False

        Call LA_Declarations.FillSchoolCbox((Me.cboSchool))
        Call LA_Declarations.FillSemesterCbox((Me.cboSemester))

        Select Case RptType
            Case enumReportTypes.Regular, enumReportTypes.AcomodoRazonable ' REGULAR
                Me.Text = "Create Report (REGULAR)"
                chkIndiv.Enabled = True
                chkRegular.Enabled = True
                chkMID.Enabled = True
                chkDestrezas.Enabled = True

                chkComp.Enabled = True

                chkIndiv.CheckState = CheckState.Checked
                chkRegular.CheckState = CheckState.Checked
                chkMID.CheckState = CheckState.Checked
                chkDestrezas.CheckState = CheckState.Checked
                chkComp.CheckState = CheckState.Checked
            Case enumReportTypes.OfficeTesting 'OFFICE TESTING
                Me.cboSchool.Tag = ""
                Me.Text = "Create Report (OFFICE TESTING)"
                Me.cboSchool.Enabled = True
                chkIndiv.Enabled = False
                chkRegular.Enabled = False
                chkMID.Enabled = False
                chkDestrezas.Enabled = False
                chkComp.Enabled = False

                chkIndiv.CheckState = CheckState.Checked
                chkRegular.CheckState = CheckState.Unchecked
                chkMID.CheckState = CheckState.Unchecked
                chkDestrezas.CheckState = CheckState.Unchecked
                chkComp.CheckState = CheckState.Unchecked
            Case enumReportTypes.Entrance ' ENTRANCE
                Me.Text = "Create Report (ENTRANCE)"
                chkIndiv.Enabled = True
                chkMID.Enabled = False
                chkRegular.Enabled = True
                chkDestrezas.Enabled = True
                chkComp.Enabled = False

                chkIndiv.CheckState = CheckState.Checked
                chkMID.CheckState = CheckState.Unchecked
                chkDestrezas.CheckState = CheckState.Checked
                chkRegular.CheckState = CheckState.Checked
                chkComp.CheckState = CheckState.Unchecked
        End Select
    End Sub

    Private Sub cmdCancel_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdContinue_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdContinue.Click

        Dim VC As New ValidateClass

        If Not VC.ValidateForm(Me) Then
            Exit Sub
        End If
        If Val(txtTo.Text) < Val(txtFrom.Text) Then
            Exit Sub
        End If

        If CBool(chkPEP.CheckState) Then
            Call CreatePEP()
        ElseIf CBool(chkExperimental.CheckState) Then
            Call CreateExp()
        Else
            Me.CreateRegular()
        End If

    End Sub

    Private Sub cmdPrevious_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdPrevious.Click
        With frmPreviousRpts
            .RepType = Me.RptType
            .Sch = Microsoft.VisualBasic.Compatibility.VB6.GetItemData(cboSchool, cboSchool.SelectedIndex)
            .Show()
        End With
    End Sub

    Private Sub Command3_Click()
        Me.Close()
    End Sub
#End Region
#Region "LEVEL TWO ROUTINES"
    'Called By: frmCreateReport_Load()
    'UPGRADE_WARNING: Event chkAcomodo.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chkAcomodo_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) _
        Handles chkAcomodo.CheckStateChanged
        If CBool(chkAcomodo.CheckState) Then
            ' -- BEGIN JuanCa Greatest Hammer Part 1--
            oldRptType = RptType
            RptType = 3
            ' -- END JuanCa Greatest Hammer Part 1 --
        Else
            ' -- BEGIN JuanCa Greatest Hammer Part 2--
            RptType = oldRptType
            ' -- END JuanCa Greatest Hammer Part 2--
        End If
        Call SetButtons()
    End Sub
    'UPGRADE_WARNING: Event chkPEP.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub chkPEP_CheckStateChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) _
        Handles chkPEP.CheckStateChanged
        If CBool(chkPEP.CheckState) Then
            chkAcomodo.CheckState = CheckState.Unchecked
            chkIndiv.Enabled = True
            chkRegular.Enabled = True
            chkMID.Enabled = False
            chkDestrezas.Enabled = False
            chkComp.Enabled = False
            chkIndiv.CheckState = CheckState.Checked
            chkRegular.CheckState = CheckState.Checked
            chkMID.CheckState = CheckState.Unchecked
            chkDestrezas.CheckState = CheckState.Unchecked
            chkComp.CheckState = CheckState.Unchecked
        Else
            Select Case RptType
                Case enumReportTypes.OfficeTesting 'OFFICE TESTING
                    Me.Text = "Create Report (OFFICE TESTING)"
                    Me.cboSchool.Enabled = False
                    chkIndiv.Enabled = False
                    chkRegular.Enabled = False
                    chkMID.Enabled = False
                    chkDestrezas.Enabled = False
                    chkComp.Enabled = False
                    Me.chkInvoice.Enabled = False

                    chkIndiv.CheckState = CheckState.Checked
                    chkRegular.CheckState = CheckState.Unchecked
                    chkMID.CheckState = CheckState.Unchecked
                    chkDestrezas.CheckState = CheckState.Unchecked
                    chkComp.CheckState = CheckState.Unchecked
                    Me.chkInvoice.CheckState = CheckState.Unchecked


                Case enumReportTypes.Entrance ' ENTRANCE
                    Me.Text = "Create Report (ENTRANCE)"
                    chkIndiv.Enabled = False
                    chkMID.Enabled = False
                    chkRegular.Enabled = False
                    chkDestrezas.Enabled = False
                    chkComp.Enabled = False

                    chkIndiv.CheckState = CheckState.Checked
                    chkMID.CheckState = CheckState.Unchecked
                    chkDestrezas.CheckState = CheckState.Checked
                    chkRegular.CheckState = CheckState.Unchecked
                    chkComp.CheckState = CheckState.Unchecked

                Case enumReportTypes.Regular, enumReportTypes.AcomodoRazonable ' REGULAR
                    Me.Text = "Create Report (REGULAR)"
                    chkIndiv.Enabled = True
                    chkRegular.Enabled = True
                    chkMID.Enabled = True
                    chkDestrezas.Enabled = True

                    chkComp.Enabled = True

                    chkIndiv.CheckState = CheckState.Checked
                    chkRegular.CheckState = CheckState.Checked
                    chkMID.CheckState = CheckState.Checked
                    chkDestrezas.CheckState = CheckState.Checked
                    chkComp.CheckState = CheckState.Checked

            End Select
        End If
        Call SetButtons()
    End Sub
    'UPGRADE_WARNING: Event cboSchool.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cboSchool_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cboSchool.SelectedIndexChanged
        Me.SetButtons()
    End Sub
    'UPGRADE_WARNING: Event cboSemester.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks>
    '''          Called By: LA_Declarations.GetSemester()
    ''' </remarks>
    Private Sub cboSemester_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cboSemester.SelectedIndexChanged
        Me.SetButtons()
    End Sub
    'UPGRADE_WARNING: Event txtYear.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks>
    '''          Called By frmCreateReport.Form_Load()
    ''' </remarks>
    Private Sub txtYear_TextChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles txtYear.TextChanged
        Me.SetButtons()
    End Sub

    'Called By: cmdContinue_Click()
    Sub CreateExp()
        Dim FromGrade As Short
        Dim Rep_ID As Integer
        Dim ServDate As Object
        Dim ToGrade As Short

        Dim Cn As New Connection
        Dim Rs As New Recordset
        Dim RsRep As New Recordset
        Dim sQuery As String

        OpenConnection(Cn, Config.ConnectionString)

        RsRep.Open("Select * From Reports where rep_id =-1", Cn, CursorTypeEnum.adOpenKeyset,
                   LockTypeEnum.adLockPessimistic)

        FromGrade = Val(txtFrom.Text)
        ToGrade = Val(txtTo.Text)

        RsRep.AddNew()
        RsRep.Fields("rep_type").Value = RptType
        RsRep.Fields("rep_sch_id").Value = Microsoft.VisualBasic.Compatibility.VB6.GetItemData(cboSchool,
                                                                                               cboSchool.SelectedIndex)
        RsRep.Fields("Rep_Year").Value = Me.txtYear.Text
        RsRep.Fields("Rep_Sem").Value = Microsoft.VisualBasic.Compatibility.VB6.GetItemData(cboSemester,
                                                                                            cboSemester.SelectedIndex)
        RsRep.Fields("rep_indiv").Value = False
        RsRep.Fields("rep_mid").Value = False
        RsRep.Fields("rep_regular").Value = True
        RsRep.Fields("rep_destrezas").Value = True
        RsRep.Fields("rep_factura").Value = 0
        RsRep.Fields("rep_comp").Value = 0
        RsRep.Fields("rep_FromGrade").Value = FromGrade
        RsRep.Fields("rep_ToGrade").Value = ToGrade
        RsRep.Fields("Rep_AcomRazonable").Value = False
        RsRep.Fields("rep_reposicion").Value = True
        RsRep.Update()
        Rep_ID = RsRep.Fields("Rep_ID").Value
        RsRep.Close()

        If RptType <> 0 Then
            sQuery =
                "Select Jobs.*,Schools.SC_SCH_NAME From Jobs left outer join SCHOOLS ON Jobs.J_SCH = SCHOOLS.SC_ID WHERE "
            sQuery = sQuery & " Year(Jobs.J_DATE) = " & Me.txtYear.Text & " AND "
            sQuery = sQuery & " Jobs.J_Type = " & Me.RptType & " AND "
            sQuery = sQuery & " Jobs.J_USER = '" & LoggedUser.UserID & "' AND "
            sQuery = sQuery & " Jobs.J_SCH = " &
                     Microsoft.VisualBasic.Compatibility.VB6.GetItemData(Me.cboSchool, Me.cboSchool.SelectedIndex) &
                     " AND "
            sQuery = sQuery & " Jobs.J_SEM = " &
                     Microsoft.VisualBasic.Compatibility.VB6.GetItemData(Me.cboSemester, Me.cboSemester.SelectedIndex) &
                     " AND "
            sQuery = sQuery & " Jobs.J_Printed = 0 AND Jobs.J_Status = 4 AND Jobs.J_AcomRazonable = " &
                     chkAcomodo.CheckState
        Else
            sQuery = "Select Jobs.* From Jobs WHERE "
            sQuery = sQuery & " Year(Jobs.J_DATE) = " & Me.txtYear.Text & " AND "
            sQuery = sQuery & " Jobs.J_Type = " & Me.RptType & " AND "
            sQuery = sQuery & " Jobs.J_USER = '" & LoggedUser.UserID & "' AND "
            sQuery = sQuery & " Jobs.J_SEM = " &
                     Microsoft.VisualBasic.Compatibility.VB6.GetItemData(Me.cboSemester, Me.cboSemester.SelectedIndex) &
                     " AND "
            sQuery = sQuery & " Jobs.J_Printed = 0 AND Jobs.J_Status = 4 AND Jobs.J_AcomRazonable = " &
                     chkAcomodo.CheckState
        End If

        If CBool(chkPEP.CheckState) Then
            sQuery = sQuery & " AND IsNull(Jobs.J_PEPV,0) = 52 "
        Else
            sQuery = sQuery & " AND IsNull(Jobs.J_PEPV,0) <> 52 "
        End If

        Rs.Open(sQuery, Cn, 1, 3, 0)

        While Not Rs.EOF
            Select Case Rs.Fields("J_REN").Value
                Case 55
                    Rs.Fields("j_rep_name").Value = "REN-12A"
                Case 56
                    Rs.Fields("j_rep_name").Value = "REN-12"
                Case 61
                    Rs.Fields("j_rep_name").Value = "REN-34"
                Case 62
                    Rs.Fields("j_rep_name").Value = "REN-23"
                Case 63
                    Rs.Fields("j_rep_name").Value = "REN-34NE"
                Case 67
                    Rs.Fields("j_rep_name").Value = "REN-56N"
                Case 64
                    Rs.Fields("j_rep_name").Value = "REN-45N"
            End Select
            'UPGRADE_WARNING: Couldn't resolve default property of object Rep_ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Rs.Fields("j_rep_id").Value = Rep_ID
            Rs.Fields("j_printed").Value = True
            'UPGRADE_WARNING: Couldn't resolve default property of object ServDate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ServDate = Rs.Fields("J_Serv_Date").Value
            Rs.Update()
            Rs.MoveNext()
        End While

        Rs.Close()

        'Update the ServDate to the report
        'UPGRADE_WARNING: Couldn't resolve default property of object Rep_ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ServDate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Cn.Execute("Update Reports Set Rep_Serv_Date ='" & ServDate & "' Where Rep_ID = " & Rep_ID)

        Cn.Close()

        'TODO:
        Dim rptPepGrupal As New frmReport
        ''UPGRADE_WARNING: Couldn't resolve default property of object Rep_ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        rptPepGrupal.ReportID = Rep_ID
        rptPepGrupal.ReportFile = Config.ReportsPath & "DestrezasRENExp.rpt"
        rptPepGrupal.Show()
    End Sub
    'Called By: cmdContinue_Click()
    Sub CreatePEP()

        Dim Cn As New Connection
        Dim FromGrade As Short
        Dim Rep_ID As Integer
        Dim Result As MsgBoxResult
        Dim Rs As New Recordset
        Dim Sch As Integer
        Dim Sem As Short
        Dim ToGrade As Short

        Sch = Microsoft.VisualBasic.Compatibility.VB6.GetItemData(cboSchool, cboSchool.SelectedIndex)
        Sem = Microsoft.VisualBasic.Compatibility.VB6.GetItemData(cboSemester, cboSemester.SelectedIndex)

        'Buscamos el desde que grado y hasta que grado se va a imprimir el reporte
        FromGrade = Val(txtFrom.Text)
        ToGrade = Val(txtTo.Text)

        If JobsNotCompleted(Me.RptType, Sch, Val(txtYear.Text), Sem, chkAcomodo.CheckState, chkPEP.CheckState) Then
            Result = MsgBox("There are one or more jobs without completing. Do you want to proceed with the report?",
                            MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If Result = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        Rep_ID = ReportExist(RptType, Sch, Val(txtYear.Text), Sem, chkAcomodo.CheckState, chkPEP.CheckState)
        If Rep_ID > 0 Then
            Result =
                MsgBox(
                    "The requested report already exist. Do you want to recreate it?" & vbCrLf & vbCrLf &
                    "YES        : Re-create and Print  the report" & vbCrLf & "NO          : Print the report" & vbCrLf &
                    "CANCEL : Do not print the report.", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel)
            If Result = MsgBoxResult.Yes Then
                Call DeleteReport(Rep_ID)
                Call _
                    CreatePepReport(Me.RptType, Sch, Val(txtYear.Text), Sem, CBool(chkIndiv.CheckState),
                                    CBool(chkMID.CheckState), CBool(chkDestrezas.CheckState), CBool(chkComp.CheckState),
                                    CBool(chkInvoice.CheckState), CBool(chkRegular.CheckState), FromGrade, ToGrade,
                                    chkAcomodo.CheckState)
            ElseIf Result = MsgBoxResult.Cancel Then
                Exit Sub
            End If
        Else
            Call _
                CreatePepReport(Me.RptType, Sch, Val(txtYear.Text), Sem, CBool(chkIndiv.CheckState),
                                CBool(chkMID.CheckState), CBool(chkDestrezas.CheckState), CBool(chkComp.CheckState),
                                CBool(chkInvoice.CheckState), CBool(chkRegular.CheckState), FromGrade, ToGrade,
                                chkAcomodo.CheckState)

        End If


        Me.Close()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks>
    '''          'Called By: frmCreateReport.cmdContinue_Click()
    ''' </remarks>
    Sub CreateRegular()
        Dim Cn As New Connection
        Dim Rs As New Recordset
        Dim Sch As Integer
        Dim schstr() As String
        Dim Sem As Short
        Dim Rep_ID As Integer
        Dim Result As MsgBoxResult
        Dim FromGrade As Short
        Dim ToGrade As Short

        'Sch = Microsoft.VisualBasic.Compatibility.VB6.GetItemData(cboSchool, cboSchool.SelectedIndex)
        'Sem = Microsoft.VisualBasic.Compatibility.VB6.GetItemData(cboSemester, cboSemester.SelectedIndex)

        schstr = Split(cboSchool.SelectedItem.ToString, " - ")
        Sch = Val(schstr(0))
        Sem = cboSemester.SelectedIndex

        'Buscamos el desde que grado y hasta que grado se va a imprimir el reporte
        FromGrade = Val(txtFrom.Text)
        ToGrade = Val(txtTo.Text)

        If Me.chkAcomodo.CheckState = CheckState.Checked Then Me.RptType = 3 'Acomodo Razonable

        If LA_Declarations.JobsNotCompleted(Me.RptType, Sch, Val(txtYear.Text), Sem, chkAcomodo.CheckState, chkPEP.CheckState) Then
            Result = MsgBox("There are one or more jobs without completing. Do you want to proceed with the report?",
                            MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If Result = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        If RptType = 2 Then
            'Rep_ID = ReportExist(RptType, Sch, Val(txtYear), Sem, chkAcomodo, chkPEP)
            Rep_ID = 0
        Else
            Rep_ID = 0
        End If

        If Rep_ID > 0 Then
            Result =
                MsgBox(
                    "The requested report already exist. Do you want to recreate it?" & vbCrLf & vbCrLf &
                    "YES        : Re-create and Print  the report" & vbCrLf & "NO          : Print the report" & vbCrLf &
                    "CANCEL : Do not print the report.", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel)
            If Result = MsgBoxResult.Yes Then
                Call DeleteReport(Rep_ID)
                Call _
                    LA_Declarations.CreateReport(Me.RptType, Sch, Val(txtYear.Text), Sem, CBool(chkIndiv.CheckState),
                                 CBool(chkMID.CheckState), CBool(chkDestrezas.CheckState), CBool(chkComp.CheckState),
                                 CBool(chkInvoice.CheckState), CBool(chkRegular.CheckState), FromGrade, ToGrade,
                                 chkAcomodo.CheckState, chkReposition.CheckState)
            ElseIf Result = MsgBoxResult.Cancel Then
                Exit Sub
            End If
        Else
            Call _
                LA_Declarations.CreateReport(Me.RptType, Sch, Val(txtYear.Text), Sem, CBool(chkIndiv.CheckState),
                             CBool(chkMID.CheckState), CBool(chkDestrezas.CheckState), CBool(chkComp.CheckState),
                             CBool(chkInvoice.CheckState), CBool(chkRegular.CheckState), FromGrade, ToGrade,
                             chkAcomodo.CheckState, chkReposition.CheckState)
        End If
        Me.Close()
    End Sub

#End Region
#Region "LEVEL THREE ROUTINES"
    ''' <remarks>
    '''           Called By: frmCreateReport.txtYear_TextChanged()
    '''           Called By: frmCreateReport.cboSchool.SelectedIndex_Changed()
    '''           Called By: frmCreateReport.cboSemester.SelectedIndex_Changed()
    ''' </remarks>
    Sub SetButtons()
        If Me.RptType <> enumReportTypes.OfficeTesting Then
            If Val(txtYear.Text) > 0 And cboSchool.Text <> String.Empty And cboSemester.Text <> String.Empty Then
                cmdContinue.Enabled = True
                cmdPrevious.Enabled = True
                Me.FillJobsPending()
                If Val(lblPending.Text) > 0 Then
                    cmdContinue.Enabled = True
                Else
                    cmdContinue.Enabled = False 'Esta linea estaba en comentario
                End If
            Else
                cmdContinue.Enabled = False 'Esta linea estaba en comentario
                cmdPrevious.Enabled = False
                lvJobs.Items.Clear()
                lblPending.Text = String.Empty
            End If
        Else
            If Val(txtYear.Text) > 0 And cboSemester.Text <> String.Empty Then
                cmdContinue.Enabled = True
                cmdPrevious.Enabled = True
                Me.FillJobsPending()
                If Val(lblPending.Text) > 0 Then
                    cmdContinue.Enabled = True
                Else
                    cmdContinue.Enabled = False 'Esta linea estaba en comentario
                End If
            Else
                cmdContinue.Enabled = False 'Esta linea estaba en comentario
                cmdPrevious.Enabled = False
                lvJobs.Items.Clear()
                lblPending.Text = String.Empty
            End If
        End If
    End Sub
#End Region
#Region "LEVEL FOUR ROUTINES"
    ''' <remarks>
    '''          Called By: frmCreateReport.SetButtons()
    ''' </remarks>
    Sub FillJobsPending()
        Dim Cn As New Connection
        Dim Rs As New Recordset
        Dim Item As ListViewItem
        Dim sQuery As String
        Dim schoolids() As String
        Dim id As String

        schoolids = Split(cboSchool.SelectedItem.ToString, " - ")
        id = Val(schoolids(0))


        'MessageBox.Show(cboSemester.SelectedIndex.ToString, "Test", MessageBoxButtons.OK)
        If RptType <> 0 Then
            'sQuery = "Select Jobs.*,Schools.SC_SCH_NAME From Jobs left outer join SCHOOLS ON Jobs.J_SCH = SCHOOLS.SC_ID WHERE "
            'sQuery = sQuery & " Year(Jobs.J_DATE) = " & Me.txtYear.Text & " AND "
            'sQuery = sQuery & " Jobs.J_Type = " & Me.RptType & " AND "
            'sQuery = sQuery & " Jobs.J_USER = '" & LoggedUser.UserID & "' AND "
            'sQuery = sQuery & " Jobs.J_SCH = " &
            '         cboSchool.SelectedIndex.ToString &
            '         " AND "
            'sQuery = sQuery & " Jobs.J_SEM = " &
            '         cboSemester.SelectedIndex.ToString &
            '         " AND "
            'sQuery = sQuery & " Jobs.J_Status = 4 AND Jobs.J_AcomRazonable = " &
            '         chkAcomodo.CheckState

            sQuery = "Select Jobs.*,Schools.SC_SCH_NAME From Jobs left outer join SCHOOLS ON Jobs.J_SCH = SCHOOLS.SC_ID WHERE "
            sQuery &= " Year(Jobs.J_DATE) = " & Me.txtYear.Text & " AND "
            sQuery &= " Jobs.J_Type = " & Me.RptType & " AND "
            sQuery &= " Jobs.J_USER = '" & LoggedUser.UserID & "' AND "
            sQuery &= " Jobs.J_SCH = " & id.Trim & " AND "
            sQuery &= " Jobs.J_SEM = " & cboSemester.SelectedIndex.ToString & " AND "
            sQuery &= " Jobs.J_Status = 4 AND Jobs.J_AcomRazonable = " & chkAcomodo.CheckState
        Else
            sQuery = "Select Jobs.* From Jobs WHERE "
            sQuery &= " Year(Jobs.J_DATE) = " & Me.txtYear.Text & " AND "
            sQuery &= " Jobs.J_Type = " & Me.RptType.ToString.Trim & " AND "
            sQuery &= " Jobs.J_USER = '" & LoggedUser.UserID.Trim & "' AND "
            sQuery &= " Jobs.J_SEM = " & cboSemester.SelectedIndex.ToString & " AND "
            sQuery &= " Jobs.J_Printed = 0 AND Jobs.J_Status = 4 AND Jobs.J_AcomRazonable = " & chkAcomodo.CheckState
        End If

        If CBool(chkPEP.CheckState) Then
            sQuery &= " AND IsNull(Jobs.J_PEPV,0) = 52 "
        Else
            sQuery &= " AND IsNull(Jobs.J_PEPV,0) <> 52 "
        End If

        LA_Declarations.OpenConnection(Cn, Config.ConnectionString)

        Rs.Open(sQuery, Cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)

        lvJobs.Items.Clear()
        'MessageBox.Show(Rs.Fields("j_type").Value.ToString, "test", MessageBoxButtons.OK)
        While Not Rs.EOF
            If Rs.Fields("j_type").Value = 0 Then
                Item = Me.lvJobs.Items.Add("J" & Rs.Fields("j_id").Value, "Multiple Schools", "")
            Else
                Item = Me.lvJobs.Items.Add("J" & Rs.Fields("j_id").Value, LA_Declarations.GetValue(Rs.Fields("sc_sch_name")), "")
            End If
            If Item.SubItems.Count > 1 Then
                Item.SubItems(1).Text = Rs.Fields("J_DATE").Value
            Else
                Item.SubItems.Insert(1, New ListViewItem.ListViewSubItem(Nothing, Rs.Fields("J_DATE").Value))
            End If
            If Item.SubItems.Count > 2 Then
                Item.SubItems(2).Text = LA_Declarations.GetGradeName(Rs.Fields("J_GRADE").Value)
            Else
                Item.SubItems.Insert(2,
                                     New ListViewItem.ListViewSubItem(Nothing, LA_Declarations.GetGradeName(Rs.Fields("J_GRADE").Value)))
            End If
            If Item.SubItems.Count > 3 Then
                Item.SubItems(3).Text = Rs.Fields("J_SEC").Value
            Else
                Item.SubItems.Insert(3, New ListViewItem.ListViewSubItem(Nothing, Rs.Fields("J_SEC").Value))
            End If
            If Item.SubItems.Count > 4 Then
                Item.SubItems(4).Text = Rs.Fields("J_TOTAL_EST").Value
            Else
                Item.SubItems.Insert(4, New ListViewItem.ListViewSubItem(Nothing, Rs.Fields("J_TOTAL_EST").Value))
            End If
            Rs.MoveNext()
        End While

        If Rs.RecordCount = 0 Then
            Item = Me.lvJobs.Items.Add("No Jobs Pending...")
        End If
        lblPending.Text = Rs.RecordCount.ToString.Trim

        Rs.Close()
        Cn.Close()
    End Sub
#End Region

#Region "Unknown Routines"
    Sub CreateOT()
        Dim Result As MsgBoxResult
        Dim Cn As New Connection
        Dim Rs As New Recordset
        Dim Sch As Integer
        Dim Sem As Short
        Dim Rep_ID As Integer
        Dim FromGrade As Short
        Dim ToGrade As Short

        Sch = 0
        Sem = Microsoft.VisualBasic.Compatibility.VB6.GetItemData(cboSemester, cboSemester.SelectedIndex)

        'Buscamos el desde que grado y hasta que grado se va a imprimir el reporte
        FromGrade = Val(txtFrom.Text)
        ToGrade = Val(txtTo.Text)


        If JobsNotCompleted(Me.RptType, Sch, Val(txtYear.Text), Sem, Me.chkAcomodo.CheckState, chkPEP.CheckState) Then
            'UPGRADE_WARNING: Couldn't resolve default property of object Result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Result = MsgBox("There are one or more jobs without completing. Do you want to proceed with the report?",
                            MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If Result = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        '-- ALCO
        Call _
            CreateReport(Me.RptType, Sch, Val(txtYear.Text), Sem, CBool(chkIndiv.CheckState), CBool(chkMID.CheckState),
                         CBool(chkDestrezas.CheckState), CBool(chkComp.CheckState), CBool(Me.chkInvoice.CheckState),
                         False, FromGrade, ToGrade, Me.chkAcomodo.CheckState, Me.chkReposition.CheckState)


        Me.Close()
    End Sub
#End Region

    
End Class