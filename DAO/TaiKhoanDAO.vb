Imports Entyti

Public Class TaiKhoanDAO
    Private con As New clsketNoi
    Dim _soluong As Integer
    Dim sql As String

    Public Function LoadData() As DataTable
        Return con.getData("dbo.sp_LoadTaiKhoan")
    End Function
    Public Function Add(ByVal tk As TaiKhoanEntyti) As Integer
        _soluong = 2
        Dim Name(_soluong) As String
        Dim Values(_soluong) As Object
        sql = "dbo.sp_insertTK"
        Name(0) = "@ma"
        Values(0) = tk.Ma
        Name(1) = "@Matkhau"
        Values(1) = tk.Ten
        Name(2) = "@note"
        Values(2) = tk.Ghichu
        Return con.Add(sql, Name, Values, _soluong)
    End Function
    Public Function Delete(ByVal tk As TaiKhoanEntyti) As Integer
        _soluong = 0
        Dim Name(_soluong) As String
        Dim Values(_soluong) As Object
        sql = "dbo.sp_deTK "
        Name(0) = "@ma"
        Values(0) = tk.Ma
        Return con.Add(sql, Name, Values, _soluong)
    End Function
    Public Function Update(ByVal tk As TaiKhoanEntyti) As Integer
        _soluong = 2
        Dim Name(_soluong) As String
        Dim Values(_soluong) As Object
        sql = "dbo.sp_updateTK"
        Name(0) = "@ma"
        Values(0) = tk.Ma
        Name(1) = "@pass"
        Values(1) = tk.Ten
        Name(2) = "@note"
        Values(2) = tk.Ghichu
        Return con.Add(sql, Name, Values, _soluong)
    End Function
    Public Function Search(ByVal tk As TaiKhoanEntyti) As Integer
        _soluong = 0
        Dim Name(_soluong) As String
        Dim Values(_soluong) As Object
        sql = "dbo.sp_SearchTK "
        Name(0) = "@ma"
        Values(0) = tk.Ma
        Return con.Add(sql, Name, Values, _soluong)
    End Function
End Class
