Public Class NhaCCDAO
    Private provider As New DataProvider
    Public Function load() As DataTable
        Return provider.ExecuQuery("SELECT * FROM dbo.NhaCC")
    End Function
End Class
