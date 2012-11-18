<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ALUNOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarAlunoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FUNCIONÁRIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CADASTRARFUNCIONARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENSALIDADESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FINANCEIROToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AVISOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RELATÓRIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AJUDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FUNCIONÁRIOToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ALUNOToolStripMenuItem, Me.FUNCIONÁRIOToolStripMenuItem, Me.MENSALIDADESToolStripMenuItem, Me.FINANCEIROToolStripMenuItem, Me.AVISOSToolStripMenuItem, Me.RELATÓRIOSToolStripMenuItem, Me.AJUDAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(715, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ALUNOToolStripMenuItem
        '
        Me.ALUNOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarAlunoToolStripMenuItem})
        Me.ALUNOToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALUNOToolStripMenuItem.Name = "ALUNOToolStripMenuItem"
        Me.ALUNOToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ALUNOToolStripMenuItem.Text = "ALUNO"
        '
        'CadastrarAlunoToolStripMenuItem
        '
        Me.CadastrarAlunoToolStripMenuItem.Name = "CadastrarAlunoToolStripMenuItem"
        Me.CadastrarAlunoToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.CadastrarAlunoToolStripMenuItem.Text = "Cadastrar Aluno"
        '
        'FUNCIONÁRIOToolStripMenuItem
        '
        Me.FUNCIONÁRIOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CADASTRARFUNCIONARIOToolStripMenuItem})
        Me.FUNCIONÁRIOToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FUNCIONÁRIOToolStripMenuItem.Name = "FUNCIONÁRIOToolStripMenuItem"
        Me.FUNCIONÁRIOToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.FUNCIONÁRIOToolStripMenuItem.Text = "FUNCIONÁRIO"
        '
        'CADASTRARFUNCIONARIOToolStripMenuItem
        '
        Me.CADASTRARFUNCIONARIOToolStripMenuItem.Name = "CADASTRARFUNCIONARIOToolStripMenuItem"
        Me.CADASTRARFUNCIONARIOToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.CADASTRARFUNCIONARIOToolStripMenuItem.Text = "CADASTRAR FUNCIONARIO"
        '
        'MENSALIDADESToolStripMenuItem
        '
        Me.MENSALIDADESToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MENSALIDADESToolStripMenuItem.Name = "MENSALIDADESToolStripMenuItem"
        Me.MENSALIDADESToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.MENSALIDADESToolStripMenuItem.Text = "MENSALIDADES"
        '
        'FINANCEIROToolStripMenuItem
        '
        Me.FINANCEIROToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FINANCEIROToolStripMenuItem.Name = "FINANCEIROToolStripMenuItem"
        Me.FINANCEIROToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.FINANCEIROToolStripMenuItem.Text = "FINANCEIRO"
        '
        'AVISOSToolStripMenuItem
        '
        Me.AVISOSToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AVISOSToolStripMenuItem.Name = "AVISOSToolStripMenuItem"
        Me.AVISOSToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.AVISOSToolStripMenuItem.Text = "AVISOS"
        '
        'RELATÓRIOSToolStripMenuItem
        '
        Me.RELATÓRIOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FUNCIONÁRIOToolStripMenuItem1})
        Me.RELATÓRIOSToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RELATÓRIOSToolStripMenuItem.Name = "RELATÓRIOSToolStripMenuItem"
        Me.RELATÓRIOSToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.RELATÓRIOSToolStripMenuItem.Text = "RELATÓRIOS"
        '
        'AJUDAToolStripMenuItem
        '
        Me.AJUDAToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AJUDAToolStripMenuItem.Name = "AJUDAToolStripMenuItem"
        Me.AJUDAToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.AJUDAToolStripMenuItem.Text = "AJUDA"
        '
        'FUNCIONÁRIOToolStripMenuItem1
        '
        Me.FUNCIONÁRIOToolStripMenuItem1.Name = "FUNCIONÁRIOToolStripMenuItem1"
        Me.FUNCIONÁRIOToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.FUNCIONÁRIOToolStripMenuItem1.Text = "FUNCIONÁRIO"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(715, 338)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.ShowIcon = False
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ALUNOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FUNCIONÁRIOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MENSALIDADESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FINANCEIROToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AVISOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RELATÓRIOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AJUDAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastrarAlunoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CADASTRARFUNCIONARIOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FUNCIONÁRIOToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
