Option Strict Off
Option Explicit On

Imports ADODB

Namespace Forms.ReportForms

    Friend Class frmPreviousRpts
        Inherits Form
        Public Sch As Integer
        Public SchName As String
        Public RepType As Short

#Region "LEVEL ONE ROUTINES"
        'Called From : frmSchools.PreviousReportsToolStripMenuItem_Click()
        Private Sub frmPreviousRpts_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
            FillList()
        End Sub
        'UPGRADE_WARNING: Event frmPreviousRpts.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub frmPreviousRpts_Resize(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Resize
            Call SetLV()
        End Sub
        Private Sub cmdClose_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdClose.Click
            Me.Close()
        End Sub
        Private Sub cmdPrint_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdPrint.Click
            If Not Me.lvReports.FocusedItem Is Nothing Then
                frmPrintReport.iRepID = GetIDFromKey(lvReports.FocusedItem.Name)
                frmPrintReport.ShowDialog()
            End If
        End Sub
#End Region
#Region "LEVEL TWO ROUTINES"
        'Called By: frmPreviousReports_Load()
        Sub FillList()
            Dim sQuery As String
            Dim Cn As New Connection
            Dim Rs As New Recordset
            Dim Item As ListViewItem

            sQuery = "Select * From Reports Where "
            sQuery &= " Rep_SCH_ID = " & Me.Sch & " Order by Rep_serv_date Desc"

            OpenConnection(Cn, Config.ConnectionString)

            Rs.Open(sQuery, Cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)

            While Not Rs.EOF
                Item = Me.lvReports.Items.Add("R" & Rs.Fields("Rep_ID").Value, Rs.Fields("Rep_Date").Value, "")
                ''UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                ''UPGRADE_WARNING: DateValue has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'

                If GetValue(Rs.Fields("rep_serv_date")) <> String.Empty And Item.SubItems.Count > 1 Then
                    Item.SubItems(1).Text = DateValue(GetValue(Rs.Fields("rep_serv_date"))).ToString.Trim
                Else
                    Item.SubItems.Insert(1,
                                         New ListViewItem.ListViewSubItem(Nothing,
                                                                          CStr(GetValue(Rs.Fields("rep_serv_date")))))
                End If
                ''UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                If Item.SubItems.Count > 2 Then
                    Item.SubItems(2).Text = GetSemester(GetValue(Rs.Fields("Rep_Sem"), 0))
                Else
                    Item.SubItems.Insert(2,
                                         New ListViewItem.ListViewSubItem(Nothing,
                                                                          GetSemester(GetValue(Rs.Fields("Rep_Sem"), 0))))
                End If
                ''UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                If Item.SubItems.Count > 2 Then
                    Item.SubItems(2).Text = GetReportType(GetValue(Rs.Fields("rep_type"), 0))
                Else
                    Item.SubItems.Insert(2,
                                         New ListViewItem.ListViewSubItem(Nothing,
                                                                          GetReportType(GetValue(Rs.Fields("rep_type"), 0))))
                End If
                Rs.MoveNext()
            End While

            If Rs.RecordCount = 0 Then
                Me.lvReports.Items.Add("No Previous Reports...")
                cmdPrint.Enabled = False
            End If

            Me.Text = "Previous Reports for " & SchName & " (" & Rs.RecordCount & ")"
            Rs.Close()
            Cn.Close()
        End Sub

        'Called By: frmPreviousRpts_Resize()
        Sub SetLV()
            lvReports.Top = 0
            lvReports.Left = 0
            lvReports.Width = ClientRectangle.Width
            lvReports.Height =
                Microsoft.VisualBasic.Compatibility.VB6.TwipsToPixelsY(
                    Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(ClientRectangle.Height) - 550)

            cmdClose.Top =
                Microsoft.VisualBasic.Compatibility.VB6.TwipsToPixelsY(
                    Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(ClientRectangle.Height) - 450)
            cmdPrint.Top =
                Microsoft.VisualBasic.Compatibility.VB6.TwipsToPixelsY(
                    Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(ClientRectangle.Height) - 450)
        End Sub
        #End Region
    End Class
End Namespace