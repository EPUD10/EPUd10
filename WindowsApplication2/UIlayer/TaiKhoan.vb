Public Class TaiKhoan
    Private Sub TaiKhoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim provider As New DataProvider
        dgvTaikhoan.DataSource = provider.ExecuQuery("SELECT * FROM dbo.TaiKhoan")
        dgvTaikhoan.Columns("ID_nv").HeaderText = "Mã nhân viên"
        dgvTaikhoan.Columns("MK_nv").HeaderText = "Mật khẩu"
        dgvTaikhoan.Columns("GhiChu_nv").HeaderText = "Ghi chú"
    End Sub
End Class
