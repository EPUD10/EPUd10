Public Class TaiKhoanDAO
    Private provider As New DataProvider()
    Public Function LoadData() As DataTable
        Return provider.ExecuQuery("SELECT * FROM dbo.TaiKhoan")
    End Function
End Class
