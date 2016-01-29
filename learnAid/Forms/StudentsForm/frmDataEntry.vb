Option Strict Off
Option Explicit On

Imports learnAid.BLL
Imports learnAid.Forms.ReportForms
Imports Microsoft.VisualBasic.Compatibility

Namespace Forms.StudentsForm
    Friend Class frmDataEntry
        Inherits System.Windows.Forms.Form

        Dim aIdList As New List(Of String)
        Public bCancel As Boolean
        Private bEdit As Boolean
        Dim DragItemIndex As String
        Public iJobID As Integer
        Public iSchID As Integer
        Public StudentCount As Short
        Dim StudentsLoaded As Short

#Region "LEVEL ONE ROUTINES"
        Private Sub frmDataEntry_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
            bCancel = True
            Call LoadData()
            If Not LVNames.FocusedItem Is Nothing Then
                'LVNames.FocusedItem.Font = VB6.FontChangeBold(LVNames.FocusedItem.Font, True)
                LVNames.FocusedItem.Font = New Font(LVNames.FocusedItem.Font, FontStyle.Bold)
            End If
            cboAR.Items.Add("Todos")
            cboAR.Items.Add("Solo AR")
            cboAR.Items.Add("No AR")
            cboAR.SelectedIndex = 0
        End Sub
        'UPGRADE_WARNING: Form event frmDataEntry.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        Private Sub frmDataEntry_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
            Me.txtName.Focus()
        End Sub
        Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
            Me.Hide()
        End Sub
        Private Sub cmdCancel_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles cmdCancel.KeyDown
            Dim KeyCode As Short = eventArgs.KeyCode
            Dim Shift As Short = eventArgs.KeyData \ &H10000
            Dim Grid As Object
            'UPGRADE_WARNING: Couldn't resolve default property of object Grid.SetFocus. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If KeyCode = System.Windows.Forms.Keys.Tab Then
                Grid.SetFocus()
            End If
        End Sub
        Private Sub cmdCancel_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdCancel.MouseDown
            Dim Button As Short = eventArgs.Button \ &H100000
            Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
            Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
            Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
            Dim EditingName As Boolean = False
        End Sub
        Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
            If StudentCount = LVNames.Items.Count Then
                If bEdit = False Then
                    'If StudentsLoaded > 0 Then DeleteStudents()
                    'Call SaveNames()
                    Call UpdateNames()
                Else
                    Call UpdateNames()
                End If
                bCancel = False
                Me.Hide()
            Else
                MsgBox("Must enter " & StudentCount & " students.", MsgBoxStyle.Information)
                If MsgBox("Do you want save and close anyway?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Close List") = MsgBoxResult.Yes Then
                    bCancel = False
                    'If StudentsLoaded > 0 Then 'DeleteStudents
                    Call UpdateNames()
                    Me.Hide()
                End If
            End If
        End Sub
        Private Sub cmdOK_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles cmdOK.KeyDown
            Dim KeyCode As Short = eventArgs.KeyCode
            Dim Shift As Short = eventArgs.KeyData \ &H10000
            If KeyCode = System.Windows.Forms.Keys.Tab Then
                cmdCancel.Focus()
            End If
        End Sub
        Private Sub cmdOK_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdOK.MouseDown
            Dim Button As Short = eventArgs.Button \ &H100000
            Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
            Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
            Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
            Dim EditingName As Boolean = False
        End Sub
        Private Sub cmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrint.Click
            Dim Conn As New ADODB.Connection
            Dim Rec As New ADODB.Recordset

            'Dim Aus As String
            Dim FromAR As Integer
            Dim repName As String = ""
            Dim rptRep As New frmReport
            Dim ToAR As Integer

            'Dim CrxRpt As CRAXDRT.Report
            'Dim CrxApp As New CRAXDRT.Application

            Conn.Open(Config.ConnectionString)

            'save first
            Call UpdateNames()
            Me.LVNames.Items.Clear()
            Call LoadData()

            Rec.Open("SELECT * FROM Jobs WHERE j_id = " & iJobID, Conn, 3, 3)

            If Rec.RecordCount = 1 Then
                Select Case Rec.Fields("j_plugin").Value
                    Case "BATC2"
                        repName = "2010_STUDENTS_C2.rpt"
                    Case "BAT23_34"
                        repName = "2010_STUDENTS_2010.rpt"
                    Case "BAT122005"
                        repName = "2010_STUDENTS_2005.rpt"
                    Case "BATAIDR", "BATPRE1"
                        repName = "2010_STUDENTS_AID.rpt"
                    Case "BAT12"
                        repName = "2012_STUDENTS_BAT12.rpt"
                    Case "BAT23"
                        repName = "2012_STUDENTS_BAT23.rpt"
                    Case "BAT34"
                        repName = "2012_STUDENTS_BAT34.rpt"
                    Case Else
                        If Microsoft.VisualBasic.Left(Rec.Fields("j_plugin").Value, 4) = "DIAL" Then
                            repName = "2010_STUDENTS_DIAL4.rpt"
                        Else
                            MsgBox("Bateria no configura con Hoja de Contestacion")
                            Rec.Close()
                            Conn.Close()
                            Exit Sub
                        End If
                End Select
            End If
            Rec.Close()
            Conn.Close()

            Select Case cboAR.SelectedIndex
                Case 0                     'todos
                    FromAR = 0
                    ToAR = 1
                Case 1                    'solo AR
                    FromAR = 1
                    ToAR = 1
                Case 2                    'SIN AR
                    FromAR = 0
                    ToAR = 0
            End Select

            If Me.chkPreview.CheckState = False Then
                'UPGRADE_WARNING: Couldn't resolve default property of object repName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'CrxRpt = CrxApp.OpenReport(Config.ReportsPath & repName)
                'CrxRpt.PrinterSetup((Me.Handle.ToInt32))
                'CrxRpt.ParameterFields(1).AddCurrentValue((Me.iJobID))
                'CrxRpt.ParameterFields(2).AddCurrentValue((FromAR))
                'CrxRpt.ParameterFields(3).AddCurrentValue((ToAR))
                'CrxRpt.PrintOut(True, 1, False)
                ''UPGRADE_NOTE: Object CrxRpt may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
                'CrxRpt = Nothing
            Else
                rptRep.ReportID = Me.iJobID
                rptRep.FromGrade = FromAR
                rptRep.ToGrade = ToAR
                rptRep.isAR = True
                rptRep.ReportFile = Config.ReportsPath & repName
                rptRep.ShowDialog()
            End If
        End Sub
        Private Sub LVNames_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles LVNames.DoubleClick
            ' CP 2015.02.28 - the logic here is beyond me, it's either an X or nothing
            Dim X As Short = CShort(Me.LVNames.FocusedItem.Text)
            If Me.LVNames.Items(X - 1).SubItems(2).Text = "X" Then
                Me.LVNames.Items.Item(X - 1).SubItems(2).Text = ""
            Else
                Me.LVNames.Items.Item(X - 1).SubItems(2).Text = "X"
            End If

            ''UPGRADE_WARNING: Lower bound of collection Me.LVNames.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            ''UPGRADE_WARNING: Lower bound of collection Me.LVNames.ListItems() has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            'If Me.LVNames.Items.Item(X - 1).SubItems(1).Text = "" Then
            '    'UPGRADE_WARNING: Lower bound of collection Me.LVNames.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            '    'UPGRADE_WARNING: Lower bound of collection Me.LVNames.ListItems() has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            '    If Me.LVNames.Items.Item(X - 1).SubItems.Count > 2 Then
            '        Me.LVNames.Items.Item(X - 1).SubItems(2).Text = "X"
            '    Else
            '        Me.LVNames.Items.Item(X - 1).SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "X"))
            '    End If
            'Else
            '    'UPGRADE_WARNING: Lower bound of collection Me.LVNames.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            '    'UPGRADE_WARNING: Lower bound of collection Me.LVNames.ListItems() has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            '    If Me.LVNames.Items.Item(X - 1).SubItems.Count > 2 Then
            '        Me.LVNames.Items.Item(X - 1).SubItems(2).Text = ""
            '    Else
            '        Me.LVNames.Items.Item(X - 1).SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, ""))
            '    End If
            'End If

        End Sub
        'UPGRADE_ISSUE: MSComctlLib.ListView event LVNames.ItemClick was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
        Private Sub edit_student() Handles _Toolbar1_Button2.Click
            Dim sEdad As String
            Dim sName As String
            Dim sSex As String
            Dim MBResult As MsgBoxResult
            If Not LVNames.FocusedItem Is Nothing Then

                txtName.Text = InputBox("Enter the correct name using the proper syntax")
                If (Trim(txtName.Text) <> String.Empty) And (Not LVNames.FocusedItem Is Nothing) Then
                    sName = FormatName(Capitalize(Trim(txtName.Text)))
                    If sName <> "INVALID" Then
                        sSex = String.Empty
                        sEdad = String.Empty
                        'verifico edad y sexo
                        If InStr(1, UCase(sName), "/E") > 0 Then
                            'pusieron edad
                            sEdad = Split(UCase(sName), "/E")(1)
                            If InStr(1, sEdad, "/") > 0 Then
                                sEdad = Split(sEdad, "/")(0)
                            End If
                            sName = Replace(sName, "/E" & sEdad, "", , , CompareMethod.Text)
                        End If

                        If InStr(1, UCase(sName), "/S") > 0 Then
                            'pusieron sexo
                            sSex = Split(UCase(sName), "/S")(1)
                            If InStr(1, sSex, "/") > 0 Then
                                sSex = Split(sSex, "/")(0)
                            End If
                            sName = Replace(sName, "/S" & sSex, "", , , CompareMethod.Text)
                        End If

                        'UPGRADE_WARNING: Lower bound of collection LVNames.SelectedItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        If LVNames.FocusedItem.SubItems.Count > 1 Then
                            LVNames.FocusedItem.SubItems(1).Text = sName
                        Else
                            LVNames.FocusedItem.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, sName))
                        End If
                        'UPGRADE_WARNING: Lower bound of collection LVNames.SelectedItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        If LVNames.FocusedItem.SubItems.Count > 9 Then
                            LVNames.FocusedItem.SubItems(9).Text = sEdad
                        Else
                            LVNames.FocusedItem.SubItems.Insert(9, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, sEdad))
                        End If
                        'UPGRADE_WARNING: Lower bound of collection LVNames.SelectedItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        If LVNames.FocusedItem.SubItems.Count > 10 Then
                            LVNames.FocusedItem.SubItems(10).Text = sSex
                        Else
                            LVNames.FocusedItem.SubItems.Insert(10, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, sSex))
                        End If
                    Else
                        'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        MBResult = MsgBox("Invalid Name Syntax", MsgBoxStyle.OkOnly, "Student Name")
                        Me.txtName.Focus()
                    End If
                End If
            End If
        End Sub

        Private Sub LVNames_ItemClick(ByVal Item As System.Windows.Forms.ListViewItem)
            Dim sLname As String
            Dim sName As String
            'txtName = Item.SubItems(1)
            ' SetBoldSelectedItem

            sName = Item.SubItems(1).Text
            sLname = Split(sName, ",")(0)
            sLname = Replace(sLname, " ", ", ")
            If InStr(1, sName, ",") > 0 Then
                Me.txtName.Text = sLname & "," & Split(sName, ",")(1)
            Else
                Me.txtName.Text = sLname & ", " & sName
            End If

            'edad
            If Trim(Item.SubItems(9).Text) <> "" And Item.SubItems(9).Text <> "0" Then
                Me.txtName.Text = Me.txtName.Text & "/E" & Item.SubItems(9).Text
            End If

            'sex
            If Trim(Item.SubItems(10).Text) <> "" Then
                'UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                Me.txtName.Text = Me.txtName.Text & "/S" & Item.SubItems(10).Text
            End If
            SetBoldSelectedItem()
            'Me.txtName.SetFocus
        End Sub
        Private Sub LVNames_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles LVNames.KeyUp
            Dim KeyCode As Short = eventArgs.KeyCode
            Dim Shift As Short = eventArgs.KeyData \ &H10000
            Dim sLname As String
            Dim sName As String

            Select Case KeyCode
                Case 46 'DEL
                    If (Not LVNames.FocusedItem Is Nothing) Then
                        LVNames.Items.RemoveAt((LVNames.FocusedItem.Index))
                        Me.Text = "Enter Student list (" & Me.LVNames.Items.Count & " of " & StudentCount & ")"
                        Me.txtName.Text = ""
                        Call SetItemsNumber()
                    End If
                Case 113 'F4
                    sName = Me.LVNames.FocusedItem.SubItems.Item(1).Text
                    sLname = Split(sName, ",")(0)
                    sLname = Replace(sLname, " ", ", ")
                    Me.txtName.Text = sLname & "," & Split(sName, ",")(1)
                    SetBoldSelectedItem()
                    Me.txtName.Focus()
            End Select
        End Sub
        Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar1_Button1.Click, _Toolbar1_Button2.Click, BtnDel.Click, _Toolbar1_Button4.Click, _Toolbar1_Button5.Click, _Toolbar1_Button6.Click
            Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
            Dim sEdad As String
            Dim sName As String
            Dim sSex As String
            Dim MBResult As MsgBoxResult
            Select Case Button.Name
                Case "BtnNew"
                    Call txtName_KeyPress(txtName, New System.Windows.Forms.KeyPressEventArgs(Chr(13)))
                    'Case "BtnEdit"
                    '    If (Trim(txtName.Text) <> String.Empty) And (Not LVNames.FocusedItem Is Nothing) Then
                    '        sName = FormatName(Capitalize(Trim(txtName.Text)))
                    '        If sName <> "INVALID" Then
                    '            sSex = String.Empty
                    '            sEdad = String.Empty
                    '            'verifico edad y sexo
                    '            If InStr(1, UCase(sName), "/E") > 0 Then
                    '                'pusieron edad
                    '                sEdad = Split(UCase(sName), "/E")(1)
                    '                If InStr(1, sEdad, "/") > 0 Then
                    '                    sEdad = Split(sEdad, "/")(0)
                    '                End If
                    '                sName = Replace(sName, "/E" & sEdad, "", , , CompareMethod.Text)
                    '            End If

                    '            If InStr(1, UCase(sName), "/S") > 0 Then
                    '                'pusieron sexo
                    '                sSex = Split(UCase(sName), "/S")(1)
                    '                If InStr(1, sSex, "/") > 0 Then
                    '                    sSex = Split(sSex, "/")(0)
                    '                End If
                    '                sName = Replace(sName, "/S" & sSex, "", , , CompareMethod.Text)
                    '            End If

                    '            'UPGRADE_WARNING: Lower bound of collection LVNames.SelectedItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    '            If LVNames.FocusedItem.SubItems.Count > 1 Then
                    '                LVNames.FocusedItem.SubItems(1).Text = sName
                    '            Else
                    '                LVNames.FocusedItem.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, sName))
                    '            End If
                    '            'UPGRADE_WARNING: Lower bound of collection LVNames.SelectedItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    '            If LVNames.FocusedItem.SubItems.Count > 9 Then
                    '                LVNames.FocusedItem.SubItems(9).Text = sEdad
                    '            Else
                    '                LVNames.FocusedItem.SubItems.Insert(9, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, sEdad))
                    '            End If
                    '            'UPGRADE_WARNING: Lower bound of collection LVNames.SelectedItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    '            If LVNames.FocusedItem.SubItems.Count > 10 Then
                    '                LVNames.FocusedItem.SubItems(10).Text = sSex
                    '            Else
                    '                LVNames.FocusedItem.SubItems.Insert(10, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, sSex))
                    '            End If
                    '        Else
                    '            'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '            MBResult = MsgBox("Invalid Name Syntax", MsgBoxStyle.OkOnly, "Student Name")
                    '            Me.txtName.Focus()
                    '        End If

                    '    End If
                Case "BtnDel"
                    If (Not LVNames.FocusedItem Is Nothing) Then
                        'UPGRADE_ISSUE: MSComctlLib.ListItem property LVNames.SelectedItem.Ghosted was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                        'LVNames.FocusedItem.Ghosted = True
                        'LVNames.FocusedItem.ForeColor = System.Drawing.Color.Red
                        'LVNames.ListItems.Remove(LVNames.SelectedItem.Index)
                        LVNames.FocusedItem.Remove()
                        Me.Text = "Enter Student list (" & Me.LVNames.Items.Count & " of " & StudentCount & ")"
                        Me.txtName.Text = ""
                        Call SetItemsNumber()
                    End If
                Case "Up"
                    Call MoveUp()
                Case "Down"
                    Call MoveDown()
            End Select
            SetBoldSelectedItem()
        End Sub
        Private Sub txtName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
            Dim iCounter1 As Integer
            Dim Item As System.Windows.Forms.ListViewItem
            Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
            Dim sEdad As String
            Dim sName As String
            Dim sSex As String = ""
            Dim sSexo As String
            Dim MBResult As MsgBoxResult

            If (KeyAscii = 13) And (Trim(txtName.Text) <> String.Empty) Then
                sName = FormatName(Capitalize(Trim(txtName.Text)))
                sEdad = String.Empty
                sSexo = String.Empty
                If UCase(sName) <> "INVALID" Then 'UCASE es una marron de JC
                    'verifico edad y sexo
                    If InStr(1, UCase(sName), "/E") > 0 Then
                        'pusieron edad
                        sEdad = Split(UCase(sName), "/E")(1)
                        If InStr(1, sEdad, "/") > 0 Then sEdad = Split(sEdad, "/")(0)
                        sName = Replace(sName, "/E" & sEdad, "", , , CompareMethod.Text)
                    End If
                    If InStr(1, UCase(sName), "/S") > 0 Then
                        'pusieron sexo
                        sSex = Split(UCase(sName), "/S")(1)
                        If InStr(1, sSex, "/") > 0 Then sSex = Split(sSex, "/")(0)
                        sName = Replace(sName, "/S" & sSex, "", , , CompareMethod.Text)
                    End If
                    Item = LVNames.Items.Add(CStr(LVNames.Items.Count + 1))
                    Item.EnsureVisible()
                    Item.Selected = True
                    If Item.SubItems.Count > 1 Then
                        Item.SubItems(1).Text = Trim(sName)
                    Else
                        Item.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Trim(sName)))
                    End If
                    ' CP 2015.02.28 - since the way the listiew is indexed has changed since VB6, we're going to add the columns manually 
                    '               to avoid index problems
                    For iCounter1 = 2 To 10
                        Item.SubItems.Insert(iCounter1, New System.Windows.Forms.ListViewItem.ListViewSubItem())
                    Next
                    If Item.SubItems.Count > 9 Then
                        Item.SubItems(9).Text = sEdad
                    Else
                        Item.SubItems.Insert(9, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, sEdad))
                    End If
                    If Item.SubItems.Count > 10 Then
                        Item.SubItems(10).Text = sSex
                    Else
                        Item.SubItems.Insert(10, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, sSex))
                    End If
                    txtName.Text = String.Empty
                    KeyAscii = 0
                    SetBoldSelectedItem()
                    Me.Text = "Enter Student list (" & Me.LVNames.Items.Count & " of " & StudentCount & ")"
                Else
                    MBResult = MsgBox("Invalid Name Syntax", MsgBoxStyle.OkOnly, "Student Name")
                    Me.txtName.Focus()
                End If
            End If
            eventArgs.KeyChar = Chr(KeyAscii)
            If KeyAscii = 0 Then
                eventArgs.Handled = True
            End If
        End Sub
        Private Sub txtName_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyUp
            Dim KeyCode As Short = eventArgs.KeyCode
            Dim Shift As Short = eventArgs.KeyData \ &H10000
            Dim sName As String
            Dim MBResult As MsgBoxResult
            If KeyCode = 113 Then 'F4
                If (Trim(txtName.Text) <> String.Empty) And (Not LVNames.FocusedItem Is Nothing) Then
                    sName = FormatName(Capitalize(Trim(txtName.Text)))
                    If sName <> "INVALID" Then
                        If LVNames.FocusedItem.SubItems.Count > 1 Then
                            LVNames.FocusedItem.SubItems(1).Text = sName
                        Else
                            LVNames.FocusedItem.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, sName))
                        End If
                        Me.txtName.Text = String.Empty
                        Me.txtName.Focus()
                    Else
                        MBResult = MsgBox("Invalid Syntax Name", MsgBoxStyle.OkOnly, "Student Name")
                    End If
                End If
            End If
        End Sub
#End Region
#Region "LEVEL TWO ROUTINES"
        'Called By: frmDataEntry_Load()
        'Called By: frmDataEntry.cmdPrint_Click()
        Sub LoadData()
            Dim sQueryJobs As String = "Select * from Jobs Where J_ID =" & iJobID
            Dim sQueryStudent As String = "Select * from Answers Where A_J_ID =" & iJobID & " ORDER BY a_order"

            Dim dtJobs As DataTable = GlobalResources.ExecuteDataTable(sQueryJobs)
            Dim dtStudents As DataTable = GlobalResources.ExecuteDataTable(sQueryStudent)

            Dim AR As String
            Dim Aus As String
            Dim CurrEdad As String
            Dim i As Integer = 0
            Dim Item As System.Windows.Forms.ListViewItem


            'Dim Cn As ADODB.Connection
            'Dim Rs As ADODB.Recordset
            'Cn = New ADODB.Connection
            'Rs = New ADODB.Recordset

            'OpenConnection(Cn, Config.ConnectionString)

            'Rs.Open("Select * from Jobs Where J_ID =" & iJobID, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            'StudentCount = Rs.Fields("J_TOTAL_EST").Value
            'Rs.Close()

            'Rs.Open("Select * from Answers Where A_J_ID =" & iJobID & " ORDER BY a_order, A_ID", Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            'StudentsLoaded = Rs.RecordCount

            If dtJobs.Rows.Count > 0 Then
                StudentCount = dtJobs.Rows(0)("J_TOTAL_EST").ToString()
            End If
            StudentsLoaded = dtStudents.Rows.Count

            If StudentCount <> StudentsLoaded Then
                bEdit = False 'Crear records
            Else
                bEdit = True 'Update records
            End If

            Me.Text = "Enter Student list (" & StudentsLoaded & " of " & StudentCount & ") JobID:" & Me.iJobID
            For iCounter As Integer = 0 To dtStudents.Rows.Count - 1
                aIdList.Add(dtStudents(iCounter)("A_ID").ToString())
                Item = LVNames.Items.Add("L" & dtStudents(iCounter)("A_ID").ToString(), CStr(LVNames.Items.Count + 1), "")
                If Item.SubItems.Count > 1 Then
                    Item.SubItems(1).Text = dtStudents(iCounter)("A_NOMBRE").ToString()
                Else
                    Item.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, dtStudents(iCounter)("A_NOMBRE").ToString()))
                End If

                Aus = dtStudents(iCounter)("a_ausente").ToString()
                If Aus = "1" Then Item.Checked = True

                AR = dtStudents(iCounter)("A_ar").ToString()
                'If AR = "1" Then
                If Item.SubItems.Count > 2 Then
                    If AR = "1" Then
                        Item.SubItems(2).Text = "X"
                    Else
                        Item.SubItems(2).Text = ""
                    End If
                Else
                    If AR = "1" Then
                        Item.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "X"))
                    Else
                        Item.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, ""))
                    End If
                End If
                'End If

                CurrEdad = dtStudents(iCounter)("A_edad").ToString()
                CurrEdad = VB6.Format(CurrEdad, "##.#0")
                If CurrEdad <> "" Then
                    If (CDbl(Split(CurrEdad, ".")(1))) > 10 Then
                        CurrEdad = VB6.Format(CurrEdad, "##.##")
                    End If
                End If

                If Item.SubItems.Count > 3 Then
                    Item.SubItems(3).Text = dtStudents(iCounter)("A_ID").ToString()
                Else
                    Item.SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, dtStudents(iCounter)("A_ID").ToString()))
                End If

                If Item.SubItems.Count > 4 Then
                    Item.SubItems(4).Text = dtStudents(iCounter)("A_NV_TOTAL").ToString()
                Else
                    Item.SubItems.Insert(4, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, dtStudents(iCounter)("A_NV_TOTAL").ToString()))
                End If

                If Item.SubItems.Count > 5 Then
                    Item.SubItems(5).Text = dtStudents(iCounter)("A_LES_TOTAL").ToString()
                Else
                    Item.SubItems.Insert(5, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, dtStudents(iCounter)("A_LES_TOTAL").ToString()))
                End If

                If Item.SubItems.Count > 6 Then
                    Item.SubItems(6).Text = dtStudents(iCounter)("A_REN_TOTAL").ToString()
                Else
                    Item.SubItems.Insert(6, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, dtStudents(iCounter)("A_REN_TOTAL").ToString()))
                End If

                If Item.SubItems.Count > 7 Then
                    Item.SubItems(7).Text = dtStudents(iCounter)("A_MAT_TOTAL").ToString()
                Else
                    Item.SubItems.Insert(7, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, dtStudents(iCounter)("A_MAT_TOTAL").ToString()))
                End If

                If Item.SubItems.Count > 8 Then
                    Item.SubItems(8).Text = dtStudents(iCounter)("A_AIDR_TOTAL").ToString()
                Else
                    Item.SubItems.Insert(8, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, dtStudents(iCounter)("A_AIDR_TOTAL").ToString.Replace(".00", "")))
                End If

                If Item.SubItems.Count > 9 Then
                    Item.SubItems(9).Text = CurrEdad
                Else
                    Item.SubItems.Insert(9, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, CurrEdad))
                End If

                If Item.SubItems.Count > 10 Then
                    Item.SubItems(10).Text = dtStudents(iCounter)("A_sexo").ToString()
                Else
                    Item.SubItems.Insert(10, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, dtStudents(iCounter)("A_sexo").ToString()))
                End If

                'Rs.MoveNext()
            Next iCounter

            'Rs.Close()
            'Cn.Close()

        End Sub
        'Called By: frmDataEntry.Toolbar1_ButtonClick()
        Sub MoveDown()
            Dim iIndex As Short
            'Dim Item As System.Windows.Forms.ListViewItem
            Dim sARCurrent As String
            Dim sARDown As String
            Dim sIDCurrent As Integer
            Dim sIDDown As Integer
            Dim sNameCurrent As String
            Dim sNameDown As String

            With LVNames
                If Not .FocusedItem Is Nothing Then
                    iIndex = .FocusedItem.Index
                    If iIndex < .Items.Count Then
                        sNameDown = LVNames.Items.Item(iIndex + 1).SubItems(1).Text
                        sARDown = LVNames.Items.Item(iIndex + 1).SubItems(2).Text
                        sIDDown = CInt(LVNames.Items.Item(iIndex + 1).SubItems(3).Text)
                        sNameCurrent = LVNames.Items.Item(iIndex).SubItems(1).Text
                        sARCurrent = LVNames.Items.Item(iIndex).SubItems(2).Text
                        sIDCurrent = CInt(LVNames.Items.Item(iIndex).SubItems(3).Text)
                        If LVNames.Items.Item(iIndex + 1).SubItems.Count > 1 Then
                            LVNames.Items.Item(iIndex + 1).SubItems(1).Text = sNameCurrent
                        Else
                            LVNames.Items.Item(iIndex + 1).SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, sNameCurrent))
                        End If
                        If LVNames.Items.Item(iIndex + 1).SubItems.Count > 2 Then
                            LVNames.Items.Item(iIndex + 1).SubItems(2).Text = sARCurrent
                        Else
                            LVNames.Items.Item(iIndex + 1).SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, sARCurrent))
                        End If
                        If LVNames.Items.Item(iIndex + 1).SubItems.Count > 3 Then
                            LVNames.Items.Item(iIndex + 1).SubItems(3).Text = CStr(sIDCurrent)
                        Else
                            LVNames.Items.Item(iIndex + 1).SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, CStr(sIDCurrent)))
                        End If
                        If LVNames.Items.Item(iIndex).SubItems.Count > 1 Then
                            LVNames.Items.Item(iIndex).SubItems(1).Text = sNameDown
                        Else
                            LVNames.Items.Item(iIndex).SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, sNameDown))
                        End If
                        If LVNames.Items.Item(iIndex).SubItems.Count > 2 Then
                            LVNames.Items.Item(iIndex).SubItems(2).Text = sARDown
                        Else
                            LVNames.Items.Item(iIndex).SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, sARDown))
                        End If
                        If LVNames.Items.Item(iIndex).SubItems.Count > 3 Then
                            LVNames.Items.Item(iIndex).SubItems(3).Text = CStr(sIDDown)
                        Else
                            LVNames.Items.Item(iIndex).SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, CStr(sIDDown)))
                        End If
                        LVNames.Items.Item(iIndex + 1).Selected = True
                    End If
                End If
            End With
        End Sub
        'Called By: frmDataEntry.Toolbar1_ButtonClick()
        Sub MoveUp()
            Dim iIndex As Short
            'Dim Item As System.Windows.Forms.ListViewItem
            Dim sARCurrent As String
            Dim sARUp As String
            Dim sIDCurrent As Integer
            Dim sIDUp As Integer
            Dim sNameCurrent As String
            Dim sNameUp As String

            With LVNames
                If Not .FocusedItem Is Nothing Then
                    iIndex = .FocusedItem.Index
                    If iIndex > 1 Then
                        sNameUp = LVNames.Items.Item(iIndex - 1).SubItems(1).Text
                        sARUp = LVNames.Items.Item(iIndex - 1).SubItems(2).Text
                        sIDUp = CInt(LVNames.Items.Item(iIndex - 1).SubItems(3).Text)
                        sNameCurrent = LVNames.Items.Item(iIndex).SubItems(1).Text
                        sARCurrent = LVNames.Items.Item(iIndex).SubItems(2).Text
                        sIDCurrent = CInt(LVNames.Items.Item(iIndex).SubItems(3).Text)
                        If LVNames.Items.Item(iIndex - 1).SubItems.Count > 1 Then
                            LVNames.Items.Item(iIndex - 1).SubItems(1).Text = sNameCurrent
                        Else
                            LVNames.Items.Item(iIndex - 1).SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, sNameCurrent))
                        End If
                        If LVNames.Items.Item(iIndex - 1).SubItems.Count > 2 Then
                            LVNames.Items.Item(iIndex - 1).SubItems(2).Text = sARCurrent
                        Else
                            LVNames.Items.Item(iIndex - 1).SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, sARCurrent))
                        End If
                        If LVNames.Items.Item(iIndex - 1).SubItems.Count > 3 Then
                            LVNames.Items.Item(iIndex - 1).SubItems(3).Text = CStr(sIDCurrent)
                        Else
                            LVNames.Items.Item(iIndex - 1).SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, CStr(sIDCurrent)))
                        End If
                        If LVNames.Items.Item(iIndex).SubItems.Count > 1 Then
                            LVNames.Items.Item(iIndex).SubItems(1).Text = sNameUp
                        Else
                            LVNames.Items.Item(iIndex).SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, sNameUp))
                        End If
                        If LVNames.Items.Item(iIndex).SubItems.Count > 2 Then
                            LVNames.Items.Item(iIndex).SubItems(2).Text = sARUp
                        Else
                            LVNames.Items.Item(iIndex).SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, sARUp))
                        End If
                        If LVNames.Items.Item(iIndex).SubItems.Count > 3 Then
                            LVNames.Items.Item(iIndex).SubItems(3).Text = CStr(sIDUp)
                        Else
                            LVNames.Items.Item(iIndex).SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, CStr(sIDUp)))
                        End If
                        LVNames.Items.Item(iIndex - 1).Selected = True
                    End If
                End If
            End With
        End Sub
        'Called By: frmDataEntry.LVNames_ItemClick()
        'Called By: frmDataEntry.LVNames_KeyUp()
        'Called By: frmDataEntry.Toolbar1_ButtonClick()
        'Called By: frmDataEntry.txtName_KeyPress()
        Sub SetBoldSelectedItem()
            Dim i As Integer
            If Not LVNames.FocusedItem Is Nothing Then
                For iCounter As Integer = 0 To LVNames.Items.Count - 1
                    LVNames.Items.Item(iCounter).Font = VB6.FontChangeBold(LVNames.Items.Item(iCounter).Font, False)
                Next iCounter
                LVNames.FocusedItem.Font = VB6.FontChangeBold(LVNames.FocusedItem.Font, True)
            End If
        End Sub
        'Called By: frmDataEntry.LVNames_KeyUp()
        'Called By: frmDataEntry.Toolbar1_ButtonClick()
        Sub SetItemsNumber()

            For iCounter As Integer = 0 To LVNames.Items.Count - 1
                LVNames.Items.Item(iCounter).Text = iCounter.ToString
            Next iCounter
        End Sub
        'Called By: frmDataEntry.cmdOK_Click()
        'Called By: frmDataEntry.cmdPrint_Click()
        Sub UpdateNames()
            Dim sQuery As String
            Dim Conn As ADODB.Connection
            Conn = New ADODB.Connection
            Dim Rec As ADODB.Recordset
            Rec = New ADODB.Recordset
            Dim Rs As New ADODB.Recordset

            Dim Aus As String
            Dim A_ID As Integer
            Dim bCont As Boolean
            Dim i As Integer
            Dim TotPend As Short
            Dim y As Short

            Conn.Open(Config.ConnectionString)
            y = 0
            TotPend = 0

            'get school id from job
            Me.iSchID = 0
            sQuery = "select j_sch from jobs where j_id = " & Me.iJobID
            Rs.Open(sQuery, Conn, 3, 3)
            If Rs.RecordCount = 1 Then
                Me.iSchID = Rs.Fields("J_SCH").Value
            End If
            Rs.Close()

            For iCounter As Integer = 0 To Me.LVNames.Items.Count - 1
                bCont = True
                A_ID = Val(LVNames.Items.Item(iCounter).SubItems(3).Text)
                If aIdList.Contains(A_ID) Then
                    aIdList.Remove(A_ID)
                End If
                If A_ID > 0 Then
                    If Me.LVNames.Items.Item(iCounter) Is Nothing Then 'Me.LVNames.Items.Item(i).Ghosted = True Then
                        'marcardo para borrar
                        sQuery = "delete from answers where a_id = " & A_ID
                        Conn.Execute(sQuery)
                        bCont = False
                    Else
                        Rec.Open("SELECT * FROM ANSWERS WHERE A_ID=" & A_ID, Conn, 1, 3, 0)
                    End If
                Else
                    If Me.LVNames.Items.Item(iCounter) Is Nothing Then 'Me.LVNames.Items.Item(i).Ghosted = True Then
                        'marcado para borrar, pero es nuevo, no se hace nada
                        bCont = False
                    Else
                        Rec.Open("SELECT * FROM ANSWERS WHERE A_ID=0", Conn, 1, 3, 0)
                        Rec.AddNew()
                        Rec.Fields("A_J_ID").Value = Me.iJobID
                    End If
                End If

                If bCont Then
                    y += 1

                    Rec.Fields("A_NOMBRE").Value = LVNames.Items.Item(iCounter).SubItems(1).Text
                    Rec.Fields("A_edad").Value = IIf(LVNames.Items.Item(iCounter).SubItems(9).Text = "", 0, LVNames.Items.Item(iCounter).SubItems(9).Text)
                    Rec.Fields("A_sexo").Value = LVNames.Items.Item(iCounter).SubItems(10).Text

                    Aus = LVNames.Items.Item(iCounter).SubItems(2).Text
                    If Aus = "X" Then
                        Rec.Fields("A_ar").Value = 1
                    Else
                        Rec.Fields("A_ar").Value = 0
                    End If

                    If LVNames.Items.Item(iCounter).Checked Then
                        Rec.Fields("a_ausente").Value = 1
                    Else
                        Rec.Fields("a_ausente").Value = 0
                    End If

                    If Me.iSchID > 0 Then
                        Rec.Fields("a_school").Value = Me.iSchID
                    End If

                    Rec.Fields("a_order").Value = y
                    If IsDBNull(Rec.Fields("a_newscan").Value) = True Then
                        Rec.Fields("a_newscan").Value = 0
                        TotPend = TotPend + 1
                    End If
                    Rec.Update()
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetValue(Rec!a_newscan, 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    ' CP 2015.03.01 - if a_newscan is null, then increment TotPend. this is the same check as aboved, so moved it
                    '               to where the correct typing will happen
                    'If GetValue(Rec.Fields("a_newscan"), 0) = 0 Then
                    'TotPend = TotPend + 1
                    'End If
                    Rec.Close()
                End If
            Next iCounter

            'Delete from answers 
            For iCounter As Integer = 0 To aIdList.Count - 1
                sQuery = "delete from answers where a_id = " & aIdList(iCounter)
                Conn.Execute(sQuery)
            Next iCounter
            sQuery = "update jobs set j_total_est_pend = " & TotPend & " where j_id = " & Me.iJobID
            Conn.Execute(sQuery)
            Conn.Close()
        End Sub
#End Region
#Region "Unknown/Unused Routines"
        Sub DeleteAllStudents()
            Dim Cn As New ADODB.Connection
            Dim Cm As New ADODB.Command

            'NOT USED ANYMORE
            'Exit Sub

            OpenConnection(Cn, Config.ConnectionString)
            Cm.ActiveConnection = Cn

            Cm.CommandText = "DELETE FROM Answers Where a_j_ID =" & Me.iJobID
            Cm.Execute()

            Cn.Close()
        End Sub

        Sub DeleteStudent(ByVal aid As String)
            Dim Cn As New ADODB.Connection
            Dim Cm As New ADODB.Command

            'NOT USED ANYMORE
            'Exit Sub

            OpenConnection(Cn, Config.ConnectionString)
            Cm.ActiveConnection = Cn

            Cm.CommandText = "DELETE FROM Answers Where a_ID =" & aid

            Cm.Execute()

            Cn.Close()
        End Sub

        Sub SaveNames()
            Dim Conn As ADODB.Connection
            Conn = New ADODB.Connection
            Dim Rec As ADODB.Recordset
            Rec = New ADODB.Recordset
            Dim i As Integer
            'NOT USED ANYMORE
            Exit Sub

            Conn.Open(Config.ConnectionString)

            Rec.Open("SELECT * FROM ANSWERS WHERE A_J_ID=" & iJobID, Conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
            For iCounter As Integer = 1 To LVNames.Items.Count

                Rec.AddNew()
                Rec.Fields("A_J_ID").Value = iJobID
                Rec.Fields("A_NOMBRE").Value = LVNames.Items.Item(iCounter).SubItems(1).Text
                Rec.Fields("A_edad").Value = LVNames.Items.Item(iCounter).SubItems(9).Text
                Rec.Fields("a_sex").Value = LVNames.Items.Item(iCounter).SubItems(10).Text
                If LVNames.Items.Item(i).SubItems(2).Text = "X" Then
                    Rec.Fields("A_ar").Value = 1
                Else
                    Rec.Fields("A_ar").Value = 0
                End If
                If LVNames.Items.Item(i).Checked Then
                    Rec.Fields("a_ausente").Value = 1
                Else
                    Rec.Fields("a_ausente").Value = 0
                End If
                Rec.Update()
            Next iCounter
            Rec.Close()
            Conn.Close()
            Rec = Nothing
            Conn = Nothing
        End Sub
#End Region

    End Class
End Namespace