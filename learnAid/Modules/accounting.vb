Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.Compatibility
Imports learnAid.Forms.AccountingForms
Module Accounting_Mod
    'Called From frmnominaprocess_Activated
    Sub CreateAccounting()
        Dim sQuery As String
        Dim Cn As ADODB.Connection
        Dim Rs As ADODB.Recordset
        Dim Rs2 As ADODB.Recordset
        Cn = CreateObject("adodb.connection")
        Rs = CreateObject("adodb.recordset")
        Rs2 = CreateObject("adodb.recordset")

        Dim CreateRecord As Boolean
        Dim dConsTotal As Integer
        Dim iIncrement As Integer
        Dim iTotalWidth As Integer
        Dim NG_ID As Integer
        Dim NG_TotalExaminers As Short
        Dim NG_TotalPaid As Double
        Dim sFrom As String
        Dim sTo As String

        'dTypes Values

        '1  = Bateria Regular
        '2  = Mixto
        '3  = AID
        '4  = Millaje
        '5  = Peaje
        '6  = Exam a Cargo 2 o menos
        '7  = Exam a Cargo 3 a 6
        '8  = Exam a Cargo 7 o mas
        '9  = Visita a la Oficina
        '10  = Trabajo en la Oficina
        '11 = Reuniones/Adiestramientos
        '15 = Acomodo Razonable
        '16 = Office Testing

        OpenConnection(Cn, Config.ConnectionString)

        sFrom = frmnomina.txtFrom.Text
        sTo = frmnomina.txtTo.Text

        'DELETE RECORDS FROM TEMPORARY TABLE
        Cn.Execute("DELETE FROM NOMINA_TEMPLATE WHERE NT_STATUS = 'P' AND NT_AJUSTE = 0")
        Cn.Execute("DELETE FROM NOMINA_GENERAL WHERE NG_STATUS = 'P'")

        'CREATE PARENT RECORD
        Rs.Open("Nomina_General", Cn, 1, 3, 0)
        Rs.AddNew()
        Rs.Fields("ng_from").Value = frmnomina.txtFrom.Text
        Rs.Fields("ng_to").Value = frmnomina.txtTo.Text
        Rs.Update()
        NG_ID = Rs.Fields("ng_id").Value
        frmnomina.txtParentID.Text = NG_ID.ToString.Trim
        Rs.Close()

        Cn.Execute("UPDATE NOMINA_TEMPLATE SET NT_PARENTID = " & NG_ID & "WHERE NT_STATUS='P' AND NT_AJUSTE = 1")

        sQuery = "Select * from Consultants where con_type = 'E' order by con_id"

        Rs.Open(sQuery, Cn, 3, 3)

        frmnominaprocess.Shape1.Width = 0
        iTotalWidth = 4280
        iIncrement = 4280 / Rs.RecordCount
        dConsTotal = 0

        'Abro tabla para poder añadir examinadors en blanco si no tienen nada
        sQuery = "Nomina_Template"
        Rs2.Open(sQuery, Cn, 1, 3, 0)

        While Not Rs.EOF
            'If Rs!con_id = 12 Then Stop
            frmnominaprocess.Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmnominaprocess.Shape1.Width) + iIncrement)

            CreateRecord = Set_Bat(Rs.Fields("CON_ID"), sFrom, sTo, 1, NG_ID) 'Trabajar con Examinadores
            CreateRecord = Set_Bat(Rs.Fields("CON_ID"), sFrom, sTo, 2, NG_ID) 'Trabajar con Asistentes
            CreateRecord = Set_ACargos(Rs.Fields("CON_ID"), sFrom, sTo, NG_ID) 'Trabajar con Examinadores a Cargo

            Set_Peaje(Rs.Fields("CON_ID"), sFrom, sTo, 1, NG_ID) 'Trabajar peaje de Examinador
            Set_Peaje(Rs.Fields("CON_ID"), sFrom, sTo, 2, NG_ID) 'Trabajar peaje de Asistente
            Set_Correccion(Rs.Fields("CON_ID"), sFrom, sTo, NG_ID) 'Trabajar si corrigio pruebas

            CreateRecord = Set_Acomodo(Rs.Fields("CON_ID"), sFrom, sTo, 1, NG_ID) 'Trabajar Acomodo Razonable
            CreateRecord = Set_Acomodo(Rs.Fields("CON_ID"), sFrom, sTo, 2, NG_ID) 'Trabajar Acomodo Razonable Asistente
            CreateRecord = Set_Office_Testing(Rs.Fields("CON_ID"), sFrom, sTo, 1, NG_ID) 'Trabajar Office Testing
            CreateRecord = Set_PEPV(Rs.Fields("CON_ID"), sFrom, sTo, 1, NG_ID) 'Trabajar PEPV

            '    If CreateRecord = False Then
            '        'Creo record en blanco al examinador para que se le puedan entrar ajustes
            '        Rs2.AddNew
            '            Rs2!nt_sch_name = ""
            '            Rs2!nt_sch_city = ""
            '            Rs2!nt_serv_date = Null
            '            Rs2!nt_cons_id = Rs!CON_ID
            '            Rs2!nt_amount = 0
            '            Rs2!nt_parentid = NG_ID
            '        Rs2.Update
            '    End If
            System.Windows.Forms.Application.DoEvents()
            Rs.MoveNext()
            dConsTotal += 1
        End While

        Rs.Close()
        Rs2.Close()

        '--Calculate Total Examiners and Total Paid
        sQuery = "SELECT SUM(nt_amount) AS nt_amount, nt_cons_id " & "From dbo.Nomina_Template " & "Where (nt_parentid = " & NG_ID & " ) GROUP BY nt_cons_id"

        Rs.Open(sQuery, Cn, 3, 3)
        While Not Rs.EOF
            NG_TotalExaminers += 1
            NG_TotalPaid = NG_TotalPaid + Rs.Fields("nt_amount").Value
            Rs.MoveNext()
        End While
        Rs.Close()
        '----

        '--UPDATE PARENT
        sQuery = "SELECT * From Nomina_General where NG_ID = " & NG_ID
        Rs.Open(sQuery, Cn, 1, 3, 0)

        Rs.Fields("NG_TotalExaminer").Value = NG_TotalExaminers
        Rs.Fields("NG_TotalPaid").Value = NG_TotalPaid
        Rs.Update()
        Rs.Close()
        '---
        frmnominaprocess.Close()

        Cn.Close()

    End Sub
    'Called By: CreateAccounting()
    Function Set_ACargos(ByRef dCons As Object, ByVal sFrom As String, ByVal sTo As String, ByVal NG_ID As Integer) As Boolean
        Dim sQuery As String
        Dim sQuery2 As String
        Dim Cn As ADODB.Connection
        Dim Rs As ADODB.Recordset
        Dim Rs2 As ADODB.Recordset
        Cn = CreateObject("adodb.connection")
        Rs = CreateObject("adodb.recordset")
        Rs2 = CreateObject("adodb.recordset")

        Dim CreateRecord As Boolean = False

        Dim CurrCity As String
        Dim CurrDate As String
        Dim CurrRepID As Integer
        Dim CurrSchool As String

        Dim dAmount1 As Double
        Dim dAmount2 As Double
        Dim dAmount3 As Double
        Dim dAmount As Double
        Dim dType As Short
        Dim PrevCons As String
        Dim PrevCons2 As String
        Dim TotExaminers As Integer

        '----PRECIOS----LUEGO PONERLOS EN INI FILE
        dAmount1 = 12 '1 a 2 personas
        dAmount2 = 18 '3 a 6 personas
        dAmount3 = 24 '7 o mas
        '----PRECIOS-----

        OpenConnection(Cn, Config.ConnectionString)


        'sQuery = "SELECT Resultados.resg_rep_id, MAX(dbo.SCHOOLS.SC_SCH_NAME) AS SC_SCH_NAME, MAX(dbo.SCHOOLS.SC_City) AS SC_City, MAX(dbo.SCHOOLS.SC_Cost) AS SC_Cost, " & _
        '"MAX(dbo.Resultados.reg_serv_date) AS reg_serv_date, COUNT(dbo.Resultados.resg_cons) AS tot_cons " & _
        '"FROM dbo.Resultados INNER JOIN " & _
        '"dbo.SCHOOLS ON dbo.Resultados.reg_sc_id = dbo.SCHOOLS.SC_ID INNER JOIN " & _
        '"dbo.Reports ON dbo.Resultados.resg_rep_id = dbo.Reports.Rep_ID " & _
        '"WHERE (dbo.Resultados.resg_CONS3 = " & dCons & ") AND (dbo.Resultados.reg_serv_date >= '" & sFrom & "') AND " & _
        '"(dbo.Resultados.reg_serv_date <= '" & sTo & "') AND (dbo.Reports.Rep_Type = 1 or dbo.Reports.Rep_Type = 2) " & _
        '" AND Reports.rep_AcomRazonable = 0 AND Reports.Rep_pepv = 0 " & _
        '"GROUP BY dbo.Resultados.resg_rep_id, dbo.Resultados.reg_serv_date, dbo.Resultados.resg_cons3 " & _
        '"ORDER BY MAX(dbo.Resultados.reg_serv_date)"

        'UPGRADE_WARNING: Couldn't resolve default property of object dCons. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sQuery = "SELECT MAX(dbo.Reports.rep_serv_date) AS rep_serv_date, dbo.Resultados.resg_CONS3, dbo.Reports.Rep_ID, dbo.Resultados.resg_CONS, MAX(dbo.SCHOOLS.SC_SCH_NAME) AS SC_SCH_NAME, MAX(dbo.SCHOOLS.SC_City) AS SC_CITY, dbo.Resultados.resg_CONS, dbo.Resultados.resg_CONS2 " & "FROM dbo.Reports INNER JOIN dbo.Resultados ON dbo.Reports.Rep_ID = dbo.Resultados.resg_rep_id INNER JOIN dbo.SCHOOLS ON dbo.Reports.Rep_SCH_ID = dbo.SCHOOLS.SC_ID " & "WHERE (dbo.Reports.rep_serv_date >= '" & sFrom & "') AND (dbo.Reports.rep_serv_date <= '" & sTo & "') AND (dbo.Reports.Rep_Type > 0) " & "GROUP BY dbo.Reports.Rep_ID, dbo.Resultados.resg_CONS3, dbo.Resultados.resg_CONS, dbo.Resultados.resg_CONS2 " & "Having (dbo.Resultados.resg_CONS3 = " & dCons & ") And (dbo.Resultados.resg_CONS > 0) " & "ORDER BY dbo.Reports.Rep_ID, dbo.Resultados.resg_CONS, dbo.Resultados.resg_CONS2 "
        Rs.Open(sQuery, Cn, 3, 3)

        sQuery2 = "Select * from Nomina_Template"
        Rs2.Open(sQuery2, Cn, 1, 3, 0)

        CurrCity = ""
        CurrRepID = 0
        CurrSchool = ""
        PrevCons = ""
        PrevCons2 = ""
        TotExaminers = 0
        If Not Rs.EOF And Not Rs.BOF Then
            CurrRepID = Rs.Fields("Rep_ID").Value
            CurrSchool = Rs.Fields("sc_sch_name").Value
            CurrCity = Rs.Fields("sc_city").Value
            CurrDate = Rs.Fields("rep_serv_date").Value
        End If

        While Not Rs.EOF
            If CurrRepID <> Rs.Fields("Rep_ID").Value Then
                dAmount = 0
                dType = 0
                Select Case TotExaminers
                    Case 0
                        'Do Nothing.
                    Case Is <= 2
                        dAmount = dAmount1
                        dType = 6
                    Case Is <= 6
                        dAmount = dAmount2
                        dType = 7
                    Case Is >= 7
                        dAmount = dAmount3
                        dType = 8
                End Select
                If dAmount > 0 Then
                    Rs2.AddNew()
                    Rs2.Fields("nt_sch_name").Value = CurrSchool
                    Rs2.Fields("nt_sch_city").Value = CurrCity
                    Rs2.Fields("nt_serv_date").Value = CurrDate
                    Rs2.Fields("nt_cons_id").Value = dCons
                    Rs2.Fields("nt_type").Value = dType
                    Rs2.Fields("nt_amount").Value = dAmount
                    Rs2.Fields("nt_parentid").Value = NG_ID
                    Rs2.Update()
                    CreateRecord = True
                End If
                CurrDate = Rs.Fields("rep_serv_date").Value
                CurrRepID = Rs.Fields("Rep_ID").Value
                CurrSchool = Rs.Fields("sc_sch_name").Value
                CurrCity = Rs.Fields("sc_city").Value
                PrevCons = ""
                PrevCons2 = ""
                TotExaminers = 0
            End If

            If InStr(1, PrevCons, "[" & Rs.Fields("resg_cons").Value & "]") <= 0 Then
                TotExaminers += 1
            End If
            If Rs.Fields("resg_cons2").Value > 0 And InStr(1, PrevCons2, "[" & Rs.Fields("resg_cons2").Value & "]") <= 0 Then
                TotExaminers += 1
            End If
            PrevCons = PrevCons & "[" & Rs.Fields("resg_cons").Value & "]"
            PrevCons2 = PrevCons2 & "[" & Rs.Fields("resg_cons2").Value & "]"
            Rs.MoveNext()
            System.Windows.Forms.Application.DoEvents()
        End While

        If TotExaminers > 0 Then
            'Dio EOF y hay que crear record por el ultimo conteo
            dAmount = 0
            dType = 0
            Select Case TotExaminers
                Case 0
                    'Do Nothing.
                Case Is <= 2
                    dAmount = dAmount1
                    dType = 6
                Case Is <= 6
                    dAmount = dAmount2
                    dType = 7
                Case Is >= 7
                    dAmount = dAmount3
                    dType = 8
            End Select
            If dAmount > 0 Then
                Rs2.AddNew()
                Rs2.Fields("nt_sch_name").Value = CurrSchool
                Rs2.Fields("nt_sch_city").Value = CurrCity
                Rs2.Fields("nt_serv_date").Value = CurrDate
                Rs2.Fields("nt_cons_id").Value = dCons
                Rs2.Fields("nt_type").Value = dType
                Rs2.Fields("nt_amount").Value = dAmount
                Rs2.Fields("nt_parentid").Value = NG_ID
                Rs2.Update()
                CreateRecord = True
            End If
        End If
        Set_ACargos = CreateRecord
    End Function
    'called By: CreateAccounting()
    Function Set_Acomodo(ByRef dCons As Object, ByVal sFrom As String, ByVal sTo As String, ByVal dConsType As Integer, ByVal NG_ID As Integer) As Boolean
        Dim sQuery As String
        Dim Cn As ADODB.Connection
        Dim Rs As ADODB.Recordset
        Dim RsServCount As ADODB.Recordset
        Dim Rs2 As ADODB.Recordset
        'Dim Rs3 As ADODB.Recordset
        Cn = CreateObject("adodb.connection")
        Rs = CreateObject("adodb.recordset")
        RsServCount = CreateObject("adodb.recordset")
        Rs2 = CreateObject("adodb.recordset")

        Dim CreateReport As Boolean = False
        Dim dAmount4Sab As Object
        Dim dAmount4 As Object

        Dim dAmount As Double
        Dim dAmount1 As Double
        Dim dAmount2 As Double
        Dim dAmount3 As Double
        Dim dAmount1Sab As Double
        Dim dAmount2Sab As Double
        Dim dAmount3Sab As Double

        'Dim dAmountAID As Double
        'Dim dAmountAID1 As Double
        'Dim dAmountAID2 As Double
        'Dim dAmountAID3 As Double
        Dim dType As Short
        Dim sDay As Object
        Dim TestCount As Short

        '----PRECIOS----LUEGO PONERLOS EN INI FILE
        If dConsType = 1 Then
            'Precios normales
            dAmount1 = 50
            dAmount1Sab = 55
            dAmount2 = 75
            dAmount2Sab = 80
            dAmount3 = 60
            dAmount3Sab = 65
            dAmount4 = 80
            dAmount4Sab = 85
        Else
            'Precios de Asistente
            'Precios normales
            dAmount1 = 45
            dAmount1Sab = 50
            dAmount2 = 70
            dAmount2Sab = 75
            dAmount3 = 55
            dAmount3Sab = 60
            dAmount4 = 75
            dAmount4Sab = 80
        End If
        '----PRECIOS-----
        OpenConnection(Cn, Config.ConnectionString)

        If dConsType = 1 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object dCons. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sQuery = " SELECT Reports.*,Resultados.*, dbo.SCHOOLS.* " & " FROM dbo.Reports LEFT OUTER JOIN dbo.SCHOOLS ON dbo.Reports.Rep_SCH_ID = dbo.SCHOOLS.SC_ID RIGHT OUTER JOIN dbo.Resultados ON dbo.Reports.Rep_ID = dbo.Resultados.resg_rep_id " & " WHERE     (Reports.rep_serv_date >= '" & sFrom & "') AND (Reports.rep_serv_date <= '" & sTo & "') AND (resultados.resg_CONS = " & dCons & ") AND " & " Reports.rep_AcomRazonable = 1 and Reports.Rep_pepv = 0 " & " ORDER BY Reports.rep_serv_date"
        Else
            'Asistente
            'UPGRADE_WARNING: Couldn't resolve default property of object dCons. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sQuery = " SELECT Reports.*,Resultados.* , dbo.SCHOOLS.* " & " FROM dbo.Reports LEFT OUTER JOIN dbo.SCHOOLS ON dbo.Reports.Rep_SCH_ID = dbo.SCHOOLS.SC_ID RIGHT OUTER JOIN dbo.Resultados ON dbo.Reports.Rep_ID = dbo.Resultados.resg_rep_id " & " WHERE     (Reports.rep_serv_date >= '" & sFrom & "') AND (Reports.rep_serv_date <= '" & sTo & "') AND (resultados.resg_CONS2 = " & dCons & ") AND " & " Reports.rep_AcomRazonable = 1 and Reports.Rep_pepv = 0 " & " ORDER BY Reports.rep_serv_date"
        End If
        Rs.Open(sQuery, Cn, 3, 3)

        sQuery = "Select * from Nomina_Template"
        Rs2.Open(sQuery, Cn, 1, 3, 0)

        While Not Rs.EOF
            'Revisar si es semana o sabado el servicio
            'UPGRADE_WARNING: Couldn't resolve default property of object sDay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sDay = Weekday(Rs.Fields("reg_serv_date").Value, FirstDayOfWeek.Sunday)
            dAmount = 0
            dType = 0
            TestCount = 0

            'Contar Cuantas Pruebas se dieron
            If Rs.Fields("resg_Mat").Value > 0 Then TestCount = TestCount + 1
            If Rs.Fields("resg_NV").Value > 0 Then TestCount = TestCount + 1
            If Rs.Fields("resg_REN").Value > 0 Then TestCount = TestCount + 1
            If Rs.Fields("resg_LES").Value > 0 Then TestCount = TestCount + 1
            If Rs.Fields("resg_AID").Value > 0 Then TestCount = 1

            'UPGRADE_WARNING: Couldn't resolve default property of object dConsType. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If dConsType = 1 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object dCons. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sQuery = " SELECT Reports.*,Resultados.* " & " FROM         Reports RIGHT OUTER JOIN " & "                      Resultados ON Reports.Rep_ID = Resultados.resg_rep_id " & " WHERE     (Reports.rep_serv_date = '" & Rs.Fields("Rep_Serv_date").Value & "')  AND (resultados.resg_CONS = " & dCons & ") "
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object dCons. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sQuery = " SELECT Reports.*,Resultados.* " & " FROM         Reports RIGHT OUTER JOIN " & "                      Resultados ON Reports.Rep_ID = Resultados.resg_rep_id " & " WHERE     (Reports.rep_serv_date = '" & Rs.Fields("Rep_Serv_date").Value & "')  AND (resultados.resg_CONS2 = " & dCons & ") "
            End If
            RsServCount.Open(sQuery, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            Select Case RsServCount.RecordCount
                Case 0
                    'Do Nothing.
                Case 1
                    If TestCount <= 2 Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object sDay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        If sDay = 7 Then
                            dAmount = dAmount1Sab
                        Else
                            dAmount = dAmount1
                        End If
                    Else
                        'UPGRADE_WARNING: Couldn't resolve default property of object sDay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        If sDay = 7 Then
                            dAmount = dAmount2Sab
                        Else
                            dAmount = dAmount2
                        End If
                    End If
                Case Is >= 2
                    If TestCount <= 2 Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object sDay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        If sDay = 7 Then
                            dAmount = dAmount3Sab
                        Else
                            dAmount = dAmount3
                        End If
                    Else
                        'UPGRADE_WARNING: Couldn't resolve default property of object sDay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        If sDay = 7 Then
                            'UPGRADE_WARNING: Couldn't resolve default property of object dAmount4Sab. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            dAmount = dAmount4Sab
                        Else
                            'UPGRADE_WARNING: Couldn't resolve default property of object dAmount4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            dAmount = dAmount4
                        End If
                    End If

            End Select
            RsServCount.Close()

            Rs2.AddNew()
            Rs2.Fields("nt_sch_name").Value = Rs.Fields("sc_sch_name").Value
            Rs2.Fields("nt_sch_city").Value = Rs.Fields("sc_city").Value
            Rs2.Fields("nt_serv_date").Value = Rs.Fields("reg_serv_date").Value
            'UPGRADE_WARNING: Couldn't resolve default property of object dCons. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Rs2.Fields("nt_cons_id").Value = dCons
            Rs2.Fields("nt_type").Value = 15 'Acomodo Razonable
            Rs2.Fields("nt_amount").Value = dAmount
            Rs2.Fields("nt_parentid").Value = NG_ID
            Rs2.Update()

            If Rs.Fields("SC_COST").Value > 0 Then
                'Se le va a pagar millaje por lo tanto se le entra otro record
                Rs2.AddNew()
                Rs2.Fields("nt_sch_name").Value = Rs.Fields("sc_sch_name").Value
                Rs2.Fields("nt_sch_city").Value = Rs.Fields("sc_city").Value
                Rs2.Fields("nt_serv_date").Value = Rs.Fields("reg_serv_date").Value
                'UPGRADE_WARNING: Couldn't resolve default property of object dCons. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                Rs2.Fields("nt_cons_id").Value = dCons
                Rs2.Fields("nt_type").Value = 4 'Millaje
                Rs2.Fields("nt_amount").Value = Rs.Fields("SC_COST").Value
                Rs2.Fields("nt_parentid").Value = NG_ID
                Rs2.Update()
            End If

            Rs.MoveNext()
            System.Windows.Forms.Application.DoEvents()
            CreateReport = True
        End While

        Set_Acomodo = CreateReport

    End Function
     'Called By: CreateAccounting()
    Function Set_Bat(ByRef dCons As Object, ByVal sFrom As String, ByVal sTo As String, ByVal dConsType As Integer, ByVal NG_ID As Integer) As Boolean
        Dim sQuery As String
        Dim Cn As ADODB.Connection
        Dim Rs As ADODB.Recordset
        Dim Rs2 As ADODB.Recordset
        Dim Rs3 As ADODB.Recordset
        Cn = CreateObject("adodb.connection")
        Rs = CreateObject("adodb.recordset")
        Rs2 = CreateObject("adodb.recordset")
        Rs3 = CreateObject("adodb.recordset")


        Dim CreateRecord As Boolean = False
        Dim dAmount As Double
        Dim dAmount1 As Double
        Dim dAmount2 As Double
        Dim dAmount3 As Double
        Dim dAmount1Sab As Double
        Dim dAmount2Sab As Double
        Dim dAmount3Sab As Double

        Dim dAmountAID As Double
        Dim dAmountAID1 As Double
        Dim dAmountAID2 As Double
        Dim dAmountAID3 As Double
        Dim dType As Short
        Dim sDay As Object
        Dim TotGroup As Object

        '----PRECIOS----LUEGO PONERLOS EN INI FILE
        If dConsType = 1 Then
            'Precios normales
            dAmount1 = 40
            dAmount1Sab = 50
            dAmount2 = 45
            dAmount2Sab = 50
            dAmount3 = 50
            dAmount3Sab = 60
            dAmountAID1 = 40
            dAmountAID2 = 45
            dAmountAID3 = 50
        Else
            'Precios de Asistente
            dAmount1 = 35
            dAmount1Sab = 45
            dAmount2 = 40
            dAmount2Sab = 45
            dAmount3 = 45
            dAmount3Sab = 55
            dAmountAID1 = 35
            dAmountAID2 = 40
            dAmountAID3 = 45
        End If
        '----PRECIOS-----



        OpenConnection(Cn, Config.ConnectionString)


        'UPGRADE_WARNING: Couldn't resolve default property of object dConsType. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If dConsType = 1 Then

            '****************************Exception thrown below at sQuery*********************************

            'UPGRADE_WARNING: Couldn't resolve default property of object dCons. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sQuery = "SELECT Resultados.resg_rep_id, MAX(dbo.SCHOOLS.SC_SCH_NAME) AS SC_SCH_NAME, MAX(dbo.SCHOOLS.SC_City) AS " & _
                " SC_City, MAX(dbo.SCHOOLS.SC_Cost) AS SC_Cost, MAX(dbo.SCHOOLS.SC_Toll) AS SC_Toll, " & _
                " MAX(dbo.Resultados.reg_serv_date) AS reg_serv_date, COUNT(dbo.Resultados.resg_id) AS tot_bat, SUM(dbo.Resultados.resg_total_est) AS tot_stud " & _
                " FROM dbo.Resultados INNER JOIN " & _
                " dbo.SCHOOLS ON dbo.Resultados.reg_sc_id = dbo.SCHOOLS.SC_ID INNER JOIN " & _
                " dbo.Reports ON dbo.Resultados.resg_rep_id = dbo.Reports.Rep_ID " & "WHERE (dbo.Resultados.resg_CONS = " & dCons & _
                " ) AND (dbo.Resultados.reg_serv_date >= '" & sFrom & "') AND " & _
                " (dbo.Resultados.reg_serv_date <= '" & sTo & _
                " ') AND (dbo.Reports.Rep_Type = 1 or dbo.Reports.Rep_Type = 2) " & _
                " AND Reports.rep_AcomRazonable = 0 AND Reports.Rep_pepv = 0 " & _
                " GROUP BY dbo.Resultados.resg_rep_id, dbo.Resultados.reg_serv_date " & _
                " ORDER BY MAX(dbo.Resultados.reg_serv_date)"
        Else
            'Asistente
            'UPGRADE_WARNING: Couldn't resolve default property of object sTo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object sFrom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object dCons. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sQuery = "SELECT Resultados.resg_rep_id, MAX(dbo.SCHOOLS.SC_SCH_NAME) AS SC_SCH_NAME, MAX(dbo.SCHOOLS.SC_City) AS SC_City, " & _
                " MAX(dbo.SCHOOLS.SC_Cost) AS SC_Cost, MAX(dbo.SCHOOLS.SC_Toll) AS SC_Toll, " & _
                "MAX(dbo.Resultados.reg_serv_date) AS reg_serv_date, COUNT(dbo.Resultados.resg_id) AS tot_bat, SUM(dbo.Resultados.resg_total_est) AS tot_stud  " & _
                "FROM dbo.Resultados INNER JOIN " & _
                "dbo.SCHOOLS ON dbo.Resultados.reg_sc_id = dbo.SCHOOLS.SC_ID INNER JOIN " & _
                "dbo.Reports ON dbo.Resultados.resg_rep_id = dbo.Reports.Rep_ID " & "WHERE (dbo.Resultados.resg_CONS2 = " & dCons & _
                ") AND (dbo.Resultados.reg_serv_date >= '" & sFrom & "') AND " & "(dbo.Resultados.reg_serv_date <= '" & sTo & _
                "') AND (dbo.Reports.Rep_Type = 1 or dbo.Reports.Rep_Type = 2) " & _
                " AND Reports.rep_AcomRazonable = 0 AND Reports.Rep_pepv = 0 " & _
                "GROUP BY dbo.Resultados.resg_rep_id, dbo.Resultados.reg_serv_date " & _
                "ORDER BY MAX(dbo.Resultados.reg_serv_date)"
        End If

        Rs.Open(sQuery, Cn, 3, 3)

        sQuery = "Select * from Nomina_Template"
        Rs2.Open(sQuery, Cn, 1, 3, 0)

        While Not Rs.EOF
            'Revisar si es semana o sabado el servicio
            'UPGRADE_WARNING: Couldn't resolve default property of object sDay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sDay = Weekday(Rs.Fields("reg_serv_date").Value, FirstDayOfWeek.Sunday)
            dAmount = 0
            dAmountAID = 0
            dType = 0
            Select Case Rs.Fields("tot_bat").Value
                Case 0
                    'Do Nothing.
                Case 1
                    'UPGRADE_WARNING: Couldn't resolve default property of object sDay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If sDay = 7 Then
                        dAmount = dAmount1Sab
                    Else
                        dAmount = dAmount1
                    End If
                    dType = 1
                Case 2 'Mixto
                    'UPGRADE_WARNING: Couldn't resolve default property of object sDay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If sDay = 7 Then
                        dAmount = dAmount2Sab
                    Else
                        dAmount = dAmount2
                    End If
                    dType = 2
                Case 3
                    'Mixto
                    'UPGRADE_WARNING: Couldn't resolve default property of object sDay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If sDay = 7 Then
                        dAmount = dAmount3Sab
                    Else
                        dAmount = dAmount3
                    End If
                    dType = 2
                Case Else
                    'Mixto
                    'UPGRADE_WARNING: Couldn't resolve default property of object sDay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If sDay = 7 Then
                        dAmount = dAmount3Sab
                    Else
                        dAmount = dAmount3
                    End If
                    dType = 2
            End Select

            'Antes de adjudicarle el precio, verifico si no tuvo un AID
            'para entonces cambiarle el precio si lo tuvo.

            If dConsType = 1 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object dCons. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sQuery = "Select * from Resultados where resg_rep_id = " & Rs.Fields("resg_rep_id").Value & " AND resg_AID > 0 AND resg_cons = " & dCons & " AND reg_serv_date = '" & Rs.Fields("reg_serv_date").Value & "'"
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object dCons. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sQuery = "Select * from Resultados where resg_rep_id = " & Rs.Fields("resg_rep_id").Value & " AND resg_AID > 0 AND resg_cons2 = " & dCons & " AND reg_serv_date = '" & Rs.Fields("reg_serv_date").Value & "'"
            End If

            Rs3.Open(sQuery, Cn, 3, 3)

            If Rs3.RecordCount > 0 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object TotGroup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                TotGroup = 0
                While Not Rs3.EOF
                    Select Case Rs3.Fields("resg_total_est").Value
                        Case Is <= 15
                            TotGroup += 1
                        Case Is <= 32
                            TotGroup += 2
                        Case Is > 32
                            TotGroup += 3
                    End Select
                    Rs3.MoveNext()
                End While
                'Tuvo AIDS, por lo tanto dividir en grupo de 16 estudiantes.
                Select Case TotGroup
                    Case 1
                        dAmountAID = dAmountAID1
                    Case 2
                        dAmountAID = dAmountAID2
                    Case Is >= 3
                        dAmountAID = dAmountAID3
                End Select
            End If
            Rs3.Close()

            'verifico cual cantidad es mayor, para pagarle la mayor

            If dAmountAID > dAmount Then
                dAmount = dAmountAID
                dType = 3 'AID
            End If

            Rs2.AddNew()
            Rs2.Fields("nt_sch_name").Value = Rs.Fields("sc_sch_name").Value
            Rs2.Fields("nt_sch_city").Value = Rs.Fields("sc_city").Value
            Rs2.Fields("nt_serv_date").Value = Rs.Fields("reg_serv_date").Value
            Rs2.Fields("nt_cons_id").Value = dCons
            Rs2.Fields("nt_type").Value = dType
            Rs2.Fields("nt_amount").Value = dAmount
            Rs2.Fields("nt_parentid").Value = NG_ID
            Rs2.Update()

            If Rs.Fields("SC_COST").Value > 0 Then
                'Se le va a pagar millaje por lo tanto se le entra otro record
                Rs2.AddNew()
                Rs2.Fields("nt_sch_name").Value = Rs.Fields("sc_sch_name").Value
                Rs2.Fields("nt_sch_city").Value = Rs.Fields("sc_city").Value
                Rs2.Fields("nt_serv_date").Value = Rs.Fields("reg_serv_date").Value
                Rs2.Fields("nt_cons_id").Value = dCons
                Rs2.Fields("nt_type").Value = 4 'Millaje
                Rs2.Fields("nt_amount").Value = Rs.Fields("SC_COST").Value
                Rs2.Fields("nt_parentid").Value = NG_ID
                Rs2.Update()
            End If

            Rs.MoveNext()
            System.Windows.Forms.Application.DoEvents()
            CreateRecord = True
        End While

        Set_Bat = CreateRecord

    End Function
    'Called By: CreateAccounting()
    Sub Set_Correccion(ByRef dCons As Object, ByVal sFrom As String, ByRef sTo As String, ByVal NG_ID As Integer)
        Dim sQuery As String
        Dim Cn As ADODB.Connection
        Dim Rs As ADODB.Recordset
        Dim Rs2 As ADODB.Recordset
        Cn = CreateObject("adodb.connection")
        Rs = CreateObject("adodb.recordset")
        Rs2 = CreateObject("adodb.recordset")

        Dim dAmount As Double
        Dim dAmount1 As Double
        Dim dAmount2 As Double
        Dim dAmount3 As Double
        Dim dTotStud As Double
        Dim dType As Double

        '----PRECIOS----LUEGO PONERLOS EN INI FILE
        'Precios normales
        dAmount1 = 0.45 'AID
        dAmount2 = 0.55 'R1-PRE
        dAmount3 = 0.55 'R2PRE
        '----PRECIOS-----

        OpenConnection(Cn, Config.ConnectionString)
        'UPGRADE_WARNING: Couldn't resolve default property of object dCons. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sQuery = "SELECT Resultados.resg_rep_id, SCHOOLS.SC_SCH_NAME, SCHOOLS.SC_City, SCHOOLS.SC_Cost, " &
            "Resultados.reg_serv_date, Resultados.resg_REN, Resultados.resg_AID, Resultados.resg_Total_Est " &
            "FROM Resultados INNER JOIN " & "SCHOOLS ON Resultados.reg_sc_id = SCHOOLS.SC_ID INNER JOIN " &
            "Reports ON Resultados.resg_rep_id = Reports.Rep_ID " & "WHERE (Resultados.resg_CONS = " & dCons &
            ") AND (Resultados.reg_serv_date >= '" & sFrom & "') AND " & "(Resultados.reg_serv_date <= '" & sTo &
            "') AND (Reports.Rep_Type = 2 or Reports.Rep_Type = 1) " & "ORDER BY Resultados.reg_serv_date"

        Rs.Open(sQuery, Cn, 3, 3)

        sQuery = "Select * from Nomina_Template"
        Rs2.Open(sQuery, Cn, 1, 3, 0)

        While Not Rs.EOF
            dAmount = 0
            dType = 0
            dTotStud = 0
            Select Case Rs.Fields("resg_REN").Value
                Case 48
                    'R2 PRE
                    dAmount = dAmount3 * Rs.Fields("resg_total_est").Value
                    dType = 13
                Case 49
                    'R1 pre
                    dAmount = dAmount2 * Rs.Fields("resg_total_est").Value
                    dType = 12
                Case Else
                    'Do Nothing
            End Select
            Select Case Rs.Fields("resg_AID").Value
                Case 51
                    'AID
                    dAmount = dAmount1 * Rs.Fields("resg_total_est").Value
                    dType = 14
                Case Else
                    'Do Nothing
            End Select

            If dType > 0 Then
                Rs2.AddNew()
                Rs2.Fields("nt_sch_name").Value = Rs.Fields("sc_sch_name").Value
                Rs2.Fields("nt_sch_city").Value = Rs.Fields("sc_city").Value
                Rs2.Fields("nt_serv_date").Value = Rs.Fields("reg_serv_date").Value
                Rs2.Fields("nt_cons_id").Value = dCons
                Rs2.Fields("nt_type").Value = dType
                Rs2.Fields("nt_amount").Value = dAmount
                Rs2.Fields("nt_parentid").Value = NG_ID
                Rs2.Update()
            End If
            Rs.MoveNext()
            System.Windows.Forms.Application.DoEvents()
        End While
    End Sub
    'Called By: CreateAccounting()
    Function Set_Office_Testing(ByRef dCons As Object, ByVal sFrom As String, ByVal sTo As String, ByVal dConsType As Integer, ByVal NG_ID As Integer) As Boolean
        Dim sQuery As String
        Dim Cn As ADODB.Connection
        Dim Rs As ADODB.Recordset
        Dim Rs2 As ADODB.Recordset
        Dim Rs3 As ADODB.Recordset
        Cn = CreateObject("adodb.connection")
        Rs = CreateObject("adodb.recordset")
        Rs2 = CreateObject("adodb.recordset")
        Rs3 = CreateObject("adodb.recordset")

        Dim CreateReport As Boolean
        Dim dAmount As Double
        Dim dAmount1 As Double
        Dim dAmount2 As Double
        Dim dType As Short

        '----PRECIOS----LUEGO PONERLOS EN INI FILE
        dAmount1 = 65 'Si son menos de 10 estudiantes
        dAmount2 = 75 'Si son 11 o mas
        '----PRECIOS-----
        OpenConnection(Cn, Config.ConnectionString)

        'UPGRADE_WARNING: Couldn't resolve default property of object dCons. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object sTo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object sFrom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sQuery = "SELECT COUNT(dbo.ResEst.rese_id) AS tot_stud, Reports.Rep_ID, Reports.rep_serv_date " & "FROM Resultados INNER JOIN " & "Reports ON Resultados.resg_rep_id = Reports.Rep_ID INNER JOIN " & "ResEst ON dbo.Resultados.resg_id = dbo.ResEst.resg_id " & "WHERE (Reports.Rep_Type = 0) AND (Resultados.reg_serv_date >= '" & sFrom & "') AND (Resultados.reg_serv_date <= '" & sTo & "') AND " & "(Resultados.resg_CONS = " & dCons & ") " & "GROUP BY Reports.Rep_ID, Reports.rep_serv_date "

        Rs.Open(sQuery, Cn, 3, 3)

        sQuery = "Select * from Nomina_Template"
        Rs2.Open(sQuery, Cn, 1, 3, 0)

        While Not Rs.EOF
            dAmount = 0
            If Rs.Fields("tot_stud").Value <= 10 Then
                dAmount = dAmount1
                dType = 16
            Else
                dAmount = dAmount2
                dType = 17
            End If

            Rs2.AddNew()
            Rs2.Fields("nt_sch_name").Value = "Multiple Schools"
            Rs2.Fields("nt_sch_city").Value = ""
            Rs2.Fields("nt_serv_date").Value = Rs.Fields("rep_serv_date").Value
            Rs2.Fields("nt_cons_id").Value = dCons
            Rs2.Fields("nt_type").Value = dType
            Rs2.Fields("nt_amount").Value = dAmount
            Rs2.Fields("nt_parentid").Value = NG_ID
            Rs2.Update()
            Rs.MoveNext()
            System.Windows.Forms.Application.DoEvents()
            CreateReport = True
        End While
        Set_Office_Testing = CreateReport
    End Function
    'Called By: CreateAccounting()
    Sub Set_Peaje(ByRef dCons As Object, ByVal sFrom As String, ByVal sTo As String, ByVal dConsType As Integer, ByVal NG_ID As Integer)
        Dim sQuery As String
        Dim Cn As ADODB.Connection
        Dim Rs As ADODB.Recordset
        Dim Rs2 As ADODB.Recordset
        Cn = CreateObject("adodb.connection")
        Rs = CreateObject("adodb.recordset")
        Rs2 = CreateObject("adodb.recordset")
        Dim bToll As Boolean

        Dim CurrRepID As Integer
        Dim CurrRepDate As String
        'Dim dType As Short

        OpenConnection(Cn, Config.ConnectionString)

        If dConsType = 1 Then
            'Examinador
            sQuery = "SELECT dbo.Resultados.resg_rep_id, dbo.SCHOOLS.SC_SCH_NAME, dbo.SCHOOLS.SC_City, dbo.SCHOOLS.SC_Cost, dbo.SCHOOLS.SC_Toll, " & "dbo.Resultados.reg_serv_date , dbo.Resultados.resg_CONS, dbo.Resultados.resg_toll1 " & "FROM dbo.Resultados INNER JOIN dbo.SCHOOLS ON dbo.Resultados.reg_sc_id = dbo.SCHOOLS.SC_ID INNER JOIN dbo.Reports ON dbo.Resultados.resg_rep_id = dbo.Reports.Rep_ID " & "WHERE (dbo.Reports.Rep_Type = 2 or dbo.Reports.Rep_Type = 1 or dbo.Reports.rep_pepv = 1 or dbo.Reports.rep_AcomRazonable = 1) AND dbo.Reports.Rep_Type <> 0 AND (dbo.Resultados.reg_serv_date >= '" & sFrom & "') AND (dbo.Resultados.reg_serv_date <= '" & sTo & "') AND dbo.Resultados.resg_CONS = " & dCons & "ORDER BY dbo.Resultados.reg_serv_date "
        Else
            'Asistente
            sQuery = "SELECT dbo.Resultados.resg_rep_id, dbo.SCHOOLS.SC_SCH_NAME, dbo.SCHOOLS.SC_City, dbo.SCHOOLS.SC_Cost, dbo.SCHOOLS.SC_Toll, " & "dbo.Resultados.reg_serv_date , dbo.Resultados.resg_CONS2, dbo.Resultados.resg_toll2 " & "FROM dbo.Resultados INNER JOIN dbo.SCHOOLS ON dbo.Resultados.reg_sc_id = dbo.SCHOOLS.SC_ID INNER JOIN dbo.Reports ON dbo.Resultados.resg_rep_id = dbo.Reports.Rep_ID " & "WHERE (dbo.Reports.Rep_Type = 2 or dbo.Reports.Rep_Type = 1 or dbo.Reports.rep_pepv = 1 or dbo.Reports.rep_AcomRazonable = 1) AND dbo.Reports.Rep_Type <> 0 AND (dbo.Resultados.reg_serv_date >= '" & sFrom & "') AND (dbo.Resultados.reg_serv_date <= '" & sTo & "') AND dbo.Resultados.resg_CONS2 = " & dCons & "ORDER BY dbo.Resultados.reg_serv_date "
        End If

        Rs.Open(sQuery, Cn, 3, 3)

        sQuery = "Select * from Nomina_Template"
        Rs2.Open(sQuery, Cn, 1, 3, 0)

        CurrRepID = 0
        CurrRepDate = ""

        While Not Rs.EOF
            If dConsType = 1 Then 'Examinador
                bToll = Rs.Fields("resg_toll1").Value
            Else 'Asistente
                bToll = Rs.Fields("resg_toll2").Value
            End If

            If bToll Then
                If CurrRepID <> Rs.Fields("resg_rep_id").Value Or CurrRepDate <> Rs.Fields("reg_serv_date").Value Then
                    CurrRepID = Rs.Fields("resg_rep_id").Value
                    CurrRepDate = Rs.Fields("reg_serv_date").Value
                    Rs2.AddNew()
                    Rs2.Fields("nt_sch_name").Value = Rs.Fields("sc_sch_name").Value
                    Rs2.Fields("nt_sch_city").Value = Rs.Fields("sc_city").Value
                    Rs2.Fields("nt_serv_date").Value = Rs.Fields("reg_serv_date").Value
                    Rs2.Fields("nt_cons_id").Value = dCons
                    Rs2.Fields("nt_type").Value = 5 'Peaje
                    Rs2.Fields("nt_amount").Value = Rs.Fields("sc_toll").Value
                    Rs2.Fields("nt_parentid").Value = NG_ID
                    Rs2.Update()
                End If
            End If
            Rs.MoveNext()
            System.Windows.Forms.Application.DoEvents()
        End While
        Rs.Close()
        Rs2.Close()
        Cn.Close()
    End Sub
    'Called By: CreateAccounting()
    Function Set_PEPV(ByRef dCons As Object, ByVal sFrom As String, ByVal sTo As String, ByVal dConsType As Integer, ByVal NG_ID As Integer) As Boolean
        Dim sDay As Object

        Dim Cn As ADODB.Connection
        Dim Rs As ADODB.Recordset
        Dim Rs2 As ADODB.Recordset
        Dim Rs3 As ADODB.Recordset
        Dim sQuery As String
        Dim dAmount1 As Double
        Dim dAmount2 As Double
        Dim dAmount As Double
        Dim dType As Short
        Dim CreateReport As Boolean

        CreateReport = False

        '----PRECIOS----LUEGO PONERLOS EN INI FILE
        dAmount1 = 55 'Lunes a Viernes
        dAmount2 = 60 'Sabados
        '----PRECIOS-----


        Cn = CreateObject("adodb.connection")
        Rs = CreateObject("adodb.recordset")
        Rs2 = CreateObject("adodb.recordset")
        Rs3 = CreateObject("adodb.recordset")

        OpenConnection(Cn, Config.ConnectionString)

        'UPGRADE_WARNING: Couldn't resolve default property of object dCons. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object sTo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object sFrom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sQuery = "SELECT COUNT(dbo.ResEst.rese_id) AS tot_stud, Reports.Rep_ID, Reports.rep_serv_date, MAX(dbo.SCHOOLS.SC_SCH_NAME) AS SC_SCH_NAME, MAX(dbo.SCHOOLS.SC_City) AS SC_City, MAX(dbo.SCHOOLS.SC_Cost) AS SC_Cost, MAX(dbo.SCHOOLS.SC_Toll) AS SC_Toll " & "FROM Resultados INNER JOIN " & "Reports ON Resultados.resg_rep_id = Reports.Rep_ID INNER JOIN " & "dbo.SCHOOLS ON dbo.Resultados.reg_sc_id = dbo.SCHOOLS.SC_ID INNER JOIN " & "ResEst ON dbo.Resultados.resg_id = dbo.ResEst.resg_id " & "WHERE (Reports.Rep_pepv = 1) AND (Resultados.reg_serv_date >= '" & sFrom & "') AND (Resultados.reg_serv_date <= '" & sTo & "') AND " & "(Resultados.resg_CONS = " & dCons & ") " & "GROUP BY Reports.Rep_ID, Reports.rep_serv_date "

        Rs.Open(sQuery, Cn, 3, 3)

        sQuery = "Select * from Nomina_Template"
        Rs2.Open(sQuery, Cn, 1, 3, 0)

        While Not Rs.EOF
            dAmount = 0
            'UPGRADE_WARNING: Couldn't resolve default property of object sDay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sDay = Weekday(Rs.Fields("rep_serv_date").Value, FirstDayOfWeek.Sunday)
            'UPGRADE_WARNING: Couldn't resolve default property of object sDay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If sDay = 7 Then
                'Sabado
                dAmount = dAmount2
                dType = 19
            Else
                'Lunes a Viernes
                dAmount = dAmount1
                dType = 18
            End If

            Rs2.AddNew()
            Rs2.Fields("nt_sch_name").Value = Rs.Fields("sc_sch_name").Value
            Rs2.Fields("nt_sch_city").Value = Rs.Fields("sc_city").Value
            Rs2.Fields("nt_serv_date").Value = Rs.Fields("rep_serv_date").Value
            'UPGRADE_WARNING: Couldn't resolve default property of object dCons. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Rs2.Fields("nt_cons_id").Value = dCons
            Rs2.Fields("nt_type").Value = dType
            Rs2.Fields("nt_amount").Value = dAmount
            Rs2.Fields("nt_parentid").Value = NG_ID
            Rs2.Update()

            If Rs.Fields("SC_COST").Value > 0 Then
                'Se le va a pagar millaje por lo tanto se le entra otro record
                Rs2.AddNew()
                Rs2.Fields("nt_sch_name").Value = Rs.Fields("sc_sch_name").Value
                Rs2.Fields("nt_sch_city").Value = Rs.Fields("sc_city").Value
                Rs2.Fields("nt_serv_date").Value = Rs.Fields("rep_serv_date").Value
                'UPGRADE_WARNING: Couldn't resolve default property of object dCons. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                Rs2.Fields("nt_cons_id").Value = dCons
                Rs2.Fields("nt_type").Value = 4 'Millaje
                Rs2.Fields("nt_amount").Value = Rs.Fields("SC_COST").Value
                Rs2.Fields("nt_parentid").Value = NG_ID
                Rs2.Update()
            End If

            Rs.MoveNext()
            System.Windows.Forms.Application.DoEvents()
            CreateReport = True
        End While

        Set_PEPV = CreateReport

    End Function

End Module