Imports DTO1

Public Class NhaCCBUS
    Dim cls As New NhacCCDAO
    Public Function GetData() As DataTable
        Return cls.LoadData()
    End Function
End Class
