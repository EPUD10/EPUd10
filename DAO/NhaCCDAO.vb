Imports DAO
Imports Entyti
Public Class NhaCCDAO
    Public con As New clsketNoi
    Private _soluong As Integer
    Public Function LoadData() As DataTable
        Return con.getData("dbo.sp_loadNhacCC")
    End Function
    Public Function insert(ByVal NCC As NhaCCEntyti) As Integer
        _soluong = 4
        Dim sql As String = "dbo.sp_insertNCC"
        Dim Name(_soluong) As String
        Dim Values(_soluong) As Object
        Name(0) = "@id"
        Values(0) = NCC.Ma
        Name(1) = "@name"
        Values(1) = NCC.Ten
        Name(2) = "@Add"
        Values(2) = NCC.DiaChi
        Name(3) = "@phone"
        Values(3) = NCC.DienThoai
        Name(4) = "@Email"
        Values(4) = NCC.Email
        Return con.Add(sql, Name, Values, _soluong)
    End Function
    Public Function Remove(ByVal NCC As NhaCCEntyti) As Integer
        _soluong = 0
        Dim sql As String = "sp_RemoveNCC"
        Dim Name(_soluong) As String
        Dim Values(_soluong) As Object
        Name(0) = "@ma"
        Values(0) = NCC.Ma
        Return con.Add(sql, Name, Values, _soluong)
    End Function
    Public Function Update(ByVal NCC As NhaCCEntyti) As Integer
        _soluong = 4
        Dim sql As String = "sp_UpdateNCC"
        Dim Name(_soluong) As String
        Dim Values(_soluong) As Object
        Name(0) = "@ma"
        Values(0) = NCC.Ma
        Name(1) = "@ten"
        Values(1) = NCC.Ten
        Name(2) = "@dc"
        Values(2) = NCC.DiaChi
        Name(3) = "@dt"
        Values(3) = NCC.DienThoai
        Name(4) = "@email"
        Values(4) = NCC.Email
        Return con.Add(sql, Name, Values, _soluong)
    End Function
End Class
