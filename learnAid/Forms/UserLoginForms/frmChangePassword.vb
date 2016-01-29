Option Strict Off
Option Explicit On
Namespace Forms.UserLoginForms
    Friend Class frmChangePassword
        Inherits System.Windows.Forms.Form

        Public bCancel As Boolean
        Sub UpdateUser()
            Dim Cn As ADODB.Connection
            Dim Rs As ADODB.Recordset
            Cn = New ADODB.Connection
            Rs = New ADODB.Recordset

            OpenConnection(Cn, Config.ConnectionString)

            Rs.Open("Select * From Users Where U_USERID ='" & txtUserName.Text & "'", Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)

            If Rs.Fields("U_PWD").Value = txtOLD.Text Then
                Rs.Fields("U_PWD").Value = Me.txtNew.Text
                Rs.Update()
                MsgBox("Password was changed.", MsgBoxStyle.Information)
                Me.Hide()
                bCancel = False
            Else
                MsgBox("Old Password is incorrect.", MsgBoxStyle.Information)
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
            If txtNew.Text <> txtConfirmation.Text Then
                MsgBox("The new password and the confirmation are different.", MsgBoxStyle.Information)
                Exit Function
            End If
            ValidData = True
        End Function

        Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
            Me.Hide()
        End Sub

        Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
            If ValidData Then
                Call UpdateUser()
            End If
        End Sub

        Private Sub frmChangePassword_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
            bCancel = True
        End Sub
    End Class
End Namespace