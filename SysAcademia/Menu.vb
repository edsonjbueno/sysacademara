Imports System.Data.SqlClient

Public Class Menu


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conexao As SqlConnection = FabricadeConexao.GetConexao
        FabricadeConexao.FechaConexao(conexao)
        MessageBox.Show("Ok")

    End Sub
End Class
