Imports System.Data.SqlClient


' DAO esta pronto e funcionando, "FAVOR NÃO AUTERAR SEM FALAR COMIGO" Ederson..

Public Class DAO_Cidade

    Private Conexao As SqlConnection

    Public Sub New(ByVal conexao As SqlConnection)
        Me.Conexao = conexao
    End Sub
    Public Function Insert(ByVal Obj_Cidade As ClassCidade) As Integer


        Dim Comando As New SqlCommand()
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
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

    'Public Function GetById(ByVal nome As Integer) As ClassCidade

    '    Dim Comando As New SqlCommand
    '    Comando.Connection = Conexao
    '    Comando.CommandType = CommandType.Text
    '    Comando.CommandText = ("select * from Cidade order by @Nome = Nome")
    '    Comando.Parameters.AddWithValue("@Nome", nome)


    '    Dim Obj_Cidade As ClassCidade = Nothing
    '    Dim Cursor As SqlDataReader = Comando.ExecuteReader
    '    If Cursor.Read Then
    '        Obj_Cidade = New ClassCidade
    '        Obj_Cidade.Nome = Cursor("Nome")

    '    End If

    '    If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then
    '        Cursor.Close()
    '    End If

    '    Return Obj_Cidade


    'End Function
    Public Function Update(ByVal Cidade As ClassCidade) As Integer
        Return Nothing
    End Function

    Public Function Delete(ByVal Cidade As ClassCidade) As Integer
        Return Nothing
    End Function

    Public Function Delete(ByVal Id As Integer) As Integer
        Return Nothing
    End Function
End Class
