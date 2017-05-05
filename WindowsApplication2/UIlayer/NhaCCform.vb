
Imports BUS
Imports Entyti

Public Class NhaCCform
    Private cls As New NhaCCBUS
    Private NCC As New NhaCCEntyti
    Private Sub showData()
        dgvNhaCC.DataSource = cls.LoadData
    End Sub
    Private Sub ClearLb()
        lbAdd.Text = ""
        lbEmail.Text = ""
        lbID.Text = ""
        lbName.Text = ""
        lbPhone.Text = ""
    End Sub
    Private Sub Clear()
        txtMaNhaCC.Text = ""
        txtTenNhaCC.Text = ""
        txtDienThoai.Text = ""
        txtDiaChi.Text = ""
        txtEmail.Text = ""
        txtMaNhaCC.Focus()
    End Sub
    Private Sub KTEmty()
        If (String.IsNullOrEmpty(txtDiaChi.Text)) Then
            lbAdd.Text = "Address is not NULL"
        End If
        If (String.IsNullOrEmpty(txtDienThoai.Text)) Then
            lbPhone.Text = "Phone is not NULL"
        End If
        If (String.IsNullOrEmpty(txtEmail.Text)) Then
            lbEmail.Text = "Email is not NULL"
        End If
        If (String.IsNullOrEmpty(txtMaNhaCC.Text)) Then
            lbID.Text = "ID is not NULL"
        End If
        If (String.IsNullOrEmpty(txtTenNhaCC.Text)) Then
            lbName.Text = "Name is not NULL"
        End If
    End Sub

    Private Sub NhaCCform_Load(sender As Object, e As EventArgs) Handles Me.Load
        Clear()
        ClearLb()
        showData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrEmpty(txtDiaChi.Text) OrElse String.IsNullOrEmpty(txtDienThoai.Text) OrElse String.IsNullOrEmpty(txtEmail.Text) OrElse String.IsNullOrEmpty(txtMaNhaCC.Text) OrElse String.IsNullOrEmpty(txtTenNhaCC.Text) Then
            KTEmty()
        Else
            NCC.Ma = txtMaNhaCC.Text
            NCC.Ten = txtTenNhaCC.Text
            NCC.DienThoai = txtDienThoai.Text
            NCC.DiaChi = txtDiaChi.Text
            NCC.Email = txtEmail.Text
            cls.insert(NCC)
            showData()
            Clear()
            MessageBox.Show("Add success !")
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        NCC.Ma = txtMaNhaCC.Text
        cls.Remove(NCC)
        showData()
        Clear()
        MessageBox.Show("Remove success !")
    End Sub

    Private Sub dgvNhaCC_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNhaCC.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgvNhaCC.Rows(e.RowIndex)
            txtMaNhaCC.Text = row.Cells("ID_nhaCC").Value.ToString
            txtTenNhaCC.Text = row.Cells("Ten_nhaCC").Value.ToString
            txtDienThoai.Text = row.Cells("DT_nhaCC").Value.ToString
            txtDiaChi.Text = row.Cells("DC_nhaCC").Value.ToString
            txtEmail.Text = row.Cells("Email_nhaCC").Value.ToString
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(txtDiaChi.Text) OrElse String.IsNullOrEmpty(txtDienThoai.Text) OrElse String.IsNullOrEmpty(txtEmail.Text) OrElse String.IsNullOrEmpty(txtMaNhaCC.Text) OrElse String.IsNullOrEmpty(txtTenNhaCC.Text) Then
            KTEmty()
        Else
            NCC.Ma = txtMaNhaCC.Text
            NCC.Ten = txtTenNhaCC.Text
            NCC.DienThoai = txtDienThoai.Text
            NCC.DiaChi = txtDiaChi.Text
            NCC.Email = txtEmail.Text
            cls.Update(NCC)
            showData()
            Clear()
            MessageBox.Show("Add success !")
        End If
    End Sub
End Class
