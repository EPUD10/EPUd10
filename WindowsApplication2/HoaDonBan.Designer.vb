<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HoaDonBan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HoaDonBan))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSoLuong = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtMahdb = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cmbNV = New System.Windows.Forms.ComboBox()
        Me.cmbSP = New System.Windows.Forms.ComboBox()
        Me.cmbCH = New System.Windows.Forms.ComboBox()
        Me.datetime = New System.Windows.Forms.DateTimePicker()
        Me.dgvHDN = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnRemove = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnAdd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cmbNhaCC = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtGiaNhap = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvHDN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtGiaNhap)
        Me.GroupBox1.Controls.Add(Me.cmbNhaCC)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel7)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel8)
        Me.GroupBox1.Controls.Add(Me.datetime)
        Me.GroupBox1.Controls.Add(Me.cmbCH)
        Me.GroupBox1.Controls.Add(Me.cmbSP)
        Me.GroupBox1.Controls.Add(Me.cmbNV)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel4)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel5)
        Me.GroupBox1.Controls.Add(Me.txtSoLuong)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel3)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel2)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel6)
        Me.GroupBox1.Controls.Add(Me.txtMahdb)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(881, 268)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'txtSoLuong
        '
        Me.txtSoLuong.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtSoLuong.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtSoLuong.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSoLuong.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtSoLuong.BorderThickness = 1
        Me.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSoLuong.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSoLuong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtSoLuong.isPassword = False
        Me.txtSoLuong.Location = New System.Drawing.Point(352, 89)
        Me.txtSoLuong.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(182, 22)
        Me.txtSoLuong.TabIndex = 56
        Me.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(349, 67)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(59, 18)
        Me.BunifuCustomLabel3.TabIndex = 55
        Me.BunifuCustomLabel3.Text = "Number"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(349, 133)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(66, 18)
        Me.BunifuCustomLabel2.TabIndex = 54
        Me.BunifuCustomLabel2.Text = "Datetime"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(48, 133)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(82, 18)
        Me.BunifuCustomLabel6.TabIndex = 52
        Me.BunifuCustomLabel6.Text = "ID Product"
        '
        'txtMahdb
        '
        Me.txtMahdb.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtMahdb.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtMahdb.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMahdb.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtMahdb.BorderThickness = 1
        Me.txtMahdb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMahdb.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMahdb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtMahdb.isPassword = False
        Me.txtMahdb.Location = New System.Drawing.Point(49, 89)
        Me.txtMahdb.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMahdb.Name = "txtMahdb"
        Me.txtMahdb.Size = New System.Drawing.Size(192, 22)
        Me.txtMahdb.TabIndex = 51
        Me.txtMahdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(46, 67)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(84, 18)
        Me.BunifuCustomLabel1.TabIndex = 50
        Me.BunifuCustomLabel1.Text = "ID Billiard"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(672, 67)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(92, 18)
        Me.BunifuCustomLabel4.TabIndex = 59
        Me.BunifuCustomLabel4.Text = "ID Salesman"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(672, 133)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(64, 18)
        Me.BunifuCustomLabel5.TabIndex = 58
        Me.BunifuCustomLabel5.Text = "ID Store"
        '
        'cmbNV
        '
        Me.cmbNV.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbNV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNV.FormattingEnabled = True
        Me.cmbNV.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbNV.IntegralHeight = False
        Me.cmbNV.ItemHeight = 16
        Me.cmbNV.Location = New System.Drawing.Point(675, 89)
        Me.cmbNV.Name = "cmbNV"
        Me.cmbNV.Size = New System.Drawing.Size(192, 24)
        Me.cmbNV.TabIndex = 20
        Me.cmbNV.TabStop = False
        '
        'cmbSP
        '
        Me.cmbSP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSP.FormattingEnabled = True
        Me.cmbSP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbSP.IntegralHeight = False
        Me.cmbSP.ItemHeight = 16
        Me.cmbSP.Location = New System.Drawing.Point(49, 154)
        Me.cmbSP.Name = "cmbSP"
        Me.cmbSP.Size = New System.Drawing.Size(192, 24)
        Me.cmbSP.TabIndex = 60
        Me.cmbSP.TabStop = False
        '
        'cmbCH
        '
        Me.cmbCH.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbCH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCH.FormattingEnabled = True
        Me.cmbCH.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbCH.IntegralHeight = False
        Me.cmbCH.ItemHeight = 16
        Me.cmbCH.Location = New System.Drawing.Point(675, 159)
        Me.cmbCH.Name = "cmbCH"
        Me.cmbCH.Size = New System.Drawing.Size(192, 24)
        Me.cmbCH.TabIndex = 62
        Me.cmbCH.TabStop = False
        '
        'datetime
        '
        Me.datetime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datetime.Location = New System.Drawing.Point(352, 154)
        Me.datetime.Name = "datetime"
        Me.datetime.Size = New System.Drawing.Size(228, 22)
        Me.datetime.TabIndex = 63
        '
        'dgvHDN
        '
        Me.dgvHDN.AllowUserToAddRows = False
        Me.dgvHDN.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvHDN.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHDN.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvHDN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvHDN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHDN.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHDN.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvHDN.DoubleBuffered = True
        Me.dgvHDN.EnableHeadersVisualStyles = False
        Me.dgvHDN.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dgvHDN.HeaderForeColor = System.Drawing.Color.SeaGreen
        Me.dgvHDN.Location = New System.Drawing.Point(0, 424)
        Me.dgvHDN.Name = "dgvHDN"
        Me.dgvHDN.ReadOnly = True
        Me.dgvHDN.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvHDN.Size = New System.Drawing.Size(887, 259)
        Me.dgvHDN.TabIndex = 1
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
        Me.btnSearch.Location = New System.Drawing.Point(765, 378)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnSearch.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSearch.selected = False
        Me.btnSearch.Size = New System.Drawing.Size(105, 28)
        Me.btnSearch.TabIndex = 55
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSearch.Textcolor = System.Drawing.Color.White
        Me.btnSearch.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnUpdate.Location = New System.Drawing.Point(393, 308)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnUpdate.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUpdate.selected = False
        Me.btnUpdate.Size = New System.Drawing.Size(105, 28)
        Me.btnUpdate.TabIndex = 54
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
        Me.btnRemove.Location = New System.Drawing.Point(711, 308)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnRemove.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnRemove.OnHoverTextColor = System.Drawing.Color.White
        Me.btnRemove.selected = False
        Me.btnRemove.Size = New System.Drawing.Size(105, 28)
        Me.btnRemove.TabIndex = 53
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRemove.Textcolor = System.Drawing.Color.White
        Me.btnRemove.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtSearch.Location = New System.Drawing.Point(490, 384)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(223, 22)
        Me.txtSearch.TabIndex = 58
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(486, 362)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(56, 18)
        Me.BunifuCustomLabel11.TabIndex = 57
        Me.BunifuCustomLabel11.Text = "Srearch"
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
        Me.btnAdd.Location = New System.Drawing.Point(58, 308)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnAdd.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAdd.selected = False
        Me.btnAdd.Size = New System.Drawing.Size(105, 28)
        Me.btnAdd.TabIndex = 56
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAdd.Textcolor = System.Drawing.Color.White
        Me.btnAdd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cmbNhaCC
        '
        Me.cmbNhaCC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbNhaCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNhaCC.FormattingEnabled = True
        Me.cmbNhaCC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbNhaCC.IntegralHeight = False
        Me.cmbNhaCC.ItemHeight = 16
        Me.cmbNhaCC.Location = New System.Drawing.Point(354, 233)
        Me.cmbNhaCC.Name = "cmbNhaCC"
        Me.cmbNhaCC.Size = New System.Drawing.Size(192, 24)
        Me.cmbNhaCC.TabIndex = 71
        Me.cmbNhaCC.TabStop = False
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(46, 207)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(51, 18)
        Me.BunifuCustomLabel7.TabIndex = 70
        Me.BunifuCustomLabel7.Text = "Accede"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(351, 207)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(86, 18)
        Me.BunifuCustomLabel8.TabIndex = 69
        Me.BunifuCustomLabel8.Text = "ID Supplier"
        '
        'txtGiaNhap
        '
        Me.txtGiaNhap.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtGiaNhap.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtGiaNhap.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtGiaNhap.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtGiaNhap.BorderThickness = 1
        Me.txtGiaNhap.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGiaNhap.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtGiaNhap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtGiaNhap.isPassword = False
        Me.txtGiaNhap.Location = New System.Drawing.Point(49, 233)
        Me.txtGiaNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGiaNhap.Name = "txtGiaNhap"
        Me.txtGiaNhap.Size = New System.Drawing.Size(192, 22)
        Me.txtGiaNhap.TabIndex = 72
        Me.txtGiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'HoaDonBan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.BunifuCustomLabel11)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.dgvHDN)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "HoaDonBan"
        Me.Size = New System.Drawing.Size(887, 683)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvHDN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtSoLuong As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtMahdb As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cmbNV As ComboBox
    Friend WithEvents cmbCH As ComboBox
    Friend WithEvents cmbSP As ComboBox
    Friend WithEvents datetime As DateTimePicker
    Friend WithEvents dgvHDN As Bunifu.Framework.UI.BunifuCustomDataGrid
    Protected Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnRemove As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnAdd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cmbNhaCC As ComboBox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtGiaNhap As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
