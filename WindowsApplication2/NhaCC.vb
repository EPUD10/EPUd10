Public Class NhaCC
    Private Sub NhaCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim x, y As Integer
    Dim newpoint As Point
    Private Sub NhaCC_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub NhaCC_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub
End Class