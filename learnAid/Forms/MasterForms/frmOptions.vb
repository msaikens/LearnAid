Option Strict Off
Option Explicit On
Namespace Forms.MasterForms
    Friend Class frmOptions
        Inherits System.Windows.Forms.Form

        Public FirstExecution As Boolean

#Region "LEVEL ONE ROUTINES"
        Private Sub frmOptions_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
            Call LoadData()
        End Sub

        'UPGRADE_WARNING: Event chkBlankPassword.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        Private Sub chkBlankPassword_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkBlankPassword.CheckStateChanged
            If chkBlankPassword.CheckState = System.Windows.Forms.CheckState.Checked Then
                Me.txtPassword.Enabled = False
                Me.txtPassword.BackColor = Me.BackColor
                Me.txtPassword.Text = String.Empty
            Else
                Me.txtPassword.Enabled = True
                Me.txtPassword.BackColor = Me.txtUserID.BackColor
                Me.txtPassword.Text = String.Empty
            End If

        End Sub

        Private Sub cmdApply_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdApply.Click
            If ValidData() Then
                SaveData()
                Config.FirstExecution = False
                Call LA_Declarations.SaveSystemSettings()
                Call LA_Declarations.RegisterPlugins()
            End If
        End Sub

        Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
            Me.Close()
        End Sub

        Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
            If ValidData() Then
                SaveData()
                Config.FirstExecution = False
                Call LA_Declarations.SaveSystemSettings()
                Call LA_Declarations.RegisterPlugins()
                Me.Close()
            End If
        End Sub

        Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
            Dim Desc As String = TestConnection()
            If Desc = String.Empty Then
                MsgBox("The Connection was sucessfully tested.", MsgBoxStyle.Information)
            Else
                MsgBox(Desc, MsgBoxStyle.Critical, "Error testing the connection.")
            End If
        End Sub

        Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
            Dim StrFolder As String
            StrFolder = BrowseForFolder(Me.Handle.ToInt32, "Select the Data Folder")
            If StrFolder <> String.Empty Then
                If Len(StrFolder) > 3 Then
                    StrFolder &= "\"
                End If
                Me.txtDataFilesPath.Text = StrFolder
            End If
        End Sub

        Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
            Dim StrFolder As String
            StrFolder = BrowseForFolder(Me.Handle.ToInt32, "Select the consultant's report Folder")
            If StrFolder <> String.Empty Then
                If Len(StrFolder) > 3 Then
                    StrFolder &= "\"
                End If
                Me.txtConsultantsPath.Text = StrFolder
            End If
        End Sub

        Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
            Dim StrFolder As String
            StrFolder = BrowseForFolder(Me.Handle.ToInt32, "Select the reports folder")
            If StrFolder <> String.Empty Then
                If Len(StrFolder) > 3 Then
                    StrFolder &= "\"
                End If
                Me.txtReportsPath.Text = StrFolder
            End If
        End Sub

        Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
            Dim StrFolder As String
            StrFolder = BrowseForFolder(Me.Handle.ToInt32, "Select the Plugins Folder")
            If StrFolder <> String.Empty Then
                If Len(StrFolder) > 3 Then
                    StrFolder &= "\"
                End If
                Me.txtPluginsPath.Text = StrFolder
            End If
        End Sub

#End Region
#Region "LEVEL TWO ROUTINES"
        Sub LoadData()
            With Config
                '////////////////////////////////////////////////////////////////////////
                '    Set the Database Tab
                '////////////////////////////////////////////////////////////////////////
                Me.txtDatabase.Text = .DatabaseName
                Me.txtDataSource.Text = .DataSource
                Me.txtPassword.Text = .DbPassword
                Me.txtUserID.Text = .DbUserID
                Me.txtCompID.Text = .COMP_ID

                '////////////////////////////////////////////////////////////////////////
                '    Set the General Tab
                '////////////////////////////////////////////////////////////////////////
                Me.txtPluginsPath.Text = .PluginsPath
                Me.txtConsultantsPath.Text = .ConsultantsPath
                Me.txtReportsPath.Text = .ReportsPath
                Me.txtDataFilesPath.Text = .DataFilesPath
                Me.chkShowStartUp.CheckState = CBool2Int(Config.ShowStartUp)
                Me.chkBlankPassword.CheckState = CBool2Int(Config.DbBlankPWD)
                Me.chkEnableLog.CheckState = CBool2Int(Config.EnableLog)

                If Config.DbBlankPWD Then
                    Me.txtPassword.Enabled = False
                    Me.txtPassword.BackColor = Me.BackColor
                    Me.txtPassword.Text = ""
                End If
            End With
        End Sub

        Sub SaveData()
            With Config
                .DatabaseName = Me.txtDatabase.Text
                .DataSource = Me.txtDataSource.Text
                .DbBlankPWD = (Me.chkBlankPassword.CheckState = System.Windows.Forms.CheckState.Checked)
                .DbPassword = Me.txtPassword.Text
                .DbUserID = Me.txtUserID.Text
                .COMP_ID = Me.txtCompID.Text
                .ConnectionString = GetConnectionString(.DbUserID, .DbPassword, .DatabaseName, .DataSource, .DbBlankPWD)

                .PluginsPath = Me.txtPluginsPath.Text
                .ConsultantsPath = Me.txtConsultantsPath.Text
                .ReportsPath = Me.txtReportsPath.Text
                .DataFilesPath = Me.txtDataFilesPath.Text
                .ShowStartUp = (Me.chkShowStartUp.CheckState = System.Windows.Forms.CheckState.Checked)
                .EnableLog = (Me.chkEnableLog.CheckState = System.Windows.Forms.CheckState.Checked)
            End With
        End Sub

        Function ValidData() As Boolean
            ValidData = False

            '//////////////////////////////////////////////////////
            '   Validate General Tab
            '//////////////////////////////////////////////////////
            If Trim(txtCompID.Text) = "" Then
                MsgBox("It's required a unique Id for this computer.", MsgBoxStyle.Information)
                Exit Function
            End If

            If Not System.IO.Directory.Exists(Me.txtDataFilesPath.Text) Or Trim(Me.txtDataFilesPath.Text) = "" Then
                MsgBox("The Data files path specified is invalid or does not exist.", MsgBoxStyle.Information)
                Exit Function
            ElseIf Microsoft.VisualBasic.Right(txtDataFilesPath.Text, 1) <> "\" Then
                txtDataFilesPath.Text &= "\"
            End If

            If Not System.IO.Directory.Exists(Me.txtPluginsPath.Text) Or Trim(Me.txtPluginsPath.Text) = "" Then
                MsgBox("The plugins path specified is invalid or does not exist.", MsgBoxStyle.Information)
                Exit Function
            ElseIf Microsoft.VisualBasic.Right(txtPluginsPath.Text, 1) <> "\" Then
                txtPluginsPath.Text &= "\"
            End If


            If Not System.IO.Directory.Exists(Me.txtConsultantsPath.Text) Or Trim(Me.txtConsultantsPath.Text) = "" Then
                MsgBox("The consultants report path specified is invalid or does not exist.", MsgBoxStyle.Information)
                Exit Function
            ElseIf Microsoft.VisualBasic.Right(txtConsultantsPath.Text, 1) <> "\" Then
                txtConsultantsPath.Text &= "\"
            End If

            If Not System.IO.Directory.Exists(Me.txtReportsPath.Text) Or Trim(Me.txtReportsPath.Text) = "" Then
                MsgBox("The Reports path specified is invalid or does not exist.", MsgBoxStyle.Information)
                Exit Function
            ElseIf Microsoft.VisualBasic.Right(txtReportsPath.Text, 1) <> "\" Then
                txtReportsPath.Text &= "\"
            End If


            '//////////////////////////////////////////////////////
            '   Validate Database Tab
            '//////////////////////////////////////////////////////
            Dim Desc As String

            Desc = TestConnection()
            If Desc <> String.Empty Then
                MsgBox(Desc, MsgBoxStyle.Critical, "Error testing the connection.")
                Exit Function
            End If


            ValidData = True
        End Function

#End Region
#Region "LEVEL THREE ROUTINES"
        Function TestConnection() As String
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset
            Dim CS As String
            Try
                'On Error GoTo Errores

                CS = GetConnectionString((Me.txtUserID).Text, (Me.txtPassword).Text, (Me.txtDatabase).Text, (Me.txtDataSource).Text, Me.chkBlankPassword.CheckState = System.Windows.Forms.CheckState.Checked)

                Cn.ConnectionTimeout = iMaxConn
                Cn.CommandTimeout = iMaxConn
                Cn.Open(CS)
                Rs.Open("Select * from Answers where a_ID = -1", Cn)
                Rs.Close()
                Cn.Close()
                Return Nothing
            Catch ex As Exception
                TestConnection = ex.Message
            End Try
        End Function
#End Region
#Region "Unknown Routines"
        Sub UpdateData()

        End Sub
#End Region

    End Class
End Namespace