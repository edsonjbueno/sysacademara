﻿Imports System.Data.SqlClient


Public Class DAO_Funcionario

    Private Conexao As SqlConnection

    Public Sub New(ByVal Conexao As SqlConnection)
        Me.Conexao = Conexao
    End Sub

    Public Function Insert(ByVal ObjFuncionario As ClassFuncionario) As Integer

        Dim Comando As New SqlCommand

        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        Comando.CommandText = "INSERT INTO Funcionario (Matricula_Funcionario,Nome,Data_Nasc,Sexo,Cpf,Rg,Salario,Codigo_TipoFuncionario,Codigo_Status) VALUES (@Matricula_Funcionario,@Nome,@Data_Nasc,@Sexo,@Cpf,@Rg,@Salario,@Codigo_TipoFuncionario,@Codigo_Status)"

        Comando.Parameters.AddWithValue("@Matricula_Funcionario", ObjFuncionario.Matricula_Funcionario)
        Comando.Parameters.AddWithValue("@Nome", ObjFuncionario.Nome)
        Comando.Parameters.AddWithValue("@Data_Nasc", BbUtil.GetNull(ObjFuncionario.Data_Nasc))
        Comando.Parameters.AddWithValue("@Sexo", BbUtil.GetNull(ObjFuncionario.Sexo))
        Comando.Parameters.AddWithValue("@Cpf", BbUtil.GetNull(ObjFuncionario.Cpf))
        Comando.Parameters.AddWithValue("@Rg", BbUtil.GetNull(ObjFuncionario.Rg))
        Comando.Parameters.AddWithValue("@Salario", BbUtil.GetNull(ObjFuncionario.Salario))
        Comando.Parameters.AddWithValue("@Codigo_TipoFuncionario", BbUtil.GetNull(ObjFuncionario.Codigo_TipoFuncionario.Codigo_TipoFuncionario))
        Comando.Parameters.AddWithValue("@Codigo_Status", BbUtil.GetNull(ObjFuncionario.SituacaoFuncionario.Codigo_SituacaoFuncionario))
        'Comando.Parameters.AddWithValue("@Codigo_Endereco", BbUtil.GetNull(ObjFuncionario.Codigo_Endereco.Codigo_Endereco))

        Return Comando.ExecuteNonQuery()

    End Function

End Class