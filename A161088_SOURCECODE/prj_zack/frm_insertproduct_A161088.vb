Public Class frm_insertproduct_A161088

    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"

    Private Sub frm_insertproduct_A161088_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        grd_product.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A161088")

        txt_id.Text = generate_id()
        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)



    End Sub

    Private Function generate_id() As String
        Dim lastID As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCTS_A161088").Rows(0).Item("lastID")

        'MsgBox(lastID)

        Dim newID As String = "A" & Mid(lastID, 2) + 1
        Return newID


    End Function


    Private Sub btn_insert_Click(sender As System.Object, e As System.EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A161088 VALUES('" & txt_id.Text & "','" & txt_name.Text & "' ,'" & txt_price.Text & "','" & txt_location.Text & "','" & txt_year.Text & "','" & txt_rating.Text & "','" & txt_type.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_id.Text & ".jpg")

            grd_product.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A161088")

            txt_id.Text = generate_id()
            txt_name.Text = ""
            txt_location.Text = ""
            txt_price.Text = ""
            txt_rating.Text = ""
            txt_year.Text = ""
            txt_type.Text = ""
            txt_picture.Text = defaultpicture
            pic_product.BackgroundImage = Image.FromFile(defaultpicture)




        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered , as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try


    End Sub

    Private Sub btn_picture_Click(sender As System.Object, e As System.EventArgs) Handles btn_picture.Click

        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files(*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()
        Try
            pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            txt_picture.Text = OpenFileDialog1.FileName

        Catch ex As Exception

        End Try
       




    End Sub

    Private Sub btn_back_Click(sender As System.Object, e As System.EventArgs) Handles btn_back.Click
        frm_product_A161088.Show()
        Me.Hide()


    End Sub
End Class