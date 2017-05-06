Imports DAO
Public Class SanPhamBUS
    Private cls As New SanPhamDAO
    Public Function LoadData() As DataTable
        Return cls.LoadData()
        'ok
    End Function
    Public Sub New()

    End Sub


End Class
