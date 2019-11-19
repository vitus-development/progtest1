<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Brugere
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
        Me.ForNavn = New System.Windows.Forms.Label()
        Me.EfterNavn = New System.Windows.Forms.Label()
        Me.FødselsDato = New System.Windows.Forms.Label()
        Me.KoenLabel = New System.Windows.Forms.Label()
        Me.FornavnTekst = New System.Windows.Forms.TextBox()
        Me.EfterNavnTekst = New System.Windows.Forms.TextBox()
        Me.FødselsdatoText = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BrugerDataSet1 = New Walk.BrugerDataSet1()
        Me.BrugerDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrugerDataTableAdapter = New Walk.BrugerDataSet1TableAdapters.BrugerDataTableAdapter()
        Me.PkBrugerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FornavnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EfternavnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FødselsdagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrugerDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrugerDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ForNavn
        '
        Me.ForNavn.AutoSize = True
        Me.ForNavn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForNavn.Location = New System.Drawing.Point(13, 22)
        Me.ForNavn.Name = "ForNavn"
        Me.ForNavn.Size = New System.Drawing.Size(57, 16)
        Me.ForNavn.TabIndex = 0
        Me.ForNavn.Text = "Fornavn"
        '
        'EfterNavn
        '
        Me.EfterNavn.AutoSize = True
        Me.EfterNavn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EfterNavn.Location = New System.Drawing.Point(13, 55)
        Me.EfterNavn.Name = "EfterNavn"
        Me.EfterNavn.Size = New System.Drawing.Size(64, 16)
        Me.EfterNavn.TabIndex = 1
        Me.EfterNavn.Text = "Efternavn"
        '
        'FødselsDato
        '
        Me.FødselsDato.AutoSize = True
        Me.FødselsDato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FødselsDato.Location = New System.Drawing.Point(13, 96)
        Me.FødselsDato.Name = "FødselsDato"
        Me.FødselsDato.Size = New System.Drawing.Size(84, 16)
        Me.FødselsDato.TabIndex = 2
        Me.FødselsDato.Text = "Fødselsdato"
        '
        'KoenLabel
        '
        Me.KoenLabel.AutoSize = True
        Me.KoenLabel.Location = New System.Drawing.Point(13, 126)
        Me.KoenLabel.Name = "KoenLabel"
        Me.KoenLabel.Size = New System.Drawing.Size(26, 13)
        Me.KoenLabel.TabIndex = 3
        Me.KoenLabel.Text = "Køn"
        '
        'FornavnTekst
        '
        Me.FornavnTekst.Location = New System.Drawing.Point(148, 19)
        Me.FornavnTekst.Name = "FornavnTekst"
        Me.FornavnTekst.Size = New System.Drawing.Size(121, 20)
        Me.FornavnTekst.TabIndex = 4
        '
        'EfterNavnTekst
        '
        Me.EfterNavnTekst.Location = New System.Drawing.Point(148, 55)
        Me.EfterNavnTekst.Name = "EfterNavnTekst"
        Me.EfterNavnTekst.Size = New System.Drawing.Size(121, 20)
        Me.EfterNavnTekst.TabIndex = 5
        '
        'FødselsdatoText
        '
        Me.FødselsdatoText.Location = New System.Drawing.Point(148, 89)
        Me.FødselsdatoText.Name = "FødselsdatoText"
        Me.FødselsdatoText.Size = New System.Drawing.Size(100, 20)
        Me.FødselsdatoText.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(148, 119)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(121, 20)
        Me.TextBox4.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.ForNavn)
        Me.GroupBox1.Controls.Add(Me.KoenLabel)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.FødselsDato)
        Me.GroupBox1.Controls.Add(Me.FornavnTekst)
        Me.GroupBox1.Controls.Add(Me.EfterNavn)
        Me.GroupBox1.Controls.Add(Me.FødselsdatoText)
        Me.GroupBox1.Controls.Add(Me.EfterNavnTekst)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox1.Location = New System.Drawing.Point(21, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 152)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Brugger indtastning"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(148, 89)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker2.TabIndex = 10
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.SteelBlue
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox5.Location = New System.Drawing.Point(21, 52)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(200, 46)
        Me.TextBox5.TabIndex = 9
        Me.TextBox5.Text = "Bruger oprettelse"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PkBrugerIDDataGridViewTextBoxColumn, Me.FornavnDataGridViewTextBoxColumn, Me.EfternavnDataGridViewTextBoxColumn, Me.FødselsdagDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BrugerDataBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(21, 294)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(476, 150)
        Me.DataGridView1.TabIndex = 10
        '
        'BrugerDataSet1
        '
        Me.BrugerDataSet1.DataSetName = "BrugerDataSet1"
        Me.BrugerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BrugerDataBindingSource
        '
        Me.BrugerDataBindingSource.DataMember = "BrugerData"
        Me.BrugerDataBindingSource.DataSource = Me.BrugerDataSet1
        '
        'BrugerDataTableAdapter
        '
        Me.BrugerDataTableAdapter.ClearBeforeFill = True
        '
        'PkBrugerIDDataGridViewTextBoxColumn
        '
        Me.PkBrugerIDDataGridViewTextBoxColumn.DataPropertyName = "Pk_Bruger_ID"
        Me.PkBrugerIDDataGridViewTextBoxColumn.HeaderText = "Pk_Bruger_ID"
        Me.PkBrugerIDDataGridViewTextBoxColumn.Name = "PkBrugerIDDataGridViewTextBoxColumn"
        Me.PkBrugerIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FornavnDataGridViewTextBoxColumn
        '
        Me.FornavnDataGridViewTextBoxColumn.DataPropertyName = "Fornavn"
        Me.FornavnDataGridViewTextBoxColumn.HeaderText = "Fornavn"
        Me.FornavnDataGridViewTextBoxColumn.Name = "FornavnDataGridViewTextBoxColumn"
        '
        'EfternavnDataGridViewTextBoxColumn
        '
        Me.EfternavnDataGridViewTextBoxColumn.DataPropertyName = "Efternavn"
        Me.EfternavnDataGridViewTextBoxColumn.HeaderText = "Efternavn"
        Me.EfternavnDataGridViewTextBoxColumn.Name = "EfternavnDataGridViewTextBoxColumn"
        '
        'FødselsdagDataGridViewTextBoxColumn
        '
        Me.FødselsdagDataGridViewTextBoxColumn.DataPropertyName = "Fødselsdag"
        Me.FødselsdagDataGridViewTextBoxColumn.HeaderText = "Fødselsdag"
        Me.FødselsdagDataGridViewTextBoxColumn.Name = "FødselsdagDataGridViewTextBoxColumn"
        '
        'Brugere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Brugere"
        Me.Text = "Brugere"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrugerDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrugerDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ForNavn As Label
    Friend WithEvents EfterNavn As Label
    Friend WithEvents FødselsDato As Label
    Friend WithEvents KoenLabel As Label
    Friend WithEvents FornavnTekst As TextBox
    Friend WithEvents EfterNavnTekst As TextBox
    Friend WithEvents FødselsdatoText As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BrugerDataSet1 As BrugerDataSet1
    Friend WithEvents BrugerDataBindingSource As BindingSource
    Friend WithEvents BrugerDataTableAdapter As BrugerDataSet1TableAdapters.BrugerDataTableAdapter
    Friend WithEvents PkBrugerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FornavnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EfternavnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FødselsdagDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
