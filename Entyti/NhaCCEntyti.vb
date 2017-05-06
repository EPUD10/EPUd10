Public Class NhaCCEntyti
    Private _ma As String
    Private _ten As String
    Private _diaChi As String
    Private _dienThoai As Integer
    Private _Email As String

    Public Property Ma As String
        Get
            Return _ma
        End Get
        Set(value As String)
            _ma = value
        End Set
    End Property

    Public Property Ten As String
        Get
            Return _ten
        End Get
        Set(value As String)
            _ten = value
        End Set
    End Property

    Public Property DiaChi As String
        Get
            Return _diaChi
        End Get
        Set(value As String)
            _diaChi = value
        End Set
    End Property

    Public Property DienThoai As Integer
        Get
            Return _dienThoai
        End Get
        Set(value As Integer)
            _dienThoai = value
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
    Public Sub New()

    End Sub
End Class
