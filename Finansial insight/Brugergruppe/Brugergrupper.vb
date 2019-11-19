Imports System.Data.SqlClient
Public Class BrugerGrupper
    Dim com As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Private Sub Brugergruppe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BrugergruppeDataSet.Brugergruppe' table. You can move, or remove it, as needed.
        Me.BrugergruppeTableAdapter.Fill(Me.BrugergruppeDataSet.Brugergruppe)
        'TODO: This line of code loads data into the 'BrugergruppeDataSet.Brugergruppe' table. You can move, or remove it, as needed.
        Me.BrugergruppeTableAdapter.Fill(Me.BrugergruppeDataSet.Brugergruppe)

        com.ConnectionString = "Data Source=VBJXPS2017;Initial Catalog=Likviditetsmodul;Integrated Security=True"

        If com.State = ConnectionState.Open Then
            com.Close()
        End If

        com.Open()

        disp_data()

    End Sub
    Private Sub DataGridview1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try


            If com.State = ConnectionState.Open Then
                com.Close()
            End If
            com.Open()
            i = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())

            cmd = com.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Brugergruppe where Løbenr =" & i & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While dr.Read()
                DatoVærdi.Text = dr.GetString(1).ToString()
                BrugerGruppeTekst.Text = dr.GetString(2).ToString()
                KommentarTekst.Text = dr.GetString(3).ToString()
                cmd.ExecuteNonQuery()

            End While

        Catch ex As Exception

        End Try

    End Sub
    Public Sub disp_data()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Brugergruppe"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub
    Private Sub GroupBox1__Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DatoVærdi.Text = Format(DateTimePicker1.Value, "yyyy-MM-dd")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Brugergruppe values('" & DatoVærdi.Text & "',
                                                            '" & BrugerGruppeTekst.Text & "',                                              
                                                            '" & KommentarTekst.Text & "')"
        cmd.ExecuteNonQuery()

        disp_data()

        MessageBox.Show("record Inserted Successsfully")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If com.State = ConnectionState.Open Then
            com.Close()
        End If
        com.Open()

        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = ("UPDATE Brugergruppe set Dato = '" + DatoVærdi.Text + "',BrugerGruppe = '" + BrugerGruppeTekst.Text + "', Kommentar = '" + KommentarTekst.Text + " ' where Løbenr= ") & i & ""
        cmd.ExecuteNonQuery()

        disp_data()


        MessageBox.Show("record updated Successsfully")

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If com.State = ConnectionState.Open Then
            com.Close()
        End If
        com.Open()

        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from Brugergruppe where Dato = '" & DatoVærdi.Text & "'"
        cmd.ExecuteNonQuery()

        disp_data()


        MessageBox.Show("record deleted Successsfully")

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        BrugergruppeBindingSource.MovePrevious()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        BrugergruppeBindingSource.MoveNext()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        BrugergruppeBindingSource.MoveFirst()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        BrugergruppeBindingSource.MoveLast()
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
