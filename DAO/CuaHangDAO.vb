
Imports Entyti

Public Class CuaHangDAO
    Private cls As New clsketNoi
    Private _soluong As Integer
    Private sql As String
    Public Function LoadData() As DataTable
        Return cls.getData("sp_LoadCH")
    End Function
    Public Function checkID(ByVal CH As CuaHangEntyti) As DataTable
        _soluong = 0
        Dim Name(_soluong) As String
        Dim values(_soluong) As Object
        sql = "sp_checkIDCH"
        Name(0) = "@ma"
        values(0) = CH.Ma
        Return cls.checkID(sql, Name, values, _soluong)
    End Function
    Public Function Add(ByVal CH As CuaHangEntyti) As Integer
        _soluong = 4
        Dim Name(_soluong) As String
        Dim values(_soluong) As Object
        sql = "sp_insertCH"
        Name(0) = "@ma"
        values(0) = CH.Ma
        Name(1) = "@ten"
        values(1) = CH.Ten
        Name(2) = "@dt"
        values(2) = CH.DienThoai
        Name(3) = "@dc"
        values(3) = CH.DiaChi
        Name(4) = "@mail"
        values(4) = CH.Email
        Return cls.Add(sql, Name, values, _soluong)
    End Function
    Public Function Remove(ByVal CH As CuaHangEntyti) As Integer
        _soluong = 0
        Dim Name(_soluong) As String
        Dim values(_soluong) As Object
        sql = "dbo.sp_removeCH"
        Name(0) = "@ma"
        values(0) = CH.Ma
        Return cls.Add(sql, Name, values, _soluong)
    End Function
    Public Function Update(ByVal CH As CuaHangEntyti) As Integer
        _soluong = 4
        Dim Name(_soluong) As String
        Dim values(_soluong) As Object
        sql = "dbo.sp_UpdateCH"
        Name(0) = "@ma"
        values(0) = CH.Ma
        Name(1) = "@ten"
        values(1) = CH.Ten
        Name(2) = "@phone"
        values(2) = CH.DienThoai
        Name(3) = "@dc"
        values(3) = CH.DiaChi
        Name(4) = "@email"
        values(4) = CH.Email
        Return cls.Add(sql, Name, values, _soluong)
    End Function
End Class
