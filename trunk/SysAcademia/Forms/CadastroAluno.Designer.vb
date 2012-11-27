<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroAluno
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
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarNovaCidadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarTipoDeMensalidadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarAlunoCadastradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AJUDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ComboTipoTelefone = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.MaskTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboSituação = New System.Windows.Forms.ComboBox()
        Me.ComboMensalidade = New System.Windows.Forms.ComboBox()
        Me.ComboSexo = New System.Windows.Forms.ComboBox()
        Me.MaskDataNasc = New System.Windows.Forms.MaskedTextBox()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.TxtMatricula = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.ComboEstado = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboCidade = New System.Windows.Forms.ComboBox()
        Me.Cidade = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtComplemento = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtBairro = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNº = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtRua = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Mask_DataPagamento = New System.Windows.Forms.MaskedTextBox()
        Me.ComboValor = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem, Me.SAIRToolStripMenuItem, Me.AJUDAToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(811, 24)
        Me.MenuStrip1.TabIndex = 33
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarNovaCidadeToolStripMenuItem, Me.CadastrarTipoDeMensalidadeToolStripMenuItem, Me.ConsultarAlunoCadastradoToolStripMenuItem})
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'CadastrarNovaCidadeToolStripMenuItem
        '
        Me.CadastrarNovaCidadeToolStripMenuItem.Name = "CadastrarNovaCidadeToolStripMenuItem"
        Me.CadastrarNovaCidadeToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.CadastrarNovaCidadeToolStripMenuItem.Text = "Cadastrar Nova Cidade"
        '
        'CadastrarTipoDeMensalidadeToolStripMenuItem
        '
        Me.CadastrarTipoDeMensalidadeToolStripMenuItem.Name = "CadastrarTipoDeMensalidadeToolStripMenuItem"
        Me.CadastrarTipoDeMensalidadeToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.CadastrarTipoDeMensalidadeToolStripMenuItem.Text = "Cadastrar Tipo de Mensalidade"
        '
        'ConsultarAlunoCadastradoToolStripMenuItem
        '
        Me.ConsultarAlunoCadastradoToolStripMenuItem.Name = "ConsultarAlunoCadastradoToolStripMenuItem"
        Me.ConsultarAlunoCadastradoToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.ConsultarAlunoCadastradoToolStripMenuItem.Text = "Consultar Aluno Cadastrado"
        '
        'SAIRToolStripMenuItem
        '
        Me.SAIRToolStripMenuItem.Name = "SAIRToolStripMenuItem"
        Me.SAIRToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.SAIRToolStripMenuItem.Text = "SAIR"
        '
        'AJUDAToolStripMenuItem
        '
        Me.AJUDAToolStripMenuItem.Name = "AJUDAToolStripMenuItem"
        Me.AJUDAToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AJUDAToolStripMenuItem.Text = "AJUDA"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(343, 298)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "Valor:"
        '
        'ComboTipoTelefone
        '
        Me.ComboTipoTelefone.FormattingEnabled = True
        Me.ComboTipoTelefone.Location = New System.Drawing.Point(325, 257)
        Me.ComboTipoTelefone.Name = "ComboTipoTelefone"
        Me.ComboTipoTelefone.Size = New System.Drawing.Size(121, 21)
        Me.ComboTipoTelefone.TabIndex = 51
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(228, 260)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 13)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Tipo de Telefone:"
        '
        'MaskTelefone
        '
        Me.MaskTelefone.Location = New System.Drawing.Point(104, 258)
        Me.MaskTelefone.Mask = "(99)0000-0000"
        Me.MaskTelefone.Name = "MaskTelefone"
        Me.MaskTelefone.Size = New System.Drawing.Size(100, 20)
        Me.MaskTelefone.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(28, 260)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Telefone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Situação:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Mensalidade:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Sexo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Data Nasc:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Nome:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Matricula:"
        '
        'ComboSituação
        '
        Me.ComboSituação.FormattingEnabled = True
        Me.ComboSituação.Location = New System.Drawing.Point(103, 222)
        Me.ComboSituação.Name = "ComboSituação"
        Me.ComboSituação.Size = New System.Drawing.Size(121, 21)
        Me.ComboSituação.TabIndex = 41
        '
        'ComboMensalidade
        '
        Me.ComboMensalidade.FormattingEnabled = True
        Me.ComboMensalidade.Location = New System.Drawing.Point(93, 296)
        Me.ComboMensalidade.Name = "ComboMensalidade"
        Me.ComboMensalidade.Size = New System.Drawing.Size(232, 21)
        Me.ComboMensalidade.TabIndex = 40
        '
        'ComboSexo
        '
        Me.ComboSexo.FormattingEnabled = True
        Me.ComboSexo.Location = New System.Drawing.Point(103, 186)
        Me.ComboSexo.Name = "ComboSexo"
        Me.ComboSexo.Size = New System.Drawing.Size(121, 21)
        Me.ComboSexo.TabIndex = 39
        '
        'MaskDataNasc
        '
        Me.MaskDataNasc.Location = New System.Drawing.Point(103, 150)
        Me.MaskDataNasc.Mask = "00/00/0000"
        Me.MaskDataNasc.Name = "MaskDataNasc"
        Me.MaskDataNasc.Size = New System.Drawing.Size(100, 20)
        Me.MaskDataNasc.TabIndex = 38
        Me.MaskDataNasc.ValidatingType = GetType(Date)
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(103, 109)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(374, 20)
        Me.TxtNome.TabIndex = 37
        '
        'TxtMatricula
        '
        Me.TxtMatricula.Location = New System.Drawing.Point(103, 71)
        Me.TxtMatricula.Name = "TxtMatricula"
        Me.TxtMatricula.Size = New System.Drawing.Size(100, 20)
        Me.TxtMatricula.TabIndex = 36
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(288, 482)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(193, 28)
        Me.BtnCancelar.TabIndex = 69
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Location = New System.Drawing.Point(89, 482)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(193, 28)
        Me.BtnSalvar.TabIndex = 68
        Me.BtnSalvar.Text = "SALVAR"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'ComboEstado
        '
        Me.ComboEstado.FormattingEnabled = True
        Me.ComboEstado.Location = New System.Drawing.Point(89, 401)
        Me.ComboEstado.Name = "ComboEstado"
        Me.ComboEstado.Size = New System.Drawing.Size(177, 21)
        Me.ComboEstado.TabIndex = 67
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 409)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Estado:"
        '
        'ComboCidade
        '
        Me.ComboCidade.FormattingEnabled = True
        Me.ComboCidade.Location = New System.Drawing.Point(89, 428)
        Me.ComboCidade.Name = "ComboCidade"
        Me.ComboCidade.Size = New System.Drawing.Size(177, 21)
        Me.ComboCidade.TabIndex = 65
        '
        'Cidade
        '
        Me.Cidade.AutoSize = True
        Me.Cidade.Location = New System.Drawing.Point(18, 436)
        Me.Cidade.Name = "Cidade"
        Me.Cidade.Size = New System.Drawing.Size(43, 13)
        Me.Cidade.TabIndex = 64
        Me.Cidade.Text = "Cidade:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(257, 373)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Complemento:"
        '
        'TxtComplemento
        '
        Me.TxtComplemento.Location = New System.Drawing.Point(337, 370)
        Me.TxtComplemento.Name = "TxtComplemento"
        Me.TxtComplemento.Size = New System.Drawing.Size(118, 20)
        Me.TxtComplemento.TabIndex = 62
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 370)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Bairro:"
        '
        'TxtBairro
        '
        Me.TxtBairro.Location = New System.Drawing.Point(93, 370)
        Me.TxtBairro.Name = "TxtBairro"
        Me.TxtBairro.Size = New System.Drawing.Size(154, 20)
        Me.TxtBairro.TabIndex = 60
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(418, 347)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "N º:"
        '
        'TxtNº
        '
        Me.TxtNº.Location = New System.Drawing.Point(461, 341)
        Me.TxtNº.Name = "TxtNº"
        Me.TxtNº.Size = New System.Drawing.Size(71, 20)
        Me.TxtNº.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Rua / Av:"
        '
        'TxtRua
        '
        Me.TxtRua.Location = New System.Drawing.Point(93, 344)
        Me.TxtRua.Name = "TxtRua"
        Me.TxtRua.Size = New System.Drawing.Size(307, 20)
        Me.TxtRua.TabIndex = 56
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(472, 299)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 13)
        Me.Label16.TabIndex = 70
        Me.Label16.Text = "Data Pagamento:"
        '
        'Mask_DataPagamento
        '
        Me.Mask_DataPagamento.Location = New System.Drawing.Point(568, 296)
        Me.Mask_DataPagamento.Mask = "00/00/0000"
        Me.Mask_DataPagamento.Name = "Mask_DataPagamento"
        Me.Mask_DataPagamento.Size = New System.Drawing.Size(100, 20)
        Me.Mask_DataPagamento.TabIndex = 71
        Me.Mask_DataPagamento.ValidatingType = GetType(Date)
        '
        'ComboValor
        '
        Me.ComboValor.FormattingEnabled = True
        Me.ComboValor.Location = New System.Drawing.Point(383, 295)
        Me.ComboValor.Name = "ComboValor"
        Me.ComboValor.Size = New System.Drawing.Size(83, 21)
        Me.ComboValor.TabIndex = 74
        '
        'CadastroAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(811, 658)
        Me.Controls.Add(Me.ComboValor)
        Me.Controls.Add(Me.Mask_DataPagamento)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.ComboEstado)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ComboCidade)
        Me.Controls.Add(Me.Cidade)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtComplemento)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtBairro)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtNº)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtRua)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ComboTipoTelefone)
        Me.Controls.Add(Me.TxtMatricula)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.MaskTelefone)
        Me.Controls.Add(Me.MaskDataNasc)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ComboSexo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboMensalidade)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboSituação)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "CadastroAluno"
        Me.ShowIcon = False
        Me.Text = "CadastroAluno"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ComboTipoTelefone As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents MaskTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboSituação As System.Windows.Forms.ComboBox
    Friend WithEvents ComboMensalidade As System.Windows.Forms.ComboBox
    Friend WithEvents ComboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents MaskDataNasc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtNome As System.Windows.Forms.TextBox
    Friend WithEvents TxtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnSalvar As System.Windows.Forms.Button
    Friend WithEvents ComboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ComboCidade As System.Windows.Forms.ComboBox
    Friend WithEvents Cidade As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtBairro As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtNº As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtRua As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Mask_DataPagamento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ComboValor As System.Windows.Forms.ComboBox
    Friend WithEvents MENUToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastrarNovaCidadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastrarTipoDeMensalidadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SAIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AJUDAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarAlunoCadastradoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
