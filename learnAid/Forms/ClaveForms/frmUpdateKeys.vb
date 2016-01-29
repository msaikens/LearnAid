Imports learnAid.BLL
Imports Microsoft.VisualBasic.Compatibility
Namespace Forms.ClaveForms
    Public Class frmUpdateKeys

        Protected isValid As Integer
        Protected zero As Integer = 0
        Protected one As Integer = 1

#Region "LEVEL ONE ROUTINES"
        Private Sub frmUpdateKeys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            cboDB.Items.Clear()
            cboDB.Items.Add("LA")
            'cboDB.Items.Add("TITULO1")
            cboDB.SelectedIndex = 0
            LoadData()
        End Sub
        Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
            isValid = Validation()
            If Not isValid Then
                Exit Sub
            End If
            frmEditKeys.ClaveId = VB6.GetItemData(cmbEdit, cmbEdit.SelectedIndex)
            frmEditKeys.Show()
        End Sub
        Private Sub cmdEditDestrezas_Click(sender As Object, e As EventArgs) Handles cmdEditDestrezas.Click
            isValid = Validation()
            If Not isValid Then
                Exit Sub
            End If
            frmEditSkills.ClaveId = VB6.GetItemData(cmbEdit, cmbEdit.SelectedIndex)
            frmEditSkills.Show()
        End Sub
        Private Sub Command1_Click(sender As Object, e As EventArgs) Handles Command1.Click
            isValid = Validation()
            If Not isValid Then
                Exit Sub
            End If
            frmRules.ClaveID = cmbEdit.SelectedItem
            frmRules.Show()
        End Sub
#End Region
#Region "LEVEL TWO ROUTINES"

        Private Sub LoadData()
            'Dim Cn As New ADODB.Connection

            'Select Case Me.cboDB.Text
            '    Case "LA"
            '        CnStr = "Provider=MSDASQL.1;Persist Security Info=False;User ID=sa;Data Source=Learnaid;Initial Catalog=LA"
            '    Case "TITULO1"
            '        CnStr = "Provider=MSDASQL.1;Persist Security Info=False;User ID=sa;Data Source=La_titulo1;Initial Catalog=LA_TITULO1"
            'End Select
            'Cn.Open(CnStr)

            'Dim Rs As New ADODB.Recordset

            'OpenConnection(Cn, Config.ConnectionString)

            'Rs.Open("SELECT * FROM Claves WHERE Active = 1 ORDER BY cl_type", Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            'cmbEdit.Items.Clear()
            'While Not Rs.EOF
            '    cmbEdit.Items.Add(Rs.Fields("cl_type").Value)
            '    VB6.SetItemData(cmbEdit, cmbEdit.Items.Count - 1, Rs.Fields("CL_ID").Value)
            '    Rs.MoveNext()
            'End While
            'Rs.Close()
            'Cn.Close()

            Dim sQuery As String = "SELECT * FROM Claves WHERE Active = 1 ORDER BY cl_type"
            Dim dt As DataTable = GlobalResources.ExecuteDataTable(sQuery)
            Dim iCounter1 As Integer

            For iCounter1 = 0 To dt.Rows.Count - 1
                cmbEdit.Items.Add(dt.Rows(iCounter1)("cl_type").ToString())
                VB6.SetItemData(cmbEdit, cmbEdit.Items.Count - 1, dt.Rows(iCounter1)("CL_ID").ToString())
            Next
        End Sub
        Private Function Validation()
            If cmbEdit.Text = "" Then
                MessageBox.Show("You must select a test.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            Return True
        End Function
#End Region

        

        

        

        
    End Class
End Namespace