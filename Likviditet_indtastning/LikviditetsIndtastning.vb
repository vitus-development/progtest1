Imports System.Data.SqlClient
Public Class LikviditetsIndtastning

    Dim com As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer

    Private Sub LikviditetsIndtastning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LikviditetsmodulDataSet.KorrektionsFact' table. You can move, or remove it, as needed.
        Me.KorrektionsFactTableAdapter.Fill(Me.LikviditetsmodulDataSet.KorrektionsFact)
        'TODO: This line of code loads data into the 'LikviditetsmodulDataSet.KorrektionsFact' table. You can move, or remove it, as needed.
        Me.KorrektionsFactTableAdapter.Fill(Me.LikviditetsmodulDataSet.KorrektionsFact)


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
            cmd.CommandText = "select * from KorrektionsFact where Løbenr =" & i & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While dr.Read()
                DatoVærdi.Text = dr.GetString(1).ToString()
                BrugerGruppe.Text = dr.GetString(2).ToString()
                BrugerTekst.Text = dr.GetString(3).ToString()
                VersionTekst.Text = dr.GetSqlString(5).ToString()
                Dim01Navn.Text = dr.GetString(7).ToString()
                Dim01Værdi.Text = dr.GetString(8).ToString()
                Dim02Navn.Text = dr.GetString(9).ToString()
                Dim02Værdi.Text = dr.GetString(10).ToString()
                Dim03Navn.Text = dr.GetString(11).ToString()
                Dim03Værdi.Text = dr.GetString(12).ToString()
                Dim04Navn.Text = dr.GetString(13).ToString()
                Dim04Værdi.Text = dr.GetString(14).ToString()
                Dim05Navn.Text = dr.GetString(15).ToString()
                Dim05Værdi.Text = dr.GetString(16).ToString()
                Dim06Navn.Text = dr.GetString(17).ToString()
                Dim06Værdi.Text = dr.GetString(18).ToString()
                Dim07Navn.Text = dr.GetString(19).ToString()
                Dim07Værdi.Text = dr.GetString(20).ToString()
                Dim08Navn.Text = dr.GetString(21).ToString()
                Dim08Værdi.Text = dr.GetString(22).ToString()
                Dim09Navn.Text = dr.GetString(23).ToString()
                Dim09Værdi.Text = dr.GetString(24).ToString()
                Dim10Navn.Text = dr.GetString(25).ToString()
                Dim10Værdi.Text = dr.GetString(26).ToString()
                BeløbsVærdi.Text = dr.GetString(4).ToString()
                KommentarTekst.Text = dr.GetString(6).ToString()
                cmd.ExecuteNonQuery()

            End While

        Catch ex As Exception

        End Try

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    Public Sub disp_data()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from KorrektionsFact"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt



    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DatoVærdi.Text = Format(DateTimePicker1.Value, "yyyy-MM-dd")

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into KorrektionsFact values(   '" & DatoVærdi.Text & "',
                                                               '" & BrugerGruppe.Text & "',                                              
                                                               '" & BrugerTekst.Text & "',
                                                               '" & VersionTekst.Text & "',
                                                               '" & Dim01Navn.Text & "',
                                                               '" & Dim01Værdi.Text & "', 
                                                               '" & Dim02Navn.Text & "', 
                                                               '" & Dim02Værdi.Text & "', 
                                                               '" & Dim03Navn.Text & "', 
                                                               '" & Dim03Værdi.Text & "', 
                                                               '" & Dim04Navn.Text & "', 
                                                               '" & Dim04Værdi.Text & "', 
                                                               '" & Dim05Navn.Text & "',
                                                               '" & Dim05Værdi.Text & "', 
                                                               '" & Dim06Navn.Text & "', 
                                                               '" & Dim06Værdi.Text & "', 
                                                               '" & Dim07Navn.Text & "', 
                                                               '" & Dim07Værdi.Text & "',
                                                               '" & Dim08Navn.Text & "', 
                                                               '" & Dim08Værdi.Text & "', 
                                                               '" & Dim09Navn.Text & "', 
                                                               '" & Dim09Værdi.Text & "', 
                                                               '" & Dim10Navn.Text & "', 
                                                               '" & Dim10Værdi.Text & "', 
                                                                '" & BeløbsVærdi.Text & "',
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
        cmd.CommandText = "UPDATE KorrektionsFact set           Dato = '" + DatoVærdi.Text + "',
                                                                [BrugerGruppe] = '" + BrugerGruppe.Text + "',                                              
                                                                [Bruger] ='" + BrugerTekst.Text + "',
                                                                [Version]= '" + VersionTekst.Text + "',
                                                                [Dim01] = '" + Dim01Navn.Text + "',
                                                                [Dim01Value] ='" + Dim01Værdi.Text + "', 
                                                                [Dim02] = '" + Dim02Navn.Text + "', 
                                                               [Dim02Value] = '" + Dim02Værdi.Text + "', 
                                                               [Dim03] = '" + Dim03Navn.Text + "', 
                                                               [Dim03Value] = '" + Dim03Værdi.Text + "', 
                                                               [Dim04] = '" + Dim04Navn.Text + "', 
                                                               [Dim04Value] ='" + Dim04Værdi.Text + "', 
                                                               [Dim05] = '" + Dim05Navn.Text + "',
                                                               [Dim05Value] ='" + Dim05Værdi.Text + "', 
                                                               [Dim06] = '" + Dim06Navn.Text + "', 
                                                               [Dim06Value] = '" + Dim06Værdi.Text + "', 
                                                               [Dim07] = '" + Dim07Navn.Text + "', 
                                                               [Dim07Value] = '" + Dim07Værdi.Text + "',
                                                               [Dim08] = '" + Dim08Navn.Text + "', 
                                                               [Dim08Value] = '" + Dim08Værdi.Text + "', 
                                                               [Dim09] = '" + Dim09Navn.Text + "', 
                                                               [Dim09Value] = '" + Dim09Værdi.Text + "', 
                                                               [Dim10] = '" + Dim10Navn.Text + "', 
                                                               [Dim10Value] = '" + Dim10Værdi.Text + "', 
                                                               Beløb = '" + BeløbsVærdi.Text + "',
                                                               Kommentar = '" + KommentarTekst.Text + "' where Løbenr= " & i & ""

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
        cmd.CommandText = "delete from KorrektionsFact where Dato = '" & DatoVærdi.Text & "'"
        cmd.ExecuteNonQuery()

        disp_data()


        MessageBox.Show("record deleted Successsfully")

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        KorrektionsFactBindingSource.MovePrevious()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        KorrektionsFactBindingSource.MoveNext()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If com.State = ConnectionState.Open Then
            com.Close()
        End If
        com.Open()

        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from KorrektionsFact where [Bruger] =  '" + BrugerTekst.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If com.State = ConnectionState.Open Then
            com.Close()
        End If
        com.Open()

        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from KorrektionsFact where [Dim01Value] =  '" + Dim01Værdi.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If com.State = ConnectionState.Open Then
            com.Close()
        End If
        com.Open()

        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from KorrektionsFact where    [Version]= '" + VersionTekst.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles LeverandørNavn.TextChanged

    End Sub

    Private Sub KommentarTekst_TextChanged(sender As Object, e As EventArgs) Handles KommentarTekst.TextChanged

    End Sub

    Private Sub KommentarLabel_Click(sender As Object, e As EventArgs) Handles KommentarLabel.Click

    End Sub

    Private Sub Dim06Navn_TextChanged(sender As Object, e As EventArgs) Handles Dim06Navn.TextChanged



    End Sub

End Class
