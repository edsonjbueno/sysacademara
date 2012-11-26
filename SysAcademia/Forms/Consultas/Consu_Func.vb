Imports System.Data.SqlClient


Public Class Consu_Func

    Private Sub BtnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnListar.Click

        Dim Conexao As SqlConnection = Nothing


        Try
            Conexao = FabricadeConexao.GetConexao()
            Dim Dao As New DAO_Funcionario(Conexao)
            ClassFuncionarioBindingSource.DataSource = Dao.ListAll

        Catch ex As Exception
            MessageBox.Show("Erro ao acessar o banco de dados." & ex.Message)
        End Try

        FabricadeConexao.FechaConexao(Conexao)


    End Sub

    Private Sub Consu_Func_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub


    Sub Pesquisar()

        Dim Conexao As SqlConnection = Nothing


        Try
            Conexao = FabricadeConexao.GetConexao()
            Dim Dao As New DAO_Funcionario(Conexao)
            ClassFuncionarioBindingSource.DataSource = Dao.ListAll


        Catch ex As Exception
            MessageBox.Show("Erro ao acessar o banco de dados." & ex.Message)
        End Try

        FabricadeConexao.FechaConexao(Conexao)


    End Sub
End Class