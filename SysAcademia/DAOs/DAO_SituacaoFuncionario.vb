Imports System.Data.SqlClient

Public Class DAO_SituacaoFuncionario

    Private Conexao As SqlConnection

    Public Sub New(ByVal Conexao As SqlConnection)
        Me.Conexao = Conexao
    End Sub


    Public Function ListAll() As List(Of ClassSituacaoFuncionario)

        Dim FuncionarioSituacao As New List(Of ClassSituacaoFuncionario)

        Dim Comando As New SqlCommand
        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        Comando.CommandText = ("select * from Status_Funcionario")

        Dim Cursor As SqlDataReader = Comando.ExecuteReader()

        While Cursor.Read()

            Dim Obj_SituacaoFuncionario As New ClassSituacaoFuncionario()
            Obj_SituacaoFuncionario.Codigo_SituacaoFuncionario = Cursor("Codigo_Status")
            Obj_SituacaoFuncionario.Descricao = Cursor("Descricao")
            FuncionarioSituacao.Add(Obj_SituacaoFuncionario)

        End While

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then
            Cursor.Close()
        End If

        Return FuncionarioSituacao

    End Function

End Class
