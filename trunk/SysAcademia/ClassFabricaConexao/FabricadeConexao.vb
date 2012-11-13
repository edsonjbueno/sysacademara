Imports System.Data.SqlClient
Public Class FabricadeConexao


    Private Shared StringConexao As String = My.Settings.StringDeConexao

    Public Shared Function GetConexao() As SqlConnection

        Dim Conexao As New SqlConnection()
        Conexao.ConnectionString = StringConexao
        Conexao.Open()
        Return Conexao
    End Function

    Public Shared Sub FechaConexao(ByVal conexao As SqlConnection)
        Try
            If conexao IsNot Nothing AndAlso conexao.State <> ConnectionState.Closed Then
                conexao.Close()
                conexao = Nothing

            End If
        Catch ex As Exception
            Console.WriteLine("Erro: " & ex.Message)
        End Try
    End Sub

    
End Class


