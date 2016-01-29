Option Strict Off
Option Explicit On
Friend Class Nomina
	Private mvarExaminer As New colExaminers 'local copy
	
	
	
	Public Property Examiner() As colExaminers
		Get
			'used when retrieving value of a property, on the right side of an assignment.
			'Syntax: Debug.Print X.Examiner
			Examiner = mvarExaminer
		End Get
		Set(ByVal Value As colExaminers)
			'used when assigning an Object to the property, on the left side of a Set statement.
			'Syntax: Set x.Examiner = Form1
			mvarExaminer = Value
		End Set
	End Property
End Class