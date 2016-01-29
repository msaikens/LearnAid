Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmInformeConsultoresAdminMain
    Inherits System.Windows.Forms.Form

    Sub CreateNewINI(ByRef sFile As String)
        Dim vNewINI As Object = Nothing
        Dim iCtr As Short

        ' -- Condiciones
        'UPGRADE_WARNING: Couldn't resolve default property of object vNewINI. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vNewINI = vNewINI & "[Condiciones]" & vbCrLf
        With Me.lvContitions
            'UPGRADE_WARNING: Couldn't resolve default property of object vNewINI. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            vNewINI = vNewINI & "Count=" & .Items.Count & vbCrLf
            For iCtr = 1 To .Items.Count
                'UPGRADE_WARNING: Lower bound of collection Me.lvContitions.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                'UPGRADE_WARNING: Couldn't resolve default property of object vNewINI. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                vNewINI = vNewINI & "condicion" & iCtr - 1 & "=" & .Items.Item(iCtr).Text & vbCrLf
            Next iCtr
        End With
        'UPGRADE_WARNING: Couldn't resolve default property of object vNewINI. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vNewINI = vNewINI & vbCrLf

        ' -- Instrucciones
        'UPGRADE_WARNING: Couldn't resolve default property of object vNewINI. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vNewINI = vNewINI & "[Instrucciones]" & vbCrLf
        With Me.lvInstructions
            'UPGRADE_WARNING: Couldn't resolve default property of object vNewINI. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            vNewINI = vNewINI & "Count=" & .Items.Count & vbCrLf
            For iCtr = 1 To .Items.Count
                'UPGRADE_WARNING: Lower bound of collection Me.lvInstructions.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                'UPGRADE_WARNING: Couldn't resolve default property of object vNewINI. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                vNewINI = vNewINI & "instruccion" & iCtr - 1 & "=" & .Items.Item(iCtr).Text & vbCrLf
            Next iCtr
        End With
        'UPGRADE_WARNING: Couldn't resolve default property of object vNewINI. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vNewINI = vNewINI & vbCrLf

        ' -- Repeticiones
        'UPGRADE_WARNING: Couldn't resolve default property of object vNewINI. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vNewINI = vNewINI & "[Repeticion]" & vbCrLf
        With Me.lvRepetition
            'UPGRADE_WARNING: Couldn't resolve default property of object vNewINI. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            vNewINI = vNewINI & "Count=" & .Items.Count & vbCrLf
            For iCtr = 1 To .Items.Count
                'UPGRADE_WARNING: Lower bound of collection Me.lvRepetition.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                'UPGRADE_WARNING: Couldn't resolve default property of object vNewINI. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                vNewINI = vNewINI & "repeticion" & iCtr - 1 & "=" & .Items.Item(iCtr).Text & vbCrLf
            Next iCtr
        End With
        'UPGRADE_WARNING: Couldn't resolve default property of object vNewINI. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vNewINI = vNewINI & vbCrLf

        ' -- Conducta
        'UPGRADE_WARNING: Couldn't resolve default property of object vNewINI. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vNewINI = vNewINI & "[Conducta]" & vbCrLf
        With Me.lvConduct
            'UPGRADE_WARNING: Couldn't resolve default property of object vNewINI. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            vNewINI = vNewINI & "Count=" & .Items.Count & vbCrLf
            For iCtr = 1 To .Items.Count
                'UPGRADE_WARNING: Lower bound of collection Me.lvConduct.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                'UPGRADE_WARNING: Couldn't resolve default property of object vNewINI. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                vNewINI = vNewINI & "conducta" & iCtr - 1 & "=" & .Items.Item(iCtr).Text & vbCrLf
            Next iCtr
        End With
        'UPGRADE_WARNING: Couldn't resolve default property of object vNewINI. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vNewINI = vNewINI & vbCrLf

        ' -- Recomendaciones
        'UPGRADE_WARNING: Couldn't resolve default property of object vNewINI. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vNewINI = vNewINI & "[Recomendaciones]" & vbCrLf
        With Me.lvRecommendations
            'UPGRADE_WARNING: Couldn't resolve default property of object vNewINI. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            vNewINI = vNewINI & "Count=" & .Items.Count & vbCrLf
            For iCtr = 1 To .Items.Count
                'UPGRADE_WARNING: Lower bound of collection Me.lvRecommendations.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                'UPGRADE_WARNING: Couldn't resolve default property of object vNewINI. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                vNewINI = vNewINI & "recomendacion" & iCtr - 1 & "=" & .Items.Item(iCtr).Tag & vbCrLf
            Next iCtr
        End With
        'UPGRADE_WARNING: Couldn't resolve default property of object vNewINI. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        vNewINI = vNewINI & vbCrLf

        'CreateFile sFile, vNewINI

    End Sub

    Private Sub cmdAddCondiiton_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAddCondiiton.Click
        'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'

        '--Code Change-- jh' Load(frmAddEditConduct)
        Dim frmAddEditCondition As New frmAddEditCondition

        frmAddEditCondition.txtAction.Text = "A"
        frmAddEditCondition.ShowDialog()
    End Sub

    Private Sub cmdAddConduct_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAddConduct.Click
        'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'

        '--Code Change-- jh' Load(frmAddEditConduct)
        Dim frmAddEditConduct As New frmAddEditConduct

        frmAddEditConduct.txtAction.Text = "A"
        frmAddEditConduct.ShowDialog()
    End Sub

    Private Sub cmdAddInstruction_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAddInstruction.Click
        'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'

        '--Code Change-- jh'  Load(frmAddEditInstruction)
        Dim frmAddEditInstruction As New frmAddEditInstruction

        frmAddEditInstruction.txtAction.Text = "A"
        frmAddEditInstruction.ShowDialog()
    End Sub

    Private Sub cmdAddRecommendation_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAddRecommendation.Click
        'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'

        '--Code Change-- jh' Load(frmAddEditRecommendation)
        Dim frmAddEditRecommendation As New frmAddEditRecommendation

        frmAddEditRecommendation.txtAction.Text = "A"
        frmAddEditRecommendation.ShowDialog()
    End Sub

    Private Sub cmdAddRepetition_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAddRepetition.Click
        'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'

        '--Code Change-- jh' Load(frmAddEditRepetition)
        Dim frmAddEditRepetition As New frmAddEditRepetition

        frmAddEditRepetition.txtAction.Text = "A"
        frmAddEditRepetition.ShowDialog()
    End Sub

    Private Sub cmdDeleteCondiiton_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDeleteCondiiton.Click
        If Not Me.lvContitions.FocusedItem Is Nothing Then
            Me.lvContitions.Items.RemoveAt((Me.lvContitions.FocusedItem.Name))
        End If
    End Sub

    Private Sub cmdDeleteConduct_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDeleteConduct.Click
        If Not Me.lvConduct.FocusedItem Is Nothing Then
            Me.lvConduct.Items.RemoveAt((Me.lvConduct.FocusedItem.Name))
        End If
    End Sub

    Private Sub cmdDeleteInstruction_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDeleteInstruction.Click
        If Not Me.lvInstructions.FocusedItem Is Nothing Then
            Me.lvInstructions.Items.RemoveAt((Me.lvInstructions.FocusedItem.Name))
        End If
    End Sub

    Private Sub cmdDeleteRecommendation_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDeleteRecommendation.Click
        If Not Me.lvRecommendations.FocusedItem Is Nothing Then
            Me.lvRecommendations.Items.RemoveAt((Me.lvRecommendations.FocusedItem.Name))
        End If
    End Sub

    Private Sub cmdDeleteRepetition_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDeleteRepetition.Click
        If Not Me.lvRepetition.FocusedItem Is Nothing Then
            Me.lvRepetition.Items.RemoveAt((Me.lvRepetition.FocusedItem.Name))
        End If
    End Sub

    Private Sub cmdEditCondiiton_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEditCondiiton.Click
        If Not Me.lvContitions.FocusedItem Is Nothing Then
            'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'

            '--Code Change-- jh'   Load(frmAddEditCondition)
            Dim frmAddEditCondition As New frmAddEditCondition

            frmAddEditCondition.txtAction.Text = "E"
            frmAddEditCondition.txtData.Text = Me.lvContitions.FocusedItem.Text
            frmAddEditCondition.ShowDialog()
        End If
    End Sub

    Private Sub cmdEditConduct_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEditConduct.Click
        If Not Me.lvConduct.FocusedItem Is Nothing Then
            'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'

            '--Code Change-- jh'  Load(frmAddEditConduct)
            Dim frmAddEditConduct As New frmAddEditConduct

            frmAddEditConduct.txtAction.Text = "E"
            frmAddEditConduct.txtData.Text = Me.lvConduct.FocusedItem.Text
            frmAddEditConduct.ShowDialog()
        End If
    End Sub

    Private Sub cmdEditInstruction_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEditInstruction.Click
        If Not Me.lvInstructions.FocusedItem Is Nothing Then
            'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'

            '--Code Change-- jh' Load(frmAddEditInstruction)
            Dim frmAddEditInstruction As New frmAddEditInstruction

            frmAddEditInstruction.txtAction.Text = "E"
            frmAddEditInstruction.txtData.Text = Me.lvInstructions.FocusedItem.Text
            frmAddEditInstruction.ShowDialog()
        End If
    End Sub

    Private Sub cmdEditRecommendation_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEditRecommendation.Click
        If Not Me.lvRecommendations.FocusedItem Is Nothing Then
            'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'

            '--Code Change-- jh' Load(frmAddEditRecommendation)
            Dim frmAddEditRecommendation As New frmAddEditRecommendation

            frmAddEditRecommendation.txtAction.Text = "E"
            frmAddEditRecommendation.txtData.Text = Me.lvRecommendations.FocusedItem.Tag
            frmAddEditRecommendation.ShowDialog()
        End If
    End Sub

    Private Sub cmdEditRepetition_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEditRepetition.Click
        If Not Me.lvRepetition.FocusedItem Is Nothing Then
            'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'

            '--Code Change-- jh'  Load(frmAddEditRepetition)
            Dim frmAddEditRepetition As New frmAddEditRepetition

            frmAddEditRepetition.txtAction.Text = "E"
            frmAddEditRepetition.txtData.Text = Me.lvRepetition.FocusedItem.Text
            frmAddEditRepetition.ShowDialog()
        End If
    End Sub

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Me.Close()
    End Sub

    Private Sub Command16_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command16.Click
        Kill(My.Application.Info.DirectoryPath & "\data.ini")
        CreateNewINI(My.Application.Info.DirectoryPath & "\data.ini")
        Me.Close()
    End Sub

    Private Sub frmInformeConsultoresAdminMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.SSTab1.SelectedIndex = 0
        FillInstrucciones()
        FillCondiciones()
        FillRepeticion()
        FillConducta()
        FillRecomendaciones()
    End Sub

    Sub FillInstrucciones()
        Dim sText As Object
        Dim iCount As Short
        Dim iCtr As Short
        Dim objThisItem As System.Windows.Forms.ListViewItem

        iCount = CShort(GetINIValue(Config.ReportsPath & "\data.ini", "Instrucciones", "Count"))

        For iCtr = 0 To iCount - 1
            'UPGRADE_WARNING: Couldn't resolve default property of object sText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sText = GetINIValue(Config.ReportsPath & "\data.ini", "Instrucciones", "Instruccion" & iCtr)
            'UPGRADE_WARNING: Couldn't resolve default property of object sText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            objThisItem = Me.lvInstructions.Items.Add("instruction" & iCtr, sText, "")
        Next iCtr
    End Sub
    Sub FillRecomendaciones()
        Dim sText As Object
        Dim iCount As Short
        Dim iCtr As Short
        Dim objThisItem As System.Windows.Forms.ListViewItem

        iCount = CShort(GetINIValue(Config.ReportsPath & "\data.ini", "Recomendaciones", "Count"))

        For iCtr = 0 To iCount - 1
            'UPGRADE_WARNING: Couldn't resolve default property of object sText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sText = GetINIValue(Config.ReportsPath & "\data.ini", "Recomendaciones", "Recomendacion" & iCtr)
            'UPGRADE_WARNING: Couldn't resolve default property of object sText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            objThisItem = Me.lvRecommendations.Items.Add("recomendacion" & iCtr, VB.Left(sText, 75) & "...", "")
            'UPGRADE_WARNING: Couldn't resolve default property of object sText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            objThisItem.Tag = sText
        Next iCtr
    End Sub

    Sub FillRepeticion()
        Dim sText As Object
        Dim iCount As Short
        Dim iCtr As Short
        Dim objThisItem As System.Windows.Forms.ListViewItem

        iCount = CShort(GetINIValue(Config.ReportsPath & "\data.ini", "Repeticion", "Count"))

        For iCtr = 0 To iCount - 1
            'UPGRADE_WARNING: Couldn't resolve default property of object sText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sText = GetINIValue(Config.ReportsPath & "\data.ini", "Repeticion", "Repeticion" & iCtr)
            'UPGRADE_WARNING: Couldn't resolve default property of object sText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            objThisItem = Me.lvRepetition.Items.Add("Repeticion" & iCtr, sText, "")
        Next iCtr
    End Sub

    Sub FillConducta()
        Dim sText As Object
        Dim iCount As Short
        Dim iCtr As Short
        Dim objThisItem As System.Windows.Forms.ListViewItem

        iCount = CShort(GetINIValue(Config.ReportsPath & "\data.ini", "Conducta", "Count"))

        For iCtr = 0 To iCount - 1
            'UPGRADE_WARNING: Couldn't resolve default property of object sText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sText = GetINIValue(Config.ReportsPath & "\data.ini", "Conducta", "Conducta" & iCtr)
            'UPGRADE_WARNING: Couldn't resolve default property of object sText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            objThisItem = Me.lvConduct.Items.Add("Conducta" & iCtr, sText, "")
        Next iCtr
    End Sub

    Sub FillCondiciones()
        Dim sText As Object
        Dim iCount As Short
        Dim iCtr As Short
        Dim objThisItem As System.Windows.Forms.ListViewItem

        iCount = CShort(GetINIValue(Config.ReportsPath & "\data.ini", "Condiciones", "Count"))

        For iCtr = 0 To iCount - 1
            'UPGRADE_WARNING: Couldn't resolve default property of object sText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sText = GetINIValue(Config.ReportsPath & "\data.ini", "Condiciones", "Condicion" & iCtr)
            'UPGRADE_WARNING: Couldn't resolve default property of object sText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            objThisItem = Me.lvContitions.Items.Add("condition" & iCtr, sText, "")
        Next iCtr
    End Sub

    Private Sub lvConduct_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvConduct.DoubleClick
        cmdEditConduct_Click(cmdEditConduct, New System.EventArgs())
    End Sub

    Private Sub lvContitions_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvContitions.DoubleClick
        cmdEditCondiiton_Click(cmdEditCondiiton, New System.EventArgs())
    End Sub

    Private Sub lvInstructions_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvInstructions.DoubleClick
        cmdEditInstruction_Click(cmdEditInstruction, New System.EventArgs())
    End Sub

    Private Sub lvRecommendations_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvRecommendations.DoubleClick
        cmdEditRecommendation_Click(cmdEditRecommendation, New System.EventArgs())
    End Sub

    Private Sub lvRepetition_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvRepetition.DoubleClick
        cmdEditRepetition_Click(cmdEditRepetition, New System.EventArgs())
    End Sub
End Class