Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.Compatibility
Imports learnAid.Forms.MasterForms
Friend Class frmAddOfficeStudent
	Inherits System.Windows.Forms.Form
	Dim BatteryChanged As Boolean
    Public pep As Short
    Dim iSemester As Short
   
	
    Sub SetBattery()
        Dim sNV As String = Nothing
        Dim sLES As String = Nothing
        Dim sREN As String = Nothing
        Dim sMat As String = Nothing
        Dim sPN As String = Nothing

        If CBool(pep) Then

            Call SelectItemWithID(cboLES, 52)
            Call SelectItemWithID(cboRen, 52)
            Call SelectItemWithID(cboMAT, 52)
            Call SelectItemWithID(cboNV, 52)

        ElseIf cboSemester.Text <> "" And cboGrade.Text <> "" Then
            'Bat = getDefExam(cboGrade.ItemData(cboGrade.ListIndex), cboSemester.ItemData(cboSemester.ListIndex))
            'Call GetDefaultsValues(Bat, cboSemester.ItemData(cboSemester.ListIndex), sLES, sREN, sMat, sNV, sPN)
            Call GetDefaultsValues(cboGrade.SelectedIndex, cboSemester.SelectedIndex, sLES, sREN, sMat, sNV, sPN, 0, "officetesting")
            Call SetValueToCBox(cboLES, sLES)
            Call SetValueToCBox(cboRen, sREN)
            Call SetValueToCBox(cboMAT, sMat)
            Call SetValueToCBox(cboNV, sNV)


        End If
    End Sub
	
	
	Function ValidData() As Boolean
		Dim C As Short
		ValidData = False
		lblMsg.ForeColor = System.Drawing.Color.Red
		
		
		If Trim(txtName.Text) = "" Then
			lblMsg.Text = "Enter the student name."
			txtName.Focus()
			Exit Function
		End If
		
		
		If Trim(cboSchool.Text) = "" Then
			lblMsg.Text = "Select the a school."
			cboSchool.Focus()
			Exit Function
		End If
		
		If Trim(cboGrade.Text) = "" Then
			lblMsg.Text = "Select the a Grade."
			cboGrade.Focus()
			Exit Function
		End If
		
		If Trim(cboSemester.Text) = "" Then
			lblMsg.Text = "Select the a Semester."
			cboSemester.Focus()
			Exit Function
		End If
		
		
		
		C = 0
		If Trim(cboMat.Text) = "" Then
			C = C + 1
		End If
		
		If Trim(cboNV.Text) = "" Then
			C = C + 1
		End If
		If Trim(cboLes.Text) = "" Then
			C = C + 1
		End If
		If Trim(cboRen.Text) = "" Then
			C = C + 1
		End If
		
		
		
		
		ValidData = True
		
		
	End Function
	
	
	
	'UPGRADE_WARNING: Event cboBattery.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboBattery_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboBattery.SelectedIndexChanged
		Dim def_id As Integer
		
		If InStr(1, cboBattery.Text, "|") > 0 Then
            def_id = CInt(Split(cboBattery.Text, "|")(2))
            SetExam((def_id))
		Else
			SetExam()
		End If
		
	End Sub
	
	
    Sub SetExam(Optional ByRef def_id As Integer = 0)

        Dim sNV As String = Nothing
        Dim sLES As String = Nothing
        Dim sREN As String = Nothing
        Dim sMat As String = Nothing

        If Me.cboSemester.Text = "First Semester(Aug-Dec)" Then
            iSemester = 1
        Else
            iSemester = 2
        End If

        If cboGrade.Text <> "" Then

            'sExam = getDefExam(cboGrade.ItemData(cboGrade.ListIndex), iSemester)
            'Call GetDefaultsValues(sExam, iSemester, sLES, sREN, sMat, snv, sPluginName)
            Call GetDefaultsValues(cboGrade.SelectedIndex, iSemester, sLES, sREN, sMat, sNV, "", def_id, "editjob")
            Call SetValueToCBox(cboNV, sNV)
            Call SetValueToCBox(cboLES, sLES)
            Call SetValueToCBox(cboRen, sREN)
            Call SetValueToCBox(cboMAT, sMat)


        End If

    End Sub
	
	'UPGRADE_WARNING: Event cboGrade.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	'UPGRADE_WARNING: ComboBox event cboGrade.Change was upgraded to cboGrade.TextChanged which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
	Private Sub cboGrade_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboGrade.TextChanged
		Me.lblMsg.Text = ""
	End Sub
	
	'UPGRADE_WARNING: Event cboGrade.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboGrade_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboGrade.SelectedIndexChanged
		Me.lblMsg.Text = ""
		Call SetBattery()
	End Sub
	
	
	
	'UPGRADE_WARNING: Event cboSchool.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	'UPGRADE_WARNING: ComboBox event cboSchool.Change was upgraded to cboSchool.TextChanged which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
	Private Sub cboSchool_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboSchool.TextChanged
		Me.lblMsg.Text = ""
	End Sub
	
	'UPGRADE_WARNING: Event cboSchool.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboSchool_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboSchool.SelectedIndexChanged
		Me.lblMsg.Text = ""
	End Sub
	
	
	'UPGRADE_WARNING: Event cboSemester.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	'UPGRADE_WARNING: ComboBox event cboSemester.Change was upgraded to cboSemester.TextChanged which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
	Private Sub cboSemester_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboSemester.TextChanged
		Me.lblMsg.Text = ""
	End Sub
	
	'UPGRADE_WARNING: Event cboSemester.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboSemester_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboSemester.SelectedIndexChanged
		Call SetBattery()
		Me.lblMsg.Text = ""
	End Sub
	
	
	Private Sub cmdAdd_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAdd.Click
        Dim sName As String
		If Not ValidData Then Exit Sub

        Dim Item As System.Windows.Forms.ListViewItem
        With frmNewJob.OfficeList.Items

            If frmNewJob.OfficeList.Items.Count >= Val(frmNewJob.txtTotalStudents.Text) Then
                Me.lblMsg.ForeColor = System.Drawing.Color.Blue
                Me.lblMsg.Text = Val(frmNewJob.txtTotalStudents.Text) & " Student only."
                Exit Sub
            End If

            sName = FormatName(Capitalize(Trim(txtName.Text)))
            If UCase(sName) = "INVALID" Then
                MsgBox("Invalid Name Syntax", MsgBoxStyle.OkOnly, "Student Name")
                Exit Sub
            End If

            'UPGRADE_WARNING: Lower bound of collection frmNewJob.OfficeList.ListItems.ImageList has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            Item = .Add(sName, 0)

            'School
            'UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If Item.SubItems.Count > 1 Then
                Item.SubItems(1).Text = Me.cboSchool.Text
            Else
                Item.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.cboSchool.Text))
            End If
            'UPGRADE_WARNING: Lower bound of collection Item.ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            Item.SubItems.Item(1).Tag = CStr(Me.cboSchool.SelectedIndex)

            'Grade
            'UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If Item.SubItems.Count > 2 Then
                Item.SubItems(2).Text = Me.cboGrade.Text
            Else
                Item.SubItems.Insert(2, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.cboGrade.Text))
            End If
            'UPGRADE_WARNING: Lower bound of collection Item.ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            Item.SubItems.Item(2).Tag = CStr(Me.cboGrade.SelectedIndex)
            'Semester
            'UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If Item.SubItems.Count > 3 Then
                Item.SubItems(3).Text = Me.cboSemester.Text
            Else
                Item.SubItems.Insert(3, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.cboSemester.Text))
            End If
            'UPGRADE_WARNING: Lower bound of collection Item.ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            Item.SubItems.Item(3).Tag = CStr(Me.cboSemester.SelectedIndex)
            'Battery
            'Item.SubItems(4) = ""
            'Item.ListSubItems(4).Tag = 0
            'File
            '    Item.SubItems(4) = Me.txtFile
            '    Item.ListSubItems(4).Tag = ""
            'MAT
            If Item.SubItems.Count > 4 Then
                Item.SubItems(4).Text = Me.cboBattery.Text
            Else
                Item.SubItems.Insert(4, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.cboBattery.Text))
            End If
            'UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If Item.SubItems.Count > 5 Then
                Item.SubItems(5).Text = Me.cboMAT.Text
            Else
                Item.SubItems.Insert(5, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.cboMAT.Text))
            End If
            'UPGRADE_WARNING: Lower bound of collection Item.ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            Item.SubItems.Item(5).Tag = CStr(Me.cboMAT.SelectedIndex)
            'NV
            'UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If Item.SubItems.Count > 6 Then
                Item.SubItems(6).Text = Me.cboNV.Text
            Else
                Item.SubItems.Insert(6, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.cboNV.Text))
            End If
            'UPGRADE_WARNING: Lower bound of collection Item.ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            Item.SubItems.Item(6).Tag = CStr(Me.cboNV.SelectedIndex)
            'LES
            'UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If Item.SubItems.Count > 7 Then
                Item.SubItems(7).Text = Me.cboLES.Text
            Else
                Item.SubItems.Insert(7, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.cboLES.Text))
            End If
            'UPGRADE_WARNING: Lower bound of collection Item.ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            Item.SubItems.Item(7).Tag = CStr(Me.cboLES.SelectedIndex)
            'REN
            'UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If Item.SubItems.Count > 8 Then
                Item.SubItems(8).Text = Me.cboRen.Text
            Else
                Item.SubItems.Insert(8, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Me.cboRen.Text))
            End If
            'UPGRADE_WARNING: Lower bound of collection Item.ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            Item.SubItems.Item(8).Tag = CStr(Me.cboRen.SelectedIndex)

            'Plugin
            'UPGRADE_WARNING: Lower bound of collection Item has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            If Item.SubItems.Count > 9 Then
                Item.SubItems(9).Text = Split(cboBattery.Text, "|")(0)
            Else
                Item.SubItems.Insert(9, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, Split(cboBattery.Text, "|")(0)))
            End If
            'UPGRADE_WARNING: Lower bound of collection Item.ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            Item.SubItems.Item(9).Tag = Split(cboBattery.Text, "|")(0)

            txtName.Text = ""
            txtName.Focus()

            lblMsg.Text = "Succesfuly added."
            lblMsg.ForeColor = System.Drawing.Color.Blue

        End With
        frmNewJob.sPluginName = Split(cboBattery.Text, "|")(0)		
		
    End Sub
    Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub


    'UPGRADE_WARNING: Form event frmAddOfficeStudent.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmAddOfficeStudent_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        txtName.Focus()
    End Sub

    Private Sub frmAddOfficeStudent_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Call FillSchoolCbox(cboSchool)
        Call FillLESCbox(cboLES, , CBool(pep))
        Call FillRENCbox(cboRen, , CBool(pep))
        Call FillMATCbox(cboMAT, , CBool(pep))
        Call FillNVCbox(cboNV, , CBool(pep))
        Call FillGradeCbox(cboGrade)
        Call FillSemesterCbox(cboSemester)

        If CBool(pep) Then
            cboLES.Enabled = False
            cboRen.Enabled = False
            cboMAT.Enabled = False
            cboNV.Enabled = False
            SetBattery()
        End If

    End Sub


    'UPGRADE_WARNING: Event txtName.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtName_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtName.TextChanged
        Me.lblMsg.Text = ""
    End Sub
End Class