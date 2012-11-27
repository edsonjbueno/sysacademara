Imports System.Data.SqlClient

Public Class CadastroAluno

    Private Sub Limpa_Campos()

        TxtMatricula.Clear()
        TxtNome.Clear()
        TxtRua.Clear()
        TxtNº.Clear()
        TxtBairro.Clear()
        TxtComplemento.Clear()
        TxtMatricula.Focus()
        MaskDataNasc.Clear()
        Mask_DataPagamento.Clear()
        MaskTelefone.Clear()
        ComboCidade.Text = ""
        ComboEstado.Text = ""
        ComboMensalidade.Text = ""
        ComboSexo.Text = ""
        ComboSituação.Text = ""
        ComboTipoTelefone.Text = ""
        ComboValor.Text = ""

    End Sub
    ' Private Lista As New List(Of ClassAluno)

    Public Function Dados_Aluno() As ClassAluno     ' FUNCIONANDO CORRETAMENTE. NÃO ALTERAR SEM FALAR (Ederson)

        Dados_Endereco()
        Dados_Mensalidade()
        Dados_Telefone()

        Dim ObjAluno As New ClassAluno

        ObjAluno.Matricula_Aluno = TxtMatricula.Text.Trim
        ObjAluno.Nome = TxtNome.Text.Trim
        ObjAluno.Data_Nasc = MaskDataNasc.Text.Trim
        ObjAluno.Sexo = ComboSexo.SelectedItem.ToString.Trim
        ObjAluno.Situacao_Aluno.Codigo_Situacao = ComboSituação.SelectedValue

        Return ObjAluno

    End Function

    Private Function Dados_Endereco() As ClassEndereco   ' FUNCIONANDO CORRETAMENTE. NÃO ALTERAR SEM FALAR (Ederson)

        Dim Obj_Endereco As New ClassEndereco
        Obj_Endereco.Rua = TxtRua.Text.Trim
        Obj_Endereco.Numero = TxtNº.Text.Trim
        Obj_Endereco.Bairro = TxtBairro.Text.Trim
        Obj_Endereco.Complemento = TxtComplemento.Text.Trim
        Obj_Endereco.Busca_Cidade_Estado.Estado.Codigo_Estado = ComboEstado.SelectedValue
        Obj_Endereco.Busca_Cidade_Estado.Codigo_Cidade = ComboCidade.SelectedValue

        Return Obj_Endereco

    End Function

    Private Function Dados_Mensalidade() As ClassMensalidade     ' FUNCIONANDO CORRETAMENTE. NÃO ALTERAR SEM FALAR (Ederson)

        Dim Obj_Mensalidade As New ClassMensalidade

        Obj_Mensalidade.BuscaTipo.Codigo_Tipo = ComboMensalidade.SelectedValue
        Obj_Mensalidade.Data_Vencimento = MaskDataNasc.Text.Trim
        Obj_Mensalidade.Valor = ComboValor.SelectedValue


        Return Obj_Mensalidade

    End Function

    Private Function Dados_Telefone() As ClassTelefone   ' FUNCIONANDO CORRETAMENTE. NÃO ALTERAR SEM FALAR (Ederson)

        Dim Obj_Telefone As New ClassTelefone
        Obj_Telefone.Numero = MaskTelefone.Text.Trim
        Obj_Telefone.Tipo_Telefone = ComboTipoTelefone.SelectedItem

        Return Obj_Telefone

    End Function

    Private Sub CadastroAluno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' FUNCIONANDO CORRETAMENTE. NÃO ALTERAR SEM FALAR (Ederson)

        PopulaEstado()
        PopulaCidades()
        PopulaMensalidade()
        PopulaValor_Mensalidade()
        Popula_Situacao()
        Popula_ComboSexo()
        Popula_ComboIpoTelefone()
        Limpa_Campos()


    End Sub

    Private Sub Popula_ComboSexo()   ' FUNCIONANDO CORRETAMENTE. NÃO ALTERAR SEM FALAR (Ederson)

        ComboSexo.DataSource = GetType(ClassSexo).GetEnumValues

    End Sub

    Private Sub Popula_ComboIpoTelefone()    ' FUNCIONANDO CORRETAMENTE. NÃO ALTERAR SEM FALAR (Ederson)

        ComboTipoTelefone.DataSource = GetType(ClassTipoTelefone).GetEnumValues

    End Sub

    Private Sub Popula_Situacao()    ' FUNCIONANDO CORRETAMENTE. NÃO ALTERAR SEM FALAR (Ederson)

        Dim Conexao As SqlConnection = Nothing

        Try

            Conexao = FabricadeConexao.GetConexao()

            Dim Dao As New DAO_SituacaoAluno(Conexao)

            ComboSituação.DataSource = Dao.ListAll
            ComboSituação.DisplayMember = "Descricao"
            ComboSituação.ValueMember = "Codigo_Situacao"

        Catch ex As Exception
            MessageBox.Show("Erro no acesso BD: " & ex.Message)

        Finally
            FabricadeConexao.FechaConexao(Conexao)

        End Try

    End Sub

    Private Sub PopulaMensalidade()   ' FUNCIONANDO CORRETAMENTE. NÃO ALTERAR SEM FALAR (Ederson)' FALTA COMPLETAR UM ITEM

        Dim Conexao As SqlConnection = Nothing

        Try
            Conexao = FabricadeConexao.GetConexao

            Dim Dao As New DAO_TipoMensalidade(Conexao)
            ComboMensalidade.DataSource = Dao.ListAll
            ComboMensalidade.DisplayMember = "Descricao"
            ComboMensalidade.ValueMember = "Codigo_Tipo"

        Catch ex As Exception
            MessageBox.Show("Erro no acesso BD: " & ex.Message)

        Finally
            FabricadeConexao.FechaConexao(Conexao)

        End Try

    End Sub

    Private Sub PopulaValor_Mensalidade()    ' FUNCIONANDO CORRETAMENTE. NÃO ALTERAR SEM FALAR (Ederson)

        Dim Conexao As SqlConnection = Nothing

        Try
            Conexao = FabricadeConexao.GetConexao

            Dim Dao As New DAO_Mensalidade(Conexao)
            ComboValor.DataSource = Dao.ListByTipo_Mensalidade(ComboMensalidade.SelectedValue)
            ComboValor.DisplayMember = "Valor"
            ComboValor.ValueMember = "Codigo_Mensalidade"

        Catch ex As Exception
            MessageBox.Show("Erro no acesso BD: " & ex.Message)

        Finally
            FabricadeConexao.FechaConexao(Conexao)

        End Try

    End Sub

    Private Sub PopulaEstado()  ' FUNCIONANDO CORRETAMENTE. NÃO ALTERAR SEM FALAR (Ederson)

        Dim Conexao As SqlConnection = Nothing

        Try

            Conexao = FabricadeConexao.GetConexao()

            Dim Dao As New DAO_Estado(Conexao)
            ComboEstado.DataSource = Dao.ListAll
            ComboEstado.DisplayMember = "Nome"
            ComboEstado.ValueMember = "Codigo_Estado"

        Catch ex As Exception
            MessageBox.Show("Erro no acesso BD: " & ex.Message)

        Finally
            FabricadeConexao.FechaConexao(Conexao)

        End Try

    End Sub

    Private Sub PopulaCidades()   ' FUNCIONANDO CORRETAMENTE. NÃO ALTERAR SEM FALAR (Ederson)

        Dim Conexao As SqlConnection = Nothing

        Try
            Conexao = FabricadeConexao.GetConexao
            Dim Dao As New DAO_Cidade(Conexao)
            ComboCidade.DataSource = Dao.ListByCodigoEstado(ComboEstado.SelectedValue)
            ComboCidade.DisplayMember = "Nome"
            ComboCidade.ValueMember = "Codigo_Cidade"

        Catch ex As Exception
            MessageBox.Show("Erro" & ex.Message)


        Finally
            FabricadeConexao.FechaConexao(Conexao)

        End Try

    End Sub

    Private Sub BtnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalvar.Click

        ' FUNCIONANDO CORRETAMENTE. NÃO ALTERAR SEM FALAR (Ederson)

        Dim Conexao As SqlConnection = Nothing
        Dim Transacao As SqlTransaction = Nothing

        Try
            Conexao = FabricadeConexao.GetConexao
            Transacao = Conexao.BeginTransaction()

            'Chama DaoEndereco
            Dim Dao_Endereco As New DAO_Endereco(Conexao, Transacao)
            Dim Obj_Endereco As ClassEndereco = Dados_Endereco()
            Dim I As Integer = Dao_Endereco.Insert(Obj_Endereco)


            'Chama Dados Aluno
            Dim Obj_Aluno As ClassAluno = Dados_Aluno()
            Obj_Aluno.Endereco = Obj_Endereco 'Não Esta Sendo Usado '.Codigo_Endereco = Obj_Endereco.Codigo_Endereco
            Obj_Aluno.Mensalidade.Codigo_Mensalidade = ComboMensalidade.SelectedValue

            Dim Dao_Aluno As New DAO_Aluno(Conexao, Transacao)
            Dim EXE As Integer = Dao_Aluno.Insert(Obj_Aluno)

            'Chama DaoTelefone
            Dim Dao_Telefone As New DAO_Telefone(Conexao, Transacao)
            Dim Obj_Telefone As ClassTelefone = Dados_Telefone()
            Obj_Telefone.Matricula_Aluno = Obj_Aluno.Matricula_Aluno
            'Obj_Aluno.Telefone = Obj_Telefone
            Dim T As Integer = Dao_Telefone.Insert(Obj_Telefone)


            Transacao.Commit()

            MessageBox.Show("Dados inseridos com Sucesso !!")
            Limpa_Campos()
            ConsultarAluno.Popula_Grid()

        Catch ex As Exception

            Try
                Transacao.Rollback()

            Catch ex2 As Exception

                MessageBox.Show("Erro no acesso BD: " & ex.Message)

            End Try

        Finally

            FabricadeConexao.FechaConexao(Conexao)

        End Try

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click

        Close()

    End Sub

    Private Sub BtnCad_Nov_Cid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Cadastro_Nova_Cidade.ShowDialog()

    End Sub

    Private Sub ComboEstado_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboEstado.SelectionChangeCommitted

        PopulaCidades()

    End Sub

    Private Sub BtnD_C_T_Mensalidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Cadastro_TipoMensalidade.ShowDialog()

    End Sub

    Private Sub ComboMensalidade_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboMensalidade.SelectionChangeCommitted

        PopulaValor_Mensalidade()

    End Sub

    Private Sub CadastrarNovaCidadeToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarNovaCidadeToolStripMenuItem.Click

        Cadastro_Nova_Cidade.ShowDialog()

    End Sub

    Private Sub CadastrarTipoDeMensalidadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarTipoDeMensalidadeToolStripMenuItem.Click

        Cadastro_TipoMensalidade.ShowDialog()

    End Sub

    Private Sub SAIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAIRToolStripMenuItem.Click

        Close()

    End Sub

    Private Sub MENUToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MENUToolStripMenuItem.Click

    End Sub

    Private Sub ConsultarAlunoCadastradoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarAlunoCadastradoToolStripMenuItem.Click

        ConsultarAluno.Show()

    End Sub
End Class