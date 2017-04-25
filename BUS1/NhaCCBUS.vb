Imports DAO1
Public Class NhaCCBUS
    Dim cls As New NhaCCDAO
    Public Function load() As DataTable
        Return cls.load()
    End Function
End Class
