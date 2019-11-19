Public Class Brugere
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Brugere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BrugerDataSet1.BrugerData' table. You can move, or remove it, as needed.
        Me.BrugerDataTableAdapter.Fill(Me.BrugerDataSet1.BrugerData)

    End Sub
End Class