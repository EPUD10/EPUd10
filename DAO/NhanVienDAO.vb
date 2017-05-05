Public Class NhanVienDAO
    Private cls As New clsketNoi
    Public Function LoadData() As DataTable
        Return cls.getData("sp_LoadNV")
    End Function
End Class
