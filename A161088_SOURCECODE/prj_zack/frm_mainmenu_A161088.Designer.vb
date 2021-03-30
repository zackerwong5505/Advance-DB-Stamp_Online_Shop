<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainmenu_A161088
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mainmenu_A161088))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_product = New System.Windows.Forms.Button()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.btn_orderdetail = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_invoice = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(608, 95)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KIMCHI STAMP SHOP"
        '
        'btn_staff
        '
        Me.btn_staff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_staff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_staff.Location = New System.Drawing.Point(36, 178)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(140, 51)
        Me.btn_staff.TabIndex = 1
        Me.btn_staff.Text = "Staff"
        Me.btn_staff.UseVisualStyleBackColor = True
        '
        'btn_customer
        '
        Me.btn_customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customer.Location = New System.Drawing.Point(36, 268)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(140, 51)
        Me.btn_customer.TabIndex = 2
        Me.btn_customer.Text = "Customer"
        Me.btn_customer.UseVisualStyleBackColor = True
        '
        'btn_product
        '
        Me.btn_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_product.Location = New System.Drawing.Point(36, 441)
        Me.btn_product.Name = "btn_product"
        Me.btn_product.Size = New System.Drawing.Size(140, 51)
        Me.btn_product.TabIndex = 3
        Me.btn_product.Text = "Product"
        Me.btn_product.UseVisualStyleBackColor = True
        '
        'btn_order
        '
        Me.btn_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order.Location = New System.Drawing.Point(206, 441)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(140, 51)
        Me.btn_order.TabIndex = 4
        Me.btn_order.Text = "Order List"
        Me.btn_order.UseVisualStyleBackColor = True
        '
        'btn_orderdetail
        '
        Me.btn_orderdetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_orderdetail.Location = New System.Drawing.Point(372, 441)
        Me.btn_orderdetail.Name = "btn_orderdetail"
        Me.btn_orderdetail.Size = New System.Drawing.Size(140, 51)
        Me.btn_orderdetail.TabIndex = 5
        Me.btn_orderdetail.Text = "Make Order"
        Me.btn_orderdetail.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.Location = New System.Drawing.Point(624, 429)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(89, 130)
        Me.btn_exit.TabIndex = 6
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_invoice
        '
        Me.btn_invoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_invoice.Location = New System.Drawing.Point(36, 358)
        Me.btn_invoice.Name = "btn_invoice"
        Me.btn_invoice.Size = New System.Drawing.Size(140, 51)
        Me.btn_invoice.TabIndex = 7
        Me.btn_invoice.Text = "Invoice"
        Me.btn_invoice.UseVisualStyleBackColor = True
        '
        'frm_mainmenu_A161088
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(745, 571)
        Me.Controls.Add(Me.btn_invoice)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_orderdetail)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.btn_product)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_mainmenu_A161088"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_staff As System.Windows.Forms.Button
    Friend WithEvents btn_customer As System.Windows.Forms.Button
    Friend WithEvents btn_product As System.Windows.Forms.Button
    Friend WithEvents btn_order As System.Windows.Forms.Button
    Friend WithEvents btn_orderdetail As System.Windows.Forms.Button
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_invoice As System.Windows.Forms.Button

End Class
