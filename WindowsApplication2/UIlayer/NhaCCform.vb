
Imports BUS1

Public Class NhaCCform
    Private Sub NhaCCform_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim cls As New NhaCCBUS
        dgvNhaCC.DataSource = cls.load()
    End Sub
End Class
