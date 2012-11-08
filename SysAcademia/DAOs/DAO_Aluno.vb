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

        Comando.Parameters.AddWithValue("@Matricula_Aluno", Obj_Aluno.Matricula_Aluno)
        Comando.Parameters.AddWithValue("@Nome", Obj_Aluno.Nome)
        Comando.Parameters.AddWithValue("@Data_Nasc", Obj_Aluno.Data_Nasc)
        Comando.Parameters.AddWithValue("@Sexo", Obj_Aluno.Sexo)
        Comando.Parameters.AddWithValue("@Mensalidade", Obj_Aluno.Mensalidade.ToString)
        Comando.Parameters.AddWithValue("@Situacao_Aluno", Obj_Aluno.Situacao_Aluno)
        Comando.Parameters.AddWithValue("@Telefone", Obj_Aluno.Telefone.ToString)
        Comando.Parameters.AddWithValue("@Endereco", Obj_Aluno.Endereco.ToString)

        Dim EXE As Integer
        EXE = Comando.ExecuteNonQuery()

        Return EXE
    End Function

    'Public Function Delete(ByVal Obj_Aluno As ClassAluno) As Integer

    '    Dim Alunos As New List(Of ClassAluno)
    '    Dim Comando As New SqlCommand
    '    Comando.Connection = Conexao
    '    Comando.CommandType = CommandType.Text
    '    Comando.CommandText = ("delete from ClassAluno where Matricula_Aluno = @Matricula_Aluno")
    '    Comando.Parameters.AddWithValue("@Matricula_Aluno", Obj_Aluno.Matricula_Aluno)


    '    Dim Exe As Integer = Comando.ExecuteNonQuery
    '    Return Exe

    'End Function
    'Public Function GetById(ByVal codigo As Integer) As ClassAluno


    '    Dim Comando As New SqlCommand
    '    Comando.Connection = Conexao
    '    Comando.CommandType = CommandType.Text
    '    Comando.CommandText = ("select * from Aluno where Matricula_Aluno = @Matricula_Aluno")
    '    Comando.Parameters.AddWithValue("@Matricula_Aluno", codigo)


    '    Dim Obj_Aluno As ClassAluno = Nothing
    '    Dim Cursor As SqlDataReader = Comando.ExecuteReader
    '    If Cursor.Read Then
    '        Obj_Aluno = New ClassAluno
    '        Obj_Aluno.Matricula_Aluno = Cursor("Matricula_Aluno")
    '        Obj_Aluno.Nome = Cursor("Nome")
    '        Obj_Aluno.Data_Nasc = Cursor("Data_Nasc")
    '        Obj_Aluno.Sexo = Cursor("Sexo")
    '        Obj_Aluno.Situacao_Aluno = Cursor("Situacao_Aluno")
    '        Obj_Aluno.Endereco.Rua = Cursor("Endereco")
    '        Obj_Aluno.Endereco.Numero = Cursor("Endereco")
    '        Obj_Aluno.Endereco.Bairro = Cursor("Endereco")
    '        Obj_Aluno.Endereco.Complemento = Cursor("Endereco")
    '        Obj_Aluno.Endereco.Cidade.Nome = Cursor("Endereco")
    '        Obj_Aluno.Endereco.Cidade.Estado = Cursor("Endereco")
    '        Obj_Aluno.Telefone.Numero = Cursor("Telefone")
    '        Obj_Aluno.Telefone.Tipo = Cursor("Telefone")
    '    End If

    '    If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then
    '        Cursor.Close()
    '    End If

    '    Return Obj_Aluno


    'End Function
    'Public Function ListAll() As List(Of ClassAluno)

    '    Dim Alunos As New List(Of ClassAluno)
    '    Dim Comando As New SqlCommand
    '    Comando.Connection = Conexao
    '    Comando.CommandType = CommandType.Text
    '    Comando.CommandText = ("select * from ClassAluno order by Matricula_Aluno")

    '    Dim Cursor As SqlDataReader = Comando.ExecuteReader
    '    While Cursor.Read
    '        Dim ObjAluno As New ClassAluno
    '        ObjAluno.Matricula_Aluno = Cursor("Matricula_Aluno")
    '        ObjAluno.Nome = Cursor("Nome")
    '        ObjAluno.Data_Nasc = Cursor("Data_Nasc")
    '        ObjAluno.Sexo = Cursor("Sexo")
    '        ObjAluno.Telefone.Numero = Cursor("Telefone")
    '        ObjAluno.Telefone.Tipo = Cursor("Telefone")
    '        ObjAluno.Situacao_Aluno = Cursor("Situacao_Aluno")
    '        ObjAluno.Mensalidade.Data_Pagamento = Cursor("Mensalidade")
    '        ObjAluno.Mensalidade.Valor = Cursor("Mensalidade")
    '        ObjAluno.Endereco.Rua = Cursor("Endereco")
    '        ObjAluno.Endereco.Numero = Cursor("Endereco")
    '        ObjAluno.Endereco.Bairro = Cursor("Endereco")
    '        ObjAluno.Endereco.Complemento = Cursor("Endereco")
    '        ObjAluno.Endereco.Cidade.Nome = Cursor("Endereco")
    '        ObjAluno.Endereco.Cidade.Estado.Nome = Cursor("Endereco")

    '        Alunos.Add(ObjAluno)
    '    End While

    '    If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then
    '        Cursor.Close()
    '    End If

    '    Return Alunos
    'End Function
    'Public Function Atualizar(ByVal Obj As ClassAluno) As Integer

    '    Dim Alunos As New List(Of ClassAluno)
    '    Dim Comando As New SqlCommand
    '    Comando.Connection = Conexao
    '    Comando.CommandType = CommandType.Text
    '    Comando.CommandText = ("update Aluno set Nome = @Nome, Telefone = @Telefone where Id_Cliente = @Id_Cliente")
    '    Comando.Parameters.AddWithValue("@Nome", Obj.Nome)


    '    Dim Exe As Integer = Comando.ExecuteNonQuery
    '    Return Exe

    'End Function


End Class
