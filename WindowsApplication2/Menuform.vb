Imports System.Data.SqlClient
Public Class Menuform

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        If pnlMenu.Width = 237 And pnlMenu.Height = 550 Then
            pnlMenu.Width = 55
            pnlMenu.Height = 550
            pcb1.Visible = False
            btnmenu.Location = New Point(18, 60)
        Else
            pnlMenu.Width = 237
            pnlMenu.Height = 550
            pcb1.Visible = True
            btnmenu.Location = New Point(167, 60)
        End If
    End Sub
    Dim con As SqlConnection
    Private Sub Menuform_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim sql As String
            sql = "Data Source=.\SQLEXPRESS;Initial Catalog=ChuoiCuaHang;Persist Security Info=True;User ID=sa;Password=sa123456"
            con = New SqlConnection(sql)
            Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM	dbo.ChucVu", con)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            dtg.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub dtg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg.CellContentClick

    End Sub
End Class