<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginform
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
        Me.logInbtn = New System.Windows.Forms.Button()
        Me.usrNamelbl = New System.Windows.Forms.Label()
        Me.usrNametxt = New System.Windows.Forms.TextBox()
        Me.usrPasslbl = New System.Windows.Forms.Label()
        Me.usrPasstxt = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logInbtn
        '
        Me.logInbtn.Location = New System.Drawing.Point(411, 216)
        Me.logInbtn.Name = "logInbtn"
        Me.logInbtn.Size = New System.Drawing.Size(75, 23)
        Me.logInbtn.TabIndex = 0
        Me.logInbtn.Text = "Login"
        Me.logInbtn.UseVisualStyleBackColor = True
        '
        'usrNamelbl
        '
        Me.usrNamelbl.AutoSize = True
        Me.usrNamelbl.Location = New System.Drawing.Point(263, 122)
        Me.usrNamelbl.Name = "usrNamelbl"
        Me.usrNamelbl.Size = New System.Drawing.Size(58, 13)
        Me.usrNamelbl.TabIndex = 1
        Me.usrNamelbl.Text = "Username:"
        '
        'usrNametxt
        '
        Me.usrNametxt.Location = New System.Drawing.Point(364, 122)
        Me.usrNametxt.Name = "usrNametxt"
        Me.usrNametxt.Size = New System.Drawing.Size(100, 20)
        Me.usrNametxt.TabIndex = 3
        '
        'usrPasslbl
        '
        Me.usrPasslbl.AutoSize = True
        Me.usrPasslbl.Location = New System.Drawing.Point(263, 158)
        Me.usrPasslbl.Name = "usrPasslbl"
        Me.usrPasslbl.Size = New System.Drawing.Size(56, 13)
        Me.usrPasslbl.TabIndex = 4
        Me.usrPasslbl.Text = "Password:"
        '
        'usrPasstxt
        '
        Me.usrPasstxt.Location = New System.Drawing.Point(364, 158)
        Me.usrPasstxt.Name = "usrPasstxt"
        Me.usrPasstxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.usrPasstxt.Size = New System.Drawing.Size(100, 20)
        Me.usrPasstxt.TabIndex = 5
        Me.usrPasstxt.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Logintest1.My.Resources.Resources.finansialinsighlogo
        Me.PictureBox1.Location = New System.Drawing.Point(120, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(537, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'loginform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.usrPasstxt)
        Me.Controls.Add(Me.usrPasslbl)
        Me.Controls.Add(Me.usrNametxt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.usrNamelbl)
        Me.Controls.Add(Me.logInbtn)
        Me.Name = "loginform"
        Me.Text = "Bruger adgang"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents logInbtn As Button
    Friend WithEvents usrNamelbl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents usrNametxt As TextBox
    Friend WithEvents usrPasslbl As Label
    Friend WithEvents usrPasstxt As TextBox
End Class
