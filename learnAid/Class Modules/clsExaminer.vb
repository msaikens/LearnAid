Option Strict Off
Option Explicit On
Friend Class clsExaminer
    Private mvarActivity As New colServDetail 'local copy
    Private mvarExaminerID As Integer 'local copy
	Private mvarFName As String 'local copy
	Private mvarLName1 As String 'local copy
	Private mvarLName2 As String 'local copy

	
    Public Property Activity() As colServDetail
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.Activity
            Activity = mvarActivity
        End Get
        Set(ByVal Value As colServDetail)
            'used when assigning an Object to the property, on the left side of a Set statement.
            'Syntax: Set x.Activity = Form1
            mvarActivity = Value
        End Set
    End Property

    Public Property ExaminerID() As Integer
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.ExaminerID
            ExaminerID = mvarExaminerID
        End Get
        Set(ByVal Value As Integer)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.ExaminerID = 5
            mvarExaminerID = Value
        End Set
    End Property

    Public Property FName() As String
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.FName
            FName = mvarFName
        End Get
        Set(ByVal Value As String)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.FName = 5
            mvarFName = Value
        End Set
    End Property

    Public Property LName1() As String
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.LName1
            LName1 = mvarLName1
        End Get
        Set(ByVal Value As String)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.LName1 = 5
            mvarLName1 = Value
        End Set
    End Property

	Public Property LName2() As String
		Get
			'used when retrieving value of a property, on the right side of an assignment.
			'Syntax: Debug.Print X.LName2
			LName2 = mvarLName2
		End Get
		Set(ByVal Value As String)
			'used when assigning a value to the property, on the left side of an assignment.
			'Syntax: X.LName2 = 5
			mvarLName2 = Value
		End Set
	End Property

End Class