Option Strict Off
Option Explicit On

Imports NPOI.SS.Formula.Functions

Friend Class frmWarnings
	Inherits System.Windows.Forms.Form
	Public iJobID As Integer
	Private Corrected As Boolean
	
	Private MouseX As Single
	Private MouseY As Single
	
	Private EditingAns As Boolean
	Private ItemEditedKey As String		
	
	Private Const NAME_INDEX As Short = 1
	Private Const SECTION_INDEX As Short = 2
	Private Const QUESTION_INDEX As Short = 3
	Private Const DESCRIPTION_INDEX As Short = 4
	
	Sub ChangeAnswer()
		
		
		
		
	End Sub
	
	Sub EndEdit()
		If Not ItemIsInList((Me.cboA)) Then
			MsgBox("Invalid answer.", MsgBoxStyle.Information)
			cboA.Focus()
			Exit Sub
		End If
		
		EditingAns = False
		fraEdit.Visible = False
		Call SetAnswer(GetIDFromKey(ItemEditedKey), cboA.Text)
		lvWarnings.Focus()
	End Sub
	
	Sub FillWarningsView()
		Dim Cn As New ADODB.Connection
		Dim Rs As New ADODB.Recordset
		
		Dim CurrentItem As System.Windows.Forms.ListViewItem
		
		OpenConnection(Cn, Config.ConnectionString)
		
		Me.lvWarnings.Items.Clear()
		
		Rs.Open("Select * From Logs Where L_J_ID = " & iJobID & " Order By L_Name,l_sec,l_question ASC ", Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
		'Rs.Open "Select Logs.*, Answers.A_Nombre From Logs LEFT OUTER JOIN Answers ON Logs.L_A_ID = Answers.A_ID Where LOGS.L_J_ID = " & iJobID & " Order By L_Name ASC ", Cn, adOpenStatic, adLockReadOnly
		While Not Rs.EOF
			CurrentItem = Me.lvWarnings.Items.Add("W" & Rs.Fields("L_ID").Value, "", "")
			'UPGRADE_WARNING: Lower bound of collection CurrentItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			If CurrentItem.SubItems.Count > NAME_INDEX Then
				CurrentItem.SubItems(NAME_INDEX).Text = GetValue(Rs.Fields("L_Name"))
			Else
				CurrentItem.SubItems.Insert(NAME_INDEX, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, GetValue(Rs.Fields("L_Name"))))
			End If
			'UPGRADE_WARNING: Lower bound of collection CurrentItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			If CurrentItem.SubItems.Count > SECTION_INDEX Then
				CurrentItem.SubItems(SECTION_INDEX).Text = Rs.Fields("L_Sec").Value
			Else
				CurrentItem.SubItems.Insert(SECTION_INDEX, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Rs.Fields("L_Sec").Value))
			End If
			'UPGRADE_WARNING: Lower bound of collection CurrentItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			If CurrentItem.SubItems.Count > QUESTION_INDEX Then
				CurrentItem.SubItems(QUESTION_INDEX).Text = Rs.Fields("L_Question").Value
			Else
				CurrentItem.SubItems.Insert(QUESTION_INDEX, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Rs.Fields("L_Question").Value))
			End If
			'UPGRADE_WARNING: Lower bound of collection CurrentItem has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
			If CurrentItem.SubItems.Count > DESCRIPTION_INDEX Then
				CurrentItem.SubItems(DESCRIPTION_INDEX).Text = GetLogDesc(Rs.Fields("L_DescriptionID").Value)
			Else
				CurrentItem.SubItems.Insert(DESCRIPTION_INDEX, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, GetLogDesc(Rs.Fields("L_DescriptionID").Value)))
			End If
			
			'    If Rs!L_corrected = True And Toolbar.Buttons("Verified").Enabled Then
			'        lvWarnings.BackColor = &H8000000F
			'        Toolbar.Buttons("Verified").Enabled = False
			'    End If
			
			'UPGRADE_NOTE: Object CurrentItem may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			CurrentItem = Nothing
			Rs.MoveNext()
		End While
		
		Rs.Close()
				
		Cn.Close()	
		
	End Sub
	
	
	Function GetAnswer(ByVal L_ID As Integer) As String
		Dim i As Object
		Dim Cn As New ADODB.Connection
		Dim Rs As New ADODB.Recordset
		Dim Field As String
		Dim Q As Short
		Dim A_ID As Integer
		Dim Ans As Object
		
		OpenConnection(Cn, Config.ConnectionString)
		
		Rs.Open("Select * From Logs Where L_ID =" & L_ID, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
		If Not Rs.EOF Then
			Field = Rs.Fields("L_Field").Value
			Q = Rs.Fields("L_Question").Value
			A_ID = Rs.Fields("L_A_ID").Value
			Rs.Close()
			
			Rs.Open("Select * From Answers Where A_ID=" & A_ID, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
			If Not Rs.EOF Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Ans. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Ans = Split(GetValue(Rs.Fields(Field)), "|")
                For iCounter As Integer = 0 To UBound(Ans, 1)
                    'UPGRADE_WARNING: Couldn't resolve default property of object Ans(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If Val(Split(Ans(iCounter), "-")(0)) = Q Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object Ans(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        GetAnswer = Split(Ans(i), "-")(1)
                        Exit For
                    End If
                Next iCounter
				
			End If
		End If
		
		Rs.Close()
		Cn.Close()
		'UPGRADE_NOTE: Object Cn may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		Cn = Nothing
		
	End Function
	
	Function SetAnswer(ByVal L_ID As Integer, ByVal Answer As String) As String
		Dim i As Object
		Dim Cn As New ADODB.Connection
		Dim Rs As New ADODB.Recordset
		Dim Field As String
		Dim Q As Short
		Dim A_ID As Integer
		Dim Ans As Object
		
		OpenConnection(Cn, Config.ConnectionString)
		
		Rs.Open("Select * From Logs Where L_ID =" & L_ID, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
		If Not Rs.EOF Then
			Field = Rs.Fields("L_Field").Value
			Q = Rs.Fields("L_Question").Value
			A_ID = Rs.Fields("L_A_ID").Value
			Rs.Close()
			
			Rs.Open("Select * From Answers Where A_ID=" & A_ID, Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
			If Not Rs.EOF Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Ans. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Ans = Split(GetValue(Rs.Fields(Field)), "|")
                For iCounter As Integer = 0 To UBound(Ans, 1)
                    'UPGRADE_WARNING: Couldn't resolve default property of object Ans(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If Val(Split(Ans(iCounter), "-")(0)) = Q Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object Ans(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        Ans(i) = Q & "-" & Answer
                        Exit For
                    End If
                Next iCounter
				'UPGRADE_WARNING: Couldn't resolve default property of object Ans. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Rs.Fields(Field).Value = Join(Ans, "|")
				Rs.Update()
				
			End If
		End If
		
		Rs.Close()
		Cn.Close()
		
	End Function
	
	Sub SetControls()
		lvWarnings.Top = Me.Toolbar.Height
		lvWarnings.Left = 0
        lvWarnings.Width = Microsoft.VisualBasic.Compatibility.VB6.TwipsToPixelsX(Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsX(Me.Width) - 70)
        lvWarnings.Height = Microsoft.VisualBasic.Compatibility.VB6.TwipsToPixelsY(Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(Me.Height) - Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(Toolbar.Height) - Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(StatusBar.Height) - Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(fraEdit.Height) - 400)
		
		
        fraEdit.Height = Microsoft.VisualBasic.Compatibility.VB6.TwipsToPixelsY(380)
        fraEdit.Top = Microsoft.VisualBasic.Compatibility.VB6.TwipsToPixelsY(Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(Me.StatusBar.Top) - Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(fraEdit.Height))
		fraEdit.Left = 0
		fraEdit.Width = ClientRectangle.Width
		
		
	End Sub
	
	
	Sub SetLogCorrected(ByRef bCorrected As Boolean)
		Dim Cn As ADODB.Connection
		Dim Cm As ADODB.Command
		Dim sQuery As String
		
		Cn = New ADODB.Connection
		Cm = New ADODB.Command
		
		OpenConnection(Cn, Config.ConnectionString)
		
		Cm.ActiveConnection = Cn
		
		
		If bCorrected = True Then
			sQuery = "UPDATE Logs Set L_Corrected = 1 WHERE L_J_ID =" & iJobID
		Else
			sQuery = "UPDATE Logs Set L_Corrected = 0 WHERE L_J_ID =" & iJobID
		End If
		
		
		Cm.CommandText = sQuery
		Cm.Execute()
		
		Cn.Close()	
	End Sub
	
	Sub SetJobCorrected()
		Dim Cn As ADODB.Connection
		Dim Cm As ADODB.Command
		Dim sQuery As String
		
		Cn = New ADODB.Connection
		Cm = New ADODB.Command
		
		OpenConnection(Cn, Config.ConnectionString)
		
		Cm.ActiveConnection = Cn
		
		sQuery = "UPDATE Jobs Set J_Process_Status = 0 WHERE J_ID =" & iJobID
		
		Cm.CommandText = sQuery
		Cm.Execute()
		
		Cn.Close()		
	End Sub
	
	Private Sub CoolBar_HeightChanged(ByVal NewHeight As Single)
		Call SetControls()
	End Sub
	
	Sub StartEdit()
		Dim LID As Integer
		If Not (lvWarnings.FocusedItem Is Nothing) Then
			EditingAns = True
			fraEdit.Visible = True
			cboA.Focus()
			ItemEditedKey = lvWarnings.FocusedItem.Name
			LID = GetIDFromKey(ItemEditedKey)
			cboA.Text = GetAnswer(LID)
		Else			
			MsgBox("Please select one warning from the list.", MsgBoxStyle.Information)			
		End If
		
	End Sub
	
	Private Sub cboA_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles cboA.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		
		If KeyCode = 13 Then
			EndEdit()
		End If				
	End Sub
	
	
	Private Sub cboA_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboA.Leave
		
		If Not EditingAns Then EndEdit()
		
	End Sub
	
	
	Private Sub frmWarnings_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim i As Short 
		
		fraEdit.Visible = False
		
		cboA.Items.Add(" ")
        For iCounter As Integer = 1 To 6
            cboA.Items.Add(iCounter)
        Next iCounter
		cboA.Items.Add("S")
		cboA.Items.Add("N")
		
		Call FillWarningsView()
		
		StatusBar.Items.Item("WarningCount").Text = "Total Warnings: " & lvWarnings.Items.Count
	End Sub
	
	
	Private Sub frmWarnings_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsX(eventArgs.X)
        Dim y As Single = Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(eventArgs.Y)
		EditingAns = False
	End Sub
	
	
	'UPGRADE_WARNING: Event frmWarnings.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmWarnings_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		Call SetControls()
	End Sub
	
	
	Private Sub frmWarnings_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
				
		If Corrected Then Call SetJobCorrected()				
		
	End Sub
	
	Private Sub lvWarnings_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvWarnings.DoubleClick
		If Not (lvWarnings.GetItemAt(MouseX, MouseY) Is Nothing) Then
			StartEdit()
		End If
		
	End Sub
	
	
	Private Sub lvWarnings_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lvWarnings.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsX(eventArgs.X)
        Dim y As Single = Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(eventArgs.Y)
		EditingAns = False
	End Sub
	
	
	Private Sub lvWarnings_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lvWarnings.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsX(eventArgs.X)
        Dim y As Single = Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(eventArgs.Y)
		MouseX = X
		MouseY = y
		
	End Sub
	
	
	Private Sub StatusBar_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles StatusBar.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsX(eventArgs.X)
        Dim y As Single = Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(eventArgs.Y)
		EditingAns = False
	End Sub
	
	Private Sub Toolbar_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar_Button1.Click
		Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
		
		Select Case Button.Name
			Case "CAnswer"
				StartEdit()
				
			Case "Verified"
				Button.Enabled = False
				Corrected = True
				Call SetLogCorrected(True)
		End Select
		
	End Sub
	
	Private Sub Toolbar_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Toolbar.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsX(eventArgs.X)
        Dim y As Single = Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(eventArgs.Y)
		EditingAns = False
	End Sub
End Class