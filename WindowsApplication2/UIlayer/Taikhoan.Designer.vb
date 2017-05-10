<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Taikhoan
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Taikhoan))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbNote = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbMatKhau = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbTaiKhoan = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnAdd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtMatKhau = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtGhiChu = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtTaiKhoan = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtSearch = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnRemove = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.dgvTaiKhoan = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnReset = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvTaiKhoan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.lbNote)
        Me.Panel1.Controls.Add(Me.lbMatKhau)
        Me.Panel1.Controls.Add(Me.lbTaiKhoan)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.txtMatKhau)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel1.Controls.Add(Me.txtGhiChu)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Controls.Add(Me.txtTaiKhoan)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(211, 683)
        Me.Panel1.TabIndex = 5
        '
        'lbNote
        '
        Me.lbNote.AutoSize = True
        Me.lbNote.ForeColor = System.Drawing.Color.Red
        Me.lbNote.Location = New System.Drawing.Point(29, 466)
        Me.lbNote.Name = "lbNote"
        Me.lbNote.Size = New System.Drawing.Size(104, 13)
        Me.lbNote.TabIndex = 15
        Me.lbNote.Text = "BunifuCustomLabel5"
        '
        'lbMatKhau
        '
        Me.lbMatKhau.AutoSize = True
        Me.lbMatKhau.ForeColor = System.Drawing.Color.Red
        Me.lbMatKhau.Location = New System.Drawing.Point(29, 382)
        Me.lbMatKhau.Name = "lbMatKhau"
        Me.lbMatKhau.Size = New System.Drawing.Size(104, 13)
        Me.lbMatKhau.TabIndex = 14
        Me.lbMatKhau.Text = "BunifuCustomLabel5"
        '
        'lbTaiKhoan
        '
        Me.lbTaiKhoan.AutoSize = True
        Me.lbTaiKhoan.ForeColor = System.Drawing.Color.Red
        Me.lbTaiKhoan.Location = New System.Drawing.Point(29, 281)
        Me.lbTaiKhoan.Name = "lbTaiKhoan"
        Me.lbTaiKhoan.Size = New System.Drawing.Size(104, 13)
        Me.lbTaiKhoan.TabIndex = 13
        Me.lbTaiKhoan.Text = "BunifuCustomLabel5"
        '
        'btnAdd
        '
        Me.btnAdd.Activecolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.BorderRadius = 0
        Me.btnAdd.ButtonText = "Add"
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.btnAdd.Location = New System.Drawing.Point(16, 496)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnAdd.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAdd.selected = False
        Me.btnAdd.Size = New System.Drawing.Size(168, 28)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAdd.Textcolor = System.Drawing.Color.White
        Me.btnAdd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtMatKhau
        '
        Me.txtMatKhau.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtMatKhau.Location = New System.Drawing.Point(16, 344)
        Me.txtMatKhau.Multiline = True
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Size = New System.Drawing.Size(168, 23)
        Me.txtMatKhau.TabIndex = 7
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(16, 325)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(53, 13)
        Me.BunifuCustomLabel4.TabIndex = 6
        Me.BunifuCustomLabel4.Text = "Password"
        '
        'txtGhiChu
        '
        Me.txtGhiChu.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtGhiChu.Location = New System.Drawing.Point(16, 426)
        Me.txtGhiChu.Multiline = True
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(168, 23)
        Me.txtGhiChu.TabIndex = 5
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(16, 404)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(30, 13)
        Me.BunifuCustomLabel3.TabIndex = 4
        Me.BunifuCustomLabel3.Text = "Note"
        '
        'txtTaiKhoan
        '
        Me.txtTaiKhoan.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtTaiKhoan.Location = New System.Drawing.Point(16, 246)
        Me.txtTaiKhoan.Multiline = True
        Me.txtTaiKhoan.Name = "txtTaiKhoan"
        Me.txtTaiKhoan.Size = New System.Drawing.Size(168, 23)
        Me.txtTaiKhoan.TabIndex = 3
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(16, 230)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(47, 13)
        Me.BunifuCustomLabel2.TabIndex = 1
        Me.BunifuCustomLabel2.Text = "Account"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(49, 169)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(111, 29)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Add Data"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtSearch)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.btnRemove)
        Me.Panel2.Location = New System.Drawing.Point(230, 91)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(576, 59)
        Me.Panel2.TabIndex = 6
        '
        'txtSearch
        '
        Me.txtSearch.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(277, 12)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(168, 28)
        Me.txtSearch.TabIndex = 16
        '
        'btnSearch
        '
        Me.btnSearch.Activecolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.BorderRadius = 0
        Me.btnSearch.ButtonText = "Search"
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.btnSearch.Location = New System.Drawing.Point(451, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnSearch.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSearch.selected = False
        Me.btnSearch.Size = New System.Drawing.Size(91, 28)
        Me.btnSearch.TabIndex = 15
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSearch.Textcolor = System.Drawing.Color.White
        Me.btnSearch.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnUpdate
        '
        Me.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.BorderRadius = 0
        Me.btnUpdate.ButtonText = "Update"
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.DisabledColor = System.Drawing.Color.Gray
        Me.btnUpdate.Iconcolor = System.Drawing.Color.Transparent
        Me.btnUpdate.Iconimage = CType(resources.GetObject("btnUpdate.Iconimage"), System.Drawing.Image)
        Me.btnUpdate.Iconimage_right = Nothing
        Me.btnUpdate.Iconimage_right_Selected = Nothing
        Me.btnUpdate.Iconimage_Selected = Nothing
        Me.btnUpdate.IconMarginLeft = 0
        Me.btnUpdate.IconMarginRight = 0
        Me.btnUpdate.IconRightVisible = True
        Me.btnUpdate.IconRightZoom = 0R
        Me.btnUpdate.IconVisible = True
        Me.btnUpdate.IconZoom = 40.0R
        Me.btnUpdate.IsTab = False
        Me.btnUpdate.Location = New System.Drawing.Point(153, 12)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnUpdate.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUpdate.selected = False
        Me.btnUpdate.Size = New System.Drawing.Size(91, 28)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnUpdate.Textcolor = System.Drawing.Color.White
        Me.btnUpdate.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnRemove
        '
        Me.btnRemove.Activecolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemove.BorderRadius = 0
        Me.btnRemove.ButtonText = "Remove"
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.DisabledColor = System.Drawing.Color.Gray
        Me.btnRemove.Iconcolor = System.Drawing.Color.Transparent
        Me.btnRemove.Iconimage = CType(resources.GetObject("btnRemove.Iconimage"), System.Drawing.Image)
        Me.btnRemove.Iconimage_right = Nothing
        Me.btnRemove.Iconimage_right_Selected = Nothing
        Me.btnRemove.Iconimage_Selected = Nothing
        Me.btnRemove.IconMarginLeft = 0
        Me.btnRemove.IconMarginRight = 0
        Me.btnRemove.IconRightVisible = True
        Me.btnRemove.IconRightZoom = 0R
        Me.btnRemove.IconVisible = True
        Me.btnRemove.IconZoom = 40.0R
        Me.btnRemove.IsTab = False
        Me.btnRemove.Location = New System.Drawing.Point(36, 12)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnRemove.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnRemove.OnHoverTextColor = System.Drawing.Color.White
        Me.btnRemove.selected = False
        Me.btnRemove.Size = New System.Drawing.Size(91, 28)
        Me.btnRemove.TabIndex = 13
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRemove.Textcolor = System.Drawing.Color.White
        Me.btnRemove.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dgvTaiKhoan
        '
        Me.dgvTaiKhoan.AllowUserToAddRows = False
        Me.dgvTaiKhoan.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvTaiKhoan.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTaiKhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTaiKhoan.DoubleBuffered = True
        Me.dgvTaiKhoan.EnableHeadersVisualStyles = False
        Me.dgvTaiKhoan.HeaderBgColor = System.Drawing.Color.Silver
        Me.dgvTaiKhoan.HeaderForeColor = System.Drawing.Color.Black
        Me.dgvTaiKhoan.Location = New System.Drawing.Point(217, 156)
        Me.dgvTaiKhoan.Name = "dgvTaiKhoan"
        Me.dgvTaiKhoan.ReadOnly = True
        Me.dgvTaiKhoan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTaiKhoan.Size = New System.Drawing.Size(629, 479)
        Me.dgvTaiKhoan.TabIndex = 7
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(289, 18)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(433, 50)
        Me.BunifuCustomLabel5.TabIndex = 16
        Me.BunifuCustomLabel5.Text = "Information Account"
        '
        'btnReset
        '
        Me.btnReset.Activecolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReset.BorderRadius = 0
        Me.btnReset.ButtonText = "Reset"
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.DisabledColor = System.Drawing.Color.Gray
        Me.btnReset.Iconcolor = System.Drawing.Color.Transparent
        Me.btnReset.Iconimage = CType(resources.GetObject("btnReset.Iconimage"), System.Drawing.Image)
        Me.btnReset.Iconimage_right = Nothing
        Me.btnReset.Iconimage_right_Selected = Nothing
        Me.btnReset.Iconimage_Selected = Nothing
        Me.btnReset.IconMarginLeft = 0
        Me.btnReset.IconMarginRight = 0
        Me.btnReset.IconRightVisible = True
        Me.btnReset.IconRightZoom = 0R
        Me.btnReset.IconVisible = True
        Me.btnReset.IconZoom = 40.0R
        Me.btnReset.IsTab = False
        Me.btnReset.Location = New System.Drawing.Point(16, 543)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnReset.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnReset.OnHoverTextColor = System.Drawing.Color.White
        Me.btnReset.selected = False
        Me.btnReset.Size = New System.Drawing.Size(168, 28)
        Me.btnReset.TabIndex = 16
        Me.btnReset.Text = "Reset"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnReset.Textcolor = System.Drawing.Color.White
        Me.btnReset.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Taikhoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.dgvTaiKhoan)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Taikhoan"
        Me.Size = New System.Drawing.Size(887, 683)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvTaiKhoan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtMatKhau As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtGhiChu As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtTaiKhoan As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSearch As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnRemove As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dgvTaiKhoan As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents lbNote As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbMatKhau As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbTaiKhoan As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnReset As Bunifu.Framework.UI.BunifuFlatButton
End Class
