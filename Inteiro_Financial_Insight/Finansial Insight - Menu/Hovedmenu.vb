Public Class Hovedmenu
    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        Budget.Show()

    End Sub
    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        Administrationsmenu.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub


End Class
