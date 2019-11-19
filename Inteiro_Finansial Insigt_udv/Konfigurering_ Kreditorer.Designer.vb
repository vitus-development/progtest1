<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Konfigurering__Kreditorer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OverskriftNavn = New System.Windows.Forms.TextBox()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LøbenrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfilIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrugerGruppeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KreditornrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KreditornavnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VersionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldobruttoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopantalkreditorerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inteiro_Financial_InsightDataSetAntalKreditoer = New Inteiro_Finansial_Insigt_udv.Inteiro_Financial_InsightDataSet3()
        Me.Top_antal_kreditorerTableAdapter = New Inteiro_Finansial_Insigt_udv.Inteiro_Financial_InsightDataSet3TableAdapters.Top_antal_kreditorerTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KonfigurationantalkreditorerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inteiro_Financial_InsightDataSetKonfiguration_antal_kreditorer = New Inteiro_Finansial_Insigt_udv.Inteiro_Financial_InsightDataSetKonfiguration_antal_kreditorer()
        Me.Konfiguration_antal_kreditorerTableAdapter = New Inteiro_Finansial_Insigt_udv.Inteiro_Financial_InsightDataSetKonfiguration_antal_kreditorerTableAdapters.Konfiguration_antal_kreditorerTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProfilIdLabel = New System.Windows.Forms.Label()
        Me.BruttosaldoLabel = New System.Windows.Forms.Label()
        Me.Saldo = New System.Windows.Forms.TextBox()
        Me.SaldoLabel = New System.Windows.Forms.Label()
        Me.ProfilID = New System.Windows.Forms.TextBox()
        Me.Saldobrutto = New System.Windows.Forms.TextBox()
        Me.KreditornavnLabel = New System.Windows.Forms.Label()
        Me.Kreditornavn = New System.Windows.Forms.TextBox()
        Me.Kreditornr = New System.Windows.Forms.TextBox()
        Me.BrugerGruppeTekst = New System.Windows.Forms.TextBox()
        Me.KreditornrLabel = New System.Windows.Forms.Label()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.BrugerGruppeLabel1 = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.TextBox()
        Me.LøbenrLabel = New System.Windows.Forms.Label()
        Me.LøbenrVærdi = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Saldooutput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProfilIDOutput = New System.Windows.Forms.TextBox()
        Me.SaldobruttoOutput = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.KreditornavnOutput = New System.Windows.Forms.TextBox()
        Me.KreditornrOutput = New System.Windows.Forms.TextBox()
        Me.BrugerGruppeOutput = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.VersionOutput = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Løbenr = New System.Windows.Forms.TextBox()
        Me.StørsteKreditoer = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopantalkreditorerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inteiro_Financial_InsightDataSetAntalKreditoer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KonfigurationantalkreditorerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inteiro_Financial_InsightDataSetKonfiguration_antal_kreditorer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.StørsteKreditoer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Button15)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button16)
        Me.Panel1.Controls.Add(Me.Button17)
        Me.Panel1.Controls.Add(Me.Button18)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.OverskriftNavn)
        Me.Panel1.Controls.Add(Me.Button20)
        Me.Panel1.Location = New System.Drawing.Point(2, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 426)
        Me.Panel1.TabIndex = 93
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button15.Location = New System.Drawing.Point(14, 260)
        Me.Button15.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(173, 29)
        Me.Button15.TabIndex = 74
        Me.Button15.Text = "Gå til Dataloads"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(16, 92)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 29)
        Me.Button1.TabIndex = 97
        Me.Button1.Text = "Indsæt indtastning"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button16.Location = New System.Drawing.Point(16, 210)
        Me.Button16.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(173, 29)
        Me.Button16.TabIndex = 72
        Me.Button16.Text = "Gå til Administrationsmenu"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button17.Location = New System.Drawing.Point(16, 167)
        Me.Button17.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(173, 28)
        Me.Button17.TabIndex = 73
        Me.Button17.Text = "Vis Rapport"
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button18.Location = New System.Drawing.Point(14, 313)
        Me.Button18.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(173, 29)
        Me.Button18.TabIndex = 71
        Me.Button18.Text = "Gå til Dashboard"
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(14, 128)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 29)
        Me.Button2.TabIndex = 70
        Me.Button2.Text = "Slet indtastning "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'OverskriftNavn
        '
        Me.OverskriftNavn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OverskriftNavn.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.OverskriftNavn.Location = New System.Drawing.Point(14, 24)
        Me.OverskriftNavn.Multiline = True
        Me.OverskriftNavn.Name = "OverskriftNavn"
        Me.OverskriftNavn.Size = New System.Drawing.Size(173, 59)
        Me.OverskriftNavn.TabIndex = 69
        Me.OverskriftNavn.Text = "Konfiguration af Kreditorer"
        Me.OverskriftNavn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button20.Location = New System.Drawing.Point(14, 363)
        Me.Button20.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(173, 49)
        Me.Button20.TabIndex = 64
        Me.Button20.Text = "Luk Indtastningsmenu"
        Me.Button20.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LøbenrDataGridViewTextBoxColumn, Me.ProfilIDDataGridViewTextBoxColumn, Me.BrugerGruppeDataGridViewTextBoxColumn, Me.KreditornrDataGridViewTextBoxColumn, Me.KreditornavnDataGridViewTextBoxColumn, Me.VersionDataGridViewTextBoxColumn, Me.SaldoDataGridViewTextBoxColumn, Me.SaldobruttoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TopantalkreditorerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(260, 188)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1075, 160)
        Me.DataGridView1.TabIndex = 94
        '
        'LøbenrDataGridViewTextBoxColumn
        '
        Me.LøbenrDataGridViewTextBoxColumn.DataPropertyName = "Løbenr"
        Me.LøbenrDataGridViewTextBoxColumn.HeaderText = "Løbenr"
        Me.LøbenrDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LøbenrDataGridViewTextBoxColumn.Name = "LøbenrDataGridViewTextBoxColumn"
        Me.LøbenrDataGridViewTextBoxColumn.ReadOnly = True
        Me.LøbenrDataGridViewTextBoxColumn.Width = 125
        '
        'ProfilIDDataGridViewTextBoxColumn
        '
        Me.ProfilIDDataGridViewTextBoxColumn.DataPropertyName = "Profil_ID"
        Me.ProfilIDDataGridViewTextBoxColumn.HeaderText = "Profil_ID"
        Me.ProfilIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProfilIDDataGridViewTextBoxColumn.Name = "ProfilIDDataGridViewTextBoxColumn"
        Me.ProfilIDDataGridViewTextBoxColumn.Width = 125
        '
        'BrugerGruppeDataGridViewTextBoxColumn
        '
        Me.BrugerGruppeDataGridViewTextBoxColumn.DataPropertyName = "BrugerGruppe"
        Me.BrugerGruppeDataGridViewTextBoxColumn.HeaderText = "BrugerGruppe"
        Me.BrugerGruppeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BrugerGruppeDataGridViewTextBoxColumn.Name = "BrugerGruppeDataGridViewTextBoxColumn"
        Me.BrugerGruppeDataGridViewTextBoxColumn.Width = 125
        '
        'KreditornrDataGridViewTextBoxColumn
        '
        Me.KreditornrDataGridViewTextBoxColumn.DataPropertyName = "Kreditornr"
        Me.KreditornrDataGridViewTextBoxColumn.HeaderText = "Kreditornr"
        Me.KreditornrDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KreditornrDataGridViewTextBoxColumn.Name = "KreditornrDataGridViewTextBoxColumn"
        Me.KreditornrDataGridViewTextBoxColumn.Width = 125
        '
        'KreditornavnDataGridViewTextBoxColumn
        '
        Me.KreditornavnDataGridViewTextBoxColumn.DataPropertyName = "Kreditornavn"
        Me.KreditornavnDataGridViewTextBoxColumn.HeaderText = "Kreditornavn"
        Me.KreditornavnDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KreditornavnDataGridViewTextBoxColumn.Name = "KreditornavnDataGridViewTextBoxColumn"
        Me.KreditornavnDataGridViewTextBoxColumn.Width = 125
        '
        'VersionDataGridViewTextBoxColumn
        '
        Me.VersionDataGridViewTextBoxColumn.DataPropertyName = "Version"
        Me.VersionDataGridViewTextBoxColumn.HeaderText = "Version"
        Me.VersionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.VersionDataGridViewTextBoxColumn.Name = "VersionDataGridViewTextBoxColumn"
        Me.VersionDataGridViewTextBoxColumn.Width = 125
        '
        'SaldoDataGridViewTextBoxColumn
        '
        Me.SaldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.HeaderText = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SaldoDataGridViewTextBoxColumn.Name = "SaldoDataGridViewTextBoxColumn"
        Me.SaldoDataGridViewTextBoxColumn.Width = 125
        '
        'SaldobruttoDataGridViewTextBoxColumn
        '
        Me.SaldobruttoDataGridViewTextBoxColumn.DataPropertyName = "Saldobrutto"
        Me.SaldobruttoDataGridViewTextBoxColumn.HeaderText = "Saldobrutto"
        Me.SaldobruttoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SaldobruttoDataGridViewTextBoxColumn.Name = "SaldobruttoDataGridViewTextBoxColumn"
        Me.SaldobruttoDataGridViewTextBoxColumn.Width = 125
        '
        'TopantalkreditorerBindingSource
        '
        Me.TopantalkreditorerBindingSource.DataMember = "Top_antal_kreditorer"
        Me.TopantalkreditorerBindingSource.DataSource = Me.Inteiro_Financial_InsightDataSetAntalKreditoer
        '
        'Inteiro_Financial_InsightDataSetAntalKreditoer
        '
        Me.Inteiro_Financial_InsightDataSetAntalKreditoer.DataSetName = "Inteiro_Financial_InsightDataSetAntalKreditoer"
        Me.Inteiro_Financial_InsightDataSetAntalKreditoer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Top_antal_kreditorerTableAdapter
        '
        Me.Top_antal_kreditorerTableAdapter.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DataGridView2.DataSource = Me.KonfigurationantalkreditorerBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(260, 613)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.Size = New System.Drawing.Size(1075, 163)
        Me.DataGridView2.TabIndex = 95
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Løbenr"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Løbenr"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Profil_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Profil_ID"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BrugerGruppe"
        Me.DataGridViewTextBoxColumn3.HeaderText = "BrugerGruppe"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Kreditornr"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Kreditornr"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Kreditornavn"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Kreditornavn"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Version"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Version"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Saldo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Saldo"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Saldobrutto"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Saldobrutto"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'KonfigurationantalkreditorerBindingSource
        '
        Me.KonfigurationantalkreditorerBindingSource.DataMember = "Konfiguration_antal_kreditorer"
        Me.KonfigurationantalkreditorerBindingSource.DataSource = Me.Inteiro_Financial_InsightDataSetKonfiguration_antal_kreditorer
        '
        'Inteiro_Financial_InsightDataSetKonfiguration_antal_kreditorer
        '
        Me.Inteiro_Financial_InsightDataSetKonfiguration_antal_kreditorer.DataSetName = "Inteiro_Financial_InsightDataSetKonfiguration_antal_kreditorer"
        Me.Inteiro_Financial_InsightDataSetKonfiguration_antal_kreditorer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Konfiguration_antal_kreditorerTableAdapter
        '
        Me.Konfiguration_antal_kreditorerTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Controls.Add(Me.ProfilIdLabel)
        Me.GroupBox1.Controls.Add(Me.BruttosaldoLabel)
        Me.GroupBox1.Controls.Add(Me.Saldo)
        Me.GroupBox1.Controls.Add(Me.SaldoLabel)
        Me.GroupBox1.Controls.Add(Me.ProfilID)
        Me.GroupBox1.Controls.Add(Me.Saldobrutto)
        Me.GroupBox1.Controls.Add(Me.KreditornavnLabel)
        Me.GroupBox1.Controls.Add(Me.Kreditornavn)
        Me.GroupBox1.Controls.Add(Me.Kreditornr)
        Me.GroupBox1.Controls.Add(Me.BrugerGruppeTekst)
        Me.GroupBox1.Controls.Add(Me.KreditornrLabel)
        Me.GroupBox1.Controls.Add(Me.VersionLabel)
        Me.GroupBox1.Controls.Add(Me.BrugerGruppeLabel1)
        Me.GroupBox1.Controls.Add(Me.Version)
        Me.GroupBox1.Controls.Add(Me.LøbenrLabel)
        Me.GroupBox1.Controls.Add(Me.LøbenrVærdi)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(260, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1075, 100)
        Me.GroupBox1.TabIndex = 96
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'ProfilIdLabel
        '
        Me.ProfilIdLabel.AutoSize = True
        Me.ProfilIdLabel.Location = New System.Drawing.Point(138, 28)
        Me.ProfilIdLabel.Name = "ProfilIdLabel"
        Me.ProfilIdLabel.Size = New System.Drawing.Size(39, 13)
        Me.ProfilIdLabel.TabIndex = 107
        Me.ProfilIdLabel.Text = "ProfilId"
        '
        'BruttosaldoLabel
        '
        Me.BruttosaldoLabel.AutoSize = True
        Me.BruttosaldoLabel.Location = New System.Drawing.Point(836, 28)
        Me.BruttosaldoLabel.Name = "BruttosaldoLabel"
        Me.BruttosaldoLabel.Size = New System.Drawing.Size(60, 13)
        Me.BruttosaldoLabel.TabIndex = 107
        Me.BruttosaldoLabel.Text = "Bruttosaldo"
        '
        'Saldo
        '
        Me.Saldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TopantalkreditorerBindingSource, "Saldo", True))
        Me.Saldo.Location = New System.Drawing.Point(730, 44)
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Size = New System.Drawing.Size(100, 20)
        Me.Saldo.TabIndex = 104
        '
        'SaldoLabel
        '
        Me.SaldoLabel.AutoSize = True
        Me.SaldoLabel.Location = New System.Drawing.Point(727, 28)
        Me.SaldoLabel.Name = "SaldoLabel"
        Me.SaldoLabel.Size = New System.Drawing.Size(34, 13)
        Me.SaldoLabel.TabIndex = 106
        Me.SaldoLabel.Text = "Saldo"
        '
        'ProfilID
        '
        Me.ProfilID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TopantalkreditorerBindingSource, "Profil_ID", True))
        Me.ProfilID.Location = New System.Drawing.Point(141, 44)
        Me.ProfilID.Name = "ProfilID"
        Me.ProfilID.Size = New System.Drawing.Size(100, 20)
        Me.ProfilID.TabIndex = 103
        '
        'Saldobrutto
        '
        Me.Saldobrutto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TopantalkreditorerBindingSource, "Saldobrutto", True))
        Me.Saldobrutto.Location = New System.Drawing.Point(836, 44)
        Me.Saldobrutto.Name = "Saldobrutto"
        Me.Saldobrutto.Size = New System.Drawing.Size(100, 20)
        Me.Saldobrutto.TabIndex = 105
        '
        'KreditornavnLabel
        '
        Me.KreditornavnLabel.AutoSize = True
        Me.KreditornavnLabel.Location = New System.Drawing.Point(614, 28)
        Me.KreditornavnLabel.Name = "KreditornavnLabel"
        Me.KreditornavnLabel.Size = New System.Drawing.Size(67, 13)
        Me.KreditornavnLabel.TabIndex = 103
        Me.KreditornavnLabel.Text = "Kreditornavn"
        '
        'Kreditornavn
        '
        Me.Kreditornavn.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TopantalkreditorerBindingSource, "Kreditornavn", True))
        Me.Kreditornavn.Location = New System.Drawing.Point(617, 44)
        Me.Kreditornavn.Name = "Kreditornavn"
        Me.Kreditornavn.Size = New System.Drawing.Size(100, 20)
        Me.Kreditornavn.TabIndex = 102
        '
        'Kreditornr
        '
        Me.Kreditornr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TopantalkreditorerBindingSource, "Kreditornr", True))
        Me.Kreditornr.Location = New System.Drawing.Point(506, 44)
        Me.Kreditornr.Name = "Kreditornr"
        Me.Kreditornr.Size = New System.Drawing.Size(100, 20)
        Me.Kreditornr.TabIndex = 100
        '
        'BrugerGruppeTekst
        '
        Me.BrugerGruppeTekst.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TopantalkreditorerBindingSource, "BrugerGruppe", True))
        Me.BrugerGruppeTekst.Location = New System.Drawing.Point(248, 44)
        Me.BrugerGruppeTekst.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BrugerGruppeTekst.Name = "BrugerGruppeTekst"
        Me.BrugerGruppeTekst.Size = New System.Drawing.Size(133, 20)
        Me.BrugerGruppeTekst.TabIndex = 98
        '
        'KreditornrLabel
        '
        Me.KreditornrLabel.AutoSize = True
        Me.KreditornrLabel.Location = New System.Drawing.Point(503, 28)
        Me.KreditornrLabel.Name = "KreditornrLabel"
        Me.KreditornrLabel.Size = New System.Drawing.Size(52, 13)
        Me.KreditornrLabel.TabIndex = 101
        Me.KreditornrLabel.Text = "Kreditornr"
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Location = New System.Drawing.Point(388, 28)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(42, 13)
        Me.VersionLabel.TabIndex = 99
        Me.VersionLabel.Text = "Version"
        '
        'BrugerGruppeLabel1
        '
        Me.BrugerGruppeLabel1.AutoSize = True
        Me.BrugerGruppeLabel1.Location = New System.Drawing.Point(251, 26)
        Me.BrugerGruppeLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BrugerGruppeLabel1.Name = "BrugerGruppeLabel1"
        Me.BrugerGruppeLabel1.Size = New System.Drawing.Size(71, 13)
        Me.BrugerGruppeLabel1.TabIndex = 97
        Me.BrugerGruppeLabel1.Text = "Brugergruppe"
        '
        'Version
        '
        Me.Version.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TopantalkreditorerBindingSource, "Version", True))
        Me.Version.Location = New System.Drawing.Point(391, 44)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(100, 20)
        Me.Version.TabIndex = 98
        '
        'LøbenrLabel
        '
        Me.LøbenrLabel.AutoSize = True
        Me.LøbenrLabel.Location = New System.Drawing.Point(32, 28)
        Me.LøbenrLabel.Name = "LøbenrLabel"
        Me.LøbenrLabel.Size = New System.Drawing.Size(40, 13)
        Me.LøbenrLabel.TabIndex = 97
        Me.LøbenrLabel.Text = "Løbenr"
        '
        'LøbenrVærdi
        '
        Me.LøbenrVærdi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TopantalkreditorerBindingSource, "Løbenr", True))
        Me.LøbenrVærdi.Location = New System.Drawing.Point(35, 44)
        Me.LøbenrVærdi.Name = "LøbenrVærdi"
        Me.LøbenrVærdi.Size = New System.Drawing.Size(100, 20)
        Me.LøbenrVærdi.TabIndex = 93
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSlateGray
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Saldooutput)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.ProfilIDOutput)
        Me.GroupBox2.Controls.Add(Me.SaldobruttoOutput)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.KreditornavnOutput)
        Me.GroupBox2.Controls.Add(Me.KreditornrOutput)
        Me.GroupBox2.Controls.Add(Me.BrugerGruppeOutput)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.VersionOutput)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Løbenr)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(260, 486)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1075, 100)
        Me.GroupBox2.TabIndex = 97
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "ProfilId"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(836, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Bruttosaldo"
        '
        'Saldooutput
        '
        Me.Saldooutput.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurationantalkreditorerBindingSource, "Saldo", True))
        Me.Saldooutput.Location = New System.Drawing.Point(730, 44)
        Me.Saldooutput.Name = "Saldooutput"
        Me.Saldooutput.Size = New System.Drawing.Size(100, 20)
        Me.Saldooutput.TabIndex = 104
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(727, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Saldo"
        '
        'ProfilIDOutput
        '
        Me.ProfilIDOutput.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurationantalkreditorerBindingSource, "Profil_ID", True))
        Me.ProfilIDOutput.Location = New System.Drawing.Point(141, 44)
        Me.ProfilIDOutput.Name = "ProfilIDOutput"
        Me.ProfilIDOutput.Size = New System.Drawing.Size(100, 20)
        Me.ProfilIDOutput.TabIndex = 103
        '
        'SaldobruttoOutput
        '
        Me.SaldobruttoOutput.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurationantalkreditorerBindingSource, "Saldobrutto", True))
        Me.SaldobruttoOutput.Location = New System.Drawing.Point(836, 44)
        Me.SaldobruttoOutput.Name = "SaldobruttoOutput"
        Me.SaldobruttoOutput.Size = New System.Drawing.Size(100, 20)
        Me.SaldobruttoOutput.TabIndex = 105
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(614, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Kreditornavn"
        '
        'KreditornavnOutput
        '
        Me.KreditornavnOutput.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurationantalkreditorerBindingSource, "Kreditornavn", True))
        Me.KreditornavnOutput.Location = New System.Drawing.Point(617, 44)
        Me.KreditornavnOutput.Name = "KreditornavnOutput"
        Me.KreditornavnOutput.Size = New System.Drawing.Size(100, 20)
        Me.KreditornavnOutput.TabIndex = 102
        '
        'KreditornrOutput
        '
        Me.KreditornrOutput.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurationantalkreditorerBindingSource, "Kreditornr", True))
        Me.KreditornrOutput.Location = New System.Drawing.Point(506, 44)
        Me.KreditornrOutput.Name = "KreditornrOutput"
        Me.KreditornrOutput.Size = New System.Drawing.Size(100, 20)
        Me.KreditornrOutput.TabIndex = 100
        '
        'BrugerGruppeOutput
        '
        Me.BrugerGruppeOutput.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurationantalkreditorerBindingSource, "BrugerGruppe", True))
        Me.BrugerGruppeOutput.Location = New System.Drawing.Point(248, 44)
        Me.BrugerGruppeOutput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BrugerGruppeOutput.Name = "BrugerGruppeOutput"
        Me.BrugerGruppeOutput.Size = New System.Drawing.Size(133, 20)
        Me.BrugerGruppeOutput.TabIndex = 98
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(503, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Kreditornr"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(388, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "Version"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(251, 26)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Brugergruppe"
        '
        'VersionOutput
        '
        Me.VersionOutput.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurationantalkreditorerBindingSource, "Version", True))
        Me.VersionOutput.Location = New System.Drawing.Point(391, 44)
        Me.VersionOutput.Name = "VersionOutput"
        Me.VersionOutput.Size = New System.Drawing.Size(100, 20)
        Me.VersionOutput.TabIndex = 98
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "Løbenr"
        '
        'Løbenr
        '
        Me.Løbenr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurationantalkreditorerBindingSource, "Løbenr", True))
        Me.Løbenr.Location = New System.Drawing.Point(35, 44)
        Me.Løbenr.Name = "Løbenr"
        Me.Løbenr.Size = New System.Drawing.Size(100, 20)
        Me.Løbenr.TabIndex = 93
        '
        'StørsteKreditoer
        '
        Me.StørsteKreditoer.BackColor = System.Drawing.SystemColors.Window
        ChartArea1.Name = "ChartArea1"
        Me.StørsteKreditoer.ChartAreas.Add(ChartArea1)
        Me.StørsteKreditoer.DataSource = Me.KonfigurationantalkreditorerBindingSource
        Legend1.Name = "Legend1"
        Me.StørsteKreditoer.Legends.Add(Legend1)
        Me.StørsteKreditoer.Location = New System.Drawing.Point(260, 364)
        Me.StørsteKreditoer.Name = "StørsteKreditoer"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Største kreditorer"
        Series1.XValueMember = "Kreditornavn"
        Series1.YValueMembers = "Saldo"
        Me.StørsteKreditoer.Series.Add(Series1)
        Me.StørsteKreditoer.Size = New System.Drawing.Size(1075, 116)
        Me.StørsteKreditoer.TabIndex = 98
        Me.StørsteKreditoer.Text = "Chart1"
        '
        'Konfigurering__Kreditorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1443, 838)
        Me.Controls.Add(Me.StørsteKreditoer)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Konfigurering__Kreditorer"
        Me.Text = "Konfigurering__Kreditorer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopantalkreditorerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inteiro_Financial_InsightDataSetAntalKreditoer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KonfigurationantalkreditorerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inteiro_Financial_InsightDataSetKonfiguration_antal_kreditorer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.StørsteKreditoer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button15 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents OverskriftNavn As TextBox
    Friend WithEvents Button20 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Inteiro_Financial_InsightDataSetAntalKreditoer As Inteiro_Financial_InsightDataSet3
    Friend WithEvents TopantalkreditorerBindingSource As BindingSource
    Friend WithEvents Top_antal_kreditorerTableAdapter As Inteiro_Financial_InsightDataSet3TableAdapters.Top_antal_kreditorerTableAdapter
    Friend WithEvents LøbenrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProfilIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrugerGruppeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KreditornrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KreditornavnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VersionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaldobruttoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Inteiro_Financial_InsightDataSetKonfiguration_antal_kreditorer As Inteiro_Financial_InsightDataSetKonfiguration_antal_kreditorer
    Friend WithEvents KonfigurationantalkreditorerBindingSource As BindingSource
    Friend WithEvents Konfiguration_antal_kreditorerTableAdapter As Inteiro_Financial_InsightDataSetKonfiguration_antal_kreditorerTableAdapters.Konfiguration_antal_kreditorerTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LøbenrVærdi As TextBox
    Friend WithEvents LøbenrLabel As Label
    Friend WithEvents VersionLabel As Label
    Friend WithEvents Version As TextBox
    Friend WithEvents BrugerGruppeTekst As TextBox
    Friend WithEvents BrugerGruppeLabel1 As Label
    Friend WithEvents KreditornrLabel As Label
    Friend WithEvents Kreditornr As TextBox
    Friend WithEvents Saldo As TextBox
    Friend WithEvents KreditornavnLabel As Label
    Friend WithEvents Kreditornavn As TextBox
    Friend WithEvents ProfilID As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Saldobrutto As TextBox
    Friend WithEvents SaldoLabel As Label
    Friend WithEvents BruttosaldoLabel As Label
    Friend WithEvents ProfilIdLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Saldooutput As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ProfilIDOutput As TextBox
    Friend WithEvents SaldobruttoOutput As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents KreditornavnOutput As TextBox
    Friend WithEvents KreditornrOutput As TextBox
    Friend WithEvents BrugerGruppeOutput As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents VersionOutput As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Løbenr As TextBox
    Friend WithEvents StørsteKreditoer As DataVisualization.Charting.Chart
End Class
