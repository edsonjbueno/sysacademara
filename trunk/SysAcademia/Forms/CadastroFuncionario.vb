﻿Imports System.Data.SqlClient

Public Class CadastroFuncionario

    Private Sub BtnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalvar.Click

        Dim Conexao As SqlConnection = Nothing


        Try
            Conexao = FabricadeConexao.GetConexao()

            Dim ObjFuncionario As ClassFuncionario = GetDadosFuncionario()
            Dim Dao As New DAO_Funcionario(Conexao)

            Dim N As Integer = Dao.Insert(ObjFuncionario)

            MessageBox.Show("OK! " & N)

        Catch ex As Exception
            MessageBox.Show("Erro ao acessar o banco de dados." & ex.Message)
        End Try
        FabricadeConexao.FechaConexao(Conexao)

    End Sub

    Private Function GetDadosFuncionario() As ClassFuncionario

        Dim ObjFuncionario As New ClassFuncionario

        ObjFuncionario.Matricula_Funcionario = TxtMatricula.Text
        ObjFuncionario.Nome = TxtNome.Text
        ObjFuncionario.Cpf = MaskCPF.Text
        ObjFuncionario.Data_Nasc = MaskDataNasc.Text
        ObjFuncionario.Rg = MaskRG.Text
        ObjFuncionario.Salario = txtSalario.Text
        ObjFuncionario.Sexo = ComboSexo.SelectedItem.ToString()
        ObjFuncionario.SituacaoFuncionario.Codigo_SituacaoFuncionario = ComboSituacao.SelectedValue
        'ObjFuncionario.Telefone.Numero = MaskedTelefone.Text
        'ObjFuncionario.Telefone.Tipo = ComboTipoTelefone.SelectedItem
        ObjFuncionario.Codigo_TipoFuncionario.Codigo_TipoFuncionario = ComboTipoFunc.SelectedValue

        'Endereco
        'ObjFuncionario.Codigo_Endereco.Busca_Cidade_Estado.Estado.Nome = ComboEstado.SelectedItem
        'ObjFuncionario.Codigo_Endereco.Busca_Cidade_Estado.Nome = ComboCidade.SelectedItem

        Return ObjFuncionario

    End Function


    Public Sub PopulaSituacao()

        Dim Conexao As SqlConnection = Nothing
        Try

            Conexao = FabricadeConexao.GetConexao()

            Dim Dao As New DAO_SituacaoFuncionario(Conexao)

            ComboSituacao.DataSource = Dao.ListAll
            ComboSituacao.DisplayMember = "Descricao"
            ComboSituacao.ValueMember = "Codigo_SituacaoFuncionario"

        Catch ex As Exception
            MessageBox.Show("Erro no acesso BD: " & ex.Message)

        Finally
            FabricadeConexao.FechaConexao(Conexao)

        End Try

    End Sub

    Private Sub Popula_ComboTipoFunc()

        Dim Conexao As SqlConnection = Nothing

        Try

            Conexao = FabricadeConexao.GetConexao()

            Dim Dao As New DAO_TipoFunc(Conexao)
            ComboTipoFunc.DataSource = Dao.ListAll
            ComboTipoFunc.DisplayMember = "Descricao"
            ComboTipoFunc.ValueMember = "Codigo_TipoFuncionario"

        Catch ex As Exception
            MessageBox.Show("Erro no acesso BD: " & ex.Message)

        Finally
            FabricadeConexao.FechaConexao(Conexao)

        End Try

    End Sub

    Public Sub PopulaEstado()

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

    Private Sub PopulaCidades()

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


    Private Sub Popula_ComboSexo()
        ComboSexo.DataSource = GetType(ClassSexo).GetEnumValues
    End Sub

    Private Sub CadastroFuncionario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulaSituacao()
        Popula_ComboSexo()
        Popula_ComboTipoFunc()
        PopulaEstado()
        PopulaCidades()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CadTipFunc.Show()
    End Sub

    Private Sub BtnCad_Nov_Cid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCad_Nov_Cid.Click
        Cadastro_Nova_Cidade.ShowDialog()
    End Sub

    Private Sub ComboEstado_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboEstado.SelectionChangeCommitted
        PopulaCidades()
    End Sub
End Class