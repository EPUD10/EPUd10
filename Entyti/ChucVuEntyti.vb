Public Class ChucVuEntyti
    Private _id As String
    Private _name As String
    Private _power As String 'thuôc tính : quyền hạn 

    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
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

    Public Property Power As String
        Get
            Return _power
        End Get
        Set(value As String)
            _power = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
