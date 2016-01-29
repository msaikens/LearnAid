Option Strict Off
Option Explicit On
Imports ADODB
Imports Microsoft.VisualBasic.Compatibility

Namespace Forms.MasterForms
    Friend Class frmEditJob
        Inherits System.Windows.Forms.Form
        Public iJobID As Integer
        Public sPluginName As String
        'Dim cFlatCtrls As New FCtrls
#Region "LEVEL ONE ROUTINES"
        Private Sub frmEditJob_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
            'cFlatCtrls.SetFormControls Me


            Call LoadData()
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
        'UPGRADE_WARNING: Event cboGrade.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub cboGrade_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboGrade.SelectedIndexChanged
            SetExam()
        End Sub
        Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
            Me.Close()
        End Sub
        Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
            Dim VC As New ValidateClass

            If VC.ValidateForm(Me) Then
                Call UpdateJob()
                Me.Close()
            End If
        End Sub

        'UPGRADE_WARNING: Event optFirstSemester.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub optFirstSemester_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optFirstSemester.CheckedChanged
            If eventSender.Checked Then
                SetExam()
            End If
        End Sub
        'UPGRADE_WARNING: Event optSecondSemester.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub optSecondSemester_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optSecondSemester.CheckedChanged
            If eventSender.Checked Then
                SetExam()
            End If
        End Sub
        Private Sub txtDate_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtDate.Validating
            Dim Cancel As Boolean = eventArgs.Cancel

            If ToDate(txtDate.Text) = "" Then
                MsgBox("Enter a valid date format")
                Cancel = True
            Else
                txtDate.Text = ToDate(txtDate.Text)
            End If
            eventArgs.Cancel = Cancel
        End Sub
        Private Sub txtPrice_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtPrice.Validating
            Dim Cancel As Boolean = eventArgs.Cancel
            Me.txtPrice.Text = FormatCurrency(Val(Me.txtPrice.Text))
            eventArgs.Cancel = Cancel
        End Sub
#End Region
#Region "LEVEL TWO ROUTINES"
        Sub LoadData()
            Dim sQuery As String
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset
            Dim RsCon As New Recordset
            Dim RsJobCons As New Recordset
            Dim aid As Boolean
            Dim CurrPlugin As String
            Dim DefPlugin As String

            Dim pep As Boolean
            Dim intval As Integer

            OpenConnection(Cn, Config.ConnectionString)


            Call FillConsultantCBox(cboConsultant)
            Call FillConsultantCBox(cboConsultant2)
            Call FillConsultantCBox(cboConsultant3)
            Call FillGradeCbox(cboGrade)
            Call FillSchoolCbox(cboSchools)
            Call FillBatteryCbox(cboBattery)
            Call FillNVCbox(cboNV)
            Call FillLESCbox(cboLes)
            Call FillMATCbox(cboMat)
            Call FillRENCbox(cboRen)

            '************************<<QUERY>>*************************************************
            sQuery = "SELECT Jobs.*, Claves3.CL_TYPE AS MAT_TYPE, " & "Claves2.CL_TYPE AS REN_TYPE, " & "Claves1.CL_TYPE AS NV_TYPE, " _
            & "Claves.CL_TYPE AS LES_TYPE " & "FROM Jobs LEFT OUTER JOIN " & "Claves ON Jobs.J_LES = Claves.CL_ID LEFT OUTER JOIN " _
            & "Claves Claves1 ON " & "Jobs.J_NV = Claves1.CL_ID LEFT OUTER JOIN " & "Claves Claves2 ON " & "Jobs.J_REN = Claves2.CL_ID LEFT OUTER JOIN " _
            & "Claves Claves3 ON Jobs.J_MAT = Claves3.CL_ID " & "Where Jobs.J_ID = " & Me.iJobID.ToString
            '************************<<QUERY>>*************************************************

            ' Claves3.CL_TYPE = MAT_TYPE
            ' Claves2.CL_TYPE = REN_TYPE
            ' Claves1.CL_TYPE = NV_TYPE
            ' Claves.CL_TYPE = LES_TYPE
            ' Jobs.J_LES = Claves.CL_ID
            ' Jobs.J_NV = Claves1.CL_ID
            ' Jobs.J_REN = Claves2.CL_ID
            ' Jobs.J_MAT = Claves3.CL_ID
            ' Jobs.J_ID = (SOFTWARE) iJobID.ToString



            Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            If Not Rs.EOF Then
                ' lblJobType.Text = Rs.Fields("j_type").Value.ToString
                Select Case Rs.Fields("j_type").Value.ToString
                    Case 0
                        lblJobType.Text = "Office Testing"
                    Case 1
                        lblJobType.Text = "Entrance"
                    Case 2
                        lblJobType.Text = "Regular"

                End Select

                If Rs.Fields("J_SERV_DATE").Value.ToString = String.Empty Then
                    Me.txtDate.Text = Nothing
                Else
                    Me.txtDate.Text = Rs.Fields("J_Serv_Date").Value.ToString
                End If
                'Call SelectItemWithID(cboSchools, GetValue(Rs.Fields("J_SCH")))
                cboSchools.SelectedIndex = CInt(cboSchools.FindString(Rs.Fields("j_sch").Value.ToString))
                'MessageBox.Show(Rs.Fields("j_sch").Value.ToString)
                Call SelectItemWithID(cboGrade, GetValue(Rs.Fields("J_GRADE")))
                'cboGrade.SelectedValue = GetValue(Rs.Fields("J_GRADE"))



                Me.txtSection.Text = GetValue(Rs.Fields("J_SEC"))

                If GetValue(Rs.Fields("J_SEM")) = 1 Then
                    Me.optFirstSemester.Checked = True
                    Me.optSecondSemester.Checked = False
                Else
                    Me.optFirstSemester.Checked = False
                    Me.optSecondSemester.Checked = True
                End If



                If GetValue(Rs.Fields("j_plugin")) <> String.Empty Then

                    DefPlugin = Rs.Fields("J_Plugin").Value.ToString.Trim


                    cboBattery.SelectedIndex = cboBattery.FindString(Rs.Fields("j_plugin").Value.ToString.Trim)

                    cboBattery.SelectedText = Rs.Fields("j_plugin").Value.ToString.ToUpper
                    'Added 07/29/15 George White
                    CurrPlugin = cboBattery.Text.Trim
                    If Split(CurrPlugin, "|")(0) = DefPlugin Then
                        cboBattery.Text = DefPlugin
                    End If
                    'Me.cboBattery.Text = DefPlugin
                    'For iCounter1 = 0 To Me.cboBattery.Items.Count - 1
                    '    cboBattery.SelectedIndex = iCounter1
                    '    CurrPlugin = cboBattery.SelectedValue
                    '    If Split(CurrPlugin, "|")(0) = DefPlugin Then
                    '        Me.cboBattery.Text = CurrPlugin
                    '    End If
                    'Next iCounter1
                    '        If DefPlugin = "PEPV" Then
                    '            Me.cboBattery.AddItem "PEPV"
                    '            Me.cboBattery.Text = DefPlugin
                    '        End If
                End If

                Me.txtTotalStudents.Text = GetValue(Rs.Fields("J_TOTAL_EST"))

                'Call SelectItemWithID((Me.cboConsultant), GetValue(Rs.Fields("J_CONS"), 0))

                RsCon.Open("SELECT CON_ID, CON_NAME, CON_LNAME1 FROM CONSULTANTS ORDER BY CON_ID ASC", Cn)
                RsJobCons.Open("SELECT J_CONS,J_CONS2,J_CONS3 FROM Jobs WHERE J_ID = " & Me.iJobID.ToString, Cn)

                While Not RsCon.EOF
                    If RsJobCons.Fields("J_CONS").Value = RsCon.Fields("CON_ID").Value Then
                        Dim tmpstr As String = RsCon.Fields("CON_NAME").Value.ToString.Trim + " " + RsCon.Fields("CON_LNAME1").Value.ToString.Trim
                        cboConsultant.SelectedIndex = cboConsultant.FindString(tmpstr)
                    End If
                    If RsJobCons.Fields("J_CONS2").Value = RsCon.Fields("CON_ID").Value Then
                        Dim tmpstr2 As String = RsCon.Fields("CON_NAME").Value.ToString.Trim + " " + RsCon.Fields("CON_LNAME1").Value.ToString.Trim
                        cboConsultant2.SelectedIndex = cboConsultant2.FindString(tmpstr2)
                    End If
                    If RsJobCons.Fields("J_CONS3").Value = RsCon.Fields("CON_ID").Value Then
                        Dim tmpstr3 As String = RsCon.Fields("CON_NAME").Value.ToString.Trim + " " + RsCon.Fields("CON_LNAME1").Value.ToString.Trim
                        cboConsultant3.SelectedIndex = cboConsultant3.FindString(tmpstr3)
                    End If
                    RsCon.MoveNext()
                End While
                RsCon.Close()
                RsJobCons.Close()
                'Me.cboConsultant.SelectedIndex = CUInt(Rs.Fields("J_CONS").Value)
                'Me.cboConsultant2.SelectedText = CUInt(Rs.Fields("J_CONS2").Value)
                'Me.cboConsultant3.SelectedText = CUInt(Rs.Fields("J_CONS3").Value)
                'Me.txtFile.Text = GetValue(Rs.Fields("J_ARCHIVO"))
                'If GetValue(Rs.Fields("j_plugin")) = "BATAIDR" Or GetValue(Rs.Fields("j_plugin")) = "BATPRE1" Then
                '    aid = True
                'Else
                '    aid = False
                'End If
                'pep = (GetValue(Rs.Fields("j_plugin")) = "PEPV")

                'Call FillNVCbox(cboNV, aid, pep)
                'Call FillLESCbox(cboLes, aid, pep)
                'Call FillMATCbox(cboMat, aid, pep)
                'Call FillRENCbox(cboRen, aid, pep)

                'If Rs.Fields("j_plugin").Value.ToString = "BATAIDR" Then
                '    '    Call SetValueToCBox(cboLes, "AID")
                '    '    'cboLes.SelectedText = "AID"
                '    '    Call SetValueToCBox(cboNV, "AID")
                '    '    'cboNV.SelectedText = "AID"
                '    '    Call SetValueToCBox(cboRen, "AID")
                '    '    'cboRen.SelectedText = "AID"
                '    '    Call SetValueToCBox(cboMat, "AID")
                '    '    'cboMat.SelectedText = "AID"
                '    Call SetValueToCBox(cboLes, GetValue(Rs.Fields("LES_TYPE")))
                '    cboLes.SelectedIndex = cboLes.FindStringExact(GetValue(Rs.Fields("LES_TYPE")))
                '    Call SetValueToCBox(cboNV, GetValue(Rs.Fields("NV_TYPE")))
                '    cboNV.SelectedIndex = cboNV.FindStringExact(GetValue(Rs.Fields("NV_TYPE")))
                '    Call SetValueToCBox(cboRen, GetValue(Rs.Fields("REN_TYPE")))
                '    cboRen.SelectedIndex = cboRen.FindStringExact(GetValue(Rs.Fields("REN_TYPE")))
                '    'MessageBox.Show((Rs.Fields("REN_TYPE").Value.ToString))
                '    Call SetValueToCBox(cboMat, GetValue(Rs.Fields("MAT_TYPE")))
                '    cboMat.SelectedIndex = cboMat.FindStringExact(GetValue(Rs.Fields("MAT_TYPE")))
                'ElseIf Rs.Fields("j_plugin").Value.ToString = "BATPRE1" Then
                '    '    Call SetValueToCBox(cboLes, "PRE-1")
                '    '    'cboLes.SelectedText = "PRE-1"
                '    '    Call SetValueToCBox(cboNV, "PRE-1")
                '    '    'cboNV.SelectedText = "PRE-1"
                '    '    Call SetValueToCBox(cboRen, "PRE-1")
                '    '    'cboRen.SelectedText = "PRE-1"
                '    '    Call SetValueToCBox(cboMat, "PRE-1")
                '    '    'cboMat.SelectedText = "PRE-1"
                '    Call SetValueToCBox(cboLes, GetValue(Rs.Fields("LES_TYPE")))
                '    cboLes.SelectedIndex = cboLes.FindStringExact(GetValue(Rs.Fields("LES_TYPE")))
                '    Call SetValueToCBox(cboNV, GetValue(Rs.Fields("NV_TYPE")))
                '    cboNV.SelectedIndex = cboNV.FindStringExact(GetValue(Rs.Fields("NV_TYPE")))
                '    Call SetValueToCBox(cboRen, GetValue(Rs.Fields("REN_TYPE")))
                '    cboRen.SelectedIndex = cboRen.FindStringExact(GetValue(Rs.Fields("REN_TYPE")))
                '    'MessageBox.Show((Rs.Fields("REN_TYPE").Value.ToString))
                '    Call SetValueToCBox(cboMat, GetValue(Rs.Fields("MAT_TYPE")))
                '    cboMat.SelectedIndex = cboMat.FindStringExact(GetValue(Rs.Fields("MAT_TYPE")))
                'ElseIf Rs.Fields("j_plugin").Value.ToString = "PEPV" Then

                '    Me.cboLes.Enabled = True
                '    Me.cboRen.Enabled = True
                '    Me.cboMat.Enabled = True
                '    Me.cboNV.Enabled = True
                '    'Call SetValueToCBox(cboLes, "PEPV")
                '    cboLes.SelectedText = "PEPV"
                '    'Call SetValueToCBox(cboNV, "PEPV")
                '    cboNV.SelectedText = "PEPV"
                '    'Call SetValueToCBox(cboRen, "PEPV")

                '    cboRen.SelectedText = "PEPV"
                '    'Call SetValueToCBox(cboMat, "PEPV")
                '    cboMat.SelectedText = "PEPV"
                '    Me.lblJobType.Text = "PEPV"
                'Else
                '    Call SetValueToCBox(cboLes, GetValue(Rs.Fields("LES_TYPE")))
                '    cboLes.SelectedIndex = cboLes.FindStringExact(GetValue(Rs.Fields("LES_TYPE")))
                '    Call SetValueToCBox(cboNV, GetValue(Rs.Fields("NV_TYPE")))
                '    cboNV.SelectedIndex = cboNV.FindStringExact(GetValue(Rs.Fields("NV_TYPE")))
                '    Call SetValueToCBox(cboRen, GetValue(Rs.Fields("REN_TYPE")))
                '    cboRen.SelectedIndex = cboRen.FindStringExact(GetValue(Rs.Fields("REN_TYPE")))
                '    'MessageBox.Show((Rs.Fields("REN_TYPE").Value.ToString))
                '    Call SetValueToCBox(cboMat, GetValue(Rs.Fields("MAT_TYPE")))
                '    cboMat.SelectedIndex = cboMat.FindStringExact(GetValue(Rs.Fields("MAT_TYPE")))
                'End If

                sPluginName = GetValue(Rs.Fields("j_plugin"), "")

                Me.txtPrice.Text = FormatCurrency(GetValue(Rs.Fields("J_price"), 0))
                'Me.txtDate.Text = VB6.Format(Rs.Fields("J_Serv_Date").Value, "mm/dd/yyyy")
                'Me.txtDate.Text = Convert.ToDateTime(Rs.Fields("J_Serv_Date").Value).ToShortDateString()
                Me.chkToll1.CheckState = IIf(Rs.Fields("j_toll1").Value = True, 1, 0)
                Me.chkToll2.CheckState = IIf(Rs.Fields("j_toll2").Value = True, 1, 0)
                '//////////////////////////////////////////////////////////
                If GetValue(Rs.Fields("j_type")) = 0 Then
                    Me.cboSchools.Enabled = True
                    Me.cboSchools.Tag = ""
                    Me.cboConsultant3.Enabled = False
                    Me.cboConsultant3.Tag = ""
                    Me.cboConsultant2.Enabled = False
                    Me.cboConsultant2.Tag = ""
                    Me.chkToll1.Enabled = False
                    Me.chkToll2.Enabled = False
                    Me.txtPrice.Enabled = False
                Else
                    Me.cboConsultant.Enabled = True
                    Me.cboConsultant2.Enabled = True
                    Me.cboConsultant3.Enabled = True
                    Me.chkToll1.Enabled = True
                    Me.chkToll2.Enabled = True
                    Me.txtPrice.Enabled = True
                End If

                If GetValue(Rs.Fields("J_Status")) <> 0 Or GetValue(Rs.Fields("j_paid")) = True Or GetValue(Rs.Fields("j_printed")) = True Then
                    'Me.txtTotalStudents.Enabled = False
                    Me.cboNV.Enabled = True
                    Me.cboLes.Enabled = True
                    Me.cboRen.Enabled = True
                    Me.cboMat.Enabled = True
                    Me.optFirstSemester.Enabled = True
                    Me.optSecondSemester.Enabled = True
                    Me.cboGrade.Enabled = True
                    Me.txtFile.Enabled = True
                End If

                'The below statement is not necessary. We need controls enabled at all times.

                'If GetValue(Rs.Fields("j_paid")) = True Or GetValue(Rs.Fields("j_printed")) = True Then
                '    Me.cboConsultant.Enabled = False
                '    Me.cboConsultant2.Enabled = False
                '    Me.cboConsultant3.Enabled = False
                '    Me.txtPrice.Enabled = False
                '    Me.chkToll1.Enabled = False
                '    Me.chkToll2.Enabled = False
                '    Me.txtSection.Enabled = False
                '    Me.cboSchools.Enabled = False
                '    Me.txtDate.Enabled = False
                'End If
            Else
                MsgBox("Job not found.", MsgBoxStyle.Critical, "Error")
                Me.Close()
            End If
            Rs.Close()
            Cn.Close()
        End Sub
        Sub SetExam(Optional ByRef def_id As Integer = 0)
            'Dim sExam As String
            Dim iSemester As Short

            '*******Set the strings to nothing so the IDE doesn't throw a fit about null reference possibilities********

            Dim sNV As String = String.Empty
            Dim sLES As String = String.Empty
            Dim sREN As String = String.Empty
            Dim sMat As String = String.Empty

            If Me.optFirstSemester.Checked Then
                iSemester = 1
            Else
                iSemester = 2
            End If

            If cboGrade.Text <> "" Then
                'sExam = getDefExam(cboGrade.ItemData(cboGrade.ListIndex), iSemester)
                'Call GetDefaultsValues(sExam, iSemester, sLES, sREN, sMat, snv, sPluginName)
                Call GetDefaultsValues(cboGrade.SelectedIndex, iSemester, sLES, sREN, sMat, sNV, sPluginName, def_id, "editjob")
                Call SetValueToCBox(cboNV, sNV)
                Call SetValueToCBox(cboLes, sLES)
                Call SetValueToCBox(cboRen, sREN)
                Call SetValueToCBox(cboMat, sMat)
            End If
        End Sub
        Sub UpdateJob()
            Dim Cn As ADODB.Connection
            Dim Rs As ADODB.Recordset
            Cn = New ADODB.Connection
            Rs = New ADODB.Recordset

            Dim a As Integer
            Dim l As Integer
            Dim m As Integer
            Dim n As Integer
            Dim p As Integer
            Dim R As Integer
            Dim Sem As Integer

            Dim Cons As Integer
            Dim Cons2 As Integer
            Dim Cons3 As Integer
            Dim Grade As Integer
            Dim Sch As String
            Dim Toll1 As Boolean
            Dim Toll2 As Boolean


            If Me.cboSchools.SelectedIndex = -1 Then
                MessageBox.Show("Please Select a school", "cboSchools", MessageBoxButtons.OK)
                'Exit Sub
            End If
            If Me.cboGrade.SelectedIndex = -1 Then
                MessageBox.Show("Please Select a grade", "cboGrade", MessageBoxButtons.OK)
                'Exit Sub
            End If
            If Me.cboConsultant.SelectedIndex = -1 Then
                cboConsultant.SelectedIndex = 0
                'Exit Sub
            End If
            If Me.cboConsultant2.SelectedIndex = -1 Then
                cboConsultant2.SelectedIndex = 0
                'Exit Sub
            End If
            If Me.cboConsultant3.SelectedIndex = -1 Then
                cboConsultant3.SelectedIndex = 0
                'Exit Sub
            End If

            Sch = cboSchools.SelectedItem.ToString.Substring(0, cboSchools.SelectedItem.ToString.LastIndexOf(" -"))

            Grade = cboGrade.SelectedIndex - 1
            OpenConnection(Cn, Config.ConnectionString)

            Dim RsCon As Recordset = New Recordset
            RsCon.Open("SELECT CON_ID, CON_NAME, CON_LNAME1 FROM CONSULTANTS", Cn)
            While Not RsCon.EOF

                If cboConsultant.Text.Trim = RsCon.Fields("CON_NAME").Value.ToString.Trim + " " + RsCon.Fields("CON_LNAME1").Value.ToString.Trim Then
                    Cons = Integer.Parse(RsCon.Fields("CON_ID").Value.ToString)
                End If
                If cboConsultant2.Text.Trim = RsCon.Fields("CON_NAME").Value.ToString.Trim + " " + RsCon.Fields("CON_LNAME1").Value.ToString.Trim Then
                    Cons2 = Integer.Parse(RsCon.Fields("CON_ID").Value.ToString)
                End If
                If cboConsultant3.Text.Trim = RsCon.Fields("CON_NAME").Value.ToString.Trim + " " + RsCon.Fields("CON_LNAME1").Value.ToString.Trim Then
                    Cons3 = Integer.Parse(RsCon.Fields("CON_ID").Value.ToString)
                End If
                RsCon.MoveNext()
            End While
            'Cons = cboConsultant.SelectedIndex
            'Cons2 = cboConsultant2.SelectedIndex
            'Cons3 = cboConsultant3.SelectedIndex
            Toll1 = Me.chkToll1.CheckState
            Toll2 = Me.chkToll2.CheckState
            If Me.cboBattery.Text <> String.Empty Then
                sPluginName = Split(Me.cboBattery.Text, "|")(0)
            End If
            If cboLes.SelectedIndex = 51 Then
                l = 0
                R = 0
                m = 0
                n = 0
                a = 51
                p = 0
            ElseIf cboLes.SelectedIndex = 52 Then
                l = 0
                R = 0
                m = 0
                n = 0
                a = 0
                p = 52
            ElseIf cboLes.SelectedIndex = 69 Then  'PRE-1
                l = 0
                R = 0
                m = 0
                n = 0
                a = 69
                p = 0
            ElseIf sPluginName = "DIAL4-K" Then
                l = 0
                R = 0
                m = 0
                n = 0
                a = 88
                p = 0
            ElseIf sPluginName = "DIAL4-PK" Then
                l = 0
                R = 0
                m = 0
                n = 0
                a = 89
                p = 0
            ElseIf sPluginName = "DIAL4-PPK" Then
                l = 0
                R = 0
                m = 0
                n = 0
                a = 90
                p = 0
            ElseIf sPluginName = "DIAL4-PPK2" Then
                l = 0
                R = 0
                m = 0
                n = 0
                a = 110
                p = 0
            Else
                l = cboLes.SelectedIndex
                n = cboNV.SelectedIndex
                R = cboRen.SelectedIndex
                m = cboMat.SelectedIndex
                a = 0
            End If

            If Me.optFirstSemester.Checked Then
                Sem = 1
            Else
                Sem = 2
            End If


            Dim RsC As New ADODB.Recordset
            '============QUERY============'

            Rs.Open("SELECT * FROM Jobs WHERE J_ID =" & iJobID.ToString.Trim, Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
            RsC.Open("SELECT CL_ID, CL_TYPE FROM Claves", Cn)
            '============END QUERY============'

            'RsC.Open("SELECT CL_TYPE, CL_ID FROM Claves", Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
            If Not Rs.EOF Then
                Rs.Fields("J_SCH").Value = Sch
                Rs.Fields("J_GRADE").Value = Grade
                Rs.Fields("J_SEC").Value = Me.txtSection.Text
                Rs.Fields("J_SEM").Value = Sem
                Rs.Fields("J_TOTAL_EST").Value = Val(Me.txtTotalStudents.Text)
                Rs.Fields("J_CONS").Value = Cons
                Rs.Fields("j_toll1").Value = Toll1
                Rs.Fields("J_CONS2").Value = Cons2
                Rs.Fields("j_toll2").Value = Toll2
                Rs.Fields("J_CONS3").Value = Cons3
                If cboBattery.SelectedIndex = -1 Then
                    cboBattery.SelectedIndex = cboBattery.FindStringExact(Rs.Fields("J_PLUGIN").Value.ToString)
                End If
                'If l > 0 Then
                '    Rs.Fields("J_LES").Value = l
                'Else
                '    Rs.Fields("J_LES").Value = System.DBNull.Value
                'End If
                'If n > 0 Then
                '    Rs.Fields("J_NV").Value = n
                'Else
                '    Rs.Fields("J_NV").Value = System.DBNull.Value
                'End If
                'If R > 0 Then
                '    Rs.Fields("J_REN").Value = R
                'Else
                '    Rs.Fields("J_REN").Value = System.DBNull.Value
                'End If
                'If m > 0 Then
                '    Rs.Fields("J_MAT").Value = m
                'Else
                '    Rs.Fields("J_MAT").Value = System.DBNull.Value
                'End If
                If a > 0 Then
                    Rs.Fields("j_AID").Value = a
                Else
                    Rs.Fields("j_AID").Value = System.DBNull.Value
                End If
                If p > 0 Then
                    Rs.Fields("j_pepv").Value = p
                Else
                    Rs.Fields("j_pepv").Value = 0
                End If
                'lS = cboLes.SelectedText.ToString.Trim
                'mS = cboMat.SelectedText.ToString.Trim
                'nS = cboNV.SelectedText.ToString.Trim
                'rSt = cboRen.SelectedText.ToString.Trim
                Dim num As Integer = 1
                While Not RsC.EOF
                    Application.DoEvents()
                    If cboNV.Text.ToString = RsC.Fields("cl_type").Value.ToString Then
                        Rs.Fields("j_nv").Value = RsC.Fields("cl_id").Value
                    End If
                    If cboLes.Text.ToString = RsC.Fields("cl_type").Value.ToString Then
                        Rs.Fields("j_les").Value = RsC.Fields("cl_id").Value
                    End If
                    If cboRen.Text.ToString = RsC.Fields("cl_type").Value.ToString Then
                        Rs.Fields("j_ren").Value = RsC.Fields("cl_id").Value
                    End If
                    If cboMat.Text.ToString = RsC.Fields("cl_type").Value.ToString Then
                        Rs.Fields("j_mat").Value = RsC.Fields("cl_id").Value
                    End If
                    RsC.MoveNext()
                    If cboNV.SelectedIndex = 0 Then
                        Rs.Fields("j_nv").Value = DBNull.Value
                    End If
                    If cboLes.SelectedIndex = 0 Then
                        Rs.Fields("j_les").Value = DBNull.Value
                    End If
                    If cboRen.SelectedIndex = 0 Then
                        Rs.Fields("j_ren").Value = DBNull.Value
                    End If
                    If cboMat.SelectedIndex = 0 Then
                        Rs.Fields("j_mat").Value = DBNull.Value
                    End If
                End While

                Rs.Fields("J_ARCHIVO").Value = Me.txtFile.Text

                Rs.Fields("j_plugin").Value = sPluginName
                If Me.txtPrice.Text = String.Empty Then
                    Me.txtPrice.Text = "0.00"
                End If
                Rs.Fields("J_price").Value = CDec(Me.txtPrice.Text)
                If Me.txtDate.Text = "" Then
                    Rs.Fields("J_Serv_Date").Value = Date.Now
                Else
                    Rs.Fields("J_Serv_Date").Value = Me.txtDate.Text
                End If
                Rs.Update()

            End If
            Rs.Close()
            RsC.Close()
            Cn.Close()
        End Sub
#End Region


        
    End Class
End Namespace