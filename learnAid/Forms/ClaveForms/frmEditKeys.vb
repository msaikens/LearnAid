Imports System.Data.SqlClient
Imports BLL.GlobalResources
Namespace Forms.ClaveForms

    Public Class frmEditKeys
        Dim EditingCell As Boolean
        Dim iDestreza As Short
        Dim EditingDes As Boolean
        Dim colCels As New Collection
        Dim Category As String
        Dim ClaveType As String
        Dim Destrezas(19) As DesType
        Public ClaveId As Integer

        Private Structure DesType
            Dim DesName As String
            Dim DesAbr As String
            Dim Desc As String
        End Structure
#Region "LEVEL ONE ROUTINES"
        Private Sub frmEditKeys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim iCounter1 As Integer
            SetGridProperty()
            LoadData()

            fraEditCell.Enabled = False
            EnableTextBox((False))

            For iCounter1 = 1 To 99
                _cboA_0.Items.Add(iCounter1)
            Next iCounter1
            For iCounter1 = 1 To 6
                _cboA_1.Items.Add(iCounter1)
            Next iCounter1
            _cboA_1.Items.Add("S")
            _cboA_1.Items.Add("N")
            ShowDestrezaInfo()
        End Sub
        Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
            SaveCellInfo()
        End Sub
        Private Sub btnAddToGrid_Click(sender As Object, e As EventArgs) Handles btnAddToGrid.Click
            SaveSkillGrid()
        End Sub
        Private Sub btnEditClave_Click(sender As Object, e As EventArgs) Handles btnEditClave.Click
            EditCellInfo()
        End Sub
        Private Sub btnEditSkill_Click(sender As Object, e As EventArgs) Handles btnEditSkill.Click
            ShowDestrezaInfo()
            EditDestrezaInfo()
        End Sub
        Private Sub _cboA_0_KeyDown(sender As Object, e As KeyEventArgs) Handles _cboA_0.KeyDown, _cboA_1.KeyDown
            If e.KeyCode = Keys.Enter Then
                SaveCellInfo()
            End If
        End Sub
        Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
            Me.Close()
        End Sub
        Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
            Call CreateNewClaveRecord()
            Me.Close()
        End Sub
        Private Sub dgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
            If Not IsDBNull(dgv.CurrentCell) And Not dgv.CurrentCell.Value Is Nothing Then
                _cboA_0.Text = Split(dgv.CurrentCell.Value, " - ")(0)
                _cboA_1.Text = Split(dgv.CurrentCell.Value, " - ")(1)
                ShowDestrezaInfo()
            Else
                _cboA_0.Text = String.Empty
                _cboA_1.Text = String.Empty
            End If
        End Sub
        Private Sub dgv_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseDoubleClick
            fraEditCell.Enabled = True
        End Sub
        Private Sub _txtDes_0_KeyDown(sender As Object, e As KeyEventArgs) Handles _txtDes_0.KeyDown, _txtDes_2.KeyDown, _txtDes_1.KeyDown
            If e.KeyCode = Keys.Enter Then
                SaveSkillGrid()
            End If
        End Sub
#End Region
#Region "LEVEL TWO ROUTINES"
        Sub CreateNewClaveRecord()
            Dim Cn As New ADODB.Connection
            Dim Cm As New ADODB.Command
            Dim Rs As New ADODB.Recordset

            Dim Clave As String
            Dim iCounter1 As Integer
            Dim iCounter2 As Integer
            Dim NewClaveID As Integer


            Dim Sep As String = "|"

            'OpenConnection(Cn, Config.ConnectionString)
            OpenConnection(Cn, Config.ConnectionStringAdo)
            Cm.ActiveConnection = Cn

            Cm.CommandText = "UPDATE CLAVES SET ACTIVE = 0 WHERE CL_ID=" & ClaveId.ToString.Trim
            Cm.Execute()

            Rs.Open("SELECT * FROM Claves WHERE CL_id=" & ClaveId, Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)

            For iCounter1 = 1 To 20
                Clave = String.Empty
                For iCounter2 = 1 To dgv.Rows.Count - 1
                    If iCounter2 = 1 Then
                        Sep = String.Empty
                    Else
                        Sep = "|"
                    End If
                    If Trim(dgv.Rows(iCounter2).Cells(iCounter1 - 1).Value) <> "" Then
                        Clave &= Sep & Replace(dgv.Rows(iCounter2).Cells(iCounter1 - 1).Value, " ", String.Empty)
                    End If
                Next iCounter2
                If Clave <> String.Empty Then
                    Rs.Fields("CL_" & iCounter1.ToString).Value = Clave
                End If
            Next iCounter1
            Rs.Fields("CL_Category").Value = Category
            Rs.Fields("CL_Type").Value = ClaveType
            Rs.Fields("active").Value = 1
            Rs.Update()
            NewClaveID = Rs.Fields("CL_ID").Value
            Rs.Close()
            Cn.Close()
            Call CreateNewDestrezaRecord(NewClaveID)

        End Sub

        Sub EditCellInfo()
            EditingCell = True
            fraEditCell.Enabled = True
            btnEditClave.Enabled = False
            _cboA_0.Focus()
            _cboA_0.Text = String.Empty
            _cboA_1.Text = String.Empty
            If Not IsDBNull(dgv.CurrentCell) And Not dgv.CurrentCell.Value Is Nothing Then
                _cboA_0.Text = Split(dgv.CurrentCell.Value, " - ")(0)
                _cboA_1.Text = Split(dgv.CurrentCell.Value, " - ")(1)
            End If

        End Sub

        Sub EditDestrezaInfo()
            If UCase(Category) = "N" Then Exit Sub
            fraDes.Text = "Skill " & dgv.CurrentCell.ColumnIndex + 1
            fraDes.Enabled = True
            btnEditSkill.Enabled = False
            EnableTextBox((True))
            EditingDes = True

            Me._txtDes_0.Focus()
            iDestreza = dgv.CurrentCell.ColumnIndex
            With Destrezas(iDestreza)
                Me._txtDes_1.Text = .DesAbr
                Me._txtDes_2.Text = .Desc
                Me._txtDes_0.Text = .DesName
            End With
        End Sub

        Sub EnableTextBox(ByVal enable As Boolean)
            If Not enable Then
                _txtDes_0.Enabled = False
                _txtDes_1.Enabled = False
                _txtDes_2.Enabled = False
                btnAddToGrid.Enabled = False
            Else
                _txtDes_0.Enabled = True
                _txtDes_1.Enabled = True
                _txtDes_2.Enabled = True
                btnAddToGrid.Enabled = True
            End If
        End Sub

        Sub LoadData()
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset

            Dim iCounter1 As Integer
            Dim iCounter2 As Integer
            Dim Ans As Object

            'Dim columns As Integer
            'OpenConnection(Cn, Config.ConnectionString)
            OpenConnection(Cn, Config.ConnectionStringAdo)
            Rs.Open("Select Claves.*, Destrezas.* From Claves Left Outer Join Destrezas ON Claves.CL_ID = Destrezas.D_CL_ID Where Claves.CL_ID = " & ClaveId, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            If Not Rs.EOF Then
                Category = GetValue(Rs.Fields("CL_Category"))
                ClaveType = GetValue(Rs.Fields("CL_Type"))
                dgv.Rows.Add(20)
                dgv.Rows(0).Visible = False
                For iCounter1 = 1 To 20
                    With Destrezas(iCounter1 - 1)
                        dgv.Rows(0).Cells(iCounter1 - 1).Value = GetValue(Rs.Fields("D_" & iCounter1.ToString.Trim & "_Nombre"))
                        dgv.Columns(iCounter1 - 1).HeaderText = GetValue(Rs.Fields("D_" & iCounter1.ToString.Trim & "_Nombre"))

                        .DesName = GetValue(Rs.Fields("D_" & iCounter1.ToString.Trim & "_Nombre"))
                        .DesAbr = GetValue(Rs.Fields("D_" & iCounter1.ToString.Trim & "_ABR"))
                        .Desc = GetValue(Rs.Fields("D_" & iCounter1.ToString.Trim & "_Desc"))

                        Ans = GetValue(Rs.Fields("CL_" & iCounter1.ToString.Trim))
                        Ans = Split(Ans, "|")
                        For iCounter2 = 0 To UBound(Ans, 1)
                            If Trim(Ans(iCounter2)) <> "" Then
                                dgv.Rows(iCounter2 + 1).Cells(iCounter1 - 1).Value = Trim(Split(Ans(iCounter2), "-")(0)) & " - " & Trim(Split(Ans(iCounter2), "-")(1))
                            End If
                        Next iCounter2
                    End With
                Next iCounter1
            End If
            Rs.Close()
            Cn.Close()
        End Sub
        Sub SaveCellInfo()
            If Trim(__cboA_0.Text) <> String.Empty Or Trim(_cboA_1.Text) <> String.Empty Then
                If Trim(_cboA_0.Text) = "" Or Not ItemIsInList(_cboA_0) Then
                    MsgBox("Invalid Question Number", MsgBoxStyle.Information)
                    EditingCell = True
                    _cboA_0.Focus()
                    Exit Sub
                End If

                If Trim(_cboA_1.Text) = String.Empty Or Not ItemIsInList(_cboA_1) Then
                    MsgBox("Invalid Answer Value", MsgBoxStyle.Information)
                    EditingCell = True
                    _cboA_1.Focus()
                    Exit Sub
                End If
            End If

            dgv.CurrentCell.Value = _cboA_0.Text & " - " & UCase(_cboA_1.Text)
            fraEditCell.Enabled = False
            EditingCell = False
            btnEditClave.Enabled = True

        End Sub
        Private Sub SaveSkillGrid()

            btnEditSkill.Enabled = True

            If Not IsDBNull(dgv.CurrentCell) And Not dgv.CurrentCell.Value Is Nothing Then
                dgv.Rows(0).Cells(dgv.CurrentCell.ColumnIndex).Value = _txtDes_0.Text
                dgv.Columns(dgv.CurrentCell.ColumnIndex).HeaderText = _txtDes_0.Text

                With Destrezas(dgv.CurrentCell.ColumnIndex)
                    .DesAbr = Me._txtDes_1.Text
                    .Desc = Me._txtDes_2.Text
                    .DesName = Me._txtDes_0.Text
                End With
            End If
            fraDes.Enabled = False
        End Sub

        Private Sub SetGridProperty()
            For Each col As DataGridViewColumn In dgv.Columns
                col.Width = 80
            Next
        End Sub
        Sub ShowDestrezaInfo()
            If Not dgv.CurrentCell Is Nothing Then
                fraDes.Text = "Skill " & dgv.CurrentCell.ColumnIndex + 1
                With Destrezas(dgv.CurrentCell.ColumnIndex)
                    Me._txtDes_1.Text = .DesAbr
                    Me._txtDes_2.Text = .Desc
                    Me._txtDes_0.Text = .DesName
                End With
            End If
        End Sub

#End Region
#Region "LEVEL THREE ROUTINES"

        Sub CreateNewDestrezaRecord(ByVal CL_ID As Integer)
            Dim iCounter1 As Integer
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset

            'OpenConnection(Cn, Config.ConnectionString)
            OpenConnection(Cn, Config.ConnectionStringAdo)
            Rs.Open("SELECT * FROM DESTREZAS WHERE D_CL_ID=" & ClaveId, Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)

            If Not Rs.EOF Then
                For iCounter1 = 1 To 20
                    Rs.Fields("D_" & iCounter1.ToString.Trim & "_Nombre").Value = Destrezas(iCounter1 - 1).DesName
                    Rs.Fields("D_" & iCounter1.ToString.Trim & "_ABR").Value = Destrezas(iCounter1 - 1).DesAbr
                    If Destrezas(iCounter1 - 1).Desc = String.Empty Then
                        Rs.Fields("D_" & iCounter1.ToString.Trim & "_DESC").Value = String.Empty
                    Else
                        Rs.Fields("D_" & iCounter1.ToString.Trim & "_DESC").Value = Destrezas(iCounter1 - 1).Desc
                    End If
                Next iCounter1
                Rs.Update()
            End If
            Rs.Close()
            Cn.Close()
        End Sub
#End Region
        
#Region "Unknown Routines"
        Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        End Sub
#End Region

    End Class
End Namespace