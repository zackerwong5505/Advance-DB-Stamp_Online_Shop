Public Class frm_staff_A161088

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frm_mainmenu_A161088.Show()
        Me.Hide()


    End Sub

    Private Sub frm_staff_A161088_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim myconnection As String = "provider=Microsoft.ACE.OLEDB.12.0;Data Source = Database1.accdb;Persist Security Info=False;"

        Dim mysql As String = "SELECT * FROM TBL_STAFF_A161088"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_staff.DataSource = mydatatable
        grd_staff.Columns(0).HeaderText = "Customer ID"
        grd_staff.Columns(1).HeaderText = "Customer Name"
        grd_staff.Columns(2).HeaderText = "Phone"

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_staff.CellContentClick

    End Sub

    Private Sub btn_insert_Click(sender As System.Object, e As System.EventArgs) Handles btn_insert.Click
        frm_insertstaff_A161088.Show()
        Me.Hide()

    End Sub

    Private Sub btn_update_Click(sender As System.Object, e As System.EventArgs) Handles btn_update.Click
        frm_updatestaff_A161088.Show()
        Me.Hide()

    End Sub
End Class