Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Public Class FinansialInsightImportCsvFil
    Dim thedatatabel As New DataTable
    Dim csvData As New IO.StreamReader("C:\Users\vbj\Documents\Import_data.csv", System.Text.Encoding.Default)
    Dim com As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Private Sub FinansialInsightImportCsvFil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Stage_korrektionsDataSet.Stage_KorrektionsFact' table. You can move, or remove it, as needed.
        Me.Stage_KorrektionsFactTableAdapter.Fill(Me.Stage_korrektionsDataSet.Stage_KorrektionsFact)
        With thedatatabel
            .Columns.Add("Løbenr", System.Type.GetType("System.String"))
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim thereader As New IO.StreamReader("C:\Users\vbj\Documents\Import_data.csv", System.Text.Encoding.Default)
        Dim sline As String
        Do
            sline = thereader.ReadLine
            If sline Is Nothing Then Exit Do
            Dim thecolumns() As String = sline.Split(";")
            Dim newrow As DataRow = thedatatabel.NewRow
            newrow("Løbenr") = thecolumns(0)
            newrow("Dato") = thecolumns(1)
            newrow("BrugerGruppe") = thecolumns(2)
            newrow("Bruger") = thecolumns(3)
            newrow("Version") = thecolumns(4)
            newrow("Dim01Navn") = thecolumns(5)
            newrow("Dim01Value") = thecolumns(6)
            newrow("Dim02Navn") = thecolumns(7)
            newrow("Dim02Value") = thecolumns(8)
            newrow("Dim03Navn") = thecolumns(9)
            newrow("Dim03Value") = thecolumns(10)
            newrow("Dim04Navn") = thecolumns(11)
            newrow("Dim04Value") = thecolumns(12)
            newrow("Dim05Navn") = thecolumns(13)
            newrow("Dim05Value") = thecolumns(14)
            newrow("Dim06Navn") = thecolumns(15)
            newrow("Dim06Value") = thecolumns(16)
            newrow("Dim07Navn") = thecolumns(17)
            newrow("Dim07Value") = thecolumns(18)
            newrow("Dim08Navn") = thecolumns(19)
            newrow("Dim08Value") = thecolumns(20)
            newrow("Dim09Navn") = thecolumns(21)
            newrow("Dim09Value") = thecolumns(22)
            newrow("Dim10Navn") = thecolumns(23)
            newrow("Dim10Value") = thecolumns(24)
            newrow("Kommentar") = thecolumns(25)
            newrow("Summen af Beløb") = thecolumns(26)
            thedatatabel.Rows.Add(newrow)
        Loop
        thereader.Close()

        DataGridView1.DataSource = thedatatabel
        Me.Text = thedatatabel.Rows.Count & " rækker loaded op i Finansial Insight applikationen fra csv fil"
    End Sub
    Private Sub Button_5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim dt As New DataTable()
        Dim line As String = Nothing
        Dim i As Integer = 0

        Using sr As StreamReader = File.OpenText("C:\Users\vbj\Documents\Import_data.csv")

            line = sr.ReadLine()


            Do While line IsNot Nothing
                Dim data() As String = line.Split(";"c)
                If data.Length > 0 Then
                    If i = 0 Then
                        For Each item In data
                            dt.Columns.Add(New DataColumn())
                        Next item
                        i += 1
                    End If
                    Dim row As DataRow = dt.NewRow()
                    row.ItemArray = data
                    dt.Rows.Add(row)
                End If
                line = sr.ReadLine()
            Loop
        End Using




        Dim SqlconnectionStringBlokkeklaar As String = "Data Source=VBJXPS2017;Initial Catalog=Likviditetsmodul;Integrated Security=True"

        Using connection As New SqlClient.SqlConnection(SqlconnectionStringBlokkeklaar)

            connection.Open()
            Using copy As New SqlBulkCopy(connection)
                copy.ColumnMappings.Add(0, 0)
                copy.ColumnMappings.Add(1, 1)
                copy.ColumnMappings.Add(2, 2)
                copy.ColumnMappings.Add(3, 3)
                copy.ColumnMappings.Add(4, 4)
                copy.ColumnMappings.Add(5, 5)
                copy.ColumnMappings.Add(6, 6)
                copy.ColumnMappings.Add(7, 7)
                copy.ColumnMappings.Add(8, 8)
                copy.ColumnMappings.Add(9, 9)
                copy.ColumnMappings.Add(10, 10)
                copy.ColumnMappings.Add(11, 11)
                copy.ColumnMappings.Add(12, 12)
                copy.ColumnMappings.Add(13, 13)
                copy.ColumnMappings.Add(14, 14)
                copy.ColumnMappings.Add(15, 15)
                copy.ColumnMappings.Add(16, 16)
                copy.ColumnMappings.Add(17, 17)
                copy.ColumnMappings.Add(18, 18)
                copy.ColumnMappings.Add(19, 19)
                copy.ColumnMappings.Add(20, 20)
                copy.ColumnMappings.Add(21, 21)
                copy.ColumnMappings.Add(22, 22)
                copy.ColumnMappings.Add(23, 23)
                copy.ColumnMappings.Add(24, 24)
                copy.ColumnMappings.Add(25, 25)
                copy.ColumnMappings.Add(26, 26)
                copy.DestinationTableName = "Stage_KorrektionsFact"
                copy.WriteToServer(dt)
            End Using
        End Using

        MessageBox.Show("record Inserted Successsfully")


    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class