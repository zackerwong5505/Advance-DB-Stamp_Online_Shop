Public Class frm_insertcustomer_A161088

    Private Sub frm_insertcustomer_A161088_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        grd_customer.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A161088")
        grd_customer.Columns(0).HeaderText = "Customer ID"
        grd_customer.Columns(1).HeaderText = "Customer Name"
        grd_customer.Columns(2).HeaderText = "Phone"
        grd_customer.Columns(3).HeaderText = "Location"

        txt_id.Text = generate_id()
    End Sub
    Private Function generate_id() As String
        Dim lastID As String = run_sql_query("SELECT MAX(FLD_CUSTOMER_ID) AS LASTID FROM TBL_CUSTOMER_A161088").Rows(0).Item("lastID")

        Dim newID As String = "C" & Mid(lastID, 2) + 1
        Return newID


    End Function

    Private Sub btn_insert_Click(sender As System.Object, e As System.EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_CUSTOMER_A161088 VALUES('" & txt_id.Text & "','" & txt_name.Text & "','" & txt_phone.Text & "','" & txt_location.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
        Try

        
        mywriter.Connection.Open()
        mywriter.ExecuteNonQuery()
        mywriter.Connection.Close()
            grd_customer.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A161088")
          
            txt_id.Text = generate_id()
            txt_name.Text = ""
            txt_phone.Text = ""
            txt_location.Text = ""


        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered , as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frm_customer_A161088.Show()
        Me.Hide()

    End Sub
End Class