Imports System.Text
Imports learnAid.BLL

Namespace Forms.StudentsForm
    Public Class frmStudentResult

        Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
            SearchStudent()
        End Sub

        Private Sub SearchStudent()
            Dim iCounter1 As Integer
            Dim sqlQuery = New StringBuilder()

            If (String.IsNullOrEmpty(txtStudentName.Text) And String.IsNullOrEmpty(txtSchool.Text) And String.IsNullOrEmpty(txtJobName.Text) And
                String.IsNullOrEmpty(txtScZip.Text)) Then
                MessageBox.Show(Me, "Please Enter the Search Criteria.!!")
                Return
            End If

            sqlQuery.Clear()
            sqlQuery.Append("select t1.a_id, t1.a_nombre student, t1.a_school schoolId,t2.SC_SCH_CODE schoolCode, ")
            sqlQuery.Append("t2.SC_SCH_NAME schoolName, t2.sc_type schoolType,t1.a_j_id jobId,t2.SC_Address1,t2.SC_Address2,t2.SC_City,t2.SC_ZipCode ")
            sqlQuery.Append("from answers t1 ")
            sqlQuery.Append("left join SCHOOLS t2 on t1.a_school = t2.SC_ID ")
            sqlQuery.Append("left join Jobs t3 on t1.a_j_id = t3.J_ID where 1=1 ")
            If (Not String.IsNullOrEmpty(txtStudentName.Text.Trim())) Then
                sqlQuery.AppendFormat("and t1.a_nombre like '{0}'", GetLikeCondition(txtStudentName.Text))
            End If
            If (Not String.IsNullOrEmpty(txtSchool.Text.Trim())) Then
                sqlQuery.AppendFormat("and t2.SC_SCH_NAME like '{0}'", GetLikeCondition(txtSchool.Text))
            End If
            If (Not String.IsNullOrEmpty(txtJobName.Text)) Then
                sqlQuery.AppendFormat("and t1.a_j_id = {0}", txtJobName.Text)
            End If
            If (Not String.IsNullOrEmpty(txtScZip.Text)) Then
                sqlQuery.AppendFormat("and t2.SC_ZipCode like '{0}'", GetLikeCondition(txtScZip.Text))
            End If

            dataGrid.Rows.Clear()
            Dim dt As DataTable = GlobalResources.ExecuteDataTable(sqlQuery.ToString())


            For iCounter1 = 0 To dt.Rows.Count - 1
                Dim row = dataGrid.Rows.Add()
                dataGrid.Rows(row).Cells("colId").Value = dt.Rows(iCounter1)("a_id").ToString()
                dataGrid.Rows(row).Cells("colStudent").Value = dt.Rows(iCounter1)("student").ToString()
                dataGrid.Rows(row).Cells("colSchoolId").Value = dt.Rows(iCounter1)("schoolId").ToString()
                dataGrid.Rows(row).Cells("colSchoolName").Value = dt.Rows(iCounter1)("schoolName").ToString()
                dataGrid.Rows(row).Cells("colSchoolAdd1").Value = dt.Rows(iCounter1)("SC_Address1").ToString()
                dataGrid.Rows(row).Cells("colSchoolAdd2").Value = dt.Rows(iCounter1)("SC_Address2").ToString()
                dataGrid.Rows(row).Cells("colSchoolCity").Value = dt.Rows(iCounter1)("SC_City").ToString()
                dataGrid.Rows(row).Cells("colSchoolZip").Value = dt.Rows(iCounter1)("SC_ZipCode").ToString()
            Next iCounter1

            Me.Cursor = Cursors.Default
        End Sub

        Private Sub frmStudentResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.MdiParent = frmMain
        End Sub

        Public Function GetLikeCondition(condition As String) As String
            Dim result As String = condition
            If (rbStartWith.Checked) Then
                result = condition & "%"
            ElseIf (rbEndWith.Checked) Then
                result = "%" & condition
            ElseIf (rbAny.Checked) Then
                result = "%" & condition & "%"
            End If
            Return result
        End Function

        Private Sub txtStudentName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStudentName.KeyDown, txtScZip.KeyDown, txtSchool.KeyDown, txtJobName.KeyDown
            If e.KeyCode = Keys.Enter Then
                SearchStudent()
            End If
        End Sub
    End Class
End Namespace