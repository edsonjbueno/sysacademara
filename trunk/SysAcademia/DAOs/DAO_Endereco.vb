Imports System.Data.SqlClient

Public Class DAO_Endereco

    Private Conexao As SqlConnection

    Private Sub New(ByVal conexao As SqlConnection)
        Me.Conexao = conexao
    End Sub
    Public Function Insert(ByVal Obj_Endereco As ClassEndereco) As Integer

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        Comando.CommandText = "insert into Endereco (Rua,Numero,Complemento,Bairro) values (@Rua,@Numero,@Complemento,@Bairro)"

        Comando.Parameters.AddWithValue("@Rua", Obj_Endereco.Rua)
        Comando.Parameters.AddWithValue("@Numero", Obj_Endereco.Numero)
        Comando.Parameters.AddWithValue("@Complemento", Obj_Endereco.Complemento)
        Comando.Parameters.AddWithValue("@Bairro", Obj_Endereco.Bairro)

        Return Comando.ExecuteNonQuery

    End Function


    Public Function ListALL() As List(Of ClassEndereco)

        Dim Enderecos As New List(Of ClassEndereco)

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
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
End Class


