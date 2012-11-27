Imports System.Data.SqlClient

Public Class DAO_Aluno

    Private Conexao As SqlConnection
    Private Transacao As SqlTransaction


    Public Sub New(ByVal conexao As SqlConnection)
        Me.Conexao = conexao
    End Sub

    Public Sub New(ByVal conexao As SqlConnection, ByVal Transacao As SqlTransaction)

        Me.Conexao = conexao
        Me.Transacao = Transacao

    End Sub

    Public Function Insert(ByVal Obj_Aluno As ClassAluno) As Integer


        Dim Comando As New SqlCommand

        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text

        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If

        Comando.CommandText = "insert into Aluno (Matricula_Aluno,Nome,Data_Nasc,Sexo,Codigo_Situacao,Codigo_Endereco,Codigo_Mensalidade) values (@Matricula_Aluno,@Nome,@Data_Nasc,@Sexo,@Codigo_Situacao,@Codigo_Endereco,@Codigo_Mensalidade)"

        Comando.Parameters.AddWithValue("@Matricula_Aluno", Obj_Aluno.Matricula_Aluno)
        Comando.Parameters.AddWithValue("@Nome", Obj_Aluno.Nome)
        Comando.Parameters.AddWithValue("@Data_Nasc", BbUtil.GetNull(Obj_Aluno.Data_Nasc))
        Comando.Parameters.AddWithValue("@Sexo", BbUtil.GetNull(Obj_Aluno.Sexo))
        Comando.Parameters.AddWithValue("@Codigo_Situacao", BbUtil.GetNull(Obj_Aluno.Situacao_Aluno.Codigo_Situacao))
        Comando.Parameters.AddWithValue("@Codigo_Endereco", BbUtil.GetNull(Obj_Aluno.Endereco.Codigo_Endereco))
        Comando.Parameters.AddWithValue("@Codigo_Mensalidade", BbUtil.GetNull(Obj_Aluno.Mensalidade.Codigo_Mensalidade))

        Return Comando.ExecuteNonQuery()

    End Function

    Public Function Delete(ByVal Obj_Aluno As ClassAluno) As Integer

        'Dim Alunos As New List(Of ClassAluno)

        Dim Comando As New SqlCommand

        Comando.Connection = Conexao
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If


        Comando.CommandType = CommandType.Text
        Comando.CommandText = ("delete from Aluno where Matricula_Aluno = @Matricula_Aluno")
        Comando.Parameters.AddWithValue("@Matricula_Aluno", Obj_Aluno.Matricula_Aluno)

        Return Comando.ExecuteNonQuery

    End Function

    Public Function GetById(ByVal codigo As Integer) As ClassAluno


        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = ("select * from Aluno where Matricula_Aluno = @Matricula_Aluno")
        Comando.Parameters.AddWithValue("@Matricula_Aluno", codigo)


        Dim Obj_Aluno As ClassAluno = Nothing
        Dim Cursor As SqlDataReader = Comando.ExecuteReader

        If Cursor.Read Then

            Obj_Aluno = New ClassAluno
            Obj_Aluno.Matricula_Aluno = Cursor("Matricula_Aluno")
            Obj_Aluno.Nome = Cursor("Nome")
            Obj_Aluno.Data_Nasc = Cursor("Data_Nasc")
            Obj_Aluno.Sexo = Cursor("Sexo")
            Obj_Aluno.Situacao_Aluno.Codigo_Situacao = Cursor("Codigo_Situacao")
            Obj_Aluno.Endereco.Codigo_Endereco = Cursor("Codigo_Endereco")
            Obj_Aluno.Lista_Telefone = Cursor("Codigo_Telefone")

        End If

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then

            Cursor.Close()

        End If

        Return Obj_Aluno


    End Function

    Public Function ListAll() As List(Of ClassAluno)

        Dim Alunos As New List(Of ClassAluno)
        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If

        Comando.CommandType = CommandType.Text
        Comando.CommandText = ("select * from Aluno")

        Dim Cursor As SqlDataReader = Comando.ExecuteReader

        Dim DaoEnd As New DAO_Endereco(Conexao, Transacao)
        Dim DaoMens As New DAO_Mensalidade(Conexao, Transacao)
        Dim DaoSit As New DAO_SituacaoAluno(Conexao, Transacao)
        Dim DaoTel As New DAO_Telefone(Conexao, Transacao)

        While Cursor.Read

            Dim ObjAluno As New ClassAluno
            ObjAluno.Matricula_Aluno = Cursor("Matricula_Aluno")
            ObjAluno.Nome = Cursor("Nome")
            ObjAluno.Data_Nasc = Cursor("Data_Nasc")
            ObjAluno.Sexo = Cursor("Sexo")
            ObjAluno.Situacao_Aluno = DaoSit.GetById(Cursor("Codigo_Situacao"))
            ObjAluno.Mensalidade = DaoMens.GetById(Cursor("Codigo_Mensalidade"))
            ObjAluno.Endereco = DaoEnd.GetById(Cursor("Codigo_Endereco"))
            ObjAluno.Lista_Telefone = DaoTel.ListAll_By_MatriculaAluno(ObjAluno.Matricula_Aluno) 'Falta implementar

            Alunos.Add(ObjAluno)

        End While

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then

            Cursor.Close()

        End If

        Return Alunos

    End Function
    Public Function Atualizar(ByVal Obj As ClassAluno) As Integer

        Dim Alunos As New List(Of ClassAluno)
        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = ("update Aluno set Nome = @Nome, Data_Nasc = @Data_Nasc, Sexo = @Sexo, Codigo_Situacao = @Codigo_Situacao, Codigo_Endereco = @Codigo_Endereco, Codigo_Mensalidade = @Codigo_Mensalidade where Matricula_Aluno = @Matricula_Aluno")

        Comando.Parameters.AddWithValue("@Matricula_Aluno", Obj.Matricula_Aluno)
        Comando.Parameters.AddWithValue("@Nome", Obj.Nome)
        Comando.Parameters.AddWithValue("@Data_Nasc", Obj.Data_Nasc)
        Comando.Parameters.AddWithValue("@Sexo", Obj.Sexo)
        Comando.Parameters.AddWithValue("@Codigo_Situacao", Obj.Situacao_Aluno.Codigo_Situacao)
        Comando.Parameters.AddWithValue("@Codigo_Endereco", Obj.Endereco.Codigo_Endereco)
        Comando.Parameters.AddWithValue("@Codigo_Mensalidade", Obj.Mensalidade.Codigo_Mensalidade)


        Dim Exe As Integer = Comando.ExecuteNonQuery
        Return Exe

    End Function


End Class
