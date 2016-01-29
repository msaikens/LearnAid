Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.Compatibility
Imports learnAid.Forms.ReportForms

Friend Class frmFive
    Inherits System.Windows.Forms.Form


    Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub


    Private Sub cmdProcesar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdProcesar.Click
        Dim sQuery As String
        Dim Cn As New ADODB.Connection
        Dim Rs As New ADODB.Recordset

        Dim y As Integer
        Dim CurrYear As Integer
        Dim StartingYear As Integer
        Dim bYear As Boolean
        Dim iCtr As Integer
        Dim CurrGrado As Integer
        Dim aa As Object
        Dim bb As Object = Nothing
        Dim iTotal As Integer
        Dim wSem As String = String.Empty

        Dim CurrNombre As String
        'Dim CurrHasta As Short

        Dim xArr(12, 7) As String
        Dim SchID As Integer
        Dim isOK As Boolean
        'ConnectionString = "Provider=MSDASQL.1;Persist Security Info=False;User ID=sa;Data Source=LearnAid;Initial Catalog=LA"
        'Dim CrxApp As New CRAXDRT.Application
        'Dim CrxRpt As CRAXDRT.Report

        'xArr columns
        '    0 - Nombre
        '    1 - Grado
        '    2 - NV
        '    3 - LES
        '    4 - REN
        '    5 - MAT
        '    6 - SERV DATE
        Dim RsRpt As New ADODB.Recordset

        OpenConnection(Cn, Config.ConnectionString)

        'Create RsRpt
        sQuery = "delete from FiveYearsData"
        Cn.Execute(sQuery)

        sQuery = "select * from FiveYearsData"
        RsRpt.Open(sQuery, Cn, 1, 3, 0)
        '---

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        'sem
        Select Case Me.cbosem.Text
            Case "BOTH"
                wSem = ""
            Case "1"
                wSem = " AND dbo.reports.rep_sem = 1 "
            Case "2"
                wSem = " AND dbo.reports.rep_sem = 2 "
        End Select
        '--


        'SchID = VB6.GetItemData(Me.cboSchools, Me.cboSchools.SelectedIndex)
        SchID = cboSchools.SelectedItem.ToString.Substring(0, cboSchools.SelectedItem.ToString.LastIndexOf(" -"))
        iTotal = 0
        sQuery = "SELECT     TOP 100 PERCENT ResEst.rese_nombre, Resultados.resg_Grado, ROUND(ResEst.rese_esta_n, 0) AS NV, ROUND(ResEst.rese_esta_l, 0) AS LES, ROUND(ResEst.rese_esta_r, 0) AS REN, ROUND(ResEst.rese_esta_m, 0) AS MAT, Reports.Rep_SCH_ID, reports.rep_serv_date " & "FROM  SCHOOLS INNER JOIN " & "Reports ON dbo.SCHOOLS.SC_ID = dbo.Reports.Rep_SCH_ID INNER JOIN " & "dbo.ResEst INNER JOIN " & "dbo.Resultados ON dbo.ResEst.resg_id = dbo.Resultados.resg_id ON dbo.Reports.Rep_ID = dbo.Resultados.resg_rep_id " & "Where (dbo.Reports.Rep_SCH_ID = " & SchID & ") And (dbo.Resultados.resg_Grado >= 1) " & "AND (ROUND(dbo.ResEst.rese_esta_n, 0) > 0) AND (ROUND(dbo.ResEst.rese_esta_l, 0) > 0) AND (ROUND(dbo.ResEst.rese_esta_r, 0) > 0) AND (ROUND(dbo.ResEst.rese_esta_m, 0) > 0) AND (dbo.Reports.Rep_Type = 2) " & "" & wSem & " " & "ORDER BY dbo.ResEst.rese_nombre ASC, dbo.Resultados.resg_Grado ASC"
        'quite reposicion = 0

        Rs.Open(sQuery, Cn, 3, 3)

        While Not Rs.EOF
            CurrNombre = GetValue(Rs.Fields("rese_nombre"))
            If CurrNombre = "ACOSTA Balseiro, Andres" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object bb. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object aa. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                aa = bb
            End If
            Debug.Print(Rs.Fields("rese_nombre").Value & " - " & Rs.Fields("resg_Grado").Value & " - " & Year(Rs.Fields("rep_serv_date").Value))
            CurrGrado = Rs.Fields("resg_Grado").Value
            isOK = True
            iCtr = 0
            bYear = True
            StartingYear = Me.txtYear.Text
            StartingYear = StartingYear - (CShort(Me.cboHasta.Text) - CShort(Me.cboDesde.Text))
            CurrYear = StartingYear
            For y = CInt(Me.cboDesde.Text) To CInt(Me.cboHasta.Text)
                If Not Rs.EOF Then
                    If CurrNombre = GetValue(Rs.Fields("rese_nombre")) Then
                        If Year(Rs.Fields("rep_serv_date").Value) <> CurrYear Then
                            y = 97
                            isOK = False
                            CurrGrado = 0
                            CurrYear = StartingYear
                        Else
                            CurrYear = CurrYear + 1
                        End If

                        If CurrGrado = y And isOK Then
                            'insert in array
                            xArr(iCtr, 0) = CurrNombre
                            xArr(iCtr, 1) = y
                            xArr(iCtr, 2) = IIf(Not IsDBNull(Rs.Fields("NV").Value), Rs.Fields("NV").Value, 0)
                            xArr(iCtr, 3) = IIf(Not IsDBNull(Rs.Fields("LES").Value), Rs.Fields("LES").Value, 0)
                            xArr(iCtr, 4) = IIf(Not IsDBNull(Rs.Fields("REN").Value), Rs.Fields("REN").Value, 0)
                            xArr(iCtr, 5) = IIf(Not IsDBNull(Rs.Fields("MAT").Value), Rs.Fields("MAT").Value, 0)
                            xArr(iCtr, 6) = Rs.Fields("rep_serv_date").Value
                            iCtr += 1
                        ElseIf CurrGrado > y Then
                            y = 99
                            isOK = False
                        ElseIf CurrGrado = (y - 1) And ((y - 1) >= Me.cboDesde.Text) Then
                            y = 99
                            isOK = False
                            '                        y = y - 1
                            '                        'insert in array
                            '                        xArr(iCtr, 0) = CurrNombre
                            '                        xArr(iCtr, 1) = y
                            '                        xArr(iCtr, 2) = IIf(Not IsNull(Rs!NV), Rs!NV, 0)
                            '                        xArr(iCtr, 3) = IIf(Not IsNull(Rs!LES), Rs!LES, 0)
                            '                        xArr(iCtr, 4) = IIf(Not IsNull(Rs!REN), Rs!REN, 0)
                            '                        xArr(iCtr, 5) = IIf(Not IsNull(Rs!MAT), Rs!MAT, 0)
                            '                        xArr(iCtr, 6) = Rs!rep_serv_date
                            '                        iCtr = iCtr + 1
                        End If
                    Else
                        isOK = False
                        y = 98
                    End If
                Else
                    y = 99
                End If
                If Not Rs.EOF Then
                    If y <> 98 Then
                        Rs.MoveNext()
                        If Not Rs.EOF Then
                            CurrGrado = Rs.Fields("resg_Grado").Value
                        End If
                    End If
                Else
                    y = 99
                End If
                System.Windows.Forms.Application.DoEvents()
            Next y

            If isOK = True And iCtr >= ((Val(Me.cboHasta.Text) - Val(Me.cboDesde.Text)) + 1) Then
                'add
                iTotal += 1
                For y = 0 To iCtr - 1
                    RsRpt.AddNew()
                    RsRpt.Fields("rpt_nombre").Value = xArr(y, 0)
                    RsRpt.Fields("rpt_grado").Value = xArr(y, 1)
                    RsRpt.Fields("rpt_nv").Value = xArr(y, 2)
                    RsRpt.Fields("rpt_les").Value = xArr(y, 3)
                    RsRpt.Fields("rpt_ren").Value = xArr(y, 4)
                    RsRpt.Fields("rpt_mat").Value = xArr(y, 5)
                    RsRpt.Fields("rpt_from").Value = Me.cboDesde.Text
                    RsRpt.Fields("rpt_to").Value = Me.cboHasta.Text
                    RsRpt.Fields("rpt_school").Value = GetSchoolName(SchID)
                    RsRpt.Fields("rpt_pueblo").Value = GetSchoolCity(SchID)
                    RsRpt.Fields("rpt_serv_date").Value = xArr(y, 6)

                    RsRpt.Update()
                    Debug.Print(xArr(y, 0) & " - " & xArr(y, 1) & "-" & xArr(y, 2))
                    System.Windows.Forms.Application.DoEvents()
                Next
            End If
            For y = 0 To 12
                xArr(y, 0) = ""
                xArr(y, 1) = ""
                xArr(y, 2) = ""
                xArr(y, 3) = ""
                xArr(y, 4) = ""
                xArr(y, 5) = ""
            Next y

        End While
        RsRpt.Close()

        Me.Cursor = Cursors.Default

        MsgBox("Completed. Total Records: " & iTotal)

        'TODO
        Dim rptI As New frmReport
        If iTotal > 0 Then
            rptI.ReportID = 0
            'rptIndiv.ReportFile = Config.ReportsPath & "Individual.rpt"
            rptI.ReportFile = Config.ReportsPath & "FiveYearsData.rpt"
            rptI.Show()
        End If
    End Sub

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Dim y As Integer
        Dim CurrGrado As Integer
        Dim CurrYear As Integer
        Dim StartingYear As Integer
        Dim bYear As Object
        Dim iCtr As Object
        Dim CurrCol As Object
        Dim iTotal As Integer
        Dim wSem As String = String.Empty

        
        'Exit Sub

        Dim Cn As New ADODB.Connection
        Dim Rs As New ADODB.Recordset
        Dim CurrNombre As String
        Dim CurrHasta As Short
        Dim sQuery As String
        Dim xArr(12, 7) As String
        Dim SchID As Integer
        Dim isOK As Boolean
        'ConnectionString = "Provider=MSDASQL.1;Persist Security Info=False;User ID=sa;Data Source=LearnAid;Initial Catalog=LA"
        'Dim CrxApp As New CRAXDRT.Application
        'Dim CrxRpt As CRAXDRT.Report


        'xArr columns
        '    0 - Nombre
        '    1 - Grado
        '    2 - NV
        '    3 - LES
        '    4 - REN
        '    5 - MAT
        '    6 - SERV DATE
        Dim RsRpt As New ADODB.Recordset

        OpenConnection(Cn, Config.ConnectionString)

        'Create RsRpt
        sQuery = "delete from FiveYearsData"
        Cn.Execute(sQuery)

        sQuery = "select * from FiveYearsData"
        RsRpt.Open(sQuery, Cn, 1, 3, 0)
        '---

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        'sem
        Select Case Me.cbosem.Text
            Case "BOTH"
                wSem = ""
            Case "1"
                wSem = " AND dbo.reports.rep_sem = 1 "
            Case "2"
                wSem = " AND dbo.reports.rep_sem = 2 "
        End Select
        '--

        SchID = cboSchools.SelectedItem.ToString.Substring(0, cboSchools.SelectedItem.ToString.LastIndexOf(" -"))
        iTotal = 0
        sQuery = "SELECT     TOP 100 PERCENT Reports.Rep_SCH_ID, reports.rep_serv_date " & "FROM  SCHOOLS INNER JOIN " & "Reports ON dbo.SCHOOLS.SC_ID = dbo.Reports.Rep_SCH_ID " & "Where (dbo.Resultados.resg_Grado > 1) " & "AND (dbo.Reports.Rep_Type = 2) " & "" & wSem & " AND dbo.Reports.rep_reposicion = 0 " & "ORDER BY rep_Sch_ID ASC "

        Rs.Open(sQuery, Cn, 3, 3)

        While Not Rs.EOF

            CurrCol = Rs.Fields("rep_sch_id").Value
            Debug.Print(Rs.Fields("rep_sch_id").Value)
            isOK = True
            iCtr = 0
            bYear = True
            StartingYear = Me.txtYear.Text
            StartingYear = StartingYear - (CShort(Me.cboHasta.Text) - CShort(Me.cboDesde.Text))
            CurrYear = StartingYear
            CurrGrado = Me.cboDesde.Text
            For y = CInt(Me.cboDesde.Text) To CInt(Me.cboHasta.Text)
                If Not Rs.EOF Then
                    If CurrNombre = Rs.Fields("rese_nombre").Value Then
                        If Year(Rs.Fields("rep_serv_date").Value) <> CurrYear Then
                            y = 97
                            isOK = False
                            CurrGrado = 0
                            CurrYear = StartingYear
                        Else
                            CurrYear += 1
                        End If

                        If CurrGrado = y And isOK Then
                            'insert in array
                            xArr(iCtr, 0) = CurrCol
                            xArr(iCtr, 1) = y
                            'xArr(iCtr, 2) = GetStanineProm(Rs!Rep_ID, "NV", y)
                            xArr(iCtr, 3) = IIf(Not IsDBNull(Rs.Fields("LES").Value), Rs.Fields("LES").Value, 0)
                            xArr(iCtr, 4) = IIf(Not IsDBNull(Rs.Fields("REN").Value), Rs.Fields("REN").Value, 0)
                            xArr(iCtr, 5) = IIf(Not IsDBNull(Rs.Fields("MAT").Value), Rs.Fields("MAT").Value, 0)
                            xArr(iCtr, 6) = Rs.Fields("rep_serv_date").Value
                            iCtr += 1
                        ElseIf CurrGrado > y Then
                            y = 99
                            isOK = False
                        ElseIf CurrGrado = (y - 1) And ((y - 1) >= Me.cboDesde.Text) Then
                            y = 99
                            isOK = False

                            '                        y = y - 1
                            '                        'insert in array
                            '                        xArr(iCtr, 0) = CurrNombre
                            '                        xArr(iCtr, 1) = y
                            '                        xArr(iCtr, 2) = IIf(Not IsNull(Rs!NV), Rs!NV, 0)
                            '                        xArr(iCtr, 3) = IIf(Not IsNull(Rs!LES), Rs!LES, 0)
                            '                        xArr(iCtr, 4) = IIf(Not IsNull(Rs!REN), Rs!REN, 0)
                            '                        xArr(iCtr, 5) = IIf(Not IsNull(Rs!MAT), Rs!MAT, 0)
                            '                        xArr(iCtr, 6) = Rs!rep_serv_date
                            '                        iCtr = iCtr + 1
                        End If
                    Else
                        isOK = False
                        y = 98
                    End If
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    y = 99
                End If
                If Not Rs.EOF Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If y <> 98 Then
                        Rs.MoveNext()
                        If Not Rs.EOF Then
                            CurrGrado = Rs.Fields("resg_Grado").Value
                        End If
                    End If
                Else
                    y = 99
                End If
                System.Windows.Forms.Application.DoEvents()
            Next y

            If isOK = True And iCtr >= ((Val(Me.cboHasta.Text) - Val(Me.cboDesde.Text)) + 1) Then
                'add
                iTotal += 1
                For y = 0 To iCtr - 1
                    RsRpt.AddNew()
                    RsRpt.Fields("rpt_nombre").Value = xArr(y, 0)
                    RsRpt.Fields("rpt_grado").Value = xArr(y, 1)
                    RsRpt.Fields("rpt_nv").Value = xArr(y, 2)
                    RsRpt.Fields("rpt_les").Value = xArr(y, 3)
                    RsRpt.Fields("rpt_ren").Value = xArr(y, 4)
                    RsRpt.Fields("rpt_mat").Value = xArr(y, 5)
                    RsRpt.Fields("rpt_from").Value = Me.cboDesde.Text
                    RsRpt.Fields("rpt_to").Value = Me.cboHasta.Text
                    RsRpt.Fields("rpt_school").Value = GetSchoolName(SchID)
                    RsRpt.Fields("rpt_pueblo").Value = GetSchoolCity(SchID)
                    RsRpt.Fields("rpt_serv_date").Value = xArr(y, 6)
                    RsRpt.Update()
                    Debug.Print(xArr(y, 0) & " - " & xArr(y, 1) & "-" & xArr(y, 2))
                    System.Windows.Forms.Application.DoEvents()
                Next
            End If
            For y = 0 To 12
                xArr(y, 0) = ""
                xArr(y, 1) = ""
                xArr(y, 2) = ""
                xArr(y, 3) = ""
                xArr(y, 4) = ""
                xArr(y, 5) = ""
            Next y

        End While
        RsRpt.Close()
        '--Code Change-- jh'Me.Cursor = vbNormal
        Me.Cursor = Cursors.Default

        MsgBox("Completed. Total Records: " & iTotal.ToString)

        'UPGRADE_WARNING: Couldn't resolve default property of object iTotal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'Dim rptI As New frmReport
        'If iTotal > 0 Then
        '	rptI.ReportID = 0
        '	'rptIndiv.ReportFile = Config.ReportsPath & "Individual.rpt"
        '	rptI.ReportFile = Config.ReportsPath & "FiveYearsData.rpt"
        '	rptI.Show()
        'End If






    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Dim sQuery As String
        Dim Cn As New ADODB.Connection
        Dim Rs As New ADODB.Recordset
        Dim Rs2 As New ADODB.Recordset


        Dim y As Integer
        Dim ExcelPath As String
        Dim dTotPost As Integer
        Dim i As Integer
        Dim dTotPre As Integer
        
        
        OpenConnection(Cn, Config.ConnectionString)


        'sql mat
        sQuery = "SELECT TMP_Comparativo.comp_nombre, TMP_Comparativo.comp_grado, SCHOOLS.SC_SCH_NAME, resEst_Pre.rese_m AS PRE," & " resEst_Post.rese_m AS POST, " & " TMP_Comparativo.comp_status, resest_pre.*, resest_post.* " & " FROM TMP_Comparativo LEFT OUTER JOIN ResEst AS resEst_Pre ON TMP_Comparativo.comp_reseid_pre = resEst_Pre.rese_id " & " LEFT OUTER JOIN ResEst AS ResEst_Post ON TMP_Comparativo.comp_reseid_post = ResEst_Post.rese_id " & " LEFT OUTER JOIN  SCHOOLS ON TMP_Comparativo.comp_sch_id = SCHOOLS.SC_ID " & " WHERE (SCHOOLS.sc_comp = 'PROFESSIONAL') and tmp_comparativo.comp_grado >=1 " & " ORDER BY SCHOOLS.SC_SCH_NAME, TMP_Comparativo.comp_grado, TMP_Comparativo.comp_nombre "

        'sql ren
        'SQL = "SELECT TMP_Comparativo.comp_nombre, TMP_Comparativo.comp_grado, SCHOOLS.SC_SCH_NAME, resEst_Pre.rese_r AS PRE," & _
        '" resEst_Post.rese_r AS POST, " & _
        '" TMP_Comparativo.comp_status, resest_pre.*, resest_post.* " & _
        '" FROM TMP_Comparativo LEFT OUTER JOIN ResEst AS resEst_Pre ON TMP_Comparativo.comp_reseid_pre = resEst_Pre.rese_id " & _
        '" LEFT OUTER JOIN ResEst AS ResEst_Post ON TMP_Comparativo.comp_reseid_post = ResEst_Post.rese_id " & _
        '" LEFT OUTER JOIN  SCHOOLS ON TMP_Comparativo.comp_sch_id = SCHOOLS.SC_ID " & _
        '" WHERE (SCHOOLS.sc_comp = 'PROFESSIONAL') and tmp_comparativo.comp_grado >=1 " & _
        '" ORDER BY SCHOOLS.SC_SCH_NAME, TMP_Comparativo.comp_grado, TMP_Comparativo.comp_nombre "

        'sql les
        'SQL = "SELECT TMP_Comparativo.comp_nombre, TMP_Comparativo.comp_grado, SCHOOLS.SC_SCH_NAME, resEst_Pre.rese_l AS PRE," & _
        '" resEst_Post.rese_l AS POST, " & _
        '" TMP_Comparativo.comp_status, resest_pre.*, resest_post.* " & _
        '" FROM TMP_Comparativo LEFT OUTER JOIN ResEst AS resEst_Pre ON TMP_Comparativo.comp_reseid_pre = resEst_Pre.rese_id " & _
        '" LEFT OUTER JOIN ResEst AS ResEst_Post ON TMP_Comparativo.comp_reseid_post = ResEst_Post.rese_id " & _
        '" LEFT OUTER JOIN  SCHOOLS ON TMP_Comparativo.comp_sch_id = SCHOOLS.SC_ID " & _
        '" WHERE (SCHOOLS.sc_comp = 'PROFESSIONAL') and tmp_comparativo.comp_grado >=1 " & _
        '" ORDER BY SCHOOLS.SC_SCH_NAME, TMP_Comparativo.comp_grado, TMP_Comparativo.comp_nombre "

        'sql AID
        'SQL = "SELECT TMP_Comparativo.comp_nombre, TMP_Comparativo.comp_grado, SCHOOLS.SC_SCH_NAME, " & _
        '" resEst_PRE.rese_a1 AS pre1, resEst_PRE.rese_a2 AS pre2, resEst_PRE.rese_a3 AS pre3, resEst_PRE.rese_a4 AS pre4, resEst_PRE.rese_a5 AS pre5, resEst_PRE.rese_a6 AS pre6,resEst_PRE.rese_a7 AS pre7,resEst_PRE.rese_a8 AS pre8,resEst_PRE.rese_a9 AS pre9,resEst_PRE.rese_a10 AS pre10, " & _
        '" resEst_Post.rese_a1 AS Post1, resEst_Post.rese_a2 AS Post2, resEst_Post.rese_a3 AS Post3, resEst_Post.rese_a4 AS Post4, resEst_Post.rese_a5 AS Post5, resEst_Post.rese_a6 AS Post6,resEst_Post.rese_a7 AS Post7,resEst_Post.rese_a8 AS Post8,resEst_Post.rese_a9 AS Post9,resEst_Post.rese_a10 AS Post10, " & _
        '" TMP_Comparativo.comp_status " & _
        '" FROM TMP_Comparativo LEFT OUTER JOIN ResEst AS resEst_Pre ON TMP_Comparativo.comp_reseid_pre = resEst_Pre.rese_id " & _
        '" LEFT OUTER JOIN ResEst AS ResEst_Post ON TMP_Comparativo.comp_reseid_post = ResEst_Post.rese_id " & _
        '" LEFT OUTER JOIN  SCHOOLS ON TMP_Comparativo.comp_sch_id = SCHOOLS.SC_ID " & _
        '" WHERE (SCHOOLS.sc_comp = 'PROFESSIONAL') and tmp_comparativo.comp_grado = 0 " & _
        '" ORDER BY SCHOOLS.SC_SCH_NAME, TMP_Comparativo.comp_grado, TMP_Comparativo.comp_nombre "
        Rs.Open(sQuery, Cn, 3, 3)


        FileOpen(1, My.Application.Info.DirectoryPath & "\titulo1_data.xls", OpenMode.Output)

        PrintLine(1, "Learnaid of Puerto Rico, Inc")
        PrintLine(1, "Data 2009-2010 - COSEY")
        PrintLine(1, "Institucion" & vbTab & "Grado" & vbTab & "Estudiante" & vbTab & "PRE" & vbTab & "POST")

        While Not Rs.EOF

            If Rs.Fields("comp_grado").Value = 0 Then
                'aid
                dTotPre = 0
                For iCounter As Integer = 1 To 10
                    If iCounter <> 3 Then
                        If Rs.Fields("pre" & iCounter).Value < 2 Then
                            dTotPre += 1
                        End If
                    Else
                        If Rs.Fields("pre3").Value < 6 Then
                            dTotPre += 1
                        End If
                    End If
                Next iCounter

                dTotPost = 0
                For iCounter As Integer = 1 To 10
                    If iCounter <> 3 Then
                        If Rs.Fields("post" & iCounter.ToString).Value < 2 Then
                            dTotPost += 1
                        End If
                    Else
                        If Rs.Fields("post3").Value < 6 Then
                            dTotPost += 1
                        End If
                    End If
                Next iCounter
                PrintLine(1, Rs.Fields("sc_sch_name").Value & vbTab & Rs.Fields("comp_grado").Value & vbTab & Rs.Fields("comp_nombre").Value & vbTab & dTotPre & vbTab & dTotPost)
            Else
                If Not IsDBNull(Rs.Fields("pre").Value) And Not IsDBNull(Rs.Fields("post").Value) And Rs.Fields("comp_status").Value = "OK" Then
                    PrintLine(1, Rs.Fields("sc_sch_name").Value & vbTab & Rs.Fields("comp_grado").Value & vbTab & Rs.Fields("comp_nombre").Value & vbTab & Rs.Fields("pre").Value & vbTab & Rs.Fields("post").Value)
                End If
            End If
            Rs.MoveNext()
        End While
        Rs.Close()
        FileClose(1)

        Me.Cursor = Cursors.Default

        ExcelPath = GetINIValue(My.Application.Info.DirectoryPath & "\LearnAid.ini", "System.Settings", "MSExcelPath")
        y = Shell(ExcelPath & " " & Chr(34) & My.Application.Info.DirectoryPath & "\titulo1_data.xls" & Chr(34), AppWinStyle.NormalFocus)
    End Sub

    Private Sub Command3_Click()
        Dim sQuery As String
        Dim Cn As New ADODB.Connection
        Dim Rs As New ADODB.Recordset
        Dim Rs2 As New ADODB.Recordset

        Dim y As Object
        Dim ExcelPath As String
        Dim esta_l As Integer
        Dim esta_n As Integer
        Dim esta_r As Integer
        Dim esta_m As Integer

        OpenConnection(Cn, Config.ConnectionString)

        'esta rutina se hizo para sacar la data de los estudiantes de las escuelas del municipio de san juan.
        'ya se hizo, no hace falta mas.

        'sql mat
        sQuery = "SELECT sc_sch_name, rese_nombre, resg_grado, resg_section, resg_section, rep_serv_date, rese_n, rese_l, rese_m, rese_r, rese_esta_m, rese_esta_r, rese_esta_l, rese_esta_n FROM ResEst " & " LEFT OUTER JOIN Resultados ON ResEst.resg_id = Resultados.resg_id " & " LEFT OUTER JOIN Reports ON resg_rep_id = Reports.rep_id " & " LEFT OUTER JOIN Schools ON rep_sch_id = sc_id " & " WHERE (rep_sch_id = 448) OR (rep_sch_id = 447) " & " ORDER BY rep_sch_id, resg_grado, resg_section, rese_nombre "

        Rs.Open(sQuery, Cn, 3, 3)


        FileOpen(1, My.Application.Info.DirectoryPath & "\sanjuan_data.xls", OpenMode.Output)

        PrintLine(1, "Learnaid of Puerto Rico, Inc")
        PrintLine(1, "Data 2009-2010 - Escuela del Deporte y The School of San Juan")
        PrintLine(1, "Institucion" & vbTab & "Fecha Examen" & vbTab & "Grado" & vbTab & "Seccion" & vbTab & "Estudiante" & vbTab & "% No Verbal" & vbTab & "% Espanol" & vbTab & "% Ingles" & vbTab & "% Matematicas" & vbTab & "Estanina No Verbal" & vbTab & "Estanina Espanol" & vbTab & "Estanina Ingles" & vbTab & "Estanina Matematicas")

        While Not Rs.EOF

            If IsDBNull(Rs.Fields("rese_esta_m").Value) Then
                esta_m = 0
            Else
                esta_m = System.Math.Round(Rs.Fields("rese_esta_m").Value, 0)
                If esta_m > 9 Then
                    esta_m = 9
                End If
                If esta_m < 1 Then
                    esta_m = 1
                End If
            End If
            If IsDBNull(Rs.Fields("rese_esta_r").Value) Then
                esta_r = 0
            Else
                esta_r = System.Math.Round(Rs.Fields("rese_esta_r").Value, 0)
                If esta_r > 9 Then
                    esta_r = 9
                End If
                If esta_r < 1 Then
                    esta_r = 1
                End If
            End If
            If IsDBNull(Rs.Fields("rese_esta_n").Value) Then
                esta_n = 0
            Else
                esta_n = System.Math.Round(Rs.Fields("rese_esta_n").Value, 0)
                If esta_n > 9 Then
                    esta_n = 9
                End If
                If esta_n < 1 Then
                    esta_n = 1
                End If
            End If
            If IsDBNull(Rs.Fields("rese_esta_l").Value) Then
                esta_l = 0
            Else
                esta_l = System.Math.Round(Rs.Fields("rese_esta_l").Value, 0)
                If esta_l > 9 Then
                    esta_l = 9
                End If
                If esta_l < 1 Then
                    esta_l = 1
                End If
            End If
            PrintLine(1, Rs.Fields("sc_sch_name").Value & vbTab & Rs.Fields("rep_serv_date").Value & vbTab & Rs.Fields("resg_Grado").Value & vbTab & Rs.Fields("resg_section").Value & vbTab & Rs.Fields("rese_nombre").Value & vbTab & Rs.Fields("rese_N").Value & vbTab & Rs.Fields("rese_l").Value & vbTab & Rs.Fields("rese_R").Value & vbTab & Rs.Fields("rese_m").Value & vbTab & esta_n & vbTab & esta_l & vbTab & esta_r & vbTab & esta_m)
            Rs.MoveNext()
        End While
        Rs.Close()
        FileClose(1)
        Me.Cursor = Cursors.Default

        ExcelPath = GetINIValue(My.Application.Info.DirectoryPath & "\LearnAid.ini", "System.Settings", "MSExcelPath")
        y = Shell(ExcelPath & " " & Chr(34) & My.Application.Info.DirectoryPath & "\sanjuan_data.xls" & Chr(34), AppWinStyle.NormalFocus)
    End Sub

    Private Sub frmFive_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim sQuery As String
        Dim Cn As New ADODB.Connection
        Dim Rs As New ADODB.Recordset


        Dim y As Integer
        'ConnectionString = "Provider=MSDASQL.1;Persist Security Info=False;User ID=sa;Data Source=LearnAid;Initial Catalog=LA"

        OpenConnection(Cn, Config.ConnectionString)

        sQuery = "SELECT SCHOOLS.SC_SCH_NAME, SC_ID FROM SCHOOLS order by SC_sch_name "
        Rs.Open(sQuery, Cn, 3, 3)

        While Not Rs.EOF
            'Me.cboSchools.Items.Add(Rs.Fields("sc_sch_name").Value & "-" & Rs.Fields("sc_id").Value)
            Me.cboSchools.Items.Add(Rs.Fields("sc_id").Value & " - " & Rs.Fields("sc_sch_name").Value)
            VB6.SetItemData(Me.cboSchools, Me.cboSchools.Items.Count - 1, Rs.Fields("sc_id").Value)
            Rs.MoveNext()
        End While
        Rs.Close()
        Me.cboSchools.Refresh()


        For y = 1 To 12
            Me.cboDesde.Items.Add(y)
            VB6.SetItemData(Me.cboDesde, Me.cboDesde.Items.Count - 1, y)
            Me.cboHasta.Items.Add(y)
            VB6.SetItemData(Me.cboHasta, Me.cboHasta.Items.Count - 1, y)
        Next y
        Me.cboDesde.SelectedIndex = 0
        Me.cboHasta.SelectedIndex = 0
        Me.cbosem.Items.Add("1")
        Me.cbosem.Items.Add("2")
        Me.cbosem.Items.Add("Both")
        Me.cbosem.SelectedIndex = 0
        Me.txtYear.Text = CStr(Year(Today))
    End Sub
End Class