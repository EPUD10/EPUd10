Imports BUS
Imports Entyti

Public Class NhanVien
    Private cls As New NhanVienBUS
    Private NV As New NhanVienEntyti
    Private Sub ClearText()
        txtDC.Text = ""
        txtDT.Text = ""
        txtEmail.Text = ""
        txtName.Text = ""
        txtMaNhanVien.Text = ""
    End Sub
    Private Sub ClearLB()
        lbAdd.Text = ""
        lbEmail.Text = ""
        lbID.Text = ""
        lbName.Text = ""
        lbPhone.Text = ""
    End Sub
    Private Sub ShowData()
        dgvNhanVien.DataSource = cls.LoadData()
    End Sub
    Private Sub NameDGV()
        dgvNhanVien.Columns("ID_nv").HeaderText = "ID Salesman"
        dgvNhanVien.Columns("Ten_nv").HeaderText = "Name Salesman"
        dgvNhanVien.Columns("GT_nv").HeaderText = "Sex"
        dgvNhanVien.Columns("DC_nv").HeaderText = "Address"
        dgvNhanVien.Columns("DT_nv").HeaderText = "Phone number"
        dgvNhanVien.Columns("Email_nv").HeaderText = "Email"
        dgvNhanVien.Columns("ID_CHang").HeaderText = "ID store"
        dgvNhanVien.Columns("ID_cv").HeaderText = "ID Regency"
        dgvNhanVien.Columns("Date_nv").HeaderText = "Date of birth"
    End Sub
    Private Sub NhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearText()
        ClearLB()
        ShowData()
        NameDGV()
    End Sub

    Private Sub dgvNhanVien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNhanVien.CellClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = dgvNhanVien.Rows(e.RowIndex)
            txtMaNhanVien.Text = row.Cells("ID_nv").Value.ToString
            txtDC.Text = row.Cells("DC_nv").Value.ToString
            txtDT.Text = row.Cells("DT_nv").Value.ToString
            txtEmail.Text = row.Cells("Email_nv").Value.ToString
            txtName.Text = row.Cells("Ten_nv").Value.ToString
            cmbChucVu.Text = row.Cells("ID_cv").Value.ToString
            cmbCuaHang.Text = row.Cells("ID_CHang").Value.ToString
            'If () Then
            'End If
        End If

    End Sub
End Class
