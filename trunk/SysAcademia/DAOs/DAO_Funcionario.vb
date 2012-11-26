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
        Comando.Parameters.AddWithValue("@Data_Nasc", BdUtil.GetNull(ObjFuncionario.Data_Nasc))
        Comando.Parameters.AddWithValue("@Sexo", BdUtil.GetNull(ObjFuncionario.Sexo))
        Comando.Parameters.AddWithValue("@Cpf", BdUtil.GetNull(ObjFuncionario.Cpf))
        Comando.Parameters.AddWithValue("@Rg", BdUtil.GetNull(ObjFuncionario.Rg))
        Comando.Parameters.AddWithValue("@Salario", BdUtil.GetNull(ObjFuncionario.Salario))
        Comando.Parameters.AddWithValue("@Codigo_TipoFuncionario", BdUtil.GetNull(ObjFuncionario.Codigo_TipoFuncionario.Codigo_TipoFuncionario))
        Comando.Parameters.AddWithValue("@Codigo_Status", BdUtil.GetNull(ObjFuncionario.SituacaoFuncionario.Codigo_SituacaoFuncionario))
        Comando.Parameters.AddWithValue("@Codigo_Endereco", BdUtil.GetNull(ObjFuncionario.Codigo_Endereco.Codigo_Endereco))

        Return Comando.ExecuteNonQuery()

    End Function

    Public Function ListAll() As List(Of ClassFuncionario)

        Dim Funcionarios As New List(Of ClassFuncionario)
        Dim Comando As New SqlCommand()
        Comando.Connection = Conexao

        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        Comando.CommandText = "select * from Funcionario order by Matricula_Funcionario"

        Dim Cursor As SqlDataReader = Comando.ExecuteReader()


        While Cursor.Read()
            Dim ObjFuncionario As New ClassFuncionario()
            ObjFuncionario.Matricula_Funcionario = Cursor("Matricula_Funcionario")
            ObjFuncionario.Nome = Cursor("Nome")
            ObjFuncionario.Sexo = BdUtil.SetNull(Cursor("Sexo"))
            ObjFuncionario.Salario = BdUtil.SetNull(Cursor("Salario"))
            ObjFuncionario.Rg = BdUtil.SetNull(Cursor("Rg"))
            ObjFuncionario.Data_Nasc = BdUtil.SetNull(Cursor("Data_Nasc"))
            ObjFuncionario.Cpf = BdUtil.SetNull(Cursor("Cpf"))

            Funcionarios.Add(ObjFuncionario)

        End While

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then
            Cursor.Close()
        End If

        Return Funcionarios

    End Function

End Class
