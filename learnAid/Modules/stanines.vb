Option Strict Off
Option Explicit On
Module Stanines

#Region "LEVEL ONE ROUTINES"
    Sub SetStanines(ByVal dGrade As Double, ByVal dRepID As Integer, ByVal ConnStr As ADODB.Connection)
        Dim sQuery As String
        Dim Rs As New ADODB.Recordset

        Dim xNewSN As Double
        Dim RENRango As Boolean
        Dim NVRango As Boolean
        Dim LESRango As Boolean
        Dim MATRango As Boolean
        Dim dDev As Double
        Dim dMean As Double
        Dim dLowDev As Double
        Dim dMatMean As Double
        Dim dMatLowDev As Double
        Dim dMatDev As Double
        Dim dRenMean As Double
        Dim dRenLowDev As Double
        Dim dRenDev As Double
        Dim dLesMean As Double
        Dim dLesLowDev As Double
        Dim dLesDev As Double
        Dim dNvMean As Double
        Dim dNvLowDev As Double
        Dim dNvDev As Double

        Dim dLesScore As Double
        Dim dRenScore As Double
        'Dim dMatScore As Double
        Dim dNvScore As Double

        Dim dSTD_NV As Double
        Dim dSTD_LES As Double
        'Dim dSTD_MAT As Double
        Dim dSTD_REN As Double
        Dim dSTD_Total As Double
        Dim iMat_Count As Short

        Dim y(100) As Double
        'Dim iTotal As Integer
        Dim isMAT As Boolean
        Dim isLES As Boolean
        Dim isREN As Boolean
        Dim isNV As Boolean
        Dim ClaveMAT As Double
        Dim ClaveNV As Double
        Dim ClaveLES As Double
        Dim ClaveREN As Double
        Dim iSem As Short
        Dim PotFormula As Short

        'Get Semester and Potential Formula
        Rs = CreateObject("ADODB.Recordset")
        sQuery = "Select rep_sem, rep_sch_id From Reports where rep_id = " & dRepID.ToString.Trim
        Rs.Open(sQuery, ConnStr, 3, 3)
        iSem = Rs.Fields("rep_sem").Value
        PotFormula = Stanines.GetPotFormula(Rs.Fields("rep_sch_id").Value)
        Rs.Update()
        Rs.Close()

        Rs = CreateObject("ADODB.Recordset")
        sQuery = "Select  Resultados.resg_rep_id, Resultados.resg_Grado, Resultados.resg_REN, Resultados.resg_LES, Resultados.resg_MAT, Resultados.resg_NV," &
        "ResEst.* From Resultados " & "inner join ResEst on ResEst.resg_id = Resultados.resg_id " & "where Resultados.resg_Grado = " &
         dGrade.ToString.Trim & " and " & "Resultados.resg_rep_id = " & dRepID.ToString.Trim

        Rs.Open(sQuery, ConnStr, 1, 3, 0)

        If Rs.RecordCount <= 0 Then
            Exit Sub
        End If

        'COLOCO LAS VARIABLES DE LAS MATERIAS TOMADAS
        Rs.MoveFirst()

        'NEW PROCESS COMBINED
        Rs.MoveFirst()

        While Not Rs.EOF
            isMAT = False
            isLES = False
            isREN = False
            isNV = False

            If Val(GetValue(Rs.Fields("resg_mat"), 0)) = 0 Then
                isMAT = False
            Else
                isMAT = True
                MATRango = True
                ClaveMAT = Rs.Fields("resg_mat").Value
            End If

            If Val(GetValue(Rs.Fields("resg_les"), 0)) = 0 Then
                isLES = False
            Else
                isLES = True
                LESRango = True
                ClaveLES = Rs.Fields("resg_les").Value
            End If

            If Val(GetValue(Rs.Fields("resg_nv"), 0)) = 0 Then
                isNV = False
            Else
                isNV = True
                NVRango = True
                ClaveNV = Rs.Fields("resg_nv").Value
            End If

            If Val(GetValue(Rs.Fields("resg_REN"), 0)) = 0 Then
                isREN = False
            Else
                RENRango = True
                isREN = True
                ClaveREN = CDbl(Rs.Fields("resg_ren").Value)
            End If

            'Matematicas
            If isMAT Then
                dMean = 0
                dDev = 0
                dLowDev = 0
                GetNorms(ClaveMAT, iSem, dDev, dLowDev, dMean, dGrade, ConnStr)
                dMatDev = dDev
                dMatLowDev = dLowDev
                dMatMean = dMean

                If Not IsDBNull(Rs.Fields("rese_m").Value) Then
                    xNewSN = GetStanineNEW(ClaveMAT, iSem, dGrade, CDbl(GetValue(Rs.Fields("rese_m"), 0) * 100), ConnStr)
                Else
                    Rs.Fields("rese_m").Value = 0
                    xNewSN = GetStanineNEW(ClaveMAT, iSem, dGrade, CDbl(GetValue(Rs.Fields("rese_m"), 0) * 100), ConnStr)
                End If
                If xNewSN = 0 Then
                    Rs.Fields("rese_esta_m").Value = CDec(GetStanine(dDev, dLowDev, dMean, GetValue(Rs.Fields("rese_m"), 0) * 100))
                Else
                    'uso nueva estanina
                    Rs.Fields("rese_esta_m").Value = CDec(xNewSN)
                End If
            End If
            If isNV Then
                dMean = 0
                dDev = 0
                dLowDev = 0
                GetNorms(ClaveNV, iSem, dDev, dLowDev, dMean, dGrade, ConnStr)
                dNvDev = dDev
                dNvLowDev = dLowDev
                dNvMean = dMean

                If Not IsDBNull(Rs.Fields("rese_n").Value) Then
                    xNewSN = GetStanineNEW(ClaveNV, iSem, dGrade, GetValue(Rs.Fields("rese_n"), 0) * 100, ConnStr)
                Else
                    Rs.Fields("rese_n").Value = 0
                    xNewSN = GetStanineNEW(ClaveNV, iSem, dGrade, GetValue(Rs.Fields("rese_n"), 0) * 100, ConnStr)
                End If
                If xNewSN = 0 Then
                    Rs.Fields("rese_esta_n").Value = CDec(GetStanine(dDev, dLowDev, dMean, GetValue(Rs.Fields("rese_n"), 0) * 100))
                Else
                    'uso nueva estanina
                    Rs.Fields("rese_esta_n").Value = CDec(xNewSN)
                End If
            End If
            If isLES Then
                dMean = 0
                dDev = 0
                dLowDev = 0
                GetNorms(ClaveLES, iSem, dDev, dLowDev, dMean, dGrade, ConnStr)
                dLesDev = dDev
                dLesLowDev = dLowDev
                dLesMean = dMean
                If Not IsDBNull(Rs.Fields("rese_l").Value) Then
                    xNewSN = GetStanineNEW(ClaveLES, iSem, dGrade, GetValue(Rs.Fields("rese_l"), 0) * 100, ConnStr)
                Else
                    Rs.Fields("rese_l").Value = 0
                    xNewSN = GetStanineNEW(ClaveLES, iSem, dGrade, GetValue(Rs.Fields("rese_l"), 0) * 100, ConnStr)
                End If
                If xNewSN = 0 Then
                    Rs.Fields("rese_esta_l").Value = CDec(GetStanine(dDev, dLowDev, dMean, GetValue(Rs.Fields("rese_l"), 0) * 100))
                Else
                    'uso nueva estanina
                    Rs.Fields("rese_esta_l").Value = CDec(xNewSN)
                End If
            End If
            If isREN Then
                dMean = 0
                dDev = 0
                dLowDev = 0
                GetNorms(ClaveREN, iSem, dDev, dLowDev, dMean, dGrade, ConnStr)
                dRenDev = dDev
                dRenLowDev = dLowDev
                dRenMean = dMean
                If Not IsDBNull(Rs.Fields("rese_r").Value) Then
                    xNewSN = GetStanineNEW(ClaveREN, iSem, dGrade, GetValue(Rs.Fields("rese_r"), 0) * 100, ConnStr)
                Else
                    Rs.Fields("rese_r").Value = 0
                    xNewSN = GetStanineNEW(ClaveREN, iSem, dGrade, GetValue(Rs.Fields("rese_r"), 0) * 100, ConnStr)
                End If
                If xNewSN = 0 Then
                    Rs.Fields("rese_esta_r").Value = CDec(GetStanine(dDev, dLowDev, dMean, GetValue(Rs.Fields("rese_r"), 0) * 100))
                Else
                    'uso nueva estanina
                    Rs.Fields("rese_esta_r").Value = CDec(xNewSN)
                End If
            End If
            Rs.Update()
            Rs.MoveNext()
        End While

        '=====EMPIEZA CALCULO DE POTENCIAL=========
        'Dim esta_avg As Double

        If PotFormula = 1 Then
            'DEFAULT NV-LES

            Rs.MoveFirst()
            While Not Rs.EOF
                isMAT = False
                isLES = False
                isREN = False
                isNV = False

                If Val(GetValue(Rs.Fields("resg_mat"), 0)) = 0 Then
                    isMAT = False
                Else
                    isMAT = True
                End If

                If Val(GetValue(Rs.Fields("resg_les"), 0)) = 0 Then
                    isLES = False
                Else
                    isLES = True
                End If

                If Val(GetValue(Rs.Fields("resg_nv"), 0)) = 0 Then
                    isNV = False
                Else
                    isNV = True
                End If

                If Val(GetValue(Rs.Fields("resg_REN"), 0)) = 0 Then
                    isREN = False
                Else
                    isREN = True
                End If

                If isNV Then
                    dNvScore = GetValue(Rs.Fields("rese_n"), 0)
                Else
                    dNvScore = 0
                End If

                If isLES Then
                    dLesScore = GetValue(Rs.Fields("rese_l"), 0)
                Else
                    dLesScore = 0
                End If

                If isREN Then
                    dRenScore = GetValue(Rs.Fields("rese_r"), 0)
                Else
                    dRenScore = 0
                End If

                'si se tomaron ambas materias se calcula el potencial con ambas materias
                If isNV And isLES Then
                    dSTD_LES = GetStdScore(dLesMean, dLesDev, dLesLowDev, dLesScore * 100)
                    dSTD_NV = GetStdScore(dNvMean, dNvDev, dNvLowDev, dNvScore * 100)
                    Rs.Fields("rese_coc_pot").Value = GetPotencial(dSTD_LES + dSTD_NV, 200)
                ElseIf isNV And isREN Then  'Hago la lectura alterna
                    dSTD_NV = GetStdScore(dNvMean, dNvDev, dNvLowDev, dNvScore * 100)
                    dSTD_REN = GetStdScore(dRenMean, dRenDev, dRenLowDev, dRenScore * 100)
                    Rs.Fields("rese_coc_pot").Value = GetPotencial(dSTD_NV + dSTD_REN, 200)
                Else
                    Rs.Fields("rese_coc_pot").Value = 0
                End If
                Rs.Update()
                Rs.MoveNext()
                System.Windows.Forms.Application.DoEvents()
            End While
        Else
            'NV-REN
            Rs.MoveFirst()
            While Not Rs.EOF
                isMAT = False
                isLES = False
                isREN = False
                isNV = False
                If Val(GetValue(Rs.Fields("resg_mat"), 0)) = 0 Then
                    isMAT = False
                Else
                    isMAT = True
                End If

                If Val(GetValue(Rs.Fields("resg_les"), 0)) = 0 Then
                    isLES = False
                Else
                    isLES = True
                End If

                If Val(GetValue(Rs.Fields("resg_nv"), 0)) = 0 Then
                    isNV = False
                Else
                    isNV = True
                End If

                If Val(GetValue(Rs.Fields("resg_REN"), 0)) = 0 Then
                    isREN = False
                Else
                    isREN = True
                End If

                If isNV Then
                    dNvScore = GetValue(Rs.Fields("rese_n"), 0)
                Else
                    dNvScore = 0
                End If

                If isREN Then
                    dRenScore = GetValue(Rs.Fields("rese_r"), 0)
                Else
                    dRenScore = 0
                End If

                If isLES Then
                    dLesScore = GetValue(Rs.Fields("rese_l"), 0)
                Else
                    dLesScore = 0
                End If

                'si se tomaron ambas materias se calcula el potencial con ambas materias
                If isNV And isREN Then
                    dSTD_REN = GetStdScore(dRenMean, dRenDev, dRenLowDev, dRenScore * 100)
                    dSTD_NV = GetStdScore(dNvMean, dNvDev, dNvLowDev, dNvScore * 100)
                    Rs.Fields("rese_coc_pot").Value = GetPotencial(dSTD_REN + dSTD_NV, 200)
                ElseIf isNV And isLES Then
                    dSTD_LES = GetStdScore(dLesMean, dLesDev, dLesLowDev, dLesScore * 100)
                    dSTD_NV = GetStdScore(dNvMean, dNvDev, dNvLowDev, dNvScore * 100)
                    Rs.Fields("rese_coc_pot").Value = GetPotencial(dSTD_LES + dSTD_NV, 200)
                Else
                    Rs.Fields("rese_coc_pot").Value = 0
                End If
                Rs.Update()
                Rs.MoveNext()
                System.Windows.Forms.Application.DoEvents()
            End While
        End If

        '=====TERMINA CALCULO DE POTENCIAL=========

        '=====EMPIEZA CALCULO DE APROVECHAMIENTO=========

        Rs.MoveFirst()

        While Not Rs.EOF
            isMAT = False
            isLES = False
            isREN = False
            isNV = False

            If Val(GetValue(Rs.Fields("resg_mat"), 0)) = 0 Then
                isMAT = False
            Else
                isMAT = True
            End If

            If Val(GetValue(Rs.Fields("resg_les"), 0)) = 0 Then
                isLES = False
            Else
                isLES = True
            End If

            If Val(GetValue(Rs.Fields("resg_nv"), 0)) = 0 Then
                isNV = False
            Else
                isNV = True
            End If

            If Val(GetValue(Rs.Fields("resg_REN"), 0)) = 0 Then
                isREN = False
            Else
                isREN = True
            End If


            isNV = False 'se fuerza a falso, no debe considerarse para APROV. Deben ser las tres materias
            'y pueden ser 2 o 3
            iMat_Count = 0
            dSTD_Total = 0

            If isNV Then
                dSTD_Total = dSTD_Total + GetStdScore(dNvMean, dNvDev, dNvLowDev, Rs.Fields("rese_n").Value * 100)
                iMat_Count = iMat_Count + 1
            End If

            If isLES Then
                dSTD_Total = dSTD_Total + GetStdScore(dLesMean, dLesDev, dLesLowDev, Rs.Fields("rese_l").Value * 100)
                iMat_Count = iMat_Count + 1
            End If

            If isMAT Then
                dSTD_Total = dSTD_Total + GetStdScore(dMatMean, dMatDev, dMatLowDev, Rs.Fields("rese_m").Value * 100)
                iMat_Count = iMat_Count + 1
            End If

            If isREN Then
                dSTD_Total = dSTD_Total + GetStdScore(dRenMean, dRenDev, dRenLowDev, Rs.Fields("rese_r").Value * 100)
                iMat_Count = iMat_Count + 1
            End If

            If iMat_Count >= 2 Then
                Rs.Fields("rese_coc_apr").Value = GetPotencial(dSTD_Total, iMat_Count * 100)
            Else
                Rs.Fields("rese_coc_apr").Value = 0
            End If

            Rs.Update()
            Rs.MoveNext()
            'System.Windows.Forms.Application.DoEvents()
        End While

        '=====TERMINA CALCULO DE APROVECHAMIENTO=========

        Rs.Close()

        If MATRango = True Then
            SetRango("m", dGrade, dRepID, ConnStr)
        End If

        If NVRango = True Then
            SetRango("n", dGrade, dRepID, ConnStr)
        End If

        If LESRango = True Then
            SetRango("l", dGrade, dRepID, ConnStr)
        End If

        If RENRango = True Then
            SetRango("r", dGrade, dRepID, ConnStr)
        End If

        SetRango("pot", dGrade, dRepID, ConnStr)
        SetRango("apr", dGrade, dRepID, ConnStr)
    End Sub
#End Region



#Region "LEVEL TWO ROUTINES"
    Function CreateStanine(ByRef ss As String, ByRef ll As String, ByRef mm As String) As Object
        Dim arr(10, 2) As Double
        Dim bOk As Boolean
        Dim l As Double
        Dim m As Double
        Dim s As Double
        Dim sMat As Object = Nothing
        Dim sn As Double
        Dim v As Double

        s = CDbl(ss)
        l = CDbl(ll)
        m = CDbl(mm)

        bOk = True
        Debug.Print(sMat & " S=" & s & " LOW=" & l & " Media= " & m)
        'Debug.Print "SD=11, Mean=78"
        For v = 10 To 100 Step 1
            sn = System.Math.Round(GetStanine(s, l, m, v), 0)
            'Debug.Print v & "=" & sn
            For iCounter As Integer = 1 To 9
                If iCounter = sn Then
                    If arr(iCounter, 1) = 0 Then
                        arr(iCounter, 1) = v
                    Else
                        If arr(iCounter, 1) > v Then
                            arr(iCounter, 1) = v
                        End If
                    End If

                    If arr(iCounter, 2) = 0 Then
                        arr(iCounter, 2) = v
                    Else
                        If arr(iCounter, 2) < v Then
                            arr(iCounter, 2) = v
                        End If
                    End If
                End If
            Next iCounter
        Next v
        For iCounter As Integer = 1 To 9
            frmCreateStanine.Label1(iCounter - 1).Text = iCounter & " = " & arr(iCounter, 1) & " to " & arr(iCounter, 2)
        Next iCounter
    End Function


    'Called By: SetStanines
    ''' <param name="dClave"></param>
    ''' <param name="iSem"></param>
    ''' <param name="dDev"></param>
    ''' <param name="dLowDev"></param>
    ''' <param name="dMean"></param>
    ''' <param name="iGrade"></param>
    ''' <param name="ConnStr"></param>
    ''' <remarks>
    '''           Called By: SetStanines
    ''' </remarks>
    Sub GetNorms(ByRef dClave As Double, ByRef iSem As Short, ByRef dDev As Double, ByRef dLowDev As Double, ByRef dMean As Double, ByRef iGrade As Double, ByRef ConnStr As ADODB.Connection)
        Dim sQuery As String
        Dim rsClave As New ADODB.Recordset

        Dim cl_type As String
        Dim y As MsgBoxResult

        'Get Clave Name
        sQuery = "select cl_type from Claves where cl_id = " & dClave.ToString.Trim
        rsClave.Open(sQuery, ConnStr, 3, 3)
        If rsClave.RecordCount = 1 Then
            cl_type = rsClave.Fields("cl_type").Value
        Else
            cl_type = ""
        End If
        rsClave.Close()
        sQuery = "select * from Normas where n_clave = '" & cl_type & "' and n_grade = " & iGrade.ToString.Trim & " and n_sem = " & iSem.ToString.Trim
        'sql = "select * from Normas where n_clave = '" & cl_type & "' and n_sem = " & iSem
        rsClave.Open(sQuery, ConnStr, 3, 3)

        If rsClave.RecordCount = 1 Then
            dDev = rsClave.Fields("n_stdev").Value
            dLowDev = rsClave.Fields("n_lwdev").Value
            dMean = rsClave.Fields("n_media").Value
            rsClave.Close()
        Else
            rsClave.Close()
            sQuery = "select * from Normas where n_clave = '" & cl_type & "' and n_grade = " & iGrade.ToString.Trim
            rsClave.Open(sQuery, ConnStr, 3, 3)
            If rsClave.RecordCount = 1 Then
                dDev = rsClave.Fields("n_stdev").Value
                dLowDev = rsClave.Fields("n_lwdev").Value
                dMean = rsClave.Fields("n_media").Value
            Else
                y = MsgBox("Error in Norms. Contact Administrator", MsgBoxStyle.OkOnly, "Error")
            End If
            rsClave.Close()
        End If
    End Sub
    'Called By: SetStanines
    Function GetPotencial(ByVal dTotScore As Double, ByVal dTotMeans As Double) As Short
        GetPotencial = System.Math.Round((((dTotScore * 16) / dTotMeans) + 20) + 0.00001, 0)
    End Function

    ''' <param name="iScID"></param>
    ''' <returns></returns>
    ''' <remarks>
    '''          Called By:  Stanines.SetStanines()
    ''' </remarks>
    Function GetPotFormula(ByRef iScID As Double) As Short
        '1 = NV-LES
        '2 = NV-REN
        Dim Cn As New ADODB.Connection
        Dim Rs As New ADODB.Recordset
        Dim Ret As Short

        Ret = 1 'Default NV-LES

        If iScID > 0 Then
            LA_Declarations.OpenConnection(Cn, Config.ConnectionString)
            Rs.Open("Select sc_parentsver from Schools where sc_id = " & iScID, Cn, 3, 3)
            If Rs.RecordCount = 1 Then
                Ret = Rs.Fields("SC_ParentsVer").Value
            End If
            Rs.Close()
            Cn.Close()
        End If
        GetPotFormula = Ret
    End Function
    'Called By: SetStanines
    Function GetStanine(ByRef dSD As Double, ByRef dLow As Double, ByRef dAvg As Double, ByRef dValue As Double) As Double
        If dValue < dAvg Then
            GetStanine = System.Math.Round((((dValue - dAvg) / dLow) * 2) + 5, 3)
        Else
            GetStanine = System.Math.Round((((dValue - dAvg) / dSD) * 2) + 5, 3)
        End If

        If GetStanine < 0.5 Then
            GetStanine = 0.5
        End If
        If GetStanine > 9.5 Then
            GetStanine = 9.499
        End If
    End Function
    'Called By: SetStanines
    Function GetStanineNEW(ByRef dClave As Double, ByRef iSem As Short, ByRef iGrade As Double, ByRef dValue As Double, ByRef ConnStr As ADODB.Connection) As Double
        Dim sQuery As String
        Dim rsClave As New ADODB.Recordset

        Dim cl_type As String
        Dim Ret As Double = 0


        'creado para usar nuevas normas sin la desviacion, ni nada de eso.

        'Get Clave Name
        sQuery = "select cl_type from Claves where cl_id = " & dClave.ToString.Trim
        'rsClave.Open(SQL, ConnStr, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockPessimistic)
        rsClave.Open(sQuery, ConnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
        If Not rsClave.Fields("cl_type").Value Is Nothing Then
            cl_type = rsClave.Fields("cl_type").Value
        Else
            cl_type = String.Empty
        End If
        rsClave.Close()
        '--

        sQuery = "select * from Normas where n_clave = '" & cl_type & "' and n_grade = " & iGrade.ToString.Trim & " and n_sem = " & iSem.ToString.Trim
        'sql = "select * from Normas where n_clave = '" & cl_type & "' and n_sem = " & iSem
        rsClave.Open(sQuery, ConnStr, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
        If rsClave.RecordCount = 1 Then
            If IsDBNull(rsClave.Fields("n_newnorms")) Then
                rsClave.Fields("n_newnorms").Value = False
            End If

            '            If rsClave.Fields("n_newnorms").Value = True Then
            'uso esta estanina, de lo contrario me salgo y uso la anterior
            For iCounter As Integer = 1 To 9
                If IsDBNull(rsClave.Fields("n_" & iCounter.ToString.Trim & "_to").Value) Then
                    rsClave.Fields("n_" & iCounter.ToString.Trim & "_to").Value = DBNull.Value
                End If
                If Not IsDBNull(rsClave.Fields("n_" & iCounter.ToString.Trim & "_to").Value) Then
                    If dValue <= rsClave.Fields("n_" & iCounter.ToString.Trim & "_to").Value Then
                        Ret = iCounter
                        iCounter = 9
                    End If
                End If
            Next iCounter
            'MsgBox cl_type & " value=" & dValue & " = " & R
            rsClave.CancelUpdate()
            rsClave.Close()
            'Else
            '    Return 0
            ''UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'SQL = "select * from Normas where n_clave = '" & cl_type & "' and n_grade = " & iGrade
            'rsClave.Open(SQL, ConnStr)
            'If rsClave.RecordCount = 1 Then
            '    If IsDBNull(rsClave.Fields("n_newnorms")) Then
            '        rsClave.Fields("n_newnorms").Value = 0
            '    End If
            '    'uso esta estanina, de lo contrario me salgo y uso la anterior
            '    For i = 1 To 9
            '        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '        If IsDBNull(rsClave.Fields("n_" & i & "_to").Value) Then
            '            rsClave.Fields("n_" & i & "_to").Value = 0
            '        End If
            '        If dValue <= rsClave.Fields("n_" & i & "_to").Value Then
            '            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '            Ret = i
            '            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '            i = 9
            '        End If
            '    Next i
            '    ' MsgBox cl_type & " value=" & dValue & " = " & Ret
        End If

        'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'y = MsgBox("Error in new Norms. Contact Administrator", MsgBoxStyle.OkOnly, "Error")
        'End If
        'rsClave.Close()

        Return Ret

    End Function
    'Called By SetStanines
    Function GetStdScore(ByVal dMean As Double, ByVal dDev As Double, ByVal dLowDev As Double, ByVal dScore As Double) As Double
        Dim stdScore As Integer
        Dim tmpScore As Double
        Dim tmpMean As Double

        tmpScore = GetValue(dScore, 0) * 100
        tmpMean = dMean * 100

        If (dScore < dMean) Then
            stdScore = (tmpScore / dLowDev) - (tmpMean / dLowDev) + 500
        Else
            stdScore = (tmpScore / dDev) - (tmpMean / dDev) + 500
        End If

        If (stdScore < 200) Then
            stdScore = 200
        ElseIf (stdScore > 800) Then
            stdScore = 800
        End If

        GetStdScore = System.Math.Round(stdScore + 0.00001, 0)
    End Function
    'Called By: SetStanines
    Sub SetRango(ByRef sMat As String, ByRef dGrade As Double, ByRef dRepID As Double, ByRef ConnStr As ADODB.Connection)
        Dim sQuery As String
        Dim rsRango As ADODB.Recordset

        Dim esta_field As String = ""
        Dim MoveRec As Integer
        Dim Rango As Integer
        Dim RangoAvg As Integer
        Dim rango_field As String = ""

        Dim i As Integer
        Dim CurrVal As Object

        Select Case sMat
            Case "m"
                rango_field = "rese_rango_m"
                'esta_field = "rese_esta_m"
                esta_field = "rese_m"
            Case "l"
                rango_field = "rese_rango_l"
                'esta_field = "rese_esta_l"
                esta_field = "rese_l"
            Case "r"
                rango_field = "rese_rango_r"
                'esta_field = "rese_esta_r"
                esta_field = "rese_r"
            Case "n"
                rango_field = "rese_rango_n"
                'esta_field = "rese_esta_n"
                esta_field = "rese_n"
            Case "pot"
                rango_field = "rese_rango_pot"
                esta_field = "rese_coc_pot"
            Case "apr"
                rango_field = "rese_rango_apr"
                esta_field = "rese_coc_apr"
        End Select
        rsRango = CreateObject("ADODB.Recordset")

        sQuery = "select  Resultados.resg_rep_id, Resultados.resg_grado, ResEst.* from Resultados inner join ResEst on ResEst.resg_id = Resultados.resg_id " & "where Resultados.resg_grado = " & dGrade.ToString.Trim & " and " & "Resultados.resg_rep_id = " & dRepID.ToString.Trim & " order by " & esta_field & " DESC "

        rsRango.Open(sQuery, ConnStr, 1, 3, 0)

        MoveRec = 1
        Rango = 1
        RangoAvg = 1

        If rsRango.RecordCount > 0 Then
            CurrVal = rsRango.Fields(esta_field).Value
            rsRango.MoveNext()

            While Not rsRango.EOF
                'UPGRADE_WARNING: Couldn't resolve default property of object Rango. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                Rango = Rango + 1
                If Not IsDBNull(rsRango.Fields(esta_field).Value) Then
                    If CurrVal = rsRango.Fields(esta_field).Value Then
                        RangoAvg = RangoAvg + Rango
                        MoveRec = MoveRec + 1
                        rsRango.MoveNext()
                    Else
                        rsRango.Move((MoveRec * -1))
                        rsRango.Fields(rango_field).Value = System.Math.Round((RangoAvg / MoveRec) + 0.00001, 0)
                        For i = 1 To MoveRec - 1
                            rsRango.MoveNext()
                            rsRango.Fields(rango_field).Value = System.Math.Round((RangoAvg / MoveRec) + 0.00001, 0)
                            rsRango.Update()
                        Next i
                        rsRango.MoveNext()
                        CurrVal = rsRango.Fields(esta_field).Value
                        rsRango.MoveNext()
                        MoveRec = 1
                        RangoAvg = Rango
                    End If
                End If
            End While
            rsRango.Move((MoveRec * -1))
            rsRango.Fields(rango_field).Value = System.Math.Round((RangoAvg / MoveRec) + 0.000001, 0)
            rsRango.Update()
            For i = 1 To MoveRec - 1
                rsRango.MoveNext()
                rsRango.Fields(rango_field).Value = System.Math.Round((RangoAvg / MoveRec) + 0.000001, 0)
                rsRango.Update()
            Next i
        End If
        rsRango.Close()
    End Sub
#End Region
#Region "Unknown/Unused Routines"

    Function GetCociente(ByRef dest As Double, ByRef ConnStr As ADODB.Connection) As Short
        Dim sQuery As String
        Dim rsCo As ADODB.Recordset

        Dim Ret As Integer

        rsCo = CreateObject("ADODB.Recordset")
        dest = System.Math.Round(dest, 3)
        sQuery = "select * from Cociente where " & dest.ToString.Trim & " >= co_esta_from and " & dest.ToString.Trim & " <= co_esta_to"
        rsCo.Open(sQuery, ConnStr, 3, 3)
        If rsCo.RecordCount = 1 Then
            Ret = rsCo.Fields("co_numero").Value
        Else
            Ret = 0
        End If
        rsCo.Close()
        GetCociente = Ret
    End Function
#End Region

     

   
    


End Module