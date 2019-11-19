Imports System.Data.SqlClient

Public Class loginform
    Private Sub LogInbtn_Click(sender As Object, e As EventArgs) Handles logInbtn.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=VBJXPS2017;Initial Catalog=Vbmultiuser;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from login where username='" & usrNametxt.Text & "' and password='" & usrPasstxt.Text & "'", connection:=con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)

        If (dt.Rows.Count > 0) Then
            MessageBox.Show("You are logged in as " + dt.Rows(0)(2))
        Else
            MessageBox.Show("error")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class