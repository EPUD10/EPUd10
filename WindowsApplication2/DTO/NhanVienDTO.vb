Public Class NhanVienDTO
    Private maNV As String
    Private tenNV As String
    Private gioiTinh As String
    Private diaChi As String
    Private ngaySinh As Date
    Private dienThoai As Integer
    Private email As String
    Private maCH As String
    Private maCV As String
    Public Property Ma() As String
        Get
            Return maNV
        End Get
        Set(value As String)
            maNV = value
        End Set
    End Property
    Public Property Ten() As String
        Get
            Return tenNV
        End Get
        Set(value As String)
            tenNV = value
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
    Public Property Phone() As Integer
        Get
            Return dienThoai
        End Get
        Set(value As Integer)
            dienThoai = value
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
    Public Property mail() As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property
    Public Property MaCHang() As String
        Get
            Return maCH
        End Get
        Set(value As String)
            maCH = value
        End Set
    End Property
    Public Property maChucVu() As String
        Get
            Return maCV
        End Get
        Set(value As String)
            maCV = value
        End Set
    End Property
    Public Sub New(ByVal IDNV As String, ByVal NameNV As String, ByVal Sex As String, ByVal Address As String, ByVal Datetime As Date, ByVal phone As Integer, ByVal Mail As String, ByVal IDCH As String, ByVal IDCV As String)
        maNV = IDNV
        tenNV = NameNV
        diaChi = Address
        dienThoai = phone
        ngaySinh = Datetime
        maCH = IDCH
        maCV = IDCV
        gioiTinh = Sex
        email = Mail
    End Sub
End Class
