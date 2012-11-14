Imports System.Data.SqlClient


Public Class DAO_TipoFunc

    Private Conexao As SqlConnection

    Public Sub New(ByVal Conexao As SqlConnection)
        Me.Conexao = Conexao
    End Sub


    Public Function ListAll() As List(Of ClassTipoFunc)

        Dim TipoFuncionario As New List(Of ClassTipoFunc)

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        Comando.CommandText = ("select * from Tipo_Funcionario")

        Dim Cursor As SqlDataReader = Comando.ExecuteReader()

        While Cursor.Read()

            Dim Obj_Tipo As New ClassTipoFunc()
            Obj_Tipo.Codigo_TipoFuncionario = Cursor("Codigo_TipoFuncionario")
            Obj_Tipo.Descricao = Cursor("Descricao")
            TipoFuncionario.Add(Obj_Tipo)

        End While

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then
            Cursor.Close()
        End If

        Return TipoFuncionario

    End Function


    Public Function Insert(ByVal Obj_TipFunc As ClassTipoFunc) As Integer


        Dim Comando As New SqlCommand()
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        Comando.CommandText = "insert into Tipo_Funcionario(Descricao) values (@Descricao)"

        Comando.Parameters.AddWithValue("@Descricao", Obj_TipFunc.Descricao)

        Return Comando.ExecuteNonQuery

    End Function

End Class
