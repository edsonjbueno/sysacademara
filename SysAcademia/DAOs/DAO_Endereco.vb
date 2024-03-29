﻿Imports System.Data.SqlClient

Public Class DAO_Endereco

    Private Conexao As SqlConnection
    Private Transacao As SqlTransaction

    Public Sub New(ByVal conexao As SqlConnection)
        Me.Conexao = conexao
    End Sub

    Public Sub New(ByVal conexao As SqlConnection, ByVal Transacao As SqlTransaction)
        Me.Conexao = conexao
        Me.Transacao = Transacao
    End Sub

    Public Function Insert(ByVal Obj_Endereco As ClassEndereco) As Integer

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text

        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If

        Comando.CommandText = "insert into Endereco (Rua,Numero,Complemento,Bairro,Codigo_Cidade) values (@Rua,@Numero,@Complemento,@Bairro,@Codigo_Cidade) SELECT SCOPE_IDENTITY()"

        Comando.Parameters.AddWithValue("@Rua", Obj_Endereco.Rua)
        Comando.Parameters.AddWithValue("@Numero", Obj_Endereco.Numero)
        Comando.Parameters.AddWithValue("@Complemento", BdUtil.GetNull(Obj_Endereco.Complemento))
        Comando.Parameters.AddWithValue("@Bairro", Obj_Endereco.Bairro)
        Comando.Parameters.AddWithValue("@Codigo_Cidade", Obj_Endereco.Busca_Cidade_Estado.Codigo_Cidade)

        Dim N As Integer = Comando.ExecuteScalar()

        Obj_Endereco.Codigo_Endereco = N

        Return N

    End Function


    Public Function ListALL() As List(Of ClassEndereco)

        Dim Enderecos As New List(Of ClassEndereco)

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If

        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If

        Comando.CommandText = "select * from Endereco"

        Dim Reader As SqlDataReader = Comando.ExecuteReader


        While Reader.Read
            Dim Obj_Endereco As New ClassEndereco
            Obj_Endereco.Codigo_Endereco = Reader("Codigo_Endereco")
            Obj_Endereco.Rua = Reader("Rua")
            Obj_Endereco.Numero = Reader("Numero")
            Obj_Endereco.Complemento = Reader("Complemento")
            Obj_Endereco.Bairro = Reader("Bairro")
            Obj_Endereco.Busca_Cidade_Estado.Estado.Codigo_Estado = Reader("Codigo_Estado")
            Obj_Endereco.Busca_Cidade_Estado.Codigo_Cidade = Reader("Codigo_Cidade")

            Enderecos.Add(Obj_Endereco)

        End While


        If Reader IsNot Nothing AndAlso Not Reader.IsClosed Then
            Reader.Close()

        End If

        Return Enderecos

    End Function

    Public Function GetById(ByVal codigo As Integer) As ClassEndereco


        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = ("select * from Endereco where Codigo_Endereco = @Codigo_Endereco")
        Comando.Parameters.AddWithValue("@Codigo_Endereco", codigo)


        Dim Obj_Endereco As ClassEndereco = Nothing
        Dim Cursor As SqlDataReader = Comando.ExecuteReader
        Dim Dao_Cidade As New DAO_Cidade(Conexao, Transacao)


        If Cursor.Read Then

            Obj_Endereco = New ClassEndereco
            Obj_Endereco.Codigo_Endereco = Cursor("Codigo_Endereco")
            Obj_Endereco.Rua = Cursor("Rua")
            Obj_Endereco.Numero = Cursor("Numero")
            Obj_Endereco.Complemento = Cursor("Complemento")
            Obj_Endereco.Bairro = Cursor("Bairro")
            'Obj_Endereco.Busca_Cidade_Estado.Codigo_Cidade = Cursor("Codigo_Cidade")
            Obj_Endereco.Busca_Cidade_Estado = Dao_Cidade.GetById(Cursor("Codigo_Cidade"))



        End If

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then

            Cursor.Close()

        End If

        Return Obj_Endereco


    End Function
End Class





