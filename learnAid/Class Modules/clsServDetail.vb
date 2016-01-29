Option Strict Off
Option Explicit On
Friend Class clsServDetail
	'local variable(s) to hold property value(s)
    Private mvarAction As String
    Private mvarAdj As Boolean
    Private mvarAmount As Double 'local copy
    Private mvarNTId As Object
    Private mvarSchoolCity As String 'local copy
	Private mvarSchoolName As String 'local copy
    Private mvarServiceComments As Object 'local copy
    Private mvarServiceDate As Date 'local copy
    Private mvarServiceType As Short 'local copy
    Private mvarTypeCost As Object 'local copy
    Private mvarTypeDescription As Object 'local copy
    Private mvarTypeID As Short


    Public Property Action() As String
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.Amount
            Action = mvarAction
        End Get
        Set(ByVal Value As String)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.Amount = 5
            mvarAction = Value
        End Set
    End Property
	
	Public Property Adj() As Boolean
		Get
			Adj = mvarAdj
		End Get
		Set(ByVal Value As Boolean)
			'used when assigning a value to the property, on the left side of an assignment.
			'Syntax: X.Amount = 5
			mvarAdj = Value
		End Set
	End Property

    Public Property Amount() As Double
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.Amount
            Amount = mvarAmount
        End Get
        Set(ByVal Value As Double)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.Amount = 5
            mvarAmount = Value
        End Set
    End Property

    Public Property NTId() As Object
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.Amount
            NTId = mvarNTId
        End Get
        Set(ByVal Value As Object)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.Amount = 5
            mvarNTId = Value
        End Set
    End Property

    Public Property SchoolCity() As String
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.SchoolCity
            SchoolCity = mvarSchoolCity
        End Get
        Set(ByVal Value As String)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.SchoolCity = 5
            mvarSchoolCity = Value
        End Set
    End Property

    Public Property SchoolName() As String
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.SchoolName
            SchoolName = mvarSchoolName
        End Get
        Set(ByVal Value As String)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.SchoolName = 5
            mvarSchoolName = Value
        End Set
    End Property

    Public Property ServiceComments() As Object
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.ServiceComments
            'UPGRADE_WARNING: IsObject has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            If IsReference(mvarServiceComments) Then
                ServiceComments = mvarServiceComments
            Else
                ServiceComments = mvarServiceComments
            End If
        End Get
        Set(ByVal Value As Object)
            If IsReference(Value) And Not TypeOf Value Is String Then
                'used when assigning an Object to the property, on the left side of a Set statement.
                'Syntax: Set x.ServiceComments = Form1
                mvarServiceComments = Value
            Else
                'used when assigning a value to the property, on the left side of an assignment.
                'Syntax: X.ServiceComments = 5
                mvarServiceComments = Value
            End If
        End Set
    End Property

    Public Property ServiceDate() As DateTime
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.ServiceDate
            ServiceDate = mvarServiceDate
        End Get
        Set(value As DateTime)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.ServiceDate = 5
            mvarServiceDate = value
        End Set
    End Property

    Public Property ServiceType() As Short
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.ServiceType
            ServiceType = mvarServiceType
        End Get
        Set(ByVal Value As Short)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.ServiceType = 5
            mvarServiceType = Value
        End Set
    End Property

    Public Property TypeCost() As Double
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.TypeCost
            TypeCost = mvarTypeCost
        End Get
        Set(ByVal Value As Double)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.TypeCost = 5
            mvarTypeCost = Value
        End Set
    End Property
	
    Public Property TypeDescription() As Object
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.TypeDescription
            'UPGRADE_WARNING: IsObject has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            If IsReference(mvarTypeDescription) Then
                TypeDescription = mvarTypeDescription
            Else
                TypeDescription = mvarTypeDescription
            End If
        End Get
        Set(ByVal Value As Object)
            If IsReference(Value) And Not TypeOf Value Is String Then
                'used when assigning an Object to the property, on the left side of a Set statement.
                'Syntax: Set x.TypeDescription = Form1
                mvarTypeDescription = Value
            Else
                'used when assigning a value to the property, on the left side of an assignment.
                'Syntax: X.TypeDescription = 5
                mvarTypeDescription = Value
            End If
        End Set
    End Property
	
    Public Property TypeID() As Short
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.Amount
            TypeID = mvarTypeID
        End Get
        Set(ByVal Value As Short)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.Amount = 5
            mvarTypeID = Value
        End Set
    End Property

End Class