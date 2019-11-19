Imports System.Data.SqlClient
Public Class Indtastninger
    Dim com As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Private Sub Indtastninger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dranst.Par_Dranst' table. You can move, or remove it, as needed.
        Me.Par_DranstTableAdapter1.Fill(Me.Dranst.Par_Dranst)
        'TODO: This line of code loads data into the 'Sted.Parameter_Sted' table. You can move, or remove it, as needed.
        Me.Parameter_StedTableAdapter.Fill(Me.Sted.Parameter_Sted)

        'TODO: This line of code loads data into the 'KorrectionsFactDataSet.KorrektionsFact' table. You can move, or remove it, as needed.
        Me.KorrektionsFactTableAdapter.Fill(Me.KorrectionsFactDataSet.KorrektionsFact)
        com.ConnectionString = "Data Source=VBJXPS2017;Initial Catalog=Likviditetsmodul;Integrated Security=True"
        'TODO: This line of code loads data into the 'LikviditetsmodulDataSet3._16_Dransk' table. You can move, or remove it, as needed.
        Me._16_DranskTableAdapter.Fill(Me.LikviditetsmodulDataSet3._16_Dransk)
        'TODO: This line of code loads data into the 'LikviditetsmodulDataSet2._02_Artskonto' table. You can move, or remove it, as needed.
        Me._02_ArtskontoTableAdapter.Fill(Me.LikviditetsmodulDataSet2._02_Artskonto)
        'TODO: This line of code loads data into the 'LikviditetsmodulDataSet1._17_Bank' table. You can move, or remove it, as needed.
        Me._17_BankTableAdapter.Fill(Me.LikviditetsmodulDataSet1._17_Bank)
        'TODO: This line of code loads data into the 'LikviditetsmodulDataSet.Regkonto' table. You can move, or remove it, as needed.
        Me.RegkontoTableAdapter.Fill(Me.LikviditetsmodulDataSet.Regkonto)
        'TODO: This line of code loads data into the 'BrugerGruppeDataSet.Brugergruppe' table. You can move, or remove it, as needed.
        Me.BrugergruppeTableAdapter.Fill(Me.BrugerGruppeDataSet.Brugergruppe)
        If com.State = ConnectionState.Open Then
            com.Close()
        End If

        com.Open()




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
                BrugerGruppeTekst.Text = dr.GetString(2).ToString()
                BrugerTekst.Text = dr.GetString(3).ToString()
                VersionTekst.Text = dr.GetSqlString(4).ToString()
                Dim01Navn.Text = dr.GetString(5).ToString()
                Dim01Værdi.Text = dr.GetString(6).ToString()
                Dim02Navn.Text = dr.GetString(7).ToString()
                Dim02Værdi.Text = dr.GetString(8).ToString()
                Dim03Navn.Text = dr.GetString(9).ToString()
                Dim03Værdi.Text = dr.GetString(10).ToString()
                Dim04Navn.Text = dr.GetString(11).ToString()
                Dim04Værdi.Text = dr.GetString(12).ToString()
                Dim05Navn.Text = dr.GetString(13).ToString()
                Dim05Værdi.Text = dr.GetString(14).ToString()
                Dim06Navn.Text = dr.GetString(15).ToString()
                Dim06Værdi.Text = dr.GetString(16).ToString()
                Dim07Navn.Text = dr.GetString(17).ToString()
                Dim07Værdi.Text = dr.GetString(18).ToString()
                Dim08Navn.Text = dr.GetString(19).ToString()
                Dim08Værdi.Text = dr.GetString(20).ToString()
                Dim09Navn.Text = dr.GetString(21).ToString()
                Dim09Værdi.Text = dr.GetString(22).ToString()
                Dim10Navn.Text = dr.GetString(23).ToString()
                Dim10Værdi.Text = dr.GetString(24).ToString()
                BeløbVærdi.Text = dr.GetString(25).ToString()
                KommentarTekst.Text = dr.GetString(26).ToString()
                cmd.ExecuteNonQuery()

            End While

        Catch ex As Exception

        End Try

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

    Private Sub GroupBox1__Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub DatoLabel3_Click(sender As Object, e As EventArgs) Handles DatoLabel3.Click

    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DatoVærdi.Text = Format(DateTimePicker1.Value, "yyyy-MM-dd")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into KorrektionsFact values
                                                                
         ('" & DatoVærdi.Text & "',
        '" & BrugerGruppeTekst.Text & " ',
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
        '" & BeløbVærdi.Text & "',
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
        cmd.CommandText = ("UPDATE KorrektionsFact set 
        Dato = '" + DatoVærdi.Text + "',
        BrugerGruppe ='" + BrugerGruppeTekst.Text + " ',
        Bruger = '" + BrugerTekst.Text + "',
        Version = '" + VersionTekst.Text + "',
        Dim01 = '" + Dim01Navn.Text + "',
        Dim01Value = '" + Dim01Værdi.Text + "', 
        Dim02 =  '" + Dim02Navn.Text + "', 
        Dim02Value  = '" + Dim02Værdi.Text + "', 
        Dim03 = '" + Dim03Navn.Text + "', 
        Dim03Value ='" + Dim03Værdi.Text + "', 
        Dim04 = '" + Dim04Navn.Text + "', 
        Dim04Value = '" + Dim04Værdi.Text + "', 
        Dim05 ='" + Dim05Navn.Text + "',
        Dim05Value ='" + Dim05Værdi.Text + "', 
        Dim06 = '" + Dim06Navn.Text + "', 
        Dim06Value = '" + Dim06Værdi.Text + "', 
        Dim07 = '" + Dim07Navn.Text + "', 
        Dim07Value = '" + Dim07Værdi.Text + "',
        Dim08 = '" + Dim08Navn.Text + "', 
        Dim08Value = '" + Dim08Værdi.Text + "', 
        Dim09 = '" + Dim09Navn.Text + "', 
        Dim09Value = '" + Dim09Værdi.Text + "', 
        Dim10 = '" + Dim10Navn.Text + "', 
        Dim10Value = '" + Dim10Værdi.Text + "', 
        Beløb = '" + BeløbVærdi.Text + "',
        Kommentar = '" + KommentarTekst.Text + "' 
        where Løbenr= ") & i & ""
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
        KorrektionsFactBindingSource.MoveFirst()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        KorrektionsFactBindingSource.MoveLast()
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Hovedmenu.Show()
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        LøbenrVærdi.Text = " "
        DatoVærdi.Text = " "
        BrugerGruppeTekst.Text = " "
        BrugerTekst.Text = " "
        VersionTekst.Text = " "
        Dim01Navn.Text = " "
        Dim01Værdi.Text = " "
        Dim02Navn.Text = " "
        Dim02Værdi.Text = " "
        Dim03Navn.Text = ""
        Dim03Værdi.Text = " "
        Dim04Navn.Text = " "
        Dim04Værdi.Text = " "
        Dim05Navn.Text = " "
        Dim05Værdi.Text = " "
        Dim06Navn.Text = " "
        Dim06Værdi.Text = " "
        Dim07Navn.Text = " "
        Dim07Værdi.Text = " "
        Dim08Navn.Text = " "
        Dim08Værdi.Text = " "
        Dim09Navn.Text = " "
        Dim09Værdi.Text = " "
        Dim10Navn.Text = " "
        Dim10Værdi.Text = " "
        BeløbVærdi.Text = " "
        KommentarTekst.Text = " "

        MessageBox.Show("Indtastningform cleared Successsfully")

    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        disp_data()
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from KorrektionsFact where Dato = '" + DatoVærdi.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt


    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from KorrektionsFact where Version = '" + VersionTekst.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from KorrektionsFact where BrugerGruppe = '" + BrugerGruppeTekst.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from KorrektionsFact where Bruger = '" + BrugerTekst.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim09Værdi.Text = Regkontonr.Text

    End Sub
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim02Værdi.Text = S1tekst.Text
    End Sub
    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim08Værdi.Text = BankkontoCombo.Text
    End Sub
    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim03Værdi.Text = DranstCombo.Text
    End Sub
    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from KorrektionsFact where Løbenr = '" + LøbenrVærdi.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub
    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim04Værdi.Text = ArtskontoComboBox.Text
    End Sub
    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from KorrektionsFact where Dim03Value = '" + Dim03Værdi.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub
    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from KorrektionsFact where Dim04Value = '" + Dim04Værdi.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub GroupBox7_Enter(sender As Object, e As EventArgs) Handles GroupBox7.Enter
    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub
    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.RegkontoTableAdapter.FillBy1(Me.LikviditetsmodulDataSet.Regkonto)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Parameter_StedTableAdapter.FillBy(Me.Sted.Parameter_Sted)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStripButton1_Click(sender As Object, e As EventArgs)
        Try
            Me.Par_DranstTableAdapter.FillBy(Me.LikviditetsmodulDataSet4.Par_Dranst)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStripButton_Click_1(sender As Object, e As EventArgs)
        Try
            Me.Par_DranstTableAdapter1.FillBy(Me.Dranst.Par_Dranst)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click_1(sender As Object, e As EventArgs)
        Try
            Me.Par_DranstTableAdapter1.FillBy1(Me.Dranst.Par_Dranst)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click_2(sender As Object, e As EventArgs)
        Try
            Me.RegkontoTableAdapter.FillBy1(Me.LikviditetsmodulDataSet.Regkonto)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy2ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Par_DranstTableAdapter1.FillBy2(Me.Dranst.Par_Dranst)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class