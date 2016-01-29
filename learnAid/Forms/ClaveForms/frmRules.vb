Imports ADODB

Namespace Forms.ClaveForms
    Public Class frmRules
        Public ClaveID As Integer
        Public txtAbr = New Collection
#Region "LEVEL ONE ROUTINES"
        Private Sub frmRules_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim sQuery As String
            Dim Rs As New ADODB.Recordset
            Dim Cn As New ADODB.Connection

            Dim cltype As Object = Nothing

            'AddTextBoxToArray()

            'Dim Y As Short

            OpenConnection(Cn, Config.ConnectionString)

            sQuery = "Select  * From claves Where Claves.CL_ID = " & Me.ClaveID.ToString.Trim
            Rs.Open(sQuery, Cn, 3, 3)
            If Rs.RecordCount = 1 Then
                cltype = Rs.Fields("cl_type").Value
            End If
            Rs.Close()

            sQuery = "select * from normas where n_clave = '" & cltype & "'"
            Rs.Open(sQuery, Cn, 1, 3, 0)
            If Rs.RecordCount >= 1 Then
                'For Y = 0 To 8
                '    Me.txtAbr(Y).Text = GetValue(Rs.Fields("n_" & Y + 1 & "_to"))
                'Next Y

                _txtAbr_0.Text = GetValue(Rs.Fields("n_1_to"))
                _txtAbr_1.Text = GetValue(Rs.Fields("n_2_to"))
                _txtAbr_2.Text = GetValue(Rs.Fields("n_3_to"))
                _txtAbr_3.Text = GetValue(Rs.Fields("n_4_to"))
                _txtAbr_4.Text = GetValue(Rs.Fields("n_5_to"))
                _txtAbr_5.Text = GetValue(Rs.Fields("n_6_to"))
                _txtAbr_6.Text = GetValue(Rs.Fields("n_7_to"))
                _txtAbr_7.Text = GetValue(Rs.Fields("n_8_to"))
                _txtAbr_8.Text = GetValue(Rs.Fields("n_9_to"))

                Me.txtSD.Text = GetValue(Rs.Fields("n_stdev"))
                Me.txtLD.Text = GetValue(Rs.Fields("n_lwdev"))
                Me.txtM.Text = GetValue(Rs.Fields("n_media"))
            End If
            Rs.Close()
            Cn.Close()
        End Sub
        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub
        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            Dim sQuery As String
            Dim Rs As New ADODB.Recordset
            Dim Cn As New ADODB.Connection

            Dim cltype As Object = Nothing
            'Dim Y As Short
            If MsgBox("Esta seguro de grabar los cambios?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Grabar Destrezas") = MsgBoxResult.No Then
                Exit Sub
            End If
            OpenConnection(Cn, Config.ConnectionString)

            sQuery = "Select  * From claves Where Claves.CL_ID = " & Me.ClaveID.ToString.Trim
            Rs.Open(sQuery, Cn, 3, 3)
            If Rs.RecordCount = 1 Then
                cltype = Rs.Fields("cl_type").Value
            End If
            Rs.Close()

            sQuery = "select * from normas where n_clave = '" & cltype & "'"
            Rs.Open(sQuery, Cn, 1, 3, 0)

            While Not Rs.EOF
                'For Y = 1 To 9
                '    Rs.Fields("n_" & Y & "_to").Value = Me.txtAbr(Y - 1).Text
                'Next Y
                If Not _txtAbr_0.Text = "" Then
                    Rs.Fields("n_1_to").Value = _txtAbr_0.Text
                End If
                If Not _txtAbr_1.Text = "" Then
                    Rs.Fields("n_2_to").Value = _txtAbr_1.Text
                End If
                If Not _txtAbr_2.Text = "" Then
                    Rs.Fields("n_3_to").Value = _txtAbr_2.Text
                End If
                If Not _txtAbr_3.Text = "" Then
                    Rs.Fields("n_4_to").Value = _txtAbr_3.Text
                End If
                If Not _txtAbr_4.Text = "" Then
                    Rs.Fields("n_5_to").Value = _txtAbr_4.Text
                End If
                If Not _txtAbr_5.Text = "" Then
                    Rs.Fields("n_6_to").Value = _txtAbr_5.Text
                End If
                If Not _txtAbr_6.Text = "" Then
                    Rs.Fields("n_7_to").Value = _txtAbr_6.Text
                End If
                If Not _txtAbr_7.Text = "" Then
                    Rs.Fields("n_8_to").Value = _txtAbr_7.Text
                End If
                If Not _txtAbr_8.Text = "" Then
                    Rs.Fields("n_9_to").Value = _txtAbr_8.Text
                End If

                Rs.Fields("n_media").Value = Me.txtM.Text
                Rs.Fields("n_stdev").Value = Me.txtSD.Text
                Rs.Fields("n_lwdev").Value = Me.txtLD.Text
                Rs.Update()
                Rs.MoveNext()
            End While
            Rs.Close()
            Cn.Close()
            Me.Close()
        End Sub
#End Region
#Region "Unknown Routines"
        Public Sub AddTextBoxToArray()
            txtAbr.Add(_txtAbr_0)
            txtAbr.Add(_txtAbr_1)
            txtAbr.Add(_txtAbr_2)
            txtAbr.Add(_txtAbr_3)
            txtAbr.Add(_txtAbr_4)
            txtAbr.Add(_txtAbr_5)
            txtAbr.Add(_txtAbr_6)
            txtAbr.Add(_txtAbr_7)
            txtAbr.Add(_txtAbr_8)
        End Sub
#End Region
    End Class
End Namespace