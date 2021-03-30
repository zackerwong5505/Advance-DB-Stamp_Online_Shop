Public Class frm_order_A161088
    Private Sub grd_order_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd_order.CellContentClick

    End Sub

    Private Sub frm_order_A161088_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim myconnection As String = "provider=Microsoft.ACE.OLEDB.12.0;Data Source = Database1.accdb;Persist Security Info=False;"

        Dim mysql As String = "SELECT * FROM TBL_ORDER_A161088"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_order.DataSource = mydatatable
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frm_mainmenu_A161088.Show()
        Me.Hide()
    End Sub


    Private Sub MonthCalendar1_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs)

    End Sub
End Class