<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orderdetail_A161088
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_orderdetail_A161088))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_orderid = New System.Windows.Forms.TextBox()
        Me.pic_pro = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_cust_tel = New System.Windows.Forms.TextBox()
        Me.list_cust = New System.Windows.Forms.ListBox()
        Me.txt_cust_name = New System.Windows.Forms.TextBox()
        Me.lbl_cust_name = New System.Windows.Forms.Label()
        Me.lbl_cust_tel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.order_quantity = New System.Windows.Forms.NumericUpDown()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.lbl_year = New System.Windows.Forms.Label()
        Me.txt_sub = New System.Windows.Forms.TextBox()
        Me.lbl_sub = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_rating = New System.Windows.Forms.Label()
        Me.lst_product = New System.Windows.Forms.ListBox()
        Me.lbl_location = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_rating = New System.Windows.Forms.TextBox()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.txt_location = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pick_date = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_staff_tel = New System.Windows.Forms.TextBox()
        Me.list_staff = New System.Windows.Forms.ListBox()
        Me.txt_staff_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.ORDER_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prd_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prd_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prd_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prd_quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        CType(Me.pic_pro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.order_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order Detail"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1314, 831)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(240, 46)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Return Main Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_orderid
        '
        Me.txt_orderid.Location = New System.Drawing.Point(416, 55)
        Me.txt_orderid.Name = "txt_orderid"
        Me.txt_orderid.ReadOnly = True
        Me.txt_orderid.Size = New System.Drawing.Size(100, 22)
        Me.txt_orderid.TabIndex = 131
        '
        'pic_pro
        '
        Me.pic_pro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_pro.Location = New System.Drawing.Point(534, 30)
        Me.pic_pro.Name = "pic_pro"
        Me.pic_pro.Size = New System.Drawing.Size(149, 159)
        Me.pic_pro.TabIndex = 130
        Me.pic_pro.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.Controls.Add(Me.txt_cust_tel)
        Me.GroupBox3.Controls.Add(Me.list_cust)
        Me.GroupBox3.Controls.Add(Me.txt_cust_name)
        Me.GroupBox3.Controls.Add(Me.lbl_cust_name)
        Me.GroupBox3.Controls.Add(Me.lbl_cust_tel)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(948, 276)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(399, 229)
        Me.GroupBox3.TabIndex = 129
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customer List"
        '
        'txt_cust_tel
        '
        Me.txt_cust_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cust_tel.Location = New System.Drawing.Point(173, 185)
        Me.txt_cust_tel.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cust_tel.Name = "txt_cust_tel"
        Me.txt_cust_tel.ReadOnly = True
        Me.txt_cust_tel.Size = New System.Drawing.Size(205, 23)
        Me.txt_cust_tel.TabIndex = 119
        '
        'list_cust
        '
        Me.list_cust.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_cust.FormattingEnabled = True
        Me.list_cust.ItemHeight = 17
        Me.list_cust.Location = New System.Drawing.Point(29, 50)
        Me.list_cust.Margin = New System.Windows.Forms.Padding(4)
        Me.list_cust.Name = "list_cust"
        Me.list_cust.Size = New System.Drawing.Size(83, 72)
        Me.list_cust.TabIndex = 114
        '
        'txt_cust_name
        '
        Me.txt_cust_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cust_name.Location = New System.Drawing.Point(173, 135)
        Me.txt_cust_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cust_name.Name = "txt_cust_name"
        Me.txt_cust_name.ReadOnly = True
        Me.txt_cust_name.Size = New System.Drawing.Size(205, 23)
        Me.txt_cust_name.TabIndex = 120
        '
        'lbl_cust_name
        '
        Me.lbl_cust_name.AutoSize = True
        Me.lbl_cust_name.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cust_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_cust_name.Location = New System.Drawing.Point(25, 135)
        Me.lbl_cust_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cust_name.Name = "lbl_cust_name"
        Me.lbl_cust_name.Size = New System.Drawing.Size(59, 24)
        Me.lbl_cust_name.TabIndex = 117
        Me.lbl_cust_name.Text = "Name"
        '
        'lbl_cust_tel
        '
        Me.lbl_cust_tel.AutoSize = True
        Me.lbl_cust_tel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cust_tel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_cust_tel.Location = New System.Drawing.Point(25, 183)
        Me.lbl_cust_tel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cust_tel.Name = "lbl_cust_tel"
        Me.lbl_cust_tel.Size = New System.Drawing.Size(131, 24)
        Me.lbl_cust_tel.TabIndex = 118
        Me.lbl_cust_tel.Text = "Telephone No."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.lbl_quantity)
        Me.GroupBox1.Controls.Add(Me.order_quantity)
        Me.GroupBox1.Controls.Add(Me.txt_price)
        Me.GroupBox1.Controls.Add(Me.lbl_year)
        Me.GroupBox1.Controls.Add(Me.txt_sub)
        Me.GroupBox1.Controls.Add(Me.lbl_sub)
        Me.GroupBox1.Controls.Add(Me.pic_pro)
        Me.GroupBox1.Controls.Add(Me.pic_product)
        Me.GroupBox1.Controls.Add(Me.lbl_name)
        Me.GroupBox1.Controls.Add(Me.lbl_rating)
        Me.GroupBox1.Controls.Add(Me.lst_product)
        Me.GroupBox1.Controls.Add(Me.lbl_location)
        Me.GroupBox1.Controls.Add(Me.lbl_type)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.lbl_id)
        Me.GroupBox1.Controls.Add(Me.lbl_price)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.txt_rating)
        Me.GroupBox1.Controls.Add(Me.txt_year)
        Me.GroupBox1.Controls.Add(Me.txt_location)
        Me.GroupBox1.Controls.Add(Me.txt_type)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(32, 93)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(867, 432)
        Me.GroupBox1.TabIndex = 132
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product List"
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_quantity.Location = New System.Drawing.Point(139, 398)
        Me.lbl_quantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(82, 24)
        Me.lbl_quantity.TabIndex = 134
        Me.lbl_quantity.Text = "Quantity"
        '
        'order_quantity
        '
        Me.order_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.order_quantity.Location = New System.Drawing.Point(237, 401)
        Me.order_quantity.Margin = New System.Windows.Forms.Padding(4)
        Me.order_quantity.Name = "order_quantity"
        Me.order_quantity.Size = New System.Drawing.Size(160, 23)
        Me.order_quantity.TabIndex = 133
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(89, 352)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(205, 23)
        Me.txt_price.TabIndex = 132
        '
        'lbl_year
        '
        Me.lbl_year.AutoSize = True
        Me.lbl_year.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_year.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_year.Location = New System.Drawing.Point(17, 307)
        Me.lbl_year.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_year.Name = "lbl_year"
        Me.lbl_year.Size = New System.Drawing.Size(46, 24)
        Me.lbl_year.TabIndex = 131
        Me.lbl_year.Text = "Year"
        '
        'txt_sub
        '
        Me.txt_sub.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sub.Location = New System.Drawing.Point(624, 374)
        Me.txt_sub.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_sub.Name = "txt_sub"
        Me.txt_sub.ReadOnly = True
        Me.txt_sub.Size = New System.Drawing.Size(132, 23)
        Me.txt_sub.TabIndex = 114
        '
        'lbl_sub
        '
        Me.lbl_sub.AutoSize = True
        Me.lbl_sub.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sub.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_sub.Location = New System.Drawing.Point(506, 374)
        Me.lbl_sub.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_sub.Name = "lbl_sub"
        Me.lbl_sub.Size = New System.Drawing.Size(87, 24)
        Me.lbl_sub.TabIndex = 113
        Me.lbl_sub.Text = "Sub Total"
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(1381, 41)
        Me.pic_product.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(151, 148)
        Me.pic_product.TabIndex = 104
        Me.pic_product.TabStop = False
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_name.Location = New System.Drawing.Point(17, 208)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(59, 24)
        Me.lbl_name.TabIndex = 93
        Me.lbl_name.Text = "Name"
        '
        'lbl_rating
        '
        Me.lbl_rating.AutoSize = True
        Me.lbl_rating.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rating.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_rating.Location = New System.Drawing.Point(506, 309)
        Me.lbl_rating.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_rating.Name = "lbl_rating"
        Me.lbl_rating.Size = New System.Drawing.Size(62, 24)
        Me.lbl_rating.TabIndex = 94
        Me.lbl_rating.Text = "Rating"
        '
        'lst_product
        '
        Me.lst_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_product.FormattingEnabled = True
        Me.lst_product.ItemHeight = 17
        Me.lst_product.Location = New System.Drawing.Point(21, 41)
        Me.lst_product.Margin = New System.Windows.Forms.Padding(4)
        Me.lst_product.Name = "lst_product"
        Me.lst_product.Size = New System.Drawing.Size(133, 140)
        Me.lst_product.TabIndex = 110
        '
        'lbl_location
        '
        Me.lbl_location.AutoSize = True
        Me.lbl_location.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_location.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_location.Location = New System.Drawing.Point(506, 256)
        Me.lbl_location.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_location.Name = "lbl_location"
        Me.lbl_location.Size = New System.Drawing.Size(80, 24)
        Me.lbl_location.TabIndex = 95
        Me.lbl_location.Text = "Location"
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_type.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_type.Location = New System.Drawing.Point(506, 206)
        Me.lbl_type.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(49, 24)
        Me.lbl_type.TabIndex = 96
        Me.lbl_type.Text = "Type"
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(89, 258)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(132, 23)
        Me.txt_id.TabIndex = 107
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_id.Location = New System.Drawing.Point(17, 257)
        Me.lbl_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(27, 24)
        Me.lbl_id.TabIndex = 97
        Me.lbl_id.Text = "ID"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_price.Location = New System.Drawing.Point(17, 352)
        Me.lbl_price.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(50, 24)
        Me.lbl_price.TabIndex = 106
        Me.lbl_price.Text = "Price"
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(89, 208)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(308, 23)
        Me.txt_name.TabIndex = 98
        '
        'txt_rating
        '
        Me.txt_rating.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rating.Location = New System.Drawing.Point(625, 309)
        Me.txt_rating.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_rating.Name = "txt_rating"
        Me.txt_rating.ReadOnly = True
        Me.txt_rating.Size = New System.Drawing.Size(131, 23)
        Me.txt_rating.TabIndex = 99
        '
        'txt_year
        '
        Me.txt_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_year.Location = New System.Drawing.Point(89, 309)
        Me.txt_year.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.ReadOnly = True
        Me.txt_year.Size = New System.Drawing.Size(205, 23)
        Me.txt_year.TabIndex = 102
        '
        'txt_location
        '
        Me.txt_location.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_location.Location = New System.Drawing.Point(625, 256)
        Me.txt_location.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.ReadOnly = True
        Me.txt_location.Size = New System.Drawing.Size(205, 23)
        Me.txt_location.TabIndex = 100
        '
        'txt_type
        '
        Me.txt_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_type.Location = New System.Drawing.Point(625, 210)
        Me.txt_type.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.ReadOnly = True
        Me.txt_type.Size = New System.Drawing.Size(132, 23)
        Me.txt_type.TabIndex = 101
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(270, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 27)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "Order ID："
        '
        'pick_date
        '
        Me.pick_date.Location = New System.Drawing.Point(605, 53)
        Me.pick_date.Name = "pick_date"
        Me.pick_date.Size = New System.Drawing.Size(200, 22)
        Me.pick_date.TabIndex = 135
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.txt_staff_tel)
        Me.GroupBox2.Controls.Add(Me.list_staff)
        Me.GroupBox2.Controls.Add(Me.txt_staff_name)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(948, 30)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(399, 229)
        Me.GroupBox2.TabIndex = 136
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Staff List"
        '
        'txt_staff_tel
        '
        Me.txt_staff_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staff_tel.Location = New System.Drawing.Point(173, 185)
        Me.txt_staff_tel.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_staff_tel.Name = "txt_staff_tel"
        Me.txt_staff_tel.ReadOnly = True
        Me.txt_staff_tel.Size = New System.Drawing.Size(205, 23)
        Me.txt_staff_tel.TabIndex = 119
        '
        'list_staff
        '
        Me.list_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_staff.FormattingEnabled = True
        Me.list_staff.ItemHeight = 17
        Me.list_staff.Location = New System.Drawing.Point(29, 50)
        Me.list_staff.Margin = New System.Windows.Forms.Padding(4)
        Me.list_staff.Name = "list_staff"
        Me.list_staff.Size = New System.Drawing.Size(83, 72)
        Me.list_staff.TabIndex = 114
        '
        'txt_staff_name
        '
        Me.txt_staff_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staff_name.Location = New System.Drawing.Point(173, 135)
        Me.txt_staff_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_staff_name.Name = "txt_staff_name"
        Me.txt_staff_name.ReadOnly = True
        Me.txt_staff_name.Size = New System.Drawing.Size(205, 23)
        Me.txt_staff_name.TabIndex = 120
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(25, 135)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 24)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(25, 183)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 24)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "Telephone No."
        '
        'grd_order
        '
        Me.grd_order.AllowUserToAddRows = False
        Me.grd_order.AllowUserToDeleteRows = False
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ORDER_DATE, Me.prd_id, Me.prd_name, Me.prd_price, Me.prd_quantity, Me.subtotal})
        Me.grd_order.Location = New System.Drawing.Point(32, 593)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.RowTemplate.Height = 24
        Me.grd_order.Size = New System.Drawing.Size(1306, 186)
        Me.grd_order.TabIndex = 137
        '
        'ORDER_DATE
        '
        Me.ORDER_DATE.HeaderText = "ORDER DATE"
        Me.ORDER_DATE.Name = "ORDER_DATE"
        Me.ORDER_DATE.Width = 200
        '
        'prd_id
        '
        Me.prd_id.HeaderText = "PRODUCT ID"
        Me.prd_id.Name = "prd_id"
        '
        'prd_name
        '
        Me.prd_name.HeaderText = "PRODUCT Name"
        Me.prd_name.Name = "prd_name"
        Me.prd_name.Width = 550
        '
        'prd_price
        '
        Me.prd_price.HeaderText = "PRICE"
        Me.prd_price.Name = "prd_price"
        '
        'prd_quantity
        '
        Me.prd_quantity.HeaderText = "QUANTITY"
        Me.prd_quantity.Name = "prd_quantity"
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "SUB TOTAL"
        Me.subtotal.Name = "subtotal"
        '
        'btn_order
        '
        Me.btn_order.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order.Location = New System.Drawing.Point(733, 533)
        Me.btn_order.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(166, 38)
        Me.btn_order.TabIndex = 138
        Me.btn_order.Text = "Add Order"
        Me.btn_order.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(73, 799)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(166, 34)
        Me.btn_delete.TabIndex = 139
        Me.btn_delete.Text = "Delete Order"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_confirm
        '
        Me.btn_confirm.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm.Location = New System.Drawing.Point(269, 799)
        Me.btn_confirm.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(165, 34)
        Me.btn_confirm.TabIndex = 140
        Me.btn_confirm.Text = "Confirm Order"
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(1079, 799)
        Me.lbl_total.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(51, 24)
        Me.lbl_total.TabIndex = 142
        Me.lbl_total.Text = "Total"
        '
        'txt_total
        '
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(1138, 799)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(132, 23)
        Me.txt_total.TabIndex = 141
        '
        'frm_orderdetail_A161088
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Snow
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1651, 822)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.grd_order)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.pick_date)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_orderid)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_orderdetail_A161088"
        Me.Text = "frm_orderdetail_A161088"
        CType(Me.pic_pro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.order_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_orderid As System.Windows.Forms.TextBox
    Friend WithEvents pic_pro As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cust_tel As System.Windows.Forms.TextBox
    Friend WithEvents list_cust As System.Windows.Forms.ListBox
    Friend WithEvents txt_cust_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cust_name As System.Windows.Forms.Label
    Friend WithEvents lbl_cust_tel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_sub As System.Windows.Forms.TextBox
    Friend WithEvents lbl_sub As System.Windows.Forms.Label
    Friend WithEvents pic_product As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents lbl_rating As System.Windows.Forms.Label
    Friend WithEvents lst_product As System.Windows.Forms.ListBox
    Friend WithEvents lbl_location As System.Windows.Forms.Label
    Friend WithEvents lbl_type As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents lbl_price As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_rating As System.Windows.Forms.TextBox
    Friend WithEvents txt_year As System.Windows.Forms.TextBox
    Friend WithEvents txt_location As System.Windows.Forms.TextBox
    Friend WithEvents txt_type As System.Windows.Forms.TextBox
    Friend WithEvents txt_price As System.Windows.Forms.TextBox
    Friend WithEvents lbl_year As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pick_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_staff_tel As System.Windows.Forms.TextBox
    Friend WithEvents list_staff As System.Windows.Forms.ListBox
    Friend WithEvents txt_staff_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents order_quantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents grd_order As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_quantity As System.Windows.Forms.Label
    Friend WithEvents btn_order As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_confirm As System.Windows.Forms.Button
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents ORDER_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prd_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prd_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prd_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prd_quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
