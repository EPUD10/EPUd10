Public Class NhanVien
    Private Sub NhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim provider As New DataProvider
        dgvNhanVien.DataSource = provider.ExecuQuery("SELECT * FROM dbo.NhanVien")
        dgvNhanVien.Columns("ID_nv").HeaderText = "Mã nhân viên"
        dgvNhanVien.Columns("Ten_nv").HeaderText = "Tên nhân viên"
        dgvNhanVien.Columns("GT_nv").HeaderText = "Giới tính"
        dgvNhanVien.Columns("DC_nv").HeaderText = "ĐỊa chỉ"
        dgvNhanVien.Columns("Email_nv").HeaderText = "Email"
        dgvNhanVien.Columns("ID_CHang").HeaderText = "Mã cửa hàng"
        dgvNhanVien.Columns("ID_cv").HeaderText = "Mã chức vụ"
        dgvNhanVien.Columns("Date_nv").HeaderText = "Ngày sinh"
        dgvNhanVien.Columns("DT_nv").HeaderText = "Điện thoại"
    End Sub
End Class
