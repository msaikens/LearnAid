Namespace Forms.StudentsForm
    Public Class frmFindStudents


        Private Sub Find_CancelBtn_Click(sender As Object, e As EventArgs) Handles Find_CancelBtn.Click
            Me.Close()
        End Sub

        Private Sub FindStdntSearchBtn_Click(sender As Object, e As EventArgs) Handles FindStdntSearchBtn.Click
            If validity() = 0 Then
                Exit Sub
            End If

            frmStudentResult.Show()
        End Sub

        Protected Function validity() As Integer
            If Find_FirstName.Text = String.Empty Or Find_LNameBox.Text = String.Empty Then
                MessageBox.Show("You must enter a first name or a last name.", "Input Error", MessageBoxButtons.OK)
                Return 0
            End If
            Return 1
        End Function

        Private Sub frmFindStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace