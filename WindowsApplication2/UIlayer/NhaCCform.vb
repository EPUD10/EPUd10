
Public Class NhaCCform
    Private Sub NhaCCform_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim provider As New DataProvider
        dgvSupplier.DataSource = provider.ExecuQuery("SELECT * FROM dbo.NhaCC")
        dgvSupplier.Columns("ID_nhaCC").HeaderText = "Mã nhà cung cấp"
        dgvSupplier.Columns("Ten_nhaCC").HeaderText = "Tên nhà cung cấp"
        dgvSupplier.Columns("DT_nhaCC").HeaderText = "Điện thoại"
        dgvSupplier.Columns("DC_nhaCC").HeaderText = "Địa chỉ"
        dgvSupplier.Columns("Email_nhaCC").HeaderText = "Email"
    End Sub
End Class
