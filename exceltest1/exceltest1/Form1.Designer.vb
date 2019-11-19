<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCreateData = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxNmbOfRows = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_User = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Country = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.City = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone_Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreateData
        '
        Me.btnCreateData.Location = New System.Drawing.Point(12, 12)
        Me.btnCreateData.Name = "btnCreateData"
        Me.btnCreateData.Size = New System.Drawing.Size(82, 25)
        Me.btnCreateData.TabIndex = 0
        Me.btnCreateData.Text = "Make data"
        Me.btnCreateData.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "number of rows:"
        '
        'txtBoxNmbOfRows
        '
        Me.txtBoxNmbOfRows.Location = New System.Drawing.Point(168, 16)
        Me.txtBoxNmbOfRows.Name = "txtBoxNmbOfRows"
        Me.txtBoxNmbOfRows.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxNmbOfRows.TabIndex = 2
        Me.txtBoxNmbOfRows.Text = "10"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(265, 13)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(346, 16)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(99, 19)
        Me.btnExport.TabIndex = 4
        Me.btnExport.Text = "Export to excel"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(451, 17)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(108, 20)
        Me.btnImport.TabIndex = 5
        Me.btnImport.Text = "Import to excel"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Name_User, Me.Country, Me.City, Me.Phone_Number})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(625, 378)
        Me.DataGridView1.TabIndex = 6
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        '
        'Name_User
        '
        Me.Name_User.HeaderText = "Name_User"
        Me.Name_User.Name = "Name_User"
        '
        'Country
        '
        Me.Country.HeaderText = "Country"
        Me.Country.Name = "Country"
        '
        'City
        '
        Me.City.HeaderText = "City"
        Me.City.Name = "City"
        '
        'Phone_Number
        '
        Me.Phone_Number.HeaderText = "Phone_Number"
        Me.Phone_Number.Name = "Phone_Number"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(565, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 19)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "export to sql"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(685, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "import from sql"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtBoxNmbOfRows)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCreateData)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreateData As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxNmbOfRows As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Name_User As DataGridViewTextBoxColumn
    Friend WithEvents Country As DataGridViewTextBoxColumn
    Friend WithEvents City As DataGridViewTextBoxColumn
    Friend WithEvents Phone_Number As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
