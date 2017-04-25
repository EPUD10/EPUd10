
Public Class Menuform
    Dim x, y As Integer
    Dim newpoint As Point
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        If pnlMenu.Width = 237 Then
            tranlogo.HideSync(pcb1)
            pnlMenu.Visible = False
            pnlMenu.Width = 55
            tranpanel.ShowSync(pnlMenu)
            btnmenu.Location = New Point(18, 60)
        Else
            pnlMenu.Width = 237
            btnmenu.Location = New Point(167, 60)
            tranlogo.ShowSync(pcb1)
            tranpanel.ShowSync(pnlMenu)
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub btnKhach_Click(sender As Object, e As EventArgs)
        KhachHangForm1.Visible = False
        KhachHangForm1.BringToFront()
        tranKhachhang.ShowSync(KhachHangForm1)
    End Sub

    Private Sub btnNhaCC_Click(sender As Object, e As EventArgs)
        NhaCCform1.Visible = False
        NhaCCform1.BringToFront()
        tranNhaCC.ShowSync(NhaCCform1)
    End Sub

    Private Sub btnKhach_Click_1(sender As Object, e As EventArgs) Handles btnKhach.Click
        KhachHangForm1.Visible = False
        KhachHangForm1.BringToFront()
        tranKhachhang.ShowSync(KhachHangForm1)
    End Sub

    Private Sub btnNhaCC_Click_1(sender As Object, e As EventArgs) Handles btnNhaCC.Click
        NhaCCform1.Visible = False
        NhaCCform1.BringToFront()
        tranNhaCC.ShowSync(NhaCCform1)
    End Sub

    Private Sub btnChucVu_Click(sender As Object, e As EventArgs) Handles btnChucVu.Click
        ChucVuForm1.Visible = False
        ChucVuForm1.BringToFront()
        tranChucVu.ShowSync(ChucVuForm1)
    End Sub

    Private Sub btnNhanVien_Click(sender As Object, e As EventArgs) Handles btnNhanVien.Click
        NhanVien1.Visible = False
        NhanVien1.BringToFront()
        tranNhanVien.ShowSync(NhanVien1)
    End Sub

    Private Sub btnTaiKhoan_Click(sender As Object, e As EventArgs) Handles btnTaiKhoan.Click
        TaiKhoan1.Visible = False
        TaiKhoan1.BringToFront()
        tranTaiKhoan.ShowSync(TaiKhoan1)
    End Sub

    Private Sub btnHoaDonBan_Click(sender As Object, e As EventArgs) Handles btnHoaDonBan.Click
        HoaDonBan1.Visible = False
        HoaDonBan1.BringToFront()
        tranHDN.ShowSync(HoaDonBan1)
    End Sub

    Private Sub btnHoaDonNhap_Click(sender As Object, e As EventArgs) Handles btnHoaDonNhap.Click
        HoaDonNhap1.Visible = False
        HoaDonNhap1.BringToFront()
        tranHDN.ShowSync(HoaDonNhap1)
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        'Home1.Visible = False
        'Home1.BringToFront()
        'tranHome.ShowSync(Home1)
    End Sub

    Private Sub btnCuaHang_Click(sender As Object, e As EventArgs) Handles btnCuaHang.Click
        CuaHang1.Visible = False
        CuaHang1.BringToFront()
        CuaHang1.Show()
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

End Class