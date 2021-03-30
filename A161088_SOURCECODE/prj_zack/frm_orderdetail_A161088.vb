Public Class frm_orderdetail_A161088
    Private Sub grd_orderdetail_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub


    Private Sub frm_orderdetail_A161088_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        txt_orderid.Text = generate_id()

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A161088"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_product.DataSource = mydatatable
        lst_product.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(lst_product.Text)

        Dim mysql3 As String = "SELECT FLD_CUSTOMER_ID FROM TBL_CUSTOMER_A161088"
        Dim mydatatable3 As New DataTable
        Dim myreader3 As New OleDb.OleDbDataAdapter(mysql3, myconnection)
        myreader3.Fill(mydatatable3)
        list_cust.DataSource = mydatatable3
        list_cust.DisplayMember = "FLD_CUSTOMER_ID"
        refresh_Ctext(list_cust.Text)

        Dim mysql2 As String = "SELECT FLD_STAFF_ID FROM TBL_STAFF_A161088"
        Dim mydatatable2 As New DataTable
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)
        myreader2.Fill(mydatatable2)
        list_staff.DataSource = mydatatable2
        list_staff.DisplayMember = "FLD_STAFF_ID"
        refresh_Stext(list_staff.Text)



    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frm_mainmenu_A161088.Show()
        Me.Hide()

    End Sub

    Private Sub refresh_text(ByVal Pid As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A161088 WHERE FLD_PRODUCT_ID='" & Pid & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        txt_type.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_TYPE")
        txt_location.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_LOCATION")
        txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_PRICE")
        txt_rating.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_RATING")
        txt_year.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_YEAR")
        txt_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")

        If order_quantity.Value = 1 Then
            txt_sub.Text = FormatCurrency(mydatatable.Rows(0).Item("FLD_PRODUCT_PRICE"))

        ElseIf order_quantity.Value > 1 Then
            txt_sub.Text = FormatCurrency(mydatatable.Rows(0).Item("FLD_PRODUCT_PRICE") * order_quantity.Value)

        ElseIf order_quantity.Value = 0 Then
            txt_sub.Text = FormatCurrency(0)

        End If

        pic_pro.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")

    End Sub

    Private Function generate_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTID FROM TBL_ORDER_A161088").Rows(0).Item("LASTID")
        Dim newid As String = "O" & Mid(lastid, 2) + 1
        Return newid

    End Function
    Private Sub refresh_Ctext(ByVal CID As String)
        Dim mysql3 As String = "SELECT * FROM TBL_CUSTOMER_A161088 WHERE FLD_CUSTOMER_ID = '" & CID & "'"
        Dim mydatatable3 As New DataTable
        Dim myreader3 As New OleDb.OleDbDataAdapter(mysql3, myconnection)
        myreader3.Fill(mydatatable3)
        txt_cust_name.Text = mydatatable3.Rows(0).Item("FLD_CUSTOMER_NAME")
        txt_cust_tel.Text = mydatatable3.Rows(0).Item("FLD_CUSTOMER_Phone")

    End Sub
    Private Sub refresh_Stext(ByVal SID As String)
        Dim mysql2 As String = "SELECT * FROM TBL_STAFF_A161088 WHERE FLD_STAFF_ID = '" & SID & "'"
        Dim mydatatable2 As New DataTable
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)
        myreader2.Fill(mydatatable2)
        txt_staff_name.Text = mydatatable2.Rows(0).Item("FLD_STAFF_NAME")
        txt_staff_tel.Text = mydatatable2.Rows(0).Item("FLD_STAFF_Phone")

    End Sub
    Private Sub refresh_total()
        If grd_order.RowCount >= 1 Then
            Dim sum = 0

            For index As Integer = 0 To grd_order.RowCount - 1
                sum += grd_order.Rows(index).Cells(5).Value

            Next

            txt_total.Text = FormatCurrency(sum)

        ElseIf grd_order.RowCount = 0 Then
            txt_total.Text = FormatCurrency(0)

        End If
    End Sub
    Private Sub btn_confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_confirm.Click
        If order_quantity.Value >= 1 Then
            Dim mytransaction As OleDb.OleDbTransaction
            myconnection2.Open()
            mytransaction = myconnection2.BeginTransaction

            Try
                Dim mysql As String = "INSERT INTO TBL_ORDER_A161088 VALUES('" & txt_orderid.Text & "', '" & list_staff.Text & "', '" & list_cust.Text & "', '" & pick_date.Text & "')"
                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)
                mywriter.ExecuteNonQuery()

                For i As Integer = 0 To grd_order.RowCount - 1
                    Dim order_date As String = grd_order(0, i).Value
                    Dim product_id As String = grd_order(1, i).Value
                    Dim product_name As String = grd_order(2, i).Value
                    Dim price As String = grd_order(3, i).Value
                    Dim quantity As String = grd_order(4, i).Value
                    Dim subtotal As String = grd_order(5, i).Value

                    Dim mysql2 As String = "INSERT INTO TBL_ORDER_LIST_A161088 VALUES('" & txt_orderid.Text & "', '" & product_id & "', '" & product_name & "', '" & price & "', " & quantity & ", '" & subtotal & "')"
                    Dim mywriter2 As New OleDb.OleDbCommand(mysql2, myconnection2, mytransaction)
                    mywriter2.ExecuteNonQuery()

                Next

                mytransaction.Commit()
                myconnection2.Close()
                Beep()
                MsgBox("Transaction successful")
                grd_order.Rows.Clear()
                txt_orderid.Text = generate_id()

            Catch ex As Exception
                Beep()
                MsgBox("Make sure there is no duplicate of order!!")
                mytransaction.Rollback()
                myconnection2.Close()

            End Try
        Else
            Beep()
            MsgBox("Please make sure you have at least one order.")
        End If
    End Sub
    Private Sub lst_product_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lst_product.MouseClick
        refresh_text(lst_product.Text)

    End Sub
    Private Sub order_quantity_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles order_quantity.ValueChanged
        refresh_text(lst_product.Text)

    End Sub

    Private Sub list_cust_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles list_cust.MouseClick
        refresh_Ctext(list_cust.Text)

    End Sub
    Private Sub list_staff_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles list_staff.MouseClick
        refresh_Stext(list_staff.Text)

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If grd_order.RowCount >= 1 Then
            grd_order.Rows.Remove(grd_order.CurrentRow)
            refresh_total()
        Else
            Beep()
            MsgBox("There is no record to delete.")
        End If

    End Sub
    Private Sub btn_order_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_order.Click
        If order_quantity.Value = 0 Then
            Beep()
            MsgBox("Please select an item to order.")
        Else
            grd_order.Rows.Add(New String() {pick_date.Text, lst_product.Text, txt_name.Text, txt_price.Text, order_quantity.Value, txt_sub.Text})
            refresh_total()
        End If

    End Sub

End Class