Public Class TaiKhoan
    Private Sub TaiKhoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim provider As New DataProvider
        dgvTaiKhoan.DataSource = provider.ExecuQuery("SELECT * FROM dbo.TaiKhoan")
        dgvTaiKhoan.Columns("ID_nv").HeaderText = "Mã nhân viên"
        dgvTaiKhoan.Columns("MK_nv").HeaderText = "Mật khẩu"
        dgvTaiKhoan.Columns("GhiChu_nv").HeaderText = "Ghi chú"
    End Sub
End Class
