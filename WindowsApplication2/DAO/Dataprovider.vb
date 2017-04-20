Imports System.Data.SqlClient
Public Class Dataprovider
    Private sql As String = "Data Source=.\SQLEXPRESS;Initial Catalog=ChuoiCuaHang;Persist Security Info=True;User ID=sa;Password=sa123456"
    'Public Function ExcuteNonQuery(query As String) As DataTable
    '    Try
    '        Dim con As SqlConnection = New SqlConnection(sql)
    '        con.Open()
    '        Dim cmd As SqlCommand = New SqlCommand(query, con)
    '        Dim da As New SqlDataAdapter(cmd)
    '        Dim dt As New DataTable()
    '        da.Fill(dt)
    '        con.Close()
    '        Return dt
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Function
End Class
