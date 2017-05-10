Imports DAO

Public Class KiemTraBUS
    Dim cls As New KiemTraDAO
    Public Function CheckMail(ByVal mail As String) As Boolean
        Return cls.CheckMail(mail)
    End Function
    Public Function CheckPhone(ByVal Phone As String) As Boolean
        Return cls.CheckPhone(Phone)
    End Function
End Class
