<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChucVu
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChucVu))
        Me.dgvChucVu = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnADD = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnRemove = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbID = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbName = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbNote = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtID = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtName = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtNote = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        CType(Me.dgvChucVu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvChucVu
        '
        Me.dgvChucVu.AllowUserToAddRows = False
        Me.dgvChucVu.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvChucVu.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvChucVu.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvChucVu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvChucVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvChucVu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChucVu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvChucVu.DoubleBuffered = True
        Me.dgvChucVu.EnableHeadersVisualStyles = False
        Me.dgvChucVu.HeaderBgColor = System.Drawing.Color.Silver
        Me.dgvChucVu.HeaderForeColor = System.Drawing.Color.Black
        Me.dgvChucVu.Location = New System.Drawing.Point(0, 259)
        Me.dgvChucVu.Name = "dgvChucVu"
        Me.dgvChucVu.ReadOnly = True
        Me.dgvChucVu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvChucVu.Size = New System.Drawing.Size(887, 424)
        Me.dgvChucVu.TabIndex = 0
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(28, 103)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(84, 18)
        Me.BunifuCustomLabel1.TabIndex = 1
        Me.BunifuCustomLabel1.Text = "ID Regency"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(339, 103)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(101, 18)
        Me.BunifuCustomLabel2.TabIndex = 2
        Me.BunifuCustomLabel2.Text = "Name Regency"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(644, 103)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(37, 18)
        Me.BunifuCustomLabel3.TabIndex = 3
        Me.BunifuCustomLabel3.Text = "Note"
        '
        'btnADD
        '
        Me.btnADD.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnADD.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnADD.BorderRadius = 0
        Me.btnADD.ButtonText = "ADD"
        Me.btnADD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnADD.DisabledColor = System.Drawing.Color.Gray
        Me.btnADD.Iconcolor = System.Drawing.Color.Transparent
        Me.btnADD.Iconimage = CType(resources.GetObject("btnADD.Iconimage"), System.Drawing.Image)
        Me.btnADD.Iconimage_right = Nothing
        Me.btnADD.Iconimage_right_Selected = Nothing
        Me.btnADD.Iconimage_Selected = Nothing
        Me.btnADD.IconMarginLeft = 0
        Me.btnADD.IconMarginRight = 0
        Me.btnADD.IconRightVisible = True
        Me.btnADD.IconRightZoom = 0R
        Me.btnADD.IconVisible = True
        Me.btnADD.IconZoom = 40.0R
        Me.btnADD.IsTab = False
        Me.btnADD.Location = New System.Drawing.Point(31, 212)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnADD.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnADD.OnHoverTextColor = System.Drawing.Color.White
        Me.btnADD.selected = False
        Me.btnADD.Size = New System.Drawing.Size(108, 26)
        Me.btnADD.TabIndex = 7
        Me.btnADD.Text = "ADD"
        Me.btnADD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnADD.Textcolor = System.Drawing.Color.White
        Me.btnADD.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnRemove.Location = New System.Drawing.Point(240, 212)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnRemove.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnRemove.OnHoverTextColor = System.Drawing.Color.White
        Me.btnRemove.selected = False
        Me.btnRemove.Size = New System.Drawing.Size(108, 26)
        Me.btnRemove.TabIndex = 8
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRemove.Textcolor = System.Drawing.Color.White
        Me.btnRemove.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnUpdate.Location = New System.Drawing.Point(462, 212)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnUpdate.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUpdate.selected = False
        Me.btnUpdate.Size = New System.Drawing.Size(108, 26)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnUpdate.Textcolor = System.Drawing.Color.White
        Me.btnUpdate.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSearch.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtSearch.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtSearch.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtSearch.BorderThickness = 3
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearch.isPassword = False
        Me.txtSearch.Location = New System.Drawing.Point(647, 217)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(218, 27)
        Me.txtSearch.TabIndex = 11
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(644, 194)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(50, 18)
        Me.BunifuCustomLabel4.TabIndex = 10
        Me.BunifuCustomLabel4.Text = "Search"
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.ForeColor = System.Drawing.Color.Red
        Me.lbID.Location = New System.Drawing.Point(28, 174)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(104, 13)
        Me.lbID.TabIndex = 12
        Me.lbID.Text = "BunifuCustomLabel5"
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.ForeColor = System.Drawing.Color.Red
        Me.lbName.Location = New System.Drawing.Point(339, 174)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(104, 13)
        Me.lbName.TabIndex = 13
        Me.lbName.Text = "BunifuCustomLabel5"
        '
        'lbNote
        '
        Me.lbNote.AutoSize = True
        Me.lbNote.ForeColor = System.Drawing.Color.Red
        Me.lbNote.Location = New System.Drawing.Point(644, 174)
        Me.lbNote.Name = "lbNote"
        Me.lbNote.Size = New System.Drawing.Size(104, 13)
        Me.lbNote.TabIndex = 14
        Me.lbNote.Text = "BunifuCustomLabel5"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.Yellow
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(210, 21)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(433, 50)
        Me.BunifuCustomLabel5.TabIndex = 15
        Me.BunifuCustomLabel5.Text = "Information Regency"
        '
        'txtID
        '
        Me.txtID.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtID.Location = New System.Drawing.Point(31, 138)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(190, 20)
        Me.txtID.TabIndex = 16
        '
        'txtName
        '
        Me.txtName.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtName.Location = New System.Drawing.Point(342, 138)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(190, 20)
        Me.txtName.TabIndex = 17
        '
        'txtNote
        '
        Me.txtNote.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtNote.Location = New System.Drawing.Point(647, 138)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(190, 20)
        Me.txtNote.TabIndex = 18
        '
        'ChucVu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.lbNote)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.lbID)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnADD)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.dgvChucVu)
        Me.Name = "ChucVu"
        Me.Size = New System.Drawing.Size(887, 683)
        CType(Me.dgvChucVu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvChucVu As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnADD As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnRemove As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbID As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbName As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbNote As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtID As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtName As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtNote As WindowsFormsControlLibrary1.BunifuCustomTextbox
End Class
