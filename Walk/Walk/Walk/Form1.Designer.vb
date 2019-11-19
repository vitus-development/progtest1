<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IntastningAfWalkData
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
        Me.Datolabel = New System.Windows.Forms.Label()
        Me.FornavnLabel = New System.Windows.Forms.Label()
        Me.EfternavnLabel = New System.Windows.Forms.Label()
        Me.AntalMinutterLabel = New System.Windows.Forms.Label()
        Me.KalorierLabel = New System.Windows.Forms.Label()
        Me.KmLabel = New System.Windows.Forms.Label()
        Me.SkridtLabel = New System.Windows.Forms.Label()
        Me.DatoVærdi = New System.Windows.Forms.TextBox()
        Me.WalkDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WalkDataSet2 = New Walk.WalkDataSet()
        Me.AntalMinutterVærdi = New System.Windows.Forms.TextBox()
        Me.AntalKmVærdi = New System.Windows.Forms.TextBox()
        Me.AntalSkridtVærdi = New System.Windows.Forms.TextBox()
        Me.EfternavnTekst = New System.Windows.Forms.TextBox()
        Me.FornavnTekst = New System.Windows.Forms.TextBox()
        Me.AntalKalorierVærdi = New System.Windows.Forms.TextBox()
        Me.InsertButton = New System.Windows.Forms.Button()
        Me.IDlbl = New System.Windows.Forms.Label()
        Me.IdVærdi = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.WalkDataTableAdapter = New Walk.WalkDataSet2TableAdapters.WalkDataTableAdapter()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.WalkDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FornavnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EfternavnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SkridtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinutterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KalorierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WalkDataTableAdapter1 = New Walk.WalkDataSetTableAdapters.WalkDataTableAdapter()
        Me.TableAdapterManager = New Walk.WalkDataSetTableAdapters.TableAdapterManager()
        Me.FillByToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        CType(Me.WalkDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WalkDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        CType(Me.WalkDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Datolabel
        '
        Me.Datolabel.AutoSize = True
        Me.Datolabel.Location = New System.Drawing.Point(40, 99)
        Me.Datolabel.Name = "Datolabel"
        Me.Datolabel.Size = New System.Drawing.Size(30, 13)
        Me.Datolabel.TabIndex = 0
        Me.Datolabel.Text = "Dato"
        '
        'FornavnLabel
        '
        Me.FornavnLabel.AutoSize = True
        Me.FornavnLabel.Location = New System.Drawing.Point(42, 137)
        Me.FornavnLabel.Name = "FornavnLabel"
        Me.FornavnLabel.Size = New System.Drawing.Size(46, 13)
        Me.FornavnLabel.TabIndex = 1
        Me.FornavnLabel.Text = "Fornavn"
        '
        'EfternavnLabel
        '
        Me.EfternavnLabel.AutoSize = True
        Me.EfternavnLabel.Location = New System.Drawing.Point(40, 172)
        Me.EfternavnLabel.Name = "EfternavnLabel"
        Me.EfternavnLabel.Size = New System.Drawing.Size(53, 13)
        Me.EfternavnLabel.TabIndex = 2
        Me.EfternavnLabel.Text = "Efternavn"
        '
        'AntalMinutterLabel
        '
        Me.AntalMinutterLabel.AutoSize = True
        Me.AntalMinutterLabel.Location = New System.Drawing.Point(40, 265)
        Me.AntalMinutterLabel.Name = "AntalMinutterLabel"
        Me.AntalMinutterLabel.Size = New System.Drawing.Size(71, 13)
        Me.AntalMinutterLabel.TabIndex = 3
        Me.AntalMinutterLabel.Text = "Antal minutter"
        '
        'KalorierLabel
        '
        Me.KalorierLabel.AutoSize = True
        Me.KalorierLabel.Location = New System.Drawing.Point(40, 300)
        Me.KalorierLabel.Name = "KalorierLabel"
        Me.KalorierLabel.Size = New System.Drawing.Size(68, 13)
        Me.KalorierLabel.TabIndex = 4
        Me.KalorierLabel.Text = "Antal kalorier"
        '
        'KmLabel
        '
        Me.KmLabel.AutoSize = True
        Me.KmLabel.Location = New System.Drawing.Point(40, 235)
        Me.KmLabel.Name = "KmLabel"
        Me.KmLabel.Size = New System.Drawing.Size(48, 13)
        Me.KmLabel.TabIndex = 5
        Me.KmLabel.Text = "Antal km"
        '
        'SkridtLabel
        '
        Me.SkridtLabel.AutoSize = True
        Me.SkridtLabel.Location = New System.Drawing.Point(40, 206)
        Me.SkridtLabel.Name = "SkridtLabel"
        Me.SkridtLabel.Size = New System.Drawing.Size(59, 13)
        Me.SkridtLabel.TabIndex = 6
        Me.SkridtLabel.Text = "Antal skridt"
        '
        'DatoVærdi
        '
        Me.DatoVærdi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WalkDataBindingSource, "Dato", True))
        Me.DatoVærdi.Location = New System.Drawing.Point(167, 91)
        Me.DatoVærdi.Name = "DatoVærdi"
        Me.DatoVærdi.Size = New System.Drawing.Size(100, 20)
        Me.DatoVærdi.TabIndex = 7
        '
        'WalkDataBindingSource
        Me.WalkDataBindingSource.DataMember = "WalkData"
        Me.WalkDataBindingSource.DataSource = Me.WalkDataSet2
        '
        'WalkDataSet2
        '
        Me.WalkDataSet2.DataSetName = "WalkDataSet2"
        Me.WalkDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AntalMinutterVærdi
        '
        Me.AntalMinutterVærdi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WalkDataBindingSource, "Minutter", True))
        Me.AntalMinutterVærdi.Location = New System.Drawing.Point(167, 262)
        Me.AntalMinutterVærdi.Name = "AntalMinutterVærdi"
        Me.AntalMinutterVærdi.Size = New System.Drawing.Size(100, 20)
        Me.AntalMinutterVærdi.TabIndex = 8
        '
        'AntalKmVærdi
        '
        Me.AntalKmVærdi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WalkDataBindingSource, "Km", True))
        Me.AntalKmVærdi.Location = New System.Drawing.Point(167, 232)
        Me.AntalKmVærdi.Name = "AntalKmVærdi"
        Me.AntalKmVærdi.Size = New System.Drawing.Size(100, 20)
        Me.AntalKmVærdi.TabIndex = 9
        '
        'AntalSkridtVærdi
        '
        Me.AntalSkridtVærdi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WalkDataBindingSource, "Skridt", True))
        Me.AntalSkridtVærdi.Location = New System.Drawing.Point(167, 206)
        Me.AntalSkridtVærdi.Name = "AntalSkridtVærdi"
        Me.AntalSkridtVærdi.Size = New System.Drawing.Size(100, 20)
        Me.AntalSkridtVærdi.TabIndex = 10
        '
        'EfternavnTekst
        '
        Me.EfternavnTekst.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WalkDataBindingSource, "Efternavn", True))
        Me.EfternavnTekst.Location = New System.Drawing.Point(167, 172)
        Me.EfternavnTekst.Name = "EfternavnTekst"
        Me.EfternavnTekst.Size = New System.Drawing.Size(100, 20)
        Me.EfternavnTekst.TabIndex = 11
        '
        'FornavnTekst
        '
        Me.FornavnTekst.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WalkDataBindingSource, "Fornavn", True))
        Me.FornavnTekst.Location = New System.Drawing.Point(167, 137)
        Me.FornavnTekst.Name = "FornavnTekst"
        Me.FornavnTekst.Size = New System.Drawing.Size(100, 20)
        Me.FornavnTekst.TabIndex = 12
        '
        'AntalKalorierVærdi
        '
        Me.AntalKalorierVærdi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WalkDataBindingSource, "Kalorier", True))
        Me.AntalKalorierVærdi.Location = New System.Drawing.Point(167, 300)
        Me.AntalKalorierVærdi.Name = "AntalKalorierVærdi"
        Me.AntalKalorierVærdi.Size = New System.Drawing.Size(100, 20)
        Me.AntalKalorierVærdi.TabIndex = 13
        '
        'InsertButton
        '
        Me.InsertButton.Location = New System.Drawing.Point(35, 361)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(75, 23)
        Me.InsertButton.TabIndex = 14
        Me.InsertButton.Text = "Insert Data"
        Me.InsertButton.UseVisualStyleBackColor = True
        '
        'IDlbl
        '
        Me.IDlbl.AutoSize = True
        Me.IDlbl.Location = New System.Drawing.Point(40, 64)
        Me.IDlbl.Name = "IDlbl"
        Me.IDlbl.Size = New System.Drawing.Size(34, 13)
        Me.IDlbl.TabIndex = 16
        Me.IDlbl.Text = "IDNR"
        '
        'IdVærdi
        '
        Me.IdVærdi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WalkDataBindingSource, "Id", True))
        Me.IdVærdi.Location = New System.Drawing.Point(180, 56)
        Me.IdVærdi.Name = "IdVærdi"
        Me.IdVærdi.Size = New System.Drawing.Size(48, 20)
        Me.IdVærdi.TabIndex = 17
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(167, 361)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.DatoDataGridViewTextBoxColumn, Me.FornavnDataGridViewTextBoxColumn, Me.EfternavnDataGridViewTextBoxColumn, Me.SkridtDataGridViewTextBoxColumn, Me.KmDataGridViewTextBoxColumn, Me.MinutterDataGridViewTextBoxColumn, Me.KalorierDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.WalkDataBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(320, 56)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(836, 150)
        Me.DataGridView1.TabIndex = 20
        '
        'WalkDataTableAdapter
        '
        Me.WalkDataTableAdapter.ClearBeforeFill = True
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1176, 25)
        Me.FillByToolStrip.TabIndex = 21
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'WalkDataSet2BindingSource
        '
        Me.WalkDataSet2BindingSource.DataSource = Me.WalkDataSet2
        Me.WalkDataSet2BindingSource.Position = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'DatoDataGridViewTextBoxColumn
        '
        Me.DatoDataGridViewTextBoxColumn.DataPropertyName = "Dato"
        Me.DatoDataGridViewTextBoxColumn.HeaderText = "Dato"
        Me.DatoDataGridViewTextBoxColumn.Name = "DatoDataGridViewTextBoxColumn"
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
        'SkridtDataGridViewTextBoxColumn
        '
        Me.SkridtDataGridViewTextBoxColumn.DataPropertyName = "Skridt"
        Me.SkridtDataGridViewTextBoxColumn.HeaderText = "Skridt"
        Me.SkridtDataGridViewTextBoxColumn.Name = "SkridtDataGridViewTextBoxColumn"
        '
        'KmDataGridViewTextBoxColumn
        '
        Me.KmDataGridViewTextBoxColumn.DataPropertyName = "Km"
        Me.KmDataGridViewTextBoxColumn.HeaderText = "Km"
        Me.KmDataGridViewTextBoxColumn.Name = "KmDataGridViewTextBoxColumn"
        '
        'MinutterDataGridViewTextBoxColumn
        '
        Me.MinutterDataGridViewTextBoxColumn.DataPropertyName = "Minutter"
        Me.MinutterDataGridViewTextBoxColumn.HeaderText = "Minutter"
        Me.MinutterDataGridViewTextBoxColumn.Name = "MinutterDataGridViewTextBoxColumn"
        '
        'KalorierDataGridViewTextBoxColumn
        '
        Me.KalorierDataGridViewTextBoxColumn.DataPropertyName = "Kalorier"
        Me.KalorierDataGridViewTextBoxColumn.HeaderText = "Kalorier"
        Me.KalorierDataGridViewTextBoxColumn.Name = "KalorierDataGridViewTextBoxColumn"
        '
        'WalkDataTableAdapter1
        '
        Me.WalkDataTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Walk.WalkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WalkDataTableAdapter = Me.WalkDataTableAdapter1
        '
        'FillByToolStrip1
        '
        Me.FillByToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton1})
        Me.FillByToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip1.Name = "FillByToolStrip1"
        Me.FillByToolStrip1.Size = New System.Drawing.Size(111, 25)
        Me.FillByToolStrip1.TabIndex = 22
        Me.FillByToolStrip1.Text = "FillByToolStrip1"
        '
        'FillByToolStripButton1
        '
        Me.FillByToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton1.Name = "FillByToolStripButton1"
        Me.FillByToolStripButton1.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton1.Text = "FillBy"
        '
        'IntastningAfWalkData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1176, 450)
        Me.Controls.Add(Me.FillByToolStrip1)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.IdVærdi)
        Me.Controls.Add(Me.IDlbl)
        Me.Controls.Add(Me.InsertButton)
        Me.Controls.Add(Me.AntalKalorierVærdi)
        Me.Controls.Add(Me.FornavnTekst)
        Me.Controls.Add(Me.EfternavnTekst)
        Me.Controls.Add(Me.AntalSkridtVærdi)
        Me.Controls.Add(Me.AntalKmVærdi)
        Me.Controls.Add(Me.AntalMinutterVærdi)
        Me.Controls.Add(Me.DatoVærdi)
        Me.Controls.Add(Me.SkridtLabel)
        Me.Controls.Add(Me.KmLabel)
        Me.Controls.Add(Me.KalorierLabel)
        Me.Controls.Add(Me.AntalMinutterLabel)
        Me.Controls.Add(Me.EfternavnLabel)
        Me.Controls.Add(Me.FornavnLabel)
        Me.Controls.Add(Me.Datolabel)
        Me.Name = "IntastningAfWalkData"
        Me.Text = "Intastning af Walk data"
        CType(Me.WalkDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WalkDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        CType(Me.WalkDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip1.ResumeLayout(False)
        Me.FillByToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Datolabel As Label
    Friend WithEvents FornavnLabel As Label
    Friend WithEvents EfternavnLabel As Label
    Friend WithEvents AntalMinutterLabel As Label
    Friend WithEvents KalorierLabel As Label
    Friend WithEvents KmLabel As Label
    Friend WithEvents SkridtLabel As Label
    Friend WithEvents DatoVærdi As TextBox
    Friend WithEvents AntalMinutterVærdi As TextBox
    Friend WithEvents AntalKmVærdi As TextBox
    Friend WithEvents AntalSkridtVærdi As TextBox
    Friend WithEvents EfternavnTekst As TextBox
    Friend WithEvents FornavnTekst As TextBox
    Friend WithEvents AntalKalorierVærdi As TextBox
    Friend WithEvents InsertButton As Button
    Friend WithEvents IDlbl As Label
    Friend WithEvents IdVærdi As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents WalkDataSet2 As WalkDataSet
    Friend WithEvents WalkDataBindingSource As BindingSource
    Friend WithEvents WalkDataTableAdapter As WalkDataSet2TableAdapters.WalkDataTableAdapter
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FornavnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EfternavnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SkridtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KmDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MinutterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KalorierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WalkDataSet2BindingSource As BindingSource
    Friend WithEvents WalkDataTableAdapter1 As Walk.WalkDataSetTableAdapters.WalkDataTableAdapter
    Friend WithEvents TableAdapterManager As Walk.WalkDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FillByToolStrip1 As ToolStrip
    Friend WithEvents FillByToolStripButton1 As ToolStripButton
End Class
