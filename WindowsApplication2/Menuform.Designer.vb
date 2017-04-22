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
        Dim Animation7 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation6 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation8 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation5 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menuform))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PanelNhaCC = New System.Windows.Forms.Panel()
        Me.dgvChucVu = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnAdd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtQuyenHan = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtTenCV = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtMaChucVu = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnKhach = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnhome = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNhaCC = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnChucVu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnmenu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pcb1 = New System.Windows.Forms.PictureBox()
        Me.tranlogo = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.tranpanel = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tranNhaCC = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.tranChucVu = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNhaCC.SuspendLayout()
        CType(Me.dgvChucVu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.btnmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.PanelNhaCC)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.tranChucVu.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 46)
        Me.Panel1.TabIndex = 0
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.tranChucVu.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
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
        'PanelNhaCC
        '
        Me.PanelNhaCC.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelNhaCC.Controls.Add(Me.dgvChucVu)
        Me.PanelNhaCC.Controls.Add(Me.Panel6)
        Me.PanelNhaCC.Controls.Add(Me.Panel7)
        Me.tranChucVu.SetDecoration(Me.PanelNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.PanelNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.PanelNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.PanelNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.PanelNhaCC.Location = New System.Drawing.Point(684, 15)
        Me.PanelNhaCC.Name = "PanelNhaCC"
        Me.PanelNhaCC.Size = New System.Drawing.Size(963, 734)
        Me.PanelNhaCC.TabIndex = 5
        '
        'dgvChucVu
        '
        Me.dgvChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvChucVu.BackgroundColor = System.Drawing.Color.White
        Me.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tranpanel.SetDecoration(Me.dgvChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.dgvChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.dgvChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.dgvChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.dgvChucVu.Location = New System.Drawing.Point(252, 94)
        Me.dgvChucVu.Name = "dgvChucVu"
        Me.dgvChucVu.Size = New System.Drawing.Size(699, 396)
        Me.dgvChucVu.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.btnSearch)
        Me.Panel6.Controls.Add(Me.BunifuFlatButton2)
        Me.Panel6.Controls.Add(Me.BunifuFlatButton3)
        Me.Panel6.Controls.Add(Me.BunifuMetroTextbox1)
        Me.tranChucVu.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.Panel6.Location = New System.Drawing.Point(344, 21)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(499, 52)
        Me.Panel6.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.BorderRadius = 0
        Me.btnSearch.ButtonText = "Search"
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranChucVu.SetDecoration(Me.btnSearch, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.btnSearch, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.btnSearch, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.btnSearch, BunifuAnimatorNS.DecorationType.None)
        Me.btnSearch.DisabledColor = System.Drawing.Color.Gray
        Me.btnSearch.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSearch.Iconimage = CType(resources.GetObject("btnSearch.Iconimage"), System.Drawing.Image)
        Me.btnSearch.Iconimage_right = Nothing
        Me.btnSearch.Iconimage_right_Selected = Nothing
        Me.btnSearch.Iconimage_Selected = Nothing
        Me.btnSearch.IconMarginLeft = 0
        Me.btnSearch.IconMarginRight = 0
        Me.btnSearch.IconRightVisible = True
        Me.btnSearch.IconRightZoom = 0R
        Me.btnSearch.IconVisible = True
        Me.btnSearch.IconZoom = 40.0R
        Me.btnSearch.IsTab = False
        Me.btnSearch.Location = New System.Drawing.Point(393, 13)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSearch.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSearch.selected = False
        Me.btnSearch.Size = New System.Drawing.Size(100, 25)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSearch.Textcolor = System.Drawing.Color.White
        Me.btnSearch.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Update"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranChucVu.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = CType(resources.GetObject("BunifuFlatButton2.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 40.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(115, 13)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.Lime
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(100, 25)
        Me.BunifuFlatButton2.TabIndex = 4
        Me.BunifuFlatButton2.Text = "Update"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.Red
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "Remove"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranChucVu.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = CType(resources.GetObject("BunifuFlatButton3.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 40.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(9, 13)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.Brown
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(100, 25)
        Me.BunifuFlatButton3.TabIndex = 2
        Me.BunifuFlatButton3.Text = "Remove"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox1.BorderThickness = 1
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tranNhaCC.SetDecoration(Me.BunifuMetroTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.BunifuMetroTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.BunifuMetroTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.BunifuMetroTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(247, 13)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(139, 25)
        Me.BunifuMetroTextbox1.TabIndex = 3
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnAdd)
        Me.Panel7.Controls.Add(Me.txtQuyenHan)
        Me.Panel7.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel7.Controls.Add(Me.txtTenCV)
        Me.Panel7.Controls.Add(Me.BunifuCustomLabel9)
        Me.Panel7.Controls.Add(Me.txtMaChucVu)
        Me.Panel7.Controls.Add(Me.BunifuCustomLabel10)
        Me.Panel7.Controls.Add(Me.BunifuCustomLabel11)
        Me.tranChucVu.SetDecoration(Me.Panel7, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.Panel7, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.Panel7, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.Panel7, BunifuAnimatorNS.DecorationType.None)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(246, 734)
        Me.Panel7.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Activecolor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.BorderRadius = 0
        Me.btnAdd.ButtonText = "Add"
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tranChucVu.SetDecoration(Me.btnAdd, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.btnAdd, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.btnAdd, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.btnAdd, BunifuAnimatorNS.DecorationType.None)
        Me.btnAdd.DisabledColor = System.Drawing.Color.Gray
        Me.btnAdd.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAdd.Iconimage = CType(resources.GetObject("btnAdd.Iconimage"), System.Drawing.Image)
        Me.btnAdd.Iconimage_right = Nothing
        Me.btnAdd.Iconimage_right_Selected = Nothing
        Me.btnAdd.Iconimage_Selected = Nothing
        Me.btnAdd.IconMarginLeft = 0
        Me.btnAdd.IconMarginRight = 0
        Me.btnAdd.IconRightVisible = True
        Me.btnAdd.IconRightZoom = 0R
        Me.btnAdd.IconVisible = True
        Me.btnAdd.IconZoom = 40.0R
        Me.btnAdd.IsTab = False
        Me.btnAdd.Location = New System.Drawing.Point(38, 379)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnAdd.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAdd.selected = False
        Me.btnAdd.Size = New System.Drawing.Size(156, 26)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAdd.Textcolor = System.Drawing.Color.White
        Me.btnAdd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtQuyenHan
        '
        Me.txtQuyenHan.BackColor = System.Drawing.Color.White
        Me.txtQuyenHan.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtQuyenHan.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtQuyenHan.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtQuyenHan.BorderThickness = 1
        Me.txtQuyenHan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tranNhaCC.SetDecoration(Me.txtQuyenHan, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.txtQuyenHan, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.txtQuyenHan, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.txtQuyenHan, BunifuAnimatorNS.DecorationType.None)
        Me.txtQuyenHan.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtQuyenHan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtQuyenHan.isPassword = False
        Me.txtQuyenHan.Location = New System.Drawing.Point(4, 297)
        Me.txtQuyenHan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuyenHan.Name = "txtQuyenHan"
        Me.txtQuyenHan.Size = New System.Drawing.Size(238, 31)
        Me.txtQuyenHan.TabIndex = 6
        Me.txtQuyenHan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.tranNhaCC.SetDecoration(Me.BunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.BunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.BunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.BunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(3, 276)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(73, 17)
        Me.BunifuCustomLabel8.TabIndex = 5
        Me.BunifuCustomLabel8.Text = "Jurisdiction"
        '
        'txtTenCV
        '
        Me.txtTenCV.BackColor = System.Drawing.Color.White
        Me.txtTenCV.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtTenCV.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTenCV.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtTenCV.BorderThickness = 1
        Me.txtTenCV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tranNhaCC.SetDecoration(Me.txtTenCV, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.txtTenCV, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.txtTenCV, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.txtTenCV, BunifuAnimatorNS.DecorationType.None)
        Me.txtTenCV.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtTenCV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTenCV.isPassword = False
        Me.txtTenCV.Location = New System.Drawing.Point(5, 216)
        Me.txtTenCV.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenCV.Name = "txtTenCV"
        Me.txtTenCV.Size = New System.Drawing.Size(238, 31)
        Me.txtTenCV.TabIndex = 4
        Me.txtTenCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.tranNhaCC.SetDecoration(Me.BunifuCustomLabel9, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.BunifuCustomLabel9, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.BunifuCustomLabel9, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.BunifuCustomLabel9, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(4, 195)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(100, 17)
        Me.BunifuCustomLabel9.TabIndex = 3
        Me.BunifuCustomLabel9.Text = "Name Regency"
        '
        'txtMaChucVu
        '
        Me.txtMaChucVu.BackColor = System.Drawing.Color.White
        Me.txtMaChucVu.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtMaChucVu.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMaChucVu.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtMaChucVu.BorderThickness = 1
        Me.txtMaChucVu.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tranNhaCC.SetDecoration(Me.txtMaChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.txtMaChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.txtMaChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.txtMaChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.txtMaChucVu.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMaChucVu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMaChucVu.isPassword = False
        Me.txtMaChucVu.Location = New System.Drawing.Point(4, 134)
        Me.txtMaChucVu.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaChucVu.Name = "txtMaChucVu"
        Me.txtMaChucVu.Size = New System.Drawing.Size(238, 31)
        Me.txtMaChucVu.TabIndex = 2
        Me.txtMaChucVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.tranNhaCC.SetDecoration(Me.BunifuCustomLabel10, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.BunifuCustomLabel10, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.BunifuCustomLabel10, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.BunifuCustomLabel10, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(3, 113)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(80, 17)
        Me.BunifuCustomLabel10.TabIndex = 1
        Me.BunifuCustomLabel10.Text = "ID Regency"
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.tranNhaCC.SetDecoration(Me.BunifuCustomLabel11, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.BunifuCustomLabel11, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.BunifuCustomLabel11, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.BunifuCustomLabel11, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(58, 40)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(117, 33)
        Me.BunifuCustomLabel11.TabIndex = 0
        Me.BunifuCustomLabel11.Text = "Add Data"
        '
        'PictureBox1
        '
        Me.tranNhaCC.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
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
        Me.tranNhaCC.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
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
        Me.tranChucVu.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
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
        Me.tranChucVu.SetDecoration(Me.pnlMenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.pnlMenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.pnlMenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.pnlMenu, BunifuAnimatorNS.DecorationType.None)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 46)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(237, 734)
        Me.pnlMenu.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnKhach)
        Me.Panel4.Controls.Add(Me.btnhome)
        Me.Panel4.Controls.Add(Me.btnNhaCC)
        Me.Panel4.Controls.Add(Me.btnChucVu)
        Me.tranChucVu.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 126)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(237, 608)
        Me.Panel4.TabIndex = 4
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
        Me.tranChucVu.SetDecoration(Me.btnKhach, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.btnKhach, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.btnKhach, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.btnKhach, BunifuAnimatorNS.DecorationType.None)
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
        Me.tranChucVu.SetDecoration(Me.btnhome, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.btnhome, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.btnhome, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.btnhome, BunifuAnimatorNS.DecorationType.None)
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
        Me.tranChucVu.SetDecoration(Me.btnNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.btnNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.btnNhaCC, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.btnNhaCC, BunifuAnimatorNS.DecorationType.None)
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
        Me.tranChucVu.SetDecoration(Me.btnChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.btnChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.btnChucVu, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.btnChucVu, BunifuAnimatorNS.DecorationType.None)
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
        Me.tranChucVu.SetDecoration(Me.btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.btnmenu, BunifuAnimatorNS.DecorationType.None)
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
        Me.tranNhaCC.SetDecoration(Me.pcb1, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me.pcb1, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.pcb1, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.pcb1, BunifuAnimatorNS.DecorationType.None)
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
        Animation7.AnimateOnlyDifferences = True
        Animation7.BlindCoeff = CType(resources.GetObject("Animation7.BlindCoeff"), System.Drawing.PointF)
        Animation7.LeafCoeff = 0!
        Animation7.MaxTime = 1.0!
        Animation7.MinTime = 0!
        Animation7.MosaicCoeff = CType(resources.GetObject("Animation7.MosaicCoeff"), System.Drawing.PointF)
        Animation7.MosaicShift = CType(resources.GetObject("Animation7.MosaicShift"), System.Drawing.PointF)
        Animation7.MosaicSize = 0
        Animation7.Padding = New System.Windows.Forms.Padding(30)
        Animation7.RotateCoeff = 0.5!
        Animation7.RotateLimit = 0.2!
        Animation7.ScaleCoeff = CType(resources.GetObject("Animation7.ScaleCoeff"), System.Drawing.PointF)
        Animation7.SlideCoeff = CType(resources.GetObject("Animation7.SlideCoeff"), System.Drawing.PointF)
        Animation7.TimeCoeff = 0!
        Animation7.TransparencyCoeff = 0!
        Me.tranlogo.DefaultAnimation = Animation7
        Me.tranlogo.TimeStep = 0.01!
        '
        'tranpanel
        '
        Me.tranpanel.AnimationType = BunifuAnimatorNS.AnimationType.Leaf
        Me.tranpanel.Cursor = Nothing
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
        Me.tranpanel.DefaultAnimation = Animation6
        Me.tranpanel.TimeStep = 0.01!
        '
        'tranNhaCC
        '
        Me.tranNhaCC.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.tranNhaCC.Cursor = Nothing
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
        Me.tranNhaCC.DefaultAnimation = Animation8
        '
        'tranChucVu
        '
        Me.tranChucVu.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
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
        'Panel2
        '
        Me.tranChucVu.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.tranNhaCC.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(237, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(963, 734)
        Me.Panel2.TabIndex = 2
        '
        'Menuform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 780)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.Panel1)
        Me.tranNhaCC.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tranChucVu.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tranlogo.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.tranpanel.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menuform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menuform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNhaCC.ResumeLayout(False)
        CType(Me.dgvChucVu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.btnmenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PanelNhaCC As Panel
    Friend WithEvents dgvChucVu As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnAdd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtQuyenHan As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtTenCV As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtMaChucVu As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As Panel
End Class
