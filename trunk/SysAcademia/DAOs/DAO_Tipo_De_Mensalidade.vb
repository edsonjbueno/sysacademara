Imports System.Data.SqlClient

Public Class DAO_Tipo_De_Mensalidade


    Private Conexao As SqlConnection

        Public Sub New(ByVal conexao As SqlConnection)
            Me.Conexao = conexao
        End Sub
    Public Function Insert(ByVal Obj_TipoM As ClassTipo_De_Mensalidade) As Integer


        Dim Comando As New SqlCommand()
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        Comando.CommandText = "insert into Tipo_De_Mensalidade(Descricao) values (@Descricao)"

        Comando.Parameters.AddWithValue("@Descricao", Obj_TipoM.Descricao)

        Return Comando.ExecuteNonQuery

    End Function


    End Class
