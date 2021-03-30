<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_product_A161088
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_product_A161088))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.lbl_year = New System.Windows.Forms.Label()
        Me.pic_pro = New System.Windows.Forms.PictureBox()
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
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        CType(Me.pic_pro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(879, 412)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Return Main Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product List"
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(135, 410)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(205, 23)
        Me.txt_price.TabIndex = 148
        '
        'lbl_year
        '
        Me.lbl_year.AutoSize = True
        Me.lbl_year.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_year.Location = New System.Drawing.Point(63, 365)
        Me.lbl_year.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_year.Name = "lbl_year"
        Me.lbl_year.Size = New System.Drawing.Size(46, 24)
        Me.lbl_year.TabIndex = 147
        Me.lbl_year.Text = "Year"
        '
        'pic_pro
        '
        Me.pic_pro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_pro.Location = New System.Drawing.Point(580, 88)
        Me.pic_pro.Name = "pic_pro"
        Me.pic_pro.Size = New System.Drawing.Size(149, 159)
        Me.pic_pro.TabIndex = 146
        Me.pic_pro.TabStop = False
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(63, 266)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(59, 24)
        Me.lbl_name.TabIndex = 133
        Me.lbl_name.Text = "Name"
        '
        'lbl_rating
        '
        Me.lbl_rating.AutoSize = True
        Me.lbl_rating.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rating.Location = New System.Drawing.Point(552, 367)
        Me.lbl_rating.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_rating.Name = "lbl_rating"
        Me.lbl_rating.Size = New System.Drawing.Size(62, 24)
        Me.lbl_rating.TabIndex = 134
        Me.lbl_rating.Text = "Rating"
        '
        'lst_product
        '
        Me.lst_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_product.FormattingEnabled = True
        Me.lst_product.ItemHeight = 17
        Me.lst_product.Location = New System.Drawing.Point(67, 99)
        Me.lst_product.Margin = New System.Windows.Forms.Padding(4)
        Me.lst_product.Name = "lst_product"
        Me.lst_product.Size = New System.Drawing.Size(133, 140)
        Me.lst_product.TabIndex = 145
        '
        'lbl_location
        '
        Me.lbl_location.AutoSize = True
        Me.lbl_location.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_location.Location = New System.Drawing.Point(552, 314)
        Me.lbl_location.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_location.Name = "lbl_location"
        Me.lbl_location.Size = New System.Drawing.Size(80, 24)
        Me.lbl_location.TabIndex = 135
        Me.lbl_location.Text = "Location"
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_type.Location = New System.Drawing.Point(552, 264)
        Me.lbl_type.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(49, 24)
        Me.lbl_type.TabIndex = 136
        Me.lbl_type.Text = "Type"
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(135, 316)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(132, 23)
        Me.txt_id.TabIndex = 144
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(63, 315)
        Me.lbl_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(27, 24)
        Me.lbl_id.TabIndex = 137
        Me.lbl_id.Text = "ID"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(63, 410)
        Me.lbl_price.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(50, 24)
        Me.lbl_price.TabIndex = 143
        Me.lbl_price.Text = "Price"
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(135, 266)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(308, 23)
        Me.txt_name.TabIndex = 138
        '
        'txt_rating
        '
        Me.txt_rating.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rating.Location = New System.Drawing.Point(671, 367)
        Me.txt_rating.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_rating.Name = "txt_rating"
        Me.txt_rating.ReadOnly = True
        Me.txt_rating.Size = New System.Drawing.Size(131, 23)
        Me.txt_rating.TabIndex = 139
        '
        'txt_year
        '
        Me.txt_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_year.Location = New System.Drawing.Point(135, 367)
        Me.txt_year.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.ReadOnly = True
        Me.txt_year.Size = New System.Drawing.Size(205, 23)
        Me.txt_year.TabIndex = 142
        '
        'txt_location
        '
        Me.txt_location.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_location.Location = New System.Drawing.Point(671, 314)
        Me.txt_location.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.ReadOnly = True
        Me.txt_location.Size = New System.Drawing.Size(205, 23)
        Me.txt_location.TabIndex = 140
        '
        'txt_type
        '
        Me.txt_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_type.Location = New System.Drawing.Point(671, 268)
        Me.txt_type.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.ReadOnly = True
        Me.txt_type.Size = New System.Drawing.Size(132, 23)
        Me.txt_type.TabIndex = 141
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(909, 209)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(180, 38)
        Me.btn_update.TabIndex = 150
        Me.btn_update.Text = "Edit Product" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(909, 143)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(180, 38)
        Me.btn_insert.TabIndex = 149
        Me.btn_insert.Text = "Insert New Product" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'frm_product_A161088
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1158, 475)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.lbl_year)
        Me.Controls.Add(Me.pic_pro)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_rating)
        Me.Controls.Add(Me.lst_product)
        Me.Controls.Add(Me.lbl_location)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_rating)
        Me.Controls.Add(Me.txt_year)
        Me.Controls.Add(Me.txt_location)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frm_product_A161088"
        Me.Text = "frm_product_A161088"
        CType(Me.pic_pro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_price As System.Windows.Forms.TextBox
    Friend WithEvents lbl_year As System.Windows.Forms.Label
    Friend WithEvents pic_pro As System.Windows.Forms.PictureBox
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
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_insert As System.Windows.Forms.Button
End Class
