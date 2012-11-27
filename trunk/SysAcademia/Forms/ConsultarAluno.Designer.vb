<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarAluno
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
        Me.BtnApgar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGConsulta = New System.Windows.Forms.DataGridView()
        Me.BtnCadastro_Aluno = New System.Windows.Forms.Button()
        Me.MatriculaAlunoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataNascDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MensalidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SituacaoAlunoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnderecoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassAlunoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DGConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassAlunoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnApgar
        '
        Me.BtnApgar.Location = New System.Drawing.Point(12, 40)
        Me.BtnApgar.Name = "BtnApgar"
        Me.BtnApgar.Size = New System.Drawing.Size(210, 26)
        Me.BtnApgar.TabIndex = 0
        Me.BtnApgar.Text = "APAGAR"
        Me.BtnApgar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(236, 40)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(210, 26)
        Me.BtnEditar.TabIndex = 1
        Me.BtnEditar.Text = "EDITAR"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(284, 93)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(585, 20)
        Me.TxtBuscar.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(235, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscar:"
        '
        'DGConsulta
        '
        Me.DGConsulta.AllowUserToAddRows = False
        Me.DGConsulta.AllowUserToDeleteRows = False
        Me.DGConsulta.AutoGenerateColumns = False
        Me.DGConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGConsulta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MatriculaAlunoDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.DataNascDataGridViewTextBoxColumn, Me.SexoDataGridViewTextBoxColumn, Me.MensalidadeDataGridViewTextBoxColumn, Me.SituacaoAlunoDataGridViewTextBoxColumn, Me.EnderecoDataGridViewTextBoxColumn})
        Me.DGConsulta.DataSource = Me.ClassAlunoBindingSource
        Me.DGConsulta.Location = New System.Drawing.Point(26, 119)
        Me.DGConsulta.Name = "DGConsulta"
        Me.DGConsulta.ReadOnly = True
        Me.DGConsulta.Size = New System.Drawing.Size(1006, 223)
        Me.DGConsulta.TabIndex = 4
        '
        'BtnCadastro_Aluno
        '
        Me.BtnCadastro_Aluno.Location = New System.Drawing.Point(463, 40)
        Me.BtnCadastro_Aluno.Name = "BtnCadastro_Aluno"
        Me.BtnCadastro_Aluno.Size = New System.Drawing.Size(210, 26)
        Me.BtnCadastro_Aluno.TabIndex = 5
        Me.BtnCadastro_Aluno.Text = "CADASTRAR ALUNO"
        Me.BtnCadastro_Aluno.UseVisualStyleBackColor = True
        '
        'MatriculaAlunoDataGridViewTextBoxColumn
        '
        Me.MatriculaAlunoDataGridViewTextBoxColumn.DataPropertyName = "Matricula_Aluno"
        Me.MatriculaAlunoDataGridViewTextBoxColumn.HeaderText = "Matricula_Aluno"
        Me.MatriculaAlunoDataGridViewTextBoxColumn.Name = "MatriculaAlunoDataGridViewTextBoxColumn"
        Me.MatriculaAlunoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "Nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "Nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        Me.NomeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataNascDataGridViewTextBoxColumn
        '
        Me.DataNascDataGridViewTextBoxColumn.DataPropertyName = "Data_Nasc"
        Me.DataNascDataGridViewTextBoxColumn.HeaderText = "Data_Nasc"
        Me.DataNascDataGridViewTextBoxColumn.Name = "DataNascDataGridViewTextBoxColumn"
        Me.DataNascDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SexoDataGridViewTextBoxColumn
        '
        Me.SexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.HeaderText = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.Name = "SexoDataGridViewTextBoxColumn"
        Me.SexoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MensalidadeDataGridViewTextBoxColumn
        '
        Me.MensalidadeDataGridViewTextBoxColumn.DataPropertyName = "Mensalidade"
        Me.MensalidadeDataGridViewTextBoxColumn.HeaderText = "Mensalidade"
        Me.MensalidadeDataGridViewTextBoxColumn.Name = "MensalidadeDataGridViewTextBoxColumn"
        Me.MensalidadeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SituacaoAlunoDataGridViewTextBoxColumn
        '
        Me.SituacaoAlunoDataGridViewTextBoxColumn.DataPropertyName = "Situacao_Aluno"
        Me.SituacaoAlunoDataGridViewTextBoxColumn.HeaderText = "Situacao_Aluno"
        Me.SituacaoAlunoDataGridViewTextBoxColumn.Name = "SituacaoAlunoDataGridViewTextBoxColumn"
        Me.SituacaoAlunoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EnderecoDataGridViewTextBoxColumn
        '
        Me.EnderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco"
        Me.EnderecoDataGridViewTextBoxColumn.HeaderText = "Endereco"
        Me.EnderecoDataGridViewTextBoxColumn.Name = "EnderecoDataGridViewTextBoxColumn"
        Me.EnderecoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClassAlunoBindingSource
        '
        Me.ClassAlunoBindingSource.DataSource = GetType(SysAcademia.ClassAluno)
        '
        'ConsultarAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1090, 567)
        Me.Controls.Add(Me.BtnCadastro_Aluno)
        Me.Controls.Add(Me.DGConsulta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnApgar)
        Me.Name = "ConsultarAluno"
        Me.ShowIcon = False
        Me.Text = "ConsultarAluno"
        CType(Me.DGConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassAlunoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnApgar As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents MatriculaAlunoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataNascDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MensalidadeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SituacaoAlunoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnderecoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassAlunoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BtnCadastro_Aluno As System.Windows.Forms.Button
End Class
