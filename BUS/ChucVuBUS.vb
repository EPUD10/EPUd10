Imports DAO
Imports Entyti

Public Class ChucVuBUS
    Private cls As New ChucVuDao
    Public Function LoadData() As DataTable
        Return cls.LoadData()
    End Function
    Public Function CheckID(ByVal CV As ChucVuEntyti) As DataTable
        Return cls.CheckID(CV)
    End Function
    Public Function Insert(ByVal CV As ChucVuEntyti) As Integer
        Return cls.ADD(CV)
    End Function
    Public Function dele(ByVal CV As ChucVuEntyti) As Integer
        Return cls.Dele(CV)
    End Function
    Public Function update(ByVal CV As ChucVuEntyti) As Integer
        Return cls.Update(CV)
    End Function
End Class
