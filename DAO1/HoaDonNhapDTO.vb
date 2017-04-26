Public Class HoaDonNhapDTO
    Private maHDN As String
    Private ngayNhap As String
    Private tongTien As Double
    Private maNV As String
    Public Property Ma() As String
        Get
            Return maHDN
        End Get
        Set(value As String)
            maHDN = value
        End Set
    End Property
    Public Property NgayBan() As Date
        Get
            Return ngayNhap
        End Get
        Set(value As Date)
            ngayNhap = value
        End Set
    End Property
    Public Property TongTienBan() As Double
        Get
            Return tongTien
        End Get
        Set(value As Double)
            tongTien = value
        End Set
    End Property
    Public Property MaNHanVien() As String
        Get
            Return maNV
        End Get
        Set(value As String)
            maNV = value
        End Set
    End Property
    Public Sub New(ByVal IDHDN As String, ByVal DateTime As String, ByVal SumTien As Double, ByVal IDNV As String)
        maHDN = IDHDN
        ngayNhap = DateTime
        tongTien = SumTien
        maNV = IDNV
    End Sub
End Class
