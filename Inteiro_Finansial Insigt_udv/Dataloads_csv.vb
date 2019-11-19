Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class Dataloads_csv
    Dim thedatatabel As New DataTable
    Dim com As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer


    Private Sub Button_2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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




        Dim SqlconnectionStringBlokkeklaar As String = "Data Source=VBJXPS2017;Initial Catalog=Inteiro Financial Insight;Integrated Security=True"

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
                copy.ColumnMappings.Add(27, 27)
                copy.DestinationTableName = "Likviditetsbudget_Niveau_1_2_import"

                copy.WriteToServer(dt)

            End Using
        End Using

        MessageBox.Show("record Inserted Successsfully")


    End Sub


End Class

