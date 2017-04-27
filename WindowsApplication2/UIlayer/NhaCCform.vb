



Imports BUS
Imports Entyti

Public Class NhaCCform
    Private cls As New NhaCCBUS
    Private NCC As New NhaCCEntyti
    Private Sub NhaCCform_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgvNhaCC.DataSource = cls.LoadData
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        NCC.Ma = txtMaNhaCC.Text
        NCC.Ten = txtTenNhaCC.Text
        NCC.DienThoai = txtDienThoai.Text
        NCC.DiaChi = txtDiaChi.Text
        NCC.Email = txtEmail.Text
        cls.insert(NCC)
        cls.LoadData()
    End Sub
End Class
