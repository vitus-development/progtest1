Imports System.Data.SqlClient
Public Class Datokonfiguering
    Dim com As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Dim i2 As Integer
    Dim i3 As Integer
    Dim x As String
    Dim y As String

    Private Sub Datokonfiguering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetVSetupdato.vSetupdato' table. You can move, or remove it, as needed.
        Me.VSetupdatoTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetVSetupdato.vSetupdato)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetPeriode_År_interval_dag1.Dato_Periode_År_Interval_Dag' table. You can move, or remove it, as needed.
        Me.Dato_Periode_År_Interval_DagTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetPeriode_År_interval_dag1.Dato_Periode_År_Interval_Dag)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDatasetDatoPeriodeÅrInterval.Dato_Periode_År_Interval' table. You can move, or remove it, as needed.
        Me.Dato_Periode_År_IntervalTableAdapter.Fill(Me.Inteiro_Financial_InsightDatasetDatoPeriodeÅrInterval.Dato_Periode_År_Interval)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetDatoPeriodeÅR.Dato_Periode_År' table. You can move, or remove it, as needed.
        Me.Dato_Periode_ÅrTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetDatoPeriodeÅR.Dato_Periode_År)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetDatoPeriode2.Dato_Periode' table. You can move, or remove it, as needed.
        Me.Dato_PeriodeTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetDatoPeriode2.Dato_Periode)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetVFinansår_Profil.vFinansår' table. You can move, or remove it, as needed.
        Me.VFinansårTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetVFinansår_Profil.vFinansår)
        com.ConnectionString = "Data Source=VBJXPS2017;Initial Catalog=Inteiro Financial Insight;Integrated Security=True"
        If com.State = ConnectionState.Open Then
            com.Close()
        End If
        com.Open()

    End Sub
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
        DataGridView2.DataSource = dt4
    End Sub
    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        År.Text = ÅrComboBox.Text
        Try
            Me.Dato_Periode_År_IntervalTableAdapter.FillBy2(Me.Inteiro_Financial_InsightDatasetDatoPeriodeÅrInterval.Dato_Periode_År_Interval, År.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click

        Dagen.Text = DagComboBox.Text
        Try
            Me.Dato_PeriodeTableAdapter.FillBy1(Me.Inteiro_Financial_InsightDataSetDatoPeriode2.Dato_Periode, År.Text, Interval.Text, Dagen.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        Interval.Text = IntervalComboBox.Text


        Try
            Me.Dato_Periode_År_Interval_DagTableAdapter.FillBy2(Me.Inteiro_Financial_InsightDataSetPeriode_År_interval_dag.Dato_Periode_År_Interval_Dag, År.Text, Interval.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

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

    Private Sub Button53_Click(sender As Object, e As EventArgs)

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

    Private Sub Button53_Click_1(sender As Object, e As EventArgs) Handles Button53.Click
        Try
            Me.Dato_PeriodeTableAdapter.FillBy2(Me.Inteiro_Financial_InsightDataSetDatoPeriode2.Dato_Periode, Interval.Text, År.Text, Dagen.Text, Dato.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class