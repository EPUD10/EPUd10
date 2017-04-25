Public Class CuaHang
    Private Sub CuaHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim provider As New DataProvider
        dgvCH.DataSource = provider.ExecuQuery("SELECT * FROM dbo.CuaHang")
        dgvCH.Columns("ID_CHang").HeaderText = "Mã cửa hàng"
        dgvCH.Columns("Ten_CHang").HeaderText = "Tên cửa hàng"
        dgvCH.Columns("DC_CHang").HeaderText = "Địa chỉ"
        dgvCH.Columns("DT_CHang").HeaderText = "Điện thoại"
        dgvCH.Columns("Email_CHang").HeaderText = "Email"
    End Sub
End Class
