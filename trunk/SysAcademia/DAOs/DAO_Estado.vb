Imports System.Data.SqlClient


' DAO esta pronto e funcionando, "FAVOR NÃO AUTERAR SEM FALAR COMIGO" Ederson..

Public Class DAO_Estado

    Private Conexao As SqlConnection

    Public Sub New(ByVal conexao As SqlConnection)
        Me.Conexao = conexao
    End Sub
    
    Public Function ListAll() As List(Of ClassEstado)

        Dim Estados As New List(Of ClassEstado)

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
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

End Class
