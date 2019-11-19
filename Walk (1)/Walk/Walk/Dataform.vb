Imports System.Data.SqlClient
Public Class IntastningAfWalkData

    Dim com As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer

    Private Sub IntastningafWalkData(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WalkDataSet7.WalkData' table. You can move, or remove it, as needed.
        Me.WalkDataTableAdapter.Fill(Me.WalkDataSet7.WalkData)
        'TODO: This line of code loads data into the 'WalkDataSet6.vWalkData' table. You can move, or remove it, as needed.
        Me.VWalkDataTableAdapter.Fill(Me.WalkDataSet6.vWalkData)
        'TODO: This line of code loads data into the 'WalkDataSet5.vWalkData' table. You can move, or remove it, as needed.
        Me.VWalkDataTableAdapter1.Fill(Me.WalkDataSet1.vWalkData)
        'TODO: This line of code loads data into the 'WalkDataSet4.WalkData' table. You can move, or remove it, as needed.
        Me.WalkDataTableAdapter2.Fill(Me.WalkDataSet.WalkData)
        'TODO: This line of code loads data into the 'WalkDataSet3.WalkData' table. You can move, or remove it, as needed.
        Me.WalkDataTableAdapter1.Fill(Me.WalkDataSet3.WalkData)
        'TODO: This line of code loads data into the 'WalkDataSet2.vWalkdata' table. You can move, or remove it, as needed.
        Me.VWalkdataTableAdapter.Fill(Me.WalkDataSet2.vWalkdata)
        'TODO: This line of code loads data into the 'WalkDataSet1.WalkData' table. You can move, or remove it, as needed.
        Me.WalkDataTableAdapter.Fill(Me.WalkDataSet1.WalkData)
        'TODO: This line of code loads data into the 'WalkDataSet1.vWalkdata' table. You can move, or remove it, as needed.
        Me.WalkDataTableAdapter.Fill(Me.WalkDataSet1.WalkData)
        'TODO: This line of code loads data into the 'WalkDataSet.vWalkdata' table. You can move, or remove it, as needed.
        Me.WalkDataTableAdapter.Fill(Me.WalkDataSet1.WalkData)

        com.ConnectionString = "Data Source=VBJXPS2017\VITUS;Initial Catalog=Walk;Integrated Security=True"
        If com.State = ConnectionState.Open Then
            com.Close()
        End If
        com.Open()

        disp_data()
        disp_data1()

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
            cmd.CommandText = "select * from WalkData where Id=" & i & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While dr.Read()

                DatoVærdi.Text = dr.GetString(1).ToString()
                FornavnTekst.Text = dr.GetString(2).ToString()
                EfternavnTekst.Text = dr.GetString(3).ToString()
                AntalSkridtVærdi.Text = dr.GetString(4).ToString()
                AntalKmVærdi.Text = dr.GetString(5).ToString()
                AntalMinutterVærdi.Text = dr.GetString(6).ToString()
                AntalKalorierVærdi.Text = dr.GetString(7).ToString()
                Noter.Text = dr.GetString(8)
                cmd.ExecuteNonQuery()

            End While

        Catch ex As Exception

        End Try

    End Sub
    Public Sub disp_data()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from WalkData"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt



    End Sub
    Public Sub disp_data1()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from vWalkData"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView2.DataSource = dt


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into WalkData values('" & DatoVærdi.Text & "','" & FornavnTekst.Text & "','" & EfternavnTekst.Text & "'," & AntalSkridtVærdi.Text & "," & AntalKmVærdi.Text & "," & AntalMinutterVærdi.Text & "," & AntalKalorierVærdi.Text & ",'" & Noter.Text & "')"
        cmd.ExecuteNonQuery()

        disp_data()
        disp_data1()

        MessageBox.Show("record Inserted Successsfully")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DatoVærdi.Text = Format(DateTimePicker1.Value, "yyyy-MM-dd")

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If com.State = ConnectionState.Open Then
            com.Close()
        End If
        com.Open()

        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "UPDATE WalkData set Dato = '" & DatoVærdi.Text & "' ,Fornavn= '" & FornavnTekst.Text & "' ,Efternavn = '" & EfternavnTekst.Text & "' ,Skridt = " & AntalSkridtVærdi.Text & " ,Km= " & AntalKmVærdi.Text & " ,Minutter= " & AntalMinutterVærdi.Text & " ,Kalorier= " & AntalKalorierVærdi.Text & " ,Noter = '" & Noter.Text & "' where Id=" & i & ""
        cmd.ExecuteNonQuery()

        disp_data()
        disp_data1()

        MessageBox.Show("record updated Successsfully")

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If com.State = ConnectionState.Open Then
            com.Close()
        End If
        com.Open()

        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from WalkData where Dato = '" & DatoVærdi.Text & "'"
        cmd.ExecuteNonQuery()

        disp_data()
        disp_data1()

        MessageBox.Show("record deleted Successsfully")

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from WalkData where Dato = '" & DatoVærdi.Text & "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        disp_data()
        disp_data1()

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from WalkData where Dato = '" & DatoVærdi.Text & "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView2.DataSource = dt

        disp_data()
        disp_data1()

    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        WalkDataBindingSource.MovePrevious()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        WalkDataBindingSource.MoveNext()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

End Class
