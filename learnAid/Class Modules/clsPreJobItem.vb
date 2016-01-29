Option Strict Off
Option Explicit On
Friend Class clsPreJobItem
	'local variable(s) to hold property value(s)

    Private mvarConsultant1 As Integer 'local copy
    Private mvarConsultant2 As Integer 'local copy
    Private mvarConsultant3 As Integer 'local copy
    Private mvarGrade As Short 'local copy
    Private mvarLES As Integer 'local copy
    Private mvarMAT As Integer 'local copy
    Private mvarNV As Integer 'local copy
    Private mvarPlugin As String
    Private mvarPrice As Double 'local copy
    Private mvarREN As Integer 'local copy
    Private mvarServDate As String 'local copy
    Private mvarSection As String 'local copy
	Private mvarStudents As Short 'local copy
    Private mvarToll1 As Short
    Private mvarToll2 As Short


    Public Property Consultant1() As Integer
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.Consultant1
            Consultant1 = mvarConsultant1
        End Get
        Set(ByVal Value As Integer)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.Consultant1 = 5
            mvarConsultant1 = Value
        End Set
    End Property

    Public Property Consultant2() As Integer
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.Consultant2
            Consultant2 = mvarConsultant2
        End Get
        Set(ByVal Value As Integer)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.Consultant2 = 5
            mvarConsultant2 = Value
        End Set
    End Property

	Public Property Consultant3() As Integer
		Get
			'used when retrieving value of a property, on the right side of an assignment.
			'Syntax: Debug.Print X.Consultant3
			Consultant3 = mvarConsultant3
		End Get
		Set(ByVal Value As Integer)
			'used when assigning a value to the property, on the left side of an assignment.
			'Syntax: X.Consultant3 = 5
			mvarConsultant3 = Value
		End Set
    End Property

    Public Property Grade() As Short
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.Grade
            Grade = mvarGrade
        End Get
        Set(ByVal Value As Short)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.Grade = 5
            mvarGrade = Value
        End Set
    End Property

    Public Property LES() As Integer
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.LES
            LES = mvarLES
        End Get
        Set(ByVal Value As Integer)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.LES = 5
            mvarLES = Value
        End Set
    End Property

    Public Property MAT() As Integer
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.MAT
            MAT = mvarMAT
        End Get
        Set(ByVal Value As Integer)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.MAT = 5
            mvarMAT = Value
        End Set
    End Property

    Public Property NV() As Integer
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.NV
            NV = mvarNV
        End Get
        Set(ByVal Value As Integer)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.NV = 5
            mvarNV = Value
        End Set
    End Property

    Public Property Plugin() As String
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.Section
            Plugin = mvarPlugin
        End Get
        Set(ByVal Value As String)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.Section = 5
            mvarPlugin = Value
        End Set
    End Property

	Public Property Price() As Double
		Get
			'used when retrieving value of a property, on the right side of an assignment.
			'Syntax: Debug.Print X.Price
			Price = mvarPrice
		End Get
		Set(ByVal Value As Double)
			'used when assigning a value to the property, on the left side of an assignment.
			'Syntax: X.Price = 5
			mvarPrice = Value
		End Set
	End Property

    Public Property REN() As Integer
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.REN
            REN = mvarREN
        End Get
        Set(ByVal Value As Integer)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.REN = 5
            mvarREN = Value
        End Set
    End Property

    Public Property Section() As String
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.Section
            Section = mvarSection
        End Get
        Set(ByVal Value As String)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.Section = 5
            mvarSection = Value
        End Set
    End Property

    Public Property ServDate() As String
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.ServDate
            ServDate = mvarServDate
        End Get
        Set(ByVal Value As String)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.ServDate = 5
            mvarServDate = Value
        End Set
    End Property

    Public Property Students() As Short
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.Students
            Students = mvarStudents
        End Get
        Set(ByVal Value As Short)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.Students = 5
            mvarStudents = Value
        End Set
    End Property

    Public Property Toll1() As Integer
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.Consultant1
            Toll1 = mvarToll1
        End Get
        Set(ByVal Value As Integer)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.Consultant1 = 5
            mvarToll1 = Value
        End Set
    End Property

    Public Property Toll2() As Integer
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.Consultant1
            Toll2 = mvarToll2
        End Get
        Set(ByVal Value As Integer)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.Consultant1 = 5
            mvarToll2 = Value
        End Set
    End Property

	
	
	
	
	
End Class