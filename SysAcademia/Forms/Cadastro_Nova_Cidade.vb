Imports System.Data.SqlClient

Public Class Cadastro_Nova_Cidade


    Private _Salvar As New ClassEstado
    Public Property Salvar() As ClassEstado
        Get
            Return _Salvar
        End Get
        Set(ByVal value As ClassEstado)
            _Salvar = value
        End Set
    End Property

    Private Sub Cadastro_Nova_Cidade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulaEstado()
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

    Private Function DadosCidade() As ClassCidade

        Dim ObjCidade As New ClassCidade
        ObjCidade.Nome = TxtCidade.Text
        Salvar.ListaCidade.Add(ObjCidade)
        
        Return ObjCidade
    End Function

    Private Sub BtnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalvar.Click
        Dim Conexao As SqlConnection = Nothing

        Try
            Conexao = FabricadeConexao.GetConexao

            Dim Obj As ClassCidade = DadosCidade()

            Dim Dao As New DAO_Cidade(Conexao)
            Dim EXE As Integer = Dao.Insert(Obj)
            MsgBox("Dados inseridos com Sucesso !", MsgBoxStyle.Exclamation, "SUCESSO")

        Catch ex As Exception
            MessageBox.Show("Erro no acesso BD: " & ex.Message)

        Finally
            FabricadeConexao.FechaConexao(Conexao)

        End Try
    End Sub
End Class