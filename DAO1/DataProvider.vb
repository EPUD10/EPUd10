Imports System.Data.SqlClient
Public Class DataProvider
    Private con As SqlConnection
    Private conSTR As String = ("Data Source=.\SQLEXPRESS;Initial Catalog=ChuoiCuaHang;Persist Security Info=True;User ID=sa;Password=sa123456")
    Public Sub cknoi()
        Dim con As New SqlConnection(conSTR)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

    End Sub
    Public Function ExecuQuery(ByVal Sql As String) As DataTable
        cknoi()
        Dim cmd As New SqlCommand(Sql, con)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        con.Close()
        Return dt
    End Function

End Class
