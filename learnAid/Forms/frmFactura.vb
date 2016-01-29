Option Strict Off
Option Explicit On
Friend Class frmFactura
	Inherits System.Windows.Forms.Form
	Public lFactID As Integer
	
	Private Sub cmdExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.Click
		Me.Close()
		
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		
		Dim Cn As New ADODB.Connection
		Dim Rs As New ADODB.Recordset
		
		OpenConnection(Cn, Config.ConnectionString)
		
		Rs.Open("Select * from factura WHERE f_RepId = " & Me.lFactID, Cn, 1, 3, 0)
		If Not Rs.EOF Then
            Rs.Fields("f_ar_grados").Value = Me.txtGrados.Text

            If Me.txtGrupos.Text = "" Then
                Rs.Fields("f_ar_grupos").Value = 0
            Else
                Rs.Fields("f_ar_grupos").Value = Int32.Parse(Me.txtGrupos.Text)
            End If

            If Me.txtEst.Text = "" Then
                Rs.Fields("f_ar_est").Value = 0
            Else
                Rs.Fields("f_ar_est").Value = Int32.Parse(txtEst.Text)
            End If

            If Me.txtAmount.Text = "" Then
                Rs.Fields("f_ar_amount_group").Value = 0
            Else
                Rs.Fields("f_ar_amount_group").Value = Decimal.Parse(Me.txtAmount.Text.Replace("$", ""))
            End If

            If Me.txtTotal.Text = "" Then
                Rs.Fields("f_ar_total").Value = 0
            Else
                Rs.Fields("f_ar_total").Value = Decimal.Parse(Me.txtTotal.Text.Replace("$", ""))
            End If
            Rs.Update()
        End If

            Rs.Close()
            Cn.Close()
            Me.Close()

	End Sub
	
	Private Sub frmFactura_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Dim Cn As New ADODB.Connection
		Dim Rs As New ADODB.Recordset
		
		OpenConnection(Cn, Config.ConnectionString)
		
		Rs.Open("Select * from factura WHERE f_RepId = " & Me.lFactID, Cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
		If Not Rs.EOF Then
            Me.txtGrados.Text = GetValue(Rs.Fields("f_ar_grados"))
			Me.txtGrupos.Text = GetValue(Rs.Fields("f_ar_grupos"), 0)
			Me.txtEst.Text = GetValue(Rs.Fields("f_ar_est"), 0)
            If GetValue(Rs.Fields("f_ar_amount_group"), 0) = "" Then
                Me.txtAmount.Text = "$0.00"
            Else
                Me.txtAmount.Text = FormatCurrency(GetValue(Rs.Fields("f_ar_amount_group"), 0))
            End If

            Me.txtTotal.Text = FormatCurrency(CDbl(Me.txtGrupos.Text.Replace("$", "")) * CDbl(Me.txtAmount.Text.Replace("$", "")))
		End If
		
		Rs.Close()
		Cn.Close()
		
		
	End Sub
End Class