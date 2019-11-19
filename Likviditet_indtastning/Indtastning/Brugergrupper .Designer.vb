<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OprettelseafBrugerGrupper
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
        Me.BrugerGruppeLabel1 = New System.Windows.Forms.Label()
        Me.BrugerGruppe = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.KommentarLabel = New System.Windows.Forms.Label()
        Me.KommentarTekst = New System.Windows.Forms.TextBox()
        Me.DatoVærdi = New System.Windows.Forms.TextBox()
        Me.DatoLabel3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LøbenrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrugerGruppeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KommentarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrugergruppeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrugergruppeDataSet1 = New Indtastning.BrugergruppeDataSet1()
        Me.BrugergruppeTableAdapter = New Indtastning.BrugergruppeDataSet1TableAdapters.BrugergruppeTableAdapter()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrugergruppeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrugergruppeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BrugerGruppeLabel1
        '
        Me.BrugerGruppeLabel1.AutoSize = True
        Me.BrugerGruppeLabel1.Location = New System.Drawing.Point(18, 102)
        Me.BrugerGruppeLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BrugerGruppeLabel1.Name = "BrugerGruppeLabel1"
        Me.BrugerGruppeLabel1.Size = New System.Drawing.Size(71, 13)
        Me.BrugerGruppeLabel1.TabIndex = 3
        Me.BrugerGruppeLabel1.Text = "Brugergruppe"
        '
        'BrugerGruppe
        '
        Me.BrugerGruppe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BrugergruppeBindingSource, "BrugerGruppe", True))
        Me.BrugerGruppe.Location = New System.Drawing.Point(118, 95)
        Me.BrugerGruppe.Margin = New System.Windows.Forms.Padding(4)
        Me.BrugerGruppe.Name = "BrugerGruppe"
        Me.BrugerGruppe.Size = New System.Drawing.Size(133, 20)
        Me.BrugerGruppe.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Location = New System.Drawing.Point(19, 31)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 48)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Opret bruger "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.Location = New System.Drawing.Point(133, 30)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 49)
        Me.Button4.TabIndex = 56
        Me.Button4.Text = "Opdater bruger "
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.Location = New System.Drawing.Point(241, 30)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 49)
        Me.Button5.TabIndex = 57
        Me.Button5.Text = "Slette data"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox2.Location = New System.Drawing.Point(88, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 86)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Indlæsnings funktioner"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Controls.Add(Me.KommentarLabel)
        Me.GroupBox1.Controls.Add(Me.KommentarTekst)
        Me.GroupBox1.Controls.Add(Me.DatoVærdi)
        Me.GroupBox1.Controls.Add(Me.DatoLabel3)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BrugerGruppeLabel1)
        Me.GroupBox1.Controls.Add(Me.BrugerGruppe)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(18, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(665, 184)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opret bruger"
        '
        'KommentarLabel
        '
        Me.KommentarLabel.AutoSize = True
        Me.KommentarLabel.Location = New System.Drawing.Point(18, 136)
        Me.KommentarLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.KommentarLabel.Name = "KommentarLabel"
        Me.KommentarLabel.Size = New System.Drawing.Size(60, 13)
        Me.KommentarLabel.TabIndex = 37
        Me.KommentarLabel.Text = "Kommentar"
        '
        'KommentarTekst
        '
        Me.KommentarTekst.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BrugergruppeBindingSource, "Kommentar", True))
        Me.KommentarTekst.Location = New System.Drawing.Point(118, 136)
        Me.KommentarTekst.Margin = New System.Windows.Forms.Padding(4)
        Me.KommentarTekst.Name = "KommentarTekst"
        Me.KommentarTekst.Size = New System.Drawing.Size(492, 20)
        Me.KommentarTekst.TabIndex = 36
        '
        'DatoVærdi
        '
        Me.DatoVærdi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BrugergruppeBindingSource, "Dato", True))
        Me.DatoVærdi.Location = New System.Drawing.Point(118, 61)
        Me.DatoVærdi.Margin = New System.Windows.Forms.Padding(4)
        Me.DatoVærdi.Name = "DatoVærdi"
        Me.DatoVærdi.Size = New System.Drawing.Size(133, 20)
        Me.DatoVærdi.TabIndex = 35
        '
        'DatoLabel3
        '
        Me.DatoLabel3.AutoSize = True
        Me.DatoLabel3.Location = New System.Drawing.Point(18, 68)
        Me.DatoLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DatoLabel3.Name = "DatoLabel3"
        Me.DatoLabel3.Size = New System.Drawing.Size(30, 13)
        Me.DatoLabel3.TabIndex = 34
        Me.DatoLabel3.Text = "Dato"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(118, 22)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(160, 20)
        Me.DateTimePicker1.TabIndex = 33
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(10, 20)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Vælg dato"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LøbenrDataGridViewTextBoxColumn, Me.DatoDataGridViewTextBoxColumn, Me.BrugerGruppeDataGridViewTextBoxColumn, Me.KommentarDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BrugergruppeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(18, 353)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(665, 150)
        Me.DataGridView1.TabIndex = 60
        '
        'LøbenrDataGridViewTextBoxColumn
        '
        Me.LøbenrDataGridViewTextBoxColumn.DataPropertyName = "Løbenr"
        Me.LøbenrDataGridViewTextBoxColumn.HeaderText = "Løbenr"
        Me.LøbenrDataGridViewTextBoxColumn.Name = "LøbenrDataGridViewTextBoxColumn"
        Me.LøbenrDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatoDataGridViewTextBoxColumn
        '
        Me.DatoDataGridViewTextBoxColumn.DataPropertyName = "Dato"
        Me.DatoDataGridViewTextBoxColumn.HeaderText = "Dato"
        Me.DatoDataGridViewTextBoxColumn.Name = "DatoDataGridViewTextBoxColumn"
        '
        'BrugerGruppeDataGridViewTextBoxColumn
        '
        Me.BrugerGruppeDataGridViewTextBoxColumn.DataPropertyName = "BrugerGruppe"
        Me.BrugerGruppeDataGridViewTextBoxColumn.HeaderText = "BrugerGruppe"
        Me.BrugerGruppeDataGridViewTextBoxColumn.Name = "BrugerGruppeDataGridViewTextBoxColumn"
        '
        'KommentarDataGridViewTextBoxColumn
        '
        Me.KommentarDataGridViewTextBoxColumn.DataPropertyName = "Kommentar"
        Me.KommentarDataGridViewTextBoxColumn.HeaderText = "Kommentar"
        Me.KommentarDataGridViewTextBoxColumn.Name = "KommentarDataGridViewTextBoxColumn"
        '
        'BrugergruppeBindingSource
        '
        Me.BrugergruppeBindingSource.DataMember = "Brugergruppe"
        Me.BrugergruppeBindingSource.DataSource = Me.BrugergruppeDataSet1
        '
        'BrugergruppeDataSet1
        '
        Me.BrugergruppeDataSet1.DataSetName = "BrugergruppeDataSet1"
        Me.BrugergruppeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BrugergruppeTableAdapter
        '
        Me.BrugergruppeTableAdapter.ClearBeforeFill = True
        '
        'OprettelseafBrugerGrupper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 536)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "OprettelseafBrugerGrupper"
        Me.Text = "Oprettelse af brugergrupper "
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrugergruppeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrugergruppeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BrugerGruppeLabel1 As Label
    Friend WithEvents BrugerGruppe As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DatoVærdi As TextBox
    Friend WithEvents DatoLabel3 As Label
    Friend WithEvents KommentarTekst As TextBox
    Friend WithEvents KommentarLabel As Label
    Friend WithEvents BrugergruppeDataSet1 As BrugergruppeDataSet1
    Friend WithEvents BrugergruppeBindingSource As BindingSource
    Friend WithEvents BrugergruppeTableAdapter As BrugergruppeDataSet1TableAdapters.BrugergruppeTableAdapter
    Friend WithEvents LøbenrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrugerGruppeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KommentarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
