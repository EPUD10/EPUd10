Public Class ChucVuDao
    Private cls As New clsketNoi
    Public Function LoadData() As DataTable
        Return cls.getData("sp_LoadChucVu")
    End Function
End Class
