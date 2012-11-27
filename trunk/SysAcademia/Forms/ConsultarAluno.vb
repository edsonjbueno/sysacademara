Imports System.Data.SqlClient

Public Class ConsultarAluno

    Public Sub Popula_Grid()

        Dim Conexao As SqlConnection = Nothing


        Try
            Conexao = FabricadeConexao.GetConexao
            Dim Dao_Aluno As New DAO_Aluno(Conexao)
            ClassAlunoBindingSource.DataSource = Dao_Aluno.ListAll

            'For Each item As String In collectionObject

            'Next

            DGConsulta.Columns(0).Width = 100
            DGConsulta.Columns(1).Width = 300
            DGConsulta.Columns(2).Width = 100
            DGConsulta.Columns(3).Width = 100
            DGConsulta.Columns(4).Width = 100
            DGConsulta.Columns(5).Width = 100
            DGConsulta.Columns(6).Width = 700

        Catch ex As Exception
            MessageBox.Show("Erro ao acessar o banco de dados." & ex.Message)
        End Try

        FabricadeConexao.FechaConexao(Conexao)

    End Sub

    Private Sub ConsultarAluno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Popula_Grid()

    End Sub

    Private Sub BtnApgar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnApgar.Click

        Dim Conexao As SqlConnection = Nothing
        Dim Transacao As SqlTransaction = Nothing

        Try


            If MessageBox.Show("Desjea Apagar esse Contato ? ", "verificação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then


                Conexao = FabricadeConexao.GetConexao
                Transacao = Conexao.BeginTransaction()

                Dim Obj_AlunoSelect As ClassAluno = ClassAlunoBindingSource.Current

                'Chama DaoTelefone
                Dim DaoTel As New DAO_Telefone(Conexao, Transacao)

                For Each item As ClassTelefone In Obj_AlunoSelect.Lista_Telefone
                    DaoTel.Delete(item)

                Next


                'Chama Aluno
                Dim Dao_Aluno As New DAO_Aluno(Conexao, Transacao)
                Dao_Aluno.Delete(Obj_AlunoSelect)


                ClassAlunoBindingSource.DataSource = Nothing
                ClassAlunoBindingSource.DataSource = Dao_Aluno.ListAll

            End If

            Transacao.Commit()

            MessageBox.Show("Dados Apagados com Sucesso ! ")


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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCadastro_Aluno.Click

        CadastroAluno.ShowDialog()

    End Sub

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click

    End Sub
End Class