Option Strict Off
Option Explicit On

Imports learnAid.BLL
Imports Microsoft.VisualBasic.Compatibility

Namespace Forms.MasterForms
    Friend Class frmEditSchool
        Inherits System.Windows.Forms.Form

        Public Edit As Boolean
        Public iSchoolID As Integer
        Public bCancel As Boolean

#Region "LEVEL ONE ROUTINES"
        Private Sub frmEditSchool_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
            bCancel = True

            Call SetFrames()
            Call SetFrameVisible(0)

            Call FillConsultantCBox((Me.cboConsultant), LA_Declarations.enumConsultantType.ctConsultant)
            Call FillPotentialCbox((Me.cboParentRep))
            Call FillLangCbox((Me.cboPrincRep))

            If Edit = True Then
                LoadData()
            Else
                Me.cboPrincRep.SelectedIndex = 1
                Me.cboParentRep.SelectedIndex = 1
            End If
        End Sub
        Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
            Dim VClass As New ValidateClass

            If VClass.ValidateForm(Me) Then
                If Trim(txtSCHName.Text) <> "" Then
                    If Edit Then
                        Call Update_Renamed()
                    Else
                        Call Add_Renamed()
                    End If
                Else
                    MsgBox("School Name is a required field.", MsgBoxStyle.Information)
                End If
            End If

        End Sub
        Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
            Me.Hide()
        End Sub
        Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Info.Click, _Toolbar1_Button2.Click, Address.Click, _Toolbar1_Button4.Click, Contact.Click, _Toolbar1_Button6.Click, Consultant.Click
            Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)
            Info.Checked = False
            Address.Checked = False
            Contact.Checked = False
            Consultant.Checked = False

            Select Case Button.Name
                Case "Info"
                    Call SetFrameVisible(0)
                    Info.Checked = True
                Case "Address"
                    Call SetFrameVisible(1)
                    Address.Checked = True
                Case "Contact"
                    Call SetFrameVisible(2)
                    Contact.Checked = True
                Case "Consultant"
                    Call SetFrameVisible(3)
                    Consultant.Checked = True
            End Select

        End Sub
        'UPGRADE_WARNING: Event txtPhone.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub txtPhone_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPhone.TextChanged
            If IsNumeric(txtPhone.Text) And Len(txtPhone.Text) = 10 Then txtPhone.Text = VB6.Format(txtPhone.Text, "(###) ###-####")
        End Sub
        Private Sub txtPrice_Validating(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles txtPrice.Validating
            Dim Cancel As Boolean = eventArgs.Cancel
            If Me.txtPrice.Text = String.Empty Then
                Me.txtPrice.Text = FormatCurrency(0)
            Else
                Me.txtPrice.Text = FormatCurrency(Val(Me.txtPrice.Text))
            End If
            eventArgs.Cancel = Cancel
        End Sub
#End Region
#Region "LEVEL TWO ROUTINES"
        'Called By: Command1_Click()
        'UPGRADE_NOTE: Add was upgraded to Add_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Sub Add_Renamed()
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset

            OpenConnection(Cn, Config.ConnectionString)

            Rs.Open("Select * From Schools Where SC_SCH_NAME ='" & Me.txtSCHName.Text & "'", Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
            If Rs.EOF Then
                Rs.AddNew()
                Rs.Fields("sc_sch_name").Value = Me.txtSCHName.Text
                Rs.Fields("SC_SCH_CODE").Value = Me.txtCode.Text
                Rs.Fields("SC_Type").Value = Me.txtType.Text
                Rs.Fields("SC_Address1").Value = Me.txtAddress1.Text
                Rs.Fields("SC_Address2").Value = Me.txtAddress2.Text
                Rs.Fields("sc_city").Value = Me.txtCity.Text
                Rs.Fields("SC_Location").Value = Me.txtLocation.Text
                Rs.Fields("sc_phone").Value = Me.txtPhone.Text
                Rs.Fields("SC_Fax").Value = Me.txtFax.Text
                Rs.Fields("SC_DIRECTOR").Value = Me.txtDirector.Text
                Rs.Fields("SC_PRINCIPAL").Value = Me.txtPrincipal.Text
                Rs.Fields("SC_COUNSELOR").Value = Me.txtCounselor.Text
                Rs.Fields("SC_SEXES").Value = Me.txtSexes.Text
                Rs.Fields("SC_LowGrade").Value = Val(Me.txtHigh.Text)
                Rs.Fields("SC_HighGrade").Value = Val(Me.txtLow.Text)
                Rs.Fields("SC_COST").Value = Val(Me.txtCost.Text)
                Rs.Fields("sc_price").Value = Val(Me.txtPrice.Text)
                Rs.Fields("SC_PRINCIPALVER").Value = VB6.GetItemData(Me.cboPrincRep, Me.cboPrincRep.SelectedIndex)
                Rs.Fields("SC_ParentsVer").Value = VB6.GetItemData(Me.cboParentRep, Me.cboParentRep.SelectedIndex)
                Rs.Fields("SC_Consultant_ID").Value = ComboboxUtilities.GetComboSelectedItemId(cboConsultant)  'VB6.GetItemData(Me.cboConsultant, cboConsultant.SelectedIndex)
                Rs.Fields("SC_ZipCode").Value = Me.txtZip.Text
                If bTITULO1 Then
                    Rs.Fields("sc_comp").Value = Me.txtCompany.Text
                End If
                Rs.Update()
                bCancel = False
                Me.Hide()
            Else
                MsgBox("The school " & Me.txtSCHName.Text & " already exist.", MsgBoxStyle.Information)
            End If

            Rs.Close()
            Cn.Close()
        End Sub

        Sub LoadData()
            Dim sQuery As String = "Select * From Schools Where SC_ID =" & iSchoolID
            Dim dt = GlobalResources.ExecuteDataTable(sQuery)

            '            Dim i As Integer = 0
            If dt.Rows.Count > 0 Then
                Me.txtSCHName.Text = (dt.Rows(0)("sc_sch_name").ToString())
                Me.txtCode.Text = (dt.Rows(0)("SC_SCH_CODE").ToString())
                Me.txtType.Text = (dt.Rows(0)("SC_Type").ToString())
                Me.txtAddress1.Text = (dt.Rows(0)("SC_Address1").ToString())
                Me.txtAddress2.Text = (dt.Rows(0)("SC_Address2").ToString())
                Me.txtCity.Text = (dt.Rows(0)("sc_city").ToString())
                Me.txtLocation.Text = (dt.Rows(0)("SC_Location").ToString())
                Me.txtPhone.Text = (dt.Rows(0)("sc_phone").ToString())
                Me.txtFax.Text = (dt.Rows(0)("SC_Fax").ToString())
                Me.txtDirector.Text = (dt.Rows(0)("SC_DIRECTOR").ToString())
                Me.txtPrincipal.Text = (dt.Rows(0)("SC_PRINCIPAL").ToString())
                Me.txtCounselor.Text = (dt.Rows(0)("SC_COUNSELOR").ToString())
                Me.txtSexes.Text = (dt.Rows(0)("SC_SEXES").ToString())
                Me.txtHigh.Text = (dt.Rows(0)("SC_LowGrade").ToString())
                Me.txtLow.Text = (dt.Rows(0)("SC_HighGrade").ToString())
                Me.txtCost.Text = (dt.Rows(0)("SC_COST").ToString())
                Me.txtPrice.Text = FormatCurrency(dt.Rows(0)("sc_price").ToString(), 0)

                Call SelectItemWithID(Me.cboPrincRep, dt.Rows(0)("SC_PRINCIPALVER").ToString())
                Call SelectItemWithID(Me.cboParentRep, dt.Rows(0)("SC_ParentsVer").ToString())
                'Call SelectItemWithID(Me.cboConsultant, dt.Rows(0)("SC_Consultant_ID").ToString())
                Call ComboboxUtilities.SetComboItemWithId(Me.cboConsultant, dt.Rows(0)("SC_CONSULTANT_ID").ToString())

                Me.txtZip.Text = (dt.Rows(0)("SC_ZipCode"))
                If bTITULO1 Then
                    Me.txtCompany.Text = (dt.Rows(0)("sc_comp"))
                End If
            Else
                MsgBox("The school " & Me.txtSCHName.Text & " does not exist.", MsgBoxStyle.Information)
                bCancel = True
                Me.Hide()
            End If
        End Sub


        Sub SetFrames()
            Dim iCounter1 As Integer
            For iCounter1 = 0 To 3
                Frames(iCounter1).Left = _Frames_0.Left
                Frames(iCounter1).Top = _Frames_0.Top
                Frames(iCounter1).Width = _Frames_0.Width
                Frames(iCounter1).Height = __Frames_0.Height
            Next iCounter1
        End Sub
        Sub SetFrameVisible(ByRef frameNum As Integer)
            Dim iCounter1 As Integer
            For iCounter1 = 0 To 3
                If iCounter1 = frameNum Then
                    Frames(iCounter1).Visible = True
                Else
                    Frames(iCounter1).Visible = False
                End If
            Next iCounter1
        End Sub
        'Called By: Command1_Click()
        'UPGRADE_NOTE: Update was upgraded to Update_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Sub Update_Renamed()
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset

            OpenConnection(Cn, Config.ConnectionString)

            Rs.Open("Select * From Schools Where SC_ID=" & iSchoolID, Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
            If Not Rs.EOF Then
                Rs.Fields("sc_sch_name").Value = Me.txtSCHName.Text
                Rs.Fields("SC_SCH_CODE").Value = Me.txtCode.Text
                Rs.Fields("SC_Type").Value = Me.txtType.Text
                Rs.Fields("SC_Address1").Value = Me.txtAddress1.Text
                Rs.Fields("SC_Address2").Value = Me.txtAddress2.Text
                Rs.Fields("sc_city").Value = Me.txtCity.Text
                Rs.Fields("SC_Location").Value = Me.txtLocation.Text
                Rs.Fields("sc_phone").Value = Me.txtPhone.Text
                Rs.Fields("SC_Fax").Value = Me.txtFax.Text
                Rs.Fields("SC_DIRECTOR").Value = Me.txtDirector.Text
                Rs.Fields("SC_PRINCIPAL").Value = Me.txtPrincipal.Text
                Rs.Fields("SC_COUNSELOR").Value = Me.txtCounselor.Text
                Rs.Fields("SC_SEXES").Value = Me.txtSexes.Text
                Rs.Fields("SC_LowGrade").Value = Me.txtHigh.Text
                Rs.Fields("SC_HighGrade").Value = Me.txtLow.Text

                Rs.Fields("SC_COST").Value = Me.txtCost.Text
                Rs.Fields("sc_price").Value = Me.txtPrice.Text

                Rs.Fields("SC_PRINCIPALVER").Value = VB6.GetItemData(Me.cboPrincRep, Me.cboPrincRep.SelectedIndex)
                Rs.Fields("SC_ParentsVer").Value = VB6.GetItemData(Me.cboParentRep, Me.cboParentRep.SelectedIndex)

                Rs.Fields("SC_Consultant_ID").Value = ComboboxUtilities.GetComboSelectedItemId(cboConsultant)  'VB6.GetItemData(Me.cboConsultant, cboConsultant.SelectedIndex)

                Rs.Fields("SC_ZipCode").Value = Me.txtZip.Text
                If bTITULO1 Then
                    Rs.Fields("sc_comp").Value = Me.txtCompany.Text
                End If
                Rs.Update()
                bCancel = False
                Me.Hide()
            Else
                MsgBox("The school " & Me.txtSCHName.Text & " does not exist.", MsgBoxStyle.Information)

            End If
            Rs.Close()
            Cn.Close()
        End Sub
#End Region

         End Class
End Namespace