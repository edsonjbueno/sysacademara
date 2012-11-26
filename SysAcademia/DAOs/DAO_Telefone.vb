Imports System.Data.SqlClient

Public Class DAO_Telefone

    Private Conexao As SqlConnection

    Public Sub New(ByVal conexao As SqlConnection)
        Me.Conexao = conexao
    End Sub

    Public Function Insert(ByVal Obj_Telefone As ClassTelefone) As Integer

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        Comando.CommandText = "insert into Telefone (Numero,Matricula_Aluno,Codigo_TipoTelefone) values (@Numero,@Matricula_Aluno,@Codigo_TipoTelefone)"

        Comando.Parameters.AddWithValue("@Numero", Obj_Telefone.Numero)
        Comando.Parameters.AddWithValue("@Matricula_Aluno", Obj_Telefone.Matricula_Aluno)
        Comando.Parameters.AddWithValue("@Codigo_TipoTelefone", Obj_Telefone.Tipo_Telefone.ToString)
        Comando.Parameters.AddWithValue("@Matricula_Funcionario", Obj_Telefone.Matricula_Funcionario)


        Return Comando.ExecuteNonQuery()
    End Function

    Public Function ListAll() As List(Of ClassTelefone)

        Dim Cidades As New List(Of ClassTelefone)

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        Comando.CommandText = ("select * from Telefone")

        Dim Cursor As SqlDataReader = Comando.ExecuteReader
        While Cursor.Read
            Dim Obj_Telefone As New ClassTelefone
            Obj_Telefone.Codigo_Telefone = Cursor("Codigo_Telefone")
            Obj_Telefone.Numero = Cursor("Numero")
            Obj_Telefone.Matricula_Aluno = Cursor("Matricula_Aluno")
            Obj_Telefone.Tipo_Telefone = Cursor("Tipo_Telefone")
            Cidades.Add(Obj_Telefone)

        End While

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then
            Cursor.Close()
        End If

        Return Cidades

    End Function

End Class
