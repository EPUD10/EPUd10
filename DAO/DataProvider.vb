Imports System.Data.SqlClient
Public Class DataProvider
    Private con As SqlConnection
    Private cmd As SqlCommand
    Public Function Connect() As Boolean
        con = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=ChuoiCuaHang;Persist Security Info=True;User ID=sa;Password=sa123456")
        Try
            con.Open()
        Catch ex As Exception

        End Try
        Return True
    End Function
    Public Sub close()
        If con.State = ConnectionState.Connecting.Open Then
            con.Close()
        End If
        con.Dispose()
    End Sub

    Public Function getData(ByVal sql As String) As DataTable
        Dim dt As New DataTable
        Connect()
        cmd = New SqlCommand(sql, con)
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function
End Class
