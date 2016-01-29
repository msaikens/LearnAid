Option Strict Off
Option Explicit On
Namespace Forms.UserLoginForms
    Friend Class frmUsers
        Inherits System.Windows.Forms.Form

        Function ChangePassword() As Boolean
            frmChangePassword.txtUserName.Text = lvUsers.FocusedItem.Text
            frmChangePassword.ShowDialog()
            If frmChangePassword.bCancel = True Then
                ChangePassword = False
            Else
                ChangePassword = True
            End If
            frmChangePassword.Close()

        End Function

        Function DeleteUser() As Boolean

            Dim Cn As New ADODB.Connection

            If MsgBox("Dou you want to delete the user account '" & lvUsers.FocusedItem.Text & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                OpenConnection(Cn, Config.ConnectionString)

                Cn.Execute("DELETE FROM USERS WHERE U_USERID ='" & lvUsers.FocusedItem.Text & "'")
                Cn.Close()
                'UPGRADE_NOTE: Object Cn may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
                Cn = Nothing
                DeleteUser = True
            Else
                DeleteUser = False
            End If

        End Function

        Sub FillListView()
            Dim Cn As ADODB.Connection
            Dim Rs As ADODB.Recordset
            Dim i As Integer
            Dim Node As System.Windows.Forms.ListViewItem

            Cn = New ADODB.Connection
            Rs = New ADODB.Recordset

            OpenConnection(Cn, Config.ConnectionString)

            Rs.Open("Select * From Users", Cn)

            lvUsers.Items.Clear()

            While Not Rs.EOF
                i += 1

                Node = lvUsers.Items.Add(Rs.Fields("U_UserID").Value)
                'UPGRADE_WARNING: Lower bound of collection Node has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                If Node.SubItems.Count > 1 Then
                    Node.SubItems(1).Text = GetUserType(GetValue(Rs.Fields("U_USER_TYPE"), -1))
                Else
                    Node.SubItems.Insert(1, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, GetUserType(GetValue(Rs.Fields("U_USER_TYPE"), -1))))
                End If

                Rs.MoveNext()
            End While
            Rs.Close()
            Cn.Close()
            'UPGRADE_NOTE: Object Rs may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            Rs = Nothing
            'UPGRADE_NOTE: Object Cn may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            Cn = Nothing

        End Sub

        Function GetNewUser() As Boolean
            frmNewUser.ShowDialog()

            If frmNewUser.bCancel = True Then
                GetNewUser = False
            Else
                GetNewUser = True
            End If
            frmNewUser.Close()
        End Function

        Sub SetList()
            On Error Resume Next
            lvUsers.Top = Toolbar1.Height
            lvUsers.Left = 0
            lvUsers.Width = ClientRectangle.Width
            lvUsers.Height = Microsoft.VisualBasic.Compatibility.VB6.TwipsToPixelsY(Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(ClientRectangle.Height) - Microsoft.VisualBasic.Compatibility.VB6.PixelsToTwipsY(lvUsers.Top))
            On Error GoTo 0
        End Sub

        Private Sub frmUsers_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
            Call FillListView()
        End Sub

        'UPGRADE_WARNING: Event frmUsers.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub frmUsers_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
            SetList()
        End Sub


        Private Sub Toolbar1_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _Toolbar1_Button1.Click, _Toolbar1_Button2.Click, _Toolbar1_Button3.Click, _Toolbar1_Button4.Click
            Dim Button As System.Windows.Forms.ToolStripItem = CType(eventSender, System.Windows.Forms.ToolStripItem)

            If (lvUsers.FocusedItem Is Nothing) Then
                MsgBox("Select an user account.", MsgBoxStyle.Information)
                Exit Sub
            End If

            Select Case Button.Name

                Case "New"
                    If GetNewUser = True Then Call FillListView()

                Case "Delete"
                    If DeleteUser Then Call FillListView()


                Case "ChangePassword"
                    If ChangePassword = True Then
                    End If
            End Select
        End Sub
    End Class
End Namespace