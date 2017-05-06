Imports DAO
Imports Entyti

Public Class AccountBUS
    Private cls As New TaiKhoanDAO
    Public Function load() As DataTable
        Return cls.LoadData()
    End Function
    Public Function Add(ByVal tk As TaiKhoanEntyti) As Integer
        Return cls.Add(tk)
    End Function
    Public Function Delete(ByVal tk As TaiKhoanEntyti) As Integer
        Return cls.Delete(tk)
    End Function
    Public Function Update(ByVal tk As TaiKhoanEntyti) As Integer
        Return cls.Update(tk)
    End Function
    Public Function Search(ByVal tk As TaiKhoanEntyti) As Integer
        Return cls.Search(tk)
    End Function
End Class
