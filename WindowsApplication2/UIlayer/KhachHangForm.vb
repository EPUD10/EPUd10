Imports BUS

Public Class KhachHangForm
    Private cls As New KhachBUS
    Public Sub showData()
        dgvKhach.DataSource = cls.LoadData()
    End Sub
    Private Sub KhachHangForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
    End Sub


End Class
