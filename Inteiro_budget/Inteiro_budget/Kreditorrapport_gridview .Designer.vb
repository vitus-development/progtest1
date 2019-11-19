<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kreditorrapport_gridview
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hovedfuntion")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hovedkonto", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kreditorbudget", New System.Windows.Forms.TreeNode() {TreeNode2})
        Me.Kreditorer = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'Kreditorer
        '
        Me.Kreditorer.BackColor = System.Drawing.Color.LightSlateGray
        Me.Kreditorer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kreditorer.ForeColor = System.Drawing.Color.White
        Me.Kreditorer.Location = New System.Drawing.Point(23, 69)
        Me.Kreditorer.Name = "Kreditorer"
        TreeNode1.Name = "Node2"
        TreeNode1.Text = "Hovedfuntion"
        TreeNode2.Name = "Node1"
        TreeNode2.Text = "Hovedkonto"
        TreeNode3.Name = "Node0"
        TreeNode3.Text = "Kreditorbudget"
        Me.Kreditorer.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3})
        Me.Kreditorer.Size = New System.Drawing.Size(250, 729)
        Me.Kreditorer.TabIndex = 0
        '
        'Kreditorrapport_gridview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1594, 862)
        Me.Controls.Add(Me.Kreditorer)
        Me.Name = "Kreditorrapport_gridview"
        Me.Text = "Kreditorrapport_gridview"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Kreditorer As TreeView
End Class
