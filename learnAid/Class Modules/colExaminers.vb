Option Strict Off
Option Explicit On
Friend Class colExaminers
	Implements System.Collections.IEnumerable
	'local variable to hold collection
	Private mCol As Collection
	
	Public Function Add(ByRef ExaminerID As Object, ByRef FName As String, ByRef LName1 As String, ByRef LName2 As String, Optional ByRef Activity As colServDetail = Nothing, Optional ByRef sKey As String = "") As clsExaminer
		'create a new object
		Dim objNewMember As clsExaminer
		objNewMember = New clsExaminer
		
		'set the properties passed into the method
		'objNewMember.ServiceDate = ServiceDate
		'objNewMember.SchoolName = SchoolName
		'objNewMember.SchoolCity = SchoolCity
		'objNewMember.ServiceType = ServiceType
		'objNewMember.Amount = Amount
		'If IsObject(ServiceComments) Then
		'    Set objNewMember.ServiceComments = ServiceComments
		'Else
		'    objNewMember.ServiceComments = ServiceComments
		'End If
		'If IsObject(TypeDescription) Then
		'    Set objNewMember.TypeDescription = TypeDescription
		'Else
		'    objNewMember.TypeDescription = TypeDescription
		'End If
		'objNewMember.TypeCost = TypeCost
		'UPGRADE_WARNING: Couldn't resolve default property of object ExaminerID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		objNewMember.ExaminerID = ExaminerID
		objNewMember.FName = FName
		objNewMember.LName1 = LName1
		objNewMember.LName2 = LName2
		'If IsObject(Activity) Then
		'    Set objNewMember.Activity = Activity
		'Else
		'    objNewMember.Activity = Activity
		'End If
		If Len(sKey) = 0 Then
			mCol.Add(objNewMember)
		Else
			mCol.Add(objNewMember, sKey)
		End If
		
		'return the object created
		Add = objNewMember
		'UPGRADE_NOTE: Object objNewMember may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		objNewMember = Nothing
	End Function

    'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    Private Sub Class_Initialize_Renamed()
        'creates the collection when this class is created
        mCol = New Collection
    End Sub

    'UPGRADE_NOTE: Class_Terminate was upgraded to Class_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    Private Sub Class_Terminate_Renamed()
        'destroys collection when this class is terminated
        'UPGRADE_NOTE: Object mCol may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        mCol = Nothing
    End Sub

    Sub Clear()
        Dim iCtr As Object
        For iCtr = 1 To mCol.Count()
            mCol.Remove((1))
        Next iCtr
    End Sub

    Protected Overrides Sub Finalize()
        Class_Terminate_Renamed()
        MyBase.Finalize()
    End Sub

    'UPGRADE_NOTE: NewEnum property was commented out. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3FC1610-34F3-43F5-86B7-16C984F0E88E"'
    'Public ReadOnly Property NewEnum() As stdole.IUnknown
    'Get
    'this property allows you to enumerate
    'this collection with the For...Each syntax
    'NewEnum = mCol._NewEnum
    'End Get
    'End Property

    Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
        'UPGRADE_TODO: Uncomment and change the following line to return the collection enumerator. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="95F9AAD0-1319-4921-95F0-B9D3C4FF7F1C"'
        'GetEnumerator = mCol.GetEnumerator
    End Function

    Public Sub New()
        MyBase.New()
        Class_Initialize_Renamed()
    End Sub

    Public Sub Remove(ByRef vntIndexKey As Object)
        'used when removing an element from the collection
        'vntIndexKey contains either the Index or Key, which is why
        'it is declared as a Variant
        'Syntax: x.Remove(xyz)


        mCol.Remove(vntIndexKey)
    End Sub

    Public ReadOnly Property Count() As Integer
        Get
            'used when retrieving the number of elements in the
            'collection. Syntax: Debug.Print x.Count
            Count = mCol.Count()
        End Get
    End Property

    Default Public ReadOnly Property Item(ByVal vntIndexKey As Object) As clsExaminer
        Get
            'used when referencing an element in the collection
            'vntIndexKey contains either the Index or Key to the collection,
            'this is why it is declared as a Variant
            'Syntax: Set foo = x.Item(xyz) or Set foo = x.Item(5)
            Item = mCol.Item(vntIndexKey)
        End Get
    End Property

End Class