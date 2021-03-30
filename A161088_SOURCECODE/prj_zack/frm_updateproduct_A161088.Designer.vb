<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updateproduct_A161088
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_rating = New System.Windows.Forms.Label()
        Me.lbl_year = New System.Windows.Forms.Label()
        Me.lbl_location = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_rating = New System.Windows.Forms.TextBox()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_location = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(16, 19)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(226, 32)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Update Product"
        '
        'grd_product
        '
        Me.grd_product.AllowUserToAddRows = False
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(22, 64)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.ReadOnly = True
        Me.grd_product.RowTemplate.Height = 24
        Me.grd_product.Size = New System.Drawing.Size(616, 210)
        Me.grd_product.TabIndex = 1
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.Location = New System.Drawing.Point(381, 378)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(40, 17)
        Me.lbl_type.TabIndex = 30
        Me.lbl_type.Text = "Type"
        '
        'lbl_rating
        '
        Me.lbl_rating.AutoSize = True
        Me.lbl_rating.Location = New System.Drawing.Point(381, 350)
        Me.lbl_rating.Name = "lbl_rating"
        Me.lbl_rating.Size = New System.Drawing.Size(49, 17)
        Me.lbl_rating.TabIndex = 29
        Me.lbl_rating.Text = "Rating"
        '
        'lbl_year
        '
        Me.lbl_year.AutoSize = True
        Me.lbl_year.Location = New System.Drawing.Point(381, 322)
        Me.lbl_year.Name = "lbl_year"
        Me.lbl_year.Size = New System.Drawing.Size(38, 17)
        Me.lbl_year.TabIndex = 28
        Me.lbl_year.Text = "Year"
        '
        'lbl_location
        '
        Me.lbl_location.AutoSize = True
        Me.lbl_location.Location = New System.Drawing.Point(381, 294)
        Me.lbl_location.Name = "lbl_location"
        Me.lbl_location.Size = New System.Drawing.Size(62, 17)
        Me.lbl_location.TabIndex = 27
        Me.lbl_location.Text = "Location"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Location = New System.Drawing.Point(70, 350)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(40, 17)
        Me.lbl_price.TabIndex = 26
        Me.lbl_price.Text = "Price"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(70, 320)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(45, 17)
        Me.lbl_name.TabIndex = 25
        Me.lbl_name.Text = "Name"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(70, 294)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(21, 17)
        Me.lbl_id.TabIndex = 24
        Me.lbl_id.Text = "ID"
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(508, 373)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(100, 22)
        Me.txt_type.TabIndex = 23
        '
        'txt_rating
        '
        Me.txt_rating.Location = New System.Drawing.Point(508, 345)
        Me.txt_rating.Name = "txt_rating"
        Me.txt_rating.Size = New System.Drawing.Size(100, 22)
        Me.txt_rating.TabIndex = 22
        '
        'txt_year
        '
        Me.txt_year.Location = New System.Drawing.Point(508, 317)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(100, 22)
        Me.txt_year.TabIndex = 21
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(177, 322)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(100, 22)
        Me.txt_name.TabIndex = 20
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(177, 350)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(100, 22)
        Me.txt_price.TabIndex = 19
        '
        'txt_location
        '
        Me.txt_location.Location = New System.Drawing.Point(508, 289)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.Size = New System.Drawing.Size(100, 22)
        Me.txt_location.TabIndex = 18
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(177, 294)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(100, 22)
        Me.txt_id.TabIndex = 17
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(208, 429)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(94, 23)
        Me.btn_update.TabIndex = 31
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(328, 429)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(91, 23)
        Me.btn_delete.TabIndex = 32
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(508, 421)
        Me.Button1.Margin = New System.Windows.Forms.Padding(1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 36)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_updateproduct_A161088
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(650, 473)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.lbl_rating)
        Me.Controls.Add(Me.lbl_year)
        Me.Controls.Add(Me.lbl_location)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_rating)
        Me.Controls.Add(Me.txt_year)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_location)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.grd_product)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_updateproduct_A161088"
        Me.Text = "frm_updateproduct_A161088"
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents grd_product As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_type As System.Windows.Forms.Label
    Friend WithEvents lbl_rating As System.Windows.Forms.Label
    Friend WithEvents lbl_year As System.Windows.Forms.Label
    Friend WithEvents lbl_location As System.Windows.Forms.Label
    Friend WithEvents lbl_price As System.Windows.Forms.Label
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents txt_type As System.Windows.Forms.TextBox
    Friend WithEvents txt_rating As System.Windows.Forms.TextBox
    Friend WithEvents txt_year As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_price As System.Windows.Forms.TextBox
    Friend WithEvents txt_location As System.Windows.Forms.TextBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
