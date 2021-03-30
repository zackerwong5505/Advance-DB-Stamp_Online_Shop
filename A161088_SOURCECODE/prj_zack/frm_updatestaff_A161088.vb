﻿Public Class frm_updatestaff_A161088

    Dim current_code As String

    Private Sub frm_updatestaff_A161088_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_code()

    End Sub
    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_STAFF_A161088"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)


        grd_staff.DataSource = mydatatable
        grd_staff.Columns(0).HeaderText = "Customer ID"
        grd_staff.Columns(1).HeaderText = "Customer Name"
        grd_staff.Columns(2).HeaderText = "Phone"
    End Sub
    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_phone.Text = ""

    End Sub
    Private Sub get_current_code()
        Dim current_row As Integer = grd_staff.CurrentRow.Index

        current_code = grd_staff(0, current_row).Value

        txt_id.Text = current_code
        txt_name.Text = grd_staff(1, current_row).Value
        txt_phone.Text = grd_staff(2, current_row).Value

    End Sub
    Private Sub grd_product_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_staff.CellClick
        get_current_code()

    End Sub
    Private Sub btn_update_Click(sender As System.Object, e As System.EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_STAFF_A161088 SET FLD_STAFF_NAME='" & txt_name.Text & "' WHERE FLD_STAFF_ID='" & current_code & "'")
        run_sql_command("UPDATE TBL_STAFF_A161088 SET FLD_STAFF_PHONE='" & txt_phone.Text & "' WHERE FLD_STAFF_ID='" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated the staff """ & current_code & """.")

        refresh_grid()
        clear_fields()
        get_current_code()

    End Sub
    Private Sub btn_delete_Click(sender As System.Object, e As System.EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the course """ & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_STAFF_A161088 WHERE FLD_STAFF_ID='" & current_code & "'")


            Beep()
            MsgBox("The staff """ & current_code & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()

        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frm_staff_A161088.Show()
        Me.Hide()

    End Sub
End Class