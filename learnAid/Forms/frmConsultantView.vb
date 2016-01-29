Option Strict Off
Option Explicit On
'OBSOLETE
Imports learnAid.BLL
Imports Microsoft.VisualBasic.Compatibility
Imports learnAid.Forms.ReportForms

Friend Class frmConsultantView
    Inherits System.Windows.Forms.Form

    Sub Fill()
        Dim sQuery As String
        Dim Item As System.Windows.Forms.ListViewItem

        If Not IsDate(Me.txtConsFromDate.Text) Or Not IsDate(Me.txtConsToDate.Text) Then
            Exit Sub
        End If

        If Len(Me.txtConsFromDate.Text) < 8 Or Len(Me.txtConsToDate.Text) < 8 Then
            Exit Sub
        End If

        If Year(CDate(Me.txtConsFromDate.Text)) < 2000 Or Year(CDate(Me.txtConsToDate.Text)) < 2000 Then
            Exit Sub
        End If

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Select Case LoggedUser.UserType
            Case LA_Declarations.enumSecurityLevel.Consultant
                sQuery = "Select rep_id, rep_serv_date, rep_consult_status, rep_cons_id, sc_sch_name From Reports inner join Schools on rep_sch_id = sc_id WHERE rep_cons_id = " & LoggedUser.Cons_ID & " AND rep_serv_date >= '" & Me.txtConsFromDate.Text & " ' AND rep_serv_date <= '" & Me.txtConsToDate.Text & "' Order By rep_serv_date DESC"
            Case LA_Declarations.enumSecurityLevel.Administrator, LA_Declarations.enumSecurityLevel.DataEntry
                sQuery = "Select rep_id, rep_serv_date, rep_consult_status, rep_cons_id, sc_sch_name From Reports inner join Schools on rep_sch_id = sc_id WHERE rep_serv_date >= '" & Me.txtConsFromDate.Text & " ' AND rep_serv_date <= '" & Me.txtConsToDate.Text & "' Order By rep_serv_date DESC"
                'Rs.Open("Select rep_id, rep_serv_date, rep_consult_status, rep_cons_id, sc_sch_name From Reports inner join Schools on rep_sch_id = sc_id WHERE rep_serv_date >= '" & Me.txtConsFromDate.Text & " ' AND rep_serv_date <= '" & Me.txtConsToDate.Text & "' Order By rep_serv_date DESC", Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            Case LA_Declarations.enumSecurityLevel.accounting
                sQuery = "Select rep_id, rep_serv_date, rep_consult_status, rep_cons_id, sc_sch_name From Reports inner join Schools on rep_sch_id = sc_id WHERE rep_serv_date >= '" & Me.txtConsFromDate.Text & " ' AND rep_serv_date <= '" & Me.txtConsToDate.Text & "' Order By rep_serv_date DESC"
        End Select

        Dim dt As DataTable = GlobalResources.ExecuteDataTable(sQuery)
        Dim j As Integer = 0
        For j = 0 To dt.Rows.Count - 1

            Item = lvConsultant.Items.Item("A" & dt.Rows(j)("Rep_ID").ToString())

            If Item Is Nothing Then
                'Add the item
                Item = lvConsultant.Items.Add("A" & dt.Rows(j)("Rep_ID").ToString(), (dt.Rows(j)("rep_serv_date").ToString()), "")
                If Item.SubItems.Count > 1 Then
                    Item.SubItems(1).Text = (dt.Rows(j)("sc_sch_name").ToString())
                Else
                    Item.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, (dt.Rows(j)("sc_sch_name").ToString())))
                End If
                If Item.SubItems.Count > 2 Then
                    Item.SubItems(2).Text = (dt.Rows(j)("rep_consult_status").ToString())
                Else
                    Item.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, (dt.Rows(j)("rep_consult_status").ToString())))
                End If
                Item.Tag = "1"
            Else
                If Item.Text <> (dt.Rows(j)("rep_serv_date").ToString()) Or Item.SubItems(1).Text <> (dt.Rows(j)("sc_sch_name").ToString()) Or Item.SubItems(2).Text <> (dt.Rows(j)("rep_consult_status").ToString()) Then

                    Item.Text = (dt.Rows(j)("rep_serv_date").ToString())
                    If Item.SubItems.Count > 1 Then
                        Item.SubItems(1).Text = (dt.Rows(j)("sc_sch_name").ToString())
                    Else
                        Item.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, (dt.Rows(j)("sc_sch_name").ToString())))
                    End If
                    If Item.SubItems.Count > 2 Then
                        Item.SubItems(2).Text = (dt.Rows(j)("rep_consult_status").ToString())
                    Else
                        Item.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, (dt.Rows(j)("rep_consult_status").ToString())))
                    End If
                End If

            End If
            Item.Tag = "1"
        Next

        Dim i As Short
        i = 0

        While i < lvConsultant.Items.Count - 1
            i = i + 1
            If lvConsultant.Items.Item(i).Tag = "1" Then
                lvConsultant.Items.Item(i).Tag = ""
            Else
                lvConsultant.Items.RemoveAt(i)
                i = i - 1
            End If

        End While

        Me.Cursor = Cursors.Default

    End Sub

    Sub SetControls()
        Me.Frame1.Top = Toolbar.Height
        Me.Frame1.Left = 0
        Me.Frame1.Width = ClientRectangle.Width
        Me.Frame1.Height = VB6.TwipsToPixelsY(555)

        lvConsultant.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Toolbar.Height) + VB6.PixelsToTwipsY(Frame1.Height))
        lvConsultant.Left = 0
        lvConsultant.Width = ClientRectangle.Width
        lvConsultant.Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(ClientRectangle.Height) - VB6.PixelsToTwipsY(lvConsultant.Top))
    End Sub

    Private Sub cmdConsRefresh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdConsRefresh.Click

        Me.Fill()

    End Sub


    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        On Error GoTo err_rtn
        Dim a As Object

        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        a = Me.txtConsFromDate.Text
        ShowCalendar(a, Me.txtConsFromDate)
        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Me.txtConsFromDate.Text = a
err_cont:
        Exit Sub

err_rtn:
        MessageBox.Show("Cannot display calendar.", "Error", MessageBoxButtons.OK)
        Resume err_cont

    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        On Error GoTo err_rtn
        Dim a As Object

        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        a = Me.txtConsToDate.Text
        ShowCalendar(a, Me.txtConsToDate)
        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Me.txtConsToDate.Text = a
err_cont:
        Exit Sub

err_rtn:
        MessageBox.Show("Cannot display calendar.", "Error", MessageBoxButtons.OK)
        Resume err_cont

    End Sub


    Private Sub frmConsultantView_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Me.txtConsFromDate.Text = CStr(DateAdd(Microsoft.VisualBasic.DateInterval.Day, -120, Today))
        Me.txtConsToDate.Text = CStr(Today)

        Call Fill()

    End Sub

    'UPGRADE_WARNING: Event frmConsultantView.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmConsultantView_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        Call SetControls()
    End Sub


    Private Sub lvConsultant_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvConsultant.DoubleClick
        'Load frmInformeConsultoresMain
        'frmInformeConsultoresMain.txtDoS = Me.lvConsultant.SelectedItem.Text
        'frmInformeConsultoresMain.RepID = GetIDFromKey(lvConsultant.SelectedItem.Key)
        'frmInformeConsultoresMain.Show vbModal
        frmInformeConsultoresSectionsList.ShowDialog()
    End Sub


    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        Call Fill()
    End Sub


    Private Sub Toolbar_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar_Button1.Click, _Toolbar_Button2.Click, _Toolbar_Button3.Click
        Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
        'Dim lvAccounting As Object

        Dim Report As New frmReport
        Select Case Button.Name

            Case "OpenReport"
                If Not Me.lvConsultant.FocusedItem Is Nothing Then
                    'frmInformeConsultoresMain.Show
                    frmInformeConsultoresSectionsList.ShowDialog()
                End If
            Case "PrintReport"
                If Not Me.lvConsultant.FocusedItem Is Nothing Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object lvAccounting.SelectedItem. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'TODO:
                    ''Report.ReportID = GetIDFromKey(lvAccounting.SelectedItem.Key)
                    Report.ReportFile = Config.ReportsPath & "nomina.rpt"
                    Report.Show()
                End If
            Case "t1_d_s"
                frmT1Dist.Show()
        End Select


    End Sub


    Private Sub txtConsFromDate_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        Dim Cancel As Boolean = eventArgs.Cancel


        If Len(Me.txtConsFromDate.Text) = 0 Then
            GoTo EventExitSub
        End If

        If InStr(1, Me.txtConsFromDate.Text, "/") = 0 Then
            MsgBox("Enter a valid date format", MsgBoxStyle.Information, "LearnAID")
            Cancel = True
            GoTo EventExitSub
        End If

        Me.txtConsFromDate.Text = VB6.Format(Me.txtConsFromDate.Text, "mm/dd/yyyy")
        If Me.txtConsFromDate.Text <> "" And Not IsDBNull(Me.txtConsFromDate.Text) Then

            If Len(Me.txtConsFromDate.Text) > 10 Then
                MsgBox("Enter a valid date", MsgBoxStyle.Information, "LearnAID")
                Cancel = True
                GoTo EventExitSub
            End If


            If IsDate(Me.txtConsFromDate.Text) = False Then
                MsgBox("Enter a valid date format", MsgBoxStyle.Information, "LearnAID")
                Cancel = True
                GoTo EventExitSub
            End If

            If Year(CDate(Me.txtConsFromDate.Text)) <= 1980 Or Year(CDate(Me.txtConsFromDate.Text)) >= 2200 Then
                MsgBox("Enter a valid year", MsgBoxStyle.Information, "LearnAID")
                Cancel = True
                GoTo EventExitSub
            End If

            txtConsFromDate.Text = CStr(CDate(txtConsFromDate.Text))
        End If


EventExitSub:
        eventArgs.Cancel = Cancel
    End Sub


    Private Sub txtConsToDate_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        Dim Cancel As Boolean = eventArgs.Cancel


        If Len(Me.txtConsToDate.Text) = 0 Then
            GoTo EventExitSub
        End If

        If InStr(1, Me.txtConsToDate.Text, "/") = 0 Then
            MsgBox("Enter a valid date format", MsgBoxStyle.Information, "LearnAID")
            Cancel = True
            GoTo EventExitSub
        End If

        Me.txtConsToDate.Text = VB6.Format(Me.txtConsToDate.Text, "mm/dd/yyyy")
        If Me.txtConsToDate.Text <> "" And Not IsDBNull(Me.txtConsToDate.Text) Then

            If Len(Me.txtConsToDate.Text) > 10 Then
                MsgBox("Enter a valid date", MsgBoxStyle.Information, "LearnAID")
                Cancel = True
                GoTo EventExitSub
            End If


            If IsDate(Me.txtConsToDate.Text) = False Then
                MsgBox("Enter a valid date format", MsgBoxStyle.Information, "LearnAID")
                Cancel = True
                GoTo EventExitSub
            End If

            If Year(CDate(Me.txtConsToDate.Text)) <= 1980 Or Year(CDate(Me.txtConsToDate.Text)) >= 2200 Then
                MsgBox("Enter a valid year", MsgBoxStyle.Information, "LearnAID")
                Cancel = True
                GoTo EventExitSub
            End If

            txtConsToDate.Text = CStr(CDate(txtConsToDate.Text))
        End If

EventExitSub:
        eventArgs.Cancel = Cancel
    End Sub
End Class