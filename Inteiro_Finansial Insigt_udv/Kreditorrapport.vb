Imports System.Data.SqlClient
Public Class Kreditorrapport
    Dim com As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Dim i2 As Integer
    Dim i3 As Integer
    Dim a As String = Kreditorbudgettering.Dim04Value.Text
    Dim b As String = Kreditorbudgettering.Dim07Value.Text
    Dim c As String = Kreditorbudgettering.Dim08Value.Text
    Dim d As String = Kreditorbudgettering.Dim09Value.Text
    Dim e As String = Kreditorbudgettering.Dim02Value.Text
    Dim f As String = Kreditorbudgettering.Dim03Value.Text
    Dim g As String = Kreditorbudgettering.BrugerTekst.Text
    Dim h As String = Kreditorbudgettering.Likviditetsbruger.Text



    Private Sub Indtastningsrapport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetvKreditorpofildranstF1.vKreditorprofilDranstF1' table. You can move, or remove it, as needed.
        Me.VKreditorprofilDranstF1TableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetvKreditorpofildranstF1.vKreditorprofilDranstF1)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDatasetVkreditorprofildranst.vKreditorprofilDranst' table. You can move, or remove it, as needed.
        Me.VKreditorprofilDranstTableAdapter.Fill(Me.Inteiro_Financial_InsightDatasetVkreditorprofildranst.vKreditorprofilDranst)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetDranstF1F2F3G1G2.vKreditorprofilDranstF1F2F3G1G2' table. You can move, or remove it, as needed.
        Me.VKreditorprofilDranstF1F2F3G1G2TableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetDranstF1F2F3G1G2.vKreditorprofilDranstF1F2F3G1G2)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetBudgetKreditorprofil.Budget_KreditorprofilDranstF1F2F3G1G2' table. You can move, or remove it, as needed.
        Me.Budget_KreditorprofilDranstF1F2F3G1G2TableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetBudgetKreditorprofil.Budget_KreditorprofilDranstF1F2F3G1G2)

        com.ConnectionString = "Data Source=VBJXPS2017;Initial Catalog=Inteiro Financial Insight;Integrated Security=True"

        If com.State = ConnectionState.Open Then
            com.Close()
        End If
        com.Open()
    End Sub
    Private Sub DataGridview1_CellClick(sender As Object, e As DataGridViewCellEventArgs)

        Try


            If com.State = ConnectionState.Open Then
                com.Close()
            End If
            com.Open()
            i = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())

            cmd = com.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Budget_KreditorprofilDranstF1F2F3G1G2 where  Løbenr =" & i & " order by Bruger,Løbenr asc"
            cmd.ExecuteNonQuery()
            Dim dt1 As New DataTable()
            Dim da1 As New SqlDataAdapter(cmd)
            da1.Fill(dt1)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While dr.Read()
                Løbenr.Text = dr.GetString(1).ToString()
                Dim04Value.Text = dr.GetString(2).ToString()
                cmd.ExecuteNonQuery()

            End While

        Catch ex As Exception

        End Try


    End Sub
    Private Sub Button9_Luk_afClick(sender As Object, e As EventArgs) Handles Button9.Click
        Dim04Value1.Text = DranstComboBox.Text
        Try
            Me.Budget_KreditorprofilDranstF1F2F3G1G2TableAdapter.FillBy(Me.Inteiro_Financial_InsightDataSetBudgetKreditorprofil.Budget_KreditorprofilDranstF1F2F3G1G2, Dim04Value1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button14_Luk_afClick(sender As Object, e As EventArgs) Handles Button14.Click
        Dim04Value1.Text = DranstComboBox.Text

        Dim04Value1.Text = DranstComboBox.Text

        Try
            Me.Budget_KreditorprofilDranstF1F2F3G1G2TableAdapter.FillBy1(Me.Inteiro_Financial_InsightDataSetBudgetKreditorprofil.Budget_KreditorprofilDranstF1F2F3G1G2, Dim04Value1.Text, Kreditorbudgettering.Dim07Value.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Luk_afClick(sender As Object, e As EventArgs) Handles Button1.Click
        Kreditorbudgettering.Dim04Value.Text = Kreditorbudgettering.DranstComboBox.Text

        Try
            Me.Budget_KreditorprofilDranstF1F2F3G1G2TableAdapter.FillBy1(Me.Inteiro_Financial_InsightDataSetBudgetKreditorprofil.Budget_KreditorprofilDranstF1F2F3G1G2, Kreditorbudgettering.Dim04Value.Text, Kreditorbudgettering.Dim07Value.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class