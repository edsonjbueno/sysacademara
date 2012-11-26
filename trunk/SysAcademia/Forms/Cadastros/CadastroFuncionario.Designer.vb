<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroFuncionario
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCad_Nov_Cid = New System.Windows.Forms.Button()
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MaskRG = New System.Windows.Forms.MaskedTextBox()
        Me.MaskCPF = New System.Windows.Forms.MaskedTextBox()
        Me.ComboTipoFunc = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboTipoTelefone = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.MaskTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboSituacao = New System.Windows.Forms.ComboBox()
        Me.ComboSexo = New System.Windows.Forms.ComboBox()
        Me.MaskDataNasc = New System.Windows.Forms.MaskedTextBox()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.TxtMatricula = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnCad_Nov_Cid)
        Me.GroupBox1.Controls.Add(Me.ComboEstado)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.ComboCidade)
        Me.GroupBox1.Controls.Add(Me.Cidade)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TxtComplemento)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtBairro)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtNº)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtRua)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(599, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 227)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'BtnCad_Nov_Cid
        '
        Me.BtnCad_Nov_Cid.Location = New System.Drawing.Point(245, 99)
        Me.BtnCad_Nov_Cid.Name = "BtnCad_Nov_Cid"
        Me.BtnCad_Nov_Cid.Size = New System.Drawing.Size(172, 23)
        Me.BtnCad_Nov_Cid.TabIndex = 73
        Me.BtnCad_Nov_Cid.Text = "Cadastrar Nova Cidade ?"
        Me.BtnCad_Nov_Cid.UseVisualStyleBackColor = True
        '
        'ComboEstado
        '
        Me.ComboEstado.FormattingEnabled = True
        Me.ComboEstado.Location = New System.Drawing.Point(90, 126)
        Me.ComboEstado.Name = "ComboEstado"
        Me.ComboEstado.Size = New System.Drawing.Size(121, 21)
        Me.ComboEstado.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 129)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Estado:"
        '
        'ComboCidade
        '
        Me.ComboCidade.FormattingEnabled = True
        Me.ComboCidade.Location = New System.Drawing.Point(90, 99)
        Me.ComboCidade.Name = "ComboCidade"
        Me.ComboCidade.Size = New System.Drawing.Size(121, 21)
        Me.ComboCidade.TabIndex = 24
        '
        'Cidade
        '
        Me.Cidade.AutoSize = True
        Me.Cidade.Location = New System.Drawing.Point(19, 99)
        Me.Cidade.Name = "Cidade"
        Me.Cidade.Size = New System.Drawing.Size(43, 13)
        Me.Cidade.TabIndex = 23
        Me.Cidade.Text = "Cidade:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(258, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Complemento:"
        '
        'TxtComplemento
        '
        Me.TxtComplemento.Location = New System.Drawing.Point(338, 73)
        Me.TxtComplemento.Name = "TxtComplemento"
        Me.TxtComplemento.Size = New System.Drawing.Size(118, 20)
        Me.TxtComplemento.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Bairro:"
        '
        'TxtBairro
        '
        Me.TxtBairro.Location = New System.Drawing.Point(94, 73)
        Me.TxtBairro.Name = "TxtBairro"
        Me.TxtBairro.Size = New System.Drawing.Size(154, 20)
        Me.TxtBairro.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(419, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "N º:"
        '
        'TxtNº
        '
        Me.TxtNº.Location = New System.Drawing.Point(462, 44)
        Me.TxtNº.Name = "TxtNº"
        Me.TxtNº.Size = New System.Drawing.Size(71, 20)
        Me.TxtNº.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Rua / Av:"
        '
        'TxtRua
        '
        Me.TxtRua.Location = New System.Drawing.Point(94, 47)
        Me.TxtRua.Name = "TxtRua"
        Me.TxtRua.Size = New System.Drawing.Size(307, 20)
        Me.TxtRua.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Endereço:"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(230, 512)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(193, 28)
        Me.BtnCancelar.TabIndex = 32
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Location = New System.Drawing.Point(21, 512)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(193, 28)
        Me.BtnSalvar.TabIndex = 31
        Me.BtnSalvar.Text = "SALVAR"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MaskRG)
        Me.GroupBox2.Controls.Add(Me.MaskCPF)
        Me.GroupBox2.Controls.Add(Me.ComboTipoFunc)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtSalario)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.ComboTipoTelefone)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.MaskTelefone)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.ComboSituacao)
        Me.GroupBox2.Controls.Add(Me.ComboSexo)
        Me.GroupBox2.Controls.Add(Me.MaskDataNasc)
        Me.GroupBox2.Controls.Add(Me.TxtNome)
        Me.GroupBox2.Controls.Add(Me.TxtMatricula)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(559, 421)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        '
        'MaskRG
        '
        Me.MaskRG.Location = New System.Drawing.Point(94, 210)
        Me.MaskRG.Mask = "AA-00000000"
        Me.MaskRG.Name = "MaskRG"
        Me.MaskRG.Size = New System.Drawing.Size(100, 20)
        Me.MaskRG.TabIndex = 47
        '
        'MaskCPF
        '
        Me.MaskCPF.Location = New System.Drawing.Point(94, 173)
        Me.MaskCPF.Mask = "000.000.000-00"
        Me.MaskCPF.Name = "MaskCPF"
        Me.MaskCPF.Size = New System.Drawing.Size(100, 20)
        Me.MaskCPF.TabIndex = 46
        '
        'ComboTipoFunc
        '
        Me.ComboTipoFunc.FormattingEnabled = True
        Me.ComboTipoFunc.Location = New System.Drawing.Point(128, 360)
        Me.ComboTipoFunc.Name = "ComboTipoFunc"
        Me.ComboTipoFunc.Size = New System.Drawing.Size(121, 21)
        Me.ComboTipoFunc.TabIndex = 45
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(282, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 22)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Cadastrar tipo funcionario"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(18, 363)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 13)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Tipo do Funcionario:"
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(86, 320)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(100, 20)
        Me.txtSalario.TabIndex = 41
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 320)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Salario:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(24, 209)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "RG:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Cpf:"
        '
        'ComboTipoTelefone
        '
        Me.ComboTipoTelefone.FormattingEnabled = True
        Me.ComboTipoTelefone.Location = New System.Drawing.Point(312, 274)
        Me.ComboTipoTelefone.Name = "ComboTipoTelefone"
        Me.ComboTipoTelefone.Size = New System.Drawing.Size(121, 21)
        Me.ComboTipoTelefone.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(215, 277)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Tipo de Telefone:"
        '
        'MaskTelefone
        '
        Me.MaskTelefone.Location = New System.Drawing.Point(90, 274)
        Me.MaskTelefone.Mask = "(99)0000-0000"
        Me.MaskTelefone.Name = "MaskTelefone"
        Me.MaskTelefone.Size = New System.Drawing.Size(100, 20)
        Me.MaskTelefone.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 277)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Telefone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Situação:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Sexo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Data Nasc:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nome:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Matricula:"
        '
        'ComboSituacao
        '
        Me.ComboSituacao.FormattingEnabled = True
        Me.ComboSituacao.Location = New System.Drawing.Point(94, 239)
        Me.ComboSituacao.Name = "ComboSituacao"
        Me.ComboSituacao.Size = New System.Drawing.Size(121, 21)
        Me.ComboSituacao.TabIndex = 5
        '
        'ComboSexo
        '
        Me.ComboSexo.FormattingEnabled = True
        Me.ComboSexo.Location = New System.Drawing.Point(94, 141)
        Me.ComboSexo.Name = "ComboSexo"
        Me.ComboSexo.Size = New System.Drawing.Size(121, 21)
        Me.ComboSexo.TabIndex = 3
        '
        'MaskDataNasc
        '
        Me.MaskDataNasc.Location = New System.Drawing.Point(90, 102)
        Me.MaskDataNasc.Mask = "00/00/0000"
        Me.MaskDataNasc.Name = "MaskDataNasc"
        Me.MaskDataNasc.Size = New System.Drawing.Size(100, 20)
        Me.MaskDataNasc.TabIndex = 2
        Me.MaskDataNasc.ValidatingType = GetType(Date)
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(90, 61)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(374, 20)
        Me.TxtNome.TabIndex = 1
        '
        'TxtMatricula
        '
        Me.TxtMatricula.Location = New System.Drawing.Point(90, 23)
        Me.TxtMatricula.Name = "TxtMatricula"
        Me.TxtMatricula.Size = New System.Drawing.Size(100, 20)
        Me.TxtMatricula.TabIndex = 0
        '
        'CadastroFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 642)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Name = "CadastroFuncionario"
        Me.Text = "CadastroFuncionario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboTipoTelefone As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents MaskTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboSituacao As System.Windows.Forms.ComboBox
    Friend WithEvents ComboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents MaskDataNasc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtNome As System.Windows.Forms.TextBox
    Friend WithEvents TxtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtSalario As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboTipoFunc As System.Windows.Forms.ComboBox
    Friend WithEvents MaskRG As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BtnCad_Nov_Cid As System.Windows.Forms.Button
End Class
