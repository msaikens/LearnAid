Option Strict Off
Option Explicit On
Friend Class frmProcess
	Inherits System.Windows.Forms.Form
	
	Public Scan As Boolean
	Public JobIds As New Collection
	Public StopProcess As Boolean
	Public ProcessingJob As Boolean
	
	
	Function CreatePlugin(ByRef oPlugin As Object, ByRef PluginName As String) As Boolean
		On Error GoTo Errores
		oPlugin = CreateObject(PluginName & ".exam")
		
		If Not (oPlugin Is Nothing) Then
			CreatePlugin = True
		Else
			CreatePlugin = False
		End If
		Exit Function
		
Errores: 
		If Err.Number = 429 Then
			CreatePlugin = False
		Else
			MsgBox("Error in CreatePlugin Module", MsgBoxStyle.Critical)
		End If
		
	End Function
	
	
	Sub ProcessGroup()
		Dim Plugin As Object
		Dim PluginName As String
		Dim PluginName2 As String
		Dim i As Short
		Dim iJobStatus As Integer
		Dim MSG_CONS As String
		Dim bDoLES1 As Boolean
		Dim bDoREN1 As Boolean
		Dim bDoMAT1 As Boolean
		Dim bDoNV1 As Boolean
		Dim bDoLES2 As Boolean
		Dim bDoREN2 As Boolean
		Dim bDoMAT2 As Boolean
		Dim bDoNV2 As Boolean
		
		If Scan Then
			MSG_CONS = "Scanning Job "
		Else
			MSG_CONS = "Scoring Job "
		End If
		
		ProcessingJob = True
		
		'UPGRADE_WARNING: Couldn't resolve default property of object PBar.Min. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        PBar.Minimum = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object PBar.Max. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        PBar.Maximum = JobIds.Count()
		'UPGRADE_WARNING: Couldn't resolve default property of object PBar.Position. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'PBar.Position = 0
		
		
        For iCounter As Integer = 1 To JobIds.Count()
            'UPGRADE_WARNING: Couldn't resolve default property of object PBar.Max. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object PBar.Position. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'

            '--Code Change-- jh' lblMsg.Text = MSG_CONS & PBar.Position & " of " & PBar.Maximum
            lblMsg.Text = MSG_CONS & " of " & PBar.Maximum

            If StopProcess = True Then GoTo Terminate

            bDoLES1 = False
            bDoREN1 = False
            bDoMAT1 = False
            bDoNV1 = False
            bDoLES2 = False
            bDoREN2 = False
            bDoMAT2 = False
            bDoNV2 = False
            PluginName = ""
            PluginName2 = ""

            'UPGRADE_WARNING: Couldn't resolve default property of object JobIds(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If GetNextJobForProcess(Scan, JobIds.Item(i), iJobStatus, PluginName, bDoLES1, bDoREN1, bDoMAT1, bDoNV1, PluginName2, bDoLES2, bDoREN2, bDoMAT2, bDoNV2) Then
                System.Windows.Forms.Application.DoEvents()
                If Len(PluginName) > 0 Then
                    If CreatePlugin(Plugin, PluginName) Then

                        'UPGRADE_WARNING: Couldn't resolve default property of object Plugin.JobID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object JobIds(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        Plugin.JobID = JobIds.Item(i)
                        'UPGRADE_WARNING: Couldn't resolve default property of object Plugin.ConnectionString. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        Plugin.ConnectionString = Config.ConnectionString
                        'UPGRADE_WARNING: Couldn't resolve default property of object Plugin.EnableLog. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        Plugin.EnableLog = Config.EnableLog

                        'UPGRADE_WARNING: Couldn't resolve default property of object Plugin.DataFilePath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        Plugin.DataFilePath = Config.DataFilesPath
                        If PluginName <> "BATAIDR" And PluginName <> "BATPRE1" And PluginName <> "PEPV" Then
                            'UPGRADE_WARNING: Couldn't resolve default property of object Plugin.doLES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            Plugin.doLES = bDoLES1
                            'UPGRADE_WARNING: Couldn't resolve default property of object Plugin.doREN. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            Plugin.doREN = bDoREN1
                            'UPGRADE_WARNING: Couldn't resolve default property of object Plugin.doMAT. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            Plugin.doMAT = bDoMAT1
                            'UPGRADE_WARNING: Couldn't resolve default property of object Plugin.doNV. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            Plugin.doNV = bDoNV1
                        End If
                        If Scan Then
                            'UPGRADE_WARNING: Couldn't resolve default property of object Plugin.ScanExam. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            Plugin.ScanExam()
                        Else
                            'UPGRADE_WARNING: Couldn't resolve default property of object Plugin.DoScoring. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            Plugin.DoScoring()
                        End If

                        'UPGRADE_WARNING: Couldn't resolve default property of object Plugin.processingexam. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        While Plugin.processingexam
                            System.Windows.Forms.Application.DoEvents()
                        End While

                        'UPGRADE_WARNING: Couldn't resolve default property of object Plugin.processingexam. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        If Not Plugin.processingexam Then
                            ProcessingJob = False
                            'UPGRADE_WARNING: Couldn't resolve default property of object Plugin.ExamWarnings. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            If Plugin.ExamWarnings Then
                                'UPGRADE_WARNING: Couldn't resolve default property of object JobIds(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                Call ChangeJobStatus(JobIds.Item(i), , 1, "Warnning! One or more posible errors in scanning process")
                            End If
                            'UPGRADE_NOTE: Object Plugin may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
                            Plugin = Nothing

                        End If

                    Else
                        'UPGRADE_WARNING: Couldn't resolve default property of object JobIds(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        Call ChangeJobStatus(JobIds.Item(i), , 1, "Can't Find Plugin for this process")
                    End If
                End If

            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object PBar.Position. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'PBar.Position = i
        Next iCounter
		
Terminate: 
		ProcessingJob = False
	End Sub
	
	
	
	Private Sub frmProcess_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		StopProcess = False
		If Scan Then
			Animation.Open(My.Application.Info.DirectoryPath & "\Evaluating2.avi")
		Else
			Animation.Open(My.Application.Info.DirectoryPath & "\Scanning2.avi")
		End If
		
		Me.Refresh()
		Animation.AutoPlay = True
		
	End Sub
	
	Private Sub OKButton_Click()
		Me.Hide()
	End Sub
	
	Private Sub tmrProcess_Timer()
		
		Call ProcessGroup()
		
	End Sub
	
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
		Call ProcessGroup()
		
        For iCounter As Integer = 1 To JobIds.Count()
            JobIds.Remove(1)
        Next iCounter
		Me.Close()
		
	End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class