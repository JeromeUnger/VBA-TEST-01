Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Data.tblPatents' table. You can move, or remove it, as needed.
        Me.TblPatentsTableAdapter.Fill(Me.Data.tblPatents)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form2.Show()
    End Sub
End Class