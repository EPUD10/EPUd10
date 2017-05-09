Imports BUS
Imports Entyti

Public Class ChucVu
    Private cls As New ChucVuBUS
    Private CV As New ChucVuEntyti
    Private Sub showData()
        dgvChucVu.DataSource = cls.LoadData()
    End Sub
    Private Sub nameDGV()
        dgvChucVu.Columns("ID_cv").HeaderText = "ID Regency"
        dgvChucVu.Columns("Ten_cv").HeaderText = "Name Regency"
        dgvChucVu.Columns("QuyenHan").HeaderText = "Note"
    End Sub
    Private Sub emtylb()
        lbID.Text = ""
        lbName.Text = ""
        lbNote.Text = ""
    End Sub
    Private Sub boolEmty()
        If (String.IsNullOrEmpty(txtID.Text)) Then
            lbID.Text = "ID is not NULL"
        End If
        If (String.IsNullOrEmpty(txtName.Text)) Then
            lbName.Text = "Name is not NULL"
        End If
        If (String.IsNullOrEmpty(txtNote.Text)) Then
            lbNote.Text = "Note is not NULL"
        End If
    End Sub
    Private Sub ChucVu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
        nameDGV()
        emtylb()
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        CV.Id = txtID.Text
        If cls.CheckID(CV).Rows.Count > 0 Then
            lbID.Text = "Duplicate data"
            txtID.Text = ""
            txtID.Focus()
        Else
            If (String.IsNullOrEmpty(txtID.Text)) OrElse (String.IsNullOrEmpty(txtName.Text)) OrElse (String.IsNullOrEmpty(txtNote.Text)) Then
                boolEmty()
            Else
                CV.Id = txtID.Text
                CV.Name = txtName.Text
                CV.Power = txtNote.Text
                cls.Insert(CV)
                showData()
                MessageBox.Show("Insert success")
            End If
        End If
    End Sub

    Private Sub dgvChucVu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChucVu.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgvChucVu.Rows(e.RowIndex)
            txtID.Text = row.Cells("ID_cv").Value.ToString
            txtName.Text = row.Cells("Ten_cv").Value.ToString
            txtNote.Text = row.Cells("QuyenHan").Value.ToString
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        CV.Id = txtID.Text
        cls.dele(CV)
        showData()
        MessageBox.Show("Delete success")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        CV.Id = txtID.Text
        CV.Name = txtName.Text
        CV.Power = txtNote.Text
        cls.update(CV)
        showData()
        MessageBox.Show("Update success")
    End Sub

    Private Sub lbID_Click(sender As Object, e As EventArgs) Handles lbID.Click
        emtylb()
    End Sub

    Private Sub lbName_Click(sender As Object, e As EventArgs) Handles lbName.Click
        emtylb()
    End Sub

    Private Sub lbNote_Click(sender As Object, e As EventArgs) Handles lbNote.Click
        emtylb()
    End Sub
End Class
