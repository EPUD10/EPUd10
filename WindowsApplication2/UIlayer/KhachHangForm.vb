Imports BUS

Public Class KhachHangForm
    Private cls As New KhachBUS
    Private Sub lbEmty()
        lbID.Text = ""
        lbName.Text = ""
        lbEmail.Text = ""
        lbphone.Text = ""
        lbaddress.Text = ""
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
        dgvKhach.Columns("ID_kh").HeaderText = "ID customer"
        dgvKhach.Columns("Ten_kh").HeaderText = "Name customer"
        dgvKhach.Columns("DC_kh").HeaderText = "Address"
        dgvKhach.Columns("DT_kh").HeaderText = "Phone number"
        dgvKhach.Columns("GT_kh").HeaderText = "Sex"
        dgvKhach.Columns("Email_kh").HeaderText = "Email"
        dgvKhach.Columns("Date_kh").HeaderText = "Date of birth"
    End Sub
    Public Sub showData()
        dgvKhach.DataSource = cls.LoadData()
    End Sub
    Private Sub KhachHangForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbEmty()
        showData()
        NameDGV()
    End Sub


End Class
