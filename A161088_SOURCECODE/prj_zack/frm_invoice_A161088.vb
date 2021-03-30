Public Class frm_invoice_A161088

    Private Sub frm_invoice_A161088_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDER_A161088"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        list_order.DataSource = mydatatable
        list_order.DisplayMember = "FLD_ORDER_ID"
        refresh_text(list_order.Text)
        refresh_grid()
    End Sub

    Private Sub refresh_text(ByVal ID As String)
        Dim mysql As String = "SELECT * FROM TBL_ORDER_A161088 WHERE FLD_ORDER_ID = '" & ID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lbl_date.Text = mydatatable.Rows(0).Item("FLD_ORDER_DATE")

    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_ORDER_LIST_A161088 WHERE FLD_ORDER_ID = '" & list_order.Text & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_order_record.DataSource = mydatatable
        grd_order_record.Columns(0).HeaderText = "Order ID"
        grd_order_record.Columns(1).HeaderText = "Product ID"
        grd_order_record.Columns(2).HeaderText = "Product Name"
        grd_order_record.Columns(3).HeaderText = "Price"
        grd_order_record.Columns(4).HeaderText = "Quantity"
        grd_order_record.Columns(5).HeaderText = "Sub total"

    End Sub

    Private Sub refresh_total()
        If grd_order_record.RowCount >= 1 Then
            Dim sum = 0

            For index As Integer = 0 To grd_order_record.RowCount - 1
                sum += grd_order_record.Rows(index).Cells(5).Value

            Next

            txt_total.Text = FormatCurrency(sum)

        End If
    End Sub

    Private Sub list_order_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles list_order.MouseClick
        refresh_text(list_order.Text)
        refresh_grid()
        refresh_total()

    End Sub



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frm_mainmenu_A161088.Show()
        Me.Hide()
    End Sub

    Private Sub lbl_date_Click(sender As System.Object, e As System.EventArgs) Handles lbl_date.Click

    End Sub
End Class