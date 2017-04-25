Public Class KhachHangDTO
    Private maKH As String
    Private tenKH As String
    Private diaChi As String
    Private dienThoai As Integer
    Private gioiTinh As String
    Private email As String
    Private ngaySinh As Date
    Private Property Ma() As String
        Get
            Return maKH
        End Get
        Set(value As String)
            maKH = value
        End Set
    End Property
    Private Property Ten() As String
        Get
            Return tenKH
        End Get
        Set(value As String)
            tenKH = value
        End Set
    End Property
    Public Property Address() As String
        Get
            Return diaChi
        End Get
        Set(value As String)
            diaChi = value
        End Set
    End Property
    Public Property Phone() As Integer
        Get
            Return dienThoai
        End Get
        Set(value As Integer)
            dienThoai = value
        End Set
    End Property
    Public Property Sex() As String
        Get
            Return gioiTinh
        End Get
        Set(value As String)
            gioiTinh = value
        End Set
    End Property
    Public Property Mail() As String
        Get
            Return gioiTinh
        End Get
        Set(value As String)
            gioiTinh = value
        End Set
    End Property
    Public Property Born() As Date
        Get
            Return ngaySinh
        End Get
        Set(value As Date)
            ngaySinh = value
        End Set
    End Property
    Public Sub New(ByVal ma As String, ByVal ten As String, ByVal address As String, ByVal phone As Integer, ByVal sex As String, ByVal mail As String, ByVal datetime As Date)
        maKH = ma
        tenKH = ten
        diaChi = address
        gioiTinh = sex
        dienThoai = phone
        ngaySinh = datetime
        email = mail
    End Sub

End Class
