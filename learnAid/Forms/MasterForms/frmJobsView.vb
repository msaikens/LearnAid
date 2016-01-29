Option Strict Off
Option Explicit On

Imports NPOI.SS.Formula.Functions
Imports Microsoft.VisualBasic.Compatibility
Imports System.Data.SqlClient
Namespace Forms.MasterForms

    Friend Class frmJobsView
        Inherits System.Windows.Forms.Form
        Private MouseButton As Short
        Public LastClickedItemKey As String

#Region "LEVEL ONE ROUTINES"
        Private Sub frmJobsView_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
            'Not Required
            'Call SetListViewFlatHeader((Me.lvJobs), True)

            'mcTab.AddItem "My Jobs", "MyJobs"
            'mcTab.AddItem("All", "All")
            'mcTab.AddItem("Pending", "Pending")
            'mcTab.ActiveItem((1))

            Me.lvJobs.Columns.Item(0).Width = 30
            Me.lvJobs.Columns.Item(1).Width = 200
            Me.lvJobs.Columns.Item(2).Width = 50
            Me.lvJobs.Columns.Item(3).Width = 50 '-- Section
            Me.lvJobs.Columns.Item(4).Width = 80 '-- Semester
            Me.lvJobs.Columns.Item(5).Width = 100 '-- Date
            Me.lvJobs.Columns.Item(6).Width = 100 '-- Job Status
            Me.lvJobs.Columns.Item(7).Width = 100 '-- Process Status

        End Sub

        Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
            Load_Job()
        End Sub
        Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
            Call frmMain.mnuDeleteJob_Click(sender, e)
        End Sub
        Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
            Call frmMain.mnuEditJob_Click(sender, e)
        End Sub
        Private Sub btnMyJobs_Click(sender As Object, e As EventArgs) Handles btnMyJobs.Click
            Load_Job()
        End Sub
        Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
            Call frmMain.mnuNewJob_Click(sender, e)
        End Sub
        Private Sub btnPending_Click(sender As Object, e As EventArgs) Handles btnPending.Click
            Load_Job()
        End Sub
        Private Sub ClearJobToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearJobToolStripMenuItem.Click
            Dim Cn As New ADODB.Connection
            Dim Cm As New ADODB.Command
            Dim rsFrom As New ADODB.Recordset
            Dim rsTo As New ADODB.Recordset

            Dim JobID As Integer
            Dim NewJobID As Integer
            Dim sKey As String

            '***********************************************
            If Not (lvJobs.FocusedItem Is Nothing) Then
                If MsgBox("You want to copy the selected job?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    sKey = lvJobs.FocusedItem.Name
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
                    rsFrom.Open("Select * from Answers where a_j_id = " & JobID.ToString.Trim & " order by a_id", Cn, 3, 3)
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

        'UPGRADE_WARNING: Event frmJobsView.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub frmJobsView_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
            Call SetControls()
        End Sub

        Private Sub lvJobs_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvJobs.Click

            If MouseButton = 2 Then
                Call ValidateMenuOptions()
                'UPGRADE_ISSUE: Form method frmJobsView.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'TODO
                'PopupMenu(FrmMain.mnuJobsRmenu)
                'MsgBox lvJobs.SelectedItem.Key
            End If

        End Sub

        Private Sub lvJobs_ColumnClick(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ColumnClickEventArgs) Handles lvJobs.ColumnClick
            Dim iCounter1 As Integer
            Dim ColumnHeader As System.Windows.Forms.ColumnHeader = lvJobs.Columns(eventArgs.Column)
            lvJobs.Sort()
            'UPGRADE_ISSUE: MSComctlLib.ListView property lvJobs.SortKey was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'lvJobs.SortKey = ColumnHeader.Index - 1


            If lvJobs.Sorting = System.Windows.Forms.SortOrder.Ascending Then
                lvJobs.Sorting = System.Windows.Forms.SortOrder.Descending
                'UPGRADE_ISSUE: MSComctlLib.ColumnHeader property ColumnHeader.Icon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'ColumnHeader.Icon = "Down"
                lvJobs.Refresh()
            Else
                lvJobs.Sorting = System.Windows.Forms.SortOrder.Ascending
                'UPGRADE_ISSUE: MSComctlLib.ColumnHeader property ColumnHeader.Icon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'ColumnHeader.Icon = "Up"
            End If


            For iCounter1 = 1 To lvJobs.Columns.Count
                If iCounter1 <> ColumnHeader.Index Then
                    'UPGRADE_WARNING: Lower bound of collection lvJobs.ColumnHeaders has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    'UPGRADE_ISSUE: MSComctlLib.ColumnHeader property lvJobs.ColumnHeaders.Icon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                    'lvJobs.Columns.Item(i).Icon = 0
                End If
            Next iCounter1
        End Sub

        'UPGRADE_ISSUE: MSComctlLib.ListView event lvJobs.ItemClick was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
        Private Sub lvJobs_ItemClick(ByVal Item As System.Windows.Forms.ListViewItem)

            'TODO
            'frmProperties.FillWithJob(GetIDFromKey((Item.Name)))

        End Sub

        Private Sub lvJobs_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lvJobs.MouseUp
            Dim Button As Short = eventArgs.Button \ &H100000
            Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
            Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
            Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
            Dim Node As System.Windows.Forms.ListViewItem

            MouseButton = Button

            Node = lvJobs.GetItemAt(X, Y)

            If Not (Node Is Nothing) Then
                LastClickedItemKey = Node.Name
            Else
                If Not (lvJobs.FocusedItem Is Nothing) Then
                    LastClickedItemKey = lvJobs.FocusedItem.Name
                Else
                    LastClickedItemKey = String.Empty
                End If

            End If

        End Sub

        Private Sub mnuEvaluate_Click(sender As Object, e As EventArgs) Handles mnuEvaluate.Click
            Call Process(False, True)
        End Sub
        Private Sub mnuNewScan_Click(sender As Object, e As EventArgs) Handles mnuNewScan.Click
            Call NewProcess(False, False)
        End Sub
        Private Sub mnuOrdenScan_Click(sender As Object, e As EventArgs) Handles mnuOrdenScan.Click
            Call NewProcess(True, False)
        End Sub
        Private Sub mnuRScan_Click(sender As Object, e As EventArgs) Handles mnuRScan.Click
            Call Process(True, False)
        End Sub
        Private Sub mnuREvaluate_Click(sender As Object, e As EventArgs) Handles mnuREvaluate.Click
            Call NewProcess(False, True)
        End Sub
        Private Sub mnuReScan_Click(sender As Object, e As EventArgs) Handles mnuReScan.Click
            Call NewProcess(False, True)
        End Sub
        Private Sub mnuScan_Click(sender As Object, e As EventArgs) Handles mnuScan.Click
            Call Process(True, True)
        End Sub
        Private Sub NewJobToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewJobToolStripMenuItem.Click
            'Nothing here!
        End Sub

        Private Sub ResetJobToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetJobToolStripMenuItem.Click
            Dim sQuery As String
            Dim Cn As ADODB.Connection
            Dim Cm As ADODB.Command
            Dim Rs As ADODB.Recordset
            Dim RsA As New ADODB.Recordset

            Dim bUpdate As Boolean = False
            Dim iCounter1 As Integer
            Dim iGrade As Short
            Dim iJobID As Integer
            Dim iSemester As Short
            Dim isOT As Boolean
            Dim pep As Boolean
            Dim MBResult As MsgBoxResult


            'With frmJobsView
            If Not (lvJobs.FocusedItem Is Nothing) Then
                iJobID = GetIDFromKey(lvJobs.FocusedItem.Name)

                Cm = New ADODB.Command
                Cn = New ADODB.Connection
                Rs = New ADODB.Recordset

                OpenConnection(Cn, Config.ConnectionString)

                Rs.Open("Select * From Jobs Where J_ID =" & iJobID.ToString.Trim, Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)

                iGrade = Rs.Fields("J_GRADE").Value
                iSemester = Rs.Fields("J_SEM").Value
                pep = (GetValue(Rs.Fields("j_pepv"), 0) > 0)
                isOT = (GetValue(Rs.Fields("j_type")) = 0)
                bUpdate = False

                If iGrade + iSemester >= 6 And Not pep And Not isOT Then
                    MBResult = MsgBox("Delete student List?. Delete only using old scanning feature.", MsgBoxStyle.YesNoCancel, "Reset Job")
                    If MBResult = MsgBoxResult.No Then
                        bUpdate = True
                    ElseIf MBResult = MsgBoxResult.Yes Then
                        MBResult = MsgBox("The Student's name list will be reset to the original state. Any changes made to that list will be lost." & vbCrLf & "Do you want to continue?", MsgBoxStyle.YesNoCancel, "Reset Job")
                        If MBResult = MsgBoxResult.Yes Then
                            Rs.Fields("J_Status").Value = 0
                            Rs.Fields("J_Process_Status").Value = 0
                            Rs.Fields("J_DESCRIPTION").Value = String.Empty
                            Rs.Update()

                            'Borro los record de la tabla de logs(Warnings)
                            Cm.ActiveConnection = Cn
                            Cm.CommandText = "Delete From Logs Where L_J_ID = " & iJobID.ToString.Trim
                            Cm.Execute()

                            'Borro los record de los estudiantes del job de la tabla de ANSWERS
                            Cm.CommandText = "DELETE FROM Answers WHERE A_J_ID =" & iJobID.ToString.Trim
                            Cm.CommandTimeout = 900
                            Cm.Execute()
                            Cm = Nothing
                        End If
                    End If
                Else
                    bUpdate = True
                End If

                If bUpdate = True Then
                    MBResult = MsgBox("Continue to reset job without deleting student list?", MsgBoxStyle.YesNoCancel, "Reset Job")
                    If MBResult = MsgBoxResult.Yes Then

                        Rs.Fields("J_Status").Value = 0
                        Rs.Fields("J_Process_Status").Value = 0
                        Rs.Fields("J_DESCRIPTION").Value = ""
                        Rs.Update()

                        'HACER LOOP POR ANSWERS Y LIMPIO VALORES
                        sQuery = "select * from answers where a_j_id = " & iJobID.ToString.Trim
                        RsA.Open(sQuery, Cn, 3, 3)

                        While Not RsA.EOF
                            For iCounter1 = 1 To 10
                                RsA.Fields("a_AIDR" & iCounter1.ToString.Trim).Value = 0
                                RsA.Fields("a_AIDR" & iCounter1.ToString.Trim & "_TOTAL").Value = 0
                            Next iCounter1
                            RsA.Fields("a_aidr_total").Value = 0

                            For iCounter1 = 1 To 20
                                RsA.Fields("a_L" & iCounter1.ToString.Trim).Value = 0
                                RsA.Fields("a_L" & iCounter1.ToString.Trim & "_TOTAL").Value = 0
                            Next iCounter1
                            RsA.Fields("a_LES_total").Value = 0

                            For iCounter1 = 1 To 20
                                RsA.Fields("a_R" & iCounter1.ToString.Trim).Value = 0
                                RsA.Fields("a_R" & iCounter1.ToString.Trim & "_TOTAL").Value = 0
                            Next iCounter1
                            RsA.Fields("a_REN_total").Value = 0

                            For iCounter1 = 1 To 20
                                RsA.Fields("a_M" & iCounter1.ToString.Trim).Value = 0
                                RsA.Fields("a_M" & iCounter1.ToString.Trim & "_TOTAL").Value = 0
                            Next iCounter1
                            RsA.Fields("a_MAT_total").Value = 0

                            For iCounter1 = 1 To 20
                                RsA.Fields("a_N" & iCounter1.ToString.Trim).Value = 0
                                RsA.Fields("a_N" & iCounter1.ToString.Trim & "_TOTAL").Value = 0
                            Next iCounter1
                            RsA.Fields("a_NV_total").Value = 0

                            For iCounter1 = 1 To 6
                                RsA.Fields("a_PEPV" & iCounter1.ToString.Trim).Value = 0
                                RsA.Fields("a_PEPV" & iCounter1.ToString.Trim & "_TOTAL").Value = 0
                            Next iCounter1

                            For iCounter1 = 1 To 3
                                RsA.Fields("a_PEPV_GRUPO" & iCounter1.ToString.Trim).Value = 0
                            Next iCounter1
                            For iCounter1 = 1 To 3
                                RsA.Fields("a_PEPV_INTERES" & iCounter1.ToString.Trim).Value = 0
                            Next iCounter1

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
            'End With
        End Sub
        'Private Sub tmrUpdateJobs_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmrUpdateJobs.Tick
        '    'TODO: timer tires to update jobs everytime which throws error
        '    Call FillJobsView2()
        '    'On Error Resume Next
        '    If LastClickedItemKey <> String.Empty Then
        '        ' lvJobs.Items.Item(LastClickedItemKey).Selected = True
        '    End If
        'End Sub

        Private Sub Toolbar_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar_Button1.Click, _Toolbar_Button2.Click, _Toolbar_Button3.Click, _Toolbar_Button4.Click, _Toolbar_Button5.Click, _Toolbar_Button6.Click, _Toolbar_Button7.Click
            Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)

            Select Case Button.Name
                Case "New"

                Case "Delete"
                    'Call frmMain.mnuDeleteJob_Click(Nothing, New System.EventArgs())
                Case "VWarnings"
                    ' Call frmMain.mnuVWarnings_Click(Nothing, New System.EventArgs())
                Case "PreJobs"
                    frmPreJob.ShowDialog()
            End Select
            lvJobs.Focus()

        End Sub

        Private Sub Toolbar_ButtonMenuClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar_Button6_ButtonMenu1.Click, _Toolbar_Button6_ButtonMenu2.Click, _Toolbar_Button6_ButtonMenu3.Click, _Toolbar_Button6_ButtonMenu4.Click, _Toolbar_Button6_ButtonMenu5.Click, _Toolbar_Button7_ButtonMenu1.Click, _Toolbar_Button7_ButtonMenu2.Click
            Dim ButtonMenu As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripMenuItem)

            'TODO
            'UPGRADE_ISSUE: MSComctlLib.ButtonMenu property ButtonMenu.Key was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'Select Case ButtonMenu.Key
            '    Case "PScan"
            '        Call Process(True, True)
            '    Case "PEvaluate"
            '        Call Process(False, True)
            '    Case "PAScan"
            '        Call Process(True, False)
            '    Case "PAEvaluate"
            '        Call Process(False, False)
            '    Case "newscan"
            '        Call NewProcess(False, False)
            '    Case "newscanblank"
            '        Call NewProcess(True, False)
            '    Case "rescan"
            '        Call NewProcess(False, True)
            'End Select

        End Sub

        Private Sub updateResEstbtn_Click(sender As Object, e As EventArgs) Handles updateResEstbtn.Click
            Dim sQuery As String
            Dim conn As SqlConnection = New SqlConnection("Data Source=SERVER3\LEARNAID;Initial Catalog=LA;User ID=sa")
            Dim comm, comm2 As New SqlCommand
            Dim ansdb As ADODB.Recordset
            Dim resestdb As ADODB.Recordset
            Dim jid As String

            jid = InputBox("Please enter the job ID.", "JOB ID SELECTION")
            sQuery = "SELECT * FROM Answers WHERE a_j_id = " + Integer.Parse(jid).ToString
            ansdb.Open(sQuery, conn)
        End Sub
        Private Sub ViewEditStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewEditStudentToolStripMenuItem.Click
            Call GetNamesForJobAIDR(GetIDFromKey((LastClickedItemKey)))
        End Sub

        Private Sub ViewWarningsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewWarningsToolStripMenuItem.Click
            If Not (lvJobs.FocusedItem Is Nothing) Then
                frmWarnings.iJobID = GetIDFromKey(lvJobs.FocusedItem.Name)
                frmWarnings.ShowDialog()
            Else
                MsgBox("Please select a job.", MsgBoxStyle.Information)
            End If
        End Sub
        Private Sub VWarnings_Click(sender As Object, e As EventArgs) Handles VWarnings.Click
            Call frmMain.mnuVWarnings_Click(sender, e)
        End Sub
#End Region
#Region "LEVEL TWO ROUTINES"
        Private Sub Load_Job()
            If (btnAll.Checked) Then
                Jobs_WhereStatement = String.Empty
            ElseIf (btnMyJobs.Checked) Then
                Jobs_WhereStatement = " Where J_COMP_ID = '" & Config.COMP_ID & "'"
            ElseIf (btnPending.Checked) Then
                Jobs_WhereStatement = " Where J_STATUS = 0"
            End If

            Call FillJobsView2()
            lvJobs.Focus()
        End Sub
        Sub NewProcess(ByRef bBlank As Boolean, Optional ByRef Reprocess As Boolean = False)
            Dim sQuery As String
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset
            Dim RsA As New ADODB.Recordset
            Dim RsC As New ADODB.Recordset
            Dim RsJ As New ADODB.Recordset

            Dim J_Status As Object
            Dim j_plugin As Object


            Dim sJob As String = String.Empty

            OpenConnection(Cn, Config.ConnectionString)
            If lvJobs.FocusedItem Is Nothing Then
                MessageBox.Show("Please select a job.", "Selection error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                If GetIDFromKey(lvJobs.FocusedItem.Index) = -1 Then
                    Exit Sub
                End If
            End If
            sJob = GetIDFromKey(lvJobs.FocusedItem.Name).ToString
            If sJob = String.Empty Then
                MsgBox("Select a Job")
                Exit Sub
            End If

            '1. Seleccionar todos los de scan con el job id
            '2. hacer loop para sacar cada contestacion y hacer search en answers.
            '3.

            sQuery = "select * from jobs where j_id = " & sJob
            RsJ.Open(sQuery, Cn, 1, 3, 0)

            'UPGRADE_WARNING: Couldn't resolve default property of object j_plugin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            j_plugin = RsJ.Fields("j_plugin").Value
            'UPGRADE_WARNING: Couldn't resolve default property of object J_Status. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            J_Status = RsJ.Fields("J_Status").Value
            RsJ.Close()
            Cn.Close()

            Select Case j_plugin
                Case "BATC2"
                    If bBlank = False Then
                        If Reprocess Then
                            If MsgBox("Already process. Rescan?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                ScanProcess_C2_Reprocess()
                            Else
                                Exit Sub
                            End If
                        Else
                            Call ScanProcess_C2()
                        End If
                    Else
                        Call ScanProcess_C2_Blank()
                    End If
                Case "BAT23_34"
                    If bBlank = False Then
                        If Reprocess Then
                            MsgBox("Reprocess only in C2", MsgBoxStyle.OkOnly)
                            Exit Sub
                        End If
                        Call ScanProcess_2009()
                    Else
                        Call ScanProcess_2009_Blank()
                    End If
                Case "BAT23", "BAT34", "BAT-34"
                    If bBlank = False Then
                        If Reprocess Then
                            MsgBox("Reprocess only in C2", MsgBoxStyle.OkOnly)
                            Exit Sub
                        End If
                        Call ScanProcess_2009()
                    Else
                        Call ScanProcess_2009_Blank()
                    End If
                Case "BAT122005", "BAT12"
                    If bBlank = False Then
                        If Reprocess Then
                            MsgBox("Reprocess only in C2", MsgBoxStyle.OkOnly)
                            Exit Sub
                        End If
                        Call ScanProcess_2005()
                    Else
                        Call ScanProcess_2005_Blank()
                    End If
                Case "BATAIDR", "BATPRE1", "DIAL4-K", "DIAL4-PK", "DIAL4-PPK", "DIAL4-PPK2"
                    If bBlank = False Then
                        If Reprocess Then
                            MsgBox("Reprocess only in C2", MsgBoxStyle.OkOnly)
                            Exit Sub
                        End If
                        Call ScanProcess_A10()
                    Else
                        MsgBox("Blank A10 not implemented", MsgBoxStyle.OkOnly)
                        'Call ScanProcess_A10_Blank
                    End If
            End Select


        End Sub
        Sub Process(ByVal Scan As Boolean, ByVal Selected As Boolean)
            Dim iCounter1 As Integer
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset

            frmProcess.Scan = Scan
            If Selected Then
                For iCounter1 = 0 To lvJobs.Items.Count - 1
                    'Status = 0 Pending                    
                    If lvJobs.Items.Item(iCounter1).Selected And lvJobs.Items.Item(iCounter1).SubItems.Item(6).Tag = "2" And Scan = False Then
                        frmProcess.JobIds.Add(GetIDFromKey((lvJobs.Items.Item(iCounter1).Name)))
                    ElseIf lvJobs.Items.Item(iCounter1).Selected And lvJobs.Items.Item(iCounter1).SubItems.Item(6).Tag = "0" And Scan = True Then
                        frmProcess.JobIds.Add(GetIDFromKey((lvJobs.Items.Item(iCounter1).Name)))
                    End If
                Next iCounter1
            Else
                For iCounter1 = 0 To lvJobs.Items.Count - 1
                    'Status = 0 Pending                   
                    If lvJobs.Items.Item(iCounter1).SubItems.Item(6).Tag = "2" And Scan = False Then
                        frmProcess.JobIds.Add(GetIDFromKey((lvJobs.Items.Item(iCounter1).Name)))
                    ElseIf lvJobs.Items.Item(iCounter1).SubItems.Item(6).Tag = "0" And Scan = True Then
                        frmProcess.JobIds.Add(GetIDFromKey((lvJobs.Items.Item(iCounter1).Name)))
                    End If
                Next iCounter1
            End If
            If frmProcess.JobIds.Count() > 0 Then
                frmProcess.ShowDialog()
            Else
                frmProcess.Close()
            End If
        End Sub
        Sub SetControls()

            ''mcTab.Top = ScaleHeight - mcTab.Height
            ''mcTab.Left = 0
            ''mcTab.Width = ScaleWidth


            'On Error Resume Next
            'lvJobs.Left = 0
            'lvJobs.Top = Me.Toolbar.Height
            'lvJobs.Width = ClientRectangle.Width
            ''lvJobs.Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(ClientRectangle.Height) - VB6.PixelsToTwipsY(lvJobs.Top) - VB6.PixelsToTwipsY(mcTab.Height))
            'On Error GoTo 0

        End Sub
        'Called By: lvJobs_Click()
        Sub ValidateMenuOptions()
            Dim Cn As ADODB.Connection
            Dim Rs As ADODB.Recordset
            Cn = New ADODB.Connection
            Rs = New ADODB.Recordset

            Dim jtype As Object
            Dim iGrade As Short
            Dim iSemester As Short
            Dim sKey As String
            Dim Status As Short
            Dim ProcStatus As Short
            Dim isPEP As Boolean

            If Not (lvJobs.FocusedItem Is Nothing) Then
                sKey = lvJobs.FocusedItem.Name
                OpenConnection(Cn, Config.ConnectionString)

                Rs.Open("Select * From Jobs Where J_ID =" & GetIDFromKey(sKey).ToString.Trim, Cn)
                iGrade = Rs.Fields("J_GRADE").Value
                iSemester = Rs.Fields("J_SEM").Value
                Status = Rs.Fields("J_Status").Value
                ProcStatus = Rs.Fields("J_Process_Status").Value
                isPEP = GetValue(Rs.Fields("j_pepv"), 0) > 0
                'UPGRADE_WARNING: Couldn't resolve default property of object jtype. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                jtype = Rs.Fields("j_type").Value
                ' If Status = 0 And ProcStatus = 0 Then
                'If Status = 0 Then
                frmMain.mnuEditJob.Enabled = True
                'Else
                '    frmMain.mnuEditJob.Enabled = False
                'End If

                'UPGRADE_WARNING: Couldn't resolve default property of object jtype. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If (iGrade + iSemester >= 6 And isPEP = False) And (jtype <> 0) And (Status = 0) Then
                    frmMain.mnuStudentList.Enabled = False
                Else
                    frmMain.mnuStudentList.Enabled = True
                End If
            End If
        End Sub
#End Region
#Region "LEVEL THREE ROUTINES"
        Sub ScanProcess_2005()
            Dim sQuery As String
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset
            Dim RsA As New ADODB.Recordset
            Dim RsJ As New ADODB.Recordset
            Dim RsC As New ADODB.Recordset

            Dim aList() As String
            Dim ba As String
            Dim bc As String
            Dim bq As String
            Dim iOk As Integer
            Dim iCounter1 As Integer
            Dim iCounter2 As Integer
            Dim iOkTotal As Integer
            Dim iTot As Integer
            Dim iTotal As Integer
            Dim jobIds As New ArrayList()
            Dim sJob As String = String.Empty
            Dim slist As String
            Dim sresult As String
            Dim student_id As String
            Dim TotStud As Integer

            OpenConnection(Cn, Config.ConnectionString)

            sJob = GetIDFromKey(lvJobs.FocusedItem.Name).ToString.Trim
            If sJob = String.Empty Then
                MsgBox("Select a Job")
                Exit Sub
            End If
            sQuery = "select * from jobs where j_id = " & sJob
            RsJ.Open(sQuery, Cn, 1, 3, 0)
            sQuery = "select * from _scans where jobid like '" & sJob & "-%'"
            Rs.Open(sQuery, Cn, 3, 3)
            TotStud = 0
            While Not Rs.EOF
                TotStud += 1
                student_id = Split(Rs.Fields("jobid").Value, "-")(1)
                sQuery = "select * from answers where a_id = " & student_id
                RsA.Open(sQuery, Cn, 1, 3, 0)

                If RsA.EOF Or RsA.BOF Then
                    MsgBox("Hoja Estudiante #" & student_id & " no existe.")
                    Exit Sub
                End If
                'NV
                If Not IsDBNull(RsJ.Fields("j_nv").Value) AndAlso RsJ.Fields("j_nv").Value > 0 Then
                    sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_nv").Value.ToString.Trim
                    RsC.Open(sQuery, Cn, 3, 3)
                    iOkTotal = 0
                    iTotal = 0
                    For iCounter1 = 1 To 3
                        slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString.Trim
                        aList = Split(slist, "|")
                        sresult = String.Empty
                        iTot = 0
                        iOk = 0
                        For iCounter2 = 0 To UBound(aList)
                            bq = Split(aList(iCounter2), "-")(0)
                            ba = Split(aList(iCounter2), "-")(1)
                            bc = Rs.Fields("nvp" & iCounter1.ToString.Trim & "_" & bq).Value.ToString.Trim
                            sresult &= bq & "-" & bc & "|"
                            iTot += 1
                            iTotal += 1
                            If ba.Trim = bc.Trim Then
                                'contesto correctamente
                                iOk += 1
                                iOkTotal += 1
                            End If
                        Next iCounter2
                        RsA.Fields("a_n" & iCounter1.ToString.Trim).Value = sresult
                        RsA.Fields("a_n" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                    Next iCounter1
                    RsA.Fields("a_newscan").Value = 1
                    RsA.Fields("a_nv_total").Value = iOkTotal / iTotal
                    RsA.Update()
                    RsC.Close()
                End If

                'LES
                If Not IsDBNull(RsJ.Fields("j_les").Value) AndAlso RsJ.Fields("j_les").Value > 0 Then
                    sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_les").Value.ToString.Trim
                    RsC.Open(sQuery, Cn, 3, 3)
                    iOkTotal = 0
                    iTotal = 0
                    For iCounter1 = 1 To 20
                        If Not IsDBNull(RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString) AndAlso RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString <> "" Then
                            slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value
                            aList = Split(slist, "|")
                            sresult = String.Empty
                            iTot = 0
                            iOk = 0
                            For iCounter2 = 0 To UBound(aList)
                                bq = Split(aList(iCounter2), "-")(0)
                                ba = Split(aList(iCounter2), "-")(1)
                                bc = Rs.Fields("les_" & bq).Value.ToString.Trim
                                sresult &= bq & "-" & bc & "|"
                                iTot += 1
                                iTotal += 1
                                If ba.Trim = bc.Trim Then
                                    'contesto correctamente
                                    iOk += 1
                                    iOkTotal += 1
                                End If
                            Next iCounter2
                            RsA.Fields("a_l" & iCounter1.ToString.Trim).Value = sresult
                            RsA.Fields("a_l" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                        End If
                    Next iCounter1
                    RsA.Fields("a_newscan").Value = 1
                    RsA.Fields("a_les_total").Value = iOkTotal / iTotal
                    RsA.Update()
                    RsC.Close()
                End If

                'MAT
                If Not IsDBNull(RsJ.Fields("j_mat").Value) AndAlso RsJ.Fields("j_mat").Value > 0 Then
                    sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_mat").Value.ToString.Trim
                    RsC.Open(sQuery, Cn, 3, 3)
                    iTotal = 0
                    iOkTotal = 0
                    For iCounter1 = 1 To 20
                        If Not IsDBNull(RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString) AndAlso RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString <> "" Then
                            slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString.Trim
                            aList = Split(slist, "|")
                            sresult = String.Empty
                            iTot = 0
                            iOk = 0
                            For iCounter2 = 0 To UBound(aList)
                                bq = Split(aList(iCounter2), "-")(0)
                                ba = Split(aList(iCounter2), "-")(1)
                                bc = Rs.Fields("mat_" & bq).Value.ToString.Trim
                                sresult &= bq & "-" & bc & "|"
                                iTot += 1
                                iTotal += 1
                                If ba.Trim = bc.Trim Then
                                    'contesto correctamente
                                    iOk += 1
                                    iOkTotal += 1
                                End If
                            Next iCounter2
                            RsA.Fields("a_m" & iCounter1.ToString.Trim).Value = sresult
                            RsA.Fields("a_m" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                        End If
                    Next iCounter1
                    RsA.Fields("a_newscan").Value = 1
                    RsA.Fields("a_mat_total").Value = iOkTotal / iTotal
                    RsA.Update()
                    RsC.Close()
                End If

                'REN
                If Not IsDBNull(RsJ.Fields("j_ren").Value) AndAlso RsJ.Fields("j_ren").Value > 0 Then
                    sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_ren").Value.ToString.Trim
                    RsC.Open(sQuery, Cn, 3, 3)
                    iTotal = 0
                    iOkTotal = 0
                    For iCounter1 = 1 To 20
                        If Not IsDBNull(RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString) AndAlso RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString <> "" Then
                            slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value
                            aList = Split(slist, "|")
                            sresult = String.Empty
                            iTot = 0
                            iOk = 0
                            For iCounter2 = 0 To UBound(aList)
                                bq = Split(aList(iCounter2), "-")(0)
                                ba = Split(aList(iCounter2), "-")(1)
                                bc = Rs.Fields("ren_" & bq).Value.ToString.Trim
                                sresult &= bq & "-" & bc & "|"
                                iTot += 1
                                iTotal += 1
                                If ba.Trim = bc.Trim Then
                                    'contesto correctamente
                                    iOk += 1
                                    iOkTotal += 1
                                End If
                            Next iCounter2
                            RsA.Fields("a_r" & iCounter1.ToString.Trim).Value = sresult
                            RsA.Fields("a_r" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                        End If
                    Next iCounter1
                    RsA.Fields("a_newscan").Value = 1
                    RsA.Fields("a_ren_total").Value = iOkTotal / iTotal
                    RsA.Update()
                    RsC.Close()
                End If

                RsA.Close()
                'MoveRecord(Rs.Fields("jobid").Value, "_scans2009")
                jobIds.Add(Rs.Fields("jobid").Value)
                Rs.MoveNext()
            End While
            Rs.Close()

            For Each jobId As String In jobIds
                MoveRecord(jobId, "_scans")
            Next
            RsJ.Fields("j_status").Value = 4
            RsJ.Update()
            RsJ.Close()
            Cn.Close()

            MsgBox("Proceso Completado. Total Estudiantes Procesados = " & TotStud.ToString)

        End Sub

        Sub ScanProcess_2005_Blank()
            Dim sQuery As String
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset
            Dim RsA As New ADODB.Recordset
            Dim RsJ As New ADODB.Recordset
            Dim RsC As New ADODB.Recordset

            Dim aList() As String
            Dim ba As String
            Dim bc As String
            Dim bq As String
            Dim iOk As Integer
            Dim iCounter1 As Integer
            Dim iCounter2 As Integer
            Dim iOkTotal As Integer
            Dim iTot As Integer
            Dim iTotal As Integer
            Dim jobIds As New ArrayList()
            Dim sJob As String = String.Empty
            Dim slist As String
            Dim sresult As String
            Dim student_id As String
            Dim TotStud As Integer


            OpenConnection(Cn, Config.ConnectionString)

            sJob = GetIDFromKey(lvJobs.FocusedItem.Name).ToString.Trim
            If sJob = String.Empty Then
                MsgBox("Select a Job")
                Exit Sub
            End If

            sQuery = "select * from jobs where j_id = " & sJob
            RsJ.Open(sQuery, Cn, 1, 3, 0)

            sQuery = "select * from _scans"
            Rs.Open(sQuery, Cn, 3, 3)

            sQuery = "select * from answers where a_j_id = " & sJob & " AND a_ausente = 0 and a_newscan = 0 ORDER BY a_order, a_id"
            RsA.Open(sQuery, Cn, 1, 3, 0)

            If Not RsA.RecordCount.Equals(Rs.RecordCount) Then
                MsgBox("Total Estudiantes escaneados no concuerda con listado de estudiantes")
                RsA.Close()
                Rs.Close()
                Cn.Close()
                Exit Sub
            End If
            RsA.MoveFirst()
            TotStud = 0
            While Not Rs.EOF
                TotStud += 1

                'NV
                If Not IsDBNull(RsJ.Fields("j_nv").Value) And RsJ.Fields("j_nv").Value > 0 Then
                    sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_nv").Value.ToString.Trim
                    RsC.Open(sQuery, Cn, 3, 3)
                    iOkTotal = 0
                    iTotal = 0
                    For iCounter1 = 1 To 3
                        slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString.Trim
                        aList = Split(slist, "|")
                        sresult = String.Empty
                        iTot = 0
                        iOk = 0
                        For iCounter2 = 0 To UBound(aList)
                            bq = Split(aList(iCounter2), "-")(0)
                            ba = Split(aList(iCounter2), "-")(1)
                            bc = Rs.Fields("nvp" & iCounter1.ToString.Trim & "_" & bq).Value.ToString.Trim
                            sresult &= bq & "-" & bc & "|"
                            iTot += 1
                            iTotal += 1
                            If ba.Trim = bc.Trim Then
                                'contesto correctamente
                                iOk += 1
                                iOkTotal += 1
                            End If
                        Next iCounter2
                        RsA.Fields("a_n" & iCounter1.ToString.Trim).Value = sresult
                        RsA.Fields("a_n" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                    Next iCounter1
                    RsA.Fields("a_newscan").Value = 1
                    RsA.Fields("a_nv_total").Value = iOkTotal / iTotal
                    RsA.Update()
                    RsC.Close()
                End If

                'LES
                If Not IsDBNull(RsJ.Fields("j_les").Value) And RsJ.Fields("j_les").Value > 0 Then
                    sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_les").Value.ToString.Trim
                    RsC.Open(sQuery, Cn, 3, 3)
                    iOkTotal = 0
                    iTotal = 0
                    For iCounter1 = 1 To 20
                        If Not IsDBNull(RsC.Fields("cl_" & iCounter1.ToString.Trim).Value) Then
                            If RsC.Fields("cl_" & iCounter1.ToString.Trim).Value <> String.Empty Then
                                slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value
                                aList = Split(slist, "|")
                                sresult = String.Empty
                                iTot = 0
                                iOk = 0
                                For iCounter2 = 0 To UBound(aList)
                                    bq = Split(aList(iCounter2), "-")(0)
                                    ba = Split(aList(iCounter2), "-")(1)
                                    bc = Rs.Fields("les_" & bq).Value
                                    sresult &= bq & "-" & bc & "|"
                                    iTot += 1
                                    iTotal += 1
                                    If ba.Trim = bc.Trim Then
                                        'contesto correctamente
                                        iOk += 1
                                        iOkTotal += 1
                                    End If
                                Next iCounter2
                                RsA.Fields("a_l" & iCounter1.ToString.Trim).Value = sresult
                                RsA.Fields("a_l" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                            End If
                        End If
                    Next iCounter1
                    RsA.Fields("a_newscan").Value = 1
                    RsA.Fields("a_les_total").Value = iOkTotal / iTotal
                    RsA.Update()
                    RsC.Close()
                End If

                'MAT
                If Not IsDBNull(RsJ.Fields("j_mat").Value) And RsJ.Fields("j_mat").Value > 0 Then
                    sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_mat").Value.ToString.Trim
                    RsC.Open(sQuery, Cn, 3, 3)
                    iTotal = 0
                    iOkTotal = 0
                    For iCounter1 = 1 To 20
                        If Not IsDBNull(RsC.Fields("cl_" & iCounter1.ToString.Trim).Value) Then
                            If RsC.Fields("cl_" & iCounter1.ToString.Trim).Value <> String.Empty Then
                                slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value
                                aList = Split(slist, "|")
                                sresult = String.Empty
                                iTot = 0
                                iOk = 0
                                For iCounter2 = 0 To UBound(aList)
                                    bq = Split(aList(iCounter2), "-")(0)
                                    ba = Split(aList(iCounter2), "-")(1)
                                    bc = Rs.Fields("mat_" & bq).Value.ToString.Trim
                                    sresult &= bq & "-" & bc & "|"
                                    iTot += 1
                                    iTotal += 1
                                    If ba.Trim = bc.Trim Then
                                        'contesto correctamente
                                        iOk += 1
                                        iOkTotal += 1
                                    End If
                                Next iCounter2
                                RsA.Fields("a_m" & iCounter1.ToString.Trim).Value = sresult
                                RsA.Fields("a_m" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                            End If
                        End If
                    Next iCounter1
                    RsA.Fields("a_newscan").Value = 1
                    RsA.Fields("a_mat_total").Value = iOkTotal / iTotal
                    RsA.Update()
                    RsC.Close()
                End If

                'REN
                If Not IsDBNull(RsJ.Fields("j_ren").Value) Then
                    If RsJ.Fields("j_ren").Value > 0 Then
                        sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_ren").Value.ToString.Trim
                        RsC.Open(sQuery, Cn, 3, 3)

                        iTotal = 0
                        iOkTotal = 0
                        For iCounter1 = 1 To 20
                            If Not IsDBNull(RsC.Fields("cl_" & iCounter1.ToString.Trim).Value) Then
                                If RsC.Fields("cl_" & iCounter1.ToString.Trim).Value <> "" Then
                                    slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value
                                    aList = Split(slist, "|")
                                    sresult = String.Empty
                                    iTot = 0
                                    iOk = 0
                                    For iCounter2 = 0 To UBound(aList)
                                        bq = Split(aList(iCounter2), "-")(0)
                                        ba = Split(aList(iCounter2), "-")(1)
                                        bc = Rs.Fields("ren_" & bq).Value.ToString.Trim
                                        sresult &= bq & "-" & bc & "|"
                                        iTot += 1
                                        iTotal += 1
                                        If ba.Trim = bc.Trim Then
                                            'contesto correctamente
                                            iOk += 1
                                            iOkTotal += 1
                                        End If
                                    Next iCounter2
                                    RsA.Fields("a_r" & iCounter1.ToString.Trim).Value = sresult
                                    RsA.Fields("a_r" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                                End If
                            End If
                        Next iCounter1
                        RsA.Fields("a_newscan").Value = 1
                        RsA.Fields("a_ren_total").Value = iOkTotal / iTotal
                        RsA.Update()
                        RsC.Close()
                    End If
                End If
                'actualizo el formid para actualizarlo ya que esta en blanco o incorrecto
                Rs.Fields("jobid").Value = RsJ.Fields("j_id").Value & "-" & RsA.Fields("a_id").Value
                Rs.Update()
                RsA.MoveNext()
                'MoveRecord(Rs.Fields("jobid").Value, "_scans")
                Rs.MoveNext()
            End While

            For Each jobId As String In jobIds
                MoveRecord(jobId, "_scans")
            Next

            RsJ.Fields("j_status").Value = 4
            RsJ.Update()
            RsJ.Close()
            MsgBox("Proceso Completado. Total Estudiantes Procesados = " & TotStud)
        End Sub

        Sub ScanProcess_2009()
            Dim sQuery As String
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset
            Dim RsA As New ADODB.Recordset
            Dim RsJ As New ADODB.Recordset
            Dim RsC As New ADODB.Recordset
            Dim RsE As New ADODB.Recordset

            Dim aList() As String
            Dim ba As String
            Dim bc As String
            Dim bq As String
            Dim iCounter1 As Integer
            Dim iCounter2 As Integer
            Dim iOk As Integer
            Dim iOkTotal As Integer
            Dim iTot As Integer
            Dim iTotal As Integer
            Dim jobIds As New ArrayList()
            Dim sJob As String = String.Empty
            Dim slist As String
            Dim sresult As String
            Dim student_id As String
            Dim TotStud As Integer


            OpenConnection(Cn, Config.ConnectionString)
            sJob = CStr(GetIDFromKey(lvJobs.FocusedItem.Name))
            If sJob = "" Then
                MsgBox("Select a Job")
                Exit Sub
            End If

            sQuery = "select * from jobs where j_id = " & sJob
            RsJ.Open(sQuery, Cn, 1, 3, 0)
            sQuery = "select * from _scans2009 where jobid like '" & sJob & "-%'"
            Rs.Open(sQuery, Cn, 3, 3)
            TotStud = 0
            While Not Rs.EOF
                TotStud = TotStud + 1
                student_id = Split(Rs.Fields("jobid").Value, "-")(1)
                sQuery = "select * from answers where a_id = " & student_id
                RsA.Open(sQuery, Cn, 1, 3, 0)

                'NV
                If Not IsDBNull(RsJ.Fields("j_nv").Value) AndAlso RsJ.Fields("j_nv").Value > 0 Then
                    sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_nv").Value.ToString.Trim
                    RsC.Open(sQuery, Cn, 3, 3)
                    iOkTotal = 0
                    iTotal = 0
                    For iCounter1 = 1 To 1
                        'ScanProcessor("ScanProcess_2009")
                        slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString.Trim
                        aList = Split(slist, "|")
                        sresult = String.Empty
                        iTot = 0
                        iOk = 0
                        For iCounter2 = 0 To UBound(aList)
                            bq = Split(aList(iCounter2), "-")(0)
                            ba = Split(aList(iCounter2), "-")(1)
                            bc = Rs.Fields("nvp" & iCounter1 & "_" & bq).Value.ToString.Trim
                            sresult &= bq & "-" & bc & "|"
                            iTot += 1
                            iTotal += 1
                            If ba.Trim = bc.Trim Then
                                'contesto correctamente
                                iOk += 1
                                iOkTotal += 1
                            End If
                        Next iCounter2
                        RsA.Fields("a_n" & iCounter1.ToString.Trim).Value = sresult
                        RsA.Fields("a_n" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                    Next iCounter1
                    RsA.Fields("a_newscan").Value = 1
                    RsA.Fields("a_nv_total").Value = iOkTotal / iTotal
                    RsA.Update()
                    RsC.Close()
                End If

                'LES
                If Not IsDBNull(RsJ.Fields("j_les").Value) AndAlso RsJ.Fields("j_les").Value > 0 Then
                    sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_les").Value.ToString
                    RsC.Open(sQuery, Cn, 3, 3)

                    iOkTotal = 0
                    iTotal = 0
                    For iCounter1 = 1 To 20
                        If Not IsDBNull(RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString.Trim) And RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString <> String.Empty Then
                            slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value
                            aList = Split(slist, "|")
                            sresult = String.Empty
                            iTot = 0
                            iOk = 0
                            For iCounter2 = 0 To UBound(aList)
                                bq = Split(aList(iCounter2), "-")(0)
                                ba = Split(aList(iCounter2), "-")(1)
                                bc = Rs.Fields("les_" & bq).Value.ToString.Trim
                                sresult &= bq & "-" & bc & "|"
                                iTot += 1
                                iTotal += 1
                                If ba.Trim = bc.Trim Then
                                    'contesto correctamente
                                    iOk += 1
                                    iOkTotal += 1
                                End If
                            Next iCounter2
                            RsA.Fields("a_l" & iCounter1.ToString.Trim).Value = sresult
                            RsA.Fields("a_l" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                        End If
                    Next iCounter1
                    RsA.Fields("a_newscan").Value = 1
                    RsA.Fields("a_les_total").Value = iOkTotal / iTotal
                    RsA.Update()
                    RsC.Close()
                End If

                'MAT
                If Not IsDBNull(RsJ.Fields("j_mat").Value) AndAlso RsJ.Fields("j_mat").Value > 0 Then
                    sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_mat").Value.ToString.Trim
                    RsC.Open(sQuery, Cn, 3, 3)

                    iTotal = 0
                    iOkTotal = 0
                    For iCounter1 = 1 To 20
                        If Not IsDBNull(RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString) AndAlso RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString <> "" Then
                            slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString.Trim
                            aList = Split(slist, "|")
                            sresult = String.Empty
                            iTot = 0
                            iOk = 0
                            For iCounter2 = 0 To UBound(aList)
                                bq = Split(aList(iCounter2), "-")(0)
                                If bq <> String.Empty Then
                                    ba = Split(aList(iCounter2), "-")(1)
                                    bc = Rs.Fields("mat_" & bq).Value.ToString.Trim
                                    sresult &= bq & "-" & bc & "|"
                                    iTot += 1
                                    iTotal += 1
                                    If ba.Trim = bc.Trim Then
                                        'contesto correctamente
                                        iOk += 1
                                        iOkTotal += 1
                                    End If
                                End If
                            Next iCounter2
                            RsA.Fields("a_m" & iCounter1.ToString.Trim).Value = sresult
                            RsA.Fields("a_m" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                        End If
                    Next iCounter1
                    RsA.Fields("a_newscan").Value = 1
                    RsA.Fields("a_mat_total").Value = iOkTotal / iTotal
                    RsA.Update()
                    RsC.Close()
                End If

                'REN
                If Not IsDBNull(RsJ.Fields("j_ren").Value) AndAlso RsJ.Fields("j_ren").Value > 0 Then
                    sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_ren").Value
                    RsC.Open(sQuery, Cn, 3, 3)

                    iTotal = 0
                    iOkTotal = 0
                    For iCounter1 = 1 To 20
                        If Not IsDBNull(RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString) And RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString <> String.Empty Then
                            slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString.Trim
                            aList = Split(slist, "|")
                            sresult = String.Empty
                            iTot = 0
                            iOk = 0
                            For iCounter2 = 0 To UBound(aList)
                                bq = Split(aList(iCounter2), "-")(0)
                                ba = Split(aList(iCounter2), "-")(1)
                                bc = Rs.Fields("ren_" & bq).Value.ToString.Trim
                                sresult &= bq & "-" & bc & "|"
                                iTot += 1
                                iTotal += 1
                                If ba.Trim = bc.Trim Then
                                    'contesto correctamente
                                    iOk += 1
                                    iOkTotal += 1
                                End If
                            Next iCounter2
                            RsA.Fields("a_r" & iCounter1.ToString.Trim).Value = sresult
                            RsA.Fields("a_r" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                        End If
                    Next iCounter1
                    RsA.Fields("a_newscan").Value = 1
                    RsA.Fields("a_ren_total").Value = iOkTotal / iTotal
                    RsA.Update()
                    RsC.Close()
                End If

                RsA.Close()
                'MoveRecord(Rs.Fields("jobid").Value, "_scans2009")
                jobIds.Add(Rs.Fields("jobid").Value)
                Rs.MoveNext()
            End While
            Rs.Close()

            For Each jobId As String In jobIds
                MoveRecord(jobId, "_scans2009")
            Next

            RsJ.Fields("j_status").Value = 4
            RsJ.Update()
            RsJ.Close()
            Cn.Close()

            MsgBox("Proceso Completado. Total Estudiantes Procesados = " & TotStud)
        End Sub

        Sub ScanProcess_2009_Blank()
            Dim sQuery As String
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset
            Dim RsA As New ADODB.Recordset
            Dim RsJ As New ADODB.Recordset
            Dim RsC As New ADODB.Recordset

            Dim aList() As String
            Dim ba As String
            Dim bc As String
            Dim bq As String
            Dim iOk As Integer
            Dim iCounter1 As Integer
            Dim iCounter2 As Integer
            Dim iOkTotal As Integer
            Dim iTot As Integer
            Dim iTotal As Integer
            Dim jobIds As New ArrayList()
            Dim sJob As String = String.Empty
            Dim slist As String
            Dim sresult As String
            Dim student_id As String
            Dim TotStud As Integer

            OpenConnection(Cn, Config.ConnectionString)

            sJob = GetIDFromKey(lvJobs.FocusedItem.Name).ToString.Trim
            If sJob = String.Empty Then
                MsgBox("Select a Job")
                Exit Sub
            End If

            sQuery = "select * from jobs where j_id = " & sJob
            RsJ.Open(sQuery, Cn, 1, 3, 0)

            sQuery = "select * from _scans2009"
            Rs.Open(sQuery, Cn, 3, 3)

            sQuery = "select * from answers where a_j_id = " & sJob & " AND a_ausente = 0 and a_newscan = 0 ORDER BY a_order, a_id"
            RsA.Open(sQuery, Cn, 1, 3, 0)

            If Not RsA.RecordCount.Equals(Rs.RecordCount) Then
                MsgBox("Total Estudiantes escaneados no concuerda con listado de estudiantes")
                RsA.Close()
                Rs.Close()
                Cn.Close()
                Exit Sub
            End If
            RsA.MoveFirst()

            TotStud = 0
            While Not Rs.EOF
                TotStud += 1
                'student_id = Split(Rs("jobid"), "-")(1)

                'sQuery = "select * from answers where a_id = " & student_id
                'RsA.Open sQuery, Cn, 1, 3, 0

                'NV
                If Not IsDBNull(RsJ.Fields("j_nv").Value) And RsJ.Fields("j_nv").Value > 0 Then
                    sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_nv").Value.ToString.Trim
                    RsC.Open(sQuery, Cn, 3, 3)
                    iOkTotal = 0
                    iTotal = 0
                    For iCounter1 = 1 To 1
                        slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString.Trim
                        aList = Split(slist, "|")
                        sresult = String.Empty
                        iTot = 0
                        iOk = 0
                        For iCounter2 = 0 To UBound(aList)
                            bq = Split(aList(iCounter2), "-")(0)
                            ba = Split(aList(iCounter2), "-")(1)
                            bc = Rs.Fields("nvp" & iCounter1.ToString.Trim & "_" & bq).Value.ToString.Trim
                            sresult &= bq & "-" & bc & "|"
                            iTot += 1
                            iTotal = iTotal + 1
                            If ba.Trim = bc.Trim Then
                                'contesto correctamente
                                iOk = iOk + 1
                                iOkTotal = iOkTotal + 1
                            End If
                        Next iCounter2
                        RsA.Fields("a_n" & iCounter1.ToString.Trim).Value = sresult
                        RsA.Fields("a_n" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                    Next iCounter1
                    RsA.Fields("a_newscan").Value = 1
                    RsA.Fields("a_nv_total").Value = iOkTotal / iTotal
                    RsA.Update()
                    RsC.Close()
                End If

                'LES
                If Not IsDBNull(RsJ.Fields("j_les").Value) And RsJ.Fields("j_les").Value > 0 Then
                    sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_les").Value.ToString.Trim
                    RsC.Open(sQuery, Cn, 3, 3)

                    iOkTotal = 0
                    iTotal = 0
                    For iCounter1 = 1 To 20
                        If Not IsDBNull(RsC.Fields("cl_" & iCounter1.ToString.Trim).Value) AndAlso RsC.Fields("cl_" & iCounter1.ToString.Trim).Value <> String.Empty Then
                            slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString.Trim
                            aList = Split(slist, "|")
                            sresult = String.Empty
                            iTot = 0
                            iOk = 0
                            For iCounter2 = 0 To UBound(aList)
                                bq = Split(aList(iCounter2), "-")(0)
                                ba = Split(aList(iCounter2), "-")(1)
                                bc = Rs.Fields("les_" & bq).Value.ToString.Trim
                                sresult &= bq & "-" & bc & "|"
                                iTot += 1
                                iTotal += 1
                                If ba.Trim = bc.Trim Then
                                    'contesto correctamente
                                    iOk += 1
                                    iOkTotal += 1
                                End If
                            Next iCounter2
                            RsA.Fields("a_l" & iCounter1.ToString.Trim).Value = sresult
                            RsA.Fields("a_l" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                        End If
                    Next iCounter1
                    RsA.Fields("a_newscan").Value = 1
                    RsA.Fields("a_les_total").Value = iOkTotal / iTotal
                    RsA.Update()
                    RsC.Close()
                End If

                'MAT
                If Not IsDBNull(RsJ.Fields("j_mat").Value) AndAlso RsJ.Fields("j_mat").Value > 0 Then
                    sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_mat").Value.ToString.Trim
                    RsC.Open(sQuery, Cn, 3, 3)
                    iTotal = 0
                    iOkTotal = 0
                    For iCounter1 = 1 To 20
                        If Not IsDBNull(RsC.Fields("cl_" & iCounter1.ToString.Trim).Value) AndAlso RsC.Fields("cl_" & iCounter1.ToString.Trim).Value <> String.Empty Then
                            slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString.Trim
                            aList = Split(slist, "|")
                            sresult = String.Empty
                            iTot = 0
                            iOk = 0
                            For iCounter2 = 0 To UBound(aList)
                                bq = Split(aList(iCounter2), "-")(0)
                                ba = Split(aList(iCounter2), "-")(1)
                                bc = Rs.Fields("mat_" & bq).Value.ToString.Trim
                                sresult &= bq & "-" & bc & "|"
                                iTot += 1
                                iTotal += 1
                                If ba.Trim = bc.Trim Then
                                    'contesto correctamente
                                    iOk += 1
                                    iOkTotal += 1
                                End If
                            Next iCounter2
                            RsA.Fields("a_m" & iCounter1.ToString.Trim).Value = sresult
                            RsA.Fields("a_m" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                        End If
                    Next iCounter1
                    RsA.Fields("a_newscan").Value = 1
                    RsA.Fields("a_mat_total").Value = iOkTotal / iTotal
                    RsA.Update()
                    RsC.Close()
                End If

                'REN
                If Not IsDBNull(RsJ.Fields("j_ren").Value) AndAlso RsJ.Fields("j_ren").Value > 0 Then
                    sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_ren").Value.ToString.Trim
                    RsC.Open(sQuery, Cn, 3, 3)
                    iTotal = 0
                    iOkTotal = 0
                    For iCounter1 = 1 To 20
                        If Not IsDBNull(RsC.Fields("cl_" & iCounter1.ToString.Trim).Value) AndAlso RsC.Fields("cl_" & iCounter1.ToString.Trim).Value <> String.Empty Then
                            slist = RsC.Fields("cl_" & iCounter1).Value.ToString.Trim
                            aList = Split(slist, "|")
                            sresult = String.Empty
                            iTot = 0
                            iOk = 0
                            For iCounter2 = 0 To UBound(aList)
                                bq = Split(aList(iCounter2), "-")(0)
                                ba = Split(aList(iCounter2), "-")(1)
                                bc = Rs.Fields("ren_" & bq).Value.ToString.Trim
                                sresult &= bq & "-" & bc & "|"
                                iTot += 1
                                iTotal += 1
                                If ba.Trim = bc.Trim Then
                                    'contesto correctamente
                                    iOk += 1
                                    iOkTotal += 1
                                End If
                            Next iCounter2
                            RsA.Fields("a_r" & iCounter1.ToString.Trim).Value = sresult
                            RsA.Fields("a_r" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                        End If
                    Next iCounter1
                    RsA.Fields("a_newscan").Value = 1
                    RsA.Fields("a_ren_total").Value = iOkTotal / iTotal
                    RsA.Update()
                    RsC.Close()
                End If

                RsA.MoveNext()
                'MoveRecord(Rs.Fields("jobid").Value, "_scans2009")
                jobIds.Add(Rs.Fields("jobid").Value)
                Rs.MoveNext()
            End While
            Rs.Close()
            For Each jobId As String In jobIds
                MoveRecord(jobId, "_scans2009")
            Next

            RsJ.Fields("j_status").Value = 4
            RsJ.Update()
            RsJ.Close()
            Cn.Close()

            MsgBox("Proceso Completado. Total Estudiantes Procesados = " & TotStud)
        End Sub


        Sub ScanProcess_A10()
            Dim sQuery As String
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset
            Dim RsA As New ADODB.Recordset
            Dim RsJ As New ADODB.Recordset
            Dim RsC As New ADODB.Recordset

            Dim aList() As String
            Dim bDel As Boolean = False
            Dim ba As String
            Dim bc As String
            Dim bq As String
            Dim iOk As Integer
            Dim iCounter1 As Integer
            Dim iCounter2 As Integer
            Dim iOkTotal As Integer
            Dim iTot As Integer
            Dim iTotal As Integer
            Dim jid As String
            Dim jobIds As New ArrayList()
            Dim sJob As String = String.Empty
            Dim slist As String
            Dim sresult As String
            Dim sTot As Integer
            Dim student_id As String
            Dim TotStud As Integer
            OpenConnection(Cn, Config.ConnectionString)

            sJob = GetIDFromKey(lvJobs.FocusedItem.Name).ToString.Trim
            If sJob = String.Empty Then
                MsgBox("Select a Job")
                Exit Sub
            End If

            sQuery = "select * from jobs where j_id = " & sJob
            RsJ.Open(sQuery, Cn, 1, 3, 0)

            sQuery = "select * from _scans_AID where jobid = '" & sJob & "'"

            Rs.Open(sQuery, Cn, 3, 3)

            TotStud = 0
            While Not Rs.EOF
                bDel = False
                For iCounter1 = 1 To 6
                    student_id = Rs.Fields("aid_" & iCounter1.ToString.Trim & "_id").Value.ToString.Trim
                    If student_id <> String.Empty Then
                        sQuery = "select * from answers where a_id = " & student_id
                        RsA.Open(sQuery, Cn, 1, 3, 0)
                        If RsA.RecordCount = 1 Then
                            bDel = True
                            jid = Rs.Fields("JobID").Value.ToString.Trim & "-" & Rs.Fields("aid_1_id").Value.ToString.Trim
                            TotStud += 1
                            sTot = 0
                            For iCounter2 = 1 To 10
                                RsA.Fields("a_aidr" & iCounter2.ToString.Trim).Value = iCounter2.ToString.Trim & "-" & Rs.Fields("aid_a" & iCounter1.ToString.Trim & "_a" & iCounter2.ToString.Trim).Value
                                RsA.Fields("a_aidr" & iCounter2.ToString.Trim & "_total").Value = IIf(Rs.Fields("aid_a" & iCounter1.ToString.Trim & "_a" & iCounter2.ToString.Trim).Value = String.Empty, 0, Rs.Fields("aid_a" & iCounter1.ToString.Trim & "_a" & iCounter2.ToString.Trim).Value)
                                sTot += IIf(Rs.Fields("aid_a" & iCounter1.ToString.Trim & "_a" & iCounter2.ToString.Trim).Value = "", 0, Rs.Fields("aid_a" & iCounter1.ToString.Trim & "_a" & iCounter2.ToString.Trim).Value)
                            Next iCounter2
                            RsA.Fields("a_aidr_total").Value = sTot
                            RsA.Fields("a_newscan").Value = 1
                            RsA.Update()
                        End If
                        RsA.Close()
                    End If
                Next iCounter1
                If bDel Then
                    MoveRecord(CStr(jid), "_scans_AID", "_scansHist_AID")
                End If
                Rs.MoveNext()
            End While
            Rs.Close()
            RsJ.Fields("j_status").Value = 4
            RsJ.Update()
            RsJ.Close()
            MsgBox("Proceso Completado. Total Estudiantes Procesados = " & TotStud)
        End Sub


        Sub ScanProcess_C2()
            Dim sQuery As String
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset
            Dim RecordAns As New ADODB.Recordset
            Dim RecordResEst As New ADODB.Recordset
            Dim RsA As New ADODB.Recordset
            Dim RsJ As New ADODB.Recordset
            Dim RsC As New ADODB.Recordset
            Dim RsE As New ADODB.Recordset

            Dim aList() As String
            Dim ba As String
            Dim bc As String
            Dim bq As String
            Dim iCounter1 As Integer
            Dim iCounter2 As Integer
            Dim iOk As Integer
            Dim iOkTotal As Integer
            Dim iTot As Integer
            Dim iTotal As Integer
            Dim jobIds As New ArrayList()
            Dim sJob As String = String.Empty
            Dim slist As String
            Dim sresult As String
            Dim student_id As String
            Dim TotStud As Integer

            OpenConnection(Cn, Config.ConnectionString)
            sJob = GetIDFromKey(lvJobs.FocusedItem.Name).ToString.Trim
            If sJob = String.Empty Then
                MsgBox("Select a Job")
                Exit Sub
            End If

            '1. Seleccionar todos los de scan con el job id
            '2. hacer loop para sacar cada contestacion y hacer search en answers.
            '3.

            sQuery = "select * from jobs where j_id = " & sJob
            RsJ.Open(sQuery, Cn, 1, 3, 0)
            sQuery = "select * from _scans where jobid like '" & sJob & "-%'"
            Rs.Open(sQuery, Cn, 3, 3)
            sQuery = "select * from ResEst"
            RsE.Open(sQuery, Cn, 1, 3, 0)
            TotStud = 0
            While Not Rs.EOF
                TotStud += 1
                student_id = Split(Rs.Fields("jobid").Value, "-")(1)
                sQuery = "select * from answers where a_id = " & student_id
                RsA.Open(sQuery, Cn, 1, 3, 0)

                'NV
                If Not IsDBNull(RsJ.Fields("j_nv").Value) AndAlso RsJ.Fields("j_nv").Value > 0 Then
                    sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_nv").Value.ToString.Trim
                    RsC.Open(sQuery, Cn, 3, 3)
                    iOkTotal = 0
                    iTotal = 0
                    For iCounter1 = 1 To 3
                        slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value
                        aList = Split(slist, "|")
                        sresult = String.Empty
                        iTot = 0
                        iOk = 0
                        For iCounter2 = 0 To UBound(aList)
                            bq = Split(aList(iCounter2), "-")(0)
                            If bq <> "" Then
                                ba = Split(aList(iCounter2), "-")(1)
                                bc = Rs.Fields("nvp" & iCounter1 & "_" & bq).Value.ToString.Trim
                                sresult &= bq & "-" & bc & "|"
                                iTot += 1
                                iTotal += 1
                                If ba.Trim = bc.Trim Then
                                    'contesto correctamente
                                    iOk += 1
                                    iOkTotal += 1
                                End If
                            End If
                        Next iCounter2
                        RsA.Fields("a_n" & iCounter1.ToString.Trim).Value = sresult
                        RsA.Fields("a_n" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                    Next iCounter1
                    RsA.Fields("a_newscan").Value = 1
                    RsA.Fields("a_nv_total").Value = iOkTotal / iTotal
                    RsA.Update()
                    RsC.Close()
                End If

                'LES
                If Not IsDBNull(RsJ.Fields("j_les").Value) Then
                    If RsJ.Fields("j_les").Value > 0 Then
                        sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_les").Value.ToString.Trim
                        RsC.Open(sQuery, Cn, 3, 3)
                        iOkTotal = 0
                        iTotal = 0
                        For iCounter1 = 1 To 20
                            If Not IsDBNull(RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString.Trim) And RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString <> String.Empty Then
                                slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value
                                aList = Split(slist, "|")
                                sresult = String.Empty
                                iTot = 0
                                iOk = 0
                                For iCounter2 = 0 To UBound(aList)
                                    bq = Split(aList(iCounter2), "-")(0)
                                    ba = Split(aList(iCounter2), "-")(1)
                                    bc = Rs.Fields("les_" & bq).Value.ToString.Trim
                                    sresult &= bq & "-" & bc & "|"
                                    iTot += 1
                                    iTotal += 1
                                    If ba.Trim = bc.Trim Then
                                        'contesto correctamente
                                        iOk += 1
                                        iOkTotal += 1
                                    End If
                                Next iCounter2
                                RsA.Fields("a_l" & iCounter1.ToString.Trim).Value = sresult
                                RsA.Fields("a_l" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                            End If
                        Next iCounter1
                        RsA.Fields("a_newscan").Value = 1
                        RsA.Fields("a_les_total").Value = iOkTotal / iTotal
                        RsA.Update()
                        RsC.Close()
                    End If
                End If

                'MAT
                If Not IsDBNull(RsJ.Fields("j_mat").Value) Then
                    If RsJ.Fields("j_mat").Value > 0 Then
                        sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_mat").Value
                        RsC.Open(sQuery, Cn, 3, 3)
                        iTotal = 0
                        iOkTotal = 0
                        For iCounter1 = 1 To 20
                            If Not IsDBNull(RsC.Fields("cl_" & iCounter1).Value.ToString) And RsC.Fields("cl_" & iCounter1).Value.ToString <> String.Empty Then
                                slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value
                                aList = Split(slist, "|")
                                sresult = String.Empty
                                iTot = 0
                                iOk = 0
                                For iCounter2 = 0 To UBound(aList)
                                    bq = Split(aList(iCounter2), "-")(0)
                                    If bq <> String.Empty Then
                                        ba = Split(aList(iCounter2), "-")(1)
                                        bc = Rs.Fields("mat_" & bq).Value.ToString.Trim
                                        sresult &= bq & "-" & bc & "|"
                                        iTot += 1
                                        iTotal += 1
                                        If ba.Trim = bc.Trim Then
                                            'contesto correctamente
                                            iOk += 1
                                            iOkTotal += 1
                                        End If
                                    End If
                                Next iCounter2
                                RsA.Fields("a_m" & iCounter1.ToString.Trim).Value = sresult
                                RsA.Fields("a_m" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                            End If
                        Next iCounter1
                        RsA.Fields("a_newscan").Value = 1
                        RsA.Fields("a_mat_total").Value = iOkTotal / iTotal
                        RsA.Update()
                        RsC.Close()
                    End If
                End If

                'REN
                If Not IsDBNull(RsJ.Fields("j_ren").Value) Then
                    If RsJ.Fields("j_ren").Value > 0 Then
                        sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_ren").Value.ToString.Trim
                        RsC.Open(sQuery, Cn, 3, 3)
                        iTotal = 0
                        iOkTotal = 0
                        For iCounter1 = 1 To 20
                            If Not IsDBNull(RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString) Then
                                If RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString <> String.Empty Then
                                    slist = RsC.Fields("cl_" & iCounter1.ToString).Value
                                    aList = Split(slist, "|")
                                    sresult = String.Empty
                                    iTot = 0
                                    iOk = 0
                                    For iCounter2 = 0 To UBound(aList)
                                        bq = Split(aList(iCounter2), "-")(0)
                                        ba = Split(aList(iCounter2), "-")(1)
                                        bc = Rs.Fields("ren_" & bq).Value.ToString.Trim
                                        sresult &= bq & "-" & bc & "|"
                                        iTot += 1
                                        iTotal += 1
                                        If ba.Trim = bc.Trim Then
                                            'contesto correctamente
                                            iOk += 1
                                            iOkTotal += 1
                                        End If
                                    Next iCounter2
                                    RsA.Fields("a_r" & iCounter1.ToString.Trim).Value = sresult
                                    RsA.Fields("a_r" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                                End If
                            End If
                        Next iCounter1
                        RsA.Fields("a_newscan").Value = 1
                        RsA.Fields("a_ren_total").Value = iOkTotal / iTotal
                        RsA.Update()
                        RsC.Close()
                    End If
                End If
                RsA.Close()
                'MoveRecord(Rs.Fields("jobid").Value, "_scans2009")
                jobIds.Add(Rs.Fields("jobid").Value)
                Rs.MoveNext()
            End While
            Rs.Close()

            For Each jobId As String In jobIds
                MoveRecord(jobId, "_scans")
            Next

            RsJ.Fields("j_status").Value = 4
            RsJ.Update()
            RsJ.Close()
            MsgBox("Proceso Completado. Total Estudiantes Procesados = " & TotStud)
        End Sub

        Sub ScanProcess_C2_Blank()
            Dim sQuery As String
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset
            Dim RsA As New ADODB.Recordset
            Dim RsJ As New ADODB.Recordset
            Dim RsC As New ADODB.Recordset

            Dim aList() As String
            Dim ba As String
            Dim bc As String
            Dim bq As String
            Dim iOk As Integer
            Dim iCounter1 As Integer
            Dim iCounter2 As Integer
            Dim iOkTotal As Integer
            Dim iTot As Integer
            Dim iTotal As Integer
            Dim jobIds As New ArrayList()
            Dim sJob As String = String.Empty
            Dim slist As String
            Dim sresult As String
            Dim student_id As String
            Dim TotStud As Integer

            OpenConnection(Cn, Config.ConnectionString)

            sJob = GetIDFromKey(lvJobs.FocusedItem.Name).ToString.Trim
            If sJob = String.Empty Then
                MsgBox("Select a Job")
                Exit Sub
            End If

            sQuery = "select * from jobs where j_id = " & sJob
            RsJ.Open(sQuery, Cn, 1, 3, 0)

            sQuery = "select * from _scans"
            Rs.Open(sQuery, Cn, 1, 3, 0)

            sQuery = "select * from answers where a_j_id = " & sJob & " AND a_ausente = 0 and a_newscan = 0 ORDER BY a_order, a_id"
            RsA.Open(sQuery, Cn, 1, 3, 0)

            If Not RsA.RecordCount.Equals(Rs.RecordCount) Then
                MsgBox("Total Estudiantes escaneados no concuerda con listado de estudiantes")
                RsA.Close()
                Rs.Close()
                Cn.Close()
                Exit Sub
            End If
            RsA.MoveFirst()
            TotStud = 0
            While Not Rs.EOF
                TotStud += 1

                'NV
                If Not IsDBNull(RsJ.Fields("j_nv").Value) AndAlso RsJ.Fields("j_nv").Value > 0 Then
                    sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_nv").Value
                    RsC.Open(sQuery, Cn, 3, 3)
                    iOkTotal = 0
                    iTotal = 0
                    For iCounter1 = 1 To 3
                        slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value
                        aList = Split(slist, "|")
                        sresult = String.Empty
                        iTot = 0
                        iOk = 0
                        For iCounter2 = 0 To UBound(aList)
                            bq = Split(aList(iCounter2), "-")(0)
                            If bq <> "" Then
                                ba = Split(aList(iCounter2), "-")(1)
                                bc = Rs.Fields("nvp" & iCounter1 & "_" & bq).Value.ToString.Trim
                                sresult &= bq & "-" & bc & "|"
                                iTot += 1
                                iTotal += 1
                                If ba.Trim = bc.Trim Then
                                    'contesto correctamente
                                    iOk += 1
                                    iOkTotal += 1
                                End If
                            End If
                        Next iCounter2
                        RsA.Fields("a_n" & iCounter1.ToString.Trim).Value = sresult
                        RsA.Fields("a_n" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                    Next iCounter1
                    RsA.Fields("a_newscan").Value = 1
                    RsA.Fields("a_nv_total").Value = iOkTotal / iTotal
                    RsA.Update()
                    RsC.Close()
                End If

                'LES
                If Not IsDBNull(RsJ.Fields("j_les").Value) AndAlso RsJ.Fields("j_les").Value > 0 Then
                    sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_les").Value.ToString.Trim
                    RsC.Open(sQuery, Cn, 3, 3)
                    iOkTotal = 0
                    iTotal = 0
                    For iCounter1 = 1 To 20
                        If Not IsDBNull(RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString) And RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString <> String.Empty Then
                            slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value
                            aList = Split(slist, "|")
                            sresult = String.Empty
                            iTot = 0
                            iOk = 0
                            For iCounter2 = 0 To UBound(aList)
                                bq = Split(aList(iCounter2), "-")(0)
                                ba = Split(aList(iCounter2), "-")(1)
                                bc = Rs.Fields("les_" & bq).Value.ToString.Trim
                                sresult &= bq & "-" & bc & "|"
                                iTot += 1
                                iTotal += 1
                                If ba.Trim = bc.Trim Then
                                    'contesto correctamente
                                    iOk += 1
                                    iOkTotal += 1
                                End If
                            Next iCounter2
                            RsA.Fields("a_l" & iCounter1.ToString.Trim).Value = sresult
                            RsA.Fields("a_l" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                        End If
                    Next iCounter1
                    RsA.Fields("a_newscan").Value = 1
                    RsA.Fields("a_les_total").Value = iOkTotal / iTotal
                    RsA.Update()
                    RsC.Close()
                End If

                'MAT
                If Not IsDBNull(RsJ.Fields("j_mat").Value) AndAlso RsJ.Fields("j_mat").Value > 0 Then
                    sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_mat").Value.ToString.Trim
                    RsC.Open(sQuery, Cn, 3, 3)
                    iTotal = 0
                    iOkTotal = 0
                    For iCounter1 = 1 To 20
                        ' CP 2015.04.17 - not sure why, but needed to separate this as the comparison isn't stopping on DBNull
                        If Not IsDBNull(RsC.Fields("cl_" & iCounter1.ToString.Trim).Value) Then
                            If RsC.Fields("cl_" & iCounter1.ToString.Trim).Value <> String.Empty Then
                                slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString.Trim
                                ' CP 2015.04.17 - this is likely a hack, but we want to ignore "-"
                                slist = slist.ToString().Replace("|-", "")
                                aList = Split(slist, "|")
                                sresult = String.Empty
                                iTot = 0
                                iOk = 0
                                For Each item As String In aList
                                    Dim indexofstring As Integer
                                    If item = "-" Then
                                        item.Replace("-", vbNull)
                                    End If
                                Next
                                For iCounter2 = 0 To UBound(aList)
                                    bq = Split(aList(iCounter2), "-")(0)
                                    ba = Split(aList(iCounter2), "-")(1)
                                    bc = Rs.Fields("mat_" & bq).Value.ToString.Trim
                                    sresult &= bq & "-" & bc & "|"
                                    iTot += 1
                                    iTotal += 1
                                    If ba.Trim = bc.Trim Then
                                        'contesto correctamente
                                        iOk += 1
                                        iOkTotal += 1
                                    End If
                                Next iCounter2
                                RsA.Fields("a_m" & iCounter1.ToString.Trim).Value = sresult
                                RsA.Fields("a_m" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                            End If
                        End If
                    Next iCounter1
                    RsA.Fields("a_newscan").Value = 1
                    RsA.Fields("a_mat_total").Value = iOkTotal / iTotal
                    RsA.Update()
                    RsC.Close()
                End If

                'REN
                If Not IsDBNull(RsJ.Fields("j_ren").Value) AndAlso RsJ.Fields("j_ren").Value > 0 Then
                    sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_ren").Value
                    RsC.Open(sQuery, Cn, 3, 3)
                    iTotal = 0
                    iOkTotal = 0
                    For iCounter1 = 1 To 20
                        ' CP 2015.04.17 - had to separate as null values are falling into second comparison
                        If Not IsDBNull(RsC.Fields("cl_" & iCounter1.ToString.Trim).Value) Then
                            If RsC.Fields("cl_" & iCounter1.ToString.Trim).Value <> String.Empty Then
                                slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value.ToString.Trim
                                aList = Split(slist, "|")
                                sresult = String.Empty
                                iTot = 0
                                iOk = 0
                                For iCounter2 = 0 To UBound(aList)
                                    bq = Split(aList(iCounter2), "-")(0)
                                    ba = Split(aList(iCounter2), "-")(1)
                                    bc = Rs.Fields("ren_" & bq).Value.ToString
                                    sresult &= bq & "-" & bc & "|"
                                    iTot += 1
                                    iTotal += 1
                                    If ba.Trim = bc.Trim Then
                                        'contesto correctamente
                                        iOk += 1
                                        iOkTotal += 1
                                    End If
                                Next iCounter2
                                RsA.Fields("a_r" & iCounter1.ToString.Trim).Value = sresult
                                RsA.Fields("a_r" & iCounter1.ToString & "_total").Value = iOk / iTot
                            End If
                        End If
                    Next iCounter1
                    RsA.Fields("a_newscan").Value = 1
                    RsA.Fields("a_ren_total").Value = iOkTotal / iTotal
                    RsA.Update()
                    RsC.Close()
                End If

                ' CP 2015.04.20 - this is in the wrong place somewhow
                'RsA.Close()
                'MoveRecord(Rs.Fields("jobid").Value, "_scans")
                jobIds.Add(Rs.Fields("jobid").Value)
                Rs.MoveNext()
                ' CP 2015.04.20 - I added this, because I think that this routine moves Answers along with Scans (maybe.
                RsA.MoveNext()
            End While
            ' CP 2015.04.20 - moved the close here , outside of the loop that uses the RS
            RsA.Close()
            Rs.Close()

            For Each jobId As String In jobIds
                MoveRecord(jobId, "_scans")
            Next

            RsJ.Fields("j_status").Value = 4
            RsJ.Update()
            RsJ.Close()
            Cn.Close()

            MsgBox("Proceso Completado. Total Estudiantes Procesados = " & TotStud)


        End Sub

        Sub ScanProcess_C2_Reprocess()
            Dim sQuery As String
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset
            Dim RecordAns As New ADODB.Recordset
            Dim RecordResEst As New ADODB.Recordset
            Dim RsA As New ADODB.Recordset
            Dim RsJ As New ADODB.Recordset
            Dim RsC As New ADODB.Recordset
            Dim RsE As New ADODB.Recordset

            Dim aList() As String
            Dim ba As String
            Dim bc As String
            Dim bq As String
            Dim iCounter1 As Integer
            Dim iCounter2 As Integer
            Dim iOk As Integer
            Dim iOkTotal As Integer
            Dim iTot As Integer
            Dim iTotal As Integer
            Dim jobIds As New ArrayList()
            Dim sJob As String = String.Empty
            Dim slist As String
            Dim sresult As String
            Dim student_id As String
            Dim TotStud As Integer

            OpenConnection(Cn, Config.ConnectionString)

            sJob = GetIDFromKey(lvJobs.FocusedItem.Name).ToString
            If sJob = String.Empty Then
                MsgBox("Select a Job")
                Exit Sub
            End If

            sQuery = "select * from jobs where j_id = " & sJob
            RsJ.Open(sQuery, Cn, 1, 3, 0)

            sQuery = "select * from answers where a_j_id = " & sJob
            RsA.Open(sQuery, Cn, 3, 3)

            TotStud = 0
            While Not RsA.EOF
                student_id = RsA.Fields("A_ID").Value.ToString
                sQuery = "select * from _scansHist where jobid = '" & sJob & "-" & student_id & "'"
                Rs.Open(sQuery, Cn, 1, 3, 0)

                If Rs.RecordCount = 1 Then
                    TotStud += 1
                    'NV
                    If Not IsDBNull(RsJ.Fields("j_nv").Value) And RsJ.Fields("j_nv").Value > 0 Then
                        sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_nv").Value.ToString.Trim
                        RsC.Open(sQuery, Cn, 3, 3)
                        iOkTotal = 0
                        iTotal = 0
                        For iCounter1 = 1 To 3
                            slist = RsC.Fields("cl_" & iCounter1).Value
                            aList = Split(slist, "|")
                            sresult = String.Empty
                            iTot = 0
                            iOk = 0
                            For iCounter2 = 0 To UBound(aList)
                                bq = Split(aList(iCounter2), "-")(0)
                                ba = Split(aList(iCounter2), "-")(1)
                                bc = Rs.Fields("nvp" & iCounter1 & "_" & bq).Value.ToString.Trim
                                sresult &= bq & "-" & bc & "|"
                                iTot += 1
                                iTotal += 1
                                If ba.Trim = bc.Trim Then
                                    'contesto correctamente
                                    iOk += 1
                                    iOkTotal += 1
                                End If
                            Next iCounter2
                            RsA.Fields("a_n" & iCounter1.ToString.Trim).Value = sresult
                            RsA.Fields("a_n" & iCounter1.ToString & "_total").Value = iOk / iTot
                        Next iCounter1
                        RsA.Fields("a_newscan").Value = 1
                        RsA.Fields("a_nv_total").Value = iOkTotal / iTotal
                        RsA.Update()
                        RsC.Close()
                    End If
                    'LES
                    If Not IsDBNull(RsJ.Fields("j_les").Value) And RsJ.Fields("j_les").Value > 0 Then
                        sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_les").Value.ToString.Trim
                        RsC.Open(sQuery, Cn, 3, 3)
                        iOkTotal = 0
                        iTotal = 0
                        For iCounter1 = 1 To 20
                            If Not IsDBNull(RsC.Fields("cl_" & iCounter1.ToString.Trim).Value) And RsC.Fields("cl_" & iCounter1.ToString.Trim).Value <> String.Empty Then
                                slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value
                                aList = Split(slist, "|")
                                sresult = String.Empty
                                iTot = 0
                                iOk = 0
                                For iCounter2 = 0 To UBound(aList)
                                    bq = Split(aList(iCounter2), "-")(0)
                                    ba = Split(aList(iCounter2), "-")(1)
                                    bc = Rs.Fields("les_" & bq).Value.ToString.Trim
                                    sresult &= bq & "-" & bc & "|"
                                    iTot += 1
                                    iTotal += 1
                                    If ba.Trim = bc.Trim Then
                                        'contesto correctamente
                                        iOk += 1
                                        iOkTotal += 1
                                    End If
                                Next iCounter2
                                RsA.Fields("a_l" & iCounter1.ToString.Trim).Value = sresult
                                RsA.Fields("a_l" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                            End If
                        Next iCounter1
                        RsA.Fields("a_newscan").Value = 1
                        RsA.Fields("a_les_total").Value = iOkTotal / iTotal
                        RsA.Update()
                        RsC.Close()
                    End If

                    'MAT
                    If Not IsDBNull(RsJ.Fields("j_mat").Value) And RsJ.Fields("j_mat").Value > 0 Then
                        sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_mat").Value.ToString.Trim
                        RsC.Open(sQuery, Cn, 3, 3)
                        iTotal = 0
                        iOkTotal = 0
                        For iCounter1 = 1 To 20
                            If Not IsDBNull(RsC.Fields("cl_" & iCounter1.ToString.Trim).Value) And RsC.Fields("cl_" & iCounter1.ToString.Trim).Value <> String.Empty Then
                                slist = RsC.Fields("cl_" & iCounter1.ToString.Trim).Value
                                aList = Split(slist, "|")
                                sresult = String.Empty
                                iTot = 0
                                iOk = 0
                                For iCounter2 = 0 To UBound(aList)
                                    bq = Split(aList(iCounter2), "-")(0)
                                    ba = Split(aList(iCounter2), "-")(1)
                                    bc = Rs.Fields("mat_" & bq).Value.ToString.Trim
                                    sresult &= bq & "-" & bc & "|"
                                    iTot += 1
                                    iTotal += 1
                                    If ba.Trim = bc.Trim Then
                                        'contesto correctamente
                                        iOk += 1
                                        iOkTotal += 1
                                    End If
                                Next iCounter2
                                RsA.Fields("a_m" & iCounter1.ToString.Trim).Value = sresult
                                RsA.Fields("a_m" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                            End If
                        Next iCounter1
                        RsA.Fields("a_newscan").Value = 1
                        RsA.Fields("a_mat_total").Value = iOkTotal / iTotal
                        RsA.Update()
                        RsC.Close()
                    End If

                    'REN
                    If Not IsDBNull(RsJ.Fields("j_ren").Value) And RsJ.Fields("j_ren").Value > 0 Then
                        sQuery = "select * from Claves where cl_id = " & RsJ.Fields("j_ren").Value.ToString
                        RsC.Open(sQuery, Cn, 3, 3)
                        iTotal = 0
                        iOkTotal = 0
                        For iCounter1 = 1 To 20
                            If Not IsDBNull(RsC.Fields("cl_" & iCounter1.ToString.Trim).Value) And RsC.Fields("cl_" & iCounter1.ToString.Trim).Value <> String.Empty Then
                                slist = RsC.Fields("cl_" & iCounter1).Value
                                aList = Split(slist, "|")
                                sresult = String.Empty
                                iTot = 0
                                iOk = 0
                                For iCounter2 = 0 To UBound(aList)
                                    bq = Split(aList(iCounter2), "-")(0)
                                    ba = Split(aList(iCounter2), "-")(1)
                                    bc = Rs.Fields("ren_" & bq).Value.ToString.Trim
                                    sresult &= bq & "-" & bc & "|"
                                    iTot += 1
                                    iTotal += 1
                                    If ba.Trim = bc.Trim Then
                                        'contesto correctamente
                                        iOk += 1
                                        iOkTotal += 1
                                    End If
                                Next iCounter2
                                RsA.Fields("a_r" & iCounter1.ToString.Trim).Value = sresult
                                RsA.Fields("a_r" & iCounter1.ToString.Trim & "_total").Value = iOk / iTot
                            End If
                        Next iCounter1
                        RsA.Fields("a_newscan").Value = 1
                        RsA.Fields("a_ren_total").Value = iOkTotal / iTotal
                        RsA.Update()
                        RsC.Close()
                    End If

                End If
                Rs.Close()
                RsA.MoveNext()
            End While
            RsA.Close()

            RsJ.Fields("j_status").Value = 4
            RsJ.Update()
            RsJ.Close()
            Cn.Close()
            MsgBox("Proceso Completado. Total Estudiantes Re-procesados = " & TotStud)
        End Sub
#End Region
#Region "LEVEL FOUR ROUTINES"

        Sub MoveRecord(ByRef sID As String, ByRef sTable As String, Optional ByRef sTableTo As String = "")
            Dim sQuery As String
            Dim Cn2 As New ADODB.Connection
            Dim RsF As New ADODB.Recordset
            Dim RsT As New ADODB.Recordset

            Dim iCounter1 As Integer
            Dim aid As String
            Dim jid As String

            OpenConnection(Cn2, Config.ConnectionString)

            If sTable = "_scans_AID" Then
                jid = Split(sID, "-")(0)
                aid = Split(sID, "-")(1)
                sQuery = "select * from _scans_AID where jobid = '" & jid & "' AND aid_1_id = " & aid
            Else
                sQuery = "select * from " & sTable & "  where jobid = '" & sID & "'"
            End If
            RsF.Open(sQuery, Cn2, 3, 3)

            If sTableTo = String.Empty Then
                sTableTo = "_scansHist"
            End If

            'antes de copiar, que borre del hist cualquier duplicado de este record nuevo
            If sTable = "_scans_AID" Then
                sQuery = "delete from " & sTableTo & " where jobid = '" & jid & "' AND aid_1_id = " & aid
            Else
                sQuery = "delete from " & sTableTo & " where jobid = '" & sID & "'"
            End If
            Cn2.Execute(sQuery)
            
            'Ahora creo record nuevo en hist y lo copio
            'I think the new record is copied in history.
            sQuery = "select * from " & sTableTo & " where jobid = '0'"
            RsT.Open(sQuery, Cn2, 3, 3)
            Try
                RsT.AddNew()
                If Not RsF.EOF Then
                    For iCounter1 = 0 To RsF.Fields.Count - 1
                        RsT.Fields(RsF.Fields(iCounter1).Name).Value = RsF.Fields(iCounter1).Value
                    Next iCounter1
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            RsT.Update()
            RsF.Close()
            RsT.Close()
            'ahora borro del record en vivo
            If sTable = "_scans_AID" Then
                sQuery = "delete from " & sTable & " where jobid = '" & jid & "' AND aid_1_id = " & aid
            Else
                sQuery = "delete from " & sTable & " where jobid = '" & sID & "'"
            End If
            Cn2.Execute(sQuery)
            Cn2.Close()
        End Sub
#End Region


    End Class
End Namespace