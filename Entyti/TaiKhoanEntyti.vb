Public Class TaiKhoanEntyti
    Private _ten As String
    Private _ma As String
    Private _ghichu As String

    Public Property Ten As String
        Get
            Return _ten
        End Get
        Set(value As String)
            _ten = value
        End Set
    End Property

    Public Property Ma As String
        Get
            Return _ma
        End Get
        Set(value As String)
            _ma = value
        End Set
    End Property

    Public Property Ghichu As String
        Get
            Return _ghichu
        End Get
        Set(value As String)
            _ghichu = value
        End Set
    End Property
End Class
