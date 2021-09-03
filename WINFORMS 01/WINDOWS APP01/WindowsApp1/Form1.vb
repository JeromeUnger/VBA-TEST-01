Public Class Form1
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Data.tblPatents' table. You can move, or remove it, as needed.
        Me.TblPatentsTableAdapter.Fill(Me.Data.tblPatents)

    End Sub
End Class
