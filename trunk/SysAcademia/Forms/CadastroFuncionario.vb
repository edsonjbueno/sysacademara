Imports System.Data.SqlClient

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


        Return ObjFuncionario

    End Function

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click

    End Sub
End Class