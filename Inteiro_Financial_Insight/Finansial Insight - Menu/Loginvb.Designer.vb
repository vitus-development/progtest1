<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loginvb
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LoginLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BrugerTekst = New System.Windows.Forms.TextBox()
        Me.BrugerTekstLabel = New System.Windows.Forms.Label()
        Me.BrugerDataset = New Inteiro_Fnancial_Insight.BrugerDataset()
        Me.BrugerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrugerTableAdapter = New Inteiro_Fnancial_Insight.BrugerDatasetTableAdapters.BrugerTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BrugerDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrugerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.LoginLabel)
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1600, 100)
        Me.Panel1.TabIndex = 0
        '
        'LoginLabel
        '
        Me.LoginLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.LoginLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginLabel.ForeColor = System.Drawing.Color.White
        Me.LoginLabel.Location = New System.Drawing.Point(131, 19)
        Me.LoginLabel.Name = "LoginLabel"
        Me.LoginLabel.Size = New System.Drawing.Size(455, 50)
        Me.LoginLabel.TabIndex = 0
        Me.LoginLabel.Text = "Login til Financial Insigth"
        Me.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.BrugerTekstLabel)
        Me.Panel2.Controls.Add(Me.BrugerTekst)
        Me.Panel2.Location = New System.Drawing.Point(6, 105)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 344)
        Me.Panel2.TabIndex = 1
        '
        'BrugerTekst
        '
        Me.BrugerTekst.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BrugerBindingSource, "Bruger", True))
        Me.BrugerTekst.Location = New System.Drawing.Point(22, 70)
        Me.BrugerTekst.Margin = New System.Windows.Forms.Padding(4)
        Me.BrugerTekst.Name = "BrugerTekst"
        Me.BrugerTekst.Size = New System.Drawing.Size(133, 20)
        Me.BrugerTekst.TabIndex = 46
        '
        'BrugerTekstLabel
        '
        Me.BrugerTekstLabel.AutoSize = True
        Me.BrugerTekstLabel.Location = New System.Drawing.Point(29, 44)
        Me.BrugerTekstLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BrugerTekstLabel.Name = "BrugerTekstLabel"
        Me.BrugerTekstLabel.Size = New System.Drawing.Size(38, 13)
        Me.BrugerTekstLabel.TabIndex = 47
        Me.BrugerTekstLabel.Text = "Bruger"
        '
        'BrugerDataset
        '
        Me.BrugerDataset.DataSetName = "BrugerDataset"
        Me.BrugerDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BrugerBindingSource
        '
        Me.BrugerBindingSource.DataMember = "Bruger"
        Me.BrugerBindingSource.DataSource = Me.BrugerDataset
        '
        'BrugerTableAdapter
        '
        Me.BrugerTableAdapter.ClearBeforeFill = True
        '
        'Loginvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Loginvb"
        Me.Text = "Financial Insight -Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BrugerDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrugerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LoginLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BrugerTekst As TextBox
    Friend WithEvents BrugerTekstLabel As Label
    Friend WithEvents BrugerDataset As BrugerDataset
    Friend WithEvents BrugerBindingSource As BindingSource
    Friend WithEvents BrugerTableAdapter As BrugerDatasetTableAdapters.BrugerTableAdapter
End Class
