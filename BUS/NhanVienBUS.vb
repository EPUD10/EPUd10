Imports DAO
Imports Entyti

Public Class NhanVienBUS
    Private cls As New NhanVienDAO

    Public Function LoadData() As DataTable
        Return cls.LoadData()
    End Function
    Public Function Add(ByVal NV As NhanVienEntyti) As Integer
        Return cls.Add(NV)
    End Function
    Public Function LoadCMBCH() As DataTable
        Return cls.LoadCMBCH
    End Function
    Public Function LoadCMBCV() As DataTable
        Return cls.LoadCMBCV
    End Function
    Public Function checkID(ByVal NV As NhanVienEntyti) As DataTable
        Return cls.checkID(NV)
    End Function
    Public Function checkEmail(ByVal NV As NhanVienEntyti) As DataTable
        Return cls.checkEmail(NV)
    End Function
    Public Function checkPhone(ByVal NV As NhanVienEntyti) As DataTable
        Return cls.checkPhone(NV)
    End Function
    Public Function Delete(ByVal NV As NhanVienEntyti) As Integer
        Return cls.remove(NV)
    End Function
    Public Function Update(ByVal NV As NhanVienEntyti) As Integer
        Return cls.Update(NV)
    End Function
End Class
