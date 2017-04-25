Public Class HoaDonBanDTO
    Private maHDB As String
    Private ngayBan As Date
    Private tongTien As Double
    Private maNV As String
    Private maKH As String
    Public Property Ma() As String
        Get
            Return maHDB
        End Get
        Set(value As String)
            maHDB = value
        End Set
    End Property
    Public Property NgayHDB() As Date
        Get
            Return ngayBan
        End Get
        Set(value As Date)
            ngayBan = value
        End Set
    End Property
    Public Property Tien() As Double
        Get
            Return tongTien
        End Get
        Set(value As Double)
            tongTien = value
        End Set
    End Property
    Public Property MaNhanVien() As String
        Get
            Return maNV
        End Get
        Set(value As String)
            maNV = value
        End Set
    End Property
    Public Property MaKhachHang() As String
        Get
            Return maKH
        End Get
        Set(value As String)
            maKH = value
        End Set
    End Property
    Public Sub New(ByVal IDHDB As String, ByVal Datetime As Date, ByVal TienBan As Double, ByVal IDNV As String, ByVal IDKH As String)
        maHDB = IDHDB
        ngayBan = Datetime
        tongTien = TienBan
        maNV = IDNV
        maKH = IDKH
    End Sub
End Class
