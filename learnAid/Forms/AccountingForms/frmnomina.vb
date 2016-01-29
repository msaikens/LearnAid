Option Strict Off
Option Explicit On

Imports System.IO
Imports System.Security.Cryptography
Imports Microsoft.VisualBasic.Compatibility
Imports Microsoft.VisualBasic.PowerPacks
Imports NPOI.HSSF.UserModel

Namespace Forms.AccountingForms
    Friend Class frmnomina
        Inherits System.Windows.Forms.Form
        Public ParentID As Double

#Region "LEVEL ONE ROUTINES"
        Private Sub frmnomina_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
            Select Case Me.Tag
                Case "AUTO"
                    cmdProcess_Click(cmdProcess, New System.EventArgs())
                    Me.Tag = "NEW"
                    '    Case "NEW"
            End Select
        End Sub

        Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
            Dim dTotal As Double
            Dim iCounter1 As Integer
            Dim thisKey As String

            If Not Me.lvExaminers.FocusedItem Is Nothing Then
                thisKey = Split(Me.lvExaminers.FocusedItem.Name, "_")(1)

                Dim workbook = New HSSFWorkbook()
                Dim sheet = workbook.CreateSheet(thisKey)
                Dim row0 = sheet.CreateRow(0)
                row0.CreateCell(0).SetCellValue("School Name")
                row0.CreateCell(1).SetCellValue("Type Description")
                row0.CreateCell(2).SetCellValue("Amount")
                With objNomina.Examiner(thisKey)
                    For iCounter1 = 1 To .Activity.Count
                        Dim row = sheet.CreateRow(iCounter1)
                        row.CreateCell(0).SetCellValue(.Activity(iCounter1).SchoolName)

                        Dim strVal = .Activity(iCounter1).TypeDescription.ToString()
                        row.CreateCell(1).SetCellValue(strVal)
                        row.CreateCell(2).SetCellValue(FormatCurrency(.Activity(iCounter1).Amount, 2))

                        dTotal += CDbl(.Activity(iCounter1).Amount)
                    Next iCounter1
                End With
                Dim row1 = sheet.CreateRow(iCounter1 + 1)
                row1.CreateCell(0).SetCellValue("")
                row1.CreateCell(1).SetCellValue("Total: ")
                row1.CreateCell(2).SetCellValue(dTotal)

                sheet.AutoSizeColumn(0)
                sheet.AutoSizeColumn(1)
                sheet.AutoSizeColumn(2)
                Dim dest As String = "D:\Report.xls"
                saveFD.Filter = "Excel files (*.xls)|*.xls"
                If saveFD.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                    dest = saveFD.FileName
                End If

                Using fs As New FileStream(dest, FileMode.OpenOrCreate, FileAccess.Write)
                    workbook.Write(fs)
                End Using

                MessageBox.Show("Export Complete")
            End If
        End Sub
        Private Sub cmdAdjustments_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAdjustments.Click


            '==== Rewrite - Mitchell - ====


            'If Me.lvExaminers.FocusedItem IsNot Nothing Then
            '    frmAdjustment.Tag = "A"
            '    frmAdjustment.Show()

            'Else
            '    MsgBox("Please select an examiner from the list", MsgBoxStyle.Information)
            '    'Added Exit Sub here if no examiner selected -GWW
            '    Exit Sub
            'End If

            ''Commented out this line. -GWW
            ''If Not Me.lvActivity.SelectedItems Is Nothing Then
            ''Check the count. If 0, Drop down to Else -GWW
            'If Me.lvActivity.SelectedItems.Count > 0 Then
            '    '  MsgBox(Me.lvActivity.SelectedItems.ToString())
            '    '    MsgBox(Me.lvActivity.SelectedIndices.ToString())

            '    Dim userTaskDtlSrNo As String = lvActivity.SelectedItems(0).SubItems(1).Text.ToString()

            '    '  MsgBox(userTaskDtlSrNo)

            '    frmAdjustment.Tag = "A"
            '    frmAdjustment.Number = userTaskDtlSrNo
            '    frmAdjustment.ShowDialog()
            'Else
            '    'MsgBox("Please select A School from the list", MsgBoxStyle.Information)
            '    Exit Sub
            'End If


            '==== Rewrite Start ====

            If Me.lvExaminers.FocusedItem IsNot Nothing Then
                frmAdjustment.Tag = "A"
                frmAdjustment.Show()
            Else
                MessageBox.Show("Please select an examiner", "Selection error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub
        Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
            Dim SelErr As MsgBoxResult
            Dim MBResult As MsgBoxResult
            On Error GoTo cmdClose_Err
            If Me.cmdCompleted.Enabled = True Then
                MBResult = MsgBox("Save before Exit?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, "Save & Exit")
                Select Case MBResult
                    Case MsgBoxResult.Yes
                        SaveData()
                        ParentID = 0
                        frmAccountingView.Fill()
                        Me.Close()
                    Case MsgBoxResult.No
                        ParentID = 0
                        frmAccountingView.Fill()
                        Me.Close()
                End Select
            Else
                ParentID = 0
                frmAccountingView.Fill()
                Me.Close()
            End If
            Exit Sub
cmdClose_Err:
            SelErr = MsgBox("Unexpected error." & vbCrLf & "Error Number:" & Err.Number & vbCrLf & "Description:" & Err.Description, MsgBoxStyle.AbortRetryIgnore, "Closing Accounting")
            Select Case SelErr
                Case MsgBoxResult.Abort
                    End
                Case MsgBoxResult.Ignore
                    Resume Next
                Case MsgBoxResult.Retry
                    Resume
            End Select
        End Sub
        Private Sub cmdCompleted_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCompleted.Click
            Dim Cn As New ADODB.Connection
            If MsgBox("Set Completed. Are you sure?", MsgBoxStyle.YesNo, "Set Completed") = MsgBoxResult.Yes Then
                Me.cmdCompleted.Enabled = False
                Me.cmdSave.Enabled = True
                Me.cmdAdjustments.Enabled = True
                Me.cmdProcess.Enabled = True

                SaveData()

                'OpenConnection(Cn, Config.ConnectionString)
                OpenConnection(Cn, Config.ConnectionStringAdo)

                Cn.Execute("Update Nomina_General Set NG_Status = 'C' Where  NG_Status = 'P'")
                Cn.Execute("Update Nomina_Template Set NT_Status = 'C' Where  NT_Status = 'P'")
                objNomina.Examiner.Clear()
            End If
        End Sub
        Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
            frmPrintNomina.dNominaID = LA_Declarations.GetIDFromKey(frmAccountingView.lvAccounting.FocusedItem.Name)
            frmPrintNomina.ShowDialog()
        End Sub

        Private Sub cmdProcess_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdProcess.Click
            Dim iCounter1 As Integer
            Dim iParentID As Integer
            Dim xstart As Date
            Dim xend As Date

            'UPGRADE_NOTE: LVITEM was upgraded to LVITEM_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            Dim LVITEM_Renamed As System.Windows.Forms.ListViewItem
            xstart = Now()
            Debug.Print("start:" & xstart)
            Me.lvExaminers.Items.Clear()
            Me.lvActivity.Items.Clear()
            Me.cmdClose.Enabled = True
            objNomina.Examiner.Clear()
            'Me.cmdAdjustments.Enabled = True
            Me.lblTotalData.Text = ""
            Me.lblTotalData.Refresh()

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            ' -- Create Template Table

            iParentID = CInt(Mid(frmAccountingView.lvAccounting.FocusedItem.Name, 2))
            If Me.Tag <> "NEW" Then
                '        If iParentID > 0 Then
                '-- Fill Object
                Call GetTemplateDataintoForm(iParentID)
            Else
                'frmnominaprocess.ShowDialog()
                Call GetTemplateDataintoForm(iParentID)
            End If

            '-- Fill Examiner ListView
            With objNomina.Examiner
                If .Count > 0 Then
                    For iCounter1 = 1 To .Count
                        LVITEM_Renamed = Me.lvExaminers.Items.Add("e_" & CStr(.Item(iCounter1).ExaminerID), .Item(iCounter1).FName & " " & .Item(iCounter1).LName1 & " " & .Item(iCounter1).LName2, "")
                        System.Windows.Forms.Application.DoEvents()
                    Next iCounter1
                End If
            End With
            If Me.lvExaminers.Items.Count > 0 Then
                Me.lvExaminers.Items.Item(0).Font = VB6.FontChangeBold(Me.lvExaminers.Items.Item(1).Font, True)
                lvExaminers_Click(lvExaminers, New System.EventArgs())
            End If

            Me.Cursor = Cursors.Default

            Me.cmdClose.Enabled = True
            xend = Now()
            Debug.Print("end:" & xend)
        End Sub
        Private Sub cmdSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.Click
            Dim SelErr As MsgBoxResult
            On Error GoTo cmdSave_Err
            Call SaveData()
            frmAccountingView.Fill()
            Exit Sub
cmdSave_Err:
            SelErr = MsgBox("Unexpected error." & vbCrLf & "Error Number:" & Err.Number & vbCrLf & "Description:" & Err.Description, MsgBoxStyle.AbortRetryIgnore, "Saving Data")
            Select Case SelErr
                Case MsgBoxResult.Abort
                    End
                Case MsgBoxResult.Ignore
                    Resume Next
                Case MsgBoxResult.Retry
                    Resume
            End Select
        End Sub
        Private Sub lvActivity_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvActivity.DoubleClick
            If Not Me.lvActivity.FocusedItem Is Nothing Then
                'Load(frmAdjustment)
                frmAdjustment.Tag = "E"
                frmAdjustment.ShowDialog()
            End If
        End Sub
        Private Sub lvActivity_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles lvActivity.KeyDown
            Dim KeyCode As Short = eventArgs.KeyCode
            Dim Shift As Short = eventArgs.KeyData \ &H10000
            Dim iActivityKey As String
            Dim iexaminerkey As String
            Dim vRet As MsgBoxResult
            ' -- If the adjustments button is enabled means that this
            ' -- batch is still pending
            If Me.cmdAdjustments.Enabled = True Then
                If KeyCode = 46 Then ' DELETE
                    vRet = MsgBox("Delete this item?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
                    If vRet = MsgBoxResult.Yes Then
                        ' -- Delete selected item
                        iexaminerkey = Split(Me.lvActivity.FocusedItem.Name, "_")(1)
                        iActivityKey = "a_" & Split(Me.lvActivity.FocusedItem.Name, "_")(2)
                        objNomina.Examiner(iexaminerkey).Activity.Remove(iActivityKey)
                        'Commented out line below, fix is next two lines -GWW
                        'Me.lvActivity.Items.RemoveAt((Me.lvActivity.FocusedItem.Name))
                        Dim tmpIndex As Integer = Me.lvActivity.FocusedItem.Index
                        Me.lvActivity.Items.RemoveAt(tmpIndex)
                    End If
                End If
            End If
        End Sub
        Private Sub lvExaminers_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvExaminers.SelectedIndexChanged
            Dim dTotal As Double = 0
            Dim iCounter1 As Integer
            Dim ThisKey As String
            Dim LVITEM_Renamed As System.Windows.Forms.ListViewItem

            If Not Me.lvExaminers.FocusedItem Is Nothing Then
                ThisKey = Split(Me.lvExaminers.FocusedItem.Name, "_")(1)

                Me.lvActivity.Items.Clear()
                With objNomina.Examiner(ThisKey)
                    For iCounter1 = 1 To .Activity.Count
                        LVITEM_Renamed = Me.lvActivity.Items.Add("a_" & ThisKey & "_" & .Activity(iCounter1).NTId, CStr(.Activity(iCounter1).ServiceDate), "")
                        If LVITEM_Renamed.SubItems.Count > 1 Then
                            LVITEM_Renamed.SubItems(1).Text = .Activity(iCounter1).SchoolName
                        Else
                            LVITEM_Renamed.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, .Activity(iCounter1).SchoolName))
                        End If
                        If LVITEM_Renamed.SubItems.Count > 2 Then
                            LVITEM_Renamed.SubItems(2).Text = .Activity(iCounter1).TypeDescription
                        Else
                            LVITEM_Renamed.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, .Activity(iCounter1).TypeDescription))
                        End If
                        If LVITEM_Renamed.SubItems.Count > 3 Then
                            LVITEM_Renamed.SubItems(3).Text = FormatCurrency(.Activity(iCounter1).Amount, 2)
                        Else
                            LVITEM_Renamed.SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, FormatCurrency(.Activity(iCounter1).Amount, 2)))
                        End If
                        dTotal += CDbl(LVITEM_Renamed.SubItems(3).Text)
                    Next iCounter1
                End With
            End If
            Me.lblTotalData.Text = FormatCurrency(dTotal, 2)
            Me.lblTotalData.Refresh()
        End Sub
        'UPGRADE_ISSUE: MSComctlLib.ListView event lvExaminers.ItemClick was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
        Private Sub lvExaminers_ItemClick(ByVal Item As System.Windows.Forms.ListViewItem)
            Dim iCounter1 As Integer
            For iCounter1 = 1 To Me.lvExaminers.Items.Count

                Me.lvExaminers.Items.Item(iCounter1).Font = VB6.FontChangeBold(Me.lvExaminers.Items.Item(iCounter1).Font, False)
            Next iCounter1
            Me.lvExaminers.FocusedItem.Font = VB6.FontChangeBold(Me.lvExaminers.FocusedItem.Font, True)
            lvExaminers_Click(lvExaminers, New System.EventArgs())
        End Sub
        Private Sub txtFrom_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
            Dim Cancel As Boolean = eventArgs.Cancel
            'Me.txtFrom.Text = VB6.Format(Me.txtFrom.Text, "MM/dd/yyyy")
            Me.txtFrom.Text = FormatDateTime(Me.txtFrom.Text, "MM/dd/yyyy")
            If Me.txtFrom.Text <> "" And Not IsDBNull(Me.txtFrom.Text) Then

                If IsDate(Me.txtFrom.Text) = False Then
                    MsgBox("Enter a valid date format")
                    Cancel = True
                Else
                    txtFrom.Text = CStr(CDate(txtFrom.Text))
                End If
            End If
            eventArgs.Cancel = Cancel
        End Sub
        Private Sub txtTo_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
            Dim Cancel As Boolean = eventArgs.Cancel
            Me.txtTo.Text = FormatDateTime(Me.txtTo.Text, "mm/dd/yyyy")
            If Me.txtTo.Text <> String.Empty And Not IsDBNull(Me.txtTo.Text) Then
                If IsDate(Me.txtTo.Text) = False Then
                    MsgBox("Enter a valid date format")
                    Cancel = True
                Else
                    txtTo.Text = CDate(txtTo.Text).ToString
                End If
            End If
            eventArgs.Cancel = Cancel
        End Sub
#End Region
#Region "LEVEL TWO ROUTINES"
        Sub GetTemplateDataintoForm(ByVal ParentID As Integer)
            Dim sQuery As String
            Dim Cn As ADODB.Connection
            Dim Rs As ADODB.Recordset
            Cn = New ADODB.Connection
            Rs = New ADODB.Recordset


            Dim iConsultantsCount As Short
            Dim iCounter1 As Integer
            Dim ConID As String
            Dim ConKey As String
            Dim ConLName1 As String
            Dim ConLName2 As String
            Dim ConName As String
            Dim vConsultants As String = String.Empty
            Dim vConsultantsArray() As String

            'OpenConnection(Cn, Config.ConnectionString)
            OpenConnection(Cn, Config.ConnectionStringAdo)

            If ParentID > 0 Then
                ' -- Get unique consultants from generated template
                'Rs.Open "SELECT Nomina_Template.nt_cons_id, CONSULTANTS.CON_ID, " & _
                '"CONSULTANTS.CON_NAME, CONSULTANTS.CON_LNAME1, CONSULTANTS.CON_LNAME2 " & _
                '"FROM Nomina_Template INNER JOIN CONSULTANTS ON " & _
                '"Nomina_Template.nt_cons_id = CONSULTANTS.CON_ID " & _
                '"WHERE Nomina_Template.nt_parentid = " & ParentID & " " & _
                '"GROUP BY Nomina_Template.nt_cons_id, CONSULTANTS.CON_ID, " & _
                '"CONSULTANTS.CON_NAME, CONSULTANTS.CON_LNAME1, " & _
                '"CONSULTANTS.CON_LNAME2 order by consultants.con_name,consultants.con_lname1,consultants.con_lname2", Cn, adOpenKeyset, adLockPessimistic
                'UPGRADE_WARNING: Couldn't resolve default property of object sQuery. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sQuery = "Select * from Consultants where con_type = 'E' order by con_name, con_lname1"
                Rs.Open(sQuery, Cn, 3, 3)
            Else
                Rs.Open("SELECT Nomina_Template.nt_cons_id, CONSULTANTS.CON_ID, " & "CONSULTANTS.CON_NAME, CONSULTANTS.CON_LNAME1, CONSULTANTS.CON_LNAME2 " &
                        "FROM Nomina_Template INNER JOIN CONSULTANTS ON " & "Nomina_Template.nt_cons_id = CONSULTANTS.CON_ID " &
                        "Where Nomina_Template.nt_status = 'P' " & "GROUP BY Nomina_Template.nt_cons_id, CONSULTANTS.CON_ID, " &
                        "CONSULTANTS.CON_NAME, CONSULTANTS.CON_LNAME1, " &
                        "CONSULTANTS.CON_LNAME2 order by consultants.con_name,consultants.con_lname1,consultants.con_lname2", Cn,
                        ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)

            End If
            ' -- Get ID for each consultant
            While Not Rs.EOF
                'vConsultants = vConsultants & Rs!nt_cons_id & "," & Rs!CON_NAME & "," & Rs!Con_LName1 & "," & Rs!Con_LName2 & "|"

                vConsultants &= Rs.Fields("CON_ID").Value & "," & Rs.Fields("CON_NAME").Value & "," & Rs.Fields("Con_LName1").Value & "," & Rs.Fields("Con_LName2").Value & "|"
                Rs.MoveNext()
            End While

            ' -- Get total of consultants for this period
            iConsultantsCount = Rs.RecordCount

            ' -- Strip last PIPE if exists
            If Microsoft.VisualBasic.Right(vConsultants, 1) = "|" Then vConsultants = Microsoft.VisualBasic.Left(vConsultants, Len(vConsultants) - 1)

            ' -- Convert String to Array
            vConsultantsArray = Split(vConsultants, "|")

            ' -- Fill Object with consultant data
            For iCounter1 = 0 To UBound(vConsultantsArray)
                ConID = Split(vConsultantsArray(iCounter1), ",")(0)
                ConKey = ConID
                ConName = Split(vConsultantsArray(iCounter1), ",")(1)
                ConLName1 = Split(vConsultantsArray(iCounter1), ",")(2)
                ConLName2 = Split(vConsultantsArray(iCounter1), ",")(3)
                ' -- Add Parent Examiner Record
                objNomina.Examiner.Add(ConID, ConName, ConLName1, ConLName2, , ConKey)

                ' -- Add Activity records to this examiner
                FillConsultantActivity(ConID, ParentID)
                System.Windows.Forms.Application.DoEvents()
            Next iCounter1

            Rs.Close()
            Cn.Close()
        End Sub
        Sub SaveData()
            Dim sQuery As String
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset
            Dim RsParent As New ADODB.Recordset
            Dim RsTmp As New ADODB.Recordset


            Dim delTotal As Integer
            Dim iCounter1 As Integer
            Dim iCounter2 As Integer
            Dim SelErr As MsgBoxResult
            Dim TotalAmount As Double

            On Error GoTo cmdSave_Err

            'OpenConnection(Cn, Config.ConnectionString)
            OpenConnection(Cn, Config.ConnectionStringAdo)

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

            With objNomina
                'Open "NominaLog.txt" For Output As #1

                '//calculo el total de la nomina
                'Print #1, "A"
                For iCounter1 = 1 To .Examiner.Count
                    For iCounter2 = 1 To .Examiner(iCounter1).Activity.Count
                        'Print #1, "A " & iExaminer & " - " & iActivity
                        If Not IsDBNull(.Examiner(iCounter1).Activity(iCounter2).Amount) Then
                            TotalAmount += .Examiner(iCounter1).Activity(iCounter2).Amount
                        Else
                            Stop
                        End If
                    Next iCounter2
                Next iCounter1

                'Print #1, "B"
                Cn.Execute("UPDATE Nomina_Template SET NT_STATUS = 'D' WHERE NT_STATUS ='P'")
                'Cn.Execute "DELETE FROM Nomina_Template Where NT_STATUS = 'P'"

                '//Creo el parent
                'Print #1, "C"
                RsParent.Open("Select * From Nomina_General Where NG_STATUS='P'", Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
                If RsParent.RecordCount = 1 Then
                    RsParent.Fields("NG_From").Value = Me.txtFrom.Text
                    RsParent.Fields("NG_To").Value = Me.txtTo.Text
                    RsParent.Fields("NG_TotalExaminer").Value = .Examiner.Count
                    RsParent.Fields("NG_TotalPaid").Value = TotalAmount
                    RsParent.Fields("NG_Status").Value = "P"
                    RsParent.Update()
                Else
                    RsParent.AddNew()
                    RsParent.Fields("NG_From").Value = Me.txtFrom.Text
                    RsParent.Fields("NG_To").Value = Me.txtTo.Text
                    RsParent.Fields("NG_TotalExaminer").Value = .Examiner.Count
                    RsParent.Fields("NG_TotalPaid").Value = TotalAmount
                    RsParent.Fields("NG_Status").Value = "P"
                    RsParent.Update()
                End If
                ParentID = RsParent.Fields("NG_ID").Value
                RsParent.Close()


                '//creo los hijos
                'Print #1, "D"
                Rs.Open("Select * From Nomina_Template Where NT_ID =-1", Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
                For iCounter1 = 1 To .Examiner.Count
                    For iCounter2 = 1 To .Examiner(iCounter1).Activity.Count
                        'Print #1, "D " & iExaminer & " - " & iActivity
                        Rs.AddNew()
                        Rs.Fields("nt_cons_id").Value = .Examiner(iCounter1).ExaminerID
                        Rs.Fields("nt_parentid").Value = ParentID
                        Rs.Fields("nt_serv_date").Value = .Examiner(iCounter1).Activity(iCounter2).ServiceDate
                        Rs.Fields("nt_sch_name").Value = .Examiner(iCounter1).Activity(iCounter2).SchoolName
                        Rs.Fields("nt_sch_city").Value = .Examiner(iCounter1).Activity(iCounter2).SchoolCity
                        Rs.Fields("nt_amount").Value = .Examiner(iCounter1).Activity(iCounter2).Amount
                        'UPGRADE_WARNING: Couldn't resolve default property of object objNomina.Examiner().Activity().ServiceComments. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        Rs.Fields("nt_desc").Value = .Examiner(iCounter1).Activity(iCounter2).ServiceComments
                        Rs.Fields("NT_STATUS").Value = "P"
                        Rs.Fields("nt_type").Value = .Examiner(iCounter1).Activity(iCounter2).ServiceType
                        Rs.Fields("nt_ajuste").Value = .Examiner(iCounter1).Activity(iCounter2).Adj
                        Rs.Update()
                    Next iCounter2
                Next iCounter1
                Rs.Close()

                '//borro los status D viejos de otras nominas
                If ParentID > 0 Then
                    sQuery = "SELECT TOP 1000 * FROM Nomina_Template Where NT_STATUS = 'D' AND NT_PARENTID <> " & ParentID
                    RsTmp.Open(sQuery, Cn, 3, 3)
                    delTotal = RsTmp.RecordCount

                    For iCounter1 = 1 To delTotal
                        RsTmp.Delete()
                        System.Windows.Forms.Application.DoEvents()
                        If iCounter1 < delTotal Then
                            RsTmp.MoveNext()
                        End If
                    Next iCounter1

                    RsTmp.Close()
                End If

                '//borro los status D viejos de la misma nomina pero de 3 dias viejos
                If ParentID > 0 Then
                    sQuery = "SELECT TOP 300 * FROM Nomina_Template Where NT_STATUS = 'D' AND NT_PARENTID = " & ParentID & " AND TIMESTAMP <= '" & DateAdd(Microsoft.VisualBasic.DateInterval.Day, -3, Now) & "'"
                    RsTmp.Open(sQuery, Cn, 3, 3)
                    delTotal = RsTmp.RecordCount
                    For iCounter1 = 1 To delTotal
                        RsTmp.Delete()
                        System.Windows.Forms.Application.DoEvents()
                        If iCounter1 < delTotal Then
                            RsTmp.MoveNext()
                        End If
                    Next iCounter1
                    RsTmp.Close()
                    RsTmp = Nothing
                End If
                Cn.Close()
                'Close #1
            End With
            Me.Cursor = Cursors.Default
            Exit Sub
cmdSave_Err:
            Me.Cursor = Cursors.Default
            SelErr = MsgBox("Unexpected error." & vbCrLf & "Error Number:" & Err.Number & vbCrLf & "Description:" & Err.Description, MsgBoxStyle.AbortRetryIgnore, "Saving Data")
            Select Case SelErr
                Case MsgBoxResult.Abort
                    End
                Case MsgBoxResult.Ignore
                    Resume Next
                Case MsgBoxResult.Retry
                    Resume
            End Select
        End Sub
#End Region
#Region "LEVEL THREE ROUTINES"
        Sub FillConsultantActivity(ByVal ConID As String, ByVal ParentID As Integer)
            Dim sQuery As String
            Dim Cn As ADODB.Connection
            Dim Rs As ADODB.Recordset
            Cn = New ADODB.Connection
            Rs = New ADODB.Recordset


            'UPGRADE_NOTE: Name was upgraded to Name_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
            'Dim ID As Object
            'Dim LName1 As String
            'Dim LName2 As String
            'Dim Name_Renamed As String


            Dim Action As String = String.Empty
            Dim Amount As String = "0"
            Dim Comments As String = String.Empty

            Dim SchCity As String = String.Empty
            Dim SchName As String = String.Empty
            Dim ServDate As String = String.Empty
            Dim ServType As String = String.Empty
            Dim TypeCost As String = "0"
            Dim TypeDesc As String = String.Empty
            Dim TypeID As Object
            Dim NTId As Object
            Dim Adj As Boolean


            'OpenConnection(Cn, Config.ConnectionString)
            OpenConnection(Cn, Config.ConnectionStringAdo)

            ' -- Get unique consultants from generated template
            sQuery = "SELECT Nomina_Template.nt_id,Nomina_Template.nt_cons_id, Nomina_Template.nt_serv_date, " &
                     "Nomina_Template.nt_sch_name, Nomina_Template.nt_sch_city, " &
                     "Nomina_Template.nt_type, Nomina_Template.nt_amount, " &
                     "Nomina_Template.nt_desc, Nomina_Template.nt_ajuste, nomina_types.ty_id,nomina_types.ty_cost, nomina_types.ty_desc " &
                     "FROM Nomina_Template INNER JOIN nomina_types ON " & "Nomina_Template.nt_type = nomina_types.ty_id WHERE " &
                     "dbo.Nomina_Template.nt_cons_id = " & ConID & " AND dbo.Nomina_Template.nt_parentid = " & ParentID.ToString &
                     " AND nt_status <> 'D' order by Nomina_Template.nt_serv_date,Nomina_Template.nt_sch_name,nomina_template.nt_type"

            Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)

            With objNomina.Examiner(ConID).Activity
                While Not Rs.EOF
                    NTId = Rs.Fields("NT_ID").Value
                    ServDate = Rs.Fields("nt_serv_date").Value
                    SchName = GetValue(Rs.Fields("nt_sch_name"), "Multiple Schools")
                    SchCity = GetValue(Rs.Fields("nt_sch_city"), "")
                    ServType = Rs.Fields("nt_type").Value
                    Amount = Rs.Fields("nt_amount").Value
                    Comments = GetValue(Rs.Fields("nt_desc"), String.Empty)
                    TypeCost = Rs.Fields("ty_cost").Value
                    TypeDesc = Rs.Fields("ty_desc").Value
                    TypeID = Rs.Fields("ty_id").Value
                    Action = String.Empty
                    Adj = Rs.Fields("nt_ajuste").Value
                    .Add(NTId, ServDate, SchName, SchCity, ServType, Amount, Comments, TypeDesc, TypeCost, CStr(Action), CShort(TypeID), "a_" & NTId, Adj)
                    Rs.MoveNext()
                End While
            End With
            Rs.Close()
            Cn.Close()
        End Sub
#End Region
#Region "Unknown Routines"
        Private Sub cmdCalFrom_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
            'ShowCalendar((Me.txtFrom), Me.txtFrom.Text)
        End Sub
        Private Sub cmdCalTo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
            If Me.txtTo.Text <> "" Then
                'ShowCalendar((Me.txtTo), Me.txtTo.Text)
            Else
                'ShowCalendar((Me.txtTo), Me.txtFrom.Text)
            End If
        End Sub

        Sub ShowCalendar(ByRef TextField As System.Windows.Forms.TextBox, Optional ByVal StartupDate As Object = Nothing)
            'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
            If Not IsNothing(StartupDate) Then
                Dim frm = New frmGenericCal
                frm.Show()
                frmGenericCal.Calendar1.Value = StartupDate
            End If
            frmGenericCal.ShowDialog()
            TextField.Text = CalendarValue
        End Sub

#End Region

    End Class
End Namespace