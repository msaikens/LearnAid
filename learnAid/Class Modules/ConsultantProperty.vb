Imports System.ComponentModel

Public Class ConsultantProperty
    Private _firstname As String
    Private _lastName2 As String
    Private _lastName1 As String
    Private _phoneNo As String
    Private _zipCode As String
    Private _address As String
    Private _city As String
    <CategoryAttribute("Name"), DescriptionAttribute("Name"), [ReadOnly](True)>
    Public Property FirstName() As String
        Get
            Return _firstname
        End Get
        Set(ByVal value As String)
            _firstname = value
        End Set
    End Property
    <CategoryAttribute("Name"), DescriptionAttribute("Name"), [ReadOnly](True)>
    Public Property LastName2() As String
        Get
            Return _lastName2
        End Get
        Set(ByVal value As String)
            _lastName2 = value
        End Set
    End Property
    <CategoryAttribute("Name"), DescriptionAttribute("Name"), [ReadOnly](True)>
    Public Property LastName1() As String
        Get
            Return _lastName1
        End Get
        Set(ByVal value As String)
            _lastName1 = value
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

    <CategoryAttribute("Address"), DescriptionAttribute("Address"), [ReadOnly](True)>
    Public Property Address() As String
        Get
            Return _address
        End Get
        Set(ByVal value As String)
            _address = value
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
End Class
