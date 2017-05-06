Public Class KhachDao
    Private cls As New clsketNoi
    Public Function LoadData() As DataTable
        Return cls.getData("sp_LoadKH")
    End Function
End Class
