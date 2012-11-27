Imports System.Data.SqlClient

Public Class DAO_TipoMensalidade

    Private Conexao As SqlConnection
    Private Transacao As SqlTransaction


    Public Sub New(ByVal conexao As SqlConnection)
        Me.Conexao = conexao
    End Sub

    Public Sub New(ByVal conexao As SqlConnection, ByVal Transacao As SqlTransaction)

        Me.Conexao = conexao
        Me.Transacao = Transacao

    End Sub

    Public Function InsertTipo_Mensalidade(ByVal Obj_Mensalidade As ClassTipo_Mensalidade) As Integer

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = "insert into Tipo_Mensalidade (Descricao) values (@Descricao)"

        Comando.Parameters.AddWithValue("@Descricao", Obj_Mensalidade.Descricao)

        Return Comando.ExecuteNonQuery

    End Function

    Public Function ListAll() As List(Of ClassTipo_Mensalidade)

        Dim Tipo_Mensalidades As New List(Of ClassTipo_Mensalidade)

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = "select * from Tipo_Mensalidade"

        Dim Read As SqlDataReader = Comando.ExecuteReader


        While Read.Read()
            Dim Obj_Tipo_Mensalidade As New ClassTipo_Mensalidade
            Obj_Tipo_Mensalidade.Codigo_Tipo = Read("Codigo_Tipo")
            Obj_Tipo_Mensalidade.Descricao = Read("Descricao")
            Tipo_Mensalidades.Add(Obj_Tipo_Mensalidade)
        End While


        If Read IsNot Nothing AndAlso Not Read.IsClosed Then
            Read.Close()

        End If


        Return Tipo_Mensalidades

    End Function

    Public Function Atualizar(ByVal Obj_TipoTelefone As ClassTipoTelefone) As Integer


        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = ("update Tipo_Telefone set Descricao = @Descricao where Codigo_TipoTelefone = @Codigo_TipoTelefone")

        Comando.Parameters.AddWithValue("@Codigo_TipoTelefone", Obj_TipoTelefone)
        Comando.Parameters.AddWithValue("@Descricao", Obj_TipoTelefone.ToString)
        
        Dim Exe As Integer = Comando.ExecuteNonQuery
        Return Exe

    End Function
End Class
