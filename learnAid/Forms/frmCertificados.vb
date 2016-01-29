Option Strict Off
Option Explicit On

Imports ADODB

Friend Class frmCertificados
    Inherits Form

    Public RepID As Double

    Private Sub cmdCrear_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdCrear.Click
        MsgBox("Comming Soon!")
    End Sub

    Private Sub cmdSalir_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdBuscar_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdBuscar.Click
        Dim sQuery As String
        Dim sLES As String
        Dim sNV As Object
        Dim sMat As String
        Dim sREN As String

        Dim Rs As New Recordset
        Dim Cn As New Connection

        OpenConnection(Cn, Config.ConnectionString)

        Me.Cursor = Cursors.WaitCursor
        If chkREN.CheckState = 1 Then
            sREN = "(dbo.ResEst.rese_esta_r >= 8.5)"
        Else
            sREN = "(1=1)"
        End If

        If chkMAT.CheckState = 1 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object sMat. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sMat = "(dbo.ResEst.rese_esta_m >= 8.5)"
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object sMat. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sMat = "(1=1)"
        End If

        If chkNV.CheckState = 1 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object sNV. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sNV = "(dbo.ResEst.rese_esta_n >= 8.5)"
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object sNV. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sNV = "(1=1)"
        End If

        If chkLES.CheckState = 1 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object sLES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sLES = "(dbo.ResEst.rese_esta_l >= 8.5)"
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object sLES. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sLES = "(1=1)"
        End If

        sQuery =
            "SELECT     TOP 100 PERCENT dbo.ResEst.rese_id, dbo.ResEst.rese_nombre, dbo.Resultados.resg_Grado, dbo.ResEst.rese_esta_n, dbo.ResEst.rese_esta_l," &
            "dbo.ResEst.rese_esta_r , dbo.ResEst.rese_esta_m, dbo.Resultados.resg_rep_id " &
            "FROM dbo.Resultados INNER JOIN " & "dbo.ResEst ON dbo.Resultados.resg_id = dbo.ResEst.resg_id " &
            "WHERE (dbo.Resultados.resg_rep_id = " & Me.RepID & ") AND (dbo.Resultados.resg_Grado >= 1) AND " & "" &
            sREN & " AND " & "" & sMat & " AND " & "" & sLES & " AND " & "" & sNV & " " &
            "ORDER BY dbo.Resultados.resg_Grado, dbo.ResEst.rese_esta_n DESC"

        Rs.Open(sQuery, Cn, 3, 3)

        Me.List1.Items.Clear()
        While Not Rs.EOF
            Me.List1.Items.Add(
                "Grd: " & Rs.Fields("resg_Grado").Value & " " & Rs.Fields("rese_nombre").Value & " - " &
                Math.Round(Rs.Fields("rese_esta_l").Value, 0) & " - " & Math.Round(Rs.Fields("rese_esta_r").Value, 0) &
                " - " & Math.Round(Rs.Fields("rese_esta_m").Value, 0) & " - " &
                Math.Round(Rs.Fields("rese_esta_n").Value, 0))
            'UPGRADE_ISSUE: ListBox property List1.NewIndex was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="F649E068-7137-45E5-AC20-4D80A3CC70AC"'
            '--Code Change-- jh ' VB6.SetItemData(List1, Me.List1.Index, Rs.Fields("rese_id").Value)

            Dim currentItemNumber As Integer = Me.List1.Items.Add("MatchName")
            Microsoft.VisualBasic.Compatibility.VB6.SetItemData(List1, currentItemNumber, Rs.Fields("rese_id").Value)

            Rs.MoveNext()
        End While
        Rs.Close()
        Cn.Close()

        Me.Cursor = Cursors.Default

        'UPGRADE_NOTE: Object Rs may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Rs = Nothing
        'UPGRADE_NOTE: Object Cn may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Cn = Nothing
    End Sub

    Private Sub cmdConnTest_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdConnTest.Click
        Dim sQuery As String

        Dim Cn1 As New Connection
        Dim Cn2 As New Connection
        Dim Rs1 As New Recordset
        Dim Rs2 As New Recordset
        Dim Rs3 As New Recordset

        Dim Cs1 As String
        Dim Cs2 As String
        Dim iTime As Double
        Dim iTime2 As Double

        Debug.Print("step1:" & Now)
        iTime = Now.ToOADate
        'Cs1 = "Driver={SQL Native Client};Server=SERVER1;Database=LA; Uid=sa;Pwd=;"
        Cs1 = "Provider=MSDASQL.1;Persist Security Info=False;User ID=sa;Data Source=LearnAid;Initial Catalog=LA"

        OpenConnection(Cn1, Cs1)

        'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        sQuery = "SELECT Jobs.*, Claves3.CL_TYPE AS MAT_TYPE, " & "Claves2.CL_TYPE AS REN_TYPE, " &
              "Claves1.CL_TYPE AS NV_TYPE, " & "Claves.CL_TYPE AS LES_TYPE, CONSULTANTS.CON_NAME, " &
              "SCHOOLS.SC_SCH_NAME " & "FROM Claves RIGHT OUTER JOIN " & "CONSULTANTS RIGHT OUTER JOIN " &
              "SCHOOLS INNER JOIN " & "Jobs ON SCHOOLS.SC_ID = Jobs.J_SCH ON " & "CONSULTANTS.CON_ID = Jobs.J_CONS ON " &
              "Claves.CL_ID = Jobs.J_LES LEFT OUTER JOIN " & "Claves Claves1 ON " &
              "Jobs.J_NV = Claves1.CL_ID LEFT OUTER JOIN " & "Claves Claves2 ON " &
              "Jobs.J_REN = Claves2.CL_ID LEFT OUTER JOIN " & "Claves Claves3 ON Jobs.J_MAT = Claves3.CL_ID " &
              "Where Jobs.J_ID >= 1000"

        Rs1.Open(sQuery, Cn1, 3, 3)

        While Not Rs1.EOF
            Application.DoEvents()
            Rs1.MoveNext()
        End While
        Rs1.Close()
        Cn1.Close()

        Debug.Print("step2:" & Now)

        OpenConnection(Cn1, Cs1)
        sQuery = "select * from schools"
        Rs1.Open(sQuery, Cn1, 3, 3)

        While Not Rs1.EOF
            Rs1.MoveNext()
            Application.DoEvents()
        End While
        Rs1.Close()
        Cn1.Close()

        iTime2 = Now.ToOADate
        Debug.Print("finished:" & Now)
        'UPGRADE_WARNING: DateDiff behavior may be different. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B38EC3F-686D-4B2E-B5A5-9E8E7A762E32"'
        Debug.Print(
            "dif: " & DateDiff(DateInterval.Second, System.Date.FromOADate(iTime), System.Date.FromOADate(iTime2)))
        'UPGRADE_WARNING: DateDiff behavior may be different. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B38EC3F-686D-4B2E-B5A5-9E8E7A762E32"'
        MsgBox("dif " & DateDiff(DateInterval.Second, System.Date.FromOADate(iTime), System.Date.FromOADate(iTime2)))
    End Sub

    Private Sub frmCertificados_Load(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Load
        Dim sQuery As String
        Dim SchCity As String
        Dim SchName As String

        Dim Rs As New Recordset
        Dim Cn As New Connection

        OpenConnection(Cn, Config.ConnectionString)

        sQuery = "select sc_sch_name,sc_city from reports LEFT OUTER JOIN Schools ON rep_sch_id = sc_id where rep_id = " &
              Me.RepID
        Rs.Open(sQuery, Cn, 3, 3)

        If Rs.RecordCount = 1 Then
            SchName = Rs.Fields("sc_sch_name").Value
            SchCity = Rs.Fields("sc_city").Value
        End If

        Rs.Close()
        Cn.Close()
        Me.lclColegio.Text = SchName & " de " & SchCity

        'UPGRADE_NOTE: Object Cn may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Cn = Nothing
        'UPGRADE_NOTE: Object Rs may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        Rs = Nothing

        Me.chkLES.CheckState = CheckState.Checked
        Me.chkMAT.CheckState = CheckState.Checked
        Me.chkNV.CheckState = CheckState.Checked
        Me.chkREN.CheckState = CheckState.Checked
    End Sub
End Class