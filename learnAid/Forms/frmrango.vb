Option Strict Off
Option Explicit On

Imports ADODB
Imports VB = Microsoft.VisualBasic

Friend Class frmRango
    Inherits Form

    Private Sub cmdCreateExcel_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdCreateExcel.Click
        Dim sQuery As String
        Dim Cn As New Connection
        Dim RS As New Recordset

        Dim ExcelPath As Object
        Dim sline As Object
        Dim X As Object
        Dim FileName As Object
        Dim Restado As Object = Nothing
        Dim CurrMinPos As Object
        Dim PrevMin As Object
        Dim CurrMin As Object
        Dim CurrRango As Object
        Dim PromPos As Object
        Dim y As Object
        Dim d9 As Object = Nothing
        Dim d8 As Object = Nothing
        Dim d7 As Object = Nothing
        Dim d6 As Object = Nothing
        Dim d5 As Object = Nothing
        Dim d4 As Object = Nothing
        Dim d3 As Object = Nothing
        Dim d2 As Object = Nothing
        Dim d1 As Object = Nothing
        Dim TotStud As Object = Nothing
        Dim iProm As Object
        Dim iSobre As Object
        Dim iBajo As Object
        Dim aa As Object
        Dim bB As Object = Nothing
        Dim i As Object
        Dim sTo As String
        Dim sFrom As String
        Dim Clave As Object

        'ConnectionString = "Provider=MSDASQL.1;Persist Security Info=False;User ID=sa;Data Source=LearnAid;Initial Catalog=LA"

        Dim tmpValor As Double

        OpenConnection(Cn, Config.ConnectionString)

        'check parameters
        If Me.cboYear.Text = "" Then
            MsgBox("Select Year")
            Me.cboYear.Focus()
            Exit Sub
        End If
        If Me.cboTest.Text = "" Then
            MsgBox("Select Test")
            Me.cboTest.Focus()
            Exit Sub
        End If

        If Me.cboPromedio.Text = "" Then
            MsgBox("Select Promedio")
            Me.cboPromedio.Focus()
            Exit Sub
        End If
        '--
        Me.Cursor = Cursors.WaitCursor

        'UPGRADE_WARNING: Couldn't resolve default property of object Clave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Clave = Microsoft.VisualBasic.Compatibility.VB6.GetItemData(Me.cboTest, Me.cboTest.SelectedIndex)
        'UPGRADE_WARNING: Couldn't resolve default property of object sFrom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sFrom = "08/01/" & CDbl(Me.cboYear.Text) - 1
        'UPGRADE_WARNING: Couldn't resolve default property of object sTo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sTo = "07/31/" & Me.cboYear.Text

        'UPGRADE_WARNING: Couldn't resolve default property of object Clave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object sTo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object sFrom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sQuery = "SELECT TOP 100 PERCENT Reports.Rep_ID, Resultados.reg_sc_id, SUM(Resultados.resg_Total_Est) AS Total_Est, Resultados.resg_grado " &
            "FROM Reports " & "Inner Join Resultados ON Reports.Rep_ID = Resultados.resg_rep_id " &
            "WHERE (Reports.Rep_serv_date >= '" & sFrom & "') " & "AND (Reports.Rep_serv_date <= '" & sTo & "') " &
            "AND (Reports.Rep_Type = 2) " & "AND (Reports.rep_reposicion = 0) " &
            "AND (Reports.rep_AcomRazonable = 0) AND (Reports.rep_pepv = 0) " & "AND ((Resultados.resg_LES = " & Clave &
            " OR resg_NV = " & Clave & " OR resg_REN = " & Clave & " OR resg_MAT = " & Clave & ")) " &
            "GROUP BY Reports.Rep_ID,Resultados.reg_sc_id, Resultados.resg_grado " & "ORDER BY Resultados.reg_sc_id"

        RS.Open(sQuery, Cn, 3, 3)

        Dim ResArr(300, 8) As Object
        'Col 0 = School ID
        'COl 1 = Rep ID
        'Col 2 = Total Est
        'Col 3 = Sobre Promedio
        'Col 4 = Bajo Promedio
        'Col 5 = Rango
        'Col 6 = Temporary Rango Usage
        'Col 7 = Promedio
        'Col 8 = Grado

        Dim RangoArr(300, 7) As Object
        'Col 0 = Rango
        'Col 1 = School Name
        'Col 2 = Rep Date
        'Col 3 = TotStud
        'Col 4 = Sobre Prom
        'Col 5 = Prom
        'Col 6 = Bajo Prom
        'Col 7 = Grado
        Dim ResgGrade As Short

        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        i = 0
        While Not Rs.EOF
            If Rs.Fields("reg_sc_id").Value = 323 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object bB. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object aa. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                aa = bB
            End If
            If _
                Rs.Fields("total_est").Value >= CShort(Me.txtMinStudents.Text) And
                Rs.Fields("total_est").Value <= CShort(Me.txtMaxStudents.Text) Then
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                ResArr(i, 0) = Rs.Fields("reg_sc_id").Value
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                ResArr(i, 1) = Rs.Fields("Rep_ID").Value
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                ResArr(i, 2) = Rs.Fields("total_est").Value
                'UPGRADE_WARNING: Couldn't resolve default property of object iBajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                iBajo = 0
                'UPGRADE_WARNING: Couldn't resolve default property of object iSobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                iSobre = 0
                'UPGRADE_WARNING: Couldn't resolve default property of object iProm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                iProm = 0
                'UPGRADE_WARNING: Couldn't resolve default property of object Clave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object GetStanineProm(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                y = GetStanineProm(Rs.Fields("Rep_ID"), VB.Left(Me.cboTest.Text, 1), Rs.Fields("resg_grado").Value,
                                   iBajo, iProm, iSobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9, CShort(Clave),
                                   ResgGrade)
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object iSobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                ResArr(i, 3) = iSobre
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object iBajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                ResArr(i, 4) = iBajo
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object iProm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 7). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                ResArr(i, 7) = iProm
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 8). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                ResArr(i, 8) = ResgGrade
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                i = i + 1
            End If
            Rs.MoveNext()
        End While

        Rs.Close()


        'CREATE RANGO
        If Me.cboPromedio.Text = "Sobre Promedio" Then
            'UPGRADE_WARNING: Couldn't resolve default property of object PromPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            PromPos = 3
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object PromPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            PromPos = 4 'Bajo Promedio
        End If


        'UPGRADE_WARNING: Couldn't resolve default property of object CurrRango. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        CurrRango = 1
        'UPGRADE_WARNING: Couldn't resolve default property of object CurrMin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        CurrMin = 0

        For iCounter As Integer = 0 To 300
            'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If ResArr(iCounter, 0) > 0 Then

                'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If ResArr(iCounter, 0) = 323 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object bB. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object aa. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    aa = bB
                End If

                'UPGRADE_WARNING: Couldn't resolve default property of object CurrMin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object PrevMin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                PrevMin = CurrMin
                'UPGRADE_WARNING: Couldn't resolve default property of object CurrMin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                CurrMin = -1
                'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                CurrMinPos = 300

                For y = 0 To 300
                    'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(y, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(y, 6). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If ResArr(y, 6) <> 1 And ResArr(y, 1) > 0 Then
                        If Me.cboPromedio.Text = "Sobre Promedio" Then
                            'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(y, 7). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            tmpValor = (ResArr(y, 3) * 3) + ResArr(y, 7)
                            'UPGRADE_WARNING: Couldn't resolve default property of object CurrMin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            If tmpValor > CurrMin Then
                                'suma del (SP * 3) + P
                                'UPGRADE_WARNING: Couldn't resolve default property of object CurrMin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                CurrMin = tmpValor
                                'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                CurrMinPos = y
                            End If
                        Else
                            'Bajo Promedio
                            'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: Couldn't resolve default property of object CurrMin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(y, 4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            If ResArr(y, 4) > CurrMin Then
                                'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(y, 4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                'UPGRADE_WARNING: Couldn't resolve default property of object CurrMin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                CurrMin = ResArr(y, 4)
                                'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                CurrMinPos = y
                            End If
                        End If
                    End If
                Next y

                'UPGRADE_WARNING: Couldn't resolve default property of object CurrRango. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object CurrMin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object PrevMin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If PrevMin = CurrMin And CurrRango > 1 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object Restado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrRango. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    CurrRango = CurrRango - 1 - Restado
                    'UPGRADE_WARNING: Couldn't resolve default property of object Restado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Restado = Restado + 1
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object Restado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Restado = 0
                End If

                'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(CurrMinPos, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If ResArr(CurrMinPos, 1) > 0 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    sQuery = "SELECT SC_SCH_NAME, Rep_serv_Date, Rep_ID FROM SCHOOLS " &
                          "RIGHT OUTER JOIN Reports ON SCHOOLS.SC_ID = Reports.Rep_SCH_ID " & "Where (Reports.Rep_ID = " &
                          ResArr(CurrMinPos, 1) & ") "
                    RS.Open(sQuery, Cn, 3, 3)
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrRango. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(i, 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    RangoArr(iCounter, 0) = CurrRango
                    'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(i, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    RangoArr(iCounter, 1) = RS.Fields("sc_sch_name").Value
                    'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(i, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    RangoArr(iCounter, 2) = RS.Fields("rep_serv_date").Value
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(CurrMinPos, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(i, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    RangoArr(iCounter, 3) = ResArr(CurrMinPos, 2) 'tot students
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(CurrMinPos, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(i, 4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    RangoArr(iCounter, 4) = ResArr(CurrMinPos, 3) 'sobre prom
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(CurrMinPos, 7). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(i, 5). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    RangoArr(iCounter, 5) = ResArr(CurrMinPos, 7) 'Promedio
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(CurrMinPos, 4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(i, 6). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    RangoArr(iCounter, 6) = ResArr(CurrMinPos, 4) 'Bajo Promedio
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(CurrMinPos, 8). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(i, 7). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    RangoArr(iCounter, 7) = ResArr(CurrMinPos, 8) 'Grado
                    RS.Close()
                End If
                'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(CurrMinPos, 6). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                ResArr(CurrMinPos, 6) = 1

                'UPGRADE_WARNING: Couldn't resolve default property of object Restado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object CurrRango. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                CurrRango = CurrRango + 1 + Restado
            End If
        Next

        'UPGRADE_WARNING: Couldn't resolve default property of object FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        FileName = "ColRango-" & Me.cboYear.Text & "-" & Me.cboTest.Text & ".xls"

        'UPGRADE_WARNING: Couldn't resolve default property of object FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        FileOpen(1, My.Application.Info.DirectoryPath & "\" & FileName, OpenMode.Output)
        '
        PrintLine(1, "LearnAid of Puerto Rico, Inc." & vbTab & vbTab & "INFORME DE RANGO DE LOS COLEGIOS")
        PrintLine(1, vbTab & "Materia: " & Me.cboTest.Text)
        'UPGRADE_WARNING: Couldn't resolve default property of object sTo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object sFrom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        PrintLine(1, vbTab & "Año: " & sFrom & vbTab & sTo)
        PrintLine(1, vbTab & "Promedio: " & Me.cboPromedio.Text)

        PrintLine(1, "")
        PrintLine(1, "")
        '
        PrintLine(1,
                  "Rango" & vbTab & "Escuela" & vbTab & "Fecha Informe" & vbTab & "Tot Est" & vbTab & "Sobre Prom" &
                  vbTab & "Prom" & vbTab & "Bajo Prom" & vbTab & "Grado")
        '
        For X = 0 To UBound(RangoArr) - 1
            'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object sline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sline = RangoArr(X, 0) & vbTab
            'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object sline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sline = sline & RangoArr(X, 1) & vbTab
            'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object sline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sline = sline & RangoArr(X, 2) & vbTab
            'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object sline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sline = sline & RangoArr(X, 3) & vbTab
            'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object sline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sline = sline & RangoArr(X, 4) & vbTab
            'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object sline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sline = sline & RangoArr(X, 5) & vbTab
            'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object sline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sline = sline & RangoArr(X, 6) & vbTab
            'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object sline. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sline = sline & RangoArr(X, 7) & vbTab
            PrintLine(1, sline)
        Next X
        '
        FileClose(1)

        Me.Cursor = Cursors.Default

        '
        'UPGRADE_WARNING: Couldn't resolve default property of object ExcelPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ExcelPath = GetINIValue(My.Application.Info.DirectoryPath & "\LearnAid.ini", "System.Settings", "MSExcelPath")
        'UPGRADE_WARNING: Couldn't resolve default property of object FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object ExcelPath. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        y = Shell(ExcelPath & " " & Chr(34) & My.Application.Info.DirectoryPath & "\" & FileName & Chr(34),
                  AppWinStyle.NormalFocus)
    End Sub

    Private Sub cmdClose_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdAdd_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdAdd.Click
        Dim i As Object
        Dim bOk As Object

        'UPGRADE_WARNING: Couldn't resolve default property of object bOk. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        bOk = True
        For iCounter As Integer = 0 To lstProcess.Items.Count
            If Microsoft.VisualBasic.Compatibility.VB6.GetItemString(lstProcess, iCounter) = Me.cboTest.Text Then
                'UPGRADE_WARNING: Couldn't resolve default property of object bOk. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                bOk = False
                iCounter = lstProcess.Items.Count
            End If
        Next iCounter

        'UPGRADE_WARNING: Couldn't resolve default property of object bOk. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If bOk Then
            Me.lstProcess.Items.Add(Me.cboTest.Text)
            Microsoft.VisualBasic.Compatibility.VB6.SetItemData(Me.lstProcess, Me.lstProcess.Items.Count - 1,
                                                                Microsoft.VisualBasic.Compatibility.VB6.GetItemData(
                                                                    Me.cboTest, Me.cboTest.SelectedIndex))
        End If
    End Sub

    Private Sub cmdCreateDataReport_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdCreateDataReport.Click
        Dim sQuery As String
        Dim Cn As New Connection
        Dim Rs As New Recordset

        Dim yy As Object
        Dim xx As Object
        Dim X As Object
        Dim stemplatefolder As Object
        Dim sRootFolder As Object = Nothing
        Dim Restado As Object = Nothing
        Dim CurrMinPos As Object
        Dim PrevMin As Object
        Dim CurrMin As Object
        Dim CurrRango As Object
        Dim PromPos As Object
        Dim y As Object
        Dim d9 As Object = Nothing
        Dim d8 As Object = Nothing
        Dim d7 As Object = Nothing
        Dim d6 As Object = Nothing
        Dim d5 As Object = Nothing
        Dim d4 As Object = Nothing
        Dim d3 As Object = Nothing
        Dim d2 As Object = Nothing
        Dim d1 As Object = Nothing
        Dim TotStud As Object = Nothing
        Dim iProm As Object
        Dim iSobre As Object
        Dim iBajo As Object
        Dim CurrSem As Object
        Dim CurrGrade As Object
        Dim CurrProm As Object
        Dim CurrBajo As Object
        Dim CurrSobre As Object
        Dim currsch As Object
        Dim i As Object
        Dim sTo As String
        Dim sFrom As String
        Dim Clave As Object
        Dim z As Object


        'ConnectionString = "Provider=MSDASQL.1;Persist Security Info=False;User ID=sa;Data Source=LearnAid;Initial Catalog=LA"

        Dim tmpValor As Double
        Dim Global_Tot_Stud As Double
        Dim TotSchools As Short
        Dim iRep As Integer

        Dim scName As String
        Dim scID As String
        Dim Sem As String

        Dim ResArr(300, 8) As Object
        'Col 0 = School ID
        'COl 1 = Rep ID
        'Col 2 = Total Est
        'Col 3 = Sobre Promedio
        'Col 4 = Bajo Promedio
        'Col 5 = Rango
        'Col 6 = Temporary Rango Usage
        'Col 7 = Promedio
        'Col 8 = Grado

        Dim RangoArr(300, 8) As Object
        'Col 0 = Rango
        'Col 1 = School Name
        'Col 2 = Rep Date
        'Col 3 = TotStud
        'Col 4 = Sobre Prom
        'Col 5 = Prom
        'Col 6 = Bajo Prom
        'Col 7 = Grado
        'Col 8 = Rep ID
        Dim ResgGrade As Short
        Dim CurrMateria As String
        Dim CurrTotal As Short
        Dim CurrTotStud As Short

        OpenConnection(Cn, Config.ConnectionString)

        'check parameters
        If Me.cboYear.Text = "" Then
            MsgBox("Select Year")
            Me.cboYear.Focus()
            Exit Sub
        End If
        If Me.lstProcess.Items.Count = 0 Then
            MsgBox("Select Test")
            Me.cboTest.Focus()
            Exit Sub
        End If

        If Me.cboPromedio.Text = "" Then
            MsgBox("Select Promedio")
            Me.cboPromedio.Focus()
            Exit Sub
        End If
        '--
        Me.Cursor = Cursors.WaitCursor

        For z = 0 To Me.lstProcess.Items.Count - 1

            'UPGRADE_WARNING: Couldn't resolve default property of object Clave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Clave = Microsoft.VisualBasic.Compatibility.VB6.GetItemData(Me.lstProcess, z)
            CurrMateria = Microsoft.VisualBasic.Compatibility.VB6.GetItemString(Me.lstProcess, z)

            'UPGRADE_WARNING: Couldn't resolve default property of object sFrom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sFrom = "08/01/" & CDbl(Me.cboYear.Text) - 1
            'UPGRADE_WARNING: Couldn't resolve default property of object sTo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sTo = "07/31/" & Me.cboYear.Text

            'UPGRADE_WARNING: Couldn't resolve default property of object Clave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object sTo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object sFrom. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sQuery = "SELECT TOP 100 PERCENT Reports.Rep_ID, Resultados.reg_sc_id, SUM(Resultados.resg_Total_Est) AS Total_Est, resultados.resg_grado, reports.rep_sem " &
                "FROM Reports " & "Inner Join Resultados ON Reports.Rep_ID = Resultados.resg_rep_id " &
                "WHERE (Reports.Rep_serv_date >= '" & sFrom & "') " & "AND (Reports.Rep_serv_date <= '" & sTo & "') " &
                "AND (Reports.Rep_Type = 2) " & " " & "AND (Reports.rep_AcomRazonable = 0) AND (Reports.rep_pepv = 0) " &
                "AND ((Resultados.resg_LES = " & Clave & " OR resg_NV = " & Clave & " OR resg_REN = " & Clave &
                " OR resg_MAT = " & Clave & ")) " &
                "GROUP BY Reports.Rep_ID,Resultados.reg_sc_id, Resultados.resg_grado, reports.rep_sem " &
                "ORDER BY Resultados.reg_sc_id, reports.rep_sem, resultados.resg_grado"

            Rs.Open(sQuery, Cn, 3, 3)


            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            i = 0
            TotSchools = 0
            Global_Tot_Stud = 0
            'UPGRADE_WARNING: Couldn't resolve default property of object currsch. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            currsch = 0
            'UPGRADE_WARNING: Couldn't resolve default property of object CurrSobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            CurrSobre = 0
            'UPGRADE_WARNING: Couldn't resolve default property of object CurrBajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            CurrBajo = 0
            'UPGRADE_WARNING: Couldn't resolve default property of object CurrProm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            CurrProm = 0
            CurrTotal = 0
            'UPGRADE_WARNING: Couldn't resolve default property of object CurrGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            CurrGrade = 0
            CurrTotStud = 0
            'UPGRADE_WARNING: Couldn't resolve default property of object CurrSem. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            CurrSem = 0
            While Not Rs.EOF
                If _
                    Rs.Fields("total_est").Value >= CShort(Me.txtMinStudents.Text) And
                    Rs.Fields("total_est").Value <= CShort(Me.txtMaxStudents.Text) Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    ResArr(i, 0) = Rs.Fields("reg_sc_id").Value
                    'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    ResArr(i, 1) = Rs.Fields("Rep_ID").Value
                    'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    ResArr(i, 2) = Rs.Fields("total_est").Value
                    'UPGRADE_WARNING: Couldn't resolve default property of object iBajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    iBajo = 0
                    'UPGRADE_WARNING: Couldn't resolve default property of object iSobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    iSobre = 0
                    'UPGRADE_WARNING: Couldn't resolve default property of object iProm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    iProm = 0
                    'UPGRADE_WARNING: Couldn't resolve default property of object Clave. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetStanineProm(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    y = GetStanineProm(Rs.Fields("Rep_ID"), VB.Left(CurrMateria, 1), Rs.Fields("resg_Grado").Value,
                                       iBajo, iProm, iSobre, TotStud, d1, d2, d3, d4, d5, d6, d7, d8, d9, CShort(Clave),
                                       ResgGrade)

                    'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object iSobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    ResArr(i, 3) = iSobre
                    'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object iBajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    ResArr(i, 4) = iBajo
                    'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object iProm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 7). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    ResArr(i, 7) = iProm
                    'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 8). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    ResArr(i, 8) = ResgGrade

                    'UPGRADE_WARNING: Couldn't resolve default property of object iSobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrSobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    CurrSobre = CurrSobre + iSobre
                    'UPGRADE_WARNING: Couldn't resolve default property of object iBajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrBajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    CurrBajo = CurrBajo + iBajo
                    'UPGRADE_WARNING: Couldn't resolve default property of object iProm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrProm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    CurrProm = CurrProm + iProm
                    'UPGRADE_WARNING: Couldn't resolve default property of object currsch. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    currsch = Rs.Fields("reg_sc_id").Value
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrGrade. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    CurrGrade = ResgGrade
                    CurrTotal = CurrTotal + 1
                    CurrTotStud = CurrTotStud + Rs.Fields("total_est").Value
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrSem. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    CurrSem = Rs.Fields("Rep_Sem").Value
                    'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    i = i + 1
                    TotSchools = TotSchools + 1
                    'UPGRADE_WARNING: Couldn't resolve default property of object currsch. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Debug.Print(TotSchools & vbTab & currsch)
                    Global_Tot_Stud = Global_Tot_Stud + Rs.Fields("total_est").Value

                End If

                Rs.MoveNext()
                If Not Rs.EOF Then
                    If _
                        currsch = Rs.Fields("reg_sc_id").Value And CurrGrade = Rs.Fields("resg_Grado").Value And
                        CurrSem = Rs.Fields("Rep_Sem").Value Then
                        If _
                            Rs.Fields("total_est").Value >= CShort(Me.txtMinStudents.Text) And
                            Rs.Fields("total_est").Value <= CShort(Me.txtMaxStudents.Text) Then
                            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            i = i - 1
                            TotSchools = TotSchools - 1
                        End If
                    Else
                        If CurrTotal >= 2 Then
                            'fue una escuela con 2 o mas pruebas,
                            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            i = i - 1
                            'TotSchools = TotSchools - 1
                            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: Couldn't resolve default property of object CurrSobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            ResArr(i, 3) = CurrSobre/CurrTotal
                            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: Couldn't resolve default property of object CurrBajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            ResArr(i, 4) = CurrBajo/CurrTotal
                            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: Couldn't resolve default property of object CurrProm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 7). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            ResArr(i, 7) = CurrProm/CurrTotal
                            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            ResArr(i, 2) = CurrTotStud
                            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            i = i + 1
                        End If
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrBajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        CurrBajo = 0
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrProm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        CurrProm = 0
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrSobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        CurrSobre = 0
                        CurrTotal = 0
                        CurrTotStud = 0
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrSem. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        CurrSem = 0

                    End If
                Else
                    'se acabo el loop verificar si tengo sumado alguna escuela
                    If CurrTotal >= 2 Then
                        'fue una escuela con 2 o mas pruebas,
                        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrSobre. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        ResArr(i, 3) = CurrSobre/CurrTotal
                        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrBajo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        ResArr(i, 4) = CurrBajo/CurrTotal
                        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrProm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 7). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        ResArr(i, 7) = CurrProm/CurrTotal
                        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        ResArr(i, 2) = CurrTotStud
                    End If
                End If
            End While

            Rs.Close()


            'CREATE RANGO
            If Me.cboPromedio.Text = "Sobre Promedio" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object PromPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                PromPos = 3
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object PromPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                PromPos = 4 'Bajo Promedio
            End If


            'UPGRADE_WARNING: Couldn't resolve default property of object CurrRango. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            CurrRango = 1
            'UPGRADE_WARNING: Couldn't resolve default property of object CurrMin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            CurrMin = - 1

            For iCounter As Integer = 0 To 300
                'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(i, 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If ResArr(iCounter, 0) > 0 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrMin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object PrevMin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    PrevMin = CurrMin
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrMin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    CurrMin = -1
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    CurrMinPos = 300

                    For y = 0 To 300
                        'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(y, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(y, 6). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        If ResArr(y, 6) <> 1 And ResArr(y, 1) > 0 Then
                            If Me.cboPromedio.Text = "Sobre Promedio" Then
                                'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(y, 7). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                tmpValor = (ResArr(y, 3) * 3) + ResArr(y, 7)
                                'UPGRADE_WARNING: Couldn't resolve default property of object CurrMin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                If tmpValor > CurrMin Then
                                    'suma del (SP * 3) + P
                                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrMin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                    CurrMin = tmpValor
                                    'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                    CurrMinPos = y
                                End If
                            Else
                                'Bajo Promedio
                                'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                'UPGRADE_WARNING: Couldn't resolve default property of object CurrMin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(y, 4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                If ResArr(y, 4) > CurrMin Then
                                    'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                    'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(y, 4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrMin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                    CurrMin = ResArr(y, 4)
                                    'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                    CurrMinPos = y
                                End If
                            End If
                        End If
                    Next y

                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrRango. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrMin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object PrevMin. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If PrevMin = CurrMin And CurrRango > 1 Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object Restado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrRango. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        CurrRango = CurrRango - 1 - Restado
                        'UPGRADE_WARNING: Couldn't resolve default property of object Restado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        Restado = Restado + 1
                    Else
                        'UPGRADE_WARNING: Couldn't resolve default property of object Restado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        Restado = 0
                    End If

                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(CurrMinPos, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If ResArr(CurrMinPos, 1) > 0 Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        sQuery = "SELECT SC_SCH_NAME, Rep_serv_Date, Rep_ID FROM SCHOOLS " &
                              "RIGHT OUTER JOIN Reports ON SCHOOLS.SC_ID = Reports.Rep_SCH_ID " &
                              "Where (Reports.Rep_ID = " & ResArr(CurrMinPos, 1) & ") "
                        Rs.Open(sQuery, Cn, 3, 3)
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrRango. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(i, 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        RangoArr(iCounter, 0) = CurrRango
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(i, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        RangoArr(iCounter, 1) = ResArr(CurrMinPos, 0) & "-" & Rs.Fields("sc_sch_name").Value _
                        'SCHOOL ID - SCHOOL NAME
                        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(i, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        RangoArr(iCounter, 2) = Rs.Fields("rep_serv_date").Value
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(CurrMinPos, 2). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(i, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        RangoArr(iCounter, 3) = ResArr(CurrMinPos, 2) 'tot students
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(CurrMinPos, 3). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(i, 4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        RangoArr(iCounter, 4) = ResArr(CurrMinPos, 3) 'sobre prom
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(CurrMinPos, 7). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(i, 5). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        RangoArr(iCounter, 5) = ResArr(CurrMinPos, 7) 'Promedio
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(CurrMinPos, 4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(i, 6). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        RangoArr(iCounter, 6) = ResArr(CurrMinPos, 4) 'Bajo Promedio
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(CurrMinPos, 8). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(i, 7). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        RangoArr(iCounter, 7) = ResArr(CurrMinPos, 8) 'Grado
                        'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(CurrMinPos, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(i, 8). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        RangoArr(iCounter, 8) = ResArr(CurrMinPos, 1) 'Rep ID
                        Rs.Close()
                    End If
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrMinPos. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(CurrMinPos, 6). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    ResArr(CurrMinPos, 6) = 1

                    'UPGRADE_WARNING: Couldn't resolve default property of object Restado. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object CurrRango. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    CurrRango = CurrRango + 1 + Restado
                End If
            Next iCounter

            'Dim xml_doc As New DOMDocument
            'Dim schools_node As IXMLDOMElement

            'Dim xml_doc2 As New DOMDocument
            'Dim school_node As IXMLDOMElement
            'Dim year_node As IXMLDOMElement

            'sRootFolder = "F:\LEARNAID\RANGOS\"

            'If Not DirExists(sRootFolder & Me.cboYear) Then
            '    MkDir sRootFolder & Me.cboYear
            'End If

            'UPGRADE_WARNING: Couldn't resolve default property of object sRootFolder. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object stemplatefolder. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            stemplatefolder = sRootFolder & "Templates\"
            'sRootFolder = sRootFolder & Me.cboYear & "\"

            ' Make the Schools root node in GLOBAL.XML.


            'borro de base de datos esa materia de ese ano
            sQuery = "DELETE FROM rangos where ra_materia = '" & Split(CurrMateria, "_")(1) & "' AND " & "ra_year = '" &
                  Me.cboYear.Text & "' "
            Cn.Execute(sQuery)
            '----

            sQuery = "select * from rangos where ra_key = -1"
            Rs.Open(sQuery, Cn, 1, 3, 0)

            For X = 0 To UBound(RangoArr) - 1

                ' Make some Schools elements.
                'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(X, 1). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If RangoArr(X, 1) <> "" Then
                    ' Make the Schools root node in SCHOOL.XML.
                    'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    scID = Split(RangoArr(X, 1), "-")(0)
                    'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    scName = Split(RangoArr(X, 1), "-")(1)
                    scName = Replace_Chars(CStr(scName))
                    'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(X, 8). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    iRep = RangoArr(X, 8)

                    'verifico file con nombre de escuela
                    'sSchoolFile = sRootFolder & scID & ".xml"

                    'verifico el semestre de este reporte
                    Sem = CStr(GetSemesterFromReport(iRep))
                    If Sem = "0" Then Sem = ""

                    '        sschoolfolder = Replace_Chars(CStr(sschoolfolder))
                    '        If Not DirExists(sschoolfolder) Then
                    '            sschoolfolder = Replace_Chars(CStr(sschoolfolder))
                    '            MkDir sschoolfolder
                    '        End If

                    'inserto en base de datos de rango este record
                    Rs.AddNew()
                    Rs.Fields("ra_materia").Value = Split(CurrMateria, "_")(1)
                    Rs.Fields("ra_cat").Value = Split(CurrMateria, "_")(0)
                    Rs.Fields("ra_sch_id").Value = scID
                    Rs.Fields("ra_year").Value = Me.cboYear.Text
                    'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(X, 7). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Rs.Fields("ra_grade").Value = RangoArr(X, 7)
                    Rs.Fields("ra_sem").Value = Sem
                    'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Rs.Fields("ra_tot_est").Value = CShort(RangoArr(X, 3))
                    Rs.Fields("ra_global_est").Value = Global_Tot_Stud
                    Rs.Fields("ra_tot_inst").Value = TotSchools
                    'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(X, 0). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Rs.Fields("ra_rango").Value = RangoArr(X, 0)
                    'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(X, 4). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Rs.Fields("ra_sp").Value = RangoArr(X, 4)
                    'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(X, 5). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Rs.Fields("ra_p").Value = RangoArr(X, 5)
                    'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(X, 6). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Rs.Fields("ra_bp").Value = RangoArr(X, 6)
                    Rs.Update()

                    'MakeSchool CStr(scName), scID, CStr(sRootFolder), CStr(stemplatefolder)
                    'MakeSchoolData RangoArr(X, 0), RangoArr(X, 7), Me.cboTest.Text, scID, CStr(sSchoolFile), CInt(RangoArr(X, 3)), Global_Tot_Stud, scName, CStr(stemplatefolder), TotSchools, Sem

                End If

            Next X
            '

            Rs.Close()

            sQuery = "UPDATE Rangos Set ra_cat_order = 1 WHERE ra_cat = 'N'"
            Cn.Execute(sQuery)
            sQuery = "UPDATE Rangos Set ra_cat_order = 2 WHERE ra_cat = 'L'"
            Cn.Execute(sQuery)
            sQuery = "UPDATE Rangos Set ra_cat_order = 3 WHERE ra_cat = 'M'"
            Cn.Execute(sQuery)
            sQuery = "UPDATE Rangos Set ra_cat_order = 4 WHERE ra_cat = 'R'"
            Cn.Execute(sQuery)

            '
            lblStatus.Text = "Prueba " & CurrMateria & " finalizado"
            lblStatus.Refresh()
            Application.DoEvents()
            'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
            'UPGRADE_ISSUE: Form property frmRango.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
            '--Code Change-- jh'Me.Cursor = vbNormal
            Me.Cursor = Cursors.Default

            '

            For xx = 0 To 300
                For yy = 0 To 8
                    'UPGRADE_WARNING: Couldn't resolve default property of object yy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object xx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object ResArr(xx, yy). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    ResArr(xx, yy) = 0
                    'UPGRADE_WARNING: Couldn't resolve default property of object yy. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object xx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object RangoArr(xx, yy). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    RangoArr(xx, yy) = ""
                Next yy
            Next xx

        Next z

        MsgBox("Process Completed")
        'UPGRADE_NOTE: Object Rs may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Rs = Nothing
    End Sub


    Private Sub MakeSchool(ByVal School_Name As String, ByVal school_id As Short, ByRef xPath As String,
                           ByRef xRoot As String)
        Dim xseg As Object
        Dim sCity As Object

        Dim xData As Object


        'UPGRADE_WARNING: Couldn't resolve default property of object FiletoVar(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object xData. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        xData = FiletoVar(xPath & "global.xml")

        'UPGRADE_WARNING: Couldn't resolve default property of object xData. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If xData = "" Then
            'UPGRADE_WARNING: Couldn't resolve default property of object FiletoVar(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object xData. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            xData = FiletoVar(xRoot & "global.xml")
        End If

        'UPGRADE_WARNING: Couldn't resolve default property of object GetSchoolCity(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object sCity. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sCity = GetSchoolCity(school_id)
        'UPGRADE_WARNING: Couldn't resolve default property of object sCity. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sCity = Replace_Chars(CStr(sCity))

        'redactar segmento
        'UPGRADE_WARNING: Couldn't resolve default property of object sCity. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object xseg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        xseg = "<school><id>" & school_id & "</id><name>" & School_Name & "</name><city>" & sCity & "</city></school>"

        'buscar este rango en xdata
        '
        'UPGRADE_WARNING: Couldn't resolve default property of object xseg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object xData. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If InStr(1, xData, xseg) = 0 Then
            'no existe, anadir
            'UPGRADE_WARNING: Couldn't resolve default property of object xData. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            xData = Split(xData, "</schools>")(0)
            'UPGRADE_WARNING: Couldn't resolve default property of object xseg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object xData. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            xData = xData & xseg & "</schools>"

            'UPGRADE_WARNING: Couldn't resolve default property of object xData. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            AppendLog(xPath & "global.xml", xData, True)

        End If
    End Sub

    Private Sub MakeSchoolData(ByVal school_rango As String, ByVal school_grade As String,
                               ByVal school_materia As String, ByVal school_id As Short, ByRef xPath As String,
                               ByRef totStud1 As Short, ByRef totStud2 As Double, ByRef School_Name As String,
                               ByRef xRoot As String, ByRef totInst As Short, ByRef Sem As String)
        Dim xseg As Object
        Dim sMateria As Object = Nothing
        Dim sSort As Object = Nothing
        Dim sCity As Object
        Dim xData2 As Object
        Dim xData1 As Object
        Dim xData As Object


        If FileExists(xPath) Then
            xData = FiletoVar(xPath)
            If xData = "" Then
                xData = FiletoVar(xRoot & "data.xml")
            End If
        Else
            xData = FiletoVar(xRoot & "data.xml")
        End If

        'verificar info de school
        If InStr(1, xData, "<info></info>") > 0 Then
            'no existe, anadir
            xData1 = Split(xData, "</info>")(0)
            xData2 = Split(xData, "</info>")(1)
            sCity = GetSchoolCity(school_id)
            sCity = Replace_Chars(CStr(sCity))
            xData = xData1 & "<name>" & School_Name & "</name><city>" & sCity & "</city><year>" & Me.cboYear.Text &
                    "</year></info>" & xData2
        End If

        'redactar segmento
        Select Case Split(school_materia, "_")(0)
            Case "L"
                'UPGRADE_WARNING: Couldn't resolve default property of object sSort. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sSort = "2"
                'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sMateria = "Lectura Español"
            Case "N"
                'UPGRADE_WARNING: Couldn't resolve default property of object sSort. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sSort = "1"
                'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sMateria = "No Verbal"
            Case "R"
                'UPGRADE_WARNING: Couldn't resolve default property of object sSort. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sSort = "4"
                'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sMateria = "Lectura Inglés"
            Case "M"
                'UPGRADE_WARNING: Couldn't resolve default property of object sSort. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sSort = "3"
                Select Case UCase(Split(school_materia, "_")(1))
                    Case "BAIR"
                        'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        sMateria = "Matemáticas (Alg)"
                    Case "GE-91"
                        'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        sMateria = "Matemáticas (Geo)"
                    Case Else
                        'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        sMateria = "Matemáticas"
                End Select
            Case "A"
                'UPGRADE_WARNING: Couldn't resolve default property of object sSort. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sSort = "0"
                'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sMateria = "AID"
        End Select
        'UPGRADE_WARNING: Couldn't resolve default property of object sSort. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sSort = VB.Right("00" & school_grade, 2) & "-" & sSort & Sem

        'UPGRADE_WARNING: Couldn't resolve default property of object sMateria. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object sSort. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object xseg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        xseg = "<rango><sort>" & sSort & "</sort><pos>" & school_rango & "</pos><materia>" & sMateria &
               "</materia><grado>" & school_grade & "</grado><stud>" & totStud1 & "</stud><totstud>" & totStud2 &
               "</totstud><totinst>" & totInst & "</totinst><sem>" & Sem & "</sem></rango>"

        'buscar este rango en xdata
        '
        'UPGRADE_WARNING: Couldn't resolve default property of object xseg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object xData. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If InStr(1, xData, xseg) = 0 Then
            'no existe, anadir
            'UPGRADE_WARNING: Couldn't resolve default property of object xData. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            xData = Split(xData, "</rangos>")(0)
            'UPGRADE_WARNING: Couldn't resolve default property of object xseg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object xData. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            xData = xData & xseg & "</rangos></school>"

            'UPGRADE_WARNING: Couldn't resolve default property of object xData. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            AppendLog(xPath, xData, True)
        End If
    End Sub


    Sub AppendLog(ByVal TargetFile As String, ByVal StringToAppend As String, ByVal bCRLF As Boolean)

        Dim iFile As Short

        iFile = FreeFile
        FileOpen(iFile, TargetFile, OpenMode.Output, , OpenShare.LockReadWrite)
        Print(iFile, StringToAppend)
        FileClose(iFile)
    End Sub

    Private Sub cmdMoveBack_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdMoveBack.Click


        If lstProcess.SelectedIndex >= 0 Then
            Me.lstProcess.Items.RemoveAt(lstProcess.SelectedIndex)
            If lstProcess.Items.Count > 0 Then
                lstProcess.SelectedIndex = lstProcess.Items.Count - 1
                lstProcess.Focus()
            End If
        End If
    End Sub

    Private Sub frmRango_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Dim sQuery As String
        Dim Cn As New Connection
        Dim Rs As New Recordset

        'ConnectionString = "Provider=MSDASQL.1;Persist Security Info=False;User ID=sa;Data Source=LearnAid;Initial Catalog=LA"
        OpenConnection(Cn, Config.ConnectionString)


        '--ADD Tests to cboTest
        sQuery = "select cl_id,cl_type,cl_category from Claves order by cl_category, cl_type ASC"
        Rs.Open(sQuery, Cn, 3, 3)

        While Not Rs.EOF
            Me.cboTest.Items.Add(Rs.Fields("cl_category").Value & "_" & Rs.Fields("cl_type").Value)
            Microsoft.VisualBasic.Compatibility.VB6.SetItemData(Me.cboTest, Me.cboTest.Items.Count - 1,
                                                                Rs.Fields("CL_ID").Value)
            Rs.MoveNext()
        End While

        Rs.Close()
        '---


        Me.cboPromedio.Items.Add("Sobre Promedio")
        Me.cboPromedio.Items.Add("Bajo Promedio")

        'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sQuery = "select rep_year from reports GROUP BY rep_year order by rep_year desc"
        Rs.Open(sQuery, Cn, 3, 3)

        While Not Rs.EOF
            Me.cboYear.Items.Add(Rs.Fields("Rep_Year").Value)
            Rs.MoveNext()
        End While

        Rs.Close()
        Cn.Close()

        Cn = Nothing
        Rs = Nothing
    End Sub


    Private Sub List1_Click()
    End Sub
End Class