Public Class NhaCC
    Private maNhaCC As String
    Private tenNhaCC As String
    Private diaChiNhaCC As String
    Private dienThoai As Integer
    Private email As String
    Public Property Ma() As String
        Get
            Return maNhaCC
        End Get
        Set(value As String)
            maNhaCC = value
        End Set
    End Property
    Public Property Ten() As String
        Get
            Return tenNhaCC
        End Get
        Set(value As String)
            tenNhaCC = value
        End Set
    End Property
    Public Property address() As String
        Get
            Return diaChiNhaCC
        End Get
        Set(value As String)
            diaChiNhaCC = value
        End Set
    End Property
    Public Property phone() As Integer
        Get
            Return dienThoai
        End Get
        Set(value As Integer)
            dienThoai = value
        End Set
    End Property
    Public Property Mail() As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property
    Public Sub New(ByVal IDNhaCC As String, ByVal NameNhaCC As String, ByVal AddressNhaCC As String, ByVal phone As Integer, ByVal mail As String)
        maNhaCC = IDNhaCC
        tenNhaCC = NameNhaCC
        diaChiNhaCC = AddressNhaCC
        dienThoai = phone
        email = mail
    End Sub
End Class
