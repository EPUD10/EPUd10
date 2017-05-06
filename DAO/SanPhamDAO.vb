Public Class SanPhamDAO
    Private cls As New clsketNoi
    Public Function LoadData() As DataTable
        'ok
        Return cls.getData("sp_LoadSP") 'ok
    End Function
End Class

