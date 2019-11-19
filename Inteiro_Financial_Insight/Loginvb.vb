Public Class Loginvb
    Private Sub Loginvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BrugerDataset.Bruger' table. You can move, or remove it, as needed.
        Me.BrugerTableAdapter.Fill(Me.BrugerDataset.Bruger)

    End Sub
End Class