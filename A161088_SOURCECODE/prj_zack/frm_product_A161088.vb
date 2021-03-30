Public Class frm_product_A161088

    Private Sub frm_product_A161088_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim myconnection As String = "provider=Microsoft.ACE.OLEDB.12.0;Data Source = Database1.accdb;Persist Security Info=False;"

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A161088"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_product.DataSource = mydatatable
        lst_product.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(lst_product.Text)

       
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frm_mainmenu_A161088.Show()
        Me.Hide()

    End Sub
    Private Sub refresh_text(id As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A161088 WHERE FLD_PRODUCT_ID='" & id & "'"

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

        Try
            pic_pro.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")
        Catch ex As Exception
            pic_pro.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try

    End Sub

    Private Sub lst_product_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lst_product.MouseClick
        refresh_text(lst_product.Text)

    End Sub

    Private Sub btn_insert_Click(sender As System.Object, e As System.EventArgs) Handles btn_insert.Click
        frm_insertproduct_A161088.Show()
        Me.Hide()

    End Sub

    Private Sub btn_update_Click(sender As System.Object, e As System.EventArgs) Handles btn_update.Click
        frm_updateproduct_A161088.Show()
        Me.Hide()

    End Sub
End Class