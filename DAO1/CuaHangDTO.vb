Public Class CuaHangDTO
    Private maCh As String
    Private tenCH As String
    Private diaChi As String
    Private dienThoai As Integer
    Private email As String
    Public Property Ma() As String
        Get
            Return maCh
        End Get
        Set(value As String)
            maCh = value
        End Set
    End Property
    Public Property Ten() As String
        Get
            Return tenCH
        End Get
        Set(value As String)
            tenCH = value
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
    Public Property Mail() As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property
    Public Sub New(ByVal Ma As String, ByVal Ten As String, ByVal address As String, ByVal phone As Integer, ByVal mail As String)
        maCh = Ma
        tenCH = Ten
        diaChi = address
        dienThoai = phone
        email = mail
    End Sub
End Class
