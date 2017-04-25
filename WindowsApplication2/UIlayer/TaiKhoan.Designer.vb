<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaiKhoan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TaiKhoan))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtGhiChu = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnRemove = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAdd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtMaTK = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dgvTaiKhoan = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        CType(Me.dgvTaiKhoan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnSearch.Location = New System.Drawing.Point(752, 226)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnSearch.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSearch.selected = False
        Me.btnSearch.Size = New System.Drawing.Size(105, 28)
        Me.btnSearch.TabIndex = 68
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSearch.Textcolor = System.Drawing.Color.White
        Me.btnSearch.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtSearch.Location = New System.Drawing.Point(491, 235)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(223, 19)
        Me.txtSearch.TabIndex = 67
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(487, 201)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(56, 18)
        Me.BunifuCustomLabel11.TabIndex = 66
        Me.BunifuCustomLabel11.Text = "Srearch"
        '
        'txtGhiChu
        '
        Me.txtGhiChu.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtGhiChu.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtGhiChu.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtGhiChu.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtGhiChu.BorderThickness = 1
        Me.txtGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGhiChu.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtGhiChu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtGhiChu.isPassword = False
        Me.txtGhiChu.Location = New System.Drawing.Point(669, 45)
        Me.txtGhiChu.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(203, 20)
        Me.txtGhiChu.TabIndex = 64
        Me.txtGhiChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(666, 11)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(37, 18)
        Me.BunifuCustomLabel3.TabIndex = 63
        Me.BunifuCustomLabel3.Text = "Note"
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
        Me.btnUpdate.Location = New System.Drawing.Point(669, 133)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnUpdate.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUpdate.selected = False
        Me.btnUpdate.Size = New System.Drawing.Size(105, 28)
        Me.btnUpdate.TabIndex = 61
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
        Me.btnRemove.Location = New System.Drawing.Point(412, 133)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnRemove.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnRemove.OnHoverTextColor = System.Drawing.Color.White
        Me.btnRemove.selected = False
        Me.btnRemove.Size = New System.Drawing.Size(105, 28)
        Me.btnRemove.TabIndex = 60
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
        Me.btnAdd.Location = New System.Drawing.Point(154, 133)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnAdd.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAdd.selected = False
        Me.btnAdd.Size = New System.Drawing.Size(105, 28)
        Me.btnAdd.TabIndex = 59
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAdd.Textcolor = System.Drawing.Color.White
        Me.btnAdd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtName.Location = New System.Drawing.Point(350, 45)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(226, 19)
        Me.txtName.TabIndex = 57
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(347, 11)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(68, 18)
        Me.BunifuCustomLabel6.TabIndex = 56
        Me.BunifuCustomLabel6.Text = "Password"
        '
        'txtMaTK
        '
        Me.txtMaTK.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtMaTK.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtMaTK.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMaTK.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.txtMaTK.BorderThickness = 1
        Me.txtMaTK.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMaTK.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMaTK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtMaTK.isPassword = False
        Me.txtMaTK.Location = New System.Drawing.Point(43, 45)
        Me.txtMaTK.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaTK.Name = "txtMaTK"
        Me.txtMaTK.Size = New System.Drawing.Size(216, 19)
        Me.txtMaTK.TabIndex = 54
        Me.txtMaTK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(40, 11)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(84, 18)
        Me.BunifuCustomLabel1.TabIndex = 53
        Me.BunifuCustomLabel1.Text = "ID Account"
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
        Me.dgvTaiKhoan.Location = New System.Drawing.Point(24, 275)
        Me.dgvTaiKhoan.Name = "dgvTaiKhoan"
        Me.dgvTaiKhoan.ReadOnly = True
        Me.dgvTaiKhoan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTaiKhoan.Size = New System.Drawing.Size(848, 313)
        Me.dgvTaiKhoan.TabIndex = 69
        '
        'TaiKhoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Controls.Add(Me.dgvTaiKhoan)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.BunifuCustomLabel11)
        Me.Controls.Add(Me.txtGhiChu)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.txtMaTK)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Name = "TaiKhoan"
        Me.Size = New System.Drawing.Size(887, 683)
        CType(Me.dgvTaiKhoan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtGhiChu As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnRemove As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnAdd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtMaTK As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dgvTaiKhoan As Bunifu.Framework.UI.BunifuCustomDataGrid
End Class
