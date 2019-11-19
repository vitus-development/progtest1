Imports System.Data.SqlClient
Public Class FinansialInsightImportCsvFil
    Dim CsvTabel As New DataTable
    Dim com As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub FinansialInsightImportCsvFil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With CsvTabel
            .Columns.Add("Dato", System.Type.GetType("System.String"))
            .Columns.Add("BrugerGruppe", System.Type.GetType("System.String"))
            .Columns.Add("Bruger", System.Type.GetType("System.String"))
            .Columns.Add("Version", System.Type.GetType("System.String"))
            .Columns.Add("Dim01Navn", System.Type.GetType("System.String"))
            .Columns.Add("Dim01Value", System.Type.GetType("System.String"))
            .Columns.Add("Dim02Navn", System.Type.GetType("System.String"))
            .Columns.Add("Dim02Value", System.Type.GetType("System.String"))
            .Columns.Add("Dim03Navn", System.Type.GetType("System.String"))
            .Columns.Add("Dim03Value", System.Type.GetType("System.String"))
            .Columns.Add("Dim04Navn", System.Type.GetType("System.String"))
            .Columns.Add("Dim04Value", System.Type.GetType("System.String"))
            .Columns.Add("Dim05Navn", System.Type.GetType("System.String"))
            .Columns.Add("Dim05Value", System.Type.GetType("System.String"))
            .Columns.Add("Dim06Navn", System.Type.GetType("System.String"))
            .Columns.Add("Dim06Value", System.Type.GetType("System.String"))
            .Columns.Add("Dim07Navn", System.Type.GetType("System.String"))
            .Columns.Add("Dim07Value", System.Type.GetType("System.String"))
            .Columns.Add("Dim08Navn", System.Type.GetType("System.String"))
            .Columns.Add("Dim08Value", System.Type.GetType("System.String"))
            .Columns.Add("Dim09Navn", System.Type.GetType("System.String"))
            .Columns.Add("Dim09Value", System.Type.GetType("System.String"))
            .Columns.Add("Dim10Navn", System.Type.GetType("System.String"))
            .Columns.Add("Dim10Value", System.Type.GetType("System.String"))
            .Columns.Add("Summen af Beløb", System.Type.GetType("System.String"))
            .Columns.Add("Kommentar", System.Type.GetType("System.String"))
        End With
    End Sub
    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dim thereader As New IO.StreamReader("C:\Users\vbj\Documents\Import_data.csv", System.Text.Encoding.Default)
        Dim sline As String = ""
        Do
            sline = thereader.ReadLine
            If sline Is Nothing Then Exit Do
            Dim thecolumns() As String = sline.Split(";")
            Dim newrow As DataRow = CsvTabel.NewRow
            newrow("Dato") = thecolumns(0)
            newrow("BrugerGruppe") = thecolumns(1)
            newrow("Bruger") = thecolumns(2)
            newrow("Version") = thecolumns(3)
            newrow("Dim01Navn") = thecolumns(4)
            newrow("Dim01Value") = thecolumns(5)
            newrow("Dim02Navn") = thecolumns(6)
            newrow("Dim02Value") = thecolumns(7)
            newrow("Dim03Navn") = thecolumns(8)
            newrow("Dim03Value") = thecolumns(9)
            newrow("Dim04Navn") = thecolumns(10)
            newrow("Dim04Value") = thecolumns(11)
            newrow("Dim05Navn") = thecolumns(12)
            newrow("Dim05Value") = thecolumns(13)
            newrow("Dim06Navn") = thecolumns(14)
            newrow("Dim06Value") = thecolumns(15)
            newrow("Dim07Navn") = thecolumns(16)
            newrow("Dim07Value") = thecolumns(17)
            newrow("Dim08Navn") = thecolumns(18)
            newrow("Dim08Value") = thecolumns(19)
            newrow("Dim09Navn") = thecolumns(20)
            newrow("Dim09Value") = thecolumns(21)
            newrow("Summen af Beløb") = thecolumns(22)
            newrow("Kommentar") = thecolumns(23)
            CsvTabel.Rows.Add(newrow)
        Loop
        thereader.Close()

        DataGridView1.DataSource = CsvTabel
        Me.Text = CsvTabel.Rows.Count & " rækker loaded op i Finansial Insight applikationen fra csv fil"
    End Sub
End Class