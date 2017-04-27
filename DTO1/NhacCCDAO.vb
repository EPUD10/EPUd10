
Imports DAO1


Public Class NhacCCDAO
    Dim con As New config
    Public Function LoadData() As DataTable
        Return con.GetData("dbo.sp_loadNhacCC")
    End Function
    Public Function Add(ByVal NCCDTO As NhacCCDAO) As Integer

        Return Nothing
    End Function
End Class
