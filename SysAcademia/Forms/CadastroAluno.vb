Imports System.Data.SqlClient

Public Class CadastroAluno

    Private Function Dados_Aluno() As ClassAluno
        '
        Dim ObjAluno As New ClassAluno

        ObjAluno.Nome = TxtNome.Text
        ObjAluno.Data_Nasc = MaskDataNasc.Text
        ObjAluno.Sexo = ComboSexo.SelectedItem
        ObjAluno.Telefone.Numero = MaskTelefone.Text
        ObjAluno.Telefone.Tipo = ComboTipoTelefone.SelectedItem
        ObjAluno.Endereco.Rua = TxtRua.Text
        ObjAluno.Endereco.Numero = TxtNº.Text
        ObjAluno.Endereco.Bairro = TxtBairro.Text
        ObjAluno.Endereco.Complemento = TxtComplemento.Text
        ObjAluno.Endereco.Busca_Cidade_Estado.Estado.Nome = ComboEstado.SelectedItem
        ObjAluno.Endereco.Busca_Cidade_Estado.Nome = ComboCidade.SelectedItem
        ObjAluno.Situacao_Aluno = ComboSituação.SelectedItem
        ObjAluno.Mensalidade.Valor = TxtValor.Text
        ObjAluno.Mensalidade.Data_Pagamento = MaskPagamento.Text

        Return ObjAluno

    End Function
    Private Function DadosEndereco() As ClassEndereco

        Dim Obj_Endereco As New ClassEndereco
        Obj_Endereco.Rua = TxtRua.Text
        Obj_Endereco.Numero = TxtNº.Text
        Obj_Endereco.Complemento = TxtComplemento.Text
        Obj_Endereco.Bairro = TxtBairro.Text
        Obj_Endereco.Busca_Cidade_Estado.Estado.Nome = ComboEstado.SelectedItem
        Obj_Endereco.Busca_Cidade_Estado.Nome = ComboCidade.SelectedItem

        Return Obj_Endereco

    End Function
    Private Sub CadastroAluno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulaEstado()
        PopulaCidades()
        PopulaSexo()
    End Sub

    Public Sub PopulaEstado()  ' FUNCIONANDO CORRETAMENTE (Ederson)

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
    Private Sub PopulaCidades()   ' FUNCIONANDO CORRETAMENTE (Ederson)

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

    Private Sub PopulaSexo()
        ComboSexo.Items.Add("MASCULINO")
        ComboSexo.Items.Add("FEMININO")
    End Sub


    Private Sub BtnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalvar.Click
        Dim Conexao As SqlConnection = Nothing

        Try
            Conexao = FabricadeConexao.GetConexao

            Dim Obj As ClassAluno = Dados_Aluno()
            Dim Dao As New DAO_Aluno(Conexao)
            Dim EXE As Integer = Dao.Insert(Obj)
            MsgBox("Dados inseridos com Sucesso !", MsgBoxStyle.Exclamation, "SUCESSO")

        Catch ex As Exception
            MessageBox.Show("Erro no acesso BD: " & ex.Message)

        Finally
            FabricadeConexao.FechaConexao(Conexao)

        End Try

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub BtnCad_Nov_Cid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCad_Nov_Cid.Click
        Cadastro_Nova_Cidade.ShowDialog()

    End Sub

    Private Sub ComboEstado_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboEstado.SelectionChangeCommitted
        PopulaCidades()
    End Sub

    Private Sub BtnD_C_T_Mensalidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnD_C_T_Mensalidade.Click
        Cadastro_Tipo_Mensalidade.ShowDialog()
    End Sub
End Class