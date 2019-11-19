Imports System.Data.SqlClient
Public Class Budget
    Dim com As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Dim i2 As Integer
    Dim i3 As Integer
    Dim thedatatabel As New DataTable
    Private Sub Budget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSet3Hovedformål.vHovedformål' table. You can move, or remove it, as needed.
        Me.VHovedformålTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSet3Hovedformål.vHovedformål)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetvHovedfunktion.vHovedfunktion' table. You can move, or remove it, as needed.
        Me.VHovedfunktionTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetvHovedfunktion.vHovedfunktion)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetF1_Hovedkonto.vHovedkonto' table. You can move, or remove it, as needed.
        Me.VHovedkontoTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetF1_Hovedkonto.vHovedkonto)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSet1_sted_saldo.vStedSaldo_Primo' table. You can move, or remove it, as needed.
        Me.VStedSaldo_PrimoTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSet1_sted_saldo.vStedSaldo_Primo)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSet.vLikviditetsbudget_Niveau_1' table. You can move, or remove it, as needed.
        Me.VLikviditetsbudget_Niveau_1TableAdapter.Fill(Me.Inteiro_Financial_InsightDataSet.vLikviditetsbudget_Niveau_1)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSet.vLikviditetsbudget_Niveau_1' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetLikviditet.Likviditetsbudget_Niveau_1_2' table. You can move, or remove it, as needed.
        Me.Likviditetsbudget_Niveau_1_2TableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetLikviditet.Likviditetsbudget_Niveau_1_2)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetLikviditet.Likviditetsbudget_Niveau_1_2' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSet31.vLikviditetsbudget_Niveau_1' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSet5Version.vVersion' table. You can move, or remove it, as needed.
        Me.VVersionTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSet5Version.vVersion)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSet5BrugerGruppe.vBrugerGruppe' table. You can move, or remove it, as needed.
        Me.VBrugerGruppeTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSet5BrugerGruppe.vBrugerGruppe)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSet5Brugergruppe.vBrugerGruppe' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSet5_version.vVersion' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSet4.vBruger' table. You can move, or remove it, as needed.
        Me.VBrugerTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSet4.vBruger)
        'TODO: This line of code loads data into the 'VG2Dataset.vG2' table. You can move, or remove it, as needed.
        Me.VG2TableAdapter.Fill(Me.VG2Dataset.vG2)
        'TODO: This line of code loads data into the 'VG1Dataset.vG1' table. You can move, or remove it, as needed.
        Me.VG1TableAdapter.Fill(Me.VG1Dataset.vG1)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSet3.vLikviditetsbudget_Niveau_1' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'VlikviditetsbudgetDataSet1.vLikviditetsbudget_Niveau_1' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSet2.vDranst' table. You can move, or remove it, as needed.
        Me.VDranstTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSet2.vDranst)
        'TODO: This line of code loads data into the 'VRegkontoDataSet.vRegkonto' table. You can move, or remove it, as needed.
        Me.VRegkontoTableAdapter.Fill(Me.VRegkontoDataSet.vRegkonto)
        'TODO: This line of code loads data into the 'VStedDataSet1.vSted' table. You can move, or remove it, as needed.
        Me.VStedTableAdapter.Fill(Me.VStedDataSet1.vSted)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSet1.vStedSaldo_Primo' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'LikviditetsbudgetNiveau1Dataset.Likviditetsbudget_Niveau_1_2' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSet.vLikviditetsbudget_Niveau_1' table. You can move, or remove it, as needed.

        com.ConnectionString = "Data Source=VBJXPS2017;Initial Catalog=Inteiro Financial Insight;Integrated Security=True"

        If com.State = ConnectionState.Open Then
            com.Close()
        End If
        com.Open()

    End Sub
    Private Sub DataGridview2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick

        Try


            If com.State = ConnectionState.Open Then
                com.Close()
            End If
            com.Open()
            i = Convert.ToInt32(DataGridView2.SelectedCells.Item(0).Value.ToString())

            cmd = com.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from Likviditetsbudget_Niveau_1_2 where Løbenr =" & i & "order by Løbenr asc "
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
                K_beløb.Text = dr.GetString(27).ToString()
                Sbruttobeløb.Text = dr.GetString(28).ToString()
                Kbruttobeløb.Text = dr.GetString(29).ToString()
                cmd.ExecuteNonQuery()

            End While

        Catch ex As Exception

        End Try

    End Sub
    Private Sub DataGridview1_CellClick(sender As Object, e As DataGridViewCellEventArgs)

        Try


            If com.State = ConnectionState.Open Then
                com.Close()
            End If
            com.Open()
            i = Convert.ToInt32(DataGridView2.SelectedCells.Item(0).Value.ToString())

            cmd = com.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from vLikviditetsbudget_Niveau_1_2 where Løbenr =" & i & " order by Bruger,Løbenr asc"
            cmd.ExecuteNonQuery()
            Dim dt1 As New DataTable()
            Dim da1 As New SqlDataAdapter(cmd)
            da1.Fill(dt1)
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
                Sbruttobeløb.Text = dr.GetString(27).ToString()
                K_beløb.Text = dr.GetString(28).ToString()
                Kbruttobeløb.Text = dr.GetString(29).ToString()

                cmd.ExecuteNonQuery()

            End While

        Catch ex As Exception

        End Try

    End Sub
    Public Sub disp_data()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Likviditetsbudget_Niveau_1_2 order by Dim01Value,Løbenr asc "
        cmd.ExecuteNonQuery()
        Dim dt2 As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt2)
        DataGridView2.DataSource = dt2

    End Sub
    Public Sub disp_data1()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from vLikviditetsbudget_Niveau_1_2 order by Dim01Value,Løbenr asc "
        cmd.ExecuteNonQuery()
        Dim dt1 As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt1)
        DataGridView1.DataSource = dt1
    End Sub
    Public Sub disp_data3()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from vStedSaldo_Primo order by S1,Brugerasc "
        cmd.ExecuteNonQuery()
        Dim dt3 As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt3)
        DataGridView3.DataSource = dt3
    End Sub
    Private Sub Button18_Importer_csv_fileClick(sender As Object, e As EventArgs) Handles Button18.Click

        ImportCVS_filer.Show()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        Hovedmenu.Show()
    End Sub
    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Me.Close()
    End Sub
    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        GroupBox4.Show()
    End Sub
    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        GroupBox4.Hide()
    End Sub
    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        GroupBox6.Show()
    End Sub
    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        GroupBox6.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DatoVærdi.Text = Format(DateTimePicker1.Value, "yyyy-MM-dd")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Likviditetsbudget_Niveau_1_2 values
                                                                
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
        '" & Kbruttobeløb.Text & "')"
        cmd.ExecuteNonQuery()

        disp_data()

        MessageBox.Show("record Inserted Successsfully")

    End Sub
    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Likviditetsbudget_Niveau_1_2 values
                                                                
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
        '" & Kbruttobeløb.Text & "')"
        cmd.ExecuteNonQuery()

        disp_data()

        MessageBox.Show("record Inserted Successsfully")
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Likviditetsbudget_Niveau_1_2 values
                                                                
       ('" & ModpostDatoVærdi.Text & "',
        '" & BrugerGruppeTekst.Text & " ',
        '" & BrugerModpost.Text & "',
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
        ('" & BeløbVærdi.Text & "'*0),
        ('" & KommentarTekst.Text & "'),       
        ('" & Sbruttobeløb.Text & "'*0),
        ('" & K_beløb.Text & "'*-1),
        ('" & Kbruttobeløb.Text & "'*-1))"
        cmd.ExecuteNonQuery()

        disp_data()

        MessageBox.Show("record Inserted Successsfully")

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If com.State = ConnectionState.Open Then
            com.Close()
        End If
        com.Open()

        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = ("UPDATE Likviditetsbudget_Niveau_1_2 set
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
        S_Beløb = '" + BeløbVærdi.Text + "',  
        Kommentar = '" + KommentarTekst.Text + "',    
        S_bruttobeløb = '" + Sbruttobeløb.Text + "',
        K_beløb =  '" + K_beløb.Text + "',       
        K_bruttobeløb = '" + Kbruttobeløb.Text + "'
         where Løbenr= ") & i & ""

        cmd.ExecuteNonQuery()


        MessageBox.Show("record updated Successsfully")

    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        LikviditetsbudgetNiveau12BindingSource1.MoveFirst()
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        LøbenrVærdi.Text = " "
        DatoVærdi.Text = " "
        BrugerGruppeTekst.Text = " "
        BrugerTekst.Text = " "
        BrugerModpost.Text = " "
        VersionTekst.Text = " "
        Dim01Værdi.Text = " "
        Dim02Værdi.Text = " "
        Dim03Værdi.Text = " "
        Dim04Værdi.Text = " "
        Dim05Værdi.Text = " "
        Dim06Værdi.Text = " "
        Dim07Værdi.Text = " "
        Dim08Værdi.Text = " "
        Dim09Værdi.Text = " "
        Dim10Værdi.Text = " "
        BeløbVærdi.Text = " "
        KommentarTekst.Text = " "
        K_beløb.Text = " "
        Kbruttobeløb.Text = " "
        Sbruttobeløb.Text = " "
        MessageBox.Show("Indtastningform cleared Successsfully")
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim06Værdi.Text = Regkontonr.Text

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim01Værdi.Text = S1tekst.Text
    End Sub
    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim04Værdi.Text = DranstCombo.Text
    End Sub
    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Dim02Værdi.Text = G1ComboBox1.Text
    End Sub
    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Dim03Værdi.Text = G2ComboBox.Text

    End Sub
    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Dim07Værdi.Text = F1Combo.Text

    End Sub
    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        Dim08Værdi.Text = HovedfunktionComboBox.Text

    End Sub
    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click, Button67.Click
        BrugerTekst.Text = BrugerTekstComboBox.Text
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click, Button68.Click
        BrugerModpost.Text = BrugerModpostComboBox.Text
    End Sub
    Private Sub Button37_VersionClick(sender As Object, e As EventArgs) Handles Button37.Click, Button70.Click
        VersionTekst.Text = VersionComboBox.Text
    End Sub
    Private Sub Button38_VersionClick(sender As Object, e As EventArgs) Handles Button38.Click, Button69.Click
        BrugerGruppeTekst.Text = BrugerGruppeComboBox.Text
    End Sub
    Private Sub Button39_VersionClick(sender As Object, e As EventArgs) Handles Button39.Click
        Dim09Værdi.Text = HovedFormålComboBox.Text
    End Sub

    Private Sub Button6_Søg_stedClick(sender As Object, e As EventArgs) Handles Button6.Click, Button64.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Likviditetsbudget_Niveau_1_2 where   Dato = '" + DatoVærdi.Text + "' order by Løbenr"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView2.DataSource = dt
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from vLikviditetsbudget_Niveau_1 where  Dato = '" + DatoVærdi.Text + "'order by løbenr "
        cmd.ExecuteNonQuery()
        Dim dt2 As New DataTable()
        Dim da2 As New SqlDataAdapter(cmd)
        da.Fill(dt2)
        DataGridView1.DataSource = dt2
    End Sub
    Private Sub Button8_Søg_stedClick(sender As Object, e As EventArgs) Handles Button8.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Likviditetsbudget_Niveau_1_2 where  Version ='" + VersionTekst.Text + "' and Bruger = '" + BrugerTekst.Text + "' and Dim01Value = '" + Dim01Værdi.Text + "'  order by løbenr"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView2.DataSource = dt
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from vLikviditetsbudget_Niveau_1 where  Version = '" + VersionTekst.Text + "' and Bruger = '" + BrugerTekst.Text + "' and Dim01Value = '" + Dim01Værdi.Text + "'   order by løbenr"
        cmd.ExecuteNonQuery()
        Dim dt2 As New DataTable()
        Dim da2 As New SqlDataAdapter(cmd)
        da.Fill(dt2)
        DataGridView1.DataSource = dt2
    End Sub
    Private Sub Button15_Søg_brugerClick(sender As Object, e As EventArgs) Handles Button15.Click, Button60.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Likviditetsbudget_Niveau_1_2 where Version = '" + VersionTekst.Text + "' and Bruger = '" + BrugerTekst.Text + "' order by løbenr"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from vLikviditetsbudget_Niveau_1  where Version = '" + VersionTekst.Text + "' and Bruger = '" + BrugerTekst.Text + "'   order by løbenr"
        cmd.ExecuteNonQuery()
        Dim dt2 As New DataTable()
        Dim da2 As New SqlDataAdapter(cmd)
        da.Fill(dt2)
        DataGridView2.DataSource = dt2
    End Sub
    Private Sub Button16_Søg_brugerClick(sender As Object, e As EventArgs) Handles Button16.Click, Button63.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Likviditetsbudget_Niveau_1_2 where Version = '" + VersionTekst.Text + "' and Bruger = '" + BrugerTekst.Text + "'  order by løbenr"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from vLikviditetsbudget_Niveau_1  where Version = '" + VersionTekst.Text + "' and Bruger = '" + BrugerTekst.Text + "'  order by løbenr"
        cmd.ExecuteNonQuery()
        Dim dt2 As New DataTable()
        Dim da2 As New SqlDataAdapter(cmd)
        da.Fill(dt2)
        DataGridView2.DataSource = dt2
    End Sub
    Private Sub Button24_BrugerClick(sender As Object, e As EventArgs) Handles Button24.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Likviditetsbudget_Niveau_1_2 where Version =   '" + VersionTekst.Text + "' and Bruger = '" + BrugerTekst.Text + "' and  Løbenr = '" + LøbenrVærdi.Text + "' order by Løbenr"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView2.DataSource = dt
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from vLikviditetsbudget_Niveau_1 where  Version ='" + VersionTekst.Text + "' and Bruger = '" + BrugerTekst.Text + "' and  Løbenr = '" + LøbenrVærdi.Text + "' order by Løbenr"
        cmd.ExecuteNonQuery()
        Dim dt2 As New DataTable()
        Dim da2 As New SqlDataAdapter(cmd)
        da.Fill(dt2)
    End Sub
    Private Sub Button26_DranstClick(sender As Object, e As EventArgs) Handles Button26.Click, Button61.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Likviditetsbudget_Niveau_1_2 where  Version ='" + VersionTekst.Text + "' and Bruger = '" + BrugerTekst.Text + "' and  'Dim04Value = '" + Dim04Værdi.Text + "' order by Dim04Value"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from vLikviditetsbudget_Niveau_1 where Version = '" + VersionTekst.Text + "' and Bruger = '" + BrugerTekst.Text + "' and  'Dim04Value = '" + Dim04Værdi.Text + "' order by Dim04Value"
        cmd.ExecuteNonQuery()
        Dim dt2 As New DataTable()
        Dim da2 As New SqlDataAdapter(cmd)
        da.Fill(dt2)
    End Sub
    Private Sub Button29_RegkontoClick(sender As Object, e As EventArgs) Handles Button29.Click, Button58.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Likviditetsbudget_Niveau_1_2 where Version = '" + VersionTekst.Text + "' and Bruger = '" + BrugerTekst.Text + "' and Dim06Value = '" + Dim06Værdi.Text + "'  order by Dim06Value"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from vLikviditetsbudget_Niveau_1 where  Version = '" + VersionTekst.Text + "' and Bruger = '" + BrugerTekst.Text + "' and Dim06Value = '" + Dim06Værdi.Text + "'  order by Dim06Value"
        cmd.ExecuteNonQuery()
        Dim dt2 As New DataTable()
        Dim da2 As New SqlDataAdapter(cmd)
        da.Fill(dt2)
    End Sub
    Private Sub Button30_Dim_02Click(sender As Object, e As EventArgs) Handles Button30.Click, Button57.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Likviditetsbudget_Niveau_1_2 where Dim02Value = '" + Dim02Værdi.Text + "' and Bruger = '" + BrugerTekst.Text + "'  order by Dim02Value"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from vLikviditetsbudget_Niveau_1 where Dim02Value = '" + Dim02Værdi.Text + "' and Bruger = '" + BrugerTekst.Text + "'  order by Dim02Value"
        cmd.ExecuteNonQuery()
        Dim dt2 As New DataTable()
        Dim da2 As New SqlDataAdapter(cmd)
        da.Fill(dt2)
    End Sub
    Private Sub Button35_Dim03_Click(sender As Object, e As EventArgs) Handles Button35.Click, Button56.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Likviditetsbudget_Niveau_1_2 where Dim03Value = '" + Dim03Værdi.Text + "' and Bruger = '" + BrugerTekst.Text + "'  order by Dim03Value"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from vLikviditetsbudget_Niveau_1 where Dim03Value = '" + Dim03Værdi.Text + "' and Bruger = '" + BrugerTekst.Text + "'  order by Dim03Value"
        cmd.ExecuteNonQuery()
        Dim dt2 As New DataTable()
        Dim da2 As New SqlDataAdapter(cmd)
        da.Fill(dt2)
    End Sub

    Private Sub Button40_Dimo7_Dim03_Click(sender As Object, e As EventArgs) Handles Button40.Click, Button55.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Likviditetsbudget_Niveau_1_2 where Dim07Value = '" + Dim07Værdi.Text + "' and Bruger = '" + BrugerTekst.Text + "'  order by Dim07Value"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from vLikviditetsbudget_Niveau_1 where Dim07Value = '" + Dim07Værdi.Text + "' and Bruger = '" + BrugerTekst.Text + "'  order by Dim07Value"
        cmd.ExecuteNonQuery()
        Dim dt2 As New DataTable()
        Dim da2 As New SqlDataAdapter(cmd)
        da.Fill(dt2)
    End Sub
    Private Sub Button41_Dim08_Click(sender As Object, e As EventArgs) Handles Button41.Click, Button54.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Likviditetsbudget_Niveau_1_2 where Bruger = '" + BrugerTekst.Text + "' and Dim08Value = '" + Dim08Værdi.Text + "'  order by Dim08Value"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from vLikviditetsbudget_Niveau_1 where Bruger = '" + BrugerTekst.Text + "'  and Dim08Value = '" + Dim08Værdi.Text + "'  order by Dim08Value"
        cmd.ExecuteNonQuery()
        Dim dt2 As New DataTable()
        Dim da2 As New SqlDataAdapter(cmd)
        da.Fill(dt2)
    End Sub
    Private Sub Button42_Dim09_Dim07_Click(sender As Object, e As EventArgs) Handles Button42.Click, Button53.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Likviditetsbudget_Niveau_1_2 where Bruger = '" + BrugerTekst.Text + "' and Dim09Value = '" + Dim09Værdi.Text + "'  order by Dim09Value"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from vLikviditetsbudget_Niveau_1 where Bruger = '" + BrugerTekst.Text + "'  and Dim09Value = '" + Dim09Værdi.Text + "'  order by Dim09Value"
        cmd.ExecuteNonQuery()
        Dim dt2 As New DataTable()
        Dim da2 As New SqlDataAdapter(cmd)
        da.Fill(dt2)
    End Sub
    Private Sub GroupBox7_Enter(sender As Object, e As EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.Likviditetsbudget_Niveau_1_2TableAdapter.FillBy(Me.Inteiro_Financial_InsightDataSetLikviditet.Likviditetsbudget_Niveau_1_2, LøbenrVærdi.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStripButton1_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton1.Click
        Try
            Me.VStedSaldo_PrimoTableAdapter.FillBy(Me.Inteiro_Financial_InsightDataSet1_sted_saldo.vStedSaldo_Primo, Dim01Værdi.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStripButton2_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton2.Click
        Try
            Me.VHovedformålTableAdapter.FillBy(Me.Inteiro_Financial_InsightDataSet3Hovedformål.vHovedformål, Dim07ValueToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles FillByToolStrip1.ItemClicked

    End Sub

    Private Sub Dim07ValueToolStripLabel_Click(sender As Object, e As EventArgs) Handles Dim07ValueToolStripLabel.Click

    End Sub
End Class