Imports DAO

Public Class NhanVienBUS
    Private cls As New NhanVienDAO
    Public Function LoadData() As DataTable
        Return cls.LoadData()
    End Function
End Class
