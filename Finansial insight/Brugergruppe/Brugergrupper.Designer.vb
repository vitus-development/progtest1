<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BrugerGrupper
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.LøbenrVærdi = New System.Windows.Forms.TextBox()
        Me.BrugergruppeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrugergruppeDataSet = New Brugergruppe.BrugergruppeDataSet()
        Me.LøbenrLabel = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.KommentarLabel = New System.Windows.Forms.Label()
        Me.KommentarTekst = New System.Windows.Forms.TextBox()
        Me.DatoVærdi = New System.Windows.Forms.TextBox()
        Me.DatoLabel3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BrugerGruppeLabel1 = New System.Windows.Forms.Label()
        Me.BrugerGruppeTekst = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LøbenrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrugerGruppeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KommentarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BrugergruppeTableAdapter = New Brugergruppe.BrugergruppeDataSetTableAdapters.BrugergruppeTableAdapter()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BrugergruppeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrugergruppeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.LøbenrVærdi)
        Me.GroupBox1.Controls.Add(Me.LøbenrLabel)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.KommentarLabel)
        Me.GroupBox1.Controls.Add(Me.KommentarTekst)
        Me.GroupBox1.Controls.Add(Me.DatoVærdi)
        Me.GroupBox1.Controls.Add(Me.DatoLabel3)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BrugerGruppeLabel1)
        Me.GroupBox1.Controls.Add(Me.BrugerGruppeTekst)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 297)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(665, 184)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opret brugergruppe"
        '
        'Button9
        '
        Me.Button9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button9.Location = New System.Drawing.Point(545, 22)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(73, 47)
        Me.Button9.TabIndex = 43
        Me.Button9.Text = "Sidste  indtastning "
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button8.Location = New System.Drawing.Point(464, 22)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(73, 47)
        Me.Button8.TabIndex = 42
        Me.Button8.Text = "Første indtastning"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'LøbenrVærdi
        '
        Me.LøbenrVærdi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BrugergruppeBindingSource, "Løbenr", True))
        Me.LøbenrVærdi.Location = New System.Drawing.Point(301, 39)
        Me.LøbenrVærdi.Margin = New System.Windows.Forms.Padding(4)
        Me.LøbenrVærdi.Name = "LøbenrVærdi"
        Me.LøbenrVærdi.Size = New System.Drawing.Size(56, 20)
        Me.LøbenrVærdi.TabIndex = 41
        Me.LøbenrVærdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BrugergruppeBindingSource
        '
        Me.BrugergruppeBindingSource.DataMember = "Brugergruppe"
        Me.BrugergruppeBindingSource.DataSource = Me.BrugergruppeDataSet
        '
        'BrugergruppeDataSet
        '
        Me.BrugergruppeDataSet.DataSetName = "BrugergruppeDataSet"
        Me.BrugergruppeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LøbenrLabel
        '
        Me.LøbenrLabel.AutoSize = True
        Me.LøbenrLabel.Location = New System.Drawing.Point(298, 22)
        Me.LøbenrLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LøbenrLabel.Name = "LøbenrLabel"
        Me.LøbenrLabel.Size = New System.Drawing.Size(62, 13)
        Me.LøbenrLabel.TabIndex = 40
        Me.LøbenrLabel.Text = "Viser løbenr"
        '
        'Button7
        '
        Me.Button7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button7.Location = New System.Drawing.Point(545, 81)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(73, 47)
        Me.Button7.TabIndex = 39
        Me.Button7.Text = "Næste indtastning "
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button6.Location = New System.Drawing.Point(464, 81)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(73, 47)
        Me.Button6.TabIndex = 38
        Me.Button6.Text = "Forrige intastning"
        Me.Button6.UseVisualStyleBackColor = True
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
        Me.KommentarTekst.Size = New System.Drawing.Size(511, 20)
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
        'BrugerGruppeTekst
        '
        Me.BrugerGruppeTekst.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BrugergruppeBindingSource, "BrugerGruppe", True))
        Me.BrugerGruppeTekst.Location = New System.Drawing.Point(118, 95)
        Me.BrugerGruppeTekst.Margin = New System.Windows.Forms.Padding(4)
        Me.BrugerGruppeTekst.Name = "BrugerGruppeTekst"
        Me.BrugerGruppeTekst.Size = New System.Drawing.Size(133, 20)
        Me.BrugerGruppeTekst.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox2.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(537, 86)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Indlæsnings funktioner"
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Location = New System.Drawing.Point(19, 31)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 48)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Opret brugergruppe "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.Location = New System.Drawing.Point(368, 31)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(127, 49)
        Me.Button5.TabIndex = 57
        Me.Button5.Text = "Slet brugergruppe"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.Location = New System.Drawing.Point(178, 31)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 48)
        Me.Button4.TabIndex = 56
        Me.Button4.Text = "Opdater brugergruppe "
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LøbenrDataGridViewTextBoxColumn, Me.DatoDataGridViewTextBoxColumn, Me.BrugerGruppeDataGridViewTextBoxColumn, Me.KommentarDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BrugergruppeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 540)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(665, 150)
        Me.DataGridView1.TabIndex = 62
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
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SteelBlue
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.Location = New System.Drawing.Point(601, 83)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 49)
        Me.Button3.TabIndex = 63
        Me.Button3.Text = "Luk blanket "
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(12, 154)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(545, 64)
        Me.GroupBox3.TabIndex = 64
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Viser oprettede bruger grupper "
        '
        'BrugergruppeTableAdapter
        '
        Me.BrugergruppeTableAdapter.ClearBeforeFill = True
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.SteelBlue
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button10.Location = New System.Drawing.Point(601, 13)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(86, 49)
        Me.Button10.TabIndex = 65
        Me.Button10.Text = "Gå til menu"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'BrugerGrupper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 728)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BrugerGrupper"
        Me.Text = "Finansial Insight  Bruger Grupper"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BrugergruppeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrugergruppeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents KommentarLabel As Label
    Friend WithEvents KommentarTekst As TextBox
    Friend WithEvents DatoVærdi As TextBox
    Friend WithEvents DatoLabel3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents BrugerGruppeLabel1 As Label
    Friend WithEvents BrugerGruppeTekst As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BrugergruppeDataSet As BrugergruppeDataSet
    Friend WithEvents BrugergruppeBindingSource As BindingSource
    Friend WithEvents BrugergruppeTableAdapter As BrugergruppeDataSetTableAdapters.BrugergruppeTableAdapter
    Friend WithEvents LøbenrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrugerGruppeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KommentarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LøbenrVærdi As TextBox
    Friend WithEvents LøbenrLabel As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button10 As Button
End Class
