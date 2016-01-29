Option Strict Off
Option Explicit On

Imports ADODB
Imports learnAid.BLL
Imports Microsoft.VisualBasic.Compatibility
Imports Microsoft.VisualBasic.Compatibility.VB6

Namespace Forms.MasterForms
    Friend Class frmNewJob
        Inherits System.Windows.Forms.Form
        Public sPluginName As String
        Private iJobID As Integer
        Private iSection As Short
        Private GroupCount As Short

#Region "LEVEL ONE ROUTINES"
        Private Sub frmNewJob_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
            iSection = 1
            Call ShowFrame(iSection)

            Call FillConsultantCBox(cboConsultant)
            Call FillConsultantCBox(cboConsultant2, True)
            Call FillConsultantCBox(cboConsultant3, True)
            Call FillConsultantCBox(cboExaminerOT, True)
            Call FillGradeCbox(cboGrade)
            Call FillSchoolCbox(cboSchools)
            Call FillNVCbox(cboNV)

            Call FillLESCbox(cboLes)
            Call FillMATCbox(cboMat)
            Call FillRENCbox(cboRen)

            Me.txtDate.Text = CStr(Today)
            'UPGRADE_WARNING: Lower bound of collection Me.OfficeList.ColumnHeaders has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            'UPGRADE_ISSUE: MSComctlLib.ColumnHeader property OfficeList.ColumnHeaders.Position was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'Me.OfficeList.Columns.Item(5).Position = OfficeList.Columns.Count
        End Sub
        Private Sub cboConsultant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboConsultant.SelectedIndexChanged
            Dim s As String
            s = "foo"
        End Sub
        Private Sub cboConsultant2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboConsultant2.SelectedIndexChanged
            Dim s As String
            s = "foo"
        End Sub
        Private Sub cboConsultant3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboConsultant3.SelectedIndexChanged
            Dim s As String
            s = "foo"
        End Sub

        'UPGRADE_WARNING: Event cboGrade.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub cboGrade_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboGrade.SelectedIndexChanged
            Call SetExam()
        End Sub
        Private Sub cboSchools_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles cboSchools.Validating
            Dim Cancel As Boolean = eventArgs.Cancel
            Me.txtPrice.Text = FormatCurrency(GetPrice(VB6.GetItemData(Me.cboSchools, Me.cboSchools.SelectedIndex)))
            eventArgs.Cancel = Cancel
        End Sub
        'UPGRADE_WARNING: Event chkAcomodo.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub chkAcomodo_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkAcomodo.CheckStateChanged
            If CBool(chkAcomodo.CheckState) Then
                chkPEP.CheckState = System.Windows.Forms.CheckState.Unchecked
            End If
        End Sub
        'UPGRADE_WARNING: Event chkPEP.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub chkPEP_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkPEP.CheckStateChanged
            If CBool(chkPEP.CheckState) Then
                chkAcomodo.CheckState = System.Windows.Forms.CheckState.Unchecked
                cboLes.Enabled = False
                cboRen.Enabled = False
                cboMat.Enabled = False
                cboNV.Enabled = False
            Else
                cboLes.Enabled = True
                cboRen.Enabled = True
                cboMat.Enabled = True
                cboNV.Enabled = True
            End If

            Call FillLESCbox(cboLes, , CBool(Me.chkPEP.CheckState))
            Call FillRENCbox(cboRen, , CBool(Me.chkPEP.CheckState))
            Call FillMATCbox(cboMat, , CBool(Me.chkPEP.CheckState))
            Call FillNVCbox(cboNV, , CBool(Me.chkPEP.CheckState))
        End Sub
        Private Sub cmdBack_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBack.Click
            If iSection > 1 Then
                If iSection = 5 And Me.optOffice.Checked = False Then iSection = iSection - 1
                iSection = iSection - 1
                Call ShowFrame(iSection)
            End If
        End Sub
        Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
            Me.Close()
        End Sub
        Private Sub cmdNext_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.Click
            Dim dPrice As Double
            Dim Grade As Integer
            Dim jt As Integer
            Dim sDate As String
            Dim Sem As Integer

            Dim Cons As Integer
            Dim Cons2 As Integer
            Dim Cons3 As Integer
            Dim l As Integer
            Dim m As Integer
            Dim n As Integer
            Dim R As Integer
            Dim Sch As Integer
            Dim Toll1 As Boolean
            Dim Toll2 As Boolean

            If Not ValidateSection(iSection) Then
                Exit Sub
            End If

            If iSection < 5 Then
                If iSection = 3 And Me.optOffice.Checked = False Then
                    iSection += 1
                End If
                iSection += 1
                Call ShowFrame(iSection)

            Else 'Presiono Finish

                If Me.optOffice.Checked = True Then
                    Call SaveJobOffice()
                Else
                    If Me.optOffice.Checked Then jt = 0
                    If Me.optEntrance.Checked Then jt = 1
                    If Me.optNormal.Checked Then
                        If CBool(chkAcomodo.CheckState) Then
                            jt = 3
                        Else
                            jt = 2
                        End If
                    End If
                    '**** Selected index will no longer pull the correct data in the new software. ****
                    '**** Mitchell Aikens ****
                    Dim RsCons As New Recordset
                    Dim Cn As New Connection
                    Dim schsplit As String()
                    Dim consplit As String()
                    Dim cons2split As String()
                    Dim cons3split As String()

                    Cn.Open(Config.ConnectionString)
                    RsCons.Open("SELECT CON_ID, CON_NAME, CON_LNAME1, CON_LNAME2 FROM CONSULTANTS ORDER BY CON_LNAME1 ASC", Cn)

                    schsplit = Split(cboSchools.Text, " - ")
                    Sch = Integer.Parse(schsplit(0))

                    Grade = cboGrade.SelectedIndex - 1

                    consplit = Split(cboConsultant.Text, " ")
                    'Cons = cboConsultant.SelectedText
                    Toll1 = Me.chkToll1.CheckState
                    cons2split = Split(cboConsultant2.Text, " ")
                    'Cons2 = cboConsultant2.SelectedText
                    Toll2 = Me.chkToll2.CheckState
                    cons3split = Split(cboConsultant3.Text, " ")
                    'Cons3 = cboConsultant3.SelectedText
                    While Not RsCons.EOF
                        Dim selectedname As String
                        Dim systemname As String
                        If consplit.Length = 2 Then
                            selectedname = consplit(0) + " " + consplit(1)
                            If RsCons.Fields("CON_LNAME2") IsNot DBNull.Value Then
                                systemname = RsCons.Fields("CON_NAME").Value.ToString.Trim & " " & RsCons.Fields("CON_LNAME1").Value.ToString.Trim & " " & RsCons.Fields("CON_LNAME2").Value.ToString.Trim
                            Else
                                systemname = RsCons.Fields("CON_NAME").Value.ToString.Trim + " " + RsCons.Fields("CON_LNAME1").Value.ToString.Trim
                            End If
                            If selectedname = systemname Then

                                Cons = RsCons.Fields("CON_ID").Value

                            End If
                        End If
                        If consplit.Length = 3 Then
                            selectedname = consplit(0) + " " + consplit(1) + " " + consplit(2)
                            If RsCons.Fields("CON_LNAME2") IsNot DBNull.Value Then
                                systemname = RsCons.Fields("CON_NAME").Value.ToString.Trim & " " & RsCons.Fields("CON_LNAME1").Value.ToString.Trim & " " & RsCons.Fields("CON_LNAME2").Value.ToString.Trim
                            Else
                                systemname = RsCons.Fields("CON_NAME").Value.ToString.Trim + " " + RsCons.Fields("CON_LNAME1").Value.ToString.Trim
                            End If
                            If selectedname = systemname Then

                                Cons = RsCons.Fields("CON_ID").Value

                            End If
                        End If
                If cons2split.Length = 2 Then
                    selectedname = cons2split(0) + " " + cons2split(1)
                            If RsCons.Fields("CON_LNAME2") IsNot DBNull.Value Then
                                systemname = RsCons.Fields("CON_NAME").Value.ToString.Trim & " " & RsCons.Fields("CON_LNAME1").Value.ToString.Trim & " " & RsCons.Fields("CON_LNAME2").Value.ToString.Trim
                            Else
                                systemname = RsCons.Fields("CON_NAME").Value.ToString.Trim + " " + RsCons.Fields("CON_LNAME1").Value.ToString.Trim
                            End If
                            If selectedname = systemname Then

                                Cons2 = RsCons.Fields("CON_ID").Value

                            End If
                        End If
                If cons2split.Length = 3 Then
                    selectedname = cons2split(0) + " " + cons2split(1) + " " + cons2split(2)
                            If RsCons.Fields("CON_LNAME2") IsNot DBNull.Value Then
                                systemname = RsCons.Fields("CON_NAME").Value.ToString.Trim & " " & RsCons.Fields("CON_LNAME1").Value.ToString.Trim & " " & RsCons.Fields("CON_LNAME2").Value.ToString.Trim
                            Else
                                systemname = RsCons.Fields("CON_NAME").Value.ToString.Trim + " " + RsCons.Fields("CON_LNAME1").Value.ToString.Trim
                            End If
                            If selectedname = systemname Then

                                Cons2 = RsCons.Fields("CON_ID").Value

                            End If
                        End If
                If cons3split.Length = 2 Then
                    selectedname = cons3split(0) + " " + cons3split(1)
                            If RsCons.Fields("CON_LNAME2") IsNot DBNull.Value Then
                                systemname = RsCons.Fields("CON_NAME").Value.ToString.Trim & " " & RsCons.Fields("CON_LNAME1").Value.ToString.Trim & " " & RsCons.Fields("CON_LNAME2").Value.ToString.Trim
                            Else
                                systemname = RsCons.Fields("CON_NAME").Value.ToString.Trim + " " + RsCons.Fields("CON_LNAME1").Value.ToString.Trim
                            End If
                            If selectedname = systemname Then

                                Cons3 = RsCons.Fields("CON_ID").Value

                            End If
                        End If
                If cons3split.Length = 3 Then
                    selectedname = cons3split(0) + " " + cons3split(1) + " " + cons3split(2)
                            If RsCons.Fields("CON_LNAME2") IsNot DBNull.Value Then
                                systemname = RsCons.Fields("CON_NAME").Value.ToString.Trim & " " & RsCons.Fields("CON_LNAME1").Value.ToString.Trim & " " & RsCons.Fields("CON_LNAME2").Value.ToString.Trim
                            Else
                                systemname = RsCons.Fields("CON_NAME").Value.ToString.Trim + " " + RsCons.Fields("CON_LNAME1").Value.ToString.Trim
                            End If
                            If selectedname = systemname Then

                                Cons3 = RsCons.Fields("CON_ID").Value

                            End If
                        End If
                RsCons.MoveNext()
                    End While
                    RsCons.Close()

                    If Cons = 3 Then
                    End If
                    dPrice = CDbl(Me.txtPrice.Text)
                    sDate = Me.txtDate.Text

                    Dim RsClav As New Recordset
                    RsClav.Open("SELECT CL_TYPE, CL_ID FROM Claves ORDER BY CL_ID ASC", Cn)

                    Dim selectedskill As String
                    Dim systemskill As String

                    While Not RsClav.EOF
                        selectedskill = cboLes.Text.Trim
                        systemskill = RsClav.Fields("CL_TYPE").Value.ToString.Trim
                        If selectedskill = systemskill Then
                            l = RsClav.Fields("CL_ID").Value
                        End If
                        selectedskill = cboRen.Text.Trim
                        systemskill = RsClav.Fields("CL_TYPE").Value.ToString.Trim
                        If selectedskill = systemskill Then
                            R = RsClav.Fields("CL_ID").Value
                        End If
                        selectedskill = cboNV.Text.Trim
                        systemskill = RsClav.Fields("CL_TYPE").Value.ToString.Trim
                        If selectedskill = systemskill Then
                            n = RsClav.Fields("CL_ID").Value
                        End If
                        selectedskill = cboMat.Text.Trim
                        systemskill = RsClav.Fields("CL_TYPE").Value.ToString.Trim
                        If selectedskill = systemskill Then
                            m = RsClav.Fields("CL_ID").Value
                        End If
                        RsClav.MoveNext()
                    End While


                    'l = cboLes.Text
                    'n = cboNV.Text
                    'R = cboRen.Text
                    'm = cboMat.Text
                    If Me.optFirstSemester.Checked Then
                        Sem = 1
                    Else
                        Sem = 2
                    End If

                    iJobID = SaveJob(jt, Sch, Grade, txtSection.Text, Sem, CShort(txtTotalStudents.Text), Cons, Toll1, Cons2,
                                     Toll2, Cons3, l, n, R, m, txtFile.Text, sPluginName, dPrice, sDate, CBool(chkAcomodo.CheckState),
                                     Me.chkPEP.CheckState)

                    If (Grade + Sem < 6 Or Me.chkPEP.CheckState = True) Then
                        Call GetNamesForJobAIDR(iJobID)
                    End If
                    If iJobID = 0 Then
                        MsgBox("The Job Already exists.", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                    End If
                    Call FillJobsView2()
                    Me.Close()
            End If
        End Sub
        'UPGRADE_WARNING: Event optEntrance.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub optEntrance_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optEntrance.CheckedChanged
            If eventSender.Checked Then
                Me.chkPEP.Enabled = False
                Me.chkPEP.CheckState = System.Windows.Forms.CheckState.Unchecked
                Me.chkAcomodo.Enabled = True
                'Me.chkAcomodo.Value = vbUnchecked
            End If
        End Sub
        'UPGRADE_WARNING: Event optFirstSemester.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub optFirstSemester_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optFirstSemester.CheckedChanged
            If eventSender.Checked Then
                Call SetExam()
            End If
        End Sub
        'UPGRADE_WARNING: Event optNormal.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub optNormal_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optNormal.CheckedChanged
            If eventSender.Checked Then
                Me.chkPEP.Enabled = True
                'Me.chkPEP.Value = vbUnchecked
                Me.chkAcomodo.Enabled = True
                'Me.chkAcomodo.Value = vbUnchecked
            End If
        End Sub
        'UPGRADE_WARNING: Event optOffice.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub optOffice_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optOffice.CheckedChanged
            If eventSender.Checked Then
                Me.chkPEP.Enabled = False
                Me.chkPEP.CheckState = System.Windows.Forms.CheckState.Unchecked
                Me.chkAcomodo.Enabled = False
                Me.chkAcomodo.CheckState = System.Windows.Forms.CheckState.Unchecked
            End If
        End Sub
        'UPGRADE_WARNING: Event optSecondSemester.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub optSecondSemester_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optSecondSemester.CheckedChanged
            If eventSender.Checked Then
                Call SetExam()
            End If
        End Sub
        Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Add.Click, Remove.Click, _Toolbar1_Button3.Click, btnMoveUp.Click, btnMoveDown.Click
            Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)

            Select Case Button.Name
                Case "Add"
                    frmAddOfficeStudent.pep = Me.chkPEP.CheckState
                    frmAddOfficeStudent.ShowDialog()
                Case "Remove"
                    If Not OfficeList.FocusedItem Is Nothing Then
                        Call OfficeList.Items.RemoveAt(OfficeList.FocusedItem.Index)
                    End If
                Case "btnMoveUp"
                    Call MoveUp()
                Case "btnMoveDown"
                    Call MoveDown()
            End Select
        End Sub
        Private Sub txtDate_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDate.Validating
            Dim Cancel As Boolean = eventArgs.Cancel
            Me.txtDate.Text = VB6.Format(Me.txtDate.Text, "mm/dd/yyyy")
            If Me.txtDate.Text <> String.Empty And Not IsDBNull(Me.txtDate.Text) Then
                If IsDate(Me.txtDate.Text) = False Then
                    MsgBox("Enter a valid date format")
                    Cancel = True
                Else
                    txtDate.Text = CStr(CDate(txtDate.Text))
                End If
            End If
            eventArgs.Cancel = Cancel
        End Sub
        Private Sub txtPrice_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtPrice.Validating
            Dim Cancel As Boolean = eventArgs.Cancel
            If IsNumeric(Me.txtPrice.Text) Then Me.txtPrice.Text = FormatCurrency(Me.txtPrice.Text)
            eventArgs.Cancel = Cancel
        End Sub
        Private Sub txtTotalStudents_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
            Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
            If (KeyAscii < System.Windows.Forms.Keys.D0 Or KeyAscii > System.Windows.Forms.Keys.D9) And KeyAscii <> System.Windows.Forms.Keys.Back And KeyAscii <> System.Windows.Forms.Keys.Delete Then
                KeyAscii = 0
            End If
            eventArgs.KeyChar = Chr(KeyAscii)
            If KeyAscii = 0 Then
                eventArgs.Handled = True
            End If
        End Sub

        'UPGRADE_ISSUE: VBControlExtender event UpDown1.DownClick was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
        Private Sub UpDown1_DownClick()
            If Val(Me.txtTotalStudents.Text) > 1 Then
                Me.txtTotalStudents.Text = CStr(Val(Me.txtTotalStudents.Text) - 1)
            End If
        End Sub
        'UPGRADE_ISSUE: VBControlExtender event UpDown1.UpClick was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
        Private Sub UpDown1_UpClick()
            Me.txtTotalStudents.Text = CStr(Val(Me.txtTotalStudents.Text) + 1)
        End Sub

#End Region
#Region "LEVEL TWO ROUTINES"
        Sub FillConsultantCBox(ByRef Cbox As ComboBox, Optional ByVal ConsultantType As enumConsultantType = enumConsultantType.ctExaminer)
            FillConsultantCBox(Cbox, False)
        End Sub
        Sub FillConsultantCBox(ByRef Cbox As ComboBox, ByVal loadFromStorage As Boolean, Optional ByVal ConsultantType As enumConsultantType = enumConsultantType.ctExaminer)
            Dim Cn As Connection
            Dim Rs As Recordset
            Dim n As String
            Dim l1 As String
            Dim l2 As String
            Dim Con_Type As String

            If ConsultantType = enumConsultantType.ctConsultant Then
                Con_Type = "C"
            Else
                Con_Type = "E"
            End If
            Cbox.Items.Clear()
            Cbox.Items.Add("")

            Cn = New Connection
            Rs = New Recordset

            OpenConnection(Cn, Config.ConnectionString)

            Rs.Open("Select CON_ID,CON_NAME,CON_LNAME1,CON_LNAME2 From CONSULTANTS Where CON_TYPE ='" & Con_Type & "' Order By CON_NAME ", Cn)

            While Not Rs.EOF
                n = GetValue(Rs.Fields("CON_NAME"))
                l1 = GetValue(Rs.Fields("Con_LName1"))
                l2 = GetValue(Rs.Fields("Con_LName2"))

                Cbox.Items.Add(Trim(Trim(n) & " " & Trim(l1) & " " & Trim(l2)))
                SetItemData(Cbox, Cbox.Items.Count - 1, Rs.Fields("CON_ID").Value)
                Rs.MoveNext()
            End While

            Rs.Close()
            Cn.Close()
            'Dim sql As String = "Select CON_ID,CON_NAME + ' ' + CON_LNAME1 + ' ' + CON_LNAME2 name From CONSULTANTS Where CON_TYPE ='" & Con_Type.Value & "' Order By CON_NAME "

            'Dim dt As DataTable
            'If loadFromStorage And Not GlobalResources.Consultants Is Nothing And GlobalResources.Consultants.Rows.Count() > 0 Then
            '    dt = GlobalResources.Consultants
            'Else
            '    dt = GlobalResources.ExecuteDataTable(sql, True)
            '    GlobalResources.Consultants = dt
            'End If

            'Dim i As Integer = 0
            'If (dt.Rows.Count > 0) Then
            '    'For i = 0 To dt.Rows.Count - 1
            '    '    Cbox.Items.Add(Trim(dt.Rows(i)("name").ToString()))
            '    '    SetItemData(Cbox, Cbox.Items.Count - 1, dt.Rows(i)("CON_ID").ToString())
            '    'Next
            '    Cbox.ValueMember = "CON_ID"
            '    Cbox.DisplayMember = "name"
            '    Cbox.DataSource = dt
            'End If
            Cbox.SelectedIndex = 0
        End Sub
        Sub SetExam()
            Dim iSemester As Short
            Dim sNV As String = Nothing
            Dim sLES As String = Nothing
            Dim sREN As String = Nothing
            Dim sMat As String = Nothing

            If Me.optFirstSemester.Checked Then
                iSemester = 1
            Else
                iSemester = 2
            End If

            If CBool(Me.chkPEP.CheckState) Then

                'Call SelectItemWithID(cboNV, 52)
                'Call SelectItemWithID(cboLes, 52)
                'Call SelectItemWithID(cboRen, 52)
                'Call SelectItemWithID(cboMat, 52)
                ComboboxUtilities.SetComboItemWithId(cboNV, 52)
                ComboboxUtilities.SetComboItemWithId(cboLes, 52)
                ComboboxUtilities.SetComboItemWithId(cboRen, 52)
                ComboboxUtilities.SetComboItemWithId(cboMat, 52)
                sPluginName = "PEPV"
            ElseIf cboGrade.Text <> "" Then
                Call GetDefaultsValues(cboGrade.SelectedIndex, iSemester, sLES, sREN, sMat, sNV, sPluginName)
                'Call SetValueToCBox(cboNV, sNV)
                'Call SetValueToCBox(cboLes, sLES)
                'Call SetValueToCBox(cboRen, sREN)
                'Call SetValueToCBox(cboMat, sMat)
                ComboboxUtilities.SetComboItemWithValue(cboNV, sNV)
                ComboboxUtilities.SetComboItemWithValue(cboLes, sLES)
                ComboboxUtilities.SetComboItemWithValue(cboRen, sREN)
                ComboboxUtilities.SetComboItemWithValue(cboMat, sMat)


            End If

        End Sub
        Sub MoveDown()
            Dim iCounter1 As Integer
            Dim iIndex As Short
            Dim Item As System.Windows.Forms.ListViewItem
            With OfficeList
                If Not .FocusedItem Is Nothing Then
                    iIndex = .FocusedItem.Index
                    If iIndex < .Items.Count Then
                        'UPGRADE_WARNING: Lower bound of collection OfficeList.ListItems.ImageList has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        'UPGRADE_WARNING: Lower bound of collection OfficeList.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        Item = .Items.Insert(iIndex + 2, .FocusedItem.Text, 0)
                        For iCounter1 = 1 To 8
                            'UPGRADE_WARNING: Lower bound of collection OfficeList.SelectedItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                            'UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                            Item.SubItems(iCounter1).Text = .FocusedItem.SubItems(iCounter1).Text
                            'UPGRADE_WARNING: Lower bound of collection OfficeList.SelectedItem.ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                            'UPGRADE_WARNING: Lower bound of collection Item.ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                            Item.SubItems.Item(iCounter1).Tag = .FocusedItem.SubItems.Item(iCounter1).Tag
                        Next
                        Item.Selected = True
                        .Items.RemoveAt(iIndex)
                    End If
                End If
            End With
        End Sub
        Sub MoveUp()
            Dim iCounter1 As Integer
            Dim iIndex As Integer
            Dim Item As System.Windows.Forms.ListViewItem
            With OfficeList
                If Not .FocusedItem Is Nothing Then
                    iIndex = .FocusedItem.Index
                    If iIndex > 1 Then
                        Item = .Items.Insert(iIndex - 1, .FocusedItem.Text, 0)
                        For iCounter1 = 1 To 8
                            Item.SubItems(iCounter1) = .FocusedItem.SubItems(iCounter1)
                            Item.SubItems.Item(iCounter1).Tag = .FocusedItem.SubItems(iCounter1).Tag
                        Next
                        Item.Selected = True
                        .Items.RemoveAt(iIndex = 1)
                    End If
                End If
            End With
        End Sub
        Sub ShowFrame(ByRef iFrame As Short)
            Select Case iFrame
                Case 1
                    cmdNext.Text = "&Next"
                    cmdCancel.Enabled = True
                    Call SetFrame(fraType)
                    lblDesc.Text = "Select the type of of job you want to process."
                Case 2
                    cmdNext.Text = "&Next"
                    cmdCancel.Enabled = True
                    Call SetFrame(fraStudentCount)
                    Me.txtTotalStudents.Focus()
                    'SendKeys ("{Home}+{End}")
                    lblDesc.Text = "It's necesary the number of students were tested and the date of the service."
                Case 3
                    Call SetExam()
                    If optNormal.Checked = True Then

                        cmdNext.Text = "&Next"
                        cmdCancel.Enabled = True
                        Call SetFrame(fraNormal)
                        lblDesc.Text = "Enter the job information."
                    ElseIf optOffice.Checked = True Then
                        cmdNext.Text = "&Next"
                        cmdCancel.Enabled = True
                        Call SetFrame(fraOffice)
                        lblDesc.Text = "Enter the students for the Office Testing."
                    ElseIf optEntrance.Checked = True Then
                        cmdNext.Text = "&Next"
                        cmdCancel.Enabled = True
                        Call SetFrame(fraNormal)
                        lblDesc.Text = "Enter the job information."
                    End If
                Case 4
                    cmdNext.Text = "&Next"
                    cmdCancel.Enabled = True
                    Call ReGroup()
                    Call SetFrame(fraReport)
                    lblDesc.Text = ""
                Case 5
                    cmdNext.Text = "&Finish"
                    Call SetFrame(fraFinish)
                    lblDesc.Text = "The process for create a new job was finished."
            End Select
        End Sub
#End Region
#Region "LEVEL THREE ROUTINES"

        Sub ReGroup()
            'Dim ItemKey As String
            'Dim ParentKey As String
            'Dim iIndex As Short
            Dim FoundGroup As Boolean
            Dim GroupKey As String = Nothing
            Dim iCounter1 As Integer
            Dim iGrade As Short
            Dim iSemester As Short
            Dim n As Object
            Dim Section As Short
            Dim tmp As Object

            GroupCount = 0
            tvGroups.Nodes.Clear()

            If OfficeList.Items.Count = 0 Then
                Exit Sub
            End If

            With OfficeList
                GroupCount = 0
                For iCounter1 = 0 To .Items.Count - 1
                    iGrade = Val(.Items.Item(iCounter1).SubItems.Item(2).Tag)
                    iSemester = Val(.Items.Item(iCounter1).SubItems.Item(3).Tag)

                    FoundGroup = GetGroup(iCounter1, GroupCount, GroupKey, Section)

                    If FoundGroup Then
                        'UPGRADE_WARNING: Add method behavior has changed Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DBD08912-7C17-401D-9BE9-BA85E7772B99"'
                        'UPGRADE_ISSUE: MSComctlLib.Node property tvGroups.Nodes.Add.Selected was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                        tvGroups.Nodes.Find(GroupKey, True)(0).Nodes.Add("C" & .Items.Item(iCounter1).Index, .Items.Item(iCounter1).Text)
                    Else
                        GroupCount += 1
                        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Lower bound of collection OfficeList.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        'UPGRADE_WARNING: Lower bound of collection OfficeList.ListItems() has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object tmp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        tmp = "[" & .Items.Item(iCounter1).SubItems(2).Text & " - " & Section & "] (Multiple Schools)"
                        'UPGRADE_WARNING: Couldn't resolve default property of object tmp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        n = tvGroups.Nodes.Add("G" & GroupCount, tmp)
                        'UPGRADE_WARNING: Couldn't resolve default property of object n.Tag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        n.Tag = Section
                        'UPGRADE_WARNING: Couldn't resolve default property of object n.Bold. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        n.NodeFont = New Font(tvGroups.Font, FontStyle.Bold)
                        'UPGRADE_WARNING: Lower bound of collection OfficeList.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        'UPGRADE_WARNING: Add method behavior has changed Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DBD08912-7C17-401D-9BE9-BA85E7772B99"'
                        'UPGRADE_ISSUE: MSComctlLib.Node property tvGroups.Nodes.Add.Selected was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                        tvGroups.Nodes.Find("G" & GroupCount, True)(0).Nodes.Add("C" & .Items.Item(iCounter1).Index, .Items.Item(iCounter1).Text) '.Selected = True
                    End If
                Next iCounter1
            End With
        End Sub

        Sub SetFrame(ByRef frame As System.Windows.Forms.GroupBox)
            Dim C As System.Windows.Forms.Control
            frame.Top = fraType.Top
            frame.Left = fraType.Left
            frame.Width = fraType.Width
            frame.Height = fraType.Height
            frame.Visible = True
            frame.Text = ""
            For Each C In Me.Controls
                If Microsoft.VisualBasic.Left(C.Name, 3) = "fra" And C.Name <> frame.Name Then
                    C.Visible = False
                End If
            Next C
        End Sub
#End Region

        Function GetGroup(ByVal ItemIndex As Short, ByVal GroupCount As Short, ByRef GroupKey As String, ByRef Section As Short) As Boolean
            Dim CII As Short
            Dim FoundGroup As Boolean
            Dim g As Integer
            Dim iCounter1 As Integer
            Dim iGrade As Short
            Dim iSemester As Short
            Dim ParentKey As String
            Dim Sections As New Collection
            Dim s As Integer

            With OfficeList
                GroupKey = ""
                Section = 0
                iGrade = Val(.Items.Item(ItemIndex).SubItems.Item(2).Tag)
                iSemester = Val(.Items.Item(ItemIndex).SubItems.Item(3).Tag)

                For iCounter1 = 1 To GroupCount
                    ParentKey = "G" & iCounter1.ToString.Trim
                    CII = GetIDFromKey(tvGroups.Nodes.Item(ParentKey).FirstNode.Name)
                    If iGrade + iSemester > 2 Then 'not AID
                        'If .ListItems(ItemIndex).ListSubItems(1).Tag = .ListItems(CII).ListSubItems(1).Tag And .ListItems(ItemIndex).ListSubItems(2).Tag = .ListItems(CII).ListSubItems(2).Tag Then
                        If .Items.Item(ItemIndex).SubItems.Item(2).Tag = .Items.Item(CII).SubItems.Item(2).Tag Then
                            Sections.Add(ParentKey)
                        End If
                    Else
                        g = Val(.Items.Item(CII).SubItems.Item(2).Tag)
                        s = Val(.Items.Item(CII).SubItems.Item(3).Tag)
                        If g + s <= 2 Then
                            Sections.Add(ParentKey)
                        End If
                    End If
                Next iCounter1

                If iGrade + iSemester > 2 Then 'not AID
                    For iCounter1 = 1 To Sections.Count()
                        ParentKey = Sections.Item(iCounter1)
                        CII = GetIDFromKey(tvGroups.Nodes.Item(ParentKey).FirstNode.Name)
                        If .Items.Item(ItemIndex).SubItems.Item(5).Tag = .Items.Item(CII).SubItems.Item(5).Tag And .Items.Item(ItemIndex).SubItems.Item(8).Tag = .Items.Item(CII).SubItems.Item(8).Tag And .Items.Item(ItemIndex).SubItems.Item(7).Tag = .Items.Item(CII).SubItems.Item(7).Tag And .Items.Item(ItemIndex).SubItems.Item(6).Tag = .Items.Item(CII).SubItems.Item(6).Tag Then
                            GroupKey = ParentKey
                            Section = iCounter1
                            FoundGroup = True
                            Exit For
                        End If
                    Next iCounter1
                Else
                    If Sections.Count() > 0 Then
                        GroupKey = Sections.Item(1)
                        Section = 1
                        FoundGroup = True
                    End If
                End If
                If Not FoundGroup Then
                    Section = Sections.Count() + 1
                End If
                GetGroup = FoundGroup
            End With
        End Function

        
        'Called By: cmdNext_Click()
        Sub SaveJobOffice()
            Dim Cons2 As Integer
            Dim Cons3 As Integer
            Dim iCounter1 As Integer
            Dim Sem As String
            Dim StdCount As Short

            Dim jt As Short = 0
            Dim sDate As String
            Dim Toll2 As Object
            Dim Toll1 As Object

            Dim Cons As Short
            Dim R As String
            Dim l As String
            Dim n As String
            Dim m As String
            Dim Grade As String
            Dim Sch As String
            Dim Sec As String

            Dim GroupKey As String
            Dim ListIndex As Short


            'Dim sREN, sLES, sMat, sNV As String
            Dim sPN As String
            Dim colJobID As New Collection

            For iCounter1 = 1 To GroupCount

                GroupKey = "G" & iCounter1.ToString.Trim
                Sec = tvGroups.Nodes(GroupKey).Tag
                StdCount = tvGroups.Nodes(GroupKey).GetNodeCount(False)
                ListIndex = GetIDFromKey(tvGroups.Nodes(GroupKey).FirstNode.Name)
                Sch = OfficeList.Items.Item(ListIndex).SubItems.Item(1).Text.Substring(0, OfficeList.Items.Item(ListIndex).SubItems.Item(1).Text.LastIndexOf(" -"))
                Grade = OfficeList.Items.Item(ListIndex).SubItems.Item(2).Tag - 1
                Sem = OfficeList.Items.Item(ListIndex).SubItems.Item(3).Tag
                '' Bat = OfficeList.ListItems(ListIndex).ListSubItems(4).Text



                m = OfficeList.Items.Item(ListIndex).SubItems.Item(5).Tag
                n = OfficeList.Items.Item(ListIndex).SubItems.Item(6).Tag
                l = OfficeList.Items.Item(ListIndex).SubItems.Item(7).Tag
                R = OfficeList.Items.Item(ListIndex).SubItems.Item(8).Tag
                '   Bat = getDefExam(CInt(Grade), CInt(Sem))
                '  Call GetDefaultsValues(Bat, Sem, sLES, sREN, sMat, sNV, sPN)
                'Call GetDefaultsValues(CInt(Grade), Sem, sLES, sREN, sMat, sNV, sPN)
                sPN = OfficeList.Items.Item(ListIndex).SubItems.Item(9).Tag
                If CBool(chkPEP.CheckState) Then
                    sPN = "PEPV"
                End If
                Cons = cboExaminerOT.SelectedIndex
                sDate = Me.txtDate.Text
                iJobID = SaveJob(jt, Sch, Grade, Sec, Sem, StdCount, Cons, Toll1, Cons2, Toll2, Cons3, l, n, R, m, txtFile.Text, sPN, 0, CStr(sDate), chkAcomodo.CheckState, Me.chkPEP.CheckState)
                Call CreateStudRecs(iCounter1, iJobID)
                If iJobID > 0 Then
                    colJobID.Add(iJobID)
                Else
                    MsgBox("The job already exists.")
                End If
                Cons2 = 0
                Cons3 = 0
                Toll1 = 0
                Toll2 = 0
                Sch = 0
            Next iCounter1
        End Sub


        Sub CreateStudRecs(ByVal Group As Short, ByVal JobID As Object)
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset
            Dim iCounter1 As Integer
            Dim li As Short
            Dim n As System.Windows.Forms.TreeNode = Nothing
            'Dim ParentKey As String


            OpenConnection(Cn, Config.ConnectionString)

            Rs.Open("Select * From Answers Where A_ID =-1", Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)

            For iCounter1 = 0 To tvGroups.Nodes.Count - 1
                'If Not (tvGroups.Nodes.Item(iCounter1).Parent Is Nothing) Then
                If tvGroups.Nodes(iCounter1).FirstNode.Name = "C" & (Group - 1).ToString.Trim Then
                    'If tvGroups.Nodes.Item(iCounter1).Parent.Name.ToString = "G" & Group Then
                    Dim names As New List(Of String)
                    For Each TreeNode In tvGroups.Nodes
                        If TreeNode.ToString.Contains("Multiple") Then
                            'do nothing
                        Else
                            names.Add(TreeNode.ToString)
                        End If
                    Next
                    Rs.AddNew()
                    Rs.Fields("A_J_ID").Value = JobID
                    'Rs.Fields("A_NOMBRE").Value = tvGroups.Nodes.Item(iCounter1 + 1).Text

                    Rs.Fields("A_NOMBRE").Value = names.Item(iCounter1).ToString.Trim
                    If Me.optOffice.Checked = True Then
                        'Rs.Fields("A_J_ID").Value = JobID
                        'Rs.Fields("A_NOMBRE").Value = OfficeList.Items.Item
                        li = (GetIDFromKey((tvGroups.Nodes.Item(iCounter1).Name)) - 1)
                        Rs.Fields("a_school").Value = OfficeList.Items.Item(li).SubItems.Item(0).Tag
                    End If
                    Rs.Update()
                End If
                'End If
            Next iCounter1
            Rs.Close()
            Cn.Close()
        End Sub


        Function SaveJob(ByVal JobType As Short, ByVal Sch_ID As Integer, ByVal Grade As Short, ByVal Section As String, ByVal Semester As Short, ByVal TotalEst As Short, ByVal ConsID As Integer, ByVal Toll1 As Short, ByVal ConsID2 As Integer, ByVal Toll2 As Short, ByVal ConsID3 As Integer, ByVal LES As Integer, ByVal NV As Integer, ByVal REN As Integer, ByVal MAT As Integer, ByVal FileCode As String, ByVal Plugin As String, ByRef dPrice As Double, ByRef sDate As String, ByVal AcomodoRazonable As Short, ByVal pep As Short, Optional ByRef Company As String = "") As Integer 'return de jobid
            Dim Cn As ADODB.Connection
            Dim Rs As ADODB.Recordset
            Cn = New ADODB.Connection
            Rs = New ADODB.Recordset

            SaveJob = 0

            OpenConnection(Cn, Config.ConnectionString)
            Cn.CursorLocation = CursorLocationEnum.adUseClient
            Rs.Open("SELECT * FROM Jobs WHERE J_ID =-1", Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
            If Rs.EOF Then
                Rs.AddNew()

                Rs.Fields("j_type").Value = JobType
                Rs.Fields("j_sch").Value = Sch_ID
                Rs.Fields("J_GRADE").Value = Grade
                Rs.Fields("J_SEC").Value = Section
                Rs.Fields("J_SEM").Value = Semester
                Rs.Fields("J_TOTAL_EST").Value = TotalEst
                Rs.Fields("J_CONS").Value = ConsID
                Rs.Fields("j_toll1").Value = Toll1
                Rs.Fields("J_CONS2").Value = ConsID2
                Rs.Fields("j_toll2").Value = Toll2
                Rs.Fields("J_CONS3").Value = ConsID3

                If LES = 51 Or REN = 51 Or MAT = 51 Or NV = 51 Then
                    Rs.Fields("j_AID").Value = 51
                ElseIf CBool(pep) Then
                    Rs.Fields("j_pepv").Value = 52 '52 = PEP CLAVE ID
                    AcomodoRazonable = 0
                Else
                    If LES > 0 Then Rs.Fields("J_LES").Value = LES
                    If NV > 0 Then Rs.Fields("J_NV").Value = NV
                    If REN > 0 Then Rs.Fields("J_REN").Value = REN
                    If MAT > 0 Then Rs.Fields("J_MAT").Value = MAT
                End If
                Rs.Fields("J_DATE").Value = Now
                Rs.Fields("J_ARCHIVO").Value = FileCode
                Rs.Fields("J_USER").Value = LoggedUser.UserID
                Rs.Fields("J_COMP_ID").Value = Config.COMP_ID
                Rs.Fields("J_Status").Value = 0
                Rs.Fields("J_Process_Status").Value = 2
                Rs.Fields("J_DESCRIPTION").Value = ""
                Rs.Fields("j_plugin").Value = Plugin
                Rs.Fields("J_price").Value = dPrice
                Rs.Fields("J_Serv_Date").Value = sDate
                Rs.Fields("J_AcomRazonable").Value = AcomodoRazonable
                Rs.Update()
                Return Rs.Fields("j_id").Value
            End If
            Rs.Close()
            Cn.Close()
        End Function

        'Called By: cmdNext_Click()
        Function ValidateSection(ByRef iSection As Short) As Boolean
            Dim B As Boolean = False
            Dim VC As New ValidateClass

            ValidateSection = False
            Select Case iSection
                Case 1 'Type
                    B = True
                Case 2 'Total Students
                    B = VC.ValidateControl((Me.txtTotalStudents))
                Case 3 'Normal/Entrance/Office
                    If Me.optOffice.Checked = False Then
                        B = VC.ValidateControl((Me.cboSchools))
                        If Not B Then Exit Function
                        B = B And VC.ValidateControl((Me.cboSchools))
                        If Not B Then Exit Function
                        B = B And VC.ValidateControl((Me.cboGrade))
                        If Not B Then Exit Function
                        B = B And VC.ValidateControl((Me.txtFile))
                        If Not B Then Exit Function
                        B = B And VC.ValidateControl((Me.txtSection))
                        If Not B Then Exit Function
                        B = B And VC.ValidateControl((Me.cboConsultant))
                        If B Then
                            If IsNumeric(txtPrice.Text) Then
                                B = True
                            Else
                                MsgBox("Invalid Price per student value.", MsgBoxStyle.Information)
                                B = False
                            End If
                        End If
                    Else
                        B = True
                    End If
                Case 4 'Report
                    B = True
                Case 5 'Finish
                    B = True
            End Select
            ValidateSection = B
        End Function

#Region "Unknown Routines"
        Function ValidData() As Boolean
            Dim cboExam As Object = Nothing
            ValidData = False

            If Trim(cboSchools.Text) = String.Empty Then
                MsgBox("Please choose one school.", MsgBoxStyle.Information)
                cboSchools.Focus()
                Exit Function
            End If

            If Trim(txtFile.Text) = String.Empty Then
                MsgBox("Please enter the file code.", MsgBoxStyle.Information)
                txtFile.Focus()
                Exit Function
            End If

            If Trim(cboGrade.Text) = String.Empty Then
                MsgBox("Please choose the grade.", MsgBoxStyle.Information)
                cboGrade.Focus()
                Exit Function
            End If

            If Trim(txtSection.Text) = String.Empty Then
                MsgBox("Please enter the section.", MsgBoxStyle.Information)
                txtSection.Focus()
                Exit Function
            End If

            If Val(txtSection.Text) <= 0 Then
                MsgBox("The section must be a number greater than 0.", MsgBoxStyle.Information)
                txtSection.Focus()
                Exit Function
            End If

            If Trim(cboExam.Text) = String.Empty Then
                MsgBox("Please choose the exam.", MsgBoxStyle.Information)
                cboExam.SetFocus()
                Exit Function
            End If

            If Trim(cboConsultant.Text) = String.Empty Then
                MsgBox("Please choose the consultant.", MsgBoxStyle.Information)
                cboConsultant.Focus()
                Exit Function
            End If

            If Val(txtTotalStudents.Text) <= 0 Then
                MsgBox("The total students must be a number greater than 0.", MsgBoxStyle.Information)
                txtTotalStudents.Focus()
                Exit Function
            End If

            ValidData = True

        End Function
#End Region




        

      

        

        

        







    End Class
End Namespace