Imports System.Data.SqlClient

Public Class DAO_Aluno

    Private Conexao As SqlConnection

    Public Sub New(ByVal conexao As SqlConnection)
        Me.Conexao = conexao
    End Sub

    Public Function Insert(ByVal Obj_Aluno As ClassAluno) As Integer

        Dim Comando As New SqlCommand

        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        Comando.CommandText = "insert into ClassAluno(Matricula_Aluno,Nome,Data_Nasc,Sexo,Mensalidade,Situacao_Aluno,Telefone,Endereco) values (@Matricula_Aluno,@Nome,@Data_Nasc,@Sexo,@Mensalidade,@Situacao_Aluno,@Telefone,@Endereco)"

        Comando.Parameters.AddWithValue("@Matricula_Aluno", Obj_Aluno)
        Comando.Parameters.AddWithValue("@Nome", Obj_Aluno)
        Comando.Parameters.AddWithValue("@Data_Nasc", Obj_Aluno)
        Comando.Parameters.AddWithValue("@Sexo", Obj_Aluno)
        Comando.Parameters.AddWithValue("@Mensalidade", Obj_Aluno)
        Comando.Parameters.AddWithValue("@Situacao_Aluno", Obj_Aluno)
        Comando.Parameters.AddWithValue("@Telefone", Obj_Aluno)
        Comando.Parameters.AddWithValue("@Endereco", Obj_Aluno)

        Dim EXE As Integer
        EXE = Comando.ExecuteNonQuery()

        Return EXE
    End Function

End Class
