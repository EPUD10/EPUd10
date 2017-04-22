
Public Class Menuform
    Dim NhaCC As New NhaCCform
    Dim ChucVu As New ChucVuform
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
    Dim x, y As Integer
    Dim newpoint As Point

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub btnChucVu_Click(sender As Object, e As EventArgs) Handles btnChucVu.Click
        ChucVuform1.Visible = False
        ChucVuform1.BringToFront()
        tranNhaCC.ShowSync(ChucVuform1)
    End Sub

    Private Sub btnNhaCC_Click(sender As Object, e As EventArgs) Handles btnNhaCC.Click
        NhaCCform1.Visible = False
        NhaCCform1.BringToFront()
        tranNhaCC.ShowSync(NhaCCform1)
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