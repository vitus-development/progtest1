<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rapportmenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabRapportmenu = New System.Windows.Forms.TabControl()
        Me.Kreditorrapporter = New System.Windows.Forms.TabPage()
        Me.TabDebitorrapporter = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OverskriftNavn = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New Inteiro_Finansial_Insigt_udv.DataSet1()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabRapportmenu.SuspendLayout()
        Me.Kreditorrapporter.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabRapportmenu
        '
        Me.TabRapportmenu.Controls.Add(Me.Kreditorrapporter)
        Me.TabRapportmenu.Controls.Add(Me.TabDebitorrapporter)
        Me.TabRapportmenu.Location = New System.Drawing.Point(295, 30)
        Me.TabRapportmenu.Name = "TabRapportmenu"
        Me.TabRapportmenu.SelectedIndex = 0
        Me.TabRapportmenu.Size = New System.Drawing.Size(1188, 766)
        Me.TabRapportmenu.TabIndex = 0
        '
        'Kreditorrapporter
        '
        Me.Kreditorrapporter.Controls.Add(Me.DataGridView1)
        Me.Kreditorrapporter.Location = New System.Drawing.Point(4, 22)
        Me.Kreditorrapporter.Name = "Kreditorrapporter"
        Me.Kreditorrapporter.Padding = New System.Windows.Forms.Padding(3)
        Me.Kreditorrapporter.Size = New System.Drawing.Size(1180, 740)
        Me.Kreditorrapporter.TabIndex = 0
        Me.Kreditorrapporter.Text = "Kreditorrapporter"
        Me.Kreditorrapporter.UseVisualStyleBackColor = True
        '
        'TabDebitorrapporter
        '
        Me.TabDebitorrapporter.Location = New System.Drawing.Point(4, 22)
        Me.TabDebitorrapporter.Name = "TabDebitorrapporter"
        Me.TabDebitorrapporter.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDebitorrapporter.Size = New System.Drawing.Size(1180, 740)
        Me.TabDebitorrapporter.TabIndex = 1
        Me.TabDebitorrapporter.Text = "Debitorrapporter"
        Me.TabDebitorrapporter.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.OverskriftNavn)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Location = New System.Drawing.Point(12, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 766)
        Me.Panel1.TabIndex = 3
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button6.Location = New System.Drawing.Point(14, 196)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(173, 29)
        Me.Button6.TabIndex = 74
        Me.Button6.Text = "Gå til Dataloads"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.Location = New System.Drawing.Point(14, 101)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(173, 29)
        Me.Button4.TabIndex = 72
        Me.Button4.Text = "Brugeradministration"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button5.Location = New System.Drawing.Point(23, 302)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(173, 28)
        Me.Button5.TabIndex = 73
        Me.Button5.Text = "Vis Rapport"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Location = New System.Drawing.Point(14, 249)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 29)
        Me.Button2.TabIndex = 71
        Me.Button2.Text = "Gå til Dashboard"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(14, 64)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 29)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Indtastninger"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'OverskriftNavn
        '
        Me.OverskriftNavn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OverskriftNavn.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.OverskriftNavn.Location = New System.Drawing.Point(14, 24)
        Me.OverskriftNavn.Multiline = True
        Me.OverskriftNavn.Name = "OverskriftNavn"
        Me.OverskriftNavn.Size = New System.Drawing.Size(173, 30)
        Me.OverskriftNavn.TabIndex = 69
        Me.OverskriftNavn.Text = "Rapportering"
        Me.OverskriftNavn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.Location = New System.Drawing.Point(14, 363)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(173, 49)
        Me.Button3.TabIndex = 64
        Me.Button3.Text = "Luk Indtastningsmenu"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.DataSet1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(99, 93)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1030, 518)
        Me.DataGridView1.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'Rapportmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1521, 808)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabRapportmenu)
        Me.Name = "Rapportmenu"
        Me.Text = "Rapportmenu"
        Me.TabRapportmenu.ResumeLayout(False)
        Me.Kreditorrapporter.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabRapportmenu As TabControl
    Friend WithEvents Kreditorrapporter As TabPage
    Friend WithEvents TabDebitorrapporter As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents OverskriftNavn As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
End Class
