Imports System.Data.SqlClient

Public Class DAO_SexoGrafFun

    Private Conexao As SqlConnection
    Private Transacao As SqlTransaction

    Public Sub New(ByVal conexao As SqlConnection)
        Me.Conexao = conexao
    End Sub

    Public Function ListAll() As List(Of ClassSexoGraFun)


        Dim Funcionarios As New List(Of ClassSexoGraFun)
        Dim Comando As New SqlCommand()
        Comando.Connection = Conexao

        Comando.Connection = Conexao
        Comando.CommandType = CommandType.Text
        Comando.CommandText = "SELECT Sexo, COUNT(*) as Qtda FROM Funcionario GROUP BY Sexo "

        Dim Cursor As SqlDataReader = Comando.ExecuteReader()


        While Cursor.Read()
            Dim ObjFuncionario As New ClassSexoGraFun()

            ObjFuncionario.Sexo = BdUtil.SetNull(Cursor("Sexo"))
            ObjFuncionario.Quantidade = BdUtil.SetNull(Cursor("Qtda"))

            Funcionarios.Add(ObjFuncionario)

        End While

        If Cursor IsNot Nothing AndAlso Not Cursor.IsClosed Then
            Cursor.Close()
        End If

        Return Funcionarios

    End Function

End Class
