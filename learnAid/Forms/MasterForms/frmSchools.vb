Option Strict Off
Option Explicit On

Imports learnAid.BLL
Imports Microsoft.VisualBasic.Compatibility

Namespace Forms.MasterForms
    Friend Class frmSchools
        Inherits InheritableForms.frmBaseWithNoCloseButton
#Region "LEVEL ONE ROUTINES"
        Private Sub frmSchools_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
            Me.Top = 0
            Me.Left = 0
            Me.FillList()
        End Sub
        Private Sub AddEditPreJobsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEditPreJobsToolStripMenuItem.Click
            If Not Me.lvSchools.FocusedItem Is Nothing Then
                'frmPreJob.iSchoolID = GetIDFromKey(Me.lvSchools.FocusedItem.Name)
                sch_name = Me.lvSchools.FocusedItem.Text.Trim
                GlobalVariables.sch_name = Me.lvSchools.FocusedItem.Text.Trim
                frmPreJob.ShowDialog()

            End If
        End Sub
        Private Sub lvSchools_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvSchools.DoubleClick
            EditSchool()
        End Sub
        Private Sub lvSchools_MouseClick(sender As Object, e As MouseEventArgs) Handles lvSchools.MouseClick
            If Not lvSchools.FocusedItem Is Nothing Then
                Dim schoolID = GetIDFromKey(lvSchools.FocusedItem.Name)
                frmMain.FormProperty.FillWithSchool(schoolID)
            End If
        End Sub
        Public Sub mnuAdd_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAdd.Click, AddSchoolToolStripMenuItem.Click
            AddSchool()
        End Sub
        Public Sub mnuDelete_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuDelete.Click, DeleteSchoolToolStripMenuItem.Click
            Call DeleteSchool()
        End Sub
        Public Sub mnuView_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuView.Click, ViewEditSchoolInfoToolStripMenuItem.Click
            EditSchool()
        End Sub
        Private Sub PreviousReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviousReportsToolStripMenuItem.Click
            If Not Me.lvSchools.FocusedItem Is Nothing Then
                ReportForms.frmPreviousRpts.SchName = Me.lvSchools.FocusedItem.Text
                ReportForms.frmPreviousRpts.Sch = GetIDFromKey(Me.lvSchools.FocusedItem.Name)
                ReportForms.frmPreviousRpts.Show()
            End If
        End Sub
        Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Add.Click, Edit.Click, Delete.Click, Inactive.Click
            Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
            Select Case Button.Name
                Case "Add"
                    Call AddSchool()
                Case "Delete"
                    Call DeleteSchool()
                Case "Edit"
                    Call EditSchool()
                Case "Inactive"
                    frmInactiveSchools.Show()
            End Select
        End Sub
#End Region

#Region "LEVEL TWO ROUTINES"
        'Called By: frmSchools.mnuAdd_Click()
        'Called By: frmSchools.Toolbar1_ButtonCLick()
        Sub AddSchool()
            With frmEditSchool
                .Edit = False
                .ShowDialog()
                If .bCancel = False Then
                    Me.FillList()
                End If
                frmEditSchool.Close()
            End With
        End Sub
        'Called By: frmSchools.mnuDelete_Click()
        'Called By: frmSchools.Toolbar1_ButtonCLick()
        Sub DeleteSchool()
            Dim Cn As ADODB.Connection
            Dim delOk As Boolean = False

            If MsgBox("Esta seguro de borrar la escuela seleccionada?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Borrar Escuela") = MsgBoxResult.Yes Then
                If MsgBox("Una vez borrada, no se puede acceder los informes creados a ella. ¿Desea Continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    delOk = True
                End If
            End If

            If delOk = False Then
                Exit Sub
            End If

            With lvSchools
                If Not (.FocusedItem Is Nothing) Then
                    If Not .FocusedItem.Text = "Root" Then
                        Cn = New ADODB.Connection
                        OpenConnection(Cn, Config.ConnectionString)
                        Cn.Execute("DELETE FROM Schools WHERE SC_ID = " & GetIDFromKey(lvSchools.FocusedItem.Name))
                        Cn.Close()
                        Call FillList()
                    Else
                        MsgBox("Please select a school.", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox("Please select a school.", MsgBoxStyle.Information)
                End If
            End With
        End Sub
        'Called By: frmSchools.lvSchools_DoubleClick()
        'Called By: frmSchools.mnuView_Click()
        'Called By: frmSchools.Toolbar1_ButtonCLick()
        Sub EditSchool()
            If Me.lvSchools.FocusedItem Is Nothing Then
                MsgBox("Select a School first.", MsgBoxStyle.Information)
                Exit Sub
            End If

            With frmEditSchool
                .Edit = True
                .iSchoolID = GetIDFromKey(Me.lvSchools.FocusedItem.Name)
                .ShowDialog()
                If .bCancel = False Then
                    Me.FillList()
                End If
                frmEditSchool.Close()
            End With

        End Sub
#End Region

#Region "LEVEL THREE ROUTINES"
        'Called By: frmSchools.AddSchool()
        'Called By: frmSchools.DeleteSchool()
        'Called By: frmSchools.EditSchool()

        ''' <summary>
        ''' 
        ''' 
        ''' </summary>
        ''' <remarks>
        '''            'Called By: frmSchools_Load()
        ''' </remarks>
        Public Sub FillList()
            'Dim Cn As ADODB.Connection
            'Dim Rs As ADODB.Recordset

            'Cn = New ADODB.Connection
            'Rs = New ADODB.Recordset

            'OpenConnection(Cn, Config.ConnectionString)

            'Rs.Open("Select * From Schools ORDER BY SC_SCH_NAME ASC ", Cn)

            'With lvSchools.Items
            '    .Clear()

            '    While Not Rs.EOF
            '        .Add("S" & Rs.Fields("sc_id").Value, Rs.Fields("sc_sch_name").Value & "(" & Rs.Fields("sc_city").Value, "School")
            '        Rs.MoveNext()
            '    End While

            'End With

            'Rs.Close()
            'Cn.Close()

            Dim sQuery As String = "Select sc_id, sc_sch_name + ' (' + sc_city +')' sch_name From SChools Order By SC_SCH_Name ASC"
            Dim dt As DataTable = GlobalResources.ExecuteDataTable(sQuery)
            Dim iCounter1 As Integer
            If (dt.Rows.Count > 0) Then
                With lvSchools.Items
                    .Clear()
                    For iCounter1 = 0 To dt.Rows.Count - 1
                        .Add("S" & dt.Rows(iCounter1)("sc_id").ToString(), dt.Rows(iCounter1)("sch_name").ToString(), "School")
                    Next iCounter1
                End With
            End If
        End Sub

#End Region
#Region "Unknown/Unused Routines"
        'UPGRADE_ISSUE: MSComctlLib.ListView event lvSchools.ItemClick was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
        Private Sub lvSchools_ItemClick(ByVal Item As System.Windows.Forms.ListViewItem)
            'Call frmProperties.FillWithSchool(GetIDFromKey((Item.Name)))
        End Sub
        Public Sub mnuDock_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuDock.Click
            'UPGRADE_WARNING: Couldn't resolve default property of object frmMain.TabDock. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'With frmMain.TabDock

            '	'UPGRADE_WARNING: Couldn't resolve default property of object frmMain.TabDock. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	If .DockedForms("frmSchools").state = TabDock.tdDockedState.tdDocked Then
            '		'UPGRADE_WARNING: Couldn't resolve default property of object frmMain.TabDock. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '		Call .FormUndock("frmSchools")
            '	Else
            '		'UPGRADE_WARNING: Couldn't resolve default property of object frmMain.TabDock. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '		Call .FormDock("frmSchools")
            '	End If

            'End With

        End Sub
        Public Sub ShowDockMenu()
            ''UPGRADE_WARNING: Couldn't resolve default property of object frmMain.TabDock. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'If frmMain.TabDock.DockedForms("frmSchools").state = TabDock.tdDockedState.tdDocked Then
            '	mnuDock.Text = "UnDock"
            'Else
            '	mnuDock.Text = "Dock"
            'End If
            ''UPGRADE_ISSUE: Form method frmSchools.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            '      'PopupMenu(mnuDockMenu)
        End Sub
#End Region

    End Class
End Namespace