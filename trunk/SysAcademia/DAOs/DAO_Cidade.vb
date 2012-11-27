Imports System.Data.SqlClient


' DAO esta pronto e funcionando, "FAVOR NÃO AUTERAR SEM FALAR COMIGO" Ederson..

Public Class DAO_Cidade

    Private Conexao As SqlConnection
    Private Transacao As SqlTransaction


    Public Sub New(ByVal conexao As SqlConnection)
        Me.Conexao = conexao
    End Sub

    Public Sub New(ByVal conexao As SqlConnection, ByVal Transacao As SqlTransaction)

        Me.Conexao = conexao
        Me.Transacao = Transacao

    End Sub
    Public Function Insert(ByVal Obj_Cidade As ClassCidade) As Integer


        Dim Comando As New SqlCommand()
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = "insert into Cidade(Nome,Codigo_Estado) values (@Nome,@Codigo_Estado)"


        Comando.Parameters.AddWithValue("@Nome", Obj_Cidade.Nome)
        Comando.Parameters.AddWithValue("@Codigo_Estado", Obj_Cidade.Estado.Codigo_Estado)

        Return Comando.ExecuteNonQuery

    End Function
    Public Function ListAll() As List(Of ClassCidade)

        Dim Cidades As New List(Of ClassCidade)

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If

        Comando.CommandText = ("select * from Cidade")

        Dim Cursor As SqlDataReader = Comando.ExecuteReader
        While Cursor.Read
            Dim Obj_Cidade As New ClassCidade
            Obj_Cidade.Codigo_Cidade = Cursor("Codigo_Cidade")
            Obj_Cidade.Nome = Cursor("Nome")
            Obj_Cidade.Estado.Codigo_Estado = Cursor("Codigo_Estado")
            Cidades.Add(Obj_Cidade)
        End While

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then
            Cursor.Close()
        End If

        Return Cidades

    End Function
    Public Function ListByCodigoEstado(ByVal Codigo_Estado As Integer) As List(Of ClassCidade)

        Dim Cidades As New List(Of ClassCidade)

        Dim Comando As New SqlCommand()
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = "Select * from Cidade where Codigo_Estado = @Codigo_Estado"
        Comando.Parameters.AddWithValue("@Codigo_Estado", Codigo_Estado)

        Dim Cursor As SqlDataReader = Comando.ExecuteReader()

        While Cursor.Read()
            Dim Obj_Cidade As New ClassCidade
            Obj_Cidade.Codigo_Cidade = Cursor("Codigo_Cidade")
            Obj_Cidade.Nome = Cursor("Nome")
            Obj_Cidade.Estado.Codigo_Estado = Cursor("Codigo_Estado")
            Cidades.Add(Obj_Cidade)
        End While

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then
            Cursor.Close()

        End If

        Return Cidades

    End Function

    Public Function GetById(ByVal Codigo_Cidade As Integer) As ClassCidade

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = ("select * from Cidade where Codigo_Cidade = @Codigo_Cidade")
        Comando.Parameters.AddWithValue("@Codigo_Cidade", Codigo_Cidade)


        Dim Obj_Cidade As ClassCidade = Nothing
        Dim Cursor As SqlDataReader = Comando.ExecuteReader

        If Cursor.Read Then
            Obj_Cidade = New ClassCidade
            Obj_Cidade.Codigo_Cidade = Cursor("Codigo_Cidade")
            Obj_Cidade.Nome = Cursor("Nome")
            Obj_Cidade.Estado.Codigo_Estado = Cursor("Codigo_Estado")

        End If

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then
            Cursor.Close()
        End If

        Return Obj_Cidade


    End Function
    Public Function Update(ByVal Obj_Cidade As ClassCidade) As Integer

        Dim Cidades As New List(Of ClassCidade)
        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        If Transacao IsNot Nothing Then
            Comando.Transaction = Transacao
        End If
        Comando.CommandText = ("update Cidade set Nome = @Nome, Codigo_Estado = @Codigo_Estado where Codigo_Cidade = @Codigo_Cidade")

        Comando.Parameters.AddWithValue("@Codigo_Cidade", Obj_Cidade.Codigo_Cidade)
        Comando.Parameters.AddWithValue("@Nome", Obj_Cidade.Nome)
        Comando.Parameters.AddWithValue("@Codigo_Estado", Obj_Cidade.Estado.Codigo_Estado)

        Dim Exe As Integer = Comando.ExecuteNonQuery
        Return Exe

    End Function

    Public Function Delete(ByVal Cidade As ClassCidade) As Integer
        Return Nothing
    End Function

    Public Function Delete(ByVal Id As Integer) As Integer
        Return Nothing
    End Function
End Class
