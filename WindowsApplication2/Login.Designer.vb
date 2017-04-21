<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnSingIn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSignUp = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PanelSignUp = New System.Windows.Forms.Panel()
        Me.labelPasswordSignUp = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.labelEmailSignUp = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.labelLastName = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.labelFirst = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnSignUpLogin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtPasswordSignUp = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtEmailSignUp = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtLastName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtFirstName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PanelSignIn = New System.Windows.Forms.Panel()
        Me.labelPassworSignIn = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.labelEmailSignIn = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnSignInLogin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtPasswordSignIn = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtEmailSignIn = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tranSignUp = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.tranSignIn = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.PanelSignUp.SuspendLayout()
        Me.PanelSignIn.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'btnSingIn
        '
        Me.btnSingIn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSingIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnSingIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSingIn.BorderRadius = 0
        Me.btnSingIn.ButtonText = "Sign In"
        Me.btnSingIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranSignIn.SetDecoration(Me.btnSingIn, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignUp.SetDecoration(Me.btnSingIn, BunifuAnimatorNS.DecorationType.None)
        Me.btnSingIn.DisabledColor = System.Drawing.Color.Gray
        Me.btnSingIn.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSingIn.Iconimage = Nothing
        Me.btnSingIn.Iconimage_right = Nothing
        Me.btnSingIn.Iconimage_right_Selected = Nothing
        Me.btnSingIn.Iconimage_Selected = Nothing
        Me.btnSingIn.IconMarginLeft = 0
        Me.btnSingIn.IconMarginRight = 0
        Me.btnSingIn.IconRightVisible = True
        Me.btnSingIn.IconRightZoom = 0R
        Me.btnSingIn.IconVisible = True
        Me.btnSingIn.IconZoom = 90.0R
        Me.btnSingIn.IsTab = False
        Me.btnSingIn.Location = New System.Drawing.Point(224, 25)
        Me.btnSingIn.Name = "btnSingIn"
        Me.btnSingIn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnSingIn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnSingIn.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSingIn.selected = False
        Me.btnSingIn.Size = New System.Drawing.Size(149, 48)
        Me.btnSingIn.TabIndex = 0
        Me.btnSingIn.Text = "Sign In"
        Me.btnSingIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSingIn.Textcolor = System.Drawing.Color.White
        Me.btnSingIn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSignUp
        '
        Me.btnSignUp.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSignUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSignUp.BorderRadius = 0
        Me.btnSignUp.ButtonText = "Sign Up"
        Me.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranSignIn.SetDecoration(Me.btnSignUp, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignUp.SetDecoration(Me.btnSignUp, BunifuAnimatorNS.DecorationType.None)
        Me.btnSignUp.DisabledColor = System.Drawing.Color.Gray
        Me.btnSignUp.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSignUp.Iconimage = Nothing
        Me.btnSignUp.Iconimage_right = Nothing
        Me.btnSignUp.Iconimage_right_Selected = Nothing
        Me.btnSignUp.Iconimage_Selected = Nothing
        Me.btnSignUp.IconMarginLeft = 0
        Me.btnSignUp.IconMarginRight = 0
        Me.btnSignUp.IconRightVisible = True
        Me.btnSignUp.IconRightZoom = 0R
        Me.btnSignUp.IconVisible = True
        Me.btnSignUp.IconZoom = 90.0R
        Me.btnSignUp.IsTab = False
        Me.btnSignUp.Location = New System.Drawing.Point(80, 25)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSignUp.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnSignUp.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSignUp.selected = False
        Me.btnSignUp.Size = New System.Drawing.Size(138, 48)
        Me.btnSignUp.TabIndex = 1
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSignUp.Textcolor = System.Drawing.Color.White
        Me.btnSignUp.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PanelSignUp
        '
        Me.PanelSignUp.Controls.Add(Me.labelPasswordSignUp)
        Me.PanelSignUp.Controls.Add(Me.labelEmailSignUp)
        Me.PanelSignUp.Controls.Add(Me.labelLastName)
        Me.PanelSignUp.Controls.Add(Me.labelFirst)
        Me.PanelSignUp.Controls.Add(Me.btnSignUpLogin)
        Me.PanelSignUp.Controls.Add(Me.BunifuCustomLabel5)
        Me.PanelSignUp.Controls.Add(Me.txtPasswordSignUp)
        Me.PanelSignUp.Controls.Add(Me.BunifuCustomLabel4)
        Me.PanelSignUp.Controls.Add(Me.txtEmailSignUp)
        Me.PanelSignUp.Controls.Add(Me.BunifuCustomLabel3)
        Me.PanelSignUp.Controls.Add(Me.txtLastName)
        Me.PanelSignUp.Controls.Add(Me.BunifuCustomLabel2)
        Me.PanelSignUp.Controls.Add(Me.txtFirstName)
        Me.PanelSignUp.Controls.Add(Me.BunifuCustomLabel1)
        Me.tranSignIn.SetDecoration(Me.PanelSignUp, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignUp.SetDecoration(Me.PanelSignUp, BunifuAnimatorNS.DecorationType.None)
        Me.PanelSignUp.Location = New System.Drawing.Point(30, 96)
        Me.PanelSignUp.Name = "PanelSignUp"
        Me.PanelSignUp.Size = New System.Drawing.Size(392, 347)
        Me.PanelSignUp.TabIndex = 2
        '
        'labelPasswordSignUp
        '
        Me.labelPasswordSignUp.AutoSize = True
        Me.tranSignUp.SetDecoration(Me.labelPasswordSignUp, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignIn.SetDecoration(Me.labelPasswordSignUp, BunifuAnimatorNS.DecorationType.None)
        Me.labelPasswordSignUp.ForeColor = System.Drawing.Color.Red
        Me.labelPasswordSignUp.Location = New System.Drawing.Point(9, 273)
        Me.labelPasswordSignUp.Name = "labelPasswordSignUp"
        Me.labelPasswordSignUp.Size = New System.Drawing.Size(0, 13)
        Me.labelPasswordSignUp.TabIndex = 13
        '
        'labelEmailSignUp
        '
        Me.labelEmailSignUp.AutoSize = True
        Me.tranSignUp.SetDecoration(Me.labelEmailSignUp, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignIn.SetDecoration(Me.labelEmailSignUp, BunifuAnimatorNS.DecorationType.None)
        Me.labelEmailSignUp.ForeColor = System.Drawing.Color.Red
        Me.labelEmailSignUp.Location = New System.Drawing.Point(3, 194)
        Me.labelEmailSignUp.Name = "labelEmailSignUp"
        Me.labelEmailSignUp.Size = New System.Drawing.Size(0, 13)
        Me.labelEmailSignUp.TabIndex = 12
        '
        'labelLastName
        '
        Me.labelLastName.AutoSize = True
        Me.tranSignUp.SetDecoration(Me.labelLastName, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignIn.SetDecoration(Me.labelLastName, BunifuAnimatorNS.DecorationType.None)
        Me.labelLastName.ForeColor = System.Drawing.Color.Red
        Me.labelLastName.Location = New System.Drawing.Point(206, 113)
        Me.labelLastName.Name = "labelLastName"
        Me.labelLastName.Size = New System.Drawing.Size(0, 13)
        Me.labelLastName.TabIndex = 11
        '
        'labelFirst
        '
        Me.labelFirst.AutoSize = True
        Me.tranSignUp.SetDecoration(Me.labelFirst, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignIn.SetDecoration(Me.labelFirst, BunifuAnimatorNS.DecorationType.None)
        Me.labelFirst.ForeColor = System.Drawing.Color.Red
        Me.labelFirst.Location = New System.Drawing.Point(9, 113)
        Me.labelFirst.Name = "labelFirst"
        Me.labelFirst.Size = New System.Drawing.Size(0, 13)
        Me.labelFirst.TabIndex = 10
        '
        'btnSignUpLogin
        '
        Me.btnSignUpLogin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSignUpLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSignUpLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSignUpLogin.BorderRadius = 0
        Me.btnSignUpLogin.ButtonText = "Sign Up"
        Me.btnSignUpLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranSignIn.SetDecoration(Me.btnSignUpLogin, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignUp.SetDecoration(Me.btnSignUpLogin, BunifuAnimatorNS.DecorationType.None)
        Me.btnSignUpLogin.DisabledColor = System.Drawing.Color.Gray
        Me.btnSignUpLogin.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSignUpLogin.Iconimage = Nothing
        Me.btnSignUpLogin.Iconimage_right = Nothing
        Me.btnSignUpLogin.Iconimage_right_Selected = Nothing
        Me.btnSignUpLogin.Iconimage_Selected = Nothing
        Me.btnSignUpLogin.IconMarginLeft = 0
        Me.btnSignUpLogin.IconMarginRight = 0
        Me.btnSignUpLogin.IconRightVisible = True
        Me.btnSignUpLogin.IconRightZoom = 0R
        Me.btnSignUpLogin.IconVisible = True
        Me.btnSignUpLogin.IconZoom = 90.0R
        Me.btnSignUpLogin.IsTab = False
        Me.btnSignUpLogin.Location = New System.Drawing.Point(6, 299)
        Me.btnSignUpLogin.Name = "btnSignUpLogin"
        Me.btnSignUpLogin.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSignUpLogin.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnSignUpLogin.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSignUpLogin.selected = False
        Me.btnSignUpLogin.Size = New System.Drawing.Size(382, 39)
        Me.btnSignUpLogin.TabIndex = 9
        Me.btnSignUpLogin.Text = "Sign Up"
        Me.btnSignUpLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSignUpLogin.Textcolor = System.Drawing.Color.White
        Me.btnSignUpLogin.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.tranSignUp.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignIn.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(3, 211)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(68, 16)
        Me.BunifuCustomLabel5.TabIndex = 8
        Me.BunifuCustomLabel5.Text = "Password"
        '
        'txtPasswordSignUp
        '
        Me.txtPasswordSignUp.BorderColorFocused = System.Drawing.Color.Silver
        Me.txtPasswordSignUp.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtPasswordSignUp.BorderColorMouseHover = System.Drawing.Color.Silver
        Me.txtPasswordSignUp.BorderThickness = 1
        Me.txtPasswordSignUp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tranSignUp.SetDecoration(Me.txtPasswordSignUp, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignIn.SetDecoration(Me.txtPasswordSignUp, BunifuAnimatorNS.DecorationType.None)
        Me.txtPasswordSignUp.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPasswordSignUp.ForeColor = System.Drawing.Color.White
        Me.txtPasswordSignUp.isPassword = True
        Me.txtPasswordSignUp.Location = New System.Drawing.Point(6, 231)
        Me.txtPasswordSignUp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPasswordSignUp.Name = "txtPasswordSignUp"
        Me.txtPasswordSignUp.Size = New System.Drawing.Size(382, 34)
        Me.txtPasswordSignUp.TabIndex = 7
        Me.txtPasswordSignUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.tranSignUp.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignIn.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(3, 129)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(42, 16)
        Me.BunifuCustomLabel4.TabIndex = 6
        Me.BunifuCustomLabel4.Text = "Email"
        '
        'txtEmailSignUp
        '
        Me.txtEmailSignUp.BorderColorFocused = System.Drawing.Color.Silver
        Me.txtEmailSignUp.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtEmailSignUp.BorderColorMouseHover = System.Drawing.Color.Silver
        Me.txtEmailSignUp.BorderThickness = 1
        Me.txtEmailSignUp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tranSignUp.SetDecoration(Me.txtEmailSignUp, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignIn.SetDecoration(Me.txtEmailSignUp, BunifuAnimatorNS.DecorationType.None)
        Me.txtEmailSignUp.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtEmailSignUp.ForeColor = System.Drawing.Color.White
        Me.txtEmailSignUp.isPassword = False
        Me.txtEmailSignUp.Location = New System.Drawing.Point(6, 149)
        Me.txtEmailSignUp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmailSignUp.Name = "txtEmailSignUp"
        Me.txtEmailSignUp.Size = New System.Drawing.Size(382, 34)
        Me.txtEmailSignUp.TabIndex = 5
        Me.txtEmailSignUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.tranSignUp.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignIn.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(206, 52)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(73, 16)
        Me.BunifuCustomLabel3.TabIndex = 4
        Me.BunifuCustomLabel3.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.BorderColorFocused = System.Drawing.Color.Silver
        Me.txtLastName.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtLastName.BorderColorMouseHover = System.Drawing.Color.Silver
        Me.txtLastName.BorderThickness = 1
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tranSignUp.SetDecoration(Me.txtLastName, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignIn.SetDecoration(Me.txtLastName, BunifuAnimatorNS.DecorationType.None)
        Me.txtLastName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtLastName.ForeColor = System.Drawing.Color.White
        Me.txtLastName.isPassword = False
        Me.txtLastName.Location = New System.Drawing.Point(209, 72)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(179, 34)
        Me.txtLastName.TabIndex = 3
        Me.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.tranSignUp.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignIn.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(3, 52)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(73, 16)
        Me.BunifuCustomLabel2.TabIndex = 2
        Me.BunifuCustomLabel2.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderColorFocused = System.Drawing.Color.Silver
        Me.txtFirstName.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtFirstName.BorderColorMouseHover = System.Drawing.Color.Silver
        Me.txtFirstName.BorderThickness = 1
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tranSignUp.SetDecoration(Me.txtFirstName, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignIn.SetDecoration(Me.txtFirstName, BunifuAnimatorNS.DecorationType.None)
        Me.txtFirstName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtFirstName.ForeColor = System.Drawing.Color.White
        Me.txtFirstName.isPassword = False
        Me.txtFirstName.Location = New System.Drawing.Point(6, 72)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(195, 34)
        Me.txtFirstName.TabIndex = 1
        Me.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.tranSignUp.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignIn.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(114, 12)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(176, 25)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Sign Up For Free"
        '
        'PanelSignIn
        '
        Me.PanelSignIn.Controls.Add(Me.labelPassworSignIn)
        Me.PanelSignIn.Controls.Add(Me.labelEmailSignIn)
        Me.PanelSignIn.Controls.Add(Me.btnSignInLogin)
        Me.PanelSignIn.Controls.Add(Me.BunifuCustomLabel6)
        Me.PanelSignIn.Controls.Add(Me.txtPasswordSignIn)
        Me.PanelSignIn.Controls.Add(Me.BunifuCustomLabel7)
        Me.PanelSignIn.Controls.Add(Me.txtEmailSignIn)
        Me.PanelSignIn.Controls.Add(Me.BunifuCustomLabel10)
        Me.tranSignIn.SetDecoration(Me.PanelSignIn, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignUp.SetDecoration(Me.PanelSignIn, BunifuAnimatorNS.DecorationType.None)
        Me.PanelSignIn.Location = New System.Drawing.Point(483, 96)
        Me.PanelSignIn.Name = "PanelSignIn"
        Me.PanelSignIn.Size = New System.Drawing.Size(392, 347)
        Me.PanelSignIn.TabIndex = 3
        '
        'labelPassworSignIn
        '
        Me.labelPassworSignIn.AutoSize = True
        Me.tranSignUp.SetDecoration(Me.labelPassworSignIn, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignIn.SetDecoration(Me.labelPassworSignIn, BunifuAnimatorNS.DecorationType.None)
        Me.labelPassworSignIn.ForeColor = System.Drawing.Color.Red
        Me.labelPassworSignIn.Location = New System.Drawing.Point(6, 225)
        Me.labelPassworSignIn.Name = "labelPassworSignIn"
        Me.labelPassworSignIn.Size = New System.Drawing.Size(0, 13)
        Me.labelPassworSignIn.TabIndex = 11
        '
        'labelEmailSignIn
        '
        Me.labelEmailSignIn.AutoSize = True
        Me.tranSignUp.SetDecoration(Me.labelEmailSignIn, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignIn.SetDecoration(Me.labelEmailSignIn, BunifuAnimatorNS.DecorationType.None)
        Me.labelEmailSignIn.ForeColor = System.Drawing.Color.Red
        Me.labelEmailSignIn.Location = New System.Drawing.Point(3, 142)
        Me.labelEmailSignIn.Name = "labelEmailSignIn"
        Me.labelEmailSignIn.Size = New System.Drawing.Size(0, 13)
        Me.labelEmailSignIn.TabIndex = 10
        '
        'btnSignInLogin
        '
        Me.btnSignInLogin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSignInLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSignInLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSignInLogin.BorderRadius = 0
        Me.btnSignInLogin.ButtonText = "Sign In"
        Me.btnSignInLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranSignIn.SetDecoration(Me.btnSignInLogin, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignUp.SetDecoration(Me.btnSignInLogin, BunifuAnimatorNS.DecorationType.None)
        Me.btnSignInLogin.DisabledColor = System.Drawing.Color.Gray
        Me.btnSignInLogin.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSignInLogin.Iconimage = Nothing
        Me.btnSignInLogin.Iconimage_right = Nothing
        Me.btnSignInLogin.Iconimage_right_Selected = Nothing
        Me.btnSignInLogin.Iconimage_Selected = Nothing
        Me.btnSignInLogin.IconMarginLeft = 0
        Me.btnSignInLogin.IconMarginRight = 0
        Me.btnSignInLogin.IconRightVisible = True
        Me.btnSignInLogin.IconRightZoom = 0R
        Me.btnSignInLogin.IconVisible = True
        Me.btnSignInLogin.IconZoom = 90.0R
        Me.btnSignInLogin.IsTab = False
        Me.btnSignInLogin.Location = New System.Drawing.Point(6, 273)
        Me.btnSignInLogin.Name = "btnSignInLogin"
        Me.btnSignInLogin.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSignInLogin.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnSignInLogin.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSignInLogin.selected = False
        Me.btnSignInLogin.Size = New System.Drawing.Size(382, 39)
        Me.btnSignInLogin.TabIndex = 9
        Me.btnSignInLogin.Text = "Sign In"
        Me.btnSignInLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSignInLogin.Textcolor = System.Drawing.Color.White
        Me.btnSignInLogin.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.tranSignUp.SetDecoration(Me.BunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignIn.SetDecoration(Me.BunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(3, 159)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(68, 16)
        Me.BunifuCustomLabel6.TabIndex = 8
        Me.BunifuCustomLabel6.Text = "Password"
        '
        'txtPasswordSignIn
        '
        Me.txtPasswordSignIn.BorderColorFocused = System.Drawing.Color.Silver
        Me.txtPasswordSignIn.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtPasswordSignIn.BorderColorMouseHover = System.Drawing.Color.Silver
        Me.txtPasswordSignIn.BorderThickness = 1
        Me.txtPasswordSignIn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tranSignUp.SetDecoration(Me.txtPasswordSignIn, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignIn.SetDecoration(Me.txtPasswordSignIn, BunifuAnimatorNS.DecorationType.None)
        Me.txtPasswordSignIn.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPasswordSignIn.ForeColor = System.Drawing.Color.White
        Me.txtPasswordSignIn.isPassword = True
        Me.txtPasswordSignIn.Location = New System.Drawing.Point(6, 179)
        Me.txtPasswordSignIn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPasswordSignIn.Name = "txtPasswordSignIn"
        Me.txtPasswordSignIn.Size = New System.Drawing.Size(382, 34)
        Me.txtPasswordSignIn.TabIndex = 7
        Me.txtPasswordSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.tranSignUp.SetDecoration(Me.BunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignIn.SetDecoration(Me.BunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(3, 78)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(42, 16)
        Me.BunifuCustomLabel7.TabIndex = 6
        Me.BunifuCustomLabel7.Text = "Email"
        '
        'txtEmailSignIn
        '
        Me.txtEmailSignIn.BorderColorFocused = System.Drawing.Color.Silver
        Me.txtEmailSignIn.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtEmailSignIn.BorderColorMouseHover = System.Drawing.Color.Silver
        Me.txtEmailSignIn.BorderThickness = 1
        Me.txtEmailSignIn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tranSignUp.SetDecoration(Me.txtEmailSignIn, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignIn.SetDecoration(Me.txtEmailSignIn, BunifuAnimatorNS.DecorationType.None)
        Me.txtEmailSignIn.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtEmailSignIn.ForeColor = System.Drawing.Color.White
        Me.txtEmailSignIn.isPassword = False
        Me.txtEmailSignIn.Location = New System.Drawing.Point(6, 98)
        Me.txtEmailSignIn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmailSignIn.Name = "txtEmailSignIn"
        Me.txtEmailSignIn.Size = New System.Drawing.Size(382, 34)
        Me.txtEmailSignIn.TabIndex = 5
        Me.txtEmailSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.tranSignUp.SetDecoration(Me.BunifuCustomLabel10, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignIn.SetDecoration(Me.BunifuCustomLabel10, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(169, 12)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(78, 25)
        Me.BunifuCustomLabel10.TabIndex = 0
        Me.BunifuCustomLabel10.Text = "Sign In"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.tranSignIn.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignUp.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(433, 7)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(20, 20)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 4
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'tranSignUp
        '
        Me.tranSignUp.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide
        Me.tranSignUp.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.tranSignUp.DefaultAnimation = Animation2
        '
        'tranSignIn
        '
        Me.tranSignIn.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate
        Me.tranSignIn.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(30)
        Animation1.RotateCoeff = 0.5!
        Animation1.RotateLimit = 0.2!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.tranSignIn.DefaultAnimation = Animation1
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(467, 464)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.PanelSignIn)
        Me.Controls.Add(Me.PanelSignUp)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.btnSingIn)
        Me.tranSignUp.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tranSignIn.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "Login"
        Me.PanelSignUp.ResumeLayout(False)
        Me.PanelSignUp.PerformLayout()
        Me.PanelSignIn.ResumeLayout(False)
        Me.PanelSignIn.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PanelSignUp As Panel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtPasswordSignUp As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtEmailSignUp As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtLastName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtFirstName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnSignUp As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSingIn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PanelSignIn As Panel
    Friend WithEvents btnSignInLogin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtPasswordSignIn As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtEmailSignIn As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnSignUpLogin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents labelFirst As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents labelPasswordSignUp As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents labelEmailSignUp As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents labelLastName As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents labelPassworSignIn As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents labelEmailSignIn As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tranSignIn As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents tranSignUp As BunifuAnimatorNS.BunifuTransition
End Class
