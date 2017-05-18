Imports Entyti

Public Class KhachDao
    Private cls As New clsketNoi
    Private _soluong As Integer
    Private sql As String
    Public Function LoadData() As DataTable
        Return cls.getData("sp_LoadKH")
    End Function
    Public Function checkID(ByVal KH As KhachEntyti) As DataTable
        _soluong = 0
        sql = "sp_checkIDKH"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@ma "
        Value(0) = KH.Id
        Return cls.checkID(sql, Name, Value, _soluong)
    End Function
    Public Function checkEmail(ByVal KH As KhachEntyti) As DataTable
        _soluong = 0
        sql = "sp_checkMailKH"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@email"
        Value(0) = KH.Email
        Return cls.checkID(sql, Name, Value, _soluong)
    End Function
    Public Function checkPhone(ByVal KH As KhachEntyti) As DataTable
        _soluong = 0
        sql = "sp_checkPhoneKH"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@phone"
        Value(0) = KH.Phone
        Return cls.checkID(sql, Name, Value, _soluong)
    End Function
    Public Function inserst(ByVal KH As KhachEntyti) As Integer
        _soluong = 6
        sql = "sp_insertKH"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@ID "
        Value(0) = KH.Id
        Name(1) = "@Name"
        Value(1) = KH.Name
        Name(2) = "@DT"
        Value(2) = KH.Phone
        Name(3) = "@GT"
        Value(3) = KH.Sex
        Name(4) = "@Email"
        Value(4) = KH.Email
        Name(5) = "@Date"
        Value(5) = KH.Birth
        Name(6) = "@DC"
        Value(6) = KH.Add
        Return cls.Add(sql, Name, Value, _soluong)
    End Function
    Public Function Delete(ByVal KH As KhachEntyti) As Integer
        _soluong = 0
        sql = "sp_RemoveKH"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@ID "
        Value(0) = KH.Id
        Return cls.Add(sql, Name, Value, _soluong)
    End Function
    Public Function Update(ByVal KH As KhachEntyti) As Integer
        _soluong = 6
        sql = "sp_UpdateKH"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@ID "
        Value(0) = KH.Id
        Name(1) = "@Name"
        Value(1) = KH.Name
        Name(2) = "@DT"
        Value(2) = KH.Phone
        Name(3) = "@GT"
        Value(3) = KH.Sex
        Name(4) = "@Email"
        Value(4) = KH.Email
        Name(5) = "@Date"
        Value(5) = KH.Birth
        Name(6) = "@DC"
        Value(6) = KH.Add
        Return cls.Add(sql, Name, Value, _soluong)
    End Function
End Class
