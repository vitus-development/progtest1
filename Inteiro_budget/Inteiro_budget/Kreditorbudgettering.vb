Imports System.Data.SqlClient
Public Class Kreditorbudgettering
    Dim com As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer
    Dim i2 As Integer
    Dim i3 As Integer
    Dim x As String
    Dim y As String

    Private Sub Kreditordatoer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDatasetVkreditorprofildranst1.vKreditorprofilDranst' table. You can move, or remove it, as needed.
        Me.VKreditorprofilDranstTableAdapter1.Fill(Me.Inteiro_Financial_InsightDatasetVkreditorprofildranst1.vKreditorprofilDranst)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetBudgetKreditorprofil2.Budget_KreditorprofilDranstF1F2F3G1G2' table. You can move, or remove it, as needed.
        Me.Budget_KreditorprofilDranstF1F2F3G1G2TableAdapter1.Fill(Me.Inteiro_Financial_InsightDataSetBudgetKreditorprofil2.Budget_KreditorprofilDranstF1F2F3G1G2)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetvSetup_Betalings_dato.vSetup_Betalings_dato' table. You can move, or remove it, as needed.
        Me.VSetup_Betalings_datoTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetvSetup_Betalings_dato.vSetup_Betalings_dato)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetVSetupdato2.vSetupdato' table. You can move, or remove it, as needed.
        Me.VSetupdatoTableAdapter1.Fill(Me.Inteiro_Financial_InsightDataSetVSetupdato2.vSetupdato)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetVSetupdato.vSetupdato' table. You can move, or remove it, as needed.
        Me.VSetupdatoTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetVSetupdato.vSetupdato)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetvBudget_KreditorprofilDranstF1F2F3G1G2.vBudget_KreditorprofilDranstF1F2F3G1G2' table. You can move, or remove it, as needed.
        Me.VBudget_KreditorprofilDranstF1F2F3G1G2TableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetvBudget_KreditorprofilDranstF1F2F3G1G2.vBudget_KreditorprofilDranstF1F2F3G1G2)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetStaus.Status' table. You can move, or remove it, as needed.
        Me.StatusTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetStaus.Status)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetBudgetKreditorprofil1.Budget_KreditorprofilDranstF1F2F3G1G2' table. You can move, or remove it, as needed.
        Me.Budget_KreditorprofilDranstF1F2F3G1G2TableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetBudgetKreditorprofil1.Budget_KreditorprofilDranstF1F2F3G1G2)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetvVersion.vVersion' table. You can move, or remove it, as needed.
        Me.VVersionTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetvVersion.vVersion)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetFordelingtype.Fordelingstype' table. You can move, or remove it, as needed.
        Me.FordelingstypeTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetFordelingtype.Fordelingstype)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetvBruger.vBruger' table. You can move, or remove it, as needed.
        Me.VBrugerTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetvBruger.vBruger)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetBudgetKreditorprofil.Budget_KreditorprofilDranstF1F2F3G1G2' table. You can move, or remove it, as needed.
        Me.Budget_KreditorprofilDranstF1F2F3G1G2TableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetBudgetKreditorprofil.Budget_KreditorprofilDranstF1F2F3G1G2)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetDranstF1F2F3G1G2.vKreditorprofilDranstF1F2F3G1G2' table. You can move, or remove it, as needed.
        Me.VKreditorprofilDranstF1F2F3G1G2TableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetDranstF1F2F3G1G2.vKreditorprofilDranstF1F2F3G1G2)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetvKreditorprofilDranstF1F2F3G1.vKreditorprofilDranstF1F2F3G1' table. You can move, or remove it, as needed.
        Me.VKreditorprofilDranstF1F2F3G1TableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetvKreditorprofilDranstF1F2F3G1.vKreditorprofilDranstF1F2F3G1)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetvKreditorprofilDranstF1F2F3.vKreditorprofilDranstF1F2F3' table. You can move, or remove it, as needed.
        Me.VKreditorprofilDranstF1F2F3TableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetvKreditorprofilDranstF1F2F3.vKreditorprofilDranstF1F2F3)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetVKreditorProfilDranstF1F2.vKreditorprofilDranstF1F2' table. You can move, or remove it, as needed.
        Me.VKreditorprofilDranstF1F2TableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetVKreditorProfilDranstF1F2.vKreditorprofilDranstF1F2)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetvKreditorpofildranstF1.vKreditorprofilDranstF1' table. You can move, or remove it, as needed.
        Me.VKreditorprofilDranstF1TableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetvKreditorpofildranstF1.vKreditorprofilDranstF1)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDatasetVkreditorprofildranst.vKreditorprofilDranst' table. You can move, or remove it, as needed.
        Me.VKreditorprofilDranstTableAdapter.Fill(Me.Inteiro_Financial_InsightDatasetVkreditorprofildranst.vKreditorprofilDranst)
        'TODO: This line of code loads data into the 'Inteiro_Financial_InsightDataSetvbetalingsprofilerKreditorer.vBetalingsprofil_kreditorer' table. You can move, or remove it, as needed.
        Me.VBetalingsprofil_kreditorerTableAdapter.Fill(Me.Inteiro_Financial_InsightDataSetvbetalingsprofilerKreditorer.vBetalingsprofil_kreditorer)

        com.ConnectionString = "Data Source=VBJXPS2017;Initial Catalog=Inteiro Financial Insight;Integrated Security=True"

        If com.State = ConnectionState.Open Then
            com.Close()
        End If
        com.Open()
    End Sub
    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click

    End Sub

    Public Sub disp_data()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Budget_KreditorprofilDranstF1F2F3G1G2  "
        cmd.ExecuteNonQuery()
        Dim dt1 As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt1)
        DataGridView1.DataSource = dt1

    End Sub
    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & DatoVærdi.Text & " ',
          '" & Udbetalingsdato.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_01.Text & "',
           '" & FordeltKorrektionsBeløb_01.Text & "',
            '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()

        MessageBox.Show("record Inserted Successsfully")
        disp_data()

    End Sub
    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & DatoVærdi.Text & " ',
          '" & Udbetalingsdato.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_01.Text & "',
           '" & FordeltKorrektionsBeløb_01.Text & "',
              '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()

        disp_data()
        MessageBox.Show("record Inserted Successsfully 1")
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per02.Text & "',
          '" & Udbetalingsdato_per02.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_02.Text & "',
           '" & FordeltKorrektionsBeløb_02.Text & "',
             '" & Kommentar.Text & "',
           '" & Status.Text & "')"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 2")
        disp_data()

    End Sub
    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & DatoVærdi.Text & " ',
          '" & Udbetalingsdato.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_01.Text & "',
           '" & FordeltKorrektionsBeløb_01.Text & "',
            '" & Kommentar.Text & "')"
        cmd.ExecuteNonQuery()

        disp_data()
        MessageBox.Show("record Inserted Successsfully 1")
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per02.Text & "',
          '" & Udbetalingsdato_per02.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_02.Text & "',
           '" & FordeltKorrektionsBeløb_02.Text & "',
             '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 2")
        disp_data()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per03.Text & "',
          '" & Udbetalingsdato_per03.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_03.Text & "',
           '" & FordeltKorrektionsBeløb_03.Text & "',
           '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 3")
        disp_data()

    End Sub
    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & DatoVærdi.Text & " ',
          '" & Udbetalingsdato.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_01.Text & "',
           '" & FordeltKorrektionsBeløb_01.Text & "',
             '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()

        MessageBox.Show("record Inserted Successsfully 1")
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per02.Text & "',
          '" & Udbetalingsdato_per02.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_02.Text & "',
           '" & FordeltKorrektionsBeløb_02.Text & "',
           '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 2")
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per03.Text & "',
          '" & Udbetalingsdato_per03.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_03.Text & "',
           '" & FordeltKorrektionsBeløb_03.Text & "',
             '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 3")
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per04.Text & "',
          '" & Udbetalingsdato_per04.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_04.Text & "',
           '" & FordeltKorrektionsBeløb_04.Text & "',
         '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 4")
        disp_data()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Udbetalingsdato.Text = Format(DateTimePicker1.Value, "yyyy-MM-dd")

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Udbetalingsdato_per02.Text = Format(DateTimePicker2.Value, "yyyy-MM-dd")

    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Udbetalingsdato_per03.Text = Format(DateTimePicker3.Value, "yyyy-MM-dd")

    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Udbetalingsdato_per04.Text = Format(DateTimePicker7.Value, "yyyy-MM-dd")

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Udbetalingsdato_per05.Text = Format(DateTimePicker5.Value, "yyyy-MM-dd")

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Udbetalingsdato_per06.Text = Format(DateTimePicker6.Value, "yyyy-MM-dd")

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Udbetalingsdato_per07.Text = Format(DateTimePicker4.Value, "yyyy-MM-dd")

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Udbetalingsdato_per08.Text = Format(DateTimePicker8.Value, "yyyy-MM-dd")
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Udbetalingsdato_per09.Text = Format(DateTimePicker9.Value, "yyyy-MM-dd")

    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Udbetalingsdato_per10.Text = Format(DateTimePicker10.Value, "yyyy-MM-dd")

    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Udbetalingsdato_per11.Text = Format(DateTimePicker11.Value, "yyyy-MM-dd")

    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Udbetalingsdato_per12.Text = Format(DateTimePicker12.Value, "yyyy-MM-dd")

    End Sub
    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        DatoVærdi.Text = Format(DateTimePicker13.Value, "yyyy-MM-dd")

    End Sub
    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Dato_per02.Text = Format(DateTimePicker15.Value, "yyyy-MM-dd")

    End Sub
    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        Dato_per03.Text = Format(DateTimePicker24.Value, "yyyy-MM-dd")

    End Sub
    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Dato_per04.Text = Format(DateTimePicker23.Value, "yyyy-MM-dd")


    End Sub
    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Dato_per05.Text = Format(DateTimePicker22.Value, "yyyy-MM-dd")


    End Sub
    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        Dato_per06.Text = Format(DateTimePicker20.Value, "yyyy-MM-dd")


    End Sub
    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Dato_per07.Text = Format(DateTimePicker19.Value, "yyyy-MM-dd")


    End Sub
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dato_per08.Text = Format(DateTimePicker17.Value, "yyyy-MM-dd")


    End Sub
    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Dato_per09.Text = Format(DateTimePicker21.Value, "yyyy-MM-dd")


    End Sub
    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Dato_per10.Text = Format(DateTimePicker18.Value, "yyyy-MM-dd")


    End Sub
    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Dato_per11.Text = Format(DateTimePicker16.Value, "yyyy-MM-dd")


    End Sub
    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dato_per12.Text = Format(DateTimePicker14.Value, "yyyy-MM-dd")


    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim04Value.Text = DranstComboBox.Text



    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim07Value.Text = F1ComboBox.Text

    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim08Value.Text = F2ComboBox.Text

    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim09Value.Text = F3ComboBox.Text

    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim02Value.Text = G1ComboBox.Text

    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim03Value.Text = G2ComboBox2.Text


    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

        Budgetbeløb.Text = ForbrugComboBox.Text

    End Sub
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

        Dim Tot, Tot1, Gtot As Double
        Tot = Double.Parse(Budgetbeløb.Text)
        Tot1 = Double.Parse(K_beløb.Text)
        Gtot = Tot + Tot1
        Budget_01.Text = Gtot
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        BrugerTekst.Text = BrugerComboBox.Text

    End Sub
    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Likviditetsbruger.Text = BrugerComboBox.Text

    End Sub
    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        Version.Text = VersionComboBox.Text

    End Sub
    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        Fordelingstype.Text = FordelingstypeComboBox.Text

        AntalPerioder.Text = FordelingsantalComboBox.Text

    End Sub
    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click


    End Sub
    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        FordeltBudgetbeløb.Text = (Budgetbeløb.Text / AntalPerioder.Text)
        FordeltBudgetbeløb_01.Text = (Budgetbeløb.Text / AntalPerioder.Text)
        FordeltBudgetbeløb_02.Text = (Budgetbeløb.Text / AntalPerioder.Text)
        FordeltBudgetbeløb_03.Text = (Budgetbeløb.Text / AntalPerioder.Text)
        FordeltBudgetbeløb_04.Text = (Budgetbeløb.Text / AntalPerioder.Text)
        FordeltBudgetbeløb_05.Text = (Budgetbeløb.Text / AntalPerioder.Text)
        FordeltBudgetbeløb_06.Text = (Budgetbeløb.Text / AntalPerioder.Text)
        FordeltBudgetbeløb_07.Text = (Budgetbeløb.Text / AntalPerioder.Text)
        FordeltBudgetbeløb_08.Text = (Budgetbeløb.Text / AntalPerioder.Text)
        FordeltBudgetbeløb_09.Text = (Budgetbeløb.Text / AntalPerioder.Text)
        FordeltBudgetbeløb_10.Text = (Budgetbeløb.Text / AntalPerioder.Text)
        FordeltBudgetbeløb_11.Text = (Budgetbeløb.Text / AntalPerioder.Text)
        FordeltBudgetbeløb_12.Text = (Budgetbeløb.Text / AntalPerioder.Text)
    End Sub
    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        FordeltKorrektionsBeløb.Text = (K_beløb.Text / AntalPerioder.Text)
        FordeltKorrektionsBeløb_01.Text = (K_beløb.Text / AntalPerioder.Text)
        FordeltKorrektionsBeløb_02.Text = (K_beløb.Text / AntalPerioder.Text)
        FordeltKorrektionsBeløb_03.Text = (K_beløb.Text / AntalPerioder.Text)
        FordeltKorrektionsBeløb_04.Text = (K_beløb.Text / AntalPerioder.Text)
        FordeltKorrektionsBeløb_05.Text = (K_beløb.Text / AntalPerioder.Text)
        FordeltKorrektionsBeløb_06.Text = (K_beløb.Text / AntalPerioder.Text)
        FordeltKorrektionsBeløb_07.Text = (K_beløb.Text / AntalPerioder.Text)
        FordeltKorrektionsBeløb_08.Text = (K_beløb.Text / AntalPerioder.Text)
        FordeltKorrektionsBeløb_09.Text = (K_beløb.Text / AntalPerioder.Text)
        FordeltKorrektionsBeløb_10.Text = (K_beløb.Text / AntalPerioder.Text)
        FordeltKorrektionsBeløb_11.Text = (K_beløb.Text / AntalPerioder.Text)
        FordeltKorrektionsBeløb_12.Text = (K_beløb.Text / AntalPerioder.Text)
    End Sub

    Private Sub Dim08Value_TextChanged(sender As Object, e As EventArgs) Handles Dim08Value.TextChanged

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub Udbetalingsdato_TextChanged(sender As Object, e As EventArgs) Handles Udbetalingsdato.TextChanged

    End Sub

    Private Sub DateTimePicker15_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker15.ValueChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub
    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & DatoVærdi.Text & " ',
          '" & Udbetalingsdato.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_01.Text & "',
           '" & FordeltKorrektionsBeløb_01.Text & "',
         '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()

        MessageBox.Show("record Inserted Successsfully 1")
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per02.Text & "',
          '" & Udbetalingsdato_per02.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_02.Text & "',
           '" & FordeltKorrektionsBeløb_02.Text & "',
           '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 2")
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per03.Text & "',
          '" & Udbetalingsdato_per03.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_03.Text & "',
           '" & FordeltKorrektionsBeløb_03.Text & "',
          '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 3")
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per04.Text & "',
          '" & Udbetalingsdato_per04.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_04.Text & "',
           '" & FordeltKorrektionsBeløb_04.Text & "',
           '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 4")
        disp_data()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per05.Text & "',
          '" & Udbetalingsdato_per05.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_05.Text & "',
           '" & FordeltKorrektionsBeløb_05.Text & "',
           '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 5")
        disp_data()


    End Sub
    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & DatoVærdi.Text & " ',
          '" & Udbetalingsdato.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_01.Text & "',
           '" & FordeltKorrektionsBeløb_01.Text & "',
             '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()

        MessageBox.Show("record Inserted Successsfully 1")
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per02.Text & "',
          '" & Udbetalingsdato_per02.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_02.Text & "',
           '" & FordeltKorrektionsBeløb_02.Text & "',
         '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 2")
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per03.Text & "',
          '" & Udbetalingsdato_per03.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_03.Text & "',
           '" & FordeltKorrektionsBeløb_03.Text & "',
            '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 3")
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per04.Text & "',
          '" & Udbetalingsdato_per04.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_04.Text & "',
           '" & FordeltKorrektionsBeløb_04.Text & "',
        '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 4")
        disp_data()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per05.Text & "',
          '" & Udbetalingsdato_per05.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_05.Text & "',
           '" & FordeltKorrektionsBeløb_05.Text & "',
             '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 5")
        disp_data()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per06.Text & "',
          '" & Udbetalingsdato_per06.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_06.Text & "',
           '" & FordeltKorrektionsBeløb_06.Text & "',
            '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 6")
        disp_data()

    End Sub
    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & DatoVærdi.Text & " ',
          '" & Udbetalingsdato.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_01.Text & "',
           '" & FordeltKorrektionsBeløb_01.Text & "',
         '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()

        MessageBox.Show("record Inserted Successsfully 1")
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per02.Text & "',
          '" & Udbetalingsdato_per02.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_02.Text & "',
           '" & FordeltKorrektionsBeløb_02.Text & "',
          '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 2")
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per03.Text & "',
          '" & Udbetalingsdato_per03.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_03.Text & "',
           '" & FordeltKorrektionsBeløb_03.Text & "',
           '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 3")
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per04.Text & "',
          '" & Udbetalingsdato_per04.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_04.Text & "',
           '" & FordeltKorrektionsBeløb_04.Text & "',
          '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 4")
        disp_data()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per05.Text & "',
          '" & Udbetalingsdato_per05.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_05.Text & "',
           '" & FordeltKorrektionsBeløb_05.Text & "',
          '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 5")
        disp_data()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per06.Text & "',
          '" & Udbetalingsdato_per06.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_06.Text & "',
           '" & FordeltKorrektionsBeløb_06.Text & "',
           '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 6")
        disp_data()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per07.Text & "',
          '" & Udbetalingsdato_per07.Text & "',    
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_07.Text & "',
           '" & FordeltKorrektionsBeløb_07.Text & "',
           '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()

        MessageBox.Show("record Inserted Successsfully 7")
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per08.Text & "',
          '" & Udbetalingsdato_per08.Text & "',    
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_08.Text & "',
           '" & FordeltKorrektionsBeløb_08.Text & "',
            '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 8")
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
        '" & Dato_per09.Text & "',
          '" & Udbetalingsdato_per09.Text & "',    
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_09.Text & "',
           '" & FordeltKorrektionsBeløb_09.Text & "',
       '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 9")
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per10.Text & "',
          '" & Udbetalingsdato_per10.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_10.Text & "',
           '" & FordeltKorrektionsBeløb_10.Text & "',
           '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 10")
        disp_data()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
         '" & Dato_per11.Text & "',
          '" & Udbetalingsdato_per11.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_11.Text & "',
           '" & FordeltKorrektionsBeløb_11.Text & "',
      '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 11")
        disp_data()
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Insert into Budget_KreditorprofilDranstF1F2F3G1G2 values
            ( '" & Dim04Value.Text & "', 
           '" & BrugerTekst.Text & "',
           '" & Likviditetsbruger.Text & "',
          '" & Version.Text & "',
          '" & Dato_per12.Text & "',
          '" & Udbetalingsdato_per12.Text & "',       
          '" & Dim07Value.Text & "', 
          '" & Dim08Value.Text & "', 
          '" & Dim09Value.Text & "', 
          '" & Dim02Value.Text & "', 
          '" & Dim03Value.Text & "', 
          '" & Beløb.Text & "' ,
           '" & FordeltBudgetbeløb_12.Text & "',
           '" & FordeltKorrektionsBeløb_12.Text & "',
        '" & Kommentar.Text & "',
           '" & Status.Text & "' )"
        cmd.ExecuteNonQuery()
        MessageBox.Show("record Inserted Successsfully 12")
        disp_data()
    End Sub
    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click


    End Sub
    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click

        Dim04ValueRapport.Text = DranstComboBox.Text
        Dim07ValueRapport.Text = F1ComboBox.Text
        Dim08ValueRapport1.Text = F2ComboBox.Text
        Dim09ValueRapport1.Text = F3ComboBox.Text
        Dim02ValueRapport1.Text = G1ComboBox.Text
        Dim03ValueRapport1.Text = G2ComboBox2.Text





    End Sub

    Private Sub Status_TextChanged(sender As Object, e As EventArgs) Handles StatusOutput.TextChanged

    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        Status.Text = StatusCombobox.Text
        StatusOutput.Text = StatusCombobox.Text
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Budget_KreditorprofilDranstF1F2F3G1G2 where Dim04Value like '" + Dim04ValueRapport.Text + "' and 
        F1 like '" + Dim07ValueRapport.Text + "' and 
        F2 like '" + Dim08ValueRapport1.Text + "' and
        F3 like '" + Dim09ValueRapport1.Text + "' and
        G1 like '" + Dim02ValueRapport1.Text + "' and 
        G2 like '" + Dim03ValueRapport1.Text + "' and 
        Status like '" + StatusOutput.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt1 As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt1)
        DataGridView1.DataSource = dt1
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT  [Dim04Value]
      ,[Bruger]
      ,[Likviditetsbruger]
      ,[F1]
      ,[F2]
      ,[F3]
      ,[G1]
      ,[G2]
      ,[Status]
      ,[S_Forbrug_tidl_år]
      ,[S_budgetbeløb]
  FROM [Inteiro Financial Insight].[dbo].[vBudget_KreditorprofilDranstF1F2F3G1G2] 
     where Dim04Value like '" + Dim04ValueRapport.Text + "' and 
        F1 like '" + Dim07ValueRapport.Text + "' and 
        F2 like '" + Dim08ValueRapport1.Text + "' and
        F3 like '" + Dim09ValueRapport1.Text + "' and
        G1 like '" + Dim02ValueRapport1.Text + "' and 
       G2 like '" + Dim03ValueRapport1.Text + "' and 
        Status like '" + StatusOutput.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt2 As New DataTable()
        Dim da1 As New SqlDataAdapter(cmd)
        da.Fill(dt2)
        DataGridView2.DataSource = dt2
    End Sub


    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        BudgetKreditorprofilDranstF1F2F3G1G2BindingSource1.MoveNext()
    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        BudgetKreditorprofilDranstF1F2F3G1G2BindingSource1.MoveFirst()

    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        BudgetKreditorprofilDranstF1F2F3G1G2BindingSource1.MovePrevious()
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        BudgetKreditorprofilDranstF1F2F3G1G2BindingSource1.MoveLast()

    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        DatoVærdi.Text = DatoComboBox.Text
        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from vSetupdato  where 
        Dato = '" + DatoVærdi.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt3 As New DataTable()
        Dim da3 As New SqlDataAdapter(cmd)
        da3.Fill(dt3)
        DataGridView3.DataSource = dt3

    End Sub

    Private Sub TabIndtastning_Click(sender As Object, e As EventArgs) Handles TabIndtastning.Click

    End Sub

    Private Sub Button60_Click(sender As Object, e As EventArgs) Handles Button60.Click
        Udbetalingsdato.Text = UdbetalingsdatoComboBox.Text

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
            cmd.CommandText = "select * from  Budget_KreditorprofilDranstF1F2F3G1G2  where Løbenr =" & i & "order by Løbenr asc "
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While dr.Read()

                Dim04ValueOutput.Text = dr.GetString(1).ToString()
                BrugerOutput.Text = dr.GetString(2).ToString()
                LikviditetsBrugerOutput.Text = dr.GetString(3).ToString()
                Output_version.Text = dr.GetSqlString(4).ToString()
                Postdato.Text = dr.GetString(5).ToString()
                UdbetalingsdatoOutput.Text = dr.GetString(6).ToString()
                HovedkontoOutput.Text = dr.GetString(7).ToString()
                HovedfunktionOutput.Text = dr.GetString(8).ToString()
                F3.Text = dr.GetString(9).ToString()
                G1.Text = dr.GetString(10).ToString()
                G2.Text = dr.GetString(11).ToString()
                BeløbOutput.Text = dr.GetString(12).ToString()
                BudgetbeløbOutput.Text = dr.GetString(13).ToString()
                K_beløbOutput.Text = dr.GetString(14).ToString()
                Kommentar_output.Text = dr.GetString(15).ToString()
                Status.Text = dr.GetString(16).ToString()
                cmd.ExecuteNonQuery()

            End While

        Catch ex As Exception

        End Try

    End Sub
    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        If com.State = ConnectionState.Open Then
            com.Close()
        End If
        com.Open()

        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = ("UPDATE Budget_KreditorprofilDranstF1F2F3G1G2 set
        Status = '" + Status.Text + "'  ,  
        Version = ' " + Output_version.Text + "', 
        Bruger = '" + BrugerOutput.Text + "',
         Likviditetsbruger = '" + LikviditetsBrugerOutput.Text + "',
         Dim04Value = '" + Dim04ValueOutput.Text + "', 
         Dato = '" + Postdato.Text + "',
         Udbetalingsdato = '" + Udbetalingsdato.Text + "',
         [Forbrug tidl år] = '" + BeløbOutput.Text + "',
         Budgetbeløb = '" + BudgetbeløbOutput.Text + "',
         Korrektion = '" + K_beløbOutput.Text + "',
         Kommentar = '" + Kommentar_output.Text + "',
        F1 = '" + HovedkontoOutput.Text + "', 
         F2 = '" + HovedfunktionOutput.Text + "',
         F3 = '" + F3.Text + "', 
         G1 = '" + G1.Text + "', 
         G2 = '" + G2.Text + "'        
         where Løbenr= ") & i & ""
        cmd.ExecuteNonQuery()


        MessageBox.Show("record updated Successsfully")

    End Sub

    Private Sub OverskriftNavn_TextChanged(sender As Object, e As EventArgs) Handles OverskriftNavn.TextChanged

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy1ToolStripButton.Click
        Try
            Me.VKreditorprofilDranstTableAdapter1.FillBy1(Me.Inteiro_Financial_InsightDatasetVkreditorprofildranst1.vKreditorprofilDranst)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FordeltKorrektionsBeløb_11_TextChanged(sender As Object, e As EventArgs) Handles FordeltKorrektionsBeløb_11.TextChanged

    End Sub

    Private Sub F3_TextChanged(sender As Object, e As EventArgs) Handles F3.TextChanged

    End Sub

    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Button61.Click

    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click

    End Sub
End Class