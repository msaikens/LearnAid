Option Strict Off
Option Explicit On

Imports Microsoft.VisualBasic.PowerPacks

Namespace Forms.AccountingForms
    Friend Class frmnominaprocess
        Inherits System.Windows.Forms.Form
        'UPGRADE_WARNING: Form event frmnominaprocess.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        Private Sub frmnominaprocess_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
            Call Accounting_Mod.CreateAccounting()
        End Sub
    End Class
End Namespace