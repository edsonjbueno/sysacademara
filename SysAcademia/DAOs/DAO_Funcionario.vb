Imports System.Data.SqlClient


Public Class DAO_Funcionario

    Private Conexao As SqlConnection
    Private Transacao As SqlTransaction

    Public Sub New(ByVal conexao As SqlConnection)
        Me.Conexao = conexao
    End Sub

    Public Sub New(ByVal conexao As SqlConnection, ByVal Transacao As SqlTransaction)
        Me.Conexao = conexao
        Me.Transacao = Transacao
    End Sub

    Public Function Insert(ByVal ObjFuncionario As ClassFuncionario) As Integer

        'chamar enderecoDAO


        Dim Comando As New SqlCommand

        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = "INSERT INTO Funcionario (Matricula_Funcionario,Nome,Data_Nasc,Sexo,Cpf,Rg,Salario,Codigo_TipoFuncionario,Codigo_Status,Codigo_Endereco) VALUES (@Matricula_Funcionario,@Nome,@Data_Nasc,@Sexo,@Cpf,@Rg,@Salario,@Codigo_TipoFuncionario,@Codigo_Status,@Codigo_Endereco)"

        Comando.Parameters.AddWithValue("@Matricula_Funcionario", ObjFuncionario.Matricula_Funcionario)
        Comando.Parameters.AddWithValue("@Nome", ObjFuncionario.Nome)
        Comando.Parameters.AddWithValue("@Data_Nasc", BbUtil.GetNull(ObjFuncionario.Data_Nasc))
        Comando.Parameters.AddWithValue("@Sexo", BbUtil.GetNull(ObjFuncionario.Sexo))
        Comando.Parameters.AddWithValue("@Cpf", BbUtil.GetNull(ObjFuncionario.Cpf))
        Comando.Parameters.AddWithValue("@Rg", BbUtil.GetNull(ObjFuncionario.Rg))
        Comando.Parameters.AddWithValue("@Salario", BbUtil.GetNull(ObjFuncionario.Salario))
        Comando.Parameters.AddWithValue("@Codigo_TipoFuncionario", BbUtil.GetNull(ObjFuncionario.Codigo_TipoFuncionario.Codigo_TipoFuncionario))
        Comando.Parameters.AddWithValue("@Codigo_Status", BbUtil.GetNull(ObjFuncionario.SituacaoFuncionario.Codigo_SituacaoFuncionario))
        Comando.Parameters.AddWithValue("@Codigo_Endereco", BbUtil.GetNull(ObjFuncionario.Codigo_Endereco.Codigo_Endereco))

        Return Comando.ExecuteNonQuery()

    End Function

    Public Function ListAll() As List(Of ClassFuncionario)

        Dim Funcionarios As New List(Of ClassFuncionario)
        Dim Comando As New SqlCommand()
        Comando.Connection = Conexao

        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        Comando.CommandText = "SELECT Nome, Salario,Telefone FROM Funcionario"

        Dim Cursor As SqlDataReader = Comando.ExecuteReader()


        While Cursor.Read()
            Dim ObjFuncionario As New ClassFuncionario()
            ObjFuncionario.Salario = Cursor("Salario")
            ObjFuncionario.Nome = Cursor("Nome")
            ObjFuncionario.Telefone = Cursor("Data_Nasc")
            ObjFuncionario.SituacaoFuncionario = Cursor("SituacaoFuncionario")

            Funcionarios.Add(ObjFuncionario)

        End While

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then
            Cursor.Close()
        End If

        Return Funcionarios

    End Function

End Class
