Option Strict Off
Option Explicit On

Imports Microsoft.VisualBasic.Compatibility

Namespace Forms.AccountingForms
    Friend Class frmAccountingView
        Inherits System.Windows.Forms.Form
#Region "LEVEL ONE ROUTINES"
        Private Sub frmAccountingView_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
            Fill()
        End Sub
        Private Sub lvAccounting_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvAccounting.DoubleClick
            Dim ParentID As Integer
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset

            If Not Me.lvAccounting.FocusedItem Is Nothing Then
                ParentID = CInt(Mid(Me.lvAccounting.FocusedItem.Name, 2))
            Else
                Exit Sub
            End If

            'TEST CODE START
            'sQuery = "SELECT * FROM Nomina_General WHERE NG_ID = " & ParentID"
            'If Gateway.HasConnection = True Then
            ' Gateay.Pass("SEARCH",sQuery)
            'End If
            'TEST CODE END


            'OpenConnection(Cn, Config.ConnectionString)
            OpenConnection(Cn, Config.ConnectionStringAdo)

            Rs.Open("Select * From Nomina_General Where NG_ID =" & ParentID, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            If Rs.Fields("NG_Status").Value = "C" Then
                frmnomina.cmdCompleted.Enabled = True
                frmnomina.cmdSave.Enabled = True
                frmnomina.cmdAdjustments.Enabled = True
                frmnomina.cmdProcess.Enabled = True
            End If

            frmnomina.txtFrom.Text = Rs.Fields("NG_From").Value
            frmnomina.txtTo.Text = Rs.Fields("NG_To").Value
            frmnomina.Tag = "AUTO"
            frmnomina.ShowDialog()
        End Sub
        Private Sub Toolbar_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Add.Click, PrintReport.Click
            Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
            Select Case Button.Name
                Case "Add"
                    AddNomina()
                Case "ViewActualReport"
                Case "CreateReport"
                    Call LA_Declarations.CreateNomina()
                Case "PrintReport"
                    If Not Me.lvAccounting.FocusedItem Is Nothing Then
                        frmPrintNomina.dNominaID = GetIDFromKey(lvAccounting.FocusedItem.Name)
                        frmPrintNomina.ShowDialog()
                    End If
            End Select
        End Sub
#End Region
#Region "LEVEL TWO ROUTINES"
        Sub AddNomina()
            Dim dtnextmonthfirstday As Date
            Dim dtnextmonth As Date
            If isNominaPending() Then
                MsgBox("There's currently a pending payroll record.", MsgBoxStyle.Information)
            Else
                frmnomina.txtFrom.Text = Month(Today) & "/" & "1" & "/" & Year(Today)

                '-- Get the last day of this month
                dtnextmonth = DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, Today)
                dtnextmonthfirstday = CDate(Month(dtnextmonth).ToString & "/" & "1" & "/" & Year(dtnextmonth).ToString)

                frmnomina.txtTo.Text = CStr(DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, dtnextmonthfirstday))
                frmnomina.Tag = "NEW"
                frmnomina.ShowDialog()
            End If
        End Sub
        Sub Fill()
            Dim Item As System.Windows.Forms.ListViewItem

            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset

            Dim iCounter1 As Integer = 0

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

            'TEST CODE START
            'sQuery = "SELECT * FROM Nomina_General Order By NG_ID DESC" & ParentID"
            'If Gateway.HasConnection = True Then
            ' Gateay.Pass("SEARCH",sQuery)
            'End If
            'TEST CODE END


            OpenConnection(Cn, Config.ConnectionStringAdo)

            Rs.Open("Select * From Nomina_General Order By NG_ID DESC", Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            While Not Rs.EOF
                Item = Nothing

                On Error Resume Next
                Item = lvAccounting.Items.Item("A" & Rs.Fields("NG_ID").Value)
                On Error GoTo 0

                If Item Is Nothing Then
                    'Add the item
                    Item = lvAccounting.Items.Add("A" & Rs.Fields("NG_ID").Value, GetValue(Rs.Fields("NG_From")), "")
                    If Item.SubItems.Count > 1 Then
                        Item.SubItems(1).Text = GetValue(Rs.Fields("NG_To").Value)
                    Else
                        Item.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, GetValue(Rs.Fields("NG_To"))))
                    End If
                    If Item.SubItems.Count > 2 Then
                        Item.SubItems(2).Text = GetValue(Rs.Fields("NG_TotalExaminer"))
                    Else
                        Item.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, GetValue(Rs.Fields("NG_TotalExaminer"))))
                    End If
                    If Item.SubItems.Count > 3 Then
                        Item.SubItems(3).Text = FormatCurrency(GetValue(Rs.Fields("NG_TotalPaid"), 0))
                    Else
                        'Item.SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, FormatCurrency(GetValue(Rs.Fields("NG_TotalPaid"), 0))))
                        Item.SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, GetValue(Rs.Fields("NG_TotalPaid"))))
                    End If
                    If Item.SubItems.Count > 4 Then
                        Item.SubItems(4).Text = GetValue(Rs.Fields("NG_Status"))
                    Else
                        Item.SubItems.Insert(4, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, GetValue(Rs.Fields("NG_Status"))))
                    End If
                    Item.Tag = "1"
                Else
                    'update the item
                    If Item.Text <> GetValue(Rs.Fields("NG_From")) Or Item.SubItems(1).Text <> GetValue(Rs.Fields("NG_To")) Or Item.SubItems(2).Text <> GetValue(Rs.Fields("NG_TotalExaminer"), "") Or Item.SubItems(3).Text <> FormatCurrency(GetValue(Rs.Fields("NG_TotalPaid"), 0)) Or Item.SubItems(4).Text <> GetValue(Rs.Fields("NG_Status")) Then
                        Item.Text = GetValue(Rs.Fields("NG_From"))
                        If Item.SubItems.Count > 1 Then
                            Item.SubItems(1).Text = GetValue(Rs.Fields("NG_To"))
                        Else
                            Item.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, GetValue(Rs.Fields("NG_To"))))
                        End If
                        If Item.SubItems.Count > 2 Then
                            Item.SubItems(2).Text = GetValue(Rs.Fields("NG_TotalExaminer"))
                        Else
                            Item.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, GetValue(Rs.Fields("NG_TotalExaminer"))))
                        End If
                        If Item.SubItems.Count > 3 Then
                            Item.SubItems(3).Text = FormatCurrency(GetValue(Rs.Fields("NG_TotalPaid")))
                        Else
                            Item.SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, FormatCurrency(GetValue(Rs.Fields("NG_TotalPaid")))))
                        End If
                        If Item.SubItems.Count > 4 Then
                            Item.SubItems(4).Text = GetValue(Rs.Fields("NG_Status"))
                        Else
                            Item.SubItems.Insert(4, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, GetValue(Rs.Fields("NG_Status"))))
                        End If
                    End If
                End If
                Item.Tag = "1"
                Rs.MoveNext()
            End While



            While iCounter1 < lvAccounting.Items.Count - 1
                iCounter1 += 1
                If lvAccounting.Items.Item(iCounter1).Tag = "1" Then
                    lvAccounting.Items.Item(iCounter1).Tag = ""
                Else
                    lvAccounting.Items.RemoveAt(iCounter1)
                    iCounter1 -= 1
                End If
            End While
            Rs.Close()
            Cn.Close()

            Me.Cursor = Cursors.Default
        End Sub
#End Region
#Region "LEVEL THREE ROUTINES"
        'Called By: AddNomina()
        Function isNominaPending() As Boolean
            isNominaPending = False
            Dim iCounter1 As Integer = 0
            For iCounter1 = 0 To Me.lvAccounting.Items.Count - 1
                If Me.lvAccounting.Items.Item(iCounter1).SubItems(4).Text = "P" Then
                    isNominaPending = True
                End If
            Next iCounter1
        End Function
#End Region
    End Class
End Namespace