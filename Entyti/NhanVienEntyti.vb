Public Class NhanVienEntyti
    Private _idNV, _name, _sex, _address, _email, _idCH, _idCV As String
    Private _phone As Integer
    Private _birth As Date

    Public Property IdNV As String
        Get
            Return _idNV
        End Get
        Set(value As String)
            _idNV = value
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

    Public Property Sex As String
        Get
            Return _sex
        End Get
        Set(value As String)
            _sex = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property IdCH As String
        Get
            Return _idCH
        End Get
        Set(value As String)
            _idCH = value
        End Set
    End Property

    Public Property IdCV As String
        Get
            Return _idCV
        End Get
        Set(value As String)
            _idCV = value
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
