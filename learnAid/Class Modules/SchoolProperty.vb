Imports System.ComponentModel

Public Class SchoolProperty
    Private _schoolName As String
    Private _schoolCode As String
    Private _schoolType As String
    Private _address1 As String
    Private _address2 As String
    Private _city As String
    Private _zipCode As String

    Private _phoneNo As String
    Private _fax As String

    <CategoryAttribute("School"), DescriptionAttribute("Name"), [ReadOnly](True)>
    Public Property SchoolName() As String
        Get
            Return _schoolName
        End Get
        Set(ByVal value As String)
            _schoolName = value
        End Set
    End Property
    <CategoryAttribute("School"), DescriptionAttribute("Name"), [ReadOnly](True)>
    Public Property SchoolCode() As String
        Get
            Return _schoolCode
        End Get
        Set(ByVal value As String)
            _schoolCode = value
        End Set
    End Property
    <CategoryAttribute("School"), DescriptionAttribute("Name"), [ReadOnly](True)>
    Public Property SchoolType() As String
        Get
            Return _schoolType
        End Get
        Set(ByVal value As String)
            _schoolType = value
        End Set
    End Property

    <CategoryAttribute("Address"), DescriptionAttribute("Address"), [ReadOnly](True)>
    Public Property Address1() As String
        Get
            Return _address1
        End Get
        Set(ByVal value As String)
            _address1 = value
        End Set
    End Property
    <CategoryAttribute("Address"), DescriptionAttribute("Address"), [ReadOnly](True)>
    Public Property Address2() As String
        Get
            Return _address2
        End Get
        Set(ByVal value As String)
            _address2 = value
        End Set
    End Property
    <CategoryAttribute("Address"), DescriptionAttribute("Address"), [ReadOnly](True)>
    Public Property City() As String
        Get
            Return _city
        End Get
        Set(ByVal value As String)
            _city = value
        End Set
    End Property

    <CategoryAttribute("Address"), DescriptionAttribute("Address"), [ReadOnly](True)>
    Public Property ZipCode() As String
        Get
            Return _zipCode
        End Get
        Set(ByVal value As String)
            _zipCode = value
        End Set
    End Property

    <CategoryAttribute("Contact"), DescriptionAttribute("Contact"), [ReadOnly](True)>
    Public Property PhoneNumber() As String
        Get
            Return _phoneNo
        End Get
        Set(ByVal value As String)
            _phoneNo = value
        End Set
    End Property

    <CategoryAttribute("Contact"), DescriptionAttribute("Contact"), [ReadOnly](True)>
    Public Property Fax() As String
        Get
            Return _fax
        End Get
        Set(ByVal value As String)
            _fax = value
        End Set
    End Property
End Class
