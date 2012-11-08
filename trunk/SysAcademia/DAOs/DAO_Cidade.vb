Imports System.Data.SqlClient

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

        Dim Exe As Integer = Comando.ExecuteNonQuery
        Return Exe
    End Function
    Public Function GetById(ByVal nome As Integer) As ClassCidade

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        Comando.CommandText = ("select * from Cidade order by @Nome = Nome")
        Comando.Parameters.AddWithValue("@Nome", nome)


        Dim Obj_Cidade As ClassCidade = Nothing
        Dim Cursor As SqlDataReader = Comando.ExecuteReader
        If Cursor.Read Then
            Obj_Cidade = New ClassCidade
            Obj_Cidade.Nome = Cursor("Nome")

        End If

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then
            Cursor.Close()
        End If

        Return Obj_Cidade


    End Function

    Public Function ListAll() As List(Of ClassCidade)

        Dim Cidades As New List(Of ClassCidade)

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        Comando.CommandText = ("select Cid.Nome from Cidade Cid,Estado Est where Cid.Codigo_Estado = Est.Codigo_Estado")

        Dim Cursor As SqlDataReader = Comando.ExecuteReader
        While Cursor.Read
            Dim Obj_Cidade As New ClassCidade
            Obj_Cidade.Nome = Cursor("Nome")
            Cidades.Add(Obj_Cidade)
        End While

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then
            Cursor.Close()
        End If

        Return Cidades

    End Function


End Class
