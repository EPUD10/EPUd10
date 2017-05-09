Imports Entyti

Public Class NhanVienDAO
    Private cls As New clsketNoi
    Private _soluong As Integer
    Private sql As String
    Public Function LoadData() As DataTable
        Return cls.getData("sp_LoadNV")
    End Function
    Public Function LoadCMBCH() As DataTable
        Return cls.getData("sp_LoadCH")
    End Function
    Public Function LoadCMBCV() As DataTable
        Return cls.getData("sp_LoadChucVu")
    End Function
    Public Function checkID(ByVal NV As NhanVienEntyti) As DataTable
        _soluong = 0
        sql = "sp_checkIDNNV"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@ma"
        Value(0) = NV.IdNV
        Return cls.checkID(sql, Name, Value, _soluong)
    End Function
    Public Function Add(ByVal NV As NhanVienEntyti) As Integer
        _soluong = 8
        sql = "sp_insertNV"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@ID"
        Value(0) = NV.IdNV

        Name(1) = "@Name"
        Value(1) = NV.Name

        Name(2) = "@DT"
        Value(2) = NV.Phone

        Name(3) = "@GT"
        Value(3) = NV.Sex

        Name(4) = "@ID_cv"
        Value(4) = NV.IdCV

        Name(5) = "@ID_CHang"
        Value(5) = NV.IdCH

        Name(6) = "@Date"
        Value(6) = NV.Birth

        Name(7) = "@Email "
        Value(7) = NV.Email

        Name(8) = "@DC"
        Value(8) = NV.Address

        Return cls.Add(sql, Name, Value, _soluong)
    End Function
    Public Function remove(ByVal NV As NhanVienEntyti) As Integer
        _soluong = 0
        sql = "sp_RemoveNV"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@ID"
        Value(0) = NV.IdNV
        Return cls.Add(sql, Name, Value, _soluong)
    End Function
    Public Function Update(ByVal NV As NhanVienEntyti) As Integer
        _soluong = 8
        sql = "sp_UpdateNV"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@ID"
        Value(0) = NV.IdNV

        Name(1) = "@Name"
        Value(1) = NV.Name

        Name(2) = "@DT"
        Value(2) = NV.Phone

        Name(3) = "@GT"
        Value(3) = NV.Sex

        Name(4) = "@ID_cv"
        Value(4) = NV.IdCV

        Name(5) = "@ID_CHang"
        Value(5) = NV.IdCH

        Name(6) = "@Date"
        Value(6) = NV.Birth

        Name(7) = "@Email "
        Value(7) = NV.Email

        Name(8) = "@DC"
        Value(8) = NV.Address

        Return cls.Add(sql, Name, Value, _soluong)
    End Function
End Class
