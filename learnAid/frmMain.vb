Imports ADODB
Imports System.ComponentModel.Design
Imports NPOI.SS.Formula.Functions
Imports learnAid.Forms.InfoForms
Imports learnAid.Forms.MasterForms
Imports learnAid.Forms.UserLoginForms
Imports learnAid.Forms.AccountingForms
Imports learnAid.Forms.StudentsForm

Public Class frmMain
    Public FormProperty = New frmProperty()
    Dim _formSchool = New frmSchools()
    Dim _formConsultant = New frmConsultants()

#Region "LEVEL ONE ROUTINES"
    ''' <remarks>
    '''          This is where the main program starts
    ''' </remarks>
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Main()
        rbConsultants.Checked = False
        Me.ShowHideRightPanelContent()

        If Config.ShowStartUp Then
            frmStartUp.Show()
        Else
            Select Case LoggedUser.UserType
                Case enumSecurityLevel.DataEntry, enumSecurityLevel.Administrator
                    frmStartUp.Show()
                Case enumSecurityLevel.Consultant
                    frmStartUp.Show()
                Case enumSecurityLevel.accounting
                    frmStartUp.Show()
            End Select
        End If
        Me.ShowHideToolOptions()
        Me.ShowHideViewOptions()
        _formSchool.TopLevel = False
        _formConsultant.TopLevel = False
        FormProperty.TopLevel = False
        Me.panelRight.Controls.Add(FormProperty)
        Me.panelRight.Controls.Add(_formSchool)
        'formShool Has loading problem so loaded here
        _formSchool.Show()
        Me.panelRight.Controls.Add(_formConsultant)
        _formConsultant.Show()
    End Sub
    Private Sub mnuClaves_Click(sender As Object, e As EventArgs) Handles mnuClaves.Click
        frmListClaves.ShowDialog()
    End Sub
    Private Sub mnuCopyJob_Click(sender As Object, e As EventArgs) Handles mnuCopyJob.Click
        Dim sKey As String
        Dim JobID As Integer
        Dim NewJobID As Integer

        '***********************************************
        Dim Cn As New ADODB.Connection
        Dim Cm As New ADODB.Command
        Dim rsFrom As New ADODB.Recordset
        Dim rsTo As New ADODB.Recordset
        If Not (frmJobsView.lvJobs.FocusedItem Is Nothing) Then
            If MsgBox("You want to copy the selected job?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sKey = frmJobsView.lvJobs.FocusedItem.Name
                JobID = GetIDFromKey(sKey)

                OpenConnection(Cn, Config.ConnectionString)

                rsFrom.Open("Select * from Jobs where j_id = " & JobID, Cn, 3, 3)
                If rsFrom.RecordCount = 1 Then
                    rsTo.Open("select * from jobs where j_id = -1", Cn, 1, 3, 0)
                    rsTo.AddNew()
                    rsTo.Fields("j_type").Value = rsFrom.Fields("j_type").Value
                    rsTo.Fields("J_SCH").Value = rsFrom.Fields("J_SCH").Value
                    rsTo.Fields("J_GRADE").Value = rsFrom.Fields("J_GRADE").Value
                    rsTo.Fields("J_SEC").Value = rsFrom.Fields("J_SEC").Value
                    rsTo.Fields("J_SEM").Value = rsFrom.Fields("J_SEM").Value
                    rsTo.Fields("J_TOTAL_EST").Value = rsFrom.Fields("J_TOTAL_EST").Value
                    rsTo.Fields("J_CONS").Value = rsFrom.Fields("J_CONS").Value
                    rsTo.Fields("j_toll1").Value = rsFrom.Fields("j_toll1").Value
                    rsTo.Fields("J_CONS2").Value = rsFrom.Fields("J_CONS2").Value
                    rsTo.Fields("j_toll2").Value = rsFrom.Fields("j_toll2").Value
                    rsTo.Fields("J_CONS3").Value = rsFrom.Fields("J_CONS3").Value
                    rsTo.Fields("J_LES").Value = rsFrom.Fields("J_LES").Value
                    rsTo.Fields("J_NV").Value = rsFrom.Fields("J_NV").Value
                    rsTo.Fields("J_REN").Value = rsFrom.Fields("J_REN").Value
                    rsTo.Fields("J_MAT").Value = rsFrom.Fields("J_MAT").Value
                    rsTo.Fields("j_AID").Value = rsFrom.Fields("j_AID").Value
                    rsTo.Fields("j_pepv").Value = rsFrom.Fields("j_pepv").Value
                    rsTo.Fields("J_DATE").Value = DateTime.Now
                    rsTo.Fields("J_ARCHIVO").Value = rsFrom.Fields("J_ARCHIVO").Value
                    rsTo.Fields("J_USER").Value = rsFrom.Fields("J_USER").Value
                    rsTo.Fields("J_COMP_ID").Value = rsFrom.Fields("J_COMP_ID").Value
                    rsTo.Fields("J_Status").Value = 0
                    rsTo.Fields("J_Process_Status").Value = 0
                    rsTo.Fields("J_DESCRIPTION").Value = rsFrom.Fields("J_DESCRIPTION").Value
                    rsTo.Fields("j_plugin").Value = rsFrom.Fields("j_plugin").Value
                    rsTo.Fields("j_printed").Value = False
                    rsTo.Fields("j_paid").Value = False
                    rsTo.Fields("J_price").Value = rsFrom.Fields("J_price").Value
                    rsTo.Fields("J_Serv_Date").Value = rsFrom.Fields("J_Serv_Date").Value
                    rsTo.Fields("J_AcomRazonable").Value = rsFrom.Fields("J_AcomRazonable").Value
                    rsTo.Update()
                    NewJobID = rsTo.Fields("j_id").Value
                End If
                rsFrom.Close()
                rsTo.Close()
                rsFrom.Open("Select * from Answers where a_j_id = " & JobID & " order by a_id", Cn, 3, 3)
                rsTo.Open("select * from answers where a_id = -1", Cn, 1, 3, 0)
                While Not rsFrom.EOF
                    rsTo.AddNew()
                    rsTo.Fields("A_J_ID").Value = NewJobID
                    rsTo.Fields("A_NOMBRE").Value = rsFrom.Fields("A_NOMBRE").Value
                    rsTo.Fields("A_sexo").Value = rsFrom.Fields("A_sexo").Value
                    rsTo.Fields("a_school").Value = rsFrom.Fields("a_school").Value
                    rsTo.Update()
                    rsFrom.MoveNext()
                End While
                rsTo.Close()
                rsFrom.Close()

                Cn.Close()
                Call FillJobsView2()
            End If
        Else
            MsgBox("Please select a Job", MsgBoxStyle.Information)
        End If
    End Sub
    Public Sub mnuDeleteJob_Click(sender As Object, e As EventArgs) Handles mnuDeleteJob.Click
        Dim LastClickedItemKey As String
        Dim sKey As String
        '***********************************************
        If Not (frmJobsView.lvJobs.FocusedItem Is Nothing) Then
            If MsgBox("You want to delete the selected job?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                sKey = frmJobsView.lvJobs.FocusedItem.Name
                Call DeleteJob(GetIDFromKey(sKey))
                LastClickedItemKey = ""
                Call FillJobsView2()
            End If
        Else
            MsgBox("Please select a Job", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub mnuEditClaves_Click(sender As Object, e As EventArgs) Handles mnuEditClaves.Click
        Forms.ClaveForms.frmUpdateKeys.Show()
    End Sub
    Public Sub mnuEditJob_Click(sender As Object, e As EventArgs) Handles mnuEditJob.Click
        If Not (frmJobsView.lvJobs.FocusedItem Is Nothing) Then
            frmEditJob.iJobID = GetIDFromKey(frmJobsView.lvJobs.FocusedItem.Name)
            MessageBox.Show(frmEditJob.iJobID.ToString)
            frmEditJob.ShowDialog()
        Else
            MsgBox("Please select a job.", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub mnuEntranceReport_Click(sender As Object, e As EventArgs) Handles mnuEntranceReport.Click
        frmCreateReport.RptType = 1 'Entrance
        frmCreateReport.Show()
    End Sub
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
        Application.Exit()
    End Sub
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        frmabout.ShowDialog()
    End Sub
    Private Sub mnuHome_Click(sender As Object, e As EventArgs) Handles mnuHome.Click
        Me.mnuHome.Checked = True
        Me.mnuEvaluations.Checked = False
        Me.mnuAccounting.Checked = False
        Me.mnuReports.Checked = False

        frmStartUp.Show()
        frmJobsView.Hide()
        frmAccountingView.Hide()
    End Sub
    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        Me.Close()
        Call Main()
    End Sub
    Public Sub mnuNewJob_Click(sender As Object, e As EventArgs) Handles mnuNewJob.Click
        frmNewJob.ShowDialog()
    End Sub
    Private Sub mnuOfficeTestingReport_Click(sender As Object, e As EventArgs) Handles mnuOfficeTestingReport.Click
        frmCreateReport.RptType = 0 'Office Testing
        frmCreateReport.Show()
    End Sub
    Private Sub mnuOptions_Click(sender As Object, e As EventArgs) Handles mnuOptions.Click
        frmOptions.ShowDialog()
    End Sub
    Private Sub mnuRegularReport_Click(sender As Object, e As EventArgs) Handles mnuRegularReport.Click
        frmCreateReport.RptType = 2 'Regular
        frmCreateReport.Show()
    End Sub
    Private Sub mnuResetJob_Click(sender As Object, e As EventArgs) Handles mnuResetJob.Click
        Dim sQuery As String
        Dim Cm As New ADODB.Command
        Dim Cn As New ADODB.Connection
        Dim Rs As New ADODB.Recordset
        Dim RsA As New ADODB.Recordset

        Dim bUpdate As Boolean
        Dim iGrade As Short
        Dim iJobID As Integer
        Dim iSemester As Short
        Dim isOT As Boolean
        Dim pep As Boolean
        Dim R As MsgBoxResult


        With frmJobsView
            If Not (.lvJobs.FocusedItem Is Nothing) Then
                iJobID = GetIDFromKey(.lvJobs.FocusedItem.Name)

                OpenConnection(Cn, Config.ConnectionString)

                Rs.Open("Select * From Jobs Where J_ID =" & iJobID, Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)

                iGrade = Rs.Fields("J_GRADE").Value
                iSemester = Rs.Fields("J_SEM").Value
                pep = (GetValue(Rs.Fields("j_pepv"), 0) > 0)
                isOT = (GetValue(Rs.Fields("j_type")) = 0)
                bUpdate = False

                If iGrade + iSemester >= 6 And Not pep And Not isOT Then
                    R = MsgBox("Delete student List?. Delete only using old scanning feature.", MsgBoxStyle.YesNoCancel, "Reset Job")
                    If R = MsgBoxResult.No Then
                        bUpdate = True
                    ElseIf R = MsgBoxResult.Yes Then
                        R = MsgBox("The Student's name list will be reset to the original state. Any changes made to that list will be lost." & vbCrLf & "Do you want to continue?", MsgBoxStyle.YesNoCancel, "Reset Job")
                        If R = MsgBoxResult.Yes Then
                            Rs.Fields("J_Status").Value = 0
                            Rs.Fields("J_Process_Status").Value = 0
                            Rs.Fields("J_DESCRIPTION").Value = ""
                            Rs.Update()

                            'Borro los record de la tabla de logs(Warnings)
                            Cm.ActiveConnection = Cn
                            Cm.CommandText = "Delete From Logs Where L_J_ID = " & iJobID
                            Cm.Execute()

                            'Borro los record de los estudiantes del job de la tabla de ANSWERS
                            Cm.CommandText = "DELETE FROM Answers WHERE A_J_ID =" & iJobID
                            Cm.CommandTimeout = 900
                            Cm.Execute()
                            'UPGRADE_NOTE: Object Cm may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
                            Cm = Nothing
                        End If
                    End If
                Else
                    bUpdate = True
                End If

                If bUpdate = True Then
                    R = MsgBox("Continue to reset job without deleting student list?", MsgBoxStyle.YesNoCancel, "Reset Job")
                    If R = MsgBoxResult.Yes Then

                        Rs.Fields("J_Status").Value = 0
                        Rs.Fields("J_Process_Status").Value = 0
                        Rs.Fields("J_DESCRIPTION").Value = ""
                        Rs.Update()

                        'HACER LOOP POR ANSWERS Y LIMPIO VALORES
                        sQuery = "select * from answers where a_j_id = " & iJobID
                        RsA.Open(sQuery, Cn, 3, 3)

                        While Not RsA.EOF
                            For y As Integer = 1 To 10
                                RsA.Fields("a_AIDR" & y).Value = 0
                                RsA.Fields("a_AIDR" & y & "_TOTAL").Value = 0
                            Next y
                            RsA.Fields("a_aidr_total").Value = 0

                            For y As Integer = 1 To 10
                                RsA.Fields("a_L" & y).Value = 0
                                RsA.Fields("a_L" & y & "_TOTAL").Value = 0
                            Next y
                            RsA.Fields("a_LES_total").Value = 0

                            For y As Integer = 1 To 10
                                RsA.Fields("a_R" & y).Value = 0
                                RsA.Fields("a_R" & y & "_TOTAL").Value = 0
                            Next y
                            RsA.Fields("a_REN_total").Value = 0

                            For y As Integer = 1 To 10
                                RsA.Fields("a_M" & y).Value = 0
                                RsA.Fields("a_M" & y & "_TOTAL").Value = 0
                            Next y
                            RsA.Fields("a_MAT_total").Value = 0

                            For y As Integer = 1 To 10
                                RsA.Fields("a_N" & y).Value = 0
                                RsA.Fields("a_N" & y & "_TOTAL").Value = 0
                            Next y
                            RsA.Fields("a_NV_total").Value = 0

                            For y As Integer = 1 To 6
                                RsA.Fields("a_PEPV" & y).Value = 0
                                RsA.Fields("a_PEPV" & y & "_TOTAL").Value = 0
                            Next y

                            For y As Integer = 1 To 3
                                RsA.Fields("a_PEPV_GRUPO" & y).Value = 0
                            Next y
                            For y As Integer = 1 To 3
                                RsA.Fields("a_PEPV_INTERES" & y).Value = 0
                            Next y

                            RsA.Fields("a_newscan").Value = 0

                            RsA.Update()
                            RsA.MoveNext()
                        End While
                        RsA.Close()

                        'Borro los record de la tabla de logs(Warnings)
                        Cm.ActiveConnection = Cn
                        Cm.CommandText = "Delete From Logs Where L_J_ID = " & iJobID
                        Cm.Execute()
                    End If
                End If

                Rs.Close()
                Cn.Close()
            End If
        End With
    End Sub
    Public Sub mnuResetRep_Click(sender As Object, e As EventArgs) Handles mnuResetRep.Click
        Dim id As Integer

        If Not frmReportView.lvReports.FocusedItem Is Nothing Then

            id = GetIDFromKey(frmReportView.lvReports.FocusedItem.Name)

            If DeleteReport(id) = False Then
                MsgBox("Can't delete the report.", MsgBoxStyle.Critical)
            Else
                MsgBox("Successfully deleted the report.", MsgBoxStyle.Information)
                'reload data
                Call frmReportView.Fill()
            End If
        End If
    End Sub
    Private Sub mnuStudentList_Click(sender As Object, e As EventArgs) Handles mnuStudentList.Click
        Call GetNamesForJobAIDR(GetIDFromKey((frmJobsView.LastClickedItemKey)))
    End Sub
    Private Sub mnuUsers_Click(sender As Object, e As EventArgs) Handles mnuUsers.Click
        frmUsers.ShowDialog()
    End Sub
    Private Sub mnuViewConsultants_Click(sender As Object, e As EventArgs) Handles mnuViewConsultants.Click
        ToggleConsultants()
    End Sub
    Private Sub mnuViewSchools_Click(sender As Object, e As EventArgs) Handles mnuViewSchools.Click
        ToggleSchools()
    End Sub
    Public Sub mnuVWarnings_Click(sender As Object, e As EventArgs) Handles mnuVWarnings.Click
        If Not (frmJobsView.lvJobs.FocusedItem Is Nothing) Then
            frmWarnings.iJobID = GetIDFromKey(frmJobsView.lvJobs.FocusedItem.Name)
            frmWarnings.ShowDialog()
        Else
            MsgBox("Please select a job.", MsgBoxStyle.Information)
        End If

    End Sub
    Private Sub _Toolbar_Button1_Click(sender As Object, e As EventArgs) Handles Options.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(sender, System.Windows.Forms.ToolStripItem)
        Select Case Button.Name
            Case "Schools"
                Call mnuViewSchools_Click(mnuViewSchools, New System.EventArgs())
            Case "Properties"
                'Call mnuViewProperties_Click(mnuViewProperties, New System.EventArgs())
            Case "Consultants"
                'Call mnuViewConsultants_Click(mnuViewConsultants, New System.EventArgs())
            Case "ButtonPanel"
                'Call mnuViewButtonPanel_Click(mnuViewButtonPanel, New System.EventArgs())
            Case "Options"
                frmOptions.ShowDialog()
        End Select
    End Sub
    Private Sub _Toolbar_Button3_Click(sender As Object, e As EventArgs) Handles _Toolbar_Button3.Click
        ToggleSchools()
    End Sub
    Private Sub _Toolbar_Button4_Click(sender As Object, e As EventArgs) Handles _Toolbar_Button4.Click
        ToggleConsultants()
    End Sub
    Private Sub _Toolbar_Button5_Click(sender As Object, e As EventArgs) Handles _Toolbar_Button5.Click
        mnuViewProperties.Checked = Toggle(mnuViewProperties.Checked)
        ShowHideRightPanelContent()
        'panelRight.Visible = Toggle(panelRight.Visible)
    End Sub
    Private Sub _Toolbar_Button6_Click(sender As Object, e As EventArgs) Handles _Toolbar_Button6.Click
        panelLeft.Visible = Toggle(panelLeft.Visible)
    End Sub
    Private Sub rbEvaluation_Click(sender As Object, e As EventArgs) Handles rbEvaluation.Click, rbStudents.Click, rbReport.Click, rbConsultants.Click, rbAccounting.Click
        Me.ButtonPanelFunction()
    End Sub
#End Region

#Region "LEVEL TWO ROUTINES"

    Private Sub ButtonPanelFunction()
        If rbEvaluation.Checked Then
            frmJobsView.Show()
            Call FillJobsView2()
            If Not frmReportView Is Nothing Then frmReportView.Hide()
            If Not frmAccountingView Is Nothing Then frmAccountingView.Hide()
            If Not frmConsultantView Is Nothing Then frmConsultantView.Hide()
            If Not frmStudentResult Is Nothing Then frmStudentResult.Hide()
            frmJobsView.WindowState = System.Windows.Forms.FormWindowState.Maximized 'maximize
        ElseIf rbAccounting.Checked Then
            frmAccountingView.Show()
            If Not frmJobsView Is Nothing Then frmJobsView.Hide()
            If Not frmReportView Is Nothing Then frmReportView.Hide()
            If Not frmConsultantView Is Nothing Then frmConsultantView.Hide()
            If Not frmStudentResult Is Nothing Then frmStudentResult.Hide()
            frmAccountingView.WindowState = System.Windows.Forms.FormWindowState.Maximized 'maximize
        ElseIf rbReport.Checked Then
            '''<remarks>
            '''         This section called when the report button is clicked
            ''' </remarks>
            frmReportView.Show()
            If Not frmJobsView Is Nothing Then frmJobsView.Hide()
            If Not frmAccountingView Is Nothing Then frmAccountingView.Hide()
            If Not frmConsultantView Is Nothing Then frmConsultantView.Hide()
            If Not frmStudentResult Is Nothing Then frmStudentResult.Hide()
            frmReportView.WindowState = System.Windows.Forms.FormWindowState.Maximized 'maximize
        ElseIf rbConsultants.Checked Then
            frmConsultantView.Show()
            If Not frmJobsView Is Nothing Then frmJobsView.Hide()
            If Not frmReportView Is Nothing Then frmReportView.Hide()
            If Not frmAccountingView Is Nothing Then frmAccountingView.Hide()
            If Not frmStudentResult Is Nothing Then frmStudentResult.Hide()
            frmConsultantView.WindowState = System.Windows.Forms.FormWindowState.Maximized 'maximize
        ElseIf rbStudents.Checked Then
            frmStudentResult.Show()
            If Not frmJobsView Is Nothing Then frmJobsView.Hide()
            If Not frmReportView Is Nothing Then frmReportView.Hide()
            If Not frmAccountingView Is Nothing Then frmAccountingView.Hide()
            If Not frmAccountingView Is Nothing Then frmAccountingView.Hide()
            frmStudentResult.WindowState = System.Windows.Forms.FormWindowState.Maximized 'maximize
        End If
    End Sub

    Public Sub Main()
        Call LA_Declarations.Init()
        Call frmLogin.ShowDialog()

        If frmLogin.LoginSucceeded And Not Config.FirstExecution Then
            frmLogin.Close()
            Me.Show()
        Else
            frmLogin.Close()
        End If
    End Sub

    Public Sub ShowHideRightPanelContent()
        Dim divideFactor = GetCheckedPanel()

        If divideFactor = 0 Then
            panelRight.Visible = False
            Exit Sub
        Else
            panelRight.Visible = True
        End If

        Dim borderCheck = 0
        If divideFactor = 3 Then
            borderCheck = 1
        ElseIf divideFactor = 2 Then
            borderCheck = 2
        Else
            borderCheck = 3
        End If
        Dim topIndex = 0

        If mnuViewProperties.Checked Then
            FormProperty.TopLevel = False
            FormProperty.Height = (Me.panelRight.Height / divideFactor) - borderCheck
            FormProperty.Width = Me.panelRight.Width - 5
            FormProperty.Top = topIndex
            FormProperty.Show()
            mnuViewProperties.Checked = True
            _Toolbar_Button5.Checked = True
            topIndex = topIndex + CInt(FormProperty.Height)
        Else
            FormProperty.Hide()
            mnuViewProperties.Checked = False
            _Toolbar_Button5.Checked = False
        End If

        If mnuViewSchools.Checked Then
            _formSchool.Height = (Me.panelRight.Height / divideFactor) - borderCheck
            _formSchool.Width = Me.panelRight.Width - 5
            _formSchool.Top = topIndex
            _formSchool.Show()
            mnuViewSchools.Checked = True
            _Toolbar_Button3.Checked = True
            topIndex = topIndex + CInt(_formSchool.Height)
        Else
            _formSchool.Hide()
            mnuViewSchools.Checked = False
            _Toolbar_Button3.Checked = False
        End If

        If mnuViewConsultants.Checked Then
            _formConsultant.Height = (Me.panelRight.Height / divideFactor) - borderCheck
            _formConsultant.Width = Me.panelRight.Width - 5
            _formConsultant.Top = topIndex
            _formConsultant.Show()
            mnuViewConsultants.Checked = True
            _Toolbar_Button4.Checked = True
        Else
            _formConsultant.Hide()
            mnuViewConsultants.Checked = False
            _Toolbar_Button4.Checked = False
        End If

    End Sub
    Private Sub ShowHideToolOptions()
        'Tool Options
        Select Case LoggedUser.UserType
            Case enumSecurityLevel.Administrator
                Me.Options.Visible = True
                Me.mnuOptions.Visible = True
                Me.mnuUsers.Visible = True
            Case Else
                Me.Options.Visible = False
                Me.mnuOptions.Visible = False
                Me.mnuUsers.Visible = False
        End Select
    End Sub
    Private Sub ShowHideViewOptions()
        Select Case LoggedUser.UserType
            Case enumSecurityLevel.Administrator

            Case enumSecurityLevel.Consultant
                rbAccounting.Visible = False
                mnuAccounting.Visible = False

                rbStudents.Top = rbConsultants.Top
                rbConsultants.Top = rbReport.Top
                rbReport.Top = rbAccounting.Top
            Case enumSecurityLevel.DataEntry
                rbAccounting.Visible = False
                mnuAccounting.Visible = False
                rbConsultants.Visible = False

                rbStudents.Top = rbReport.Top
                rbReport.Top = rbAccounting.Top
            Case enumSecurityLevel.accounting
                rbEvaluation.Visible = False
                mnuEvaluations.Visible = False
                rbConsultants.Visible = False
                rbStudents.Visible = False

                rbReport.Top = rbAccounting.Top
                rbAccounting.Top = rbEvaluation.Top
            Case Else
        End Select


    End Sub
    Public Function Toggle(val As Boolean) As Boolean
        If (val) Then
            Return False
        End If
        Return True
    End Function
    Private Sub ToggleConsultants()
        mnuViewConsultants.Checked = Toggle(mnuViewConsultants.Checked)
        ShowHideRightPanelContent()
    End Sub
    Private Sub ToggleSchools()
        mnuViewSchools.Checked = Toggle(mnuViewSchools.Checked)
        ShowHideRightPanelContent()
    End Sub


#End Region
#Region "LEVEL THREE ROUTINES"
    Public Function GetCheckedPanel() As Integer
        Dim checkCounter = 0

        If mnuViewProperties.Checked Then
            checkCounter += 1
        End If
        If (mnuViewSchools.Checked) Then
            checkCounter += 1
        End If
        If (mnuViewConsultants.Checked) Then
            checkCounter += 1
        End If
        Return checkCounter
    End Function
#End Region

   
End Class
