Option Strict Off
Option Explicit On
Namespace Forms.UserLoginForms
    Friend Class frmNewUser
        Inherits System.Windows.Forms.Form
        Public bCancel As Boolean




        Sub SaveUser()
            Dim Cn As ADODB.Connection
            Dim Rs As ADODB.Recordset

            Cn = New ADODB.Connection
            Rs = New ADODB.Recordset

            OpenConnection(Cn, Config.ConnectionString)

            Rs.Open("Select * From Users Where U_USERID ='" & Me.txtUserName.Text & "'", Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)

            If Not Rs.EOF Then
                MsgBox("The user account already exist.", MsgBoxStyle.Information)
            Else
                If txtPassword.Text = txtConfirmation.Text Then
                    Rs.AddNew()
                    Rs.Fields("U_UserID").Value = txtUserName.Text
                    Rs.Fields("U_PWD").Value = txtPassword.Text
                    Rs.Fields("U_USER_TYPE").Value = Microsoft.VisualBasic.Compatibility.VB6.GetItemData(cboUserType, cboUserType.SelectedIndex)
                    Rs.Fields("U_Cons_ID").Value = Microsoft.VisualBasic.Compatibility.VB6.GetItemData(cboConsultant, cboConsultant.SelectedIndex)
                    Rs.Update()
                    MsgBox("User Account created.", MsgBoxStyle.Information)
                    Me.Hide()
                    bCancel = False
                End If
            End If

            Rs.Close()
            Cn.Close()

            'UPGRADE_NOTE: Object Rs may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            Rs = Nothing
            'UPGRADE_NOTE: Object Cn may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            Cn = Nothing

        End Sub

        Function ValidData() As Boolean
            ValidData = False

            If txtUserName.Text = String.Empty Then
                MsgBox("Please enter the username.", MsgBoxStyle.Information)
                txtUserName.Focus()
                Exit Function
            End If

            If cboUserType.Text = String.Empty Then
                MsgBox("Please select the user type.", MsgBoxStyle.Information)
                cboUserType.Focus()
                Exit Function
            ElseIf Microsoft.VisualBasic.Compatibility.VB6.GetItemData(cboUserType, cboUserType.SelectedIndex) = LA_Declarations.enumSecurityLevel.Consultant Then
                If cboConsultant.Text = String.Empty Then
                    MsgBox("Please select the Consultant.", MsgBoxStyle.Information)
                    cboConsultant.Focus()
                    Exit Function
                End If
            End If


            If txtPassword.Text <> txtConfirmation.Text Then
                MsgBox("The password and the confirmation are different.", MsgBoxStyle.Information)
                Exit Function
            End If

            ValidData = True

        End Function

        'UPGRADE_WARNING: Event cboUserType.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        'UPGRADE_WARNING: ComboBox event cboUserType.Change was upgraded to cboUserType.TextChanged which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
        Private Sub cboUserType_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboUserType.TextChanged

            If cboUserType.Text <> String.Empty And Microsoft.VisualBasic.Compatibility.VB6.GetItemData(cboUserType, cboUserType.SelectedIndex) = LA_Declarations.enumSecurityLevel.Consultant Then
                Me.cboConsultant.Enabled = True
                Me.cboConsultant.BackColor = Me.txtPassword.BackColor
            Else
                cboConsultant.SelectedIndex = 0
                Me.cboConsultant.Enabled = False
                Me.cboConsultant.BackColor = Me.BackColor
            End If

        End Sub

        'UPGRADE_WARNING: Event cboUserType.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub cboUserType_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboUserType.SelectedIndexChanged

            If cboUserType.Text <> String.Empty And Microsoft.VisualBasic.Compatibility.VB6.GetItemData(cboUserType, cboUserType.SelectedIndex) = LA_Declarations.enumSecurityLevel.Consultant Then
                Me.cboConsultant.Enabled = True
                Me.cboConsultant.BackColor = Me.txtPassword.BackColor
            Else
                cboConsultant.SelectedIndex = 0
                Me.cboConsultant.Enabled = False
                Me.cboConsultant.BackColor = Me.BackColor
            End If


        End Sub


        Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
            If ValidData() Then Call SaveUser()
        End Sub

        Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
            Me.Hide()
        End Sub

        Private Sub frmNewUser_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
            bCancel = False

            '//
            Me.cboConsultant.Enabled = False
            Me.cboConsultant.BackColor = Me.BackColor

            Call FillConsultantCBox((Me.cboConsultant), LA_Declarations.enumConsultantType.ctConsultant)


            '////////////////////////////////////////////////////////////////////
            '//Begin - Fill the user type combo box
            '////////////////////////////////////////////////////////////////////
            cboUserType.Items.Clear()
            cboUserType.Items.Add("")

            '//Accounting
            cboUserType.Items.Add("Accounting")
            Microsoft.VisualBasic.Compatibility.VB6.SetItemData(cboUserType, cboUserType.Items.Count - 1, LA_Declarations.enumSecurityLevel.accounting)

            '//Administrator
            cboUserType.Items.Add("Administrator")
            Microsoft.VisualBasic.Compatibility.VB6.SetItemData(cboUserType, cboUserType.Items.Count - 1, LA_Declarations.enumSecurityLevel.Administrator)

            '//Consultant
            cboUserType.Items.Add("Consultant")
            Microsoft.VisualBasic.Compatibility.VB6.SetItemData(cboUserType, cboUserType.Items.Count - 1, LA_Declarations.enumSecurityLevel.Consultant)

            '//Data Entry
            cboUserType.Items.Add("Data Entry")
            Microsoft.VisualBasic.Compatibility.VB6.SetItemData(cboUserType, cboUserType.Items.Count - 1, LA_Declarations.enumSecurityLevel.DataEntry)

            '//Inactive
            cboUserType.Items.Add("Inactive")
            Microsoft.VisualBasic.Compatibility.VB6.SetItemData(cboUserType, cboUserType.Items.Count - 1, LA_Declarations.enumSecurityLevel.Inactive)
            '////////////////////////////////////////////////////////////////////
            '//End - Fill the user type combo box
            '////////////////////////////////////////////////////////////////////



        End Sub
    End Class
End Namespace