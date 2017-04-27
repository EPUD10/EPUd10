Imports BUS
Imports Entyti
Public Class CuaHang
    Private cls As New CuaHangBUS
    Private CH As New CuaHangEntyti
    Public Sub showData()
        dgvCH.DataSource = cls.LoadData()
    End Sub
    Public Sub Clear()
        txtMaCH.Text = ""
        txtName.Text = ""
        txtEmail.Text = ""
        txtDT.Text = ""
        txtDC.Text = ""
        txtMaCH.Focus()
    End Sub
    Public Sub dgv()
        dgvCH.Columns("ID_CHang").HeaderText = "ID store"
        dgvCH.Columns("Ten_CHang").HeaderText = "Name store"
        dgvCH.Columns("DC_CHang").HeaderText = "Address"
        dgvCH.Columns("DT_CHang").HeaderText = "Phone number"
        dgvCH.Columns("Email_CHang").HeaderText = "Email"
    End Sub
    Private Sub CuaHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        showData()
        dgv()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        CH.Ma = txtMaCH.Text
        CH.Ten = txtName.Text
        CH.Email = txtEmail.Text
        CH.DienThoai = txtDT.Text
        CH.DiaChi = txtDC.Text
        cls.Add(CH)
        showData()
        Clear()
        MessageBox.Show("Add success !!!")
    End Sub

    Private Sub dgvCH_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCH.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgvCH.Rows(e.RowIndex)
            txtMaCH.Text = row.Cells("ID_CHang").Value.ToString
            txtDC.Text = row.Cells("DC_CHang").Value.ToString
            txtDT.Text = row.Cells("DT_CHang").Value.ToString
            txtEmail.Text = row.Cells("Email_CHang").Value.ToString
            txtName.Text = row.Cells("Ten_CHang").Value.ToString
        End If
    End Sub
End Class
