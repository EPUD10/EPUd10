Imports System.Text.RegularExpressions

Public Class KiemTraDAO
    Public Function CheckMail(ByVal emailAddress As String) As Boolean
        If emailAddress.Length = 0 Then
            Return False
        End If
        If emailAddress.IndexOf("@") > -1 Then
            If (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@")) AndAlso emailAddress.Split(".").Length > 0 AndAlso emailAddress.Split(".")(1) <> "" Then
                Return True
            End If
        End If
        Return False
    End Function
    Public Function CheckPhone(ByVal Phone As String) As Boolean
        Dim pattern As String
        pattern = "^-*[0-9,\.?\-?\(?\)?\ ]+$"
        If Phone.Length < 9 Then
            Return False
        Else Return Regex.IsMatch(Phone, pattern)
        End If

    End Function
End Class
