Namespace Forms.ClaveForms
    Public Class frmEditSkills
        Public ClaveId As Integer
#Region "LEVEL ONE ROUTINES"
        Private Sub frmEditSkills_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim iCounter1 As Integer
            Dim style = New DataGridViewCellStyle
            style.Alignment = DataGridViewContentAlignment.MiddleLeft
            grid.Rows.Add(20)
            For iCounter1 = 0 To grid.Rows.Count - 1
                grid.Rows(iCounter1).Height = 30
                grid.Rows(iCounter1).HeaderCell.Value = CStr(iCounter1 + 1)
                grid.Rows(iCounter1).HeaderCell.Style = style
            Next iCounter1
            grid.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders)
            LoadData()
        End Sub
        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub
        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            Dim sQuery As String
            Dim rs As New ADODB.Recordset
            Dim cn As New ADODB.Connection
            Dim iCounter1 As Integer

            If MsgBox("Esta seguro de grabar los cambios?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Grabar Destrezas") = MsgBoxResult.No Then
                Exit Sub
            End If
            OpenConnection(cn, Config.ConnectionString)
            sQuery = "select * from destrezas where d_cl_id = " & Me.ClaveId.ToString.Trim
            rs.Open(squery, cn, 1, 3, 0)
            If rs.RecordCount = 1 Then
                For iCounter1 = 0 To 19
                    rs.Fields("d_" & (iCounter1 + 1).ToString.Trim & "_abr").Value = grid.Rows(iCounter1).Cells(0).Value
                Next iCounter1

                For iCounter1 = 0 To 19
                    rs.Fields("d_" & (iCounter1 + 1).ToString.Trim & "_nombre").Value = grid.Rows(iCounter1).Cells(1).Value
                Next iCounter1

                For iCounter1 = 0 To 19
                    rs.Fields("d_" & (iCounter1 + 1).ToString.Trim & "_desc").Value = grid.Rows(iCounter1).Cells(2).Value
                Next iCounter1

                For iCounter1 = 0 To 19
                    rs.Fields("d_" & (iCounter1 + 1).ToString.Trim & "_desc_str").Value = grid.Rows(iCounter1).Cells(2).Value
                Next iCounter1
                rs.Update()
            End If
            rs.Close()
            cn.Close()
        End Sub
#End Region
#Region "LEVEL TWO ROUTINES"

        Private Sub LoadData()
            Dim sQuery As String
            Dim rs As New ADODB.Recordset
            Dim cn As New ADODB.Connection
            Dim iCounter1 As Integer

            OpenConnection(cn, Config.ConnectionString)

            sQuery = "select * from destrezas where d_cl_id = " & Me.ClaveId.ToString.Trim
            rs.Open(sQuery, cn, 1, 3, 0)
            If rs.RecordCount = 1 Then
                For iCounter1 = 0 To 19
                    Dim calc = iCounter1 + 1
                    Dim field = "d_" & calc.ToString.Trim & "_abr"
                    grid.Rows(iCounter1).Cells(0).Value = GetValue(rs.Fields(field))
                Next iCounter1

                For iCounter1 = 0 To 19
                    Dim calc = iCounter1 + 1
                    Dim field = "d_" & calc.ToString.Trim & "_nombre"
                    grid.Rows(iCounter1).Cells(1).Value = GetValue(rs.Fields(field))
                Next iCounter1

                For iCounter1 = 0 To 19
                    Dim calc = iCounter1 + 1
                    Dim field = "d_" & calc.ToString.Trim & "_desc"
                    grid.Rows(iCounter1).Cells(2).Value = GetValue(rs.Fields(field))
                Next iCounter1
            ElseIf rs.RecordCount = 0 Then
                rs.AddNew()
                rs.Fields("d_cl_id").Value = Me.ClaveId
                rs.Fields("d_1_abr").Value = ""
                rs.Fields("d_1_nombre").Value = ""
                rs.Fields("d_1_desc").Value = ""
                rs.Update()
            End If
            rs.Close()
            cn.Close()
        End Sub
#End Region


    End Class
End Namespace