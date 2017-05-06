Imports DAO

Public Class KhachBUS
    Private cls As New KhachDao
    Public Function LoadData() As DataTable
        Return cls.LoadData()
    End Function
End Class
