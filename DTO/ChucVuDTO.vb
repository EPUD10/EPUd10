Public Class ChucVuDTO
    Private maCV As String
    Private tenCV As String
    Private ghiChu As String
    Public Property Ma() As String
        Get
            Return maCV
        End Get
        Set(value As String)
            maCV = value
        End Set
    End Property
    Public Property Ten() As String
        Get
            Return tenCV
        End Get
        Set(value As String)
            tenCV = value
        End Set
    End Property
    Public Property Note() As String
        Get
            Return ghiChu
        End Get
        Set(value As String)
            ghiChu = value
        End Set
    End Property
    Public Sub New(ByVal ma As String, ByVal ten As String, ByVal note As String)
        maCV = ma
        tenCV = tenCV
        ghiChu = note
    End Sub
End Class
