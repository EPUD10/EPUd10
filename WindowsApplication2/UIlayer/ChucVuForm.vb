Public Class ChucVuForm
    Private Sub ChucVuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim provider As New DataProvider
        dgvChucVu.DataSource = provider.ExecuQuery("SELECT * FROM dbo.ChucVu")
        dgvChucVu.Columns("ID_cv").HeaderText = "Mã chức vụ"
        dgvChucVu.Columns("Ten_cv").HeaderText = "Tên chức vụ"
        dgvChucVu.Columns("QuyenHan").HeaderText = "Ghi chú"
    End Sub
End Class
