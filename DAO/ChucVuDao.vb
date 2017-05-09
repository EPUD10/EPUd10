Imports Entyti

Public Class ChucVuDao
    Private cls As New clsketNoi
    Private _soluong As Integer
    Private sql As String
    Public Function LoadData() As DataTable
        Return cls.getData("sp_LoadChucVu")
    End Function
    Public Function CheckID(ByVal CV As ChucVuEntyti) As DataTable
        _soluong = 0
        sql = "sp_checkIDCV"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@ma"
        Value(0) = CV.Id
        Return cls.checkID(sql, Name, Value, _soluong)
    End Function
    Public Function ADD(ByVal CV As ChucVuEntyti) As Integer
        _soluong = 2
        sql = "sp_insertChucVu"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@ma"
        Value(0) = CV.Id
        Name(1) = "@ten"
        Value(1) = CV.Name
        Name(2) = "@note"
        Value(2) = CV.Power
        Return cls.Add(sql, Name, Value, _soluong)
    End Function
    Public Function Dele(ByVal CV As ChucVuEntyti) As Integer
        _soluong = 0
        sql = "sp_RemoveCV"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@ID"
        Value(0) = CV.Id
        Return cls.Add(sql, Name, Value, _soluong)
    End Function
    Public Function Update(ByVal CV As ChucVuEntyti) As Integer
        _soluong = 2
        sql = "sp_UpdateCV"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As Object
        Name(0) = "@ID"
        Value(0) = CV.Id
        Name(1) = "@Ten"
        Value(1) = CV.Name
        Name(2) = "@Quyen"
        Value(2) = CV.Power
        Return cls.Add(sql, Name, Value, _soluong)
    End Function
End Class
