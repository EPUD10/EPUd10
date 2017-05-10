Imports BUS
Imports Entyti

Public Class Taikhoan
    Private cls As New AccountBUS
    Private TK As New TaiKhoanEntyti
    Public Sub Showdata()
        dgvTaiKhoan.DataSource = cls.load()
    End Sub
    Public Sub dgv()
        dgvTaiKhoan.Columns("ID_nv").HeaderText = "ID Account"
        dgvTaiKhoan.Columns("MK_nv").HeaderText = "Password"
        dgvTaiKhoan.Columns("GhiChu_nv").HeaderText = "Note"
    End Sub
    Public Sub clear()
        txtTaiKhoan.Text = ""
        txtMatKhau.Text = ""
        txtGhiChu.Text = ""
        txtTaiKhoan.Focus()
    End Sub
    Public Sub ktEmty()
        If String.IsNullOrEmpty(txtTaiKhoan.Text) Then
            lbTaiKhoan.Text = "ID is not NULL !"
        End If
        If String.IsNullOrEmpty(txtMatKhau.Text) Then
            lbMatKhau.Text = "Password is not NULL !"
        End If
        If String.IsNullOrEmpty(txtGhiChu.Text) Then
            lbNote.Text = "ID is not NULL !"
        End If
    End Sub
    Public Sub lbEmty()
        lbTaiKhoan.Text = ""
        lbMatKhau.Text = ""
        lbNote.Text = ""
    End Sub
    Private Sub Taikhoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbEmty()
        clear()
        Showdata()
        dgv()
        btnRemove.Enabled = False
        btnUpdate.Enabled = False
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            TK.Ma = txtTaiKhoan.Text
            If (cls.LoadID(TK).Rows.Count) > 0 Then
                lbTaiKhoan.Text = "Duplicate data"
                txtTaiKhoan.Text = ""
                txtTaiKhoan.Focus()
            Else
                If String.IsNullOrEmpty(txtTaiKhoan.Text) OrElse String.IsNullOrEmpty(txtMatKhau.Text) OrElse String.IsNullOrEmpty(txtGhiChu.Text) Then
                    ktEmty()
                Else
                    TK.Ma = txtTaiKhoan.Text
                    TK.Ten = txtMatKhau.Text
                    TK.Ghichu = txtGhiChu.Text
                    cls.Add(TK)
                    Showdata()
                    clear()
                    MessageBox.Show("Add success !")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txtTaiKhoan_Click(sender As Object, e As EventArgs) Handles txtTaiKhoan.Click
        lbEmty()
    End Sub

    Private Sub txtMatKhau_Click(sender As Object, e As EventArgs) Handles txtMatKhau.Click
        lbEmty()
    End Sub

    Private Sub txtGhiChu_Click(sender As Object, e As EventArgs) Handles txtGhiChu.Click
        lbEmty()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            TK.Ma = txtTaiKhoan.Text
            cls.Delete(TK)
            Showdata()
            MessageBox.Show("Delete success !")
            clear()
            btnAdd.Enabled = True
            txtTaiKhoan.Enabled = True
            btnRemove.Enabled = False
            btnUpdate.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub dgvTaiKhoan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTaiKhoan.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgvTaiKhoan.Rows(e.RowIndex)
            txtTaiKhoan.Text = row.Cells("ID_nv").Value.ToString
            txtMatKhau.Text = row.Cells("MK_nv").Value.ToString
            txtGhiChu.Text = row.Cells("GhiChu_nv").Value.ToString
            btnAdd.Enabled = False
            txtTaiKhoan.Enabled = False
            btnRemove.Enabled = True
            btnUpdate.Enabled = True
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            TK.Ma = txtTaiKhoan.Text
            TK.Ten = txtMatKhau.Text
            TK.Ghichu = txtGhiChu.Text
            cls.Update(TK)
            Showdata()
            MessageBox.Show("Update success !!!")
            clear()
            btnAdd.Enabled = True
            txtTaiKhoan.Enabled = True
            btnRemove.Enabled = False
            btnUpdate.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        TK.Ma = txtSearch.Text
        cls.Search(TK)
        Showdata()
        clear()
    End Sub


End Class
