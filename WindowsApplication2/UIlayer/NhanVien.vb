Imports BUS
Imports Entyti

Public Class NhanVien
    Private cls As New NhanVienBUS
    Private NV As New NhanVienEntyti
    Private check As New KiemTraBUS
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
        rbtNam.Checked = True
    End Sub
    Private Sub ShowData()
        dgvNhanVien.DataSource = cls.LoadData()
    End Sub
    Private Sub loadCMBCH()
        cmbCuaHang.DataSource = cls.LoadCMBCH()
        cmbCuaHang.DisplayMember() = "Ten_CHang"
        cmbCuaHang.ValueMember() = "ID_CHang"
    End Sub
    Private Sub loadCMBCV()
        cmbChucVu.DataSource = cls.LoadCMBCV()
        cmbChucVu.DisplayMember() = "Ten_cv"
        cmbChucVu.ValueMember() = "ID_cv"
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
        loadCMBCH()
        loadCMBCV()
        btnRemove.Enabled = False
        btnUpdate.Enabled = False
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
            'cmbCuaHang.DisplayMember() = "Ten_CHang"
            'cmbChucVu.DisplayMember() = "Ten_cv"
            btnAdd.Enabled = False
            txtMaNhanVien.Text = False
            btnRemove.Enabled = True
            btnUpdate.Enabled = True
        End If
    End Sub
    Private Sub BoolLb()
        If (String.IsNullOrEmpty(txtMaNhanVien.Text)) Then
            lbID.Text = "ID is not NULL"
        End If
        If (String.IsNullOrEmpty(txtName.Text)) Then
            lbName.Text = "ID is not NULL"
        End If
        If (String.IsNullOrEmpty(txtDT.Text)) Then
            lbPhone.Text = "Phone is not NULL"
        End If
        If (String.IsNullOrEmpty(txtDC.Text)) Then
            lbAdd.Text = "Address is not NULL"
        End If
        If (String.IsNullOrEmpty(txtEmail.Text)) Then
            lbEmail.Text = "Email is not NULL"
        End If
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            NV.IdNV = txtMaNhanVien.Text
            If cls.checkID(NV).Rows.Count > 0 Then
                lbID.Text = "Duplicate data"
                txtMaNhanVien.Text = ""
                txtMaNhanVien.Focus()
            Else
                If Check.CheckMail(txtEmail.Text) = False Then
                    lbEmail.Text = "Email is invalid"
                    txtEmail.Text = ""
                    txtEmail.Focus()
                Else
                    If Check.CheckPhone(txtDT.Text) = False Then
                        lbPhone.Text = "Phone is invalid"
                        txtDT.Text = ""
                        txtDT.Focus()
                    Else
                        If (String.IsNullOrEmpty(txtMaNhanVien.Text)) OrElse (String.IsNullOrEmpty(txtName.Text)) OrElse (String.IsNullOrEmpty(txtDT.Text)) OrElse (String.IsNullOrEmpty(txtDC.Text)) OrElse (String.IsNullOrEmpty(txtEmail.Text)) Then
                            BoolLb()
                        Else
                            NV.IdNV = txtMaNhanVien.Text()
                            NV.Name = txtName.Text()
                            NV.Phone = txtDT.Text()
                            NV.IdCV = cmbChucVu.SelectedValue
                            NV.IdCH = cmbCuaHang.SelectedValue()
                            NV.Birth = dateNV.Value
                            NV.Address = txtDC.Text()
                            NV.Email = txtEmail.Text()
                            If (rbtNam.Checked = True) Then
                                NV.Sex = rbtNam.Text()
                            Else
                                If rbtNu.Checked = True Then
                                    NV.Sex = rbtNu.Text()
                                End If
                            End If
                            cls.Add(NV)
                            ShowData()
                            MessageBox.Show("Add success")

                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            NV.IdNV = txtMaNhanVien.Text()
            cls.Delete(NV)
            ShowData()
            MessageBox.Show("Delete success")
            btnAdd.Enabled = True
            txtMaNhanVien.Text = True
            btnRemove.Enabled = False
            btnUpdate.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            NV.IdNV = txtMaNhanVien.Text()
            NV.Name = txtName.Text()
            NV.Phone = txtDT.Text()
            NV.IdCV = cmbChucVu.SelectedValue
            NV.IdCH = cmbCuaHang.SelectedValue()
            NV.Birth = dateNV.Value
            NV.Address = txtDC.Text()
            NV.Email = txtEmail.Text()
            If (rbtNam.Checked = True) Then
                NV.Sex = rbtNam.Text()
            Else
                If rbtNu.Checked = True Then
                    NV.Sex = rbtNu.Text()
                End If
            End If
            cls.Update(NV)
            ShowData()
            MessageBox.Show("Update success")
            btnAdd.Enabled = True
            txtMaNhanVien.Text = True
            btnRemove.Enabled = False
            btnUpdate.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txtDC_Click(sender As Object, e As EventArgs) Handles txtDC.Click
        ClearLB()
    End Sub

    Private Sub txtDT_Click(sender As Object, e As EventArgs) Handles txtDT.Click
        ClearLB()
    End Sub

    Private Sub txtEmail_Click(sender As Object, e As EventArgs) Handles txtEmail.Click
        ClearLB()
    End Sub

    Private Sub txtMaNhanVien_Click(sender As Object, e As EventArgs) Handles txtMaNhanVien.Click
        ClearLB()
    End Sub

    Private Sub txtName_Click(sender As Object, e As EventArgs) Handles txtName.Click
        ClearLB()
    End Sub
End Class
