<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menuform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menuform))
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation6 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation5 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation7 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation8 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation3 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation4 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation9 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation10 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnNhanVien = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnKhach = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnhome = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNhaCC = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnChucVu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnmenu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pcb1 = New System.Windows.Forms.PictureBox()
        Me.tranlogo = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tranpanel = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tranNhaCC = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.tranChucVu = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.tranKhachhang = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.tranNhanVien = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.btnTaiKhoan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnHoaDonBan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnHoaDonNhap = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.tranTaiKhoan = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.tranHDB = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.tranHDN = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Home1 = New WindowsApplication2.Home()
        Me.HoaDonBan1 = New WindowsApplication2.HoaDonBan()
        Me.HoaDonNhap1 = New WindowsApplication2.HoaDonNhap()
        Me.TaiKhoan1 = New WindowsApplication2.TaiKhoan()
        Me.NhanVien1 = New WindowsApplication2.NhanVien()
        Me.ChucVuForm1 = New WindowsApplication2.ChucVuForm()
        Me.KhachHangForm1 = New WindowsApplication2.KhachHangForm()
        Me.NhaCCform1 = New WindowsApplication2.NhaCCform()
        Me.tranHome = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.btnmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuImageButton2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranpanel.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHome.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 46)
        Me.Panel1.TabIndex = 0
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.tranHome.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.ErrorImage = Nothing
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(1129, 8)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(30, 30)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 3
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'PictureBox1
        '
        Me.tranKhachhang.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHome.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.tranTaiKhoan.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHome.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(77, 15)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(125, 24)
        Me.BunifuCustomLabel1.TabIndex = 2
        Me.BunifuCustomLabel1.Text = "Shop Parada"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.tranHome.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.ErrorImage = Nothing
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(1165, 8)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(30, 30)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 1
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.Panel4)
        Me.pnlMenu.Controls.Add(Me.btnmenu)
        Me.pnlMenu.Controls.Add(Me.pcb1)
        Me.tranpanel.SetDecoration(Me.pnlMenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranHome.SetDecoration(Me.pnlMenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.pnlMenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.pnlMenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.pnlMenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.pnlMenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.pnlMenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.pnlMenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.pnlMenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.pnlMenu, BunifuAnimatorNS.DecorationType.None)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 46)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(237, 694)
        Me.pnlMenu.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnHoaDonNhap)
        Me.Panel4.Controls.Add(Me.btnHoaDonBan)
        Me.Panel4.Controls.Add(Me.btnTaiKhoan)
        Me.Panel4.Controls.Add(Me.btnNhanVien)
        Me.Panel4.Controls.Add(Me.btnKhach)
        Me.Panel4.Controls.Add(Me.btnhome)
        Me.Panel4.Controls.Add(Me.btnNhaCC)
        Me.Panel4.Controls.Add(Me.btnChucVu)
        Me.tranpanel.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.tranHome.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.Panel4.Location = New System.Drawing.Point(0, 126)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(237, 500)
        Me.Panel4.TabIndex = 4
        '
        'btnNhanVien
        '
        Me.btnNhanVien.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnNhanVien.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNhanVien.BorderRadius = 0
        Me.btnNhanVien.ButtonText = "Salesman"
        Me.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranHome.SetDecoration(Me.btnNhanVien, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.btnNhanVien, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.btnNhanVien, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.btnNhanVien, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.btnNhanVien, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.btnNhanVien, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.btnNhanVien, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.btnNhanVien, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.btnNhanVien, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.btnNhanVien, BunifuAnimatorNS.DecorationType.None)
        Me.btnNhanVien.DisabledColor = System.Drawing.Color.Gray
        Me.btnNhanVien.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNhanVien.Iconimage = CType(resources.GetObject("btnNhanVien.Iconimage"), System.Drawing.Image)
        Me.btnNhanVien.Iconimage_right = Nothing
        Me.btnNhanVien.Iconimage_right_Selected = Nothing
        Me.btnNhanVien.Iconimage_Selected = Nothing
        Me.btnNhanVien.IconMarginLeft = 0
        Me.btnNhanVien.IconMarginRight = 0
        Me.btnNhanVien.IconRightVisible = True
        Me.btnNhanVien.IconRightZoom = 0R
        Me.btnNhanVien.IconVisible = True
        Me.btnNhanVien.IconZoom = 50.0R
        Me.btnNhanVien.IsTab = False
        Me.btnNhanVien.Location = New System.Drawing.Point(13, 210)
        Me.btnNhanVien.Name = "btnNhanVien"
        Me.btnNhanVien.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNhanVien.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNhanVien.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnNhanVien.selected = False
        Me.btnNhanVien.Size = New System.Drawing.Size(218, 36)
        Me.btnNhanVien.TabIndex = 7
        Me.btnNhanVien.Text = "Salesman"
        Me.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNhanVien.Textcolor = System.Drawing.Color.White
        Me.btnNhanVien.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnKhach
        '
        Me.btnKhach.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnKhach.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnKhach.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnKhach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnKhach.BorderRadius = 0
        Me.btnKhach.ButtonText = "Customer"
        Me.btnKhach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranHome.SetDecoration(Me.btnKhach, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.btnKhach, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.btnKhach, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.btnKhach, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.btnKhach, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.btnKhach, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.btnKhach, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.btnKhach, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.btnKhach, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.btnKhach, BunifuAnimatorNS.DecorationType.None)
        Me.btnKhach.DisabledColor = System.Drawing.Color.Gray
        Me.btnKhach.Iconcolor = System.Drawing.Color.Transparent
        Me.btnKhach.Iconimage = CType(resources.GetObject("btnKhach.Iconimage"), System.Drawing.Image)
        Me.btnKhach.Iconimage_right = Nothing
        Me.btnKhach.Iconimage_right_Selected = Nothing
        Me.btnKhach.Iconimage_Selected = Nothing
        Me.btnKhach.IconMarginLeft = 0
        Me.btnKhach.IconMarginRight = 0
        Me.btnKhach.IconRightVisible = True
        Me.btnKhach.IconRightZoom = 0R
        Me.btnKhach.IconVisible = True
        Me.btnKhach.IconZoom = 50.0R
        Me.btnKhach.IsTab = False
        Me.btnKhach.Location = New System.Drawing.Point(13, 51)
        Me.btnKhach.Name = "btnKhach"
        Me.btnKhach.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnKhach.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnKhach.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnKhach.selected = False
        Me.btnKhach.Size = New System.Drawing.Size(218, 36)
        Me.btnKhach.TabIndex = 6
        Me.btnKhach.Text = "Customer"
        Me.btnKhach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnKhach.Textcolor = System.Drawing.Color.White
        Me.btnKhach.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnhome
        '
        Me.btnhome.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnhome.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnhome.BorderRadius = 0
        Me.btnhome.ButtonText = "Home"
        Me.btnhome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranHome.SetDecoration(Me.btnhome, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.btnhome, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.btnhome, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.btnhome, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.btnhome, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.btnhome, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.btnhome, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.btnhome, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.btnhome, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.btnhome, BunifuAnimatorNS.DecorationType.None)
        Me.btnhome.DisabledColor = System.Drawing.Color.Gray
        Me.btnhome.Iconcolor = System.Drawing.Color.Transparent
        Me.btnhome.Iconimage = CType(resources.GetObject("btnhome.Iconimage"), System.Drawing.Image)
        Me.btnhome.Iconimage_right = Nothing
        Me.btnhome.Iconimage_right_Selected = Nothing
        Me.btnhome.Iconimage_Selected = Nothing
        Me.btnhome.IconMarginLeft = 0
        Me.btnhome.IconMarginRight = 0
        Me.btnhome.IconRightVisible = True
        Me.btnhome.IconRightZoom = 0R
        Me.btnhome.IconVisible = True
        Me.btnhome.IconZoom = 50.0R
        Me.btnhome.IsTab = False
        Me.btnhome.Location = New System.Drawing.Point(13, 3)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnhome.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnhome.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnhome.selected = False
        Me.btnhome.Size = New System.Drawing.Size(218, 33)
        Me.btnhome.TabIndex = 2
        Me.btnhome.Text = "Home"
        Me.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnhome.Textcolor = System.Drawing.Color.Silver
        Me.btnhome.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnNhaCC
        '
        Me.btnNhaCC.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnNhaCC.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNhaCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNhaCC.BorderRadius = 0
        Me.btnNhaCC.ButtonText = "Supplier"
        Me.btnNhaCC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranHome.SetDecoration(Me.btnNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.btnNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.btnNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.btnNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.btnNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.btnNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.btnNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.btnNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.btnNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.btnNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.btnNhaCC.DisabledColor = System.Drawing.Color.Gray
        Me.btnNhaCC.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNhaCC.Iconimage = CType(resources.GetObject("btnNhaCC.Iconimage"), System.Drawing.Image)
        Me.btnNhaCC.Iconimage_right = Nothing
        Me.btnNhaCC.Iconimage_right_Selected = Nothing
        Me.btnNhaCC.Iconimage_Selected = Nothing
        Me.btnNhaCC.IconMarginLeft = 0
        Me.btnNhaCC.IconMarginRight = 0
        Me.btnNhaCC.IconRightVisible = True
        Me.btnNhaCC.IconRightZoom = 0R
        Me.btnNhaCC.IconVisible = True
        Me.btnNhaCC.IconZoom = 40.0R
        Me.btnNhaCC.IsTab = False
        Me.btnNhaCC.Location = New System.Drawing.Point(13, 104)
        Me.btnNhaCC.Name = "btnNhaCC"
        Me.btnNhaCC.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNhaCC.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNhaCC.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnNhaCC.selected = False
        Me.btnNhaCC.Size = New System.Drawing.Size(218, 35)
        Me.btnNhaCC.TabIndex = 4
        Me.btnNhaCC.Text = "Supplier"
        Me.btnNhaCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnNhaCC.Textcolor = System.Drawing.Color.White
        Me.btnNhaCC.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnChucVu
        '
        Me.btnChucVu.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnChucVu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnChucVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChucVu.BorderRadius = 0
        Me.btnChucVu.ButtonText = "Regency"
        Me.btnChucVu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranHome.SetDecoration(Me.btnChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.btnChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.btnChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.btnChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.btnChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.btnChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.btnChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.btnChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.btnChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.btnChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.btnChucVu.DisabledColor = System.Drawing.Color.Gray
        Me.btnChucVu.Iconcolor = System.Drawing.Color.Transparent
        Me.btnChucVu.Iconimage = CType(resources.GetObject("btnChucVu.Iconimage"), System.Drawing.Image)
        Me.btnChucVu.Iconimage_right = Nothing
        Me.btnChucVu.Iconimage_right_Selected = Nothing
        Me.btnChucVu.Iconimage_Selected = Nothing
        Me.btnChucVu.IconMarginLeft = 0
        Me.btnChucVu.IconMarginRight = 0
        Me.btnChucVu.IconRightVisible = True
        Me.btnChucVu.IconRightZoom = 0R
        Me.btnChucVu.IconVisible = True
        Me.btnChucVu.IconZoom = 50.0R
        Me.btnChucVu.IsTab = False
        Me.btnChucVu.Location = New System.Drawing.Point(13, 155)
        Me.btnChucVu.Name = "btnChucVu"
        Me.btnChucVu.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnChucVu.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnChucVu.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnChucVu.selected = False
        Me.btnChucVu.Size = New System.Drawing.Size(218, 36)
        Me.btnChucVu.TabIndex = 5
        Me.btnChucVu.Text = "Regency"
        Me.btnChucVu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnChucVu.Textcolor = System.Drawing.Color.White
        Me.btnChucVu.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnmenu
        '
        Me.btnmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnmenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranHome.SetDecoration(Me.btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.btnmenu.ErrorImage = Nothing
        Me.btnmenu.Image = CType(resources.GetObject("btnmenu.Image"), System.Drawing.Image)
        Me.btnmenu.ImageActive = Nothing
        Me.btnmenu.InitialImage = Nothing
        Me.btnmenu.Location = New System.Drawing.Point(167, 60)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(25, 25)
        Me.btnmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmenu.TabIndex = 3
        Me.btnmenu.TabStop = False
        Me.btnmenu.Zoom = 10
        '
        'pcb1
        '
        Me.tranKhachhang.SetDecoration(Me.pcb1, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.pcb1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.pcb1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHome.SetDecoration(Me.pcb1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.pcb1, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.pcb1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.pcb1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.pcb1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.pcb1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.pcb1, BunifuAnimatorNS.DecorationType.None)
        Me.pcb1.Image = CType(resources.GetObject("pcb1.Image"), System.Drawing.Image)
        Me.pcb1.Location = New System.Drawing.Point(38, 49)
        Me.pcb1.Name = "pcb1"
        Me.pcb1.Size = New System.Drawing.Size(104, 42)
        Me.pcb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcb1.TabIndex = 2
        Me.pcb1.TabStop = False
        '
        'tranlogo
        '
        Me.tranlogo.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate
        Me.tranlogo.Cursor = Nothing
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
        Me.tranlogo.DefaultAnimation = Animation1
        Me.tranlogo.TimeStep = 0.01!
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.tranpanel.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.tranHome.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(237, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(963, 694)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Home1)
        Me.Panel3.Controls.Add(Me.HoaDonBan1)
        Me.Panel3.Controls.Add(Me.HoaDonNhap1)
        Me.Panel3.Controls.Add(Me.TaiKhoan1)
        Me.Panel3.Controls.Add(Me.NhanVien1)
        Me.Panel3.Controls.Add(Me.ChucVuForm1)
        Me.Panel3.Controls.Add(Me.KhachHangForm1)
        Me.Panel3.Controls.Add(Me.NhaCCform1)
        Me.tranpanel.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.tranHome.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.Panel3.Location = New System.Drawing.Point(46, 26)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(887, 676)
        Me.Panel3.TabIndex = 0
        '
        'tranpanel
        '
        Me.tranpanel.AnimationType = BunifuAnimatorNS.AnimationType.Leaf
        Me.tranpanel.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 1.0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.tranpanel.DefaultAnimation = Animation2
        Me.tranpanel.TimeStep = 0.01!
        '
        'tranNhaCC
        '
        Me.tranNhaCC.AnimationType = BunifuAnimatorNS.AnimationType.Leaf
        Me.tranNhaCC.Cursor = Nothing
        Animation6.AnimateOnlyDifferences = True
        Animation6.BlindCoeff = CType(resources.GetObject("Animation6.BlindCoeff"), System.Drawing.PointF)
        Animation6.LeafCoeff = 1.0!
        Animation6.MaxTime = 1.0!
        Animation6.MinTime = 0!
        Animation6.MosaicCoeff = CType(resources.GetObject("Animation6.MosaicCoeff"), System.Drawing.PointF)
        Animation6.MosaicShift = CType(resources.GetObject("Animation6.MosaicShift"), System.Drawing.PointF)
        Animation6.MosaicSize = 0
        Animation6.Padding = New System.Windows.Forms.Padding(0)
        Animation6.RotateCoeff = 0!
        Animation6.RotateLimit = 0!
        Animation6.ScaleCoeff = CType(resources.GetObject("Animation6.ScaleCoeff"), System.Drawing.PointF)
        Animation6.SlideCoeff = CType(resources.GetObject("Animation6.SlideCoeff"), System.Drawing.PointF)
        Animation6.TimeCoeff = 0!
        Animation6.TransparencyCoeff = 0!
        Me.tranNhaCC.DefaultAnimation = Animation6
        '
        'tranChucVu
        '
        Me.tranChucVu.AnimationType = BunifuAnimatorNS.AnimationType.Custom
        Me.tranChucVu.Cursor = Nothing
        Animation5.AnimateOnlyDifferences = True
        Animation5.BlindCoeff = CType(resources.GetObject("Animation5.BlindCoeff"), System.Drawing.PointF)
        Animation5.LeafCoeff = 0!
        Animation5.MaxTime = 1.0!
        Animation5.MinTime = 0!
        Animation5.MosaicCoeff = CType(resources.GetObject("Animation5.MosaicCoeff"), System.Drawing.PointF)
        Animation5.MosaicShift = CType(resources.GetObject("Animation5.MosaicShift"), System.Drawing.PointF)
        Animation5.MosaicSize = 0
        Animation5.Padding = New System.Windows.Forms.Padding(0)
        Animation5.RotateCoeff = 0!
        Animation5.RotateLimit = 0!
        Animation5.ScaleCoeff = CType(resources.GetObject("Animation5.ScaleCoeff"), System.Drawing.PointF)
        Animation5.SlideCoeff = CType(resources.GetObject("Animation5.SlideCoeff"), System.Drawing.PointF)
        Animation5.TimeCoeff = 0!
        Animation5.TransparencyCoeff = 0!
        Me.tranChucVu.DefaultAnimation = Animation5
        '
        'tranKhachhang
        '
        Me.tranKhachhang.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.tranKhachhang.Cursor = Nothing
        Animation7.AnimateOnlyDifferences = True
        Animation7.BlindCoeff = CType(resources.GetObject("Animation7.BlindCoeff"), System.Drawing.PointF)
        Animation7.LeafCoeff = 0!
        Animation7.MaxTime = 1.0!
        Animation7.MinTime = 0!
        Animation7.MosaicCoeff = CType(resources.GetObject("Animation7.MosaicCoeff"), System.Drawing.PointF)
        Animation7.MosaicShift = CType(resources.GetObject("Animation7.MosaicShift"), System.Drawing.PointF)
        Animation7.MosaicSize = 0
        Animation7.Padding = New System.Windows.Forms.Padding(0)
        Animation7.RotateCoeff = 0!
        Animation7.RotateLimit = 0!
        Animation7.ScaleCoeff = CType(resources.GetObject("Animation7.ScaleCoeff"), System.Drawing.PointF)
        Animation7.SlideCoeff = CType(resources.GetObject("Animation7.SlideCoeff"), System.Drawing.PointF)
        Animation7.TimeCoeff = 0!
        Animation7.TransparencyCoeff = 0!
        Me.tranKhachhang.DefaultAnimation = Animation7
        '
        'tranNhanVien
        '
        Me.tranNhanVien.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.tranNhanVien.Cursor = Nothing
        Animation8.AnimateOnlyDifferences = True
        Animation8.BlindCoeff = CType(resources.GetObject("Animation8.BlindCoeff"), System.Drawing.PointF)
        Animation8.LeafCoeff = 0!
        Animation8.MaxTime = 1.0!
        Animation8.MinTime = 0!
        Animation8.MosaicCoeff = CType(resources.GetObject("Animation8.MosaicCoeff"), System.Drawing.PointF)
        Animation8.MosaicShift = CType(resources.GetObject("Animation8.MosaicShift"), System.Drawing.PointF)
        Animation8.MosaicSize = 0
        Animation8.Padding = New System.Windows.Forms.Padding(0)
        Animation8.RotateCoeff = 0!
        Animation8.RotateLimit = 0!
        Animation8.ScaleCoeff = CType(resources.GetObject("Animation8.ScaleCoeff"), System.Drawing.PointF)
        Animation8.SlideCoeff = CType(resources.GetObject("Animation8.SlideCoeff"), System.Drawing.PointF)
        Animation8.TimeCoeff = 0!
        Animation8.TransparencyCoeff = 0!
        Me.tranNhanVien.DefaultAnimation = Animation8
        '
        'btnTaiKhoan
        '
        Me.btnTaiKhoan.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnTaiKhoan.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnTaiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTaiKhoan.BorderRadius = 0
        Me.btnTaiKhoan.ButtonText = "Account"
        Me.btnTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranHome.SetDecoration(Me.btnTaiKhoan, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.btnTaiKhoan, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.btnTaiKhoan, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.btnTaiKhoan, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.btnTaiKhoan, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.btnTaiKhoan, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.btnTaiKhoan, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.btnTaiKhoan, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.btnTaiKhoan, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.btnTaiKhoan, BunifuAnimatorNS.DecorationType.None)
        Me.btnTaiKhoan.DisabledColor = System.Drawing.Color.Gray
        Me.btnTaiKhoan.Iconcolor = System.Drawing.Color.Transparent
        Me.btnTaiKhoan.Iconimage = CType(resources.GetObject("btnTaiKhoan.Iconimage"), System.Drawing.Image)
        Me.btnTaiKhoan.Iconimage_right = Nothing
        Me.btnTaiKhoan.Iconimage_right_Selected = Nothing
        Me.btnTaiKhoan.Iconimage_Selected = Nothing
        Me.btnTaiKhoan.IconMarginLeft = 0
        Me.btnTaiKhoan.IconMarginRight = 0
        Me.btnTaiKhoan.IconRightVisible = True
        Me.btnTaiKhoan.IconRightZoom = 0R
        Me.btnTaiKhoan.IconVisible = True
        Me.btnTaiKhoan.IconZoom = 50.0R
        Me.btnTaiKhoan.IsTab = False
        Me.btnTaiKhoan.Location = New System.Drawing.Point(13, 268)
        Me.btnTaiKhoan.Name = "btnTaiKhoan"
        Me.btnTaiKhoan.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnTaiKhoan.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnTaiKhoan.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnTaiKhoan.selected = False
        Me.btnTaiKhoan.Size = New System.Drawing.Size(218, 36)
        Me.btnTaiKhoan.TabIndex = 8
        Me.btnTaiKhoan.Text = "Account"
        Me.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnTaiKhoan.Textcolor = System.Drawing.Color.White
        Me.btnTaiKhoan.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnHoaDonBan
        '
        Me.btnHoaDonBan.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnHoaDonBan.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHoaDonBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHoaDonBan.BorderRadius = 0
        Me.btnHoaDonBan.ButtonText = "Bill of sale"
        Me.btnHoaDonBan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranHome.SetDecoration(Me.btnHoaDonBan, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.btnHoaDonBan, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.btnHoaDonBan, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.btnHoaDonBan, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.btnHoaDonBan, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.btnHoaDonBan, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.btnHoaDonBan, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.btnHoaDonBan, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.btnHoaDonBan, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.btnHoaDonBan, BunifuAnimatorNS.DecorationType.None)
        Me.btnHoaDonBan.DisabledColor = System.Drawing.Color.Gray
        Me.btnHoaDonBan.Iconcolor = System.Drawing.Color.Transparent
        Me.btnHoaDonBan.Iconimage = CType(resources.GetObject("btnHoaDonBan.Iconimage"), System.Drawing.Image)
        Me.btnHoaDonBan.Iconimage_right = Nothing
        Me.btnHoaDonBan.Iconimage_right_Selected = Nothing
        Me.btnHoaDonBan.Iconimage_Selected = Nothing
        Me.btnHoaDonBan.IconMarginLeft = 0
        Me.btnHoaDonBan.IconMarginRight = 0
        Me.btnHoaDonBan.IconRightVisible = True
        Me.btnHoaDonBan.IconRightZoom = 0R
        Me.btnHoaDonBan.IconVisible = True
        Me.btnHoaDonBan.IconZoom = 50.0R
        Me.btnHoaDonBan.IsTab = False
        Me.btnHoaDonBan.Location = New System.Drawing.Point(13, 327)
        Me.btnHoaDonBan.Name = "btnHoaDonBan"
        Me.btnHoaDonBan.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHoaDonBan.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHoaDonBan.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnHoaDonBan.selected = False
        Me.btnHoaDonBan.Size = New System.Drawing.Size(218, 36)
        Me.btnHoaDonBan.TabIndex = 9
        Me.btnHoaDonBan.Text = "Bill of sale"
        Me.btnHoaDonBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnHoaDonBan.Textcolor = System.Drawing.Color.White
        Me.btnHoaDonBan.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnHoaDonNhap
        '
        Me.btnHoaDonNhap.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnHoaDonNhap.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHoaDonNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHoaDonNhap.BorderRadius = 0
        Me.btnHoaDonNhap.ButtonText = "Invoice input"
        Me.btnHoaDonNhap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranHome.SetDecoration(Me.btnHoaDonNhap, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.btnHoaDonNhap, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.btnHoaDonNhap, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.btnHoaDonNhap, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.btnHoaDonNhap, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.btnHoaDonNhap, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.btnHoaDonNhap, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.btnHoaDonNhap, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.btnHoaDonNhap, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.btnHoaDonNhap, BunifuAnimatorNS.DecorationType.None)
        Me.btnHoaDonNhap.DisabledColor = System.Drawing.Color.Gray
        Me.btnHoaDonNhap.Iconcolor = System.Drawing.Color.Transparent
        Me.btnHoaDonNhap.Iconimage = CType(resources.GetObject("btnHoaDonNhap.Iconimage"), System.Drawing.Image)
        Me.btnHoaDonNhap.Iconimage_right = Nothing
        Me.btnHoaDonNhap.Iconimage_right_Selected = Nothing
        Me.btnHoaDonNhap.Iconimage_Selected = Nothing
        Me.btnHoaDonNhap.IconMarginLeft = 0
        Me.btnHoaDonNhap.IconMarginRight = 0
        Me.btnHoaDonNhap.IconRightVisible = True
        Me.btnHoaDonNhap.IconRightZoom = 0R
        Me.btnHoaDonNhap.IconVisible = True
        Me.btnHoaDonNhap.IconZoom = 50.0R
        Me.btnHoaDonNhap.IsTab = False
        Me.btnHoaDonNhap.Location = New System.Drawing.Point(12, 385)
        Me.btnHoaDonNhap.Name = "btnHoaDonNhap"
        Me.btnHoaDonNhap.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHoaDonNhap.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHoaDonNhap.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnHoaDonNhap.selected = False
        Me.btnHoaDonNhap.Size = New System.Drawing.Size(218, 36)
        Me.btnHoaDonNhap.TabIndex = 10
        Me.btnHoaDonNhap.Text = "Invoice input"
        Me.btnHoaDonNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnHoaDonNhap.Textcolor = System.Drawing.Color.White
        Me.btnHoaDonNhap.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tranTaiKhoan
        '
        Me.tranTaiKhoan.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.tranTaiKhoan.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 0!
        Me.tranTaiKhoan.DefaultAnimation = Animation3
        '
        'tranHDB
        '
        Me.tranHDB.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.tranHDB.Cursor = Nothing
        Animation4.AnimateOnlyDifferences = True
        Animation4.BlindCoeff = CType(resources.GetObject("Animation4.BlindCoeff"), System.Drawing.PointF)
        Animation4.LeafCoeff = 0!
        Animation4.MaxTime = 1.0!
        Animation4.MinTime = 0!
        Animation4.MosaicCoeff = CType(resources.GetObject("Animation4.MosaicCoeff"), System.Drawing.PointF)
        Animation4.MosaicShift = CType(resources.GetObject("Animation4.MosaicShift"), System.Drawing.PointF)
        Animation4.MosaicSize = 0
        Animation4.Padding = New System.Windows.Forms.Padding(0)
        Animation4.RotateCoeff = 0!
        Animation4.RotateLimit = 0!
        Animation4.ScaleCoeff = CType(resources.GetObject("Animation4.ScaleCoeff"), System.Drawing.PointF)
        Animation4.SlideCoeff = CType(resources.GetObject("Animation4.SlideCoeff"), System.Drawing.PointF)
        Animation4.TimeCoeff = 0!
        Animation4.TransparencyCoeff = 0!
        Me.tranHDB.DefaultAnimation = Animation4
        '
        'tranHDN
        '
        Me.tranHDN.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.tranHDN.Cursor = Nothing
        Animation9.AnimateOnlyDifferences = True
        Animation9.BlindCoeff = CType(resources.GetObject("Animation9.BlindCoeff"), System.Drawing.PointF)
        Animation9.LeafCoeff = 0!
        Animation9.MaxTime = 1.0!
        Animation9.MinTime = 0!
        Animation9.MosaicCoeff = CType(resources.GetObject("Animation9.MosaicCoeff"), System.Drawing.PointF)
        Animation9.MosaicShift = CType(resources.GetObject("Animation9.MosaicShift"), System.Drawing.PointF)
        Animation9.MosaicSize = 0
        Animation9.Padding = New System.Windows.Forms.Padding(0)
        Animation9.RotateCoeff = 0!
        Animation9.RotateLimit = 0!
        Animation9.ScaleCoeff = CType(resources.GetObject("Animation9.ScaleCoeff"), System.Drawing.PointF)
        Animation9.SlideCoeff = CType(resources.GetObject("Animation9.SlideCoeff"), System.Drawing.PointF)
        Animation9.TimeCoeff = 0!
        Animation9.TransparencyCoeff = 0!
        Me.tranHDN.DefaultAnimation = Animation9
        '
        'Home1
        '
        Me.tranlogo.SetDecoration(Me.Home1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.Home1, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.Home1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.Home1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.Home1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.Home1, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.Home1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.Home1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.Home1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHome.SetDecoration(Me.Home1, BunifuAnimatorNS.DecorationType.None)
        Me.Home1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Home1.Location = New System.Drawing.Point(0, 0)
        Me.Home1.Name = "Home1"
        Me.Home1.Size = New System.Drawing.Size(887, 676)
        Me.Home1.TabIndex = 8
        '
        'HoaDonBan1
        '
        Me.tranlogo.SetDecoration(Me.HoaDonBan1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.HoaDonBan1, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.HoaDonBan1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.HoaDonBan1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.HoaDonBan1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.HoaDonBan1, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.HoaDonBan1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.HoaDonBan1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.HoaDonBan1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHome.SetDecoration(Me.HoaDonBan1, BunifuAnimatorNS.DecorationType.None)
        Me.HoaDonBan1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HoaDonBan1.Location = New System.Drawing.Point(0, 0)
        Me.HoaDonBan1.Name = "HoaDonBan1"
        Me.HoaDonBan1.Size = New System.Drawing.Size(887, 676)
        Me.HoaDonBan1.TabIndex = 7
        '
        'HoaDonNhap1
        '
        Me.tranlogo.SetDecoration(Me.HoaDonNhap1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.HoaDonNhap1, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.HoaDonNhap1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.HoaDonNhap1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.HoaDonNhap1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.HoaDonNhap1, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.HoaDonNhap1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.HoaDonNhap1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.HoaDonNhap1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHome.SetDecoration(Me.HoaDonNhap1, BunifuAnimatorNS.DecorationType.None)
        Me.HoaDonNhap1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HoaDonNhap1.Location = New System.Drawing.Point(0, 0)
        Me.HoaDonNhap1.Name = "HoaDonNhap1"
        Me.HoaDonNhap1.Size = New System.Drawing.Size(887, 676)
        Me.HoaDonNhap1.TabIndex = 6
        '
        'TaiKhoan1
        '
        Me.TaiKhoan1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.tranlogo.SetDecoration(Me.TaiKhoan1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.TaiKhoan1, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.TaiKhoan1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.TaiKhoan1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.TaiKhoan1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.TaiKhoan1, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.TaiKhoan1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.TaiKhoan1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.TaiKhoan1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHome.SetDecoration(Me.TaiKhoan1, BunifuAnimatorNS.DecorationType.None)
        Me.TaiKhoan1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TaiKhoan1.Location = New System.Drawing.Point(0, 0)
        Me.TaiKhoan1.Name = "TaiKhoan1"
        Me.TaiKhoan1.Size = New System.Drawing.Size(887, 676)
        Me.TaiKhoan1.TabIndex = 5
        '
        'NhanVien1
        '
        Me.NhanVien1.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.tranlogo.SetDecoration(Me.NhanVien1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.NhanVien1, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.NhanVien1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.NhanVien1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.NhanVien1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.NhanVien1, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.NhanVien1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.NhanVien1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.NhanVien1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHome.SetDecoration(Me.NhanVien1, BunifuAnimatorNS.DecorationType.None)
        Me.NhanVien1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NhanVien1.Location = New System.Drawing.Point(0, 0)
        Me.NhanVien1.Name = "NhanVien1"
        Me.NhanVien1.Size = New System.Drawing.Size(887, 676)
        Me.NhanVien1.TabIndex = 4
        Me.NhanVien1.Visible = False
        '
        'ChucVuForm1
        '
        Me.ChucVuForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.tranlogo.SetDecoration(Me.ChucVuForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.ChucVuForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.ChucVuForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.ChucVuForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.ChucVuForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.ChucVuForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.ChucVuForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.ChucVuForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.ChucVuForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHome.SetDecoration(Me.ChucVuForm1, BunifuAnimatorNS.DecorationType.None)
        Me.ChucVuForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChucVuForm1.Location = New System.Drawing.Point(0, 0)
        Me.ChucVuForm1.Name = "ChucVuForm1"
        Me.ChucVuForm1.Size = New System.Drawing.Size(887, 676)
        Me.ChucVuForm1.TabIndex = 3
        '
        'KhachHangForm1
        '
        Me.KhachHangForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.tranlogo.SetDecoration(Me.KhachHangForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.KhachHangForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.KhachHangForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.KhachHangForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.KhachHangForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.KhachHangForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.KhachHangForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.KhachHangForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.KhachHangForm1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHome.SetDecoration(Me.KhachHangForm1, BunifuAnimatorNS.DecorationType.None)
        Me.KhachHangForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KhachHangForm1.Location = New System.Drawing.Point(0, 0)
        Me.KhachHangForm1.Name = "KhachHangForm1"
        Me.KhachHangForm1.Size = New System.Drawing.Size(887, 676)
        Me.KhachHangForm1.TabIndex = 2
        Me.KhachHangForm1.Visible = False
        '
        'NhaCCform1
        '
        Me.tranlogo.SetDecoration(Me.NhaCCform1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.NhaCCform1, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me.NhaCCform1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDB.SetDecoration(Me.NhaCCform1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.NhaCCform1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.NhaCCform1, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me.NhaCCform1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me.NhaCCform1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me.NhaCCform1, BunifuAnimatorNS.DecorationType.None)
        Me.tranHome.SetDecoration(Me.NhaCCform1, BunifuAnimatorNS.DecorationType.None)
        Me.NhaCCform1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NhaCCform1.Location = New System.Drawing.Point(0, 0)
        Me.NhaCCform1.Name = "NhaCCform1"
        Me.NhaCCform1.Size = New System.Drawing.Size(887, 676)
        Me.NhaCCform1.TabIndex = 1
        Me.NhaCCform1.Visible = False
        '
        'tranHome
        '
        Me.tranHome.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.tranHome.Cursor = Nothing
        Animation10.AnimateOnlyDifferences = True
        Animation10.BlindCoeff = CType(resources.GetObject("Animation10.BlindCoeff"), System.Drawing.PointF)
        Animation10.LeafCoeff = 0!
        Animation10.MaxTime = 1.0!
        Animation10.MinTime = 0!
        Animation10.MosaicCoeff = CType(resources.GetObject("Animation10.MosaicCoeff"), System.Drawing.PointF)
        Animation10.MosaicShift = CType(resources.GetObject("Animation10.MosaicShift"), System.Drawing.PointF)
        Animation10.MosaicSize = 0
        Animation10.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation10.RotateCoeff = 0!
        Animation10.RotateLimit = 0!
        Animation10.ScaleCoeff = CType(resources.GetObject("Animation10.ScaleCoeff"), System.Drawing.PointF)
        Animation10.SlideCoeff = CType(resources.GetObject("Animation10.SlideCoeff"), System.Drawing.PointF)
        Animation10.TimeCoeff = 0!
        Animation10.TransparencyCoeff = 0!
        Me.tranHome.DefaultAnimation = Animation10
        '
        'Menuform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 740)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.Panel1)
        Me.tranHDB.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhanVien.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tranTaiKhoan.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tranHome.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tranHDN.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tranKhachhang.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menuform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menuform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.btnmenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnKhach As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnhome As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnNhaCC As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnChucVu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnmenu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pcb1 As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents tranlogo As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents tranpanel As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tranChucVu As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents tranNhaCC As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tranKhachhang As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Panel3 As Panel
    Friend WithEvents KhachHangForm1 As KhachHangForm
    Friend WithEvents NhaCCform1 As NhaCCform
    Friend WithEvents ChucVuForm1 As ChucVuForm
    Friend WithEvents btnNhanVien As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents NhanVien1 As NhanVien
    Friend WithEvents tranNhanVien As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents btnHoaDonNhap As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnHoaDonBan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnTaiKhoan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents HoaDonBan1 As HoaDonBan
    Friend WithEvents tranHDB As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents tranHDN As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents tranTaiKhoan As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents HoaDonNhap1 As HoaDonNhap
    Friend WithEvents TaiKhoan1 As TaiKhoan
    Friend WithEvents Home1 As Home
    Friend WithEvents tranHome As BunifuAnimatorNS.BunifuTransition
End Class
