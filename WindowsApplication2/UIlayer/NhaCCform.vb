﻿
Imports BUS
Imports Entyti

Public Class NhaCCform
    Private cls As New NhaCCBUS
    Private NCC As New NhaCCEntyti
    Private check As New KiemTraBUS
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
    Private Sub nameDGV()
        dgvNhaCC.Columns("ID_nhaCC").HeaderText = "ID supplier"
        dgvNhaCC.Columns("Ten_nhaCC").HeaderText = "Name supplier"
        dgvNhaCC.Columns("DT_nhaCC").HeaderText = "Phone number"
        dgvNhaCC.Columns("DC_nhaCC").HeaderText = "Address"
        dgvNhaCC.Columns("Email_nhaCC").HeaderText = "Email"
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
        nameDGV()
        btnRemove.Enabled = False
        btnUpdate.Enabled = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        NCC.Ma = txtMaNhaCC.Text
        If cls.checkID(NCC).Rows.Count > 0 Then
            lbID.Text = "Duplicate data"
            txtMaNhaCC.Text = ""
            txtMaNhaCC.Focus()
        Else
            If Check.CheckMail(txtEmail.Text) = False Then
                lbEmail.Text = "Email is invalid"
                txtEmail.Text = ""
                txtEmail.Focus()
            Else
                If check.CheckPhone(txtDienThoai.Text) = False Then
                    lbPhone.Text = "Phone is invalid"
                    txtDienThoai.Text = ""
                    txtDienThoai.Focus()
                Else
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
                End If
            End If
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            NCC.Ma = txtMaNhaCC.Text
            cls.Remove(NCC)
            showData()
            Clear()
            MessageBox.Show("Remove success !")
            btnAdd.Enabled = True
            txtMaNhaCC.Enabled = True
            btnRemove.Enabled = False
            btnUpdate.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
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
            btnAdd.Enabled = False
            txtMaNhaCC.Enabled = False
            btnRemove.Enabled = True
            btnUpdate.Enabled = True
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If check.CheckMail(txtEmail.Text) = False Then
                lbEmail.Text = "Email is invalid"
                txtEmail.Text = ""
                txtEmail.Focus()
            Else
                If check.CheckPhone(txtDienThoai.Text) = False Then
                    lbPhone.Text = "Phone is invalid"
                    txtDienThoai.Text = ""
                    txtDienThoai.Focus()
                Else
                    NCC.Email = txtEmail.Text
                    If (cls.checkEmail(NCC).Rows.Count > 0) Then
                        lbID.Text = "Duplicate data"
                        txtEmail.Text = ""
                        txtEmail.Focus()
                    Else
                        NCC.DienThoai = txtDienThoai.Text
                        If (cls.checkPhone(NCC).Rows.Count > 0) Then
                            lbID.Text = "Duplicate data"
                            txtDienThoai.Text = ""
                            txtDienThoai.Focus()
                        Else
                            NCC.Ma = txtMaNhaCC.Text
                            NCC.Ten = txtTenNhaCC.Text
                            NCC.DienThoai = txtDienThoai.Text
                            NCC.DiaChi = txtDiaChi.Text
                            NCC.Email = txtEmail.Text
                            cls.Update(NCC)
                            showData()
                            Clear()
                            MessageBox.Show("Update success !")
                            btnAdd.Enabled = True
                            txtMaNhaCC.Enabled = True
                            btnRemove.Enabled = False
                            btnUpdate.Enabled = False
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txtMaNhaCC_Click(sender As Object, e As EventArgs) Handles txtMaNhaCC.Click
        ClearLb()
    End Sub

    Private Sub txtDiaChi_Click(sender As Object, e As EventArgs) Handles txtDiaChi.Click
        ClearLb()
    End Sub

    Private Sub txtDienThoai_Click(sender As Object, e As EventArgs) Handles txtDienThoai.Click
        ClearLb()
    End Sub

    Private Sub txtEmail_Click(sender As Object, e As EventArgs) Handles txtEmail.Click
        ClearLb()
    End Sub

    Private Sub txtTenNhaCC_Click(sender As Object, e As EventArgs) Handles txtTenNhaCC.Click
        ClearLb()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Clear()
        txtMaNhaCC.Enabled = True
        btnAdd.Enabled = True
        btnRemove.Enabled = False
        btnUpdate.Enabled = False
    End Sub
End Class
