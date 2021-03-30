Public Class frm_mainmenu_A161088

    Private Sub btn_exit_Click(sender As System.Object, e As System.EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub btn_staff_Click(sender As System.Object, e As System.EventArgs) Handles btn_staff.Click
        frm_staff_A161088.Show()
        Me.Hide()


    End Sub

    Private Sub btn_customer_Click(sender As System.Object, e As System.EventArgs) Handles btn_customer.Click
        frm_customer_A161088.Show()
        Me.Hide()

    End Sub

    Private Sub btn_product_Click(sender As System.Object, e As System.EventArgs) Handles btn_product.Click
        frm_product_A161088.Show()
        Me.Hide()
    End Sub

    Private Sub frm_mainmenu_A161088_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_order_Click(sender As System.Object, e As System.EventArgs) Handles btn_order.Click
        frm_order_A161088.Show()
        Me.Hide()
    End Sub

    Private Sub btn_orderdetail_Click(sender As System.Object, e As System.EventArgs) Handles btn_orderdetail.Click
        frm_orderdetail_A161088.Show()
        Me.Hide()
    End Sub

    Private Sub btn_invoice_Click(sender As System.Object, e As System.EventArgs) Handles btn_invoice.Click
        frm_invoice_A161088.Show()
        Me.Hide()
    End Sub
End Class
