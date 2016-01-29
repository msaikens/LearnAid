Option Strict Off
Option Explicit On

Imports learnAid.BLL

Namespace Forms.MasterForms
    Friend Class frmNewConsultant
        Inherits System.Windows.Forms.Form
        Public iConsID As Integer

#Region "LEVEL ONE ROUTINES"
        Private Sub frmNewConsultant_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
            If iConsID > 0 Then
                Call LoadData()
            End If
        End Sub
        Private Sub frmNewConsultant_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
            iConsID = 0
        End Sub

        Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
            Me.Close()
        End Sub
        Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
            Dim VC As New ValidateClass
            If VC.ValidateForm(Me) Then
                If iConsID > 0 Then
                    Call UpdateCons()
                Else
                    Call CreateNewCons()
                End If
                Me.Close()
            End If
        End Sub
#End Region
#Region "LEVEL TWO ROUTINES"

        Sub CreateNewCons()
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset

            OpenConnection(Cn, Config.ConnectionString)

            Rs.Open("Select * From Consultants Where Con_ID=-1", Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
            Rs.AddNew()
            Rs.Fields("CON_NAME").Value = txtName.Text
            Rs.Fields("Con_Type").Value = IIf(Me.optCons.Checked, "C", "E")
            Rs.Fields("Con_LName1").Value = txtLastName1.Text
            Rs.Fields("Con_LName2").Value = txtLastName2.Text
            Rs.Fields("Con_Address").Value = txtAddress.Text
            Rs.Fields("Con_City").Value = txtCity.Text
            Rs.Fields("Con_ZipCode").Value = txtZipCode.Text
            Rs.Fields("Con_Phone").Value = txtPhone.Text
            Rs.Update()
            Rs.Close()
            Cn.Close()
        End Sub

        Sub LoadData()
            Dim sQuery As String = "Select * From Consultants Where Con_ID = " & iConsID
            Dim dt As DataTable = GlobalResources.ExecuteDataTable(sQuery)
            Dim iCounter1 As Integer = 0

            If dt.Rows.Count > 0 Then
                Me.txtName.Text = (dt.Rows(0)("CON_NAME").ToString())
                Me.txtLastName1.Text = (dt.Rows(0)("Con_LName1").ToString())
                Me.txtLastName2.Text = (dt.Rows(0)("Con_LName2").ToString())
                Me.txtAddress.Text = (dt.Rows(0)("Con_Address").ToString())
                Me.txtCity.Text = (dt.Rows(0)("Con_City").ToString())
                Me.txtZipCode.Text = (dt.Rows(0)("Con_ZipCode").ToString())
                Me.txtPhone.Text = (dt.Rows(0)("Con_Phone").ToString())

                If dt.Rows(0)("Con_Type").ToString() = "C" Then
                    optCons.Checked = True
                    optExaminer.Checked = False
                Else
                    optCons.Checked = False
                    optExaminer.Checked = True
                End If

            End If
        End Sub

        Sub UpdateCons()
            Dim Cn As New ADODB.Connection
            Dim Rs As New ADODB.Recordset

            OpenConnection(Cn, Config.ConnectionString)

            Rs.Open("Select * From Consultants Where Con_ID=" & iConsID, Cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
            If Not Rs.EOF Then
                Rs.Fields("CON_NAME").Value = txtName.Text
                Rs.Fields("Con_Type").Value = IIf(Me.optCons.Checked, "C", "E")
                Rs.Fields("Con_LName1").Value = txtLastName1.Text
                Rs.Fields("Con_LName2").Value = txtLastName2.Text
                Rs.Fields("Con_Address").Value = txtAddress.Text
                Rs.Fields("Con_City").Value = txtCity.Text
                Rs.Fields("Con_ZipCode").Value = txtZipCode.Text
                Rs.Fields("Con_Phone").Value = txtPhone.Text
                Rs.Update()
            End If
            Rs.Close()
            Cn.Close()
        End Sub
#End Region

    End Class
End Namespace