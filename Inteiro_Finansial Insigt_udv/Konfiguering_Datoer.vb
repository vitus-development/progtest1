Imports System.Data.SqlClient
Public Class Konfiguering_Datoer
    Dim com As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Dim i2 As Integer
    Dim i3 As Integer
    Dim x As String
    Dim y As String
    Public Sub disp_data2()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from  Setup_Betalings_dato   "
        cmd.ExecuteNonQuery()
        Dim dt4 As New DataTable()
        Dim da4 As New SqlDataAdapter(cmd)
        da4.Fill(dt4)
        DataGridView2.DataSource = dt4

    End Sub
    Public Sub disp_data1()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from  Setup_Dato   "
        cmd.ExecuteNonQuery()
        Dim dt3 As New DataTable()
        Dim da3 As New SqlDataAdapter(cmd)
        da3.Fill(dt3)
        DataGridView3.DataSource = dt3

    End Sub
    Public Sub disp_data4()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from  DatoPeriode   Dato = '" + Udbetalingsdato.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt4 As New DataTable()
        Dim da4 As New SqlDataAdapter(cmd)
        da4.Fill(dt4)
        DataGridView4.DataSource = dt4
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Løntype.Text = LøntypeComboBox.Text
    End Sub
    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        Løntype.Text = LøntypeComboBox.Text
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabKonfigureringdatoer.SelectedIndexChanged

    End Sub
    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        År.Text = ÅrComboBox.Text

    End Sub
    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click

        Dagen.Text = DagComboBox.Text

    End Sub
    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        Interval.Text = IntervalComboBox.Text


    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs)
        Dato.Text = DatoComboBox.Text


    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Setup_Dato  values
            ( '" & Dato.Text & "', 
           '" & Interval.Text & "',
           '" & Dagen.Text & "',
          '" & Dato_per01.Text & "',
          '" & Periode01.Text & "',
          '" & Dato_per02.Text & " ',
          '" & Periode02.Text & "',
          '" & Dato_per03.Text & "',  
          '" & Periode03.Text & "',
          '" & Dato_per04.Text & "',
          '" & Periode04.Text & "',
          '" & Dato_per05.Text & "',
          '" & Periode05.Text & "',
          '" & Dato_per06.Text & "', 
          '" & Periode06.Text & "',
          '" & Dato_per07.Text & "', 
          '" & Periode07.Text & "',
          '" & Dato_per08.Text & "', 
          '" & Periode08.Text & "',
          '" & Dato_per09.Text & "' ,
          '" & Periode09.Text & "',
          '" & Dato_per10.Text & "',
          '" & Periode10.Text & "',
          '" & Dato_per11.Text & "',
          '" & Periode11.Text & "',
          '" & Dato_per12.Text & "',
           '" & Periode12.Text & "' )"
        cmd.ExecuteNonQuery()

        MessageBox.Show("record Inserted Successsfully")
        disp_data1()


    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click


    End Sub



    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        If com.State = ConnectionState.Open Then
            com.Close()
        End If
        com.Open()

        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from  Setup_Dato  where Dato = '" & DatoværdiSetup.Text & "'"
        cmd.ExecuteNonQuery()

        disp_data1()


        MessageBox.Show("record deleted Successsfully")
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from  Setup_Dato   "
        cmd.ExecuteNonQuery()
        Dim dt3 As New DataTable()
        Dim da3 As New SqlDataAdapter(cmd)
        da3.Fill(dt3)
        DataGridView3.DataSource = dt3
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Udbetalingsinterval.Text = UdbetalingsintervalComboBox.Text


    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        Udbetalingsår.Text = UdbetalingsårComboBox.Text

    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        Udbetalingsdag.Text = UdbetalingsdagComboBox.Text

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Udbetalingsdato.Text = UdbetalingsdatoComboBox.Text


    End Sub

    Private Sub Button49_Click_1(sender As Object, e As EventArgs) Handles Button49.Click
        Dato.Text = DatoComboBox.Text

    End Sub

    Private Sub FillBy6ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy6ToolStripButton.Click


    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click



    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Setup_Betalings_dato  values
            ( '" & Dato.Text & "', 
           '" & Interval.Text & "',
           '" & Dagen.Text & "',
          '" & Udbetalingsdato_01.Text & "',
          '" & Periode01.Text & "',
          '" & Udbetalingsdato_per02.Text & " ',
          '" & Periode02.Text & "',
          '" & Udbetalingsdato_per03.Text & "',  
          '" & Periode03.Text & "',
          '" & Udbetalingsdato_per04.Text & "',
          '" & Periode04.Text & "',
          '" & Udbetalingsdato_per05.Text & "',
          '" & Periode05.Text & "',
          '" & Udbetalingsdato_per06.Text & "', 
          '" & Periode06.Text & "',
          '" & Udbetalingsdato_per07.Text & "', 
          '" & Periode07.Text & "',
          '" & Udbetalingsdato_per08.Text & "', 
          '" & Periode08.Text & "',
          '" & Udbetalingsdato_per09.Text & "' ,
          '" & Periode09.Text & "',
          '" & Udbetalingsdato_per10.Text & "',
          '" & Periode10.Text & "',
          '" & Udbetalingsdato_per11.Text & "',
          '" & Periode11.Text & "',
          '" & Udbetalingsdato_per12.Text & "',
           '" & Periode12.Text & "' )"
        cmd.ExecuteNonQuery()

        MessageBox.Show("record Inserted Successsfully")
        disp_data2()


    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

    End Sub

    Private Sub UdbetalingsårComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UdbetalingsårComboBox.SelectedIndexChanged

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click

    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick

    End Sub
End Class