Namespace Forms.InheritableForms
    Public Class frmBaseWithNoCloseButton
        Inherits System.Windows.Forms.Form

        Private Const CP_NOCLOSE_BUTTON As Integer = &H200
        ''' <summary>
        ''' Disable the Close Button
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Protected Overrides ReadOnly Property CreateParams() As CreateParams
            Get
                Dim myCp As CreateParams = MyBase.CreateParams
                myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
                Return myCp
            End Get
        End Property
        'Protected Overloads Overrides Sub WndProc(ByRef m As Message)
        '    Const WM_NCLBUTTONDOWN As Integer = 161
        '    Const WM_SYSCOMMAND As Integer = 274
        '    Const HTCAPTION As Integer = 2
        '    Const SC_MOVE As Integer = 61456

        '    If (m.Msg = WM_SYSCOMMAND) AndAlso (m.WParam.ToInt32() = SC_MOVE) Then
        '        Exit Sub
        '    End If

        '    If (m.Msg = WM_NCLBUTTONDOWN) AndAlso (m.WParam.ToInt32() = HTCAPTION) Then
        '        Exit Sub
        '    End If
        '    MyBase.WndProc(m)
        'End Sub

        Private Sub frmBaseWithNoCloseButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace