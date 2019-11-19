<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Indtastningsmenu
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OverskriftNavn = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.OverskriftNavn)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.RadioButton4)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Location = New System.Drawing.Point(12, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 426)
        Me.Panel1.TabIndex = 1
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
        Me.OverskriftNavn.Text = "Indtastningsmenu"
        Me.OverskriftNavn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadioButton1
        '
        Me.RadioButton1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.RadioButton1.Location = New System.Drawing.Point(14, 71)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(173, 50)
        Me.RadioButton1.TabIndex = 65
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Gå til Debitor Budget"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton4
        '
        Me.RadioButton4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.RadioButton4.Location = New System.Drawing.Point(14, 143)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(173, 50)
        Me.RadioButton4.TabIndex = 68
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Gå til Kreditor Budget"
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.RadioButton3.Location = New System.Drawing.Point(14, 216)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(173, 50)
        Me.RadioButton3.TabIndex = 67
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Gå til Lønbudget - Likviditet"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.RadioButton2.Location = New System.Drawing.Point(14, 287)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(173, 50)
        Me.RadioButton2.TabIndex = 66
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Gå til Refusionbudget - likviditet"
        Me.RadioButton2.UseVisualStyleBackColor = False
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
        Me.Button3.Text = "Luk Indtastnings Menu"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(214, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(578, 425)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel3.Location = New System.Drawing.Point(0, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(578, 51)
        Me.Panel3.TabIndex = 3
        '
        'Indtastningsmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Indtastningsmenu"
        Me.Text = "Finansial Insight - Indtastningsmenu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents OverskriftNavn As TextBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
