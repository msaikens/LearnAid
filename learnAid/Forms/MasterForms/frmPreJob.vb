Option Strict Off
Option Explicit On
Imports sysd = System.Data
Imports learnAid.BLL
Imports learnAid.Forms.ReportForms
Imports Microsoft.VisualBasic.Compatibility
Imports Microsoft.Office.Interop.Excel

Namespace Forms.MasterForms

    Friend Class frmPreJob
        Inherits System.Windows.Forms.Form
        Public iPreJobID As Integer
        Public iSchoolID As Integer
        Public sPluginName As String
        'Dim cFlatCtrls As New FCtrls
        Dim Items As New colPreJobItems
        Dim DeletedItems As New Collection

        Private Structure PreJob
            Dim Grade As Short
            Dim Section As String
            Dim TotalEst As Short
            Dim LES As Integer
            Dim NV As Integer
            Dim REN As Integer
            Dim MAT As Integer
            Dim Con1 As Integer
            Dim Con2 As Integer
        End Structure

#Region "LEVEL ONE ROUTINES"
        Private Sub frmPreJob_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
            Call SetFlatScrollBars(Me.LVDetails, True)

            'cFlatCtrls.SetFormControls Me
            Call FillConsultantCBox(cboConsultant)
            Call FillConsultantCBox(cboConsultant2)
            Call FillConsultantCBox(cboConsultant3)
            Call FillGradeCbox(cboGrade)
            Call FillSchoolCbox(cboSchools)
            Call FillSemesterCbox(cboSemester)
            Call FillBatteryCbox(cboBattery)
            Call FillNVCbox(cboNV, , True)
            Call FillLESCbox(cboLes, , True)
            Call FillMATCbox(cboMat, , True)
            Call FillRENCbox(cboRen, , True)

            'schoolint = cboSchools.FindString(sch_name)
            Dim id As Integer = -1
            For iCounter As Integer = 0 To cboSchools.Items.Count - 1
                cboSchools.SelectedIndex = iCounter
                Dim test As String = cboSchools.SelectedItem.ToString.Substring(cboSchools.SelectedItem.IndexOf("-") + 1)
                cboSchools.Text = String.Empty
                If test.Contains(" " + sch_name) Then
                    id = iCounter
                End If
            Next
            cboSchools.SelectedIndex = id
            Dim temp(0) As String
            temp = Split(cboSchools.SelectedText.ToString, " - ")
            iSchoolID = Val(temp(0))


            If iSchoolID > 0 Then
                Me.txtPrice.Text = FormatCurrency(GetPrice(CDbl(iSchoolID)))
                cboSchools.Enabled = True
                Call LoadData()
            End If

            'Call SelectItemWithID(cboSchools, iSchoolID)
            Call ComboboxUtilities.SetComboItemWithId(cboSchools, iSchoolID)
        End Sub
        Private Sub frmPreJob_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
            Dim iCounter1 As Integer
            If (Not Items Is Nothing) Then
                Items.Clear()
            End If
            If Not DeletedItems Is Nothing Then
                For iCounter1 = 1 To DeletedItems.Count()
                    DeletedItems.Remove(1)
                Next iCounter1
            End If
            'DeletedItems = Nothing
            'Items = Nothing
            'setting nothing thorws error of object not found
            DeletedItems.Clear()
            Items.Clear()
            iSchoolID = 0
        End Sub
        Private Sub frmPreJob_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            Dim KeyCode As Short = eventArgs.KeyCode
            Dim Shift As Short = eventArgs.KeyData \ &H10000
            Dim VC As New ValidateClass

            Select Case KeyCode
                Case System.Windows.Forms.Keys.F1
                    If VC.ValidateForm(Me) Then
                        Call Add_Renamed()
                    End If
                Case System.Windows.Forms.Keys.F2
                    If VC.ValidateForm(Me) Then
                        Call EditSelected()
                    End If
                Case System.Windows.Forms.Keys.F3
                    Call Delete()
            End Select
        End Sub

        'UPGRADE_WARNING: Event cboBattery.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub cboBattery_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboBattery.SelectedIndexChanged
            Dim def_id As Integer

            If InStr(1, cboBattery.Text, "|") > 0 Then
                def_id = CInt(Split(cboBattery.Text, "|")(2))
                SetExam((def_id))
            Else
                SetExam()
            End If

        End Sub
        'UPGRADE_WARNING: Event cboConsultant.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub cboConsultant_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboConsultant.SelectedIndexChanged
            If cboConsultant.Text <> String.Empty Then
                Me.chkToll1.Enabled = True
            Else
                Me.chkToll1.Enabled = False
            End If
        End Sub
        'UPGRADE_WARNING: Event cboConsultant2.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub cboConsultant2_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboConsultant2.SelectedIndexChanged
            If cboConsultant2.Text <> String.Empty Then
                Me.chkToll2.Enabled = True
            Else
                Me.chkToll2.Enabled = False
            End If
        End Sub
        'UPGRADE_WARNING: Event cboGrade.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub cboGrade_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboGrade.SelectedIndexChanged
            SetExam()
        End Sub

        Private Sub cboSchools_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSchools.SelectedIndexChanged
            Dim temp As String
            Dim temp2() As String

            temp = cboSchools.SelectedText.ToString

            temp2 = Split(temp, " - ")
            If temp2(0) <> String.Empty Then
                iSchoolID = temp2(0).ToString.Trim
                Me.txtPrice.Text = FormatCurrency(GetPrice(CDbl(iSchoolID)))
            End If
        End Sub
        Private Sub cboSchools_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles cboSchools.Validating
            Dim Cancel As Boolean = eventArgs.Cancel
            Me.txtPrice.Text = FormatCurrency(GetPrice(VB6.GetItemData(Me.cboSchools, Me.cboSchools.SelectedIndex)))
            eventArgs.Cancel = Cancel
        End Sub
        'UPGRADE_WARNING: Event cboSemester.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub cboSemester_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboSemester.SelectedIndexChanged
            SetExam()
        End Sub
        'UPGRADE_WARNING: Event chkAcomodo.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub chkAcomodo_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkAcomodo.CheckStateChanged
            If CBool(chkAcomodo.CheckState) Then
                chkPEP.CheckState = System.Windows.Forms.CheckState.Unchecked
                chkEntrance.CheckState = System.Windows.Forms.CheckState.Unchecked
            End If
        End Sub
        'UPGRADE_WARNING: Event chkEntrance.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub chkEntrance_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkEntrance.CheckStateChanged
            If CBool(chkEntrance.CheckState) Then
                chkPEP.CheckState = System.Windows.Forms.CheckState.Unchecked
                chkAcomodo.CheckState = System.Windows.Forms.CheckState.Unchecked
            End If
        End Sub
        Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
            Me.Close()
        End Sub
        Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
            Call SaveData()
            Me.Close()
        End Sub
        Private Sub cmdProgram_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdProgram.Click
            'Dim CrxApp As New Application
            'Dim CrxRpt As CRAXDRT.Report
            Dim Ind As MsgBoxResult
            Dim indValue As Short
            Dim Label As MsgBoxResult
            Dim labelValue As Short
            Dim R As MsgBoxResult
            Dim ReportFile As String
            Dim rptIndiv As New frmReport
            Dim SchID As Integer

            On Error GoTo Err_Handler

            If Me.cboSchools.Text = String.Empty Then
                Exit Sub
            End If
            Dim temp() As String = Split(cboSchools.Text, " - ")
            SchID = temp(0)
            'SchID = VB6.GetItemData(Me.cboSchools, cboSchools.SelectedIndex)
            R = MsgBox("Do you want to preview the program.", MsgBoxStyle.YesNoCancel)
            Ind = MsgBox("Individual report included?", MsgBoxStyle.YesNo)
            Label = MsgBox("Label included?", MsgBoxStyle.YesNo)

            If Ind = MsgBoxResult.Yes Then
                indValue = 1
            Else
                indValue = 0
            End If
            If Label = MsgBoxResult.Yes Then
                labelValue = 1
            Else
                labelValue = 0
            End If

            Call SaveData(indValue, labelValue)

            'Save Ind and Label settings

            If R = MsgBoxResult.Yes Then
                '///////////////////preview/////////////////////////
                rptIndiv.ReportID = SchID
                If bTITULO1 Then
                    rptIndiv.ReportFile = Config.ReportsPath & "titulo1_programa.rpt"
                Else
                    rptIndiv.ReportFile = Config.ReportsPath & "programa.rpt"
                End If
                rptIndiv.ShowDialog()
            ElseIf R = MsgBoxResult.No Then
                '///////////////////Print/////////////////////////
                frmMain.CDPrint.ShowDialog()
                If bTITULO1 Then
                    ReportFile = Config.ReportsPath & "TITULO1_programa.rpt"
                Else
                    ReportFile = Config.ReportsPath & "programa.rpt"
                End If
            End If

Terminate:
            Exit Sub
Err_Handler:
            If Err.Number = 32755 Then
                Resume Terminate
            Else
                MsgBox(Err.Number & " - " & Err.Description, MsgBoxStyle.Critical, "Error")
                Resume Terminate
            End If
        End Sub
        Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
            Dim MBResult As MsgBoxResult
            If LVDetails.Items.Count > 0 Then

                MBResult = MsgBox("Warning: Once the jobs are Generated,  the information provided in the prejob stage cannot be changed." & vbCrLf & "Do you want to continue?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
                If MBResult = MsgBoxResult.Yes Then
                    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                    Call GenerateJobs()
                    Me.Close()
                End If
            End If
        End Sub
        Private Sub LVDetails_Click(sender As Object, e As EventArgs) Handles LVDetails.Click
            If Not LVDetails.FocusedItem Is Nothing Then
                Dim item = LVDetails.Items(LVDetails.FocusedItem.Index)

                Me.txtSection.Text = item.SubItems(1).Text
                Me.txtTotalStudents.Text = item.SubItems(2).Text

                If item.SubItems(14).Text <> "" Then
                    Me.cboBattery.Text = item.SubItems(14).Text
                End If

                Call SetValueToCBox((Me.cboGrade), (item.Text))

                'Call SetValueToCBox((Me.cboLes), item.SubItems(3).Text)
                ComboboxUtilities.SetComboItemWithValue(cboLes, item.SubItems(3).Text)

                'Call SetValueToCBox((Me.cboNV), item.SubItems(4).Text)
                ComboboxUtilities.SetComboItemWithValue(cboNV, item.SubItems(4).Text)

                'Call SetValueToCBox(cboRen, item.SubItems(5).Text)
                ComboboxUtilities.SetComboItemWithValue(cboRen, item.SubItems(5).Text)

                'Call SetValueToCBox(cboMat, item.SubItems(6).Text)
                ComboboxUtilities.SetComboItemWithValue(cboMat, item.SubItems(6).Text)

                'Call SetValueToCBox((Me.cboConsultant), item.SubItems(7).Text)
                ComboboxUtilities.SetComboItemWithValue(Me.cboConsultant, item.SubItems(7).Text)

                Me.chkToll1.CheckState = IIf(item.SubItems(8).Text = "Yes", 1, 0)

                'Call SetValueToCBox(cboConsultant2, item.SubItems(9).Text)
                ComboboxUtilities.SetComboItemWithValue(Me.cboConsultant2, item.SubItems(9).Text)

                Me.chkToll2.CheckState = IIf(item.SubItems(10).Text = "Yes", 1, 0)

                'Call SetValueToCBox(cboConsultant3, item.SubItems(11).Text)
                ComboboxUtilities.SetComboItemWithValue(Me.cboConsultant3, item.SubItems(11).Text)

                Me.txtDate.Text = item.SubItems(12).Text

                Me.txtPrice.Text = item.SubItems(13).Text

                Me.cboSemester.Text = item.SubItems(15).Text

                Me.cboBattery.Text = item.SubItems(14).Text


            End If
        End Sub
        Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BtnNew.Click, _Toolbar1_Button2.Click, BtnEdit.Click, _Toolbar1_Button4.Click, BtnDel.Click
            Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
            Dim VC As New ValidateClass

            Select Case Button.Name
                Case "BtnNew"
                    If VC.ValidateForm(Me) Then
                        If IsNumeric(Me.txtPrice.Text) Then
                            Call Add_Renamed()
                        Else
                            MsgBox("Invalid Price Value.", MsgBoxStyle.Information)
                        End If

                    End If
                Case "BtnEdit"
                    If VC.ValidateForm(Me) Then
                        If IsNumeric(Me.txtPrice.Text) Then
                            Call EditSelected()
                        Else
                            MsgBox("Invalid Price Value.", MsgBoxStyle.Information)
                        End If
                    End If
                Case "BtnDel"
                    Call Delete()
            End Select
        End Sub
#End Region
#Region "LEVEL TWO ROUTINES"
        'UPGRADE_NOTE: Add was upgraded to Add_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        'Called By: frmPreJob_KeyDown()
        'Called By: frmPreJob.Toobar1_ButtonClick()
        Sub Add_Renamed()
            Dim iCon1 As Integer
            Dim iCon2 As Integer
            Dim iCon3 As Integer
            Dim iGrade As Short
            Dim iLES As Integer
            Dim iMAT As Integer
            Dim iNV As Integer
            Dim iREN As Integer
            Dim iStudents As Short
            Dim Item As System.Windows.Forms.ListViewItem
            Dim iToll1 As Short
            Dim iToll2 As Short
            Dim sSection As String

            Item = Me.LVDetails.Items.Add(cboGrade.Text)
            iGrade = VB6.GetItemData(Me.cboGrade, cboGrade.SelectedIndex)
            sSection = Me.txtSection.Text
            iStudents = Val(txtTotalStudents.Text)

            'iLES = ComboboxUtilities.GetComboSelectedItemId(cboLes)
            'iNV = ComboboxUtilities.GetComboSelectedItemId(cboNV)
            'iREN = ComboboxUtilities.GetComboSelectedItemId(cboRen)
            'iMAT = ComboboxUtilities.GetComboSelectedItemId(cboMat)
            'iCon1 = ComboboxUtilities.GetComboSelectedItemId(cboConsultant)
            'iCon2 = ComboboxUtilities.GetComboSelectedItemId(cboConsultant2)
            'iCon3 = ComboboxUtilities.GetComboSelectedItemId(cboConsultant3)

            'iLES = cboLes.SelectedValue
            If IsDBNull(cboLes.SelectedValue) Then
                iLES = vbNull
            Else
                iLES = cboLes.SelectedValue
            End If
            If IsDBNull(cboNV.SelectedValue) Then
                iNV = vbNull
            Else
                iNV = cboNV.SelectedValue
            End If
            If IsDBNull(cboRen.SelectedValue) Then
                iREN = vbNull
            Else
                iREN = cboRen.SelectedValue
            End If
            If IsDBNull(cboMat.SelectedValue) Then
                iMAT = vbNull
            Else
                iMAT = cboMat.SelectedValue
            End If

            'iNV = cboNV.SelectedValue
            'iREN = cboRen.SelectedValue
            'iMAT = cboMat.SelectedValue
            If cboConsultant.SelectedIndex = 0 Then
                iCon1 = 0
            Else
                iCon1 = cboConsultant.SelectedValue
            End If
            If cboConsultant2.SelectedIndex = 0 Then
                iCon2 = 0
            Else
                iCon2 = cboConsultant2.SelectedValue
            End If
            If cboConsultant3.SelectedIndex = 0 Then
                iCon3 = 0
            Else
                iCon3 = cboConsultant3.SelectedValue
            End If

            iToll1 = Me.chkToll1.CheckState
            iToll2 = Me.chkToll2.CheckState

            ' -- Add to collection
            Items.Add(iGrade, sSection, iStudents, iLES, iNV, iREN, iMAT, iCon1, iToll1, iCon2, iToll2, iCon3, CDbl((Me.txtPrice).Text), (Me.txtDate).Text, (Me.cboBattery).Text)

            ' -- Add to listview            
            If Item.SubItems.Count > 1 Then
                Item.SubItems(1).Text = Me.txtSection.Text
            Else
                Item.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.txtSection.Text))
            End If

            If Item.SubItems.Count > 2 Then
                Item.SubItems(2).Text = Me.txtTotalStudents.Text
            Else
                Item.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.txtTotalStudents.Text))
            End If

            If Item.SubItems.Count > 3 Then
                Item.SubItems(3).Text = Me.cboLes.Text
            Else
                Item.SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.cboLes.Text))
            End If

            If Item.SubItems.Count > 4 Then
                Item.SubItems(4).Text = Me.cboNV.Text
            Else
                Item.SubItems.Insert(4, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.cboNV.Text))
            End If

            If Item.SubItems.Count > 5 Then
                Item.SubItems(5).Text = cboRen.Text
            Else
                Item.SubItems.Insert(5, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, cboRen.Text))
            End If

            If Item.SubItems.Count > 6 Then
                Item.SubItems(6).Text = cboMat.Text
            Else
                Item.SubItems.Insert(6, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, cboMat.Text))
            End If

            If Item.SubItems.Count > 7 Then
                Item.SubItems(7).Text = Me.cboConsultant.Text
            Else
                Item.SubItems.Insert(7, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.cboConsultant.Text))
            End If

            If Item.SubItems.Count > 8 Then
                Item.SubItems(8).Text = IIf(Me.chkToll1.CheckState = 1, "Yes", "No")
            Else
                Item.SubItems.Insert(8, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, IIf(Me.chkToll1.CheckState = 1, "Yes", "No")))
            End If

            If Item.SubItems.Count > 9 Then
                Item.SubItems(9).Text = cboConsultant2.Text
            Else
                Item.SubItems.Insert(9, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, cboConsultant2.Text))
            End If

            If Item.SubItems.Count > 10 Then
                Item.SubItems(10).Text = IIf(Me.chkToll2.CheckState = 1, "Yes", "No")
            Else
                Item.SubItems.Insert(10, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, IIf(Me.chkToll2.CheckState = 1, "Yes", "No")))
            End If

            If Item.SubItems.Count > 11 Then
                Item.SubItems(11).Text = cboConsultant3.Text
            Else
                Item.SubItems.Insert(11, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, cboConsultant3.Text))
            End If

            If Item.SubItems.Count > 12 Then
                Item.SubItems(12).Text = Me.txtDate.Text
            Else
                Item.SubItems.Insert(12, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.txtDate.Text))
            End If

            If Item.SubItems.Count > 13 Then
                Item.SubItems(13).Text = Me.txtPrice.Text
            Else
                Item.SubItems.Insert(13, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.txtPrice.Text))
            End If

            If Item.SubItems.Count > 14 Then
                Item.SubItems(14).Text = Me.cboBattery.Text
            Else
                Item.SubItems.Insert(14, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.cboBattery.Text))
            End If

            If Item.SubItems.Count > 15 Then
                Item.SubItems(15).Text = Me.cboSemester.Text
            Else
                Item.SubItems.Insert(15, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.cboSemester.Text))
            End If
            Item.EnsureVisible()
        End Sub
        'Called By: frmPreJob_KeyDown()
        'Called By: frmPreJob.Toobar1_ButtonClick()
        Sub Delete()
            Dim Index As Short
            If Not LVDetails.FocusedItem Is Nothing Then
                If LVDetails.FocusedItem.Name <> String.Empty Then
                    DeletedItems.Add(LVDetails.FocusedItem.Name)
                End If
                Index = LVDetails.FocusedItem.Index
                LVDetails.Items.RemoveAt(Index)
                'index+1 to correct remove index
                Items.Remove(Index + 1)
            End If
        End Sub
        'Called By: frmPreJob_KeyDown()
        'Called By: frmPreJob.Toobar1_ButtonClick()
        Sub EditSelected()
            Dim iCon1 As Integer
            Dim iCon2 As Integer
            Dim iCon3 As Integer
            Dim iGrade As Short
            Dim iLES As Integer
            Dim iMAT As Integer
            Dim Index As Short
            Dim iNV As Integer
            Dim iREN As Integer
            Dim iStudents As Short
            Dim Item As System.Windows.Forms.ListViewItem
            Dim iToll1 As Short
            Dim iToll2 As Short
            Dim sSection As String

            Item = Me.LVDetails.FocusedItem
            If Not Item Is Nothing Then
                Index = Item.Index + 1
                Item.Text = cboGrade.Text

                If Item.SubItems.Count > 1 Then
                    Item.SubItems(1).Text = Me.txtSection.Text
                Else
                    Item.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.txtSection.Text))
                End If

                If Item.SubItems.Count > 2 Then
                    Item.SubItems(2).Text = CStr(Val(Me.txtTotalStudents.Text))
                Else
                    Item.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, CStr(Val(Me.txtTotalStudents.Text))))
                End If

                If Item.SubItems.Count > 3 Then
                    Item.SubItems(3).Text = Me.cboLes.Text
                Else
                    Item.SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.cboLes.Text))
                End If

                If Item.SubItems.Count > 4 Then
                    Item.SubItems(4).Text = Me.cboNV.Text
                Else
                    Item.SubItems.Insert(4, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.cboNV.Text))
                End If

                If Item.SubItems.Count > 5 Then
                    Item.SubItems(5).Text = cboRen.Text
                Else
                    Item.SubItems.Insert(5, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, cboRen.Text))
                End If

                If Item.SubItems.Count > 6 Then
                    Item.SubItems(6).Text = cboMat.Text
                Else
                    Item.SubItems.Insert(6, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, cboMat.Text))
                End If

                If Item.SubItems.Count > 7 Then
                    Item.SubItems(7).Text = Me.cboConsultant.Text
                Else
                    Item.SubItems.Insert(7, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.cboConsultant.Text))
                End If
                'UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                If Item.SubItems.Count > 8 Then
                    Item.SubItems(8).Text = IIf(Me.chkToll1.CheckState = 1, "Yes", "No")
                Else
                    Item.SubItems.Insert(8, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, IIf(Me.chkToll1.CheckState = 1, "Yes", "No")))
                End If
                'UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                If Item.SubItems.Count > 9 Then
                    Item.SubItems(9).Text = cboConsultant2.Text
                Else
                    Item.SubItems.Insert(9, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, cboConsultant2.Text))
                End If
                'UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                If Item.SubItems.Count > 10 Then
                    Item.SubItems(10).Text = IIf(Me.chkToll2.CheckState = 1, "Yes", "No")
                Else
                    Item.SubItems.Insert(10, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, IIf(Me.chkToll2.CheckState = 1, "Yes", "No")))
                End If
                'UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                If Item.SubItems.Count > 11 Then
                    Item.SubItems(11).Text = cboConsultant3.Text
                Else
                    Item.SubItems.Insert(11, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, cboConsultant3.Text))
                End If
                'UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                If Item.SubItems.Count > 12 Then
                    Item.SubItems(12).Text = Me.txtDate.Text
                Else
                    Item.SubItems.Insert(12, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.txtDate.Text))
                End If
                'UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                If Item.SubItems.Count > 13 Then
                    Item.SubItems(13).Text = Me.txtPrice.Text
                Else
                    Item.SubItems.Insert(13, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.txtPrice.Text))
                End If
                'UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                If Item.SubItems.Count > 14 Then
                    Item.SubItems(14).Text = Me.cboBattery.Text
                Else
                    Item.SubItems.Insert(14, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.cboBattery.Text))
                End If
                'UPGRADE_WARNING: MSComctlLib.ListItem method Item.EnsureVisible has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
                Item.EnsureVisible()

                iGrade = cboGrade.SelectedIndex
                    'VB6.GetItemData(Me.cboGrade, cboGrade.SelectedIndex)
                sSection = Me.txtSection.Text
                iStudents = Val(Me.txtTotalStudents.Text)
                'iLES = VB6.GetItemData(Me.cboLes, cboLes.SelectedIndex)
                'iNV = VB6.GetItemData(Me.cboNV, cboNV.SelectedIndex)
                'iREN = VB6.GetItemData(Me.cboRen, cboRen.SelectedIndex)
                'iMAT = VB6.GetItemData(Me.cboMat, cboMat.SelectedIndex)
                'iCon1 = VB6.GetItemData(Me.cboConsultant, cboConsultant.SelectedIndex)
                'iCon2 = VB6.GetItemData(Me.cboConsultant2, cboConsultant2.SelectedIndex)
                'iCon3 = VB6.GetItemData(Me.cboConsultant3, cboConsultant3.SelectedIndex)

                iLES = cboLes.SelectedIndex
                'ComboboxUtilities.GetComboSelectedItemId(cboLes.SelectedIndex)
                iNV = cboNV.SelectedIndex
                'ComboboxUtilities.GetComboSelectedItemId(cboNV.SelectedIndex)
                iREN = cboRen.SelectedIndex
                'ComboboxUtilities.GetComboSelectedItemId(cboRen)
                iMAT = cboMat.SelectedIndex
                'ComboboxUtilities.GetComboSelectedItemId(cboMat)
                iCon1 = cboConsultant.SelectedIndex
                'ComboboxUtilities.GetComboSelectedItemId(cboConsultant)
                iCon2 = cboConsultant2.SelectedIndex
                'ComboboxUtilities.GetComboSelectedItemId(cboConsultant2)
                iCon3 = cboConsultant3.SelectedIndex
                'ComboboxUtilities.GetComboSelectedItemId(cboConsultant3)

                iToll1 = Me.chkToll1.CheckState
                iToll2 = Me.chkToll2.CheckState


                'Items.Modify(Index, iGrade, sSection, iStudents, iLES, iNV, iREN, iMAT, iCon1, iToll2, iCon2, iToll2, iCon3, CDbl((Me.txtPrice).Text), (Me.txtDate).Text, (Me.cboBattery).Text)
            End If
        End Sub
        'Called By: frmPreJob.Command1_Click()
        Sub GenerateJobs()
            Dim Cm As New ADODB.Command
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset

            Dim bPEP As Boolean
            Dim iCounter1 As Integer
            Dim Plugin As String
            'Dim schoolId As String = ComboboxUtilities.GetComboSelectedItemId(cboSchools.)
            Dim schoolId As String = cboSchools.SelectedItem.ToString.Substring(0, cboSchools.SelectedItem.IndexOf(" -")).Trim
            OpenConnection(Cn, Config.ConnectionString)

            Rs.Open("Select * From Jobs Where J_Id=-1", Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)

            For iCounter1 = 1 To Items.Count
                Rs.AddNew()
                If Items(iCounter1).LES = 52 Then
                    bPEP = True
                Else
                    bPEP = False
                End If

                If CBool(Me.chkAcomodo.CheckState) Then
                    Rs.Fields("j_type").Value = 3
                ElseIf CBool(Me.chkEntrance.CheckState) Then
                    Rs.Fields("j_type").Value = 1
                Else
                    Rs.Fields("j_type").Value = 2 ' -- Regular
                End If

                Rs.Fields("J_GRADE").Value = Items(iCounter1).Grade
                'schoolId = schoolId.Substring(0, schoolId.IndexOf("-") - 1).Trim
                Rs.Fields("J_SCH").Value = schoolId
                Rs.Fields("J_SEM").Value = cboSemester.SelectedIndex
                'Rs.Fields("J_SEM").Value = VB6.GetItemData(cboSemester, cboSemester.SelectedIndex)
                Rs.Fields("J_ARCHIVO").Value = Me.txtFile.Text
                Rs.Fields("J_SEC").Value = Items(iCounter1).Section
                Rs.Fields("J_TOTAL_EST").Value = Items(iCounter1).Students
                If bPEP Then 'Pep
                    Rs.Fields("j_pepv").Value = 52
                ElseIf Items(iCounter1).LES = 51 Then
                    'AID                   
                    Rs.Fields("J_LES").Value = System.DBNull.Value
                    Rs.Fields("J_NV").Value = System.DBNull.Value
                    Rs.Fields("J_REN").Value = System.DBNull.Value
                    Rs.Fields("J_MAT").Value = System.DBNull.Value
                    Rs.Fields("j_AID").Value = 51
                Else
                    Rs.Fields("J_LES").Value = Items(iCounter1).LES
                    Rs.Fields("J_NV").Value = Items(iCounter1).NV
                    Rs.Fields("J_REN").Value = Items(iCounter1).REN
                    Rs.Fields("J_MAT").Value = Items(iCounter1).MAT
                    Rs.Fields("j_AID").Value = System.DBNull.Value
                End If
                Rs.Fields("J_CONS").Value = Items(iCounter1).Consultant1
                Rs.Fields("j_toll1").Value = Items(iCounter1).Toll1
                Rs.Fields("J_CONS2").Value = Items(iCounter1).Consultant2
                Rs.Fields("j_toll2").Value = Items(iCounter1).Toll2
                Rs.Fields("J_CONS3").Value = Items(iCounter1).Consultant3
                Rs.Fields("J_Serv_Date").Value = Items(iCounter1).ServDate
                Rs.Fields("J_price").Value = Items(iCounter1).Price
                Rs.Fields("J_USER").Value = LoggedUser.UserID
                Rs.Fields("J_DATE").Value = Now.ToShortDateString
                Rs.Fields("J_COMP_ID").Value = Config.COMP_ID
                Rs.Fields("J_Status").Value = 0
                Rs.Fields("J_AcomRazonable").Value = chkAcomodo.CheckState
                Rs.Fields("J_Process_Status").Value = 2
                If bPEP Then
                    Rs.Fields("j_plugin").Value = "PEPV"
                Else
                    If InStr(1, Items(iCounter1).Plugin, "|") > 0 Then
                        Rs.Fields("j_plugin").Value = Split(Items(iCounter1).Plugin, "|")(0)
                    Else
                        Rs.Fields("j_plugin").Value = String.Empty
                    End If
                End If
                Rs.Update()
            Next iCounter1
            Rs.Close()

            Cm.ActiveConnection = Cn
            Cm.CommandText = "Delete from Prejobs Where PJ_SCH_ID=" & schoolId 'VB6.GetItemData(cboSchools, cboSchools.SelectedIndex)
            Cm.Execute()
            Cm.CommandText = "update schools set sc_job_type=2 where sc_id=" & schoolId & ";"
            Cm.Execute()
            Cn.Close()
        End Sub
        'Called By: frmPreJob_Load()
        Sub LoadData()
            Dim myJobType As String
            Dim myID As Object
            'Dim Cn As New ADODB.Connection
            'Dim Rs As New ADODB.Recordset
            Dim sQuery As String
            Dim Item As System.Windows.Forms.ListViewItem

            '************************<<QUERY>>*************************************************
            sQuery = "SELECT  dbo.PREJOBS.*, CONSULTANTS1.CON_NAME + ' ' + CONSULTANTS1.CON_LNAME1 + ' ' + CONSULTANTS1.CON_LNAME2 AS CON1, " &
                "            CONSULTANTS2.CON_NAME +' ' + CONSULTANTS2.CON_LNAME1 + ' ' + CONSULTANTS2.CON_LNAME2 AS CON2," &
                "            CONSULTANTS3.CON_NAME + ' ' + CONSULTANTS3.CON_LNAME1 + ' ' + CONSULTANTS3.CON_LNAME2 AS CON3," &
                "            Claves3.CL_TYPE AS REN_TYPE, Claves2.CL_TYPE AS LES_TYPE, Claves1.CL_TYPE AS MAT_TYPE, " &
                "            Claves_1.CL_TYPE AS NV_TYPE" &
                "            FROM         dbo.Claves Claves2 RIGHT OUTER JOIN " &
                "            dbo.CONSULTANTS CONSULTANTS1 RIGHT OUTER JOIN " & "    dbo.Claves Claves3 RIGHT OUTER JOIN " &
                "            dbo.CONSULTANTS CONSULTANTS3 RIGHT OUTER JOIN " &
                "            dbo.PREJOBS ON CONSULTANTS3.CON_ID = dbo.PREJOBS.PJ_CONS3 ON Claves3.CL_ID = dbo.PREJOBS.PJ_REN ON " &
                "            CONSULTANTS1.CON_ID = dbo.PREJOBS.PJ_CONS LEFT OUTER JOIN " &
                "            dbo.CONSULTANTS CONSULTANTS2 ON dbo.PREJOBS.PJ_CONS2 = CONSULTANTS2.CON_ID ON " &
                "            Claves2.CL_ID = dbo.PREJOBS.PJ_LES LEFT OUTER JOIN " &
                "            dbo.Claves Claves1 ON dbo.PREJOBS.PJ_MAT = Claves1.CL_ID LEFT OUTER JOIN " &
                "            dbo.Claves Claves_1 ON dbo.PREJOBS.PJ_NV = Claves_1.CL_ID " &
                "Where (dbo.PREJOBS.PJ_SCH_ID = " & iSchoolID.ToString & ") order by dbo.Prejobs.PJ_Grade,dbo.Prejobs.PJ_Section "
            '************************<<QUERY>>*************************************************

            'OpenConnection(Cn, Config.ConnectionString)

            'Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            Dim dt As System.Data.DataTable = GlobalResources.ExecuteDataTable(sQuery)
            Dim iCounter1 As Integer

            If dt.Rows.Count > 0 Then
                'Not needed already loaded
                'Call SelectItemWithID(cboSchools, GetValue(Rs.Fields("PJ_SCH_ID")))
                Call SelectItemWithID(cboSemester, dt.Rows(0)("pj_semester").ToString())

                myID = dt.Rows(0)("PJ_SCH_ID").ToString()
                Me.txtFile.Text = dt.Rows(0)("PJ_ARCHIVO").ToString()
                If dt.Rows(0)("PJ_LES").ToString() = "52" Then
                    Call chkPEP_CheckStateChanged(chkPEP, New System.EventArgs())
                End If
            End If

            If Items IsNot Nothing Then
                Items.Clear()
            End If
            If LVDetails.Items IsNot Nothing Then
                LVDetails.Items.Clear()
            End If
            ' -- Alco Sledgehammer           
            myJobType = GetSchoolJobType(CInt(myID))
            Select Case myJobType
                Case "1" ' -- Entrance
                    Me.chkEntrance.CheckState = System.Windows.Forms.CheckState.Checked
                Case "2" '-- Regular
                Case "3" ' -- Acomodo
                    Me.chkAcomodo.CheckState = System.Windows.Forms.CheckState.Checked
                Case "4" ' -- PEPV
                    Me.chkPEP.CheckState = System.Windows.Forms.CheckState.Checked
            End Select
            ' --

            For iCounter1 = 0 To dt.Rows.Count - 1
                Dim pjGrade = dt.Rows(iCounter1)("pj_grade").ToString()
                Dim pjSection = dt.Rows(iCounter1)("PJ_Section").ToString()
                Dim pjTotEst = (dt.Rows(iCounter1)("PJ_Total_Est").ToString())
                Dim pjLes = (dt.Rows(iCounter1)("PJ_LES").ToString())
                Dim pjNv = (dt.Rows(iCounter1)("pj_nv").ToString())
                Dim pjRen = (dt.Rows(iCounter1)("pj_ren").ToString())
                Dim pjMat = (dt.Rows(iCounter1)("pj_mat").ToString())
                Dim pjCons = (dt.Rows(iCounter1)("PJ_CONS").ToString())
                Dim pjCons2 = (dt.Rows(iCounter1)("PJ_CONS2").ToString())
                Dim pjCons3 = (dt.Rows(iCounter1)("PJ_CONS3").ToString())
                Dim pjPlugin = (dt.Rows(iCounter1)("pj_plugin").ToString())
                Dim pjToll1 = CBool(dt.Rows(iCounter1)("pj_toll1").ToString())
                Dim pjToll2 = CBool(dt.Rows(iCounter1)("pj_toll2").ToString())
                Dim pjPrice = (dt.Rows(iCounter1)("pj_price").ToString())
                Dim pjServDate = ToDate(dt.Rows(iCounter1)("PJ_serv_date").ToString())

                Items.Add(pjGrade, pjSection, pjTotEst, pjLes,
                          pjNv, pjRen, pjMat, pjCons,
                          pjToll1, pjCons2, pjToll2, pjCons3,
                          pjPrice, pjServDate, pjPlugin)

                Item = LVDetails.Items.Add("P" & dt.Rows(iCounter1)("pj_id").ToString(), GetGradeName(dt.Rows(iCounter1)("pj_grade").ToString()), String.Empty)
                If Item.SubItems.Count > 1 Then
                    Item.SubItems(1).Text = pjSection
                Else
                    Item.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, pjSection))
                End If

                If Item.SubItems.Count > 2 Then
                    Item.SubItems(2).Text = pjTotEst
                Else
                    Item.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, pjTotEst))
                End If

                If Item.SubItems.Count > 3 Then
                    Item.SubItems(3).Text = dt.Rows(iCounter1)("LES_TYPE").ToString()
                Else
                    Item.SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, dt.Rows(iCounter1)("LES_TYPE").ToString()))
                End If

                If Item.SubItems.Count > 4 Then
                    Item.SubItems(4).Text = dt.Rows(iCounter1)("NV_TYPE").ToString()
                Else
                    Item.SubItems.Insert(4, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, dt.Rows(iCounter1)("NV_TYPE").ToString()))
                End If

                If Item.SubItems.Count > 5 Then
                    Item.SubItems(5).Text = dt.Rows(iCounter1)("REN_TYPE").ToString()
                Else
                    Item.SubItems.Insert(5, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, dt.Rows(iCounter1)("REN_TYPE").ToString()))
                End If

                If Item.SubItems.Count > 6 Then
                    Item.SubItems(6).Text = dt.Rows(iCounter1)("MAT_TYPE").ToString()
                Else
                    Item.SubItems.Insert(6, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, dt.Rows(iCounter1)("MAT_TYPE").ToString()))
                End If

                If Item.SubItems.Count > 7 Then
                    Item.SubItems(7).Text = dt.Rows(iCounter1)("CON1").ToString()
                Else
                    Item.SubItems.Insert(7, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, dt.Rows(iCounter1)("CON1").ToString()))
                End If

                If Item.SubItems.Count > 8 Then
                    Item.SubItems(8).Text = IIf(dt.Rows(iCounter1)("PJ_TOLL1").ToString() = True, "Yes", "No")
                Else
                    Item.SubItems.Insert(8, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, IIf(dt.Rows(iCounter1)("PJ_TOLL1").ToString() = True, "Yes", "No")))
                End If

                If Item.SubItems.Count > 9 Then
                    Item.SubItems(9).Text = dt.Rows(iCounter1)("CON2").ToString()
                Else
                    Item.SubItems.Insert(9, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, dt.Rows(iCounter1)("CON2").ToString()))
                End If

                If Item.SubItems.Count > 10 Then
                    Item.SubItems(10).Text = IIf(dt.Rows(iCounter1)("PJ_TOLL2").ToString() = True, "Yes", "No")
                Else
                    Item.SubItems.Insert(10, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, IIf(dt.Rows(iCounter1)("PJ_TOLL2").ToString() = True, "Yes", "No")))
                End If

                If Item.SubItems.Count > 11 Then
                    Item.SubItems(11).Text = dt.Rows(iCounter1)("CON3").ToString()
                Else
                    Item.SubItems.Insert(11, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, dt.Rows(iCounter1)("CON3").ToString()))
                End If

                If Item.SubItems.Count > 12 Then
                    Item.SubItems(12).Text = pjServDate
                Else
                    Item.SubItems.Insert(12, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, pjServDate))
                End If

                If Item.SubItems.Count > 13 Then
                    Item.SubItems(13).Text = pjPrice
                Else
                    Item.SubItems.Insert(13, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, pjPrice))
                End If

                If Item.SubItems.Count > 14 Then
                    Item.SubItems(14).Text = pjPlugin
                Else
                    Item.SubItems.Insert(14, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, pjPlugin))
                End If

                'Rs.MoveNext()
            Next

            'Rs.Close()
            'Cn.Close()

        End Sub
        'Called By: frmPreJob.cmdOK_Click()
        'Called By: frmPreJob.cmdProgram_Click()
        Sub SaveData(Optional ByRef Ind As Short = 0, Optional ByRef Label As Short = 0)
            Dim sQuery As String
            Dim Cm As ADODB.Command
            Dim Cn As New ADODB.Connection
            Dim Cn2 As New ADODB.Connection
            Dim Cn3 As New ADODB.Connection
            Dim Rs As New ADODB.Recordset

            Dim iCounter1 As Integer
            Dim Item As System.Windows.Forms.ListViewItem
            Dim myJobType As Integer
            Dim Where As String
            Dim TheItem As String
            Dim temp() As String
            Dim schoolid As String

            temp = Split(cboSchools.SelectedItem.ToString, " - ")
            schoolid = temp(0)
            OpenConnection(Cn, Config.ConnectionString)

            Rs.Open("Select * From PreJobs Where PJ_SCH_ID=" & Me.iSchoolID, Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)

            With LVDetails.Items
                For iCounter1 = 0 To .Count - 1
                    If .Item(iCounter1).Name <> String.Empty Then
                        Rs.Filter = "pj_id = " & GetIDFromKey((.Item(iCounter1).Name)).ToString.Trim
                    Else
                        Rs.AddNew()
                    End If
                    'Rs.Fields("PJ_SCH_ID").Value = ComboboxUtilities.GetComboSelectedItemId(cboSchools)
                    Try

                        Rs.Fields("PJ_SCH_ID").Value = Val(schoolid)
                        Rs.Fields("PJ_ARCHIVO").Value = txtFile.Text
                        Rs.Fields("pj_semester").Value = cboSemester.SelectedIndex
                        Rs.Fields("pj_grade").Value = Items(iCounter1 + 1).Grade
                        Rs.Fields("PJ_Section").Value = Items(iCounter1 + 1).Section
                        Rs.Fields("PJ_Total_Est").Value = Items(iCounter1 + 1).Students
                        Rs.Fields("PJ_LES").Value = Items(iCounter1 + 1).LES
                        Rs.Fields("pj_nv").Value = Items(iCounter1 + 1).NV
                        Rs.Fields("pj_ren").Value = Items(iCounter1 + 1).REN
                        Rs.Fields("pj_mat").Value = Items(iCounter1 + 1).MAT
                        Rs.Fields("PJ_CONS").Value = Items(iCounter1 + 1).Consultant1
                        Rs.Fields("PJ_TOLL1").Value = Items(iCounter1 + 1).Toll1
                        Rs.Fields("PJ_CONS2").Value = Items(iCounter1 + 1).Consultant2
                        Rs.Fields("PJ_TOLL2").Value = Items(iCounter1 + 1).Toll2
                        Rs.Fields("PJ_CONS3").Value = Items(iCounter1 + 1).Consultant3
                        Rs.Fields("PJ_serv_date").Value = Items(iCounter1 + 1).ServDate
                        Rs.Fields("pj_price").Value = Items(iCounter1 + 1).Price
                        Rs.Fields("pj_plugin").Value = Items(iCounter1 + 1).Plugin
                        Rs.Update()

                    Catch ex As Exception

                    End Try
                   

                    If .Item(iCounter1).Name = "" Then
                        .Item(iCounter1).Name = "P" & Rs.Fields("pj_id").Value
                    End If
                Next iCounter1
            End With

            If DeletedItems.Count() > 0 Then
                TheItem = Mid(DeletedItems.Item(1), 2)
                'Where = " PJ_ID = " & DeletedItems(1)
                Where = " PJ_ID = " & TheItem
                For iCounter1 = 2 To DeletedItems.Count()
                    TheItem = Mid(DeletedItems.Item(iCounter1), 2)
                    'Where = Where & " OR PJ_ID=" & DeletedItems(I)
                    Where &= " OR PJ_ID=" & TheItem
                Next iCounter1
                'Set Cm.ActiveConnection = Cn
                Cn2.Open(Config.ConnectionString)
                Cn2.Execute("DELETE FROM PreJobs WHERE " & Where)
                'Cm.CommandText = "DELETE FROM PreJobs WHERE " & Where
                'Cm.Execute
                Cn2.Close()
            End If
            Rs.Close()
            Cn.Close()

            ' -- Alco Sledgehammer
            If Me.chkAcomodo.CheckState = System.Windows.Forms.CheckState.Checked Then
                myJobType = 3
            ElseIf Me.chkEntrance.CheckState = System.Windows.Forms.CheckState.Checked Then
                myJobType = 1
            ElseIf Me.chkPEP.CheckState = System.Windows.Forms.CheckState.Checked Then
                myJobType = 4
            Else ' -- Regular                
                myJobType = 2
            End If

            Cn3.Open(Config.ConnectionString)
            sQuery = "UPDATE schools SET sc_labels = " & Label & ", sc_inf_indiv = " &
                Ind & ", sc_job_type=" & CShort(myJobType) & " where sc_id=" & VB6.GetItemData(cboSchools, cboSchools.SelectedIndex)
            Cn3.Execute(sQuery)
            ' --
        End Sub
#End Region
#Region "LEVEL THREE ROUTINES"
        'UPGRADE_WARNING: Event chkPEP.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'

        Private Sub chkPEP_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkPEP.CheckStateChanged

            If CBool(chkPEP.CheckState) Then
                'Call SelectItemWithID(cboLes, 52)
                'Call SelectItemWithID(cboRen, 52)
                'Call SelectItemWithID(cboMat, 52)
                'Call SelectItemWithID(cboNV, 52)
                ComboboxUtilities.SetComboItemWithId(cboLes, "52")
                ComboboxUtilities.SetComboItemWithId(cboRen, "52")
                ComboboxUtilities.SetComboItemWithId(cboMat, "52")
                ComboboxUtilities.SetComboItemWithId(cboNV, "52")

                chkAcomodo.CheckState = System.Windows.Forms.CheckState.Unchecked
                chkEntrance.CheckState = System.Windows.Forms.CheckState.Unchecked
            End If

            cboLes.Enabled = Not (CBool(chkPEP.CheckState))
            cboRen.Enabled = Not (CBool(chkPEP.CheckState))
            cboMat.Enabled = Not (CBool(chkPEP.CheckState))
            cboNV.Enabled = Not (CBool(chkPEP.CheckState))
            SetExam()
        End Sub

        Function GetSchoolJobType(ByRef iSchID As Integer) As String
            'Dim Cn As New ADODB.Connection
            'Dim Rs As New ADODB.Recordset

            'OpenConnection(Cn, Config.ConnectionString)

            'Rs.Open("Select sc_job_type From schools Where sc_Id=" & iSchID, Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
            'If Not Rs.EOF Then
            '    GetSchoolJobType = Rs.Fields("sc_job_type").Value
            'Else                
            '    GetSchoolJobType = 2
            'End If
            'Rs.Close()
            'Cn.Close()

            Dim sQuery As String = "Select sc_job_type From schools Where sc_Id=" & iSchID.ToString.Trim
            Dim dt As System.Data.DataTable = GlobalResources.ExecuteDataTable(sQuery)
            If (dt.Rows.Count > 0) Then
                Return dt.Rows(0)("sc_job_type").ToString()
            End If
            Return "2"
        End Function

#End Region
#Region "LEVEL FOUR ROUTINES"
        Sub SetExam(Optional ByRef def_id As Integer = 0)
            Dim sExam As String
            Dim iSemester As Short
            Dim sNV, sLES, sREN, sMat As String

            If CBool(chkPEP.CheckState) Then

            ElseIf cboGrade.Text <> "" And cboSemester.Text <> "" Then
                iSemester = cboSemester.SelectedIndex
                Call GetDefaultsValues(cboGrade.SelectedIndex, iSemester, sLES, sREN, sMat, sNV, sPluginName, def_id, "prejob")
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
#End Region

#Region "Unknown/Unused Routines"
        Private Sub txtFile_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFile.Enter
            Call System.Windows.Forms.SendKeys.Send("{HOME}+{END}")
        End Sub
        Private Sub txtPrice_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPrice.Enter
            Call System.Windows.Forms.SendKeys.Send("{HOME}+{END}")
        End Sub
        Private Sub txtPrice_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtPrice.Validating
            Dim Cancel As Boolean = eventArgs.Cancel

            If IsNumeric(Me.txtPrice.Text) Then
                Me.txtPrice.Text = FormatCurrency(Me.txtPrice.Text)
            End If
            eventArgs.Cancel = Cancel
        End Sub
        Private Sub txtSection_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSection.Enter
            Call System.Windows.Forms.SendKeys.Send("{HOME}+{END}")
        End Sub
        Private Sub txtTotalStudents_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTotalStudents.Enter
            Call System.Windows.Forms.SendKeys.Send("{HOME}+{END}")
        End Sub

        'Private Sub txtDate_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        '    Call System.Windows.Forms.SendKeys.Send("{HOME}+{END}")
        'End Sub

        'Private Sub txtDate_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        '    Dim Cancel As Boolean = eventArgs.Cancel

        '    If Val(Me.txtDate1.Text) > 0 And IsNumeric(Me.txtDate1.Text) Then
        '        Me.txtDate1.Text = VB6.Format(Me.txtDate1.Text, "##/##/####")
        '    End If

        '    If Me.txtDate1.Text <> "" And Not IsDBNull(Me.txtDate1.Text) Then

        '        If IsDate(Me.txtDate1.Text) = False Then
        '            MsgBox("Enter a valid date format")
        '            Cancel = True
        '        End If
        '    End If
        '    eventArgs.Cancel = Cancel
        'End Sub

#End Region

    End Class
End Namespace