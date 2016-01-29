Option Explicit On
Imports VB = Microsoft.VisualBasic

Imports Microsoft.VisualBasic.Compatibility
Module ConsultantMod
	
    Function CheckObservacion(ByRef xtype As String, ByRef xcond As String, ByRef xresg_id As Decimal, ByRef CurrOracion As String) As Boolean
        Dim sQuery As String


        Dim Cn As ADODB.Connection = New ADODB.Connection
        Dim Rs As ADODB.Recordset = New ADODB.Recordset


        Dim Ret As Boolean

        '--
        Ret = False

        OpenConnection(Cn, Config.ConnectionString)

        Select Case xtype
            Case "A" 'Ambiente
                Select Case xcond
                    Case "A" 'Adecuado
                        'UPGRADE_WARNING: Couldn't resolve default property of object xresg_id. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        sQuery = "select ro_id from rep_observaciones where ro_selectedid = 1 and ro_resg_id = " & xresg_id.ToString
                        Rs.Open(sQuery, Cn, 3, 3)

                        If Rs.RecordCount >= 1 Then
                            Ret = True
                        End If

                        Rs.Close()
                        Cn.Close()
                        Ret = False
                        Return Ret
                    Case "NA" 'No Adecuado
                        'UPGRADE_WARNING: Couldn't resolve default property of object xresg_id. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        sQuery = "SELECT rep_observaciones.ro_resg_id, observacion.ob_desc, rep_observaciones.ro_type, rep_observaciones.ro_selectedid " &
                            "FROM observacion RIGHT JOIN REP_OBSERVACIONES ON observacion.ob_id = rep_observaciones.ro_selectedid " &
                            "WHERE ((rep_observaciones.ro_resg_id=" & xresg_id.ToString & ") AND (rep_observaciones.ro_type='a') AND (rep_observaciones.ro_selectedid <> 1))"

                        Rs.Open(sQuery, Cn, 3, 3)
                        While Not Rs.EOF
                            Ret = True
                            'UPGRADE_WARNING: Couldn't resolve default property of object CurrOracion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            CurrOracion = CurrOracion & " " & Rs.Fields("ob_desc").Value.ToString & "."
                            Rs.MoveNext()
                        End While

                        Rs.Close()
                        Cn.Close()

                End Select
            Case "I" 'Instruccion
                Select Case xcond
                    Case "1X"
                        'UPGRADE_WARNING: Couldn't resolve default property of object xresg_id. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        sQuery = "select ro_id from rep_observaciones where ro_selectedid = 13 and ro_resg_id = " & xresg_id.ToString
                        Rs.Open(sQuery, Cn, 3, 3)

                        If Rs.RecordCount >= 1 Then
                            Ret = True
                        End If

                        Rs.Close()
                        Cn.Close()
                    Case "2X"
                        'UPGRADE_WARNING: Couldn't resolve default property of object xresg_id. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        sQuery = "select ro_id from rep_observaciones where ro_selectedid = 14 and ro_resg_id = " & xresg_id.ToString
                        Rs.Open(sQuery, Cn, 3, 3)

                        If Rs.RecordCount >= 1 Then
                            Ret = True
                        End If

                        Rs.Close()
                        Cn.Close()
                    Case "IND"
                        'UPGRADE_WARNING: Couldn't resolve default property of object xresg_id. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        sQuery = "SELECT REP_OBSERVACIONES.ro_resg_id, observacion.ob_desc, REP_OBSERVACIONES.ro_type, REP_OBSERVACIONES.ro_selectedid " &
                            "FROM observacion RIGHT JOIN REP_OBSERVACIONES ON observacion.ob_id = REP_OBSERVACIONES.ro_selectedid " &
                            "WHERE ((REP_OBSERVACIONES.ro_resg_id=" & xresg_id.ToString & ") AND (REP_OBSERVACIONES.ro_type='i') AND (REP_OBSERVACIONES.ro_selectedid >= 15 and REP_OBSERVACIONES.ro_selectedid <= 19))"

                        Rs.Open(sQuery, Cn, 3, 3)

                        If Rs.RecordCount >= 1 Then
                            Ret = True
                            'UPGRADE_WARNING: Couldn't resolve default property of object CurrOracion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            CurrOracion = CurrOracion & " " & Rs.Fields("ob_desc").Value.ToString & "."
                        End If

                        Rs.Close()
                        Cn.Close()

                End Select
            Case "C" 'Conducta
                Select Case xcond
                    Case "A"
                        'UPGRADE_WARNING: Couldn't resolve default property of object xresg_id. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        sQuery = "select ro_id from rep_observaciones where ro_selectedid = 25 and ro_resg_id = " & xresg_id.ToString
                        Rs.Open(sQuery, Cn, 3, 3)

                        If Rs.RecordCount >= 1 Then
                            Ret = True
                        End If

                        Rs.Close()
                        Cn.Close()

                    Case "NA"
                        'UPGRADE_WARNING: Couldn't resolve default property of object xresg_id. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        sQuery = "SELECT rep_observaciones.ro_resg_id, observacion.ob_desc, rep_observaciones.ro_type, rep_observaciones.ro_selectedid " &
                            "FROM observacion RIGHT JOIN REP_OBSERVACIONES ON observacion.ob_id = rep_observaciones.ro_selectedid " &
                            "WHERE ((rep_observaciones.ro_resg_id=" & xresg_id.ToString & ") AND (rep_observaciones.ro_type='c') AND (rep_observaciones.ro_selectedid <>25))"

                        Rs.Open(sQuery, Cn, 3, 3)
                        While Not Rs.EOF
                            Ret = True
                            'UPGRADE_WARNING: Couldn't resolve default property of object CurrOracion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            CurrOracion = CurrOracion & " " & Rs.Fields("ob_desc").Value.ToString & "."
                            Rs.MoveNext()
                        End While

                        Rs.Close()
                        Cn.Close()

                End Select
            Case "D" 'Dificultad
                'UPGRADE_WARNING: Couldn't resolve default property of object xresg_id. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sQuery = "SELECT rep_observaciones.ro_resg_id, observacion.ob_desc, rep_observaciones.ro_type, rep_observaciones.ro_selectedid " &
                    "FROM observacion RIGHT JOIN REP_OBSERVACIONES ON observacion.ob_id = rep_observaciones.ro_selectedid " &
                    "WHERE ((rep_observaciones.ro_resg_id=" & xresg_id.ToString & ") AND (rep_observaciones.ro_type='d') AND (rep_observaciones.ro_selectedid >=34 and rep_observaciones.ro_selectedid <=45))"

                Rs.Open(sQuery, Cn, 3, 3)
                While Not Rs.EOF
                    Ret = True
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrOracion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    CurrOracion = CurrOracion & " " & Rs.Fields("ob_desc").Value.ToString & "."
                    Rs.MoveNext()
                End While

                Rs.Close()
                Cn.Close()
        End Select
        Return Ret
    End Function
	
	
	Function CreateObservaciones(ByRef dRepID As Object, ByRef COND_RES As Object, ByRef INST_RES As Object, ByRef CONDUCTA_RES As Object) As Object
		Dim CurrOracion As Object
		Dim CurrRec As Object
		Dim TotRecs As Object
		Dim trline As Object
		Dim Ret As Object
		
		Const CHECKMARK As String = "<span style='font-family:Wingdings 2'>P</span>"
		
		
		Dim sQuery As String
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		
		'--
		Cn = CreateObject("ADODB.Connection")
		Rs = CreateObject("ADODB.Recordset")
		
		OpenConnection(Cn, Config.ConnectionString)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object dRepID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sQuery = "SELECT Resultados.resg_id, Resultados.resg_Grado, Resultados.resg_Section " & "From Resultados " & "Where (((Resultados.resg_rep_id) = " & dRepID & ")) " & "ORDER BY Resultados.resg_Grado, Resultados.resg_Section "
		
		Rs.Open(sQuery, Cn, 3, 3)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Ret = ""
		'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		trline = GetObservacionTR(False)
		Rs.MoveLast()
		'UPGRADE_WARNING: Couldn't resolve default property of object TotRecs. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TotRecs = Rs.RecordCount
		Rs.MoveFirst()
		'UPGRADE_WARNING: Couldn't resolve default property of object CurrRec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CurrRec = 1
		While Not Rs.EOF
			'UPGRADE_WARNING: Couldn't resolve default property of object TotRecs. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object CurrRec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If CurrRec = TotRecs Then
				'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				trline = GetObservacionTR(True)
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				trline = GetObservacionTR(False)
			End If
			'UPGRADE_WARNING: Couldn't resolve default property of object CurrRec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CurrRec = CurrRec + 1
			'UPGRADE_WARNING: Couldn't resolve default property of object CurrOracion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CurrOracion = ""
			'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			trline = Replace(trline, "[GRADO]", IIf(Rs.Fields("resg_grado").Value = 0, "K", Rs.Fields("resg_grado").Value) & "-" & Rs.Fields("resg_section").Value)
            'Poner funcion que me dice si se marca o no los checkmarks en esta linea
            'Ambiente

            If CheckObservacion("A", "A", Decimal.Parse(Rs.Fields("resg_id").Value.ToString), CurrOracion) = True Then
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[AA]", CHECKMARK)
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[ANA]", "")
                'UPGRADE_WARNING: Couldn't resolve default property of object COND_RES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                COND_RES = ""
            ElseIf CheckObservacion("A", "NA", Decimal.Parse(Rs.Fields("resg_id").Value.ToString), CurrOracion) Then
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[ANA]", CHECKMARK)
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[AA]", "")
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[ANA]", "")
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[AA]", "")
            End If



                'Instrucciones
            If CheckObservacion("I", "1X", Decimal.Parse(Rs.Fields("resg_id").Value.ToString), CurrOracion) Then
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[1X]", CHECKMARK)
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[2X]", "")
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[IND]", "")
                '        trLine = Replace(trLine, "[1X]", Checkmark)
                '        trLine = Replace(trLine, "[2X]", "")
                '        trLine = Replace(trLine, "[IND]", "")

            ElseIf CheckObservacion("I", "2X", Decimal.Parse(Rs.Fields("resg_id").Value.ToString), CurrOracion) Then
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[2X]", CHECKMARK)
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[1X]", "")
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[IND]", "")
            ElseIf CheckObservacion("I", "IND", Decimal.Parse(Rs.Fields("resg_id").Value.ToString), CurrOracion) Then
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[IND]", CHECKMARK)
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[2X]", "")
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[1X]", "")
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[IND]", "")
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[2X]", "")
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[1X]", "")
            End If
                '----

                'Conducta
            If CheckObservacion("C", "A", Decimal.Parse(Rs.Fields("resg_id").Value.ToString), CurrOracion) Then
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[CA]", CHECKMARK)
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[CNA]", "")
            ElseIf CheckObservacion("C", "NA", Decimal.Parse(Rs.Fields("resg_id").Value.ToString), CurrOracion) Then
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[CNA]", CHECKMARK)
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[CA]", "")
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[CNA]", "")
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[CA]", "")
            End If

                'Dificultad
                'Poner las oraciones de  Dificultad
            If CheckObservacion("D", "", Decimal.Parse(Rs.Fields("resg_id").Value.ToString), CurrOracion) Then
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[DIF]", CHECKMARK)
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                trline = Replace(trline, "[DIF]", "")
            End If
                '--

                'UPGRADE_WARNING: Couldn't resolve default property of object CurrOracion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If CurrOracion <> "" Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrOracion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    trline = Replace(trline, "[ORACION]", "" & Trim(CurrOracion) & "</span>")
                Else
                    'trline = Replace(trline, "[ORACION]", "Todo bien.")
                    'antes se ponia todo bien, pero desde 8/16/2007 no desean que salga eso, sino en blanco
                    'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    trline = Replace(trline, "[ORACION]", "" & "</span>")
                End If
                'UPGRADE_WARNING: Couldn't resolve default property of object trline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                Ret = Ret & trline
                Rs.MoveNext()
        End While
		Rs.Close()
		
		'Trabajar en el parrafo del resumen general
		'Condiciones
		'UPGRADE_WARNING: Couldn't resolve default property of object dRepID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sQuery = "SELECT REP_OBSERVACIONES.ro_selectedid, Count(REP_OBSERVACIONES.ro_id) AS tot_grupos, Max(observacion.ob_desc) AS ob_desc " & "FROM (Resultados LEFT JOIN REP_OBSERVACIONES ON Resultados.resg_id = REP_OBSERVACIONES.ro_resg_id) LEFT JOIN observacion ON REP_OBSERVACIONES.ro_selectedid = observacion.ob_id " & "Where (((Resultados.resg_rep_id) = " & dRepID & ")) " & "GROUP BY REP_OBSERVACIONES.ro_selectedid " & "HAVING (((REP_OBSERVACIONES.ro_selectedid)>= 2 And (REP_OBSERVACIONES.ro_selectedid)<= 12))"
		Rs.Open(sQuery, Cn, 3, 3)
		
		If Rs.RecordCount > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object COND_RES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			COND_RES = " excepto que"
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object COND_RES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			COND_RES = ""
		End If
		
		While Not Rs.EOF
			'UPGRADE_WARNING: Couldn't resolve default property of object GetGrupos(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object COND_RES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			COND_RES = COND_RES & " en " & GetGrupos(Rs.Fields("tot_grupos")) & " " & LCase(Left(Rs.Fields("ob_desc").Value, 1)) & Mid(Rs.Fields("ob_desc").Value, 2) & ";"
			Rs.MoveNext()
		End While
		Rs.Close()
		If Len(COND_RES) > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object COND_RES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			COND_RES = Left(COND_RES, Len(COND_RES) - 1)
		End If
		'--
		
		'INSTRUCCIONES
		'UPGRADE_WARNING: Couldn't resolve default property of object dRepID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sQuery = "SELECT REP_OBSERVACIONES.ro_selectedid, Count(REP_OBSERVACIONES.ro_id) AS tot_grupos, Max(observacion.ob_desc) AS ob_desc " & "FROM (Resultados LEFT JOIN REP_OBSERVACIONES ON Resultados.resg_id = REP_OBSERVACIONES.ro_resg_id) LEFT JOIN observacion ON REP_OBSERVACIONES.ro_selectedid = observacion.ob_id " & "Where (((Resultados.resg_rep_id) = " & dRepID & ")) " & "GROUP BY REP_OBSERVACIONES.ro_selectedid " & "HAVING (((REP_OBSERVACIONES.ro_selectedid)>= 14 And (REP_OBSERVACIONES.ro_selectedid)<= 23))"
		Rs.Open(sQuery, Cn, 3, 3)
		
		If Rs.RecordCount > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object INST_RES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			INST_RES = " excepto que"
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object INST_RES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			INST_RES = ""
		End If
		
		While Not Rs.EOF
			'UPGRADE_WARNING: Couldn't resolve default property of object GetGrupos(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object INST_RES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			INST_RES = INST_RES & " en " & GetGrupos(Rs.Fields("tot_grupos")) & " " & LCase(Left(Rs.Fields("ob_desc").Value, 1)) & Mid(Rs.Fields("ob_desc").Value, 2) & ";"
			Rs.MoveNext()
		End While
		Rs.Close()
		If Len(INST_RES) > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object INST_RES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			INST_RES = Left(INST_RES, Len(INST_RES) - 1)
		End If
		'--
		
		'CONDUCTA
		'UPGRADE_WARNING: Couldn't resolve default property of object dRepID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sQuery = "SELECT REP_OBSERVACIONES.ro_selectedid, Count(REP_OBSERVACIONES.ro_id) AS tot_grupos, Max(observacion.ob_desc) AS ob_desc " & "FROM (Resultados LEFT JOIN REP_OBSERVACIONES ON Resultados.resg_id = REP_OBSERVACIONES.ro_resg_id) LEFT JOIN observacion ON REP_OBSERVACIONES.ro_selectedid = observacion.ob_id " & "Where (((Resultados.resg_rep_id) = " & dRepID & ")) " & "GROUP BY REP_OBSERVACIONES.ro_selectedid " & "HAVING (((REP_OBSERVACIONES.ro_selectedid)>= 26 And (REP_OBSERVACIONES.ro_selectedid)<= 32))"
		Rs.Open(sQuery, Cn, 3, 3)
		
		If Rs.RecordCount > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object CONDUCTA_RES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CONDUCTA_RES = " excepto que"
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object CONDUCTA_RES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CONDUCTA_RES = ""
		End If
		
		While Not Rs.EOF
			'UPGRADE_WARNING: Couldn't resolve default property of object GetGrupos(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object CONDUCTA_RES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CONDUCTA_RES = CONDUCTA_RES & " en " & GetGrupos(Rs.Fields("tot_grupos")) & " " & LCase(Left(Rs.Fields("ob_desc").Value, 1)) & Mid(Rs.Fields("ob_desc").Value, 2) & ";"
			Rs.MoveNext()
		End While
		Rs.Close()
		If Len(CONDUCTA_RES) > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object CONDUCTA_RES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CONDUCTA_RES = Left(CONDUCTA_RES, Len(CONDUCTA_RES) - 1)
		End If
		
		
		
		Cn.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object CreateObservaciones. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CreateObservaciones = Ret
		
	End Function
	
	
	Function CreateYearPromedioStaninasOLD() As Object
		Dim ExcelPath As Object
		Dim X As Object
		Dim sch_name As Object
		Dim y As Object
		Dim SobreTotStud As Object
		Dim PromTotStud As Object
		Dim BajoTotStud As Object
		Dim d9 As Object
		Dim d8 As Object
		Dim d7 As Object
		Dim d6 As Object
		Dim d5 As Object
		Dim d4 As Object
		Dim d3 As Object
		Dim d2 As Object
		Dim d1 As Object
		Dim TotStud As Object
		Dim Sobre As Object
		Dim Prom As Object
		Dim Bajo As Object
		Dim sMateria As Object
		
		Dim SQL As String
		Dim Cn As New ADODB.Connection
		Dim Rs As New ADODB.Recordset
		Dim Informe As Object
		Dim RepID As Integer
		Dim sYear As Short
		
		OpenConnection(Cn, Config.ConnectionString)
		
		sYear = 2008 'VERIFICAR ANO ANTES DE USAR
		'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sMateria = "REN" 'Cambiar a NV,LES,MAT,REN
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Bajo = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Prom = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Sobre = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TotStud = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d1 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d2 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d3 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d4 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d5 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d6 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d7 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d8 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d9 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object BajoTotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BajoTotStud = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object PromTotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PromTotStud = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object SobreTotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		SobreTotStud = 0
		
		'Buscar Reports ID de todo el año escolar
		'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		SQL = "SELECT TOP 100 PERCENT dbo.Reports.Rep_ID AS repid, rep_sch_id, rep_serv_date " & "FROM dbo.Reports INNER JOIN " & "dbo.Resultados ON dbo.Reports.Rep_ID = dbo.Resultados.resg_rep_id " & "WHERE (rep_sch_id > 0) and (((dbo.Reports.Rep_Sem = 1) AND (dbo.Reports.Rep_Year = " & sYear & ") AND (dbo.Resultados.resg_" & sMateria & " > 0))  OR " & "((dbo.Reports.Rep_Sem = 2) AND (dbo.Reports.Rep_Year = " & (sYear + 1) & ") AND (dbo.Resultados.resg_" & sMateria & " > 0)))   " & "GROUP BY dbo.Reports.Rep_ID, rep_sch_id,rep_serv_date " & "ORDER BY dbo.Reports.Rep_ID "
		
		Rs.Open(SQL, Cn, 3, 3)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileOpen(1, My.Application.Info.DirectoryPath & "\Distribucion-" & sMateria & "-" & sYear & ".xls", OpenMode.Output)
		PrintLine(1, "LearnAid of Puerto Rico, Inc." & vbTab & vbTab & "Distribución Porcentual de Estudiantes en cada Estanina por prueba Administrada. ")
		'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(1, "Año:" & sYear & "-" & (sYear + 1) & vbTab & sMateria)
		PrintLine(1, "Rep ID" & vbTab & "School" & vbTab & "Fecha" & vbTab & "Total Est." & vbTab & "1" & vbTab & "2" & vbTab & "3" & vbTab & "4" & vbTab & "5" & vbTab & "6" & vbTab & "7" & vbTab & "8" & vbTab & "9" & vbCrLf)
		'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		y = 0
		While Not Rs.EOF
			RepID = Rs.Fields("RepID").Value
			'UPGRADE_WARNING: Couldn't resolve default property of object GetSchoolName(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object sch_name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sch_name = GetSchoolName(Rs.Fields("rep_sch_id"))
			'tot = Rs!total
			'Grado = Rs!resg_Grado
			'UPGRADE_WARNING: Couldn't resolve default property of object SobreTotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object PromTotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object BajoTotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object GetStanineProm(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = GetStanineProm(RepID, Left(sMateria, 1), 0, Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9,  ,  , CShort(BajoTotStud), CShort(PromTotStud), CShort(SobreTotStud))
			'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If TotStud >= 5 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object sch_name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				PrintLine(1, RepID & vbTab & sch_name & vbTab & Rs.Fields("rep_serv_date").Value & vbTab & TotStud & vbTab & d1 & vbTab & d2 & vbTab & d3 & vbTab & d4 & vbTab & d5 & vbTab & d6 & vbTab & d7 & vbTab & d8 & vbTab & d9 & vbTab)
			End If
			Rs.MoveNext()
			System.Windows.Forms.Application.DoEvents()
			'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			y = y + 1
			Debug.Print(y)
		End While
		Rs.Close()
		
		FileClose(1)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ExcelPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ExcelPath = GetINIValue(My.Application.Info.DirectoryPath & "\LearnAid.ini", "System.Settings", "MSExcelPath")
		'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object ExcelPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		y = Shell(ExcelPath & " " & Chr(34) & My.Application.Info.DirectoryPath & "\Distribucion-" & sMateria & "-" & sYear & ".xls" & Chr(34), AppWinStyle.NormalFocus)
		
		
		
		
		
		
	End Function
	
	
	Function CreateYearPromedioStaninasNEW() As Object
		Dim WordPath As Object
		Dim ExcelPath As Object
		Dim sM As Object
		Dim a As Object
		Dim X As Object
		Dim sch_name As Object
		Dim i As Object
		Dim y As Object
		Dim SobreTotStud As Object
		Dim PromTotStud As Object
		Dim BajoTotStud As Object
		Dim d9 As Object
		Dim d8 As Object
		Dim d7 As Object
		Dim d6 As Object
		Dim d5 As Object
		Dim d4 As Object
		Dim d3 As Object
		Dim d2 As Object
		Dim d1 As Object
		Dim TotStud As Object
		Dim Sobre As Object
		Dim Prom As Object
		Dim Bajo As Object
		Dim sMateria As Object
		Dim ConsultantsPath As Object
		
		Dim SQL As String
		Dim Cn As New ADODB.Connection
		Dim Rs As New ADODB.Recordset
		Dim Informe As Object
		Dim RepID As Integer
		Dim sYear As Short
		Dim DocName As String
		Dim DocNameXLS As String
		Dim z As Short
		Dim dArr(9) As Object
		Dim dArrTotal(9) As Object
		Dim Total_Stud As Object
		
		OpenConnection(Cn, Config.ConnectionString)
		
		sYear = CShort(frmEstaninaAnual.txtYear.Text) 'VERIFICAR ANO ANTES DE USAR
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ConsultantsPath = Config.ConsultantsPath
		'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FiletoVar(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = FiletoVar(ConsultantsPath & "templateyear.htm")
		'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DocName = ConsultantsPath & "Distribucion Staninas Anual" & "_" & sYear & "-" & (sYear + 1) & ".doc"
		
		frmEstaninaAnual.lblStatus.Visible = True
		frmEstaninaAnual.lblLes.Visible = True
		frmEstaninaAnual.lblREN.Visible = True
		frmEstaninaAnual.lblNV.Visible = True
		frmEstaninaAnual.lblMat.Visible = True
		frmEstaninaAnual.txtY.Visible = True
		For z = 1 To 4
			'Cambiar a NV,LES,MAT,REN
			Select Case z
				Case 1
					'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					sMateria = "REN"
					frmEstaninaAnual.lblREN.Font = VB6.FontChangeBold(frmEstaninaAnual.lblREN.Font, True)
				Case 2
					'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					sMateria = "NV"
					frmEstaninaAnual.lblNV.Font = VB6.FontChangeBold(frmEstaninaAnual.lblNV.Font, True)
				Case 3
					'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					sMateria = "LES"
					frmEstaninaAnual.lblLes.Font = VB6.FontChangeBold(frmEstaninaAnual.lblLes.Font, True)
				Case 4
					'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					sMateria = "MAT"
					frmEstaninaAnual.lblMat.Font = VB6.FontChangeBold(frmEstaninaAnual.lblMat.Font, True)
			End Select
			'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DocNameXLS = ConsultantsPath & "Distribucion-" & sMateria & "_" & sYear & "-" & (sYear + 1) & ".xls"
			'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Bajo = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Prom = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Sobre = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			TotStud = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d1 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d2 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d3 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d4 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d5 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d6 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d7 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d8 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d9 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object BajoTotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			BajoTotStud = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object PromTotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			PromTotStud = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object SobreTotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SobreTotStud = 0
			
			'Buscar Reports ID de todo el año escolar
			'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SQL = "SELECT TOP 100 PERCENT dbo.Reports.Rep_ID AS repid, rep_sch_id, rep_serv_date " & "FROM dbo.Reports INNER JOIN " & "dbo.Resultados ON dbo.Reports.Rep_ID = dbo.Resultados.resg_rep_id " & "WHERE (rep_sch_id > 0) and (((dbo.Reports.Rep_Sem = 1) AND (dbo.Reports.Rep_Year = " & sYear & ") AND (dbo.Resultados.resg_" & sMateria & " > 0))  OR " & "((dbo.Reports.Rep_Sem = 2) AND (dbo.Reports.Rep_Year = " & (sYear + 1) & ") AND (dbo.Resultados.resg_" & sMateria & " > 0)))   " & "GROUP BY dbo.Reports.Rep_ID, rep_sch_id,rep_serv_date " & "ORDER BY dbo.Reports.Rep_ID "
			
			Rs.Open(SQL, Cn, 3, 3)
			
			FileOpen(1, DocNameXLS, OpenMode.Output)
			PrintLine(1, "LearnAid of Puerto Rico, Inc." & vbTab & vbTab & "Distribución Porcentual de Estudiantes en cada Estanina por prueba Administrada. ")
			'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			PrintLine(1, "Año:" & sYear & "-" & (sYear + 1) & vbTab & sMateria)
			PrintLine(1, "Rep ID" & vbTab & "School" & vbTab & "Fecha" & vbTab & "Total Est." & vbTab & "1" & vbTab & "2" & vbTab & "3" & vbTab & "4" & vbTab & "5" & vbTab & "6" & vbTab & "7" & vbTab & "8" & vbTab & "9" & vbCrLf)
			'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			y = 0
			
            For iCounter As Integer = 0 To 9
                'UPGRADE_WARNING: Couldn't resolve default property of object dArr(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                dArr(iCounter) = 0
                'UPGRADE_WARNING: Couldn't resolve default property of object dArrTotal(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                dArrTotal(iCounter) = 0
            Next
			
			'UPGRADE_WARNING: Couldn't resolve default property of object Total_Stud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Total_Stud = 0
			While Not Rs.EOF
				RepID = Rs.Fields("RepID").Value
				'UPGRADE_WARNING: Couldn't resolve default property of object GetSchoolName(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object sch_name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				sch_name = GetSchoolName(Rs.Fields("rep_sch_id"))
				'tot = Rs!total
				'Grado = Rs!resg_Grado
				'UPGRADE_WARNING: Couldn't resolve default property of object SobreTotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object PromTotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object BajoTotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object GetStanineProm(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				X = GetStanineProm(RepID, Left(sMateria, 1), 0, Bajo, Prom, Sobre, TotStud, dArr(1), dArr(2), dArr(3), dArr(4), dArr(5), dArr(6), dArr(7), dArr(8), dArr(9),  ,  , CShort(BajoTotStud), CShort(PromTotStud), CShort(SobreTotStud))
				'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If TotStud >= 5 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Total_Stud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Total_Stud = Total_Stud + TotStud
					
					For a = 1 To 9
						'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object dArr(a). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object dArrTotal(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object dArrTotal(a). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						dArrTotal(a) = dArrTotal(a) + dArr(a)
					Next 
					'UPGRADE_WARNING: Couldn't resolve default property of object dArr(9). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object dArr(8). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object dArr(7). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object dArr(6). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object dArr(5). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object dArr(4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object dArr(3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object dArr(2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object dArr(1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object sch_name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					PrintLine(1, RepID & vbTab & sch_name & vbTab & Rs.Fields("rep_serv_date").Value & vbTab & TotStud & vbTab & dArr(1) & vbTab & dArr(2) & vbTab & dArr(3) & vbTab & dArr(4) & vbTab & dArr(5) & vbTab & dArr(6) & vbTab & dArr(7) & vbTab & dArr(8) & vbTab & dArr(9) & vbTab)
					'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					y = y + 1
				End If
				Rs.MoveNext()
				System.Windows.Forms.Application.DoEvents()
				'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				frmEstaninaAnual.txtY.Text = y
				Debug.Print(y)
			End While
			Rs.Close()
			
			'UPGRADE_WARNING: Couldn't resolve default property of object Total_Stud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[" & sMateria & "_TOT]", Total_Stud)
			'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object sM. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sM = Left(sMateria, 1)
			'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Bajo = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Sobre = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Prom = 0
			For a = 1 To 9
				'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If a <= 3 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object dArrTotal(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Bajo = Bajo + (dArrTotal(a) / y)
					'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ElseIf a <= 6 Then 
					'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object dArrTotal(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Prom = Prom + (dArrTotal(a) / y)
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object dArrTotal(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Sobre = Sobre + (dArrTotal(a) / y)
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object dArrTotal(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object sM. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Informe = Replace(Informe, "[" & sM & a & "]", CStr(System.Math.Round(dArrTotal(a) / y, 2)))
			Next 
			
			'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[" & sMateria & "_BAJO]", CStr(System.Math.Round(Bajo, 2)))
			'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[" & sMateria & "_PROM]", CStr(System.Math.Round(Prom, 2)))
			'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[" & sMateria & "_SOBRE]", CStr(System.Math.Round(Sobre, 2)))
			'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[" & sMateria & "_SOBRE_PROM]", CStr(System.Math.Round(Sobre + Prom, 2)))
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[YEAR]", sYear & " - " & sYear + 1)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object dArrTotal(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Total_Stud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			PrintLine(1, vbTab & y & vbTab & vbTab & Total_Stud & vbTab & System.Math.Round(dArrTotal(1) / y, 2) & vbTab & System.Math.Round(dArrTotal(2) / y, 2) & vbTab & System.Math.Round(dArrTotal(3) / y, 2) & vbTab & System.Math.Round(dArrTotal(4) / y, 2) & vbTab & System.Math.Round(dArrTotal(5) / y, 2) & vbTab & System.Math.Round(dArrTotal(6) / y, 2) & vbTab & System.Math.Round(dArrTotal(7) / y, 2) & vbTab & System.Math.Round(dArrTotal(8) / y, 2) & vbTab & System.Math.Round(dArrTotal(9) / y, 2))
			FileClose(1)
			
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ExcelPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ExcelPath = GetINIValue(My.Application.Info.DirectoryPath & "\LearnAid.ini", "System.Settings", "MSExcelPath")
			'UPGRADE_WARNING: Couldn't resolve default property of object ExcelPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			y = Shell(ExcelPath & " " & Chr(34) & DocNameXLS & Chr(34), AppWinStyle.NormalFocus)
		Next 
		
		CreateFile(DocName, Informe)
		'UPGRADE_WARNING: Couldn't resolve default property of object WordPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WordPath = GetINIValue(My.Application.Info.DirectoryPath & "\LearnAid.ini", "System.Settings", "MSWordPath")
		'UPGRADE_WARNING: Couldn't resolve default property of object WordPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		y = Shell(WordPath & " " & Chr(34) & DocName & Chr(34), AppWinStyle.NormalFocus)
		
		
		
	End Function
	Function Get50Footer(ByRef xtext As Object) As Object
		Dim X As Object
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = "<table class=MsoTableGrid border=1 cellspacing=0 cellpadding=0 align=left"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & " style='border-collapse:collapse;border:none;mso-border-alt:solid windowtext .5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & " mso-yfti-tbllook:480;mso-table-lspace:9.0pt;margin-left:6.75pt;mso-table-rspace:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & " 9.0pt;margin-right:6.75pt;mso-table-anchor-vertical:paragraph;mso-table-anchor-horizontal:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & " margin;mso-table-left:center;mso-table-top:52.8pt;mso-padding-alt:0in 5.4pt 0in 5.4pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & " mso-border-insideh:.5pt solid windowtext;mso-border-insidev:.5pt solid windowtext'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & " <tr style='mso-yfti-irow:0;mso-yfti-lastrow:yes;height:26.5pt'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  <td style='border:none;border-right:solid windowtext 1.0pt;mso-border-right-alt:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt;height:26.5pt'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  <p class=MsoNormal align=center style='text-align:center;mso-element:frame;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  mso-element-frame-hspace:9.0pt;mso-element-wrap:around;mso-element-anchor-vertical:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  paragraph;mso-element-anchor-horizontal:margin;mso-element-left:center;"
		'UPGRADE_WARNING: Couldn't resolve default property of object xtext. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  mso-element-top:52.8pt;mso-height-rule:exactly'>" & xtext & "</p>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  </td>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  <td width=57 valign=top style='width:42.45pt;border:solid windowtext 1.0pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  border-left:none;mso-border-left-alt:solid windowtext .5pt;mso-border-alt:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  solid windowtext .5pt;background:#FFC4C4;padding:0in 5.4pt 0in 5.4pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  height:26.5pt'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  <p class=MsoNormal style='mso-element:frame;mso-element-frame-hspace:9.0pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  mso-element-wrap:around;mso-element-anchor-vertical:paragraph;mso-element-anchor-horizontal:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  margin;mso-element-left:center;mso-element-top:52.8pt;mso-height-rule:exactly'><o:p>&nbsp;</o:p></p>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  </td>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & " </tr>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "</table><br><br><br>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Get50Footer. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Get50Footer = X
		
	End Function
	
    Function GetAIDAvg(ByRef dResgID As Decimal, ByRef dDestrezaID As Short) As Object
        'Esta funcion devuelve el porciento de estudiantes de un AID en una seccion
        'de un grado de un reporte.

        Dim Cn As ADODB.Connection
        Dim Rs As ADODB.Recordset
        Dim sQuery As String
        Dim TotOK As Short
        Dim TotStud As Short

        Cn = CreateObject("adodb.connection")
        Rs = CreateObject("adodb.recordset")

        OpenConnection(Cn, Config.ConnectionString)

        'UPGRADE_WARNING: Couldn't resolve default property of object dResgID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object dDestrezaID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sQuery = "Select resg_id, rese_a" & dDestrezaID & " from ResEst where resg_id = " & dResgID
        Rs.Open(sQuery, Cn, 3, 3)

        TotOK = 0
        TotStud = 0

        While Not Rs.EOF
            Select Case dDestrezaID
                Case 3
                    'Esta es la destreza que tiene que tener 6 malas o mas
                    If Rs.Fields("rese_a3").Value < 6 Then TotOK = TotOK + 1
                Case Else
                    'las demas destrezas solo con 2 o mas se considera mala
                    'UPGRADE_WARNING: Couldn't resolve default property of object dDestrezaID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If Rs.Fields("rese_a" & dDestrezaID).Value < 2 Then TotOK = TotOK + 1
            End Select

            Rs.MoveNext()

            TotStud = TotStud + 1
        End While

        Rs.Close()
        Cn.Close()

        If TotStud > 0 Then
            GetAIDAvg = System.Math.Round(((TotOK / TotStud) * 100) + 0.000001, 0)
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object GetAIDAvg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            GetAIDAvg = 0
        End If

    End Function
	
	Function GetDestrezaNum(ByVal dRepID As Double, ByVal Destreza As String, ByVal Grado As Short, ByVal Section As String, ByVal Materia As String) As Short
		Dim i As Object
		'Materia = {M,L,R}
		Dim Cn As New ADODB.Connection
		Dim Rs As New ADODB.Recordset
		Dim sQuery As String
		Dim m As String
		
		Select Case Materia
			Case "M"
				m = "MAT"
			Case "L"
				m = "LES"
			Case "R"
				m = "REN"
		End Select
		
        'sQuery = "SELECT     dbo.Reports.Rep_ID, dbo.Destrezas.D_1_Nombre, dbo.Destrezas.D_2_Nombre, dbo.Destrezas.D_3_Nombre, dbo.Destrezas.D_4_Nombre," &
        '    " dbo.Destrezas.D_5_Nombre, dbo.Destrezas.D_6_Nombre, dbo.Destrezas.D_7_Nombre, dbo.Destrezas.D_8_Nombre, dbo.Destrezas.D_9_Nombre," &
        '    " dbo.Destrezas.D_10_Nombre, dbo.Destrezas.D_11_Nombre,dbo.Destrezas.D_12_Nombre,dbo.Destrezas.D_13_Nombre,dbo.Destrezas.D_14_Nombre" &
        '    " dbo.Destrezas.D_15_Nombre, dbo.Destrezas.D_16_Nombre,dbo.Destrezas.D_17_Nombre,dbo.Destrezas.D_18_Nombre,dbo.Destrezas.D_19_Nombre,dbo.Destrezas.D_20_Nombre " &
        '    "FROM dbo.Reports INNER JOIN" & " dbo.Resultados ON dbo.Reports.Rep_ID = dbo.Resultados.resg_rep_id INNER JOIN" &
        '    " dbo.Destrezas ON dbo.Resultados.resg_" & m.ToString & " = dbo.Destrezas.D_CL_ID" &
        '    " WHERE     (dbo.Resultados.resg_Grado = " & Grado.ToString & ") AND (dbo.Resultados.resg_Section = '" & Section.ToString &
        '    "') AND (dbo.Reports.Rep_ID = " & dRepID & " )"

        sQuery = "SELECT Reports.Rep_ID, Destrezas.D_1_Nombre, Destrezas.D_2_Nombre, Destrezas.D_3_Nombre, Destrezas.D_4_Nombre," &
        "Destrezas.D_5_Nombre, Destrezas.D_6_Nombre, Destrezas.D_7_Nombre, Destrezas.D_8_Nombre, Destrezas.D_9_Nombre," &
        "Destrezas.D_10_Nombre, Destrezas.D_11_Nombre, Destrezas.D_12_Nombre, Destrezas.D_13_Nombre, Destrezas.D_14_Nombre," &
        "Destrezas.D_15_Nombre, Destrezas.D_16_Nombre, Destrezas.D_17_Nombre, Destrezas.D_18_Nombre, Destrezas.D_19_Nombre," &
        "Destrezas.D_20_Nombre " &
        "FROM Reports " &
        "INNER JOIN Resultados ON Reports.Rep_ID = Resultados.resg_rep_id " &
        "INNER JOIN Destrezas ON Resultados.resg_" & m.ToString & " = Destrezas.D_CL_ID " &
        "WHERE (Resultados.resg_Grado = " & Grado.ToString & ") AND (Resultados.resg_Section = '" & Section.ToString &
        "') AND (Reports.Rep_ID =" & dRepID.ToString & " )"



		OpenConnection(Cn, Config.ConnectionString)

		Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

		If Not Rs.EOF Then
            For iCounter As Integer = 1 To 20
                    'If Rs.Fields("D_" & iCounter & "_Nombre").Value = Destreza Then
                If Rs.Fields("D_" & iCounter & "_Nombre").Value IsNot DBNull.Value Then
                    If Rs.Fields("D_" & iCounter & "_Nombre").Value = Destreza Then
                        GetDestrezaNum = iCounter
                        Exit For
                        End If
                    End If
            Next iCounter
            End If

		Rs.Close()
		Cn.Close()


    End Function
	
	
	Function GetEjecucion(ByVal dRepID As Double, ByVal iGrade As Short, ByVal sSection As String, ByVal sDestreza As String, ByVal sMateria As String) As Object
		Dim RetAvg As Object
		Dim Ret As Object
		Dim RetTot As Object
		'sMateria = {M,R,L}
		Dim Rs As New ADODB.Recordset
		Dim Cn As New ADODB.Connection
		Dim sQuery As String
		Dim iDestreza As Short
		
		OpenConnection(Cn, Config.ConnectionString)
		
		iDestreza = GetDestrezaNum(dRepID, sDestreza, iGrade, sSection, sMateria)
		If iDestreza <> 0 Then
			
			If sMateria <> "L" And sMateria <> "R" And sMateria <> "M" Then
				
				sQuery = "SELECT     AVG(dbo.ResEst.rese_" & sMateria & iDestreza & ") AS Promedio " & "FROM         dbo.ResEst INNER JOIN " & "                      dbo.Resultados ON dbo.ResEst.resg_id = dbo.Resultados.resg_id INNER JOIN " & "                      dbo.Reports ON dbo.Resultados.resg_rep_id = dbo.Reports.Rep_ID " & "GROUP BY dbo.Reports.Rep_ID, dbo.Resultados.resg_Grado, dbo.Resultados.resg_Section " & "HAVING      (dbo.Resultados.resg_Grado =" & iGrade & ") AND (dbo.Resultados.resg_Section = '" & sSection & "') AND (dbo.Reports.Rep_ID = " & dRepID & ")"
				
				
				
				Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
				
				'UPGRADE_WARNING: Couldn't resolve default property of object GetEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Not Rs.EOF Then GetEjecucion = Rs.Fields("promedio").Value
				
				Rs.Close()
			Else
				'Nuevo Formato
				sQuery = "SELECT dbo.ResEst.rese_" & sMateria & iDestreza & " AS Promedio " & "FROM         dbo.ResEst INNER JOIN " & "                      dbo.Resultados ON dbo.ResEst.resg_id = dbo.Resultados.resg_id INNER JOIN " & "                      dbo.Reports ON dbo.Resultados.resg_rep_id = dbo.Reports.Rep_ID " & "WHERE  (dbo.Resultados.resg_Grado =" & iGrade & ") AND (dbo.Resultados.resg_Section = '" & sSection & "') AND (dbo.Reports.Rep_ID = " & dRepID & ")"
				
				Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
				'UPGRADE_WARNING: Couldn't resolve default property of object RetTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				RetTot = 0
				'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Ret = 0
				While Not Rs.EOF
					'UPGRADE_WARNING: Couldn't resolve default property of object RetTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					RetTot = RetTot + 1
					If Rs.Fields("promedio").Value >= 0.51 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						Ret = Ret + 1
					End If
					Rs.MoveNext()
				End While
				Rs.Close()
				'UPGRADE_WARNING: Couldn't resolve default property of object RetTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If RetTot > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object RetTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object RetAvg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					RetAvg = System.Math.Round(Ret / RetTot, 2) * 100
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object RetAvg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					RetAvg = 0
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object RetAvg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object GetEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				GetEjecucion = Ret & " (" & RetAvg & ")"
			End If
			Cn.Close()
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object GetEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetEjecucion = ""
		End If
	End Function
	
	Function GetPotential2ndLine() As Object
		Dim X As Object
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = "<tr style='mso-yfti-irow:1;page-break-inside:avoid'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & " <td width=103 style='width:77.4pt;border-top:none;border-left:solid windowtext 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   mso-border-top-alt:double windowtext 1.5pt;mso-border-top-alt:double 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   mso-border-left-alt:solid 1.5pt;mso-border-bottom-alt:solid .5pt;mso-border-right-alt:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   solid 1.5pt;mso-border-color-alt:windowtext;padding:0in 5.4pt 0in 5.4pt'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   <p class=MsoBodyTextIndent style='margin:0in;margin-bottom:.0001pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   mso-outline-level:1'><span lang=ES-PR style='font-family:Arial;mso-ansi-language:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   ES -PR '>[GRADO]<o:p></o:p></span></p>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   </td>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   <td width=152 style='width:114.0pt;border-top:none;border-left:none;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   mso-border-top-alt:double windowtext 1.5pt;mso-border-left-alt:solid windowtext 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   mso-border-top-alt:double 1.5pt;mso-border-left-alt:solid 1.5pt;mso-border-bottom-alt:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   solid .5pt;mso-border-right-alt:solid .5pt;mso-border-color-alt:windowtext;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   padding:0in 5.4pt 0in 5.4pt'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   <p class=MsoBodyTextIndent align=center style='margin:0in;margin-bottom:.0001pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   text-align:center;mso-outline-level:1'><span lang=ES-PR style='font-family:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   Arial;mso-ansi-language:ES-PR'>[TOT]<o:p></o:p></span></p>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   </td>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   <td width=152 style='width:114.0pt;border-top:none;border-left:none;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   mso-border-top-alt:double windowtext 1.5pt;mso-border-left-alt:solid windowtext .5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   mso-border-top-alt:double 1.5pt;mso-border-left-alt:solid .5pt;mso-border-bottom-alt:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   solid .5pt;mso-border-right-alt:solid 1.5pt;mso-border-color-alt:windowtext;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   padding:0in 5.4pt 0in 5.4pt'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   <p class=MsoBodyTextIndent align=center style='margin:0in;margin-bottom:.0001pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   text-align:center;mso-outline-level:1'><span lang=ES-PR style='font-family:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   Arial;mso-ansi-language:ES-PR'>[SOBRE]<o:p></o:p></span></p>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   </td>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   <td width=152 style='width:114.0pt;border-top:none;border-left:none;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   mso-border-top-alt:double windowtext 1.5pt;mso-border-left-alt:solid windowtext .5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   mso-border-alt:solid windowtext .5pt;mso-border-top-alt:double windowtext 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   padding:0in 5.4pt 0in 5.4pt'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   <p class=MsoBodyTextIndent align=center style='margin:0in;margin-bottom:.0001pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   text-align:center;mso-outline-level:1'><span lang=ES-PR style='font-family:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   Arial;mso-ansi-language:ES-PR'>[PROM]<o:p></o:p></span></p>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   </td>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   <td width=152 style='width:114.0pt;border-top:none;border-left:none;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   mso-border-top-alt:double windowtext 1.5pt;mso-border-left-alt:solid windowtext .5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   mso-border-top-alt:double 1.5pt;mso-border-left-alt:solid .5pt;mso-border-bottom-alt:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   solid .5pt;mso-border-right-alt:solid 1.5pt;mso-border-color-alt:windowtext;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   padding:0in 5.4pt 0in 5.4pt'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   <p class=MsoBodyTextIndent align=center style='margin:0in;margin-bottom:.0001pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   text-align:center;mso-outline-level:1'><span lang=ES-PR style='font-family:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   Arial;mso-ansi-language:ES-PR'>[BAJO]<o:p></o:p></span></p>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   </td>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  </tr>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object GetPotential2ndLine. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GetPotential2ndLine = X
		
	End Function
	
	Function GetPotentialLastLine(Optional ByRef bTotalLine As Object = False, Optional ByRef bBGGray As Boolean = False) As Object
		Dim bg As Object
		
		Dim X As Object
		
		If bBGGray = True Then
			'UPGRADE_WARNING: Couldn't resolve default property of object bg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			bg = "background:#E0E0E0;"
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object bg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			bg = ""
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object bg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = " <tr style='mso-yfti-irow:3;" & bg & "mso-yfti-lastrow:yes;page-break-inside:avoid'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  <td width=103 style='width:77.4pt;border:solid windowtext 1.5pt;border-top:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  none;mso-border-top-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  <p class=MsoBodyTextIndent style='margin:0in;margin-bottom:.0001pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  mso-outline-level:1'><span lang=ES-PR style='font-family:Arial;mso-ansi-language:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  ES -PR '>[GRADO]<o:p></o:p></span></p>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  </td>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  <td width=152 style='width:114.0pt;border-top:none;border-left:none;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  border-bottom:solid windowtext 1.5pt;border-right:solid windowtext 1.0pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  mso-border-top-alt:.5pt;mso-border-left-alt:1.5pt;mso-border-bottom-alt:1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  mso-border-right-alt:.5pt;mso-border-color-alt:windowtext;mso-border-style-alt:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  solid;padding:0in 5.4pt 0in 5.4pt'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  <p class=MsoBodyTextIndent align=center style='margin:0in;margin-bottom:.0001pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  text-align:center;mso-outline-level:1'><span lang=ES-PR style='font-family:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  Arial;mso-ansi-language:ES-PR'>[TOT]<o:p></o:p></span></p>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  </td>" & vbCrLf & vbCrLf
		
		'UPGRADE_WARNING: Couldn't resolve default property of object bTotalLine. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If bTotalLine = False Then
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  <td width=152 style='width:114.0pt;border-top:none;border-left:none;"
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  border-bottom:solid windowtext 1.5pt;border-right:solid windowtext 1.5pt;"
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;"
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  padding:0in 5.4pt 0in 5.4pt'>"
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  <p class=MsoBodyTextIndent align=center style='margin:0in;margin-bottom:.0001pt;"
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  text-align:center;mso-outline-level:1'><span lang=ES-PR style='font-family:"
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  Arial;mso-ansi-language:ES-PR'>[SOBRE]<o:p></o:p></span></p>"
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  </td>" & vbCrLf & vbCrLf
			
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  <td width=152 style='width:114.0pt;border-top:none;border-left:none;"
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  border-bottom:solid windowtext 1.5pt;border-right:solid windowtext 1.0pt;"
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;"
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  mso-border-alt:solid windowtext .5pt;mso-border-bottom-alt:solid windowtext 1.5pt;"
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  padding:0in 5.4pt 0in 5.4pt'>"
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  <p class=MsoBodyTextIndent align=center style='margin:0in;margin-bottom:.0001pt;"
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  text-align:center;mso-outline-level:1'><span lang=ES-PR style='font-family:"
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  Arial;mso-ansi-language:ES-PR'>[PROM]<o:p></o:p></span></p>"
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  </td>" & vbCrLf & vbCrLf
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  <td colspan=2 width=152 style='width:114.0pt;border-top:none;border-left:none;"
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  border-bottom:solid windowtext 1.5pt;border-right:solid windowtext 1.5pt;"
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;"
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  padding:0in 5.4pt 0in 5.4pt'>"
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  <p class=MsoBodyTextIndent align=center style='margin:0in;margin-bottom:.0001pt;"
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  text-align:center;mso-outline-level:1'><span lang=ES-PR style='font-family:"
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  Arial;mso-ansi-language:ES-PR'>[SP_P]<o:p></o:p></span></p>"
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = X & "  </td>" & vbCrLf & vbCrLf
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  <td width=152 style='width:114.0pt;border-top:none;border-left:none;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  border-bottom:solid windowtext 1.5pt;border-right:solid windowtext 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  padding:0in 5.4pt 0in 5.4pt'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  <p class=MsoBodyTextIndent align=center style='margin:0in;margin-bottom:.0001pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  text-align:center;mso-outline-level:1'><span lang=ES-PR style='font-family:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  Arial;mso-ansi-language:ES-PR'>[BAJO]<o:p></o:p></span></p>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  </td>" & vbCrLf & vbCrLf
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object GetPotentialLastLine. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GetPotentialLastLine = X
		
	End Function
	
	Function GetPotentialLine() As Object
		Dim X As Object
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = "<tr style='mso-yfti-irow:2;page-break-inside:avoid'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  <td width=103 style='width:77.4pt;border-top:none;border-left:solid windowtext 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  mso-border-top-alt:solid windowtext .5pt;mso-border-top-alt:.5pt;mso-border-left-alt:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  1.5pt;mso-border-bottom-alt:.5pt;mso-border-right-alt:1.5pt;mso-border-color-alt:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  windowtext;mso-border-style-alt:solid;padding:0in 5.4pt 0in 5.4pt'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  <p class=MsoBodyTextIndent style='margin:0in;margin-bottom:.0001pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  mso-outline-level:1'><span lang=ES-PR style='font-family:Arial;mso-ansi-language:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  ES -PR '>[GRADO]<o:p></o:p></span></p>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  </td>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  <td width=152 style='width:114.0pt;border-top:none;border-left:none;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  mso-border-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  padding:0in 5.4pt 0in 5.4pt'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  <p class=MsoBodyTextIndent align=center style='margin:0in;margin-bottom:.0001pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  text-align:center;mso-outline-level:1'><span lang=ES-PR style='font-family:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  Arial;mso-ansi-language:ES-PR'>[TOT]<o:p></o:p></span></p>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  </td>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  <td width=152 style='width:114.0pt;border-top:none;border-left:none;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  mso-border-alt:solid windowtext .5pt;mso-border-right-alt:solid windowtext 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  padding:0in 5.4pt 0in 5.4pt'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  <p class=MsoBodyTextIndent align=center style='margin:0in;margin-bottom:.0001pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  text-align:center;mso-outline-level:1'><span lang=ES-PR style='font-family:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  Arial;mso-ansi-language:ES-PR'>[SOBRE]<o:p></o:p></span></p>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  </td>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  <td width=152 style='width:114.0pt;border-top:none;border-left:none;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  mso-border-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  <p class=MsoBodyTextIndent align=center style='margin:0in;margin-bottom:.0001pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  text-align:center;mso-outline-level:1'><span lang=ES-PR style='font-family:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  Arial;mso-ansi-language:ES-PR'>[PROM]<o:p></o:p></span></p>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  </td>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  <td width=152 style='width:114.0pt;border-top:none;border-left:none;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  mso-border-top-alt:solid windowtext .5pt;mso-border-left-alt:solid windowtext .5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  mso-border-alt:solid windowtext .5pt;mso-border-right-alt:solid windowtext 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  padding:0in 5.4pt 0in 5.4pt'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  <p class=MsoBodyTextIndent align=center style='margin:0in;margin-bottom:.0001pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  text-align:center;mso-outline-level:1'><span lang=ES-PR style='font-family:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  Arial;mso-ansi-language:ES-PR'>[BAJO]<o:p></o:p></span></p>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  </td>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & " </tr>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object GetPotentialLine. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GetPotentialLine = X
		
	End Function
	
	Function GetPotentialHeader() As Object
		Dim X As Object
		
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = "<table class=MsoTableGrid border=1 cellspacing=0 cellpadding=0"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & " style='border-collapse:collapse;border:none;mso-border-alt:solid windowtext .5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  mso-yfti-tbllook:480;mso-padding-alt:0in 5.4pt 0in 5.4pt;mso-border-insideh:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  .5pt solid windowtext;mso-border-insidev:.5pt solid windowtext'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "  <tr style='mso-yfti-irow:0'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   <td width=103 style='width:77.4pt;background:#E0E0E0;border:solid windowtext 1.5pt;border-bottom:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   double windowtext 1.5pt;padding:0in 5.4pt 0in 5.4pt'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   <p class=MsoBodyTextIndent align=center style='margin:0in;margin-bottom:.0001pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   text-align:center;mso-outline-level:1'><i style='mso-bidi-font-style:normal'><span"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   style='mso-bidi-font-weight:bold'>GRADO</span></i><span lang=ES-PR"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   style='font-family:Arial;mso-ansi-language:ES-PR'><o:p></o:p></span></p>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   </td>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   <td width=152 style='width:114.0pt;background:#E0E0E0;border-top:solid windowtext 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   border-left:none;border-bottom:double windowtext 1.5pt;border-right:solid windowtext 1.0pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   mso-border-left-alt:solid windowtext 1.5pt;mso-border-top-alt:solid 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   mso-border-left-alt:solid 1.5pt;mso-border-bottom-alt:double 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   mso-border-right-alt:solid .5pt;mso-border-color-alt:windowtext;padding:0in 5.4pt 0in 5.4pt'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   <p class=MsoBodyTextIndent align=center style='margin:0in;margin-bottom:.0001pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   text-align:center;mso-outline-level:1'><i style='mso-bidi-font-style:normal'><span"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   style='mso-bidi-font-weight:bold'>TOTAL DE ESTUDIANTES</span></i><span"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   lang=ES-PR style='font-family:Arial;mso-ansi-language:ES-PR'><o:p></o:p></span></p>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   </td>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   <td width=152 style='width:114.0pt;background:#E0E0E0;border-top:solid windowtext 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   border-left:none;border-bottom:double windowtext 1.5pt;border-right:solid windowtext 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   mso-border-left-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   <p class=MsoBodyTextIndent align=center style='margin:0in;margin-bottom:.0001pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   text-align:center;mso-outline-level:1'><i style='mso-bidi-font-style:normal'><span"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   lang=ES-PR style='mso-ansi-language:ES-PR;mso-bidi-font-weight:bold'>NÚMERO"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   EST.<br>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   SOBRE<br>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   PROMEDIO<br>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   </span></i><i style='mso-bidi-font-style:normal'><span lang=ES-PR"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   style='mso-ansi-language:ES-PR'>(113 o más)</span></i><span lang=ES-PR"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   style='font-family:Arial;mso-ansi-language:ES-PR'><o:p></o:p></span></p>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   </td>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   <td width=152 style='width:114.0pt;background:#E0E0E0;border-top:solid windowtext 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   border-left:none;border-bottom:double windowtext 1.5pt;border-right:solid windowtext 1.0pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   mso-border-left-alt:solid windowtext .5pt;mso-border-top-alt:solid 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   mso-border-left-alt:solid .5pt;mso-border-bottom-alt:double 1.5pt;mso-border-right-alt:"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   solid .5pt;mso-border-color-alt:windowtext;padding:0in 5.4pt 0in 5.4pt'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   <p class=MsoBodyTextIndent align=center style='margin:0in;margin-bottom:.0001pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   text-align:center;mso-outline-level:1'><i style='mso-bidi-font-style:normal'><span"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   lang=ES-PR style='mso-ansi-language:ES-PR;mso-bidi-font-weight:bold'>NÚMERO"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   EST.<br>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   PROMEDIO<br>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   </span></i><i style='mso-bidi-font-style:normal'><span lang=ES-PR"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   style='mso-ansi-language:ES-PR'>(Desde 89 <br>hasta 112)</span></i><span"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   lang=ES-PR style='font-family:Arial;mso-ansi-language:ES-PR'><o:p></o:p></span></p>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   </td>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   <td width=152 style='width:114.0pt;background:#E0E0E0;border-top:solid windowtext 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   border-left:none;border-bottom:double windowtext 1.5pt;border-right:solid windowtext 1.5pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   mso-border-left-alt:solid windowtext .5pt;padding:0in 5.4pt 0in 5.4pt'>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   <p class=MsoBodyTextIndent align=center style='margin:0in;margin-bottom:.0001pt;"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   text-align:center;mso-outline-level:1'><i style='mso-bidi-font-style:normal'><span"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   lang=ES-PR style='mso-ansi-language:ES-PR;mso-bidi-font-weight:bold'>NÚMERO"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   EST.<br>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   BAJO<br>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   PROMEDIO<br>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   </span></i><i style='mso-bidi-font-style:normal'><span lang=ES-PR"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   style='mso-ansi-language:ES-PR'>(88 o menos)</span></i><span lang=ES-PR"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   style='font-family:Arial;mso-ansi-language:ES-PR'><o:p></o:p></span></p>"
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & "   </td>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = X & " </tr>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object GetPotentialHeader. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GetPotentialHeader = X
		
	End Function
	
	Function GetStrNumber(ByRef iNumber As Short) As String
		Dim Ret As String
		
		Select Case iNumber
			Case 1
				Ret = "un"
			Case 2
				Ret = "dos"
			Case 3
				Ret = "tres"
			Case 4
				Ret = "cuatro"
			Case 5
				Ret = "cinco"
			Case 6
				Ret = "seis"
			Case 7
				Ret = "siete"
			Case 8
				Ret = "ocho"
			Case 9
				Ret = "nueve"
			Case 10
				Ret = "diez"
			Case Else
				Ret = Trim(CStr(iNumber))
		End Select
		
		GetStrNumber = Ret
		
	End Function
	
	Function GetSuperscript(ByVal number As Short, Optional ByRef isREN As Boolean = False) As String
		
		If Not isREN Then
			Select Case number
				Case 1
					GetSuperscript = "ro"
				Case 2
					GetSuperscript = "do"
				Case 3
					GetSuperscript = "er"
				Case 4, 5, 6
					GetSuperscript = "to"
				Case 8
					GetSuperscript = "vo"
				Case 9
					GetSuperscript = "no"
				Case 7, 10, 11, 12
					GetSuperscript = "mo"
			End Select
		Else
			Select Case number
				Case 1
					GetSuperscript = "st"
				Case 2
					GetSuperscript = "nd"
				Case 3
					GetSuperscript = "rd"
				Case Is >= 4
					GetSuperscript = "th"
			End Select
		End If
	End Function
	
	Function GetTotalEjecucion(ByVal dRepID As Double, ByVal iGrade As Short, ByVal sSection As String, ByVal sMateria As String) As Object
		Dim RetAvg As Object
		Dim RetTot As Object
		Dim Ret As Object
		'sMateria = {M,R,L}
		Dim Rs As New ADODB.Recordset
		Dim Cn As New ADODB.Connection
		Dim sQuery As String
		
		
		OpenConnection(Cn, Config.ConnectionString)
		
		
		
		sQuery = "SELECT     AVG(dbo.ResEst.rese_" & sMateria & ") AS Promedio " & "FROM         dbo.ResEst INNER JOIN " & "                      dbo.Resultados ON dbo.ResEst.resg_id = dbo.Resultados.resg_id INNER JOIN " & "                      dbo.Reports ON dbo.Resultados.resg_rep_id = dbo.Reports.Rep_ID " & "GROUP BY dbo.Reports.Rep_ID, dbo.Resultados.resg_Grado, dbo.Resultados.resg_Section " & "HAVING      (dbo.Resultados.resg_Grado =" & iGrade & ") AND (dbo.Resultados.resg_Section = '" & sSection & "') AND (dbo.Reports.Rep_ID = " & dRepID & ")"
		
		
		
		If sMateria <> "L" And sMateria <> "M" And sMateria <> "R" Then
			Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object GetTotalEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Not Rs.EOF Then GetTotalEjecucion = Rs.Fields("promedio").Value
			
			Rs.Close()
		Else
			'Esta materia usa el nuevo formato
			sQuery = "SELECT     dbo.ResEst.rese_" & sMateria & " AS Promedio " & "FROM         dbo.ResEst INNER JOIN " & "                      dbo.Resultados ON dbo.ResEst.resg_id = dbo.Resultados.resg_id INNER JOIN " & "                      dbo.Reports ON dbo.Resultados.resg_rep_id = dbo.Reports.Rep_ID " & "WHERE      (dbo.Resultados.resg_Grado =" & iGrade & ") AND (dbo.Resultados.resg_Section = '" & sSection & "') AND (dbo.Reports.Rep_ID = " & dRepID & ")"
			
			Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
			'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Ret = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object RetTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			RetTot = 0
			While Not Rs.EOF
				'UPGRADE_WARNING: Couldn't resolve default property of object RetTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				RetTot = RetTot + 1
				If Rs.Fields("promedio").Value >= 0.51 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Ret = Ret + 1
				End If
				Rs.MoveNext()
			End While
			Rs.Close()
			'UPGRADE_WARNING: Couldn't resolve default property of object RetTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If RetTot > 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object RetTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object RetAvg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				RetAvg = System.Math.Round(Ret / RetTot, 2) * 100
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object RetAvg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				RetAvg = 0
			End If
			'UPGRADE_WARNING: Couldn't resolve default property of object RetAvg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object GetTotalEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetTotalEjecucion = Ret & " (" & RetAvg & ")"
		End If
		
		Cn.Close()
		
		
	End Function
	
	Function TABLE_MAT(ByVal dRepID As Double) As String
		Dim iSec As Object
		Dim idez As Object
		Dim bgc As Object
		Dim s As Object
		Dim g As Object
		Dim p As Object
		Dim i As Object
		Dim iCtr As Object
		Dim ToSup As Object
		Dim FromSup As Object
		Dim ToGrade As Object
		Dim secCtr As Object
		Dim FromGrade As Object
		Const MAX_SEC As Short = 15
		Dim Rs As New ADODB.Recordset
		Dim Cn As New ADODB.Connection
		Dim sQuery As String
		Dim HD As String
		Dim cDestrezas As New Collection
		Dim cSections As New Collection
		Dim iLastSection As Short
		Dim iFrom As Short
		Dim iTo As Short
		Dim lEjecucion As Object
		Dim SubTitle As String
		
		OpenConnection(Cn, Config.ConnectionString)
		
		'///////////////////////////////////////////////////////////////////////////////
		'//Buscar todas las Secciones
		'///////////////////////////////////////////////////////////////////////////////
		sQuery = "SELECT dbo.Resultados.*, LTRIM(STR(dbo.Resultados.resg_Grado)) + '-' + LTRIM(dbo.Resultados.resg_Section) AS Seccion, dbo.Reports.Rep_ID " & "FROM   dbo.Resultados LEFT OUTER JOIN " & "dbo.Reports ON dbo.Resultados.resg_rep_id = dbo.Reports.Rep_ID " & "Where (dbo.Reports.Rep_ID =" & dRepID & ") AND (ISNULL(Resultados.resg_AID, 0) = 0) AND Resultados.resg_MAT > 0 " & "ORDER By dbo.Resultados.resg_Grado,dbo.Resultados.resg_Section ASC "
		
		Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
		
		
		On Error Resume Next
		While Not Rs.EOF
			cSections.Add(GetValue(Rs.Fields("seccion")), "S" & Rs.Fields("seccion").Value)
			Rs.MoveNext()
		End While
		On Error GoTo 0
		
		Rs.Close()
		
		HD = ""
		
		While iLastSection < cSections.Count()
			iFrom = iLastSection + 1
			
			'--proxima linea en comentario como estaba antes que el maximo es 15 secciones
			'iTo = iLastSection + MAX_SEC
			
			iTo = iLastSection
			If iTo > cSections.Count() Then iTo = cSections.Count()
			
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Header
			'///////////////////////////////////////////////////////////////////////////////
			'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FromGrade = Split(cSections.Item(iFrom), "-")(0)
			
			'--Calcular el ToGrade poniendo que el sea 8vo el maximo (1-8 y 9-12)
			'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If iLastSection = 0 And CDbl(Split(cSections.Item(1), "-")(0)) < 9 Then
				For secCtr = 1 To cSections.Count()
					iTo = cSections.Count()
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If CDbl(Split(cSections.Item(secCtr), "-")(0)) >= 9 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						iTo = secCtr - 1
						Exit For
					End If
				Next secCtr
			Else
				'Ya hizo la primera parte de 1mo a 8vo, ahora la segunda parte es hasta el final
				iTo = cSections.Count()
			End If
			'----
			
			'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ToGrade = Split(cSections.Item(iTo), "-")(0)
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FromSup = GetSuperscript(FromGrade)
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ToSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ToSup = GetSuperscript(ToGrade)
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If FromGrade = ToGrade Then
				'UPGRADE_WARNING: Couldn't resolve default property of object FromSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				SubTitle = FromGrade & "<sup>" & FromSup & "</sup> Grado"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object ToSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				SubTitle = FromGrade & "<sup>" & FromSup & "</sup> hasta " & ToGrade & "<sup>" & ToSup & "</sup> Grado"
			End If
			
			HD = HD & "<div align=center><font name='Times New Roman' size=4><b>POR CIENTO DE EJECUCIÓN EN MATEMÁTICAS POR ÁREA<br><br></b>"
			HD = HD & "<font size=5><b>" & SubTitle & "</b></font></div>"
			HD = HD & "<BR><br>"
			
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Buscar todas las destrezas
			'///////////////////////////////////////////////////////////////////////////////
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sQuery = "SELECT     dbo.Destrezas.D_1_Nombre, dbo.Destrezas.D_2_Nombre, dbo.Destrezas.D_3_Nombre, dbo.Destrezas.D_4_Nombre, dbo.Destrezas.D_5_Nombre, " & "             dbo.Destrezas.D_6_Nombre, dbo.Destrezas.D_7_Nombre, dbo.Destrezas.D_8_Nombre, dbo.Destrezas.D_9_Nombre, dbo.Destrezas.D_10_Nombre," & "             dbo.Destrezas.D_CL_ID , dbo.Reports.Rep_ID " & "FROM         dbo.Destrezas INNER JOIN " & "             dbo.Resultados ON dbo.Destrezas.D_CL_ID = dbo.Resultados.resg_MAT INNER JOIN " & "             dbo.Reports ON dbo.Resultados.resg_rep_id = dbo.Reports.Rep_ID " & "Where (dbo.Reports.Rep_ID =" & dRepID & ") AND (ISNULL(Resultados.resg_AID, 0) = 0) " & "AND (Resultados.resg_grado >=" & FromGrade & ") AND (Resultados.resg_grado <=" & ToGrade & ") ORDER BY resultados.resg_grado"
			
			Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
			
			On Error Resume Next
			'CLEAR DESTREZAS
			For iCtr = 1 To cDestrezas.Count()
				cDestrezas.Remove((1))
			Next iCtr
			
			While Not Rs.EOF
                For iCounter As Integer = 1 To 20
                    If Not IsDBNull(Rs.Fields("D_" & i & "_Nombre").Value) And Trim(GetValue(Rs.Fields("D_" & iCounter & "_Nombre"))) <> "" Then
                        cDestrezas.Add(GetValue(Rs.Fields("D_" & i & "_Nombre")), GetValue(Rs.Fields("D_" & iCounter & "_Nombre")))
                    End If
                Next iCounter
				Rs.MoveNext()
			End While
			On Error GoTo 0
			Rs.Close()
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Table Header
			'///////////////////////////////////////////////////////////////////////////////
			HD = HD & "<table width=90% border=1 cellpadding=1 cellspacing=0 bordercolor=black align=center>"
			HD = HD & "    <tr BGCOLOR=#CCCCCC>"
			HD = HD & "        <td align=center><font name='Times New Roman' size=3><B>Grado</B></td>"
			
            For iCounter = iFrom To iTo
                'UPGRADE_WARNING: Couldn't resolve default property of object cSections.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                HD = HD & "        <td align=center><font name='Times New Roman' size=3><B>" & CStr(cSections.Item(iCounter)) & "</B></td>"

            Next iCounter
			HD = HD & "    </tr>"
			
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Totales de ejecucion
			'///////////////////////////////////////////////////////////////////////////////
			HD = HD & "    <tr>"
			HD = HD & "        <td align=left BGCOLOR=#E6E6E6><font name='Times New Roman' size=3><i><B>Por ciento correcto del grupo</B></i></td>"
			
			
            For iCounter As Integer = iFrom To iTo
                'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                p = InStr(cSections.Item(iCounter), "-")
                'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                g = Left(cSections.Item(i), p - 1)
                'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                s = Right(cSections.Item(i), Len(cSections.Item(i)) - p)
                'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object GetTotalEjecucion(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                lEjecucion = GetTotalEjecucion(dRepID, g, s, "M")
                'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If lEjecucion = "" Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    lEjecucion = "&nbsp;"
                    'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    bgc = "#ffffff"
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    lEjecucion = FormatNumber(lEjecucion * 100, 0)
                    'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If CShort(lEjecucion) < 50 Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        bgc = "#ffc4c4"
                    Else
                        'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        bgc = "#ffffff"
                    End If

                End If
                'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                HD = HD & "        <td align=center bgcolor=" & bgc & "><font size=3><I><B>" & lEjecucion & "</B></I></td>"


            Next iCounter
			HD = HD & "    </tr>"
			
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Ciclo Principal
			'///////////////////////////////////////////////////////////////////////////////
			For idez = 1 To cDestrezas.Count()
				HD = HD & "    <tr>"
				'UPGRADE_WARNING: Couldn't resolve default property of object cDestrezas(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				HD = HD & "        <td width =25% align=left BGCOLOR=#E6E6E6><font name='Times New Roman' size=3>" & cDestrezas.Item(idez) & "</font></td>"
				
				For iSec = iFrom To iTo
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					p = InStr(cSections.Item(iSec), "-")
					'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					g = Left(cSections.Item(iSec), p - 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					s = Right(cSections.Item(iSec), Len(cSections.Item(iSec)) - p)
					'UPGRADE_WARNING: Couldn't resolve default property of object cDestrezas(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object GetEjecucion(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					lEjecucion = GetEjecucion(dRepID, g, s, cDestrezas.Item(idez), "M")
					'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If lEjecucion = "" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						lEjecucion = "&nbsp;"
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						lEjecucion = FormatNumber(lEjecucion * 100, 0)
					End If
					
					'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If IsNumeric(lEjecucion) And lEjecucion < 50 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						HD = HD & "        <td align=center bgcolor=#ffc4c4><font size=3>" & lEjecucion & "</td>"
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						HD = HD & "        <td align=center bgcolor=#ffffff><font size=3>" & lEjecucion & "</td>"
					End If
					
				Next iSec
				HD = HD & "    </tr>"
			Next idez
			
			
			iLastSection = iTo
			HD = HD & "</Table>"
		End While
		
		Cn.Close()
		'///////////////////////////////////////////////////////////////////////////////
		'//Footer
		'///////////////////////////////////////////////////////////////////////////////
		
		
		'HD = HD & "<table width=20% border=0 cellpadding=1 cellspacing=0 bordercolor=black align=center>"
		'HD = HD & "    <tr>"
		'HD = HD & "        <td width= 75% align=center><font size=3>Menos del 50% =&nbsp;</td>"
		'HD = HD & "        <td width= 25% bgcolor=#000000 align=center><table width=100% bgcolor=#ffc4c4 cellpadding=0 cellspacing=0><tr><td><font size=3>&nbsp;</td></tr></table></td>"
		'HD = HD & "    </tr>"
		'HD = HD & "</table>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Get50Footer(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = HD & Get50Footer("<b>Menos del 50% =</b>")
		
		TABLE_MAT = "<BR><BR><BR>" & HD
		'UPGRADE_NOTE: Object cSections may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		cSections = Nothing
		'UPGRADE_NOTE: Object cDestrezas may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		cDestrezas = Nothing
	End Function
	Function TABLE_REN(ByVal dRepID As Double) As String
		Dim iSec As Object
		Dim idez As Object
		Dim pEjecucion As Object
		Dim bgc As Object
		Dim s As Object
		Dim g As Object
		Dim p As Object
		Dim i As Object
		Dim iCtr As Object
		Dim ToSup As Object
		Dim FromSup As Object
		Dim ToGrade As Object
		Dim secCtr As Object
		Dim FromGrade As Object
		Const MAX_SEC As Short = 15
		Dim Rs As New ADODB.Recordset
		Dim Cn As New ADODB.Connection
		Dim sQuery As String
		Dim HD As String
		Dim cDestrezas As New Collection
		Dim cSections As New Collection
		Dim iLastSection As Short
		Dim iFrom As Short
		Dim iTo As Short
		Dim lEjecucion As Object
		Dim SubTitle As String
		
		OpenConnection(Cn, Config.ConnectionString)
		
		
		'///////////////////////////////////////////////////////////////////////////////
		'//Buscar todas las Secciones
		'///////////////////////////////////////////////////////////////////////////////
		sQuery = "SELECT dbo.Resultados.*, LTRIM(STR(dbo.Resultados.resg_Grado)) + '-' + LTRIM(dbo.Resultados.resg_Section) AS Seccion, dbo.Reports.Rep_ID " & "FROM   dbo.Resultados LEFT OUTER JOIN " & "dbo.Reports ON dbo.Resultados.resg_rep_id = dbo.Reports.Rep_ID " & "Where (dbo.Reports.Rep_ID =" & dRepID & ") AND (ISNULL(Resultados.resg_AID, 0) = 0) AND Resultados.resg_REN <> 48 AND Resultados.resg_REN <> 49 AND Resultados.resg_REN > 0 " & "ORDER By dbo.Resultados.resg_Grado,dbo.Resultados.resg_Section ASC "
		
		Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
		
		
		On Error Resume Next
		While Not Rs.EOF
			cSections.Add(GetValue(Rs.Fields("seccion")), "S" & Rs.Fields("seccion").Value)
			Rs.MoveNext()
		End While
		On Error GoTo 0
		
		Rs.Close()
		
		HD = ""
		
		While iLastSection < cSections.Count()
			iFrom = iLastSection + 1
			
			'--proxima linea en comentario como estaba antes que el maximo es 15 secciones
			'iTo = iLastSection + MAX_SEC
			iTo = iLastSection
			If iTo > cSections.Count() Then iTo = cSections.Count()
			
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Header
			'///////////////////////////////////////////////////////////////////////////////
			'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FromGrade = Split(cSections.Item(iFrom), "-")(0)
			
			'--Calcular el ToGrade poniendo que el sea 8vo el maximo (1-8 y 9-12)
			'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If iLastSection = 0 And CDbl(Split(cSections.Item(1), "-")(0)) < 9 Then
				For secCtr = 1 To cSections.Count()
					iTo = cSections.Count()
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If CDbl(Split(cSections.Item(secCtr), "-")(0)) >= 9 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						iTo = secCtr - 1
						Exit For
					End If
				Next secCtr
			Else
				'Ya hizo la primera parte de 1mo a 8vo, ahora la segunda parte es hasta el final
				iTo = cSections.Count()
			End If
			'----
			
			'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ToGrade = Split(cSections.Item(iTo), "-")(0)
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FromSup = GetSuperscript(FromGrade, True)
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ToSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ToSup = GetSuperscript(ToGrade, True)
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If FromGrade = ToGrade Then
				'UPGRADE_WARNING: Couldn't resolve default property of object FromSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				SubTitle = FromGrade & "<sup>" & FromSup & "</sup> Grade"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object ToSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				SubTitle = FromGrade & "<sup>" & FromSup & "</sup> to " & ToGrade & "<sup>" & ToSup & "</sup> Grade"
			End If
			
			HD = HD & "<div align=center><font name='Times New Roman' size=4><b>ENGLISH READING BASIC SKILLS</font><br><br></b>"
			HD = HD & "<font size=5><b>" & SubTitle & "</b></font></div>"
			HD = HD & "<BR><br>"
			
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Buscar todas las destrezas
			'///////////////////////////////////////////////////////////////////////////////
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sQuery = "SELECT     dbo.Destrezas.D_1_Nombre, dbo.Destrezas.D_2_Nombre, dbo.Destrezas.D_3_Nombre, dbo.Destrezas.D_4_Nombre, dbo.Destrezas.D_5_Nombre, " & "             dbo.Destrezas.D_6_Nombre, dbo.Destrezas.D_7_Nombre, dbo.Destrezas.D_8_Nombre, dbo.Destrezas.D_9_Nombre, dbo.Destrezas.D_10_Nombre," & "             dbo.Destrezas.D_CL_ID , dbo.Reports.Rep_ID " & "FROM         dbo.Destrezas INNER JOIN " & "             dbo.Resultados ON dbo.Destrezas.D_CL_ID = dbo.Resultados.resg_REN INNER JOIN " & "             dbo.Reports ON dbo.Resultados.resg_rep_id = dbo.Reports.Rep_ID " & "Where (dbo.Reports.Rep_ID =" & dRepID & ") AND (ISNULL(Resultados.resg_AID, 0) = 0) " & "AND (Resultados.resg_grado >=" & FromGrade & ") AND (Resultados.resg_grado <=" & ToGrade & ") ORDER BY resultados.resg_grado"
			
			Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
			
			On Error Resume Next
			'CLEAR DESTREZAS
			For iCtr = 1 To cDestrezas.Count()
				cDestrezas.Remove((1))
			Next iCtr
			
			While Not Rs.EOF
                For iCounter As Integer = 1 To 10
                    If Not IsDBNull(Rs.Fields("D_" & iCounter & "_Nombre").Value) And Trim(GetValue(Rs.Fields("D_" & iCounter & "_Nombre"))) <> "" Then
                        cDestrezas.Add(GetValue(Rs.Fields("D_" & iCounter & "_Nombre")), GetValue(Rs.Fields("D_" & iCounter & "_Nombre")))
                    End If
                Next iCounter
				Rs.MoveNext()
			End While
			On Error GoTo 0
			Rs.Close()
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Table Header
			'///////////////////////////////////////////////////////////////////////////////
			HD = HD & "<table width=90% border=1 cellpadding=1 cellspacing=0 bordercolor=black align=center>"
			HD = HD & "    <tr BGCOLOR=#CCCCCC>"
			HD = HD & "        <td align=center><font name='Times New Roman' size=3><B>Grade</B></td>"
			
            For iCounter As Integer = iFrom To iTo
                'UPGRADE_WARNING: Couldn't resolve default property of object cSections.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                HD = HD & "        <td align=center><font name='Times New Roman' size=3><B>" & CStr(cSections.Item(iCounter)) & "</B></td>"

            Next iCounter
			HD = HD & "    </tr>"
			
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Totales de ejecucion
			'///////////////////////////////////////////////////////////////////////////////
			HD = HD & "    <tr>"
			HD = HD & "        <td align=left BGCOLOR=#E6E6E6><font name='Times New Roman' size=3><i><B>Percent Correct in English</B></i></td>"
			
			
            For iCounter As Integer = iFrom To iTo
                'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                p = InStr(cSections.Item(iCounter), "-")
                'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                g = Left(cSections.Item(iCounter), p - 1)
                'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                s = Right(cSections.Item(iCounter), Len(cSections.Item(i)) - p)
                'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object GetTotalEjecucion(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                lEjecucion = GetTotalEjecucion(dRepID, g, s, "R")
                'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If lEjecucion = "" Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    lEjecucion = "&nbsp;"
                    'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    bgc = "#ffffff"
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    lEjecucion = FormatNumber(lEjecucion * 100, 0)
                    'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If CShort(lEjecucion) < 50 Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        bgc = "#ffc4c4"
                    Else
                        'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        bgc = "#ffffff"
                    End If
                End If
                'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                HD = HD & "        <td align=center bgcolor=" & bgc & "><font size=3><I><B>" & lEjecucion & "</B></I></td>"
            Next iCounter
			HD = HD & "    </tr>"
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Totales de ejecucion LES
			'///////////////////////////////////////////////////////////////////////////////
			HD = HD & "    <tr>"
			HD = HD & "        <td align=left BGCOLOR=#E6E6E6><font name='Times New Roman' size=3><i><B>Percent Correct in Spanish</B></i></td>"
			
			
            For iCounter As Integer = iFrom To iTo
                'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                p = InStr(cSections.Item(iCounter), "-")
                'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                g = Left(cSections.Item(iCounter), p - 1)
                'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                s = Right(cSections.Item(iCounter), Len(cSections.Item(i)) - p)
                'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object GetTotalEjecucion(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                lEjecucion = GetTotalEjecucion(dRepID, g, s, "L")
                'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If lEjecucion = "" Or IsDBNull(lEjecucion) Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    lEjecucion = "&nbsp;"
                    'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    bgc = "#ffffff"
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    pEjecucion = Split(lEjecucion, "(")(1)
                    'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    pEjecucion = Split(pEjecucion, ")")(0)
                    'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    lEjecucion = FormatNumber(pEjecucion, 0)
                    'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If CShort(lEjecucion) < 50 Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        bgc = "#ffc4c4"
                    Else
                        'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        bgc = "#ffffff"
                    End If
                End If
                'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                HD = HD & "        <td align=center bgcolor=" & bgc & "><font size=3><I><B>" & lEjecucion & "</B></I></td>"


            Next iCounter
			HD = HD & "    </tr>"
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Ciclo Principal
			'///////////////////////////////////////////////////////////////////////////////
			For idez = 1 To cDestrezas.Count()
				HD = HD & "    <tr>"
				'UPGRADE_WARNING: Couldn't resolve default property of object cDestrezas(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				HD = HD & "        <td width =25% align=left BGCOLOR=#E6E6E6><font name='Times New Roman' size=3>" & cDestrezas.Item(idez) & "</font></td>"
				
				For iSec = iFrom To iTo
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					p = InStr(cSections.Item(iSec), "-")
					'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					g = Left(cSections.Item(iSec), p - 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					s = Right(cSections.Item(iSec), Len(cSections.Item(iSec)) - p)
					'UPGRADE_WARNING: Couldn't resolve default property of object cDestrezas(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object GetEjecucion(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					lEjecucion = GetEjecucion(dRepID, g, s, cDestrezas.Item(idez), "R")
					'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If lEjecucion = "" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						lEjecucion = "&nbsp;"
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						lEjecucion = FormatNumber(lEjecucion * 100, 0)
					End If
					
					'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If IsNumeric(lEjecucion) And lEjecucion < 50 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						HD = HD & "        <td align=center bgcolor=#ffc4c4><font size=3>" & lEjecucion & "</td>"
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						HD = HD & "        <td align=center bgcolor=#ffffff><font size=3>" & lEjecucion & "</td>"
					End If
					
				Next iSec
				HD = HD & "    </tr>"
			Next idez
			
			
			iLastSection = iTo
			HD = HD & "</Table>"
		End While
		
		Cn.Close()
		'///////////////////////////////////////////////////////////////////////////////
		'//Footer
		'///////////////////////////////////////////////////////////////////////////////
		
		
		'HD = HD & "<table width=20% border=0 cellpadding=1 cellspacing=0 bordercolor=black align=center>"
		'HD = HD & "    <tr>"
		'HD = HD & "        <td width= 75% align=center><font size=3>Less than 50% =&nbsp;</td>"
		'HD = HD & "        <td width= 25% bgcolor=#000000 align=center><table width=100% bgcolor=#ffc4c4 cellpadding=0 cellspacing=0><tr><td><font size=3>&nbsp;</td></tr></table></td>"
		'HD = HD & "    </tr>"
		'HD = HD & "</table>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Get50Footer(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = HD & Get50Footer("<b>Less than 50% =</b>")
		
		TABLE_REN = "<BR><BR><BR>" & HD
		'UPGRADE_NOTE: Object cSections may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		cSections = Nothing
		'UPGRADE_NOTE: Object cDestrezas may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		cDestrezas = Nothing
	End Function
	
	
	
	Function TABLE_LES(ByVal dRepID As Double) As String
		Dim idez As Object
		Dim td2 As Object
		Dim td1 As Object
		Dim pEjecucion As Object
		Dim bgc As Object
		Dim s As Object
		Dim g As Object
		Dim p As Object
		Dim tmpSec As Object
		Dim iSec2 As Object
		Dim iSec As Object
		Dim iSec1 As Object
		Dim i As Object
		Dim iCtr As Object
		Dim ToSup As Object
		Dim FromSup As Object
		Dim ToGrade As Object
		Dim FromGrade As Object
		Dim secCtr As Object
		Const MAX_SEC As Short = 15
		Dim Rs As New ADODB.Recordset
		Dim Cn As New ADODB.Connection
		Dim sQuery As String
		Dim HD As String
		Dim cDestrezas As New Collection
		Dim cSections As New Collection
		Dim iLastSection As Short
		Dim iFrom As Short
		Dim iTo As Short
		Dim lEjecucion As Object
		Dim SubTitle As String
		
		OpenConnection(Cn, Config.ConnectionString)
		
		'///////////////////////////////////////////////////////////////////////////////
		'//Buscar todas las Secciones
		'///////////////////////////////////////////////////////////////////////////////
		sQuery = "SELECT dbo.Resultados.*, LTRIM(STR(dbo.Resultados.resg_Grado)) + '-' + LTRIM(dbo.Resultados.resg_Section) AS Seccion, dbo.Reports.Rep_ID " & "FROM   dbo.Resultados LEFT OUTER JOIN " & "dbo.Reports ON dbo.Resultados.resg_rep_id = dbo.Reports.Rep_ID " & "Where (dbo.Reports.Rep_ID =" & dRepID & ") AND (ISNULL(Resultados.resg_AID, 0) = 0) AND Resultados.resg_LES > 0 AND Resultados.resg_LES <> 68 " & "ORDER By dbo.Resultados.resg_Grado, dbo.Resultados.resg_Section ASC "
		
		Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
		
		
		On Error Resume Next
		While Not Rs.EOF
			cSections.Add(GetValue(Rs.Fields("seccion")) & "|" & Rs.Fields("resg_total_est").Value, "S" & Rs.Fields("seccion").Value)
			Rs.MoveNext()
		End While
		On Error GoTo 0
		
		Rs.Close()
		
		HD = ""
		iLastSection = 0
		While iLastSection < cSections.Count()
			iFrom = iLastSection + 1
			
			'--proxima linea en comentario como estaba antes que el maximo es 15 secciones
			'iTo = iLastSection + MAX_SEC
			iTo = iFrom
			If iTo > cSections.Count() Then iTo = cSections.Count()
			
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Header
			'///////////////////////////////////////////////////////////////////////////////
			
			
			'--Calcular el ToGrade poniendo que el sea 8vo el maximo (1-8 y 9-12)
			'--Update sep 17 2007:
			'---Calcular el ToGrade poniendo que el sea 1-3, 4-6, 7-9 y 10-12
			
			
			'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If CDbl(Split(cSections.Item(iFrom), "-")(0)) >= 1 And CDbl(Split(cSections.Item(iFrom), "-")(0)) <= 3 Then
				For secCtr = iFrom To cSections.Count()
					'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					iTo = secCtr
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If CDbl(Split(cSections.Item(iTo), "-")(0)) >= 4 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						iTo = secCtr - 1
						Exit For
					End If
				Next secCtr
				'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf CDbl(Split(cSections.Item(iFrom), "-")(0)) >= 4 And CDbl(Split(cSections.Item(iFrom), "-")(0)) <= 6 Then 
				For secCtr = iFrom To cSections.Count()
					'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					iTo = secCtr
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If CDbl(Split(cSections.Item(secCtr), "-")(0)) >= 7 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						iTo = secCtr - 1
						Exit For
					End If
				Next secCtr
				'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf CDbl(Split(cSections.Item(iFrom), "-")(0)) >= 7 And CDbl(Split(cSections.Item(iFrom), "-")(0)) <= 9 Then 
				For secCtr = iFrom To cSections.Count()
					'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					iTo = secCtr
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If CDbl(Split(cSections.Item(secCtr), "-")(0)) >= 10 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						iTo = secCtr - 1
						Exit For
					End If
				Next secCtr
			Else
				'Ya hizo todas las partes hasta 9no, ahora es hasta el final
				iTo = cSections.Count()
			End If
			'----
			
			'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FromGrade = Split(cSections.Item(iFrom), "-")(0)
			'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ToGrade = Split(cSections.Item(iTo), "-")(0)
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If FromGrade > ToGrade Then
				'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ToGrade = FromGrade
				iTo = iFrom
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FromSup = GetSuperscript(FromGrade)
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ToSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ToSup = GetSuperscript(ToGrade)
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If FromGrade = ToGrade Then
				'UPGRADE_WARNING: Couldn't resolve default property of object FromSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				SubTitle = FromGrade & "<sup>" & FromSup & "</sup> Grado"
				'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf (CShort(FromGrade) + 1) = CShort(ToGrade) Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object ToSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				SubTitle = FromGrade & "<sup>" & FromSup & "</sup>  y  " & ToGrade & "<sup>" & ToSup & "</sup> Grado"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object ToSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				SubTitle = FromGrade & "<sup>" & FromSup & "</sup>  hasta  " & ToGrade & "<sup>" & ToSup & "</sup> Grado"
			End If
			
			If HD <> "" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Get50Footer(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				HD = HD & "<Br>" & Get50Footer("<p class=MsoBodyText align=center><b>Menos del 51% =</b></p>") & "<br><br><br><br><br><br><br>"
			End If
			HD = HD & "<p class=MsoNormal align=center style='text-align:center'><span lang=ES-PR style='font-size:14.0pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'><b>FRECUENCIA Y PORCIENTO DE ESTUDIANTES QUE ALCANZÓ EL 51% O MÁS <BR> EN LAS DESTREZAS BÁSICAS DE LECTURA EN ESPAÑOL</span><br><br>"
			HD = HD & "<span lang=ES-PR style='font-size:18pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'>" & SubTitle & "</b></SPAN></P>"
			HD = HD & "<BR><br>"
			
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Buscar todas las destrezas
			'///////////////////////////////////////////////////////////////////////////////
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sQuery = "SELECT     dbo.Destrezas.D_1_Nombre, dbo.Destrezas.D_2_Nombre, dbo.Destrezas.D_3_Nombre, dbo.Destrezas.D_4_Nombre, dbo.Destrezas.D_5_Nombre, " & "             dbo.Destrezas.D_6_Nombre, dbo.Destrezas.D_7_Nombre, dbo.Destrezas.D_8_Nombre, dbo.Destrezas.D_9_Nombre, dbo.Destrezas.D_10_Nombre," & "             dbo.Destrezas.D_CL_ID , dbo.Reports.Rep_ID, resg_total_est " & "FROM         dbo.Destrezas INNER JOIN " & "             dbo.Resultados ON dbo.Destrezas.D_CL_ID = dbo.Resultados.resg_LES INNER JOIN " & "             dbo.Reports ON dbo.Resultados.resg_rep_id = dbo.Reports.Rep_ID " & "Where (dbo.Reports.Rep_ID =" & dRepID & ") AND (ISNULL(Resultados.resg_AID, 0) = 0) " & "AND (Resultados.resg_grado >=" & FromGrade & ") AND (Resultados.resg_grado <=" & ToGrade & ") order by resultados.resg_grado"
			
			Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
			
			On Error Resume Next
			'CLEAR DESTREZAS
			For iCtr = 1 To cDestrezas.Count()
				cDestrezas.Remove((1))
			Next iCtr
			
			While Not Rs.EOF
                For iCounter As Integer = 1 To 10
                    If Not IsDBNull(Rs.Fields("D_" & iCounter & "_Nombre").Value) And Trim(GetValue(Rs.Fields("D_" & iCounter & "_Nombre"))) <> "" Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        cDestrezas.Add(GetValue(Rs.Fields("D_" & iCounter & "_Nombre")), GetValue(Rs.Fields("D_" & iCounter & "_Nombre")))
                    End If
                Next iCounter
				Rs.MoveNext()
			End While
			On Error GoTo 0
			Rs.Close()
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Table Header
			'///////////////////////////////////////////////////////////////////////////////
			HD = HD & "<table width=90% border=1 cellpadding=1 cellspacing=0 bordercolor=black align=center>"
			HD = HD & "    <tr BGCOLOR=#CCCCCC>"
			HD = HD & "        <td align=center><i><p class=MsoBodyText align=center><B>GRADO - GRUPO</B></i></p></td>"
			
            For iCounter As Integer = iFrom To iTo
                'UPGRADE_WARNING: Couldn't resolve default property of object cSections.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object iSec1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                iSec1 = Split(cSections.Item(iCounter), "|")(0)
                'UPGRADE_WARNING: Couldn't resolve default property of object iSec1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object iSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                iSec = iSec1
                'UPGRADE_WARNING: Couldn't resolve default property of object iSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                HD = HD & "        <td align=center colspan=2><p class=MsoBodyText align=center><B><i>" & CStr(iSec) & "</i></B></p></td>"

            Next iCounter
			HD = HD & "    </tr>"
			
			'--------HEADER ADICIONAL TOTAL # ESTUDIANTES-------------
			HD = HD & "    <tr BGCOLOR=#CCCCCC>"
			HD = HD & "        <td align=center><p class=MsoBodyText align=center><B><i>TOTAL # ESTUDIANTES</i></B></p></td>"
			
            For iCounter As Integer = iFrom To iTo
                'UPGRADE_WARNING: Couldn't resolve default property of object cSections.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object iSec2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                iSec2 = Split(cSections.Item(iCounter), "|")(1)
                'UPGRADE_WARNING: Couldn't resolve default property of object iSec2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object iSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                iSec = "N=" & iSec2
                'UPGRADE_WARNING: Couldn't resolve default property of object iSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                HD = HD & "        <td align=center colspan=2><p class=MsoBodyText align=center><B><i>" & CStr(iSec) & "</B></i></p></td>"

            Next iCounter
			HD = HD & "    </tr>"
			'--------------------------------------
			
			
			'--------HEADER ADICIONAL FRECUENCIA / PORCIENTO-------------
			HD = HD & "    <tr BGCOLOR=#CCCCCC>"
			HD = HD & "        <td align=center><p class=MsoBodyText align=center><B><i>FRECUENCIA / PORCIENTO</i></B></p></td>"
			
            For iCounter As Integer = iFrom To iTo
                HD = HD & "        <td width=60 align=center><p class=MsoBodyText align=center><i><B>n</B></i></p></td>"
                HD = HD & "        <td width=60 align=center><p class=MsoBodyText align=center><i><B>%</B></i></p></td>"
            Next iCounter
			HD = HD & "    </tr>"
			'--------------------------------------
			
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Totales de ejecucion
			'///////////////////////////////////////////////////////////////////////////////
			HD = HD & "    <tr>"
			HD = HD & "        <td align=left BGCOLOR=#E6E6E6><p class=MsoBodyText align=left><i><B>Dominio total de la prueba</B></p></i></td>"
			
			
            For iCounter As Integer = iFrom To iTo
                'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                tmpSec = Split(cSections.Item(iCounter), "|")(0)
                'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                p = InStr(tmpSec, "-")
                'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                g = Left(tmpSec, p - 1)
                'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                s = Right(tmpSec, Len(tmpSec) - p)
                'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object GetTotalEjecucion(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                lEjecucion = GetTotalEjecucion(dRepID, g, s, "L")
                'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If lEjecucion = "" Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    lEjecucion = "&nbsp;"
                    'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    bgc = "#ffffff"
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    pEjecucion = Split(lEjecucion, "(")(1)
                    'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    pEjecucion = Split(pEjecucion, ")")(0)
                    'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    pEjecucion = FormatNumber(pEjecucion, 0)
                    'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If CShort(pEjecucion) < 51 Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        bgc = "#ffc4c4"
                    Else
                        'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        bgc = "#ffffff"
                    End If
                End If
                'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If InStr(1, lEjecucion, "(") > 0 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object td1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    td1 = Split(lEjecucion, "(")(0)
                    'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object td2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    td2 = Replace(Split(lEjecucion, "(")(1), ")", "")
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object td1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    td1 = lEjecucion
                    'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object td2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    td2 = lEjecucion
                End If
                'UPGRADE_WARNING: Couldn't resolve default property of object td1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                HD = HD & "        <td align=center bgcolor=" & bgc & "><p class=MsoBodyText align=center><I><B>" & td1 & "</B></I></p></td>"
                'UPGRADE_WARNING: Couldn't resolve default property of object td2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                HD = HD & "        <td align=center bgcolor=" & bgc & "><p class=MsoBodyText align=center><I><B>" & td2 & "</B></I></p></td>"


            Next iCounter
			HD = HD & "    </tr>"
			
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Ciclo Principal
			'///////////////////////////////////////////////////////////////////////////////
			For idez = 1 To cDestrezas.Count()
				HD = HD & "    <tr>"
				'UPGRADE_WARNING: Couldn't resolve default property of object cDestrezas(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				HD = HD & "        <td width =25% align=left BGCOLOR=#E6E6E6><p class=MsoBodyText align=left>" & cDestrezas.Item(idez) & "</p></td>"
				
				For iSec = iFrom To iTo
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					tmpSec = Split(cSections.Item(iSec), "|")(0)
					'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					p = InStr(tmpSec, "-")
					'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					g = Left(tmpSec, p - 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					s = Right(tmpSec, Len(tmpSec) - p)
					'UPGRADE_WARNING: Couldn't resolve default property of object cDestrezas(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object GetEjecucion(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					lEjecucion = GetEjecucion(dRepID, g, s, cDestrezas.Item(idez), "L")
					'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					bgc = "#ffffff"
					'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If lEjecucion = "" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						lEjecucion = "&nbsp;"
						'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						bgc = "#ffffff"
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						pEjecucion = Split(lEjecucion, "(")(1)
						'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						pEjecucion = Split(pEjecucion, ")")(0)
						'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						pEjecucion = FormatNumber(pEjecucion, 0)
						'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If CShort(pEjecucion) < 51 Then
							'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							bgc = "#ffc4c4"
						Else
							'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							bgc = "#ffffff"
						End If
					End If
					'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If InStr(1, lEjecucion, "(") > 0 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object td1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						td1 = Split(lEjecucion, "(")(0)
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object td2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						td2 = Replace(Split(lEjecucion, "(")(1), ")", "")
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object td1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						td1 = lEjecucion
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object td2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						td2 = lEjecucion
					End If
					'UPGRADE_WARNING: Couldn't resolve default property of object td1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					HD = HD & "        <td align=center bgcolor=" & bgc & "><p class=MsoBodyText align=center>" & td1 & "</p></td>"
					'UPGRADE_WARNING: Couldn't resolve default property of object td2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					HD = HD & "        <td align=center bgcolor=" & bgc & "><p class=MsoBodyText align=center>" & td2 & "</p></td>"
				Next iSec
				HD = HD & "    </tr>"
			Next idez
			
			
			iLastSection = iTo
			HD = HD & "</Table>"
		End While
		
		Cn.Close()
		'///////////////////////////////////////////////////////////////////////////////
		'//Footer
		'///////////////////////////////////////////////////////////////////////////////
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Get50Footer(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = HD & Get50Footer("<b><p class=MsoBodyText align=center>Menos del 51% =</b></p>")
		
		TABLE_LES = "<BR><BR><BR>" & HD
		'UPGRADE_NOTE: Object cSections may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		cSections = Nothing
		'UPGRADE_NOTE: Object cDestrezas may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		cDestrezas = Nothing
	End Function
	
	Function TABLE_MAT2(ByVal dRepID As Double) As String
		Dim idez As Object
		Dim td2 As Object
		Dim td1 As Object
		Dim pEjecucion As Object
		Dim bgc As Object
		Dim s As Object
		Dim g As Object
		Dim p As Object
		Dim tmpSec As Object
		Dim iSec2 As Object
		Dim iSec As Object
		Dim iSec1 As Object
		Dim i As Object
		Dim iCtr As Object
		Dim ToSup As Object
		Dim FromSup As Object
		Dim ToGrade As Object
		Dim secCtr As Object
		Dim FromGrade As Object
		Const MAX_SEC As Short = 15
		Dim Rs As New ADODB.Recordset
		Dim Cn As New ADODB.Connection
		Dim sQuery As String
		Dim HD As String
		Dim cDestrezas As New Collection
		Dim cSections As New Collection
		Dim iLastSection As Short
		Dim iFrom As Short
		Dim iTo As Short
		Dim lEjecucion As Object
		Dim SubTitle As String
		
		OpenConnection(Cn, Config.ConnectionString)
		
		
		'///////////////////////////////////////////////////////////////////////////////
		'//Buscar todas las Secciones
		'///////////////////////////////////////////////////////////////////////////////
		sQuery = "SELECT dbo.Resultados.*, LTRIM(STR(dbo.Resultados.resg_Grado)) + '-' + LTRIM(dbo.Resultados.resg_Section) AS Seccion, dbo.Reports.Rep_ID " & "FROM   dbo.Resultados LEFT OUTER JOIN " & "dbo.Reports ON dbo.Resultados.resg_rep_id = dbo.Reports.Rep_ID " & "Where (dbo.Reports.Rep_ID =" & dRepID & ") AND (ISNULL(Resultados.resg_AID, 0) = 0) AND Resultados.resg_MAT > 0 AND Resultados.resg_MAT <> 68 " & "ORDER By dbo.Resultados.resg_Grado, dbo.Resultados.resg_Section ASC "
		
		Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
		
		
		On Error Resume Next
		While Not Rs.EOF
			cSections.Add(GetValue(Rs.Fields("seccion")) & "|" & Rs.Fields("resg_total_est").Value, "S" & Rs.Fields("seccion").Value)
			Rs.MoveNext()
		End While
		On Error GoTo 0
		
		Rs.Close()
		
		HD = ""
		
		While iLastSection < cSections.Count()
			iFrom = iLastSection + 1
			
			'--proxima linea en comentario como estaba antes que el maximo es 15 secciones
			'iTo = iLastSection + MAX_SEC
			iTo = iFrom
			If iTo > cSections.Count() Then iTo = cSections.Count()
			If iFrom > cSections.Count() Then iFrom = cSections.Count()
			
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Header
			'///////////////////////////////////////////////////////////////////////////////
			'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FromGrade = Split(cSections.Item(iFrom), "-")(0)
			
			'--Calcular el ToGrade poniendo que el sea 8vo el maximo (1-8 y 9-12)
			'--Update sep 17 2007:
			'---Calcular el ToGrade poniendo que el sea 1-3, 4-6, 7-9 y 10-12
			'---Calcular el ToGrade poniendo que el sea 1-3, 4 solo, 5-7, 8-9, y 10-12
			
			If iLastSection = 0 Then iLastSection = 1
			
			'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If CDbl(Split(cSections.Item(iFrom), "-")(0)) < 2 Then
				For secCtr = 1 To cSections.Count()
					iTo = cSections.Count()
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If CDbl(Split(cSections.Item(secCtr), "-")(0)) >= 2 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						iTo = secCtr - 1
						Exit For
					End If
				Next secCtr
				'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf CDbl(Split(cSections.Item(iFrom), "-")(0)) < 3 Then 
				For secCtr = 1 To cSections.Count()
					iTo = cSections.Count()
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If CDbl(Split(cSections.Item(secCtr), "-")(0)) >= 3 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						iTo = secCtr - 1
						Exit For
					End If
				Next secCtr
				'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf CDbl(Split(cSections.Item(iFrom), "-")(0)) < 4 Then 
				For secCtr = 1 To cSections.Count()
					iTo = cSections.Count()
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If CDbl(Split(cSections.Item(secCtr), "-")(0)) >= 4 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						iTo = secCtr - 1
						Exit For
					End If
				Next secCtr
				'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf CDbl(Split(cSections.Item(iFrom), "-")(0)) < 5 Then 
				For secCtr = 1 To cSections.Count()
					iTo = cSections.Count()
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If CDbl(Split(cSections.Item(secCtr), "-")(0)) >= 5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						iTo = secCtr - 1
						Exit For
					End If
				Next secCtr
				'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf CDbl(Split(cSections.Item(iFrom), "-")(0)) < 6 Then 
				For secCtr = 1 To cSections.Count()
					iTo = cSections.Count()
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If CDbl(Split(cSections.Item(secCtr), "-")(0)) >= 6 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						iTo = secCtr - 1
						Exit For
					End If
				Next secCtr
				'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf CDbl(Split(cSections.Item(iFrom), "-")(0)) < 7 Then 
				For secCtr = 1 To cSections.Count()
					iTo = cSections.Count()
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If CDbl(Split(cSections.Item(secCtr), "-")(0)) >= 7 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						iTo = secCtr - 1
						Exit For
					End If
				Next secCtr
				'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf CDbl(Split(cSections.Item(iFrom), "-")(0)) < 8 Then 
				For secCtr = 1 To cSections.Count()
					iTo = cSections.Count()
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If CDbl(Split(cSections.Item(secCtr), "-")(0)) >= 8 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						iTo = secCtr - 1
						Exit For
					End If
				Next secCtr
				'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf CDbl(Split(cSections.Item(iFrom), "-")(0)) < 9 Then 
				For secCtr = 1 To cSections.Count()
					iTo = cSections.Count()
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If CDbl(Split(cSections.Item(secCtr), "-")(0)) >= 9 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						iTo = secCtr - 1
						Exit For
					End If
				Next secCtr
				'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf CDbl(Split(cSections.Item(iFrom), "-")(0)) < 10 Then 
				For secCtr = 1 To cSections.Count()
					iTo = cSections.Count()
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If CDbl(Split(cSections.Item(secCtr), "-")(0)) >= 10 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						iTo = secCtr - 1
						Exit For
					End If
				Next secCtr
				'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf CDbl(Split(cSections.Item(iFrom), "-")(0)) < 11 Then 
				For secCtr = 1 To cSections.Count()
					iTo = cSections.Count()
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If CDbl(Split(cSections.Item(secCtr), "-")(0)) >= 11 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						iTo = secCtr - 1
						Exit For
					End If
				Next secCtr
				'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf CDbl(Split(cSections.Item(iFrom), "-")(0)) < 12 Then 
				For secCtr = 1 To cSections.Count()
					iTo = cSections.Count()
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If CDbl(Split(cSections.Item(secCtr), "-")(0)) >= 12 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						iTo = secCtr - 1
						Exit For
					End If
				Next secCtr
			Else
				'Ya hizo la primera parte de 1mo a 8vo, ahora la segunda parte es hasta el final
				iTo = cSections.Count()
			End If
			'----
			
			'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ToGrade = Split(cSections.Item(iTo), "-")(0)
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If FromGrade > ToGrade Then
				'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ToGrade = FromGrade
				iTo = iFrom
			End If
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FromSup = GetSuperscript(FromGrade)
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ToSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ToSup = GetSuperscript(ToGrade)
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If FromGrade = ToGrade Then
				'UPGRADE_WARNING: Couldn't resolve default property of object FromSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				SubTitle = FromGrade & "<sup>" & FromSup & "</sup> Grado"
				'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf (CShort(FromGrade) + 1) = CShort(ToGrade) Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object ToSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				SubTitle = FromGrade & "<sup>" & FromSup & "</sup>  y  " & ToGrade & "<sup>" & ToSup & "</sup> Grado"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object ToSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				SubTitle = FromGrade & "<sup>" & FromSup & "</sup>  hasta  " & ToGrade & "<sup>" & ToSup & "</sup> Grado"
			End If
			
			If HD <> "" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Get50Footer(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				HD = HD & Get50Footer("<p class=MsoBodyText align=center><b>Menos del 51% =</b></p>") & "<br><br><br><br><br><br><br>"
			End If
			
			HD = HD & "<p class=MsoNormal align=center style='text-align:center'><span lang=ES-PR style='font-size:14.0pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'><b>FRECUENCIA Y PORCIENTO DE ESTUDIANTES QUE ALCANZÓ EL 51% O MÁS <BR> EN LAS DESTREZAS BÁSICAS DE LAS MATEMÁTICAS</span><br><br>"
			HD = HD & "<span lang=ES-PR style='font-size:18pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'>" & SubTitle & "</b></span></p>"
			HD = HD & "<BR><br>"
			
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Buscar todas las destrezas
			'///////////////////////////////////////////////////////////////////////////////
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sQuery = "SELECT D_1_Nombre, D_2_Nombre, D_3_Nombre, D_4_Nombre, D_5_Nombre, " &
                "D_6_Nombre, D_7_Nombre, D_8_Nombre, D_9_Nombre, D_10_Nombre, D_11_Nombre, D_12_Nombre, D_13_Nombre, D_14_Nombre, D_15_Nombre," &
                "D_16_Nombre, D_17_Nombre, D_18_Nombre, D_19_Nombre, D_20_Nombre," &
                "D_CL_ID , Rep_ID, resg_total_est " & "FROM Destrezas INNER JOIN " &
                "Resultados ON Destrezas.D_CL_ID = Resultados.resg_MAT INNER JOIN " &
                "Reports ON Resultados.resg_rep_id = Reports.Rep_ID " &
                "WHERE (Reports.Rep_ID =" & dRepID & ") AND (ISNULL(Resultados.resg_AID, 0) = 0) " &
                "AND (Resultados.resg_grado >=" & FromGrade & ") AND (Resultados.resg_grado <=" & ToGrade & ") order by resultados.resg_grado"
			
			Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
			
			On Error Resume Next
			'CLEAR DESTREZAS
			For iCtr = 1 To cDestrezas.Count()
				cDestrezas.Remove((1))
			Next iCtr
			
			While Not Rs.EOF
                For iCounter As Integer = 1 To 20
                    If Not IsDBNull(Rs.Fields("D_" & iCounter & "_Nombre").Value) And Trim(GetValue(Rs.Fields("D_" & iCounter & "_Nombre"))) <> "" Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        cDestrezas.Add(GetValue(Rs.Fields("D_" & iCounter & "_Nombre")), GetValue(Rs.Fields("D_" & iCounter & "_Nombre")))
                    End If
                Next iCounter
				Rs.MoveNext()
			End While
			On Error GoTo 0
			Rs.Close()
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Table Header
			'///////////////////////////////////////////////////////////////////////////////
			HD = HD & "<table width=90% border=1 cellpadding=1 cellspacing=0 bordercolor=black align=center>"
			HD = HD & "    <tr BGCOLOR=#CCCCCC>"
			HD = HD & "        <td align=center width=300><p class=MsoBodyText align=center><I><B>GRADO - GRUPO</I></B></p></td>"
			
            For iCounter As Integer = iFrom To iTo
                'UPGRADE_WARNING: Couldn't resolve default property of object cSections.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object iSec1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                iSec1 = Split(cSections.Item(iCounter), "|")(0)
                'UPGRADE_WARNING: Couldn't resolve default property of object iSec1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object iSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                iSec = iSec1
                'UPGRADE_WARNING: Couldn't resolve default property of object iSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                HD = HD & "        <td align=center colspan=2><p class=MsoBodyText align=center><B><I>" & CStr(iSec) & "</B></I></p></td>"

            Next iCounter
			HD = HD & "    </tr>"
			
			'--------HEADER ADICIONAL TOTAL # ESTUDIANTES-------------
			HD = HD & "    <tr BGCOLOR=#CCCCCC>"
			HD = HD & "        <td align=center><p class=MsoBodyText align=center><B><i>TOTAL # ESTUDIANTES</i></B></p></td>"
			
            For iCounter As Integer = iFrom To iTo
                'UPGRADE_WARNING: Couldn't resolve default property of object cSections.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object iSec2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                iSec2 = Split(cSections.Item(iCounter), "|")(1)
                'UPGRADE_WARNING: Couldn't resolve default property of object iSec2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object iSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                iSec = "N=" & iSec2
                'UPGRADE_WARNING: Couldn't resolve default property of object iSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                HD = HD & "        <td align=center colspan=2><p class=MsoBodyText align=center><B><i>" & CStr(iSec) & "</i></B></p></td>"

            Next iCounter
			HD = HD & "    </tr>"
			'--------------------------------------
			
			'--------HEADER ADICIONAL FRECUENCIA / PORCIENTO-------------
			HD = HD & "    <tr BGCOLOR=#CCCCCC>"
			HD = HD & "        <td width=400 align=center><p class=MsoBodyText align=center><B><i>FRECUENCIA / PORCIENTO</i></B></p></td>"
			
            For iCounter As Integer = iFrom To iTo
                HD = HD & "        <td width=60 align=center><p class=MsoBodyText align=center><i><B>n</B></i></p></td>"
                HD = HD & "        <td width=60 align=center><p class=MsoBodyText align=center><i><B>%</B></i></p></td>"
            Next iCounter
			HD = HD & "    </tr>"
			'--------------------------------------
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Totales de ejecucion
			'///////////////////////////////////////////////////////////////////////////////
			HD = HD & "    <tr>"
			HD = HD & "        <td align=left BGCOLOR=#E6E6E6><p class=MsoBodyText align=left><i><B>Dominio total de la prueba</B></p></i></td>"
			
			
            For iCounter As Integer = iFrom To iTo
                'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                tmpSec = Split(cSections.Item(iCounter), "|")(0)
                'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                p = InStr(tmpSec, "-")
                'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                g = Left(tmpSec, p - 1)
                'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                s = Right(tmpSec, Len(tmpSec) - p)
                'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object GetTotalEjecucion(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                lEjecucion = GetTotalEjecucion(dRepID, g, s, "M")
                'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If lEjecucion = "" Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    lEjecucion = "&nbsp;"
                    'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    bgc = "#ffffff"
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    pEjecucion = Split(lEjecucion, "(")(1)
                    'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    pEjecucion = Split(pEjecucion, ")")(0)
                    'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    pEjecucion = FormatNumber(pEjecucion, 0)
                    'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If CShort(pEjecucion) < 51 Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        bgc = "#ffc4c4"
                    Else
                        'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        bgc = "#ffffff"
                    End If
                End If

                'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If InStr(1, lEjecucion, "(") > 0 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object td1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    td1 = Split(lEjecucion, "(")(0)
                    'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object td2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    td2 = Replace(Split(lEjecucion, "(")(1), ")", "")
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object td1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    td1 = lEjecucion
                    'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object td2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    td2 = lEjecucion
                End If
                'UPGRADE_WARNING: Couldn't resolve default property of object td1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                HD = HD & "        <td align=center bgcolor=" & bgc & "><p class=MsoBodyText align=center><I><B>" & td1 & "</B></I></p></td>"
                'UPGRADE_WARNING: Couldn't resolve default property of object td2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                HD = HD & "        <td align=center bgcolor=" & bgc & "><p class=MsoBodyText align=center><I><B>" & td2 & "</B></I></p></td>"


            Next iCounter
			HD = HD & "    </tr>"
			
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Ciclo Principal
			'///////////////////////////////////////////////////////////////////////////////
			For idez = 1 To cDestrezas.Count()
				HD = HD & "    <tr>"
				'UPGRADE_WARNING: Couldn't resolve default property of object cDestrezas(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				HD = HD & "        <td width =25% align=left BGCOLOR=#E6E6E6><p class=MsoBodyText align=left>" & cDestrezas.Item(idez) & "</p></td>"
				
				For iSec = iFrom To iTo
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					tmpSec = Split(cSections.Item(iSec), "|")(0)
					'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					p = InStr(tmpSec, "-")
					'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					g = Left(tmpSec, p - 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					s = Right(tmpSec, Len(tmpSec) - p)
					'UPGRADE_WARNING: Couldn't resolve default property of object cDestrezas(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object GetEjecucion(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					lEjecucion = GetEjecucion(dRepID, g, s, cDestrezas.Item(idez), "M")
					'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					bgc = "#ffffff"
					'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If lEjecucion = "" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						lEjecucion = "&nbsp;"
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						pEjecucion = Split(lEjecucion, "(")(1)
						'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						pEjecucion = Split(pEjecucion, ")")(0)
						'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						pEjecucion = FormatNumber(pEjecucion, 0)
						'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If CShort(pEjecucion) < 51 Then
							'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							bgc = "#ffc4c4"
						Else
							'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							bgc = "#ffffff"
						End If
					End If
					
					'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If InStr(1, lEjecucion, "(") > 0 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object td1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						td1 = Split(lEjecucion, "(")(0)
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object td2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						td2 = Replace(Split(lEjecucion, "(")(1), ")", "")
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object td1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						td1 = lEjecucion
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object td2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						td2 = lEjecucion
					End If
					'UPGRADE_WARNING: Couldn't resolve default property of object td1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					HD = HD & "        <td align=center bgcolor=" & bgc & "><p class=MsoBodyText align=center>" & td1 & "</p></td>"
					'UPGRADE_WARNING: Couldn't resolve default property of object td2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					HD = HD & "        <td align=center bgcolor=" & bgc & "><p class=MsoBodyText align=center>" & td2 & "</p></td>"
				Next iSec
				HD = HD & "    </tr>"
			Next idez
			
			
			iLastSection = iTo
			HD = HD & "</Table>"
		End While
		
		Cn.Close()
		'///////////////////////////////////////////////////////////////////////////////
		'//Footer
		'///////////////////////////////////////////////////////////////////////////////
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Get50Footer(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = HD & Get50Footer("<p class=MsoBodyText align=center><b>Menos del 51% =</b></p>")
		
		TABLE_MAT2 = "<BR><BR><BR>" & HD
		'UPGRADE_NOTE: Object cSections may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		cSections = Nothing
		'UPGRADE_NOTE: Object cDestrezas may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		cDestrezas = Nothing
	End Function
	
	Function TABLE_REN2(ByVal dRepID As Double) As String
		Dim idez As Object
		Dim td2 As Object
		Dim td1 As Object
		Dim pEjecucion As Object
		Dim bgc As Object
		Dim s As Object
		Dim g As Object
		Dim p As Object
		Dim tmpSec As Object
		Dim iSec As Object
		Dim iSec2 As Object
		Dim iSec1 As Object
		Dim i As Object
		Dim iCtr As Object
		Dim ToSup As Object
		Dim FromSup As Object
		Dim ToGrade As Object
		Dim FromGrade As Object
		Dim secCtr As Object
		Const MAX_SEC As Short = 15
		Dim Rs As New ADODB.Recordset
		Dim Cn As New ADODB.Connection
		Dim sQuery As String
		Dim HD As String
		Dim cDestrezas As New Collection
		Dim cSections As New Collection
		Dim iLastSection As Short
		Dim iFrom As Short
		Dim iTo As Short
		Dim lEjecucion As Object
		Dim SubTitle As String
		
		OpenConnection(Cn, Config.ConnectionString)
		
		
		'///////////////////////////////////////////////////////////////////////////////
		'//Buscar todas las Secciones
		'///////////////////////////////////////////////////////////////////////////////
		sQuery = "SELECT dbo.Resultados.*, LTRIM(STR(dbo.Resultados.resg_Grado)) + '-' + LTRIM(dbo.Resultados.resg_Section) AS Seccion, dbo.Reports.Rep_ID " & "FROM   dbo.Resultados LEFT OUTER JOIN " & "dbo.Reports ON dbo.Resultados.resg_rep_id = dbo.Reports.Rep_ID " & "Where (dbo.Reports.Rep_ID =" & dRepID & ") AND (ISNULL(Resultados.resg_AID, 0) = 0) AND Resultados.resg_REN > 0 AND Resultados.resg_REN <> 68 " & "ORDER By dbo.Resultados.resg_Grado, dbo.Resultados.resg_Section ASC "
		
		Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
		
		
		On Error Resume Next
		While Not Rs.EOF
			cSections.Add(GetValue(Rs.Fields("seccion")) & "|" & Rs.Fields("resg_total_est").Value, "S" & Rs.Fields("seccion").Value)
			Rs.MoveNext()
		End While
		On Error GoTo 0
		
		Rs.Close()
		
		HD = ""
		iLastSection = 0
		While iLastSection < cSections.Count()
			iFrom = iLastSection + 1
			
			'--proxima linea en comentario como estaba antes que el maximo es 15 secciones
			'iTo = iLastSection + MAX_SEC
			iTo = iFrom
			If iTo > cSections.Count() Then iTo = cSections.Count()
			
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Header
			'///////////////////////////////////////////////////////////////////////////////
			
			
			'--Calcular el ToGrade poniendo que el sea 8vo el maximo (1-8 y 9-12)
			'--Update sep 17 2007:
			'---Calcular el ToGrade poniendo que el sea 1-3, 4-6, 7-9 y 10-12
			
			
			'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If CDbl(Split(cSections.Item(iFrom), "-")(0)) >= 1 And CDbl(Split(cSections.Item(iFrom), "-")(0)) <= 3 Then
				For secCtr = iFrom To cSections.Count()
					'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					iTo = secCtr
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If CDbl(Split(cSections.Item(iTo), "-")(0)) >= 4 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						iTo = secCtr - 1
						Exit For
					End If
				Next secCtr
				'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf CDbl(Split(cSections.Item(iFrom), "-")(0)) >= 4 And CDbl(Split(cSections.Item(iFrom), "-")(0)) <= 6 Then 
				For secCtr = iFrom To cSections.Count()
					'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					iTo = secCtr
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If CDbl(Split(cSections.Item(secCtr), "-")(0)) >= 7 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						iTo = secCtr - 1
						Exit For
					End If
				Next secCtr
				'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf CDbl(Split(cSections.Item(iFrom), "-")(0)) >= 7 And CDbl(Split(cSections.Item(iFrom), "-")(0)) <= 9 Then 
				For secCtr = iFrom To cSections.Count()
					'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					iTo = secCtr
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If CDbl(Split(cSections.Item(secCtr), "-")(0)) >= 10 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object secCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						iTo = secCtr - 1
						Exit For
					End If
				Next secCtr
			Else
				'Ya hizo todas las partes hasta 9no, ahora es hasta el final
				iTo = cSections.Count()
			End If
			'----
			
			'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FromGrade = Split(cSections.Item(iFrom), "-")(0)
			'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ToGrade = Split(cSections.Item(iTo), "-")(0)
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If FromGrade > ToGrade Then
				'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ToGrade = FromGrade
				iTo = iFrom
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FromSup = GetSuperscript(FromGrade, True)
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ToSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ToSup = GetSuperscript(ToGrade, True)
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If FromGrade = ToGrade Then
				'UPGRADE_WARNING: Couldn't resolve default property of object FromSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				SubTitle = FromGrade & "<sup>" & FromSup & "</sup> Grade"
				'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf (CShort(FromGrade) + 1) = CShort(ToGrade) Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object ToSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				SubTitle = FromGrade & "<sup>" & FromSup & "</sup>  and  " & ToGrade & "<sup>" & ToSup & "</sup> Grade"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object ToSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromSup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				SubTitle = FromGrade & "<sup>" & FromSup & "</sup> to " & ToGrade & "<sup>" & ToSup & "</sup> Grade"
			End If
			
			If HD <> "" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Get50Footer(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				HD = HD & "<Br>" & Get50Footer("<p class=MsoBodyText align=center><b>Less than 51% =</b></p>") & "<br><br><br><br><br><br><br>"
			End If
			
			HD = HD & "<p class=MsoNormal align=center style='text-align:center'><span lang=ES-PR style='font-size:14.0pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'><b>FREQUENCY AND STUDENT PERCENTAGE WITH 51% OR MORE <BR> ON THE ENGLISH BASIC SKILLS</span><br><br>"
			HD = HD & "<span lang=ES-PR style='font-size:18pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'>" & SubTitle & "</b></SPAN></P>"
			HD = HD & "<BR><br>"
			
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Buscar todas las destrezas
			'///////////////////////////////////////////////////////////////////////////////
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ToGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FromGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sQuery = "SELECT     D_1_Nombre, D_2_Nombre, D_3_Nombre, D_4_Nombre, D_5_Nombre, " & "             D_6_Nombre, D_7_Nombre, D_8_Nombre, D_9_Nombre, D_10_Nombre," & "             D_CL_ID , Rep_ID, resg_total_est " & "FROM         Destrezas INNER JOIN " & "             Resultados ON Destrezas.D_CL_ID = Resultados.resg_REN INNER JOIN " & "             Reports ON Resultados.resg_rep_id = Reports.Rep_ID " & "Where (Reports.Rep_ID =" & dRepID & ") AND (ISNULL(Resultados.resg_AID, 0) = 0) " & "AND (Resultados.resg_grado >=" & FromGrade & ") AND (Resultados.resg_grado <=" & ToGrade & ") order by resultados.resg_grado"
			
			Rs.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
			
			On Error Resume Next
			'CLEAR DESTREZAS
			For iCtr = 1 To cDestrezas.Count()
				cDestrezas.Remove((1))
			Next iCtr
			
			While Not Rs.EOF
                For iCounter As Integer = 1 To 10
                    If Not IsDBNull(Rs.Fields("D_" & iCounter & "_Nombre").Value) And Trim(GetValue(Rs.Fields("D_" & iCounter & "_Nombre").Value)) <> "" Then
                        cDestrezas.Add(GetValue(Rs.Fields("D_" & iCounter & "_Nombre").Value), GetValue(Rs.Fields("D_" & iCounter & "_Nombre").Value))
                    End If
                Next iCounter
				Rs.MoveNext()
			End While
			On Error GoTo 0
			Rs.Close()
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Table Header
			'///////////////////////////////////////////////////////////////////////////////
			HD = HD & "<table width=90% border=1 cellpadding=1 cellspacing=0 bordercolor=black align=center>"
			HD = HD & "    <tr BGCOLOR=#CCCCCC>"
			HD = HD & "        <td align=center><p class=MsoBodyText align=center><I><B>GRADE - GROUP</B></I></P></td>"
			
			For i = iFrom To iTo
				'UPGRADE_WARNING: Couldn't resolve default property of object cSections.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object iSec1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				iSec1 = Split(cSections.Item(i), "|")(0)
				'UPGRADE_WARNING: Couldn't resolve default property of object cSections.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object iSec2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				iSec2 = Split(cSections.Item(i), "|")(1)
				'UPGRADE_WARNING: Couldn't resolve default property of object iSec1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object iSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				iSec = iSec1
				'UPGRADE_WARNING: Couldn't resolve default property of object iSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				HD = HD & "        <td align=center colspan=2><p class=MsoBodyText align=center><B><i>" & CStr(iSec) & "</i></P></B></td>"
				
			Next i
			HD = HD & "    </tr>"
			
			'--------HEADER ADICIONAL TOTAL # ESTUDIANTES-------------
			HD = HD & "    <tr BGCOLOR=#CCCCCC>"
			HD = HD & "        <td align=center><p class=MsoBodyText align=center><B><i>TOTAL # STUDENTS</i></B></p></td>"
			
			For i = iFrom To iTo
				'UPGRADE_WARNING: Couldn't resolve default property of object cSections.Item(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object iSec2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				iSec2 = Split(cSections.Item(i), "|")(1)
				'UPGRADE_WARNING: Couldn't resolve default property of object iSec2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object iSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				iSec = "N=" & iSec2
				'UPGRADE_WARNING: Couldn't resolve default property of object iSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				HD = HD & "        <td align=center colspan=2><p class=MsoBodyText align=center><i><B>" & CStr(iSec) & "</B></i></p></td>"
				
			Next i
			HD = HD & "    </tr>"
			'--------------------------------------
			
			'--------HEADER ADICIONAL FRECUENCIA / PORCIENTO-------------
			HD = HD & "    <tr BGCOLOR=#CCCCCC>"
			HD = HD & "        <td align=center><p class=MsoBodyText align=center><B><i>FREQUENCY / PERCENT</i></B></p></td>"
			
			For i = iFrom To iTo
				HD = HD & "        <td align=center width=60><p class=MsoBodyText align=center><i><B>n</B></i></p></td>"
				HD = HD & "        <td align=center width=60><p class=MsoBodyText align=center><i><B>%</B></i></p></td>"
			Next i
			HD = HD & "    </tr>"
			'--------------------------------------
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Totales de ejecucion
			'///////////////////////////////////////////////////////////////////////////////
			HD = HD & "    <tr>"
			HD = HD & "        <td align=left BGCOLOR=#E6E6E6><p class=MsoBodyText align=left><i><B>Total Test Accomplishment</B></P></i></td>"
			
			
			For i = iFrom To iTo
				'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				tmpSec = Split(cSections.Item(i), "|")(0)
				'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				p = InStr(tmpSec, "-")
				'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				g = Left(tmpSec, p - 1)
				'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				s = Right(tmpSec, Len(tmpSec) - p)
				'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object GetTotalEjecucion(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lEjecucion = GetTotalEjecucion(dRepID, g, s, "R")
				'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If lEjecucion = "" Then
					'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					lEjecucion = "&nbsp;"
					'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					bgc = "#ffffff"
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					pEjecucion = Split(lEjecucion, "(")(1)
					'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					pEjecucion = Split(pEjecucion, ")")(0)
					'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					pEjecucion = FormatNumber(pEjecucion, 0)
					'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If CShort(pEjecucion) < 51 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						bgc = "#ffc4c4"
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						bgc = "#ffffff"
					End If
				End If
				
				'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If InStr(1, lEjecucion, "(") > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object td1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					td1 = Split(lEjecucion, "(")(0)
					'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object td2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					td2 = Replace(Split(lEjecucion, "(")(1), ")", "")
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object td1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					td1 = lEjecucion
					'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object td2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					td2 = lEjecucion
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object td1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				HD = HD & "        <td align=center bgcolor=" & bgc & "><p class=MsoBodyText align=center><I><B>" & td1 & "</B></I></p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				HD = HD & "        <td align=center bgcolor=" & bgc & "><p class=MsoBodyText align=center><I><B>" & td2 & "</B></I></p></td>"
				
				
			Next i
			HD = HD & "    </tr>"
			
			
			'///////////////////////////////////////////////////////////////////////////////
			'//Ciclo Principal
			'///////////////////////////////////////////////////////////////////////////////
			For idez = 1 To cDestrezas.Count()
				HD = HD & "    <tr>"
				'UPGRADE_WARNING: Couldn't resolve default property of object cDestrezas(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				HD = HD & "        <td width =25% align=left BGCOLOR=#E6E6E6><p class=MsoBodyText align=left>" & cDestrezas.Item(idez) & "</p></td>"
				
				For iSec = iFrom To iTo
					'UPGRADE_WARNING: Couldn't resolve default property of object cSections(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					tmpSec = Split(cSections.Item(iSec), "|")(0)
					'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					p = InStr(tmpSec, "-")
					'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					g = Left(tmpSec, p - 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object tmpSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					s = Right(tmpSec, Len(tmpSec) - p)
					'UPGRADE_WARNING: Couldn't resolve default property of object cDestrezas(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object GetEjecucion(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					lEjecucion = GetEjecucion(dRepID, g, s, cDestrezas.Item(idez), "R")
					'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					bgc = "#ffffff"
					'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If lEjecucion = "" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						lEjecucion = "&nbsp;"
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						pEjecucion = Split(lEjecucion, "(")(1)
						'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						pEjecucion = Split(pEjecucion, ")")(0)
						'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						pEjecucion = FormatNumber(pEjecucion, 0)
						'UPGRADE_WARNING: Couldn't resolve default property of object pEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If CShort(pEjecucion) < 51 Then
							'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							bgc = "#ffc4c4"
						Else
							'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							bgc = "#ffffff"
						End If
					End If
					
					'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If InStr(1, lEjecucion, "(") > 0 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object td1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						td1 = Split(lEjecucion, "(")(0)
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object td2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						td2 = Replace(Split(lEjecucion, "(")(1), ")", "")
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object td1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						td1 = lEjecucion
						'UPGRADE_WARNING: Couldn't resolve default property of object lEjecucion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object td2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						td2 = lEjecucion
					End If
					'UPGRADE_WARNING: Couldn't resolve default property of object td1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					HD = HD & "        <td align=center bgcolor=" & bgc & "><p class=MsoBodyText align=center>" & td1 & "</p></td>"
					'UPGRADE_WARNING: Couldn't resolve default property of object td2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					HD = HD & "        <td align=center bgcolor=" & bgc & "><p class=MsoBodyText align=center>" & td2 & "</p></td>"
				Next iSec
				HD = HD & "    </tr>"
			Next idez
			
			
			iLastSection = iTo
			HD = HD & "</Table>"
		End While
		
		Cn.Close()
		'///////////////////////////////////////////////////////////////////////////////
		'//Footer
		'///////////////////////////////////////////////////////////////////////////////
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Get50Footer(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = HD & Get50Footer("<b>Less than 51% =</b>")
		
		TABLE_REN2 = "<BR><BR><BR>" & HD
		'UPGRADE_NOTE: Object cSections may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		cSections = Nothing
		'UPGRADE_NOTE: Object cDestrezas may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		cDestrezas = Nothing
	End Function
	
	
	Function FiletoVar(ByRef sourcefile As String) As Object
		Dim hFile As Short
		Dim Result As Object
		Dim FileLine As String
		
		hFile = FreeFile
		
		'If FileExists(sourcefile) Then 'Cambie esta linea por la siguienete pq no tenia la funcion que se estaba invocando
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If Dir(sourcefile) <> "" Then
			FileOpen(hFile, sourcefile, OpenMode.Binary)
			'UPGRADE_WARNING: Couldn't resolve default property of object Result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Result = InputString(hFile, LOF(hFile))
			FileClose(hFile)
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object Result. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FiletoVar. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FiletoVar = Result
		Exit Function
	End Function
	Sub CreateConsultantReport(ByVal dRepID As Double)
		Dim RECOM_LINE As Object
		Dim iCtr As Object
		Dim RECOM As Object
		Dim CurrGrado As Object
		Dim EST_DESTACADOS As Object
		Dim d9 As Object
		Dim d8 As Object
		Dim d7 As Object
		Dim d6 As Object
		Dim d5 As Object
		Dim d4 As Object
		Dim d3 As Object
		Dim d2 As Object
		Dim d1 As Object
		Dim Sobre As Object
		Dim Prom As Object
		Dim Bajo As Object
		Dim observaciontable As Object
		Dim CONDUCTA_RES As Object
		Dim INST_RES As Object
		Dim COND_RES As Object
		Dim bgc As Object
		Dim pTotal As Object
		Dim preY As Object
		Dim preX As Object
		Dim preTable As Object
		Dim preDes As Object
		Dim TotStud As Object
		Dim totalStud As Object
		Dim preSec As Object
		Dim pre1x As Object
		Dim LastParrafo As Object
		Dim DomDesc As Object
		Dim i As Object
		Dim MaxDomTot As Object
		Dim MaxDom As Object
		Dim X As Object
		Dim CurrDomTot As Object
		Dim z As Object
		Dim CurrAidTot As Object
		Dim Destreza As Object
		Dim DominioTot As Object
		Dim AidTot As Object
		Dim AID_RES As Object
		Dim AID_RES_TITLE As Object
		Dim Repo_Intr As Object
		Dim Ausente_Intr As Object
		Dim Acomodo_Intr As Object
		Dim PRE1_Intr As Object
		Dim AID_Intr As Object
		Dim Ingles_Intr As Object
		Dim tempgrade As Object
		Dim CurrGrade As Object
		Dim sTotGrades As Object
		Dim TotGrades As Object
		Dim firstaid As Object
		Dim FirstRen As Object
		Dim TotStu As Object
		Dim Semester As Object
		Dim informelist As Object
		Dim InformeFooter As Object
		Dim FROMTO As Object
        Dim DestDirlist As Object
		Dim Ausente_Tot As Object
		Dim repo_tot As Object
		Dim repo_date As Object
		Dim acomodo_tot As Object
		Dim FooterLine As Object
		Dim ReportsPath As Object
		Dim ConsultantsPath As Object
		Dim iIncrement As Object
		Dim iTotalWidth As Object
		Dim sQuery As String
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		Dim RsRep As ADODB.Recordset
		Dim RsRes As ADODB.Recordset
		Dim RsEst As ADODB.Recordset
		Dim Informe As Object
		Dim FromGrade As String
		Dim ToGrade As String
		Dim DestDir As String
		Dim DocName As String
		Dim isPRE1 As Boolean
		Dim Pre1Data As Object
		Dim firstPre1 As String 'para guardar el grado que tiene pre1
		Dim BajoTotStud As Short
		Dim PromTotStud As Short
		Dim SobreTotStud As Short
		
		firstPre1 = ""
		
		'UPGRADE_WARNING: Couldn't resolve default property of object iTotalWidth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		iTotalWidth = VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width)
		frmreportprocess.Shape1.Width = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object iTotalWidth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		iIncrement = iTotalWidth / 22
		
		'--
		Cn = CreateObject("ADODB.Connection")
		
		OpenConnection(Cn, Config.ConnectionString)
		
		'ConsultantsPath = "C:\Documents and Settings\angelpinzon\My Documents\Clients\LearnAid\Consultant\consultores\"
		'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ConsultantsPath = Config.ConsultantsPath
		'ReportsPath = "C:\Documents and Settings\angelpinzon\My Documents\Clients\LearnAid\Consultant\"
		'UPGRADE_WARNING: Couldn't resolve default property of object ReportsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ReportsPath = Config.ReportsPath
		'UPGRADE_WARNING: Couldn't resolve default property of object FooterLine. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        FooterLine = "Resultados [COL_NAME] - [SERVICE_DATE] <br> [CON_FULL_NAME], [CON_TITLE], Learn Aid Puerto Rico"
        'UPGRADE_WARNING: Couldn't resolve default property of object acomodo_tot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'acomodo_tot = GetValue((frmInformeConsultoresSectionsList.txtAcomodo), 0)
        acomodo_tot = GetValue((frmInformeConsultoresSectionsList.txtAcomodo.Text), 0)
		'UPGRADE_WARNING: Couldn't resolve default property of object repo_date. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'repo_date = SetDate(GetValue((frmInformeConsultoresSectionsList.txtReposicionDate), ""), True, False)
        Dim a As String
        a = frmInformeConsultoresSectionsList.dtReposicionDate.Value.ToString()
        repo_date = SetDate(a, True, False)
		'UPGRADE_WARNING: Couldn't resolve default property of object repo_date. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If repo_date <> "" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object repo_date. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			repo_date = SetDate(repo_date)
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object repo_tot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        repo_tot = GetValue((frmInformeConsultoresSectionsList.txtReposicion.Text), 0)
		'UPGRADE_WARNING: Couldn't resolve default property of object Ausente_Tot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Ausente_Tot = GetValue((frmInformeConsultoresSectionsList.txtAusentes.Text), 0)
		
		'>>>>------------------------------new added by JC-------------<<<<<
		
        sQuery = "SELECT CON_ID,CONSULTANTS.CON_NAME, CONSULTANTS.CON_LNAME1, CONSULTANTS.CON_LNAME2, CONSULTANTS.CON_FULL_NAME,CONSULTANTS.CON_TITLE, SCHOOLS.SC_SCH_NAME, " &
                    "Reports.rep_serv_date, Reports.Rep_ID, Reports.Rep_Type " &
                    "FROM (Reports LEFT JOIN SCHOOLS ON Reports.Rep_SCH_ID = SCHOOLS.SC_ID) LEFT JOIN CONSULTANTS ON Reports.rep_cons_id = CONSULTANTS.CON_ID " &
                    "WHERE (((Reports.Rep_ID)=" & dRepID & " ))"
		
        Rs = New ADODB.Recordset
        Rs.Open(sQuery, Cn, 3, 3)
		
        DocName = Rs.Fields("sc_sch_name").Value & " - " & Month(GetValue(Rs.Fields("rep_serv_date").Value, "")) & " - " & Year(GetValue(Rs.Fields("rep_serv_date").Value, ""))
		'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DestDir = ConsultantsPath & Trim(Rs.Fields("con_name").Value & " " & Rs.Fields("con_lname1").Value & " " & Rs.Fields("con_lname2").Value)
		'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object DestDirlist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DestDirlist = ConsultantsPath & Trim(Rs.Fields("con_name").Value & " " & Rs.Fields("con_lname1").Value & " " & Rs.Fields("con_lname2").Value) & "\" & DocName
		
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If Dir(DestDir, FileAttribute.Directory) = "" Then MkDir(DestDir)
		'UPGRADE_WARNING: Couldn't resolve default property of object DestDirlist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object DestDirlist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Dir(DestDirlist, FileAttribute.Directory) = "" Then MkDir(DestDirlist)
		
		DestDir = DestDir & "\"
		'UPGRADE_WARNING: Couldn't resolve default property of object DestDirlist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DestDirlist = DestDirlist & "\"
		
		
		'FileCopy ConsultantsPath & "consultor2.htm", DocName
		'----INCREMENT 1
		'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		frmreportprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width) + iIncrement)
		System.Windows.Forms.Application.DoEvents()
		'----
		
		'---
		'DESDE QUE GRADO HASTA QUE GRADO y Fecha del Servicio y Total de Estudiantes
		RsRes = CreateObject("ADODB.Recordset")
		'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sQuery = "select resg_grado, resg_total_est, resg_REN, resg_aid,resg_LES from Resultados where resg_rep_id = " & dRepID & " order by resg_grado"
        RsRes.Open(sQuery, Cn, 3, 3)
		FromGrade = "0"
		ToGrade = "0"
		If RsRes.RecordCount > 0 Then
			RsRes.MoveFirst()
			FromGrade = GetStrGrade(Int(CDbl(RsRes.Fields("resg_grado").Value)))
			RsRes.MoveLast()
			ToGrade = GetStrGrade(Int(CDbl(RsRes.Fields("resg_grado").Value)))
		End If
		If FromGrade = ToGrade And FromGrade = "0" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object FROMTO. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FROMTO = ToGrade
		ElseIf FromGrade = ToGrade Then 
			If ToGrade = "Tercero" Then ToGrade = "Tercer"
			If ToGrade = "Primero" Then ToGrade = "Primer"
			If ToGrade = "Kindergarten" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object FROMTO. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				FROMTO = ToGrade
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object FROMTO. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				FROMTO = ToGrade & " Grado"
			End If
		Else
			If ToGrade = "Tercero" Then ToGrade = "Tercer"
			If ToGrade = "Primero" Then ToGrade = "Primer"
			If FromGrade = "Tercero" Then FromGrade = "Tercer"
			If FromGrade = "Primero" Then FromGrade = "Primer"
			'UPGRADE_WARNING: Couldn't resolve default property of object FROMTO. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FROMTO = FromGrade & " a " & ToGrade & " Grado"
		End If
		
		'--
		'UPGRADE_WARNING: Couldn't resolve default property of object FROMTO. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If FROMTO = "Primer Grado" Then
			'SOlamente es primer grado, verifico si de casualidad es un PRE1
			RsRes.MoveFirst()
			If RsRes.Fields("resg_AID").Value = 69 Then
				isPRE1 = True
			End If
		End If
		
		'LOAD INFORME
		'--
		'UPGRADE_WARNING: Couldn't resolve default property of object FooterLine. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        FooterLine = Replace(FooterLine, "[CON_FULL_NAME]", GetValue(Rs.Fields("con_full_name").Value, ""))
		'UPGRADE_WARNING: Couldn't resolve default property of object FooterLine. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        FooterLine = Replace(FooterLine, "[CON_TITLE]", GetValue(Rs.Fields("con_title").Value, ""))
		
		'UPGRADE_WARNING: Couldn't resolve default property of object FROMTO. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If FROMTO <> "Kindergarten" And isPRE1 = False Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FiletoVar(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = FiletoVar(ConsultantsPath & "template.htm")
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[CON_FULL_NAME]", GetValue(Rs.Fields("con_full_name").Value, ""))
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[CON_TITLE]", GetValue(Rs.Fields("con_title").Value, ""))
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FiletoVar(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object InformeFooter. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			InformeFooter = FiletoVar(ConsultantsPath & "template_files\header.htm")
			'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FiletoVar(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object informelist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			informelist = FiletoVar(ConsultantsPath & "template_files\filelist.xml")
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "template_files", DocName)
			DocName = DocName & ".htm"
			'UPGRADE_WARNING: Couldn't resolve default property of object informelist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			informelist = Replace(informelist, "template.htm", DocName)
			'UPGRADE_WARNING: Couldn't resolve default property of object InformeFooter. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			InformeFooter = Replace(InformeFooter, "template.htm", DocName)
			'UPGRADE_WARNING: Couldn't resolve default property of object DestDirlist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CreateFile(DestDirlist & "filelist.xml", informelist)
			'UPGRADE_WARNING: Couldn't resolve default property of object DestDirlist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FileCopy(ConsultantsPath & "template_files\image001.png", DestDirlist & "image001.png")
			'UPGRADE_WARNING: Couldn't resolve default property of object DestDirlist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FileCopy(ConsultantsPath & "template_files\image002.png", DestDirlist & "image002.png")
		Else
			'AID solamente
			'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FiletoVar(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = FiletoVar(ConsultantsPath & "templateAID.htm")
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[CON_FULL_NAME]", GetValue(Rs.Fields("con_full_name"), ""))
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[CON_TITLE]", GetValue(Rs.Fields("con_title"), ""))
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FiletoVar(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object InformeFooter. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			InformeFooter = FiletoVar(ConsultantsPath & "templateAID_files\header.htm")
			'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FiletoVar(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object informelist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			informelist = FiletoVar(ConsultantsPath & "templateAID_files\filelist.xml")
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "templateAID_files", DocName)
			
			'copiar imagen logo para AID
			'UPGRADE_WARNING: Couldn't resolve default property of object DestDirlist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FileCopy(ConsultantsPath & "templateAID_files\image001.png", DestDirlist & "image001.png")
			'--
			
			DocName = DocName & ".htm"
			'UPGRADE_WARNING: Couldn't resolve default property of object informelist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			informelist = Replace(informelist, "templateAID.htm", DocName)
			'UPGRADE_WARNING: Couldn't resolve default property of object InformeFooter. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			InformeFooter = Replace(InformeFooter, "templateAID.htm", DocName)
			'UPGRADE_WARNING: Couldn't resolve default property of object DestDirlist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CreateFile(DestDirlist & "filelist.xml", informelist)
		End If
		
		'vuelvo a resetearlo a false para que en el loop se ponga true cuando le toque
		isPRE1 = False
		'--
		
		'UPGRADE_WARNING: Couldn't resolve default property of object FROMTO. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[FROM_TO]", FROMTO)
		
		If Rs.Fields("rep_type").Value = 2 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[PORT_EVAL]", "Evaluación Regular")

		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[PORT_EVAL]", "Evaluación Regular")

		End If

        Rs.Close()
        '>>>>------------------------------new added by JC-------------<<<<<

        '----INCREMENT 2
        'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmreportprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width) + iIncrement)
        frmreportprocess.lblStatus.Text = "Opening data tables..."
        frmreportprocess.lblStatus.Refresh()
        System.Windows.Forms.Application.DoEvents()
        '----

        'OPEN Reports table
        RsRep = CreateObject("ADODB.Recordset")
        'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sQuery = "select * from Reports where rep_id = " & dRepID
        RsRep.Open(sQuery, Cn, 3, 3)
        'UPGRADE_WARNING: Couldn't resolve default property of object Semester. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Semester = RsRep.Fields("rep_sem").Value
        'UPGRADE_WARNING: Couldn't resolve default property of object Semester. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[SEMESTER]", IIf(Semester = 1, "primer", "segundo"))


        'Service Date Portada
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[PORT_SERVICE_DATE]", SetDate(RsRep.Fields("rep_serv_date"), True, True), , 1)
        'Service Date Introduccion
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[INT_SERVICE_DATE]", SetDate(RsRep.Fields("rep_serv_date"), True, False), , 1)
        'Service Date Observaciones
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[OBS_SERVICE_DATE]", SetDate(RsRep.Fields("rep_serv_date"), True, False), , 1)


        'UPGRADE_WARNING: Couldn't resolve default property of object FooterLine. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        FooterLine = Replace(FooterLine, "[SERVICE_DATE]", SetShortDate(a), , 1)
        'Invisible
        '    FooterLine = Replace(FooterLine, "[SERVICE_DATE]", a, False, True)
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'Informe = Replace(Informe, "[SERVICE_DATE]", SetShortDate(RsRep.Fields("rep_serv_date"), True, True), , 1)
        Informe = Replace(Informe, "[SERVICE_DATE]", SetShortDate(a), , 1)
        '---

        'Get School Info
        Rs = CreateObject("ADODB.Recordset")
        'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sQuery = "select * from Schools where sc_id = " & RsRep.Fields("rep_sch_id").Value
        Rs.Open(sQuery, Cn, 3, 3)

        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[COL_NAME]", GetValue(Rs.Fields("SC_SCH_NAME"), ""))
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[COL_TYPE]", GetValue(Rs.Fields("sc_type"), ""))
        'UPGRADE_WARNING: Couldn't resolve default property of object FooterLine. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        FooterLine = Replace(FooterLine, "[COL_NAME]", GetValue(Rs.Fields("SC_SCH_NAME"), ""))
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[COL_CITY]", GetValue(Rs.Fields("sc_city"), ""))

        Rs.Close()
        '--
        '----INCREMENT 3
        'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmreportprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width) + iIncrement)
        System.Windows.Forms.Application.DoEvents()
        '----



        '----INCREMENT 4
        'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmreportprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width) + iIncrement)
        System.Windows.Forms.Application.DoEvents()
        '----

        'Calcular su total de estudiantes
        RsRes.MoveFirst()
        'UPGRADE_WARNING: Couldn't resolve default property of object TotStu. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        TotStu = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object FirstRen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        FirstRen = ""
        'UPGRADE_WARNING: Couldn't resolve default property of object firstaid. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        firstaid = ""
        'UPGRADE_WARNING: Couldn't resolve default property of object TotGrades. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        TotGrades = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object sTotGrades. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sTotGrades = ""
        'UPGRADE_WARNING: Couldn't resolve default property of object CurrGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        CurrGrade = -1
        While Not RsRes.EOF
            'UPGRADE_WARNING: Couldn't resolve default property of object TotStu. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            TotStu = TotStu + RsRes.Fields("resg_Total_Est").Value

            'UPGRADE_WARNING: Couldn't resolve default property of object FirstRen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Try
                If FirstRen = "" And RsRes.Fields("resg_REN").Value > 0 Then

                    'UPGRADE_WARNING: Couldn't resolve default property of object FirstRen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    FirstRen = RsRes.Fields("resg_grado").Value
                End If
            Catch ex As Exception

            End Try

            Try
                'UPGRADE_WARNING: Couldn't resolve default property of object firstaid. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If firstaid = "" And RsRes.Fields("resg_AID").Value = 51 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object firstaid. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    firstaid = RsRes.Fields("resg_grado").Value
                End If
            Catch ex As Exception

            End Try

            Try
                If isPRE1 = False And RsRes.Fields("resg_AID").Value = 69 Then
                    isPRE1 = True
                    firstPre1 = RsRes.Fields("resg_grado").Value
                    'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object FiletoVar(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object Pre1Data. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Pre1Data = FiletoVar(ConsultantsPath & "templatepre1data.txt")
                End If
            Catch ex As Exception

            End Try



            If CurrGrade <> RsRes.Fields("resg_grado").Value Then
                'UPGRADE_WARNING: Couldn't resolve default property of object TotGrades. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                TotGrades = TotGrades + 1
                'UPGRADE_WARNING: Couldn't resolve default property of object CurrGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                CurrGrade = RsRes.Fields("resg_grado").Value
            End If

            Select Case TotGrades
                Case 1
                    'UPGRADE_WARNING: Couldn't resolve default property of object sTotGrades. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sTotGrades = "el grado evaluado"
                Case 2
                    'UPGRADE_WARNING: Couldn't resolve default property of object sTotGrades. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sTotGrades = "los dos grados evaluados"

                Case 3
                    'UPGRADE_WARNING: Couldn't resolve default property of object sTotGrades. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sTotGrades = "los tres grados evaluados"
                Case 4
                    'UPGRADE_WARNING: Couldn't resolve default property of object sTotGrades. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sTotGrades = "los cuatro grados evaluados"
                Case 5
                    'UPGRADE_WARNING: Couldn't resolve default property of object sTotGrades. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sTotGrades = "los cinco grados evaluados"
                Case 6
                    'UPGRADE_WARNING: Couldn't resolve default property of object sTotGrades. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sTotGrades = "los seis grados evaluados"
                Case 7
                    'UPGRADE_WARNING: Couldn't resolve default property of object sTotGrades. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sTotGrades = "los siete grados evaluados"
                Case 8
                    'UPGRADE_WARNING: Couldn't resolve default property of object sTotGrades. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sTotGrades = "los ocho grados evaluados"
                Case 9
                    'UPGRADE_WARNING: Couldn't resolve default property of object sTotGrades. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sTotGrades = "los nueve grados evaluados"
                Case 10
                    'UPGRADE_WARNING: Couldn't resolve default property of object sTotGrades. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sTotGrades = "los diez grados evaluados"
                Case Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object TotGrades. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object sTotGrades. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sTotGrades = "los " & TotGrades & " grados evaluados"
            End Select


            RsRes.MoveNext()
            System.Windows.Forms.Application.DoEvents()
        End While
        RsRes.Close()

        '----INCREMENT 5
        'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmreportprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width) + iIncrement)
        System.Windows.Forms.Application.DoEvents()
        '----

        'UPGRADE_WARNING: Couldn't resolve default property of object TotStu. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[TOT_STUDENTS]", TotStu)
        'UPGRADE_WARNING: Couldn't resolve default property of object sTotGrades. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[TOT_GRADOS]", sTotGrades)
        'UPGRADE_WARNING: Couldn't resolve default property of object FirstRen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If FirstRen.ToString <> "" Then
            'Tuvo ingles en algun grado
            'UPGRADE_WARNING: Couldn't resolve default property of object FirstRen. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object tempgrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            tempgrade = GetStrGrade(CShort(FirstRen))
            'UPGRADE_WARNING: Couldn't resolve default property of object tempgrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If tempgrade = "Tercero" Then tempgrade = "Tercer"
            'UPGRADE_WARNING: Couldn't resolve default property of object tempgrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If tempgrade = "Primero" Then tempgrade = "Primer"
            'UPGRADE_WARNING: Couldn't resolve default property of object tempgrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object Ingles_Intr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Ingles_Intr = ", Matemáticas y Comprensión de Lectura en Inglés a partir del " & tempgrade & " grado."
            'UPGRADE_WARNING: Couldn't resolve default property of object Ingles_Intr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[INGLES_INTR]", Ingles_Intr)
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[INGLES_INTR]", " y Matemáticas.")
        End If



        If firstaid.ToString <> "" Then
            'Tuvo AID en algun grado
            'UPGRADE_WARNING: Couldn't resolve default property of object firstaid. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object AID_Intr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            AID_Intr = " Los estudiantes del " & GetStrGrade(CShort(firstaid)) & " tomaron la Prueba de Apresto (AID)."
            'UPGRADE_WARNING: Couldn't resolve default property of object AID_Intr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[AID_INTR]", AID_Intr)
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[AID_INTR]", "")
        End If

        If firstPre1.ToString <> "" Then
            'Tuvo PRE1 en algun grado
            'UPGRADE_WARNING: Couldn't resolve default property of object PRE1_Intr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            PRE1_Intr = " Los estudiantes del " & GetStrGrade(CShort(firstPre1)) & " tomaron la Prueba de PRE-1 Destrezas Iniciales de Español y Matemáticas."
            'UPGRADE_WARNING: Couldn't resolve default property of object PRE1_Intr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[PRE1_INTR]", PRE1_Intr)
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[PRE1_INTR]", "")
        End If


        '--
        '----INCREMENT 6
        'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmreportprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width) + iIncrement)
        System.Windows.Forms.Application.DoEvents()
        '----

        'UPGRADE_WARNING: Couldn't resolve default property of object acomodo_tot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If acomodo_tot.ToString <> "" Then
            'UPGRADE_WARNING: Couldn't resolve default property of object acomodo_tot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Select Case CShort(acomodo_tot)

                Case 0
                    'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Informe = Replace(Informe, "[ACOMODO_INTR]", "")
                    'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Informe = Replace(Informe, "[ACOMODO_TOTAL]", CStr(0))
                Case 1
                    'UPGRADE_WARNING: Couldn't resolve default property of object Acomodo_Intr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Acomodo_Intr = " Se ofreció Acomodo Razonable a un estudiante, cuyo resultado fue procesado por separado."
                    'UPGRADE_WARNING: Couldn't resolve default property of object Acomodo_Intr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Informe = Replace(Informe, "[ACOMODO_INTR]", Acomodo_Intr)
                    'UPGRADE_WARNING: Couldn't resolve default property of object acomodo_tot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Informe = Replace(Informe, "[ACOMODO_TOTAL]", acomodo_tot)
                Case Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object acomodo_tot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object Acomodo_Intr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Acomodo_Intr = " Se ofreció Acomodo Razonable a un total de " & GetStrNumber(CShort(acomodo_tot)) & " estudiantes, cuyos resultados fueron procesados por separado."
                    'UPGRADE_WARNING: Couldn't resolve default property of object Acomodo_Intr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Informe = Replace(Informe, "[ACOMODO_INTR]", Acomodo_Intr)
                    'UPGRADE_WARNING: Couldn't resolve default property of object acomodo_tot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Informe = Replace(Informe, "[ACOMODO_TOTAL]", acomodo_tot)
            End Select
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[ACOMODO_INTR]", "")
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[ACOMODO_TOTAL]", CStr(0))
        End If

        'UPGRADE_WARNING: Couldn't resolve default property of object Ausente_Tot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If Ausente_Tot.ToString <> "" Then
            Select Case Ausente_Tot
                Case 0
                    'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Informe = Replace(Informe, "[AUSENTE_INTR]", " El Equipo Examinador reportó que no hubo estudiantes ausentes ese día.")
                Case 1
                    'UPGRADE_WARNING: Couldn't resolve default property of object Ausente_Intr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Ausente_Intr = " El Equipo Examinador reportó un estudiante ausente ese día."
                    'UPGRADE_WARNING: Couldn't resolve default property of object Ausente_Intr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Informe = Replace(Informe, "[AUSENTE_INTR]", Ausente_Intr)
                Case Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object Ausente_Tot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object Ausente_Intr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Ausente_Intr = " El Equipo Examinador reportó " & GetStrNumber(CShort(Ausente_Tot)) & " estudiantes ausentes ese día."
                    'UPGRADE_WARNING: Couldn't resolve default property of object Ausente_Intr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Informe = Replace(Informe, "[AUSENTE_INTR]", Ausente_Intr)
            End Select
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[AUSENTE_INTR]", " El Equipo Examinador reportó que no hubo estudiantes ausentes ese día.")
        End If

        'UPGRADE_WARNING: Couldn't resolve default property of object repo_tot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If repo_tot.ToString <> "" Then
            Select Case repo_tot
                Case 0
                    'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Informe = Replace(Informe, "[REPO_INTR]", "")
                Case 1
                    'UPGRADE_WARNING: Couldn't resolve default property of object repo_date. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object Repo_Intr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Repo_Intr = " Se administró la reposición a un estudiante el " & repo_date & " y su resultado fue incluído con los de su salón hogar."
                    'UPGRADE_WARNING: Couldn't resolve default property of object Repo_Intr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Informe = Replace(Informe, "[REPO_INTR]", Repo_Intr)
                Case Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object repo_date. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object repo_tot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object Repo_Intr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Repo_Intr = " Se administró la reposición a " & GetStrNumber(CShort(repo_tot)) & " estudiantes el " & repo_date & " y sus resultados fueron incluidos con los de su salón hogar."
                    'UPGRADE_WARNING: Couldn't resolve default property of object Repo_Intr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Informe = Replace(Informe, "[REPO_INTR]", Repo_Intr)
            End Select
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[REPO_INTR]", "")
        End If

        '----INCREMENT 7
        'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmreportprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width) + iIncrement)
        System.Windows.Forms.Application.DoEvents()
        '----

        If isPRE1 = True Then
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[AID_PRUEBA_NOMBRE]", "PRE-1")
            'UPGRADE_WARNING: Couldn't resolve default property of object firstaid. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ElseIf firstaid.ToString <> "" Then
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[AID_PRUEBA_NOMBRE]", "Apresto")
        End If

        'Crear parrafo para el AID
        'UPGRADE_WARNING: Couldn't resolve default property of object firstaid. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Dim DomArr(11) As Object
        If firstaid.ToString <> "" Then

            'UPGRADE_WARNING: Couldn't resolve default property of object AID_RES_TITLE. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            AID_RES_TITLE = "<B>Prueba de Apresto (Kindergarten)</B>"
            'UPGRADE_WARNING: Couldn't resolve default property of object AID_RES_TITLE. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[AID_RES_TITLE]", AID_RES_TITLE)

            'UPGRADE_WARNING: Couldn't resolve default property of object Semester. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Semester = 1 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object AID_RES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                AID_RES = "La Prueba de Apresto nos indica cuán preparados están los estudiantes que terminaron el " & GetStrGrade(CShort(0)) & " para iniciarse en la lectura y realizar las tareas del Primer grado."
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object firstaid. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object AID_RES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                AID_RES = "La Prueba de Apresto nos indica cuán preparados están los estudiantes que cursan el " & GetStrGrade(CShort(firstaid)) & " para iniciarse en la lectura y realizar las tareas del Primer grado en el próximo año escolar."
            End If

            'UPGRADE_WARNING: Couldn't resolve default property of object firstaid. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sQuery = "SELECT Resultados.resg_id, Resultados.resg_rep_id, Resultados.resg_Grado, Resultados.resg_Section " & "From Resultados " & "WHERE (((Resultados.resg_rep_id)=" & dRepID & ") AND ((Resultados.resg_Grado)=" & firstaid & "));"

            Rs.Open(sQuery, Cn, 3, 3)
            'UPGRADE_WARNING: Couldn't resolve default property of object AidTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            AidTot = 0
            'UPGRADE_WARNING: Couldn't resolve default property of object DominioTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            DominioTot = 0
            'UPGRADE_WARNING: Couldn't resolve default property of object Destreza. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Destreza = ""
            While Not Rs.EOF
                'UPGRADE_WARNING: Couldn't resolve default property of object firstaid. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sQuery = "SELECT Resultados.resg_Grado, Resultados.resg_Section, ResEst.rese_nombre, ResEst.rese_a1, ResEst.rese_a2, ResEst.rese_a3, ResEst.rese_a4, ResEst.rese_a5, ResEst.rese_a6, ResEst.rese_a7, ResEst.rese_a8, ResEst.rese_a9, ResEst.rese_a10 " & "FROM ResEst INNER JOIN Resultados ON ResEst.resg_id = Resultados.resg_id " & "Where ((Resultados.resg_rep_id = " & dRepID & ") And (Resultados.resg_Grado = " & firstaid & ") AND (Resultados.resg_id = " & Rs.Fields("resg_id").Value & ")) " & "ORDER BY Resultados.resg_Section "

                RsRes.Open(sQuery, Cn, 3, 3)

                'UPGRADE_WARNING: Couldn't resolve default property of object AidTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                AidTot = AidTot + RsRes.RecordCount
                'UPGRADE_WARNING: Couldn't resolve default property of object CurrAidTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                CurrAidTot = RsRes.RecordCount
                For z = 1 To 10
                    'UPGRADE_WARNING: Couldn't resolve default property of object z. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(z). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    DomArr(z) = 0
                Next z

                'Sacar cuantos tuvieron dominio en 7 o mas
                While Not RsRes.EOF
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrDomTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    CurrDomTot = 0
                    If RsRes.Fields("rese_a1").Value <= 1 Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrDomTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        CurrDomTot = CurrDomTot + 1
                        'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        DomArr(1) = DomArr(1) + 1
                    End If
                    If RsRes.Fields("rese_a2").Value <= 1 Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrDomTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        CurrDomTot = CurrDomTot + 1
                        'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        DomArr(2) = DomArr(2) + 1
                    End If
                    If RsRes.Fields("rese_a3").Value <= 5 Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrDomTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        CurrDomTot = CurrDomTot + 1
                        'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        DomArr(3) = DomArr(3) + 1
                    End If
                    If RsRes.Fields("rese_a4").Value <= 1 Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrDomTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        CurrDomTot = CurrDomTot + 1
                        'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        DomArr(4) = DomArr(4) + 1
                    End If
                    If RsRes.Fields("rese_a5").Value <= 1 Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrDomTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        CurrDomTot = CurrDomTot + 1
                        'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(5). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        DomArr(5) = DomArr(5) + 1
                    End If
                    If RsRes.Fields("rese_a6").Value <= 1 Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrDomTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        CurrDomTot = CurrDomTot + 1
                        'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(6). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        DomArr(6) = DomArr(6) + 1
                    End If
                    If RsRes.Fields("rese_a7").Value <= 1 Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrDomTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        CurrDomTot = CurrDomTot + 1
                        'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(7). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        DomArr(7) = DomArr(7) + 1
                    End If
                    If RsRes.Fields("rese_a8").Value <= 1 Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrDomTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        CurrDomTot = CurrDomTot + 1
                        'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(8). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        DomArr(8) = DomArr(8) + 1
                    End If
                    If RsRes.Fields("rese_a9").Value <= 1 Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrDomTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        CurrDomTot = CurrDomTot + 1
                        'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(9). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        DomArr(9) = DomArr(9) + 1
                    End If
                    If RsRes.Fields("rese_a10").Value <= 1 Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrDomTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        CurrDomTot = CurrDomTot + 1
                        'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(10). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        DomArr(10) = DomArr(10) + 1
                    End If
                    'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    X = RsRes.Fields("rese_nombre").Value
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrDomTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If CurrDomTot >= 7 Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object DominioTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        DominioTot = DominioTot + 1
                    End If
                    RsRes.MoveNext()
                    System.Windows.Forms.Application.DoEvents()
                End While


                'Destreza 1
                'UPGRADE_WARNING: Couldn't resolve default property of object MaxDom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                MaxDom = 0
                'UPGRADE_WARNING: Couldn't resolve default property of object MaxDomTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                MaxDomTot = 0
                For i = 1 To 10
                    'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object MaxDomTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If DomArr(i) > MaxDomTot Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object MaxDom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        MaxDom = i
                        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object MaxDomTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        MaxDomTot = DomArr(i)
                    End If
                Next i

                'UPGRADE_WARNING: Couldn't resolve default property of object CurrAidTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object MaxDomTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                MaxDomTot = System.Math.Round((MaxDomTot / CurrAidTot) * 100, 0) ''a veces da un OverFlow
                'UPGRADE_WARNING: Couldn't resolve default property of object DomDesc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                DomDesc = GetAIDDesc(MaxDom)
                'UPGRADE_WARNING: Couldn't resolve default property of object DomDesc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object MaxDomTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object firstaid. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object Destreza. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                Destreza = Destreza & "<br><br>En el <b><u>" & GetStrGrade(CShort(firstaid)) & "-" & Rs.Fields("resg_section").Value & "</b></u>, un " & MaxDomTot & "% de los estudiantes demostró dominar la destreza de <U>" & DomDesc & "</U>"

                'Destreza 2
                'UPGRADE_WARNING: Couldn't resolve default property of object MaxDom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(MaxDom). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                DomArr(MaxDom) = 0
                'UPGRADE_WARNING: Couldn't resolve default property of object MaxDom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                MaxDom = 0
                'UPGRADE_WARNING: Couldn't resolve default property of object MaxDomTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                MaxDomTot = 0
                For i = 1 To 10
                    'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object MaxDomTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If DomArr(i) > MaxDomTot Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object MaxDom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        MaxDom = i
                        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object DomArr(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object MaxDomTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        MaxDomTot = DomArr(i)
                    End If
                Next i
                'UPGRADE_WARNING: Couldn't resolve default property of object CurrAidTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object MaxDomTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                MaxDomTot = System.Math.Round((MaxDomTot / CurrAidTot) * 100, 0)
                'UPGRADE_WARNING: Couldn't resolve default property of object DomDesc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                DomDesc = GetAIDDesc(MaxDom)
                'UPGRADE_WARNING: Couldn't resolve default property of object DomDesc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object MaxDomTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object Destreza. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                Destreza = Destreza & "  y un " & MaxDomTot & "%, la destreza de <U>" & DomDesc & "</U>."

                Rs.MoveNext()
                RsRes.Close()
                System.Windows.Forms.Application.DoEvents()
            End While
            Rs.Close()
            'Poner Dominio Total y Total de Estudiantes
            'UPGRADE_WARNING: Couldn't resolve default property of object DominioTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object AidTot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object AID_RES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            AID_RES = AID_RES & "<br><br><b><u>De los " & AidTot & " estudiantes evaluados, " & DominioTot & " demostraron dominio en siete o más de las diez destrezas evaluadas.</b></u>"
            'UPGRADE_WARNING: Couldn't resolve default property of object Destreza. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object AID_RES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            AID_RES = AID_RES & Destreza

            'UPGRADE_WARNING: Couldn't resolve default property of object LastParrafo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LastParrafo = "<div align=justify><p class=MsoHeading7 style='text-align:justify'><span lang=ES-PR style='font-family:Arial;mso-ansi-language:ES-PR;mso-bidi-font-weight:bold'>Si un estudiante muestra dificultad en una o más destrezas, se le deben proveer actividades adicionales, procurando el desarrollo apropiado de las mismas.  Cuando un estudiante muestra rezago en tres o más de las diez destrezas evaluadas, recomendamos una evaluación más detallada, buscando identificar necesidades específicas con el propósito de proveerle la ayuda apropiada e intervención temprana.<o:p></span></p></div>"
            'UPGRADE_WARNING: Couldn't resolve default property of object LastParrafo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object AID_RES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            AID_RES = AID_RES & "<BR><BR>" & LastParrafo

            'UPGRADE_WARNING: Couldn't resolve default property of object AID_RES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[AID_RES]", AID_RES)

        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[AID_RES]", "")
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[AID_RES_TITLE]", "")
        End If






        Dim rsDes As New ADODB.Recordset
        Dim pre1Arr(10, 10) As Object
        If firstPre1 <> "" Then
            'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sQuery = "select * from destrezas where d_cl_id = 69"
            rsDes.Open(sQuery, Cn, 3, 3)

            For pre1x = 1 To 10
                'UPGRADE_WARNING: Couldn't resolve default property of object pre1x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object pre1Arr(pre1x, 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                pre1Arr(pre1x, 0) = rsDes.Fields("d_" & pre1x & "_nombre").Value
            Next pre1x

            'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sQuery = "SELECT Resultados.resg_id, Resultados.resg_rep_id, Resultados.resg_Grado, Resultados.resg_Section " & "From Resultados " & "WHERE (((Resultados.resg_rep_id)=" & dRepID & ") AND ((Resultados.resg_Grado)=" & firstPre1 & ")) order by resg_section"

            Rs.Open(sQuery, Cn, 3, 3)

            'UPGRADE_WARNING: Couldn't resolve default property of object preSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            preSec = 1
            'UPGRADE_WARNING: Couldn't resolve default property of object totalStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            totalStud = 0
            While Not Rs.EOF
                sQuery = "select ResEst.* from  ResEst INNER JOIN Resultados ON dbo.ResEst.resg_id = Resultados.resg_id " & " Where (Resultados.resg_Grado = " & firstPre1 & ") AND " & " resultados.resg_id = " & Rs.Fields("resg_id").Value & " ORDER BY Resultados.resg_Section"

                RsRes.Open(sQuery, Cn, 3, 3)

                'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                TotStud = 0
                'UPGRADE_WARNING: Couldn't resolve default property of object preSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object pre1Arr(0, preSec). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                pre1Arr(0, preSec) = Rs.Fields("resg_section").Value
                While Not RsRes.EOF
                    For preDes = 1 To 10
                        'UPGRADE_WARNING: Couldn't resolve default property of object preDes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        If RsRes.Fields("rese_a" & preDes).Value < rsDes.Fields("d_" & preDes & "_minAvg").Value Then
                            'UPGRADE_WARNING: Couldn't resolve default property of object preSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: Couldn't resolve default property of object preDes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: Couldn't resolve default property of object pre1Arr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: Couldn't resolve default property of object pre1Arr(preDes, preSec). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            pre1Arr(preDes, preSec) = Val(pre1Arr(preDes, preSec)) + 1
                        End If
                    Next preDes
                    'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    TotStud = TotStud + 1

                    RsRes.MoveNext()
                End While
                RsRes.Close()
                'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object totalStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                totalStud = totalStud + TotStud
                'Calculo el total
                For preDes = 1 To 10
                    'UPGRADE_WARNING: Couldn't resolve default property of object preSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object preDes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object pre1Arr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object pre1Arr(preDes, preSec). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    pre1Arr(preDes, preSec) = Val(pre1Arr(preDes, preSec)) / TotStud
                Next preDes

                'UPGRADE_WARNING: Couldn't resolve default property of object preSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                preSec = preSec + 1
                Rs.MoveNext()
            End While
            rsDes.Close()
            Rs.Close()
            'UPGRADE_NOTE: Object rsDes may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            rsDes = Nothing
            'UPGRADE_WARNING: Couldn't resolve default property of object preSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            preSec = preSec - 1

            'UPGRADE_WARNING: Couldn't resolve default property of object totalStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object Pre1Data. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Pre1Data = Replace(Pre1Data, "[TOT_STUD]", totalStud)
            'UPGRADE_WARNING: Couldn't resolve default property of object preSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If preSec = 1 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object Pre1Data. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                Pre1Data = Replace(Pre1Data, "[TOT_GRP]", "un grupo")
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object preSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object Pre1Data. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                Pre1Data = Replace(Pre1Data, "[TOT_GRP]", preSec & " grupos")
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object Pre1Data. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Pre1Data = Replace(Pre1Data, "[PRE1_GRADO]", GetStrGrade(CShort(firstPre1)))

            'UPGRADE_WARNING: Couldn't resolve default property of object preTable. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            preTable = preTable & "<p class=MsoNormal align=center style='text-align:center'><span lang=ES-PR style='font-size:14.0pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'><b>PORCIENTO DE ESTUDIANTES QUE DOMINARON CADA DESTREZA EN LA <BR>PRUEBA PRE-1</b></p></span><BR><BR>"
            'UPGRADE_WARNING: Couldn't resolve default property of object preTable. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            preTable = preTable & "<table width=60% align=center border=1 cellpadding=5 cellspacing=0 bordercolor=black>"
            'UPGRADE_WARNING: Couldn't resolve default property of object preTable. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            preTable = preTable & "<tr BGCOLOR=#CCCCCC><td align=left><p class=MsoBodyText><b>GRUPOS:</b></p></td>"
            'UPGRADE_WARNING: Couldn't resolve default property of object preSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            For preX = 1 To preSec
                'UPGRADE_WARNING: Couldn't resolve default property of object preX. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object pre1Arr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object preTable. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                preTable = preTable & "<td align=center><p class=MsoBodyText><b>" & pre1Arr(0, preX) & "</b></td>"
            Next preX
            'UPGRADE_WARNING: Couldn't resolve default property of object preTable. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            preTable = preTable & "</tr>"

            For preX = 1 To 10
                'UPGRADE_WARNING: Couldn't resolve default property of object preTable. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                preTable = preTable & "<tr>"
                'UPGRADE_WARNING: Couldn't resolve default property of object preX. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object pre1Arr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object preTable. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                preTable = preTable & "<td align=left BGCOLOR=#E6E6E6><p class=MsoBodyText>" & pre1Arr(preX, 0) & "</td>"
                'UPGRADE_WARNING: Couldn't resolve default property of object preSec. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                For preY = 1 To preSec
                    'UPGRADE_WARNING: Couldn't resolve default property of object preY. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object preX. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object pre1Arr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object pTotal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    pTotal = System.Math.Round(pre1Arr(preX, preY), 3) * 100
                    'UPGRADE_WARNING: Couldn't resolve default property of object pTotal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If CShort(pTotal) < 80 Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        bgc = "#ffc4c4"
                    Else
                        'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        bgc = "#ffffff"
                    End If
                    'UPGRADE_WARNING: Couldn't resolve default property of object pTotal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object bgc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object preTable. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    preTable = preTable & "<td align=center bgcolor=" & bgc & "><p class=MsoBodyText>" & pTotal & "</p></td>"
                Next preY
                'UPGRADE_WARNING: Couldn't resolve default property of object preTable. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                preTable = preTable & "</tr>"
            Next preX
            'UPGRADE_WARNING: Couldn't resolve default property of object preTable. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            preTable = preTable & "</table>"
            'UPGRADE_WARNING: Couldn't resolve default property of object Get50Footer(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object preTable. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            preTable = preTable & Get50Footer("<p class=MsoBodyText align=center><b>Menos del 80% =</b></p>")
            'preTable = preTable & "<Br><Br><table width=90% align=center border=0>"
            'preTable = preTable & "<tr><td align=center>Menos del 80% = </td></tr></table>"

            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[PRE1_RES_TITLE]", "Resultados del " & GetStrGrade(CShort(firstPre1)))
            'UPGRADE_WARNING: Couldn't resolve default property of object Pre1Data. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[PRE1_RES]", Pre1Data)
            'UPGRADE_WARNING: Couldn't resolve default property of object preTable. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[PRE1_TABLE]", preTable)
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[PRE1_RES]", "")
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[PRE1_RES_TITLE]", "")
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[PRE1_TABLE]", "")
        End If


        '----INCREMENT 8
        'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmreportprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width) + iIncrement)
        frmreportprocess.lblStatus.Text = "Building NV paragraph..."
        frmreportprocess.lblStatus.Refresh()
        System.Windows.Forms.Application.DoEvents()
        '----

        'UPGRADE_WARNING: Couldn't resolve default property of object CreateObservaciones(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object observaciontable. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        observaciontable = CreateObservaciones(dRepID, COND_RES, INST_RES, CONDUCTA_RES)
        'UPGRADE_WARNING: Couldn't resolve default property of object observaciontable. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[OBS_TABLE]", observaciontable)
        'UPGRADE_WARNING: Couldn't resolve default property of object COND_RES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[COND_RES]", COND_RES & ". ")
        'UPGRADE_WARNING: Couldn't resolve default property of object INST_RES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[INST_RES]", INST_RES & ". ")
        'UPGRADE_WARNING: Couldn't resolve default property of object CONDUCTA_RES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[CONDUCTA_RES]", CONDUCTA_RES & ". ")

        'Configurar parrafo de  No Verbal
        'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Bajo = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Prom = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Sobre = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        TotStud = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d1 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d2 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d3 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d4 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d5 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d6 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d7 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d8 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d9 = 0
        BajoTotStud = 0
        PromTotStud = 0
        SobreTotStud = 0

        'UPGRADE_WARNING: Couldn't resolve default property of object GetStanineProm(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        X = GetStanineProm(dRepID, "N", 0, Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9, , , BajoTotStud, PromTotStud, SobreTotStud)
        'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[NV_SOBRE]", Sobre & "%")
        'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[NV_BAJO]", Bajo & "%")
        'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[NV_PROM]", Prom & "%")
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[NV_SOBRE_EQ]", CStr(SobreTotStud))
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[NV_BAJO_EQ]", CStr(BajoTotStud))
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[NV_PROM_EQ]", CStr(PromTotStud))
        'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[NV_SOBRE_PROM]", (Sobre + Prom) & "%")
        'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[NV_TOT]", TotStud)
        'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[N1]", d1)
        'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[N2]", d2)
        'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[N3]", d3)
        'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[N4]", d4)
        'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[N5]", d5)
        'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[N6]", d6)
        'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[N7]", d7)
        'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[N8]", d8)
        'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[N9]", d9)
        '--

        '----INCREMENT 9
        'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmreportprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width) + iIncrement)
        frmreportprocess.lblStatus.Text = "Building MAT paragraph..."
        frmreportprocess.lblStatus.Refresh()
        System.Windows.Forms.Application.DoEvents()
        '----


        'Configurar parrafo de  Matematicas
        'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Bajo = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Prom = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Sobre = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        TotStud = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d1 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d2 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d3 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d4 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d5 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d6 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d7 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d8 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d9 = 0
        BajoTotStud = 0
        PromTotStud = 0
        SobreTotStud = 0

        'UPGRADE_WARNING: Couldn't resolve default property of object GetStanineProm(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        X = GetStanineProm(dRepID, "M", 0, Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9, , , BajoTotStud, PromTotStud, SobreTotStud)
        'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[MAT_SOBRE]", Sobre & "%")
        'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[MAT_BAJO]", Bajo & "%")
        'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[MAT_PROM]", Prom & "%")
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[MAT_SOBRE_EQ]", CStr(SobreTotStud))
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[MAT_BAJO_EQ]", CStr(BajoTotStud))
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[MAT_PROM_EQ]", CStr(PromTotStud))
        'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[MAT_SOBRE_PROM]", (Sobre + Prom) & "%")
        'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[MAT_TOT]", TotStud)
        'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[M1]", d1)
        'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[M2]", d2)
        'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[M3]", d3)
        'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[M4]", d4)
        'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[M5]", d5)
        'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[M6]", d6)
        'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[M7]", d7)
        'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[M8]", d8)
        'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[M9]", d9)
        '--
        '----INCREMENT 10
        'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmreportprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width) + iIncrement)
        frmreportprocess.lblStatus.Text = "Building REN paragraph..."
        frmreportprocess.lblStatus.Refresh()

        System.Windows.Forms.Application.DoEvents()
        '----

        'Configurar parrafo de  INGLES
        'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Bajo = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Prom = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Sobre = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        TotStud = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d1 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d2 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d3 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d4 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d5 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d6 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d7 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d8 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d9 = 0
        BajoTotStud = 0
        PromTotStud = 0
        SobreTotStud = 0

        'UPGRADE_WARNING: Couldn't resolve default property of object GetStanineProm(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        X = GetStanineProm(dRepID, "R", 0, Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9, , , BajoTotStud, PromTotStud, SobreTotStud)
        'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[REN_SOBRE]", Sobre & "%")
        'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[REN_BAJO]", Bajo & "%")
        'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[REN_PROM]", Prom & "%")
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[REN_SOBRE_EQ]", CStr(SobreTotStud))
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[REN_BAJO_EQ]", CStr(BajoTotStud))
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[REN_PROM_EQ]", CStr(PromTotStud))
        'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[REN_TOT]", TotStud)
        'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[REN_SOBRE_PROM]", (Sobre + Prom) & "%")
        'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[R1]", d1)
        'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[R2]", d2)
        'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[R3]", d3)
        'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[R4]", d4)
        'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[R5]", d5)
        'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[R6]", d6)
        'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[R7]", d7)
        'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[R8]", d8)
        'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[R9]", d9)
        '--
        '----INCREMENT 11
        'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmreportprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width) + iIncrement)
        frmreportprocess.lblStatus.Text = "Building LES paragraph..."
        frmreportprocess.lblStatus.Refresh()

        System.Windows.Forms.Application.DoEvents()
        '----

        'Configurar parrafo de  LES
        'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Bajo = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Prom = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Sobre = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        TotStud = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d1 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d2 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d3 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d4 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d5 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d6 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d7 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d8 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        d9 = 0
        BajoTotStud = 0
        PromTotStud = 0
        SobreTotStud = 0

        'UPGRADE_WARNING: Couldn't resolve default property of object GetStanineProm(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        X = GetStanineProm(dRepID, "L", 0, Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9, , , BajoTotStud, PromTotStud, SobreTotStud)
        'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[LES_SOBRE]", Sobre & "%")
        'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[LES_BAJO]", Bajo & "%")
        'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[LES_PROM]", Prom & "%")
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[LES_SOBRE_EQ]", CStr(SobreTotStud))
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[LES_BAJO_EQ]", CStr(BajoTotStud))
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[LES_PROM_EQ]", CStr(PromTotStud))
        'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[LES_TOT]", TotStud)
        'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[LES_SOBRE_PROM]", (Sobre + Prom) & "%")
        'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[L1]", d1)
        'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[L2]", d2)
        'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[L3]", d3)
        'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[L4]", d4)
        'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[L5]", d5)
        'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[L6]", d6)
        'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[L7]", d7)
        'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[L8]", d8)
        'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[L9]", d9)
        '--
        '----INCREMENT 12
        'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmreportprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width) + iIncrement)
        frmreportprocess.lblStatus.Text = "Searching for outstanding students..."
        frmreportprocess.lblStatus.Refresh()

        System.Windows.Forms.Application.DoEvents()
        '----

        'Estudiantes Destacados
        sQuery = "SELECT Resultados.resg_Grado, ResEst.rese_nombre, ResEst.rese_coc_pot, ResEst.rese_coc_apr " & "FROM ResEst INNER JOIN Resultados ON ResEst.resg_id = Resultados.resg_id " & "Where (((ResEst.rese_coc_pot) >= 113) And ((ResEst.rese_coc_apr) >= 113) And ((Resultados.resg_rep_id) = " & dRepID & ")) " & "ORDER BY Resultados.resg_Grado, ResEst.rese_nombre "

        Rs.Open(sQuery, Cn, 3, 3)

        'UPGRADE_WARNING: Couldn't resolve default property of object EST_DESTACADOS. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        EST_DESTACADOS = ""
        'UPGRADE_WARNING: Couldn't resolve default property of object CurrGrado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        CurrGrado = ""
        While Not Rs.EOF
            If CurrGrado <> Rs.Fields("resg_grado").Value.ToString Then
                'UPGRADE_WARNING: Couldn't resolve default property of object EST_DESTACADOS. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                EST_DESTACADOS = EST_DESTACADOS & "<BR><b>" & GetStrGrade(Rs.Fields("resg_grado").Value) & "</b><BR><BR>"
                'UPGRADE_WARNING: Couldn't resolve default property of object CurrGrado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                CurrGrado = Rs.Fields("resg_grado").Value
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object EST_DESTACADOS. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            EST_DESTACADOS = EST_DESTACADOS & Rs.Fields("rese_nombre").Value & "<BR>"
            Rs.MoveNext()
            System.Windows.Forms.Application.DoEvents()
        End While
        Rs.Close()

        'UPGRADE_WARNING: Couldn't resolve default property of object EST_DESTACADOS. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[EST_DESTACADOS]", EST_DESTACADOS)
        '--
        '----INCREMENT 13
        'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmreportprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width) + iIncrement)
        frmreportprocess.lblStatus.Text = "Building Recommendations..."
        frmreportprocess.lblStatus.Refresh()

        System.Windows.Forms.Application.DoEvents()
        '----

        '============Create Recomendaciones=======================

        sQuery = "SELECT observacion.ob_desc, observacion.ob_id " & "FROM (REP_OBSERVACIONES RIGHT JOIN Resultados ON REP_OBSERVACIONES.ro_resg_id = Resultados.resg_id) LEFT JOIN observacion ON REP_OBSERVACIONES.ro_selectedid = observacion.ob_id " & "Where (((Resultados.resg_rep_id) = " & dRepID & ") And ((observacion.ob_type) = 'r')) " & "ORDER BY observacion.ob_id"

        'nuevo query para que traiga todas las recomendaciones y que ellos quiten las que no aplican
        sQuery = "SELECT observacion.ob_desc, observacion.ob_id " & "FROM observacion  " & "Where observacion.ob_type = 'r' " & "ORDER BY observacion.ob_id"


        Rs.Open(sQuery, Cn, 3, 3)
        'UPGRADE_WARNING: Couldn't resolve default property of object RECOM. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        RECOM = ""
        'UPGRADE_WARNING: Couldn't resolve default property of object iCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        iCtr = 1
        While Not Rs.EOF
            'UPGRADE_WARNING: Couldn't resolve default property of object GetRecomendacionLine(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object RECOM_LINE. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            RECOM_LINE = GetRecomendacionLine()
            'UPGRADE_WARNING: Couldn't resolve default property of object iCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object RECOM_LINE. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            RECOM_LINE = Replace(RECOM_LINE, "[NO]", iCtr)
            'UPGRADE_WARNING: Couldn't resolve default property of object RECOM_LINE. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            RECOM_LINE = Replace(RECOM_LINE, "[RECOM]", Rs.Fields("ob_desc").Value)
            'UPGRADE_WARNING: Couldn't resolve default property of object RECOM_LINE. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object RECOM. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            RECOM = RECOM & RECOM_LINE
            Rs.MoveNext()
            'UPGRADE_WARNING: Couldn't resolve default property of object iCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            iCtr = iCtr + 1
            System.Windows.Forms.Application.DoEvents()
        End While
        Rs.Close()

        'UPGRADE_WARNING: Couldn't resolve default property of object RECOM. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[RECOMENDACIONES]", RECOM)
        '----INCREMENT 14
        'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmreportprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width) + iIncrement)
        frmreportprocess.lblStatus.Text = "Building Academic Potential..."
        frmreportprocess.lblStatus.Refresh()
        System.Windows.Forms.Application.DoEvents()
        '----

        '--

        '=================------POTENCIAL ACADEMICO -----========================
        'UPGRADE_WARNING: Couldn't resolve default property of object Potencial_Academico(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[POTENCIAL_ACADEMICO]", Potencial_Academico(dRepID))
        '--
        '----INCREMENT 15
        'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmreportprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width) + iIncrement)
        System.Windows.Forms.Application.DoEvents()
        '----

        '=================-----APRESTO TABLE -----========================
        If Len(firstaid) > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object Table_APRESTO(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[APRESTO_TABLE]", Table_APRESTO(dRepID))
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Informe = Replace(Informe, "[APRESTO_TABLE]", "")
        End If
        '----INCREMENT 16
        'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmreportprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width) + iIncrement)
        frmreportprocess.lblStatus.Text = "Building Comparison Table..."
        frmreportprocess.lblStatus.Refresh()
        System.Windows.Forms.Application.DoEvents()
        '----

        '--

        '=================-----COMPARACION TABLE -----========================
        'UPGRADE_WARNING: Couldn't resolve default property of object Table_COMPARACION(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[COMP_TABLE]", Table_COMPARACION(dRepID))
        '--
        '----INCREMENT 17
        'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmreportprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width) + iIncrement)
        frmreportprocess.lblStatus.Text = "Building LES Table..."
        frmreportprocess.lblStatus.Refresh()
        System.Windows.Forms.Application.DoEvents()
        '----

        '--------------------DESTREZA LES TABLE---------------------------------
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[LES_TABLE]", TABLE_LES(dRepID))
        '--
        '----INCREMENT 18
        'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmreportprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width) + iIncrement)
        frmreportprocess.lblStatus.Text = "Building REN Table..."
        frmreportprocess.lblStatus.Refresh()
        System.Windows.Forms.Application.DoEvents()
        '----

        '--------------------DESTREZA REN TABLE---------------------------------
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[REN_TABLE]", TABLE_REN2(dRepID))
        '--
        '----INCREMENT 19
        'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmreportprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width) + iIncrement)
        frmreportprocess.lblStatus.Text = "Building MAT Table..."
        frmreportprocess.lblStatus.Refresh()
        System.Windows.Forms.Application.DoEvents()
        '----

        '--------------------DESTREZA MAT TABLE---------------------------------
        'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Informe = Replace(Informe, "[MAT_TABLE]", TABLE_MAT2(dRepID))
        '--
        '----INCREMENT 20
        'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmreportprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width) + iIncrement)
        frmreportprocess.lblStatus.Text = "Finalizing Report..."
        frmreportprocess.lblStatus.Refresh()
        System.Windows.Forms.Application.DoEvents()
        '----

        CreateFile(DestDir & DocName, Informe)
        'UPGRADE_WARNING: Couldn't resolve default property of object FooterLine. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object InformeFooter. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        InformeFooter = Replace(InformeFooter, "[FOOTER_LINE]", FooterLine)
        '----INCREMENT 21
        'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmreportprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width) + iIncrement)
        System.Windows.Forms.Application.DoEvents()
        '----

        'UPGRADE_WARNING: Couldn't resolve default property of object DestDirlist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        CreateFile(DestDirlist & "header.htm", InformeFooter)
        '----INCREMENT 22
        'UPGRADE_WARNING: Couldn't resolve default property of object iIncrement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmreportprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmreportprocess.Shape1.Width) + iIncrement)
        System.Windows.Forms.Application.DoEvents()



        'UPGRADE_WARNING: Couldn't resolve default property of object firstaid. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'


        '----

    End Sub
	
	
	Sub CreateT1_Dist_Report()
		Dim WordPath As Object
		Dim sColData As Object
		Dim sFromTo As Object
		Dim DestDirlist As Object
		Dim informelist As Object
		Dim sTotCol As Object
		Dim sTotStud As Object
		Dim X As Object
		Dim d9 As Object
		Dim d8 As Object
		Dim d7 As Object
		Dim d6 As Object
		Dim d5 As Object
		Dim d4 As Object
		Dim d3 As Object
		Dim d2 As Object
		Dim d1 As Object
		Dim TotStud As Object
		Dim Sobre As Object
		Dim Prom As Object
		Dim Bajo As Object
		Dim InformeFooter As Object
		Dim ConsultantsPath As Object
		Dim sQuery As String
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		Dim RsRep As ADODB.Recordset
		Dim RsRes As ADODB.Recordset
		Dim RsEst As ADODB.Recordset
		Dim Informe As Object
		Dim FromGrade As String
		Dim ToGrade As String
		Dim DestDir As String
		Dim DocName As String
		Dim isPRE1 As Boolean
		Dim Pre1Data As Object
		Dim firstPre1 As String 'para guardar el grado que tiene pre1
		Dim BajoTotStud As Short
		Dim PromTotStud As Short
		Dim SobreTotStud As Short
		Dim hShell As Object
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ConsultantsPath = Config.ConsultantsPath
		'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FiletoVar(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = FiletoVar(ConsultantsPath & "template_titulo1_distribucion.htm")
		'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FiletoVar(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object InformeFooter. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		InformeFooter = FiletoVar(ConsultantsPath & "template_titulo1_distribucion_files\header.htm")
		'Configurar parrafo de  Matematicas
		'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Bajo = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Prom = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Sobre = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TotStud = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d1 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d2 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d3 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d4 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d5 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d6 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d7 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d8 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d9 = 0
		BajoTotStud = 0
		PromTotStud = 0
		SobreTotStud = 0
		
		'UPGRADE_WARNING: Couldn't resolve default property of object GetStaninePromT1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = GetStaninePromT1("", "M", Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9,  ,  , BajoTotStud, PromTotStud, SobreTotStud)
		'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[MAT_SOBRE]", Sobre & "%")
		'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[MAT_BAJO]", Bajo & "%")
		'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[MAT_PROM]", Prom & "%")
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[MAT_SOBRE_EQ]", CStr(SobreTotStud))
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[MAT_BAJO_EQ]", CStr(BajoTotStud))
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[MAT_PROM_EQ]", CStr(PromTotStud))
		'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[MAT_SOBRE_PROM]", (Sobre + Prom) & "%")
		'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[MAT_TOT]", TotStud)
		'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[M1]", d1)
		'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[M2]", d2)
		'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[M3]", d3)
		'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[M4]", d4)
		'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[M5]", d5)
		'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[M6]", d6)
		'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[M7]", d7)
		'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[M8]", d8)
		'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[M9]", d9)
		'--
		
		System.Windows.Forms.Application.DoEvents()
		'----
		
		'Configurar parrafo de  INGLES
		'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Bajo = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Prom = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Sobre = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TotStud = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d1 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d2 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d3 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d4 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d5 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d6 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d7 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d8 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d9 = 0
		BajoTotStud = 0
		PromTotStud = 0
		SobreTotStud = 0
		
		'UPGRADE_WARNING: Couldn't resolve default property of object GetStaninePromT1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = GetStaninePromT1("", "R", Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9,  ,  , BajoTotStud, PromTotStud, SobreTotStud)
		'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[REN_SOBRE]", Sobre & "%")
		'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[REN_BAJO]", Bajo & "%")
		'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[REN_PROM]", Prom & "%")
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[REN_SOBRE_EQ]", CStr(SobreTotStud))
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[REN_BAJO_EQ]", CStr(BajoTotStud))
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[REN_PROM_EQ]", CStr(PromTotStud))
		'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[REN_TOT]", TotStud)
		'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[REN_SOBRE_PROM]", (Sobre + Prom) & "%")
		'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[R1]", d1)
		'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[R2]", d2)
		'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[R3]", d3)
		'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[R4]", d4)
		'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[R5]", d5)
		'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[R6]", d6)
		'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[R7]", d7)
		'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[R8]", d8)
		'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[R9]", d9)
		'--
		
		System.Windows.Forms.Application.DoEvents()
		'----
		
		'Configurar parrafo de  LES
		'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Bajo = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Prom = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Sobre = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TotStud = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d1 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d2 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d3 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d4 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d5 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d6 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d7 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d8 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d9 = 0
		BajoTotStud = 0
		PromTotStud = 0
		SobreTotStud = 0
		
		'UPGRADE_WARNING: Couldn't resolve default property of object GetStaninePromT1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		X = GetStaninePromT1("", "L", Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9,  ,  , BajoTotStud, PromTotStud, SobreTotStud)
		'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[LES_SOBRE]", Sobre & "%")
		'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[LES_BAJO]", Bajo & "%")
		'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[LES_PROM]", Prom & "%")
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[LES_SOBRE_EQ]", CStr(SobreTotStud))
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[LES_BAJO_EQ]", CStr(BajoTotStud))
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[LES_PROM_EQ]", CStr(PromTotStud))
		'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[LES_TOT]", TotStud)
		'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[LES_SOBRE_PROM]", (Sobre + Prom) & "%")
		'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[L1]", d1)
		'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[L2]", d2)
		'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[L3]", d3)
		'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[L4]", d4)
		'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[L5]", d5)
		'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[L6]", d6)
		'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[L7]", d7)
		'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[L8]", d8)
		'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[L9]", d9)
		'--
		'----INCREMENT 12
		System.Windows.Forms.Application.DoEvents()
		'----
		
		'Calcular total de Estudiantes
		Cn = CreateObject("ADODB.Connection")
		Rs = CreateObject("ADODB.Recordset")
		OpenConnection(Cn, Config.ConnectionString)
		
		sQuery = "SELECT Resultados.resg_rep_id " & "FROM Resultados INNER JOIN ResEst ON Resultados.resg_id = ResEst.resg_id " & "INNER JOIN schools ON Resultados.reg_sc_id = Schools.sc_id " & "INNER JOIN reports ON Resultados.resg_rep_id = Reports.rep_id " & "WHERE (((Schools.sc_comp)= '" & frmT1Dist.cboComp.Text & "') AND " & "(Resultados.reg_serv_date >= '" & frmT1Dist.txtDesde.Text & "') AND " & "(Resultados.reg_serv_date <= '" & frmT1Dist.txtHasta.Text & "') AND " & "(Reports.rep_sem = '" & frmT1Dist.cboSem.Text & "') AND (Reports.rep_type = 2) " & ") "
		
		Rs.Open(sQuery, Cn, 3, 3)
		'UPGRADE_WARNING: Couldn't resolve default property of object sTotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sTotStud = 0
		If Rs.RecordCount > 0 Then
			Rs.MoveLast()
			'UPGRADE_WARNING: Couldn't resolve default property of object sTotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sTotStud = Rs.RecordCount
		End If
		Rs.Close()
		
		'--
		'Calcular Total Colegios
		sQuery = "SELECT max(sc_id) as schid " & "FROM Resultados " & "INNER JOIN Schools ON Resultados.reg_sc_id = Schools.sc_id " & "INNER JOIN reports ON Resultados.resg_rep_id = Reports.rep_id " & "WHERE (((Schools.sc_comp)= '" & frmT1Dist.cboComp.Text & "') AND " & "(Resultados.reg_serv_date >= '" & frmT1Dist.txtDesde.Text & "') AND " & "(Resultados.reg_serv_date <= '" & frmT1Dist.txtHasta.Text & "') AND " & "(Reports.rep_sem = '" & frmT1Dist.cboSem.Text & "') AND (Reports.rep_type = 2) " & ") GROUP BY reg_sc_id "
		
		Rs.Open(sQuery, Cn, 3, 3)
		'UPGRADE_WARNING: Couldn't resolve default property of object sTotCol. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sTotCol = 0
		If Rs.RecordCount > 0 Then
			Rs.MoveLast()
			'UPGRADE_WARNING: Couldn't resolve default property of object sTotCol. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sTotCol = Rs.RecordCount
		End If
		Rs.Close()
		
		'--
		'UPGRADE_NOTE: Object Rs may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		Rs = Nothing
		
		DocName = frmT1Dist.cboComp.Text & "-" & frmT1Dist.cboSem.Text & "-" & Year(CDate(frmT1Dist.txtDesde.Text))
		'UPGRADE_WARNING: Couldn't resolve default property of object InformeFooter. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		InformeFooter = Replace(InformeFooter, "template_Titulo1_Distribucion", DocName)
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "template_Titulo1_Distribucion", DocName)
		'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object FiletoVar(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object informelist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		informelist = FiletoVar(ConsultantsPath & "template_Titulo1_Distribucion_files\filelist.xml")
		'UPGRADE_WARNING: Couldn't resolve default property of object informelist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		informelist = Replace(informelist, "template_Titulo1_Distribucion", DocName)
		'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DestDir = ConsultantsPath & frmT1Dist.cboComp.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object DestDirlist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DestDirlist = ConsultantsPath & frmT1Dist.cboComp.Text & "\" & DocName & "_files"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[PROV_NAME]", frmT1Dist.cboComp.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object sTotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[TOT_STUD]", sTotStud)
		'UPGRADE_WARNING: Couldn't resolve default property of object sTotCol. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[TOT_COL]", sTotCol)
		
		Select Case frmT1Dist.cboSem.Text
			Case "1"
				'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Informe = Replace(Informe, "[SEM]", "Pre Prueba")
			Case "2"
				'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Informe = Replace(Informe, "[SEM]", "Post Prueba")
		End Select
		'UPGRADE_WARNING: Couldn't resolve default property of object InformeFooter. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		InformeFooter = Replace(InformeFooter, "[FOOTER_LINE]", "")
		'UPGRADE_WARNING: Couldn't resolve default property of object sFromTo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sFromTo = "Año Escolar (" & Year(CDate(frmT1Dist.txtDesde.Text)) & " - " & Year(CDate(frmT1Dist.txtHasta.Text)) & ")"
		'UPGRADE_WARNING: Couldn't resolve default property of object sFromTo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[FROM_TO]", sFromTo)
		'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Informe = Replace(Informe, "[YEAR]", CStr(Year(CDate(frmT1Dist.txtDesde.Text))))
		
		If frmT1Dist.chkColegios.CheckState = System.Windows.Forms.CheckState.Checked Then
			'UPGRADE_WARNING: Couldn't resolve default property of object CreateT1_Dist_Col(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object sColData. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sColData = CreateT1_Dist_Col(Cn)
			'UPGRADE_WARNING: Couldn't resolve default property of object sColData. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[COL_AREA]", vbCrLf & sColData)
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[COL_AREA]", "" & vbTab & vbTab & vbTab)
		End If
		
		
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If Dir(DestDir, FileAttribute.Directory) = "" Then MkDir(DestDir)
		'UPGRADE_WARNING: Couldn't resolve default property of object DestDirlist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object DestDirlist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Dir(DestDirlist, FileAttribute.Directory) = "" Then MkDir(DestDirlist)
		
		DestDir = DestDir & "\"
		'UPGRADE_WARNING: Couldn't resolve default property of object DestDirlist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DestDirlist = DestDirlist & "\"
		
		
		CreateFile(DestDir & DocName & ".htm", Informe)
		'UPGRADE_WARNING: Couldn't resolve default property of object DestDirlist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CreateFile(DestDirlist & "header.htm", InformeFooter)
		'UPGRADE_WARNING: Couldn't resolve default property of object DestDirlist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CreateFile(DestDirlist & "filelist.xml", informelist)
		'UPGRADE_WARNING: Couldn't resolve default property of object DestDirlist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileCopy(ConsultantsPath & "template_titulo1_distribucion_files\image001.png", DestDirlist & "image001.png")
		
		'UPGRADE_WARNING: Couldn't resolve default property of object WordPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WordPath = GetINIValue(My.Application.Info.DirectoryPath & "\learnaid.ini", "System.Settings", "MSWordPath")
		'UPGRADE_WARNING: Couldn't resolve default property of object WordPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object hShell. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		hShell = Shell(WordPath & " " & Chr(34) & DestDir & DocName & ".htm" & Chr(34), AppWinStyle.MaximizedFocus)
		
		'----
		'----
		
	End Sub
	
	
	Function CreateT1_Dist_Col(ByRef Cn As ADODB.Connection) As Object
		Dim sFromTo As Object
		Dim X As Object
		Dim d9 As Object
		Dim d8 As Object
		Dim d7 As Object
		Dim d6 As Object
		Dim d5 As Object
		Dim d4 As Object
		Dim d3 As Object
		Dim d2 As Object
		Dim d1 As Object
		Dim TotStud As Object
		Dim Sobre As Object
		Dim Prom As Object
		Dim Bajo As Object
		Dim ConsultantsPath As Object
		Dim sTotCol As Object
		Dim sQuery As String
		Dim Rs As ADODB.Recordset
		Dim Informe As Object
		Dim FromGrade As String
		Dim ToGrade As String
		Dim DestDir As String
		Dim DocName As String
		Dim isPRE1 As Boolean
		Dim Pre1Data As Object
		Dim firstPre1 As String 'para guardar el grado que tiene pre1
		Dim BajoTotStud As Short
		Dim PromTotStud As Short
		Dim SobreTotStud As Short
		Dim hShell As Object
		Dim InformeGlobal As String
		
		Rs = CreateObject("ADODB.Recordset")
		'OpenConnection Cn, Config.ConnectionString
		
		sQuery = "SELECT max(sc_id) as schid, max(sc_sch_name) as scname " & "FROM Resultados " & "INNER JOIN Schools ON Resultados.reg_sc_id = Schools.sc_id " & "INNER JOIN reports ON Resultados.resg_rep_id = Reports.rep_id " & "WHERE (((Schools.sc_comp)= '" & frmT1Dist.cboComp.Text & "') AND " & "(Resultados.reg_serv_date >= '" & frmT1Dist.txtDesde.Text & "') AND " & "(Resultados.reg_serv_date <= '" & frmT1Dist.txtHasta.Text & "') AND " & "(Reports.rep_sem = '" & frmT1Dist.cboSem.Text & "') AND (Reports.rep_type = 2) " & ") GROUP BY reg_sc_id "
		
		Rs.Open(sQuery, Cn, 3, 3)
		'UPGRADE_WARNING: Couldn't resolve default property of object sTotCol. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sTotCol = 0
		
		InformeGlobal = ""
		'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ConsultantsPath = Config.ConsultantsPath
		
		While Not Rs.EOF
			'UPGRADE_WARNING: Couldn't resolve default property of object ConsultantsPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object FiletoVar(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = FiletoVar(ConsultantsPath & "template_titulo1_distribucion_colegio.htm")
			'Configurar parrafo de  Matematicas
			'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Bajo = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Prom = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Sobre = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			TotStud = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d1 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d2 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d3 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d4 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d5 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d6 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d7 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d8 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d9 = 0
			BajoTotStud = 0
			PromTotStud = 0
			SobreTotStud = 0
			
			'UPGRADE_WARNING: Couldn't resolve default property of object GetStaninePromT1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = GetStaninePromT1(Rs.Fields("schid").Value, "M", Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9,  ,  , BajoTotStud, PromTotStud, SobreTotStud)
			'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[MAT_SOBRE]", Sobre & "%")
			'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[MAT_BAJO]", Bajo & "%")
			'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[MAT_PROM]", Prom & "%")
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[MAT_SOBRE_EQ]", CStr(SobreTotStud))
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[MAT_BAJO_EQ]", CStr(BajoTotStud))
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[MAT_PROM_EQ]", CStr(PromTotStud))
			'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[MAT_SOBRE_PROM]", (Sobre + Prom) & "%")
			'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[MAT_TOT]", TotStud)
			'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[M1]", d1)
			'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[M2]", d2)
			'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[M3]", d3)
			'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[M4]", d4)
			'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[M5]", d5)
			'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[M6]", d6)
			'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[M7]", d7)
			'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[M8]", d8)
			'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[M9]", d9)
			'--
			
			System.Windows.Forms.Application.DoEvents()
			'----
			
			'Configurar parrafo de  INGLES
			'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Bajo = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Prom = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Sobre = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			TotStud = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d1 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d2 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d3 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d4 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d5 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d6 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d7 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d8 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d9 = 0
			BajoTotStud = 0
			PromTotStud = 0
			SobreTotStud = 0
			
			'UPGRADE_WARNING: Couldn't resolve default property of object GetStaninePromT1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = GetStaninePromT1(Rs.Fields("schid").Value, "R", Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9,  ,  , BajoTotStud, PromTotStud, SobreTotStud)
			'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[REN_SOBRE]", Sobre & "%")
			'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[REN_BAJO]", Bajo & "%")
			'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[REN_PROM]", Prom & "%")
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[REN_SOBRE_EQ]", CStr(SobreTotStud))
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[REN_BAJO_EQ]", CStr(BajoTotStud))
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[REN_PROM_EQ]", CStr(PromTotStud))
			'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[REN_TOT]", TotStud)
			'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[REN_SOBRE_PROM]", (Sobre + Prom) & "%")
			'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[R1]", d1)
			'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[R2]", d2)
			'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[R3]", d3)
			'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[R4]", d4)
			'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[R5]", d5)
			'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[R6]", d6)
			'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[R7]", d7)
			'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[R8]", d8)
			'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[R9]", d9)
			'--
			
			System.Windows.Forms.Application.DoEvents()
			'----
			
			'Configurar parrafo de  LES
			'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Bajo = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Prom = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Sobre = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			TotStud = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d1 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d2 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d3 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d4 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d5 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d6 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d7 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d8 = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			d9 = 0
			BajoTotStud = 0
			PromTotStud = 0
			SobreTotStud = 0
			
			'UPGRADE_WARNING: Couldn't resolve default property of object GetStaninePromT1(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = GetStaninePromT1(Rs.Fields("schid").Value, "L", Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9,  ,  , BajoTotStud, PromTotStud, SobreTotStud)
			'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[LES_SOBRE]", Sobre & "%")
			'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[LES_BAJO]", Bajo & "%")
			'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[LES_PROM]", Prom & "%")
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[LES_SOBRE_EQ]", CStr(SobreTotStud))
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[LES_BAJO_EQ]", CStr(BajoTotStud))
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[LES_PROM_EQ]", CStr(PromTotStud))
			'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[LES_TOT]", TotStud)
			'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[LES_SOBRE_PROM]", (Sobre + Prom) & "%")
			'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[L1]", d1)
			'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[L2]", d2)
			'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[L3]", d3)
			'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[L4]", d4)
			'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[L5]", d5)
			'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[L6]", d6)
			'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[L7]", d7)
			'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[L8]", d8)
			'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[L9]", d9)
			'--
			'----INCREMENT 12
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[PROV_NAME]", frmT1Dist.cboComp.Text)
			'UPGRADE_WARNING: Couldn't resolve default property of object sFromTo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sFromTo = "Año Escolar (" & Year(CDate(frmT1Dist.txtDesde.Text)) & " - " & Year(CDate(frmT1Dist.txtHasta.Text)) & ")"
			'UPGRADE_WARNING: Couldn't resolve default property of object sFromTo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[FROM_TO]", sFromTo)
			'UPGRADE_WARNING: Couldn't resolve default property of object sFromTo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[YEAR]", sFromTo)
			Select Case frmT1Dist.cboSem.Text
				Case "1"
					'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Informe = Replace(Informe, "[SEM]", "Pre Prueba")
				Case "2"
					'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Informe = Replace(Informe, "[SEM]", "Post Prueba")
			End Select
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Informe = Replace(Informe, "[COL_NAME]", Rs.Fields("scname").Value)
			System.Windows.Forms.Application.DoEvents()
			'UPGRADE_WARNING: Couldn't resolve default property of object Informe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			InformeGlobal = InformeGlobal & Informe
			'----
			Rs.MoveNext()
		End While
		Rs.Close()
		
		'--
		'UPGRADE_NOTE: Object Rs may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		Rs = Nothing
		'UPGRADE_NOTE: Object Cn may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		Cn = Nothing
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object CreateT1_Dist_Col. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CreateT1_Dist_Col = InformeGlobal
		'----
		'----
		
	End Function
	
	
	
	
	Sub CreateFile(ByRef TargetFile As String, ByRef StringToAppend As Object)
		Dim iFile As Short
		
		iFile = FreeFile
		FileOpen(iFile, TargetFile, OpenMode.Output)
		PrintLine(iFile, StringToAppend)
		FileClose(iFile)
	End Sub
	
	
	Function GetAIDDesc(ByRef xid As Object) As String
		Dim Ret As Object
		
		Select Case xid
			Case 1
				'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Ret = "Discriminación visual"
			Case 2
				'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Ret = "Memoria visual"
			Case 3
				'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Ret = "Músculos finos"
			Case 4
				'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Ret = "Cierre"
			Case 5
				'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Ret = "Discriminación auditiva"
			Case 6
				'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Ret = "Instrucciones de direccionalidad"
			Case 7
				'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Ret = "Distinguir cantidades"
			Case 8
				'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Ret = "Concepto de mayor que"
			Case 9
				'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Ret = "Distinguir números"
			Case 10
				'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Ret = "Concepto de menor que"
		End Select
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GetAIDDesc = Ret
		
	End Function
	
	Function GetGrupos(ByRef xid As Object) As Object
		Dim Ret As Object
		
		Select Case xid
			Case 1
				'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Ret = "un grupo"
			Case 2
				'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Ret = "dos grupos"
			Case 3
				'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Ret = "tres grupos"
			Case 4
				'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Ret = "cuatro grupos"
			Case 5
				'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Ret = "cinco grupos"
			Case 6
				'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Ret = "seis grupos"
			Case 7
				'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Ret = "siete grupos"
			Case Else
				'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Ret = "muchos grupos"
		End Select
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object GetGrupos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GetGrupos = Ret
	End Function
	
	Function GetObservacionTR(ByRef isLast As Boolean) As Object
		Dim bwidth As Object
		
		If isLast = False Then
			'UPGRADE_WARNING: Couldn't resolve default property of object bwidth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			bwidth = ".25"
			
			'UPGRADE_WARNING: Couldn't resolve default property of object bwidth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetObservacionTR = "<tr style='mso-yfti-irow:4;height:15.0pt'>" & vbCrLf & "<td width=87 style='width:65.45pt;border-top:none;border-left:solid windowtext 2.25pt;" & vbCrLf & "border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 2.25pt;" & vbCrLf & "mso-border-left-alt:solid windowtext 2.25pt;mso-border-top-alt:solid windowtext .25pt;mso-border-alt:solid windowtext .25pt;" & vbCrLf & "mso-border-bottom-alt:solid windowtext " & bwidth & "pt;mso-border-left-alt:2.25pt;background:#E0E0E0;padding:0in 5.4pt 0in 5.4pt;" & vbCrLf & "height:15.0pt'>" & vbCrLf & "<p class=MsoNormal align=center style='text-align:center'><b" & vbCrLf & "style='mso-bidi-font-weight:normal'><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'>[GRADO]</span><o:p></o:p></b></p>" & vbCrLf & "</td>" & vbCrLf
			
			'UPGRADE_WARNING: Couldn't resolve default property of object bwidth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetObservacionTR = GetObservacionTR & "<td width=42 colspan=2 style='width:31.3pt;border-top:none;border-left:none;" & vbCrLf & "border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;" & vbCrLf & "mso-border-top-alt:solid windowtext .25pt;mso-border-left-alt:solid windowtext 2.25pt;" & vbCrLf & "mso-border-top-alt:.25pt;mso-border-left-alt:2.25pt;mso-border-bottom-alt:" & vbCrLf & bwidth & "pt;mso-border-right-alt:.5pt;mso-border-color-alt:windowtext;mso-border-style-alt:" & vbCrLf & "solid;padding:0in 5.4pt 0in 5.4pt;height:15.0pt'>" & vbCrLf & "<p class=MsoNormal align=center style='text-align:center'><b" & vbCrLf & "style='mso-bidi-font-weight:normal'><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'>[AA]</span><o:p></o:p></b></p>" & vbCrLf & "</td>" & vbCrLf
			
			'UPGRADE_WARNING: Couldn't resolve default property of object bwidth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetObservacionTR = GetObservacionTR & "<td width=42 style='width:31.5pt;border-top:none;border-left:none;border-bottom:" & vbCrLf & "solid windowtext 1.0pt;border-right:solid windowtext 2.25pt;mso-border-top-alt:" & vbCrLf & "solid windowtext .25pt;mso-border-left-alt:solid windowtext .5pt;mso-border-top-alt:" & vbCrLf & ".25pt;mso-border-left-alt:.5pt;mso-border-bottom-alt:" & bwidth & "pt;mso-border-right-alt:" & vbCrLf & "2.25pt;mso-border-color-alt:windowtext;mso-border-style-alt:solid;padding:" & vbCrLf & "0in 5.4pt 0in 5.4pt;height:15.0pt'>" & vbCrLf & "<p class=MsoNormal align=center style='text-align:center'><b" & vbCrLf & "style='mso-bidi-font-weight:normal'><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'>[ANA]</span><o:p></o:p></b></p>" & vbCrLf & "</td>" & vbCrLf
			
			'UPGRADE_WARNING: Couldn't resolve default property of object bwidth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetObservacionTR = GetObservacionTR & "<td width=36 style='width:26.95pt;border-top:none;border-left:none;" & vbCrLf & "border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;" & vbCrLf & "mso-border-top-alt:solid windowtext .25pt;mso-border-left-alt:solid windowtext 2.25pt;" & vbCrLf & "mso-border-top-alt:.25pt;mso-border-left-alt:2.25pt;mso-border-bottom-alt:" & vbCrLf & bwidth & "pt;mso-border-right-alt:.5pt;mso-border-color-alt:windowtext;mso-border-style-alt:" & vbCrLf & "solid;padding:0in 5.4pt 0in 5.4pt;height:15.0pt'>" & vbCrLf & "<p class=MsoNormal align=center style='text-align:center'><b" & vbCrLf & "style='mso-bidi-font-weight:normal'><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'>[1X]</span><o:p></o:p></b></p>" & vbCrLf & "</td>" & vbCrLf
			
			'UPGRADE_WARNING: Couldn't resolve default property of object bwidth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetObservacionTR = GetObservacionTR & "<td width=36 style='width:26.95pt;border-top:none;border-left:none;" & vbCrLf & "border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;" & vbCrLf & "mso-border-top-alt:solid windowtext .25pt;mso-border-left-alt:solid windowtext .5pt;" & vbCrLf & "mso-border-top-alt:.25pt;mso-border-left-alt:.5pt;mso-border-bottom-alt:" & vbCrLf & bwidth & "pt;mso-border-right-alt:.5pt;mso-border-color-alt:windowtext;mso-border-style-alt:" & vbCrLf & "solid;padding:0in 5.4pt 0in 5.4pt;height:15.0pt'>" & vbCrLf & "<h5><span style='font-size:12.0pt;mso-bidi-font-size:10.0pt;mso-ansi-language:" & vbCrLf & "EN-US;text-decoration:none;text-underline:none'><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'>[2X]</span><o:p></o:p></span></h5>" & vbCrLf & "</td>" & vbCrLf
			
			'UPGRADE_WARNING: Couldn't resolve default property of object bwidth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetObservacionTR = GetObservacionTR & "<td width=48 style='width:35.85pt;border-top:none;border-left:none;" & vbCrLf & "border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 2.25pt;" & vbCrLf & "mso-border-top-alt:solid windowtext .25pt;mso-border-left-alt:solid windowtext .5pt;" & vbCrLf & "mso-border-top-alt:.25pt;mso-border-left-alt:.5pt;mso-border-bottom-alt:" & vbCrLf & bwidth & "pt;mso-border-right-alt:2.25pt;mso-border-color-alt:windowtext;mso-border-style-alt:" & vbCrLf & "solid;padding:0in 5.4pt 0in 5.4pt;height:15.0pt'>" & vbCrLf & "<p class=MsoNormal align=center style='text-align:center'><b" & vbCrLf & "style='mso-bidi-font-weight:normal'><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:" & vbCrLf & "ES -PR '>[IND]<o:p></o:p></span></b></p>" & vbCrLf & "</td>" & vbCrLf
			
			'UPGRADE_WARNING: Couldn't resolve default property of object bwidth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetObservacionTR = GetObservacionTR & "<td width=42 style='width:31.5pt;border-top:none;border-left:none;border-bottom:" & vbCrLf & "solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;mso-border-top-alt:" & vbCrLf & "solid windowtext .25pt;mso-border-left-alt:solid windowtext 2.25pt;" & vbCrLf & "mso-border-top-alt:.25pt;mso-border-left-alt:2.25pt;mso-border-bottom-alt:" & vbCrLf & bwidth & "pt;mso-border-right-alt:.5pt;mso-border-color-alt:windowtext;mso-border-style-alt:" & vbCrLf & "solid;padding:0in 5.4pt 0in 5.4pt;height:15.0pt'>" & vbCrLf & "<p class=MsoNormal align=center style='text-align:center'><b" & vbCrLf & "style='mso-bidi-font-weight:normal'><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:" & vbCrLf & "ES -PR '>[CA]<o:p></o:p></span></b></p>" & vbCrLf & "</td>" & vbCrLf
			
			'UPGRADE_WARNING: Couldn't resolve default property of object bwidth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetObservacionTR = GetObservacionTR & "<td width=42 style='width:31.5pt;border-top:none;border-left:none;border-bottom:" & vbCrLf & "solid windowtext 1.0pt;border-right:solid windowtext 2.25pt;mso-border-top-alt:" & vbCrLf & "solid windowtext .25pt;mso-border-left-alt:solid windowtext .5pt;mso-border-top-alt:" & vbCrLf & ".25pt;mso-border-left-alt:.5pt;mso-border-bottom-alt:" & bwidth & "pt;mso-border-right-alt:" & vbCrLf & "2.25pt;mso-border-color-alt:windowtext;mso-border-style-alt:solid;padding:" & vbCrLf & "0in 5.4pt 0in 5.4pt;height:15.0pt'>" & vbCrLf & "<p class=MsoNormal align=center style='text-align:center'><b" & vbCrLf & "style='mso-bidi-font-weight:normal'><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:" & vbCrLf & "ES -PR '>[CNA]<o:p></o:p></span></b></p>" & vbCrLf & "</td>" & vbCrLf
			
			'UPGRADE_WARNING: Couldn't resolve default property of object bwidth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetObservacionTR = GetObservacionTR & "<td width=42 style='width:31.3pt;border-top:none;border-left:none;border-bottom:" & vbCrLf & "solid windowtext 1.0pt;border-right:solid windowtext 2.25pt;mso-border-top-alt:" & vbCrLf & "solid windowtext .25pt;mso-border-left-alt:solid windowtext 2.25pt;" & vbCrLf & "mso-border-alt:solid windowtext .25pt;mso-border-right-alt:2.25pt;mso-border-bottom-alt:solid windowtext " & bwidth & "pt;" & vbCrLf & "padding:0in 5.4pt 0in 5.4pt;height:15.0pt'>" & vbCrLf & "<p class=MsoNormal align=center style='text-align:center'><b" & vbCrLf & "style='mso-bidi-font-weight:normal'><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:" & vbCrLf & "ES -PR '>[DIF]<o:p></o:p></span></b></p>" & vbCrLf & "</td>" & vbCrLf
			
			'UPGRADE_WARNING: Couldn't resolve default property of object bwidth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetObservacionTR = GetObservacionTR & "<td width=475 colspan=2 style='width:356.5pt;border-top:none;border-left:" & vbCrLf & "none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 2.25pt;" & vbCrLf & "mso-border-top-alt:solid windowtext .25pt;mso-border-left-alt:solid windowtext 2.25pt;" & vbCrLf & "mso-border-alt:solid windowtext .25pt;mso-border-right-alt:2.25pt;mso-border-bottom-alt:solid windowtext " & bwidth & "pt;" & vbCrLf & "padding:0in 5.4pt 0in 5.4pt;height:15.0pt'>" & vbCrLf & "<p class=MsoNormal align=center style='text-align:justify'>" & vbCrLf & "<span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:" & vbCrLf & "ES -PR '></b>[ORACION]<o:p></o:p></span></p>" & vbCrLf & "</td></tr>" & vbCrLf
		Else
			
			'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetObservacionTR = "<tr style='mso-yfti-irow:24;mso-yfti-lastrow:yes;height:12.8pt'>" & "<td width=87 style='width:65.45pt;border-top:none;border-left:solid windowtext 2.25pt;" & "border-bottom:solid windowtext 2.25pt;border-right:solid windowtext 1.0pt;" & "mso-border-top-alt:solid windowtext .25pt;mso-border-top-alt:.25pt;" & "mso-border-left-alt:2.25pt;mso-border-bottom-alt:2.25pt;mso-border-right-alt:" & ".25pt;mso-border-color-alt:windowtext;mso-border-style-alt:solid;background:" & "#E0E0E0;padding:0in 5.4pt 0in 5.4pt;height:12.8pt'>" & "<p class=MsoNormal align=center style='text-align:center'>" & "<b style='mso-bidi-font-weight:normal'><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'>[GRADO]</span><o:p></o:p></b></p></td>"
			
			'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetObservacionTR = GetObservacionTR & "<td width=42 colspan=2 style='width:31.3pt;border-top:none;border-left:none;" & "border-bottom:solid windowtext 2.25pt;border-right:solid windowtext 1.0pt;" & "mso-border-top-alt:solid windowtext .25pt;mso-border-left-alt:solid windowtext 2.25pt;" & "mso-border-top-alt:.25pt;mso-border-left-alt:2.25pt;mso-border-bottom-alt:" & "2.25pt;mso-border-right-alt:.5pt;mso-border-color-alt:windowtext;mso-border-style-alt:" & "solid;padding:0in 5.4pt 0in 5.4pt;height:12.8pt'>" & "<p class=MsoNormal align=center style='text-align:center'><b style='mso-bidi-font-weight:normal'><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'><o:p>[AA]</o:p></span></b></p></td>"
			
			'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetObservacionTR = GetObservacionTR & "<td width=42 style='width:31.5pt;border-top:none;border-left:none;border-bottom:" & "solid windowtext 2.25pt;border-right:solid windowtext 2.25pt;mso-border-top-alt:" & "solid windowtext .25pt;mso-border-left-alt:solid windowtext .5pt;padding:" & "0in 5.4pt 0in 5.4pt;height:12.8pt'>" & "<p class=MsoNormal align=center style='text-align:center'><b" & "style='mso-bidi-font-weight:normal'><o:p><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'>[ANA]</span></o:p></b></p></td>"
			
			
			'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetObservacionTR = GetObservacionTR & "<td width=36 style='width:26.95pt;border-top:none;border-left:none;" & "border-bottom:solid windowtext 2.25pt;border-right:solid windowtext 1.0pt;" & "mso-border-top-alt:solid windowtext .25pt;mso-border-left-alt:solid windowtext 2.25pt;" & "mso-border-top-alt:.25pt;mso-border-left-alt:2.25pt;mso-border-bottom-alt:" & "2.25pt;mso-border-right-alt:.5pt;mso-border-color-alt:windowtext;mso-border-style-alt:" & "solid;padding:0in 5.4pt 0in 5.4pt;height:12.8pt'>" & "<p class=MsoNormal align=center style='text-align:center'><b" & "style='mso-bidi-font-weight:normal'><o:p><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'>[1X]</span></o:p></b></p></td>"
			
			'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetObservacionTR = GetObservacionTR & "<td width=36 style='width:26.95pt;border-top:none;border-left:none;" & "border-bottom:solid windowtext 2.25pt;border-right:solid windowtext 1.0pt;" & "mso-border-top-alt:solid windowtext .25pt;mso-border-left-alt:solid windowtext .5pt;" & "mso-border-top-alt:.25pt;mso-border-left-alt:.5pt;mso-border-bottom-alt:2.25pt;" & "mso-border-right-alt:.5pt;mso-border-color-alt:windowtext;mso-border-style-alt:" & "solid;padding:0in 5.4pt 0in 5.4pt;height:12.8pt'>" & "<h5><span style='font-size:12.0pt;mso-bidi-font-size:10.0pt;mso-ansi-language:" & "EN-US;text-decoration:none;text-underline:none'><o:p><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'>[2X]</span></o:p></span></h5></td>"
			
			'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetObservacionTR = GetObservacionTR & "<td width=48 style='width:35.85pt;border-top:none;border-left:none;" & "border-bottom:solid windowtext 2.25pt;border-right:solid windowtext 2.25pt;" & "mso-border-top-alt:solid windowtext .25pt;mso-border-left-alt:solid windowtext .5pt;" & "padding:0in 5.4pt 0in 5.4pt;height:12.8pt'><b style='mso-bidi-font-weight:" & "Normal '><span style='mso-ansi-language:-PR '></b>" & "<p class=MsoNormal align=center style='text-align:center'><b" & "style='mso-bidi-font-weight:normal'><span lang=ES-PR style='mso-ansi-language:" & "ES -PR '><o:p><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'>[IND]</span></o:p></span></b></p></td>"
			
			'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetObservacionTR = GetObservacionTR & "<td width=42 style='width:31.5pt;border-top:none;border-left:none;border-bottom:" & "solid windowtext 2.25pt;border-right:solid windowtext 1.0pt;mso-border-top-alt:" & "solid windowtext .25pt;mso-border-left-alt:solid windowtext 2.25pt;" & "mso-border-top-alt:.25pt;mso-border-left-alt:2.25pt;mso-border-bottom-alt:" & "2.25pt;mso-border-right-alt:.5pt;mso-border-color-alt:windowtext;mso-border-style-alt:" & "solid;padding:0in 5.4pt 0in 5.4pt;height:12.8pt'>" & "<p class=MsoNormal align=center style='text-align:center'><b" & "style='mso-bidi-font-weight:normal'><span lang=ES-PR style='mso-ansi-language:" & "ES -PR '><o:p><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'>[CA]</span></o:p></span></b></p></td>"
			
			'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetObservacionTR = GetObservacionTR & "<td width=42 style='width:31.5pt;border-top:none;border-left:none;border-bottom:" & "solid windowtext 2.25pt;border-right:solid windowtext 2.25pt;mso-border-top-alt:" & "solid windowtext .25pt;mso-border-left-alt:solid windowtext .5pt;padding:" & "0in 5.4pt 0in 5.4pt;height:12.8pt'>" & "<p class=MsoNormal align=center style='text-align:center'><b" & "style='mso-bidi-font-weight:normal'><span lang=ES-PR style='mso-ansi-language:" & "ES -PR '><o:p><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'>[CNA]</span></o:p></span></b></p></td>"
			
			'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetObservacionTR = GetObservacionTR & "<td width=42 style='width:31.3pt;border-top:none;border-left:none;border-bottom:" & "solid windowtext 2.25pt;border-right:solid windowtext 2.25pt;mso-border-top-alt:" & "solid windowtext .25pt;mso-border-left-alt:solid windowtext .25pt;padding:" & "0in 5.4pt 0in 5.4pt;height:12.8pt'>" & "<p class=MsoNormal align=center style='text-align:center'><b" & "style='mso-bidi-font-weight:normal'><span lang=ES-PR style='mso-ansi-language:" & "ES -PR '><o:p><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'>[DIF]</span></o:p></span></b></p></td>"
			
			'UPGRADE_WARNING: Couldn't resolve default property of object GetObservacionTR. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			GetObservacionTR = GetObservacionTR & "<td width=475 colspan=2 style='width:356.5pt;border-top:none;border-left:" & "none;border-bottom:solid windowtext 2.25pt;border-right:solid windowtext 2.25pt;" & "mso-border-top-alt:solid windowtext .25pt;mso-border-left-alt:solid windowtext .25pt;" & "padding:0in 5.4pt 0in 5.4pt;height:12.8pt'>" & "<p class=MsoNormal align=center style='text-align:justify'>" & "<span style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES -PR '>[ORACION]<o:p></o:p></span></p></td>"
		End If
		
		
		
	End Function
	
	Function GetRecomendacionLine() As Object
		Dim Ret As Object
		
		'ret = "<p class=MsoBodyTextIndent2 style='margin-top:0in;margin-right:0in;margin-bottom:"
		'ret = ret & "12.0pt;margin-left:.75in;text-align:justify;text-indent:-.25in;line-height:"
		'ret = ret & "normal;mso-list:l1 level1 lfo5;tab-stops:list .75in'><![if !supportLists]><span"
		'ret = ret & "style='font-family:Arial;mso-fareast-font-family:Arial'><span style='mso-list:"
		'ret = ret & "Ignore '>[NO]<span style='font:7.0pt ""Times New Roman""'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"
		'ret = ret & "</span></span></span><![endif]><span style='font-family:Arial'>[RECOM]"
		'ret = ret & "<o:p></o:p></span></p>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Ret = "<p class=MsoBodyTextIndent2 style='margin-top:0in;margin-right:.5in;margin-bottom:"
		'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Ret = Ret & " 12.0pt;margin-left:.75in;text-align:justify;text-indent:-.25in;line-height:"
		'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Ret = Ret & " normal;mso-list:l18 level1 lfo5;tab-stops:list -2.25in .5in'><![if !supportLists]><span"
		'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Ret = Ret & " lang=ES-PR style='font-family:Arial;mso-fareast-font-family:Arial;mso-ansi-language:"
		'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Ret = Ret & " ES -PR '><span style='mso-list:Ignore'>[NO]<span style='font:7.0pt ""Times New Roman""'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"
		'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Ret = Ret & " </span></span></span><![endif]><span lang=ES-PR style='font-family:Arial;"
		'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Ret = Ret & " mso -ansi - language: ES -PR '>[RECOM]<o:p></o:p></span></p>"
		
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object GetRecomendacionLine. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GetRecomendacionLine = Ret
		
	End Function
	
	Function GetStanineProm(ByRef dRepID As Object, ByRef xmateria As Object, ByRef xGrade As Short, ByRef Bajo As Object, ByRef Prom As Object, ByRef Sobre As Object, ByRef TotStud As Object, ByRef d1 As Object, ByRef d2 As Object, ByRef d3 As Object, ByRef d4 As Object, ByRef d5 As Object, ByRef d6 As Object, ByRef d7 As Object, ByRef d8 As Object, ByRef d9 As Object, Optional ByRef xClave As Short = 0, Optional ByRef ResgGrade As Short = 0, Optional ByRef BajoTotStud As Short = 0, Optional ByRef PromTotStud As Short = 0, Optional ByRef SobreTotStud As Short = 0) As Object
		Dim sClave As Object
		Dim sQuery As String
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		
		'--
		Cn = CreateObject("ADODB.Connection")
		Rs = CreateObject("ADODB.Recordset")
		
		OpenConnection(Cn, Config.ConnectionString)
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Bajo = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Prom = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Sobre = 0
		BajoTotStud = 0
		PromTotStud = 0
		SobreTotStud = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d1 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d2 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d3 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d4 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d5 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d6 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d7 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d8 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d9 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TotStud = 0
		If xClave > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object sClave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sClave = " = " & xClave
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object sClave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sClave = ">0"
		End If
		
		Select Case xmateria
			Case "N" 'No verbal
				If xGrade > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object sClave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object dRepID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					sQuery = "SELECT Resultados.resg_rep_id, ResEst.rese_esta_n, Resultados.resg_NV, resultados.resg_grado " & "FROM Resultados INNER JOIN ResEst ON Resultados.resg_id = ResEst.resg_id " & "WHERE (((Resultados.resg_rep_id)=" & dRepID & ") AND ((Resultados.resg_NV)" & sClave & ") AND ((Resultados.resg_grado)= " & xGrade & ")) "
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object sClave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object dRepID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					sQuery = "SELECT Resultados.resg_rep_id, ResEst.rese_esta_n, Resultados.resg_NV, resultados.resg_grado " & "FROM Resultados INNER JOIN ResEst ON Resultados.resg_id = ResEst.resg_id " & "WHERE (((Resultados.resg_rep_id)=" & dRepID & ") AND ((Resultados.resg_NV)" & sClave & ")) "
				End If
				Rs.Open(sQuery, Cn, 3, 3)
				
				While Not Rs.EOF
					ResgGrade = Rs.Fields("resg_Grado").Value
					If Rs.Fields("rese_esta_n").Value < 1.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d1 = d1 + 1
					End If
					If Rs.Fields("rese_esta_n").Value >= 1.5 And Rs.Fields("rese_esta_n").Value < 2.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d2 = d2 + 1
					End If
					If Rs.Fields("rese_esta_n").Value >= 2.5 And Rs.Fields("rese_esta_n").Value < 3.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d3 = d3 + 1
					End If
					If Rs.Fields("rese_esta_n").Value >= 3.5 And Rs.Fields("rese_esta_n").Value < 4.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d4 = d4 + 1
					End If
					If Rs.Fields("rese_esta_n").Value >= 4.5 And Rs.Fields("rese_esta_n").Value < 5.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d5 = d5 + 1
					End If
					If Rs.Fields("rese_esta_n").Value >= 5.5 And Rs.Fields("rese_esta_n").Value < 6.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d6 = d6 + 1
					End If
					If Rs.Fields("rese_esta_n").Value >= 6.5 And Rs.Fields("rese_esta_n").Value < 7.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d7 = d7 + 1
					End If
					If Rs.Fields("rese_esta_n").Value >= 7.5 And Rs.Fields("rese_esta_n").Value < 8.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d8 = d8 + 1
					End If
					If Rs.Fields("rese_esta_n").Value >= 8.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d9 = d9 + 1
					End If
					
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					TotStud = TotStud + 1
					Rs.MoveNext()
				End While
				
				'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If TotStud > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Sobre = d7 + d8 + d9
					'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Prom = d4 + d5 + d6
					'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Bajo = d1 + d2 + d3
					
					'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					SobreTotStud = d7 + d8 + d9
					'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					PromTotStud = d4 + d5 + d6
					'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					BajoTotStud = d1 + d2 + d3
					
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d1 = System.Math.Round((d1 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d2 = System.Math.Round((d2 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d3 = System.Math.Round((d3 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d4 = System.Math.Round((d4 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d5 = System.Math.Round((d5 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d6 = System.Math.Round((d6 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d7 = System.Math.Round((d7 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d8 = System.Math.Round((d8 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d9 = System.Math.Round((d9 / TotStud) * 100 + 0.0000001, 1)
					
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Bajo = System.Math.Round((Bajo / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Prom = System.Math.Round((Prom / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Sobre = System.Math.Round((Sobre / TotStud) * 100 + 0.0000001, 1)
				End If
				
				Rs.Close()
			Case "M" 'Matematicas
				If xGrade > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object sClave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object dRepID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sQuery = "SELECT Resultados.resg_rep_id, ResEst.rese_esta_m, Resultados.resg_MAT, resultados.resg_grado " & "FROM Resultados INNER JOIN ResEst ON Resultados.resg_id = ResEst.resg_id " & "WHERE (((Resultados.resg_rep_id)=" & dRepID & ") AND ((Resultados.resg_MAT)" & sClave & ") AND ((Resultados.resg_grado)= " & xGrade & ")) "
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object sClave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object dRepID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					sQuery = "SELECT Resultados.resg_rep_id, ResEst.rese_esta_m, Resultados.resg_MAT,Resultados.resg_grado " & "FROM Resultados INNER JOIN ResEst ON Resultados.resg_id = ResEst.resg_id " & "WHERE (((Resultados.resg_rep_id)=" & dRepID & ") AND ((Resultados.resg_MAT)" & sClave & ")) "
				End If
				Rs.Open(sQuery, Cn, 3, 3)
				
				While Not Rs.EOF
					ResgGrade = Rs.Fields("resg_Grado").Value
					If Rs.Fields("rese_esta_m").Value < 1.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d1 = d1 + 1
					End If
					If Rs.Fields("rese_esta_m").Value >= 1.5 And Rs.Fields("rese_esta_m").Value < 2.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d2 = d2 + 1
					End If
					If Rs.Fields("rese_esta_m").Value >= 2.5 And Rs.Fields("rese_esta_m").Value < 3.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d3 = d3 + 1
					End If
					If Rs.Fields("rese_esta_m").Value >= 3.5 And Rs.Fields("rese_esta_m").Value < 4.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d4 = d4 + 1
					End If
					If Rs.Fields("rese_esta_m").Value >= 4.5 And Rs.Fields("rese_esta_m").Value < 5.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d5 = d5 + 1
					End If
					If Rs.Fields("rese_esta_m").Value >= 5.5 And Rs.Fields("rese_esta_m").Value < 6.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d6 = d6 + 1
					End If
					If Rs.Fields("rese_esta_m").Value >= 6.5 And Rs.Fields("rese_esta_m").Value < 7.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d7 = d7 + 1
					End If
					If Rs.Fields("rese_esta_m").Value >= 7.5 And Rs.Fields("rese_esta_m").Value < 8.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d8 = d8 + 1
					End If
					If Rs.Fields("rese_esta_m").Value >= 8.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d9 = d9 + 1
					End If
					
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					TotStud = TotStud + 1
					Rs.MoveNext()
				End While
				'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If TotStud > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Sobre = d7 + d8 + d9
					'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Prom = d4 + d5 + d6
					'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Bajo = d1 + d2 + d3
					'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					SobreTotStud = d7 + d8 + d9
					'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					PromTotStud = d4 + d5 + d6
					'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					BajoTotStud = d1 + d2 + d3
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d1 = System.Math.Round((d1 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d2 = System.Math.Round((d2 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d3 = System.Math.Round((d3 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d4 = System.Math.Round((d4 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d5 = System.Math.Round((d5 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d6 = System.Math.Round((d6 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d7 = System.Math.Round((d7 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d8 = System.Math.Round((d8 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d9 = System.Math.Round((d9 / TotStud) * 100 + 0.0000001, 1)
					
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Bajo = System.Math.Round((Bajo / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Prom = System.Math.Round((Prom / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Sobre = System.Math.Round((Sobre / TotStud) * 100 + 0.0000001, 1)
					
				End If
				
				Rs.Close()
			Case "R" 'ingles
				If xGrade > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object sClave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object dRepID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					sQuery = "SELECT Resultados.resg_rep_id, ResEst.rese_esta_r, Resultados.resg_REN, resultados.resg_grado " & "FROM Resultados INNER JOIN ResEst ON Resultados.resg_id = ResEst.resg_id " & "WHERE (((Resultados.resg_rep_id)=" & dRepID & ") AND ((Resultados.resg_REN)" & sClave & ") AND ((Resultados.resg_grado)= " & xGrade & ")) "
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object sClave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object dRepID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					sQuery = "SELECT Resultados.resg_rep_id, ResEst.rese_esta_r, Resultados.resg_REN, resultados.resg_grado " & "FROM Resultados INNER JOIN ResEst ON Resultados.resg_id = ResEst.resg_id " & "WHERE (((Resultados.resg_rep_id)=" & dRepID & ") AND ((Resultados.resg_REN)" & sClave & ")) "
				End If
				
				Rs.Open(sQuery, Cn, 3, 3)
				
				While Not Rs.EOF
					ResgGrade = Rs.Fields("resg_Grado").Value
					If Rs.Fields("rese_esta_r").Value < 1.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d1 = d1 + 1
					End If
					If Rs.Fields("rese_esta_r").Value >= 1.5 And Rs.Fields("rese_esta_r").Value < 2.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d2 = d2 + 1
					End If
					If Rs.Fields("rese_esta_r").Value >= 2.5 And Rs.Fields("rese_esta_r").Value < 3.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d3 = d3 + 1
					End If
					If Rs.Fields("rese_esta_r").Value >= 3.5 And Rs.Fields("rese_esta_r").Value < 4.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d4 = d4 + 1
					End If
					If Rs.Fields("rese_esta_r").Value >= 4.5 And Rs.Fields("rese_esta_r").Value < 5.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d5 = d5 + 1
					End If
					If Rs.Fields("rese_esta_r").Value >= 5.5 And Rs.Fields("rese_esta_r").Value < 6.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d6 = d6 + 1
					End If
					If Rs.Fields("rese_esta_r").Value >= 6.5 And Rs.Fields("rese_esta_r").Value < 7.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d7 = d7 + 1
					End If
					If Rs.Fields("rese_esta_r").Value >= 7.5 And Rs.Fields("rese_esta_r").Value < 8.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d8 = d8 + 1
					End If
					If Rs.Fields("rese_esta_r").Value >= 8.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d9 = d9 + 1
					End If
					
					
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					TotStud = TotStud + 1
					Rs.MoveNext()
				End While
				'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If TotStud > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Sobre = d7 + d8 + d9
					'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Prom = d4 + d5 + d6
					'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Bajo = d1 + d2 + d3
					'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					SobreTotStud = d7 + d8 + d9
					'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					PromTotStud = d4 + d5 + d6
					'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					BajoTotStud = d1 + d2 + d3
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d1 = System.Math.Round((d1 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d2 = System.Math.Round((d2 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d3 = System.Math.Round((d3 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d4 = System.Math.Round((d4 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d5 = System.Math.Round((d5 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d6 = System.Math.Round((d6 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d7 = System.Math.Round((d7 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d8 = System.Math.Round((d8 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d9 = System.Math.Round((d9 / TotStud) * 100 + 0.0000001, 1)
					
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Bajo = System.Math.Round((Bajo / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Prom = System.Math.Round((Prom / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Sobre = System.Math.Round((Sobre / TotStud) * 100 + 0.0000001, 1)
				End If
				Rs.Close()
			Case "L" 'espanol
				If xGrade > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object sClave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object dRepID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					sQuery = "SELECT Resultados.resg_rep_id, ResEst.rese_esta_l, Resultados.resg_LES, resultados.resg_grado " & "FROM Resultados INNER JOIN ResEst ON Resultados.resg_id = ResEst.resg_id " & "WHERE (((Resultados.resg_rep_id)=" & dRepID & ") AND ((Resultados.resg_LES) " & sClave & " AND (Resultados.resg_LES <> 68)) AND ((Resultados.resg_grado)= " & xGrade & ")) "
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object sClave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object dRepID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					sQuery = "SELECT Resultados.resg_rep_id, ResEst.rese_esta_l, Resultados.resg_LES, resultados.resg_grado " & "FROM Resultados INNER JOIN ResEst ON Resultados.resg_id = ResEst.resg_id " & "WHERE (((Resultados.resg_rep_id)=" & dRepID & ") AND ((Resultados.resg_LES)" & sClave & ") AND (Resultados.resg_LES <> 68)  ) "
				End If
				
				Rs.Open(sQuery, Cn, 3, 3)
				
				While Not Rs.EOF
					ResgGrade = Rs.Fields("resg_Grado").Value
					If Rs.Fields("rese_esta_l").Value < 1.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d1 = d1 + 1
					End If
					If Rs.Fields("rese_esta_l").Value >= 1.5 And Rs.Fields("rese_esta_l").Value < 2.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d2 = d2 + 1
					End If
					If Rs.Fields("rese_esta_l").Value >= 2.5 And Rs.Fields("rese_esta_l").Value < 3.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d3 = d3 + 1
					End If
					If Rs.Fields("rese_esta_l").Value >= 3.5 And Rs.Fields("rese_esta_l").Value < 4.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d4 = d4 + 1
					End If
					If Rs.Fields("rese_esta_l").Value >= 4.5 And Rs.Fields("rese_esta_l").Value < 5.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d5 = d5 + 1
					End If
					If Rs.Fields("rese_esta_l").Value >= 5.5 And Rs.Fields("rese_esta_l").Value < 6.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d6 = d6 + 1
					End If
					If Rs.Fields("rese_esta_l").Value >= 6.5 And Rs.Fields("rese_esta_l").Value < 7.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d7 = d7 + 1
					End If
					If Rs.Fields("rese_esta_l").Value >= 7.5 And Rs.Fields("rese_esta_l").Value < 8.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d8 = d8 + 1
					End If
					If Rs.Fields("rese_esta_l").Value >= 8.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d9 = d9 + 1
					End If
					
					
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					TotStud = TotStud + 1
					Rs.MoveNext()
				End While
				'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If TotStud > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Sobre = d7 + d8 + d9
					'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Prom = d4 + d5 + d6
					'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Bajo = d1 + d2 + d3
					'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					SobreTotStud = d7 + d8 + d9
					'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					PromTotStud = d4 + d5 + d6
					'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					BajoTotStud = d1 + d2 + d3
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d1 = System.Math.Round((d1 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d2 = System.Math.Round((d2 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d3 = System.Math.Round((d3 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d4 = System.Math.Round((d4 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d5 = System.Math.Round((d5 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d6 = System.Math.Round((d6 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d7 = System.Math.Round((d7 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d8 = System.Math.Round((d8 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d9 = System.Math.Round((d9 / TotStud) * 100 + 0.0000001, 1)
					
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Bajo = System.Math.Round((Bajo / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Prom = System.Math.Round((Prom / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Sobre = System.Math.Round((Sobre / TotStud) * 100 + 0.0000001, 1)
				End If
				Rs.Close()
		End Select
		
	End Function
	
	Function GetStaninePromT1(ByRef sCol As String, ByRef xmateria As Object, ByRef Bajo As Object, ByRef Prom As Object, ByRef Sobre As Object, ByRef TotStud As Object, ByRef d1 As Object, ByRef d2 As Object, ByRef d3 As Object, ByRef d4 As Object, ByRef d5 As Object, ByRef d6 As Object, ByRef d7 As Object, ByRef d8 As Object, ByRef d9 As Object, Optional ByRef xClave As Short = 0, Optional ByRef ResgGrade As Short = 0, Optional ByRef BajoTotStud As Short = 0, Optional ByRef PromTotStud As Short = 0, Optional ByRef SobreTotStud As Short = 0) As Object
		Dim sClave As Object
		Dim sQuery As String
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		
		'--
		Cn = CreateObject("ADODB.Connection")
		Rs = CreateObject("ADODB.Recordset")
		
		OpenConnection(Cn, Config.ConnectionString)
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Bajo = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Prom = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Sobre = 0
		BajoTotStud = 0
		PromTotStud = 0
		SobreTotStud = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d1 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d2 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d3 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d4 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d5 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d6 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d7 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d8 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		d9 = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TotStud = 0
		If xClave > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object sClave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sClave = " = " & xClave
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object sClave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sClave = ">0"
		End If
		
		Select Case xmateria
			Case "M" 'Matematicas
				If sCol = "" Then
					'UPGRADE_WARNING: Couldn't resolve default property of object sClave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					sQuery = "SELECT Resultados.resg_rep_id, ResEst.rese_esta_m, Resultados.resg_MAT,Resultados.resg_grado " & "FROM Resultados INNER JOIN ResEst ON Resultados.resg_id = ResEst.resg_id " & "INNER JOIN schools ON Resultados.reg_sc_id = Schools.sc_id " & "INNER JOIN reports ON Resultados.resg_rep_id = Reports.rep_id " & "WHERE (((Schools.sc_comp)= '" & frmT1Dist.cboComp.Text & "') AND ((Resultados.resg_MAT)" & sClave & ") AND " & "(Resultados.reg_serv_date >= '" & frmT1Dist.txtDesde.Text & "') AND " & "(Resultados.reg_serv_date <= '" & frmT1Dist.txtHasta.Text & "') AND " & "(Reports.rep_sem = '" & frmT1Dist.cboSem.Text & "') AND (Reports.rep_type = 2) " & ") "
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object sClave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					sQuery = "SELECT Resultados.resg_rep_id, ResEst.rese_esta_m, Resultados.resg_MAT,Resultados.resg_grado " & "FROM Resultados INNER JOIN ResEst ON Resultados.resg_id = ResEst.resg_id " & "INNER JOIN schools ON Resultados.reg_sc_id = Schools.sc_id " & "INNER JOIN reports ON Resultados.resg_rep_id = Reports.rep_id " & "WHERE (((Schools.sc_id)= " & sCol & ") AND ((Resultados.resg_MAT)" & sClave & ") AND " & "(Resultados.reg_serv_date >= '" & frmT1Dist.txtDesde.Text & "') AND " & "(Resultados.reg_serv_date <= '" & frmT1Dist.txtHasta.Text & "') AND " & "(Reports.rep_sem = '" & frmT1Dist.cboSem.Text & "') AND (Reports.rep_type = 2) " & ") "
				End If
				Rs.Open(sQuery, Cn, 3, 3)
				
				While Not Rs.EOF
					ResgGrade = Rs.Fields("resg_Grado").Value
					If Rs.Fields("rese_esta_m").Value < 1.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d1 = d1 + 1
					End If
					If Rs.Fields("rese_esta_m").Value >= 1.5 And Rs.Fields("rese_esta_m").Value < 2.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d2 = d2 + 1
					End If
					If Rs.Fields("rese_esta_m").Value >= 2.5 And Rs.Fields("rese_esta_m").Value < 3.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d3 = d3 + 1
					End If
					If Rs.Fields("rese_esta_m").Value >= 3.5 And Rs.Fields("rese_esta_m").Value < 4.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d4 = d4 + 1
					End If
					If Rs.Fields("rese_esta_m").Value >= 4.5 And Rs.Fields("rese_esta_m").Value < 5.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d5 = d5 + 1
					End If
					If Rs.Fields("rese_esta_m").Value >= 5.5 And Rs.Fields("rese_esta_m").Value < 6.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d6 = d6 + 1
					End If
					If Rs.Fields("rese_esta_m").Value >= 6.5 And Rs.Fields("rese_esta_m").Value < 7.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d7 = d7 + 1
					End If
					If Rs.Fields("rese_esta_m").Value >= 7.5 And Rs.Fields("rese_esta_m").Value < 8.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d8 = d8 + 1
					End If
					If Rs.Fields("rese_esta_m").Value >= 8.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d9 = d9 + 1
					End If
					
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					TotStud = TotStud + 1
					Rs.MoveNext()
				End While
				'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If TotStud > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Sobre = d7 + d8 + d9
					'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Prom = d4 + d5 + d6
					'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Bajo = d1 + d2 + d3
					'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					SobreTotStud = d7 + d8 + d9
					'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					PromTotStud = d4 + d5 + d6
					'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					BajoTotStud = d1 + d2 + d3
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d1 = System.Math.Round((d1 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d2 = System.Math.Round((d2 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d3 = System.Math.Round((d3 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d4 = System.Math.Round((d4 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d5 = System.Math.Round((d5 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d6 = System.Math.Round((d6 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d7 = System.Math.Round((d7 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d8 = System.Math.Round((d8 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d9 = System.Math.Round((d9 / TotStud) * 100 + 0.0000001, 1)
					
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Bajo = System.Math.Round((Bajo / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Prom = System.Math.Round((Prom / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Sobre = System.Math.Round((Sobre / TotStud) * 100 + 0.0000001, 1)
					
				End If
				
				Rs.Close()
			Case "R" 'ingles
				If sCol = "" Then
					'UPGRADE_WARNING: Couldn't resolve default property of object sClave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					sQuery = "SELECT Resultados.resg_rep_id, ResEst.rese_esta_r, Resultados.resg_MAT,Resultados.resg_grado " & "FROM Resultados INNER JOIN ResEst ON Resultados.resg_id = ResEst.resg_id " & "INNER JOIN schools ON Resultados.reg_sc_id = Schools.sc_id " & "INNER JOIN reports ON Resultados.resg_rep_id = Reports.rep_id " & "WHERE (((Schools.sc_comp)= '" & frmT1Dist.cboComp.Text & "') AND ((Resultados.resg_REN)" & sClave & ") AND " & "(Resultados.reg_serv_date >= '" & frmT1Dist.txtDesde.Text & "') AND " & "(Resultados.reg_serv_date <= '" & frmT1Dist.txtHasta.Text & "') AND " & "(Reports.rep_sem = '" & frmT1Dist.cboSem.Text & "') AND (Reports.rep_type = 2) " & ") "
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object sClave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					sQuery = "SELECT Resultados.resg_rep_id, ResEst.rese_esta_r, Resultados.resg_MAT,Resultados.resg_grado " & "FROM Resultados INNER JOIN ResEst ON Resultados.resg_id = ResEst.resg_id " & "INNER JOIN schools ON Resultados.reg_sc_id = Schools.sc_id " & "INNER JOIN reports ON Resultados.resg_rep_id = Reports.rep_id " & "WHERE (((Schools.sc_id)= " & sCol & ") AND ((Resultados.resg_REN)" & sClave & ") AND " & "(Resultados.reg_serv_date >= '" & frmT1Dist.txtDesde.Text & "') AND " & "(Resultados.reg_serv_date <= '" & frmT1Dist.txtHasta.Text & "') AND " & "(Reports.rep_sem = '" & frmT1Dist.cboSem.Text & "') AND (Reports.rep_type = 2) " & ") "
				End If
				
				Rs.Open(sQuery, Cn, 3, 3)
				
				While Not Rs.EOF
					ResgGrade = Rs.Fields("resg_Grado").Value
					If Rs.Fields("rese_esta_r").Value < 1.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d1 = d1 + 1
					End If
					If Rs.Fields("rese_esta_r").Value >= 1.5 And Rs.Fields("rese_esta_r").Value < 2.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d2 = d2 + 1
					End If
					If Rs.Fields("rese_esta_r").Value >= 2.5 And Rs.Fields("rese_esta_r").Value < 3.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d3 = d3 + 1
					End If
					If Rs.Fields("rese_esta_r").Value >= 3.5 And Rs.Fields("rese_esta_r").Value < 4.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d4 = d4 + 1
					End If
					If Rs.Fields("rese_esta_r").Value >= 4.5 And Rs.Fields("rese_esta_r").Value < 5.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d5 = d5 + 1
					End If
					If Rs.Fields("rese_esta_r").Value >= 5.5 And Rs.Fields("rese_esta_r").Value < 6.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d6 = d6 + 1
					End If
					If Rs.Fields("rese_esta_r").Value >= 6.5 And Rs.Fields("rese_esta_r").Value < 7.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d7 = d7 + 1
					End If
					If Rs.Fields("rese_esta_r").Value >= 7.5 And Rs.Fields("rese_esta_r").Value < 8.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d8 = d8 + 1
					End If
					If Rs.Fields("rese_esta_r").Value >= 8.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d9 = d9 + 1
					End If
					
					
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					TotStud = TotStud + 1
					Rs.MoveNext()
				End While
				'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If TotStud > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Sobre = d7 + d8 + d9
					'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Prom = d4 + d5 + d6
					'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Bajo = d1 + d2 + d3
					'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					SobreTotStud = d7 + d8 + d9
					'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					PromTotStud = d4 + d5 + d6
					'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					BajoTotStud = d1 + d2 + d3
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d1 = System.Math.Round((d1 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d2 = System.Math.Round((d2 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d3 = System.Math.Round((d3 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d4 = System.Math.Round((d4 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d5 = System.Math.Round((d5 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d6 = System.Math.Round((d6 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d7 = System.Math.Round((d7 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d8 = System.Math.Round((d8 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d9 = System.Math.Round((d9 / TotStud) * 100 + 0.0000001, 1)
					
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Bajo = System.Math.Round((Bajo / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Prom = System.Math.Round((Prom / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Sobre = System.Math.Round((Sobre / TotStud) * 100 + 0.0000001, 1)
				End If
				Rs.Close()
			Case "L" 'espanol
				If sCol = "" Then
					'UPGRADE_WARNING: Couldn't resolve default property of object sClave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					sQuery = "SELECT Resultados.resg_rep_id, ResEst.rese_esta_l, Resultados.resg_MAT,Resultados.resg_grado " & "FROM Resultados INNER JOIN ResEst ON Resultados.resg_id = ResEst.resg_id " & "INNER JOIN schools ON Resultados.reg_sc_id = Schools.sc_id " & "INNER JOIN reports ON Resultados.resg_rep_id = Reports.rep_id " & "WHERE (((Schools.sc_comp)= '" & frmT1Dist.cboComp.Text & "') AND ((Resultados.resg_LES)" & sClave & ") AND " & "(Resultados.reg_serv_date >= '" & frmT1Dist.txtDesde.Text & "') AND " & "(Resultados.reg_serv_date <= '" & frmT1Dist.txtHasta.Text & "') AND " & "(Reports.rep_sem = '" & frmT1Dist.cboSem.Text & "') AND (Reports.rep_type = 2) " & ") "
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object sClave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					sQuery = "SELECT Resultados.resg_rep_id, ResEst.rese_esta_l, Resultados.resg_MAT,Resultados.resg_grado " & "FROM Resultados INNER JOIN ResEst ON Resultados.resg_id = ResEst.resg_id " & "INNER JOIN schools ON Resultados.reg_sc_id = Schools.sc_id " & "INNER JOIN reports ON Resultados.resg_rep_id = Reports.rep_id " & "WHERE (((Schools.sc_id)= " & sCol & ") AND ((Resultados.resg_LES)" & sClave & ") AND " & "(Resultados.reg_serv_date >= '" & frmT1Dist.txtDesde.Text & "') AND " & "(Resultados.reg_serv_date <= '" & frmT1Dist.txtHasta.Text & "') AND " & "(Reports.rep_sem = '" & frmT1Dist.cboSem.Text & "') AND (Reports.rep_type = 2) " & ") "
				End If
				
				Rs.Open(sQuery, Cn, 3, 3)
				
				While Not Rs.EOF
					ResgGrade = Rs.Fields("resg_Grado").Value
					If Rs.Fields("rese_esta_l").Value < 1.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d1 = d1 + 1
					End If
					If Rs.Fields("rese_esta_l").Value >= 1.5 And Rs.Fields("rese_esta_l").Value < 2.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d2 = d2 + 1
					End If
					If Rs.Fields("rese_esta_l").Value >= 2.5 And Rs.Fields("rese_esta_l").Value < 3.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d3 = d3 + 1
					End If
					If Rs.Fields("rese_esta_l").Value >= 3.5 And Rs.Fields("rese_esta_l").Value < 4.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d4 = d4 + 1
					End If
					If Rs.Fields("rese_esta_l").Value >= 4.5 And Rs.Fields("rese_esta_l").Value < 5.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d5 = d5 + 1
					End If
					If Rs.Fields("rese_esta_l").Value >= 5.5 And Rs.Fields("rese_esta_l").Value < 6.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d6 = d6 + 1
					End If
					If Rs.Fields("rese_esta_l").Value >= 6.5 And Rs.Fields("rese_esta_l").Value < 7.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d7 = d7 + 1
					End If
					If Rs.Fields("rese_esta_l").Value >= 7.5 And Rs.Fields("rese_esta_l").Value < 8.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d8 = d8 + 1
					End If
					If Rs.Fields("rese_esta_l").Value >= 8.5 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						d9 = d9 + 1
					End If
					
					
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					TotStud = TotStud + 1
					Rs.MoveNext()
				End While
				'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If TotStud > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Sobre = d7 + d8 + d9
					'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Prom = d4 + d5 + d6
					'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Bajo = d1 + d2 + d3
					'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					SobreTotStud = d7 + d8 + d9
					'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					PromTotStud = d4 + d5 + d6
					'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					BajoTotStud = d1 + d2 + d3
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d1 = System.Math.Round((d1 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d2 = System.Math.Round((d2 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d3 = System.Math.Round((d3 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d4 = System.Math.Round((d4 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d5. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d5 = System.Math.Round((d5 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d6. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d6 = System.Math.Round((d6 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d7. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d7 = System.Math.Round((d7 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d8. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d8 = System.Math.Round((d8 / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object d9. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					d9 = System.Math.Round((d9 / TotStud) * 100 + 0.0000001, 1)
					
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Bajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Bajo = System.Math.Round((Bajo / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Prom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Prom = System.Math.Round((Prom / TotStud) * 100 + 0.0000001, 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object TotStud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object Sobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Sobre = System.Math.Round((Sobre / TotStud) * 100 + 0.0000001, 1)
				End If
				Rs.Close()
		End Select
		
	End Function
	Function GetStrGrade(ByRef iGrade As Short) As String
		Dim Ret As String
		
		Select Case iGrade
			Case 0
				Ret = "Kindergarten"
			Case 1
				Ret = "Primero"
			Case 2
				Ret = "Segundo"
			Case 3
				Ret = "Tercero"
			Case 4
				Ret = "Cuarto"
			Case 5
				Ret = "Quinto"
			Case 6
				Ret = "Sexto"
			Case 7
				Ret = "Séptimo"
			Case 8
				Ret = "Octavo"
			Case 9
				Ret = "Noveno"
			Case 10
				Ret = "Décimo"
			Case 11
				Ret = "Undécimo"
			Case 12
				Ret = "Duodécimo"
		End Select
		
		GetStrGrade = Ret
		
	End Function
	
	
	Function Potencial_Academico(ByRef dRepID As Double) As Object
		Dim Line2 As Object
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		Dim sQuery As String
		Dim TotStud As Short
		Dim CurrGrado As Short
		Dim Prom As Short
		Dim SobreProm As Short
		Dim BajoProm As Short
		Dim iTotP As Short
		Dim iTotSP As Short
		Dim iTotB As Short
		Dim iTotal As Short
		Dim HD As Object
		Dim td As Object
		Dim bEnter As Boolean
		
		Cn = CreateObject("adodb.connection")
		Rs = CreateObject("adodb.recordset")
		
		OpenConnection(Cn, Config.ConnectionString)
		
		sQuery = "SELECT Resultados.resg_Grado, ResEst.rese_coc_pot " & "FROM Resultados INNER JOIN ResEst ON Resultados.resg_id = ResEst.resg_id INNER JOIN Reports ON Resultados.resg_rep_id = Reports.Rep_ID " & "Where (Resultados.resg_rep_id = " & dRepID & ") And (Reports.Rep_Sem + Resultados.resg_Grado > 2) " & "ORDER BY .Resultados.resg_Grado "
		
		Rs.Open(sQuery, Cn, 3, 3)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object GetPotentialHeader(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = GetPotentialHeader()
		'HD = HD & "<table width=80% align=center border=1 cellpadding=5 cellspacing=0 bordercolor=black>"
		'HD = HD & "<tr>"
		'HD = HD & "  <td width=20% align=center><b>GRADO</TD>"
		'HD = HD & "  <td width=20% align=center><b>TOTAL DE ESTUDIANTES</TD>"
		'HD = HD & "  <TD width=30% align=center><b>NÚMERO EST.<br>PROMEDIO<br></b>(Desde 89 hasta 112)</td>"
		'HD = HD & "  <TD width=30% align=center><b>NÚMERO EST.<br>SOBRE<br>PROMEDIO<br></b>(113 o más)</td>"
		'HD = HD & "</tr>"
		
		TotStud = 0
		CurrGrado = 0
		Prom = 0
		SobreProm = 0
		BajoProm = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object Line2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Line2 = True
		bEnter = False
		While Not Rs.EOF
			bEnter = True
			If CurrGrado <> Rs.Fields("resg_Grado").Value Then
				If TotStud > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object Line2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If Line2 = True Then
						'UPGRADE_WARNING: Couldn't resolve default property of object GetPotential2ndLine(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						td = GetPotential2ndLine()
						'UPGRADE_WARNING: Couldn't resolve default property of object Line2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						Line2 = False
					Else
						'Verifico que sea la ultima linea
						'UPGRADE_WARNING: Couldn't resolve default property of object GetPotentialLine(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						td = GetPotentialLine()
					End If
					'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					td = Replace(td, "[GRADO]", "<b>" & GetStrGrade(CurrGrado) & "</b>")
					'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					td = Replace(td, "[TOT]", CStr(TotStud))
					'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					td = Replace(td, "[PROM]", CStr(Prom))
					'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					td = Replace(td, "[SOBRE]", CStr(SobreProm))
					'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					td = Replace(td, "[BAJO]", CStr(BajoProm))
					'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					HD = HD & td
				End If
				CurrGrado = Rs.Fields("resg_Grado").Value
				TotStud = 0
				Prom = 0
				SobreProm = 0
				BajoProm = 0
			End If
			
			TotStud = TotStud + 1
			iTotal = iTotal + 1
			If Rs.Fields("rese_coc_pot").Value >= 89 And Rs.Fields("rese_coc_pot").Value <= 112 Then
				Prom = Prom + 1
				iTotP = iTotP + 1
			ElseIf Rs.Fields("rese_coc_pot").Value >= 113 Then 
				SobreProm = SobreProm + 1
				iTotSP = iTotSP + 1
			ElseIf Rs.Fields("rese_coc_pot").Value <= 88 Then 
				BajoProm = BajoProm + 1
				iTotB = iTotB + 1
			End If
			
			Rs.MoveNext()
		End While
		
		If TotStud > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object GetPotentialLastLine(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = GetPotentialLastLine(False, False)
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = Replace(td, "[GRADO]", "<b>" & GetStrGrade(CurrGrado) & "</b>")
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = Replace(td, "[TOT]", CStr(TotStud))
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = Replace(td, "[PROM]", CStr(Prom))
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = Replace(td, "[SOBRE]", CStr(SobreProm))
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = Replace(td, "[BAJO]", CStr(BajoProm))
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			HD = HD & td
		End If
		
		'Print total line #1 (total SP, total Prom)
		'UPGRADE_WARNING: Couldn't resolve default property of object GetPotentialLastLine(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		td = GetPotentialLastLine(False, True)
		'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		td = Replace(td, "[GRADO]", "")
		'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		td = Replace(td, "[TOT]", "")
		If iTotal > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = Replace(td, "[PROM]", "<b>" & iTotP & " (" & System.Math.Round((iTotP / iTotal) * 100, 0) & "%)</b>")
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = Replace(td, "[SOBRE]", "<b>" & iTotSP & " (" & System.Math.Round((iTotSP / iTotal) * 100, 0) & "%)</b>")
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = Replace(td, "[PROM]", "")
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = Replace(td, "[SOBRE]", "")
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		td = Replace(td, "[BAJO]", "")
		'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = HD & td
		
		'Print total line #2 (total students, SP + Prom, Tot BP)
		'UPGRADE_WARNING: Couldn't resolve default property of object GetPotentialLastLine(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		td = GetPotentialLastLine(True, True)
		'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		td = Replace(td, "[GRADO]", "<b>Total</b>")
		'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		td = Replace(td, "[TOT]", "<b>" & iTotal & "</b>")
		If iTotal > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = Replace(td, "[SP_P]", "<b>" & CStr(iTotP + iTotSP) & " (" & System.Math.Round(((iTotP + iTotSP) / iTotal) * 100, 0) & "%)</b>")
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = Replace(td, "[BAJO]", "<b>" & iTotB & " (" & System.Math.Round((iTotB / iTotal) * 100, 0) & "%)</b>")
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = Replace(td, "[SP_P]", "")
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = Replace(td, "[BAJO]", "")
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		td = Replace(td, "[SOBRE]", "")
		'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = HD & td
		
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = HD & " </tr>"
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = HD & "</table>"
		
		Rs.Close()
		Cn.Close()
		
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If bEnter = False Then HD = ""
		
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Potencial_Academico. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Potencial_Academico = HD
		
	End Function
	
	Function Table_APRESTO(ByRef dRepID As Double) As Object
        Dim iCtr As Integer
		Dim sTitle As Object
		
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		
		Dim sQuery As String
		Dim HD As Object
		Dim td As Object
		Dim AIDAvg As Short
		
		Cn = CreateObject("adodb.connection")
		Rs = CreateObject("adodb.recordset")
		
		OpenConnection(Cn, Config.ConnectionString)
		
		sQuery = "Select resg_grado, resg_section, resg_id from Resultados where resg_rep_id = " & dRepID & " and resg_AID = 51 order by resg_grado, resg_section"
		Rs.Open(sQuery, Cn, 3, 3)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = ""
		If Rs.RecordCount > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			HD = HD & "  <center><span lang=ES-PR style='font-family:Arial;font-size:14pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'><b>PORCIENTO DE ESTUDIANTES QUE DOMINARON CADA DESTREZA EN LA</b></span><br>"
			'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			HD = HD & "  <span lang=ES-PR style='font-family:Arial;font-size:14pt;mso-bidi-font-size:14.0pt;mso-ansi-language:ES-PR'><b>PRUEBA DE APRESTO</B></span><br><br></center></p>"
			'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			HD = HD & "<table width=70% align=center border=1 cellpadding=5 cellspacing=0 bordercolor=black>"
			'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			HD = HD & "<tr BGCOLOR=#CCCCCC>"
			'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			HD = HD & "  <td align=center><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'><b>Grado</b></span></p></td>"
			
			'Hacer loop por todo el recordset para crear todos los TD del header
			While Not Rs.EOF
				'UPGRADE_WARNING: Couldn't resolve default property of object sTitle. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				sTitle = Rs.Fields("resg_grado").Value & "-" & Rs.Fields("resg_section").Value
				'UPGRADE_WARNING: Couldn't resolve default property of object sTitle. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Left(sTitle, 1) = "0" Then sTitle = "K" & Mid(sTitle, 2)
				
				'UPGRADE_WARNING: Couldn't resolve default property of object sTitle. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				HD = HD & "  <td align=center><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'><b>" & sTitle & "</b></p></span></td>"
				Rs.MoveNext()
			End While
			
			Rs.MoveFirst()
			
			'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			HD = HD & "</tr>"
		End If
		
		Dim AIDOrder(10) As Short
		
		AIDOrder(1) = 1
		AIDOrder(2) = 2
		AIDOrder(3) = 3
		AIDOrder(4) = 4
		AIDOrder(5) = 6
		AIDOrder(6) = 5
		AIDOrder(7) = 8
		AIDOrder(8) = 10
		AIDOrder(9) = 7
		AIDOrder(10) = 9
		
		
        For iCtr = 1 To 10
            'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            td = ""
            'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            td = td & "<tr>"
            'UPGRADE_WARNING: Couldn't resolve default property of object iCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            td = td & "  <td align=left BGCOLOR=#E6E6E6 width=230><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'>" & GetAIDDesc(AIDOrder(iCtr)) & "</span></td>"
            Rs.MoveFirst()
            While Not Rs.EOF
                'UPGRADE_WARNING: Couldn't resolve default property of object iCtr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object GetAIDAvg(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                AIDAvg = GetAIDAvg(Decimal.Parse(Rs.Fields("resg_id").Value), Short.Parse(AIDOrder(iCtr)))
                If AIDAvg < 80 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    td = td & "  <td align=center bgcolor=#ffc4c4><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'>" & AIDAvg & " </span></p></TD>"
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    td = td & "  <td align=center><span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'>" & AIDAvg & "</span></p></TD>"
                End If
                Rs.MoveNext()
            End While
            'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            td = td & "</tr>"
            'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            HD = HD & td
        Next iCtr
		
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If HD <> "" Then HD = HD & "</table>"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Get50Footer(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = HD & Get50Footer("<span lang=ES-PR style='font-family:Arial;font-size:12pt;mso-bidi-font-size:12.0pt;mso-ansi-language:ES-PR'><b>Menos del 80% =</b></span></p>")
		
		Rs.Close()
		Cn.Close()
		
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Table_APRESTO. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Table_APRESTO = "<BR><BR>" & HD
		
	End Function
	
	
	
	Function Table_COMPARACION(ByRef dRepID As Double) As Object
		Dim X As Object
		Dim d9 As Object
		Dim d8 As Object
		Dim d7 As Object
		Dim d6 As Object
		Dim d5 As Object
		Dim d4 As Object
		Dim d3 As Object
		Dim d2 As Object
		Dim d1 As Object
		Dim Prev1Grado As Object
		Dim Prev2Grado As Object
		Dim SobreProm As Object
		Dim PrevYear2_Date As Object
		Dim PrevYear1_Date As Object
		Dim CurrYear_Date As Object
		
		Dim Cn As ADODB.Connection
		Dim Rs As ADODB.Recordset
		Dim RsRes As ADODB.Recordset
		
		Dim sQuery As String
		Dim TotStud As Short
		Dim CurrGrado As Short
		Dim HD As Object
		Dim td As Object
		Dim CurrYear As String
		Dim PrevYear1 As String
		Dim PrevYear2 As String
		Dim Prev1ID As Double
		Dim Prev2ID As Double
		Dim Sch_ID As Double
		Dim CurrSem As Short
		Dim Bajo As Double
		Dim Prom As Double
		Dim Sobre As Double
		
		
		Cn = CreateObject("adodb.connection")
		Rs = CreateObject("adodb.recordset")
		RsRes = CreateObject("adodb.recordset")
		
		OpenConnection(Cn, Config.ConnectionString)
		
		sQuery = "SELECT Rep_Year, Rep_Sem, Rep_SCH_ID,rep_serv_date from Reports where rep_id = " & dRepID
		
		Rs.Open(sQuery, Cn, 3, 3)
		
		If Rs.Fields("Rep_Sem").Value = 1 Then
			CurrYear = Rs.Fields("Rep_Year").Value & "-" & (Rs.Fields("Rep_Year").Value + 1)
			'UPGRADE_WARNING: Couldn't resolve default property of object CurrYear_Date. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CurrYear_Date = Rs.Fields("rep_serv_date").Value
			PrevYear1 = (Rs.Fields("Rep_Year").Value - 1) & "-" & (Rs.Fields("Rep_Year")).Value
			PrevYear2 = (Rs.Fields("Rep_Year").Value - 2) & "-" & (Rs.Fields("Rep_Year").Value - 1)
		Else
			CurrYear = (Rs.Fields("Rep_Year").Value - 1) & "-" & (Rs.Fields("Rep_Year")).Value
			'UPGRADE_WARNING: Couldn't resolve default property of object CurrYear_Date. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			CurrYear_Date = Rs.Fields("rep_serv_date").Value
			PrevYear1 = (Rs.Fields("Rep_Year").Value - 2) & "-" & (Rs.Fields("Rep_Year").Value - 1)
			PrevYear2 = (Rs.Fields("Rep_Year").Value - 3) & "-" & (Rs.Fields("Rep_Year").Value - 2)
		End If
		Sch_ID = Rs.Fields("rep_sch_id").Value
		CurrSem = Rs.Fields("Rep_Sem").Value
		Rs.Close()
		
		'--GET OTHER 2 PREVIOUS REPORTS ID
		sQuery = "SELECT TOP 2 * from Reports where REP_SCH_ID = " & Sch_ID & " and rep_type = 2  and rep_id <> " & dRepID & " and rep_reposicion = 0 and rep_AcomRazonable = 0 and rep_pepv = 0 order by rep_serv_date DESC "
		
		Rs.Open(sQuery, Cn, 3, 3)
		
		Select Case Rs.RecordCount
			Case 2
				Prev1ID = Rs.Fields("Rep_ID").Value
				'UPGRADE_WARNING: Couldn't resolve default property of object PrevYear1_Date. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				PrevYear1_Date = Rs.Fields("rep_serv_date").Value
				Rs.MoveNext()
				Prev2ID = Rs.Fields("Rep_ID").Value
				'UPGRADE_WARNING: Couldn't resolve default property of object PrevYear2_Date. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				PrevYear2_Date = Rs.Fields("rep_serv_date").Value
			Case 1
				Prev1ID = Rs.Fields("Rep_ID").Value
				'UPGRADE_WARNING: Couldn't resolve default property of object PrevYear1_Date. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				PrevYear1_Date = Rs.Fields("rep_serv_date").Value
				Prev2ID = 0
				'UPGRADE_WARNING: Couldn't resolve default property of object PrevYear2_Date. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				PrevYear2_Date = ""
			Case Else
				Prev1ID = 0
				Prev2ID = 0
				'UPGRADE_WARNING: Couldn't resolve default property of object PrevYear2_Date. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				PrevYear2_Date = ""
				'UPGRADE_WARNING: Couldn't resolve default property of object PrevYear1_Date. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				PrevYear1_Date = ""
		End Select
		
		Rs.Close()
		'--
		
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = ""
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = HD & "<table width=90% border=1 cellpadding=1 cellspacing=0 bordercolor=black align=center>"
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = HD & "    <tr BGCOLOR=#CCCCCC>"
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = HD & "        <td align=center><p class=MsoBodyText>Prueba</p></td>"
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = HD & "        <td align=center><p class=MsoBodyText>Grado</p></td>"
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = HD & "        <td colspan=3 align=center><p class=MsoBodyText>" & SetShortDate(PrevYear2_Date, False) & "</p></td>"
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = HD & "        <td align=center><p class=MsoBodyText>Grado</p></td>"
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = HD & "        <td colspan=3 align=center><p class=MsoBodyText>" & SetShortDate(PrevYear1_Date, False) & "</p></td>"
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = HD & "        <td align=center><p class=MsoBodyText>Grado</p></td>"
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = HD & "        <td colspan=3 align=center><p class=MsoBodyText>" & SetShortDate(CurrYear_Date, False) & "</p></td>"
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = HD & "    </tr>"
		
		
		
		TotStud = 0
		CurrGrado = 0
		Prom = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object SobreProm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		SobreProm = 0
		
		sQuery = "SELECT Resultados.resg_Grado " & "FROM Resultados INNER JOIN Reports ON Resultados.resg_rep_id = Reports.Rep_ID " & "Where (Resultados.resg_rep_id = " & dRepID & ") And (Reports.Rep_Sem + Resultados.resg_Grado > 2) " & "GROUP BY Resultados.resg_Grado ORDER BY resg_grado"
		
		Rs.Open(sQuery, Cn, 3, 3)
		
		While Not Rs.EOF
			CurrGrado = Rs.Fields("resg_Grado").Value
			
			'----LINEA HEADER-----
			
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = ""
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = td & "<tr BGCOLOR=#E6E6E6>"
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
			
			'ESCRIBIR COLUMNAS DEL ANO 2
			'UPGRADE_WARNING: Couldn't resolve default property of object Prev2Grado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Prev2Grado = 0
			If Prev2ID > 0 Then
				If CurrGrado - 2 + CurrSem > 2 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object Prev2Grado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Prev2Grado = CurrGrado - 2
				End If
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object Prev2Grado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Prev2Grado = 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#E6E6E6><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#E6E6E6><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#E6E6E6><font size=3></td>"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object Prev2Grado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><p class=MsoBodyText><b>" & GetStrGrade(CShort(Prev2Grado)) & "</b></p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center><p class=MsoBodyText><b>SP</b></p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center><p class=MsoBodyText><b>P</b></p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center><p class=MsoBodyText><b>BP</b></p></td>"
			End If
			'--
			
			'ESCRIBIR COLUMNAS DEL ANO 1
			'UPGRADE_WARNING: Couldn't resolve default property of object Prev1Grado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Prev1Grado = 0
			If Prev1ID > 0 Then
				If CurrGrado - 1 + CurrSem > 2 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object Prev1Grado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Prev1Grado = CurrGrado - 1
				End If
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object Prev1Grado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Prev1Grado = 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#E6E6E6><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#E6E6E6><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#E6E6E6><font size=3></td>"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object Prev1Grado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><p class=MsoBodyText><b>" & GetStrGrade(CShort(Prev1Grado)) & "</b></p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center><p class=MsoBodyText><b>SP</b></p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center><p class=MsoBodyText><b>P</b></p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center><p class=MsoBodyText><b>BP</b></p></td>"
			End If
			'--
			
			'ESCRIBIR COLUMNAS DEL CORRIENTE ANO
			If CurrGrado = 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#E6E6E6><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#E6E6E6><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#E6E6E6><font size=3></td>"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><p class=MsoBodyText><b>" & GetStrGrade(CurrGrado) & "</b></p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center><p class=MsoBodyText><b>SP</b></p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center><p class=MsoBodyText><b>P</b></p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center><p class=MsoBodyText><b>BP</b></p></td>"
			End If
			'--
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = td & "</tr>"
			
			'=============================================================
			
			'----NO VERBAL-----'
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = td & "<tr>"
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = td & "    <td width=10% align=left BGCOLOR=#CCCCCC><p class=MsoBodyText>No Verbal</p></td>"
			
			'ESCRIBIR COLUMNAS DEL ANO 2
			Bajo = 0
			Sobre = 0
			Prom = 0
			If Prev2ID > 0 Then
				If CurrGrado - 2 + CurrSem > 2 Then
					'Getdata
					'UPGRADE_WARNING: Couldn't resolve default property of object GetStanineProm(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					X = GetStanineProm(Prev2ID, "N", CurrGrado - 2, Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9)
				End If
			End If
			
			If Bajo = 0 And Sobre = 0 And Prom = 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#D0FBC7><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFFFC4><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFC4C4><font size=3></td>"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#D0FBC7><p class=MsoBodyText>" & Sobre & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFFFC4><p class=MsoBodyText>" & Prom & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFC4C4><p class=MsoBodyText>" & Bajo & "</p></td>"
			End If
			'--
			
			'ESCRIBIR COLUMNAS DEL ANO 1
			Bajo = 0
			Sobre = 0
			Prom = 0
			If Prev1ID > 0 Then
				If CurrGrado - 1 + CurrSem > 2 Then
					'Getdata
					'UPGRADE_WARNING: Couldn't resolve default property of object GetStanineProm(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					X = GetStanineProm(Prev1ID, "N", CurrGrado - 1, Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9)
				End If
			End If
			
			If Bajo = 0 And Sobre = 0 And Prom = 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#D0FBC7><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFFFC4><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFC4C4><font size=3></td>"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#D0FBC7><p class=MsoBodyText>" & Sobre & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFFFC4><p class=MsoBodyText>" & Prom & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFC4C4><p class=MsoBodyText>" & Bajo & "</p></td>"
			End If
			'--
			
			'ESCRIBIR COLUMNAS DEL ANO CORRIENTE
			Bajo = 0
			Sobre = 0
			Prom = 0
			If dRepID > 0 Then
				If CurrGrado + CurrSem > 2 Then
					'Getdata
					'UPGRADE_WARNING: Couldn't resolve default property of object GetStanineProm(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					X = GetStanineProm(dRepID, "N", CurrGrado, Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9)
				End If
			End If
			
			If Bajo = 0 And Sobre = 0 And Prom = 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#D0FBC7><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFFFC4><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFC4C4><font size=3></td>"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#D0FBC7><p class=MsoBodyText>" & Sobre & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFFFC4><p class=MsoBodyText>" & Prom & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFC4C4><p class=MsoBodyText>" & Bajo & "</p></td>"
			End If
			'--
			
			'=============================================================
			
			'----ESPANOL-----'
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = td & "<tr>"
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = td & "    <td width=10% align=left BGCOLOR=#CCCCCC><p class=MsoBodyText>Lectura</p></td>"
			
			'ESCRIBIR COLUMNAS DEL ANO 2
			Bajo = 0
			Sobre = 0
			Prom = 0
			If Prev2ID > 0 Then
				If CurrGrado - 2 + CurrSem > 2 Then
					'Getdata
					'UPGRADE_WARNING: Couldn't resolve default property of object GetStanineProm(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					X = GetStanineProm(Prev2ID, "L", CurrGrado - 2, Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9)
				End If
			End If
			
			If Bajo = 0 And Sobre = 0 And Prom = 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#D0FBC7><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFFFC4><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFC4C4><font size=3></td>"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#D0FBC7><p class=MsoBodyText>" & Sobre & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFFFC4><p class=MsoBodyText>" & Prom & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFC4C4><p class=MsoBodyText>" & Bajo & "</p></td>"
			End If
			'--
			
			'ESCRIBIR COLUMNAS DEL ANO 1
			Bajo = 0
			Sobre = 0
			Prom = 0
			If Prev1ID > 0 Then
				If CurrGrado - 1 + CurrSem > 2 Then
					'Getdata
					'UPGRADE_WARNING: Couldn't resolve default property of object GetStanineProm(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					X = GetStanineProm(Prev1ID, "L", CurrGrado - 1, Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9)
				End If
			End If
			
			If Bajo = 0 And Sobre = 0 And Prom = 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#D0FBC7><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFFFC4><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFC4C4><font size=3></td>"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#D0FBC7><p class=MsoBodyText>" & Sobre & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFFFC4><p class=MsoBodyText>" & Prom & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFC4C4><p class=MsoBodyText>" & Bajo & "</p></td>"
			End If
			'--
			
			'ESCRIBIR COLUMNAS DEL ANO CORRIENTE
			Bajo = 0
			Sobre = 0
			Prom = 0
			If dRepID > 0 Then
				If CurrGrado + CurrSem > 2 Then
					'Getdata
					'UPGRADE_WARNING: Couldn't resolve default property of object GetStanineProm(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					X = GetStanineProm(dRepID, "L", CurrGrado, Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9)
				End If
			End If
			
			If Bajo = 0 And Sobre = 0 And Prom = 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#D0FBC7><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFFFC4><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFC4C4><font size=3></td>"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#D0FBC7><p class=MsoBodyText>" & Sobre & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFFFC4><p class=MsoBodyText>" & Prom & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFC4C4><p class=MsoBodyText>" & Bajo & "</p></td>"
			End If
			'--
			
			'=============================================================
			
			'----READING-----'
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = td & "<tr>"
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = td & "    <td width=10% align=left BGCOLOR=#CCCCCC><p class=MsoBodyText>Reading</p></td>"
			
			'ESCRIBIR COLUMNAS DEL ANO 2
			Bajo = 0
			Sobre = 0
			Prom = 0
			If Prev2ID > 0 Then
				If CurrGrado - 2 + CurrSem > 2 Then
					'Getdata
					'UPGRADE_WARNING: Couldn't resolve default property of object GetStanineProm(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					X = GetStanineProm(Prev2ID, "R", CurrGrado - 2, Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9)
				End If
			End If
			
			If Bajo = 0 And Sobre = 0 And Prom = 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#D0FBC7><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFFFC4><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFC4C4><font size=3></td>"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#D0FBC7><p class=MsoBodyText>" & Sobre & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFFFC4><p class=MsoBodyText>" & Prom & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFC4C4><p class=MsoBodyText>" & Bajo & "</p></td>"
			End If
			'--
			
			'ESCRIBIR COLUMNAS DEL ANO 1
			Bajo = 0
			Sobre = 0
			Prom = 0
			If Prev1ID > 0 Then
				If CurrGrado - 1 + CurrSem > 2 Then
					'Getdata
					'UPGRADE_WARNING: Couldn't resolve default property of object GetStanineProm(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					X = GetStanineProm(Prev1ID, "R", CurrGrado - 1, Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9)
				End If
			End If
			
			If Bajo = 0 And Sobre = 0 And Prom = 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#D0FBC7><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFFFC4><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFC4C4><font size=3></td>"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#D0FBC7><p class=MsoBodyText>" & Sobre & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFFFC4><p class=MsoBodyText>" & Prom & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFC4C4><p class=MsoBodyText>" & Bajo & "</p></td>"
			End If
			'--
			
			'ESCRIBIR COLUMNAS DEL ANO CORRIENTE
			Bajo = 0
			Sobre = 0
			Prom = 0
			If dRepID > 0 Then
				If CurrGrado + CurrSem > 2 Then
					'Getdata
					'UPGRADE_WARNING: Couldn't resolve default property of object GetStanineProm(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					X = GetStanineProm(dRepID, "R", CurrGrado, Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9)
				End If
			End If
			
			If Bajo = 0 And Sobre = 0 And Prom = 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#D0FBC7><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFFFC4><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFC4C4><font size=3></td>"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center BGCOLOR=#D0FBC7><p class=MsoBodyText>" & Sobre & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center BGCOLOR=#FFFFC4><p class=MsoBodyText>" & Prom & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center BGCOLOR=#FFC4C4><p class=MsoBodyText>" & Bajo & "</p></td>"
			End If
			'--
			
			'=============================================================
			
			'----MATEMATICAS-----'
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = td & "<tr>"
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = td & "    <td width=10% align=left BGCOLOR=#CCCCCC><p class=MsoBodyText>Matemáticas</p></td>"
			
			'ESCRIBIR COLUMNAS DEL ANO 2
			Bajo = 0
			Sobre = 0
			Prom = 0
			If Prev2ID > 0 Then
				If CurrGrado - 2 + CurrSem > 2 Then
					'Getdata
					'UPGRADE_WARNING: Couldn't resolve default property of object GetStanineProm(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					X = GetStanineProm(Prev2ID, "M", CurrGrado - 2, Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9)
				End If
			End If
			
			If Bajo = 0 And Sobre = 0 And Prom = 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#D0FBC7><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFFFC4><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFC4C4><font size=3></td>"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center BGCOLOR=#D0FBC7><p class=MsoBodyText>" & Sobre & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center BGCOLOR=#FFFFC4><p class=MsoBodyText>" & Prom & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center BGCOLOR=#FFC4C4><p class=MsoBodyText>" & Bajo & "</p></td>"
			End If
			'--
			
			'ESCRIBIR COLUMNAS DEL ANO 1
			Bajo = 0
			Sobre = 0
			Prom = 0
			If Prev1ID > 0 Then
				If CurrGrado - 1 + CurrSem > 2 Then
					'Getdata
					'UPGRADE_WARNING: Couldn't resolve default property of object GetStanineProm(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					X = GetStanineProm(Prev1ID, "M", CurrGrado - 1, Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9)
				End If
			End If
			
			If Bajo = 0 And Sobre = 0 And Prom = 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#D0FBC7><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFFFC4><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFC4C4><font size=3></td>"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center BGCOLOR=#D0FBC7><p class=MsoBodyText>" & Sobre & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center BGCOLOR=#FFFFC4><p class=MsoBodyText>" & Prom & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center BGCOLOR=#FFC4C4><p class=MsoBodyText>" & Bajo & "</p></td>"
			End If
			'--
			
			'ESCRIBIR COLUMNAS DEL ANO CORRIENTE
			Bajo = 0
			Sobre = 0
			Prom = 0
			If dRepID > 0 Then
				If CurrGrado + CurrSem > 2 Then
					'Getdata
					'UPGRADE_WARNING: Couldn't resolve default property of object GetStanineProm(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					X = GetStanineProm(dRepID, "M", CurrGrado, Bajo, Prom, Sobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9)
				End If
			End If
			
			If Bajo = 0 And Sobre = 0 And Prom = 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#D0FBC7><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFFFC4><font size=3></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center bgcolor=#FFC4C4><font size=3></td>"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=10% align=center><font size=3>&nbsp;</td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center BGCOLOR=#D0FBC7><p class=MsoBodyText>" & Sobre & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center BGCOLOR=#FFFFC4><p class=MsoBodyText>" & Prom & "</p></td>"
				'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				td = td & "    <td width=5% align=center BGCOLOR=#FFC4C4><p class=MsoBodyText>" & Bajo & "</p></td>"
			End If
			'--
			
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			td = td & "</tr>"
			'UPGRADE_WARNING: Couldn't resolve default property of object td. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			HD = HD & td
			Rs.MoveNext()
		End While
		
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HD = HD & "</table>"
		
		Rs.Close()
		Cn.Close()
		
		'UPGRADE_WARNING: Couldn't resolve default property of object HD. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Table_COMPARACION. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Table_COMPARACION = HD
		
	End Function
	
	
	
	Function SetDate(ByRef xdate As Object, Optional ByRef isDay As Boolean = True, Optional ByRef isDayCapital As Boolean = True) As String
		Dim diastr As Object
		
		Dim Fecha As String
		Dim Fecha_Field As String
		Dim Anio As String
		Dim dia As String
		
		'UPGRADE_WARNING: Couldn't resolve default property of object xdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Fecha_Field = xdate.ToString()

		If IsDate(Fecha_Field) = False Then
			SetDate = Fecha_Field
			Exit Function
		End If
		dia = CStr(VB.Day(CDate(Fecha_Field)))
		'dia = Right("00" & dia, 2)
		If Len(dia) > 1 Then
			If Left(dia, 1) = "0" Then dia = Mid(dia, 2)
		End If
		
		Fecha = dia & " de "
		
		Select Case Month(CDate(Fecha_Field))
			Case 1
				Fecha = Fecha & "enero"
			Case 2
				Fecha = Fecha & "febrero"
			Case 3
				Fecha = Fecha & "marzo"
			Case 4
				Fecha = Fecha & "abril"
			Case 5
				Fecha = Fecha & "mayo"
			Case 6
				Fecha = Fecha & "junio"
			Case 7
				Fecha = Fecha & "julio"
			Case 8
				Fecha = Fecha & "agosto"
			Case 9
				Fecha = Fecha & "septiembre"
			Case 10
				Fecha = Fecha & "octubre"
			Case 11
				Fecha = Fecha & "noviembre"
			Case 12
				Fecha = Fecha & "diciembre"
		End Select
		
		'Get Dia
		If isDay = True Then
			If isDayCapital = True Then
				Select Case WeekDay(CDate(Fecha_Field))
					Case 1
						'UPGRADE_WARNING: Couldn't resolve default property of object diastr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						diastr = "Domingo"
					Case 2
						'UPGRADE_WARNING: Couldn't resolve default property of object diastr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						diastr = "Lunes"
					Case 3
						'UPGRADE_WARNING: Couldn't resolve default property of object diastr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						diastr = "Martes"
					Case 4
						'UPGRADE_WARNING: Couldn't resolve default property of object diastr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						diastr = "Miércoles"
					Case 5
						'UPGRADE_WARNING: Couldn't resolve default property of object diastr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						diastr = "Jueves"
					Case 6
						'UPGRADE_WARNING: Couldn't resolve default property of object diastr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						diastr = "Viernes"
					Case 7
						'UPGRADE_WARNING: Couldn't resolve default property of object diastr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						diastr = "Sábado"
				End Select
			Else
				Select Case WeekDay(CDate(Fecha_Field))
					Case 1
						'UPGRADE_WARNING: Couldn't resolve default property of object diastr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						diastr = "domingo"
					Case 2
						'UPGRADE_WARNING: Couldn't resolve default property of object diastr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						diastr = "lunes"
					Case 3
						'UPGRADE_WARNING: Couldn't resolve default property of object diastr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						diastr = "martes"
					Case 4
						'UPGRADE_WARNING: Couldn't resolve default property of object diastr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						diastr = "miércoles"
					Case 5
						'UPGRADE_WARNING: Couldn't resolve default property of object diastr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						diastr = "jueves"
					Case 6
						'UPGRADE_WARNING: Couldn't resolve default property of object diastr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						diastr = "viernes"
					Case 7
						'UPGRADE_WARNING: Couldn't resolve default property of object diastr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						diastr = "sábado"
				End Select
			End If
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object diastr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			diastr = ""
		End If
		
		Anio = CStr(Year(CDate(Fecha_Field)))
		Anio = Replace(Anio, ",", "")
		'Anio = Split(Anio, ".")(1)
		
		Fecha = Fecha & " de " & Anio
		
		'UPGRADE_WARNING: Couldn't resolve default property of object diastr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		SetDate = diastr & ", " & Fecha
		
	End Function
	
	
    Function SetShortDate(ByRef xdate As String, Optional ByRef LongMon As Boolean = True, Optional ByRef strDay As Boolean = False) As String
        Dim sDia As Object

        Dim Fecha As String
        Dim Fecha_Field As String
        Dim Anio As String
        Dim dia As String

        'UPGRADE_WARNING: Couldn't resolve default property of object xdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Fecha_Field = xdate.ToString()


        'UPGRADE_WARNING: Couldn't resolve default property of object xdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If xdate.ToString() = "" Then Exit Function

        'dia = CStr(VB.Day(CDate(Fecha_Field)))
        dia = Fecha_Field
        Fecha = ""

        If strDay = True Then

            'UPGRADE_WARNING: Couldn't resolve default property of object xdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Select Case Weekday(Convert.ToDateTime(Fecha_Field), FirstDayOfWeek.Sunday)
                Case 1
                    'UPGRADE_WARNING: Couldn't resolve default property of object sDia. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sDia = "domingo"
                Case 2
                    'UPGRADE_WARNING: Couldn't resolve default property of object sDia. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sDia = "lunes"
                Case 3
                    'UPGRADE_WARNING: Couldn't resolve default property of object sDia. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sDia = "martes"
                Case 4
                    'UPGRADE_WARNING: Couldn't resolve default property of object sDia. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sDia = "miércoles"
                Case 5
                    'UPGRADE_WARNING: Couldn't resolve default property of object sDia. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sDia = "jueves"
                Case 6
                    'UPGRADE_WARNING: Couldn't resolve default property of object sDia. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sDia = "viernes"
                Case 7
                    'UPGRADE_WARNING: Couldn't resolve default property of object sDia. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sDia = "sábado"
            End Select
        End If

        Select Case Month(CDate(Fecha_Field))
            Case 1
                Fecha = Fecha & "enero"
            Case 2
                Fecha = Fecha & "febrero"
            Case 3
                Fecha = Fecha & "marzo"
            Case 4
                Fecha = Fecha & "abril"
            Case 5
                Fecha = Fecha & "mayo"
            Case 6
                Fecha = Fecha & "junio"
            Case 7
                Fecha = Fecha & "julio"
            Case 8
                Fecha = Fecha & "agosto"
            Case 9
                Fecha = Fecha & "septiembre"
            Case 10
                Fecha = Fecha & "octubre"
            Case 11
                Fecha = Fecha & "noviembre"
            Case 12
                Fecha = Fecha & "diciembre"
        End Select

        If LongMon = False Then
            Fecha = dia & " de " & Left(Fecha, 3)
        Else
            Fecha = dia & " de " & Fecha
        End If

        Anio = CStr(Year(CDate(Fecha_Field)))
        Anio = Replace(Anio, ",", "")

        Fecha = Fecha & " de " & Right(Anio, 4)

        If strDay = True Then
            'UPGRADE_WARNING: Couldn't resolve default property of object sDia. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Fecha = sDia & ", " & Fecha
        End If

        SetShortDate = Fecha

    End Function
End Module