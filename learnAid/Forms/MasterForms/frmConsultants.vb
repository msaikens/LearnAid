Option Strict Off
Option Explicit On

Imports learnAid.BLL
Imports learnAid.Forms.InheritableForms
Imports Microsoft.VisualBasic.Compatibility

Namespace Forms.MasterForms
    Friend Class frmConsultants
        Inherits frmBaseWithNoCloseButton
#Region "LEVEL ONE ROUTINES"
        Private Sub frmConsultants_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
            Me.Left = 0
            Me.FillList()
        End Sub
        'UPGRADE_WARNING: Event frmConsultants.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub frmConsultants_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
            Call SetLV()
        End Sub
        Private Sub lvCons_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvCons.DoubleClick
            If Not lvCons.FocusedItem Is Nothing Then
                frmNewConsultant.iConsID = GetIDFromKey(lvCons.FocusedItem.Name)
                frmNewConsultant.ShowDialog()
                Call FillList()
            End If
        End Sub
        Private Sub lvCons_MouseClick(sender As Object, e As MouseEventArgs) Handles lvCons.MouseClick
            If Not lvCons.FocusedItem Is Nothing Then
                Dim iConsId = GetIDFromKey(lvCons.FocusedItem.Name)
                frmMain.FormProperty.FillWithConsultant(iConsId)
            End If
        End Sub
        Private Sub lvCons_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lvCons.MouseUp
            Dim Button As Short = eventArgs.Button \ &H100000
            Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
            Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
            Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
            Dim Item As System.Windows.Forms.ListViewItem

            If Button = 2 Then

                Item = lvCons.GetItemAt(X, y)
                If Not Item Is Nothing Then
                    Me.mnuDelete.Enabled = True
                    Me.mnuEdit.Enabled = True
                Else
                    Me.mnuDelete.Enabled = False
                    Me.mnuEdit.Enabled = False
                End If
            End If
        End Sub
        Public Sub mnuAdd_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAdd.Click, AddToolStripMenuItem.Click
            frmNewConsultant.ShowDialog()
            Call FillList()
        End Sub
        Public Sub mnuDelete_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuDelete.Click, DeleteToolStripMenuItem.Click
            If Not lvCons.FocusedItem Is Nothing Then
                Call DeleteConsultant(GetIDFromKey(lvCons.FocusedItem.Name))
                Call FillList()
            End If
        End Sub
        Public Sub mnuEdit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEdit.Click, EditToolStripMenuItem.Click
            If Not lvCons.FocusedItem Is Nothing Then
                frmNewConsultant.iConsID = GetIDFromKey(lvCons.FocusedItem.Name)
                frmNewConsultant.ShowDialog()
                Call FillList()
            End If
        End Sub
        Public Sub mnuHide_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHide.Click
            'Call frmMain.mnuViewConsultants_Click(Nothing, New System.EventArgs())
        End Sub
        Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Add.Click, Edit.Click, Delete.Click
            Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)

            Select Case Button.Name
                Case "Add"
                    frmNewConsultant.iConsID = 0
                    frmNewConsultant.ShowDialog()
                    Call FillList()
                Case "Edit"
                    If Not lvCons.FocusedItem Is Nothing Then
                        frmNewConsultant.iConsID = GetIDFromKey(lvCons.FocusedItem.Name)
                        frmNewConsultant.ShowDialog()
                        Call FillList()
                    End If
                Case "Delete"
                    If Not lvCons.FocusedItem Is Nothing Then
                        Call DeleteConsultant(GetIDFromKey(lvCons.FocusedItem.Name))
                        Call FillList()
                    End If
            End Select
        End Sub
#End Region
#Region "LEVEL TWO ROUTINES"

        Sub DeleteConsultant(ByRef ID As Integer)
            Dim Cn As New ADODB.Connection
            Dim Cm As New ADODB.Command

            OpenConnection(Cn, Config.ConnectionString)

            Cm.ActiveConnection = Cn

            Cm.CommandText = "DELETE FROM Consultants Where CON_ID =" & ID
            Cm.Execute()
            Cn.Close()
        End Sub
        Sub FillList()
            'Dim Cn As New ADODB.Connection
            'Dim Rs As New ADODB.Recordset
            'Dim sName As String

            'OpenConnection(Cn, Config.ConnectionString)

            'lvCons.Items.Clear()

            'Rs.Open("Select * From Consultants order by con_name,con_lname1,con_lname2", Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            'While Not Rs.EOF
            '    sName = Trim(GetValue(Rs.Fields("CON_NAME")) & " " & GetValue(Rs.Fields("Con_LName1")) & " " & GetValue(Rs.Fields("Con_LName2")))
            '    lvCons.Items.Add("C" & Rs.Fields("CON_ID").Value, sName, "Consultant")
            '    Rs.MoveNext()
            'End While

            'Rs.Close()
            'Cn.Close()
            Dim sQuery As String = "Select * From Consultants order by con_name,con_lname1,con_lname2"
            Dim sName As String
            Dim dt As DataTable = GlobalResources.ExecuteDataTable(sQuery)
            Dim iCounter1 As Integer
            lvCons.Items.Clear()
            If (dt.Rows.Count > 0) Then
                For iCounter1 = 0 To dt.Rows.Count - 1
                    sName = Trim(dt.Rows(iCounter1)("CON_NAME").ToString() & " " & dt.Rows(iCounter1)("Con_LName1").ToString() & " " & dt.Rows(iCounter1)("Con_LName2"))
                    lvCons.Items.Add("C" & dt.Rows(iCounter1)("CON_ID").ToString(), sName, "Consultant")
                Next
            End If
        End Sub
        Sub SetLV()
            On Error Resume Next
            lvCons.Top = Toolbar1.Height
            lvCons.Left = 0
            lvCons.Width = ClientRectangle.Width
            lvCons.Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(ClientRectangle.Height) - VB6.PixelsToTwipsY(lvCons.Top))
        End Sub
#End Region

        
    End Class
End Namespace