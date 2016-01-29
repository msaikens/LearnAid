Option Strict Off
Option Explicit On

Imports learnAid.Forms.MasterForms
Namespace Forms.UserLoginForms
    Friend Class frmLogin
        Inherits System.Windows.Forms.Form

        Public LoginSucceeded As Boolean
#Region "LEVEL ONE ROUTINES"
        ''' <param name="eventSender"></param>
        ''' <param name="eventArgs"></param>
        ''' <remarks>
        '''           Called By: frmMain.Main()
        ''' </remarks>

        Private Sub frmLogin_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

            'Dim netVersion As String
            'Dim localVersion As String
            'Dim SyncVersion As String
            'Dim y As Integer

            'TODO
            ''Check Version
            'netVersion = GetFileVersion("\\server1\Ddrive\LearnAid\learnaid.exe")
            'localVersion = GetFileVersion(My.Application.Info.DirectoryPath & "\learnaid.exe")
            'SyncVersion = GetFileVersion(My.Application.Info.DirectoryPath & "\learnaid_sync.exe")
            'If localVersion <> netVersion And SyncVersion <> "" Then
            '	'actualizar versiones
            '	y = Shell(My.Application.Info.DirectoryPath & "\learnaid_sync.exe", AppWinStyle.Hide)
            '	End
            'End If

            'LoginSucceeded = False
            'Me.lblVersion.Text = GetFileVersion(My.Application.Info.DirectoryPath & "\learnaid.exe")

            Me.cboDB.Items.Clear()
            Me.cboDB.Items.Add("LA")
            Me.cboDB.Items.Add("TITULO1")
            Me.cboDB.SelectedIndex = 0

            Me.TopMost = True
        End Sub

        'UPGRADE_WARNING: Form event frmLogin.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        Private Sub frmLogin_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
            Me.txtUserName.Text = LoggedUser.UserID
            If Me.txtUserName.Text <> String.Empty Then
                Me.txtPassword.Focus()
            End If
        End Sub
        Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
            'set the global var to false
            'to denote a failed login
            LoginSucceeded = False
            'No need to set any variables really. If cancel is clicked, the user doesn't need to access the software.
            'Terminate the entire aplication on all threads.?
            Me.Close()
            Application.Exit()
        End Sub

        Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
            'On Error GoTo Errores
            Dim Cn As New ADODB.Connection
            Dim Rs As ADODB.Recordset
            Dim sPassword As String = String.Empty

            'REConfigurar Connection string
            Select Case Me.cboDB.SelectedIndex
                Case 0
                    'se queda igual
                    bTITULO1 = False
                    'Config.ConnectionString = "Driver={SQL Native Client};Server=SERVER1;Database=LA; Uid=sa;Pwd=;"
                    'Config.ConnectionString = GetConnectionString(Config.DbUserID, Config.DbPassword, Config.DatabaseName, Config.DataSource, Config.DbBlankPWD)
                    Config.ConnectionString = BLL.GlobalResources.GetConnectionStringAdo(Config.DbUserID, Config.DbPassword, Config.DatabaseName, Config.DataSource, Config.DbBlankPWD)
                    Config.ConnectionStringAdo = BLL.GlobalResources.GetConnectionStringAdo(Config.DbUserID, Config.DbPassword, Config.DatabaseName, Config.DataSource, Config.DbBlankPWD)
                Case 1
                    'Config.ConnectionString = GetConnectionString(Config.DbUserID, Config.DbPassword, "LA_TITULO1", Config.DataSource, Config.DbBlankPWD)
                    'Config.ConnectionString = "Driver={SQL Native Client};Server=SERVER1;Database=LA_TITULO1; Uid=sa;Pwd=;"
                    Config.ConnectionString = BLL.GlobalResources.GetConnectionStringAdo(Config.DbUserID, Config.DbPassword, "LA_TITULO1", Config.DataSource, Config.DbBlankPWD)
                    Config.ConnectionStringAdo = BLL.GlobalResources.GetConnectionStringAdo(Config.DbUserID, Config.DbPassword, "LA_TITULO1", Config.DataSource, Config.DbBlankPWD)
                    bTITULO1 = True
                Case Else
                    MsgBox("Please select the Database")
                    Exit Sub
            End Select

            'connection string might be changes so opening the connection
            BLL.GlobalResources.OpenConnection()

            Dim sQuery As String = "SELECT U_PWD,U_USER_TYPE,U_CONS_ID FROM USERS WHERE U_USERID = '" & Me.txtUserName.Text & "'"
            Dim dt As DataTable = BLL.GlobalResources.ExecuteDataTable(sQuery)
            If dt.Rows.Count > 0 Then
                If dt.Rows(0)("U_USER_TYPE").ToString() = LA_Declarations.enumSecurityLevel.Inactive Then
                    MsgBox("Your user account was disable. Please contact your system administrator.", MsgBoxStyle.Critical, "Access Denied")
                    txtPassword.Text = String.Empty
                    txtUserName.Focus()
                    SendKeys.Send("{Home}+{End}")
                Else
                    If Not IsDBNull(dt.Rows(0)("U_PWD").ToString()) Then
                        sPassword = dt.Rows(0)("U_PWD").ToString()
                    End If
                    'check for correct password
                    If txtPassword.Text = sPassword Then
                        If Config.FirstExecution And Not (dt.Rows(0)("U_USER_TYPE").ToString() = LA_Declarations.enumSecurityLevel.Administrator) Then
                            MsgBox("The Administrator must be logged and configure the system before any user can use it.", MsgBoxStyle.Information, "Login")
                            Exit Sub
                        ElseIf Config.FirstExecution And (dt.Rows(0)("U_USER_TYPE").ToString() = LA_Declarations.enumSecurityLevel.Administrator) Then
                            frmOptions.ShowDialog()
                        End If

                        LoggedUser.UserID = txtUserName.Text
                        LoggedUser.UserType = dt.Rows(0)("U_USER_TYPE").ToString()
                        If LoggedUser.UserType = LA_Declarations.enumSecurityLevel.Consultant Then
                            LoggedUser.Cons_ID = GetValue(dt.Rows(0)("U_Cons_ID").ToString())
                        End If

                        LoginSucceeded = True
                        Me.Hide()
                        frmMain.Show()
                    Else
                        MsgBox("Invalid Password, try again!", MsgBoxStyle.Information, "Login")
                        txtPassword.Focus()
                        SendKeys.Send("{Home}+{End}")
                    End If
                End If
            Else
                MsgBox("Invalid Username, try again!", MsgBoxStyle.Information, "Login")
                txtPassword.Text = String.Empty
                txtUserName.Focus()
                SendKeys.Send("{Home}+{End}")
            End If

            '            Rs = New ADODB.Recordset

            '            OpenConnection(Cn, Config.ConnectionString)

            '            Rs.Open("SELECT U_PWD,U_USER_TYPE,U_CONS_ID FROM USERS WHERE U_USERID = '" & Me.txtUserName.Text & "'", Cn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
            '            If Not Rs.EOF Then
            '                If Rs.Fields("U_USER_TYPE").Value = LA_Declarations.enumSecurityLevel.Inactive Then
            '                    MsgBox("Your user account was disable. Please contact your system administrator.", MsgBoxStyle.Critical, "Access Denied")
            '                    txtPassword.Text = ""
            '                    txtUserName.Focus()
            '                    SendKeys.Send("{Home}+{End}")
            '                Else
            '                    If Not IsDBNull(Rs.Fields("U_PWD").Value) Then sPassword = Rs.Fields("U_PWD").Value
            '                    'check for correct password
            '                    If txtPassword.Text = sPassword Then
            '                        If Config.FirstExecution And Not (Rs.Fields("U_USER_TYPE").Value = LA_Declarations.enumSecurityLevel.Administrator) Then
            '                            MsgBox("The Administrator must be logged and configure the system before any user can use it.", MsgBoxStyle.Information, "Login")
            '                            Rs.Close()
            '                            Cn.Close()
            '                            Exit Sub
            '                        ElseIf Config.FirstExecution And (Rs.Fields("U_USER_TYPE").Value = LA_Declarations.enumSecurityLevel.Administrator) Then
            '                            frmOptions.ShowDialog()
            '                        End If

            '                        LoggedUser.UserID = txtUserName.Text
            '                        LoggedUser.UserType = Rs.Fields("U_USER_TYPE").Value
            '                        If LoggedUser.UserType = LA_Declarations.enumSecurityLevel.Consultant Then
            '                            LoggedUser.Cons_ID = GetValue(Rs.Fields("U_Cons_ID"), 0)
            '                        End If

            '                        '---
            '                        LoginSucceeded = True
            '                        Me.Hide()
            '                        frmMain.Show()
            '                    Else
            '                        MsgBox("Invalid Password, try again!", MsgBoxStyle.Information, "Login")
            '                        txtPassword.Focus()
            '                        System.Windows.Forms.SendKeys.Send("{Home}+{End}")
            '                    End If
            '                End If
            '            Else
            '                MsgBox("Invalid Username, try again!", MsgBoxStyle.Information, "Login")
            '                txtPassword.Text = ""
            '                txtUserName.Focus()
            '                System.Windows.Forms.SendKeys.Send("{Home}+{End}")
            '            End If
            '            Rs.Close()
            '            Cn.Close()
            '            Exit Sub
            'Errores:
            '            MsgBox(Err.Description, MsgBoxStyle.Critical)

        End Sub



        Private Sub txtPassword_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPassword.Enter
            Me.txtPassword.SelectionStart = 0
            Me.txtPassword.SelectionLength = Len(Me.txtPassword.Text)
        End Sub


        Private Sub txtUserName_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtUserName.Enter
            Me.txtUserName.SelectionStart = 0
            Me.txtUserName.SelectionLength = Len(Me.txtUserName.Text)
        End Sub
#End Region
    End Class
End Namespace