Imports DAO
Imports Entyti

Public Class NhaCCBUS
    Private cls As New NhaCCDAO

    Public Function LoadData() As DataTable
        Return cls.LoadData()
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
