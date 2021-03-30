Public Class frm_updatecustomer_A161088

    Dim current_code As String

    Private Sub frm_updatecustomer_A161088_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_code()

    End Sub
    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A161088"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_customer.DataSource = mydatatable
        grd_customer.Columns(0).HeaderText = "Customer ID"
        grd_customer.Columns(1).HeaderText = "Customer Name"
        grd_customer.Columns(2).HeaderText = "Phone"
        grd_customer.Columns(3).HeaderText = "Location"
    End Sub
    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_phone.Text = ""
        txt_location.Text = ""

    End Sub
    Private Sub get_current_code()
        Dim current_row As Integer = grd_customer.CurrentRow.Index

        current_code = grd_customer(0, current_row).Value

        txt_id.Text = current_code
        txt_name.Text = grd_customer(1, current_row).Value
        txt_phone.Text = grd_customer(2, current_row).Value
        txt_location.Text = grd_customer(3, current_row).Value



    End Sub
    Private Sub grd_product_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_customer.CellClick
        get_current_code()

    End Sub
    Private Sub btn_update_Click(sender As System.Object, e As System.EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_CUSTOMER_A161088 SET FLD_CUSTOMER_NAME='" & txt_name.Text & "' WHERE FLD_CUSTOMER_ID='" & current_code & "'")
        run_sql_command("UPDATE TBL_CUSTOMER_A161088 SET FLD_CUSTOMER_PHONE='" & txt_phone.Text & "' WHERE FLD_CUSTOMER_ID='" & current_code & "'")
        run_sql_command("UPDATE TBL_CUSTOMER_A161088 SET FLD_CUSTOMER_PHONE='" & txt_location.Text & "' WHERE FLD_CUSTOMER_ID='" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated the st """ & current_code & """.")

        refresh_grid()
        clear_fields()
        get_current_code()

    End Sub
    Private Sub btn_delete_Click(sender As System.Object, e As System.EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the course """ & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_CUSTOMER_A161088 WHERE FLD_CUSTOMER_ID='" & current_code & "'")


            Beep()
            MsgBox("The customer """ & current_code & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()

        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        frm_customer_A161088.Show()
        Me.Hide()


    End Sub

    Private Sub lbl_title_Click(sender As System.Object, e As System.EventArgs) Handles lbl_title.Click

    End Sub
End Class