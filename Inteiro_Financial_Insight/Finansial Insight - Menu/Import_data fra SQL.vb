Imports System.Data.SqlClient
Imports System
Public Class Import_data_fra_SQL
    Dim dt As New DataTable
    Dim Sql As New SqlClient.SqlConnection("Data Source=VBJXPS2017;Initial Catalog=Likviditetsmodul;Integrated Security=True")
    Dim adbtr As New SqlDataAdapter("Select * From dbo.Likviditetsbudgetkørsel", Sql)
     Dim dt1 As New DataTable
    Dim Sql1 As New SqlClient.SqlConnection("Data Source=VBJXPS2017;Initial Catalog=Inteiro Financial Insight;Integrated Security=True")
    Dim adbtr1 As New SqlDataAdapter("Select * From dbo.Likviditetsbudget_Niveau_1_2_test", Sql)
    Dim com As New SqlConnection
    Dim com1 As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Private Sub Budget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LikviditetsmodulDataSetBudgetkørsel_2.Likviditetsbudgetkørsel' table. You can move, or remove it, as needed.
        Me.LikviditetsbudgetkørselTableAdapter1.Fill(Me.LikviditetsmodulDataSetBudgetkørsel_2.Likviditetsbudgetkørsel)
        Me.Likviditetsbudget_Niveau_1_2_testTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSettest.Likviditetsbudget_Niveau_1_2_test)
        com.ConnectionString = "Data Source=VBJXPS2017;Initial Catalog=Likviditetsmodul;Integrated Security=True"
        If com.State = ConnectionState.Open Then
            com.Close()
        End If
        com.Open()
        com1.ConnectionString = ("Data Source=VBJXPS2017;Initial Catalog=Inteiro Financial Insight;Integrated Security=True")
        If com1.State = ConnectionState.Open Then
            com.Close()
        End If


    End Sub

    Private Sub DataGridview1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        DataGridView1.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
        Try


            If com.State = ConnectionState.Open Then
                com.Close()
            End If
            com.Open()
            i = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())

            cmd = com.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Likviditetsbudgetkørsel"
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While dr.Read()

                DatoVærdi.Text = dr.GetString(0).ToString()
                BrugerGruppeTekst.Text = dr.GetString(1).ToString()
                BrugerTekst.Text = dr.GetString(2).ToString()
                VersionTekst.Text = dr.GetSqlString(3).ToString()
                Dim01Navn.Text = dr.GetString(4).ToString()
                Dim01Værdi.Text = dr.GetString(5).ToString()
                Dim02Navn.Text = dr.GetString(6).ToString()
                Dim02Værdi.Text = dr.GetString(7).ToString()
                Dim03Navn.Text = dr.GetString(8).ToString()
                Dim03Værdi.Text = dr.GetString(9).ToString()
                Dim04Navn.Text = dr.GetString(10).ToString()
                Dim04Værdi.Text = dr.GetString(11).ToString()
                Dim05Navn.Text = dr.GetString(12).ToString()
                Dim05Værdi.Text = dr.GetString(13).ToString()
                Dim06Navn.Text = dr.GetString(14).ToString()
                Dim06Værdi.Text = dr.GetString(15).ToString()
                Dim07Navn.Text = dr.GetString(16).ToString()
                Dim07Værdi.Text = dr.GetString(17).ToString()
                Dim08Navn.Text = dr.GetString(18).ToString()
                Dim08Værdi.Text = dr.GetString(19).ToString()
                Dim09Navn.Text = dr.GetString(20).ToString()
                Dim09Værdi.Text = dr.GetString(21).ToString()
                Dim10Navn.Text = dr.GetString(22).ToString()
                Dim10Værdi.Text = dr.GetString(23).ToString()
                BeløbVærdi.Text = dr.GetFloat(24).ToString()
                KommentarTekst.Text = dr.GetString(25).ToString()
                K_beløb.Text = dr.GetFloat(26).ToString()
                Sbruttobeløb.Text = dr.GetFloat(27).ToString()
                Kbruttobeløb.Text = dr.GetFloat(28).ToString()
                MomsbelagtVærdi.Text = dr.GetString(29).ToString()
                cmd.ExecuteNonQuery()
                com.Close()
            End While

        Catch ex As Exception

        End Try

    End Sub
    Private Sub DataGridview2_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        DataGridView1.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex)
        Try


            If com.State = ConnectionState.Open Then
                com.Close()
            End If
            com.Open()
            i = Convert.ToInt32(DataGridView2.SelectedCells.Item(0).Value.ToString())

            cmd = com.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from dbo.Likviditetsbudget_Niveau_1_2_test"
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt1)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While dr.Read()

                DatoVærdi.Text = dr.GetString(0).ToString()
                BrugerGruppeTekst.Text = dr.GetString(1).ToString()
                BrugerTekst.Text = dr.GetString(2).ToString()
                VersionTekst.Text = dr.GetSqlString(3).ToString()
                Dim01Navn.Text = dr.GetString(4).ToString()
                Dim01Værdi.Text = dr.GetString(5).ToString()
                Dim02Navn.Text = dr.GetString(6).ToString()
                Dim02Værdi.Text = dr.GetString(7).ToString()
                Dim03Navn.Text = dr.GetString(8).ToString()
                Dim03Værdi.Text = dr.GetString(9).ToString()
                Dim04Navn.Text = dr.GetString(10).ToString()
                Dim04Værdi.Text = dr.GetString(11).ToString()
                Dim05Navn.Text = dr.GetString(12).ToString()
                Dim05Værdi.Text = dr.GetString(13).ToString()
                Dim06Navn.Text = dr.GetString(14).ToString()
                Dim06Værdi.Text = dr.GetString(15).ToString()
                Dim07Navn.Text = dr.GetString(16).ToString()
                Dim07Værdi.Text = dr.GetString(17).ToString()
                Dim08Navn.Text = dr.GetString(18).ToString()
                Dim08Værdi.Text = dr.GetString(19).ToString()
                Dim09Navn.Text = dr.GetString(20).ToString()
                Dim09Værdi.Text = dr.GetString(21).ToString()
                Dim10Navn.Text = dr.GetString(22).ToString()
                Dim10Værdi.Text = dr.GetString(23).ToString()
                BeløbVærdi.Text = dr.GetFloat(24).ToString()
                KommentarTekst.Text = dr.GetString(25).ToString()
                K_beløb.Text = dr.GetFloat(26).ToString()
                Sbruttobeløb.Text = dr.GetFloat(27).ToString()
                Kbruttobeløb.Text = dr.GetFloat(28).ToString()
                MomsbelagtVærdi.Text = dr.GetString(29).ToString()
                cmd.ExecuteNonQuery()
                com.Close()
            End While

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Import_data_fra_SQL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sql.Open()
        adbtr.Fill(dt)
        DataGridView1.DataSource = dt
        Sql.Close()
    End Sub

    Private Sub Import_data_fra_SQL1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sql.Open()
        adbtr.Fill(dt)
        DataGridView2.DataSource = dt1
        Sql.Close()
    End Sub

    Private Sub Button_1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim StrConn = "Data Source=VBJXPS2017;Initial Catalog=Likviditetsmodul;Integrated Security=True"
        Dim SQLConn As New SqlConnection(StrConn)
        Dim SQLcmd As New Data.SqlClient.SqlCommand
        Try

            SQLConn.Open()
            SQLcmd.Connection = SQLConn
            SQLcmd.CommandText = "INSERT INTO dbo.Likviditetsbudget_Niveau_1_2_test 
             ([Dato]
      ,[BrugerGruppe]
      ,[Bruger]
      ,[Version]
      ,[Dim01]
      ,[Dim01Value]
      ,[Dim02]
      ,[Dim02Value]
      ,[Dim03]
      ,[Dim03Value]
      ,[Dim04]
      ,[Dim04Value]
      ,[Dim05]
      ,[Dim05Value]
      ,[Dim06]
      ,[Dim06Value]
      ,[Dim07]
      ,[Dim07Value]
      ,[Dim08]
      ,[Dim08Value]
      ,[Dim09]
      ,[Dim09Value]
      ,[Dim10]
      ,[Dim10Value]
      ,[S_beløb]
      ,[Kommentar]
      ,[S_bruttobeløb]
      ,[K_beløb]
      ,[K_bruttobeløb]
      ,[Momsbelagt])
              VALUES (
 @Dato ,
        @BrugerGruppe,
         @Bruger,
        @Version,
        @Dim01,
        @Dim01Værdi, 
        @Dim02, 
        @Dim02Værdi, 
        @2Dim03, 
        @Dim03Værdi, 
        @Dim04, 
        @Dim04Værdi, 
        @Dim05Navn,
        @Dim05Værdi, 
        @Dim06, 
        @Dim06Værdi, 
        @Dim07, 
        @Dim07Værdi,
        @Dim08, 
        @Dim08Værdi, 
        @Dim09, 
        @Dim09Værdi, 
        @Dim10, 
        @Dim10Værdi,
        @S_beløb,
        @Kommentar,      
        @S_bruttobeløb,
        @K_beløb,
        @K_bruttobeløb,
            @Momsbelagt)"

            SQLcmd.Parameters.Add("@DataGridView1.Dato", SqlDbType.Text)
            SQLcmd.Parameters.Add("@DataGridView1.BrugerGruppe", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Bruger", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Version", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Dim01", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Dim01Value", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Dim02", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Dim02Value", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Dim03", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Dim03Value", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Dim03", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Dim03Value", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Dim04", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Dim04Value", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Dim05", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Dim05Value", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Dim06", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Dim06Value", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Dim07", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Dim07Value", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Dim08", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Dim08Value", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Dim09", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Dim09Value", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Dim10", SqlDbType.VarChar)
            SQLcmd.Parameters.Add("@DataGridView1.Dim10Value", SqlDbType.Text)
            SQLcmd.Parameters.Add("@DataGridView1.S_beløb", SqlDbType.Float)
            SQLcmd.Parameters.Add("@DataGridView1.Kommentar", SqlDbType.Float)
            SQLcmd.Parameters.Add("@DataGridView1.S_bruttobeløb", SqlDbType.Float)
            SQLcmd.Parameters.Add("@DataGridView1.K_beløb", SqlDbType.Float)
            SQLcmd.Parameters.Add("@DataGridView1.K_bruttobeløb", SqlDbType.Float)
            SQLcmd.Parameters.Add("@DataGridView1.Momsbelagt", SqlDbType.Float)




            For i As Integer = 0 To DataGridView2.Rows.Count - 1
                SQLcmd.Parameters(0).Value = DataGridView2.Rows(i).Cells(0).Value
                SQLcmd.Parameters(1).Value = DataGridView2.Rows(i).Cells(1).Value
                SQLcmd.Parameters(2).Value = DataGridView2.Rows(i).Cells(2).Value
                SQLcmd.Parameters(3).Value = DataGridView2.Rows(i).Cells(3).Value
                SQLcmd.Parameters(4).Value = DataGridView2.Rows(i).Cells(4).Value
                SQLcmd.Parameters(5).Value = DataGridView2.Rows(i).Cells(5).Value
                SQLcmd.Parameters(6).Value = DataGridView2.Rows(i).Cells(6).Value
                SQLcmd.Parameters(7).Value = DataGridView2.Rows(i).Cells(7).Value
                SQLcmd.Parameters(8).Value = DataGridView2.Rows(i).Cells(8).Value
                SQLcmd.Parameters(9).Value = DataGridView2.Rows(i).Cells(9).Value
                SQLcmd.Parameters(10).Value = DataGridView2.Rows(i).Cells(10).Value
                SQLcmd.Parameters(11).Value = DataGridView2.Rows(i).Cells(11).Value
                SQLcmd.Parameters(12).Value = DataGridView2.Rows(i).Cells(12).Value
                SQLcmd.Parameters(13).Value = DataGridView2.Rows(i).Cells(13).Value
                SQLcmd.Parameters(14).Value = DataGridView2.Rows(i).Cells(14).Value
                SQLcmd.Parameters(15).Value = DataGridView2.Rows(i).Cells(15).Value
                SQLcmd.Parameters(16).Value = DataGridView2.Rows(i).Cells(16).Value
                SQLcmd.Parameters(17).Value = DataGridView2.Rows(i).Cells(17).Value
                SQLcmd.Parameters(18).Value = DataGridView2.Rows(i).Cells(18).Value
                SQLcmd.Parameters(19).Value = DataGridView2.Rows(i).Cells(19).Value
                SQLcmd.Parameters(20).Value = DataGridView2.Rows(i).Cells(20).Value
                SQLcmd.Parameters(21).Value = DataGridView2.Rows(i).Cells(21).Value
                SQLcmd.Parameters(22).Value = DataGridView2.Rows(i).Cells(22).Value
                SQLcmd.Parameters(23).Value = DataGridView2.Rows(i).Cells(23).Value
                SQLcmd.Parameters(24).Value = DataGridView2.Rows(i).Cells(24).Value
                SQLcmd.Parameters(25).Value = DataGridView2.Rows(i).Cells(25).Value
                SQLcmd.Parameters(26).Value = DataGridView2.Rows(i).Cells(26).Value
                SQLcmd.Parameters(27).Value = DataGridView2.Rows(i).Cells(27).Value
                SQLcmd.Parameters(28).Value = DataGridView2.Rows(i).Cells(28).Value
                SQLcmd.Parameters(29).Value = DataGridView2.Rows(i).Cells(29).Value
                SQLcmd.Parameters(30).Value = DataGridView2.Rows(i).Cells(28).Value
                SQLcmd.Parameters(31).Value = DataGridView2.Rows(i).Cells(29).Value
            Next
        Catch ex As SqlException

            MessageBox.Show("record Inserted Successsfully")
        End Try

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Sql1.Open()
        com1.ConnectionString = "Data Source=VBJXPS2017;Initial Catalog=Inteiro Financial Insight;Integrated Security=True"
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Likviditetsbudget_Niveau_1_2_test values
                                                                
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
        '" & BeløbVærdi.Text & "' ,
         '" & KommentarTekst.Text & "',      
         '" & Sbruttobeløb.Text & "',
        '" & K_beløb.Text & "',
        '" & Kbruttobeløb.Text & "',
         '" & MomsbelagtVærdi.Text & "')"
        cmd.ExecuteNonQuery()



        disp_data()

        MessageBox.Show("record Inserted Successsfully")
    End Sub
    Public Sub disp_data()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Likviditetsbudget_Niveau_1_2_test "
        cmd.ExecuteNonQuery()
        Dim dt1 As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt1)
        DataGridView2.DataSource = dt1

    End Sub

End Class