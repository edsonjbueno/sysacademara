Imports System.Data.SqlClient

Public Class Cadastro_Nova_Cidade

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
    Private Function GetDadosCidade() As ClassCidade

        Dim ObjCidade As New ClassCidade
        ObjCidade.Estado.Codigo_Estado = ComboEstado.SelectedValue
        ObjCidade.Nome = TxtCidade.Text

        Return ObjCidade

    End Function

    Private Sub BtnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalvar.Click

        Dim Conexao As SqlConnection = Nothing

        Try

            Conexao = FabricadeConexao.GetConexao

            Dim Cidade As ClassCidade = GetDadosCidade()
            Dim Dao As New DAO_Cidade(Conexao)
            Dim N As Integer = Dao.Insert(Cidade)
            MessageBox.Show("Dados inseridos com sucesso !!!")

        Catch ex As Exception
            MessageBox.Show("Erro no acesso BD: " & ex.Message)

        Finally
            FabricadeConexao.FechaConexao(Conexao)

        End Try
    End Sub

    Private Sub Cadastro_Nova_Cidade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulaEstado()

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Close()

    End Sub
End Class