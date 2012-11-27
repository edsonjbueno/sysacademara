Imports System.Data.SqlClient

Public Class Cadastro_TipoMensalidade

    Private Function DadosTipo_Mensalidade() As ClassTipo_Mensalidade
        Dim Obj_Tipo As New ClassTipo_Mensalidade
        Obj_Tipo.Descricao = TxtTipo_Mensalidade.Text

        Return Obj_Tipo

    End Function

    Private Sub Cadastro_Tipo_Mensalidade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalvar.Click

        Dim Conexao As SqlConnection = Nothing

        Try
            Conexao = FabricadeConexao.GetConexao

            Dim Obj_TipoM As ClassTipo_Mensalidade = DadosTipo_Mensalidade()
            Dim Dao As New DAO_TipoMensalidade(Conexao)
            Dim N As Integer = Dao.InsertTipo_Mensalidade(Obj_TipoM)

            MessageBox.Show("Dados inseridos com Sucesso !!!")


        Catch ex As Exception
            MessageBox.Show("ERRO no acesso BD:" & ex.Message)


        Finally
            FabricadeConexao.FechaConexao(Conexao)

        End Try

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class