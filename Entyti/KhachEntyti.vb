Public Class KhachEntyti
    Private _id As String
    Private _name As String
    Private _add As String
    Private _phone As Integer
    Private _sex As String
    Private _Email As String
    Private _birth As Date

    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Add As String
        Get
            Return _add
        End Get
        Set(value As String)
            _add = value
        End Set
    End Property

    Public Property Phone As Integer
        Get
            Return _phone
        End Get
        Set(value As Integer)
            _phone = value
        End Set
    End Property

    Public Property Sex As String
        Get
            Return _sex
        End Get
        Set(value As String)
            _sex = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property

    Public Property Birth As Date
        Get
            Return _birth
        End Get
        Set(value As Date)
            _birth = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
