Option Strict Off
Option Explicit On


Imports NPOI.SS.Formula.Functions
Imports Microsoft.VisualBasic.Compatibility
Imports System.ComponentModel

Friend Class frmReportView
    Inherits Form
    Dim WHERE_STATEMENT As String

#Region "LEVEL ONE ROUTINES"
    Private Sub frmReportView_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        '\B/---------------------inicializamos toolbar---------------------------\B/
        Select Case LoggedUser.UserType
            Case enumSecurityLevel.accounting
                'UPGRADE_WARNING: Lower bound of collection Me.Toolbar1.Buttons has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                Me.Toolbar1.Items.Item(1).Enabled = False
                'UPGRADE_WARNING: Lower bound of collection Me.Toolbar1.Buttons has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                Me.Toolbar1.Items.Item(2).Enabled = False
        End Select
        '/E\---------------------inicializamos toolbar---------------------------/E\

        Me.txtRepFromDate.Text = DateAdd(DateInterval.Day, -120, DateTime.Today).ToString
        Me.txtRepToDate.Text = DateTime.Today.ToString
        Me.Fill2()
    End Sub

    ''' <param name="eventSender"></param>
    ''' <param name="eventArgs"></param>
    ''' <remarks>
    '''           Called By: frmMain.rbEvaluation_Click() -- frmReport_Show()
    ''' </remarks>

    Private Sub frmReportView_Resize(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Resize
        Call Me.SetControls()
    End Sub
    'This is for the Create Report Button
    Private Sub Toolbar1_ButtonMenuClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) _
        Handles RegularReport.Click, OTReport.Click, EntranceReport.Click
        Dim ButtonMenu As ToolStripItem = CType(eventSender, ToolStripMenuItem)
        Select Case ButtonMenu.Name
            Case "RegularReport"
                frmCreateReport.RptType = enumReportTypes.Regular
                frmCreateReport.ShowDialog()
            Case "EntranceReport"
                frmCreateReport.RptType = enumReportTypes.Entrance
                frmCreateReport.ShowDialog()
            Case "OTReport"
                frmCreateReport.RptType = enumReportTypes.OfficeTesting
                frmCreateReport.ShowDialog()
        End Select
    End Sub

    'This is for the Print Report Button
    Private Sub Toolbar1_ButtonClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) _
        Handles _Toolbar1_Button1.Click, Print.Click, _Toolbar1_Button3.Click, Delete.Click, Analysis.Click, Range.Click,
                Certificados.Click, Five.Click, Estanina.Click, Prepost.Click
        Dim Button As ToolStripItem = CType(eventSender, ToolStripItem)
        'Dim Res As MsgBoxResult

        Select Case Button.Name
            Case "Print"
                If Not Me.lvReports.FocusedItem Is Nothing Then
                    frmPrintReport.iRepID = LA_Declarations.GetIDFromKey(lvReports.FocusedItem.Name)
                    frmPrintReport.ShowDialog()
                End If
            Case "Delete"
                Call frmMain.mnuResetRep_Click(Nothing, New EventArgs()) '// sub del Delete PopUp menu
            Case "Analysis"
                'Call frmEstadistico.Show()
            Case "Range"
                Call frmRango.Show()
            Case "Certificados"
                frmCertificados.RepID = GetIDFromKey(lvReports.FocusedItem.Name)
                frmCertificados.Show()
            Case "Five"
                frmFive.Show()
            Case "Estanina"
                'frmCreateStanine.Show
                frmEstaninaAnual.Show()
            Case "Prepost"
                frmPrePost.Show()
        End Select
    End Sub

#End Region
#Region "LEVEL TWO ROUTINES"
    ''' <remarks>
    '''            Called By: frmReportView_Load()
    ''' </remarks>
    Sub Fill2()
        Dim Cn As ADODB.Connection
        Dim Rs As ADODB.Recordset
        Dim CurrentItem As ListViewItem
        Cn = New ADODB.Connection
        Rs = New ADODB.Recordset
        Try
            If Not IsDate(Me.txtRepFromDate.Text) Or
                Not IsDate(Me.txtRepToDate.Text) Then
                Exit Sub
            End If

            Dim sQuery As String = "SELECT Reports.*, SCHOOLS.SC_SCH_NAME "
            sQuery &= "FROM Reports LEFT OUTER JOIN "
            'UPGRADE_WARNING: DateValue has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            sQuery &= "SCHOOLS ON Reports.Rep_SCH_ID = SCHOOLS.SC_ID " & "WHERE Rep_Serv_Date >= '" &
                     DateValue(Me.txtRepFromDate.Text) & "' AND " & "Rep_Serv_Date <= '" & DateValue(Me.txtRepToDate.Text) &
                     "' Order By Rep_Serv_Date Desc"

            If Me.txtRepFromDate.Text.Length < 8 Or Me.txtRepToDate.Text.Length < 8 Then
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            LA_Declarations.OpenConnection(Cn, Config.ConnectionString)
            'OpenConnection(Cn, Config.ConnectionStringAdo)

            lvReports.Refresh()
            lvReports.Update()

            With Me.lvReports.Items

                'Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
                Rs.Open(sQuery, Cn, 3, 3)
                While Not Rs.EOF
                    'MessageBox.Show(Rs.Fields("Rep_ID").Value)
                    CurrentItem = Nothing
                    'On Error Resume Next
                    CurrentItem = .Item("R" & Rs.Fields("Rep_ID").Value)
                    'CurrentItem = .Item("R" & GetValue(Rs.Fields("Rep_ID")))
                    'On Error GoTo 0
                    'Si existe ya en listview entonces verifico si hay algun cambio
                    'y de haber algun cambio entonces actualiso el item
                    If Not (CurrentItem Is Nothing) Then
                        If CurrentItem.Text <> LA_Declarations.GetValue(Rs.Fields("rep_serv_date")) Then _
                            CurrentItem.Text = LA_Declarations.GetValue(Rs.Fields("rep_serv_date"))
                        'UPGRADE_WARNING: Lower bound of collection CurrentItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        'UPGRADE_WARNING: Lower bound of collection CurrentItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        If _
                            CurrentItem.SubItems(1).Text <> LA_Declarations.GetReportType(LA_Declarations.GetValue(Rs.Fields("rep_type"), -1)) And
                            CurrentItem.SubItems.Count > 1 Then
                            CurrentItem.SubItems(1).Text = LA_Declarations.GetReportType(LA_Declarations.GetValue(Rs.Fields("rep_type"), -1))
                        Else
                            CurrentItem.SubItems.Insert(1,
                                                        New ListViewItem.ListViewSubItem(Nothing,
                                                            LA_Declarations.GetReportType(
                                                              LA_Declarations.GetValue(Rs.Fields("rep_type"), -1))))
                        End If
                        'UPGRADE_WARNING: Lower bound of collection CurrentItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        'UPGRADE_WARNING: Lower bound of collection CurrentItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        If _
                           CurrentItem.SubItems(2).Text <> LA_Declarations.GetValue(Rs.Fields("sc_sch_name")) And
                           CurrentItem.SubItems.Count > 2 Then
                            CurrentItem.SubItems(2).Text = LA_Declarations.GetValue(Rs.Fields("sc_sch_name"))
                        Else
                            CurrentItem.SubItems.Insert(2,
                                                        New ListViewItem.ListViewSubItem(Nothing,
                                                            LA_Declarations.GetValue(Rs.Fields("sc_sch_name"))))
                        End If
                        'UPGRADE_WARNING: Lower bound of collection CurrentItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        'UPGRADE_WARNING: Lower bound of collection CurrentItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        If _
                            CurrentItem.SubItems(3).Text <> LA_Declarations.GetValue(Rs.Fields("Rep_Year")) And
                            CurrentItem.SubItems.Count > 3 Then
                            CurrentItem.SubItems(3).Text = LA_Declarations.GetValue(Rs.Fields("Rep_Year"))
                        Else
                            CurrentItem.SubItems.Insert(3,
                                                        New ListViewItem.ListViewSubItem(Nothing,
                                                            LA_Declarations.GetValue(Rs.Fields("Rep_Year"))))
                        End If
                        'UPGRADE_WARNING: Lower bound of collection CurrentItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        'UPGRADE_WARNING: Lower bound of collection CurrentItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        If _
                            CurrentItem.SubItems(4).Text <> LA_Declarations.GetSemester(LA_Declarations.GetValue(Rs.Fields("Rep_Sem"), -1)) And
                            CurrentItem.SubItems.Count > 4 Then
                            CurrentItem.SubItems(4).Text = LA_Declarations.GetSemester(LA_Declarations.GetValue(Rs.Fields("Rep_Sem"), -1))
                        Else
                            CurrentItem.SubItems.Insert(4,
                                                        New ListViewItem.ListViewSubItem(Nothing,
                                                            LA_Declarations.GetSemester(LA_Declarations.GetValue(Rs.Fields("Rep_Sem"), -1))))
                        End If
                        'UPGRADE_WARNING: Lower bound of collection CurrentItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        'UPGRADE_WARNING: Lower bound of collection CurrentItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        If _
                            CurrentItem.SubItems(5).Text <>
                            IIf(GetValue(Rs.Fields("Rep_AcomRazonable"), False), "Yes", "No") And
                            CurrentItem.SubItems.Count > 5 Then
                            CurrentItem.SubItems(5).Text = IIf(LA_Declarations.GetValue(Rs.Fields("Rep_AcomRazonable"), False), "Yes", "No")
                        Else
                            CurrentItem.SubItems.Insert(5,
                                                        New ListViewItem.ListViewSubItem(Nothing,
                                                            IIf(LA_Declarations.GetValue(Rs.Fields("Rep_AcomRazonable"), False), "Yes", "No")))
                        End If
                        'UPGRADE_WARNING: Lower bound of collection CurrentItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        'UPGRADE_WARNING: Lower bound of collection CurrentItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        If _
                            CurrentItem.SubItems(6).Text <> IIf(LA_Declarations.GetValue(Rs.Fields("rep_reposicion"), False), "Yes", "No") And
                            CurrentItem.SubItems.Count > 6 Then
                            CurrentItem.SubItems(6).Text = IIf(LA_Declarations.GetValue(Rs.Fields("rep_reposicion"), False), "Yes", "No")
                        Else
                            CurrentItem.SubItems.Insert(6,
                                                        New ListViewItem.ListViewSubItem(Nothing,
                                                            IIf(LA_Declarations.GetValue(Rs.Fields("rep_reposicion"), False), "Yes", "No")))
                        End If
                    Else
                        'De no existir ese item entonces se añade al listview
                        'On Error Resume Next
                        CurrentItem = .Add("R" & Rs.Fields("Rep_ID").Value, LA_Declarations.GetValue(Rs.Fields("rep_serv_date")), "")
                        'UPGRADE_WARNING: Lower bound of collection CurrentItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        If CurrentItem.SubItems.Count > 1 Then
                            CurrentItem.SubItems(1).Text = GetReportType(LA_Declarations.GetValue(Rs.Fields("rep_type"), -1))
                        Else
                            CurrentItem.SubItems.Insert(1,
                                                        New ListViewItem.ListViewSubItem(Nothing,
                                                            LA_Declarations.GetReportType(LA_Declarations.GetValue(Rs.Fields("rep_type"), -1))))
                        End If
                        'UPGRADE_WARNING: Lower bound of collection CurrentItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        If CurrentItem.SubItems.Count > 2 Then
                            CurrentItem.SubItems(2).Text = LA_Declarations.GetValue(Rs.Fields("sc_sch_name"))
                        Else
                            CurrentItem.SubItems.Insert(2,
                                                        New ListViewItem.ListViewSubItem(Nothing,
                                                            LA_Declarations.GetValue(Rs.Fields("sc_sch_name"))))
                        End If
                        'UPGRADE_WARNING: Lower bound of collection CurrentItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        If CurrentItem.SubItems.Count > 3 Then
                            CurrentItem.SubItems(3).Text = LA_Declarations.GetValue(Rs.Fields("Rep_Year"))
                        Else
                            CurrentItem.SubItems.Insert(3,
                                                        New ListViewItem.ListViewSubItem(Nothing,
                                                            LA_Declarations.GetValue(Rs.Fields("Rep_Year"))))
                        End If
                        'UPGRADE_WARNING: Lower bound of collection CurrentItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        If CurrentItem.SubItems.Count > 4 Then
                            CurrentItem.SubItems(4).Text = GetSemester(GetValue(Rs.Fields("Rep_Sem"), -1))
                        Else
                            CurrentItem.SubItems.Insert(4,
                                                        New ListViewItem.ListViewSubItem(Nothing,
                                                         LA_Declarations.GetSemester(LA_Declarations.GetValue(Rs.Fields("Rep_Sem"), -1))))
                        End If
                        'UPGRADE_WARNING: Lower bound of collection CurrentItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        If CurrentItem.SubItems.Count > 5 Then
                            CurrentItem.SubItems(5).Text = IIf(LA_Declarations.GetValue(Rs.Fields("Rep_AcomRazonable")), "Yes", "No")
                        Else
                            CurrentItem.SubItems.Insert(5,
                                                        New ListViewItem.ListViewSubItem(Nothing,
                                                            IIf(LA_Declarations.GetValue(Rs.Fields("Rep_AcomRazonable")), "Yes", "No")))
                        End If
                        'UPGRADE_WARNING: Lower bound of collection CurrentItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                        If CurrentItem.SubItems.Count > 6 Then
                            CurrentItem.SubItems(6).Text = IIf(LA_Declarations.GetValue(Rs.Fields("rep_reposicion")), "Yes", "No")
                        Else
                            CurrentItem.SubItems.Insert(6,
                                                        New ListViewItem.ListViewSubItem(Nothing,
                                                            IIf(LA_Declarations.GetValue(Rs.Fields("rep_reposicion")), "Yes", "No")))
                        End If
                        ' On Error GoTo 0
                    End If
                    'Se marca el item con "1" en la propiedad de Tag para saber que este record
                    'ya fue chequeado por lo tanto existe en la base de datos
                    CurrentItem.Tag = "1"
                    Rs.MoveNext()

                End While

                'Verifico el listado de items buscando los items que no han sido chequeados para removerlose
                'del listados
            End With
            Dim i As Integer = 0
            While i <= Me.lvReports.Items.Count - 1
                'UPGRADE_WARNING: Lower bound of collection Me.lvReports.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                CurrentItem = Me.lvReports.Items.Item(i)
                If CurrentItem.Tag = "1" Then
                    CurrentItem.Tag = String.Empty
                    i += 1
                Else
                    Call Me.lvReports.Items.RemoveAt(CurrentItem.Index)
                End If
            End While
            Rs.Close()
            Cn.Close()

            Rs = Nothing
            Cn = Nothing

            Me.Cursor = Cursors.Default
            Frame1.Cursor = Cursors.Default
        Catch ex As Exception
            'MessageBox.Show(ex.Message + "\n" + ex.InnerException.Message + "\n" + ex.StackTrace)
            MsgBox(ex.Message)
        End Try

    End Sub

    ''' <remarks>
    '''           Called By: frmReportView.Resize()
    ''' </remarks>
    Sub SetControls()
        On Error Resume Next
        Frame1.Top = Me.Toolbar1.Height
        Frame1.Left = 0
        Frame1.Height = Microsoft.VisualBasic.Compatibility.VB6.TwipsToPixelsY(555)
        Frame1.Width = ClientRectangle.Width

        lvReports.Top =
            Microsoft.VisualBasic.Compatibility.VB6.TwipsToPixelsY(
                Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(Me.Toolbar1.Height) +
                Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(Me.Frame1.Height))
        lvReports.Left = 0
        lvReports.Height =
            Microsoft.VisualBasic.Compatibility.VB6.TwipsToPixelsY(
                Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(ClientRectangle.Height) -
                Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(lvReports.Top))
        lvReports.Width = ClientRectangle.Width
    End Sub
#End Region
    Public Sub Fill()
        Dim Cn As New ADODB.Connection
        Dim Rs As New ADODB.Recordset
        Dim sQuery As String
        Dim Item As ListViewItem

        sQuery = "SELECT Reports.*, SCHOOLS.SC_SCH_NAME "
        sQuery = sQuery & "FROM Reports LEFT OUTER JOIN "
        sQuery = sQuery & "SCHOOLS ON Reports.Rep_SCH_ID = SCHOOLS.SC_ID "

        OpenConnection(Cn, Config.ConnectionString)

        Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

        lvReports.Items.Clear()
        'lvReports.Update()
        
        While Not Rs.EOF
            Item = lvReports.Items.Add("R" & Rs.Fields("Rep_ID").Value, Rs.Fields("Rep_Date").Value, "")
            'UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If Item.SubItems.Count > 1 Then
                Item.SubItems(1).Text = GetReportType(GetValue(Rs.Fields("rep_type"), - 1))
            Else
                Item.SubItems.Insert(1,
                                     New ListViewItem.ListViewSubItem(Nothing,
                                                                      GetReportType(GetValue(Rs.Fields("rep_type"), - 1))))
            End If
            'UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If Item.SubItems.Count > 2 Then
                Item.SubItems(2).Text = GetValue(Rs.Fields("sc_sch_name"))
            Else
                Item.SubItems.Insert(2, New ListViewItem.ListViewSubItem(Nothing, GetValue(Rs.Fields("sc_sch_name"))))
            End If
            'UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If Item.SubItems.Count > 3 Then
                Item.SubItems(3).Text = GetValue(Rs.Fields("Rep_Year"))
            Else
                Item.SubItems.Insert(3, New ListViewItem.ListViewSubItem(Nothing, GetValue(Rs.Fields("Rep_Year"))))
            End If
            'UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If Item.SubItems.Count > 4 Then
                Item.SubItems(4).Text = GetSemester(GetValue(Rs.Fields("Rep_Sem"), - 1))
            Else
                Item.SubItems.Insert(4,
                                     New ListViewItem.ListViewSubItem(Nothing,
                                                                      GetSemester(GetValue(Rs.Fields("Rep_Sem"), - 1))))
            End If
            Rs.MoveNext()
        End While
        Rs.Close()
        Cn.Close()
    End Sub
    'TODO
    
 


    Private Sub cmdRepRefresh_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) _
        Handles cmdRepRefresh.Click

        Me.Fill2()
    End Sub

    Private Sub Command1_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) 
        On Error GoTo err_rtn
        Dim a As Object

        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        a = Me.txtRepFromDate.Text
        'ShowCalendar(a, Me.txtRepFromDate)
        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Me.txtRepFromDate.Text = a

        err_cont:
        Exit Sub

        err_rtn:
        MsgBox("Calendar cann't be display")
        Resume err_cont
    End Sub

    Private Sub Command2_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) 
        On Error GoTo err_rtn
        Dim a As Object

        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        a = Me.txtRepToDate.Text
        'ShowCalendar(a, Me.txtRepToDate)
        'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Me.txtRepToDate.Text = a

        err_cont:
        Exit Sub

        err_rtn:
        MsgBox("Calendar can't be display")
        Resume err_cont
    End Sub

    Private Sub lvReports_DoubleClick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) _
        Handles lvReports.DoubleClick


        If Not lvReports.FocusedItem Is Nothing Then
            frmEditReport.RepID = GetIDFromKey(lvReports.FocusedItem.Name)
            frmEditReport.ShowDialog()
        End If
    End Sub

    Private Sub lvReports_MouseUp(ByVal eventSender As Object, ByVal eventArgs As MouseEventArgs) _
        Handles lvReports.MouseUp
        Dim Button As Short = eventArgs.Button\&H100000
        Dim Shift As Short = ModifierKeys\&H10000
        Dim X As Single = Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsX(eventArgs.X)
        Dim y As Single = Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(eventArgs.Y)
        If Button = 2 Then
            If Not lvReports.GetItemAt(X, y) Is Nothing Then
                'UPGRADE_ISSUE: Form method frmReportView.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'PopupMenu(frmMain.mnuRep_RMenu)
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Timer1.Tick
        Me.Fill2()
    End Sub

    
    Private Sub txtRepFromDate_Validating(ByVal eventSender As Object, ByVal eventArgs As CancelEventArgs) _
        
        Dim Cancel As Boolean = eventArgs.Cancel


        If Me.txtRepFromDate.Text.Length = 0 Then
            GoTo EventExitSub
        End If

        If InStr(1, Me.txtRepFromDate.Text, "/") = 0 Then
            MsgBox("Enter a valid date format", MsgBoxStyle.Information, "LearnAID")
            Cancel = True
            GoTo EventExitSub
        End If

        Me.txtRepFromDate.Text = Microsoft.VisualBasic.Compatibility.VB6.Format(Me.txtRepFromDate.Text, "mm/dd/yyyy")
        If Me.txtRepFromDate.Text <> "" And Not IsDbNull(Me.txtRepFromDate.Text) Then

            If Me.txtRepFromDate.Text.Length > 10 Then
                MsgBox("Enter a valid date", MsgBoxStyle.Information, "LearnAID")
                Cancel = True
                GoTo EventExitSub
            End If


            If IsDate(Me.txtRepFromDate.Text) = False Then
                MsgBox("Enter a valid date format", MsgBoxStyle.Information, "LearnAID")
                Cancel = True
                GoTo EventExitSub
            End If

            If Year(CDate(Me.txtRepFromDate.Text)) <= 1980 Or Year(CDate(Me.txtRepFromDate.Text)) >= 2200 Then
                MsgBox("Enter a valid year", MsgBoxStyle.Information, "LearnAID")
                Cancel = True
                GoTo EventExitSub
            End If

            txtRepFromDate.Text = CStr(CDate(txtRepFromDate.Text))
        End If


        EventExitSub:
        eventArgs.Cancel = Cancel
    End Sub

    Private Sub txtRepToDate_Validating(ByVal eventSender As Object, ByVal eventArgs As CancelEventArgs) _
        
        Dim Cancel As Boolean = eventArgs.Cancel


        If Me.txtRepToDate.Text.Length = 0 Then
            GoTo EventExitSub
        End If

        If InStr(1, Me.txtRepToDate.Text, "/") = 0 Then
            MsgBox("Enter a valid date format", MsgBoxStyle.Information, "LearnAID")
            Cancel = True
            GoTo EventExitSub
        End If

        Me.txtRepToDate.Text = Microsoft.VisualBasic.Compatibility.VB6.Format(Me.txtRepToDate.Text, "mm/dd/yyyy")
        If Me.txtRepToDate.Text <> "" And Not IsDBNull(Me.txtRepToDate.Text) Then

            If Me.txtRepToDate.Text.Length > 10 Then
                MsgBox("Enter a valid date", MsgBoxStyle.Information, "LearnAID")
                Cancel = True
                GoTo EventExitSub
            End If


            If IsDate(Me.txtRepToDate.Text) = False Then
                MsgBox("Enter a valid date format", MsgBoxStyle.Information, "LearnAID")
                Cancel = True
                GoTo EventExitSub
            End If

            If Year(CDate(Me.txtRepToDate.Text)) <= 1980 Or Year(CDate(Me.txtRepToDate.Text)) >= 2200 Then
                MsgBox("Enter a valid year", MsgBoxStyle.Information, "LearnAID")
                Cancel = True
                GoTo EventExitSub
            End If

            txtRepToDate.Text = CStr(CDate(txtRepToDate.Text))
        End If

        EventExitSub:
        eventArgs.Cancel = Cancel
    End Sub
End Class