Imports System.Data.SqlClient

Public Class DAO_SituacaoAluno

    Private Conexao As SqlConnection
    Private Transacao As SqlTransaction


    Public Sub New(ByVal Conexao As SqlConnection)
        Me.Conexao = Conexao
    End Sub

    Public Sub New(ByVal conexao As SqlConnection, ByVal Transacao As SqlTransaction)

        Me.Conexao = conexao
        Me.Transacao = Transacao

    End Sub


    Public Function ListAll() As List(Of ClassSituacao_Aluno)

        Dim AlunoSituacao As New List(Of ClassSituacao_Aluno)

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = ("select * from Situacao_Aluno")

        Dim Cursor As SqlDataReader = Comando.ExecuteReader()

        While Cursor.Read()

            Dim Obj_SituacaoAluno As New ClassSituacao_Aluno()
            Obj_SituacaoAluno.Codigo_Situacao = Cursor("Codigo_Situacao")
            Obj_SituacaoAluno.Descricao = Cursor("Descricao")
            AlunoSituacao.Add(Obj_SituacaoAluno)

        End While

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then
            Cursor.Close()
        End If

        Return AlunoSituacao

    End Function

    Public Function GetById(ByVal codigo As Integer) As ClassSituacao_Aluno


        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = ("select * from Situacao_Aluno where Codigo_Situacao = @Codigo_Situacao")
        Comando.Parameters.AddWithValue("@Codigo_Situacao", codigo)


        Dim Obj_Situacao As ClassSituacao_Aluno = Nothing
        Dim Cursor As SqlDataReader = Comando.ExecuteReader

        If Cursor.Read Then

            Obj_Situacao = New ClassSituacao_Aluno
            Obj_Situacao.Codigo_Situacao = Cursor("Codigo_Situacao")
            Obj_Situacao.Descricao = Cursor("Descricao")

        End If

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then

            Cursor.Close()

        End If

        Return Obj_Situacao


    End Function

    Public Function Atualizar(ByVal Obj_SituacaoAluno As ClassSituacao_Aluno) As Integer


        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = ("update Situacao_Aluno set Descricao = @Descricao where Codigo_Situacao = @Codigo_Situacao")

        Comando.Parameters.AddWithValue("@Codigo_Situacao", Obj_SituacaoAluno.Codigo_Situacao)
        Comando.Parameters.AddWithValue("@Descricao", Obj_SituacaoAluno.Descricao)

        Dim Exe As Integer = Comando.ExecuteNonQuery
        Return Exe

    End Function

End Class
