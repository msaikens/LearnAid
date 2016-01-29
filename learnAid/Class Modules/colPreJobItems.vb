Option Strict Off
Option Explicit On
Friend Class colPreJobItems
	Implements System.Collections.IEnumerable
	'local variable to hold collection
	Private mCol As Collection

    
	
    Public Function Add(ByRef Grade As Short, ByRef Section As String, ByRef Students As Short, ByRef LES As Integer, ByRef NV As Integer,
                        ByRef REN As Integer, ByRef MAT As Integer, ByRef Consultant1 As Integer, ByRef Toll1 As Short, ByRef Consultant2 As Integer,
                        ByRef Toll2 As Short, ByRef Consultant3 As Integer, ByRef Price As Double, ByRef ServDate As String, ByRef sPlugin As String,
                        Optional ByRef sKey As String = "") As clsPreJobItem
        'create a new object
        Dim objNewMember As clsPreJobItem
        objNewMember = New clsPreJobItem

        'set the properties passed into the method
        objNewMember.Grade = Grade
        objNewMember.Section = Section
        objNewMember.Students = Students
        objNewMember.LES = LES
        objNewMember.NV = NV
        objNewMember.REN = REN
        objNewMember.MAT = MAT
        objNewMember.Consultant1 = Consultant1
        objNewMember.Toll1 = Toll1
        objNewMember.Consultant2 = Consultant2
        objNewMember.Toll2 = Toll2
        objNewMember.Consultant3 = Consultant3
        objNewMember.ServDate = ServDate
        objNewMember.Price = Price
        objNewMember.Plugin = sPlugin

        If Len(sKey) = 0 Then
            mCol.Add(objNewMember)
        Else
            mCol.Add(objNewMember, sKey)
        End If

        'return the object created
        Add = objNewMember

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

    Public Sub Clear()

        For iCounter As Integer = 1 To mCol.Count()
            mCol.Remove(1)
        Next iCounter
    End Sub

    Public ReadOnly Property Count() As Integer
        Get
            'used when retrieving the number of elements in the
            'collection. Syntax: Debug.Print x.Count
            Count = mCol.Count()
        End Get
    End Property

    Protected Overrides Sub Finalize()
        Class_Terminate_Renamed()
        MyBase.Finalize()
    End Sub

    Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
        'UPGRADE_TODO: Uncomment and change the following line to return the collection enumerator. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="95F9AAD0-1319-4921-95F0-B9D3C4FF7F1C"'
        'GetEnumerator = mCol.GetEnumerator
    End Function

    Default Public ReadOnly Property Item(ByVal vntIndexKey As Object) As clsPreJobItem
        Get
            'used when referencing an element in the collection
            'vntIndexKey contains either the Index or Key to the collection,
            'this is why it is declared as a Variant
            'Syntax: Set foo = x.Item(xyz) or Set foo = x.Item(5)
            Item = mCol.Item(vntIndexKey)
        End Get
    End Property
	
    Public Sub Modify(ByRef Index As Short, ByRef Grade As Short, ByRef Section As String, ByRef Students As Short, ByRef LES As Integer, ByRef NV As Integer, ByRef REN As Integer, ByRef MAT As Integer, ByRef Consultant1 As Integer, ByRef Toll1 As Short, ByRef Consultant2 As Integer, ByRef Toll2 As Short, ByRef Consultant3 As Integer, ByRef Price As Double, ByRef ServDate As String, ByRef sPlugin As String)

        'set the properties passed into the method
        MsgBox(Index)
        mCol.Item(Index).Grade = Grade
        mCol.Item(Index).Section = Section
        mCol.Item(Index).Students = Students
        mCol.Item(Index).LES = LES
        mCol.Item(Index).NV = NV
        mCol.Item(Index).REN = REN
        mCol.Item(Index).MAT = MAT
        mCol.Item(Index).Consultant1 = Consultant1
        mCol.Item(Index).Toll1 = Toll1
        mCol.Item(Index).Consultant2 = Consultant2
        mCol.Item(Index).Toll2 = Toll2
        mCol.Item(Index).Consultant3 = Consultant3
        mCol.Item(Index).Price = Price
        mCol.Item(Index).ServDate = ServDate
        mCol.Item(Index).Plugin = sPlugin
    End Sub

    Public Sub New()
        MyBase.New()
        Class_Initialize_Renamed()
    End Sub

	'UPGRADE_NOTE: NewEnum property was commented out. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3FC1610-34F3-43F5-86B7-16C984F0E88E"'
	'Public ReadOnly Property NewEnum() As stdole.IUnknown
		'Get
			'this property allows you to enumerate
			'this collection with the For...Each syntax
			'NewEnum = mCol._NewEnum
		'End Get
	'End Property

	Public Sub Remove(ByRef vntIndexKey As Object)
		'used when removing an element from the collection
		'vntIndexKey contains either the Index or Key, which is why
		'it is declared as a Variant
		'Syntax: x.Remove(xyz)
				
		mCol.Remove(vntIndexKey)
	End Sub
	
	
    
	
	
	
	
End Class