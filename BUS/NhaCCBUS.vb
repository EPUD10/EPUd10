Imports DAO
Imports Entyti

Public Class NhaCCBUS
    Private cls As New NhaCCDAO

    Public Function LoadData() As DataTable
        Return cls.LoadData()
    End Function
    Public Function checkID(ByVal NCC As NhaCCEntyti) As DataTable
        Return cls.checkID(NCC)
    End Function
    Public Function checkEmail(ByVal NCC As NhaCCEntyti) As DataTable
        Return cls.checkEmail(NCC)
    End Function
    Public Function checkPhone(ByVal NCC As NhaCCEntyti) As DataTable
        Return cls.checkPhone(NCC)
    End Function
    Public Function insert(ByVal NCC As NhaCCEntyti) As Integer
        Return cls.insert(NCC)
    End Function
    Public Function Remove(ByVal NCC As NhaCCEntyti) As Integer
        Return cls.Remove(NCC)
    End Function
    Public Function Update(ByVal NCC As NhaCCEntyti) As Integer
        Return cls.Update(NCC)
    End Function
End Class
