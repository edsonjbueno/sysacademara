Imports System.Data.SqlClient

Public Class CadastroAluno

    Dim List As New List(Of ClassCidade)

    Private Function Dados_Aluno() As ClassAluno

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
        ObjAluno.Endereco.Cidade.Estado = ComboEstado.SelectedItem
        ObjAluno.Endereco.Cidade.Nome = ComboCidade.SelectedItem
        ObjAluno.Situacao_Aluno = ComboSituação.SelectedItem
        ObjAluno.Mensalidade.Valor = TxtValor.Text
        ObjAluno.Mensalidade.Data_Pagamento = MaskPagamento.Text


        Return ObjAluno
    End Function

    Private Sub CadastroAluno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulaEstado()

        Dim Cidades As ClassCidade = ComboCidade.SelectedItem
        ComboCidade.DataSource = ListCidades(Cidades.Coidgo_Cidade)
        ComboCidade.DisplayMember = "Estado"
    End Sub
    Public Sub PopulaEstado()
        Dim Conexao As SqlConnection = Nothing
        Try

            Conexao = FabricadeConexao.GetConexao()

            Dim Dao As New DAO_Estado(Conexao)
            ComboEstado.DataSource = Dao.ListAll
            ComboEstado.DisplayMember = "Nome"

        Catch ex As Exception
            MessageBox.Show("Erro no acesso BD: " & ex.Message)

        Finally
            FabricadeConexao.FechaConexao(Conexao)

        End Try


    End Sub
    Private Sub Popula_Cidade_De_Estado()
        Dim Cidades As ClassCidade = ComboCidade.SelectedItem
        ComboCidade.DataSource = ListCidades(Cidades.Coidgo_Cidade)
        ComboCidade.DisplayMember = "Estado"
    End Sub

    Private Function ListCidades(ByVal codigo As Integer) As List(Of ClassCidade)
        Dim CidadesLocais As New List(Of ClassCidade)

        Dim Conexao As SqlConnection = Nothing

        Try

            Conexao = FabricadeConexao.GetConexao()

            Dim Dao As New DAO_Cidade(Conexao)

            For Each C As ClassCidade In Dao.ListAll
                If C.Estado.Codigo_Estado = codigo Then
                    CidadesLocais.Add(C)

                End If

            Next


        Catch ex As Exception

            MessageBox.Show("Erro no acesso BD: " & ex.Message)

        Finally
            FabricadeConexao.FechaConexao(Conexao)

        End Try

        Return CidadesLocais
    End Function

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
End Class