Public Class Login

    Private Sub EmtySignUp()
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtEmailSignUp.Text = ""
        txtPasswordSignUp.Text = ""
        txtFirstName.Focus()
    End Sub
    Private Sub BoolEmtySignUp()
        If txtFirstName.Text = "" Then
            labelFirst.Text = "Bạn chưa nhập tên!"
        End If
        If txtLastName.Text = "" Then
            labelLastName.Text = "Bạn chưa nhập tên!"
        End If
        If txtEmailSignUp.Text = "" Then
            labelEmailSignUp.Text = "Bạn chưa nhập email!"
        End If
        If txtPasswordSignUp.Text = "" Then
            labelPasswordSignUp.Text = "Bạn chưa nhập mật khẩu!"
        End If
    End Sub
    Private Sub deLabelSignUp()
        If String.IsNullOrEmpty(txtFirstName.Text) Then
            labelFirst.Text = ""
        End If
        If String.IsNullOrEmpty(txtLastName.Text) Then
            labelLastName.Text = ""
        End If
        If String.IsNullOrEmpty(txtEmailSignUp.Text) Then
            labelEmailSignUp.Text = ""
        End If
        If String.IsNullOrEmpty(txtPasswordSignUp.Text) Then
            labelPasswordSignUp.Text = ""
        End If
    End Sub
    Private Sub EmtySignIn()
        txtEmailSignIn.Text = ""
        txtPasswordSignIn.Text = ""
        txtEmailSignIn.Focus()
    End Sub
    Private Sub BoolEmtySignIn()
        If txtEmailSignIn.Text = "" Then
            labelEmailSignIn.Text = "Bạn chưa nhập email!"
        End If
        If txtPasswordSignIn.Text = "" Then
            labelPassworSignIn.Text = "Bạn chưa nhập mật khẩu!"
        End If
    End Sub
    Private Sub deLabelSignIn()
        If String.IsNullOrEmpty(txtEmailSignIn.Text) Then
            labelEmailSignIn.Text = ""
        End If
        If String.IsNullOrEmpty(txtPasswordSignIn.Text) Then
            labelPassworSignIn.Text = ""
        End If
    End Sub
    Private Sub btnSingIn_Click(sender As Object, e As EventArgs) Handles btnSingIn.Click
        If PanelSignIn.Left = 483 Then
            PanelSignUp.Visible = False
            PanelSignUp.Left = 483
            PanelSignIn.Visible = False
            PanelSignIn.Left = 30
            PanelSignIn.Visible = True
            PanelSignIn.Refresh()
            EmtySignIn()
            deLabelSignIn()
        End If
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        If PanelSignUp.Left = 483 Then
            PanelSignIn.Visible = False
            PanelSignIn.Left = 483
            PanelSignUp.Visible = False
            PanelSignUp.Left = 30
            PanelSignUp.Visible = True
            PanelSignUp.Refresh()
            EmtySignUp()
            deLabelSignUp()
        End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        EmtySignUp()
    End Sub

    Private Sub btnSignUpLogin_Click(sender As Object, e As EventArgs) Handles btnSignUpLogin.Click
        BoolEmtySignUp()
    End Sub

    Private Sub btnSignInLogin_Click(sender As Object, e As EventArgs) Handles btnSignInLogin.Click
        BoolEmtySignIn()
    End Sub

End Class