Public Class Menu


    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        If (pnlsh.Width = 180 And pnlsh.Height = 485) Then
            pnlsh.Width = 42
            pnlsh.Height = 485
            pcb1.Visible = False
            btnmenu.Size = New Size(20, 20)
            btnmenu.Location = New Point(12, 44)
        Else
            pnlsh.Width = 180
            pnlsh.Height = 485
            pcb1.Visible = True
            btnmenu.Size = New System.Drawing.Size(30, 30)
            btnmenu.Location = New Point(140, 43)
        End If

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class