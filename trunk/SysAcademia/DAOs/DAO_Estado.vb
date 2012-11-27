Imports System.Data.SqlClient


' DAO esta pronto e funcionando, "FAVOR NÃO AUTERAR SEM FALAR COMIGO" Ederson..

Public Class DAO_Estado

    Private Conexao As SqlConnection
    Private Transacao As SqlTransaction

    Public Sub New(ByVal conexao As SqlConnection)
        Me.Conexao = conexao
    End Sub
    
    Public Sub New(ByVal conexao As SqlConnection, ByVal Transacao As SqlTransaction)

        Me.Conexao = conexao
        Me.Transacao = Transacao

    End Sub

    Public Function ListAll() As List(Of ClassEstado)

        Dim Estados As New List(Of ClassEstado)

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = "select * from Estado"

        Dim Cursor As SqlDataReader = Comando.ExecuteReader
        While Cursor.Read
            Dim Obj_Estado As New ClassEstado
            Obj_Estado.Codigo_Estado = Cursor("Codigo_Estado")
            Obj_Estado.Nome = Cursor("Nome")
            Estados.Add(Obj_Estado)
        End While

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then
            Cursor.Close()
        End If

        Return Estados

    End Function

    Public Function Update(ByVal Obj_Estado As ClassEstado) As Integer

        Dim Estados As New List(Of ClassEstado)
        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = ("update Estado set Nome = @Nome where Codigo_Estado = @Codigo_Estado")

        Comando.Parameters.AddWithValue("@Codigo_Estado", Obj_Estado.Codigo_Estado)
        Comando.Parameters.AddWithValue("@Nome", Obj_Estado.Nome)

        Dim Exe As Integer = Comando.ExecuteNonQuery
        Return Exe

    End Function

End Class
