Imports System.Data.SqlClient
Public Class Konfigurering__Kreditorer
    Dim com As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Dim i2 As Integer
    Dim i3 As Integer
    Dim x As String
    Dim y As String
    Private Sub Konfigurering_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        com.ConnectionString = "Data Source=VBJXPS2017;Initial Catalog=Inteiro Financial Insight;Integrated Security=True"

        If com.State = ConnectionState.Open Then
            com.Close()
        End If
    End Sub

    Public Sub disp_data()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Konfiguration_antal_kreditorer "
        cmd.ExecuteNonQuery()
        Dim dt2 As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt2)
        DataGridView2.DataSource = dt2
    End Sub
    Public Sub disp_data1()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Konfiguration_antal_kreditorer "
        cmd.ExecuteNonQuery()
        Dim dt3 As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt3)
        DataGridView2.DataSource = dt3
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        com.Open()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Konfiguration_antal_kreditorer values
            ('" & ProfilID.Text & "',
           '" & BrugerGruppeTekst.Text & "',
          '" & Kreditornr.Text & " ',
          '" & Kreditornavn.Text & "',   
          '" & Version.Text & "',
          '" & Saldo.Text & "', 
          '" & Saldobrutto.Text & "')"
        cmd.ExecuteNonQuery()

        MessageBox.Show("record Inserted Successsfully")
        disp_data()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If com.State = ConnectionState.Open Then
            com.Close()
        End If
        com.Open()

        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from Konfiguration_antal_kreditorer where Løbenr = '" & Løbenr.Text & "'"
        cmd.ExecuteNonQuery()

        disp_data()


        MessageBox.Show("record deleted Successsfully")

    End Sub
    Private Sub Profil_ID_TextChanged(sender As Object, e As EventArgs) Handles Saldo.TextChanged

    End Sub

    Private Sub BrugerGruppeTekst_TextChanged(sender As Object, e As EventArgs) Handles BrugerGruppeTekst.TextChanged

    End Sub

    Private Sub Version_TextChanged(sender As Object, e As EventArgs) Handles Version.TextChanged

    End Sub

    Private Sub VersionLabel_Click(sender As Object, e As EventArgs) Handles VersionLabel.Click

    End Sub

    Private Sub KreditornrLabel_Click(sender As Object, e As EventArgs) Handles KreditornrLabel.Click

    End Sub

    Private Sub Kreditornr_TextChanged(sender As Object, e As EventArgs) Handles Kreditornr.TextChanged

    End Sub

    Private Sub Kreditornavn_TextChanged(sender As Object, e As EventArgs) Handles Kreditornavn.TextChanged

    End Sub

    Private Sub KreditornavnLabel_Click(sender As Object, e As EventArgs) Handles KreditornavnLabel.Click

    End Sub

    Private Sub BrugerGruppeLabel1_Click(sender As Object, e As EventArgs) Handles BrugerGruppeLabel1.Click

    End Sub

    Private Sub Konfigurering__Kreditorer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetKonfiguration_antal_kreditorer1.Konfiguration_antal_kreditorer' table. You can move, or remove it, as needed.
        Me.Konfiguration_antal_kreditorerTableAdapter1.Fill(Me.Inteiro_Financial_InsightDataSetKonfiguration_antal_kreditorer1.Konfiguration_antal_kreditorer)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSet3.Top_antal_kreditorer' table. You can move, or remove it, as needed.
        Me.Top_antal_kreditorerTableAdapter1.Fill(Me.Inteiro_Financial_InsightDataSet3.Top_antal_kreditorer)

    End Sub
End Class