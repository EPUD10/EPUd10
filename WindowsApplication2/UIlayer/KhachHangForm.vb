Public Class KhachHangForm
    Private Sub KhachHangForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim provider As New DataProvider
        dgvKhach.DataSource = provider.ExecuQuery("SELECT * FROM dbo.Khachhang")
        dgvKhach.Columns("ID_kh").HeaderText = "Mã Khách"
        dgvKhach.Columns("Ten_kh").HeaderText = "Tên khách"
        dgvKhach.Columns("Date_kh").HeaderText = "Ngày sinh"
        dgvKhach.Columns("GT_kh").HeaderText = "Giới tính"
        dgvKhach.Columns("DC_kh").HeaderText = "Địa chỉ"
        dgvKhach.Columns("DT_kh").HeaderText = "Điện thoại"
        dgvKhach.Columns("Email_kh").HeaderText = "Email"
    End Sub
End Class
