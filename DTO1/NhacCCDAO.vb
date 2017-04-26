Public Class NhacCCDAO
    Dim con As New config
    Public Function LoadData() As DataTable
        Return con.GetData("dbo.sp_loadNhacCC")
    End Function
End Class
