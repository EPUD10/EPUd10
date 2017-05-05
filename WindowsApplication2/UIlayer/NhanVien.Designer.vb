<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NhanVien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NhanVien))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbChucVu = New System.Windows.Forms.ComboBox()
        Me.cmbCuaHang = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtDT = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnRemove = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAdd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.rbtNu = New System.Windows.Forms.RadioButton()
        Me.rbtNam = New System.Windows.Forms.RadioButton()
        Me.dateNV = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtDC = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtMaNhanVien = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.dgvNhanVien = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.lbID = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbPhone = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbName = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbEmail = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbAdd = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbAdd)
        Me.GroupBox1.Controls.Add(Me.lbEmail)
        Me.GroupBox1.Controls.Add(Me.lbName)
        Me.GroupBox1.Controls.Add(Me.lbPhone)
        Me.GroupBox1.Controls.Add(Me.lbID)
        Me.GroupBox1.Controls.Add(Me.cmbChucVu)
        Me.GroupBox1.Controls.Add(Me.cmbCuaHang)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtDT)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel3)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel2)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnRemove)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.rbtNu)
        Me.GroupBox1.Controls.Add(Me.rbtNam)
        Me.GroupBox1.Controls.Add(Me.dateNV)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel7)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel8)
        Me.GroupBox1.Controls.Add(Me.txtDC)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel9)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel6)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel5)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel4)
        Me.GroupBox1.Controls.Add(Me.txtMaNhanVien)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(881, 251)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add data"
        '
        'cmbChucVu
        '
        Me.cmbChucVu.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbChucVu.FormattingEnabled = True
        Me.cmbChucVu.Location = New System.Drawing.Point(492, 203)
        Me.cmbChucVu.Name = "cmbChucVu"
        Me.cmbChucVu.Size = New System.Drawing.Size(164, 23)
        Me.cmbChucVu.TabIndex = 29
        '
        'cmbCuaHang
        '
        Me.cmbCuaHang.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCuaHang.FormattingEnabled = True
        Me.cmbCuaHang.Location = New System.Drawing.Point(491, 138)
        Me.cmbCuaHang.Name = "cmbCuaHang"
        Me.cmbCuaHang.Size = New System.Drawing.Size(165, 23)
        Me.cmbCuaHang.TabIndex = 28
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtEmail.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtEmail.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmail.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtEmail.BorderThickness = 1
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtEmail.isPassword = False
        Me.txtEmail.Location = New System.Drawing.Point(265, 137)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(152, 19)
        Me.txtEmail.TabIndex = 27
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtDT
        '
        Me.txtDT.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtDT.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtDT.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDT.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtDT.BorderThickness = 1
        Me.txtDT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDT.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtDT.isPassword = False
        Me.txtDT.Location = New System.Drawing.Point(265, 63)
        Me.txtDT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDT.Name = "txtDT"
        Me.txtDT.Size = New System.Drawing.Size(152, 19)
        Me.txtDT.TabIndex = 26
        Me.txtDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(262, 41)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(105, 18)
        Me.BunifuCustomLabel3.TabIndex = 25
        Me.BunifuCustomLabel3.Text = "Phone Number"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(271, 115)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(48, 18)
        Me.BunifuCustomLabel2.TabIndex = 24
        Me.BunifuCustomLabel2.Text = "Email"
        '
        'btnUpdate
        '
        Me.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(109, Byte), Integer))
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
        Me.btnUpdate.Location = New System.Drawing.Point(700, 204)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnUpdate.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUpdate.selected = False
        Me.btnUpdate.Size = New System.Drawing.Size(105, 28)
        Me.btnUpdate.TabIndex = 23
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnUpdate.Textcolor = System.Drawing.Color.White
        Me.btnUpdate.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnRemove
        '
        Me.btnRemove.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
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
        Me.btnRemove.Location = New System.Drawing.Point(700, 138)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnRemove.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnRemove.OnHoverTextColor = System.Drawing.Color.White
        Me.btnRemove.selected = False
        Me.btnRemove.Size = New System.Drawing.Size(105, 28)
        Me.btnRemove.TabIndex = 22
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRemove.Textcolor = System.Drawing.Color.White
        Me.btnRemove.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAdd
        '
        Me.btnAdd.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(128, Byte), Integer))
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
        Me.btnAdd.Location = New System.Drawing.Point(700, 77)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnAdd.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAdd.selected = False
        Me.btnAdd.Size = New System.Drawing.Size(105, 28)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAdd.Textcolor = System.Drawing.Color.White
        Me.btnAdd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'rbtNu
        '
        Me.rbtNu.AutoSize = True
        Me.rbtNu.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtNu.Location = New System.Drawing.Point(126, 204)
        Me.rbtNu.Name = "rbtNu"
        Me.rbtNu.Size = New System.Drawing.Size(45, 22)
        Me.rbtNu.TabIndex = 20
        Me.rbtNu.TabStop = True
        Me.rbtNu.Text = "Nữ"
        Me.rbtNu.UseVisualStyleBackColor = True
        '
        'rbtNam
        '
        Me.rbtNam.AutoSize = True
        Me.rbtNam.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtNam.Location = New System.Drawing.Point(27, 204)
        Me.rbtNam.Name = "rbtNam"
        Me.rbtNam.Size = New System.Drawing.Size(56, 22)
        Me.rbtNam.TabIndex = 19
        Me.rbtNam.TabStop = True
        Me.rbtNam.Text = "Nam"
        Me.rbtNam.UseVisualStyleBackColor = True
        '
        'dateNV
        '
        Me.dateNV.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.dateNV.BorderRadius = 0
        Me.dateNV.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateNV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.dateNV.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dateNV.FormatCustom = Nothing
        Me.dateNV.Location = New System.Drawing.Point(217, 204)
        Me.dateNV.Margin = New System.Windows.Forms.Padding(6)
        Me.dateNV.Name = "dateNV"
        Me.dateNV.Size = New System.Drawing.Size(236, 22)
        Me.dateNV.TabIndex = 2
        Me.dateNV.Value = New Date(2017, 4, 22, 22, 16, 41, 77)
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(489, 110)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(64, 18)
        Me.BunifuCustomLabel7.TabIndex = 16
        Me.BunifuCustomLabel7.Text = "ID Store"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(489, 182)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(84, 18)
        Me.BunifuCustomLabel8.TabIndex = 14
        Me.BunifuCustomLabel8.Text = "ID Regency"
        '
        'txtDC
        '
        Me.txtDC.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtDC.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtDC.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDC.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtDC.BorderThickness = 1
        Me.txtDC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDC.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtDC.isPassword = False
        Me.txtDC.Location = New System.Drawing.Point(491, 63)
        Me.txtDC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDC.Name = "txtDC"
        Me.txtDC.Size = New System.Drawing.Size(165, 19)
        Me.txtDC.TabIndex = 13
        Me.txtDC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(214, 182)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(104, 18)
        Me.BunifuCustomLabel9.TabIndex = 12
        Me.BunifuCustomLabel9.Text = " Date of birth "
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtName.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtName.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtName.BorderThickness = 1
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtName.isPassword = False
        Me.txtName.Location = New System.Drawing.Point(26, 132)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(152, 19)
        Me.txtName.TabIndex = 11
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(23, 110)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(109, 18)
        Me.BunifuCustomLabel6.TabIndex = 10
        Me.BunifuCustomLabel6.Text = "Name Salesman"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(23, 182)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(30, 18)
        Me.BunifuCustomLabel5.TabIndex = 8
        Me.BunifuCustomLabel5.Text = "Sex"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(494, 41)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(59, 18)
        Me.BunifuCustomLabel4.TabIndex = 6
        Me.BunifuCustomLabel4.Text = "Address"
        '
        'txtMaNhanVien
        '
        Me.txtMaNhanVien.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtMaNhanVien.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtMaNhanVien.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMaNhanVien.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtMaNhanVien.BorderThickness = 1
        Me.txtMaNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMaNhanVien.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMaNhanVien.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtMaNhanVien.isPassword = False
        Me.txtMaNhanVien.Location = New System.Drawing.Point(26, 63)
        Me.txtMaNhanVien.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaNhanVien.Name = "txtMaNhanVien"
        Me.txtMaNhanVien.Size = New System.Drawing.Size(152, 19)
        Me.txtMaNhanVien.TabIndex = 1
        Me.txtMaNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(23, 41)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(92, 18)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "ID Salesman"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtSearch.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtSearch.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearch.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtSearch.BorderThickness = 1
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtSearch.isPassword = False
        Me.txtSearch.Location = New System.Drawing.Point(454, 289)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(223, 22)
        Me.txtSearch.TabIndex = 18
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(450, 267)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(56, 18)
        Me.BunifuCustomLabel11.TabIndex = 17
        Me.BunifuCustomLabel11.Text = "Srearch"
        '
        'btnSearch
        '
        Me.btnSearch.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(47, Byte), Integer))
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
        Me.btnSearch.Location = New System.Drawing.Point(715, 283)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnSearch.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSearch.selected = False
        Me.btnSearch.Size = New System.Drawing.Size(105, 28)
        Me.btnSearch.TabIndex = 22
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSearch.Textcolor = System.Drawing.Color.White
        Me.btnSearch.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dgvNhanVien
        '
        Me.dgvNhanVien.AllowUserToAddRows = False
        Me.dgvNhanVien.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvNhanVien.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNhanVien.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNhanVien.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvNhanVien.DoubleBuffered = True
        Me.dgvNhanVien.EnableHeadersVisualStyles = False
        Me.dgvNhanVien.HeaderBgColor = System.Drawing.Color.Silver
        Me.dgvNhanVien.HeaderForeColor = System.Drawing.Color.Black
        Me.dgvNhanVien.Location = New System.Drawing.Point(0, 341)
        Me.dgvNhanVien.Name = "dgvNhanVien"
        Me.dgvNhanVien.ReadOnly = True
        Me.dgvNhanVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvNhanVien.Size = New System.Drawing.Size(887, 342)
        Me.dgvNhanVien.TabIndex = 23
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.ForeColor = System.Drawing.Color.Red
        Me.lbID.Location = New System.Drawing.Point(25, 93)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(127, 15)
        Me.lbID.TabIndex = 30
        Me.lbID.Text = "BunifuCustomLabel10"
        '
        'lbPhone
        '
        Me.lbPhone.AutoSize = True
        Me.lbPhone.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPhone.ForeColor = System.Drawing.Color.Red
        Me.lbPhone.Location = New System.Drawing.Point(262, 93)
        Me.lbPhone.Name = "lbPhone"
        Me.lbPhone.Size = New System.Drawing.Size(127, 15)
        Me.lbPhone.TabIndex = 31
        Me.lbPhone.Text = "BunifuCustomLabel10"
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.ForeColor = System.Drawing.Color.Red
        Me.lbName.Location = New System.Drawing.Point(25, 163)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(127, 15)
        Me.lbName.TabIndex = 32
        Me.lbName.Text = "BunifuCustomLabel10"
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmail.ForeColor = System.Drawing.Color.Red
        Me.lbEmail.Location = New System.Drawing.Point(262, 163)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(127, 15)
        Me.lbEmail.TabIndex = 33
        Me.lbEmail.Text = "BunifuCustomLabel10"
        '
        'lbAdd
        '
        Me.lbAdd.AutoSize = True
        Me.lbAdd.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAdd.ForeColor = System.Drawing.Color.Red
        Me.lbAdd.Location = New System.Drawing.Point(489, 93)
        Me.lbAdd.Name = "lbAdd"
        Me.lbAdd.Size = New System.Drawing.Size(127, 15)
        Me.lbAdd.TabIndex = 34
        Me.lbAdd.Text = "BunifuCustomLabel10"
        '
        'NhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Controls.Add(Me.dgvNhanVien)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.BunifuCustomLabel11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "NhanVien"
        Me.Size = New System.Drawing.Size(887, 683)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtDC As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtMaNhanVien As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents rbtNu As RadioButton
    Friend WithEvents rbtNam As RadioButton
    Friend WithEvents dateNV As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents btnAdd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnRemove As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Protected Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtEmail As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtDT As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cmbChucVu As ComboBox
    Friend WithEvents cmbCuaHang As ComboBox
    Friend WithEvents dgvNhanVien As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents lbAdd As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbEmail As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbName As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbPhone As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbID As Bunifu.Framework.UI.BunifuCustomLabel
End Class
