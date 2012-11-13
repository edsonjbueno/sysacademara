Imports System.Data.SqlClient

Public Class Cadastro_Tipo_Mensalidade

    Private Function DadosTipo_Mensalidade() As ClassTipo_De_Mensalidade
        Dim Obj_TipoM As New ClassTipo_De_Mensalidade
        Obj_TipoM.Descricao = TxtTipo_Mensalidade.Text

        Return Obj_TipoM
    End Function

    Private Sub Cadastro_Tipo_Mensalidade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalvar.Click

        Dim Conexao As SqlConnection = Nothing

        Try
            Conexao = FabricadeConexao.GetConexao

            Dim Obj_TipoM As ClassTipo_De_Mensalidade = DadosTipo_Mensalidade()
            Dim Dao As New DAO_Tipo_De_Mensalidade(Conexao)
            Dim N As Integer = Dao.Insert(Obj_TipoM)
            MessageBox.Show("Dados inseridos com Sucesso !!!")


        Catch ex As Exception
            MessageBox.Show("ERRO no acesso BD:" & ex.Message)


        Finally
            FabricadeConexao.FechaConexao(Conexao)

        End Try

    End Sub
End Class