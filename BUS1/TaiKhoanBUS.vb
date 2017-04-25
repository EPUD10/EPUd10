Imports DAO1
Public Class Class1
    Public Shared Function LoadData() As DataTable
        Dim cls As New TaiKhoanDAO
        Return cls.LoadData()
    End Function
End Class
