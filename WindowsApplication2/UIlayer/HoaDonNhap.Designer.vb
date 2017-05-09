<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HoaDonNhap
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DTdate = New System.Windows.Forms.DateTimePicker()
        Me.cmbIDSales = New System.Windows.Forms.ComboBox()
        Me.cmbNameSup = New System.Windows.Forms.ComboBox()
        Me.txtPhoneSup = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtAddStore = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtNameSales = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtAddress = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtIDInvoice = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbTextMoney = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel18 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtSumMoney = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cmbIDProduct = New System.Windows.Forms.ComboBox()
        Me.btnDele = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnPrint = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAdd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.dgvHDN = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.txthanhTien = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtGia = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel13 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtNamePro = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel14 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtSoLuong = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel15 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel17 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cmbNameStore = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvHDN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(349, 9)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(188, 34)
        Me.BunifuCustomLabel1.TabIndex = 3
        Me.BunifuCustomLabel1.Text = "Invoice input"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbNameStore)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel10)
        Me.GroupBox1.Controls.Add(Me.DTdate)
        Me.GroupBox1.Controls.Add(Me.cmbIDSales)
        Me.GroupBox1.Controls.Add(Me.cmbNameSup)
        Me.GroupBox1.Controls.Add(Me.txtPhoneSup)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel9)
        Me.GroupBox1.Controls.Add(Me.txtAddStore)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel8)
        Me.GroupBox1.Controls.Add(Me.txtNameSales)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel7)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel6)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel5)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel4)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel3)
        Me.GroupBox1.Controls.Add(Me.txtIDInvoice)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(852, 209)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information Invoice"
        '
        'DTdate
        '
        Me.DTdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTdate.Location = New System.Drawing.Point(44, 113)
        Me.DTdate.Name = "DTdate"
        Me.DTdate.Size = New System.Drawing.Size(211, 21)
        Me.DTdate.TabIndex = 18
        '
        'cmbIDSales
        '
        Me.cmbIDSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIDSales.FormattingEnabled = True
        Me.cmbIDSales.Location = New System.Drawing.Point(625, 49)
        Me.cmbIDSales.Name = "cmbIDSales"
        Me.cmbIDSales.Size = New System.Drawing.Size(185, 24)
        Me.cmbIDSales.TabIndex = 17
        '
        'cmbNameSup
        '
        Me.cmbNameSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNameSup.FormattingEnabled = True
        Me.cmbNameSup.Location = New System.Drawing.Point(340, 46)
        Me.cmbNameSup.Name = "cmbNameSup"
        Me.cmbNameSup.Size = New System.Drawing.Size(185, 24)
        Me.cmbNameSup.TabIndex = 16
        '
        'txtPhoneSup
        '
        Me.txtPhoneSup.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtPhoneSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneSup.Location = New System.Drawing.Point(341, 173)
        Me.txtPhoneSup.Name = "txtPhoneSup"
        Me.txtPhoneSup.Size = New System.Drawing.Size(185, 21)
        Me.txtPhoneSup.TabIndex = 15
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(338, 146)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(92, 15)
        Me.BunifuCustomLabel9.TabIndex = 14
        Me.BunifuCustomLabel9.Text = "Phone Supplier"
        '
        'txtAddStore
        '
        Me.txtAddStore.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtAddStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddStore.Location = New System.Drawing.Point(625, 173)
        Me.txtAddStore.Name = "txtAddStore"
        Me.txtAddStore.Size = New System.Drawing.Size(185, 21)
        Me.txtAddStore.TabIndex = 13
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(41, 146)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(73, 15)
        Me.BunifuCustomLabel8.TabIndex = 12
        Me.BunifuCustomLabel8.Text = "Name Store"
        '
        'txtNameSales
        '
        Me.txtNameSales.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtNameSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameSales.Location = New System.Drawing.Point(625, 115)
        Me.txtNameSales.Name = "txtNameSales"
        Me.txtNameSales.Size = New System.Drawing.Size(185, 21)
        Me.txtNameSales.TabIndex = 11
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(622, 88)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(100, 15)
        Me.BunifuCustomLabel7.TabIndex = 10
        Me.BunifuCustomLabel7.Text = "Name Salesman"
        '
        'txtAddress
        '
        Me.txtAddress.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(340, 115)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(185, 21)
        Me.txtAddress.TabIndex = 9
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(337, 88)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(100, 15)
        Me.BunifuCustomLabel6.TabIndex = 8
        Me.BunifuCustomLabel6.Text = "Address Supplier"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(41, 88)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(36, 15)
        Me.BunifuCustomLabel5.TabIndex = 6
        Me.BunifuCustomLabel5.Text = "Date "
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(337, 22)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(90, 15)
        Me.BunifuCustomLabel4.TabIndex = 4
        Me.BunifuCustomLabel4.Text = "Name Supplier"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(622, 22)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(78, 15)
        Me.BunifuCustomLabel3.TabIndex = 2
        Me.BunifuCustomLabel3.Text = "ID Salesman"
        '
        'txtIDInvoice
        '
        Me.txtIDInvoice.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtIDInvoice.Enabled = False
        Me.txtIDInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDInvoice.Location = New System.Drawing.Point(44, 49)
        Me.txtIDInvoice.Name = "txtIDInvoice"
        Me.txtIDInvoice.Size = New System.Drawing.Size(185, 21)
        Me.txtIDInvoice.TabIndex = 1
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(41, 22)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(60, 15)
        Me.BunifuCustomLabel2.TabIndex = 0
        Me.BunifuCustomLabel2.Text = "ID Invoice"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BunifuFlatButton1)
        Me.GroupBox2.Controls.Add(Me.BunifuFlatButton2)
        Me.GroupBox2.Controls.Add(Me.BunifuFlatButton3)
        Me.GroupBox2.Controls.Add(Me.lbTextMoney)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel18)
        Me.GroupBox2.Controls.Add(Me.txtSumMoney)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel11)
        Me.GroupBox2.Controls.Add(Me.cmbIDProduct)
        Me.GroupBox2.Controls.Add(Me.btnDele)
        Me.GroupBox2.Controls.Add(Me.btnPrint)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.dgvHDN)
        Me.GroupBox2.Controls.Add(Me.txthanhTien)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel12)
        Me.GroupBox2.Controls.Add(Me.txtGia)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel13)
        Me.GroupBox2.Controls.Add(Me.txtNamePro)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel14)
        Me.GroupBox2.Controls.Add(Me.txtSoLuong)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel15)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel17)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 261)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(852, 384)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information Product"
        '
        'lbTextMoney
        '
        Me.lbTextMoney.AutoSize = True
        Me.lbTextMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTextMoney.Location = New System.Drawing.Point(640, 346)
        Me.lbTextMoney.Name = "lbTextMoney"
        Me.lbTextMoney.Size = New System.Drawing.Size(129, 15)
        Me.lbTextMoney.TabIndex = 25
        Me.lbTextMoney.Text = "BunifuCustomLabel19"
        '
        'BunifuCustomLabel18
        '
        Me.BunifuCustomLabel18.AutoSize = True
        Me.BunifuCustomLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel18.Location = New System.Drawing.Point(513, 346)
        Me.BunifuCustomLabel18.Name = "BunifuCustomLabel18"
        Me.BunifuCustomLabel18.Size = New System.Drawing.Size(79, 15)
        Me.BunifuCustomLabel18.TabIndex = 24
        Me.BunifuCustomLabel18.Text = "Text Money : "
        '
        'txtSumMoney
        '
        Me.txtSumMoney.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtSumMoney.Enabled = False
        Me.txtSumMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSumMoney.Location = New System.Drawing.Point(643, 300)
        Me.txtSumMoney.Name = "txtSumMoney"
        Me.txtSumMoney.Size = New System.Drawing.Size(185, 21)
        Me.txtSumMoney.TabIndex = 23
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(513, 303)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(73, 15)
        Me.BunifuCustomLabel11.TabIndex = 22
        Me.BunifuCustomLabel11.Text = "Sum money"
        '
        'cmbIDProduct
        '
        Me.cmbIDProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIDProduct.FormattingEnabled = True
        Me.cmbIDProduct.Location = New System.Drawing.Point(37, 49)
        Me.cmbIDProduct.Name = "cmbIDProduct"
        Me.cmbIDProduct.Size = New System.Drawing.Size(185, 24)
        Me.cmbIDProduct.TabIndex = 21
        '
        'btnDele
        '
        Me.btnDele.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnDele.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnDele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDele.BorderRadius = 0
        Me.btnDele.ButtonText = "DeleteProduct"
        Me.btnDele.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDele.DisabledColor = System.Drawing.Color.Gray
        Me.btnDele.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDele.Iconimage = Nothing
        Me.btnDele.Iconimage_right = Nothing
        Me.btnDele.Iconimage_right_Selected = Nothing
        Me.btnDele.Iconimage_Selected = Nothing
        Me.btnDele.IconMarginLeft = 0
        Me.btnDele.IconMarginRight = 0
        Me.btnDele.IconRightVisible = True
        Me.btnDele.IconRightZoom = 0R
        Me.btnDele.IconVisible = True
        Me.btnDele.IconZoom = 90.0R
        Me.btnDele.IsTab = False
        Me.btnDele.Location = New System.Drawing.Point(250, 488)
        Me.btnDele.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.btnDele.Name = "btnDele"
        Me.btnDele.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnDele.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnDele.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDele.selected = False
        Me.btnDele.Size = New System.Drawing.Size(198, 51)
        Me.btnDele.TabIndex = 15
        Me.btnDele.Text = "DeleteProduct"
        Me.btnDele.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDele.Textcolor = System.Drawing.Color.White
        Me.btnDele.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnPrint
        '
        Me.btnPrint.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrint.BorderRadius = 0
        Me.btnPrint.ButtonText = "Print Invoice"
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.DisabledColor = System.Drawing.Color.Gray
        Me.btnPrint.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPrint.Iconimage = Nothing
        Me.btnPrint.Iconimage_right = Nothing
        Me.btnPrint.Iconimage_right_Selected = Nothing
        Me.btnPrint.Iconimage_Selected = Nothing
        Me.btnPrint.IconMarginLeft = 0
        Me.btnPrint.IconMarginRight = 0
        Me.btnPrint.IconRightVisible = True
        Me.btnPrint.IconRightZoom = 0R
        Me.btnPrint.IconVisible = True
        Me.btnPrint.IconZoom = 90.0R
        Me.btnPrint.IsTab = False
        Me.btnPrint.Location = New System.Drawing.Point(486, 488)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnPrint.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnPrint.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPrint.selected = False
        Me.btnPrint.Size = New System.Drawing.Size(198, 51)
        Me.btnPrint.TabIndex = 14
        Me.btnPrint.Text = "Print Invoice"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnPrint.Textcolor = System.Drawing.Color.White
        Me.btnPrint.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAdd
        '
        Me.btnAdd.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.BorderRadius = 0
        Me.btnAdd.ButtonText = "Add Product"
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.DisabledColor = System.Drawing.Color.Gray
        Me.btnAdd.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAdd.Iconimage = Nothing
        Me.btnAdd.Iconimage_right = Nothing
        Me.btnAdd.Iconimage_right_Selected = Nothing
        Me.btnAdd.Iconimage_Selected = Nothing
        Me.btnAdd.IconMarginLeft = 0
        Me.btnAdd.IconMarginRight = 0
        Me.btnAdd.IconRightVisible = True
        Me.btnAdd.IconRightZoom = 0R
        Me.btnAdd.IconVisible = True
        Me.btnAdd.IconZoom = 90.0R
        Me.btnAdd.IsTab = False
        Me.btnAdd.Location = New System.Drawing.Point(10, 488)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnAdd.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAdd.selected = False
        Me.btnAdd.Size = New System.Drawing.Size(198, 51)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add Product"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAdd.Textcolor = System.Drawing.Color.White
        Me.btnAdd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dgvHDN
        '
        Me.dgvHDN.AllowUserToAddRows = False
        Me.dgvHDN.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvHDN.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvHDN.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvHDN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvHDN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHDN.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHDN.DoubleBuffered = True
        Me.dgvHDN.EnableHeadersVisualStyles = False
        Me.dgvHDN.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dgvHDN.HeaderForeColor = System.Drawing.Color.SeaGreen
        Me.dgvHDN.Location = New System.Drawing.Point(6, 153)
        Me.dgvHDN.Name = "dgvHDN"
        Me.dgvHDN.ReadOnly = True
        Me.dgvHDN.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvHDN.Size = New System.Drawing.Size(840, 134)
        Me.dgvHDN.TabIndex = 12
        '
        'txthanhTien
        '
        Me.txthanhTien.BorderColor = System.Drawing.Color.SeaGreen
        Me.txthanhTien.Enabled = False
        Me.txthanhTien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthanhTien.Location = New System.Drawing.Point(625, 49)
        Me.txthanhTien.Name = "txthanhTien"
        Me.txthanhTien.Size = New System.Drawing.Size(185, 21)
        Me.txthanhTien.TabIndex = 11
        '
        'txtGia
        '
        Me.txtGia.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtGia.Enabled = False
        Me.txtGia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGia.Location = New System.Drawing.Point(333, 109)
        Me.txtGia.Name = "txtGia"
        Me.txtGia.Size = New System.Drawing.Size(185, 21)
        Me.txtGia.TabIndex = 9
        '
        'BunifuCustomLabel13
        '
        Me.BunifuCustomLabel13.AutoSize = True
        Me.BunifuCustomLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel13.Location = New System.Drawing.Point(330, 82)
        Me.BunifuCustomLabel13.Name = "BunifuCustomLabel13"
        Me.BunifuCustomLabel13.Size = New System.Drawing.Size(80, 15)
        Me.BunifuCustomLabel13.TabIndex = 8
        Me.BunifuCustomLabel13.Text = "Price Product"
        '
        'txtNamePro
        '
        Me.txtNamePro.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtNamePro.Enabled = False
        Me.txtNamePro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamePro.Location = New System.Drawing.Point(37, 109)
        Me.txtNamePro.Name = "txtNamePro"
        Me.txtNamePro.Size = New System.Drawing.Size(185, 21)
        Me.txtNamePro.TabIndex = 7
        '
        'BunifuCustomLabel14
        '
        Me.BunifuCustomLabel14.AutoSize = True
        Me.BunifuCustomLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel14.Location = New System.Drawing.Point(34, 82)
        Me.BunifuCustomLabel14.Name = "BunifuCustomLabel14"
        Me.BunifuCustomLabel14.Size = New System.Drawing.Size(86, 15)
        Me.BunifuCustomLabel14.TabIndex = 6
        Me.BunifuCustomLabel14.Text = "Name Product"
        '
        'txtSoLuong
        '
        Me.txtSoLuong.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtSoLuong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoLuong.Location = New System.Drawing.Point(333, 49)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(185, 21)
        Me.txtSoLuong.TabIndex = 5
        '
        'BunifuCustomLabel15
        '
        Me.BunifuCustomLabel15.AutoSize = True
        Me.BunifuCustomLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel15.Location = New System.Drawing.Point(330, 22)
        Me.BunifuCustomLabel15.Name = "BunifuCustomLabel15"
        Me.BunifuCustomLabel15.Size = New System.Drawing.Size(97, 15)
        Me.BunifuCustomLabel15.TabIndex = 4
        Me.BunifuCustomLabel15.Text = "Number Product"
        '
        'BunifuCustomLabel17
        '
        Me.BunifuCustomLabel17.AutoSize = True
        Me.BunifuCustomLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel17.Location = New System.Drawing.Point(34, 22)
        Me.BunifuCustomLabel17.Name = "BunifuCustomLabel17"
        Me.BunifuCustomLabel17.Size = New System.Drawing.Size(64, 15)
        Me.BunifuCustomLabel17.TabIndex = 0
        Me.BunifuCustomLabel17.Text = "ID Product"
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.Silver
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(622, 146)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(83, 15)
        Me.BunifuCustomLabel10.TabIndex = 19
        Me.BunifuCustomLabel10.Text = "Address Store"
        '
        'cmbNameStore
        '
        Me.cmbNameStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNameStore.FormattingEnabled = True
        Me.cmbNameStore.Location = New System.Drawing.Point(44, 173)
        Me.cmbNameStore.Name = "cmbNameStore"
        Me.cmbNameStore.Size = New System.Drawing.Size(185, 24)
        Me.cmbNameStore.TabIndex = 20
        '
        'BunifuCustomLabel12
        '
        Me.BunifuCustomLabel12.AutoSize = True
        Me.BunifuCustomLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel12.Location = New System.Drawing.Point(622, 22)
        Me.BunifuCustomLabel12.Name = "BunifuCustomLabel12"
        Me.BunifuCustomLabel12.Size = New System.Drawing.Size(89, 15)
        Me.BunifuCustomLabel12.TabIndex = 10
        Me.BunifuCustomLabel12.Text = "Money Product"
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "DeleteProduct"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(173, 314)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(121, 33)
        Me.BunifuFlatButton1.TabIndex = 28
        Me.BunifuFlatButton1.Text = "DeleteProduct"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Print Invoice"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Nothing
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(341, 314)
        Me.BunifuFlatButton2.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(121, 33)
        Me.BunifuFlatButton2.TabIndex = 27
        Me.BunifuFlatButton2.Text = "Print Invoice"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "Add Product"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = Nothing
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 90.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(20, 314)
        Me.BunifuFlatButton3.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(121, 33)
        Me.BunifuFlatButton3.TabIndex = 26
        Me.BunifuFlatButton3.Text = "Add Product"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'HoaDonNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Name = "HoaDonNhap"
        Me.Size = New System.Drawing.Size(887, 683)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvHDN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DTdate As DateTimePicker
    Friend WithEvents cmbIDSales As ComboBox
    Friend WithEvents cmbNameSup As ComboBox
    Friend WithEvents txtPhoneSup As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtAddStore As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtNameSales As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtAddress As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtIDInvoice As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbTextMoney As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel18 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtSumMoney As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cmbIDProduct As ComboBox
    Friend WithEvents btnDele As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnPrint As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnAdd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dgvHDN As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents txthanhTien As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtGia As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel13 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtNamePro As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel14 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtSoLuong As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel15 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel17 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cmbNameStore As ComboBox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel12 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
End Class
