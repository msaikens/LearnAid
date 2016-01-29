Option Strict Off
Option Explicit On

Imports Microsoft.VisualBasic.Compatibility

Namespace Forms.MasterForms
    Friend Class frmEditClave
        Inherits System.Windows.Forms.Form
        Dim EditingCell As Boolean
        Dim iDestreza As Short
        Dim EditingDes As Boolean
        Public ClaveID As Integer
        Dim colCels As New Collection
        Dim Category As String
        Dim ClaveType As String
        Dim EditedCell As CellType
        Dim isPEP As Boolean

        Private Structure CellType
            Dim Row As Short
            Dim Col As Short
        End Structure

        Private Structure DesType
            Dim DesName As String
            Dim DesABR As String
            Dim Desc As String
        End Structure

        'UPGRADE_WARNING: Lower bound of array Destrezas was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
        Dim Destrezas(10) As DesType
#Region "LEVEL ONE ROUTINES"
        Private Sub frmEditClave_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
            Dim iCounter1 As Integer
            Call SetGrid()

            'DIST 30
            'NORMAL WIDTH 615
            'EXTENDED WIDTH 735

            If ClaveID = 52 Then 'PEP
                isPEP = True
                Me.Toolbar1.Items.Item("EditDestreza").Enabled = False
            End If

            Call LoadData()

            fraDes.Enabled = False
            fraEditCell.Visible = False
            fraEditCell.Enabled = False
            EnableTextBox((False))

            For iCounter1 = 1 To 99
                cboA(0).Items.Add(iCounter1)
            Next iCounter1
            For iCounter1 = 1 To 6
                cboA(1).Items.Add(iCounter1)
            Next iCounter1
            cboA(1).Items.Add("S")
            cboA(1).Items.Add("N")
            ShowDestrezaInfo()

        End Sub
        Private Sub cboA_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles cboA.KeyDown
            Dim KeyCode As Short = eventArgs.KeyCode
            Dim Shift As Short = eventArgs.KeyData \ &H10000
            Dim Index As Short = cboA.GetIndex(eventSender)
            Select Case KeyCode
                Case System.Windows.Forms.Keys.Left
                    If Index = 1 Then
                        If cboA(1).SelectionStart = 0 Then cboA(0).Focus()
                    End If
                Case System.Windows.Forms.Keys.Right
                    If Index = 0 Then
                        If cboA(0).SelectionStart = Len(cboA(0).Text) Then cboA(1).Focus()
                    End If
                Case 13
                    SaveCellInfo()
                Case System.Windows.Forms.Keys.Tab
                    If Index = 0 Then
                        cboA(1).Focus()
                    Else
                        cboA(0).Focus()
                    End If
            End Select
        End Sub
        Private Sub cboA_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboA.Leave
            Dim Index As Short = cboA.GetIndex(eventSender)
            If Not EditingCell Then SaveCellInfo()
        End Sub
        Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
            Me.Close()
        End Sub
        Private Sub cmdCancel_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles cmdCancel.KeyDown
            Dim KeyCode As Short = eventArgs.KeyCode
            Dim Shift As Short = eventArgs.KeyData \ &H10000
            'If KeyCode = System.Windows.Forms.Keys.Tab Then Grid.Focus()
        End Sub
        Private Sub cmdCancel_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdCancel.MouseDown
            Dim Button As Short = eventArgs.Button \ &H100000
            Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
            Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
            Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
            EditingCell = False
            EditingDes = False
        End Sub
        Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
            Call CreateNewClaveRecord()
            Me.Close()
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
            EditingCell = False
            EditingDes = False
        End Sub
        Private Sub frmEditClave_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
            Dim Button As Short = eventArgs.Button \ &H100000
            Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
            Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
            Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
            EditingCell = False
            EditingDes = False
        End Sub
        Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar1_Button1.Click, _Toolbar1_Button2.Click, _Toolbar1_Button3.Click
            Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
            Select Case Button.Name
                Case "EditClave"
                    EditCellInfo()
                Case "EditDestreza"
                    ShowDestrezaInfo()
                    EditDestrezaInfo()
            End Select
        End Sub
        Private Sub Toolbar1_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Toolbar1.MouseDown
            Dim Button As Short = eventArgs.Button \ &H100000
            Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
            Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
            Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
            EditingCell = False
            EditingDes = False
        End Sub
        Private Sub txtDes_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtDes.KeyDown
            Dim KeyCode As Short = eventArgs.KeyCode
            Dim Shift As Short = eventArgs.KeyData \ &H10000
            Dim Index As Short = txtDes.GetIndex(eventSender)
            Select Case KeyCode
                Case System.Windows.Forms.Keys.Up
                    If Index > 0 Then
                        txtDes(Index - 1).Focus()
                    End If
                Case System.Windows.Forms.Keys.Down
                    If Index < 2 Then
                        txtDes(Index + 1).Focus()
                    End If
                Case 13
                    SaveDestrezaInfo()
                Case System.Windows.Forms.Keys.Tab
                    If Index = 2 Then
                        txtDes(0).Focus()
                    Else
                        txtDes(Index + 1).Focus()
                    End If
            End Select
        End Sub
        Private Sub txtDes_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtDes.KeyPress
            Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
            Dim Index As Short = txtDes.GetIndex(eventSender)

            If KeyAscii = 13 Then
                ' SaveDestrezaInfo
                KeyAscii = 0
            ElseIf KeyAscii = System.Windows.Forms.Keys.Tab Then
                KeyAscii = 0
            End If

            eventArgs.KeyChar = Chr(KeyAscii)
            If KeyAscii = 0 Then
                eventArgs.Handled = True
            End If
        End Sub
        Private Sub txtDes_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDes.Leave
            Dim Index As Short = txtDes.GetIndex(eventSender)
            Debug.Print("LostFocus " & EditingDes)
            If Not EditingDes Then
                SaveDestrezaInfo()
            End If
        End Sub
        Private Sub txtDes_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles txtDes.MouseDown
            Dim Button As Short = eventArgs.Button \ &H100000
            Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
            Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
            Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
            Dim Index As Short = txtDes.GetIndex(eventSender)
            EditingCell = False
        End Sub
#End Region
#Region "LEVEL TWO ROUTINES"

        Sub CreateNewClaveRecord()
            Dim Cn As New ADODB.Connection
            Dim Cm As New ADODB.Command
            Dim Rs As New ADODB.Recordset

            Dim NewClaveID As Integer
            Dim Sep As String = "|"

            OpenConnection(Cn, Config.ConnectionString)
            'Dim R As Object
            'Dim d As Object
            'Dim Clave As String
            'Set Cm.ActiveConnection = Cn

            'Cm.CommandText = "UPDATE CLAVES SET ACTIVE = 0 WHERE CL_ID=" & ClaveID
            'Cm.Execute

            Rs.Open("SELECT * FROM Claves WHERE CL_id=" & ClaveID, Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)

            'For d = 1 To 10
            '	Clave = ""
            '	For R = 1 To Grid.Rows - 1
            '		'UPGRADE_WARNING: Couldn't resolve default property of object R. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '		If R = 1 Then
            '			Sep = ""
            '		Else
            '			Sep = "|"
            '		End If
            '		'UPGRADE_WARNING: Couldn't resolve default property of object d. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '		'UPGRADE_WARNING: Couldn't resolve default property of object R. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '		If Trim(Grid.get_TextMatrix(R, d)) <> "" Then
            '			'UPGRADE_WARNING: Couldn't resolve default property of object d. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '			'UPGRADE_WARNING: Couldn't resolve default property of object R. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '			Clave = Clave & Sep & Replace(Grid.get_TextMatrix(R, d), " ", "")
            '		End If
            '	Next R
            '	'UPGRADE_WARNING: Couldn't resolve default property of object d. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	If Clave <> "" Then Rs.Fields("CL_" & d).Value = Clave
            'Next d
            Rs.Fields("CL_Category").Value = Category
            Rs.Fields("CL_Type").Value = ClaveType
            Rs.Fields("active").Value = 1
            Rs.Update()
            NewClaveID = Rs.Fields("CL_ID").Value
            Rs.Close()
            Cn.Close()
            If UCase(Category) <> "N" Then
                Call CreateNewDestrezaRecord(NewClaveID)
            End If
        End Sub

        Sub EditCellInfo()
            'DIST 30
            'NORMAL WIDTH 495
            'EXTENDED WIDTH 735

            'If isPEP And Grid.Col = 6 Then 'PEP
            '	Me.cboA(0).Width = VB6.TwipsToPixelsX(615)
            '	Me.cboA(1).Width = VB6.TwipsToPixelsX(1335)
            '	Me.cboA(1).Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.cboA(0).Left) + VB6.PixelsToTwipsX(Me.cboA(0).Width) + 30)
            'Else
            '	Me.cboA(0).Width = VB6.TwipsToPixelsX(615)
            '	Me.cboA(1).Width = VB6.TwipsToPixelsX(615)
            '	Me.cboA(1).Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.cboA(0).Left) + VB6.PixelsToTwipsX(Me.cboA(0).Width) + 30)
            'End If

            EditingCell = True
            fraEditCell.Enabled = True
            fraEditCell.Visible = True
            Toolbar1.Items.Item("EditClave").Enabled = False

            'EditedCell.Row = Grid.Row
            'EditedCell.Col = Grid.Col

            cboA(0).Focus()
            On Error Resume Next
            cboA(0).Text = String.Empty
            cboA(1).Text = String.Empty
            'cboA(0).Text = Split(Grid.Text, " - ")(0)
            'cboA(1).Text = Split(Grid.Text, " - ")(1)
        End Sub

        Sub EditDestrezaInfo()
            'If UCase(Category) = "N" Then Exit Sub
            'fraDes.Text = "Destreza " & Grid.Col + 1
            'fraDes.Enabled = True
            'Toolbar1.Items.Item("EditDestreza").Enabled = False
            'EnableTextBox((True))
            'EditingDes = True

            'Me.txtDes(0).Focus()
            'iDestreza = Grid.Col
            With Destrezas(iDestreza)
                Me.txtDes(1).Text = .DesABR
                Me.txtDes(2).Text = .Desc
                Me.txtDes(0).Text = .DesName
            End With
        End Sub

        Sub LoadData()
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset

            Dim iCounter1 As Integer
            Dim iCounter2 As Integer
            Dim Ans As Object

            OpenConnection(Cn, Config.ConnectionString)

            Rs.Open("Select Claves.*, Destrezas.* From Claves Left Outer Join Destrezas ON Claves.CL_ID = Destrezas.D_CL_ID Where Claves.CL_ID = " & ClaveID, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            If Not Rs.EOF Then
                Category = GetValue(Rs.Fields("CL_Category"))
                ClaveType = GetValue(Rs.Fields("CL_Type"))
                For iCounter1 = 1 To 20
                    With Destrezas(iCounter1)
                        'Grid.set_TextMatrix(0, d, GetValue(Rs.Fields("D_" & d & "_Nombre")))
                        .DesName = GetValue(Rs.Fields("D_" & iCounter1.ToString.Trim & "_Nombre"))
                        .DesABR = GetValue(Rs.Fields("D_" & iCounter1.ToString.Trim & "_ABR"))
                        .Desc = GetValue(Rs.Fields("D_" & iCounter1.ToString.Trim & "_Desc"))
                        Ans = GetValue(Rs.Fields("CL_" & iCounter1.ToString.Trim))
                        Ans = Split(Ans, "|")
                        For iCounter2 = 0 To UBound(Ans, 1)
                            If Trim(Ans(iCounter2)) <> "" Then
                                'Grid.set_TextMatrix(a + 1, d, Trim(Split(Ans(a), "-")(0)) & " - " & Trim(Split(Ans(a), "-")(1)))
                            End If
                        Next iCounter2
                    End With
                Next iCounter1
            End If
            Rs.Close()
            Cn.Close()

        End Sub
        Sub SaveCellInfo()
            'Dim i As Object
            'Dim bItemisInList As Boolean
            'Dim PepAns As Short


            'If Trim(cboA(0).Text) <> "" Or Trim(cboA(1).Text) <> "" Then
            '	If Trim(cboA(0).Text) = "" Or Not ItemIsInList(cboA(0)) Then
            '		MsgBox("Invalid Question Number", MsgBoxStyle.Information)
            '		EditingCell = True
            '		cboA(0).Focus()
            '		Exit Sub
            '	End If

            '	If Trim(cboA(1).Text) = "" Or (Not ItemIsInList(cboA(0)) And Not isPEP) Or (isPEP And Len(cboA(1).Text) > 5) Then
            '		MsgBox("Invalid Answer Value", MsgBoxStyle.Information)
            '		EditingCell = True
            '		cboA(1).Focus()
            '		Exit Sub
            '	End If

            '	If isPEP And Grid.Col = 6 Then
            '		PepAns = 0
            '		For i = 1 To Len(cboA(1).Text)
            '			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '			Select Case UCase(Mid(cboA(1).Text, i, 1))
            '				Case "A"
            '					PepAns = PepAns + 16
            '				Case "B"
            '					PepAns = PepAns + 8
            '				Case "C"
            '					PepAns = PepAns + 4
            '				Case "D"
            '					PepAns = PepAns + 2
            '				Case "N"
            '					PepAns = PepAns + 1
            '			End Select
            '		Next i
            '		Grid.set_TextMatrix(EditedCell.Row, EditedCell.Col, cboA(0).Text & " - " & VB6.Format(PepAns, "00"))
            '	Else
            '		Grid.set_TextMatrix(EditedCell.Row, EditedCell.Col, cboA(0).Text & " - " & UCase(cboA(1).Text))
            '	End If
            '	If (EditedCell.Row + 1) < (Grid.Rows - 1) Then
            '		Grid.Col = EditedCell.Col
            '		Grid.Row = EditedCell.Row + 1
            '	End If

            'Else
            '	Grid.set_TextMatrix(EditedCell.Row, EditedCell.Col, "")
            'End If
            fraEditCell.Enabled = False
            fraEditCell.Visible = False
            EditingCell = False
            Toolbar1.Items.Item("EditClave").Enabled = True
        End Sub
        Sub SaveDestrezaInfo()
            With Destrezas(iDestreza)
                .DesABR = Me.txtDes(1).Text
                .Desc = Me.txtDes(2).Text
                .DesName = Me.txtDes(0).Text
                'Grid.set_TextMatrix(0, iDestreza, txtDes(0).Text)
            End With
            fraDes.Enabled = False
            EnableTextBox((False))
            EditingDes = False
            Toolbar1.Items.Item("EditDestreza").Enabled = True

        End Sub
        Sub SetGrid()
            'Dim i As Object
            '      Grid.set_ColWidth(0, 0, 400)
            'For i = 1 To Grid.Rows - 1
            '	'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	Grid.set_TextMatrix(i, 0, i)
            'Next i
        End Sub
        Sub ShowDestrezaInfo()
            'fraDes.Text = "Destreza " & Grid.Col + 1
            'With Destrezas(Grid.Col)
            '	Me.txtDes(1).Text = .DesABR
            '	Me.txtDes(2).Text = .Desc
            '	Me.txtDes(0).Text = .DesName
            'End With
        End Sub
#End Region
#Region "LEVEL THREE ROUTINES"
        Sub CreateNewDestrezaRecord(ByVal CL_ID As Integer)
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset

            Dim iCounter1 As Integer

            OpenConnection(Cn, Config.ConnectionString)

            Rs.Open("SELECT * FROM DESTREZAS WHERE D_CL_id=" & CL_ID, Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)

            For iCounter1 = 1 To 20
                Rs.Fields("D_" & iCounter1.ToString.Trim & "_Nombre").Value = Destrezas(iCounter1).DesName
                Rs.Fields("D_" & iCounter1.ToString.Trim & "_ABR").Value = Destrezas(iCounter1).DesABR
                Rs.Fields("D_" & iCounter1.ToString.Trim & "_DESC").Value = Destrezas(iCounter1).Desc
            Next iCounter1
            Rs.Update()
            Rs.Close()
            Cn.Close()
        End Sub
        Sub EnableTextBox(ByVal enable As Boolean)
            For iCounter1 As Integer = 0 To 2
                If enable Then
                    'txtDes(i).BackColor = Me.Grid.BackColor
                Else
                    txtDes(iCounter1).BackColor = Me.BackColor
                End If
            Next iCounter1
        End Sub

#End Region
#Region "Unknown Routines"
        Sub DeleteCell(ByRef Row As Short, ByRef Col As Short)
            For iCounter1 As Integer = 1 To colCels.Count()
                colCels.Remove(1)
            Next iCounter1


            'For i = Row + 1 To Grid.Rows - 1
            '	'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	colCels.Add(Grid.get_TextMatrix(i, Col))
            'Next i

            'For i = 1 To colCels.Count()
            '	'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	'UPGRADE_WARNING: Couldn't resolve default property of object colCels(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	Grid.set_TextMatrix(Row + i - 1, Col, colCels.Item(i))
            'Next i

            'Grid.set_TextMatrix(Grid.Rows - 1, Col, "")
        End Sub
        'Private Sub Grid_EnterCell(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Grid.EnterCell
        '	Debug.Print("enter")



        'End Sub

        'Private Sub Grid_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSHierarchicalFlexGridLib.DMSHFlexGridEvents_KeyDownEvent) Handles Grid.KeyDownEvent
        '	Select Case eventArgs.KeyCode
        '		Case System.Windows.Forms.Keys.Delete
        '			DeleteCell((Grid.Row), (Grid.Col))
        '			ShowCellInfo()
        '		Case System.Windows.Forms.Keys.F2
        '			If Not isPEP Then
        '				ShowDestrezaInfo()
        '				EditDestrezaInfo()
        '			End If
        '		Case 13
        '			EditCellInfo()
        '		Case System.Windows.Forms.Keys.Tab
        '			cmdOK.Focus()

        '	End Select
        'End Sub

        'Private Sub Grid_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSHierarchicalFlexGridLib.DMSHFlexGridEvents_KeyPressEvent) Handles Grid.KeyPressEvent

        '	'If KeyAscii = 13 Then EditCellInfo


        'End Sub
        'Private Sub Grid_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSHierarchicalFlexGridLib.DMSHFlexGridEvents_MouseDownEvent) Handles Grid.MouseDownEvent
        '	Debug.Print("MOUSE DOWN    GRID  " & EditingDes)

        '	EditingCell = False
        '	EditingDes = False

        'End Sub

        'Private Sub Grid_SelChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Grid.SelChange
        '	ShowDestrezaInfo()
        'End Sub
        'Private Sub Grid_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSHierarchicalFlexGridLib.DMSHFlexGridEvents_MouseDownEvent) Handles Grid.MouseDownEvent
        '	Debug.Print("MOUSE DOWN    GRID  " & EditingDes)

        '	EditingCell = False
        '	EditingDes = False

        'End Sub

        'Private Sub Grid_SelChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Grid.SelChange
        '	ShowDestrezaInfo()
        'End Sub

        Sub ShowCellInfo()
            On Error Resume Next
            'cboA(0).Text = ""
            'cboA(1).Text = ""
            'cboA(0).Text = Split(Grid.Text, " - ")(0)
            'cboA(1).Text = Split(Grid.Text, " - ")(1)
        End Sub
#End Region
    End Class
End Namespace