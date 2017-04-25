<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KhachHangForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KhachHangForm))
        Me.dgvKhach = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.datetime = New System.Windows.Forms.DateTimePicker()
        Me.rbtnu = New System.Windows.Forms.RadioButton()
        Me.rbtNam = New System.Windows.Forms.RadioButton()
        Me.txtPhoneNumber = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtEmail = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtAddress = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtNameCus = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtIDCustomer = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnRemove = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnadd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        CType(Me.dgvKhach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvKhach
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvKhach.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvKhach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvKhach.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvKhach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvKhach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvKhach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKhach.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvKhach.DoubleBuffered = True
        Me.dgvKhach.EnableHeadersVisualStyles = False
        Me.dgvKhach.HeaderBgColor = System.Drawing.Color.Silver
        Me.dgvKhach.HeaderForeColor = System.Drawing.Color.Black
        Me.dgvKhach.Location = New System.Drawing.Point(0, 0)
        Me.dgvKhach.Name = "dgvKhach"
        Me.dgvKhach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvKhach.Size = New System.Drawing.Size(887, 273)
        Me.dgvKhach.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.datetime)
        Me.Panel1.Controls.Add(Me.rbtnu)
        Me.Panel1.Controls.Add(Me.rbtNam)
        Me.Panel1.Controls.Add(Me.txtPhoneNumber)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel7)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel6)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Controls.Add(Me.txtNameCus)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.txtIDCustomer)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Location = New System.Drawing.Point(20, 365)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(840, 199)
        Me.Panel1.TabIndex = 20
        '
        'datetime
        '
        Me.datetime.Location = New System.Drawing.Point(319, 137)
        Me.datetime.Name = "datetime"
        Me.datetime.Size = New System.Drawing.Size(200, 20)
        Me.datetime.TabIndex = 34
        '
        'rbtnu
        '
        Me.rbtnu.AutoSize = True
        Me.rbtnu.Location = New System.Drawing.Point(192, 137)
        Me.rbtnu.Name = "rbtnu"
        Me.rbtnu.Size = New System.Drawing.Size(39, 17)
        Me.rbtnu.TabIndex = 33
        Me.rbtnu.TabStop = True
        Me.rbtnu.Text = "Nữ"
        Me.rbtnu.UseVisualStyleBackColor = True
        '
        'rbtNam
        '
        Me.rbtNam.AutoSize = True
        Me.rbtNam.Location = New System.Drawing.Point(139, 137)
        Me.rbtNam.Name = "rbtNam"
        Me.rbtNam.Size = New System.Drawing.Size(47, 17)
        Me.rbtNam.TabIndex = 32
        Me.rbtNam.TabStop = True
        Me.rbtNam.Text = "Nam"
        Me.rbtNam.UseVisualStyleBackColor = True
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtPhoneNumber.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPhoneNumber.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtPhoneNumber.BorderThickness = 1
        Me.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtPhoneNumber.isPassword = False
        Me.txtPhoneNumber.Location = New System.Drawing.Point(687, 68)
        Me.txtPhoneNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(146, 22)
        Me.txtPhoneNumber.TabIndex = 31
        Me.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(689, 48)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(91, 15)
        Me.BunifuCustomLabel7.TabIndex = 30
        Me.BunifuCustomLabel7.Text = "Phone Number"
        '
        'txtEmail
        '
        Me.txtEmail.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtEmail.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmail.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtEmail.BorderThickness = 1
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtEmail.isPassword = False
        Me.txtEmail.Location = New System.Drawing.Point(579, 132)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(146, 22)
        Me.txtEmail.TabIndex = 29
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(578, 113)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(39, 15)
        Me.BunifuCustomLabel6.TabIndex = 28
        Me.BunifuCustomLabel6.Text = "Email"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(316, 113)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(74, 15)
        Me.BunifuCustomLabel5.TabIndex = 27
        Me.BunifuCustomLabel5.Text = "Date or birth"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(136, 113)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(28, 15)
        Me.BunifuCustomLabel4.TabIndex = 26
        Me.BunifuCustomLabel4.Text = "Sex"
        '
        'txtAddress
        '
        Me.txtAddress.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtAddress.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAddress.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtAddress.BorderThickness = 1
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtAddress.isPassword = False
        Me.txtAddress.Location = New System.Drawing.Point(466, 68)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(146, 22)
        Me.txtAddress.TabIndex = 25
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(468, 48)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(51, 15)
        Me.BunifuCustomLabel3.TabIndex = 24
        Me.BunifuCustomLabel3.Text = "Address"
        '
        'txtNameCus
        '
        Me.txtNameCus.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtNameCus.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNameCus.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtNameCus.BorderThickness = 1
        Me.txtNameCus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNameCus.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNameCus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtNameCus.isPassword = False
        Me.txtNameCus.Location = New System.Drawing.Point(245, 68)
        Me.txtNameCus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNameCus.Name = "txtNameCus"
        Me.txtNameCus.Size = New System.Drawing.Size(146, 22)
        Me.txtNameCus.TabIndex = 23
        Me.txtNameCus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(247, 48)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(97, 15)
        Me.BunifuCustomLabel2.TabIndex = 22
        Me.BunifuCustomLabel2.Text = "Name Customer"
        '
        'txtIDCustomer
        '
        Me.txtIDCustomer.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtIDCustomer.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtIDCustomer.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtIDCustomer.BorderThickness = 1
        Me.txtIDCustomer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIDCustomer.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtIDCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtIDCustomer.isPassword = False
        Me.txtIDCustomer.Location = New System.Drawing.Point(24, 68)
        Me.txtIDCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIDCustomer.Name = "txtIDCustomer"
        Me.txtIDCustomer.Size = New System.Drawing.Size(146, 22)
        Me.txtIDCustomer.TabIndex = 21
        Me.txtIDCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(26, 48)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(75, 15)
        Me.BunifuCustomLabel1.TabIndex = 20
        Me.BunifuCustomLabel1.Text = "ID Customer"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.btnRemove)
        Me.Panel2.Controls.Add(Me.btnadd)
        Me.Panel2.Location = New System.Drawing.Point(20, 579)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(839, 76)
        Me.Panel2.TabIndex = 21
        '
        'btnUpdate
        '
        Me.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.btnUpdate.Location = New System.Drawing.Point(635, 28)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnUpdate.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUpdate.selected = False
        Me.btnUpdate.Size = New System.Drawing.Size(106, 32)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnUpdate.Textcolor = System.Drawing.Color.White
        Me.btnUpdate.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnRemove
        '
        Me.btnRemove.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.btnRemove.Location = New System.Drawing.Point(377, 28)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnRemove.OnHoverTextColor = System.Drawing.Color.White
        Me.btnRemove.selected = False
        Me.btnRemove.Size = New System.Drawing.Size(106, 32)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRemove.Textcolor = System.Drawing.Color.White
        Me.btnRemove.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnadd
        '
        Me.btnadd.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnadd.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnadd.BorderRadius = 0
        Me.btnadd.ButtonText = "Add"
        Me.btnadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadd.DisabledColor = System.Drawing.Color.Gray
        Me.btnadd.Iconcolor = System.Drawing.Color.Transparent
        Me.btnadd.Iconimage = CType(resources.GetObject("btnadd.Iconimage"), System.Drawing.Image)
        Me.btnadd.Iconimage_right = Nothing
        Me.btnadd.Iconimage_right_Selected = Nothing
        Me.btnadd.Iconimage_Selected = Nothing
        Me.btnadd.IconMarginLeft = 0
        Me.btnadd.IconMarginRight = 0
        Me.btnadd.IconRightVisible = True
        Me.btnadd.IconRightZoom = 0R
        Me.btnadd.IconVisible = True
        Me.btnadd.IconZoom = 40.0R
        Me.btnadd.IsTab = False
        Me.btnadd.Location = New System.Drawing.Point(119, 28)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnadd.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnadd.OnHoverTextColor = System.Drawing.Color.White
        Me.btnadd.selected = False
        Me.btnadd.Size = New System.Drawing.Size(106, 32)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "Add"
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnadd.Textcolor = System.Drawing.Color.White
        Me.btnadd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnSearch)
        Me.Panel3.Controls.Add(Me.txtSearch)
        Me.Panel3.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel3.Location = New System.Drawing.Point(476, 282)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(408, 71)
        Me.Panel3.TabIndex = 22
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageActive = Nothing
        Me.btnSearch.Location = New System.Drawing.Point(358, 37)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(25, 25)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSearch.TabIndex = 25
        Me.btnSearch.TabStop = False
        Me.btnSearch.Zoom = 10
        '
        'txtSearch
        '
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearch.HintForeColor = System.Drawing.Color.Empty
        Me.txtSearch.HintText = ""
        Me.txtSearch.isPassword = False
        Me.txtSearch.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtSearch.LineIdleColor = System.Drawing.Color.Gray
        Me.txtSearch.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtSearch.LineThickness = 3
        Me.txtSearch.Location = New System.Drawing.Point(64, 40)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(320, 25)
        Me.txtSearch.TabIndex = 24
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(65, 16)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(60, 20)
        Me.BunifuCustomLabel8.TabIndex = 22
        Me.BunifuCustomLabel8.Text = "Search"
        '
        'KhachHangForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvKhach)
        Me.Name = "KhachHangForm"
        Me.Size = New System.Drawing.Size(887, 683)
        CType(Me.dgvKhach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvKhach As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents datetime As DateTimePicker
    Friend WithEvents rbtnu As RadioButton
    Friend WithEvents rbtNam As RadioButton
    Friend WithEvents txtPhoneNumber As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtEmail As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtAddress As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtNameCus As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtIDCustomer As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnRemove As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnadd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
