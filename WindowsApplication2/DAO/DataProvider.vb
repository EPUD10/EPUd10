Imports System.Data.SqlClient
Public Class DataProvider
    Private conSTR As String = ("Data Source=.\SQLEXPRESS;Initial Catalog=ChuoiCuaHang;Persist Security Info=True;User ID=sa;Password=sa123456")
    Public Function ExecuQuery(ByVal Sql As String) As DataTable
        Dim con As New SqlConnection(conSTR)
        con.Open()
        Dim cmd As New SqlCommand(Sql, con)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        con.Close()
        Return dt
    End Function

End Class
