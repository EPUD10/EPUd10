Public Class SanPhamEntyti
    Private _idSP, _idNCC, _name, _amount, _info, _exp As String
    'amount: số lượng, _info: ttsp, exp: hạn sd
    'ok
    Private _price As Double

    Public Property Amount As String
        Get
            Return _amount
        End Get
        Set(value As String)
            _amount = value
        End Set
    End Property

    Public Property Exp As String
        Get
            Return _exp
        End Get
        Set(value As String)
            _exp = value
        End Set
    End Property

    Public Property IdNCC As String
        Get
            Return _idNCC
        End Get
        Set(value As String)
            _idNCC = value
        End Set
    End Property

    Public Property IdSP As String
        Get
            Return _idSP
        End Get
        Set(value As String)
            _idSP = value
        End Set
    End Property

    Public Property Info As String
        Get
            Return _info
        End Get
        Set(value As String)
            _info = value
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

    Public Property Price As Double
        Get
            Return _price
        End Get
        Set(value As Double)
            _price = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
