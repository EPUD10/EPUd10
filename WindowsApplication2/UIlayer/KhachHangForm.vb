Imports BUS
Imports Entyti

Public Class KhachHangForm
    Private cls As New KhachBUS
    Private KH As New KhachEntyti
    Private check As New KiemTraBUS
    Private Sub lbEmty()
        lbID.Text = ""
        lbName.Text = ""
        lbEmail.Text = ""
        lbphone.Text = ""
        lbaddress.Text = ""
        rbtNam.Checked = True
    End Sub
    Private Sub txtEmty()
        txtAddress.Text = ""
        txtEmail.Text = ""
        txtIDCustomer.Text = ""
        txtNameCus.Text = ""
        txtPhoneNumber.Text = ""
    End Sub
    Private Sub BoolLb()
        If String.IsNullOrEmpty(txtIDCustomer.Text) Then
            lbID.Text = "ID is not NULL"
        End If
        If String.IsNullOrEmpty(txtNameCus.Text) Then
            lbName.Text = "ID is not NULL"
        End If
        If String.IsNullOrEmpty(txtEmail.Text) Then
            lbEmail.Text = "ID is not NULL"
        End If
        If String.IsNullOrEmpty(txtPhoneNumber.Text) Then
            lbphone.Text = "ID is not NULL"
        End If
        If String.IsNullOrEmpty(txtAddress.Text) Then
            lbaddress.Text = "ID is not NULL"
        End If
    End Sub
    Private Sub NameDGV()
        Try
            dgvKhach.Columns("ID_kh").HeaderText = "ID customer"
            dgvKhach.Columns("Ten_kh").HeaderText = "Name customer"
            dgvKhach.Columns("DC_kh").HeaderText = "Address"
            dgvKhach.Columns("DT_kh").HeaderText = "Phone number"
            dgvKhach.Columns("GT_kh").HeaderText = "Sex"
            dgvKhach.Columns("Email_kh").HeaderText = "Email"
            dgvKhach.Columns("Date_kh").HeaderText = "Date of birth"
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub showData()
        dgvKhach.DataSource = cls.LoadData()
    End Sub
    Private Sub KhachHangForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbEmty()
        showData()
        NameDGV()
        btnRemove.Enabled = False
        btnUpdate.Enabled = False
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        KH.Id = txtIDCustomer.Text
        If cls.checkID(KH).Rows.Count > 0 Then
            lbID.Text = "Duplicate data"
            txtIDCustomer.Text = ""
            txtIDCustomer.Focus()
        Else
            If Check.CheckMail(txtEmail.Text) = False Then
                lbEmail.Text = "Email is invalid"
                txtEmail.Text = ""
                txtEmail.Focus()
            Else
                If check.CheckPhone(txtPhoneNumber.Text) = False Then
                    lbphone.Text = "Phone is invalid"
                    txtPhoneNumber.Text = ""
                    txtPhoneNumber.Focus()
                Else
                    If String.IsNullOrEmpty(txtIDCustomer.Text) OrElse String.IsNullOrEmpty(txtNameCus.Text) OrElse String.IsNullOrEmpty(txtEmail.Text) OrElse String.IsNullOrEmpty(txtPhoneNumber.Text) OrElse String.IsNullOrEmpty(txtAddress.Text) Then
                        BoolLb()
                    Else
                        KH.Id = txtIDCustomer.Text
                        KH.Name = txtNameCus.Text
                        KH.Phone = txtPhoneNumber.Text
                        KH.Email = txtEmail.Text
                        KH.Birth = datetime.Value
                        KH.Add = txtAddress.Text
                        If rbtNam.Checked Then
                            KH.Sex = rbtNam.Text
                        ElseIf rbtnu.Checked Then
                            KH.Sex = rbtnu.Text
                        End If
                        cls.ADD(KH)
                        showData()
                        MessageBox.Show("insert success")
                        txtEmty()

                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            KH.Id = txtIDCustomer.Text
            cls.Dele(KH)
            showData()
            MessageBox.Show("Remove success")
            txtEmty()
            txtIDCustomer.Enabled = True
            btnadd.Enabled = True
            btnRemove.Enabled = False
            btnUpdate.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            KH.Id = txtIDCustomer.Text
            KH.Name = txtNameCus.Text
            KH.Phone = txtPhoneNumber.Text
            KH.Email = txtEmail.Text
            KH.Birth = datetime.Value
            KH.Add = txtAddress.Text
            If rbtNam.Checked Then
                KH.Sex = rbtNam.Text
            ElseIf rbtnu.Checked Then
                KH.Sex = rbtnu.Text
            End If
            cls.Update(KH)
            showData()
            MessageBox.Show("Update success")
            txtEmty()
            txtIDCustomer.Enabled = True
            btnadd.Enabled = True
            btnRemove.Enabled = False
            btnUpdate.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub dgvKhach_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKhach.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgvKhach.Rows(e.RowIndex)
            txtIDCustomer.Text = row.Cells("ID_kh").Value.ToString
            txtNameCus.Text = row.Cells("Ten_kh").Value.ToString
            txtPhoneNumber.Text = row.Cells("DT_kh").Value.ToString
            txtEmail.Text = row.Cells("Email_kh").Value.ToString
            datetime.Value = row.Cells("Date_kh").Value.ToString
            txtAddress.Text = row.Cells("DC_kh").Value.ToString
            'If StrComp(row.Cells("GT_kh").Value.ToString, "Nam") = 1 Then
            '    rbtNam.Checked = True
            'Else
            '    If StrComp(row.Cells("GT_kh").Value.ToString, "Nữ") = 1 Then
            '        rbtnu.Checked = True
            '    End If
            'End If
            ' MessageBox.Show(StrComp(row.Cells("GT_kh").Value.ToString, rbtNam.Text).ToString)
            txtIDCustomer.Enabled = False
            btnadd.Enabled = False
            btnRemove.Enabled = True
            btnUpdate.Enabled = True
        End If
    End Sub

    Private Sub txtAddress_Click(sender As Object, e As EventArgs) Handles txtAddress.Click
        lbEmty()
    End Sub

    Private Sub txtEmail_Click(sender As Object, e As EventArgs) Handles txtEmail.Click
        lbEmty()
    End Sub

    Private Sub txtIDCustomer_Click(sender As Object, e As EventArgs) Handles txtIDCustomer.Click
        lbEmty()
    End Sub

    Private Sub txtNameCus_Click(sender As Object, e As EventArgs) Handles txtNameCus.Click
        lbEmty()
    End Sub

    Private Sub txtPhoneNumber_Click(sender As Object, e As EventArgs) Handles txtPhoneNumber.Click
        lbEmty()
    End Sub
End Class
