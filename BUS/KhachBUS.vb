Imports DAO
Imports Entyti

Public Class KhachBUS
    Private cls As New KhachDao
    Private KH As New KhachEntyti
    Public Function LoadData() As DataTable
        Return cls.LoadData()
    End Function
    Public Function checkID(ByVal KH As KhachEntyti) As DataTable
        Return cls.checkID(KH)
    End Function
    Public Function ADD(ByVal KH) As Integer
        Return cls.inserst(KH)
    End Function
    Public Function Dele(ByVal KH) As Integer
        Return cls.Delete(KH)
    End Function
    Public Function Update(ByVal KH) As Integer
        Return cls.Update(KH)
    End Function
End Class
