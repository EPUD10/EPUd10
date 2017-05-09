
Imports BUS

Public Class HoaDonBan
    Public Function creatKey(ByVal tiento As String) As String
        Dim key As String = tiento
        Dim d As String
        d = Format(Date.Now, "yyyy/MM/ddHHss")
        key = key + Replace(d, "/", "_")
        Return key
    End Function
    Private Sub HoaDonBan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
End Class
