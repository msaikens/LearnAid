Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.Compatibility
Imports learnAid.Forms.AccountingForms
Friend Class frmAdjustment
	Inherits System.Windows.Forms.Form
    Dim bFirstTime As Boolean
    Private _school As String

    Public Property Number() As String
        Get
            Return _school
        End Get
        Set(ByVal value As String)
            _school = value
        End Set
    End Property

#Region "LEVEL ONE ROUTINES"
    'Called By: frmNomina.cmdAdjustments_Click()
    'Called By: frmNomina.lvActivity_DoubleClick()
    Private Sub frmAdjustment_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        bFirstTime = True
        cboSchools.Text = _school
    End Sub
    'UPGRADE_WARNING: Form event frmAdjustment.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmAdjustment_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        Dim iActivityKey As String = ""
        Dim iExaminerID As String = ""
        If bFirstTime Then
            If Not frmnomina.lvExaminers.FocusedItem Is Nothing Then
                iExaminerID = Split(frmnomina.lvExaminers.FocusedItem.Name, "_")(1)
            End If
            If Not frmnomina.lvActivity.FocusedItem Is Nothing Then
                iActivityKey = Split(frmnomina.lvActivity.FocusedItem.Name, "_")(2)
            End If
            If Me.Tag = Nothing Then
                Me.Tag = "A"
            End If
            Select Case Me.Tag
                Case "E"
                    FillTypeCbo()
                    With objNomina.Examiner(iExaminerID).Activity("a_" & iActivityKey)
                        Me.txtServiceDate.Text = CStr(.ServiceDate)
                        'Me.txtSchName = .SchoolName
                        Call LA_Declarations.SetValueToCBox(cboSchools, .SchoolName)
                        Call LA_Declarations.SelectItemWithID((Me.cboServType), .TypeID)
                        Me.txtAmount.Text = FormatCurrency(.Amount, 2)
                        Me.txtComments.Text = .ServiceComments
                    End With
                Case "A"
                    FillTypeCbo()
                    Me.txtAmount.Text = "$0.00"
                    Me.txtComments.Text = ""
                    cboSchools.SelectedIndex = Val(GetSetting("LearnAid", "Nomina", "AdjSchool", "-1"))
                    'Me.txtSCHName = ""
                    'Call SelectItemWithID(cboSchools, 0)
                    Me.txtServiceDate.Text = ""
                    ' Me.cboServType.ListIndex = 1
            End Select
            bFirstTime = False
        End If
    End Sub
    Private Sub cboSchools_MouseClick(sender As Object, e As MouseEventArgs) Handles cboSchools.MouseClick
        Call LA_Declarations.FillSchoolCbox((Me.cboSchools))
        cboSchools.Text = _school
    End Sub
    Private Sub cmdCalendar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim a As Object = Nothing
        ShowCalendar(a, Today)
        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Me.txtServiceDate.Text = a
    End Sub
    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Dim iExaminerID As String
        Dim iNTRecID As String
        Dim NTnum As String
        Dim LVITEM_Renamed As System.Windows.Forms.ListViewItem
        Dim RndNum As String
        ' frmnomina.lvActivity.SelectedItem.Key
        ' --
        ' returns a string with format s_n1_n2
        ' where n1 is the db id for that consultant
        ' and n2 is the list view position of this
        ' item within lvactivity

        iExaminerID = Split(frmnomina.lvExaminers.FocusedItem.Name, "_")(1)

        If Not IsDate(Me.txtServiceDate.Text) Then
            MsgBox("Invalid Service Date", MsgBoxStyle.OkOnly, "Nomina")
            Exit Sub
        End If

        If Me.Tag = "E" Then
            ' -- Update Object
            iNTRecID = Split(frmnomina.lvActivity.FocusedItem.Name, "_")(2)

            With objNomina.Examiner(iExaminerID).Activity("a_" & iNTRecID)
                .Action = Me.Tag
                .Amount = CDbl(Me.txtAmount.Text)
                '.SchoolName = Me.txtSchName
                .SchoolName = Me.cboSchools.Text
                .ServiceComments = Me.txtComments
                .ServiceDate = CDate(Me.txtServiceDate.Text)
                .ServiceType = Me.cboServType.SelectedIndex
                .TypeID = Me.cboServType.SelectedIndex
            End With

            ' -- Object UI
            With frmnomina.lvActivity.FocusedItem
                .Tag = Me.Tag
                .Text = Me.txtServiceDate.Text
                '.SubItems(1) = Me.txtSchName
                'UPGRADE_WARNING: Lower bound of collection frmnomina.lvActivity.SelectedItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                If frmnomina.lvActivity.FocusedItem.SubItems.Count > 1 Then
                    frmnomina.lvActivity.FocusedItem.SubItems(1).Text = Me.cboSchools.Text
                Else
                    frmnomina.lvActivity.FocusedItem.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.cboSchools.Text))
                End If
                'UPGRADE_WARNING: Lower bound of collection frmnomina.lvActivity.SelectedItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                If frmnomina.lvActivity.FocusedItem.SubItems.Count > 2 Then
                    frmnomina.lvActivity.FocusedItem.SubItems(2).Text = Me.cboServType.Text
                Else
                    frmnomina.lvActivity.FocusedItem.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.cboServType.Text))
                End If
                'UPGRADE_WARNING: Lower bound of collection frmnomina.lvActivity.SelectedItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                If frmnomina.lvActivity.FocusedItem.SubItems.Count > 3 Then
                    frmnomina.lvActivity.FocusedItem.SubItems(3).Text = FormatCurrency(Me.txtAmount.Text, 2)
                Else
                    frmnomina.lvActivity.FocusedItem.SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, FormatCurrency(Me.txtAmount.Text, 2)))
                End If
            End With
        Else
            ' -- 'New Object
            RndNum = LA_Declarations.GetXRandom(4)
            'UPGRADE_WARNING: Couldn't resolve default property of object NTnum. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            NTnum = LA_Declarations.GetNRandom(4)
            If Not cboServType.SelectedIndex = -1 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object RndNum. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                Call LA_Declarations.objNomina.Examiner(iExaminerID).Activity.Add(RndNum, (Me.txtServiceDate.Value), (Me.cboSchools).Text, "", VB6.GetItemData(Me.cboServType, cboServType.SelectedIndex), (Me.txtAmount), (Me.txtComments), (Me.cboServType.Text), 0, Me.Tag, VB6.GetItemData(cboServType, cboServType.SelectedIndex), "a_" & RndNum, True)
                ' -- Object UI
                With frmnomina.lvActivity
                    'UPGRADE_WARNING: Couldn't resolve default property of object iExaminerID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    LVITEM_Renamed = .Items.Add("a_" & iExaminerID & "_" & RndNum, Me.txtServiceDate.Text, "")
                    'LVITEM.SubItems(1) = Me.txtSCHName
                    'UPGRADE_WARNING: Lower bound of collection LVITEM_Renamed has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    If LVITEM_Renamed.SubItems.Count > 1 Then
                        LVITEM_Renamed.SubItems(1).Text = Me.cboSchools.Text
                    Else
                        LVITEM_Renamed.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.cboSchools.Text))
                    End If
                    'UPGRADE_WARNING: Lower bound of collection LVITEM_Renamed has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    If LVITEM_Renamed.SubItems.Count > 2 Then
                        LVITEM_Renamed.SubItems(2).Text = Me.cboServType.Text
                    Else
                        LVITEM_Renamed.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.cboServType.Text))
                    End If
                    'UPGRADE_WARNING: Lower bound of collection LVITEM_Renamed has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    If LVITEM_Renamed.SubItems.Count > 3 Then
                        LVITEM_Renamed.SubItems(3).Text = FormatCurrency(Me.txtAmount.Text, 2)
                    Else
                        LVITEM_Renamed.SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, FormatCurrency(Me.txtAmount.Text, 2)))
                    End If

                End With
            Else
                MsgBox("Invalid service type", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Adjustment")
                Exit Sub
            End If
        End If
        Call SaveSetting("LearnAid", "Nomina", "AdjSchool", CStr(Me.cboSchools.SelectedIndex))
        Me.Close()
    End Sub
    Private Sub txtAmount_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtAmount.Validating
        Dim Cancel As Boolean = eventArgs.Cancel
        If Trim(Me.txtAmount.Text) = "" Then
            Me.txtAmount.Text = FormatCurrency(0)
        Else
            Me.txtAmount.Text = Replace(Me.txtAmount.Text, "$", "")
            Me.txtAmount.Text = FormatCurrency(Val(Me.txtAmount.Text))
        End If
        eventArgs.Cancel = Cancel
    End Sub
    Private Sub txtServiceDate_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs)
        Dim Cancel As Boolean = eventArgs.Cancel

        If Len(Me.txtServiceDate.Text) = 0 Then
            GoTo EventExitSub
        End If

        If InStr(1, Me.txtServiceDate.Text, "/") = 0 Then
            MsgBox("Enter a valid date format", MsgBoxStyle.Information, "LearnAID")
            Cancel = True
            GoTo EventExitSub
        End If

        Me.txtServiceDate.Text = VB6.Format(Me.txtServiceDate.Text, "mm/dd/yyyy")
        If Me.txtServiceDate.Text <> "" And Not IsDBNull(Me.txtServiceDate.Text) Then

            If Len(Me.txtServiceDate.Text) > 10 Then
                MsgBox("Enter a valid date", MsgBoxStyle.Information, "LearnAID")
                Cancel = True
                GoTo EventExitSub
            End If

            If IsDate(Me.txtServiceDate.Text) = False Then
                MsgBox("Enter a valid date format", MsgBoxStyle.Information, "LearnAID")
                Cancel = True
                GoTo EventExitSub
            End If

            If Year(CDate(Me.txtServiceDate.Text)) <= 1980 Or Year(CDate(Me.txtServiceDate.Text)) >= 2200 Then
                MsgBox("Enter a valid year", MsgBoxStyle.Information, "LearnAID")
                Cancel = True
                GoTo EventExitSub
            End If
            txtServiceDate.Text = CStr(CDate(txtServiceDate.Text))
        End If
EventExitSub:
        eventArgs.Cancel = Cancel
    End Sub
#End Region
#Region "LEVEL TWO ROUTINES"
    'Called By: frmAdjustment.Activated
    Sub FillTypeCbo()
        Dim sQuery As String
        Dim Cn As ADODB.Connection
        Dim Rs As ADODB.Recordset

        Cn = New ADODB.Connection
        Rs = New ADODB.Recordset

        OpenConnection(Cn, Config.ConnectionString)

        sQuery = "select * from nomina_types order by ty_desc"

        Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)

        With cboServType
            .Items.Add("")
            While Not Rs.EOF
                .Items.Add(Rs.Fields("ty_desc").Value)
                VB6.SetItemData(cboServType, .Items.Count - 1, Rs.Fields("ty_id").Value)
                Rs.MoveNext()
            End While
        End With
        Rs.Close()
        Cn.Close()
    End Sub
    'Called By: cmdCalendar_Click()
    Sub ShowCalendar(ByRef TextField As Object, Optional ByVal StartupDate As Object = Nothing)
        'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
        If Not IsNothing(StartupDate) Then
            'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'

            '--Code Change-- jh' Load(frmGenericCal)
            Dim frmGenericCal As New frmGenericCal

            'UPGRADE_WARNING: Couldn't resolve default property of object StartupDate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            frmGenericCal.Calendar1.Value = StartupDate
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object StartupDate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            StartupDate = Today
        End If
        frmGenericCal.ShowDialog()
        'UPGRADE_WARNING: Couldn't resolve default property of object CalendarValue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object TextField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        TextField = CalendarValue
    End Sub
#End Region

End Class