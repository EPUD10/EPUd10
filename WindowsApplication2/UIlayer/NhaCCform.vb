
Public Class NhaCCform
    Private Sub NhaCCform_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim provider As New DataProvider
        dgvNhaCC.DataSource = provider.ExecuQuery("SELECT * FROM dbo.NhaCC")
        dgvNhaCC.Columns("ID_nhaCC").HeaderText = "Mã nhà cung cấp"
        dgvNhaCC.Columns("Ten_nhaCC").HeaderText = "Tên nhà cung cấp"
        dgvNhaCC.Columns("DT_nhaCC").HeaderText = "Điện thoại"
        dgvNhaCC.Columns("DC_nhaCC").HeaderText = "Địa chỉ"
        dgvNhaCC.Columns("Email_nhaCC").HeaderText = "Email"
    End Sub
End Class
